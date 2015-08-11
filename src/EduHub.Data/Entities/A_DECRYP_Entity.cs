using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Decrypted data IMPORT
    /// </summary>
    public class A_DECRYP_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// enote LINE_TYPE of decrypted data, eg. BPAY [Alphanumeric: a10]
        /// </summary>
        public string LINE_TYPE { get; internal set; }
        /// <summary>
        /// raw data after decrypted [Alphanumeric: a200]
        /// </summary>
        public string RECORD { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        
        
    }
}
