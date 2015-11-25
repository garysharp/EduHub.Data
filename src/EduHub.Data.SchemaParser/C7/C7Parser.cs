using EduHub.Data.SchemaParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EduHub.Data.SchemaParser.C7
{
    public static class C7Parser
    {
        private static Regex TestEntity = new Regex(@"^(?:ACCOUNT|TRANS),([^\(,]+).*?,(.+?),", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static Regex TestEntityIgnore = new Regex(@"^\s*#|^\s*\*", RegexOptions.Compiled);
        private static Regex TestEntityDirective = new Regex(@"^\s*(\w+)\s*:\s*(.*?);", RegexOptions.Compiled);
        private static Regex TestFieldIgnore = new Regex(@"^\s*#|^\s{0,5}\*", RegexOptions.Compiled);
        private static Regex TestField = new Regex(@"^\s+(.+?)(?:\((.+?)\.(.+?)(?::.+?)?\))?\s*,\s*(\d+)?(.+?)\s*(?:;|,.*;)(?:(?:\s*?\*)?(.*))?", RegexOptions.Compiled);
        private static Regex TestFieldComment = new Regex(@"^\s{6,}\*\s?(.*?)\s*$", RegexOptions.Compiled);
        private static Regex TestFieldDirective = new Regex(@"^\s*(\w+)\s*:\s*(.*?);", RegexOptions.Compiled);
        private static Regex TestFieldArray = new Regex(@"^(\d+)(.*)", RegexOptions.Compiled);
        private static Regex TestDevCommentStart = new Regex(@"^\s*?#\s*?IF\s+?DEVELOP\s*?;", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex TestDevCommentEnd = new Regex(@"^\s*?#\s*?IF\s+?DEVELOP\s*?;", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static EduHubSchema Parse(string C7SchemaFilename)
        {
            return Parse(System.IO.File.ReadLines(C7SchemaFilename));
        }

        public static EduHubSchema Parse(IEnumerable<string> C7Schema)
        {
            var schema = new EduHubSchema();

            var filteredC7Schema = FilterSchemaDirectives(C7Schema);

            ParseEntities(filteredC7Schema, schema);

            return schema;
        }

        private static IEnumerable<string> FilterSchemaDirectives(IEnumerable<string> C7Schema)
        {
            var directiveValues = new HashSet<string>();
            var state = new Stack<Func<HashSet<string>, bool>>();
            var status = true;

            foreach (var originalLine in C7Schema)
            {
                var line = originalLine.Trim();

                if (line.Length > 1 && line[0] == '#')
                {
                    if (line.StartsWith("#COMPILE"))
                    {
                        // Add directive
                        var directive = line.Substring(8, line.IndexOf(';') - 8).Trim();

                        // Override for CHESS (eduHub is always CHESS)
                        if (directive == "NOCHESS")
                        {
                            directive = "CHESS";
                        }

                        directiveValues.Add(directive);
                    }
                    else if (line.StartsWith("#IF"))
                    {
                        string directive;
                        var terminator = line.IndexOf(';');
                        if (terminator > 0)
                        {
                            directive = line.Substring(4, terminator - 4);
                        }
                        else
                        {
                            directive = line.Substring(4);
                        }

                        var directives = directive.Split('|').Select(d => d.Trim()).ToList();

                        if (directives.Count == 0)
                        {
                            throw new InvalidOperationException("Invalid schema command");
                        }

                        // Push to state
                        state.Push(values => values.Any(v => directives.Any(d => v == d)));
                    }
                    else if (line.StartsWith("#ELSE"))
                    {
                        // Push inverse to state
                        var directive = state.Pop();
                        // Inverse
                        state.Push(values => !directive(values));
                    }
                    else if (line.StartsWith("#ENDIF"))
                    {
                        // Pop state
                        var directive = state.Pop();
                    }
                    else if (status)
                    {
                        yield return originalLine;
                    }

                    status = state.Count == 0 || state.All(s => s(directiveValues));
                }
                else if (status)
                {
                    yield return originalLine;
                }
            }
        }

        private static void ParseEntities(IEnumerable<string> C7Schema, EduHubSchema Schema)
        {
            using (var schemaIterator = C7Schema.GetEnumerator())
            {
                if (!schemaIterator.MoveNext())
                    return;

                while (true)
                {
                    // Match Entities
                    var entityMatch = TestEntity.Match(schemaIterator.Current);
                    if (entityMatch.Success)
                    {
                        var entity = Schema.AddEntity(
                            Name: entityMatch.Groups[1].Value.Trim(),
                            Description: entityMatch.Groups[2].Value.Trim());

                        // Match Fields
                        entity.AddFields(ParseFields(entity, schemaIterator));

                        // Match Directives
                        ParseDirectives(entity, schemaIterator);
                    }
                    else
                    {
                        if (!schemaIterator.MoveNext())
                            return;
                    }
                };
            }
        }

        private static IEnumerable<EduHubField> ParseFields(EduHubEntity Entity, IEnumerator<string> SchemaIterator)
        {
            EduHubField field = null;
            int fieldArraySize = 0;
            while (SchemaIterator.MoveNext())
            {
                if (!string.IsNullOrWhiteSpace(SchemaIterator.Current) && !TestFieldIgnore.IsMatch(SchemaIterator.Current))
                {
                    var commentMatch = TestFieldComment.Match(SchemaIterator.Current);
                    if (commentMatch.Success)
                    {
                        if (field != null)
                        {
                            field.AppendDescription(commentMatch.Groups[1].Value);
                        }
                    }
                    else
                    {
                        var fieldMatch = TestField.Match(SchemaIterator.Current);
                        if (fieldMatch.Success)
                        {
                            if (field != null)
                            {
                                foreach (var expandedField in ExpandField(field, fieldArraySize))
                                {
                                    yield return expandedField;
                                }
                            }

                            string name = fieldMatch.Groups[1].Value.Trim();
                            string description = fieldMatch.Groups[6].Success ? fieldMatch.Groups[6].Value.Trim() : string.Empty;
                            fieldArraySize = fieldMatch.Groups[4].Success ? int.Parse(fieldMatch.Groups[4].Value) : 1;
                            string type, typeDescription;
                            int typeMaxLength;
                            DetermineFieldType(fieldMatch.Groups[5].Value.ToUpperInvariant(), out type, out typeDescription, out typeMaxLength);
                            Tuple<string, string> foreignParentKey = fieldMatch.Groups[2].Success
                                ? Tuple.Create(fieldMatch.Groups[2].Value, fieldMatch.Groups[3].Value)
                                : null;

                            field = new EduHubField(
                                Entity: Entity,
                                Name: name,
                                Description: description,
                                Type: type,
                                TypeDescription: typeDescription,
                                TypeMaxLength: typeMaxLength,
                                IsNullable: true,
                                IsIdentity: false,
                                ForeignParentKey: foreignParentKey);
                        }
                        else
                        {
                            if (TestFieldDirective.IsMatch(SchemaIterator.Current))
                            {
                                // End of Fields Declaration (directives started)
                                break;
                            }
                            else
                            {
                                throw new InvalidOperationException("Unexpected schema format");
                            }
                        }
                    }
                }
            }
            foreach (var expandedField in ExpandField(field, fieldArraySize))
            {
                yield return expandedField;
            }
        }

        private static void ParseDirectives(EduHubEntity Entity, IEnumerator<string> SchemaIterator)
        {
            do
            {
                if (!string.IsNullOrWhiteSpace(SchemaIterator.Current) && !TestEntityIgnore.IsMatch(SchemaIterator.Current))
                {
                    // Test directive
                    var directiveMatch = TestEntityDirective.Match(SchemaIterator.Current);
                    if (directiveMatch.Success)
                    {
                        switch (directiveMatch.Groups[1].Value.ToUpperInvariant())
                        {
                            case "KEYS":
                                // Process Keys
                                var keys = directiveMatch.Groups[2].Value.Trim().Split(',').Where(k => !string.IsNullOrWhiteSpace(k)).Select(k => k.Trim());

                                foreach (var key in keys)
                                {
                                    Entity.Fields.First(e => e.Name.Equals(key, StringComparison.OrdinalIgnoreCase)).IsKey = true;
                                }
                                break;
                            case "MOREINFO":
                            case "QUICKADD":
                            case "NODUPS":
                                // Ignore directives
                                break;
                            default:
                                // Current entity block finished
                                return;
                        }
                    }
                    else if (TestEntity.IsMatch(SchemaIterator.Current))
                    {
                        // Another entity found, finished current entity block
                        return;
                    }
                    else
                    {
                        throw new InvalidOperationException("Unexpected schema format");
                    }
                }

            } while (SchemaIterator.MoveNext());
        }

        private static IEnumerable<EduHubField> ExpandField(EduHubField Field, int FieldCount)
        {
            if (FieldCount < 1)
                throw new ArgumentOutOfRangeException("FieldCount", "FieldCount should not be less than 1");
            if (FieldCount > 99)
                throw new ArgumentOutOfRangeException("FieldCount", "FieldCount should not be greater than 99");

            if (FieldCount != 1)
            {
                // Array Field
                for (int i = 1; i <= FieldCount; i++)
                {
                    yield return new EduHubField(
                        Entity: Field.Entity,
                        Name: $"{Field.Name}{i:00}",
                        Description: Field.Description,
                        Type: Field.Type,
                        TypeDescription: Field.TypeDescription,
                        TypeMaxLength: Field.TypeMaxLength,
                        IsNullable: Field.IsNullable,
                        IsIdentity: Field.IsIdentity,
                        ForeignParentKey: Field.ForeignParentKey);
                }
            }
            else
            {
                yield return Field;
            }
        }

        private static void DetermineFieldType(string TypeKey, out string Type, out string Description, out int Precision)
        {
            switch (TypeKey[0])
            {
                case 'A':
                    Type = "string";
                    Description = "Alphanumeric";
                    Precision = int.Parse(TypeKey.Substring(1));
                    return;
                case 'U':
                    Type = "string";
                    Description = "Uppercase Alphanumeric";
                    Precision = int.Parse(TypeKey.Substring(1));
                    return;
                case 'T':
                    Type = "string";
                    Description = "Titlecase";
                    Precision = int.Parse(TypeKey.Substring(1));
                    return;
                case 'I':
                    Type = "short";
                    Description = "Integer";
                    Precision = 0;
                    return;
                case 'L':
                    Type = "int";
                    Description = "Integer";
                    Precision = 0;
                    return;
                case 'R':
                    Type = "double";
                    Description = "Floating Point Number";
                    Precision = 0;
                    return;
                case 'C':
                    Type = "decimal";
                    Description = "Currency";
                    Precision = 0;
                    return;
                case 'D':
                    Type = "DateTime";
                    Description = "Date Time";
                    Precision = 0;
                    return;
                case 'M':
                    Type = "string";
                    Description = "Memo";
                    Precision = 0;
                    return;
                case 'B':
                    switch (TypeKey[1])
                    {
                        case 'A':
                            Type = "byte[]";
                            Description = "Avilable";
                            Precision = 0;
                            return;
                        case 'P':
                            Type = "byte[]";
                            Description = "Picture";
                            Precision = 0;
                            return;
                        case 'B':
                            Type = "byte[]";
                            Description = "Batch Information";
                            Precision = 0;
                            return;
                        case 'G':
                            Type = "byte[]";
                            Description = "Grid";
                            Precision = 0;
                            return;
                        case 'O':
                            Type = "byte[]";
                            Description = "OLE Controls";
                            Precision = 0;
                            return;
                        case 'F':
                            Type = "byte[]";
                            Description = "Files";
                            Precision = 0;
                            return;
                        default:
                            throw new InvalidOperationException("Unknown field type");
                    }
                default:
                    throw new InvalidOperationException("Unknown field type");
            }
        }

    }
}
