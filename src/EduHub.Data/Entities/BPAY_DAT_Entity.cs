using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPay Data
    /// </summary>
    public class BPAY_DAT_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// denote where Header (H), Footer (F) , Error (E) [Alphanumeric: a1]
        /// </summary>
        public string LINE_TYPE { get; internal set; }
        /// <summary>
        /// raw data after decrypted [Alphanumeric: a255]
        /// </summary>
        public string RECORD { get; internal set; }
        /// <summary>
        /// Payment Date [Alphanumeric: a8]
        /// </summary>
        public string PAYMENT_DATE { get; internal set; }
        /// <summary>
        /// Customer Reference [Alphanumeric: a50]
        /// </summary>
        public string CUST_REF { get; internal set; }
        /// <summary>
        /// Transaction amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// Payment type (IB) [Alphanumeric: a2]
        /// </summary>
        public string PAYMENT_TYPE { get; internal set; }
        /// <summary>
        /// Biller code [Alphanumeric: a5]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// Support Reference [Alphanumeric: a21]
        /// </summary>
        public string SUPPORT_REF { get; internal set; }
        /// <summary>
        /// Default to N [Alphanumeric: a1]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }
        /// <summary>
        /// Default to BP [Alphanumeric: a2]
        /// </summary>
        public string RECORD_TYPE { get; internal set; }
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
