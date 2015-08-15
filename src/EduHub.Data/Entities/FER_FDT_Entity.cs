using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FDT Financal Holding Table
    /// </summary>
    public class FER_FDT_Entity : EntityBase
    {
#region Navigation Property Cache
        private SKGS_Entity _SOURCE_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u8]
        /// </summary>
        public string SOURCE { get; internal set; }
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DR_DRKEY { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DR_DRKEY_IMP { get; internal set; }
        /// <summary>
        /// Debtor name [Alphanumeric: a30]
        /// </summary>
        public string DR_TITLE { get; internal set; }
        /// <summary>
        /// CONTACT NAME [Alphanumeric: a30]
        /// </summary>
        public string DR_CONTACT { get; internal set; }
        /// <summary>
        /// Business name [Alphanumeric: a30]
        /// </summary>
        public string DR_BUSNAME { get; internal set; }
        /// <summary>
        /// Business address of Debtor [Alphanumeric: a30]
        /// </summary>
        public string DR_BUSADD01 { get; internal set; }
        /// <summary>
        /// Business address of Debtor [Alphanumeric: a30]
        /// </summary>
        public string DR_BUSADD02 { get; internal set; }
        /// <summary>
        /// Business state [Uppercase Alphanumeric: u3]
        /// </summary>
        public string DR_BUSSTATE { get; internal set; }
        /// <summary>
        /// Postcode [Alphanumeric: a4]
        /// </summary>
        public string DR_POSTCODE { get; internal set; }
        /// <summary>
        /// Telephone number [Alphanumeric: a20]
        /// </summary>
        public string DR_TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile [Alphanumeric: a15]
        /// </summary>
        public string DR_FAX { get; internal set; }
        /// <summary>
        /// Mailing name [Alphanumeric: a30]
        /// </summary>
        public string DR_MAILNAME { get; internal set; }
        /// <summary>
        /// Mailing address [Alphanumeric: a30]
        /// </summary>
        public string DR_MAILADD01 { get; internal set; }
        /// <summary>
        /// Mailing address [Alphanumeric: a30]
        /// </summary>
        public string DR_MAILADD02 { get; internal set; }
        /// <summary>
        /// Mailing state [Uppercase Alphanumeric: u3]
        /// </summary>
        public string DR_MAILSTATE { get; internal set; }
        /// <summary>
        /// Mailing postcode [Alphanumeric: a4]
        /// </summary>
        public string DR_MAILPOST { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DR_DRTYPE { get; internal set; }
        /// <summary>
        /// Charges this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DR_CHARGES_YTD { get; internal set; }
        /// <summary>
        /// Notes about this client [Memo: m]
        /// </summary>
        public string DR_NOTES { get; internal set; }
        /// <summary>
        /// Y/N flag for memos [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DR_MEMO_FLAG { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string DR_REMARK { get; internal set; }
        /// <summary>
        /// Email address for emailing financial statements direct to the Sundry Debtor [Alphanumeric: a60]
        /// </summary>
        public string DR_BILLING_EMAIL { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DR_BALANCE { get; internal set; }
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CR_CRKEY { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CR_CRKEY_IMP { get; internal set; }
        /// <summary>
        /// Creditor title [Alphanumeric: a40]
        /// </summary>
        public string CR_TITLE { get; internal set; }
        /// <summary>
        /// Curr Bal [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CR_CUR_BAL { get; internal set; }
        /// <summary>
        /// Contact name [Alphanumeric: a30]
        /// </summary>
        public string CR_CONTACT { get; internal set; }
        /// <summary>
        /// Three address lines [Alphanumeric: a40]
        /// </summary>
        public string CR_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Three address lines [Alphanumeric: a40]
        /// </summary>
        public string CR_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Three address lines [Alphanumeric: a40]
        /// </summary>
        public string CR_ADDRESS03 { get; internal set; }
        /// <summary>
        /// State [Uppercase Alphanumeric: u4]
        /// </summary>
        public string CR_STATE { get; internal set; }
        /// <summary>
        /// Post code [Alphanumeric: a4]
        /// </summary>
        public string CR_POSTCODE { get; internal set; }
        /// <summary>
        /// Phone number [Alphanumeric: a15]
        /// </summary>
        public string CR_TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile number [Alphanumeric: a15]
        /// </summary>
        public string CR_FAX { get; internal set; }
        /// <summary>
        /// Email Address [Alphanumeric: a60]
        /// </summary>
        public string CR_EMAIL { get; internal set; }
        /// <summary>
        /// Email For Payments [Alphanumeric: a60]
        /// </summary>
        public string CR_EMAIL_FOR_PAYMENTS { get; internal set; }
        /// <summary>
        /// Mobile number [Alphanumeric: a15]
        /// </summary>
        public string CR_MOBILE { get; internal set; }
        /// <summary>
        /// Is this a PRMS creditor [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CR_PRMS_FLAG { get; internal set; }
        /// <summary>
        /// Australian Business number [Uppercase Alphanumeric: u15]
        /// </summary>
        public string CR_ABN { get; internal set; }
        /// <summary>
        /// Pay As You Go rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? CR_PAYG_RATE { get; internal set; }
        /// <summary>
        /// Credit limit [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CR_CRLIMIT { get; internal set; }
        /// <summary>
        /// Trading terms in days [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CR_TERMS { get; internal set; }
        /// <summary>
        /// Bank/State/Branch number [Alphanumeric: a6]
        /// </summary>
        public string CR_BSB { get; internal set; }
        /// <summary>
        /// Bank Account Number [Alphanumeric: a15]
        /// </summary>
        public string CR_ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Bank Account Name [Alphanumeric: a60]
        /// </summary>
        public string CR_ACCOUNT_NAME { get; internal set; }
        /// <summary>
        /// Lodgement Reference [Alphanumeric: a18]
        /// </summary>
        public string CR_LODGE_REF { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string CR_SURNAME { get; internal set; }
        /// <summary>
        /// First name [Uppercase Alphanumeric: u15]
        /// </summary>
        public string CR_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name [Uppercase Alphanumeric: u15]
        /// </summary>
        public string CR_SECOND_NAME { get; internal set; }
        /// <summary>
        /// Birthdate [Date Time nullable: d]
        /// </summary>
        public DateTime? CR_PAYG_BIRTHDATE { get; internal set; }
        /// <summary>
        /// Startdate [Date Time nullable: d]
        /// </summary>
        public DateTime? CR_PAYG_STARTDATE { get; internal set; }
        /// <summary>
        /// Contract enddate [Date Time nullable: d]
        /// </summary>
        public DateTime? CR_PAYG_TERMDATE { get; internal set; }
        /// <summary>
        /// Two address lines [Uppercase Alphanumeric: u38]
        /// </summary>
        public string CR_PAYG_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines [Uppercase Alphanumeric: u38]
        /// </summary>
        public string CR_PAYG_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb [Uppercase Alphanumeric: u20]
        /// </summary>
        public string CR_PAYG_SUBURB { get; internal set; }
        /// <summary>
        /// State [Uppercase Alphanumeric: u3]
        /// </summary>
        public string CR_PAYG_STATE { get; internal set; }
        /// <summary>
        /// Postcode [Uppercase Alphanumeric: u4]
        /// </summary>
        public string CR_PAYG_POST { get; internal set; }
        /// <summary>
        /// Country [Uppercase Alphanumeric: u20]
        /// </summary>
        public string CR_PAYG_COUNTRY { get; internal set; }
        /// <summary>
        /// Payer code in PPD [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CR_PPDKEY { get; internal set; }
        /// <summary>
        /// BPAY biller code [Alphanumeric: a10]
        /// </summary>
        public string CR_BILLER_CODE { get; internal set; }
        /// <summary>
        /// BPAY reference [Alphanumeric: a20]
        /// </summary>
        public string CR_BPAY_REFERENCE { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? CR_LASTPAYDATE { get; internal set; }
        /// <summary>
        /// Employee key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PE_PEKEY { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PE_PEKEY_IMP { get; internal set; }
        /// <summary>
        /// Employee surname [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PE_SURNAME { get; internal set; }
        /// <summary>
        /// First name [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PE_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PE_SECOND_NAME { get; internal set; }
        /// <summary>
        /// Known as or prefered name [Alphanumeric: a15]
        /// </summary>
        public string PE_PREF_NAME { get; internal set; }
        /// <summary>
        /// Previous surname [Alphanumeric: a30]
        /// </summary>
        public string PE_PREVIOUS_NAME { get; internal set; }
        /// <summary>
        /// Birth date [Date Time nullable: d]
        /// </summary>
        public DateTime? PE_BIRTHDATE { get; internal set; }
        /// <summary>
        /// Gender (M or F) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_GENDER { get; internal set; }
        /// <summary>
        /// Home address [Uppercase Alphanumeric: u38]
        /// </summary>
        public string PE_HOMEADD01 { get; internal set; }
        /// <summary>
        /// Home address [Uppercase Alphanumeric: u38]
        /// </summary>
        public string PE_HOMEADD02 { get; internal set; }
        /// <summary>
        /// Home suburb [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PE_HOMESUBURB { get; internal set; }
        /// <summary>
        /// Home state [Uppercase Alphanumeric: u3]
        /// </summary>
        public string PE_HOMESTATE { get; internal set; }
        /// <summary>
        /// Home post code [Alphanumeric: a4]
        /// </summary>
        public string PE_HOMEPOST { get; internal set; }
        /// <summary>
        /// Overseas Country [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PE_COUNTRY { get; internal set; }
        /// <summary>
        /// Home telephone number [Alphanumeric: a15]
        /// </summary>
        public string PE_HOMEPHONE { get; internal set; }
        /// <summary>
        /// Business phone [Alphanumeric: a15]
        /// </summary>
        public string PE_BUS_PHONE { get; internal set; }
        /// <summary>
        /// Phone extention [Alphanumeric: a5]
        /// </summary>
        public string PE_PHONE_EXT { get; internal set; }
        /// <summary>
        /// Fax number [Alphanumeric: a15]
        /// </summary>
        public string PE_FAX { get; internal set; }
        /// <summary>
        /// Mobile [Alphanumeric: a15]
        /// </summary>
        public string PE_MOBILE { get; internal set; }
        /// <summary>
        /// E-mail address [Alphanumeric: a60]
        /// </summary>
        public string PE_EMAIL { get; internal set; }
        /// <summary>
        /// Driver's licence number [Alphanumeric: a15]
        /// </summary>
        public string PE_DRIVERS_LIC_NO { get; internal set; }
        /// <summary>
        /// Previous salary review date [Date Time nullable: d]
        /// </summary>
        public DateTime? PE_SALREVDATE { get; internal set; }
        /// <summary>
        /// Leave Calc Suspended To date [Date Time nullable: d]
        /// </summary>
        public DateTime? PE_SUSPEND_DATE { get; internal set; }
        /// <summary>
        /// Payroll number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PE_PENUMBER { get; internal set; }
        /// <summary>
        /// Tax file number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PE_TAXFILENUM { get; internal set; }
        /// <summary>
        /// Tax code [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PE_TAXCODE { get; internal set; }
        /// <summary>
        /// Number of dependents [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PE_NO_DEPEND { get; internal set; }
        /// <summary>
        /// Annual dependent rebate [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PE_DEP_REBATE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_ZONE_CODE { get; internal set; }
        /// <summary>
        /// Zone allowance claimed [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PE_ZONE_ALLOW { get; internal set; }
        /// <summary>
        /// Taxable Allowances per week [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PE_ALLOWANCES { get; internal set; }
        /// <summary>
        /// Payroll group [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PE_PAYCODE { get; internal set; }
        /// <summary>
        /// Department [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PE_DEPARTMENT { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_EMPLOY_TYPE { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PE_NORMAL_HOURS { get; internal set; }
        /// <summary>
        /// Full time equivalent [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PE_FTE_VALUE { get; internal set; }
        /// <summary>
        /// Annual Salary [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PE_ANNUAL_SALARY { get; internal set; }
        /// <summary>
        /// Standard hours for this position per pay cycle [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PE_STD_HOURS { get; internal set; }
        /// <summary>
        /// Union name [Alphanumeric: a20]
        /// </summary>
        public string PE_UNION_NAME { get; internal set; }
        /// <summary>
        /// Answer to Q9 [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_MEDICARE_Q09A { get; internal set; }
        /// <summary>
        /// Answer to Q10 [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_MEDICARE_Q10A { get; internal set; }
        /// <summary>
        /// Answer to Q11 [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_MEDICARE_Q11A { get; internal set; }
        /// <summary>
        /// Answer to Q12 [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_MEDICARE_Q12A { get; internal set; }
        /// <summary>
        /// Leave Management Group [Uppercase Alphanumeric: u8]
        /// </summary>
        public string PE_LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Y if the SGL threshold is ignored for this employee [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PE_ESUPER_IGNORE_THRESHOLD { get; internal set; }
        /// <summary>
        /// Superannuation fund name [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PE_ESUPER_FUND { get; internal set; }
        /// <summary>
        /// Superannuation fund member number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PE_ESUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Superannuation percentage [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PE_ESUPER_PERCENT { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? PE_LASTPAYDATE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PE_PEPS_TRCENTRE { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? PE_START_DATE_IMP { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEPS_CODE { get; internal set; }
        /// <summary>
        /// Pay item code [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PEPS_PAYITEM { get; internal set; }
        /// <summary>
        /// Pay rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PEPS_TRCOST { get; internal set; }
        /// <summary>
        /// Hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PEPS_TRQTY { get; internal set; }
        /// <summary>
        /// Dollar value [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PEPS_TRAMT { get; internal set; }
        /// <summary>
        /// Detail [Alphanumeric: a30]
        /// </summary>
        public string PEPS_TRDET { get; internal set; }
        /// <summary>
        /// S = Standard L = Last [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PEPS_FLAG { get; internal set; }
        /// <summary>
        /// Pay Rate Step [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PEPS_PAY_STEP { get; internal set; }
        /// <summary>
        /// Super fund key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEPS_SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PEPS_SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Percentage contribution [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PEPS_SUPER_PERCENT { get; internal set; }
        /// <summary>
        /// Cost Centre [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEPS_TRCENTRE { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEPM_CODE { get; internal set; }
        /// <summary>
        /// Bank Account name [Uppercase Alphanumeric: u30]
        /// </summary>
        public string PEPM_NAME { get; internal set; }
        /// <summary>
        /// Temporary value [Alphanumeric: a10]
        /// </summary>
        public string PEPM_CHQ_NO { get; internal set; }
        /// <summary>
        /// Default amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PEPM_DAMOUNT { get; internal set; }
        /// <summary>
        /// Bank name [Alphanumeric: a12]
        /// </summary>
        public string PEPM_BANK { get; internal set; }
        /// <summary>
        /// Bank-state-branch as BBBBBB [Alphanumeric: a6]
        /// </summary>
        public string PEPM_BSB { get; internal set; }
        /// <summary>
        /// Account number [Alphanumeric: a15]
        /// </summary>
        public string PEPM_ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Actual amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PEPM_AMOUNT { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PEPM_FLAG { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u2]
        /// </summary>
        public string PEPM_PAYMODE { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEPY_CODE { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? PEPY_TRANSDATE { get; internal set; }
        /// <summary>
        /// Originator [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEPY_STAFF { get; internal set; }
        /// <summary>
        /// Generic purpose for notes [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PEPY_PURPOSE { get; internal set; }
        /// <summary>
        /// Employee notes [Memo: m]
        /// </summary>
        public string PEPY_NOTES { get; internal set; }
        /// <summary>
        /// Key [Uppercase Alphanumeric: u6]
        /// </summary>
        public string KPN_KPNKEY { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u6]
        /// </summary>
        public string KPN_KPNKEY_IMP { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a40]
        /// </summary>
        public string KPN_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Contact code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPC_KPCKEY { get; internal set; }
        /// <summary>
        /// Contact surname [Alphanumeric: a20]
        /// </summary>
        public string KPC_SURNAME { get; internal set; }
        /// <summary>
        /// First name [Alphanumeric: a15]
        /// </summary>
        public string KPC_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name [Alphanumeric: a15]
        /// </summary>
        public string KPC_SECOND_NAME { get; internal set; }
        /// <summary>
        /// Gender [Uppercase Alphanumeric: u1]
        /// </summary>
        public string KPC_GENDER { get; internal set; }
        /// <summary>
        /// Address [Alphanumeric: a30]
        /// </summary>
        public string KPC_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Address [Alphanumeric: a30]
        /// </summary>
        public string KPC_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Address [Alphanumeric: a30]
        /// </summary>
        public string KPC_ADDRESS03 { get; internal set; }
        /// <summary>
        /// State [Uppercase Alphanumeric: u3]
        /// </summary>
        public string KPC_STATE { get; internal set; }
        /// <summary>
        /// Post code [Alphanumeric: a4]
        /// </summary>
        public string KPC_POST { get; internal set; }
        /// <summary>
        /// Business phone [Alphanumeric: a15]
        /// </summary>
        public string KPC_BUS_PHONE { get; internal set; }
        /// <summary>
        /// Alternate/ home phone [Alphanumeric: a15]
        /// </summary>
        public string KPC_HOME_PHONE { get; internal set; }
        /// <summary>
        /// Mobile phone [Alphanumeric: a15]
        /// </summary>
        public string KPC_MOBILE { get; internal set; }
        /// <summary>
        /// Email address [Memo: m]
        /// </summary>
        public string KPC_EMAIL { get; internal set; }
        /// <summary>
        /// Key [Integer (32bit signed nullable): l]
        /// </summary>
        public int? KPCL_KPCLKEY { get; internal set; }
        /// <summary>
        /// PE Link [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPCL_LINK { get; internal set; }
        /// <summary>
        /// Link type (eg:PE,DH) [Uppercase Alphanumeric: u3]
        /// </summary>
        public string KPCL_SOURCE { get; internal set; }
        /// <summary>
        /// Link code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPCL_CONTACT { get; internal set; }
        /// <summary>
        /// Contact description eg:Parents, Manager [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPCL_CONTACT_TYPE { get; internal set; }
        /// <summary>
        /// Order of contact [Integer (16bit signed nullable): i]
        /// </summary>
        public short? KPCL_CONTACT_PREFERENCE { get; internal set; }
        /// <summary>
        /// Contact relationship Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPCR_KPCRKEY { get; internal set; }
        /// <summary>
        /// Contact relationship Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPCR_KPCRKEY_IMP { get; internal set; }
        /// <summary>
        /// Contact Relation description [Alphanumeric: a30]
        /// </summary>
        public string KPCR_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Super fund key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PF_PFKEY { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PF_PFKEY_IMP { get; internal set; }
        /// <summary>
        /// Super fund name [Alphanumeric: a30]
        /// </summary>
        public string PF_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Pay item key [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PI_PIKEY { get; internal set; }
        /// <summary>
        /// Pay item key [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PI_PIKEY_IMP { get; internal set; }
        /// <summary>
        /// oldname=PAYTYPE; * PN KEY  0 if available to all [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PI_PAYCODE { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string PI_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Addition or Deduction [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PI_TRANSTYPE { get; internal set; }
        /// <summary>
        /// This item taxable? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PI_TAXABLE { get; internal set; }
        /// <summary>
        /// Hrs, Kms, Day, Prd, etc [Alphanumeric: a3]
        /// </summary>
        public string PI_UNIT { get; internal set; }
        /// <summary>
        /// Category (eg SICK,HOLS,NORM) [Alphanumeric: a5]
        /// </summary>
        public string PI_CATEGORY { get; internal set; }
        /// <summary>
        /// PAYG Payment summary box no. [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PI_PAYG_BOX { get; internal set; }
        /// <summary>
        /// Direct tax rate for this item [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PI_TAXRATE { get; internal set; }
        /// <summary>
        /// Calc VALUE = RATE*HOURS? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PI_AUTOCALC { get; internal set; }
        /// <summary>
        /// SGL  applies? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PI_SUPER_LEVY { get; internal set; }
        /// <summary>
        /// Use  for personal super calc? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PI_PERS_SUPER { get; internal set; }
        /// <summary>
        /// Rate for personal super [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PI_PERS_SUPER_RATE { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string PI_INITIATIVE { get; internal set; }
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_ARKEY { get; internal set; }
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_ARKEY_IMP { get; internal set; }
        /// <summary>
        /// Title (Primary description) [Alphanumeric: a40]
        /// </summary>
        public string AR_TITLE { get; internal set; }
        /// <summary>
        /// Extra description of the asset [Alphanumeric: a30]
        /// </summary>
        public string AR_DESCRIPTION01 { get; internal set; }
        /// <summary>
        /// Extra description of the asset [Alphanumeric: a30]
        /// </summary>
        public string AR_DESCRIPTION02 { get; internal set; }
        /// <summary>
        /// Asset type [Uppercase Alphanumeric: u2]
        /// </summary>
        public string AR_ASSET_TYPE { get; internal set; }
        /// <summary>
        /// Asset category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_CATEGORY { get; internal set; }
        /// <summary>
        /// Asset category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_CATEGORY_IMP { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_SUBCATEGORY_IMP { get; internal set; }
        /// <summary>
        /// Asset tax category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_TAX_CATEGORY { get; internal set; }
        /// <summary>
        /// Asset Release Type [Uppercase Alphanumeric: u2]
        /// </summary>
        public string AR_RELEASE_TYPE { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AR_AOB_COST { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Quantity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AR_OB_QTY { get; internal set; }
        /// <summary>
        /// Invoice number of original acquisition [Alphanumeric: a10]
        /// </summary>
        public string AR_ORIG_INVOICE_NO { get; internal set; }
        /// <summary>
        /// Invoice number of most recent purchase/addition [Alphanumeric: a10]
        /// </summary>
        public string AR_LAST_INVOICE_NO { get; internal set; }
        /// <summary>
        /// Warranty in months [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AR_WARRANTY { get; internal set; }
        /// <summary>
        /// Expiry date of warranty [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_WARRANTYEXP { get; internal set; }
        /// <summary>
        /// Serial number/Reg. number [Alphanumeric: a20]
        /// </summary>
        public string AR_SERIAL { get; internal set; }
        /// <summary>
        /// Asset locations [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_LOCATION { get; internal set; }
        /// <summary>
        /// Asset locations [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_LOCATION_IMP { get; internal set; }
        /// <summary>
        /// Departments [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_DEPARTMENT { get; internal set; }
        /// <summary>
        /// Departments [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_DEPARTMENT_IMP { get; internal set; }
        /// <summary>
        /// Campus number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AR_CAMPUS { get; internal set; }
        /// <summary>
        /// Campus number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AR_CAMPUS_IMP { get; internal set; }
        /// <summary>
        /// Sub Category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_BRANCH { get; internal set; }
        /// <summary>
        /// Lease start date [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_LEASE_START_DATE { get; internal set; }
        /// <summary>
        /// Lease end date [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_LEASE_END_DATE { get; internal set; }
        /// <summary>
        /// Last stocktake date [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_LAST_ST_DATE { get; internal set; }
        /// <summary>
        /// Last addition date [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_LAST_ADDN_DATE { get; internal set; }
        /// <summary>
        /// Expected life [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AR_EXPECTED_LIFE { get; internal set; }
        /// <summary>
        /// Last Date this asset was serviced [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_LAST_SVC_DATE { get; internal set; }
        /// <summary>
        /// Date for next service [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_NEXT_SVC_DATE { get; internal set; }
        /// <summary>
        /// Comments from last service [Memo: m]
        /// </summary>
        public string AR_LAST_SVC_DETAILS { get; internal set; }
        /// <summary>
        /// Owner [Alphanumeric: a30]
        /// </summary>
        public string AR_OWNER { get; internal set; }
        /// <summary>
        /// Cleaning memo [Memo: m]
        /// </summary>
        public string AR_CLEANING { get; internal set; }
        /// <summary>
        /// Hazard memo [Memo: m]
        /// </summary>
        public string AR_HAZARD { get; internal set; }
        /// <summary>
        /// Site reference [Alphanumeric: a20]
        /// </summary>
        public string AR_SITE_REFERENCE { get; internal set; }
        /// <summary>
        /// Extra details [Memo: m]
        /// </summary>
        public string AR_EXTRA_DETAILS { get; internal set; }
        /// <summary>
        /// Purchase Date [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_PURDATE { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? AR_PURDATE_IMP { get; internal set; }
        /// <summary>
        /// Supplier [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AR_ORIG_SUPPLIER { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AR_ORIG_COST { get; internal set; }
        /// <summary>
        /// Picture of asset [Picture (byte array): bp]
        /// </summary>
        public byte[] AR_ASSET_PIC { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string FDT_COMMENT { get; internal set; }
        /// <summary>
        /// Record has been flagged for process [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FDT_PROCESS_FLAG { get; internal set; }
        /// <summary>
        /// Date Record was exported from source on [Date Time nullable: d]
        /// </summary>
        public DateTime? FDT_DATE_EXP { get; internal set; }
        /// <summary>
        /// Time Record was exported from source on [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FDT_TIME_EXP { get; internal set; }
        /// <summary>
        /// Date Record was imported into actual table on [Date Time nullable: d]
        /// </summary>
        public DateTime? FDT_DATE_IMP { get; internal set; }
        /// <summary>
        /// Time Record was imported into actual table on [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FDT_TIME_IMP { get; internal set; }
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
        /// Navigation property for [SOURCE] => [SKGS_Entity].[SCHOOL]
        /// 
        /// </summary>
        public SKGS_Entity SOURCE_SKGS {
            get
            {
                if (SOURCE != null)
                {
                    if (_SOURCE_SKGS == null)
                    {
                        _SOURCE_SKGS = Context.SKGS.FindBySCHOOL(SOURCE);
                    }
                    return _SOURCE_SKGS;
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
