using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace EduHub.Data.C7SchemaParser
{
    public class C7Schema
    {
        public string Filename { get; private set; }

        public IReadOnlyDictionary<string, C7Entity> Entities { get; private set; }

        public C7Schema(string Filename)
        {
            this.Filename = Filename;
            Parse();
        }

        private void Parse()
        {
            using (var schemaLines = File.ReadLines(Filename).GetEnumerator())
            {
                Entities = C7Entity.Parse(this, schemaLines).ToDictionary(e => e.Name, StringComparer.OrdinalIgnoreCase);
            }

            foreach (var entity in Entities.Values)
            {
                entity.DetermineRelationships();
            }
        }

        public XElement ToXElement()
        {
            return new XElement("Schema",
                Entities.Values.OrderBy(e => e.Name).Select(e => e.ToXElement()));
        }
    }
}
