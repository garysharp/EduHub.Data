using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medicare Levy Parameters
    /// </summary>
    public partial class PML : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Tax scale
        /// </summary>
        public short SCALE { get; internal set; }
        /// <summary>
        /// Weekly earning threshold
        /// </summary>
        public decimal? WEEKLY_EARNING_THRESHOLD { get; internal set; }
        /// <summary>
        /// Weekly earning shade in threshold
        /// </summary>
        public decimal? WEEKLY_SHADEIN_THRESHOLD { get; internal set; }
        /// <summary>
        /// Medicare levy family threshold
        /// </summary>
        public decimal? MEDLEVY_FAMILY_THRESHOLD { get; internal set; }
        /// <summary>
        /// Weekly family threshold divisor
        /// </summary>
        public double? WFT_DIVISOR { get; internal set; }
        /// <summary>
        /// Amount per child
        /// </summary>
        public decimal? ADDITIONAL_CHILD { get; internal set; }
        /// <summary>
        /// Shade out point multiplier
        /// </summary>
        public double? SOP_MULTIPLIER { get; internal set; }
        /// <summary>
        /// Shade out point divisor
        /// </summary>
        public double? SOP_DIVISOR { get; internal set; }
        /// <summary>
        /// Weekly Levy Adjustment factor
        /// </summary>
        public double? WLA_FALCTOR { get; internal set; }
        /// <summary>
        /// Medicare Levy
        /// </summary>
        public double? MEDICARE_LEVY { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion
    }
}
