using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Families
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DF : EduHubEntity
    {

        #region Navigation Property Cache

        private KGL Cache_NATIVE_LANG_A_KGL;
        private KGL Cache_OTHER_LANG_A_KGL;
        private KGT Cache_BIRTH_COUNTRY_A_KGT;
        private KGL Cache_LOTE_HOME_CODE_A_KGL;
        private KGL Cache_NATIVE_LANG_B_KGL;
        private KGL Cache_OTHER_LANG_B_KGL;
        private KGT Cache_BIRTH_COUNTRY_B_KGT;
        private KGL Cache_LOTE_HOME_CODE_B_KGL;
        private KGL Cache_PREF_NOTICE_LANG_KGL;
        private UM Cache_HOMEKEY_UM;
        private UM Cache_MAILKEY_UM;
        private UM Cache_BILLINGKEY_UM;
        private KCD Cache_DOCTOR_KCD;
        private KGL Cache_EMERG_LANG01_KGL;
        private KGL Cache_EMERG_LANG02_KGL;
        private KGL Cache_EMERG_LANG03_KGL;
        private KGL Cache_EMERG_LANG04_KGL;
        private KGL Cache_HOME_LANG_KGL;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<DFB> Cache_DFKEY_DFB_FAM_CODE;
        private IReadOnlyList<DFF> Cache_DFKEY_DFF_CODE;
        private IReadOnlyList<DFHI> Cache_DFKEY_DFHI_FKEY;
        private IReadOnlyList<DFVT> Cache_DFKEY_DFVT_FAMILY;
        private IReadOnlyList<ST> Cache_DFKEY_ST_FAMILY;
        private IReadOnlyList<ST> Cache_DFKEY_ST_FAMB;
        private IReadOnlyList<ST> Cache_DFKEY_ST_FAMC;
        private IReadOnlyList<STSB> Cache_DFKEY_STSB_FAMILY;

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
        /// Family ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DFKEY { get; internal set; }

        /// <summary>
        /// (Was MNAME) Parent/guardian A first given name
        /// [Alphanumeric (30)]
        /// </summary>
        public string NAME_A { get; internal set; }

        /// <summary>
        /// (Was MSURNAME) Parent/guardian A surname (default SURNAME)
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME_A { get; internal set; }

        /// <summary>
        /// (Was MTITLE) Parent/guardian A title
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE_A { get; internal set; }

        /// <summary>
        /// (Was MWORK_CONT) Can parent/guardian A be contacted at work? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WORK_CONT_A { get; internal set; }

        /// <summary>
        /// (Was MOCCUPATION) Parent/guardian A occupation
        /// [Alphanumeric (35)]
        /// </summary>
        public string OCCUPATION_A { get; internal set; }

        /// <summary>
        /// (Was MEMPLOYER) Parent/guardian A employer
        /// [Alphanumeric (30)]
        /// </summary>
        public string EMPLOYER_A { get; internal set; }

        /// <summary>
        /// (Was MNATIVE_LANG) Parent/guardian A native language
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string NATIVE_LANG_A { get; internal set; }

        /// <summary>
        /// (Was M_OTHER_LANG) Parent/guardian A other language
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string OTHER_LANG_A { get; internal set; }

        /// <summary>
        /// (Was M_INTERPRETER) Parent/guardian A requires interpreter? Y=Yes, N=No, S=Sometimes
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTERPRETER_A { get; internal set; }

        /// <summary>
        /// (Was MBIRTH_COUNTRY) Parent/guardian A country of birth
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string BIRTH_COUNTRY_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A at home during business hours? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BH_AT_HOME_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A telephone contact if not at home during business hours
        /// [Memo]
        /// </summary>
        public string BH_CONTACT_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A at home after hours? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AH_AT_HOME_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A telephone contact if not at home after hours
        /// [Memo]
        /// </summary>
        public string AH_CONTACT_A { get; internal set; }

        /// <summary>
        /// (Was M_E_MAIL) Parent/guardian A e-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string E_MAIL_A { get; internal set; }

        /// <summary>
        /// (Was PREF_COM_A) Parent/guardian A preferred mail mechanism: M=Mail, E=E-mail, F=Fax, P=Phone
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PREF_MAIL_MECH_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A fax number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FAX_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A gender: M=Male, F=Female
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A School Education
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SCH_ED_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A Non School Education (0,5-8)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NON_SCH_ED_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A Occupation Status (A,B,C,D,N,U)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OCCUP_STATUS_A { get; internal set; }

        /// <summary>
        /// The Language other than English spoken at home by parent/guardian A
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LOTE_HOME_CODE_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A mobile number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE_A { get; internal set; }

        /// <summary>
        /// SMS can be used to notify this parent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SMS_NOTIFY_A { get; internal set; }

        /// <summary>
        /// Email can be used to notify this parent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string E_MAIL_NOTIFY_A { get; internal set; }

        /// <summary>
        /// (Was FNAME) Parent/guardian B first given name
        /// [Alphanumeric (30)]
        /// </summary>
        public string NAME_B { get; internal set; }

        /// <summary>
        /// (Was FSURNAME) Parent/guardian B surname (default SURNAME)
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME_B { get; internal set; }

        /// <summary>
        /// (Was FTITLE) Parent/guardian B title
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE_B { get; internal set; }

        /// <summary>
        /// (Was FWORK_CONT) Can parent/guardian B be contacted at work? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WORK_CONT_B { get; internal set; }

        /// <summary>
        /// (Was FOCCUPATION) Parent/guardian B occupation
        /// [Alphanumeric (35)]
        /// </summary>
        public string OCCUPATION_B { get; internal set; }

        /// <summary>
        /// (Was FEMPLOYER) Parent/guardian B employer
        /// [Alphanumeric (30)]
        /// </summary>
        public string EMPLOYER_B { get; internal set; }

        /// <summary>
        /// (Was FNATIVE_LANG) Parent/guardian B native language
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string NATIVE_LANG_B { get; internal set; }

        /// <summary>
        /// (Was F_OTHER_LANG) Parent/guardian B other language
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string OTHER_LANG_B { get; internal set; }

        /// <summary>
        /// (Was F_INTERPRETER) Parent/guardian B requires interpreter? Y=Yes, N=No, S=Sometimes
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INTERPRETER_B { get; internal set; }

        /// <summary>
        /// (Was FBIRTH_COUNTRY) Parent/guardian B country of birth
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string BIRTH_COUNTRY_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B at home during business hours? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BH_AT_HOME_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B telephone contact if not at home during business hours
        /// [Memo]
        /// </summary>
        public string BH_CONTACT_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B at home after hours? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AH_AT_HOME_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B telephone contact if not at home after hours
        /// [Memo]
        /// </summary>
        public string AH_CONTACT_B { get; internal set; }

        /// <summary>
        /// (Was F_E_MAIL) Parent/guardian B e-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string E_MAIL_B { get; internal set; }

        /// <summary>
        /// (Was PREF_COM_B) Parent/guardian B preferred mail mechanism: M=Mail, E=E-mail, F=Fax, P=Phone
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PREF_MAIL_MECH_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B fax number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FAX_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B gender: M=Male, F=Female
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B School Education (0-4)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SCH_ED_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B Non School Education (0,5-8)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NON_SCH_ED_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B Occupation Status (A,B,C,D,N,U)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OCCUP_STATUS_B { get; internal set; }

        /// <summary>
        /// The Language other than English spoken at home by parent/guardian B
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string LOTE_HOME_CODE_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B mobile number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE_B { get; internal set; }

        /// <summary>
        /// SMS can be used to notify this parent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SMS_NOTIFY_B { get; internal set; }

        /// <summary>
        /// Email can be used to notify this parent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string E_MAIL_NOTIFY_B { get; internal set; }

        /// <summary>
        /// Preferred language for notices
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string PREF_NOTICE_LANG { get; internal set; }

        /// <summary>
        /// (Was SG_PARTICIPATION) Special group participation: 1=Adult A, 2=Adult B, B=Both
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GROUP_AVAILABILITY { get; internal set; }

        /// <summary>
        /// (Was FAM_OCCUP) Family occupation status group (1-5)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OCCUP_STATUS_GRP { get; internal set; }

        /// <summary>
        /// Home addressee
        /// [Titlecase (30)]
        /// </summary>
        public string HOMETITLE { get; internal set; }

        /// <summary>
        /// Home address ID
        /// </summary>
        public int? HOMEKEY { get; internal set; }

        /// <summary>
        /// Mail addressee
        /// [Titlecase (30)]
        /// </summary>
        public string MAILTITLE { get; internal set; }

        /// <summary>
        /// Mail address ID
        /// </summary>
        public int? MAILKEY { get; internal set; }

        /// <summary>
        /// Billing name
        /// [Titlecase (40)]
        /// </summary>
        public string BILLINGTITLE { get; internal set; }

        /// <summary>
        /// Billing address ID
        /// </summary>
        public int? BILLINGKEY { get; internal set; }

        /// <summary>
        /// Billing memo
        /// [Memo]
        /// </summary>
        public string BILLING_MEMO { get; internal set; }

        /// <summary>
        /// Account type: 0=Brought forward, 1=Open item
        /// </summary>
        public short? ACCTYPE { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED01 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED02 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED03 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED04 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED05 { get; internal set; }

        /// <summary>
        /// Amount received in payment but not yet allocated to an invoice
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }

        /// <summary>
        /// Charges this year
        /// </summary>
        public decimal? CHARGES { get; internal set; }

        /// <summary>
        /// Last receipt amount
        /// </summary>
        public decimal? LASTREC { get; internal set; }

        /// <summary>
        /// Last receipt date
        /// </summary>
        public DateTime? LASTRECDATE { get; internal set; }

        /// <summary>
        /// Opening balance
        /// </summary>
        public decimal? OPBAL { get; internal set; }

        /// <summary>
        /// Opening balance at start of year
        /// </summary>
        public decimal? OPBAL_YEAR { get; internal set; }

        /// <summary>
        /// Auto access inventory price level: related to sale of stock items to families: to be retained at present
        /// </summary>
        public short? PRICELEVEL { get; internal set; }

        /// <summary>
        /// Seed number for BPAY reference
        /// </summary>
        public int? BPAY_SEQUENCE { get; internal set; }

        /// <summary>
        /// BPAY Reference number with check digit
        /// [Alphanumeric (20)]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }

        /// <summary>
        /// Number of current students for which this family is the PRIME family (automatically maintained by software) (cf NO_ASSOC_STUDENTS)
        /// </summary>
        public short? NO_STUDENTS { get; internal set; }

        /// <summary>
        /// Number of current students with which this family is associated (as Prime, Alternative or Additional family) (cf NO_STUDENTS)
        /// </summary>
        public short? NO_ASSOC_STUDENTS { get; internal set; }

        /// <summary>
        /// Credit limit
        /// </summary>
        public decimal? CREDIT_LIMIT { get; internal set; }

        /// <summary>
        /// Billing group
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string BILL_GROUP { get; internal set; }

        /// <summary>
        /// Reference to local doctor (default for each student)
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
        /// Name(s) of person(s) to contact in an emergency
        /// [Titlecase (30)]
        /// </summary>
        public string EMERG_NAME03 { get; internal set; }

        /// <summary>
        /// Name(s) of person(s) to contact in an emergency
        /// [Titlecase (30)]
        /// </summary>
        public string EMERG_NAME04 { get; internal set; }

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
        /// Relationship to a student in this family of each person to contact in an emergency
        /// [Alphanumeric (11)]
        /// </summary>
        public string EMERG_RELATION03 { get; internal set; }

        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency
        /// [Alphanumeric (11)]
        /// </summary>
        public string EMERG_RELATION04 { get; internal set; }

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
        /// Language spoken by person(s) to contact in an emergency
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string EMERG_LANG03 { get; internal set; }

        /// <summary>
        /// Language spoken by person(s) to contact in an emergency
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string EMERG_LANG04 { get; internal set; }

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
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT03 { get; internal set; }

        /// <summary>
        /// Contact details for each person to contact in an emergency
        /// [Memo]
        /// </summary>
        public string EMERG_CONTACT04 { get; internal set; }

        /// <summary>
        /// School has received authority to react to accident? (Y/N) (default for each student)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACC_DECLARATION { get; internal set; }

        /// <summary>
        /// (Was CALL_AMBULANCE) Family has ambulance subscription? (Y/N) (default for each student)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AMBULANCE_SUBSCRIBER { get; internal set; }

        /// <summary>
        /// Medicare No (default for each student)
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string MEDICARE_NO { get; internal set; }

        /// <summary>
        /// The language spoken at home
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string HOME_LANG { get; internal set; }

        /// <summary>
        /// Cheque Account Name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DRAWER { get; internal set; }

        /// <summary>
        /// Cheque BSB Number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }

        /// <summary>
        /// Does debtor require tax invoices for GST? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TAX_INVOICE { get; internal set; }

        /// <summary>
        /// The ABN number for this debtor
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string ABN { get; internal set; }

        /// <summary>
        /// General Email address for emailing financial statements direct to families
        /// [Alphanumeric (60)]
        /// </summary>
        public string BILLING_EMAIL { get; internal set; }

        /// <summary>
        /// Preferred Email: A=Adult A e-mail, B=Adult B e-mail, C=Billing e-mail
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PREF_EMAIL { get; internal set; }

        /// <summary>
        /// User Id for eMaze
        /// [Alphanumeric (32)]
        /// </summary>
        public string USER_NAME { get; internal set; }

        /// <summary>
        /// Access from web allowed using USER_NAME
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WEB_ENABLED { get; internal set; }

        /// <summary>
        /// ID of the record of this family in the CASES system
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string CASES_KEY { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? EMA_APPLY_DATE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_APPLY { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string DSS_SURNAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Titlecase (30)]
        /// </summary>
        public string DSS_FIRST_NAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (5)]
        /// </summary>
        public string SSN_ELIG_CODE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SSN { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? EMA_TOTAL1P { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? EMA_STAT1P { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? EMA_TOTAL2P { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? EMA_STAT2P { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_CLAIM_VN { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_SEND { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_CLAIM_PD { get; internal set; }

        /// <summary>
        /// CSEF identifier for existing families
        /// [Alphanumeric (10)]
        /// </summary>
        public string CASES_EMA_ID { get; internal set; }

        /// <summary>
        /// Date last udpated
        /// </summary>
        public DateTime? SCH_ED_A_LU { get; internal set; }

        /// <summary>
        /// Date last udpated
        /// </summary>
        public DateTime? NON_SCH_ED_A_LU { get; internal set; }

        /// <summary>
        /// Date last udpated
        /// </summary>
        public DateTime? OCCUP_STATUS_A_LU { get; internal set; }

        /// <summary>
        /// Date last udpated
        /// </summary>
        public DateTime? SCH_ED_B_LU { get; internal set; }

        /// <summary>
        /// Date last udpated
        /// </summary>
        public DateTime? NON_SCH_ED_B_LU { get; internal set; }

        /// <summary>
        /// Date last udpated
        /// </summary>
        public DateTime? OCCUP_STATUS_B_LU { get; internal set; }

        /// <summary>
        /// Calculated Non School Education
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CNSE { get; internal set; }

        /// <summary>
        /// Calculated School Education
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CSE { get; internal set; }

        /// <summary>
        /// Final Education Value
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FSE { get; internal set; }

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
        /// KGL (Languages) related entity by [DF.NATIVE_LANG_A]-&gt;[KGL.KGLKEY]
        /// (Was MNATIVE_LANG) Parent/guardian A native language
        /// </summary>
        public KGL NATIVE_LANG_A_KGL
        {
            get
            {
                if (NATIVE_LANG_A == null)
                {
                    return null;
                }
                if (Cache_NATIVE_LANG_A_KGL == null)
                {
                    Cache_NATIVE_LANG_A_KGL = Context.KGL.FindByKGLKEY(NATIVE_LANG_A);
                }

                return Cache_NATIVE_LANG_A_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.OTHER_LANG_A]-&gt;[KGL.KGLKEY]
        /// (Was M_OTHER_LANG) Parent/guardian A other language
        /// </summary>
        public KGL OTHER_LANG_A_KGL
        {
            get
            {
                if (OTHER_LANG_A == null)
                {
                    return null;
                }
                if (Cache_OTHER_LANG_A_KGL == null)
                {
                    Cache_OTHER_LANG_A_KGL = Context.KGL.FindByKGLKEY(OTHER_LANG_A);
                }

                return Cache_OTHER_LANG_A_KGL;
            }
        }

        /// <summary>
        /// KGT (Countries) related entity by [DF.BIRTH_COUNTRY_A]-&gt;[KGT.COUNTRY]
        /// (Was MBIRTH_COUNTRY) Parent/guardian A country of birth
        /// </summary>
        public KGT BIRTH_COUNTRY_A_KGT
        {
            get
            {
                if (BIRTH_COUNTRY_A == null)
                {
                    return null;
                }
                if (Cache_BIRTH_COUNTRY_A_KGT == null)
                {
                    Cache_BIRTH_COUNTRY_A_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY_A);
                }

                return Cache_BIRTH_COUNTRY_A_KGT;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// The Language other than English spoken at home by parent/guardian A
        /// </summary>
        public KGL LOTE_HOME_CODE_A_KGL
        {
            get
            {
                if (LOTE_HOME_CODE_A == null)
                {
                    return null;
                }
                if (Cache_LOTE_HOME_CODE_A_KGL == null)
                {
                    Cache_LOTE_HOME_CODE_A_KGL = Context.KGL.FindByKGLKEY(LOTE_HOME_CODE_A);
                }

                return Cache_LOTE_HOME_CODE_A_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.NATIVE_LANG_B]-&gt;[KGL.KGLKEY]
        /// (Was FNATIVE_LANG) Parent/guardian B native language
        /// </summary>
        public KGL NATIVE_LANG_B_KGL
        {
            get
            {
                if (NATIVE_LANG_B == null)
                {
                    return null;
                }
                if (Cache_NATIVE_LANG_B_KGL == null)
                {
                    Cache_NATIVE_LANG_B_KGL = Context.KGL.FindByKGLKEY(NATIVE_LANG_B);
                }

                return Cache_NATIVE_LANG_B_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.OTHER_LANG_B]-&gt;[KGL.KGLKEY]
        /// (Was F_OTHER_LANG) Parent/guardian B other language
        /// </summary>
        public KGL OTHER_LANG_B_KGL
        {
            get
            {
                if (OTHER_LANG_B == null)
                {
                    return null;
                }
                if (Cache_OTHER_LANG_B_KGL == null)
                {
                    Cache_OTHER_LANG_B_KGL = Context.KGL.FindByKGLKEY(OTHER_LANG_B);
                }

                return Cache_OTHER_LANG_B_KGL;
            }
        }

        /// <summary>
        /// KGT (Countries) related entity by [DF.BIRTH_COUNTRY_B]-&gt;[KGT.COUNTRY]
        /// (Was FBIRTH_COUNTRY) Parent/guardian B country of birth
        /// </summary>
        public KGT BIRTH_COUNTRY_B_KGT
        {
            get
            {
                if (BIRTH_COUNTRY_B == null)
                {
                    return null;
                }
                if (Cache_BIRTH_COUNTRY_B_KGT == null)
                {
                    Cache_BIRTH_COUNTRY_B_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY_B);
                }

                return Cache_BIRTH_COUNTRY_B_KGT;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// The Language other than English spoken at home by parent/guardian B
        /// </summary>
        public KGL LOTE_HOME_CODE_B_KGL
        {
            get
            {
                if (LOTE_HOME_CODE_B == null)
                {
                    return null;
                }
                if (Cache_LOTE_HOME_CODE_B_KGL == null)
                {
                    Cache_LOTE_HOME_CODE_B_KGL = Context.KGL.FindByKGLKEY(LOTE_HOME_CODE_B);
                }

                return Cache_LOTE_HOME_CODE_B_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.PREF_NOTICE_LANG]-&gt;[KGL.KGLKEY]
        /// Preferred language for notices
        /// </summary>
        public KGL PREF_NOTICE_LANG_KGL
        {
            get
            {
                if (PREF_NOTICE_LANG == null)
                {
                    return null;
                }
                if (Cache_PREF_NOTICE_LANG_KGL == null)
                {
                    Cache_PREF_NOTICE_LANG_KGL = Context.KGL.FindByKGLKEY(PREF_NOTICE_LANG);
                }

                return Cache_PREF_NOTICE_LANG_KGL;
            }
        }

        /// <summary>
        /// UM (Addresses) related entity by [DF.HOMEKEY]-&gt;[UM.UMKEY]
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
        /// UM (Addresses) related entity by [DF.MAILKEY]-&gt;[UM.UMKEY]
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
        /// UM (Addresses) related entity by [DF.BILLINGKEY]-&gt;[UM.UMKEY]
        /// Billing address ID
        /// </summary>
        public UM BILLINGKEY_UM
        {
            get
            {
                if (BILLINGKEY == null)
                {
                    return null;
                }
                if (Cache_BILLINGKEY_UM == null)
                {
                    Cache_BILLINGKEY_UM = Context.UM.FindByUMKEY(BILLINGKEY.Value);
                }

                return Cache_BILLINGKEY_UM;
            }
        }

        /// <summary>
        /// KCD (Doctors) related entity by [DF.DOCTOR]-&gt;[KCD.KCDKEY]
        /// Reference to local doctor (default for each student)
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
        /// KGL (Languages) related entity by [DF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
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
        /// KGL (Languages) related entity by [DF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
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
        /// KGL (Languages) related entity by [DF.EMERG_LANG03]-&gt;[KGL.KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG03_KGL
        {
            get
            {
                if (EMERG_LANG03 == null)
                {
                    return null;
                }
                if (Cache_EMERG_LANG03_KGL == null)
                {
                    Cache_EMERG_LANG03_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG03);
                }

                return Cache_EMERG_LANG03_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.EMERG_LANG04]-&gt;[KGL.KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG04_KGL
        {
            get
            {
                if (EMERG_LANG04 == null)
                {
                    return null;
                }
                if (Cache_EMERG_LANG04_KGL == null)
                {
                    Cache_EMERG_LANG04_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG04);
                }

                return Cache_EMERG_LANG04_KGL;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [DF.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// The language spoken at home
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

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// DFB (BPAY Receipts) related entities by [DF.DFKEY]-&gt;[DFB.FAM_CODE]
        /// Family ID
        /// </summary>
        public IReadOnlyList<DFB> DFKEY_DFB_FAM_CODE
        {
            get
            {
                if (Cache_DFKEY_DFB_FAM_CODE == null &&
                    !Context.DFB.TryFindByFAM_CODE(DFKEY, out Cache_DFKEY_DFB_FAM_CODE))
                {
                    Cache_DFKEY_DFB_FAM_CODE = new List<DFB>().AsReadOnly();
                }

                return Cache_DFKEY_DFB_FAM_CODE;
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [DF.DFKEY]-&gt;[DFF.CODE]
        /// Family ID
        /// </summary>
        public IReadOnlyList<DFF> DFKEY_DFF_CODE
        {
            get
            {
                if (Cache_DFKEY_DFF_CODE == null &&
                    !Context.DFF.TryFindByCODE(DFKEY, out Cache_DFKEY_DFF_CODE))
                {
                    Cache_DFKEY_DFF_CODE = new List<DFF>().AsReadOnly();
                }

                return Cache_DFKEY_DFF_CODE;
            }
        }

        /// <summary>
        /// DFHI (Family History) related entities by [DF.DFKEY]-&gt;[DFHI.FKEY]
        /// Family ID
        /// </summary>
        public IReadOnlyList<DFHI> DFKEY_DFHI_FKEY
        {
            get
            {
                if (Cache_DFKEY_DFHI_FKEY == null &&
                    !Context.DFHI.TryFindByFKEY(DFKEY, out Cache_DFKEY_DFHI_FKEY))
                {
                    Cache_DFKEY_DFHI_FKEY = new List<DFHI>().AsReadOnly();
                }

                return Cache_DFKEY_DFHI_FKEY;
            }
        }

        /// <summary>
        /// DFVT (Family Voluntary Transactions) related entities by [DF.DFKEY]-&gt;[DFVT.FAMILY]
        /// Family ID
        /// </summary>
        public IReadOnlyList<DFVT> DFKEY_DFVT_FAMILY
        {
            get
            {
                if (Cache_DFKEY_DFVT_FAMILY == null &&
                    !Context.DFVT.TryFindByFAMILY(DFKEY, out Cache_DFKEY_DFVT_FAMILY))
                {
                    Cache_DFKEY_DFVT_FAMILY = new List<DFVT>().AsReadOnly();
                }

                return Cache_DFKEY_DFVT_FAMILY;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [DF.DFKEY]-&gt;[ST.FAMILY]
        /// Family ID
        /// </summary>
        public IReadOnlyList<ST> DFKEY_ST_FAMILY
        {
            get
            {
                if (Cache_DFKEY_ST_FAMILY == null &&
                    !Context.ST.TryFindByFAMILY(DFKEY, out Cache_DFKEY_ST_FAMILY))
                {
                    Cache_DFKEY_ST_FAMILY = new List<ST>().AsReadOnly();
                }

                return Cache_DFKEY_ST_FAMILY;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [DF.DFKEY]-&gt;[ST.FAMB]
        /// Family ID
        /// </summary>
        public IReadOnlyList<ST> DFKEY_ST_FAMB
        {
            get
            {
                if (Cache_DFKEY_ST_FAMB == null &&
                    !Context.ST.TryFindByFAMB(DFKEY, out Cache_DFKEY_ST_FAMB))
                {
                    Cache_DFKEY_ST_FAMB = new List<ST>().AsReadOnly();
                }

                return Cache_DFKEY_ST_FAMB;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [DF.DFKEY]-&gt;[ST.FAMC]
        /// Family ID
        /// </summary>
        public IReadOnlyList<ST> DFKEY_ST_FAMC
        {
            get
            {
                if (Cache_DFKEY_ST_FAMC == null &&
                    !Context.ST.TryFindByFAMC(DFKEY, out Cache_DFKEY_ST_FAMC))
                {
                    Cache_DFKEY_ST_FAMC = new List<ST>().AsReadOnly();
                }

                return Cache_DFKEY_ST_FAMC;
            }
        }

        /// <summary>
        /// STSB (Family Invoice Allocations) related entities by [DF.DFKEY]-&gt;[STSB.FAMILY]
        /// Family ID
        /// </summary>
        public IReadOnlyList<STSB> DFKEY_STSB_FAMILY
        {
            get
            {
                if (Cache_DFKEY_STSB_FAMILY == null &&
                    !Context.STSB.TryFindByFAMILY(DFKEY, out Cache_DFKEY_STSB_FAMILY))
                {
                    Cache_DFKEY_STSB_FAMILY = new List<STSB>().AsReadOnly();
                }

                return Cache_DFKEY_STSB_FAMILY;
            }
        }

        #endregion

    }
}
