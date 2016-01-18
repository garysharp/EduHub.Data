using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FTE Student Retentions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SRAG : EduHubEntity
    {

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
        /// </summary>
        public int SRAG_ID { get; internal set; }

        /// <summary>
        /// Benchmark recording year
        /// </summary>
        public short? BRY { get; internal set; }

        /// <summary>
        /// Retention period
        /// [Alphanumeric (20)]
        /// </summary>
        public string PERIOD { get; internal set; }

        /// <summary>
        /// number of full time equivalent students retained in the period
        /// </summary>
        public double? RETENTION { get; internal set; }

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
