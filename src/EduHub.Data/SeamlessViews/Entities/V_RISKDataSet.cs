using EduHub.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Risk Data Set
    /// </summary>
    public class V_RISKDataSet : SeamlessViewsDataSet<V_RISK>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_RISK"; } }

        internal V_RISKDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.DF;
            yield return Context.EduHubContext.KCT;
            yield return Context.EduHubContext.KCV;
            // KGD - Optional, use if available
            if (Context.EduHubContext.KGD.IsAvailable)
            {
                yield return Context.EduHubContext.KGD;
            }
            // KGG - Optional, use if available
            if (Context.EduHubContext.KGG.IsAvailable)
            {
                yield return Context.EduHubContext.KGG;
            }
            yield return Context.EduHubContext.KGT;
            yield return Context.EduHubContext.SKGS;
            yield return Context.EduHubContext.ST;
            yield return Context.EduHubContext.STVDI;
            yield return Context.EduHubContext.SXAB;
            yield return Context.EduHubContext.SXABCONV;
        }

        /// <inheritdoc />
        protected override List<V_RISK> Load()
        {
            var year = DateTime.Now.Year;
            var kgdAvailable = Context.EduHubContext.KGD.IsAvailable;
            var kggAvailable = Context.EduHubContext.KGG.IsAvailable;

            return Context.EduHubContext
                .ST
                .Where(st => st.STATUS == "ACTV" || st.STATUS == "INAC" || st.STATUS == "LVNG" || (st.EXIT_DATE.HasValue && st.EXIT_DATE.Value.Year == year))
                .Select(st => new V_RISK(Context, st, kgdAvailable, kggAvailable))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            var builder = new StringBuilder();

            builder.Append($@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_RISK]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_RISK]
