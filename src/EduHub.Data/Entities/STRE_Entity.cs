using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Re-Enrolment
    /// </summary>
    public class STRE_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SKEY] => [ST_Entity].[STKEY]
        /// Student key
        /// </summary>
        public ST_Entity SKEY_ST { get { return SKEY == null ? null : Context.ST.FindBySTKEY(SKEY); } }
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
        /// Navigation property for [ST_SCHOOL_YEAR] => [KCY_Entity].[KCYKEY]
        /// Year Level at time of leaving
        /// </summary>
        public KCY_Entity ST_SCHOOL_YEAR_KCY { get { return ST_SCHOOL_YEAR == null ? null : Context.KCY.FindByKCYKEY(ST_SCHOOL_YEAR); } }
        /// <summary>
        /// Home Group at time of leaving [Uppercase Alphanumeric: u3]
        /// </summary>
        public string ST_HOME_GROUP { get; internal set; }
        /// <summary>
        /// Navigation property for [ST_HOME_GROUP] => [KGC_Entity].[KGCKEY]
        /// Home Group at time of leaving
        /// </summary>
        public KGC_Entity ST_HOME_GROUP_KGC { get { return ST_HOME_GROUP == null ? null : Context.KGC.FindByKGCKEY(ST_HOME_GROUP); } }
        /// <summary>
        /// Previous school attended [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ST_PREVIOUS_SCHOOL { get; internal set; }
        /// <summary>
        /// Navigation property for [ST_PREVIOUS_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// Previous school attended
        /// </summary>
        public SKGS_Entity ST_PREVIOUS_SCHOOL_SKGS { get { return ST_PREVIOUS_SCHOOL == null ? null : Context.SKGS.FindBySCHOOL(ST_PREVIOUS_SCHOOL); } }
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
        /// Navigation property for [ST_VISA_SUBCLASS] => [KCV_Entity].[VISA_SUBCLASS]
        /// Visa Sub-class
        /// </summary>
        public KCV_Entity ST_VISA_SUBCLASS_KCV { get { return ST_VISA_SUBCLASS == null ? null : Context.KCV.FindByVISA_SUBCLASS(ST_VISA_SUBCLASS); } }
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
        /// Navigation property for [ST_HOME_LANG] => [KGL_Entity].[KGLKEY]
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// </summary>
        public KGL_Entity ST_HOME_LANG_KGL { get { return ST_HOME_LANG == null ? null : Context.KGL.FindByKGLKEY(ST_HOME_LANG); } }
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
        /// Navigation property for [ST_CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Student's home campus
        /// </summary>
        public SCI_Entity ST_CAMPUS_SCI { get { return ST_CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(ST_CAMPUS.Value) : null; } }
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
        /// Navigation property for [STPT_SCHL_NUM01] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM01_SKGS { get { return STPT_SCHL_NUM01 == null ? null : Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM01); } }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string STPT_SCHL_NUM02 { get; internal set; }
        /// <summary>
        /// Navigation property for [STPT_SCHL_NUM02] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM02_SKGS { get { return STPT_SCHL_NUM02 == null ? null : Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM02); } }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string STPT_SCHL_NUM03 { get; internal set; }
        /// <summary>
        /// Navigation property for [STPT_SCHL_NUM03] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM03_SKGS { get { return STPT_SCHL_NUM03 == null ? null : Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM03); } }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string STPT_SCHL_NUM04 { get; internal set; }
        /// <summary>
        /// Navigation property for [STPT_SCHL_NUM04] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity STPT_SCHL_NUM04_SKGS { get { return STPT_SCHL_NUM04 == null ? null : Context.SKGS.FindBySCHOOL(STPT_SCHL_NUM04); } }
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
        /// Navigation property for [ST_NEXT_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// School to which departed student has gone (if any)
        /// </summary>
        public SKGS_Entity ST_NEXT_SCHOOL_SKGS { get { return ST_NEXT_SCHOOL == null ? null : Context.SKGS.FindBySCHOOL(ST_NEXT_SCHOOL); } }
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
        /// Navigation property for [ST_LOTE_HOME_CODE] => [KGL_Entity].[KGLKEY]
        /// The Language other than English spoken at home by student, copied from ST record
        /// </summary>
        public KGL_Entity ST_LOTE_HOME_CODE_KGL { get { return ST_LOTE_HOME_CODE == null ? null : Context.KGL.FindByKGLKEY(ST_LOTE_HOME_CODE); } }
        /// <summary>
        /// The language other than English spoken at home by adult A, copied from DF [Uppercase Alphanumeric: u7]
        /// </summary>
        public string DF_LOTE_HOME_CODE_A { get; internal set; }
        /// <summary>
        /// Navigation property for [DF_LOTE_HOME_CODE_A] => [KGL_Entity].[KGLKEY]
        /// The language other than English spoken at home by adult A, copied from DF
        /// </summary>
        public KGL_Entity DF_LOTE_HOME_CODE_A_KGL { get { return DF_LOTE_HOME_CODE_A == null ? null : Context.KGL.FindByKGLKEY(DF_LOTE_HOME_CODE_A); } }
        /// <summary>
        /// The language other than English spoken at home by adult B, copied from DF [Uppercase Alphanumeric: u7]
        /// </summary>
        public string DF_LOTE_HOME_CODE_B { get; internal set; }
        /// <summary>
        /// Navigation property for [DF_LOTE_HOME_CODE_B] => [KGL_Entity].[KGLKEY]
        /// The language other than English spoken at home by adult B, copied from DF
        /// </summary>
        public KGL_Entity DF_LOTE_HOME_CODE_B_KGL { get { return DF_LOTE_HOME_CODE_B == null ? null : Context.KGL.FindByKGLKEY(DF_LOTE_HOME_CODE_B); } }
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
        
        
    }
}
