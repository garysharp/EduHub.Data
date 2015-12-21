using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// School Information Data Set
    /// </summary>
    public class V_SCIDataSet : SeamlessViewsDataSet<V_SCI>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_SCI"; } }

        internal V_SCIDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.SCI;
        }

        /// <inheritdoc />
        protected override List<V_SCI> Load()
        {
            return Context.EduHubContext
                .SCI
                .Select(sci => new V_SCI(Context, sci))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_SCI]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_SCI]
AS
SELECT
    SCI.SCIKEY,
    SCI.CAMPUS_NAME,
    SCI.CAMPUS_TYPE,
    SCI.SCHOOL_NAME,
    SCI.SCHOOL_TYPE
FROM {ParentDatabaseName}..SCI SCI';";
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
                        writer.WriteLine("SCIKEY,CAMPUS_NAME,CAMPUS_TYPE,SCHOOL_NAME,SCHOOL_TYPE");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write(entity.SCIKEY);
                        writer.Write(",\"");
                        writer.Write(entity.CAMPUS_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.CAMPUS_TYPE);
                        writer.Write("\",\"");
                        writer.Write(entity.SCHOOL_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.SCHOOL_TYPE);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
