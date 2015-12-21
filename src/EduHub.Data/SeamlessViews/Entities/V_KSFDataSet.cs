using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Faculties Data Set
    /// </summary>
    public class V_KSFDataSet : SeamlessViewsDataSet<V_KSF>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_KSF"; } }

        internal V_KSFDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.KSF;
        }

        /// <inheritdoc />
        protected override List<V_KSF> Load()
        {
            return Context.EduHubContext
                .KSF
                .Select(ksf => new V_KSF(Context, ksf))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_KSF]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_KSF]
AS
SELECT
    KSF.KSFKEY,
    KSF.DESCRIPTION
FROM {ParentDatabaseName}..KSF KSF';";
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
                        writer.WriteLine("KSFKEY,DESCRIPTION");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.KSFKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.DESCRIPTION);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
