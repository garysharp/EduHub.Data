using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Subject Classes Data Set
    /// </summary>
    public class V_SUDataSet : SeamlessViewsDataSet<V_SU>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_SU"; } }

        internal V_SUDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.KCY;
            yield return Context.EduHubContext.SU;
        }

        /// <inheritdoc />
        protected override List<V_SU> Load()
        {
            return Context.EduHubContext
                .SU
                .Where(su => su.SUBJECT_ACADEMIC_YEAR_KCY != null)
                .Select(su => new V_SU(Context, su))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_SU]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_SU]
AS
SELECT
    SU.SUKEY,
    SU.SHORTNAME,
    SU.FULLNAME,
    SU.OVERVIEW,
    SU.FACULTY,
    SU.SEMESTER,
    SU.SUBJECT_ACADEMIC_YEAR,
    KCY.DESCRIPTION
FROM {ParentDatabaseName}..SU SU
JOIN {ParentDatabaseName}..KCY KCY ON SU.SUBJECT_ACADEMIC_YEAR = KCY.KCYKEY';";
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
                        writer.WriteLine("SUKEY,SHORTNAME,FULLNAME,OVERVIEW,FACULTY,SEMESTER,SUBJECT_ACADEMIC_YEAR,DESCRIPTION");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.SUKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.SHORTNAME);
                        writer.Write("\",\"");
                        writer.Write(entity.FULLNAME);
                        writer.Write("\",\"");
                        writer.Write(entity.OVERVIEW);
                        writer.Write("\",\"");
                        writer.Write(entity.FACULTY);
                        writer.Write("\",");
                        writer.Write(entity.SEMESTER);
                        writer.Write(",\"");
                        writer.Write(entity.SUBJECT_ACADEMIC_YEAR);
                        writer.Write("\",\"");
                        writer.Write(entity.DESCRIPTION);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
