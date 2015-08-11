using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations
    /// </summary>
    public class SADAG_Entity : EntityBase
    {
        /// <summary>
        /// Unique ID for this record [Integer (32bit signed): l]
        /// </summary>
        public int SADAG_ID { get; internal set; }
        /// <summary>
        /// Benchmark recording year [Integer (16bit signed nullable): i]
        /// </summary>
        public short? BRY { get; internal set; }
        /// <summary>
        /// 00 to 12 or 15 = Ungraded [Alphanumeric: a2]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// number of full time equivalent students in the cohort [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? FTE { get; internal set; }
        /// <summary>
        /// the absence code being aggregated [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ABS_CODE { get; internal set; }
        /// <summary>
        /// the number of days lost by the year level for this code [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DAYS { get; internal set; }
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
