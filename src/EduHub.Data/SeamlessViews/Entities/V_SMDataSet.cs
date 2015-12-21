using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Rooms Data Set
    /// </summary>
    public class V_SMDataSet : SeamlessViewsDataSet<V_SM>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_SM"; } }

        internal V_SMDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.SM;
        }

        /// <inheritdoc />
        protected override List<V_SM> Load()
        {
            return Context.EduHubContext
                .SM
                .Select(sm => new V_SM(Context, sm))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_SM]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_SM]
AS
SELECT
    SM.ROOM,
    SM.TITLE,
    SM.DESCRIPTION,
    SM.SEATING,
    SM.FACULTY
FROM {ParentDatabaseName}..SM SM';";
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
                        writer.WriteLine("ROOM,TITLE,DESCRIPTION,SEATING,FACULTY");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.ROOM);
                        writer.Write("\",\"");
                        writer.Write(entity.TITLE);
                        writer.Write("\",\"");
                        writer.Write(entity.DESCRIPTION);
                        writer.Write("\",");
                        writer.Write(entity.SEATING);
                        writer.Write(",\"");
                        writer.Write(entity.FACULTY);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
