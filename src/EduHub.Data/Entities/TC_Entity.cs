using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar
    /// </summary>
    public class TC_Entity : EntityBase
    {
        /// <summary>
        /// Calendar entry code [Date Time: d]
        /// </summary>
        public DateTime TCKEY { get; internal set; }
        /// <summary>
        /// Title [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// memo comment [Memo: m]
        /// </summary>
        public string DAY_COMMENT { get; internal set; }
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
