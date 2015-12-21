using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Student Groupings Data Set
    /// </summary>
    public class V_SGDataSet : SeamlessViewsDataSet<V_SG>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_SG"; } }

        internal V_SGDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.SG;
        }

        /// <inheritdoc />
        protected override List<V_SG> Load()
        {
            return Context.EduHubContext
                .SG
                .Select(sg => new V_SG(Context, sg))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_SG]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_SG]
AS
SELECT
    SG.SGKEY,
    SG.TITLE,
    SG.ADULT_RESPONSIBLE
FROM {ParentDatabaseName}..SG SG';";
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
                        writer.WriteLine("SGKEY,TITLE,ADULT_RESPONSIBLE");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.SGKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.TITLE);
                        writer.Write("\",\"");
                        writer.Write(entity.ADULT_RESPONSIBLE);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
