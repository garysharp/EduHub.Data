using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations
    /// </summary>
    public class SACAG : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Unique ID for this record
        /// </summary>
        public int SACAG_ID { get; internal set; }
        /// <summary>
        /// Benchmark recording year
        /// </summary>
        public short? BRY { get; internal set; }
        /// <summary>
        /// 00 to 12 or 15 = Ungraded
        /// [Alphanumeric (2)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// 1, 2 or 3 = All year
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// FO, KT, LB, MB, MO, SA, YR OA, OB, OC, OD, ON
        /// [Alphanumeric (2)]
        /// </summary>
        public string COHORT { get; internal set; }
        /// <summary>
        /// number of full time equivalent students in the cohort
        /// </summary>
        public double? FTE { get; internal set; }
        /// <summary>
        /// total number of unapproved days absent for all students in cohort
        /// </summary>
        public double? UNAPPROVED { get; internal set; }
        /// <summary>
        /// total number of approved days absent for all students in cohort
        /// </summary>
        public double? APPROVED { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
