using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Students Data Set
    /// </summary>
    public class V_STDataSet : SeamlessViewsDataSet<V_ST>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_ST"; } }

        internal V_STDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.DF;
            yield return Context.EduHubContext.KCY;
            yield return Context.EduHubContext.ST;
            yield return Context.EduHubContext.UM;
        }

        /// <inheritdoc />
        protected override List<V_ST> Load()
        {
            return Context.EduHubContext
                .ST
                .Where(st => st.STATUS != "LEFT" &&
                            st.SCHOOL_YEAR != null &&
                            st.FAMILY != null &&
                            st.FAMILY_DF.MAILKEY != null)
                .Select(st => new V_ST(Context, st))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_ST]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_ST]
AS
SELECT
    ST.STKEY,
    (ST.SURNAME + '' '' + ST.PREF_NAME + '' '' + ST.SCHOOL_YEAR + '' '' + ST.HOME_GROUP) STUDENT,
    (CASE
        WHEN ST.CONTACT_A = ''A'' THEN
            DF.TITLE_A + '' '' + (SUBSTRING(DF.NAME_A,1,1)) + '' '' + DF.SURNAME_A
        WHEN ST.CONTACT_A = ''B'' THEN
            DF.TITLE_B + '' '' + (SUBSTRING(DF.NAME_B,1,1))  + '' '' + DF.SURNAME_B
        WHEN ST.CONTACT_A = ''N'' THEN NULL
        ELSE
            CASE
                WHEN DF.SURNAME_A = DF.SURNAME_B THEN
                    DF.TITLE_A + '' '' + (SUBSTRING(DF.NAME_A,1,1)) + '' & '' +
                        DF.TITLE_B + '' '' + (SUBSTRING(DF.NAME_B,1,1)) +  '' '' + DF.SURNAME_A
                ELSE
                    CASE
                        WHEN DF.SURNAME_A <> DF.SURNAME_B THEN
                            DF.TITLE_A + '' '' + (SUBSTRING(DF.NAME_A,1,1)) + '' '' + DF.SURNAME_A + '' & '' +
                                DF.TITLE_B + '' '' + (SUBSTRING(DF.NAME_B,1,1)) + '' '' + DF.SURNAME_B
                        WHEN DF.SURNAME_A IS NULL AND DF.SURNAME_B IS NOT NULL THEN
                            DF.TITLE_B + '' '' + (SUBSTRING(DF.NAME_B,1,1)) + '' '' + DF.SURNAME_B
                        WHEN DF.SURNAME_B IS NULL AND DF.SURNAME_A IS NOT NULL THEN
                            DF.TITLE_A + '' '' + (SUBSTRING(DF.NAME_A,1,1)) + '' '' + DF.SURNAME_A
                        WHEN DF.SURNAME_A IS NULL AND DF.SURNAME_B IS  NULL THEN
                            ''STUDENT HAS NO LISTED PARENTS''
                    END
            END
    END) PARENT1,
    ST.LIVING_ARR,
    (CASE
        WHEN ST.CONTACT_A = ''A'' THEN
            DF.TITLE_A + '' '' + DF.SURNAME_A
        WHEN ST.CONTACT_A = ''B'' THEN
            DF.TITLE_B + '' '' + DF.SURNAME_B
        WHEN ST.CONTACT_A = ''N'' THEN NULL
        ELSE
            CASE
                WHEN DF.SURNAME_A = DF.SURNAME_B THEN
                    DF.TITLE_A + '' & '' + DF.TITLE_B + '' '' + DF.SURNAME_A
                ELSE
                    CASE
                        WHEN DF.SURNAME_A <> DF.SURNAME_B THEN
                            DF.TITLE_A + '' '' + DF.SURNAME_A + '' & '' + DF.TITLE_B + '' '' + DF.SURNAME_B
                        WHEN DF.SURNAME_A IS NULL AND DF.SURNAME_B IS NOT NULL THEN
                            DF.TITLE_B + '' '' + DF.SURNAME_B
                        WHEN DF.SURNAME_B IS NULL AND DF.SURNAME_A IS NOT NULL THEN
                            DF.TITLE_A + '' '' + DF.SURNAME_A
                        WHEN DF.SURNAME_A IS NULL AND DF.SURNAME_B IS  NULL THEN
                            ''STUDENT HAS NO LISTED PARENTS''
                    END
            END
    END) PARENT2,
    ST.SURNAME,
    ST.FIRST_NAME,
    ST.SECOND_NAME,
     ST.PREF_NAME,
    ST.TITLE,
    ST.AB_STUDY,
    ST.ED_ALLOW EMA,
    ST.BIRTHDATE,
    ST.CAMPUS,
    ST.ENTRY,
    ST.GENDER,
     ST.HOME_GROUP,
    ST.HOME_LANG,
    ST.HOUSE,
    ST.KOORIE,
    ST.NOTES,
    ST.RELATION_A01,
     ST.SCHOOL_YEAR,
    ST.FAM_ORDER,
    KCY.DESCRIPTION,
    ST.STATUS,
    ST.STUDENT_PIC,
    ST.TAG,
    ST.YOUTH_ALLOW,
    ST.FAMILY,
    ST.LOTE_HOME_CODE,
    ST.SGB_FUNDED, 
    ST.INTERNATIONAL_ST_ID,
    ST.CONTACT_A,
    ST.IMMUNISE_CERT_STATUS,
    (CASE WHEN COALESCE(CASE WHEN ST.LOTE_HOME_CODE = ''1201'' THEN NULL ELSE ST.LOTE_HOME_CODE END,
                        CASE WHEN DF.LOTE_HOME_CODE_A = ''1201'' THEN NULL ELSE DF.LOTE_HOME_CODE_A END,
                        CASE WHEN DF.LOTE_HOME_CODE_B = ''1201'' THEN NULL ELSE DF.LOTE_HOME_CODE_B END)
            IS NOT NULL
        THEN ''Y'' ELSE ''N''
    END) LBOTE,
    DF.DFKEY,
    DF.SURNAME_A,
    DF.NAME_A,
    DF.TITLE_A,
    DF.E_MAIL_A,
    DF.SURNAME_B,
    DF.NAME_B,
    DF.E_MAIL_B,
    DF.TITLE_B,
    DF.MAILKEY,
    DF.NO_STUDENTS,
    DF.LOTE_HOME_CODE_A,
    DF.LOTE_HOME_CODE_B,
    DF.OCCUP_STATUS_A,
    DF.OCCUP_STATUS_B,
    DF.WORK_CONT_A,
    DF.BH_AT_HOME_A,
    DF.BH_CONTACT_A,
    DF.AH_AT_HOME_A,
    DF.AH_CONTACT_A,
    DF.PREF_MAIL_MECH_A,
    DF.FAX_A,
    DF.WORK_CONT_B,
    DF.BH_AT_HOME_B,
    DF.BH_CONTACT_B,
    DF.AH_AT_HOME_B,
    DF.AH_CONTACT_B,
    DF.PREF_MAIL_MECH_B,
    DF.FAX_B,
    (CASE
        WHEN ST.RELATION_A01 = ''self'' THEN ''N''
        ELSE
            CASE
                WHEN ISNULL(DF.OCCUP_STATUS_A, ''U'') <= ISNULL(DF.OCCUP_STATUS_B, ''U'') THEN
                    ISNULL(DF.OCCUP_STATUS_A, ''U'')
                ELSE
                    ISNULL(DF.OCCUP_STATUS_B, ''U'')
            END
    END) FAM_OCCUP,
    UM.UMKEY,
    UM.ADDRESS01,
    UM.ADDRESS02,
    UM.ADDRESS03,
    UM.POSTCODE,
    UM.STATE,
    UM.TELEPHONE,
    UM.FAX
