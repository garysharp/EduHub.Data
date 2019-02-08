using EduHub.Data.SchemaParser.C7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EduHub.Data.SchemaParser.Models
{
    public class EduHubSchema
    {
        private Dictionary<string, EduHubEntity> entities;

        public IEnumerable<EduHubEntity> Entities => entities.Values;

        internal EduHubSchema()
        {
        }

        public EduHubEntity this[string Name]
        {
            get
            {
                return entities[Name];
            }
        }

        public bool Contains(string Name)
        {
            return entities.ContainsKey(Name);
        }

        public bool Contains(EduHubEntity Entity)
        {
            return entities.ContainsValue(Entity);
        }

        internal EduHubEntity AddEntity(EduHubEntity Entity)
        {
            if (entities == null)
                entities = new Dictionary<string, EduHubEntity>(StringComparer.Ordinal);

            entities.Add(Entity.Name, Entity);
            return Entity;
        }

        internal EduHubEntity AddEntity(string Name, string Description)
        {
            var entity = new EduHubEntity(this, Name, Description);
            AddEntity(entity);
            return entity;
        }

        internal void RemoveEntity(string Name)
        {
            entities.Remove(Name);
        }

        public XElement ToXElement()
        {
            return new XElement("Schema",
                Entities.OrderBy(e => e.Name).Select(e => e.ToXElement()));
        }

        public static EduHubSchema FromC7Schema(IList<IC7Element> Elements)
        {
            var schema = new EduHubSchema();

            foreach (var element in Elements)
            {
                switch (element)
                {
                    case IC7Entity c7entity:
                        var entity = new EduHubEntity(schema, c7entity.Name, c7entity.Description.Trim());
                        entity.AddFields(c7entity.ToEduHubFields(entity));
                        schema.AddEntity(entity);
                        break;
                    default:
                        break;
                }
            }

            return schema;
        }
    }
}
