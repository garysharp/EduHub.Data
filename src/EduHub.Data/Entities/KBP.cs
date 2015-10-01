using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts Import
    /// </summary>
    public class KBP : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Unique payment reference number
        /// [Alphanumeric (21)]
        /// </summary>
        public string REFERENCE_NO { get; internal set; }
        /// <summary>
        /// Family Bill Pay Reference number
        /// [Alphanumeric (20)]
        /// </summary>
        public string CUST_REFERENCE { get; internal set; }
        /// <summary>
        /// BPAY Import record type required for import
        /// [Alphanumeric (2)]
        /// </summary>
        public string RECORD_TYPE { get; internal set; }
        /// <summary>
        /// School biller code required for import
        /// [Alphanumeric (10)]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// Type of payment 05 = Payment 15 = Error Correction 25 = Reversal
        /// [Alphanumeric (2)]
        /// </summary>
        public string PAYMENT_TYPE { get; internal set; }
        /// <summary>
        /// Receipt value
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// Receipt date
        /// </summary>
        public DateTime? PAYMENT_DATE { get; internal set; }
        /// <summary>
        /// Processed/flagged for deletion set to 'Y' else null
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }
        /// <summary>
        /// TID of invoice being paid for imported invoice payments
        /// </summary>
        public int? INVOICE_TID { get; internal set; }
        /// <summary>
        /// Source Ledger type
        /// eg. DF, DR
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
