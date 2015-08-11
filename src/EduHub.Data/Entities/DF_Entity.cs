using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Families
    /// </summary>
    public class DF_Entity : EntityBase
    {
        /// <summary>
        /// Family ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DFKEY { get; internal set; }
        /// <summary>
        /// (Was MNAME) Parent/guardian A first given name [Alphanumeric: a30]
        /// </summary>
        public string NAME_A { get; internal set; }
        /// <summary>
        /// (Was MSURNAME) Parent/guardian A surname (default SURNAME) [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME_A { get; internal set; }
        /// <summary>
        /// (Was MTITLE) Parent/guardian A title [Titlecase: t4]
        /// </summary>
        public string TITLE_A { get; internal set; }
        /// <summary>
        /// (Was MWORK_CONT) Can parent/guardian A be contacted at work? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string WORK_CONT_A { get; internal set; }
        /// <summary>
        /// (Was MOCCUPATION) Parent/guardian A occupation [Alphanumeric: a35]
        /// </summary>
        public string OCCUPATION_A { get; internal set; }
        /// <summary>
        /// (Was MEMPLOYER) Parent/guardian A employer [Alphanumeric: a30]
        /// </summary>
        public string EMPLOYER_A { get; internal set; }
        /// <summary>
        /// (Was MNATIVE_LANG) Parent/guardian A native language [Uppercase Alphanumeric: u7]
        /// </summary>
        public string NATIVE_LANG_A { get; internal set; }
        /// <summary>
        /// Navigation property for [NATIVE_LANG_A] => [KGL_Entity].[KGLKEY]
        /// (Was MNATIVE_LANG) Parent/guardian A native language
        /// </summary>
        public KGL_Entity NATIVE_LANG_A_KGL { get { return NATIVE_LANG_A == null ? null : Context.KGL.FindByKGLKEY(NATIVE_LANG_A); } }
        /// <summary>
        /// (Was M_OTHER_LANG) Parent/guardian A other language [Uppercase Alphanumeric: u7]
        /// </summary>
        public string OTHER_LANG_A { get; internal set; }
        /// <summary>
        /// Navigation property for [OTHER_LANG_A] => [KGL_Entity].[KGLKEY]
        /// (Was M_OTHER_LANG) Parent/guardian A other language
        /// </summary>
        public KGL_Entity OTHER_LANG_A_KGL { get { return OTHER_LANG_A == null ? null : Context.KGL.FindByKGLKEY(OTHER_LANG_A); } }
        /// <summary>
        /// (Was M_INTERPRETER) Parent/guardian A requires interpreter? Y=Yes, N=No, S=Sometimes [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER_A { get; internal set; }
        /// <summary>
        /// (Was MBIRTH_COUNTRY) Parent/guardian A country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY_A { get; internal set; }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY_A] => [KGT_Entity].[COUNTRY]
        /// (Was MBIRTH_COUNTRY) Parent/guardian A country of birth
        /// </summary>
        public KGT_Entity BIRTH_COUNTRY_A_KGT { get { return BIRTH_COUNTRY_A == null ? null : Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY_A); } }
        /// <summary>
        /// Parent/guardian A at home during business hours? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BH_AT_HOME_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A telephone contact if not at home during business hours [Memo: m]
        /// </summary>
        public string BH_CONTACT_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A at home after hours? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AH_AT_HOME_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A telephone contact if not at home after hours [Memo: m]
        /// </summary>
        public string AH_CONTACT_A { get; internal set; }
        /// <summary>
        /// (Was M_E_MAIL) Parent/guardian A e-mail address [Alphanumeric: a60]
        /// </summary>
        public string E_MAIL_A { get; internal set; }
        /// <summary>
        /// (Was PREF_COM_A) Parent/guardian A preferred mail mechanism: M=Mail, E=E-mail, F=Fax [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PREF_MAIL_MECH_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A fax number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string FAX_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A gender: M=Male, F=Female [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A School Education [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SCH_ED_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A Non School Education (0,5-8) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string NON_SCH_ED_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A Occupation Status (A,B,C,D,N,U) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OCCUP_STATUS_A { get; internal set; }
        /// <summary>
        /// The Language other than English spoken at home by parent/guardian A [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LOTE_HOME_CODE_A { get; internal set; }
        /// <summary>
        /// Navigation property for [LOTE_HOME_CODE_A] => [KGL_Entity].[KGLKEY]
        /// The Language other than English spoken at home by parent/guardian A
        /// </summary>
        public KGL_Entity LOTE_HOME_CODE_A_KGL { get { return LOTE_HOME_CODE_A == null ? null : Context.KGL.FindByKGLKEY(LOTE_HOME_CODE_A); } }
        /// <summary>
        /// (Was FNAME) Parent/guardian B first given name [Alphanumeric: a30]
        /// </summary>
        public string NAME_B { get; internal set; }
        /// <summary>
        /// (Was FSURNAME) Parent/guardian B surname (default SURNAME) [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME_B { get; internal set; }
        /// <summary>
        /// (Was FTITLE) Parent/guardian B title [Titlecase: t4]
        /// </summary>
        public string TITLE_B { get; internal set; }
        /// <summary>
        /// (Was FWORK_CONT) Can parent/guardian B be contacted at work? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string WORK_CONT_B { get; internal set; }
        /// <summary>
        /// (Was FOCCUPATION) Parent/guardian B occupation [Alphanumeric: a35]
        /// </summary>
        public string OCCUPATION_B { get; internal set; }
        /// <summary>
        /// (Was FEMPLOYER) Parent/guardian B employer [Alphanumeric: a30]
        /// </summary>
        public string EMPLOYER_B { get; internal set; }
        /// <summary>
        /// (Was FNATIVE_LANG) Parent/guardian B native language [Uppercase Alphanumeric: u7]
        /// </summary>
        public string NATIVE_LANG_B { get; internal set; }
        /// <summary>
        /// Navigation property for [NATIVE_LANG_B] => [KGL_Entity].[KGLKEY]
        /// (Was FNATIVE_LANG) Parent/guardian B native language
        /// </summary>
        public KGL_Entity NATIVE_LANG_B_KGL { get { return NATIVE_LANG_B == null ? null : Context.KGL.FindByKGLKEY(NATIVE_LANG_B); } }
        /// <summary>
        /// (Was F_OTHER_LANG) Parent/guardian B other language [Uppercase Alphanumeric: u7]
        /// </summary>
        public string OTHER_LANG_B { get; internal set; }
        /// <summary>
        /// Navigation property for [OTHER_LANG_B] => [KGL_Entity].[KGLKEY]
        /// (Was F_OTHER_LANG) Parent/guardian B other language
        /// </summary>
        public KGL_Entity OTHER_LANG_B_KGL { get { return OTHER_LANG_B == null ? null : Context.KGL.FindByKGLKEY(OTHER_LANG_B); } }
        /// <summary>
        /// (Was F_INTERPRETER) Parent/guardian B requires interpreter? Y=Yes, N=No, S=Sometimes [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER_B { get; internal set; }
        /// <summary>
        /// (Was FBIRTH_COUNTRY) Parent/guardian B country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY_B { get; internal set; }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY_B] => [KGT_Entity].[COUNTRY]
        /// (Was FBIRTH_COUNTRY) Parent/guardian B country of birth
        /// </summary>
        public KGT_Entity BIRTH_COUNTRY_B_KGT { get { return BIRTH_COUNTRY_B == null ? null : Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY_B); } }
        /// <summary>
        /// Parent/guardian B at home during business hours? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BH_AT_HOME_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B telephone contact if not at home during business hours [Memo: m]
        /// </summary>
        public string BH_CONTACT_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B at home after hours? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AH_AT_HOME_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B telephone contact if not at home after hours [Memo: m]
        /// </summary>
        public string AH_CONTACT_B { get; internal set; }
        /// <summary>
        /// (Was F_E_MAIL) Parent/guardian B e-mail address [Alphanumeric: a60]
        /// </summary>
        public string E_MAIL_B { get; internal set; }
        /// <summary>
        /// (Was PREF_COM_B) Parent/guardian B preferred mail mechanism: M=Mail, E=E-mail, F=Fax [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PREF_MAIL_MECH_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B fax number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string FAX_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B gender: M=Male, F=Female [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B School Education (0-4) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SCH_ED_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B Non School Education (0,5-8) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string NON_SCH_ED_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B Occupation Status (A,B,C,D,N,U) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OCCUP_STATUS_B { get; internal set; }
        /// <summary>
        /// The Language other than English spoken at home by parent/guardian B [Uppercase Alphanumeric: u7]
        /// </summary>
        public string LOTE_HOME_CODE_B { get; internal set; }
        /// <summary>
        /// Navigation property for [LOTE_HOME_CODE_B] => [KGL_Entity].[KGLKEY]
        /// The Language other than English spoken at home by parent/guardian B
        /// </summary>
        public KGL_Entity LOTE_HOME_CODE_B_KGL { get { return LOTE_HOME_CODE_B == null ? null : Context.KGL.FindByKGLKEY(LOTE_HOME_CODE_B); } }
        /// <summary>
        /// Preferred language for notices [Uppercase Alphanumeric: u7]
        /// </summary>
        public string PREF_NOTICE_LANG { get; internal set; }
        /// <summary>
        /// Navigation property for [PREF_NOTICE_LANG] => [KGL_Entity].[KGLKEY]
        /// Preferred language for notices
        /// </summary>
        public KGL_Entity PREF_NOTICE_LANG_KGL { get { return PREF_NOTICE_LANG == null ? null : Context.KGL.FindByKGLKEY(PREF_NOTICE_LANG); } }
        /// <summary>
        /// (Was SG_PARTICIPATION) Special group participation: 1=Adult A, 2=Adult B, B=Both [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GROUP_AVAILABILITY { get; internal set; }
        /// <summary>
        /// (Was FAM_OCCUP) Family occupation status group (1-5) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OCCUP_STATUS_GRP { get; internal set; }
        /// <summary>
        /// Home addressee [Titlecase: t30]
        /// </summary>
        public string HOMETITLE { get; internal set; }
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
        /// Mail addressee [Titlecase: t30]
        /// </summary>
        public string MAILTITLE { get; internal set; }
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
        /// Billing name [Titlecase: t40]
        /// </summary>
        public string BILLINGTITLE { get; internal set; }
        /// <summary>
        /// Billing address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? BILLINGKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [BILLINGKEY] => [UM_Entity].[UMKEY]
        /// Billing address ID
        /// </summary>
        public UM_Entity BILLINGKEY_UM { get { return BILLINGKEY.HasValue ? Context.UM.FindByUMKEY(BILLINGKEY.Value) : null; } }
        /// <summary>
        /// Billing memo [Memo: m]
        /// </summary>
        public string BILLING_MEMO { get; internal set; }
        /// <summary>
        /// Account type: 0=Brought forward, 1=Open item [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCTYPE { get; internal set; }
        /// <summary>
        /// Aged balances [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AGED01 { get; internal set; }
        /// <summary>
        /// Aged balances [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AGED02 { get; internal set; }
        /// <summary>
        /// Aged balances [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AGED03 { get; internal set; }
        /// <summary>
        /// Aged balances [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AGED04 { get; internal set; }
        /// <summary>
        /// Aged balances [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AGED05 { get; internal set; }
        /// <summary>
        /// Amount received in payment but not yet allocated to an invoice [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }
        /// <summary>
        /// Charges this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CHARGES { get; internal set; }
        /// <summary>
        /// Last receipt amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTREC { get; internal set; }
        /// <summary>
        /// Last receipt date [Date Time nullable: d]
        /// </summary>
        public DateTime? LASTRECDATE { get; internal set; }
        /// <summary>
        /// Opening balance [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OPBAL { get; internal set; }
        /// <summary>
        /// Opening balance at start of year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OPBAL_YEAR { get; internal set; }
        /// <summary>
        /// Auto access inventory price level: related to sale of stock items to families: to be retained at present [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PRICELEVEL { get; internal set; }
        /// <summary>
        /// Seed number for BPAY reference [Integer (32bit signed nullable): l]
        /// </summary>
        public int? BPAY_SEQUENCE { get; internal set; }
        /// <summary>
        /// BPAY Reference number with check digit [Alphanumeric: a20]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Number of current students for which this family is the PRIME family (automatically maintained by software) (cf NO_ASSOC_STUDENTS) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NO_STUDENTS { get; internal set; }
        /// <summary>
        /// Number of current students with which this family is associated (as Prime, Alternative or Additional family) (cf NO_STUDENTS) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NO_ASSOC_STUDENTS { get; internal set; }
        /// <summary>
        /// Credit limit [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CREDIT_LIMIT { get; internal set; }
        /// <summary>
        /// Billing group [Uppercase Alphanumeric: u10]
        /// </summary>
        public string BILL_GROUP { get; internal set; }
        /// <summary>
        /// Reference to local doctor (default for each student) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DOCTOR { get; internal set; }
        /// <summary>
        /// Navigation property for [DOCTOR] => [KCD_Entity].[KCDKEY]
        /// Reference to local doctor (default for each student)
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
        /// Name(s) of person(s) to contact in an emergency [Titlecase: t30]
        /// </summary>
        public string EMERG_NAME03 { get; internal set; }
        /// <summary>
        /// Name(s) of person(s) to contact in an emergency [Titlecase: t30]
        /// </summary>
        public string EMERG_NAME04 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
        /// </summary>
        public string EMERG_RELATION01 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
        /// </summary>
        public string EMERG_RELATION02 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
        /// </summary>
        public string EMERG_RELATION03 { get; internal set; }
        /// <summary>
        /// Relationship to a student in this family of each person to contact in an emergency [Alphanumeric: a11]
        /// </summary>
        public string EMERG_RELATION04 { get; internal set; }
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
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG03 { get; internal set; }
        /// <summary>
        /// Navigation property for [EMERG_LANG03] => [KGL_Entity].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL_Entity EMERG_LANG03_KGL { get { return EMERG_LANG03 == null ? null : Context.KGL.FindByKGLKEY(EMERG_LANG03); } }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG04 { get; internal set; }
        /// <summary>
        /// Navigation property for [EMERG_LANG04] => [KGL_Entity].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL_Entity EMERG_LANG04_KGL { get { return EMERG_LANG04 == null ? null : Context.KGL.FindByKGLKEY(EMERG_LANG04); } }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT01 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT02 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT03 { get; internal set; }
        /// <summary>
        /// Contact details for each person to contact in an emergency [Memo: m]
        /// </summary>
        public string EMERG_CONTACT04 { get; internal set; }
        /// <summary>
        /// School has received authority to react to accident? (Y/N) (default for each student) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACC_DECLARATION { get; internal set; }
        /// <summary>
        /// (Was CALL_AMBULANCE) Family has ambulance subscription? (Y/N) (default for each student) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AMBULANCE_SUBSCRIBER { get; internal set; }
        /// <summary>
        /// Medicare No (default for each student) [Uppercase Alphanumeric: u12]
        /// </summary>
        public string MEDICARE_NO { get; internal set; }
        /// <summary>
        /// The language spoken at home [Uppercase Alphanumeric: u7]
        /// </summary>
        public string HOME_LANG { get; internal set; }
        /// <summary>
        /// Navigation property for [HOME_LANG] => [KGL_Entity].[KGLKEY]
        /// The language spoken at home
        /// </summary>
        public KGL_Entity HOME_LANG_KGL { get { return HOME_LANG == null ? null : Context.KGL.FindByKGLKEY(HOME_LANG); } }
        /// <summary>
        /// Cheque Account Name [Alphanumeric: a30]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Cheque BSB Number [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Does debtor require tax invoices for GST? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TAX_INVOICE { get; internal set; }
        /// <summary>
        /// The ABN number for this debtor [Uppercase Alphanumeric: u15]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// General Email address for emailing financial statements direct to families [Alphanumeric: a60]
        /// </summary>
        public string BILLING_EMAIL { get; internal set; }
        /// <summary>
        /// ID of the record of this family in the CASES system [Uppercase Alphanumeric: u7]
        /// </summary>
        public string CASES_KEY { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? EMA_APPLY_DATE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EMA_APPLY { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u30]
        /// </summary>
        public string DSS_SURNAME { get; internal set; }
        /// <summary>
        ///  [Titlecase: t30]
        /// </summary>
        public string DSS_FIRST_NAME { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a5]
        /// </summary>
        public string SSN_ELIG_CODE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u15]
        /// </summary>
        public string SSN { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? EMA_TOTAL1P { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EMA_STAT1P { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? EMA_TOTAL2P { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EMA_STAT2P { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EMA_CLAIM_VN { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EMA_SEND { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EMA_CLAIM_PD { get; internal set; }
        /// <summary>
        /// EMA identifier for existing families [Alphanumeric: a10]
        /// </summary>
        public string CASES_EMA_ID { get; internal set; }
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
