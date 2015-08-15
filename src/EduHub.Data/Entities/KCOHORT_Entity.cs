using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cohorts for data aggregation
    /// </summary>
    public class KCOHORT_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Unique ID for this record [Alphanumeric: a2]
        /// </summary>
        public string COHORT { get; internal set; }
        /// <summary>
        /// Description of Cohort [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// used in VELS aggregates [Alphanumeric: a1]
        /// </summary>
        public string VELS { get; internal set; }
        /// <summary>
        /// used in absence benchmark [Alphanumeric: a1]
        /// </summary>
        public string BENCHMARK { get; internal set; }
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
#endregion

#region Navigation Properties
#endregion
    }
}
