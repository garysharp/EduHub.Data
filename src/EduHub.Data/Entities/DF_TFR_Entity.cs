using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// DF Transfer
    /// </summary>
    public class DF_TFR_Entity : EntityBase
    {
#region Navigation Property Cache
        private SKGS_Entity _ORIG_SCHOOL_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Orignating School [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }
        /// <summary>
        /// Unique DF Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string DF_TRANS_ID { get; internal set; }
        /// <summary>
        /// Family ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DFKEY { get; internal set; }
        /// <summary>
        /// New Family Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DFKEY_NEW { get; internal set; }
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
        /// (Was M_OTHER_LANG) Parent/guardian A other language [Uppercase Alphanumeric: u7]
        /// </summary>
        public string OTHER_LANG_A { get; internal set; }
        /// <summary>
        /// (Was M_INTERPRETER) Parent/guardian A requires interpreter? Y=Yes, N=No, S=Sometimes [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER_A { get; internal set; }
        /// <summary>
        /// (Was MBIRTH_COUNTRY) Parent/guardian A country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY_A { get; internal set; }
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
        /// (Was F_OTHER_LANG) Parent/guardian B other language [Uppercase Alphanumeric: u7]
        /// </summary>
        public string OTHER_LANG_B { get; internal set; }
        /// <summary>
        /// (Was F_INTERPRETER) Parent/guardian B requires interpreter? Y=Yes, N=No, S=Sometimes [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTERPRETER_B { get; internal set; }
        /// <summary>
        /// (Was FBIRTH_COUNTRY) Parent/guardian B country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY_B { get; internal set; }
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
        /// Preferred language for notices [Uppercase Alphanumeric: u7]
        /// </summary>
        public string PREF_NOTICE_LANG { get; internal set; }
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
        /// New Home address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? HOMEKEY_NEW { get; internal set; }
        /// <summary>
        /// Mail addressee [Titlecase: t30]
        /// </summary>
        public string MAILTITLE { get; internal set; }
        /// <summary>
        /// Mail address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MAILKEY { get; internal set; }
        /// <summary>
        /// New Home address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MAILKEY_NEW { get; internal set; }
        /// <summary>
        /// Billing name [Titlecase: t40]
        /// </summary>
        public string BILLINGTITLE { get; internal set; }
        /// <summary>
        /// Billing address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? BILLINGKEY { get; internal set; }
        /// <summary>
        /// New Home address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? BILLINGKEY_NEW { get; internal set; }
        /// <summary>
        /// Billing memo [Memo: m]
        /// </summary>
        public string BILLING_MEMO { get; internal set; }
        /// <summary>
        /// Account type: 0=Brought forward, 1=Open item [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCTYPE { get; internal set; }
        /// <summary>
        /// Auto access inventory price level: related to sale of stock items to families: to be retained at present [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PRICELEVEL { get; internal set; }
        /// <summary>
        /// Seed number for BPAY reference [Integer (32bit signed nullable): l]
        /// </summary>
        public int? BPAY_SEQUENCE { get; internal set; }
        /// <summary>
        /// Reference number with check digit [Integer (32bit signed nullable): l]
        /// </summary>
        public int? BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Reference to local doctor (default for each student) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DOCTOR { get; internal set; }
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
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG02 { get; internal set; }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG03 { get; internal set; }
        /// <summary>
        /// Language spoken by person(s) to contact in an emergency [Uppercase Alphanumeric: u7]
        /// </summary>
        public string EMERG_LANG04 { get; internal set; }
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
        /// Cheque Account Name [Alphanumeric: a30]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Cheque BSB Number [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// The ABN number for this debtor [Uppercase Alphanumeric: u15]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// General Email address for emailing financial statements direct to families [Alphanumeric: a60]
        /// </summary>
        public string BILLING_EMAIL { get; internal set; }
        /// <summary>
        /// Unique Home UM Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string UMH_TRANS_ID { get; internal set; }
        /// <summary>
        /// Unique Mail UM Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string UMM_TRANS_ID { get; internal set; }
        /// <summary>
        /// Unique Billing UM Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string UMB_TRANS_ID { get; internal set; }
        /// <summary>
        /// Unique KCD Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string KCD_TRANS_ID { get; internal set; }
        /// <summary>
        /// Current Status of Import [Uppercase Alphanumeric: u15]
        /// </summary>
        public string IMP_STATUS { get; internal set; }
        /// <summary>
        /// Actual Date data transfered into live table [Date Time nullable: d]
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [ORIG_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS_Entity ORIG_SCHOOL_SKGS {
            get
            {
                if (ORIG_SCHOOL != null)
                {
                    if (_ORIG_SCHOOL_SKGS == null)
                    {
                        _ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                    }
                    return _ORIG_SCHOOL_SKGS;
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
