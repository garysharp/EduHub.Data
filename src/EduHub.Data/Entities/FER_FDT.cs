using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FDT Financal Holding Table
    /// </summary>
    public class FER_FDT : EntityBase
    {
#region Navigation Property Cache
        private SKGS _SOURCE_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SOURCE { get; internal set; }
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DR_DRKEY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DR_DRKEY_IMP { get; internal set; }
        /// <summary>
        /// Debtor name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_TITLE { get; internal set; }
        /// <summary>
        /// CONTACT NAME
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_CONTACT { get; internal set; }
        /// <summary>
        /// Business name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_BUSNAME { get; internal set; }
        /// <summary>
        /// Business address of Debtor
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_BUSADD01 { get; internal set; }
        /// <summary>
        /// Business address of Debtor
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_BUSADD02 { get; internal set; }
        /// <summary>
        /// Business state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string DR_BUSSTATE { get; internal set; }
        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string DR_POSTCODE { get; internal set; }
        /// <summary>
        /// Telephone number
        /// [Alphanumeric (20)]
        /// </summary>
        public string DR_TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile
        /// [Alphanumeric (15)]
        /// </summary>
        public string DR_FAX { get; internal set; }
        /// <summary>
        /// Mailing name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_MAILNAME { get; internal set; }
        /// <summary>
        /// Mailing address
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_MAILADD01 { get; internal set; }
        /// <summary>
        /// Mailing address
        /// [Alphanumeric (30)]
        /// </summary>
        public string DR_MAILADD02 { get; internal set; }
        /// <summary>
        /// Mailing state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string DR_MAILSTATE { get; internal set; }
        /// <summary>
        /// Mailing postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string DR_MAILPOST { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DR_DRTYPE { get; internal set; }
        /// <summary>
        /// Charges this year
        /// </summary>
        public decimal? DR_CHARGES_YTD { get; internal set; }
        /// <summary>
        /// Notes about this client
        /// [Memo]
        /// </summary>
        public string DR_NOTES { get; internal set; }
        /// <summary>
        /// Y/N flag for memos
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DR_MEMO_FLAG { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string DR_REMARK { get; internal set; }
        /// <summary>
        /// Email address for emailing financial statements direct to the Sundry Debtor
        /// [Alphanumeric (60)]
        /// </summary>
        public string DR_BILLING_EMAIL { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DR_BALANCE { get; internal set; }
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CR_CRKEY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CR_CRKEY_IMP { get; internal set; }
        /// <summary>
        /// Creditor title
        /// [Alphanumeric (40)]
        /// </summary>
        public string CR_TITLE { get; internal set; }
        /// <summary>
        /// Curr Bal
        /// </summary>
        public decimal? CR_CUR_BAL { get; internal set; }
        /// <summary>
        /// Contact name
        /// [Alphanumeric (30)]
        /// </summary>
        public string CR_CONTACT { get; internal set; }
        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string CR_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string CR_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string CR_ADDRESS03 { get; internal set; }
        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string CR_STATE { get; internal set; }
        /// <summary>
        /// Post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string CR_POSTCODE { get; internal set; }
        /// <summary>
        /// Phone number
        /// [Alphanumeric (15)]
        /// </summary>
        public string CR_TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string CR_FAX { get; internal set; }
        /// <summary>
        /// Email Address
        /// [Alphanumeric (60)]
        /// </summary>
        public string CR_EMAIL { get; internal set; }
        /// <summary>
        /// Email For Payments
        /// [Alphanumeric (60)]
        /// </summary>
        public string CR_EMAIL_FOR_PAYMENTS { get; internal set; }
        /// <summary>
        /// Mobile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string CR_MOBILE { get; internal set; }
        /// <summary>
        /// Is this a PRMS creditor
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CR_PRMS_FLAG { get; internal set; }
        /// <summary>
        /// Australian Business number
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string CR_ABN { get; internal set; }
        /// <summary>
        /// Pay As You Go rate
        /// </summary>
        public double? CR_PAYG_RATE { get; internal set; }
        /// <summary>
        /// Credit limit
        /// </summary>
        public decimal? CR_CRLIMIT { get; internal set; }
        /// <summary>
        /// Trading terms in days
        /// </summary>
        public short? CR_TERMS { get; internal set; }
        /// <summary>
        /// Bank/State/Branch number
        /// [Alphanumeric (6)]
        /// </summary>
        public string CR_BSB { get; internal set; }
        /// <summary>
        /// Bank Account Number
        /// [Alphanumeric (15)]
        /// </summary>
        public string CR_ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Bank Account Name
        /// [Alphanumeric (60)]
        /// </summary>
        public string CR_ACCOUNT_NAME { get; internal set; }
        /// <summary>
        /// Lodgement Reference
        /// [Alphanumeric (18)]
        /// </summary>
        public string CR_LODGE_REF { get; internal set; }
        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string CR_SURNAME { get; internal set; }
        /// <summary>
        /// First name
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string CR_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string CR_SECOND_NAME { get; internal set; }
        /// <summary>
        /// Birthdate
        /// </summary>
        public DateTime? CR_PAYG_BIRTHDATE { get; internal set; }
        /// <summary>
        /// Startdate
        /// </summary>
        public DateTime? CR_PAYG_STARTDATE { get; internal set; }
        /// <summary>
        /// Contract enddate
        /// </summary>
        public DateTime? CR_PAYG_TERMDATE { get; internal set; }
        /// <summary>
        /// Two address lines
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string CR_PAYG_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string CR_PAYG_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string CR_PAYG_SUBURB { get; internal set; }
        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string CR_PAYG_STATE { get; internal set; }
        /// <summary>
        /// Postcode
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string CR_PAYG_POST { get; internal set; }
        /// <summary>
        /// Country
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string CR_PAYG_COUNTRY { get; internal set; }
        /// <summary>
        /// Payer code in PPD
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CR_PPDKEY { get; internal set; }
        /// <summary>
        /// BPAY biller code
        /// [Alphanumeric (10)]
        /// </summary>
        public string CR_BILLER_CODE { get; internal set; }
        /// <summary>
        /// BPAY reference
        /// [Alphanumeric (20)]
        /// </summary>
        public string CR_BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CR_LASTPAYDATE { get; internal set; }
        /// <summary>
        /// Employee key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PE_PEKEY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PE_PEKEY_IMP { get; internal set; }
        /// <summary>
        /// Employee surname
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PE_SURNAME { get; internal set; }
        /// <summary>
        /// First name
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PE_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PE_SECOND_NAME { get; internal set; }
        /// <summary>
        /// Known as or prefered name
        /// [Alphanumeric (15)]
        /// </summary>
        public string PE_PREF_NAME { get; internal set; }
        /// <summary>
        /// Previous surname
        /// [Alphanumeric (30)]
        /// </summary>
        public string PE_PREVIOUS_NAME { get; internal set; }
        /// <summary>
        /// Birth date
        /// </summary>
        public DateTime? PE_BIRTHDATE { get; internal set; }
        /// <summary>
        /// Gender (M or F)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_GENDER { get; internal set; }
        /// <summary>
        /// Home address
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string PE_HOMEADD01 { get; internal set; }
        /// <summary>
        /// Home address
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string PE_HOMEADD02 { get; internal set; }
        /// <summary>
        /// Home suburb
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PE_HOMESUBURB { get; internal set; }
        /// <summary>
        /// Home state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string PE_HOMESTATE { get; internal set; }
        /// <summary>
        /// Home post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string PE_HOMEPOST { get; internal set; }
        /// <summary>
        /// Overseas Country
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PE_COUNTRY { get; internal set; }
        /// <summary>
        /// Home telephone number
        /// [Alphanumeric (15)]
        /// </summary>
        public string PE_HOMEPHONE { get; internal set; }
        /// <summary>
        /// Business phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string PE_BUS_PHONE { get; internal set; }
        /// <summary>
        /// Phone extention
        /// [Alphanumeric (5)]
        /// </summary>
        public string PE_PHONE_EXT { get; internal set; }
        /// <summary>
        /// Fax number
        /// [Alphanumeric (15)]
        /// </summary>
        public string PE_FAX { get; internal set; }
        /// <summary>
        /// Mobile
        /// [Alphanumeric (15)]
        /// </summary>
        public string PE_MOBILE { get; internal set; }
        /// <summary>
        /// E-mail address
        /// [Alphanumeric (60)]
        /// </summary>
        public string PE_EMAIL { get; internal set; }
        /// <summary>
        /// Driver's licence number
        /// [Alphanumeric (15)]
        /// </summary>
        public string PE_DRIVERS_LIC_NO { get; internal set; }
        /// <summary>
        /// Previous salary review date
        /// </summary>
        public DateTime? PE_SALREVDATE { get; internal set; }
        /// <summary>
        /// Leave Calc Suspended To date
        /// </summary>
        public DateTime? PE_SUSPEND_DATE { get; internal set; }
        /// <summary>
        /// Payroll number
        /// </summary>
        public int? PE_PENUMBER { get; internal set; }
        /// <summary>
        /// Tax file number
        /// </summary>
        public int? PE_TAXFILENUM { get; internal set; }
        /// <summary>
        /// Tax code
        /// </summary>
        public short? PE_TAXCODE { get; internal set; }
        /// <summary>
        /// Number of dependents
        /// </summary>
        public short? PE_NO_DEPEND { get; internal set; }
        /// <summary>
        /// Annual dependent rebate
        /// </summary>
        public decimal? PE_DEP_REBATE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_ZONE_CODE { get; internal set; }
        /// <summary>
        /// Zone allowance claimed
        /// </summary>
        public decimal? PE_ZONE_ALLOW { get; internal set; }
        /// <summary>
        /// Taxable Allowances per week
        /// </summary>
        public decimal? PE_ALLOWANCES { get; internal set; }
        /// <summary>
        /// Payroll group
        /// </summary>
        public short? PE_PAYCODE { get; internal set; }
        /// <summary>
        /// Department
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PE_DEPARTMENT { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_EMPLOY_TYPE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PE_NORMAL_HOURS { get; internal set; }
        /// <summary>
        /// Full time equivalent
        /// </summary>
        public double? PE_FTE_VALUE { get; internal set; }
        /// <summary>
        /// Annual Salary
        /// </summary>
        public decimal? PE_ANNUAL_SALARY { get; internal set; }
        /// <summary>
        /// Standard hours for this position per pay cycle
        /// </summary>
        public double? PE_STD_HOURS { get; internal set; }
        /// <summary>
        /// Union name
        /// [Alphanumeric (20)]
        /// </summary>
        public string PE_UNION_NAME { get; internal set; }
        /// <summary>
        /// Answer to Q9
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_MEDICARE_Q09A { get; internal set; }
        /// <summary>
        /// Answer to Q10
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_MEDICARE_Q10A { get; internal set; }
        /// <summary>
        /// Answer to Q11
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_MEDICARE_Q11A { get; internal set; }
        /// <summary>
        /// Answer to Q12
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_MEDICARE_Q12A { get; internal set; }
        /// <summary>
        /// Leave Management Group
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string PE_LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Y if the SGL threshold is ignored for this employee
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PE_ESUPER_IGNORE_THRESHOLD { get; internal set; }
        /// <summary>
        /// Superannuation fund name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PE_ESUPER_FUND { get; internal set; }
        /// <summary>
        /// Superannuation fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PE_ESUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Superannuation percentage
        /// </summary>
        public double? PE_ESUPER_PERCENT { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PE_LASTPAYDATE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PE_PEPS_TRCENTRE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PE_START_DATE_IMP { get; internal set; }
        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEPS_CODE { get; internal set; }
        /// <summary>
        /// Pay item code
        /// </summary>
        public short? PEPS_PAYITEM { get; internal set; }
        /// <summary>
        /// Pay rate
        /// </summary>
        public double? PEPS_TRCOST { get; internal set; }
        /// <summary>
        /// Hours
        /// </summary>
        public double? PEPS_TRQTY { get; internal set; }
        /// <summary>
        /// Dollar value
        /// </summary>
        public decimal? PEPS_TRAMT { get; internal set; }
        /// <summary>
        /// Detail
        /// [Alphanumeric (30)]
        /// </summary>
        public string PEPS_TRDET { get; internal set; }
        /// <summary>
        /// S = Standard L = Last
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PEPS_FLAG { get; internal set; }
        /// <summary>
        /// Pay Rate Step
        /// </summary>
        public short? PEPS_PAY_STEP { get; internal set; }
        /// <summary>
        /// Super fund key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEPS_SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PEPS_SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Percentage contribution
        /// </summary>
        public double? PEPS_SUPER_PERCENT { get; internal set; }
        /// <summary>
        /// Cost Centre
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEPS_TRCENTRE { get; internal set; }
        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEPM_CODE { get; internal set; }
        /// <summary>
        /// Bank Account name
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string PEPM_NAME { get; internal set; }
        /// <summary>
        /// Temporary value
        /// [Alphanumeric (10)]
        /// </summary>
        public string PEPM_CHQ_NO { get; internal set; }
        /// <summary>
        /// Default amount
        /// </summary>
        public decimal? PEPM_DAMOUNT { get; internal set; }
        /// <summary>
        /// Bank name
        /// [Alphanumeric (12)]
        /// </summary>
        public string PEPM_BANK { get; internal set; }
        /// <summary>
        /// Bank-state-branch as BBBBBB
        /// [Alphanumeric (6)]
        /// </summary>
        public string PEPM_BSB { get; internal set; }
        /// <summary>
        /// Account number
        /// [Alphanumeric (15)]
        /// </summary>
        public string PEPM_ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Actual amount
        /// </summary>
        public decimal? PEPM_AMOUNT { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PEPM_FLAG { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string PEPM_PAYMODE { get; internal set; }
        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEPY_CODE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PEPY_TRANSDATE { get; internal set; }
        /// <summary>
        /// Originator
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEPY_STAFF { get; internal set; }
        /// <summary>
        /// Generic purpose for notes
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PEPY_PURPOSE { get; internal set; }
        /// <summary>
        /// Employee notes
        /// [Memo]
        /// </summary>
        public string PEPY_NOTES { get; internal set; }
        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KPN_KPNKEY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KPN_KPNKEY_IMP { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (40)]
        /// </summary>
        public string KPN_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Contact code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPC_KPCKEY { get; internal set; }
        /// <summary>
        /// Contact surname
        /// [Alphanumeric (20)]
        /// </summary>
        public string KPC_SURNAME { get; internal set; }
        /// <summary>
        /// First name
        /// [Alphanumeric (15)]
        /// </summary>
        public string KPC_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name
        /// [Alphanumeric (15)]
        /// </summary>
        public string KPC_SECOND_NAME { get; internal set; }
        /// <summary>
        /// Gender
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string KPC_GENDER { get; internal set; }
        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string KPC_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string KPC_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string KPC_ADDRESS03 { get; internal set; }
        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KPC_STATE { get; internal set; }
        /// <summary>
        /// Post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string KPC_POST { get; internal set; }
        /// <summary>
        /// Business phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string KPC_BUS_PHONE { get; internal set; }
        /// <summary>
        /// Alternate/ home phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string KPC_HOME_PHONE { get; internal set; }
        /// <summary>
        /// Mobile phone
        /// [Alphanumeric (15)]
        /// </summary>
        public string KPC_MOBILE { get; internal set; }
        /// <summary>
        /// Email address
        /// [Memo]
        /// </summary>
        public string KPC_EMAIL { get; internal set; }
        /// <summary>
        /// Key
        /// </summary>
        public int? KPCL_KPCLKEY { get; internal set; }
        /// <summary>
        /// PE Link
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCL_LINK { get; internal set; }
        /// <summary>
        /// Link type (eg:PE,DH)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KPCL_SOURCE { get; internal set; }
        /// <summary>
        /// Link code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCL_CONTACT { get; internal set; }
        /// <summary>
        /// Contact description eg:Parents, Manager
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCL_CONTACT_TYPE { get; internal set; }
        /// <summary>
        /// Order of contact
        /// </summary>
        public short? KPCL_CONTACT_PREFERENCE { get; internal set; }
        /// <summary>
        /// Contact relationship Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCR_KPCRKEY { get; internal set; }
        /// <summary>
        /// Contact relationship Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCR_KPCRKEY_IMP { get; internal set; }
        /// <summary>
        /// Contact Relation description
        /// [Alphanumeric (30)]
        /// </summary>
        public string KPCR_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Super fund key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PF_PFKEY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PF_PFKEY_IMP { get; internal set; }
        /// <summary>
        /// Super fund name
        /// [Alphanumeric (30)]
        /// </summary>
        public string PF_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Pay item key
        /// </summary>
        public short? PI_PIKEY { get; internal set; }
        /// <summary>
        /// Pay item key
        /// </summary>
        public short? PI_PIKEY_IMP { get; internal set; }
        /// <summary>
        /// oldname=PAYTYPE; * PN KEY  0 if available to all
        /// </summary>
        public short? PI_PAYCODE { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string PI_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Addition or Deduction
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PI_TRANSTYPE { get; internal set; }
        /// <summary>
        /// This item taxable? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PI_TAXABLE { get; internal set; }
        /// <summary>
        /// Hrs, Kms, Day, Prd, etc
        /// [Alphanumeric (3)]
        /// </summary>
        public string PI_UNIT { get; internal set; }
        /// <summary>
        /// Category (eg SICK,HOLS,NORM)
        /// [Alphanumeric (5)]
        /// </summary>
        public string PI_CATEGORY { get; internal set; }
        /// <summary>
        /// PAYG Payment summary box no.
        /// </summary>
        public short? PI_PAYG_BOX { get; internal set; }
        /// <summary>
        /// Direct tax rate for this item
        /// </summary>
        public double? PI_TAXRATE { get; internal set; }
        /// <summary>
        /// Calc VALUE = RATE*HOURS? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PI_AUTOCALC { get; internal set; }
        /// <summary>
        /// SGL  applies?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PI_SUPER_LEVY { get; internal set; }
        /// <summary>
        /// Use  for personal super calc?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PI_PERS_SUPER { get; internal set; }
        /// <summary>
        /// Rate for personal super
        /// </summary>
        public double? PI_PERS_SUPER_RATE { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string PI_INITIATIVE { get; internal set; }
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_ARKEY { get; internal set; }
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_ARKEY_IMP { get; internal set; }
        /// <summary>
        /// Title (Primary description)
        /// [Alphanumeric (40)]
        /// </summary>
        public string AR_TITLE { get; internal set; }
        /// <summary>
        /// Extra description of the asset
        /// [Alphanumeric (30)]
        /// </summary>
        public string AR_DESCRIPTION01 { get; internal set; }
        /// <summary>
        /// Extra description of the asset
        /// [Alphanumeric (30)]
        /// </summary>
        public string AR_DESCRIPTION02 { get; internal set; }
        /// <summary>
        /// Asset type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string AR_ASSET_TYPE { get; internal set; }
        /// <summary>
        /// Asset category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_CATEGORY { get; internal set; }
        /// <summary>
        /// Asset category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_CATEGORY_IMP { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_SUBCATEGORY_IMP { get; internal set; }
        /// <summary>
        /// Asset tax category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_TAX_CATEGORY { get; internal set; }
        /// <summary>
        /// Asset Release Type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string AR_RELEASE_TYPE { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Cost ex GST
        /// </summary>
        public decimal? AR_AOB_COST { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Quantity
        /// </summary>
        public short? AR_OB_QTY { get; internal set; }
        /// <summary>
        /// Invoice number of original acquisition
        /// [Alphanumeric (10)]
        /// </summary>
        public string AR_ORIG_INVOICE_NO { get; internal set; }
        /// <summary>
        /// Invoice number of most recent purchase/addition
        /// [Alphanumeric (10)]
        /// </summary>
        public string AR_LAST_INVOICE_NO { get; internal set; }
        /// <summary>
        /// Warranty in months
        /// </summary>
        public short? AR_WARRANTY { get; internal set; }
        /// <summary>
        /// Expiry date of warranty
        /// </summary>
        public DateTime? AR_WARRANTYEXP { get; internal set; }
        /// <summary>
        /// Serial number/Reg. number
        /// [Alphanumeric (20)]
        /// </summary>
        public string AR_SERIAL { get; internal set; }
        /// <summary>
        /// Asset locations
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_LOCATION { get; internal set; }
        /// <summary>
        /// Asset locations
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_LOCATION_IMP { get; internal set; }
        /// <summary>
        /// Departments
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_DEPARTMENT { get; internal set; }
        /// <summary>
        /// Departments
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_DEPARTMENT_IMP { get; internal set; }
        /// <summary>
        /// Campus number
        /// </summary>
        public int? AR_CAMPUS { get; internal set; }
        /// <summary>
        /// Campus number
        /// </summary>
        public int? AR_CAMPUS_IMP { get; internal set; }
        /// <summary>
        /// Sub Category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_BRANCH { get; internal set; }
        /// <summary>
        /// Lease start date
        /// </summary>
        public DateTime? AR_LEASE_START_DATE { get; internal set; }
        /// <summary>
        /// Lease end date
        /// </summary>
        public DateTime? AR_LEASE_END_DATE { get; internal set; }
        /// <summary>
        /// Last stocktake date
        /// </summary>
        public DateTime? AR_LAST_ST_DATE { get; internal set; }
        /// <summary>
        /// Last addition date
        /// </summary>
        public DateTime? AR_LAST_ADDN_DATE { get; internal set; }
        /// <summary>
        /// Expected life
        /// </summary>
        public short? AR_EXPECTED_LIFE { get; internal set; }
        /// <summary>
        /// Last Date this asset was serviced
        /// </summary>
        public DateTime? AR_LAST_SVC_DATE { get; internal set; }
        /// <summary>
        /// Date for next service
        /// </summary>
        public DateTime? AR_NEXT_SVC_DATE { get; internal set; }
        /// <summary>
        /// Comments from last service
        /// [Memo]
        /// </summary>
        public string AR_LAST_SVC_DETAILS { get; internal set; }
        /// <summary>
        /// Owner
        /// [Alphanumeric (30)]
        /// </summary>
        public string AR_OWNER { get; internal set; }
        /// <summary>
        /// Cleaning memo
        /// [Memo]
        /// </summary>
        public string AR_CLEANING { get; internal set; }
        /// <summary>
        /// Hazard memo
        /// [Memo]
        /// </summary>
        public string AR_HAZARD { get; internal set; }
        /// <summary>
        /// Site reference
        /// [Alphanumeric (20)]
        /// </summary>
        public string AR_SITE_REFERENCE { get; internal set; }
        /// <summary>
        /// Extra details
        /// [Memo]
        /// </summary>
        public string AR_EXTRA_DETAILS { get; internal set; }
        /// <summary>
        /// Purchase Date
        /// </summary>
        public DateTime? AR_PURDATE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? AR_PURDATE_IMP { get; internal set; }
        /// <summary>
        /// Supplier
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AR_ORIG_SUPPLIER { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? AR_ORIG_COST { get; internal set; }
        /// <summary>
        /// Picture of asset
        /// </summary>
        public byte[] AR_ASSET_PIC { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string FDT_COMMENT { get; internal set; }
        /// <summary>
        /// Record has been flagged for process
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FDT_PROCESS_FLAG { get; internal set; }
        /// <summary>
        /// Date Record was exported from source on
        /// </summary>
        public DateTime? FDT_DATE_EXP { get; internal set; }
        /// <summary>
        /// Time Record was exported from source on
        /// </summary>
        public short? FDT_TIME_EXP { get; internal set; }
        /// <summary>
        /// Date Record was imported into actual table on
        /// </summary>
        public DateTime? FDT_DATE_IMP { get; internal set; }
        /// <summary>
        /// Time Record was imported into actual table on
        /// </summary>
        public short? FDT_TIME_IMP { get; internal set; }
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
        /// Navigation property for [SOURCE] => [SKGS].[SCHOOL]
        /// 
        /// </summary>
        public SKGS SOURCE_SKGS {
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
