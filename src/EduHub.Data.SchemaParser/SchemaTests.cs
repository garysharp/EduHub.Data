using EduHub.Data.SchemaParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHub.Data.SchemaParser
{
    public static class SchemaTests
    {
        public static void TestForeignKeys(EduHubSchema Schema)
        {
            foreach (var childField in Schema.Entities.SelectMany(e => e.Fields).Where(f => f.ForeignParentKey != null))
            {
                var foreignParent = childField.GetForeignParent();
                if (foreignParent == null)
                    throw new InvalidOperationException("Foreign parent not found");

                var foreignIndex = foreignParent.GetIndex();
                if (foreignIndex == null)
                    throw new InvalidOperationException("Foreign parent is not indexed");

                if (!foreignIndex.IsUnique)
                    throw new InvalidOperationException("Foreign index is not unique");
            }
        }
    }
}
