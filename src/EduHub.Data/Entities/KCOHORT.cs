using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cohorts for data aggregation
    /// </summary>
    public class KCOHORT : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Unique ID for this record
        /// [Alphanumeric (2)]
        /// </summary>
        public string COHORT { get; internal set; }
        /// <summary>
        /// Description of Cohort
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// used in VELS aggregates
        /// [Alphanumeric (1)]
        /// </summary>
        public string VELS { get; internal set; }
        /// <summary>
        /// used in absence benchmark
        /// [Alphanumeric (1)]
        /// </summary>
        public string BENCHMARK { get; internal set; }
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
