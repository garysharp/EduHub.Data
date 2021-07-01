using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cohorts for data aggregation
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCOHORT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SVAG> Cache_COHORT_SVAG_COHORT;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// SVAG (VELS Aggregated Dimensions) related entities by [KCOHORT.COHORT]-&gt;[SVAG.COHORT]
        /// Unique ID for this record
        /// </summary>
        public IReadOnlyList<SVAG> COHORT_SVAG_COHORT
        {
            get
            {
                if (Cache_COHORT_SVAG_COHORT == null &&
                    !Context.SVAG.TryFindByCOHORT(COHORT, out Cache_COHORT_SVAG_COHORT))
                {
                    Cache_COHORT_SVAG_COHORT = new List<SVAG>().AsReadOnly();
                }

                return Cache_COHORT_SVAG_COHORT;
            }
        }

        #endregion

    }
}
