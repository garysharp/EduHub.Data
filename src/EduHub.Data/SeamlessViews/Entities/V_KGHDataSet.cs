using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Houses Data Set
    /// </summary>
    public class V_KGHDataSet : SeamlessViewsDataSet<V_KGH>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_KGH"; } }

        internal V_KGHDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.KGH;
        }

        /// <inheritdoc />
        protected override List<V_KGH> Load()
        {
            return Context.EduHubContext
                .KGH
                .Select(kgh => new V_KGH(Context, kgh))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_KGH]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_KGH]
AS
SELECT
    KGH.KGHKEY,
    KGH.DESCRIPTION
FROM {ParentDatabaseName}..KGH KGH';";
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
                        writer.WriteLine("KGHKEY,DESCRIPTION");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.KGHKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.DESCRIPTION);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