FROM [{ParentDatabaseName}]..ST ST
JOIN [{ParentDatabaseName}]..KCY KCY ON ST.SCHOOL_YEAR = KCY.KCYKEY
JOIN [{ParentDatabaseName}]..DF DF ON DF.DFKEY = ST.FAMILY 
JOIN [{ParentDatabaseName}]..UM UM ON DF.MAILKEY = UM.UMKEY
WHERE ST.STATUS <> ''LEFT''';";
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
                        writer.WriteLine("STKEY,STUDENT,PARENT1,LIVING_ARR,PARENT2,SURNAME,FIRST_NAME,SECOND_NAME,PREF_NAME,TITLE,AB_STUDY,EMA,BIRTHDATE,CAMPUS,ENTRY,GENDER,HOME_GROUP,HOME_LANG,HOUSE,KOORIE,NOTES,RELATION_A01,SCHOOL_YEAR,FAM_ORDER,DESCRIPTION,STATUS,STUDENT_PIC,TAG,YOUTH_ALLOW,FAMILY,LOTE_HOME_CODE,SGB_FUNDED,INTERNATIONAL_ST_ID,CONTACT_A,IMMUNISE_CERT_STATUS,LBOTE,DFKEY,SURNAME_A,NAME_A,TITLE_A,E_MAIL_A,SURNAME_B,NAME_B,E_MAIL_B,TITLE_B,MAILKEY,NO_STUDENTS,LOTE_HOME_CODE_A,LOTE_HOME_CODE_B,OCCUP_STATUS_A,OCCUP_STATUS_B,WORK_CONT_A,BH_AT_HOME_A,BH_CONTACT_A,AH_AT_HOME_A,AH_CONTACT_A,PREF_MAIL_MECH_A,FAX_A,WORK_CONT_B,BH_AT_HOME_B,BH_CONTACT_B,AH_AT_HOME_B,AH_CONTACT_B,PREF_MAIL_MECH_B,FAX_B,FAM_OCCUP,UMKEY,ADDRESS01,ADDRESS02,ADDRESS03,POSTCODE,STATE,TELEPHONE,FAX");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.STKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.STUDENT);
                        writer.Write("\",\"");
                        writer.Write(entity.PARENT1);
                        writer.Write("\",\"");
                        writer.Write(entity.LIVING_ARR);
                        writer.Write("\",\"");
                        writer.Write(entity.PARENT2);
                        writer.Write("\",\"");
                        writer.Write(entity.SURNAME);
                        writer.Write("\",\"");
                        writer.Write(entity.FIRST_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.SECOND_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.PREF_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.TITLE);
                        writer.Write("\",\"");
                        writer.Write(entity.AB_STUDY);
                        writer.Write("\",\"");
                        writer.Write(entity.EMA);
                        writer.Write("\",\"");
                        writer.Write(entity.BIRTHDATE?.ToString("yyyy-MM-dd"));
                        writer.Write("\",");
                        writer.Write(entity.CAMPUS);
                        writer.Write(",\"");
                        writer.Write(entity.ENTRY?.ToString("yyyy-MM-dd"));
                        writer.Write("\",\"");
                        writer.Write(entity.GENDER);
                        writer.Write("\",\"");
                        writer.Write(entity.HOME_GROUP);
                        writer.Write("\",\"");
                        writer.Write(entity.HOME_LANG);
                        writer.Write("\",\"");
                        writer.Write(entity.HOUSE);
                        writer.Write("\",\"");
                        writer.Write(entity.KOORIE);
                        writer.Write("\",\"");
                        writer.Write(entity.NOTES);
                        writer.Write("\",\"");
                        writer.Write(entity.RELATION_A01);
                        writer.Write("\",\"");
                        writer.Write(entity.SCHOOL_YEAR);
                        writer.Write("\",");
                        writer.Write(entity.FAM_ORDER);
                        writer.Write(",\"");
                        writer.Write(entity.DESCRIPTION);
                        writer.Write("\",\"");
                        writer.Write(entity.STATUS);
                        writer.Write("\",");
                        // STUDENT_PIC - Not Supported
                        writer.Write(",\"");
                        writer.Write(entity.TAG);
                        writer.Write("\",\"");
                        writer.Write(entity.YOUTH_ALLOW);
                        writer.Write("\",\"");
                        writer.Write(entity.FAMILY);
                        writer.Write("\",\"");
                        writer.Write(entity.LOTE_HOME_CODE);
                        writer.Write("\",\"");
                        writer.Write(entity.SGB_FUNDED);
                        writer.Write("\",\"");
                        writer.Write(entity.INTERNATIONAL_ST_ID);
                        writer.Write("\",\"");
                        writer.Write(entity.CONTACT_A);
                        writer.Write("\",\"");
                        writer.Write(entity.IMMUNISE_CERT_STATUS);
                        writer.Write("\",\"");
                        writer.Write(entity.LBOTE);
                        writer.Write("\",\"");
                        writer.Write(entity.DFKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.SURNAME_A);
                        writer.Write("\",\"");
                        writer.Write(entity.NAME_A);
                        writer.Write("\",\"");
                        writer.Write(entity.TITLE_A);
                        writer.Write("\",\"");
                        writer.Write(entity.E_MAIL_A);
                        writer.Write("\",\"");
                        writer.Write(entity.SURNAME_B);
                        writer.Write("\",\"");
                        writer.Write(entity.NAME_B);
                        writer.Write("\",\"");
                        writer.Write(entity.E_MAIL_B);
                        writer.Write("\",\"");
                        writer.Write(entity.TITLE_B);
                        writer.Write("\",");
                        writer.Write(entity.MAILKEY);
                        writer.Write(",");
                        writer.Write(entity.NO_STUDENTS);
                        writer.Write(",\"");
                        writer.Write(entity.LOTE_HOME_CODE_A);
                        writer.Write("\",\"");
                        writer.Write(entity.LOTE_HOME_CODE_B);
                        writer.Write("\",\"");
                        writer.Write(entity.OCCUP_STATUS_A);
                        writer.Write("\",\"");
                        writer.Write(entity.OCCUP_STATUS_B);
                        writer.Write("\",\"");
                        writer.Write(entity.WORK_CONT_A);
                        writer.Write("\",\"");
                        writer.Write(entity.BH_AT_HOME_A);
                        writer.Write("\",\"");
                        writer.Write(entity.BH_CONTACT_A);
                        writer.Write("\",\"");
                        writer.Write(entity.AH_AT_HOME_A);
                        writer.Write("\",\"");
                        writer.Write(entity.AH_CONTACT_A);
                        writer.Write("\",\"");
                        writer.Write(entity.PREF_MAIL_MECH_A);
                        writer.Write("\",\"");
                        writer.Write(entity.FAX_A);
                        writer.Write("\",\"");
                        writer.Write(entity.WORK_CONT_B);
                        writer.Write("\",\"");
                        writer.Write(entity.BH_AT_HOME_B);
                        writer.Write("\",\"");
                        writer.Write(entity.BH_CONTACT_B);
                        writer.Write("\",\"");
                        writer.Write(entity.AH_AT_HOME_B);
                        writer.Write("\",\"");
                        writer.Write(entity.AH_CONTACT_B);
                        writer.Write("\",\"");
                        writer.Write(entity.PREF_MAIL_MECH_B);
                        writer.Write("\",\"");
                        writer.Write(entity.FAX_B);
                        writer.Write("\",\"");
                        writer.Write(entity.FAM_OCCUP);
                        writer.Write("\",");
                        writer.Write(entity.UMKEY);
                        writer.Write(",\"");
                        writer.Write(entity.ADDRESS01);
                        writer.Write("\",\"");
                        writer.Write(entity.ADDRESS02);
                        writer.Write("\",\"");
                        writer.Write(entity.ADDRESS03);
                        writer.Write("\",\"");
                        writer.Write(entity.POSTCODE);
                        writer.Write("\",\"");
                        writer.Write(entity.STATE);
                        writer.Write("\",\"");
                        writer.Write(entity.TELEPHONE);
                        writer.Write("\",\"");
                        writer.Write(entity.FAX);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
