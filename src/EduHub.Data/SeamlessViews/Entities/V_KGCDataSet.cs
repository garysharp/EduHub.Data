using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Home Groups Data Set
    /// </summary>
    public class V_KGCDataSet : SeamlessViewsDataSet<V_KGC>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_KGC"; } }

        internal V_KGCDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.KGC;
        }

        /// <inheritdoc />
        protected override List<V_KGC> Load()
        {
            return Context.EduHubContext
                .KGC
                .Select(kgc => new V_KGC(Context, kgc))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_KGC]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_KGC]
AS
SELECT
    KGC.KGCKEY,
    KGC.ROOM,
    KGC.TEACHER
FROM [{ParentDatabaseName}]..KGC KGC';";
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
                        writer.WriteLine("KGCKEY,ROOM,TEACHER");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.KGCKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.ROOM);
                        writer.Write("\",\"");
                        writer.Write(entity.TEACHER);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
