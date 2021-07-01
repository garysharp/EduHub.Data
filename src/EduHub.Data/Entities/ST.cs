using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Students
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ST : EduHubEntity
    {

        #region Navigation Property Cache

        private DF Cache_FAMILY_DF;
        private DF Cache_FAMB_DF;
        private DF Cache_FAMC_DF;
        private SKGS Cache_PREVIOUS_SCHOOL_SKGS;
        private KGC Cache_HOME_GROUP_KGC;
        private KGC Cache_NEXT_HG_KGC;
        private KCY Cache_SCHOOL_YEAR_KCY;
        private KGH Cache_HOUSE_KGH;
        private SCI Cache_CAMPUS_SCI;
        private KGR Cache_RELIGION_KGR;
        private KCI Cache_REL_INSTR_KCI;
        private KCV Cache_VISA_SUBCLASS_KCV;
        private KGT Cache_BIRTH_COUNTRY_KGT;
        private KGL Cache_HOME_LANG_KGL;
        private KCD Cache_DOCTOR_KCD;
        private KGL Cache_EMERG_LANG01_KGL;
        private KGL Cache_EMERG_LANG02_KGL;
        private KGL Cache_LANGUAGE_PREVIOUS_SCHOOLING_KGL;
        private SKGS Cache_NEXT_SCHOOL_SKGS;
        private KGG Cache_EXIT_CAT01_KGG;
        private KGG Cache_EXIT_CAT02_KGG;
        private KGD Cache_EXIT_DEST01_KGD;
        private KGD Cache_EXIT_DEST02_KGD;
        private KCT Cache_INAC_ABS_CODE_KCT;
        private KGL Cache_LOTE_HOME_CODE_KGL;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<BKHR> Cache_STKEY_BKHR_STUDENT;
        private IReadOnlyList<DFF> Cache_STKEY_DFF_TRSTUD;
        private IReadOnlyList<DFF> Cache_STKEY_DFF_STUDENT;
        private IReadOnlyList<SDP> Cache_STKEY_SDP_STUDENT_KEY;
        private IReadOnlyList<SMC> Cache_STKEY_SMC_STUDENT;
        private IReadOnlyList<SSHG> Cache_STKEY_SSHG_STUDENT;
        private IReadOnlyList<STAR> Cache_STKEY_STAR_SKEY;
        private IReadOnlyList<STBT> Cache_STKEY_STBT_STBTKEY;
        private IReadOnlyList<STMA> Cache_STKEY_STMA_SKEY;
        private IReadOnlyList<STMB> Cache_STKEY_STMB_SKEY;
        private IReadOnlyList<STNAT> Cache_STKEY_STNAT_SKEY;
        private IReadOnlyList<STPO> Cache_STKEY_STPO_STPOKEY;
        private IReadOnlyList<STPS> Cache_STKEY_STPS_SKEY;
        private IReadOnlyList<STPT> Cache_STKEY_STPT_STPTKEY;
        private IReadOnlyList<STRA> Cache_STKEY_STRA_STKEY;
        private IReadOnlyList<STRE> Cache_STKEY_STRE_SKEY;
        private IReadOnlyList<STSB> Cache_STKEY_STSB_SKEY;
        private IReadOnlyList<STSP> Cache_STKEY_STSP_SPKEY;
        private IReadOnlyList<STSUP> Cache_STKEY_STSUP_SKEY;
        private IReadOnlyList<STTRIPS> Cache_STKEY_STTRIPS_STUDENT_ID;
        private IReadOnlyList<STVDI> Cache_STKEY_STVDI_SKEY;
        private IReadOnlyList<STVDO> Cache_STKEY_STVDO_SKEY;
        private IReadOnlyList<SXAB> Cache_STKEY_SXAB_STKEY;
        private IReadOnlyList<SXABCONV> Cache_STKEY_SXABCONV_STKEY;
        private IReadOnlyList<SXAS> Cache_STKEY_SXAS_STKEY;
        private IReadOnlyList<SXHI> Cache_STKEY_SXHI_SKEY;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

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
        /// &lt;No documentation available&gt;
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
        /// &lt;No documentation available&gt;
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
        /// Aboriginal/Torres Strait Islander: N=None, K=Aboriginal, T=Torres Strait Islander, B=Both Aboriginal and TSI, U=Unknown/Not Stated
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
        /// [Alphanumeric (20)]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }

        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency
        /// [Alphanumeric (20)]
        /// </summary>
        public string EMERG_RELATION02 { get; internal set; }

        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Alphanumeric (20)]
        /// </summary>
        public string EMERG_CONTACT01 { get; internal set; }

        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Alphanumeric (20)]
        /// </summary>
        public string EMERG_CONTACT02 { get; internal set; }

        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT_MEMO01 { get; internal set; }

        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT_MEMO02 { get; internal set; }

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
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string DISABILITY_ID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PSDREQ { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HEARING_IMPAIR { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VISUAL_IMPAIR { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SPEECH_IMPAIR { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
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
        /// 'C ' = complete, 'I ' = Incomplete no reason, 'N ' = Not Sighted/Provided, etc
        /// [Alphanumeric (2)]
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
        /// Legal limitations on decision-making responsibilities for student (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LEGAL_LIMIT_DECISION { get; internal set; }

        /// <summary>
        /// Legal limitations on contact with student (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LEGAL_LIMIT_CONTACT { get; internal set; }

        /// <summary>
        /// Describe limitations
        /// [Memo]
        /// </summary>
        public string LEGAL_LIMITATION { get; internal set; }

        /// <summary>
        /// Copies of documentation provided to school (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DOC_COPIES { get; internal set; }

        /// <summary>
        /// Listed in Student Online Case System (SOCS) (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LISTED_IN_SOCS { get; internal set; }

        /// <summary>
        /// Student received Student Support Services (SSS) (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SUPPORT_SERVICES { get; internal set; }

        /// <summary>
        /// Student received other school-based or departmental student support (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STUDENT_SUPPORT { get; internal set; }

        /// <summary>
        /// Student received non-school-based/non-departmental support over the last two years (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STUDENT_OTHER_SUPPORT { get; internal set; }

        /// <summary>
        /// Has a Student Support Group been formed for this student? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SUPPORT_GROUP { get; internal set; }

        /// <summary>
        /// Is the Department of Health and Human Services currently involved with the child and their family? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHILD_PROTECTION { get; internal set; }

        /// <summary>
        /// Are there any concerns regarding the student’s attendance, including truancy? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ATTENDANCE_CONCERNS { get; internal set; }

        /// <summary>
        /// Has the student been subject to any disciplinary action in the past 12 months? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISCIPLINARY_ACTION { get; internal set; }

        /// <summary>
        /// Are there any foreseeable risks of harm to the student, or to others? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WELFARE_RISKS { get; internal set; }

        /// <summary>
        /// Student Effort
        /// [Alphanumeric (15)]
        /// </summary>
        public string EFFORT { get; internal set; }

        /// <summary>
        /// Student Class Behaviour
        /// [Alphanumeric (15)]
        /// </summary>
        public string CLASS_BEHAVIOUR { get; internal set; }

        /// <summary>
        /// Student Organisation
        /// [Alphanumeric (15)]
        /// </summary>
        public string ORGANISATION { get; internal set; }

        /// <summary>
        /// Student Social Behaviour
        /// [Alphanumeric (15)]
        /// </summary>
        public string SOCIAL_BEHAVIOUR { get; internal set; }

        /// <summary>
        /// Additional Learning Support (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LEARNING_SUPPORT { get; internal set; }

        /// <summary>
        /// Enrolled in, or has received English as an Additional Language New Arrivals Program (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NEW_ARRIVALS_PROGRAM { get; internal set; }

        /// <summary>
        /// Likely Refugee Background (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REFUGEE_BACKGROUND { get; internal set; }

        /// <summary>
        /// Copies of documents sent to receiving school (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSFER_DOCS_SENT { get; internal set; }

        /// <summary>
        /// Enrolled in VET (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VET { get; internal set; }

        /// <summary>
        /// Unique Student Identifier
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string USI { get; internal set; }

        /// <summary>
        /// School defined field inlist
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SCH_DEFINED01 { get; internal set; }

        /// <summary>
        /// School defined field inlist
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SCH_DEFINED02 { get; internal set; }

        /// <summary>
        /// Teacher Recommendation (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TEACHER_RECOMMENDATION { get; internal set; }

        /// <summary>
        /// DHHS CRIS ID
        /// [Uppercase Alphanumeric (9)]
        /// </summary>
        public string CRIS_ID { get; internal set; }

        /// <summary>
        /// Caring responsibilities
        /// [Alphanumeric (40)]
        /// </summary>
        public string YOUNG_CARER { get; internal set; }

        /// <summary>
        /// Self-described Gender description
        /// [Alphanumeric (100)]
        /// </summary>
        public string GENDER_DESC { get; internal set; }

        /// <summary>
        /// Student is using the services of a tutor as part of the Tutor Learning Initiative (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DET_TUTOR { get; internal set; }

        /// <summary>
        /// MYLNS Literacy (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MYLNS_LITERACY { get; internal set; }

        /// <summary>
        /// MYLNS Numeracy (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MYLNS_NUMERACY { get; internal set; }

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
        /// DF (Families) related entity by [ST.FAMILY]-&gt;[DF.DFKEY]
        /// Student's prime family
        /// </summary>
        public DF FAMILY_DF
        {
            get
            {
                if (FAMILY == null)
                {
                    return null;
                }
                if (Cache_FAMILY_DF == null)
                {
                    Cache_FAMILY_DF = Context.DF.FindByDFKEY(FAMILY);
                }

                return Cache_FAMILY_DF;
            }
        }

        /// <summary>
        /// DF (Families) related entity by [ST.FAMB]-&gt;[DF.DFKEY]
        /// Student's alternative family
        /// </summary>
        public DF FAMB_DF
        {
            get
            {
                if (FAMB == null)
                {
                    return null;
                }
                if (Cache_FAMB_DF == null)
                {
                    Cache_FAMB_DF = Context.DF.FindByDFKEY(FAMB);
                }

                return Cache_FAMB_DF;
            }
        }

        /// <summary>
        /// DF (Families) related entity by [ST.FAMC]-&gt;[DF.DFKEY]
        /// Student's additional contact family
        /// </summary>
        public DF FAMC_DF
        {
            get
            {
                if (FAMC == null)
                {
                    return null;
                }
                if (Cache_FAMC_DF == null)
                {
                    Cache_FAMC_DF = Context.DF.FindByDFKEY(FAMC);
                }

                return Cache_FAMC_DF;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [ST.PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// (Was PREVIOUS) Previous school attended
        /// </summary>
        public SKGS PREVIOUS_SCHOOL_SKGS
        {
            get
            {
                if (PREVIOUS_SCHOOL == null)
                {
                    return null;
                }
                if (Cache_PREVIOUS_SCHOOL_SKGS == null)
                {
                    Cache_PREVIOUS_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(PREVIOUS_SCHOOL);
                }

                return Cache_PREVIOUS_SCHOOL_SKGS;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [ST.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// (Was FORM) Student's home group
        /// </summary>
        public KGC HOME_GROUP_KGC
        {
            get
            {
                if (HOME_GROUP == null)
                {
                    return null;
                }
                if (Cache_HOME_GROUP_KGC == null)
                {
                    Cache_HOME_GROUP_KGC = Context.KGC.FindByKGCKEY(HOME_GROUP);
                }

                return Cache_HOME_GROUP_KGC;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [ST.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// Anticipated next home group
        /// </summary>
        public KGC NEXT_HG_KGC
        {
            get
            {
                if (NEXT_HG == null)
                {
                    return null;
                }
                if (Cache_NEXT_HG_KGC == null)
                {
                    Cache_NEXT_HG_KGC = Context.KGC.FindByKGCKEY(NEXT_HG);
                }

                return Cache_NEXT_HG_KGC;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [ST.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// Year level
        /// </summary>
        public KCY SCHOOL_YEAR_KCY
        {
            get
            {
                if (SCHOOL_YEAR == null)
                {
                    return null;
                }
                if (Cache_SCHOOL_YEAR_KCY == null)
                {
                    Cache_SCHOOL_YEAR_KCY = Context.KCY.FindByKCYKEY(SCHOOL_YEAR);
                }

                return Cache_SCHOOL_YEAR_KCY;
            }
        }

        /// <summary>
        /// KGH (Houses) related entity by [ST.HOUSE]-&gt;[KGH.KGHKEY]
        /// Student's house group
        /// </summary>
        public KGH HOUSE_KGH
        {
            get
            {
                if (HOUSE == null)
                {
                    return null;
                }
                if (Cache_HOUSE_KGH == null)
                {
                    Cache_HOUSE_KGH = Context.KGH.FindByKGHKEY(HOUSE);
                }

                return Cache_HOUSE_KGH;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [ST.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Student's home campus
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        /// <summary>
        /// KGR (Religions) related entity by [ST.RELIGION]-&gt;[KGR.RELIGION]
        /// Religion
        /// </summary>
        public KGR RELIGION_KGR
        {
            get
            {
                if (RELIGION == null)
                {
                    return null;
                }
                if (Cache_RELIGION_KGR == null)
                {
                    Cache_RELIGION_KGR = Context.KGR.FindByRELIGION(RELIGION);
                }

                return Cache_RELIGION_KGR;
            }
        }

        /// <summary>
        /// KCI (Religious Instruction Curricula) related entity by [ST.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// Link to Religious Instruction Course
        /// </summary>
        public KCI REL_INSTR_KCI
        {
            get
            {
                if (REL_INSTR == null)
                {
                    return null;
                }
                if (Cache_REL_INSTR_KCI == null)
                {
                    Cache_REL_INSTR_KCI = Context.KCI.FindByKCIKEY(REL_INSTR);
                }

                return Cache_REL_INSTR_KCI;
            }
        }

        /// <summary>
        /// KCV (Visa Subclasses) related entity by [ST.VISA_SUBCLASS]-&gt;[KCV.VISA_SUBCLASS]
        /// Visa Sub-class
        /// </summary>
        public KCV VISA_SUBCLASS_KCV
        {
            get
            {
                if (VISA_SUBCLASS == null)
                {
                    return null;
                }
                if (Cache_VISA_SUBCLASS_KCV == null)
                {
                    Cache_VISA_SUBCLASS_KCV = Context.KCV.FindByVISA_SUBCLASS(VISA_SUBCLASS);
                }

                return Cache_VISA_SUBCLASS_KCV;
            }
        }

        /// <summary>
        /// KGT (Countries) related entity by [ST.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// Country of birth
        /// </summary>
        public KGT BIRTH_COUNTRY_KGT
        {
            get
            {
                if (BIRTH_COUNTRY == null)
                {
                    return null;
                }
                if (Cache_BIRTH_COUNTRY_KGT == null)
                {
                    Cache_BIRTH_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY);
                }

                return Cache_BIRTH_COUNTRY_KGT;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [ST.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// </summary>
        public KGL HOME_LANG_KGL
        {
            get
            {
                if (HOME_LANG == null)
                {
                    return null;
                }
                if (Cache_HOME_LANG_KGL == null)
                {
                    Cache_HOME_LANG_KGL = Context.KGL.FindByKGLKEY(HOME_LANG);
                }

                return Cache_HOME_LANG_KGL;
            }
        }

        /// <summary>
        /// KCD (Doctors) related entity by [ST.DOCTOR]-&gt;[KCD.KCDKEY]
        /// Student's regular medical practitioner
        /// </summary>
        public KCD DOCTOR_KCD
        {
            get
            {
                if (DOCTOR == null)
                {
                    return null;
                }
                if (Cache_DOCTOR_KCD == null)
                {
                    Cache_DOCTOR_KCD = Context.KCD.FindByKCDKEY(DOCTOR);
                }

                return Cache_DOCTOR_KCD;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [ST.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG01_KGL
        {
            get
            {
                if (EMERG_LANG01 == null)
                {
                    return null;
                }
                if (Cache_EMERG_LANG01_KGL == null)
                {
                    Cache_EMERG_LANG01_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG01);
                }

                return Cache_EMERG_LANG01_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [ST.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG02_KGL
        {
            get
            {
                if (EMERG_LANG02 == null)
                {
                    return null;
                }
                if (Cache_EMERG_LANG02_KGL == null)
                {
                    Cache_EMERG_LANG02_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG02);
                }

                return Cache_EMERG_LANG02_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [ST.LANGUAGE_PREVIOUS_SCHOOLING]-&gt;[KGL.KGLKEY]
        /// Language of previous schooling
        /// </summary>
        public KGL LANGUAGE_PREVIOUS_SCHOOLING_KGL
        {
            get
            {
                if (LANGUAGE_PREVIOUS_SCHOOLING == null)
                {
                    return null;
                }
                if (Cache_LANGUAGE_PREVIOUS_SCHOOLING_KGL == null)
                {
                    Cache_LANGUAGE_PREVIOUS_SCHOOLING_KGL = Context.KGL.FindByKGLKEY(LANGUAGE_PREVIOUS_SCHOOLING);
                }

                return Cache_LANGUAGE_PREVIOUS_SCHOOLING_KGL;
            }
        }

        /// <summary>
        /// SKGS (Schools) related entity by [ST.NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// School to which departed student has gone (if any)
        /// </summary>
        public SKGS NEXT_SCHOOL_SKGS
        {
            get
            {
                if (NEXT_SCHOOL == null)
                {
                    return null;
                }
                if (Cache_NEXT_SCHOOL_SKGS == null)
                {
                    Cache_NEXT_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(NEXT_SCHOOL);
                }

                return Cache_NEXT_SCHOOL_SKGS;
            }
        }

        /// <summary>
        /// KGG (Year 9-12 Exit Categories) related entity by [ST.EXIT_CAT01]-&gt;[KGG.KGGKEY]
        /// EXIT Category
        /// </summary>
        public KGG EXIT_CAT01_KGG
        {
            get
            {
                if (EXIT_CAT01 == null)
                {
                    return null;
                }
                if (Cache_EXIT_CAT01_KGG == null)
                {
                    Cache_EXIT_CAT01_KGG = Context.KGG.FindByKGGKEY(EXIT_CAT01);
                }

                return Cache_EXIT_CAT01_KGG;
            }
        }

        /// <summary>
        /// KGG (Year 9-12 Exit Categories) related entity by [ST.EXIT_CAT02]-&gt;[KGG.KGGKEY]
        /// EXIT Category
        /// </summary>
        public KGG EXIT_CAT02_KGG
        {
            get
            {
                if (EXIT_CAT02 == null)
                {
                    return null;
                }
                if (Cache_EXIT_CAT02_KGG == null)
                {
                    Cache_EXIT_CAT02_KGG = Context.KGG.FindByKGGKEY(EXIT_CAT02);
                }

                return Cache_EXIT_CAT02_KGG;
            }
        }

        /// <summary>
        /// KGD (Year 9-12 Exit Destinations) related entity by [ST.EXIT_DEST01]-&gt;[KGD.KGDKEY]
        /// EXIT Destination
        /// </summary>
        public KGD EXIT_DEST01_KGD
        {
            get
            {
                if (EXIT_DEST01 == null)
                {
                    return null;
                }
                if (Cache_EXIT_DEST01_KGD == null)
                {
                    Cache_EXIT_DEST01_KGD = Context.KGD.FindByKGDKEY(EXIT_DEST01);
                }

                return Cache_EXIT_DEST01_KGD;
            }
        }

        /// <summary>
        /// KGD (Year 9-12 Exit Destinations) related entity by [ST.EXIT_DEST02]-&gt;[KGD.KGDKEY]
        /// EXIT Destination
        /// </summary>
        public KGD EXIT_DEST02_KGD
        {
            get
            {
                if (EXIT_DEST02 == null)
                {
                    return null;
                }
                if (Cache_EXIT_DEST02_KGD == null)
                {
                    Cache_EXIT_DEST02_KGD = Context.KGD.FindByKGDKEY(EXIT_DEST02);
                }

                return Cache_EXIT_DEST02_KGD;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [ST.INAC_ABS_CODE]-&gt;[KCT.KCTKEY]
        /// Code used to populate attendance records whilst status is INACtive.
        /// </summary>
        public KCT INAC_ABS_CODE_KCT
        {
            get
            {
                if (INAC_ABS_CODE == null)
                {
                    return null;
                }
                if (Cache_INAC_ABS_CODE_KCT == null)
                {
                    Cache_INAC_ABS_CODE_KCT = Context.KCT.FindByKCTKEY(INAC_ABS_CODE.Value);
                }

                return Cache_INAC_ABS_CODE_KCT;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [ST.LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// The Language other than English spoken at home by student
        /// </summary>
        public KGL LOTE_HOME_CODE_KGL
        {
            get
            {
                if (LOTE_HOME_CODE == null)
                {
                    return null;
                }
                if (Cache_LOTE_HOME_CODE_KGL == null)
                {
                    Cache_LOTE_HOME_CODE_KGL = Context.KGL.FindByKGLKEY(LOTE_HOME_CODE);
                }

                return Cache_LOTE_HOME_CODE_KGL;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// BKHR (Book Hire Records) related entities by [ST.STKEY]-&gt;[BKHR.STUDENT]
        /// Student ID
        /// </summary>
        public IReadOnlyList<BKHR> STKEY_BKHR_STUDENT
        {
            get
            {
                if (Cache_STKEY_BKHR_STUDENT == null &&
                    !Context.BKHR.TryFindBySTUDENT(STKEY, out Cache_STKEY_BKHR_STUDENT))
                {
                    Cache_STKEY_BKHR_STUDENT = new List<BKHR>().AsReadOnly();
                }

                return Cache_STKEY_BKHR_STUDENT;
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [ST.STKEY]-&gt;[DFF.TRSTUD]
        /// Student ID
        /// </summary>
        public IReadOnlyList<DFF> STKEY_DFF_TRSTUD
        {
            get
            {
                if (Cache_STKEY_DFF_TRSTUD == null &&
                    !Context.DFF.TryFindByTRSTUD(STKEY, out Cache_STKEY_DFF_TRSTUD))
                {
                    Cache_STKEY_DFF_TRSTUD = new List<DFF>().AsReadOnly();
                }

                return Cache_STKEY_DFF_TRSTUD;
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [ST.STKEY]-&gt;[DFF.STUDENT]
        /// Student ID
        /// </summary>
        public IReadOnlyList<DFF> STKEY_DFF_STUDENT
        {
            get
            {
                if (Cache_STKEY_DFF_STUDENT == null &&
                    !Context.DFF.TryFindBySTUDENT(STKEY, out Cache_STKEY_DFF_STUDENT))
                {
                    Cache_STKEY_DFF_STUDENT = new List<DFF>().AsReadOnly();
                }

                return Cache_STKEY_DFF_STUDENT;
            }
        }

        /// <summary>
        /// SDP (Incident Instigators) related entities by [ST.STKEY]-&gt;[SDP.STUDENT_KEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<SDP> STKEY_SDP_STUDENT_KEY
        {
            get
            {
                if (Cache_STKEY_SDP_STUDENT_KEY == null &&
                    !Context.SDP.TryFindBySTUDENT_KEY(STKEY, out Cache_STKEY_SDP_STUDENT_KEY))
                {
                    Cache_STKEY_SDP_STUDENT_KEY = new List<SDP>().AsReadOnly();
                }

                return Cache_STKEY_SDP_STUDENT_KEY;
            }
        }

        /// <summary>
        /// SMC (Student Medical Conditions) related entities by [ST.STKEY]-&gt;[SMC.STUDENT]
        /// Student ID
        /// </summary>
        public IReadOnlyList<SMC> STKEY_SMC_STUDENT
        {
            get
            {
                if (Cache_STKEY_SMC_STUDENT == null &&
                    !Context.SMC.TryFindBySTUDENT(STKEY, out Cache_STKEY_SMC_STUDENT))
                {
                    Cache_STKEY_SMC_STUDENT = new List<SMC>().AsReadOnly();
                }

                return Cache_STKEY_SMC_STUDENT;
            }
        }

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [ST.STKEY]-&gt;[SSHG.STUDENT]
        /// Student ID
        /// </summary>
        public IReadOnlyList<SSHG> STKEY_SSHG_STUDENT
        {
            get
            {
                if (Cache_STKEY_SSHG_STUDENT == null &&
                    !Context.SSHG.TryFindBySTUDENT(STKEY, out Cache_STKEY_SSHG_STUDENT))
                {
                    Cache_STKEY_SSHG_STUDENT = new List<SSHG>().AsReadOnly();
                }

                return Cache_STKEY_SSHG_STUDENT;
            }
        }

        /// <summary>
        /// STAR (Student Access Restrictions) related entities by [ST.STKEY]-&gt;[STAR.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STAR> STKEY_STAR_SKEY
        {
            get
            {
                if (Cache_STKEY_STAR_SKEY == null &&
                    !Context.STAR.TryFindBySKEY(STKEY, out Cache_STKEY_STAR_SKEY))
                {
                    Cache_STKEY_STAR_SKEY = new List<STAR>().AsReadOnly();
                }

                return Cache_STKEY_STAR_SKEY;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [ST.STKEY]-&gt;[STBT.STBTKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STBT> STKEY_STBT_STBTKEY
        {
            get
            {
                if (Cache_STKEY_STBT_STBTKEY == null &&
                    !Context.STBT.TryFindBySTBTKEY(STKEY, out Cache_STKEY_STBT_STBTKEY))
                {
                    Cache_STKEY_STBT_STBTKEY = new List<STBT>().AsReadOnly();
                }

                return Cache_STKEY_STBT_STBTKEY;
            }
        }

        /// <summary>
        /// STMA (Subject Selections &amp; Marks) related entities by [ST.STKEY]-&gt;[STMA.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STMA> STKEY_STMA_SKEY
        {
            get
            {
                if (Cache_STKEY_STMA_SKEY == null &&
                    !Context.STMA.TryFindBySKEY(STKEY, out Cache_STKEY_STMA_SKEY))
                {
                    Cache_STKEY_STMA_SKEY = new List<STMA>().AsReadOnly();
                }

                return Cache_STKEY_STMA_SKEY;
            }
        }

        /// <summary>
        /// STMB (Student Merit Behaviour Details) related entities by [ST.STKEY]-&gt;[STMB.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STMB> STKEY_STMB_SKEY
        {
            get
            {
                if (Cache_STKEY_STMB_SKEY == null &&
                    !Context.STMB.TryFindBySKEY(STKEY, out Cache_STKEY_STMB_SKEY))
                {
                    Cache_STKEY_STMB_SKEY = new List<STMB>().AsReadOnly();
                }

                return Cache_STKEY_STMB_SKEY;
            }
        }

        /// <summary>
        /// STNAT (Student Notes and Attachments) related entities by [ST.STKEY]-&gt;[STNAT.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STNAT> STKEY_STNAT_SKEY
        {
            get
            {
                if (Cache_STKEY_STNAT_SKEY == null &&
                    !Context.STNAT.TryFindBySKEY(STKEY, out Cache_STKEY_STNAT_SKEY))
                {
                    Cache_STKEY_STNAT_SKEY = new List<STNAT>().AsReadOnly();
                }

                return Cache_STKEY_STNAT_SKEY;
            }
        }

        /// <summary>
        /// STPO (Position or Group Memberships) related entities by [ST.STKEY]-&gt;[STPO.STPOKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STPO> STKEY_STPO_STPOKEY
        {
            get
            {
                if (Cache_STKEY_STPO_STPOKEY == null &&
                    !Context.STPO.TryFindBySTPOKEY(STKEY, out Cache_STKEY_STPO_STPOKEY))
                {
                    Cache_STKEY_STPO_STPOKEY = new List<STPO>().AsReadOnly();
                }

                return Cache_STKEY_STPO_STPOKEY;
            }
        }

        /// <summary>
        /// STPS (Student Previous School) related entities by [ST.STKEY]-&gt;[STPS.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STPS> STKEY_STPS_SKEY
        {
            get
            {
                if (Cache_STKEY_STPS_SKEY == null &&
                    !Context.STPS.TryFindBySKEY(STKEY, out Cache_STKEY_STPS_SKEY))
                {
                    Cache_STKEY_STPS_SKEY = new List<STPS>().AsReadOnly();
                }

                return Cache_STKEY_STPS_SKEY;
            }
        }

        /// <summary>
        /// STPT (Student Part-Time Enrolments) related entities by [ST.STKEY]-&gt;[STPT.STPTKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STPT> STKEY_STPT_STPTKEY
        {
            get
            {
                if (Cache_STKEY_STPT_STPTKEY == null &&
                    !Context.STPT.TryFindBySTPTKEY(STKEY, out Cache_STKEY_STPT_STPTKEY))
                {
                    Cache_STKEY_STPT_STPTKEY = new List<STPT>().AsReadOnly();
                }

                return Cache_STKEY_STPT_STPTKEY;
            }
        }

        /// <summary>
        /// STRA (Multiple Day Absences) related entities by [ST.STKEY]-&gt;[STRA.STKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STRA> STKEY_STRA_STKEY
        {
            get
            {
                if (Cache_STKEY_STRA_STKEY == null &&
                    !Context.STRA.TryFindBySTKEY(STKEY, out Cache_STKEY_STRA_STKEY))
                {
                    Cache_STKEY_STRA_STKEY = new List<STRA>().AsReadOnly();
                }

                return Cache_STKEY_STRA_STKEY;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [ST.STKEY]-&gt;[STRE.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STRE> STKEY_STRE_SKEY
        {
            get
            {
                if (Cache_STKEY_STRE_SKEY == null &&
                    !Context.STRE.TryFindBySKEY(STKEY, out Cache_STKEY_STRE_SKEY))
                {
                    Cache_STKEY_STRE_SKEY = new List<STRE>().AsReadOnly();
                }

                return Cache_STKEY_STRE_SKEY;
            }
        }

        /// <summary>
        /// STSB (Family Invoice Allocations) related entities by [ST.STKEY]-&gt;[STSB.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STSB> STKEY_STSB_SKEY
        {
            get
            {
                if (Cache_STKEY_STSB_SKEY == null &&
                    !Context.STSB.TryFindBySKEY(STKEY, out Cache_STKEY_STSB_SKEY))
                {
                    Cache_STKEY_STSB_SKEY = new List<STSB>().AsReadOnly();
                }

                return Cache_STKEY_STSB_SKEY;
            }
        }

        /// <summary>
        /// STSP (Suspension Details) related entities by [ST.STKEY]-&gt;[STSP.SPKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STSP> STKEY_STSP_SPKEY
        {
            get
            {
                if (Cache_STKEY_STSP_SPKEY == null &&
                    !Context.STSP.TryFindBySPKEY(STKEY, out Cache_STKEY_STSP_SPKEY))
                {
                    Cache_STKEY_STSP_SPKEY = new List<STSP>().AsReadOnly();
                }

                return Cache_STKEY_STSP_SPKEY;
            }
        }

        /// <summary>
        /// STSUP (Support Persons) related entities by [ST.STKEY]-&gt;[STSUP.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STSUP> STKEY_STSUP_SKEY
        {
            get
            {
                if (Cache_STKEY_STSUP_SKEY == null &&
                    !Context.STSUP.TryFindBySKEY(STKEY, out Cache_STKEY_STSUP_SKEY))
                {
                    Cache_STKEY_STSUP_SKEY = new List<STSUP>().AsReadOnly();
                }

                return Cache_STKEY_STSUP_SKEY;
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [ST.STKEY]-&gt;[STTRIPS.STUDENT_ID]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STTRIPS> STKEY_STTRIPS_STUDENT_ID
        {
            get
            {
                if (Cache_STKEY_STTRIPS_STUDENT_ID == null &&
                    !Context.STTRIPS.TryFindBySTUDENT_ID(STKEY, out Cache_STKEY_STTRIPS_STUDENT_ID))
                {
                    Cache_STKEY_STTRIPS_STUDENT_ID = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_STKEY_STTRIPS_STUDENT_ID;
            }
        }

        /// <summary>
        /// STVDI (VELS Dimension Results) related entities by [ST.STKEY]-&gt;[STVDI.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STVDI> STKEY_STVDI_SKEY
        {
            get
            {
                if (Cache_STKEY_STVDI_SKEY == null &&
                    !Context.STVDI.TryFindBySKEY(STKEY, out Cache_STKEY_STVDI_SKEY))
                {
                    Cache_STKEY_STVDI_SKEY = new List<STVDI>().AsReadOnly();
                }

                return Cache_STKEY_STVDI_SKEY;
            }
        }

        /// <summary>
        /// STVDO (VELS Domain Results) related entities by [ST.STKEY]-&gt;[STVDO.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<STVDO> STKEY_STVDO_SKEY
        {
            get
            {
                if (Cache_STKEY_STVDO_SKEY == null &&
                    !Context.STVDO.TryFindBySKEY(STKEY, out Cache_STKEY_STVDO_SKEY))
                {
                    Cache_STKEY_STVDO_SKEY = new List<STVDO>().AsReadOnly();
                }

                return Cache_STKEY_STVDO_SKEY;
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [ST.STKEY]-&gt;[SXAB.STKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<SXAB> STKEY_SXAB_STKEY
        {
            get
            {
                if (Cache_STKEY_SXAB_STKEY == null &&
                    !Context.SXAB.TryFindBySTKEY(STKEY, out Cache_STKEY_SXAB_STKEY))
                {
                    Cache_STKEY_SXAB_STKEY = new List<SXAB>().AsReadOnly();
                }

                return Cache_STKEY_SXAB_STKEY;
            }
        }

        /// <summary>
        /// SXABCONV (Converted Student Half-Day Absences) related entities by [ST.STKEY]-&gt;[SXABCONV.STKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<SXABCONV> STKEY_SXABCONV_STKEY
        {
            get
            {
                if (Cache_STKEY_SXABCONV_STKEY == null &&
                    !Context.SXABCONV.TryFindBySTKEY(STKEY, out Cache_STKEY_SXABCONV_STKEY))
                {
                    Cache_STKEY_SXABCONV_STKEY = new List<SXABCONV>().AsReadOnly();
                }

                return Cache_STKEY_SXABCONV_STKEY;
            }
        }

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [ST.STKEY]-&gt;[SXAS.STKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<SXAS> STKEY_SXAS_STKEY
        {
            get
            {
                if (Cache_STKEY_SXAS_STKEY == null &&
                    !Context.SXAS.TryFindBySTKEY(STKEY, out Cache_STKEY_SXAS_STKEY))
                {
                    Cache_STKEY_SXAS_STKEY = new List<SXAS>().AsReadOnly();
                }

                return Cache_STKEY_SXAS_STKEY;
            }
        }

        /// <summary>
        /// SXHI (Student History) related entities by [ST.STKEY]-&gt;[SXHI.SKEY]
        /// Student ID
        /// </summary>
        public IReadOnlyList<SXHI> STKEY_SXHI_SKEY
        {
            get
            {
                if (Cache_STKEY_SXHI_SKEY == null &&
                    !Context.SXHI.TryFindBySKEY(STKEY, out Cache_STKEY_SXHI_SKEY))
                {
                    Cache_STKEY_SXHI_SKEY = new List<SXHI>().AsReadOnly();
                }

                return Cache_STKEY_SXHI_SKEY;
            }
        }

        #endregion

    }
}
