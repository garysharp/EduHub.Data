using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes
    /// </summary>
    public class TRPMODE_Entity : EntityBase
    {
        /// <summary>
        /// Transport Modes [Integer (32bit signed): l]
        /// </summary>
        public int TRANSPORT_MODE_ID { get; internal set; }
        /// <summary>
        /// Transport Desc [Alphanumeric: a60]
        /// </summary>
        public string TRANSPORT_MODE_DESC { get; internal set; }
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
