using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Student Half-Day Absences Data Set
    /// </summary>
    public class V_SXABDataSet : SeamlessViewsDataSet<V_SXAB>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_SXAB"; } }

        internal V_SXABDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.SXAB;
        }

        /// <inheritdoc />
        protected override List<V_SXAB> Load()
        {
            return Context.EduHubContext
                .SXAB
                .Select(sxab => new V_SXAB(Context, sxab))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_SXAB]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_SXAB]
AS
SELECT
    SXAB.SXAB_ID,
    SXAB.ABSENCE_DATE,
    SXAB.STKEY,
    SXAB.AM_ACT_TYPE,
    SXAB.PM_ACT_TYPE
FROM [{ParentDatabaseName}]..SXAB SXAB';";
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
                        writer.WriteLine("SXAB_ID,ABSENCE_DATE,STKEY,AM_ACT_TYPE,PM_ACT_TYPE");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write(entity.SXAB_ID);
                        writer.Write(",\"");
                        writer.Write(entity.ABSENCE_DATE?.ToString("yyyy-MM-dd"));
                        writer.Write("\",\"");
                        writer.Write(entity.STKEY);
                        writer.Write("\",");
                        writer.Write(entity.AM_ACT_TYPE);
                        writer.Write(",");
                        writer.WriteLine(entity.PM_ACT_TYPE);
                    }
                }
            }
        }
    }
}
