﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EduHub.Data.SchemaParser.Models
{
    public class EduHubEntity
    {
        public EduHubSchema Schema { get; private set; }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsScoped { get; private set; }

        private List<EduHubField> fields;
        private List<EduHubIndex> indexes;

        public IReadOnlyList<EduHubField> Fields => fields.AsReadOnly();
        public IReadOnlyList<EduHubIndex> Indexes => indexes.AsReadOnly();

        internal EduHubEntity(EduHubSchema Schema, string Name, string Description, bool IsScoped)
        {
            this.Schema = Schema;
            this.Name = Name;
            this.Description = Description;
            this.IsScoped = IsScoped;
            fields = new List<EduHubField>();
            indexes = new List<EduHubIndex>();
        }

        internal void AddField(EduHubField Field)
        {
            fields.Add(Field);
        }

        internal void AddFields(IEnumerable<EduHubField> Fields)
        {
            fields.AddRange(Fields);
        }

        internal void AddIndex(EduHubIndex Index)
        {
            indexes.Add(Index);
        }

        internal bool RemoveIndex(EduHubIndex Index)
        {
            return indexes.Remove(Index);
        }

        public XElement ToXElement()
        {
            var element = new XElement("Entity",
                new XAttribute(nameof(Name), Name),
                new XAttribute(nameof(Description), Description));
            if (IsScoped)
                element.Add(new XAttribute(nameof(IsScoped), IsScoped));
            element.Add(new XElement("Fields", Fields.Select(f => f.ToXElement())),
                new XElement("Indexes", Indexes.OrderBy(i => i.Name).Select(i => i.ToXElement())));
            return element;
        }

        public override string ToString()
        {
            return $"{Name} ({fields.Count} fields): {Description}";
        }
    }
}
