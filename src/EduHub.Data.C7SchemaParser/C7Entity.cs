using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EduHub.Data.C7SchemaParser
{
    public class C7Entity
    {
        public C7Schema Schema { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public IReadOnlyList<C7Field> Fields { get; private set; }

        private C7Entity(C7Schema Schema, Match Match)
            : this(
                  Schema: Schema,
                  Name: Match.Groups[1].Value.Trim(),
                  Description: Match.Groups[2].Value.Trim())
        { }

        private C7Entity(C7Schema Schema, string Name, string Description)
        {
            this.Schema = Schema;
            this.Name = Name;
            this.Description = Description;
        }

        private static Regex TestEntity = new Regex(@"^(?:ACCOUNT|TRANS),([^\(,]+).*?,(.+?),", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static Regex TestIgnore = new Regex(@"^\s*#|^\s*\*", RegexOptions.Compiled);
        private static Regex TestDirective = new Regex(@"^\s*(\w+)\s*:\s*(.*?);", RegexOptions.Compiled);

        internal static IEnumerable<C7Entity> Parse(C7Schema Schema, IEnumerator<string> SchemaLines)
        {
            if (!SchemaLines.MoveNext())
            {
                // End of schema
                yield break;
            }

            while (true)
            {
                var entityMatch = TestEntity.Match(SchemaLines.Current);

                // Found entity
                if (entityMatch.Success)
                {
                    // Parse entity match
                    var entity = new C7Entity(Schema, entityMatch);

                    // Discover entity fields
                    entity.Fields = C7Field.ParseFields(entity, SchemaLines).Distinct(new C7FieldComparer()).ToList().AsReadOnly();

                    // Discover entity directives
                    ProcessDirectives(entity, SchemaLines);

                    yield return entity;
                }
                else
                {
                    if (!SchemaLines.MoveNext())
                    {
                        break;
                    }
                }
            }

            // Finished
            yield break;
        }

        private static void ProcessDirectives(C7Entity Entity, IEnumerator<string> SchemaLines)
        {
            while (true)
            {
                // Test ignore line
                if (!string.IsNullOrWhiteSpace(SchemaLines.Current) && !TestIgnore.IsMatch(SchemaLines.Current))
                {
                    // Test directive
                    var directiveMatch = TestDirective.Match(SchemaLines.Current);
                    if (directiveMatch.Success)
                    {
                        switch (directiveMatch.Groups[1].Value.ToUpperInvariant())
                        {
                            case "KEYS":
                                // Process Keys
                                ProcessFieldKeys(Entity, directiveMatch.Groups[2].Value);
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
                    else if (TestEntity.IsMatch(SchemaLines.Current))
                    {
                        // Another entity found, finished current entity block
                        return;
                    }
                    else
                    {
                        throw new InvalidOperationException("Unexpected schema format");
                    }
                }

                if (!SchemaLines.MoveNext())
                {
                    return;
                }
            }
        }

        private static void ProcessFieldKeys(C7Entity Entity, string Keys)
        {
            var keys = Keys.Trim().Split(',').Where(k => !string.IsNullOrWhiteSpace(k)).Select(k => k.Trim());

            foreach (var key in keys)
            {
                Entity.Fields.First(f => f.Name.Equals(key, StringComparison.OrdinalIgnoreCase)).IsKey = true;
            }
        }

        internal void DetermineRelationships()
        {
            foreach (var field in Fields)
            {
                field.DetermineRelationship();
            }
        }

        public XElement ToXElement()
        {
            return new XElement("Element",
                new XAttribute("Name", Name),
                new XAttribute("Description", Description),
                Fields.Select(f => f.ToXElement())
                );
        }

        public override string ToString()
        {
            return $"{Name}: {Description}";
        }
    }
}
