using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Languages Data Set
    /// </summary>
    public class V_KGLDataSet : SeamlessViewsDataSet<V_KGL>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_KGL"; } }

        internal V_KGLDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.KGL;
        }

        /// <inheritdoc />
        protected override List<V_KGL> Load()
        {
            return Context.EduHubContext
                .KGL
                .Select(kgl => new V_KGL(Context, kgl))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_KGL]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_KGL]
AS
SELECT
    KGL.KGLKEY,
    KGL.DESCRIPTION
FROM [{ParentDatabaseName}]..KGL KGL';";
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
                        writer.WriteLine("KGLKEY,DESCRIPTION");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.KGLKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.DESCRIPTION);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
