using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Students
    /// </summary>
    public class ST_Entity : EntityBase
    {
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First given name [Alphanumeric: a20]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second given name [Alphanumeric: a20]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Preferred name [Alphanumeric: a20]
        /// </summary>
        public string PREF_NAME { get; internal set; }
        /// <summary>
        /// Title (eg Mr, Ms) [Titlecase: t4]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Student's prime family [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Navigation property for [FAMILY] => [DF_Entity].[DFKEY]
        /// Student's prime family
        /// </summary>
        public DF_Entity FAMILY_DF { get { return FAMILY == null ? null : Context.DF.FindByDFKEY(FAMILY); } }
        /// <summary>
        /// Does the prime family receive academic reports? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACADEMIC_A { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_A { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in prime family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_A01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in prime family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_A02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT_A { get; internal set; }
        /// <summary>
        /// Student's alternative family [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMB { get; internal set; }
        /// <summary>
        /// Navigation property for [FAMB] => [DF_Entity].[DFKEY]
        /// Student's alternative family
        /// </summary>
        public DF_Entity FAMB_DF { get { return FAMB == null ? null : Context.DF.FindByDFKEY(FAMB); } }
        /// <summary>
        /// Does the alternative family receive academic reports? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACADEMIC_B { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_B { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in alternative family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_B01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in alternative family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_B02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT_B { get; internal set; }
        /// <summary>
        /// Student's additional contact family [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMC { get; internal set; }
        /// <summary>
        /// Navigation property for [FAMC] => [DF_Entity].[DFKEY]
        /// Student's additional contact family
        /// </summary>
        public DF_Entity FAMC_DF { get { return FAMC == null ? null : Context.DF.FindByDFKEY(FAMC); } }
        /// <summary>
        /// Does the additional contact family receive academic reports? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACADEMIC_C { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_C { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in additional contact family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_C01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in additional contact family [Alphanumeric: a20]
        /// </summary>
        public string RELATION_C02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT_C { get; internal set; }
        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIVING_ARR { get; internal set; }
        /// <summary>
        /// Distance to school [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DIST_SCHL { get; internal set; }
        /// <summary>
        /// Normal mode of transport (Walking/Bicycle/School Bus/Public Bus/Train/Tram/Driven/Self driven/Taxi/Other) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSPORT { get; internal set; }
        /// <summary>
        /// Registration of car if self driven [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CAR_REGO { get; internal set; }
        /// <summary>
        /// E-mail address [Alphanumeric: a60]
        /// </summary>
        public string E_MAIL { get; internal set; }
        /// <summary>
        /// Student mobile telephone number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MAP_TYPE { get; internal set; }
        /// <summary>
        /// (Was MELWAY_PAGE) Map no (MELWAY or other) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAP_NUM { get; internal set; }
        /// <summary>
        /// (Was MELWAY_GRID_X) Horizontal grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string X_AXIS { get; internal set; }
        /// <summary>
        /// (Was MELWAY_GRID_Y) Vertical grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string Y_AXIS { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int REGISTRATION { get; internal set; }
        /// <summary>
        /// Unique ID across state (School ID+REGISTRATION) - Now redundant Aegis 7401 [Uppercase Alphanumeric: u15]
        /// </summary>
        public string FIRST_REG_NO { get; internal set; }
        /// <summary>
        /// Student Gender [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Date of birth [Date Time nullable: d]
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Proof of birthdate sighted? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PROOF_DOB { get; internal set; }
        /// <summary>
        /// Australian residence status: P=Permanent, T=Temporary [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RESIDENT_STATUS { get; internal set; }
        /// <summary>
        /// Basis of Australian permanent residence status: E=Eligible for Australian passport, A=Holds Australian passport, P=Holds permanent residency visa [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERMANENT_BASIS { get; internal set; }
        /// <summary>
        /// Date of entry to school [Date Time nullable: d]
        /// </summary>
        public DateTime? ENTRY { get; internal set; }
        /// <summary>
        /// Date of exit from school [Date Time nullable: d]
        /// </summary>
        public DateTime? EXIT_DATE { get; internal set; }
        /// <summary>
        /// Date of arrival in or return to Australia (BLANK if born in Australia!) [Date Time nullable: d]
        /// </summary>
        public DateTime? ARRIVAL { get; internal set; }
        /// <summary>
        /// Date of first enrolment in an Australian school (Triggered if PREVIOUS_SCHOOL filled OR defaults to ENTRY) [Date Time nullable: d]
        /// </summary>
        public DateTime? AUSSIE_SCHOOL { get; internal set; }
        /// <summary>
        /// Aide required to assist integration into school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTEGRATION { get; internal set; }
        /// <summary>
        /// Date when TAG when tag set to LEFT or * when student delinked from FAMILY (generally not used but software required) [Date Time nullable: d]
        /// </summary>
        public DateTime? DATELEFT { get; internal set; }
        /// <summary>
        /// Expiry date for ID card only [Date Time nullable: d]
        /// </summary>
        public DateTime? EXPIRY_DATE { get; internal set; }
        /// <summary>
        /// Is ID card valid? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ID_CARD_VALID { get; internal set; }
        /// <summary>
        /// (Was PREVIOUS) Previous school attended [Uppercase Alphanumeric: u8]
        /// </summary>
        public string PREVIOUS_SCHOOL { get; internal set; }
        /// <summary>
        /// Navigation property for [PREVIOUS_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// (Was PREVIOUS) Previous school attended
        /// </summary>
        public SKGS_Entity PREVIOUS_SCHOOL_SKGS { get { return PREVIOUS_SCHOOL == null ? null : Context.SKGS.FindBySCHOOL(PREVIOUS_SCHOOL); } }
        /// <summary>
        /// Order in family (automatically maintained by software) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FAM_ORDER { get; internal set; }
        /// <summary>
        /// Notes - any general purpose [Memo: m]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SGB_FUNDED { get; internal set; }
        /// <summary>
        /// Is this student an applicant for, or in receipt of, EMA? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ED_ALLOW { get; internal set; }
        /// <summary>
        /// EMA amount paid in Semester 1 [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? EMA_AMT1P { get; internal set; }
        /// <summary>
        /// EMA amount paid in Semester 2 [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? EMA_AMT2P { get; internal set; }
        /// <summary>
        /// EMA identifier for existing students [Alphanumeric: a10]
        /// </summary>
        public string CASES_EMA_ID { get; internal set; }
        /// <summary>
        /// Student status: Active, Inactive, Future, Left school, Delete [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Classifies students into groups for timetabling (use calendar yr of yr 6 or yr 12):if LEFT or *,student not considered a sibling of family for fee determination [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG { get; internal set; }
        /// <summary>
        /// Curent year of enrolment - set by student promotion [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ENROLMENT_YEAR { get; internal set; }
        /// <summary>
        /// Advance a year level? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ADV_SCHL_YR { get; internal set; }
        /// <summary>
        /// (Was FORM) Student's home group [Uppercase Alphanumeric: u3]
        /// </summary>
        public string HOME_GROUP { get; internal set; }
        /// <summary>
        /// Navigation property for [HOME_GROUP] => [KGC_Entity].[KGCKEY]
        /// (Was FORM) Student's home group
        /// </summary>
        public KGC_Entity HOME_GROUP_KGC { get { return HOME_GROUP == null ? null : Context.KGC.FindByKGCKEY(HOME_GROUP); } }
        /// <summary>
        /// Anticipated next home group [Uppercase Alphanumeric: u3]
        /// </summary>
        public string NEXT_HG { get; internal set; }
        /// <summary>
        /// Navigation property for [NEXT_HG] => [KGC_Entity].[KGCKEY]
        /// Anticipated next home group
        /// </summary>
        public KGC_Entity NEXT_HG_KGC { get { return NEXT_HG == null ? null : Context.KGC.FindByKGCKEY(NEXT_HG); } }
        /// <summary>
        /// Year level [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// Navigation property for [SCHOOL_YEAR] => [KCY_Entity].[KCYKEY]
        /// Year level
        /// </summary>
        public KCY_Entity SCHOOL_YEAR_KCY { get { return SCHOOL_YEAR == null ? null : Context.KCY.FindByKCYKEY(SCHOOL_YEAR); } }
        /// <summary>
        /// Student's house group [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HOUSE { get; internal set; }
        /// <summary>
        /// Navigation property for [HOUSE] => [KGH_Entity].[KGHKEY]
        /// Student's house group
        /// </summary>
        public KGH_Entity HOUSE_KGH { get { return HOUSE == null ? null : Context.KGH.FindByKGHKEY(HOUSE); } }
        /// <summary>
        /// Student's home campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Student's home campus
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        ///  [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LOCKER_NUM { get; internal set; }
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
        /// Link to Religious Instruction Course [Uppercase Alphanumeric: u10]
        /// </summary>
        public string REL_INSTR { get; internal set; }
        /// <summary>
        /// Navigation property for [REL_INSTR] => [KCI_Entity].[KCIKEY]
        /// Link to Religious Instruction Course
        /// </summary>
        public KCI_Entity REL_INSTR_KCI { get { return REL_INSTR == null ? null : Context.KCI.FindByKCIKEY(REL_INSTR); } }
        /// <summary>
        /// External exam code (BoS no): possibly not required [Uppercase Alphanumeric: u10]
        /// </summary>
        public string VCE_ID { get; internal set; }
        /// <summary>
        /// Visa Sub-class [Uppercase Alphanumeric: u3]
        /// </summary>
        public string VISA_SUBCLASS { get; internal set; }
        /// <summary>
        /// Navigation property for [VISA_SUBCLASS] => [KCV_Entity].[VISA_SUBCLASS]
        /// Visa Sub-class
        /// </summary>
        public KCV_Entity VISA_SUBCLASS_KCV { get { return VISA_SUBCLASS == null ? null : Context.KCV.FindByVISA_SUBCLASS(VISA_SUBCLASS); } }
        /// <summary>
        /// Visa statistical code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string VISA_STAT_CODE { get; internal set; }
        /// <summary>
        /// Visa expiry date [Date Time nullable: d]
        /// </summary>
        public DateTime? VISA_EXPIRY { get; internal set; }
        /// <summary>
        /// Repeating student [Uppercase Alphanumeric: u1]
        /// </summary>
        public string REPEAT { get; internal set; }
        /// <summary>
        /// Country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY] => [KGT_Entity].[COUNTRY]
        /// Country of birth
        /// </summary>
        public KGT_Entity BIRTH_COUNTRY_KGT { get { return BIRTH_COUNTRY == null ? null : Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY); } }
        /// <summary>
        /// Student speaks English? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENG_SPEAK { get; internal set; }
        /// <summary>
        /// The language spoken at home: copied from DF record of family with whom student lives most [Uppercase Alphanumeric: u7]
        /// </summary>
        public string HOME_LANG { get; internal set; }
        /// <summary>
        /// Navigation property for [HOME_LANG] => [KGL_Entity].[KGLKEY]
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// </summary>
        public KGL_Entity HOME_LANG_KGL { get { return HOME_LANG == null ? null : Context.KGL.FindByKGLKEY(HOME_LANG); } }
        /// <summary>
        /// Born overseas? (Y/N): set to Y if ST.BIRTH_COUNTRY <> "1101": if Y then ARRIVAL is requested [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OVERSEAS { get; internal set; }
        /// <summary>
        /// Indigenous background: K=Aboriginal, T=Torres Strait Islander, B=Both Aboriginal and Torres Strait Islander, N=No indigenous background, X=Declined to Respond [Uppercase Alphanumeric: u1]
        /// </summary>
        public string KOORIE { get; internal set; }
        /// <summary>
        /// Youth allowance (<25) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string YOUTH_ALLOW { get; internal set; }
        /// <summary>
        /// Receives aboriginal allowance [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AB_STUDY { get; internal set; }
        /// <summary>
        /// Restricted access memo [Memo: m]
        /// </summary>
        public string ACCESS { get; internal set; }
        /// <summary>
        /// Type of access restriction [Uppercase Alphanumeric: u20]
        /// </summary>
        public string ACCESS_TYPE { get; internal set; }
        /// <summary>
        /// Access alert? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACCESS_ALERT { get; internal set; }
        /// <summary>
        /// Access alert? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RISK_ALERT { get; internal set; }
        /// <summary>
        /// Restricted risk memo [Memo: m]
        /// </summary>
        public string RISK_MEMO { get; internal set; }
        /// <summary>
        /// Student's regular medical practitioner [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DOCTOR { get; internal set; }
        /// <summary>
        /// Navigation property for [DOCTOR] => [KCD_Entity].[KCDKEY]
        /// Student's regular medical practitioner
        /// </summary>
        public KCD_Entity DOCTOR_KCD { get { return DOCTOR == null ? null : Context.KCD.FindByKCDKEY(DOCTOR); } }
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
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
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
        /// School has received authority to react to accident? (Y/N) (held on DF and copied here on creation) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACC_DECLARATION { get; internal set; }
        /// <summary>
        /// No longer used, the Ambulance field on DF should be used [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AMBULANCE_SUBSCRIBER { get; internal set; }
        /// <summary>
        /// Medicare No (held on DF and copied here on creation) [Uppercase Alphanumeric: u12]
        /// </summary>
        public string MEDICARE_NO { get; internal set; }
        /// <summary>
        /// International Student Id (7 Numeric) [Uppercase Alphanumeric: u7]
        /// </summary>
        public string INTERNATIONAL_ST_ID { get; internal set; }
        /// <summary>
        /// Student has disability? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DISABILITY { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u6]
        /// </summary>
        public string DISABILITY_ID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PSDREQ { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HEARING_IMPAIR { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string VISUAL_IMPAIR { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SPEECH_IMPAIR { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PHYSICAL_IMPAIR { get; internal set; }
        /// <summary>
        /// Medical alert flag (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MEDICAL_ALERT { get; internal set; }
        /// <summary>
        /// Is there an associated SMC record? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MEDICAL_CONDITION { get; internal set; }
        /// <summary>
        /// Activity restriction which may affect group membership [Memo: m]
        /// </summary>
        public string ACTIVITY_RESTRICTION { get; internal set; }
        /// <summary>
        /// C = complete, I = Incomplete, N = Not Sighted [Alphanumeric: a1]
        /// </summary>
        public string IMMUNISE_CERT_STATUS { get; internal set; }
        /// <summary>
        /// Immunisation certificate sighted? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string IMMUN_CERT_SIGHTED { get; internal set; }
        /// <summary>
        /// Overall Immunisation status [Uppercase Alphanumeric: u1]
        /// </summary>
        public string IMMUNIZE { get; internal set; }
        /// <summary>
        /// Disability type & adjustment level assessed? (Y/N) - Default value: blank [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DISABILITY_ADJUSTMENT_ASSESSED { get; internal set; }
        /// <summary>
        /// Is the student provided with adjustments to address a disability Y/N? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DISABILITY_ADJUSTMENT { get; internal set; }
        /// <summary>
        /// P =Physical; C = Cognitive; S = Sensory; SE = Social/Emotional - Default value: blank [Alphanumeric: a2]
        /// </summary>
        public string DISABILITY_TYPE { get; internal set; }
        /// <summary>
        /// 0 = No adjustment; 1 = Supplementary; 2 = Substantial; 3 = Extensive - Default value: blank [Alphanumeric: a2]
        /// </summary>
        public string DISABILITY_ADJUSTMENT_LEVEL { get; internal set; }
        /// <summary>
        /// The last time that either the Type of Disability or Level of Adjustment had been updated [Date Time nullable: d]
        /// </summary>
        public DateTime? DISABILITY_ADJUSTMENT_LW_DATE { get; internal set; }
        /// <summary>
        /// Permission for a head lice check has been received Y/N or U= Unknown [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HEAD_LICE_CHECK { get; internal set; }
        /// <summary>
        /// Total number of days this student has been suspended [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ANNUAL_TOT { get; internal set; }
        /// <summary>
        /// Student picture [Picture (byte array): bp]
        /// </summary>
        public byte[] STUDENT_PIC { get; internal set; }
        /// <summary>
        /// OK to publish picture in media Y/N/U [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PUBLISH_PHOTO_MEDIA { get; internal set; }
        /// <summary>
        /// OK to publish picture in Ultranet Y/N [Alphanumeric: a1]
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
        /// Librarian clearance? (Y/N): internal use: simplifies the clearance of a student leaving the school [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LIBRARY_FLAG { get; internal set; }
        /// <summary>
        /// Registrar clearance? (Y/U/N): internal use: simplifies the clearance of a student leaving the school [Uppercase Alphanumeric: u1]
        /// </summary>
        public string REGISTRAR_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLEAR1_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLEAR2_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLEAR3_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLEAR4_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLEAR5_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CLEAR6_FLAG { get; internal set; }
        /// <summary>
        /// Progress of AR check on student leaving: -1=in progress, 0=OK, 1=error: receipt not posted to GL, 2=error: outstanding transactions, 3=1 & 2 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AR_STATUS { get; internal set; }
        /// <summary>
        /// Years of previous education [Integer (16bit signed nullable): i]
        /// </summary>
        public short? YEARS_PREVIOUS_EDUCATION { get; internal set; }
        /// <summary>
        /// Years of interruption to education [Integer (16bit signed nullable): i]
        /// </summary>
        public short? YEARS_INTERRUPTION_EDUCATION { get; internal set; }
        /// <summary>
        /// Language of previous schooling [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LANGUAGE_PREVIOUS_SCHOOLING { get; internal set; }
        /// <summary>
        /// Navigation property for [LANGUAGE_PREVIOUS_SCHOOLING] => [KGL_Entity].[KGLKEY]
        /// Language of previous schooling
        /// </summary>
        public KGL_Entity LANGUAGE_PREVIOUS_SCHOOLING_KGL { get { return LANGUAGE_PREVIOUS_SCHOOLING == null ? null : Context.KGL.FindByKGLKEY(LANGUAGE_PREVIOUS_SCHOOLING); } }
        /// <summary>
        /// School to which departed student has gone (if any) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string NEXT_SCHOOL { get; internal set; }
        /// <summary>
        /// Navigation property for [NEXT_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// School to which departed student has gone (if any)
        /// </summary>
        public SKGS_Entity NEXT_SCHOOL_SKGS { get { return NEXT_SCHOOL == null ? null : Context.SKGS.FindBySCHOOL(NEXT_SCHOOL); } }
        /// <summary>
        /// EXIT Category [Uppercase Alphanumeric: u2]
        /// </summary>
        public string EXIT_CAT01 { get; internal set; }
        /// <summary>
        /// Navigation property for [EXIT_CAT01] => [KGG_Entity].[KGGKEY]
        /// EXIT Category
        /// </summary>
        public KGG_Entity EXIT_CAT01_KGG { get { return EXIT_CAT01 == null ? null : Context.KGG.FindByKGGKEY(EXIT_CAT01); } }
        /// <summary>
        /// EXIT Category [Uppercase Alphanumeric: u2]
        /// </summary>
        public string EXIT_CAT02 { get; internal set; }
        /// <summary>
        /// Navigation property for [EXIT_CAT02] => [KGG_Entity].[KGGKEY]
        /// EXIT Category
        /// </summary>
        public KGG_Entity EXIT_CAT02_KGG { get { return EXIT_CAT02 == null ? null : Context.KGG.FindByKGGKEY(EXIT_CAT02); } }
        /// <summary>
        /// EXIT Destination [Uppercase Alphanumeric: u6]
        /// </summary>
        public string EXIT_DEST01 { get; internal set; }
        /// <summary>
        /// Navigation property for [EXIT_DEST01] => [KGD_Entity].[KGDKEY]
        /// EXIT Destination
        /// </summary>
        public KGD_Entity EXIT_DEST01_KGD { get { return EXIT_DEST01 == null ? null : Context.KGD.FindByKGDKEY(EXIT_DEST01); } }
        /// <summary>
        /// EXIT Destination [Uppercase Alphanumeric: u6]
        /// </summary>
        public string EXIT_DEST02 { get; internal set; }
        /// <summary>
        /// Navigation property for [EXIT_DEST02] => [KGD_Entity].[KGDKEY]
        /// EXIT Destination
        /// </summary>
        public KGD_Entity EXIT_DEST02_KGD { get { return EXIT_DEST02 == null ? null : Context.KGD.FindByKGDKEY(EXIT_DEST02); } }
        /// <summary>
        /// Last write date of EXIT_CAT and EXIT_DEST [Date Time nullable: d]
        /// </summary>
        public DateTime? EXIT_MODIFY_DATE01 { get; internal set; }
        /// <summary>
        /// Last write date of EXIT_CAT and EXIT_DEST [Date Time nullable: d]
        /// </summary>
        public DateTime? EXIT_MODIFY_DATE02 { get; internal set; }
        /// <summary>
        /// Full time? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FULLTIME { get; internal set; }
        /// <summary>
        /// Time fraction for SRP funding for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SGB_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Time fraction of student's attendance [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ACTUAL_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Planned arrival date at destination school [Date Time nullable: d]
        /// </summary>
        public DateTime? DEST_ARRIVAL_DATE { get; internal set; }
        /// <summary>
        /// Planned departure date from current school [Date Time nullable: d]
        /// </summary>
        public DateTime? DEPARTURE_DATE { get; internal set; }
        /// <summary>
        /// Notified start date at destination school [Date Time nullable: d]
        /// </summary>
        public DateTime? ARRIVED_DESTINATION { get; internal set; }
        /// <summary>
        /// Date destination school notified of transfer [Date Time nullable: d]
        /// </summary>
        public DateTime? NOTIFIED_DESTINATION { get; internal set; }
        /// <summary>
        /// Date VCE notified [Date Time nullable: d]
        /// </summary>
        public DateTime? VCE_NOTIFIED { get; internal set; }
        /// <summary>
        /// Exit form printed? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EXIT_FORM { get; internal set; }
        /// <summary>
        /// Transfer form printed? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSFER_FORM { get; internal set; }
        /// <summary>
        /// Date parental approval received for student to leave [Date Time nullable: d]
        /// </summary>
        public DateTime? PARENTAL_APPROVAL_DATE { get; internal set; }
        /// <summary>
        /// Notes on attempts to get parental approval [Memo: m]
        /// </summary>
        public string PARENTAL_APPROVAL_NOTE { get; internal set; }
        /// <summary>
        /// reason for exit if due to a natural disaster or pandemic [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DISASTER_EXIT_REASON { get; internal set; }
        /// <summary>
        /// Notes on student attendance/absence [Memo: m]
        /// </summary>
        public string ATTENDANCE_MEMO { get; internal set; }
        /// <summary>
        /// Flag student as half day or period attendance [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ABS_HDAY_PERIOD { get; internal set; }
        /// <summary>
        /// Flag student as re-enrolled (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STRE_FLAG { get; internal set; }
        /// <summary>
        /// Temporary flag used to suppress history trigger during promotion procedure [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PROMOTED { get; internal set; }
        /// <summary>
        /// Code used to populate attendance records whilst status is INACtive. [Integer (16bit signed nullable): i]
        /// </summary>
        public short? INAC_ABS_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [INAC_ABS_CODE] => [KCT_Entity].[KCTKEY]
        /// Code used to populate attendance records whilst status is INACtive.
        /// </summary>
        public KCT_Entity INAC_ABS_CODE_KCT { get { return INAC_ABS_CODE.HasValue ? Context.KCT.FindByKCTKEY(INAC_ABS_CODE.Value) : null; } }
        /// <summary>
        /// The Language other than English spoken at home by student [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LOTE_HOME_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [LOTE_HOME_CODE] => [KGL_Entity].[KGLKEY]
        /// The Language other than English spoken at home by student
        /// </summary>
        public KGL_Entity LOTE_HOME_CODE_KGL { get { return LOTE_HOME_CODE == null ? null : Context.KGL.FindByKGLKEY(LOTE_HOME_CODE); } }
        /// <summary>
        /// Victorian Studant Number [Uppercase Alphanumeric: u12]
        /// </summary>
        public string VSN { get; internal set; }
        /// <summary>
        /// Specialised curriculum RE = Reggio Emilia, S = Steiner, M = Montessori, IB = International Baccalaureate [Uppercase Alphanumeric: u2]
        /// </summary>
        public string SPEC_CURR { get; internal set; }
        /// <summary>
        /// Has transition to prep statemnt been sighted Y=Yes, N=No, U=Unspecified [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSITION_STATEMENT { get; internal set; }
        /// <summary>
        /// Used for SDT - Parent given school permission to transfer student electronically. [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TFR_PERMISSION { get; internal set; }
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
