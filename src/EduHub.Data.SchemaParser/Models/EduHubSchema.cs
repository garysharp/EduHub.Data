using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EduHub.Data.SchemaParser.Models
{
    public class EduHubSchema
    {
        private List<EduHubEntity> entities;

        public IReadOnlyList<EduHubEntity> Entities { get; private set; }

        internal EduHubSchema()
        {
        }

        internal EduHubEntity AddEntity(EduHubEntity Entity)
        {
            if (entities == null)
            {
                entities = new List<EduHubEntity>();
                Entities = entities.AsReadOnly();
            }

            entities.Add(Entity);
            return Entity;
        }

        internal EduHubEntity AddEntity(string Name, string Description)
        {
            var entity = new EduHubEntity(this, Name, Description);
            AddEntity(entity);
            return entity;
        }

        public XElement ToXElement()
        {
            return new XElement("Schema",
                Entities.OrderBy(e => e.Name).Select(e => e.ToXElement()));
        }
    }
}
