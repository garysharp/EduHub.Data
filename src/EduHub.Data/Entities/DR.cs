using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Receivable
    /// </summary>
    public class DR : EntityBase
    {
#region Navigation Property Cache
        private SA _DRTABLEA_SA;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRKEY { get; internal set; }
        /// <summary>
        /// Debtor name
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Outstanding allocation amount
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }
        /// <summary>
        /// Charges to date
        /// </summary>
        public decimal? CHARGES { get; internal set; }
        /// <summary>
        /// Charges this year
        /// </summary>
        public decimal? CHARGES_YTD { get; internal set; }
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
        /// Opening balances
        /// </summary>
        public decimal? OPBAL { get; internal set; }
        /// <summary>
        /// Last receipt amount
        /// </summary>
        public decimal? LASTREC { get; internal set; }
        /// <summary>
        /// Last receipt date
        /// </summary>
        public DateTime? LASTRECDATE { get; internal set; }
        /// <summary>
        /// Open item (1) or...
        /// Brought forward (0)
        /// </summary>
        public short? ACCTYPE { get; internal set; }
        /// <summary>
        /// CONTACT NAME
        /// [Alphanumeric (30)]
        /// </summary>
        public string CONTACT { get; internal set; }
        /// <summary>
        /// T = Trade Debtor (not used)
        /// I = Internal Debtor
        /// 1 = AUS Debtor
        /// 2 = NSW Debtor
        /// 6 = WA  Debtor
        /// 9 = FRV Debtor
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DRTYPE { get; internal set; }
        /// <summary>
        /// Table
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRTABLEA { get; internal set; }
        /// <summary>
        /// Business name
        /// [Alphanumeric (30)]
        /// </summary>
        public string BUSNAME { get; internal set; }
        /// <summary>
        /// Business address of Debtor
        /// [Alphanumeric (30)]
        /// </summary>
        public string BUSADD01 { get; internal set; }
        /// <summary>
        /// Business address of Debtor
        /// [Alphanumeric (30)]
        /// </summary>
        public string BUSADD02 { get; internal set; }
        /// <summary>
        /// Business state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string BUSSTATE { get; internal set; }
        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Telephone number
        /// [Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile
        /// [Alphanumeric (15)]
        /// </summary>
        public string FAX { get; internal set; }
        /// <summary>
        /// Mobile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Email address for emailing financial statements direct to the Sundry Debtor
        /// 
        /// [Alphanumeric (60)]
        /// </summary>
        public string BILLING_EMAIL { get; internal set; }
        /// <summary>
        /// Mailing name
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILNAME { get; internal set; }
        /// <summary>
        /// Mailing address
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILADD01 { get; internal set; }
        /// <summary>
        /// Mailing address
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILADD02 { get; internal set; }
        /// <summary>
        /// Mailing state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string MAILSTATE { get; internal set; }
        /// <summary>
        /// Mailing postcode
        /// 
        /// [Alphanumeric (4)]
        /// </summary>
        public string MAILPOST { get; internal set; }
        /// <summary>
        /// Delivery name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELNAME { get; internal set; }
        /// <summary>
        /// Delivery address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Delivery address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Delivery postcode
        /// 
        /// [Alphanumeric (4)]
        /// </summary>
        public string DELIVPOST { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string REMARK { get; internal set; }
        /// <summary>
        /// Inventory price level
        /// 
        /// </summary>
        public short? PRICELEVEL { get; internal set; }
        /// <summary>
        /// Y/N flag for memos
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEMO_FLAG { get; internal set; }
        /// <summary>
        /// Notes about this client
        /// 
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRSHORT { get; internal set; }
        /// <summary>
        /// Staff customer support rep
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string CSR { get; internal set; }
        /// <summary>
        /// Debtor group
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRGROUP { get; internal set; }
        /// <summary>
        /// Date first commenced as client
        /// 
        /// </summary>
        public DateTime? COMMENCE { get; internal set; }
        /// <summary>
        /// Number of DRF transactions
        /// </summary>
        public double? DRFCOUNT { get; internal set; }
        /// <summary>
        /// Does debtor require tax invoices for GST
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TAX_INVOICE { get; internal set; }
        /// <summary>
        /// Seed number for BPAY reference
        /// </summary>
        public int? BPAY_SEQUENCE { get; internal set; }
        /// <summary>
        /// BPAY Reference number with check digit
        /// 
        /// [Alphanumeric (20)]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last user name
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [DRTABLEA] => [SA].[SAKEY]
        /// Table
        /// </summary>
        public SA DRTABLEA_SA {
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
