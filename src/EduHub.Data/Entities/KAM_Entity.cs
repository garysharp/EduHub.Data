using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions
    /// </summary>
    public class KAM_Entity : EntityBase
    {
        /// <summary>
        /// Code to identify standard disciplinary action [Uppercase Alphanumeric: u5]
        /// </summary>
        public string KAMKEY { get; internal set; }
        /// <summary>
        /// Brief description of disciplinary action [Alphanumeric: a40]
        /// </summary>
        public string BRIEF { get; internal set; }
        /// <summary>
        /// Full description of disciplinary action [Memo: m]
        /// </summary>
        public string DETAIL { get; internal set; }
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
