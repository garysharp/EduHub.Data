using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Subject Selections &amp; Marks Data Set
    /// </summary>
    public class V_STMADataSet : SeamlessViewsDataSet<V_STMA>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_STMA"; } }

        internal V_STMADataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.STMA;
        }

        /// <inheritdoc />
        protected override List<V_STMA> Load()
        {
            return Context.EduHubContext
                .STMA
                .Select(stma => new V_STMA(Context, stma))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_STMA]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_STMA]
AS
SELECT
    STMA.SKEY,
    STMA.MKEY,
    STMA.CLASS,
    STMA.FULLNAME,
    STMA.TEACHER_NAME,
    STMA.TTPERIOD
FROM [{ParentDatabaseName}]..STMA STMA';";
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
                        writer.WriteLine("SKEY,MKEY,CLASS,FULLNAME,TEACHER_NAME,TTPERIOD");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.SKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.MKEY);
                        writer.Write("\",");
                        writer.Write(entity.CLASS);
                        writer.Write(",\"");
                        writer.Write(entity.FULLNAME);
                        writer.Write("\",\"");
                        writer.Write(entity.TEACHER_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.TTPERIOD);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
