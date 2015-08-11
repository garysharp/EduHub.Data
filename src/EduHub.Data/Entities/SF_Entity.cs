using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff
    /// </summary>
    public class SF_Entity : EntityBase
    {
        /// <summary>
        /// Staff member code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SFKEY { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// Title: Mr, Ms, etc [Titlecase: t4]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// First given name [Alphanumeric: a20]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second given name [Alphanumeric: a20]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Preferred name [Alphanumeric: a15]
        /// </summary>
        public string PREF_NAME { get; internal set; }
        /// <summary>
        /// Previous surname if changed [Titlecase: t30]
        /// </summary>
        public string PREVIOUS_NAME { get; internal set; }
        /// <summary>
        /// Gender of staff member (M/F) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Date of Birth [Date Time nullable: d]
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Home address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? HOMEKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [HOMEKEY] => [UM_Entity].[UMKEY]
        /// Home address ID
        /// </summary>
        public UM_Entity HOMEKEY_UM { get { return HOMEKEY.HasValue ? Context.UM.FindByUMKEY(HOMEKEY.Value) : null; } }
        /// <summary>
        /// Mail address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MAILKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [MAILKEY] => [UM_Entity].[UMKEY]
        /// Mail address ID
        /// </summary>
        public UM_Entity MAILKEY_UM { get { return MAILKEY.HasValue ? Context.UM.FindByUMKEY(MAILKEY.Value) : null; } }
        /// <summary>
        /// Mobile phone [Uppercase Alphanumeric: u20]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Work phone [Alphanumeric: a20]
        /// </summary>
        public string WORK_PHONE { get; internal set; }
        /// <summary>
        /// E-mail address [Alphanumeric: a60]
        /// </summary>
        public string E_MAIL { get; internal set; }
        /// <summary>
        /// Victorian Institute of Teaching ID Number [Alphanumeric: a10]
        /// </summary>
        public string VIT_NO { get; internal set; }
        /// <summary>
        /// Start date at school [Date Time nullable: d]
        /// </summary>
        public DateTime? START { get; internal set; }
        /// <summary>
        /// Finished date at school [Date Time nullable: d]
        /// </summary>
        public DateTime? FINISH { get; internal set; }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY01 { get; internal set; }
        /// <summary>
        /// Navigation property for [FACULTY01] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY01_KSF { get { return FACULTY01 == null ? null : Context.KSF.FindByKSFKEY(FACULTY01); } }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY02 { get; internal set; }
        /// <summary>
        /// Navigation property for [FACULTY02] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY02_KSF { get { return FACULTY02 == null ? null : Context.KSF.FindByKSFKEY(FACULTY02); } }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY03 { get; internal set; }
        /// <summary>
        /// Navigation property for [FACULTY03] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY03_KSF { get { return FACULTY03 == null ? null : Context.KSF.FindByKSFKEY(FACULTY03); } }
        /// <summary>
        /// Faculty/ies [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY04 { get; internal set; }
        /// <summary>
        /// Navigation property for [FACULTY04] => [KSF_Entity].[KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF_Entity FACULTY04_KSF { get { return FACULTY04 == null ? null : Context.KSF.FindByKSFKEY(FACULTY04); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT01 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT01] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT01_SU { get { return SUBJECT01 == null ? null : Context.SU.FindBySUKEY(SUBJECT01); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT02 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT02] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT02_SU { get { return SUBJECT02 == null ? null : Context.SU.FindBySUKEY(SUBJECT02); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT03 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT03] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT03_SU { get { return SUBJECT03 == null ? null : Context.SU.FindBySUKEY(SUBJECT03); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT04 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT04] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT04_SU { get { return SUBJECT04 == null ? null : Context.SU.FindBySUKEY(SUBJECT04); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT05 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT05] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT05_SU { get { return SUBJECT05 == null ? null : Context.SU.FindBySUKEY(SUBJECT05); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT06 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT06] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT06_SU { get { return SUBJECT06 == null ? null : Context.SU.FindBySUKEY(SUBJECT06); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT07 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT07] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT07_SU { get { return SUBJECT07 == null ? null : Context.SU.FindBySUKEY(SUBJECT07); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT08 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT08] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT08_SU { get { return SUBJECT08 == null ? null : Context.SU.FindBySUKEY(SUBJECT08); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT09 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT09] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT09_SU { get { return SUBJECT09 == null ? null : Context.SU.FindBySUKEY(SUBJECT09); } }
        /// <summary>
        /// Subjects normally taken in priority sequence [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT10 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT10] => [SU_Entity].[SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU_Entity SUBJECT10_SU { get { return SUBJECT10 == null ? null : Context.SU.FindBySUKEY(SUBJECT10); } }
        /// <summary>
        /// Full time equivalent [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? FTE { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY01 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY02 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY03 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY04 { get; internal set; }
        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AVAILABILITY05 { get; internal set; }
        /// <summary>
        /// ? [Integer (16bit signed nullable): i]
        /// </summary>
        public short? RANK { get; internal set; }
        /// <summary>
        /// ID of home campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// ID of home campus
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        /// School house [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HOUSE { get; internal set; }
        /// <summary>
        /// Navigation property for [HOUSE] => [KGH_Entity].[KGHKEY]
        /// School house
        /// </summary>
        public KGH_Entity HOUSE_KGH { get { return HOUSE == null ? null : Context.KGH.FindByKGHKEY(HOUSE); } }
        /// <summary>
        /// Home teaching room [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Home teaching room
        /// </summary>
        public SM_Entity ROOM_SM { get { return ROOM == null ? null : Context.SM.FindByROOM(ROOM); } }
        /// <summary>
        /// Usual location when not teaching [Uppercase Alphanumeric: u4]
        /// </summary>
        public string OTHER_LOCATION { get; internal set; }
        /// <summary>
        /// Navigation property for [OTHER_LOCATION] => [SM_Entity].[ROOM]
        /// Usual location when not teaching
        /// </summary>
        public SM_Entity OTHER_LOCATION_SM { get { return OTHER_LOCATION == null ? null : Context.SM.FindByROOM(OTHER_LOCATION); } }
        /// <summary>
        /// Car registration number [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CAR_REGO { get; internal set; }
        /// <summary>
        /// Teacher available for timetabling: T=Available, N=Non-teacher, L=Left, U=Unavailable, E=Emergency [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STAFF_TYPE { get; internal set; }
        /// <summary>
        /// (Was POS_CODE) Reference to Staff Position (1) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string POS_CODE_A { get; internal set; }
        /// <summary>
        /// Navigation property for [POS_CODE_A] => [KSC_Entity].[KSCKEY]
        /// (Was POS_CODE) Reference to Staff Position (1)
        /// </summary>
        public KSC_Entity POS_CODE_A_KSC { get { return POS_CODE_A == null ? null : Context.KSC.FindByKSCKEY(POS_CODE_A); } }
        /// <summary>
        /// Reference to Staff Position (2) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string POS_CODE_B { get; internal set; }
        /// <summary>
        /// Navigation property for [POS_CODE_B] => [KSC_Entity].[KSCKEY]
        /// Reference to Staff Position (2)
        /// </summary>
        public KSC_Entity POS_CODE_B_KSC { get { return POS_CODE_B == null ? null : Context.KSC.FindByKSCKEY(POS_CODE_B); } }
        /// <summary>
        /// Teacher type (Permanent, Secondment, Volunteer, etc) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Staff status: Active,Left school [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF_STATUS { get; internal set; }
        /// <summary>
        /// Major area of teaching otherwise not available [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAJORA { get; internal set; }
        /// <summary>
        /// Navigation property for [MAJORA] => [KSA_Entity].[KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA_Entity MAJORA_KSA { get { return MAJORA == null ? null : Context.KSA.FindByKSAKEY(MAJORA); } }
        /// <summary>
        /// Major area of teaching otherwise not available [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAJORB { get; internal set; }
        /// <summary>
        /// Navigation property for [MAJORB] => [KSA_Entity].[KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA_Entity MAJORB_KSA { get { return MAJORB == null ? null : Context.KSA.FindByKSAKEY(MAJORB); } }
        /// <summary>
        /// Major area of teaching otherwise not available [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAJORC { get; internal set; }
        /// <summary>
        /// Navigation property for [MAJORC] => [KSA_Entity].[KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA_Entity MAJORC_KSA { get { return MAJORC == null ? null : Context.KSA.FindByKSAKEY(MAJORC); } }
        /// <summary>
        /// Details of any additional skills, etc [Memo: m]
        /// </summary>
        public string SKILL_QUALIFICATION { get; internal set; }
        /// <summary>
        /// Central payroll record number [Uppercase Alphanumeric: u9]
        /// </summary>
        public string PAYROLL_REC_NO { get; internal set; }
        /// <summary>
        /// Central payroll classification [Alphanumeric: a20]
        /// </summary>
        public string PAYROLL_CLASS { get; internal set; }
        /// <summary>
        /// Religion [Uppercase Alphanumeric: u12]
        /// </summary>
        public string RELIGION { get; internal set; }
        /// <summary>
        /// Navigation property for [RELIGION] => [KGR_Entity].[RELIGION]
        /// Religion
        /// </summary>
        public KGR_Entity RELIGION_KGR { get { return RELIGION == null ? null : Context.KGR.FindByRELIGION(RELIGION); } }
        /// <summary>
        /// Staff name to be used in reports [Alphanumeric: a30]
        /// </summary>
        public string REPORT_NAME { get; internal set; }
        /// <summary>
        /// Police clearance? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string POLICE_CLEARANCE { get; internal set; }
        /// <summary>
        /// Last police clearance date [Date Time nullable: d]
        /// </summary>
        public DateTime? CLEARANCE_DATE { get; internal set; }
        /// <summary>
        /// Staff Photograph [Picture (byte array): bp]
        /// </summary>
        public byte[] STAFF_PIC { get; internal set; }
        /// <summary>
        /// OK to publish picture Y/N [Alphanumeric: a1]
        /// </summary>
        public string OK_TO_PUBLISH { get; internal set; }
        /// <summary>
        /// Date/time of last change [Date Time nullable: d]
        /// </summary>
        public DateTime? PIC_LW_DATE { get; internal set; }
        /// <summary>
        /// N=New, R=Ready to upload, C=Copied [Alphanumeric: a1]
        /// </summary>
        public string PIC_STATUS { get; internal set; }
        /// <summary>
        /// Indicates which periods teacher is available for extras: used by Calendar [Available (byte array): ba]
        /// </summary>
        public byte[] AVAILABLE { get; internal set; }
        /// <summary>
        /// Maximum number of extras allowed in a year/term [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAX_EXTRAS { get; internal set; }
        /// <summary>
        /// No of extras already taken this year/term [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACC_EXTRAS { get; internal set; }
        /// <summary>
        /// No of extras already taken this cycle/week [Integer (16bit signed nullable): i]
        /// </summary>
        public short? WEEK_EXTRAS { get; internal set; }
        /// <summary>
        /// Last date an extra taken [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_EXTRAS { get; internal set; }
        /// <summary>
        /// (Was COUNTRY_BIRTH) Country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY] => [KGT_Entity].[COUNTRY]
        /// (Was COUNTRY_BIRTH) Country of birth
        /// </summary>
        public KGT_Entity BIRTH_COUNTRY_KGT { get { return BIRTH_COUNTRY == null ? null : Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY); } }
        /// <summary>
        /// Language(s) spoken by this staff member [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LANG01 { get; internal set; }
        /// <summary>
        /// Navigation property for [LANG01] => [KGL_Entity].[KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL_Entity LANG01_KGL { get { return LANG01 == null ? null : Context.KGL.FindByKGLKEY(LANG01); } }
        /// <summary>
        /// Language(s) spoken by this staff member [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LANG02 { get; internal set; }
        /// <summary>
        /// Navigation property for [LANG02] => [KGL_Entity].[KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL_Entity LANG02_KGL { get { return LANG02 == null ? null : Context.KGL.FindByKGLKEY(LANG02); } }
        /// <summary>
        /// Able and willing to act as interpreter [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER01 { get; internal set; }
        /// <summary>
        /// Able and willing to act as interpreter [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER02 { get; internal set; }
        /// <summary>
        /// Name(s) of person(s) to contact in an emergency [Titlecase: t30]
        /// </summary>
        public string EMERG_NAME01 { get; internal set; }
        /// <summary>
        /// Name(s) of person(s) to contact in an emergency [Titlecase: t30]
        /// </summary>
        public string EMERG_NAME02 { get; internal set; }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG01 { get; internal set; }
        /// <summary>
        /// Navigation property for [EMERG_LANG01] => [KGL_Entity].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL_Entity EMERG_LANG01_KGL { get { return EMERG_LANG01 == null ? null : Context.KGL.FindByKGLKEY(EMERG_LANG01); } }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG02 { get; internal set; }
        /// <summary>
        /// Navigation property for [EMERG_LANG02] => [KGL_Entity].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL_Entity EMERG_LANG02_KGL { get { return EMERG_LANG02 == null ? null : Context.KGL.FindByKGLKEY(EMERG_LANG02); } }
        /// <summary>
        /// Relationship to staff member of each person to contact in an emergency [Titlecase: t12]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }
        /// <summary>
        /// Relationship to staff member of each person to contact in an emergency [Titlecase: t12]
        /// </summary>
        public string EMERG_RELATION02 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT01 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT02 { get; internal set; }
        /// <summary>
        /// Is this staff member prepared to be in any special groups? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GROUP_AVAILABILITY { get; internal set; }
        /// <summary>
        /// Normal timetable load for this staff member [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }
        /// <summary>
        /// Y/N information regarding whether the employee records should be updated via HRMS import [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HRMS_UPDATE { get; internal set; }
        /// <summary>
        /// Last update from HRMS import [Date Time nullable: d]
        /// </summary>
        public DateTime? HRMS_DATETIME { get; internal set; }
        /// <summary>
        /// Link to sundry debtors [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DEBTOR_ID { get; internal set; }
        /// <summary>
        /// Navigation property for [DEBTOR_ID] => [DR_Entity].[DRKEY]
        /// Link to sundry debtors
        /// </summary>
        public DR_Entity DEBTOR_ID_DR { get { return DEBTOR_ID == null ? null : Context.DR.FindByDRKEY(DEBTOR_ID); } }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
