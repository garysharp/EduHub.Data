using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Actual Sessions Data Set
    /// </summary>
    public class V_TXASDataSet : SeamlessViewsDataSet<V_TXAS>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_TXAS"; } }

        internal V_TXASDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.TXAS;
        }

        /// <inheritdoc />
        protected override List<V_TXAS> Load()
        {
            return Context.EduHubContext
                .TXAS
                .Select(txas => new V_TXAS(Context, txas))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_TXAS]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_TXAS]
AS
SELECT
    TXAS.CLASS,
    TXAS.DAY_NO,
    TXAS.LOCATION,
    TXAS.PERIOD_NO,
    TXAS.SESSION_DATE,
    TXAS.SUBJECT,
    TXAS.TEACHER
FROM [{ParentDatabaseName}]..TXAS TXAS';";
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
                        writer.WriteLine("CLASS,DAY_NO,LOCATION,PERIOD_NO,SESSION_DATE,SUBJECT,TEACHER");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write(entity.CLASS);
                        writer.Write(',');
                        writer.Write(entity.DAY_NO);
                        writer.Write(",\"");
                        writer.Write(entity.LOCATION);
                        writer.Write("\",");
                        writer.Write(entity.PERIOD_NO);
                        writer.Write(",\"");
                        writer.Write(entity.SESSION_DATE?.ToString("yyyy-MM-dd"));
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT);
                        writer.Write("\",\"");
                        writer.Write(entity.TEACHER);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
