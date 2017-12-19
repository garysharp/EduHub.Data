using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SF : EduHubEntity
    {

        #region Navigation Property Cache

        private UM Cache_HOMEKEY_UM;
        private UM Cache_MAILKEY_UM;
        private KSF Cache_FACULTY01_KSF;
        private KSF Cache_FACULTY02_KSF;
        private KSF Cache_FACULTY03_KSF;
        private KSF Cache_FACULTY04_KSF;
        private SU Cache_SUBJECT01_SU;
        private SU Cache_SUBJECT02_SU;
        private SU Cache_SUBJECT03_SU;
        private SU Cache_SUBJECT04_SU;
        private SU Cache_SUBJECT05_SU;
        private SU Cache_SUBJECT06_SU;
        private SU Cache_SUBJECT07_SU;
        private SU Cache_SUBJECT08_SU;
        private SU Cache_SUBJECT09_SU;
        private SU Cache_SUBJECT10_SU;
        private SCI Cache_CAMPUS_SCI;
        private KGH Cache_HOUSE_KGH;
        private SM Cache_ROOM_SM;
        private SM Cache_OTHER_LOCATION_SM;
        private KSC Cache_POS_CODE_A_KSC;
        private KSC Cache_POS_CODE_B_KSC;
        private KSA Cache_MAJORA_KSA;
        private KSA Cache_MAJORB_KSA;
        private KSA Cache_MAJORC_KSA;
        private KGR Cache_RELIGION_KGR;
        private KGT Cache_BIRTH_COUNTRY_KGT;
        private KGL Cache_LANG01_KGL;
        private KGL Cache_LANG02_KGL;
        private KGL Cache_EMERG_LANG01_KGL;
        private KGL Cache_EMERG_LANG02_KGL;
        private DR Cache_DEBTOR_ID_DR;
        private SP_REPLY Cache_SMS_REPLY_SP_REPLY;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<AKK> Cache_SFKEY_AKK_STAFF;
        private IReadOnlyList<BKHR> Cache_SFKEY_BKHR_STAFF;
        private IReadOnlyList<CRF> Cache_SFKEY_CRF_APPROVED_BY;
        private IReadOnlyList<CRF> Cache_SFKEY_CRF_STAFF_ORDER_BY;
        private IReadOnlyList<CRPR> Cache_SFKEY_CRPR_STAFF_ORDER_BY;
        private IReadOnlyList<CRPR> Cache_SFKEY_CRPR_APPROVED_BY;
        private IReadOnlyList<CRTT> Cache_SFKEY_CRTT_STAFF;
        private IReadOnlyList<KCPC> Cache_SFKEY_KCPC_STAFF;
        private IReadOnlyList<KCY> Cache_SFKEY_KCY_TEACHER;
        private IReadOnlyList<KCY> Cache_SFKEY_KCY_TEACHER_B;
        private IReadOnlyList<KGC> Cache_SFKEY_KGC_TEACHER;
        private IReadOnlyList<KGC> Cache_SFKEY_KGC_TEACHER_B;
        private IReadOnlyList<KSF> Cache_SFKEY_KSF_COORDINATOR;
        private IReadOnlyList<PGID> Cache_SFKEY_PGID_IMPORTED_BY;
        private IReadOnlyList<RQ> Cache_SFKEY_RQ_ORDER_BY;
        private IReadOnlyList<RQ> Cache_SFKEY_RQ_APPROVED_BY;
        private IReadOnlyList<RQPG> Cache_SFKEY_RQPG_SFKEY;
        private IReadOnlyList<RQREL> Cache_SFKEY_RQREL_SFKEY;
        private IReadOnlyList<SAD> Cache_SFKEY_SAD_AREA_DUTY_TEACHER;
        private IReadOnlyList<SAIM> Cache_SFKEY_SAIM_STAFF;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SCH_PRINCIPAL;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_OIC;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_VPRIN;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_2VPRIN;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_3VPRIN;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_APRIN;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_BMANAGER;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_VAC_CONTACT;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_EMERG_CONTACT;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SCH_AOIC;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SCH_VPRIN;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SCH_BMANAGER;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SCH_VAC_CONTACT;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SCH_EMERG_CONTACT;
        private IReadOnlyList<SCI> Cache_SFKEY_SCI_SF_PURCH_MANAGER;
        private IReadOnlyList<SCL> Cache_SFKEY_SCL_TEACHER01;
        private IReadOnlyList<SCL> Cache_SFKEY_SCL_TEACHER02;
        private IReadOnlyList<SDPA> Cache_SFKEY_SDPA_TAKEN_BY;
        private IReadOnlyList<SFAQ> Cache_SFKEY_SFAQ_SFAQKEY;
        private IReadOnlyList<SFAV> Cache_SFKEY_SFAV_TEACH;
        private IReadOnlyList<SFQA> Cache_SFKEY_SFQA_TEACH;
        private IReadOnlyList<SM> Cache_SFKEY_SM_STAFF_CODE;
        private IReadOnlyList<SMCD> Cache_SFKEY_SMCD_STAFF;
        private IReadOnlyList<SP_RECIP> Cache_SFKEY_SP_RECIP_SFKEY;
        private IReadOnlyList<SS> Cache_SFKEY_SS_DEFAULT_TEACHER;
        private IReadOnlyList<SSHG> Cache_SFKEY_SSHG_TEACHER;
        private IReadOnlyList<STSP> Cache_SFKEY_STSP_REF_TEACHERA;
        private IReadOnlyList<STSP> Cache_SFKEY_STSP_REF_TEACHERB;
        private IReadOnlyList<TCTB> Cache_SFKEY_TCTB_TEACHER;
        private IReadOnlyList<TCTQ> Cache_SFKEY_TCTQ_T1TEACH;
        private IReadOnlyList<TCTQ> Cache_SFKEY_TCTQ_T2TEACH;
        private IReadOnlyList<TCTQ> Cache_SFKEY_TCTQ_EXTRA_TEACH;
        private IReadOnlyList<TCTR> Cache_SFKEY_TCTR_TEACH;
        private IReadOnlyList<THTQ> Cache_SFKEY_THTQ_T1TEACH;
        private IReadOnlyList<THTQ> Cache_SFKEY_THTQ_T2TEACH;
        private IReadOnlyList<THTQ> Cache_SFKEY_THTQ_EXTRA_TEACH;
        private IReadOnlyList<TTEF> Cache_SFKEY_TTEF_STAFF;
        private IReadOnlyList<TTTG> Cache_SFKEY_TTTG_T1TEACH;
        private IReadOnlyList<TTTG> Cache_SFKEY_TTTG_T2TEACH;
        private IReadOnlyList<TXAS> Cache_SFKEY_TXAS_TEACHER;

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
        /// Staff member code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SFKEY { get; internal set; }

        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// Title: Mr, Ms, etc
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE { get; internal set; }

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
        /// [Alphanumeric (15)]
        /// </summary>
        public string PREF_NAME { get; internal set; }

        /// <summary>
        /// Previous surname if changed
        /// [Titlecase (30)]
        /// </summary>
        public string PREVIOUS_NAME { get; internal set; }

        /// <summary>
        /// Gender of staff member (M/F)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }

        /// <summary>
        /// Home address ID
        /// </summary>
        public int? HOMEKEY { get; internal set; }

        /// <summary>
        /// Mail address ID
        /// </summary>
        public int? MAILKEY { get; internal set; }

        /// <summary>
        /// Mobile phone
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// Work phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string WORK_PHONE { get; internal set; }

        /// <summary>
        /// E-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string E_MAIL { get; internal set; }

        /// <summary>
        /// Victorian Institute of Teaching ID Number
        /// [Alphanumeric (10)]
        /// </summary>
        public string VIT_NO { get; internal set; }

        /// <summary>
        /// Start date at school
        /// </summary>
        public DateTime? START { get; internal set; }

        /// <summary>
        /// Finished date at school
        /// </summary>
        public DateTime? FINISH { get; internal set; }

        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY01 { get; internal set; }

        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY02 { get; internal set; }

        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY03 { get; internal set; }

        /// <summary>
        /// Faculty/ies
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY04 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT01 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT02 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT03 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT04 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT05 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT06 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT07 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT08 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT09 { get; internal set; }

        /// <summary>
        /// Subjects normally taken in priority sequence
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT10 { get; internal set; }

        /// <summary>
        /// Full time equivalent
        /// </summary>
        public double? FTE { get; internal set; }

        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY01 { get; internal set; }

        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY02 { get; internal set; }

        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY03 { get; internal set; }

        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY04 { get; internal set; }

        /// <summary>
        /// Code for availability each day: A=AM only, P=PM only, N=Not available, Y=Available all day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AVAILABILITY05 { get; internal set; }

        /// <summary>
        /// ?
        /// </summary>
        public short? RANK { get; internal set; }

        /// <summary>
        /// ID of home campus
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// School house
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HOUSE { get; internal set; }

        /// <summary>
        /// Home teaching room
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }

        /// <summary>
        /// Usual location when not teaching
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string OTHER_LOCATION { get; internal set; }

        /// <summary>
        /// Car registration number
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CAR_REGO { get; internal set; }

        /// <summary>
        /// Teacher available for timetabling: T=Available, N=Non-teacher, L=Left, U=Unavailable, E=Emergency
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STAFF_TYPE { get; internal set; }

        /// <summary>
        /// (Was POS_CODE) Reference to Staff Position (1)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string POS_CODE_A { get; internal set; }

        /// <summary>
        /// Reference to Staff Position (2)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string POS_CODE_B { get; internal set; }

        /// <summary>
        /// Teacher type (Permanent, Secondment, Volunteer, etc)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STATUS { get; internal set; }

        /// <summary>
        /// Staff status: Active,Left school
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF_STATUS { get; internal set; }

        /// <summary>
        /// Major area of teaching otherwise not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAJORA { get; internal set; }

        /// <summary>
        /// Major area of teaching otherwise not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAJORB { get; internal set; }

        /// <summary>
        /// Major area of teaching otherwise not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAJORC { get; internal set; }

        /// <summary>
        /// Details of any additional skills, etc
        /// [Memo]
        /// </summary>
        public string SKILL_QUALIFICATION { get; internal set; }

        /// <summary>
        /// Central payroll record number
        /// [Uppercase Alphanumeric (9)]
        /// </summary>
        public string PAYROLL_REC_NO { get; internal set; }

        /// <summary>
        /// Central payroll classification
        /// [Alphanumeric (20)]
        /// </summary>
        public string PAYROLL_CLASS { get; internal set; }

        /// <summary>
        /// Religion
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string RELIGION { get; internal set; }

        /// <summary>
        /// Staff name to be used in reports
        /// [Alphanumeric (30)]
        /// </summary>
        public string REPORT_NAME { get; internal set; }

        /// <summary>
        /// Police clearance? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string POLICE_CLEARANCE { get; internal set; }

        /// <summary>
        /// Last police clearance date
        /// </summary>
        public DateTime? CLEARANCE_DATE { get; internal set; }

        /// <summary>
        /// Staff Photograph
        /// </summary>
        public byte[] STAFF_PIC { get; internal set; }

        /// <summary>
        /// OK to publish picture Y/N
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
        /// Indicates which periods teacher is available for extras: used by Calendar
        /// </summary>
        public byte[] AVAILABLE { get; internal set; }

        /// <summary>
        /// Maximum number of extras allowed in a year/term
        /// </summary>
        public short? MAX_EXTRAS { get; internal set; }

        /// <summary>
        /// No of extras already taken this year/term
        /// </summary>
        public short? ACC_EXTRAS { get; internal set; }

        /// <summary>
        /// No of extras already taken this cycle/week
        /// </summary>
        public short? WEEK_EXTRAS { get; internal set; }

        /// <summary>
        /// Last date an extra taken
        /// </summary>
        public DateTime? LAST_EXTRAS { get; internal set; }

        /// <summary>
        /// (Was COUNTRY_BIRTH) Country of birth
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }

        /// <summary>
        /// Language(s) spoken by this staff member
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LANG01 { get; internal set; }

        /// <summary>
        /// Language(s) spoken by this staff member
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LANG02 { get; internal set; }

        /// <summary>
        /// Able and willing to act as interpreter
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTERPRETER01 { get; internal set; }

        /// <summary>
        /// Able and willing to act as interpreter
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTERPRETER02 { get; internal set; }

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
        /// Relationship to staff member of each person to contact in an emergency
        /// [Titlecase (12)]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }

        /// <summary>
        /// Relationship to staff member of each person to contact in an emergency
        /// [Titlecase (12)]
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
        /// Is this staff member prepared to be in any special groups? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GROUP_AVAILABILITY { get; internal set; }

        /// <summary>
        /// Normal timetable load for this staff member
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }

        /// <summary>
        /// Y/N information regarding whether the employee records should be updated via HRMS import
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HRMS_UPDATE { get; internal set; }

        /// <summary>
        /// Last update from HRMS import
        /// </summary>
        public DateTime? HRMS_DATETIME { get; internal set; }

        /// <summary>
        /// Link to sundry debtors
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEBTOR_ID { get; internal set; }

        /// <summary>
        /// Notes - any general purpose
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }

        /// <summary>
        /// Driver's licence number
        /// [Alphanumeric (15)]
        /// </summary>
        public string DRIVERS_LIC_NO { get; internal set; }

        /// <summary>
        /// Driver's licence expiry date
        /// </summary>
        public DateTime? DRIVERS_LIC_EXPIRY { get; internal set; }

        /// <summary>
        /// VIT expiry date
        /// </summary>
        public DateTime? VIT_EXPIRY { get; internal set; }

        /// <summary>
        /// Working With Children Check card number
        /// [Uppercase Alphanumeric (11)]
        /// </summary>
        public string WWCC_NUMBER { get; internal set; }

        /// <summary>
        /// WWCC expiry date
        /// </summary>
        public DateTime? WWCC_EXPIRY { get; internal set; }

        /// <summary>
        /// WWCC card Type E=Employee, V=Volunteer
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WWCC_TYPE { get; internal set; }

        /// <summary>
        /// SMS Reply Recipient Group key
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SMS_REPLY { get; internal set; }

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
        /// UM (Addresses) related entity by [SF.HOMEKEY]-&gt;[UM.UMKEY]
        /// Home address ID
        /// </summary>
        public UM HOMEKEY_UM
        {
            get
            {
                if (HOMEKEY == null)
                {
                    return null;
                }
                if (Cache_HOMEKEY_UM == null)
                {
                    Cache_HOMEKEY_UM = Context.UM.FindByUMKEY(HOMEKEY.Value);
                }

                return Cache_HOMEKEY_UM;
            }
        }

        /// <summary>
        /// UM (Addresses) related entity by [SF.MAILKEY]-&gt;[UM.UMKEY]
        /// Mail address ID
        /// </summary>
        public UM MAILKEY_UM
        {
            get
            {
                if (MAILKEY == null)
                {
                    return null;
                }
                if (Cache_MAILKEY_UM == null)
                {
                    Cache_MAILKEY_UM = Context.UM.FindByUMKEY(MAILKEY.Value);
                }

                return Cache_MAILKEY_UM;
            }
        }

        /// <summary>
        /// KSF (Faculties) related entity by [SF.FACULTY01]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY01_KSF
        {
            get
            {
                if (FACULTY01 == null)
                {
                    return null;
                }
                if (Cache_FACULTY01_KSF == null)
                {
                    Cache_FACULTY01_KSF = Context.KSF.FindByKSFKEY(FACULTY01);
                }

                return Cache_FACULTY01_KSF;
            }
        }

        /// <summary>
        /// KSF (Faculties) related entity by [SF.FACULTY02]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY02_KSF
        {
            get
            {
                if (FACULTY02 == null)
                {
                    return null;
                }
                if (Cache_FACULTY02_KSF == null)
                {
                    Cache_FACULTY02_KSF = Context.KSF.FindByKSFKEY(FACULTY02);
                }

                return Cache_FACULTY02_KSF;
            }
        }

        /// <summary>
        /// KSF (Faculties) related entity by [SF.FACULTY03]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY03_KSF
        {
            get
            {
                if (FACULTY03 == null)
                {
                    return null;
                }
                if (Cache_FACULTY03_KSF == null)
                {
                    Cache_FACULTY03_KSF = Context.KSF.FindByKSFKEY(FACULTY03);
                }

                return Cache_FACULTY03_KSF;
            }
        }

        /// <summary>
        /// KSF (Faculties) related entity by [SF.FACULTY04]-&gt;[KSF.KSFKEY]
        /// Faculty/ies
        /// </summary>
        public KSF FACULTY04_KSF
        {
            get
            {
                if (FACULTY04 == null)
                {
                    return null;
                }
                if (Cache_FACULTY04_KSF == null)
                {
                    Cache_FACULTY04_KSF = Context.KSF.FindByKSFKEY(FACULTY04);
                }

                return Cache_FACULTY04_KSF;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT01]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT01_SU
        {
            get
            {
                if (SUBJECT01 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT01_SU == null)
                {
                    Cache_SUBJECT01_SU = Context.SU.FindBySUKEY(SUBJECT01);
                }

                return Cache_SUBJECT01_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT02]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT02_SU
        {
            get
            {
                if (SUBJECT02 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT02_SU == null)
                {
                    Cache_SUBJECT02_SU = Context.SU.FindBySUKEY(SUBJECT02);
                }

                return Cache_SUBJECT02_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT03]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT03_SU
        {
            get
            {
                if (SUBJECT03 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT03_SU == null)
                {
                    Cache_SUBJECT03_SU = Context.SU.FindBySUKEY(SUBJECT03);
                }

                return Cache_SUBJECT03_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT04]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT04_SU
        {
            get
            {
                if (SUBJECT04 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT04_SU == null)
                {
                    Cache_SUBJECT04_SU = Context.SU.FindBySUKEY(SUBJECT04);
                }

                return Cache_SUBJECT04_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT05]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT05_SU
        {
            get
            {
                if (SUBJECT05 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT05_SU == null)
                {
                    Cache_SUBJECT05_SU = Context.SU.FindBySUKEY(SUBJECT05);
                }

                return Cache_SUBJECT05_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT06]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT06_SU
        {
            get
            {
                if (SUBJECT06 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT06_SU == null)
                {
                    Cache_SUBJECT06_SU = Context.SU.FindBySUKEY(SUBJECT06);
                }

                return Cache_SUBJECT06_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT07]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT07_SU
        {
            get
            {
                if (SUBJECT07 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT07_SU == null)
                {
                    Cache_SUBJECT07_SU = Context.SU.FindBySUKEY(SUBJECT07);
                }

                return Cache_SUBJECT07_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT08]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT08_SU
        {
            get
            {
                if (SUBJECT08 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT08_SU == null)
                {
                    Cache_SUBJECT08_SU = Context.SU.FindBySUKEY(SUBJECT08);
                }

                return Cache_SUBJECT08_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT09]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT09_SU
        {
            get
            {
                if (SUBJECT09 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT09_SU == null)
                {
                    Cache_SUBJECT09_SU = Context.SU.FindBySUKEY(SUBJECT09);
                }

                return Cache_SUBJECT09_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SF.SUBJECT10]-&gt;[SU.SUKEY]
        /// Subjects normally taken in priority sequence
        /// </summary>
        public SU SUBJECT10_SU
        {
            get
            {
                if (SUBJECT10 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT10_SU == null)
                {
                    Cache_SUBJECT10_SU = Context.SU.FindBySUKEY(SUBJECT10);
                }

                return Cache_SUBJECT10_SU;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SF.CAMPUS]-&gt;[SCI.SCIKEY]
        /// ID of home campus
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
        /// KGH (Houses) related entity by [SF.HOUSE]-&gt;[KGH.KGHKEY]
        /// School house
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
        /// SM (Rooms) related entity by [SF.ROOM]-&gt;[SM.ROOM]
        /// Home teaching room
        /// </summary>
        public SM ROOM_SM
        {
            get
            {
                if (ROOM == null)
                {
                    return null;
                }
                if (Cache_ROOM_SM == null)
                {
                    Cache_ROOM_SM = Context.SM.FindByROOM(ROOM);
                }

                return Cache_ROOM_SM;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [SF.OTHER_LOCATION]-&gt;[SM.ROOM]
        /// Usual location when not teaching
        /// </summary>
        public SM OTHER_LOCATION_SM
        {
            get
            {
                if (OTHER_LOCATION == null)
                {
                    return null;
                }
                if (Cache_OTHER_LOCATION_SM == null)
                {
                    Cache_OTHER_LOCATION_SM = Context.SM.FindByROOM(OTHER_LOCATION);
                }

                return Cache_OTHER_LOCATION_SM;
            }
        }

        /// <summary>
        /// KSC (Staff Positions) related entity by [SF.POS_CODE_A]-&gt;[KSC.KSCKEY]
        /// (Was POS_CODE) Reference to Staff Position (1)
        /// </summary>
        public KSC POS_CODE_A_KSC
        {
            get
            {
                if (POS_CODE_A == null)
                {
                    return null;
                }
                if (Cache_POS_CODE_A_KSC == null)
                {
                    Cache_POS_CODE_A_KSC = Context.KSC.FindByKSCKEY(POS_CODE_A);
                }

                return Cache_POS_CODE_A_KSC;
            }
        }

        /// <summary>
        /// KSC (Staff Positions) related entity by [SF.POS_CODE_B]-&gt;[KSC.KSCKEY]
        /// Reference to Staff Position (2)
        /// </summary>
        public KSC POS_CODE_B_KSC
        {
            get
            {
                if (POS_CODE_B == null)
                {
                    return null;
                }
                if (Cache_POS_CODE_B_KSC == null)
                {
                    Cache_POS_CODE_B_KSC = Context.KSC.FindByKSCKEY(POS_CODE_B);
                }

                return Cache_POS_CODE_B_KSC;
            }
        }

        /// <summary>
        /// KSA (Areas of Teaching) related entity by [SF.MAJORA]-&gt;[KSA.KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA MAJORA_KSA
        {
            get
            {
                if (MAJORA == null)
                {
                    return null;
                }
                if (Cache_MAJORA_KSA == null)
                {
                    Cache_MAJORA_KSA = Context.KSA.FindByKSAKEY(MAJORA);
                }

                return Cache_MAJORA_KSA;
            }
        }

        /// <summary>
        /// KSA (Areas of Teaching) related entity by [SF.MAJORB]-&gt;[KSA.KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA MAJORB_KSA
        {
            get
            {
                if (MAJORB == null)
                {
                    return null;
                }
                if (Cache_MAJORB_KSA == null)
                {
                    Cache_MAJORB_KSA = Context.KSA.FindByKSAKEY(MAJORB);
                }

                return Cache_MAJORB_KSA;
            }
        }

        /// <summary>
        /// KSA (Areas of Teaching) related entity by [SF.MAJORC]-&gt;[KSA.KSAKEY]
        /// Major area of teaching otherwise not available
        /// </summary>
        public KSA MAJORC_KSA
        {
            get
            {
                if (MAJORC == null)
                {
                    return null;
                }
                if (Cache_MAJORC_KSA == null)
                {
                    Cache_MAJORC_KSA = Context.KSA.FindByKSAKEY(MAJORC);
                }

                return Cache_MAJORC_KSA;
            }
        }

        /// <summary>
        /// KGR (Religions) related entity by [SF.RELIGION]-&gt;[KGR.RELIGION]
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
        /// KGT (Countries) related entity by [SF.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// (Was COUNTRY_BIRTH) Country of birth
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
        /// KGL (Languages) related entity by [SF.LANG01]-&gt;[KGL.KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL LANG01_KGL
        {
            get
            {
                if (LANG01 == null)
                {
                    return null;
                }
                if (Cache_LANG01_KGL == null)
                {
                    Cache_LANG01_KGL = Context.KGL.FindByKGLKEY(LANG01);
                }

                return Cache_LANG01_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [SF.LANG02]-&gt;[KGL.KGLKEY]
        /// Language(s) spoken by this staff member
        /// </summary>
        public KGL LANG02_KGL
        {
            get
            {
                if (LANG02 == null)
                {
                    return null;
                }
                if (Cache_LANG02_KGL == null)
                {
                    Cache_LANG02_KGL = Context.KGL.FindByKGLKEY(LANG02);
                }

                return Cache_LANG02_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [SF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
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
        /// KGL (Languages) related entity by [SF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
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
        /// DR (Accounts Receivable) related entity by [SF.DEBTOR_ID]-&gt;[DR.DRKEY]
        /// Link to sundry debtors
        /// </summary>
        public DR DEBTOR_ID_DR
        {
            get
            {
                if (DEBTOR_ID == null)
                {
                    return null;
                }
                if (Cache_DEBTOR_ID_DR == null)
                {
                    Cache_DEBTOR_ID_DR = Context.DR.FindByDRKEY(DEBTOR_ID);
                }

                return Cache_DEBTOR_ID_DR;
            }
        }

        /// <summary>
        /// SP_REPLY (SMS Reply Recipient Groups) related entity by [SF.SMS_REPLY]-&gt;[SP_REPLY.CODE]
        /// SMS Reply Recipient Group key
        /// </summary>
        public SP_REPLY SMS_REPLY_SP_REPLY
        {
            get
            {
                if (SMS_REPLY == null)
                {
                    return null;
                }
                if (Cache_SMS_REPLY_SP_REPLY == null)
                {
                    Cache_SMS_REPLY_SP_REPLY = Context.SP_REPLY.FindByCODE(SMS_REPLY);
                }

                return Cache_SMS_REPLY_SP_REPLY;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// AKK (Asset Key Holders) related entities by [SF.SFKEY]-&gt;[AKK.STAFF]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<AKK> SFKEY_AKK_STAFF
        {
            get
            {
                if (Cache_SFKEY_AKK_STAFF == null &&
                    !Context.AKK.TryFindBySTAFF(SFKEY, out Cache_SFKEY_AKK_STAFF))
                {
                    Cache_SFKEY_AKK_STAFF = new List<AKK>().AsReadOnly();
                }

                return Cache_SFKEY_AKK_STAFF;
            }
        }

        /// <summary>
        /// BKHR (Book Hire Records) related entities by [SF.SFKEY]-&gt;[BKHR.STAFF]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<BKHR> SFKEY_BKHR_STAFF
        {
            get
            {
                if (Cache_SFKEY_BKHR_STAFF == null &&
                    !Context.BKHR.TryFindBySTAFF(SFKEY, out Cache_SFKEY_BKHR_STAFF))
                {
                    Cache_SFKEY_BKHR_STAFF = new List<BKHR>().AsReadOnly();
                }

                return Cache_SFKEY_BKHR_STAFF;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [SF.SFKEY]-&gt;[CRF.APPROVED_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<CRF> SFKEY_CRF_APPROVED_BY
        {
            get
            {
                if (Cache_SFKEY_CRF_APPROVED_BY == null &&
                    !Context.CRF.TryFindByAPPROVED_BY(SFKEY, out Cache_SFKEY_CRF_APPROVED_BY))
                {
                    Cache_SFKEY_CRF_APPROVED_BY = new List<CRF>().AsReadOnly();
                }

                return Cache_SFKEY_CRF_APPROVED_BY;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [SF.SFKEY]-&gt;[CRF.STAFF_ORDER_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<CRF> SFKEY_CRF_STAFF_ORDER_BY
        {
            get
            {
                if (Cache_SFKEY_CRF_STAFF_ORDER_BY == null &&
                    !Context.CRF.TryFindBySTAFF_ORDER_BY(SFKEY, out Cache_SFKEY_CRF_STAFF_ORDER_BY))
                {
                    Cache_SFKEY_CRF_STAFF_ORDER_BY = new List<CRF>().AsReadOnly();
                }

                return Cache_SFKEY_CRF_STAFF_ORDER_BY;
            }
        }

        /// <summary>
        /// CRPR (Creditor Purchase Requisitions) related entities by [SF.SFKEY]-&gt;[CRPR.STAFF_ORDER_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<CRPR> SFKEY_CRPR_STAFF_ORDER_BY
        {
            get
            {
                if (Cache_SFKEY_CRPR_STAFF_ORDER_BY == null &&
                    !Context.CRPR.TryFindBySTAFF_ORDER_BY(SFKEY, out Cache_SFKEY_CRPR_STAFF_ORDER_BY))
                {
                    Cache_SFKEY_CRPR_STAFF_ORDER_BY = new List<CRPR>().AsReadOnly();
                }

                return Cache_SFKEY_CRPR_STAFF_ORDER_BY;
            }
        }

        /// <summary>
        /// CRPR (Creditor Purchase Requisitions) related entities by [SF.SFKEY]-&gt;[CRPR.APPROVED_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<CRPR> SFKEY_CRPR_APPROVED_BY
        {
            get
            {
                if (Cache_SFKEY_CRPR_APPROVED_BY == null &&
                    !Context.CRPR.TryFindByAPPROVED_BY(SFKEY, out Cache_SFKEY_CRPR_APPROVED_BY))
                {
                    Cache_SFKEY_CRPR_APPROVED_BY = new List<CRPR>().AsReadOnly();
                }

                return Cache_SFKEY_CRPR_APPROVED_BY;
            }
        }

        /// <summary>
        /// CRTT (Creditor Trade Types) related entities by [SF.SFKEY]-&gt;[CRTT.STAFF]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<CRTT> SFKEY_CRTT_STAFF
        {
            get
            {
                if (Cache_SFKEY_CRTT_STAFF == null &&
                    !Context.CRTT.TryFindBySTAFF(SFKEY, out Cache_SFKEY_CRTT_STAFF))
                {
                    Cache_SFKEY_CRTT_STAFF = new List<CRTT>().AsReadOnly();
                }

                return Cache_SFKEY_CRTT_STAFF;
            }
        }

        /// <summary>
        /// KCPC (Creditor Purchasing Card) related entities by [SF.SFKEY]-&gt;[KCPC.STAFF]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<KCPC> SFKEY_KCPC_STAFF
        {
            get
            {
                if (Cache_SFKEY_KCPC_STAFF == null &&
                    !Context.KCPC.TryFindBySTAFF(SFKEY, out Cache_SFKEY_KCPC_STAFF))
                {
                    Cache_SFKEY_KCPC_STAFF = new List<KCPC>().AsReadOnly();
                }

                return Cache_SFKEY_KCPC_STAFF;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entities by [SF.SFKEY]-&gt;[KCY.TEACHER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<KCY> SFKEY_KCY_TEACHER
        {
            get
            {
                if (Cache_SFKEY_KCY_TEACHER == null &&
                    !Context.KCY.TryFindByTEACHER(SFKEY, out Cache_SFKEY_KCY_TEACHER))
                {
                    Cache_SFKEY_KCY_TEACHER = new List<KCY>().AsReadOnly();
                }

                return Cache_SFKEY_KCY_TEACHER;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entities by [SF.SFKEY]-&gt;[KCY.TEACHER_B]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<KCY> SFKEY_KCY_TEACHER_B
        {
            get
            {
                if (Cache_SFKEY_KCY_TEACHER_B == null &&
                    !Context.KCY.TryFindByTEACHER_B(SFKEY, out Cache_SFKEY_KCY_TEACHER_B))
                {
                    Cache_SFKEY_KCY_TEACHER_B = new List<KCY>().AsReadOnly();
                }

                return Cache_SFKEY_KCY_TEACHER_B;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [SF.SFKEY]-&gt;[KGC.TEACHER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<KGC> SFKEY_KGC_TEACHER
        {
            get
            {
                if (Cache_SFKEY_KGC_TEACHER == null &&
                    !Context.KGC.TryFindByTEACHER(SFKEY, out Cache_SFKEY_KGC_TEACHER))
                {
                    Cache_SFKEY_KGC_TEACHER = new List<KGC>().AsReadOnly();
                }

                return Cache_SFKEY_KGC_TEACHER;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [SF.SFKEY]-&gt;[KGC.TEACHER_B]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<KGC> SFKEY_KGC_TEACHER_B
        {
            get
            {
                if (Cache_SFKEY_KGC_TEACHER_B == null &&
                    !Context.KGC.TryFindByTEACHER_B(SFKEY, out Cache_SFKEY_KGC_TEACHER_B))
                {
                    Cache_SFKEY_KGC_TEACHER_B = new List<KGC>().AsReadOnly();
                }

                return Cache_SFKEY_KGC_TEACHER_B;
            }
        }

        /// <summary>
        /// KSF (Faculties) related entities by [SF.SFKEY]-&gt;[KSF.COORDINATOR]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<KSF> SFKEY_KSF_COORDINATOR
        {
            get
            {
                if (Cache_SFKEY_KSF_COORDINATOR == null &&
                    !Context.KSF.TryFindByCOORDINATOR(SFKEY, out Cache_SFKEY_KSF_COORDINATOR))
                {
                    Cache_SFKEY_KSF_COORDINATOR = new List<KSF>().AsReadOnly();
                }

                return Cache_SFKEY_KSF_COORDINATOR;
            }
        }

        /// <summary>
        /// PGID (General Ledger Import Details) related entities by [SF.SFKEY]-&gt;[PGID.IMPORTED_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<PGID> SFKEY_PGID_IMPORTED_BY
        {
            get
            {
                if (Cache_SFKEY_PGID_IMPORTED_BY == null &&
                    !Context.PGID.TryFindByIMPORTED_BY(SFKEY, out Cache_SFKEY_PGID_IMPORTED_BY))
                {
                    Cache_SFKEY_PGID_IMPORTED_BY = new List<PGID>().AsReadOnly();
                }

                return Cache_SFKEY_PGID_IMPORTED_BY;
            }
        }

        /// <summary>
        /// RQ (Purchase Requisition) related entities by [SF.SFKEY]-&gt;[RQ.ORDER_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<RQ> SFKEY_RQ_ORDER_BY
        {
            get
            {
                if (Cache_SFKEY_RQ_ORDER_BY == null &&
                    !Context.RQ.TryFindByORDER_BY(SFKEY, out Cache_SFKEY_RQ_ORDER_BY))
                {
                    Cache_SFKEY_RQ_ORDER_BY = new List<RQ>().AsReadOnly();
                }

                return Cache_SFKEY_RQ_ORDER_BY;
            }
        }

        /// <summary>
        /// RQ (Purchase Requisition) related entities by [SF.SFKEY]-&gt;[RQ.APPROVED_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<RQ> SFKEY_RQ_APPROVED_BY
        {
            get
            {
                if (Cache_SFKEY_RQ_APPROVED_BY == null &&
                    !Context.RQ.TryFindByAPPROVED_BY(SFKEY, out Cache_SFKEY_RQ_APPROVED_BY))
                {
                    Cache_SFKEY_RQ_APPROVED_BY = new List<RQ>().AsReadOnly();
                }

                return Cache_SFKEY_RQ_APPROVED_BY;
            }
        }

        /// <summary>
        /// RQPG (Purchasing Group) related entities by [SF.SFKEY]-&gt;[RQPG.SFKEY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<RQPG> SFKEY_RQPG_SFKEY
        {
            get
            {
                if (Cache_SFKEY_RQPG_SFKEY == null &&
                    !Context.RQPG.TryFindBySFKEY(SFKEY, out Cache_SFKEY_RQPG_SFKEY))
                {
                    Cache_SFKEY_RQPG_SFKEY = new List<RQPG>().AsReadOnly();
                }

                return Cache_SFKEY_RQPG_SFKEY;
            }
        }

        /// <summary>
        /// RQREL (Staff Purchasing Group Link) related entities by [SF.SFKEY]-&gt;[RQREL.SFKEY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<RQREL> SFKEY_RQREL_SFKEY
        {
            get
            {
                if (Cache_SFKEY_RQREL_SFKEY == null &&
                    !Context.RQREL.TryFindBySFKEY(SFKEY, out Cache_SFKEY_RQREL_SFKEY))
                {
                    Cache_SFKEY_RQREL_SFKEY = new List<RQREL>().AsReadOnly();
                }

                return Cache_SFKEY_RQREL_SFKEY;
            }
        }

        /// <summary>
        /// SAD (Accidents) related entities by [SF.SFKEY]-&gt;[SAD.AREA_DUTY_TEACHER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SAD> SFKEY_SAD_AREA_DUTY_TEACHER
        {
            get
            {
                if (Cache_SFKEY_SAD_AREA_DUTY_TEACHER == null &&
                    !Context.SAD.TryFindByAREA_DUTY_TEACHER(SFKEY, out Cache_SFKEY_SAD_AREA_DUTY_TEACHER))
                {
                    Cache_SFKEY_SAD_AREA_DUTY_TEACHER = new List<SAD>().AsReadOnly();
                }

                return Cache_SFKEY_SAD_AREA_DUTY_TEACHER;
            }
        }

        /// <summary>
        /// SAIM (Sickbay Medication Administrations) related entities by [SF.SFKEY]-&gt;[SAIM.STAFF]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SAIM> SFKEY_SAIM_STAFF
        {
            get
            {
                if (Cache_SFKEY_SAIM_STAFF == null &&
                    !Context.SAIM.TryFindBySTAFF(SFKEY, out Cache_SFKEY_SAIM_STAFF))
                {
                    Cache_SFKEY_SAIM_STAFF = new List<SAIM>().AsReadOnly();
                }

                return Cache_SFKEY_SAIM_STAFF;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SCH_PRINCIPAL]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SCH_PRINCIPAL
        {
            get
            {
                if (Cache_SFKEY_SCI_SCH_PRINCIPAL == null &&
                    !Context.SCI.TryFindBySCH_PRINCIPAL(SFKEY, out Cache_SFKEY_SCI_SCH_PRINCIPAL))
                {
                    Cache_SFKEY_SCI_SCH_PRINCIPAL = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SCH_PRINCIPAL;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_OIC]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_OIC
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_OIC == null &&
                    !Context.SCI.TryFindBySF_OIC(SFKEY, out Cache_SFKEY_SCI_SF_OIC))
                {
                    Cache_SFKEY_SCI_SF_OIC = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_OIC;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_VPRIN]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_VPRIN
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_VPRIN == null &&
                    !Context.SCI.TryFindBySF_VPRIN(SFKEY, out Cache_SFKEY_SCI_SF_VPRIN))
                {
                    Cache_SFKEY_SCI_SF_VPRIN = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_VPRIN;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_2VPRIN]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_2VPRIN
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_2VPRIN == null &&
                    !Context.SCI.TryFindBySF_2VPRIN(SFKEY, out Cache_SFKEY_SCI_SF_2VPRIN))
                {
                    Cache_SFKEY_SCI_SF_2VPRIN = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_2VPRIN;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_3VPRIN]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_3VPRIN
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_3VPRIN == null &&
                    !Context.SCI.TryFindBySF_3VPRIN(SFKEY, out Cache_SFKEY_SCI_SF_3VPRIN))
                {
                    Cache_SFKEY_SCI_SF_3VPRIN = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_3VPRIN;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_APRIN]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_APRIN
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_APRIN == null &&
                    !Context.SCI.TryFindBySF_APRIN(SFKEY, out Cache_SFKEY_SCI_SF_APRIN))
                {
                    Cache_SFKEY_SCI_SF_APRIN = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_APRIN;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_BMANAGER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_BMANAGER
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_BMANAGER == null &&
                    !Context.SCI.TryFindBySF_BMANAGER(SFKEY, out Cache_SFKEY_SCI_SF_BMANAGER))
                {
                    Cache_SFKEY_SCI_SF_BMANAGER = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_BMANAGER;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_VAC_CONTACT]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_VAC_CONTACT
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_VAC_CONTACT == null &&
                    !Context.SCI.TryFindBySF_VAC_CONTACT(SFKEY, out Cache_SFKEY_SCI_SF_VAC_CONTACT))
                {
                    Cache_SFKEY_SCI_SF_VAC_CONTACT = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_VAC_CONTACT;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_EMERG_CONTACT]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_EMERG_CONTACT
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_EMERG_CONTACT == null &&
                    !Context.SCI.TryFindBySF_EMERG_CONTACT(SFKEY, out Cache_SFKEY_SCI_SF_EMERG_CONTACT))
                {
                    Cache_SFKEY_SCI_SF_EMERG_CONTACT = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_EMERG_CONTACT;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SCH_AOIC]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SCH_AOIC
        {
            get
            {
                if (Cache_SFKEY_SCI_SCH_AOIC == null &&
                    !Context.SCI.TryFindBySCH_AOIC(SFKEY, out Cache_SFKEY_SCI_SCH_AOIC))
                {
                    Cache_SFKEY_SCI_SCH_AOIC = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SCH_AOIC;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SCH_VPRIN]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SCH_VPRIN
        {
            get
            {
                if (Cache_SFKEY_SCI_SCH_VPRIN == null &&
                    !Context.SCI.TryFindBySCH_VPRIN(SFKEY, out Cache_SFKEY_SCI_SCH_VPRIN))
                {
                    Cache_SFKEY_SCI_SCH_VPRIN = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SCH_VPRIN;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SCH_BMANAGER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SCH_BMANAGER
        {
            get
            {
                if (Cache_SFKEY_SCI_SCH_BMANAGER == null &&
                    !Context.SCI.TryFindBySCH_BMANAGER(SFKEY, out Cache_SFKEY_SCI_SCH_BMANAGER))
                {
                    Cache_SFKEY_SCI_SCH_BMANAGER = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SCH_BMANAGER;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SCH_VAC_CONTACT]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SCH_VAC_CONTACT
        {
            get
            {
                if (Cache_SFKEY_SCI_SCH_VAC_CONTACT == null &&
                    !Context.SCI.TryFindBySCH_VAC_CONTACT(SFKEY, out Cache_SFKEY_SCI_SCH_VAC_CONTACT))
                {
                    Cache_SFKEY_SCI_SCH_VAC_CONTACT = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SCH_VAC_CONTACT;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SCH_EMERG_CONTACT]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SCH_EMERG_CONTACT
        {
            get
            {
                if (Cache_SFKEY_SCI_SCH_EMERG_CONTACT == null &&
                    !Context.SCI.TryFindBySCH_EMERG_CONTACT(SFKEY, out Cache_SFKEY_SCI_SCH_EMERG_CONTACT))
                {
                    Cache_SFKEY_SCI_SCH_EMERG_CONTACT = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SCH_EMERG_CONTACT;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SF.SFKEY]-&gt;[SCI.SF_PURCH_MANAGER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCI> SFKEY_SCI_SF_PURCH_MANAGER
        {
            get
            {
                if (Cache_SFKEY_SCI_SF_PURCH_MANAGER == null &&
                    !Context.SCI.TryFindBySF_PURCH_MANAGER(SFKEY, out Cache_SFKEY_SCI_SF_PURCH_MANAGER))
                {
                    Cache_SFKEY_SCI_SF_PURCH_MANAGER = new List<SCI>().AsReadOnly();
                }

                return Cache_SFKEY_SCI_SF_PURCH_MANAGER;
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SF.SFKEY]-&gt;[SCL.TEACHER01]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCL> SFKEY_SCL_TEACHER01
        {
            get
            {
                if (Cache_SFKEY_SCL_TEACHER01 == null &&
                    !Context.SCL.TryFindByTEACHER01(SFKEY, out Cache_SFKEY_SCL_TEACHER01))
                {
                    Cache_SFKEY_SCL_TEACHER01 = new List<SCL>().AsReadOnly();
                }

                return Cache_SFKEY_SCL_TEACHER01;
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SF.SFKEY]-&gt;[SCL.TEACHER02]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SCL> SFKEY_SCL_TEACHER02
        {
            get
            {
                if (Cache_SFKEY_SCL_TEACHER02 == null &&
                    !Context.SCL.TryFindByTEACHER02(SFKEY, out Cache_SFKEY_SCL_TEACHER02))
                {
                    Cache_SFKEY_SCL_TEACHER02 = new List<SCL>().AsReadOnly();
                }

                return Cache_SFKEY_SCL_TEACHER02;
            }
        }

        /// <summary>
        /// SDPA (Disciplinary Actions) related entities by [SF.SFKEY]-&gt;[SDPA.TAKEN_BY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SDPA> SFKEY_SDPA_TAKEN_BY
        {
            get
            {
                if (Cache_SFKEY_SDPA_TAKEN_BY == null &&
                    !Context.SDPA.TryFindByTAKEN_BY(SFKEY, out Cache_SFKEY_SDPA_TAKEN_BY))
                {
                    Cache_SFKEY_SDPA_TAKEN_BY = new List<SDPA>().AsReadOnly();
                }

                return Cache_SFKEY_SDPA_TAKEN_BY;
            }
        }

        /// <summary>
        /// SFAQ (Staff Availability in Quilt) related entities by [SF.SFKEY]-&gt;[SFAQ.SFAQKEY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SFAQ> SFKEY_SFAQ_SFAQKEY
        {
            get
            {
                if (Cache_SFKEY_SFAQ_SFAQKEY == null &&
                    !Context.SFAQ.TryFindBySFAQKEY(SFKEY, out Cache_SFKEY_SFAQ_SFAQKEY))
                {
                    Cache_SFKEY_SFAQ_SFAQKEY = new List<SFAQ>().AsReadOnly();
                }

                return Cache_SFKEY_SFAQ_SFAQKEY;
            }
        }

        /// <summary>
        /// SFAV (Staff Availability for Calendar Extras) related entities by [SF.SFKEY]-&gt;[SFAV.TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SFAV> SFKEY_SFAV_TEACH
        {
            get
            {
                if (Cache_SFKEY_SFAV_TEACH == null &&
                    !Context.SFAV.TryFindByTEACH(SFKEY, out Cache_SFKEY_SFAV_TEACH))
                {
                    Cache_SFKEY_SFAV_TEACH = new List<SFAV>().AsReadOnly();
                }

                return Cache_SFKEY_SFAV_TEACH;
            }
        }

        /// <summary>
        /// SFQA (Staff Qualifications) related entities by [SF.SFKEY]-&gt;[SFQA.TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SFQA> SFKEY_SFQA_TEACH
        {
            get
            {
                if (Cache_SFKEY_SFQA_TEACH == null &&
                    !Context.SFQA.TryFindByTEACH(SFKEY, out Cache_SFKEY_SFQA_TEACH))
                {
                    Cache_SFKEY_SFQA_TEACH = new List<SFQA>().AsReadOnly();
                }

                return Cache_SFKEY_SFQA_TEACH;
            }
        }

        /// <summary>
        /// SM (Rooms) related entities by [SF.SFKEY]-&gt;[SM.STAFF_CODE]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SM> SFKEY_SM_STAFF_CODE
        {
            get
            {
                if (Cache_SFKEY_SM_STAFF_CODE == null &&
                    !Context.SM.TryFindBySTAFF_CODE(SFKEY, out Cache_SFKEY_SM_STAFF_CODE))
                {
                    Cache_SFKEY_SM_STAFF_CODE = new List<SM>().AsReadOnly();
                }

                return Cache_SFKEY_SM_STAFF_CODE;
            }
        }

        /// <summary>
        /// SMCD (Student Medication Doses) related entities by [SF.SFKEY]-&gt;[SMCD.STAFF]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SMCD> SFKEY_SMCD_STAFF
        {
            get
            {
                if (Cache_SFKEY_SMCD_STAFF == null &&
                    !Context.SMCD.TryFindBySTAFF(SFKEY, out Cache_SFKEY_SMCD_STAFF))
                {
                    Cache_SFKEY_SMCD_STAFF = new List<SMCD>().AsReadOnly();
                }

                return Cache_SFKEY_SMCD_STAFF;
            }
        }

        /// <summary>
        /// SP_RECIP (SMS Reply Recipients) related entities by [SF.SFKEY]-&gt;[SP_RECIP.SFKEY]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SP_RECIP> SFKEY_SP_RECIP_SFKEY
        {
            get
            {
                if (Cache_SFKEY_SP_RECIP_SFKEY == null &&
                    !Context.SP_RECIP.TryFindBySFKEY(SFKEY, out Cache_SFKEY_SP_RECIP_SFKEY))
                {
                    Cache_SFKEY_SP_RECIP_SFKEY = new List<SP_RECIP>().AsReadOnly();
                }

                return Cache_SFKEY_SP_RECIP_SFKEY;
            }
        }

        /// <summary>
        /// SS (Specialist Subjects) related entities by [SF.SFKEY]-&gt;[SS.DEFAULT_TEACHER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SS> SFKEY_SS_DEFAULT_TEACHER
        {
            get
            {
                if (Cache_SFKEY_SS_DEFAULT_TEACHER == null &&
                    !Context.SS.TryFindByDEFAULT_TEACHER(SFKEY, out Cache_SFKEY_SS_DEFAULT_TEACHER))
                {
                    Cache_SFKEY_SS_DEFAULT_TEACHER = new List<SS>().AsReadOnly();
                }

                return Cache_SFKEY_SS_DEFAULT_TEACHER;
            }
        }

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [SF.SFKEY]-&gt;[SSHG.TEACHER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<SSHG> SFKEY_SSHG_TEACHER
        {
            get
            {
                if (Cache_SFKEY_SSHG_TEACHER == null &&
                    !Context.SSHG.TryFindByTEACHER(SFKEY, out Cache_SFKEY_SSHG_TEACHER))
                {
                    Cache_SFKEY_SSHG_TEACHER = new List<SSHG>().AsReadOnly();
                }

                return Cache_SFKEY_SSHG_TEACHER;
            }
        }

        /// <summary>
        /// STSP (Suspension Details) related entities by [SF.SFKEY]-&gt;[STSP.REF_TEACHERA]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<STSP> SFKEY_STSP_REF_TEACHERA
        {
            get
            {
                if (Cache_SFKEY_STSP_REF_TEACHERA == null &&
                    !Context.STSP.TryFindByREF_TEACHERA(SFKEY, out Cache_SFKEY_STSP_REF_TEACHERA))
                {
                    Cache_SFKEY_STSP_REF_TEACHERA = new List<STSP>().AsReadOnly();
                }

                return Cache_SFKEY_STSP_REF_TEACHERA;
            }
        }

        /// <summary>
        /// STSP (Suspension Details) related entities by [SF.SFKEY]-&gt;[STSP.REF_TEACHERB]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<STSP> SFKEY_STSP_REF_TEACHERB
        {
            get
            {
                if (Cache_SFKEY_STSP_REF_TEACHERB == null &&
                    !Context.STSP.TryFindByREF_TEACHERB(SFKEY, out Cache_SFKEY_STSP_REF_TEACHERB))
                {
                    Cache_SFKEY_STSP_REF_TEACHERB = new List<STSP>().AsReadOnly();
                }

                return Cache_SFKEY_STSP_REF_TEACHERB;
            }
        }

        /// <summary>
        /// TCTB (Teacher Absences) related entities by [SF.SFKEY]-&gt;[TCTB.TEACHER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TCTB> SFKEY_TCTB_TEACHER
        {
            get
            {
                if (Cache_SFKEY_TCTB_TEACHER == null &&
                    !Context.TCTB.TryFindByTEACHER(SFKEY, out Cache_SFKEY_TCTB_TEACHER))
                {
                    Cache_SFKEY_TCTB_TEACHER = new List<TCTB>().AsReadOnly();
                }

                return Cache_SFKEY_TCTB_TEACHER;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [SF.SFKEY]-&gt;[TCTQ.T1TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TCTQ> SFKEY_TCTQ_T1TEACH
        {
            get
            {
                if (Cache_SFKEY_TCTQ_T1TEACH == null &&
                    !Context.TCTQ.TryFindByT1TEACH(SFKEY, out Cache_SFKEY_TCTQ_T1TEACH))
                {
                    Cache_SFKEY_TCTQ_T1TEACH = new List<TCTQ>().AsReadOnly();
                }

                return Cache_SFKEY_TCTQ_T1TEACH;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [SF.SFKEY]-&gt;[TCTQ.T2TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TCTQ> SFKEY_TCTQ_T2TEACH
        {
            get
            {
                if (Cache_SFKEY_TCTQ_T2TEACH == null &&
                    !Context.TCTQ.TryFindByT2TEACH(SFKEY, out Cache_SFKEY_TCTQ_T2TEACH))
                {
                    Cache_SFKEY_TCTQ_T2TEACH = new List<TCTQ>().AsReadOnly();
                }

                return Cache_SFKEY_TCTQ_T2TEACH;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [SF.SFKEY]-&gt;[TCTQ.EXTRA_TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TCTQ> SFKEY_TCTQ_EXTRA_TEACH
        {
            get
            {
                if (Cache_SFKEY_TCTQ_EXTRA_TEACH == null &&
                    !Context.TCTQ.TryFindByEXTRA_TEACH(SFKEY, out Cache_SFKEY_TCTQ_EXTRA_TEACH))
                {
                    Cache_SFKEY_TCTQ_EXTRA_TEACH = new List<TCTQ>().AsReadOnly();
                }

                return Cache_SFKEY_TCTQ_EXTRA_TEACH;
            }
        }

        /// <summary>
        /// TCTR (Teacher Replacements) related entities by [SF.SFKEY]-&gt;[TCTR.TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TCTR> SFKEY_TCTR_TEACH
        {
            get
            {
                if (Cache_SFKEY_TCTR_TEACH == null &&
                    !Context.TCTR.TryFindByTEACH(SFKEY, out Cache_SFKEY_TCTR_TEACH))
                {
                    Cache_SFKEY_TCTR_TEACH = new List<TCTR>().AsReadOnly();
                }

                return Cache_SFKEY_TCTR_TEACH;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [SF.SFKEY]-&gt;[THTQ.T1TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<THTQ> SFKEY_THTQ_T1TEACH
        {
            get
            {
                if (Cache_SFKEY_THTQ_T1TEACH == null &&
                    !Context.THTQ.TryFindByT1TEACH(SFKEY, out Cache_SFKEY_THTQ_T1TEACH))
                {
                    Cache_SFKEY_THTQ_T1TEACH = new List<THTQ>().AsReadOnly();
                }

                return Cache_SFKEY_THTQ_T1TEACH;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [SF.SFKEY]-&gt;[THTQ.T2TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<THTQ> SFKEY_THTQ_T2TEACH
        {
            get
            {
                if (Cache_SFKEY_THTQ_T2TEACH == null &&
                    !Context.THTQ.TryFindByT2TEACH(SFKEY, out Cache_SFKEY_THTQ_T2TEACH))
                {
                    Cache_SFKEY_THTQ_T2TEACH = new List<THTQ>().AsReadOnly();
                }

                return Cache_SFKEY_THTQ_T2TEACH;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [SF.SFKEY]-&gt;[THTQ.EXTRA_TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<THTQ> SFKEY_THTQ_EXTRA_TEACH
        {
            get
            {
                if (Cache_SFKEY_THTQ_EXTRA_TEACH == null &&
                    !Context.THTQ.TryFindByEXTRA_TEACH(SFKEY, out Cache_SFKEY_THTQ_EXTRA_TEACH))
                {
                    Cache_SFKEY_THTQ_EXTRA_TEACH = new List<THTQ>().AsReadOnly();
                }

                return Cache_SFKEY_THTQ_EXTRA_TEACH;
            }
        }

        /// <summary>
        /// TTEF (Exam Staff) related entities by [SF.SFKEY]-&gt;[TTEF.STAFF]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TTEF> SFKEY_TTEF_STAFF
        {
            get
            {
                if (Cache_SFKEY_TTEF_STAFF == null &&
                    !Context.TTEF.TryFindBySTAFF(SFKEY, out Cache_SFKEY_TTEF_STAFF))
                {
                    Cache_SFKEY_TTEF_STAFF = new List<TTEF>().AsReadOnly();
                }

                return Cache_SFKEY_TTEF_STAFF;
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [SF.SFKEY]-&gt;[TTTG.T1TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TTTG> SFKEY_TTTG_T1TEACH
        {
            get
            {
                if (Cache_SFKEY_TTTG_T1TEACH == null &&
                    !Context.TTTG.TryFindByT1TEACH(SFKEY, out Cache_SFKEY_TTTG_T1TEACH))
                {
                    Cache_SFKEY_TTTG_T1TEACH = new List<TTTG>().AsReadOnly();
                }

                return Cache_SFKEY_TTTG_T1TEACH;
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [SF.SFKEY]-&gt;[TTTG.T2TEACH]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TTTG> SFKEY_TTTG_T2TEACH
        {
            get
            {
                if (Cache_SFKEY_TTTG_T2TEACH == null &&
                    !Context.TTTG.TryFindByT2TEACH(SFKEY, out Cache_SFKEY_TTTG_T2TEACH))
                {
                    Cache_SFKEY_TTTG_T2TEACH = new List<TTTG>().AsReadOnly();
                }

                return Cache_SFKEY_TTTG_T2TEACH;
            }
        }

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [SF.SFKEY]-&gt;[TXAS.TEACHER]
        /// Staff member code
        /// </summary>
        public IReadOnlyList<TXAS> SFKEY_TXAS_TEACHER
        {
            get
            {
                if (Cache_SFKEY_TXAS_TEACHER == null &&
                    !Context.TXAS.TryFindByTEACHER(SFKEY, out Cache_SFKEY_TXAS_TEACHER))
                {
                    Cache_SFKEY_TXAS_TEACHER = new List<TXAS>().AsReadOnly();
                }

                return Cache_SFKEY_TXAS_TEACHER;
            }
        }

        #endregion

    }
}
