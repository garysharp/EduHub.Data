using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPay Data
    /// </summary>
    public partial class BPAY_DAT : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// denote where Header (H), Footer (F) , Error (E)
        /// [Alphanumeric (1)]
        /// </summary>
        public string LINE_TYPE { get; internal set; }
        /// <summary>
        /// raw data after decrypted
        /// [Alphanumeric (255)]
        /// </summary>
        public string RECORD { get; internal set; }
        /// <summary>
        /// Payment Date
        /// [Alphanumeric (8)]
        /// </summary>
        public string PAYMENT_DATE { get; internal set; }
        /// <summary>
        /// Customer Reference
        /// [Alphanumeric (50)]
        /// </summary>
        public string CUST_REF { get; internal set; }
        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// Payment type (IB)
        /// [Alphanumeric (2)]
        /// </summary>
        public string PAYMENT_TYPE { get; internal set; }
        /// <summary>
        /// Biller code
        /// [Alphanumeric (5)]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// Support Reference
        /// [Alphanumeric (21)]
        /// </summary>
        public string SUPPORT_REF { get; internal set; }
        /// <summary>
        /// Default to N
        /// [Alphanumeric (1)]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }
        /// <summary>
        /// Default to BP
        /// [Alphanumeric (2)]
        /// </summary>
        public string RECORD_TYPE { get; internal set; }
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
    }
}
