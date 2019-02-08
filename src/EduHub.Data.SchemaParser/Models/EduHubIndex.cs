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
        public bool IsClustered { get; private set; }
        public bool IsPrimary { get; internal set; }

        internal EduHubIndex(EduHubEntity Entity, string Name, IReadOnlyList<EduHubField> Fields, bool IsPrimary, bool IsUnique, bool IsClustered)
        {
            this.Entity = Entity;
            this.Name = Name;
            this.Fields = Fields;
            this.IsPrimary = IsPrimary;
            this.IsUnique = IsUnique;
            this.IsClustered = IsClustered;
        }

        public XElement ToXElement()
        {
            return new XElement("Index",
                new XAttribute(nameof(Name), Name),
                new XAttribute(nameof(IsPrimary), IsPrimary),
                new XAttribute(nameof(IsUnique), IsUnique),
                new XAttribute(nameof(IsClustered), IsClustered),
                Fields.Select(f => new XElement("Field", new XText(f.Name))));
        }

        public override string ToString()
        {
            return $"{Name} {(IsPrimary ? " (Primary)" : null)}{(IsUnique ? " (Unique)" : null)}{(IsClustered ? " (Clustered)" : null)}";
        }
    }
}
