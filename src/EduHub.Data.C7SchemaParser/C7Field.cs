using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EduHub.Data.C7SchemaParser
{
    public class C7Field
    {
        private List<C7Field> relationshipChildren;

        public C7Entity Entity { get; private set; }

        public string Name { get; private set; }

        public string TypeKey { get; private set; }
        private Lazy<Tuple<Type, string, string, int>> TypeDefinition;
        public Type Type { get { return TypeDefinition.Value.Item1; } }
        public string TypeName { get { return TypeDefinition.Value.Item2; } }
        public string TypeDescription { get { return TypeDefinition.Value.Item3; } }
        public int TypePrecision { get { return TypeDefinition.Value.Item4; } }

        public bool IsKey { get; internal set; }

        public string RelationshipKey { get; private set; }
        public C7Field Relationship { get; private set; }

        public IReadOnlyList<C7Field> RelationshipChildren { get { return relationshipChildren.AsReadOnly(); } }

        public string Description { get; private set; }

        private C7Field(C7Entity Entity, Match Match)
            : this(
                  Entity: Entity,
                  Name: Match.Groups[1].Value.Trim(),
                  TypeKey: Match.Groups[3].Value.Trim(),
                  RelationshipKey: Match.Groups[2].Success ? Match.Groups[2].Value.Trim() : null,
                  Description: Match.Groups[4].Success ? Match.Groups[4].Value.Trim() : null
                  )
        { }

        private C7Field(C7Entity Entity, string Name, string TypeKey, string RelationshipKey, string Description)
        {
            this.Entity = Entity;
            this.Name = Name;
            this.TypeKey = TypeKey.ToLowerInvariant();
            this.RelationshipKey = RelationshipKey;
            this.Description = Description;
            TypeDefinition = new Lazy<Tuple<Type, string, string, int>>(DetermineFrameworkType);
        }

        private static Regex TestIgnore = new Regex(@"^\s*#|^\s{0,5}\*", RegexOptions.Compiled);
        private static Regex TestField = new Regex(@"^\s+(.+?)(?:\((.+?)\))?\s*,(.+?)(?:;|,.*;)(?:(?:\s*?\*)?(.*))?", RegexOptions.Compiled);
        private static Regex TestFieldComment = new Regex(@"^\s{6,}\*\s?(.*)", RegexOptions.Compiled);
        private static Regex TestDirective = new Regex(@"^\s*(\w+)\s*:\s*(.*?);", RegexOptions.Compiled);
        private static Regex TestArrayField = new Regex(@"^(\d+)(.*)", RegexOptions.Compiled);

        internal static IEnumerable<C7Field> ParseFields(C7Entity Entity, IEnumerator<string> SchemaLines)
        {
            C7Field field = null;
            while (SchemaLines.MoveNext())
            {
                // Ignore whitespace or comment lines
                if (!string.IsNullOrWhiteSpace(SchemaLines.Current) && !TestIgnore.IsMatch(SchemaLines.Current))
                {
                    var commentMatch = TestFieldComment.Match(SchemaLines.Current);
                    if (commentMatch.Success)
                    {
                        if (field != null)
                        {
                            // Add comment to field description
                            if (string.IsNullOrWhiteSpace(field.Description))
                            {
                                field.Description = commentMatch.Groups[1].Value.Trim();
                            }
                            else
                            {
                                field.Description += Environment.NewLine + commentMatch.Groups[1].Value.TrimEnd();
                            }
                        }
                    }
                    else
                    {
                        // Test for field
                        var fieldMatch = TestField.Match(SchemaLines.Current);
                        if (fieldMatch.Success)
                        {
                            // Submit finished field
                            if (field != null)
                            {
                                foreach (var f in ExpandField(field))
                                {
                                    yield return f;
                                }
                            }

                            // Declare new field
                            field = new C7Field(Entity, fieldMatch);
                        }
                        else
                        {
                            // Test directive
                            if (TestDirective.IsMatch(SchemaLines.Current))
                            {
                                // Field block finished
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

            // Submit finished field
            if (field != null)
            {
                foreach (var f in ExpandField(field))
                {
                    yield return f;
                }
            }
        }

        private static IEnumerable<C7Field> ExpandField(C7Field Field)
        {
            var arrayMatch = TestArrayField.Match(Field.TypeKey);
            if (arrayMatch.Success)
            {
                var length = int.Parse(arrayMatch.Groups[1].Value);
                for (int i = 1; i <= length; i++)
                {
                    yield return new C7Field(
                        Entity: Field.Entity,
                        Name: $"{Field.Name}{i:00}",
                        TypeKey: arrayMatch.Groups[2].Value,
                        RelationshipKey: Field.RelationshipKey,
                        Description: Field.Description
                        );
                }
            }
            else
            {
                yield return Field;
            }
        }

        internal void DetermineRelationship()
        {
            if (RelationshipKey != null)
            {
                var foreignEntityKey = RelationshipKey.Split('.')[0];
                var foreignFieldKey = RelationshipKey.Split('.')[1].Split(':')[0];

                var foreignEntity = Entity.Schema.Entities[foreignEntityKey];
                var foreignField = foreignEntity.Fields.First(f => f.Name.Equals(foreignFieldKey, StringComparison.OrdinalIgnoreCase));

                Relationship = foreignField;

                foreignField.AddChildRelationship(this);
            }
        }

        internal void AddChildRelationship(C7Field Field)
        {
            if (relationshipChildren == null)
            {
                relationshipChildren = new List<C7Field>();
            }

            relationshipChildren.Add(Field);
        }

        private Tuple<Type, string, string, int> DetermineFrameworkType()
        {
            switch (TypeKey[0])
            {
                case 'a':
                    return Tuple.Create(typeof(string), "string", "Alphanumeric", int.Parse(TypeKey.Substring(1)));
                case 'u':
                    return Tuple.Create(typeof(string), "string", "Uppercase Alphanumeric", int.Parse(TypeKey.Substring(1)));
                case 't':
                    return Tuple.Create(typeof(string), "string", "Titlecase", int.Parse(TypeKey.Substring(1)));
                case 'i':
                    if (IsKey)
                    {
                        return Tuple.Create(typeof(short), "short", "Integer (16bit signed)", 0);
                    }
                    else
                    {
                        return Tuple.Create(typeof(short?), "short?", "Integer (16bit signed nullable)", 0);
                    }
                case 'l':
                    if (IsKey)
                    {
                        return Tuple.Create(typeof(int), "int", "Integer (32bit signed)", 0);
                    }
                    else
                    {
                        return Tuple.Create(typeof(int?), "int?", "Integer (32bit signed nullable)", 0);
                    }
                case 'r':
                    if (IsKey)
                    {
                        return Tuple.Create(typeof(double), "double", "Floating Point Number (precision 15)", 0);
                    }
                    else
                    {
                        return Tuple.Create(typeof(double?), "double?", "Floating Point Number (precision 15 nullable)", 0);
                    }
                case 'c':
                    if (IsKey)
                    {
                        return Tuple.Create(typeof(decimal), "decimal", "Currency (128bit scaled integer)", 0);
                    }
                    else
                    {
                        return Tuple.Create(typeof(decimal?), "decimal?", "Currency (128bit scaled integer nullable)", 0);
                    }
                case 'd':
                    if (IsKey)
                    {
                        return Tuple.Create(typeof(DateTime), "DateTime", "Date Time", 0);
                    }
                    else
                    {
                        return Tuple.Create(typeof(DateTime?), "DateTime?", "Date Time nullable", 0);
                    }    
                case 'm':
                    return Tuple.Create(typeof(string), "string", "Memo", 0);
                case 'b':
                    switch (TypeKey[1])
                    {
                        case 'a':
                            return Tuple.Create(typeof(byte[]), "byte[]", "Available (byte array)", 0);
                        case 'p':
                            return Tuple.Create(typeof(byte[]), "byte[]", "Picture (byte array)", 0);
                        case 'b':
                            return Tuple.Create(typeof(byte[]), "byte[]", "Batch Information (byte array)", 0);
                        case 'g':
                            return Tuple.Create(typeof(byte[]), "byte[]", "Grid (byte array)", 0);
                        case 'o':
                            return Tuple.Create(typeof(byte[]), "byte[]", "OLE Controls (byte array)", 0);
                        case 'f':
                            return Tuple.Create(typeof(byte[]), "byte[]", "Files (byte array)", 0);
                        default:
                            throw new InvalidOperationException("Unknown field type");
                    }
                default:
                    throw new InvalidOperationException("Unknown field type");
            }
        }

        public XElement ToXElement()
        {
            if (RelationshipKey == null)
            {
                return new XElement("Field",
                    new XAttribute("Name", Name),
                    new XAttribute("TypeKey", TypeKey),
                    new XAttribute("Type", Type.FullName),
                    new XAttribute("TypeName", TypeName),
                    new XAttribute("TypeDescription", TypeDescription),
                    new XAttribute("TypePrecision", TypePrecision),
                    new XAttribute("IsKey", IsKey),
                    Description);
            }
            else
            {
                return new XElement("Field",
                    new XAttribute("Name", Name),
                    new XAttribute("TypeKey", TypeKey),
                    new XAttribute("Type", Type.FullName),
                    new XAttribute("TypeName", TypeName),
                    new XAttribute("TypeDescription", TypeDescription),
                    new XAttribute("TypePrecision", TypePrecision),
                    new XAttribute("IsKey", IsKey),
                    new XAttribute("RelationshipEntity", Relationship.Entity.Name),
                    new XAttribute("RelationshipField", Relationship.Name),
                    Description);
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name} [{TypeKey}]: {Description}";
        }
    }
}
