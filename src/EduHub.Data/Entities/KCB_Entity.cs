using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications
    /// </summary>
    public class KCB_Entity : EntityBase
    {
        /// <summary>
        /// Behaviour code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KCBKEY { get; internal set; }
        /// <summary>
        /// Behaviour description [Alphanumeric: a40]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Is this positive (P) or negative (N) behaviour? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string POS_NEG { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
