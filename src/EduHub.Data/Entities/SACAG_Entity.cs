using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations
    /// </summary>
    public class SACAG_Entity : EntityBase
    {
        /// <summary>
        /// Unique ID for this record [Integer (32bit signed): l]
        /// </summary>
        public int SACAG_ID { get; internal set; }
        /// <summary>
        /// Benchmark recording year [Integer (16bit signed nullable): i]
        /// </summary>
        public short? BRY { get; internal set; }
        /// <summary>
        /// 00 to 12 or 15 = Ungraded [Alphanumeric: a2]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// 1, 2 or 3 = All year [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// FO, KT, LB, MB, MO, SA, YR OA, OB, OC, OD, ON [Alphanumeric: a2]
        /// </summary>
        public string COHORT { get; internal set; }
        /// <summary>
        /// number of full time equivalent students in the cohort [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? FTE { get; internal set; }
        /// <summary>
        /// total number of unapproved days absent for all students in cohort [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? UNAPPROVED { get; internal set; }
        /// <summary>
        /// total number of approved days absent for all students in cohort [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? APPROVED { get; internal set; }
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
