using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Families
    /// </summary>
    public class DF : EntityBase
    {
#region Navigation Property Cache
        private KGL _NATIVE_LANG_A_KGL;
        private KGL _OTHER_LANG_A_KGL;
        private KGT _BIRTH_COUNTRY_A_KGT;
        private KGL _LOTE_HOME_CODE_A_KGL;
        private KGL _NATIVE_LANG_B_KGL;
        private KGL _OTHER_LANG_B_KGL;
        private KGT _BIRTH_COUNTRY_B_KGT;
        private KGL _LOTE_HOME_CODE_B_KGL;
        private KGL _PREF_NOTICE_LANG_KGL;
        private UM _HOMEKEY_UM;
        private UM _MAILKEY_UM;
        private UM _BILLINGKEY_UM;
        private KCD _DOCTOR_KCD;
        private KGL _EMERG_LANG01_KGL;
        private KGL _EMERG_LANG02_KGL;
        private KGL _EMERG_LANG03_KGL;
        private KGL _EMERG_LANG04_KGL;
        private KGL _HOME_LANG_KGL;
#endregion

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
        /// (Was PREF_COM_A) Parent/guardian A preferred mail mechanism: M=Mail, E=E-mail, F=Fax
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
        /// (Was PREF_COM_B) Parent/guardian B preferred mail mechanism: M=Mail, E=E-mail, F=Fax
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
        /// ID of the record of this family in the CASES system
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string CASES_KEY { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EMA_APPLY_DATE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_APPLY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string DSS_SURNAME { get; internal set; }
        /// <summary>
        /// 
        /// [Titlecase (30)]
        /// </summary>
        public string DSS_FIRST_NAME { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (5)]
        /// </summary>
        public string SSN_ELIG_CODE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SSN { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? EMA_TOTAL1P { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? EMA_STAT1P { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? EMA_TOTAL2P { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? EMA_STAT2P { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_CLAIM_VN { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_SEND { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_CLAIM_PD { get; internal set; }
        /// <summary>
        /// EMA identifier for existing families
        /// [Alphanumeric (10)]
        /// </summary>
        public string CASES_EMA_ID { get; internal set; }
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
        /// Navigation property for [NATIVE_LANG_A] => [KGL].[KGLKEY]
        /// (Was MNATIVE_LANG) Parent/guardian A native language
        /// </summary>
        public KGL NATIVE_LANG_A_KGL {
            get
            {
                if (NATIVE_LANG_A != null)
                {
                    if (_NATIVE_LANG_A_KGL == null)
                    {
                        _NATIVE_LANG_A_KGL = Context.KGL.FindByKGLKEY(NATIVE_LANG_A);
                    }
                    return _NATIVE_LANG_A_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [OTHER_LANG_A] => [KGL].[KGLKEY]
        /// (Was M_OTHER_LANG) Parent/guardian A other language
        /// </summary>
        public KGL OTHER_LANG_A_KGL {
            get
            {
                if (OTHER_LANG_A != null)
                {
                    if (_OTHER_LANG_A_KGL == null)
                    {
                        _OTHER_LANG_A_KGL = Context.KGL.FindByKGLKEY(OTHER_LANG_A);
                    }
                    return _OTHER_LANG_A_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY_A] => [KGT].[COUNTRY]
        /// (Was MBIRTH_COUNTRY) Parent/guardian A country of birth
        /// </summary>
        public KGT BIRTH_COUNTRY_A_KGT {
            get
            {
                if (BIRTH_COUNTRY_A != null)
                {
                    if (_BIRTH_COUNTRY_A_KGT == null)
                    {
                        _BIRTH_COUNTRY_A_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY_A);
                    }
                    return _BIRTH_COUNTRY_A_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LOTE_HOME_CODE_A] => [KGL].[KGLKEY]
        /// The Language other than English spoken at home by parent/guardian A
        /// </summary>
        public KGL LOTE_HOME_CODE_A_KGL {
            get
            {
                if (LOTE_HOME_CODE_A != null)
                {
                    if (_LOTE_HOME_CODE_A_KGL == null)
                    {
                        _LOTE_HOME_CODE_A_KGL = Context.KGL.FindByKGLKEY(LOTE_HOME_CODE_A);
                    }
                    return _LOTE_HOME_CODE_A_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [NATIVE_LANG_B] => [KGL].[KGLKEY]
        /// (Was FNATIVE_LANG) Parent/guardian B native language
        /// </summary>
        public KGL NATIVE_LANG_B_KGL {
            get
            {
                if (NATIVE_LANG_B != null)
                {
                    if (_NATIVE_LANG_B_KGL == null)
                    {
                        _NATIVE_LANG_B_KGL = Context.KGL.FindByKGLKEY(NATIVE_LANG_B);
                    }
                    return _NATIVE_LANG_B_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [OTHER_LANG_B] => [KGL].[KGLKEY]
        /// (Was F_OTHER_LANG) Parent/guardian B other language
        /// </summary>
        public KGL OTHER_LANG_B_KGL {
            get
            {
                if (OTHER_LANG_B != null)
                {
                    if (_OTHER_LANG_B_KGL == null)
                    {
                        _OTHER_LANG_B_KGL = Context.KGL.FindByKGLKEY(OTHER_LANG_B);
                    }
                    return _OTHER_LANG_B_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY_B] => [KGT].[COUNTRY]
        /// (Was FBIRTH_COUNTRY) Parent/guardian B country of birth
        /// </summary>
        public KGT BIRTH_COUNTRY_B_KGT {
            get
            {
                if (BIRTH_COUNTRY_B != null)
                {
                    if (_BIRTH_COUNTRY_B_KGT == null)
                    {
                        _BIRTH_COUNTRY_B_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY_B);
                    }
                    return _BIRTH_COUNTRY_B_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LOTE_HOME_CODE_B] => [KGL].[KGLKEY]
        /// The Language other than English spoken at home by parent/guardian B
        /// </summary>
        public KGL LOTE_HOME_CODE_B_KGL {
            get
            {
                if (LOTE_HOME_CODE_B != null)
                {
                    if (_LOTE_HOME_CODE_B_KGL == null)
                    {
                        _LOTE_HOME_CODE_B_KGL = Context.KGL.FindByKGLKEY(LOTE_HOME_CODE_B);
                    }
                    return _LOTE_HOME_CODE_B_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PREF_NOTICE_LANG] => [KGL].[KGLKEY]
        /// Preferred language for notices
        /// </summary>
        public KGL PREF_NOTICE_LANG_KGL {
            get
            {
                if (PREF_NOTICE_LANG != null)
                {
                    if (_PREF_NOTICE_LANG_KGL == null)
                    {
                        _PREF_NOTICE_LANG_KGL = Context.KGL.FindByKGLKEY(PREF_NOTICE_LANG);
                    }
                    return _PREF_NOTICE_LANG_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOMEKEY] => [UM].[UMKEY]
        /// Home address ID
        /// </summary>
        public UM HOMEKEY_UM {
            get
            {
                if (HOMEKEY.HasValue)
                {
                    if (_HOMEKEY_UM == null)
                    {
                        _HOMEKEY_UM = Context.UM.FindByUMKEY(HOMEKEY.Value);
                    }
                    return _HOMEKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MAILKEY] => [UM].[UMKEY]
        /// Mail address ID
        /// </summary>
        public UM MAILKEY_UM {
            get
            {
                if (MAILKEY.HasValue)
                {
                    if (_MAILKEY_UM == null)
                    {
                        _MAILKEY_UM = Context.UM.FindByUMKEY(MAILKEY.Value);
                    }
                    return _MAILKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BILLINGKEY] => [UM].[UMKEY]
        /// Billing address ID
        /// </summary>
        public UM BILLINGKEY_UM {
            get
            {
                if (BILLINGKEY.HasValue)
                {
                    if (_BILLINGKEY_UM == null)
                    {
                        _BILLINGKEY_UM = Context.UM.FindByUMKEY(BILLINGKEY.Value);
                    }
                    return _BILLINGKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DOCTOR] => [KCD].[KCDKEY]
        /// Reference to local doctor (default for each student)
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
        /// Navigation property for [EMERG_LANG03] => [KGL].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG03_KGL {
            get
            {
                if (EMERG_LANG03 != null)
                {
                    if (_EMERG_LANG03_KGL == null)
                    {
                        _EMERG_LANG03_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG03);
                    }
                    return _EMERG_LANG03_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EMERG_LANG04] => [KGL].[KGLKEY]
        /// Language spoken by person(s) to contact in an emergency
        /// </summary>
        public KGL EMERG_LANG04_KGL {
            get
            {
                if (EMERG_LANG04 != null)
                {
                    if (_EMERG_LANG04_KGL == null)
                    {
                        _EMERG_LANG04_KGL = Context.KGL.FindByKGLKEY(EMERG_LANG04);
                    }
                    return _EMERG_LANG04_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOME_LANG] => [KGL].[KGLKEY]
        /// The language spoken at home
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
#endregion
    }
}
