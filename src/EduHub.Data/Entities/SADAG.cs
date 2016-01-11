using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADAG : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Unique ID for this record
        /// </summary>
        public int SADAG_ID { get; internal set; }

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
        /// number of full time equivalent students in the cohort
        /// </summary>
        public double? FTE { get; internal set; }

        /// <summary>
        /// the absence code being aggregated
        /// </summary>
        public short? ABS_CODE { get; internal set; }

        /// <summary>
        /// the number of days lost by the year level for this code
        /// </summary>
        public double? DAYS { get; internal set; }

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

    }
}
