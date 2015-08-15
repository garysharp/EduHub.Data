using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable
    /// </summary>
    public class CR_Entity : EntityBase
    {
#region Navigation Property Cache
        private KAB_Entity _BSB_KAB;
        private PPD_Entity _PPDKEY_PPD;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CRKEY { get; internal set; }
        /// <summary>
        /// Creditor title [Alphanumeric: a40]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Outstanding allocation amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }
        /// <summary>
        /// MTD purchases [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? MTDPURCH { get; internal set; }
        /// <summary>
        /// YTD purchases [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? YTDPURCH { get; internal set; }
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
        /// Opening balance [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OPBAL { get; internal set; }
        /// <summary>
        /// Credit limit [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CRLIMIT { get; internal set; }
        /// <summary>
        /// Last payment date [Date Time nullable: d]
        /// </summary>
        public DateTime? LASTPAYDATE { get; internal set; }
        /// <summary>
        /// Last payment amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTPAY { get; internal set; }
        /// <summary>
        /// Account type
        /// 0 - Balance forward
        /// 1 - Open item [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCTYPE { get; internal set; }
        /// <summary>
        /// Trading terms in days [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TERMS { get; internal set; }
        /// <summary>
        /// Discount percentage [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DISCOUNT { get; internal set; }
        /// <summary>
        /// Contact name [Alphanumeric: a30]
        /// </summary>
        public string CONTACT { get; internal set; }
        /// <summary>
        /// Three address lines [Alphanumeric: a40]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Three address lines [Alphanumeric: a40]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Three address lines [Alphanumeric: a40]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
        /// <summary>
        /// State [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Post code [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Phone number [Alphanumeric: a15]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile number [Alphanumeric: a15]
        /// </summary>
        public string FAX { get; internal set; }
        /// <summary>
        /// Email Address for orders [Alphanumeric: a60]
        /// </summary>
        public string CR_EMAIL { get; internal set; }
        /// <summary>
        /// Email address for payments [Alphanumeric: a60]
        /// </summary>
        public string EMAIL_FOR_PAYMENTS { get; internal set; }
        /// <summary>
        /// Mobile number [Alphanumeric: a15]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Committed future purchases [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? COMMITMENT { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STOP_FLAG { get; internal set; }
        /// <summary>
        /// Australian Business number [Uppercase Alphanumeric: u15]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Pay As You Go rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PAYG_RATE { get; internal set; }
        /// <summary>
        /// Bank/State/Branch number [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank Account Number [Alphanumeric: a15]
        /// </summary>
        public string ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Bank Account Name [Alphanumeric: a60]
        /// </summary>
        public string ACCOUNT_NAME { get; internal set; }
        /// <summary>
        /// Lodgement Reference [Alphanumeric: a18]
        /// </summary>
        public string LODGE_REF { get; internal set; }
        /// <summary>
        /// BPAY biller code [Alphanumeric: a10]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// BPAY reference [Alphanumeric: a20]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First name [Uppercase Alphanumeric: u15]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name [Uppercase Alphanumeric: u15]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Birthdate [Date Time nullable: d]
        /// </summary>
        public DateTime? PAYG_BIRTHDATE { get; internal set; }
        /// <summary>
        /// Startdate [Date Time nullable: d]
        /// </summary>
        public DateTime? PAYG_STARTDATE { get; internal set; }
        /// <summary>
        /// Contract enddate [Date Time nullable: d]
        /// </summary>
        public DateTime? PAYG_TERMDATE { get; internal set; }
        /// <summary>
        /// Two address lines [Uppercase Alphanumeric: u38]
        /// </summary>
        public string PAYG_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines [Uppercase Alphanumeric: u38]
        /// </summary>
        public string PAYG_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PAYG_SUBURB { get; internal set; }
        /// <summary>
        /// State [Uppercase Alphanumeric: u3]
        /// </summary>
        public string PAYG_STATE { get; internal set; }
        /// <summary>
        /// Postcode [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PAYG_POST { get; internal set; }
        /// <summary>
        /// Country [Uppercase Alphanumeric: u20]
        /// </summary>
        public string PAYG_COUNTRY { get; internal set; }
        /// <summary>
        /// Payer code in PPD [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PPDKEY { get; internal set; }
        /// <summary>
        /// Is this a PRMS creditor [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRMS_FLAG { get; internal set; }
        /// <summary>
        /// Last write date for PRMS fields [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_PRMSINFO_DATE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [BSB] => [KAB_Entity].[BSB]
        /// Bank/State/Branch number
        /// </summary>
        public KAB_Entity BSB_KAB {
            get
            {
                if (BSB != null)
                {
                    if (_BSB_KAB == null)
                    {
                        _BSB_KAB = Context.KAB.FindByBSB(BSB);
                    }
                    return _BSB_KAB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PPDKEY] => [PPD_Entity].[PPDKEY]
        /// Payer code in PPD
        /// </summary>
        public PPD_Entity PPDKEY_PPD {
            get
            {
                if (PPDKEY != null)
                {
                    if (_PPDKEY_PPD == null)
                    {
                        _PPDKEY_PPD = Context.PPD.FindByPPDKEY(PPDKEY);
                    }
                    return _PPDKEY_PPD;
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
