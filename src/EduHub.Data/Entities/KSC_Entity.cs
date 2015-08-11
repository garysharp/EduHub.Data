using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions
    /// </summary>
    public class KSC_Entity : EntityBase
    {
        /// <summary>
        /// Position code [Uppercase Alphanumeric: u6]
        /// </summary>
        public string KSCKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string SF_POSITION { get; internal set; }
        /// <summary>
        /// Period allowance for this position [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ALLOTMENT { get; internal set; }
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
