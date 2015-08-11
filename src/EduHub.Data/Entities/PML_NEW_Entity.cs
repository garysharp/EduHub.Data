using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Medicare Levy Parameters
    /// </summary>
    public class PML_NEW_Entity : EntityBase
    {
        /// <summary>
        /// Tax scale [Integer (16bit signed): i]
        /// </summary>
        public short SCALE { get; internal set; }
        /// <summary>
        /// Weekly earning threshold [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? WEEKLY_EARNING_THRESHOLD { get; internal set; }
        /// <summary>
        /// Weekly earning shade in threshold [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? WEEKLY_SHADEIN_THRESHOLD { get; internal set; }
        /// <summary>
        /// Medicare levy family threshold [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? MEDLEVY_FAMILY_THRESHOLD { get; internal set; }
        /// <summary>
        /// Weekly family threshold divisor [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? WFT_DIVISOR { get; internal set; }
        /// <summary>
        /// Amount per child [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ADDITIONAL_CHILD { get; internal set; }
        /// <summary>
        /// Shade out point multiplier [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SOP_MULTIPLIER { get; internal set; }
        /// <summary>
        /// Shade out point divisor [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SOP_DIVISOR { get; internal set; }
        /// <summary>
        /// Weekly Levy Adjustment factor [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? WLA_FALCTOR { get; internal set; }
        /// <summary>
        /// Medicare Levy [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? MEDICARE_LEVY { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
