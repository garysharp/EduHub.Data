using EduHub.Data.SchemaParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.SchemaParser
{
    public static class Customizations
    {

        public static void ApplyVersion60Overrides(EduHubSchema schema)
        {

            // Records in datasets without a unique index cannot be deleted
            //  and this breaks delta/partial dataset support.
            // In v60 unique indexes on 'TID' (Transaction ID) columns were removed
            //  for a large number of datasets. All currently available data confirms
            //  that these columns continue to be unique and make a good unique key.
            // This patch restores unique indexes for affected datasets without unique
            //  columns, but with a TID column which was previously unique.
            // This is a deviation from the official schema, but necessary at this point.

            // restore unique TID  index for datasets with no unique index
            foreach (var entityName in new string[] { "ARF", "CRF", "DFF", "DRF", "GLCF", "GLCFPREV", "GLF", "GLFPREV", "PEF" })
                if (schema.Contains(entityName))
                    RestoreTidUniqueColumn(schema[entityName]);

            // primary key constraints were removed from the official schema, but
            //  there serve an important purpose in our recreation
            foreach (var entity in schema.Entities)
            {
                RestorePrimaryKey(entity);
            }
        }

        private static void RestoreTidUniqueColumn(EduHubEntity entity)
        {
            // check no unique column is available
            if (!entity.Indexes.Any(e => e.IsUnique))
            {
                var tidColumn = entity.Fields.FirstOrDefault(e =>
                    e.Name.Equals("TID", StringComparison.Ordinal) &&
                    !e.IsNullable && e.SqlType.Equals("int"));

                // has valid TID column
                if (tidColumn != null)
                {
                    // existing index?
                    var index = entity.Indexes.FirstOrDefault(i => i.Fields.Contains(tidColumn));
                    if (index == null)
                    {
                        // create index
                        var fields = new List<EduHubField>() { tidColumn };
                        index = new EduHubIndex(entity, "Index_TID", fields, false, true, false);
                        entity.AddIndex(index);
                    }
                }
            }
        }

        private static void RestorePrimaryKey(EduHubEntity entity)
        {
            if (!entity.Indexes.Any(i => i.IsPrimary))
            {
                var index = entity.Indexes.FirstOrDefault(i =>
                    i.Name.Equals("Index_TID", StringComparison.Ordinal) &&
                    i.IsUnique);

                if (index != null)
                {
                    index.IsPrimary = true;
                }
            }
        }

    }
}
