using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Student Attendance Data Set
    /// </summary>
    public class V_ST_ATTENDDataSet : SeamlessViewsDataSet<V_ST_ATTEND>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_ST_ATTEND"; } }

        internal V_ST_ATTENDDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.KCY;
            yield return Context.EduHubContext.KGC;
            yield return Context.EduHubContext.ST;
        }

        /// <inheritdoc />
        protected override List<V_ST_ATTEND> Load()
        {
            return Context.EduHubContext
                .ST
                .Where(st => st.STATUS == "ACTV" || st.STATUS == "LVNG")
                .Select(st => new V_ST_ATTEND(Context, st))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_ST_ATTEND]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_ST_ATTEND]
AS
SELECT
    ST.REGISTRATION SID,
    ST.STKEY,
    ST.SURNAME,
    ST.FIRST_NAME,
    ST.PREF_NAME,
    ST.HOME_GROUP,
    ISNULL(KGC.DESCRIPTION, ST.HOME_GROUP) hgrpdesc,
    ST.SCHOOL_YEAR,
    ISNULL(KCY.SHORT_DESC, ST.SCHOOL_YEAR) yrlvldesc,
    ST.HOUSE,
    ST.FAMILY,
    ST.STATUS,
    ST.NOTES,
    ST.OVERSEAS,
    ST.ACCESS_ALERT,
    ST.ATTENDANCE_MEMO,
    ST.TAG,
    ST.FAMB,
    ST.CAMPUS,
    ST.MEDICAL_ALERT
FROM [{ParentDatabaseName}]..ST ST
LEFT JOIN [{ParentDatabaseName}]..KCY AS KCY ON KCY.KCYKEY = ST.SCHOOL_YEAR 
LEFT JOIN [{ParentDatabaseName}]..KGC AS KGC ON KGC.KGCKEY = ST.HOME_GROUP
WHERE (ST.STATUS IN (''ACTV'', ''LVNG''))';";
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
                        writer.WriteLine("SID,STKEY,SURNAME,FIRST_NAME,PREF_NAME,HOME_GROUP,hgrpdesc,SCHOOL_YEAR,yrlvldesc,HOUSE,FAMILY,STATUS,NOTES,OVERSEAS,ACCESS_ALERT,ATTENDANCE_MEMO,TAG,FAMB,CAMPUS,MEDICAL_ALERT");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write(entity.SID);
                        writer.Write(",\"");
                        writer.Write(entity.STKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.SURNAME);
                        writer.Write("\",\"");
                        writer.Write(entity.FIRST_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.PREF_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.HOME_GROUP);
                        writer.Write("\",\"");
                        writer.Write(entity.hgrpdesc);
                        writer.Write("\",\"");
                        writer.Write(entity.SCHOOL_YEAR);
                        writer.Write("\",\"");
                        writer.Write(entity.yrlvldesc);
                        writer.Write("\",\"");
                        writer.Write(entity.HOUSE);
                        writer.Write("\",\"");
                        writer.Write(entity.FAMILY);
                        writer.Write("\",\"");
                        writer.Write(entity.STATUS);
                        writer.Write("\",\"");
                        writer.Write(entity.NOTES);
                        writer.Write("\",\"");
                        writer.Write(entity.OVERSEAS);
                        writer.Write("\",\"");
                        writer.Write(entity.ACCESS_ALERT);
                        writer.Write("\",\"");
                        writer.Write(entity.ATTENDANCE_MEMO);
                        writer.Write("\",\"");
                        writer.Write(entity.TAG);
                        writer.Write("\",\"");
                        writer.Write(entity.FAMB);
                        writer.Write("\",");
                        writer.Write(entity.CAMPUS);
                        writer.Write(",\"");
                        writer.Write(entity.MEDICAL_ALERT);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
