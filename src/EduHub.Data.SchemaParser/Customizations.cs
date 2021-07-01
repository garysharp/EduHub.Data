using EduHub.Data.SchemaParser.Models;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.SchemaParser
{
    public static class Customizations
    {

        public static void EnsureNavigationFieldIndexes(EduHubSchema schema)
        {
            foreach (var childField in schema.Entities.SelectMany(e => e.Fields).Where(f => f.ForeignParentKey.EntityName != null))
            {
                if (childField.GetIndex() == null)
                {
                    var entity = childField.Entity;
                    var fields = new List<EduHubField>() { childField };
                    var indexName = $"Index_{string.Join("_", fields.Select(f => f.Name))}";
                    var index = new EduHubIndex(entity, indexName, fields.AsReadOnly(), false, false, false);
                    entity.AddIndex(index);
                }
            }
        }

    }
}
