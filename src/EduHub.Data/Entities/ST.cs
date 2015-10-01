using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Students
    /// </summary>
    public class ST : EntityBase
    {
#region Navigation Property Cache
        private DF _FAMILY_DF;
        private DF _FAMB_DF;
        private DF _FAMC_DF;
        private SKGS _PREVIOUS_SCHOOL_SKGS;
        private KGC _HOME_GROUP_KGC;
        private KGC _NEXT_HG_KGC;
        private KCY _SCHOOL_YEAR_KCY;
        private KGH _HOUSE_KGH;
        private SCI _CAMPUS_SCI;
        private KGR _RELIGION_KGR;
        private KCI _REL_INSTR_KCI;
        private KCV _VISA_SUBCLASS_KCV;
        private KGT _BIRTH_COUNTRY_KGT;
        private KGL _HOME_LANG_KGL;
        private KCD _DOCTOR_KCD;
        private KGL _EMERG_LANG01_KGL;
        private KGL _EMERG_LANG02_KGL;
        private KGL _LANGUAGE_PREVIOUS_SCHOOLING_KGL;
        private SKGS _NEXT_SCHOOL_SKGS;
        private KGG _EXIT_CAT01_KGG;
        private KGG _EXIT_CAT02_KGG;
        private KGD _EXIT_DEST01_KGD;
        private KGD _EXIT_DEST02_KGD;
        private KCT _INAC_ABS_CODE_KCT;
        private KGL _LOTE_HOME_CODE_KGL;
#endregion

#region Field Properties
        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First given name
        /// [Alphanumeric (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second given name
        /// [Alphanumeric (20)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Preferred name
        /// [Alphanumeric (20)]
        /// </summary>
        public string PREF_NAME { get; internal set; }
        /// <summary>
        /// Title (eg Mr, Ms)
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Student's prime family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Does the prime family receive academic reports? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACADEMIC_A { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_A { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in prime family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_A01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in prime family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_A02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT_A { get; internal set; }
        /// <summary>
        /// Student's alternative family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMB { get; internal set; }
        /// <summary>
        /// Does the alternative family receive academic reports? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACADEMIC_B { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_B { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in alternative family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_B01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in alternative family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_B02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT_B { get; internal set; }
        /// <summary>
        /// Student's additional contact family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMC { get; internal set; }
        /// <summary>
        /// Does the additional contact family receive academic reports? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACADEMIC_C { get; internal set; }
        /// <summary>
        /// Living with (Always/Mostly/Balanced/Occasionally/Never)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_C { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in additional contact family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_C01 { get; internal set; }
        /// <summary>
        /// Relationships to Adults A and B in additional contact family
        /// [Alphanumeric (20)]
        /// </summary>
        public string RELATION_C02 { get; internal set; }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT_C { get; internal set; }
        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIVING_ARR { get; internal set; }
        /// <summary>
        /// Distance to school
        /// </summary>
        public double? DIST_SCHL { get; internal set; }
        /// <summary>
        /// Normal mode of transport (Walking/Bicycle/School Bus/Public Bus/Train/Tram/Driven/Self driven/Taxi/Other)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSPORT { get; internal set; }
        /// <summary>
        /// Registration of car if self driven
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CAR_REGO { get; internal set; }
        /// <summary>
        /// E-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string E_MAIL { get; internal set; }
        /// <summary>
        /// Student mobile telephone number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAP_TYPE { get; internal set; }
        /// <summary>
        /// (Was MELWAY_PAGE) Map no (MELWAY or other)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAP_NUM { get; internal set; }
        /// <summary>
        /// (Was MELWAY_GRID_X) Horizontal grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string X_AXIS { get; internal set; }
        /// <summary>
        /// (Was MELWAY_GRID_Y) Vertical grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string Y_AXIS { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int REGISTRATION { get; internal set; }
        /// <summary>
        /// Unique ID across state (School ID+REGISTRATION) - Now redundant Aegis 7401
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string FIRST_REG_NO { get; internal set; }
        /// <summary>
        /// Student Gender
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Proof of birthdate sighted? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PROOF_DOB { get; internal set; }
        /// <summary>
        /// Australian residence status: P=Permanent, T=Temporary
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESIDENT_STATUS { get; internal set; }
        /// <summary>
        /// Basis of Australian permanent residence status: E=Eligible for Australian passport, A=Holds Australian passport, P=Holds permanent residency visa
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERMANENT_BASIS { get; internal set; }
        /// <summary>
        /// Date of entry to school
        /// </summary>
        public DateTime? ENTRY { get; internal set; }
        /// <summary>
        /// Date of exit from school
        /// </summary>
        public DateTime? EXIT_DATE { get; internal set; }
        /// <summary>
        /// Date of arrival in or return to Australia (BLANK if born in Australia!)
        /// </summary>
        public DateTime? ARRIVAL { get; internal set; }
        /// <summary>
        /// Date of first enrolment in an Australian school (Triggered if PREVIOUS_SCHOOL filled OR defaults to ENTRY)
        /// </summary>
        public DateTime? AUSSIE_SCHOOL { get; internal set; }
        /// <summary>
        /// Aide required to assist integration into school? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTEGRATION { get; internal set; }
        /// <summary>
        /// Date when TAG when tag set to LEFT or * when student delinked from FAMILY (generally not used but software required)
        /// </summary>
        public DateTime? DATELEFT { get; internal set; }
        /// <summary>
        /// Expiry date for ID card only
        /// </summary>
        public DateTime? EXPIRY_DATE { get; internal set; }
        /// <summary>
        /// Is ID card valid? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ID_CARD_VALID { get; internal set; }
        /// <summary>
        /// (Was PREVIOUS) Previous school attended
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string PREVIOUS_SCHOOL { get; internal set; }
        /// <summary>
        /// Order in family (automatically maintained by software)
        /// </summary>
        public short? FAM_ORDER { get; internal set; }
        /// <summary>
        /// Notes - any general purpose
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SGB_FUNDED { get; internal set; }
        /// <summary>
        /// Is this student an applicant for, or in receipt of, CSEF? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ED_ALLOW { get; internal set; }
        /// <summary>
        /// CSEF amount paid in Semester 1
        /// </summary>
        public decimal? EMA_AMT1P { get; internal set; }
        /// <summary>
        /// CSEF amount paid in Semester 2
        /// </summary>
        public decimal? EMA_AMT2P { get; internal set; }
        /// <summary>
        /// CSEF identifier for existing students
        /// [Alphanumeric (10)]
        /// </summary>
        public string CASES_EMA_ID { get; internal set; }
        /// <summary>
        /// Student status: Active, Inactive, Future, Left school, Delete
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Classifies students into groups for timetabling (use calendar yr of yr 6 or yr 12):if LEFT or *,student not considered a sibling of family for fee determination
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG { get; internal set; }
        /// <summary>
        /// Curent year of enrolment - set by student promotion
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ENROLMENT_YEAR { get; internal set; }
        /// <summary>
        /// Advance a year level? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ADV_SCHL_YR { get; internal set; }
        /// <summary>
        /// (Was FORM) Student's home group
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string HOME_GROUP { get; internal set; }
        /// <summary>
        /// Anticipated next home group
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string NEXT_HG { get; internal set; }
        /// <summary>
        /// Year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// Student's house group
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HOUSE { get; internal set; }
        /// <summary>
        /// Student's home campus
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LOCKER_NUM { get; internal set; }
        /// <summary>
        /// Religion
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string RELIGION { get; internal set; }
        /// <summary>
        /// Link to Religious Instruction Course
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string REL_INSTR { get; internal set; }
        /// <summary>
        /// External exam code (BoS no): possibly not required
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string VCE_ID { get; internal set; }
        /// <summary>
        /// Visa Sub-class
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string VISA_SUBCLASS { get; internal set; }
        /// <summary>
        /// Visa statistical code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string VISA_STAT_CODE { get; internal set; }
        /// <summary>
        /// Visa expiry date
        /// </summary>
        public DateTime? VISA_EXPIRY { get; internal set; }
        /// <summary>
        /// Repeating student
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REPEAT { get; internal set; }
        /// <summary>
        /// Country of birth
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }
        /// <summary>
        /// Student speaks English? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENG_SPEAK { get; internal set; }
        /// <summary>
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string HOME_LANG { get; internal set; }
        /// <summary>
        /// Born overseas? (Y/N): set to Y if ST.BIRTH_COUNTRY &lt;&gt; "1101": if Y then ARRIVAL is requested
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OVERSEAS { get; internal set; }
        /// <summary>
        /// Indigenous background: K=Aboriginal, T=Torres Strait Islander, B=Both Aboriginal and Torres Strait Islander, N=No indigenous background, X=Declined to Respond
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string KOORIE { get; internal set; }
        /// <summary>
        /// Youth allowance (&lt;25)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string YOUTH_ALLOW { get; internal set; }
        /// <summary>
        /// Receives aboriginal allowance
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AB_STUDY { get; internal set; }
        /// <summary>
        /// Restricted access memo
        /// [Memo]
        /// </summary>
        public string ACCESS { get; internal set; }
        /// <summary>
        /// Type of access restriction
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ACCESS_TYPE { get; internal set; }
        /// <summary>
        /// Access alert? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACCESS_ALERT { get; internal set; }
        /// <summary>
        /// Access alert? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RISK_ALERT { get; internal set; }
        /// <summary>
        /// Restricted risk memo
        /// [Memo]
        /// </summary>
        public string RISK_MEMO { get; internal set; }
        /// <summary>
        /// Student's regular medical practitioner
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DOCTOR { get; internal set; }
        /// <summary>
        /// Name(s) of person(s) to contact in an emergency
        /// [Titlecase (30)]
        /// </summary>
        public string EMERG_NAME01 { get; internal set; }
        /// <summary>
        /// Name(s) of person(s) to contact in an emergency
        /// [Titlecase (30)]
        /// </summary>
        public string EMERG_NAME02 { get; internal set; }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string EMERG_LANG01 { get; internal set; }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string EMERG_LANG02 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency
        /// [Alphanumeric (11)]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency
        /// [Alphanumeric (11)]
        /// </summary>
        public string EMERG_RELATION02 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT01 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT02 { get; internal set; }
        /// <summary>
        /// School has received authority to react to accident? (Y/N) (held on DF and copied here on creation)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACC_DECLARATION { get; internal set; }
        /// <summary>
        /// No longer used, the Ambulance field on DF should be used
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AMBULANCE_SUBSCRIBER { get; internal set; }
        /// <summary>
        /// Medicare No (held on DF and copied here on creation)
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string MEDICARE_NO { get; internal set; }
        /// <summary>
        /// International Student Id (7 Numeric)
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string INTERNATIONAL_ST_ID { get; internal set; }
        /// <summary>
        /// Student has disability? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISABILITY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string DISABILITY_ID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PSDREQ { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HEARING_IMPAIR { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VISUAL_IMPAIR { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SPEECH_IMPAIR { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PHYSICAL_IMPAIR { get; internal set; }
        /// <summary>
        /// Medical alert flag (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICAL_ALERT { get; internal set; }
        /// <summary>
        /// Is there an associated SMC record? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEDICAL_CONDITION { get; internal set; }
        /// <summary>
        /// Activity restriction which may affect group membership
        /// [Memo]
        /// </summary>
        public string ACTIVITY_RESTRICTION { get; internal set; }
        /// <summary>
        /// C = complete, I = Incomplete, N = Not Sighted
        /// [Alphanumeric (1)]
        /// </summary>
        public string IMMUNISE_CERT_STATUS { get; internal set; }
        /// <summary>
        /// Immunisation certificate sighted? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string IMMUN_CERT_SIGHTED { get; internal set; }
        /// <summary>
        /// Permission for immunisation program Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string IMMUNISE_PERMISSION { get; internal set; }
        /// <summary>
        /// Overall Immunisation status
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string IMMUNIZE { get; internal set; }
        /// <summary>
        /// Disability type &amp; adjustment level assessed? (Y/N) - Default value: blank
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISABILITY_ADJUSTMENT_ASSESSED { get; internal set; }
        /// <summary>
        /// Is the student provided with adjustments to address a disability Y?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISABILITY_ADJUSTMENT { get; internal set; }
        /// <summary>
        /// C = Cognitive; P = Physical; S = Sensory; SE = Social/Emotional - Default value: blank
        /// [Alphanumeric (2)]
        /// </summary>
        public string DISABILITY_TYPE { get; internal set; }
        /// <summary>
        /// 1 = Quality differentiated teaching practice; 2 = Supplementary; 3 = Substantial; 4 = Extensive - Default value: blank
        /// [Alphanumeric (2)]
        /// </summary>
        public string DISABILITY_ADJUSTMENT_LEVEL { get; internal set; }
        /// <summary>
        /// The last time that either the Type of Disability or Level of Adjustment had been updated
        /// </summary>
        public DateTime? DISABILITY_ADJUSTMENT_LW_DATE { get; internal set; }
        /// <summary>
        /// Permission for a head lice check has been received Y/N or U= Unknown
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HEAD_LICE_CHECK { get; internal set; }
        /// <summary>
        /// Total number of days this student has been suspended
        /// </summary>
        public double? ANNUAL_TOT { get; internal set; }
        /// <summary>
        /// Student picture
        /// </summary>
        public byte[] STUDENT_PIC { get; internal set; }
        /// <summary>
        /// OK to publish picture in media Y/N/U
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PUBLISH_PHOTO_MEDIA { get; internal set; }
        /// <summary>
        /// OK to publish picture in Ultranet Y/N
        /// [Alphanumeric (1)]
        /// </summary>
        public string OK_TO_PUBLISH { get; internal set; }
        /// <summary>
        /// Date/time of last change
        /// </summary>
        public DateTime? PIC_LW_DATE { get; internal set; }
        /// <summary>
        /// N=New, R=Ready to upload, C=Copied
        /// [Alphanumeric (1)]
        /// </summary>
        public string PIC_STATUS { get; internal set; }
        /// <summary>
        /// Librarian clearance? (Y/N): internal use: simplifies the clearance of a student leaving the school
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LIBRARY_FLAG { get; internal set; }
        /// <summary>
        /// Registrar clearance? (Y/U/N): internal use: simplifies the clearance of a student leaving the school
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REGISTRAR_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLEAR1_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLEAR2_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLEAR3_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLEAR4_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLEAR5_FLAG { get; internal set; }
        /// <summary>
        /// One of a number of flags indicating clearance gained from various people
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLEAR6_FLAG { get; internal set; }
        /// <summary>
        /// Progress of AR check on student leaving: -1=in progress, 0=OK, 1=error: receipt not posted to GL, 2=error: outstanding transactions, 3=1 &amp; 2
        /// </summary>
        public short? AR_STATUS { get; internal set; }
        /// <summary>
        /// Years of previous education
        /// </summary>
        public short? YEARS_PREVIOUS_EDUCATION { get; internal set; }
        /// <summary>
        /// Years of interruption to education
        /// </summary>
        public short? YEARS_INTERRUPTION_EDUCATION { get; internal set; }
        /// <summary>
        /// Language of previous schooling
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LANGUAGE_PREVIOUS_SCHOOLING { get; internal set; }
        /// <summary>
        /// School to which departed student has gone (if any)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string NEXT_SCHOOL { get; internal set; }
        /// <summary>
        /// EXIT Category
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string EXIT_CAT01 { get; internal set; }
        /// <summary>
        /// EXIT Category
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string EXIT_CAT02 { get; internal set; }
        /// <summary>
        /// EXIT Destination
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string EXIT_DEST01 { get; internal set; }
        /// <summary>
        /// EXIT Destination
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string EXIT_DEST02 { get; internal set; }
        /// <summary>
        /// Last write date of EXIT_CAT and EXIT_DEST
        /// </summary>
        public DateTime? EXIT_MODIFY_DATE01 { get; internal set; }
        /// <summary>
        /// Last write date of EXIT_CAT and EXIT_DEST
        /// </summary>
        public DateTime? EXIT_MODIFY_DATE02 { get; internal set; }
        /// <summary>
        /// Full time? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FULLTIME { get; internal set; }
        /// <summary>
        /// Time fraction for SRP funding for current calendar year
        /// </summary>
        public double? SGB_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Time fraction of student's attendance
        /// </summary>
        public double? ACTUAL_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Planned arrival date at destination school
        /// </summary>
        public DateTime? DEST_ARRIVAL_DATE { get; internal set; }
        /// <summary>
        /// Planned departure date from current school
        /// </summary>
        public DateTime? DEPARTURE_DATE { get; internal set; }
        /// <summary>
        /// Notified start date at destination school
        /// </summary>
        public DateTime? ARRIVED_DESTINATION { get; internal set; }
        /// <summary>
        /// Date destination school notified of transfer
        /// </summary>
        public DateTime? NOTIFIED_DESTINATION { get; internal set; }
        /// <summary>
        /// Date VCE notified
        /// </summary>
        public DateTime? VCE_NOTIFIED { get; internal set; }
        /// <summary>
        /// Exit form printed? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EXIT_FORM { get; internal set; }
        /// <summary>
        /// Transfer form printed? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSFER_FORM { get; internal set; }
        /// <summary>
        /// Date parental approval received for student to leave
        /// </summary>
        public DateTime? PARENTAL_APPROVAL_DATE { get; internal set; }
        /// <summary>
        /// Notes on attempts to get parental approval
        /// [Memo]
        /// </summary>
        public string PARENTAL_APPROVAL_NOTE { get; internal set; }
        /// <summary>
        /// reason for exit if due to a natural disaster or pandemic
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISASTER_EXIT_REASON { get; internal set; }
        /// <summary>
        /// Notes on student attendance/absence
        /// [Memo]
        /// </summary>
        public string ATTENDANCE_MEMO { get; internal set; }
        /// <summary>
        /// Flag student as half day or period attendance
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ABS_HDAY_PERIOD { get; internal set; }
        /// <summary>
        /// Flag student as re-enrolled (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STRE_FLAG { get; internal set; }
        /// <summary>
        /// Temporary flag used to suppress history trigger during promotion procedure
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PROMOTED { get; internal set; }
        /// <summary>
        /// Code used to populate attendance records whilst status is INACtive.
        /// </summary>
        public short? INAC_ABS_CODE { get; internal set; }
        /// <summary>
        /// The Language other than English spoken at home by student
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LOTE_HOME_CODE { get; internal set; }
        /// <summary>
        /// Victorian Studant Number
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string VSN { get; internal set; }
        /// <summary>
        /// Specialised curriculum RE = Reggio Emilia, S = Steiner, M = Montessori, IB = International Baccalaureate
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SPEC_CURR { get; internal set; }
        /// <summary>
        /// Has transition to prep statemnt been sighted Y=Yes, N=No, U=Unspecified
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSITION_STATEMENT { get; internal set; }
        /// <summary>
        /// Used for SDT - Parent given school permission to transfer student electronically.
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TFR_PERMISSION { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [FAMILY] => [DF].[DFKEY]
        /// Student's prime family
        /// </summary>
        public DF FAMILY_DF {
            get
            {
                if (FAMILY != null)
                {
                    if (_FAMILY_DF == null)
                    {
                        _FAMILY_DF = Context.DF.FindByDFKEY(FAMILY);
                    }
                    return _FAMILY_DF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FAMB] => [DF].[DFKEY]
        /// Student's alternative family
        /// </summary>
        public DF FAMB_DF {
            get
            {
                if (FAMB != null)
                {
                    if (_FAMB_DF == null)
                    {
                        _FAMB_DF = Context.DF.FindByDFKEY(FAMB);
                    }
                    return _FAMB_DF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FAMC] => [DF].[DFKEY]
        /// Student's additional contact family
        /// </summary>
        public DF FAMC_DF {
            get
            {
                if (FAMC != null)
                {
                    if (_FAMC_DF == null)
                    {
                        _FAMC_DF = Context.DF.FindByDFKEY(FAMC);
                    }
                    return _FAMC_DF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PREVIOUS_SCHOOL] => [SKGS].[SCHOOL]
        /// (Was PREVIOUS) Previous school attended
        /// </summary>
        public SKGS PREVIOUS_SCHOOL_SKGS {
            get
            {
                if (PREVIOUS_SCHOOL != null)
                {
                    if (_PREVIOUS_SCHOOL_SKGS == null)
                    {
                        _PREVIOUS_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(PREVIOUS_SCHOOL);
                    }
                    return _PREVIOUS_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOME_GROUP] => [KGC].[KGCKEY]
        /// (Was FORM) Student's home group
        /// </summary>
        public KGC HOME_GROUP_KGC {
            get
            {
                if (HOME_GROUP != null)
                {
                    if (_HOME_GROUP_KGC == null)
                    {
                        _HOME_GROUP_KGC = Context.KGC.FindByKGCKEY(HOME_GROUP);
                    }
                    return _HOME_GROUP_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [NEXT_HG] => [KGC].[KGCKEY]
        /// Anticipated next home group
        /// </summary>
        public KGC NEXT_HG_KGC {
            get
            {
                if (NEXT_HG != null)
                {
                    if (_NEXT_HG_KGC == null)
                    {
                        _NEXT_HG_KGC = Context.KGC.FindByKGCKEY(NEXT_HG);
                    }
                    return _NEXT_HG_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCHOOL_YEAR] => [KCY].[KCYKEY]
        /// Year level
        /// </summary>
        public KCY SCHOOL_YEAR_KCY {
            get
            {
                if (SCHOOL_YEAR != null)
                {
                    if (_SCHOOL_YEAR_KCY == null)
                    {
                        _SCHOOL_YEAR_KCY = Context.KCY.FindByKCYKEY(SCHOOL_YEAR);
                    }
                    return _SCHOOL_YEAR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOUSE] => [KGH].[KGHKEY]
        /// Student's house group
        /// </summary>
        public KGH HOUSE_KGH {
            get
            {
                if (HOUSE != null)
                {
                    if (_HOUSE_KGH == null)
                    {
                        _HOUSE_KGH = Context.KGH.FindByKGHKEY(HOUSE);
                    }
                    return _HOUSE_KGH;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI].[SCIKEY]
        /// Student's home campus
        /// </summary>
        public SCI CAMPUS_SCI {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [RELIGION] => [KGR].[RELIGION]
        /// Religion
        /// </summary>
        public KGR RELIGION_KGR {
            get
            {
                if (RELIGION != null)
                {
                    if (_RELIGION_KGR == null)
                    {
                        _RELIGION_KGR = Context.KGR.FindByRELIGION(RELIGION);
                    }
                    return _RELIGION_KGR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [REL_INSTR] => [KCI].[KCIKEY]
        /// Link to Religious Instruction Course
        /// </summary>
        public KCI REL_INSTR_KCI {
            get
            {
                if (REL_INSTR != null)
                {
                    if (_REL_INSTR_KCI == null)
                    {
                        _REL_INSTR_KCI = Context.KCI.FindByKCIKEY(REL_INSTR);
                    }
                    return _REL_INSTR_KCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [VISA_SUBCLASS] => [KCV].[VISA_SUBCLASS]
        /// Visa Sub-class
        /// </summary>
        public KCV VISA_SUBCLASS_KCV {
            get
            {
                if (VISA_SUBCLASS != null)
                {
                    if (_VISA_SUBCLASS_KCV == null)
                    {
                        _VISA_SUBCLASS_KCV = Context.KCV.FindByVISA_SUBCLASS(VISA_SUBCLASS);
                    }
                    return _VISA_SUBCLASS_KCV;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY] => [KGT].[COUNTRY]
        /// Country of birth
        /// </summary>
        public KGT BIRTH_COUNTRY_KGT {
            get
            {
                if (BIRTH_COUNTRY != null)
                {
                    if (_BIRTH_COUNTRY_KGT == null)
                    {
                        _BIRTH_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY);
                    }
                    return _BIRTH_COUNTRY_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOME_LANG] => [KGL].[KGLKEY]
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// </summary>
        public KGL HOME_LANG_KGL {
            get
            {
                if (HOME_LANG != null)
                {
                    if (_HOME_LANG_KGL == null)
                    {
                        _HOME_LANG_KGL = Context.KGL.FindByKGLKEY(HOME_LANG);
                    }
                    return _HOME_LANG_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DOCTOR] => [KCD].[KCDKEY]
        /// Student's regular medical practitioner
        /// </summary>
        public KCD DOCTOR_KCD {
            get
            {
                if (DOCTOR != null)
                {
                    if (_DOCTOR_KCD == null)
                    {
                        _DOCTOR_KCD = Context.KCD.FindByKCDKEY(DOCTOR);
                    }
                    return _DOCTOR_KCD;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EMERG_LANG01] => [KGL].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG01_KGL {
            get
            {
                if (EMERG_LANG01 != null)
                {
                    if (_EMERG_LANG01_KGL == null)
                    {
                        _EMERG_LANG01_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG01);
                    }
                    return _EMERG_LANG01_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EMERG_LANG02] => [KGL].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG02_KGL {
            get
            {
                if (EMERG_LANG02 != null)
                {
                    if (_EMERG_LANG02_KGL == null)
                    {
                        _EMERG_LANG02_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG02);
                    }
                    return _EMERG_LANG02_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LANGUAGE_PREVIOUS_SCHOOLING] => [KGL].[KGLKEY]
        /// Language of previous schooling
        /// </summary>
        public KGL LANGUAGE_PREVIOUS_SCHOOLING_KGL {
            get
            {
                if (LANGUAGE_PREVIOUS_SCHOOLING != null)
                {
                    if (_LANGUAGE_PREVIOUS_SCHOOLING_KGL == null)
                    {
                        _LANGUAGE_PREVIOUS_SCHOOLING_KGL = Context.KGL.FindByKGLKEY(LANGUAGE_PREVIOUS_SCHOOLING);
                    }
                    return _LANGUAGE_PREVIOUS_SCHOOLING_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [NEXT_SCHOOL] => [SKGS].[SCHOOL]
        /// School to which departed student has gone (if any)
        /// </summary>
        public SKGS NEXT_SCHOOL_SKGS {
            get
            {
                if (NEXT_SCHOOL != null)
                {
                    if (_NEXT_SCHOOL_SKGS == null)
                    {
                        _NEXT_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(NEXT_SCHOOL);
                    }
                    return _NEXT_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXIT_CAT01] => [KGG].[KGGKEY]
        /// EXIT Category
        /// </summary>
        public KGG EXIT_CAT01_KGG {
            get
            {
                if (EXIT_CAT01 != null)
                {
                    if (_EXIT_CAT01_KGG == null)
                    {
                        _EXIT_CAT01_KGG = Context.KGG.FindByKGGKEY(EXIT_CAT01);
                    }
                    return _EXIT_CAT01_KGG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXIT_CAT02] => [KGG].[KGGKEY]
        /// EXIT Category
        /// </summary>
        public KGG EXIT_CAT02_KGG {
            get
            {
                if (EXIT_CAT02 != null)
                {
                    if (_EXIT_CAT02_KGG == null)
                    {
                        _EXIT_CAT02_KGG = Context.KGG.FindByKGGKEY(EXIT_CAT02);
                    }
                    return _EXIT_CAT02_KGG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXIT_DEST01] => [KGD].[KGDKEY]
        /// EXIT Destination
        /// </summary>
        public KGD EXIT_DEST01_KGD {
            get
            {
                if (EXIT_DEST01 != null)
                {
                    if (_EXIT_DEST01_KGD == null)
                    {
                        _EXIT_DEST01_KGD = Context.KGD.FindByKGDKEY(EXIT_DEST01);
                    }
                    return _EXIT_DEST01_KGD;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXIT_DEST02] => [KGD].[KGDKEY]
        /// EXIT Destination
        /// </summary>
        public KGD EXIT_DEST02_KGD {
            get
            {
                if (EXIT_DEST02 != null)
                {
                    if (_EXIT_DEST02_KGD == null)
                    {
                        _EXIT_DEST02_KGD = Context.KGD.FindByKGDKEY(EXIT_DEST02);
                    }
                    return _EXIT_DEST02_KGD;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [INAC_ABS_CODE] => [KCT].[KCTKEY]
        /// Code used to populate attendance records whilst status is INACtive.
        /// </summary>
        public KCT INAC_ABS_CODE_KCT {
            get
            {
                if (INAC_ABS_CODE.HasValue)
                {
                    if (_INAC_ABS_CODE_KCT == null)
                    {
                        _INAC_ABS_CODE_KCT = Context.KCT.FindByKCTKEY(INAC_ABS_CODE.Value);
                    }
                    return _INAC_ABS_CODE_KCT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LOTE_HOME_CODE] => [KGL].[KGLKEY]
        /// The Language other than English spoken at home by student
        /// </summary>
        public KGL LOTE_HOME_CODE_KGL {
            get
            {
                if (LOTE_HOME_CODE != null)
                {
                    if (_LOTE_HOME_CODE_KGL == null)
                    {
                        _LOTE_HOME_CODE_KGL = Context.KGL.FindByKGLKEY(LOTE_HOME_CODE);
                    }
                    return _LOTE_HOME_CODE_KGL;
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
