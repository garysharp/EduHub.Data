using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Subject Classes Data Set
    /// </summary>
    public class V_SCLDataSet : SeamlessViewsDataSet<V_SCL>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_SCL"; } }

        internal V_SCLDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.SCL;
        }

        /// <inheritdoc />
        protected override List<V_SCL> Load()
        {
            return Context.EduHubContext
                .SCL
                .Select(scl => new V_SCL(Context, scl))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_SCL]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_SCL]
AS
SELECT
    SCL.SCLKEY,
    SCL.SUBJECT,
    SCL.CLASS,
    SCL.TEACHER01,
    SCL.ROOM01
FROM {ParentDatabaseName}..SCL SCL';";
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
                        writer.WriteLine("SCLKEY,SUBJECT,CLASS,TEACHER01,ROOM01");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.SCLKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT);
                        writer.Write("\",");
                        writer.Write(entity.CLASS);
                        writer.Write(",\"");
                        writer.Write(entity.TEACHER01);
                        writer.Write("\",\"");
                        writer.Write(entity.ROOM01);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
