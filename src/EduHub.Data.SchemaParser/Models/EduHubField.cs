using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EduHub.Data.SchemaParser.Models
{
    public class EduHubField
    {
        public EduHubEntity Entity { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public string Type { get; internal set; }
        public string TypeDescription { get; private set; }
        public int TypeMaxLength { get; internal set; }
        public string SqlType { get; internal set; }
        public bool IsKey { get; internal set; }
        public bool IsNullable { get; internal set; }
        public bool IsIdentity { get; internal set; }

        public (string EntityName, string FieldName) ForeignParentKey { get; internal set; }

        internal EduHubField(EduHubEntity Entity, string Name, string Description, string Type, string TypeDescription, int TypeMaxLength, bool IsKey, bool IsNullable, bool IsIdentity, (string EntityName, string FieldName) ForeignParentKey)
        {
            this.Entity = Entity;
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
            this.TypeDescription = TypeDescription;
            this.TypeMaxLength = TypeMaxLength;
            this.IsKey = IsKey;
            this.IsNullable = IsNullable;
            this.IsIdentity = IsIdentity;
            this.ForeignParentKey = ForeignParentKey;
        }

        public EduHubField GetForeignParent()
        {
            if (ForeignParentKey.EntityName == null)
                return null;

            return Entity.Schema.Entities
                .First(e => e.Name == ForeignParentKey.EntityName)
                .Fields.First(f => f.Name == ForeignParentKey.FieldName);
        }

        public EduHubIndex GetIndex()
        {
            if (Entity == null)
                throw new InvalidOperationException("Entity is not initialized");

            return Entity.Indexes
                .Where(i => i.Fields.Count == 1 && i.Fields[0] == this)
                .FirstOrDefault();
        }

        public IEnumerable<EduHubField> GetForeignChildren()
        {
            var key = (EntityName: Entity.Name, FieldName: Name);

            return Entity.Schema.Entities
                .Where(e => e != Entity)
                .SelectMany(e => e.Fields)
                .Where(f => f.ForeignParentKey.Equals(key));
        }

        internal void AppendDescription(string Description)
        {
            if (!string.IsNullOrWhiteSpace(Description))
            {
                if (string.IsNullOrWhiteSpace(this.Description))
                {
                    this.Description = Description;
                }
                else
                {
                    this.Description += $"\r\n{Description}";
                }
            }
        }

        public XElement ToXElement()
        {
            List<object> contents = new List<object>
            {
                new XAttribute(nameof(Name), Name),
                new XAttribute(nameof(IsKey), IsKey),
                new XAttribute(nameof(IsNullable), IsNullable),
                new XAttribute(nameof(IsIdentity), IsIdentity),
                new XAttribute(nameof(Type), Type),
                new XAttribute(nameof(TypeDescription), TypeDescription)
            };
            if (TypeMaxLength != 0)
            {
                contents.Add(new XAttribute(nameof(TypeMaxLength), TypeMaxLength));
            }
            contents.Add(new XAttribute(nameof(SqlType), SqlType));
            if (ForeignParentKey.EntityName != null)
            {
                contents.Add(new XAttribute("ForeignParent", $"{ForeignParentKey.Item1}:{ForeignParentKey.Item2}"));
            }
            if (!string.IsNullOrWhiteSpace(Description) && Description != "*")
            {
                contents.Add(new XCData(Description));
            }

            return new XElement("Field", contents.ToArray());
        }

        public override string ToString()
        {
            return $"{Name}{(IsKey ? " (Key)" : null)}: {Description}";
        }
    }
}
