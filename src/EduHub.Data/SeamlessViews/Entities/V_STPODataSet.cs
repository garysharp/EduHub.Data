using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Position or Group Memberships Data Set
    /// </summary>
    public class V_STPODataSet : SeamlessViewsDataSet<V_STPO>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_STPO"; } }

        internal V_STPODataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.STPO;
        }

        /// <inheritdoc />
        protected override List<V_STPO> Load()
        {
            return Context.EduHubContext
                .STPO
                .Select(stpo => new V_STPO(Context, stpo))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_STPO]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_STPO]
AS
SELECT
    STPO.STPOKEY,
    STPO.SGLINK
FROM [{ParentDatabaseName}]..STPO STPO';";
        }

        /// <inheritdoc />
        public override void WriteToCsv(string Filename, bool IncludeHeader)
        {
            using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    if (IncludeHeader)
                    {
                        writer.WriteLine("STPOKEY,SGLINK");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.STPOKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.SGLINK);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
