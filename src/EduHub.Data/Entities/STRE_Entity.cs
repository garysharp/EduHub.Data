using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Re-Enrolment
    /// </summary>
    public class STRE_Entity : EntityBase
    {
#region Navigation Property Cache
        private ST_Entity _SKEY_ST;
        private KCY_Entity _ST_SCHOOL_YEAR_KCY;
        private KGC_Entity _ST_HOME_GROUP_KGC;
        private SKGS_Entity _ST_PREVIOUS_SCHOOL_SKGS;
        private KCV_Entity _ST_VISA_SUBCLASS_KCV;
        private KGL_Entity _ST_HOME_LANG_KGL;
        private SCI_Entity _ST_CAMPUS_SCI;
        private SKGS_Entity _STPT_SCHL_NUM01_SKGS;
        private SKGS_Entity _STPT_SCHL_NUM02_SKGS;
        private SKGS_Entity _STPT_SCHL_NUM03_SKGS;
        private SKGS_Entity _STPT_SCHL_NUM04_SKGS;
        private SKGS_Entity _ST_NEXT_SCHOOL_SKGS;
        private KGL_Entity _ST_LOTE_HOME_CODE_KGL;
        private KGL_Entity _DF_LOTE_HOME_CODE_A_KGL;
        private KGL_Entity _DF_LOTE_HOME_CODE_B_KGL;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Date of previous ENTRY [Date Time nullable: d]
        /// </summary>
        public DateTime? ST_ENTRY { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? ST_EXIT_DATE { get; internal set; }
        /// <summary>
        /// Year Level at time of leaving [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ST_SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// Home Group at time of leaving [Uppercase Alphanumeric: u3]
        /// </summary>
        public string ST_HOME_GROUP { get; internal set; }
        /// <summary>
        /// Previous school attended [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ST_PREVIOUS_SCHOOL { get; internal set; }
        /// <summary>
        /// Residency status [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ST_RESIDENT_STATUS { get; internal set; }
        /// <summary>
        /// Basis of Australian permanent residence status: E=Eligible for Australian passport, A=Holds Australian passport, P=Holds permanent residency visa [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ST_PERMANENT_BASIS { get; internal set; }
        /// <summary>
        /// Visa Sub-class [Uppercase Alphanumeric: u3]
        /// </summary>
        public string ST_VISA_SUBCLASS { get; internal set; }
        /// <summary>
        /// Visa statistical code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ST_VISA_STAT_CODE { get; internal set; }
        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ST_SGB_FUNDED { get; internal set; }
        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ST_LIVING_ARR { get; internal set; }
        /// <summary>
        /// Full time? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ST_FULLTIME { get; internal set; }
        /// <summary>
        /// The language spoken at home: copied from DF record of family with whom student lives most [Uppercase Alphanumeric: u7]
        /// </summary>
        public string ST_HOME_LANG { get; internal set; }
        /// <summary>
        /// Is this student an applicant for, or in receipt of, EMA? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ST_ED_ALLOW { get; internal set; }
        /// <summary>
        /// Youth allowance (<25) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ST_YOUTH_ALLOW { get; internal set; }
        /// <summary>
        /// Student's home campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ST_CAMPUS { get; internal set; }
        /// <summary>
        /// Adult A occupation status group (A,B,C,D,E,N,U) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DF_OCCUP_STATUS_A { get; internal set; }
        /// <summary>
        /// Adult B occupation status group (A,B,C,D,E,N,U) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DF_OCCUP_STATUS_B { get; internal set; }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string STPT_SCHL_NUM01 { get; internal set; }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string STPT_SCHL_NUM02 { get; internal set; }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string STPT_SCHL_NUM03 { get; internal set; }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string STPT_SCHL_NUM04 { get; internal set; }
        /// <summary>
        /// Time fraction SRP funding for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION01 { get; internal set; }
        /// <summary>
        /// Time fraction SRP funding for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION02 { get; internal set; }
        /// <summary>
        /// Time fraction SRP funding for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION03 { get; internal set; }
        /// <summary>
        /// Time fraction SRP funding for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_SGB_TIME_FRACTION04 { get; internal set; }
        /// <summary>
        /// Actual Time fraction for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION01 { get; internal set; }
        /// <summary>
        /// Actual Time fraction for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION02 { get; internal set; }
        /// <summary>
        /// Actual Time fraction for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION03 { get; internal set; }
        /// <summary>
        /// Actual Time fraction for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STPT_ACTUAL_TIME_FRACTION04 { get; internal set; }
        /// <summary>
        /// Is this school claiming this student for SRP funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STPT_ENROLLED01 { get; internal set; }
        /// <summary>
        /// Is this school claiming this student for SRP funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STPT_ENROLLED02 { get; internal set; }
        /// <summary>
        /// Is this school claiming this student for SRP funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STPT_ENROLLED03 { get; internal set; }
        /// <summary>
        /// Is this school claiming this student for SRP funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STPT_ENROLLED04 { get; internal set; }
        /// <summary>
        /// School to which departed student has gone (if any) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ST_NEXT_SCHOOL { get; internal set; }
        /// <summary>
        /// Visa expiry date [Date Time nullable: d]
        /// </summary>
        public DateTime? ST_VISA_EXPIRY { get; internal set; }
        /// <summary>
        /// Notes on attempts to get parental approval [Alphanumeric: a200]
        /// </summary>
        public string ST_PARENTAL_APPROVAL_NOTE { get; internal set; }
        /// <summary>
        /// The Language other than English spoken at home by student, copied from ST record [Uppercase Alphanumeric: u7]
        /// </summary>
        public string ST_LOTE_HOME_CODE { get; internal set; }
        /// <summary>
        /// The language other than English spoken at home by adult A, copied from DF [Uppercase Alphanumeric: u7]
        /// </summary>
        public string DF_LOTE_HOME_CODE_A { get; internal set; }
        /// <summary>
        /// The language other than English spoken at home by adult B, copied from DF [Uppercase Alphanumeric: u7]
        /// </summary>
        public string DF_LOTE_HOME_CODE_B { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SKEY] => [ST_Entity].[STKEY]
        /// Student key
        /// </summary>
        public ST_Entity SKEY_ST {
            get
            {
                if (SKEY != null)
                {
                    if (_SKEY_ST == null)
                    {
                        _SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                    }
                    return _SKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_SCHOOL_YEAR] => [KCY_Entity].[KCYKEY]
        /// Year Level at time of leaving
        /// </summary>
        public KCY_Entity ST_SCHOOL_YEAR_KCY {
            get
            {
                if (ST_SCHOOL_YEAR != null)
                {
                    if (_ST_SCHOOL_YEAR_KCY == null)
                    {
                        _ST_SCHOOL_YEAR_KCY = Context.KCY.FindByKCYKEY(ST_SCHOOL_YEAR);
                    }
                    return _ST_SCHOOL_YEAR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_HOME_GROUP] => [KGC_Entity].[KGCKEY]
        /// Home Group at time of leaving
        /// </summary>
        public KGC_Entity ST_HOME_GROUP_KGC {
            get
            {
                if (ST_HOME_GROUP != null)
                {
                    if (_ST_HOME_GROUP_KGC == null)
                    {
                        _ST_HOME_GROUP_KGC = Context.KGC.FindByKGCKEY(ST_HOME_GROUP);
                    }
                    return _ST_HOME_GROUP_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_PREVIOUS_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// Previous school attended
        /// </summary>
        public SKGS_Entity ST_PREVIOUS_SCHOOL_SKGS {
            get
            {
                if (ST_PREVIOUS_SCHOOL != null)
                {
                    if (_ST_PREVIOUS_SCHOOL_SKGS == null)
                    {
                        _ST_PREVIOUS_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ST_PREVIOUS_SCHOOL);
                    }
                    return _ST_PREVIOUS_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_VISA_SUBCLASS] => [KCV_Entity].[VISA_SUBCLASS]
        /// Visa Sub-class
        /// </summary>
        public KCV_Entity ST_VISA_SUBCLASS_KCV {
            get
            {
                if (ST_VISA_SUBCLASS != null)
                {
                    if (_ST_VISA_SUBCLASS_KCV == null)
                    {
                        _ST_VISA_SUBCLASS_KCV = Context.KCV.FindByVISA_SUBCLASS(ST_VISA_SUBCLASS);
                    }
                    return _ST_VISA_SUBCLASS_KCV;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_HOME_LANG] => [KGL_Entity].[KGLKEY]
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// </summary>
        public KGL_Entity ST_HOME_LANG_KGL {
            get
            {
                if (ST_HOME_LANG != null)
                {
                    if (_ST_HOME_LANG_KGL == null)
                    {
                        _ST_HOME_LANG_KGL = Context.KGL.FindByKGLKEY(ST_HOME_LANG);
                    }
                    return _ST_HOME_LANG_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Student's home campus
        /// </summary>
        public SCI_Entity ST_CAMPUS_SCI {
            get
            {
                if (ST_CAMPUS.HasValue)
                {
                    if (_ST_CAMPUS_SCI == null)
                    {
                        _ST_CAMPUS_SCI = Context.SCI.FindBySCIKEY(ST_CAMPUS.Value);
                    }
                    return _ST_CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STPT_SCHL_NUM01] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM01_SKGS {
            get
            {
                if (STPT_SCHL_NUM01 != null)
                {
                    if (_STPT_SCHL_NUM01_SKGS == null)
                    {
                        _STPT_SCHL_NUM01_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM01);
                    }
                    return _STPT_SCHL_NUM01_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STPT_SCHL_NUM02] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM02_SKGS {
            get
            {
                if (STPT_SCHL_NUM02 != null)
                {
                    if (_STPT_SCHL_NUM02_SKGS == null)
                    {
                        _STPT_SCHL_NUM02_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM02);
                    }
                    return _STPT_SCHL_NUM02_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STPT_SCHL_NUM03] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM03_SKGS {
            get
            {
                if (STPT_SCHL_NUM03 != null)
                {
                    if (_STPT_SCHL_NUM03_SKGS == null)
                    {
                        _STPT_SCHL_NUM03_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM03);
                    }
                    return _STPT_SCHL_NUM03_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STPT_SCHL_NUM04] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM04_SKGS {
            get
            {
                if (STPT_SCHL_NUM04 != null)
                {
                    if (_STPT_SCHL_NUM04_SKGS == null)
                    {
                        _STPT_SCHL_NUM04_SKGS = Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM04);
                    }
                    return _STPT_SCHL_NUM04_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_NEXT_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// School to which departed student has gone (if any)
        /// </summary>
        public SKGS_Entity ST_NEXT_SCHOOL_SKGS {
            get
            {
                if (ST_NEXT_SCHOOL != null)
                {
                    if (_ST_NEXT_SCHOOL_SKGS == null)
                    {
                        _ST_NEXT_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ST_NEXT_SCHOOL);
                    }
                    return _ST_NEXT_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_LOTE_HOME_CODE] => [KGL_Entity].[KGLKEY]
        /// The Language other than English spoken at home by student, copied from ST record
        /// </summary>
        public KGL_Entity ST_LOTE_HOME_CODE_KGL {
            get
            {
                if (ST_LOTE_HOME_CODE != null)
                {
                    if (_ST_LOTE_HOME_CODE_KGL == null)
                    {
                        _ST_LOTE_HOME_CODE_KGL = Context.KGL.FindByKGLKEY(ST_LOTE_HOME_CODE);
                    }
                    return _ST_LOTE_HOME_CODE_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DF_LOTE_HOME_CODE_A] => [KGL_Entity].[KGLKEY]
        /// The language other than English spoken at home by adult A, copied from DF
        /// </summary>
        public KGL_Entity DF_LOTE_HOME_CODE_A_KGL {
            get
            {
                if (DF_LOTE_HOME_CODE_A != null)
                {
                    if (_DF_LOTE_HOME_CODE_A_KGL == null)
                    {
                        _DF_LOTE_HOME_CODE_A_KGL = Context.KGL.FindByKGLKEY(DF_LOTE_HOME_CODE_A);
                    }
                    return _DF_LOTE_HOME_CODE_A_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DF_LOTE_HOME_CODE_B] => [KGL_Entity].[KGLKEY]
        /// The language other than English spoken at home by adult B, copied from DF
        /// </summary>
        public KGL_Entity DF_LOTE_HOME_CODE_B_KGL {
            get
            {
                if (DF_LOTE_HOME_CODE_B != null)
                {
                    if (_DF_LOTE_HOME_CODE_B_KGL == null)
                    {
                        _DF_LOTE_HOME_CODE_B_KGL = Context.KGL.FindByKGLKEY(DF_LOTE_HOME_CODE_B);
                    }
                    return _DF_LOTE_HOME_CODE_B_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