AS
SELECT
    ST.FIRST_REG_NO,
    ST.STKEY,
    CONVERT(varchar(12), ST.ENTRY, 101) ENTRY,
    ST.SCHOOL_YEAR,
    ST.HOME_GROUP,
    (ST.SURNAME + '', '' + ST.FIRST_NAME) STUDENT,
    ISNULL(RS1.UNAPPROVED,0) UNAPPROVED,
    CASE
        WHEN RS1.DAYS_MARKED > 0 THEN
            (RS1.DAYS_MARKED - RS1.ABSENCES) / RS1.DAYS_MARKED * 100
        ELSE 0
    END ATTEND_PERCENT,
    ISNULL(RS3.ENGREA, '''') ENGREA,
    ISNULL(RS4.ENGWRI, '''') ENGWRI,
    ISNULL(RS5.MATNUM, '''') MATNUM,
    ISNULL(RS6.MATSTR, '''') MATSTR,
    ISNULL(RS1.INTERNAL_SUSPENSION, 0) INTERNAL_SUSPENSION,
    ISNULL(RS1.EXTERNAL_SUSPENSION, 0) EXTERNAL_SUSPENSION,
    (CASE
        WHEN ST.RELATION_A01 = ''self'' THEN ''N''
        ELSE
            CASE
                WHEN ISNULL(DF.OCCUP_STATUS_A, ''U'') <= ISNULL(DF.OCCUP_STATUS_B, ''U'') THEN
                    ISNULL(DF.OCCUP_STATUS_A, ''U'')
                ELSE
                    ISNULL(DF.OCCUP_STATUS_B, ''U'')
            END
    END) OCCUPATION_CODE,
    ISNULL(KOORIE,''N'') +
        CASE
            WHEN ST.BIRTH_COUNTRY IN (SELECT KGT.COUNTRY FROM KGT WHERE KGT.REFUGEE = ''Y'') THEN
                ''Y''
            ELSE
                CASE
                    WHEN COALESCE(CASE WHEN ST.LOTE_HOME_CODE = ''1201'' THEN NULL ELSE ST.LOTE_HOME_CODE END,
                            CASE WHEN DF.LOTE_HOME_CODE_A = ''1201'' THEN NULL ELSE DF.LOTE_HOME_CODE_A END,
                            CASE WHEN DF.LOTE_HOME_CODE_B = ''1201'' THEN NULL ELSE DF.LOTE_HOME_CODE_B END) IS NOT NULL AND
                        ST.HOME_LANG <> ''1201'' AND
                        DATEADD(YY, 7, ST.AUSSIE_SCHOOL) >= CONVERT(datetime, CONVERT(varchar(4), YEAR(GETDATE())) + ''-01-01'') AND
                        ST.VISA_SUBCLASS IN (SELECT KCV.VISA_SUBCLASS FROM KCV WHERE REFUGEE = ''Y'') THEN
                        ''Y''
                    ELSE ''N''
                END
        END +
        ISNULL(DISABILITY, ''N'') +
        ISNULL(INTEGRATION, ''N'') +
        ISNULL(YOUTH_ALLOW, ''N'') +
        ISNULL(ACCESS_ALERT, ''N'') +
        ISNULL(RISK_ALERT,''N'') +
        ISNULL(MEDICAL_ALERT,''N'') ALERTS,
    ST.GENDER,
    ST.LIVING_ARR,
    ISNULL(CONVERT(VARCHAR(10),ST.EXIT_DATE,103),'''') EXIT_DATE,");

            // KGD isn't currently included in any typical eduHub services
            if (Context.EduHubContext.KGD.IsAvailable)
            {
                builder.Append($@"
    CASE
        WHEN ST.STATUS = ''LEFT'' THEN
            ISNULL(CASE
                WHEN ST.SCHOOL_YEAR < ''09'' OR ST.SCHOOL_YEAR = ''UG'' THEN
                    (SELECT SKGS.NAME FROM [{ParentDatabaseName}]..SKGS SKGS WHERE SCHOOL = ST.NEXT_SCHOOL)
                ELSE
                    (SELECT KGD.DESCRIPTION FROM [{ParentDatabaseName}]..KGD KGD WHERE KGDKEY = ST.EXIT_DEST01)
            END,'''')
        ELSE ''''
    END EXIT_0,");
            }
            else
            {
                builder.Append($@"
    CASE
        WHEN ST.STATUS = ''LEFT'' THEN
            ISNULL((SELECT SKGS.NAME FROM [{ParentDatabaseName}]..SKGS SKGS WHERE SCHOOL = ST.NEXT_SCHOOL), '''')
        ELSE ''''
    END EXIT_0,");
            }

            // KGG isn't currently included in any typical eduHub services
            if (Context.EduHubContext.KGG.IsAvailable)
            {
                builder.Append(@"
    KGG.DESCRIPTION EXIT_6");
            }
            else
            {
                builder.Append(@"
    NULL EXIT_6");
            }

            builder.Append($@"
FROM (
        (
            (
                (
                    ([{ParentDatabaseName}]..ST AS ST
                    LEFT JOIN (
                        SELECT
                            SXAB.STKEY,
                            SUM(CASE WHEN SXAB.AM_ACT_TYPE IN (208, 300, 500) THEN 0.5 ELSE 0 END + CASE WHEN SXAB.PM_ACT_TYPE IN (208, 300, 500) THEN 0.5 ELSE 0 END) unapproved,
                            SUM(CASE WHEN SXAB.AM_ACT_TYPE >= 200 AND KCTAM.CURRICULUM = ''N'' THEN 0.5 ELSE 0 END + CASE WHEN SXAB.PM_ACT_TYPE >= 200 AND KCTPM.CURRICULUM = ''N'' THEN 0.5 ELSE 0 END) absences,
                            SUM(CASE WHEN SXAB.AM_ACT_TYPE > 0 THEN 0.5 ELSE 0 END + CASE WHEN SXAB.PM_ACT_TYPE > 0 THEN 0.5 ELSE 0 END) days_marked,
                            SUM(CASE WHEN SXAB.AM_ACT_TYPE = 401 THEN 0.5 ELSE 0 END + CASE WHEN SXAB.PM_ACT_TYPE = 401 THEN 0.5 ELSE 0 END) external_suspension,
                            SUM(CASE WHEN SXAB.AM_ACT_TYPE = 400 THEN 0.5 ELSE 0 END + CASE WHEN SXAB.PM_ACT_TYPE = 400 THEN 0.5 ELSE 0 END) internal_suspension
                            FROM
                            (
                                (SELECT * FROM
                                    (SELECT
                                        STKEY,
                                        AM_ACT_TYPE % 1000 AM_ACT_TYPE,
                                        PM_ACT_TYPE % 1000 PM_ACT_TYPE
                                    FROM (
                                        SELECT
                                            STKEY,
                                            ABSENCE_DATE,
                                            MIN(CASE
                                                WHEN source = ''sxab'' AND AM_ACT_TYPE > 0 THEN
                                                    AM_ACT_TYPE 
                                                WHEN source = ''conv'' AND AM_ACT_TYPE > 0 THEN
                                                    1000 + AM_ACT_TYPE
                                                ELSE 2000
                                            END) AM_ACT_TYPE,
                                            MIN(CASE
                                                WHEN source = ''sxab'' AND PM_ACT_TYPE > 0 THEN
                                                    PM_ACT_TYPE
                                                WHEN source = ''conv'' AND PM_ACT_TYPE > 0 THEN
                                                    1000 + PM_ACT_TYPE
                                                ELSE 2000
                                            END) PM_ACT_TYPE
                                        FROM (
                                            SELECT
                                                SXAB.STKEY,
                                                SXAB.ABSENCE_DATE,
                                                SXAB.AM_ACT_TYPE,
                                                SXAB.PM_ACT_TYPE,
                                                ''sxab'' source
                                            FROM [{ParentDatabaseName}]..SXAB SXAB
                                            WHERE YEAR(SXAB.ABSENCE_DATE) = YEAR(GETDATE()) 
                                            UNION ALL
                                            SELECT
                                                SXABCONV.STKEY,
                                                SXABCONV.ABSENCE_DATE,
                                                SXABCONV.AM_TYPE,
                                                SXABCONV.PM_TYPE,
                                                ''conv'' source
                                            FROM [{ParentDatabaseName}]..SXABCONV SXABCONV
                                            WHERE YEAR(SXABCONV.ABSENCE_DATE) = YEAR(GETDATE())) as rs0
                                        GROUP BY STKEY, ABSENCE_DATE) rs98
                                    ) rs99
                                ) SXAB
                            LEFT JOIN [{ParentDatabaseName}]..KCT as KCTAM ON SXAB.AM_ACT_TYPE = KCTAM.KCTKEY
                            )
                        LEFT JOIN [{ParentDatabaseName}]..KCT as KCTPM ON SXAB.PM_ACT_TYPE = KCTPM.KCTKEY
                        GROUP BY SXAB.STKEY) RS1 ON ST.STKEY = RS1.STKEY
                    )
                    LEFT JOIN (
                        SELECT RS1.SKEY, RS1.SCORE ENGREA
                        FROM (
                            SELECT
                                SKEY,
                                YEAR_SEMESTER,
                                CASE SCORE
                                    WHEN ''NA'' THEN ''0''
                                    ELSE SCORE
                                END SCORE
                            FROM [{ParentDatabaseName}]..STVDI
                            WHERE VDIMENSION = ''ENGREA'') RS1
                        JOIN (
                            SELECT
                                SKEY,
                                MAX(YEAR_SEMESTER) YEAR_SEMESTER
                            FROM (
                                SELECT
                                    SKEY,
                                    MAX(YEAR_SEMESTER) YEAR_SEMESTER
                                FROM [{ParentDatabaseName}]..STVDI
                                WHERE VDIMENSION = ''ENGREA'' AND SCORE <> ''NA''
                                GROUP BY SKEY) as RS
                            GROUP BY SKEY
                        ) RS2 ON RS1.SKEY = RS2.SKEY AND RS1.YEAR_SEMESTER = RS2.YEAR_SEMESTER
                    ) AS RS3 ON ST.STKEY = RS3.SKEY
                )
                LEFT JOIN (
                    SELECT
                        RS1.SKEY,
                        RS1.SCORE ENGWRI
                    FROM (
                        SELECT
                            SKEY,
                            YEAR_SEMESTER,
                            CASE SCORE
                                WHEN ''NA'' THEN ''0''
                                ELSE SCORE
                            END SCORE
                        FROM [{ParentDatabaseName}]..STVDI
                        WHERE VDIMENSION = ''ENGWRI'') as RS1
                    JOIN (
                        SELECT
                            SKEY,
                            MAX(YEAR_SEMESTER) YEAR_SEMESTER
                        FROM (
                            SELECT
                                SKEY,
                                MAX(YEAR_SEMESTER) YEAR_SEMESTER
                            FROM [{ParentDatabaseName}]..STVDI
                            WHERE VDIMENSION = ''ENGWRI'' AND SCORE <> ''NA''
                            GROUP BY SKEY) as RS
                        GROUP BY SKEY
                    ) RS2 ON RS1.SKEY = RS2.SKEY AND RS1.YEAR_SEMESTER = RS2.YEAR_SEMESTER
                ) AS RS4 ON ST.STKEY = RS4.SKEY
            )
            LEFT JOIN (
                SELECT
                    RS1.SKEY,
                    RS1.SCORE MATNUM
                FROM (
                    SELECT
                        SKEY,
                        YEAR_SEMESTER,
                        CASE SCORE
                            WHEN ''NA'' THEN ''0''
                            ELSE SCORE
                        END SCORE
                    FROM [{ParentDatabaseName}]..STVDI
                    WHERE VDIMENSION = ''MATNUM'') RS1
                JOIN (
                    SELECT
                        SKEY,
                        MAX(YEAR_SEMESTER) YEAR_SEMESTER
                    FROM (
                        SELECT
                            SKEY,
                            MAX(YEAR_SEMESTER) YEAR_SEMESTER
                        FROM [{ParentDatabaseName}]..STVDI
                        WHERE VDIMENSION = ''MATNUM'' AND SCORE <> ''NA''
                        GROUP BY SKEY) RS
                    GROUP BY SKEY
                ) RS2 ON RS1.SKEY = RS2.SKEY AND RS1.YEAR_SEMESTER = RS2.YEAR_SEMESTER
            ) RS5 ON ST.STKEY = RS5.SKEY
        )
        LEFT JOIN (
            SELECT
                RS1.SKEY,
                RS1.SCORE MATSTR
            FROM (
                SELECT
                    SKEY,
                    YEAR_SEMESTER,
                    CASE SCORE
                        WHEN ''NA'' THEN ''0''
                        ELSE SCORE
                    END SCORE
                FROM [{ParentDatabaseName}]..STVDI
                WHERE VDIMENSION = ''MATSTR'') as RS1
            JOIN (
                SELECT
                    SKEY,
                    MAX(YEAR_SEMESTER) YEAR_SEMESTER
                FROM (
                    SELECT
                        SKEY,
                        MAX(YEAR_SEMESTER) YEAR_SEMESTER
                    FROM [{ParentDatabaseName}]..STVDI
                    WHERE VDIMENSION = ''MATSTR'' AND SCORE <> ''NA''
                    GROUP BY SKEY) RS
                GROUP BY SKEY
            ) RS2 ON RS1.SKEY = RS2.SKEY AND RS1.YEAR_SEMESTER = RS2.YEAR_SEMESTER
        ) AS RS6 ON ST.STKEY = RS6.SKEY
    )
LEFT JOIN [{ParentDatabaseName}]..DF as df ON ST.FAMILY = DF.DFKEY");

            // KGG isn't currently included in any typical eduHub services
            if (Context.EduHubContext.KGG.IsAvailable)
            {
                builder.Append($@"
LEFT JOIN [{ParentDatabaseName}]..KGG KGG ON KGGKEY = ST.EXIT_CAT01");
            }

            builder.Append(@"
WHERE ST.STATUS IN (''ACTV'',''INAC'',''LVNG'') OR YEAR(ST.EXIT_DATE) = YEAR(GETDATE())';");

            return builder.ToString();
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
                        writer.WriteLine("FIRST_REG_NO,STKEY,ENTRY,SCHOOL_YEAR,HOME_GROUP,STUDENT,UNAPPROVED,ATTEND_PERCENT,ENGREA,ENGWRI,MATNUM,MATSTR,INTERNAL_SUSPENSION,EXTERNAL_SUSPENSION,OCCUPATION_CODE,ALERTS,GENDER,LIVING_ARR,EXIT_DATE,EXIT_0,EXIT_6");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.FIRST_REG_NO);
                        writer.Write("\",\"");
                        writer.Write(entity.STKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.ENTRY);
                        writer.Write("\",\"");
                        writer.Write(entity.SCHOOL_YEAR);
                        writer.Write("\",\"");
                        writer.Write(entity.HOME_GROUP);
                        writer.Write("\",\"");
                        writer.Write(entity.STUDENT);
                        writer.Write("\",");
                        writer.Write(entity.UNAPPROVED);
                        writer.Write(',');
                        writer.Write(entity.ATTEND_PERCENT);
                        writer.Write(",\"");
                        writer.Write(entity.ENGREA);
                        writer.Write("\",\"");
                        writer.Write(entity.ENGWRI);
                        writer.Write("\",\"");
                        writer.Write(entity.MATNUM);
                        writer.Write("\",\"");
                        writer.Write(entity.MATSTR);
                        writer.Write("\",");
                        writer.Write(entity.INTERNAL_SUSPENSION);
                        writer.Write(',');
                        writer.Write(entity.EXTERNAL_SUSPENSION);
                        writer.Write(",\"");
                        writer.Write(entity.OCCUPATION_CODE);
                        writer.Write("\",\"");
                        writer.Write(entity.ALERTS);
                        writer.Write("\",\"");
                        writer.Write(entity.GENDER);
                        writer.Write("\",\"");
                        writer.Write(entity.LIVING_ARR);
                        writer.Write("\",\"");
                        writer.Write(entity.EXIT_DATE);
                        writer.Write("\",\"");
                        writer.Write(entity.EXIT_0);
                        writer.Write("\",\"");
                        writer.Write(entity.EXIT_6);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
