using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// AIM Data Set
    /// </summary>
    public class V_AIMDataSet : SeamlessViewsDataSet<V_AIM>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_AIM"; } }

        internal V_AIMDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.DF;
            yield return Context.EduHubContext.ST;
        }

        /// <inheritdoc />
        protected override List<V_AIM> Load()
        {
            return Context.EduHubContext
                .ST
                .Where(st => st.STATUS == "ACTV" || st.STATUS == "INAC" || st.STATUS == "LVNG")
                .Select(st => new V_AIM(Context, st))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_AIM]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_AIM]
AS
SELECT
    ST.STKEY student_code,
    ST.FIRST_NAME first_name,
    (CASE WHEN ST.SECOND_NAME IS NULL THEN '''' ELSE ST.SECOND_NAME END) middle_name,
    ST.SURNAME surname,
    (CASE GENDER
        WHEN ''M'' THEN ''MALE''
        WHEN ''F'' THEN ''FEMAL''
        ELSE ''''
    END) gender,
    CONVERT(varchar(10), ST.BIRTHDATE, 103) date_of_birth,
    (CASE WHEN COALESCE(CASE WHEN ST.LOTE_HOME_CODE = ''1201'' THEN NULL ELSE ST.LOTE_HOME_CODE END,
                        CASE WHEN DF.LOTE_HOME_CODE_A = ''1201'' THEN NULL ELSE DF.LOTE_HOME_CODE_A END,
                        CASE WHEN DF.LOTE_HOME_CODE_B = ''1201'' THEN NULL ELSE DF.LOTE_HOME_CODE_B END)
            IS NULL
        THEN 0 ELSE 1
    END) LBOTE,
    (CASE
        WHEN ST.KOORIE = ''K'' THEN 1
        WHEN ST.KOORIE = ''T'' THEN 1
        WHEN ST.KOORIE = ''B'' THEN 1
        WHEN ST.KOORIE = ''U'' THEN 1
        ELSE 0
    END) ATSI,
    (CASE WHEN ST.DISABILITY = ''Y'' THEN 1 ELSE 0 END) disability_status,
    (CASE WHEN ST.ED_ALLOW = ''Y'' THEN 1 ELSE 0 END) EMA,
    (CASE WHEN ST.ENG_SPEAK = ''N'' THEN 1 ELSE 0 END) ESL,
    (CASE WHEN ST.HOME_GROUP IS NULL THEN '''' ELSE ST.HOME_GROUP END) home_group,
    (CASE WHEN ST.SCHOOL_YEAR = ''00'' THEN ''P'' ELSE ST.SCHOOL_YEAR END) year_level
FROM {ParentDatabaseName}..ST ST
LEFT JOIN {ParentDatabaseName}..DF DF ON ST.FAMILY = DF.DFKEY
WHERE ST.STATUS in (''ACTV'',''INAC'', ''LVNG'')';";
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
                        writer.WriteLine("student_code,first_name,middle_name,surname,gender,date_of_birth,LBOTE,ATSI,disability_status,EMA,ESL,home_group,year_level");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.student_code);
                        writer.Write("\",\"");
                        writer.Write(entity.first_name);
                        writer.Write("\",\"");
                        writer.Write(entity.middle_name);
                        writer.Write("\",\"");
                        writer.Write(entity.surname);
                        writer.Write("\",\"");
                        writer.Write(entity.gender);
                        writer.Write("\",");
                        writer.Write(entity.date_of_birth);
                        writer.Write(',');
                        writer.Write(entity.LBOTE);
                        writer.Write(',');
                        writer.Write(entity.ATSI);
                        writer.Write(',');
                        writer.Write(entity.disability_status);
                        writer.Write(',');
                        writer.Write(entity.EMA);
                        writer.Write(',');
                        writer.Write(entity.ESL);
                        writer.Write(",\"");
                        writer.Write(entity.home_group);
                        writer.Write("\",\"");
                        writer.Write(entity.year_level);
                        writer.WriteLine('"');
                    }
                }
            }
        }

        /// <summary>
        /// Writes the AIM Data Set in the format expected by On Demand Testing
        /// </summary>
        /// <param name="Filename">Location to Output File</param>
        public void WriteToOnDemandImport(string Filename)
        {
            using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var entity in this)
                    {
                        writer.Write(entity.student_code);
                        writer.Write(',');
                        writer.Write(entity.first_name);
                        writer.Write(',');
                        writer.Write(entity.middle_name);
                        writer.Write(',');
                        writer.Write(entity.surname);
                        writer.Write(',');
                        writer.Write(entity.gender);
                        writer.Write(',');
                        writer.Write(entity.date_of_birth);
                        writer.Write(',');
                        writer.Write(entity.LBOTE);
                        writer.Write(',');
                        writer.Write(entity.ATSI);
                        writer.Write(',');
                        writer.Write(entity.disability_status);
                        writer.Write(',');
                        writer.Write(entity.EMA);
                        writer.Write(',');
                        writer.Write(entity.ESL);
                        writer.Write(',');
                        writer.Write(entity.home_group);
                        writer.Write(',');
                        writer.WriteLine(entity.year_level);
                    }
                }
            }
        }
    }
}
