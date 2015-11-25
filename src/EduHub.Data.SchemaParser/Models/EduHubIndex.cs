using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EduHub.Data.SchemaParser.Models
{
    public class EduHubIndex
    {
        public EduHubEntity Entity { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyList<EduHubField> Fields { get; private set; }
        public bool IsUnique { get; private set; }

        internal EduHubIndex(EduHubEntity Entity, string Name, IReadOnlyList<EduHubField> Fields, bool IsUnique)
        {
            this.Entity = Entity;
            this.Name = Name;
            this.Fields = Fields;
            this.IsUnique = IsUnique;
        }

        public XElement ToXElement()
        {
            return new XElement("Index",
                new XAttribute("Name", Name),
                new XAttribute("IsUnique", IsUnique),
                Fields.Select(f => new XElement("Field", new XText(f.Name))));
        }

        public override string ToString()
        {
            return $"{Name} {(IsUnique ? " (Unique)" : null)}";
        }
    }
}
