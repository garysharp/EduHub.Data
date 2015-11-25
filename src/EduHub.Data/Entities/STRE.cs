using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Re-Enrolment
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STRE : EntityBase
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
        private KCY Cache_ST_SCHOOL_YEAR_KCY;
        private KGC Cache_ST_HOME_GROUP_KGC;
        private SKGS Cache_ST_PREVIOUS_SCHOOL_SKGS;
        private KCV Cache_ST_VISA_SUBCLASS_KCV;
        private KGL Cache_ST_HOME_LANG_KGL;
        private SCI Cache_ST_CAMPUS_SCI;
        private SKGS Cache_STPT_SCHL_NUM01_SKGS;
        private SKGS Cache_STPT_SCHL_NUM02_SKGS;
        private SKGS Cache_STPT_SCHL_NUM03_SKGS;
        private SKGS Cache_STPT_SCHL_NUM04_SKGS;
        private SKGS Cache_ST_NEXT_SCHOOL_SKGS;
        private KGL Cache_ST_LOTE_HOME_CODE_KGL;
        private KGL Cache_DF_LOTE_HOME_CODE_A_KGL;
        private KGL Cache_DF_LOTE_HOME_CODE_B_KGL;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// Date of previous ENTRY
        /// </summary>
        public DateTime? ST_ENTRY { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? ST_EXIT_DATE { get; internal set; }

        /// <summary>
        /// Year Level at time of leaving
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ST_SCHOOL_YEAR { get; internal set; }

        /// <summary>
        /// Home Group at time of leaving
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string ST_HOME_GROUP { get; internal set; }

        /// <summary>
        /// Previous school attended
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ST_PREVIOUS_SCHOOL { get; internal set; }

        /// <summary>
        /// Residency status
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ST_RESIDENT_STATUS { get; internal set; }

        /// <summary>
        /// Basis of Australian permanent residence status: E=Eligible for Australian passport, A=Holds Australian passport, P=Holds permanent residency visa
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ST_PERMANENT_BASIS { get; internal set; }

        /// <summary>
        /// Visa Sub-class
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string ST_VISA_SUBCLASS { get; internal set; }

        /// <summary>
        /// Visa statistical code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ST_VISA_STAT_CODE { get; internal set; }

        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ST_SGB_FUNDED { get; internal set; }

        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ST_LIVING_ARR { get; internal set; }

        /// <summary>
        /// Full time? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ST_FULLTIME { get; internal set; }

        /// <summary>
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string ST_HOME_LANG { get; internal set; }

        /// <summary>
        /// Is this student an applicant for, or in receipt of, CSEF? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ST_ED_ALLOW { get; internal set; }

        /// <summary>
        /// Youth allowance (&lt;25)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ST_YOUTH_ALLOW { get; internal set; }

        /// <summary>
        /// Student's home campus
        /// </summary>
        public int? ST_CAMPUS { get; internal set; }

        /// <summary>
        /// Adult A occupation status group (A,B,C,D,E,N,U)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DF_OCCUP_STATUS_A { get; internal set; }

        /// <summary>
        /// Adult B occupation status group (A,B,C,D,E,N,U)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DF_OCCUP_STATUS_B { get; internal set; }

        /// <summary>
        /// ID of school (could be home school)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string STPT_SCHL_NUM01 { get; internal set; }

        /// <summary>
        /// ID of school (could be home school)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string STPT_SCHL_NUM02 { get; internal set; }

        /// <summary>
        /// ID of school (could be home school)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string STPT_SCHL_NUM03 { get; internal set; }

        /// <summary>
        /// ID of school (could be home school)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string STPT_SCHL_NUM04 { get; internal set; }

        /// <summary>
        /// Time fraction SRP funding for current calendar year
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION01 { get; internal set; }

        /// <summary>
        /// Time fraction SRP funding for current calendar year
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION02 { get; internal set; }

        /// <summary>
        /// Time fraction SRP funding for current calendar year
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION03 { get; internal set; }

        /// <summary>
        /// Time fraction SRP funding for current calendar year
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION04 { get; internal set; }

        /// <summary>
        /// Actual Time fraction for current calendar year
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION01 { get; internal set; }

        /// <summary>
        /// Actual Time fraction for current calendar year
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION02 { get; internal set; }

        /// <summary>
        /// Actual Time fraction for current calendar year
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION03 { get; internal set; }

        /// <summary>
        /// Actual Time fraction for current calendar year
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION04 { get; internal set; }

        /// <summary>
        /// Is this school claiming this student for SRP funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STPT_ENROLLED01 { get; internal set; }

        /// <summary>
        /// Is this school claiming this student for SRP funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STPT_ENROLLED02 { get; internal set; }

        /// <summary>
        /// Is this school claiming this student for SRP funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STPT_ENROLLED03 { get; internal set; }

        /// <summary>
        /// Is this school claiming this student for SRP funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STPT_ENROLLED04 { get; internal set; }

        /// <summary>
        /// School to which departed student has gone (if any)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ST_NEXT_SCHOOL { get; internal set; }

        /// <summary>
        /// Visa expiry date
        /// </summary>
        public DateTime? ST_VISA_EXPIRY { get; internal set; }

        /// <summary>
        /// Notes on attempts to get parental approval
        /// [Alphanumeric (200)]
        /// </summary>
        public string ST_PARENTAL_APPROVAL_NOTE { get; internal set; }

        /// <summary>
        /// The Language other than English spoken at home by student, copied from ST record
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string ST_LOTE_HOME_CODE { get; internal set; }

        /// <summary>
        /// The language other than English spoken at home by adult A, copied from DF
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string DF_LOTE_HOME_CODE_A { get; internal set; }

        /// <summary>
        /// The language other than English spoken at home by adult B, copied from DF
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string DF_LOTE_HOME_CODE_B { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// ST (Students) related entity by [STRE.SKEY]-&gt;[ST.STKEY]
        /// Student key
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (Cache_SKEY_ST == null)
                {
                    Cache_SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                }

                return Cache_SKEY_ST;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [STRE.ST_SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// Year Level at time of leaving
        /// </summary>
        public KCY ST_SCHOOL_YEAR_KCY
        {
            get
            {
                if (ST_SCHOOL_YEAR == null)
                {
                    return null;
                }
                if (Cache_ST_SCHOOL_YEAR_KCY == null)
                {
                    Cache_ST_SCHOOL_YEAR_KCY = Context.KCY.FindByKCYKEY(ST_SCHOOL_YEAR);
                }

                return Cache_ST_SCHOOL_YEAR_KCY;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [STRE.ST_HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// Home Group at time of leaving
        /// </summary>
        public KGC ST_HOME_GROUP_KGC
        {
            get
            {
                if (ST_HOME_GROUP == null)
                {
                    return null;
                }
                if (Cache_ST_HOME_GROUP_KGC == null)
                {
                    Cache_ST_HOME_GROUP_KGC = Context.KGC.FindByKGCKEY(ST_HOME_GROUP);
                }

                return Cache_ST_HOME_GROUP_KGC;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [STRE.ST_PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Previous school attended
        /// </summary>
        public SKGS ST_PREVIOUS_SCHOOL_SKGS
        {
            get
            {
                if (ST_PREVIOUS_SCHOOL == null)
                {
                    return null;
                }
                if (Cache_ST_PREVIOUS_SCHOOL_SKGS == null)
                {
                    Cache_ST_PREVIOUS_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ST_PREVIOUS_SCHOOL);
                }

                return Cache_ST_PREVIOUS_SCHOOL_SKGS;
            }
        }

        /// <summary>
        /// KCV (Visa Subclasses) related entity by [STRE.ST_VISA_SUBCLASS]-&gt;[KCV.VISA_SUBCLASS]
        /// Visa Sub-class
        /// </summary>
        public KCV ST_VISA_SUBCLASS_KCV
        {
            get
            {
                if (ST_VISA_SUBCLASS == null)
                {
                    return null;
                }
                if (Cache_ST_VISA_SUBCLASS_KCV == null)
                {
                    Cache_ST_VISA_SUBCLASS_KCV = Context.KCV.FindByVISA_SUBCLASS(ST_VISA_SUBCLASS);
                }

                return Cache_ST_VISA_SUBCLASS_KCV;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [STRE.ST_HOME_LANG]-&gt;[KGL.KGLKEY]
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// </summary>
        public KGL ST_HOME_LANG_KGL
        {
            get
            {
                if (ST_HOME_LANG == null)
                {
                    return null;
                }
                if (Cache_ST_HOME_LANG_KGL == null)
                {
                    Cache_ST_HOME_LANG_KGL = Context.KGL.FindByKGLKEY(ST_HOME_LANG);
                }

                return Cache_ST_HOME_LANG_KGL;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STRE.ST_CAMPUS]-&gt;[SCI.SCIKEY]
        /// Student's home campus
        /// </summary>
        public SCI ST_CAMPUS_SCI
        {
            get
            {
                if (ST_CAMPUS == null)
                {
                    return null;
                }
                if (Cache_ST_CAMPUS_SCI == null)
                {
                    Cache_ST_CAMPUS_SCI = Context.SCI.FindBySCIKEY(ST_CAMPUS.Value);
                }

                return Cache_ST_CAMPUS_SCI;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [STRE.STPT_SCHL_NUM01]-&gt;[SKGS.SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS STPT_SCHL_NUM01_SKGS
        {
            get
            {
                if (STPT_SCHL_NUM01 == null)
                {
                    return null;
                }
                if (Cache_STPT_SCHL_NUM01_SKGS == null)
                {
                    Cache_STPT_SCHL_NUM01_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM01);
                }

                return Cache_STPT_SCHL_NUM01_SKGS;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [STRE.STPT_SCHL_NUM02]-&gt;[SKGS.SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS STPT_SCHL_NUM02_SKGS
        {
            get
            {
                if (STPT_SCHL_NUM02 == null)
                {
                    return null;
                }
                if (Cache_STPT_SCHL_NUM02_SKGS == null)
                {
                    Cache_STPT_SCHL_NUM02_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM02);
                }

                return Cache_STPT_SCHL_NUM02_SKGS;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [STRE.STPT_SCHL_NUM03]-&gt;[SKGS.SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS STPT_SCHL_NUM03_SKGS
        {
            get
            {
                if (STPT_SCHL_NUM03 == null)
                {
                    return null;
                }
                if (Cache_STPT_SCHL_NUM03_SKGS == null)
                {
                    Cache_STPT_SCHL_NUM03_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM03);
                }

                return Cache_STPT_SCHL_NUM03_SKGS;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [STRE.STPT_SCHL_NUM04]-&gt;[SKGS.SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS STPT_SCHL_NUM04_SKGS
        {
            get
            {
                if (STPT_SCHL_NUM04 == null)
                {
                    return null;
                }
                if (Cache_STPT_SCHL_NUM04_SKGS == null)
                {
                    Cache_STPT_SCHL_NUM04_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM04);
                }

                return Cache_STPT_SCHL_NUM04_SKGS;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [STRE.ST_NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// School to which departed student has gone (if any)
        /// </summary>
        public SKGS ST_NEXT_SCHOOL_SKGS
        {
            get
            {
                if (ST_NEXT_SCHOOL == null)
                {
                    return null;
                }
                if (Cache_ST_NEXT_SCHOOL_SKGS == null)
                {
                    Cache_ST_NEXT_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ST_NEXT_SCHOOL);
                }

                return Cache_ST_NEXT_SCHOOL_SKGS;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [STRE.ST_LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// The Language other than English spoken at home by student, copied from ST record
        /// </summary>
        public KGL ST_LOTE_HOME_CODE_KGL
        {
            get
            {
                if (ST_LOTE_HOME_CODE == null)
                {
                    return null;
                }
                if (Cache_ST_LOTE_HOME_CODE_KGL == null)
                {
                    Cache_ST_LOTE_HOME_CODE_KGL = Context.KGL.FindByKGLKEY(ST_LOTE_HOME_CODE);
                }

                return Cache_ST_LOTE_HOME_CODE_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [STRE.DF_LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// The language other than English spoken at home by adult A, copied from DF
        /// </summary>
        public KGL DF_LOTE_HOME_CODE_A_KGL
        {
            get
            {
                if (DF_LOTE_HOME_CODE_A == null)
                {
                    return null;
                }
                if (Cache_DF_LOTE_HOME_CODE_A_KGL == null)
                {
                    Cache_DF_LOTE_HOME_CODE_A_KGL = Context.KGL.FindByKGLKEY(DF_LOTE_HOME_CODE_A);
                }

                return Cache_DF_LOTE_HOME_CODE_A_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [STRE.DF_LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// The language other than English spoken at home by adult B, copied from DF
        /// </summary>
        public KGL DF_LOTE_HOME_CODE_B_KGL
        {
            get
            {
                if (DF_LOTE_HOME_CODE_B == null)
                {
                    return null;
                }
                if (Cache_DF_LOTE_HOME_CODE_B_KGL == null)
                {
                    Cache_DF_LOTE_HOME_CODE_B_KGL = Context.KGL.FindByKGLKEY(DF_LOTE_HOME_CODE_B);
                }

                return Cache_DF_LOTE_HOME_CODE_B_KGL;
            }
        }

        #endregion

    }
}
