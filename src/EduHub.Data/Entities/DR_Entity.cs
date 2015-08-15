using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Receivable
    /// </summary>
    public class DR_Entity : EntityBase
    {
#region Navigation Property Cache
        private SA_Entity _DRTABLEA_SA;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DRKEY { get; internal set; }
        /// <summary>
        /// Debtor name [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Outstanding allocation amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }
        /// <summary>
        /// Charges to date [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CHARGES { get; internal set; }
        /// <summary>
        /// Charges this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CHARGES_YTD { get; internal set; }
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
        /// Opening balances [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OPBAL { get; internal set; }
        /// <summary>
        /// Last receipt amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTREC { get; internal set; }
        /// <summary>
        /// Last receipt date [Date Time nullable: d]
        /// </summary>
        public DateTime? LASTRECDATE { get; internal set; }
        /// <summary>
        /// Open item (1) or...
        /// Brought forward (0) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCTYPE { get; internal set; }
        /// <summary>
        /// CONTACT NAME [Alphanumeric: a30]
        /// </summary>
        public string CONTACT { get; internal set; }
        /// <summary>
        /// T = Trade Debtor (not used)
        /// I = Internal Debtor
        /// 1 = AUS Debtor
        /// 2 = NSW Debtor
        /// 6 = WA  Debtor
        /// 9 = FRV Debtor
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DRTYPE { get; internal set; }
        /// <summary>
        /// Table [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DRTABLEA { get; internal set; }
        /// <summary>
        /// Business name [Alphanumeric: a30]
        /// </summary>
        public string BUSNAME { get; internal set; }
        /// <summary>
        /// Business address of Debtor [Alphanumeric: a30]
        /// </summary>
        public string BUSADD01 { get; internal set; }
        /// <summary>
        /// Business address of Debtor [Alphanumeric: a30]
        /// </summary>
        public string BUSADD02 { get; internal set; }
        /// <summary>
        /// Business state [Uppercase Alphanumeric: u3]
        /// </summary>
        public string BUSSTATE { get; internal set; }
        /// <summary>
        /// Postcode [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Telephone number [Alphanumeric: a20]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile [Alphanumeric: a15]
        /// </summary>
        public string FAX { get; internal set; }
        /// <summary>
        /// Mobile number [Alphanumeric: a15]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Email address for emailing financial statements direct to the Sundry Debtor
        ///  [Alphanumeric: a60]
        /// </summary>
        public string BILLING_EMAIL { get; internal set; }
        /// <summary>
        /// Mailing name [Alphanumeric: a30]
        /// </summary>
        public string MAILNAME { get; internal set; }
        /// <summary>
        /// Mailing address [Alphanumeric: a30]
        /// </summary>
        public string MAILADD01 { get; internal set; }
        /// <summary>
        /// Mailing address [Alphanumeric: a30]
        /// </summary>
        public string MAILADD02 { get; internal set; }
        /// <summary>
        /// Mailing state [Uppercase Alphanumeric: u3]
        /// </summary>
        public string MAILSTATE { get; internal set; }
        /// <summary>
        /// Mailing postcode
        ///  [Alphanumeric: a4]
        /// </summary>
        public string MAILPOST { get; internal set; }
        /// <summary>
        /// Delivery name [Alphanumeric: a30]
        /// </summary>
        public string DELNAME { get; internal set; }
        /// <summary>
        /// Delivery address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Delivery address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Delivery postcode
        ///  [Alphanumeric: a4]
        /// </summary>
        public string DELIVPOST { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string REMARK { get; internal set; }
        /// <summary>
        /// Inventory price level
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PRICELEVEL { get; internal set; }
        /// <summary>
        /// Y/N flag for memos [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MEMO_FLAG { get; internal set; }
        /// <summary>
        /// Notes about this client
        ///  [Memo: m]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DRSHORT { get; internal set; }
        /// <summary>
        /// Staff customer support rep [Uppercase Alphanumeric: u4]
        /// </summary>
        public string CSR { get; internal set; }
        /// <summary>
        /// Debtor group [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DRGROUP { get; internal set; }
        /// <summary>
        /// Date first commenced as client
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? COMMENCE { get; internal set; }
        /// <summary>
        /// Number of DRF transactions [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DRFCOUNT { get; internal set; }
        /// <summary>
        /// Does debtor require tax invoices for GST
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TAX_INVOICE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last user name [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [DRTABLEA] => [SA_Entity].[SAKEY]
        /// Table
        /// </summary>
        public SA_Entity DRTABLEA_SA {
            get
            {
                if (DRTABLEA != null)
                {
                    if (_DRTABLEA_SA == null)
                    {
                        _DRTABLEA_SA = Context.SA.FindBySAKEY(DRTABLEA);
                    }
                    return _DRTABLEA_SA;
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
