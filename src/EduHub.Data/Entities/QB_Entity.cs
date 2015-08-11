using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Batch Headers
    /// </summary>
    public class QB_Entity : EntityBase
    {
        /// <summary>
        /// Batch number (Prime Key) [Integer (32bit signed): l]
        /// </summary>
        public int QBKEY { get; internal set; }
        /// <summary>
        /// Batch comment [Alphanumeric: a40]
        /// </summary>
        public string NARRATIVE { get; internal set; }
        /// <summary>
        /// Batch total [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOTAL { get; internal set; }
        /// <summary>
        /// Class [Uppercase Alphanumeric: u2]
        /// </summary>
        public string CLASS { get; internal set; }
        /// <summary>
        /// Number of transactions [Integer (32bit signed nullable): l]
        /// </summary>
        public int? QUANTITY { get; internal set; }
        /// <summary>
        /// Batch type [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BATCHTYPE { get; internal set; }
        /// <summary>
        /// Transaction type [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSTYPE { get; internal set; }
        /// <summary>
        /// Batch data [Batch Information (byte array): bb]
        /// </summary>
        public byte[] BATCHDATA { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BATCHPRINTED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BANKPRINTED { get; internal set; }
        /// <summary>
        /// Mandatory field [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BATCHTRACE { get; internal set; }
        /// <summary>
        /// 0 = normal, 1 = forward,2 = standing,3 = reversal [Integer (16bit signed nullable): i]
        /// </summary>
        public short? BATCHCLASS { get; internal set; }
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
        
        
    }
}
