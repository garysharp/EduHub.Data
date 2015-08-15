using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts Import
    /// </summary>
    public class KBP_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Unique payment reference number [Alphanumeric: a21]
        /// </summary>
        public string REFERENCE_NO { get; internal set; }
        /// <summary>
        /// Family Bill Pay Reference number [Alphanumeric: a20]
        /// </summary>
        public string CUST_REFERENCE { get; internal set; }
        /// <summary>
        /// BPAY Import record type required for import [Alphanumeric: a2]
        /// </summary>
        public string RECORD_TYPE { get; internal set; }
        /// <summary>
        /// School biller code required for import [Alphanumeric: a10]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// Type of payment 05 = Payment 15 = Error Correction 25 = Reversal [Alphanumeric: a2]
        /// </summary>
        public string PAYMENT_TYPE { get; internal set; }
        /// <summary>
        /// Receipt value [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// Receipt date [Date Time nullable: d]
        /// </summary>
        public DateTime? PAYMENT_DATE { get; internal set; }
        /// <summary>
        /// Processed/flagged for deletion set to 'Y' else null [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }
        /// <summary>
        /// TID of invoice being paid for imported invoice payments [Integer (32bit signed nullable): l]
        /// </summary>
        public int? INVOICE_TID { get; internal set; }
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
#endregion
    }
}
