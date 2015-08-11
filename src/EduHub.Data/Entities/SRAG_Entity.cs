using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FTE Student Retentions
    /// </summary>
    public class SRAG_Entity : EntityBase
    {
        /// <summary>
        /// Unique ID for this record [Integer (32bit signed): l]
        /// </summary>
        public int SRAG_ID { get; internal set; }
        /// <summary>
        /// Benchmark recording year [Integer (16bit signed nullable): i]
        /// </summary>
        public short? BRY { get; internal set; }
        /// <summary>
        /// Retention period [Alphanumeric: a20]
        /// </summary>
        public string PERIOD { get; internal set; }
        /// <summary>
        /// number of full time equivalent students retained in the period [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? RETENTION { get; internal set; }
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
