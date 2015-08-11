using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Dates for Absences
    /// </summary>
    public class KCC_Entity : EntityBase
    {
        /// <summary>
        /// Date [Date Time: d]
        /// </summary>
        public DateTime KCCKEY { get; internal set; }
        /// <summary>
        /// Monday, Tuesday, etc [Titlecase: t10]
        /// </summary>
        public string DAYTODAY { get; internal set; }
        /// <summary>
        /// School, Holiday, Weekend [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAY_TYPE { get; internal set; }
        /// <summary>
        /// Day of the year [Integer (16bit signed nullable): i]
        /// </summary>
        public short? JULIAN { get; internal set; }
        /// <summary>
        /// Semester (1-2) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// Year of the calendar date [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DAY_YEAR { get; internal set; }
        /// <summary>
        /// Month of the calendar date [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DAY_MONTH { get; internal set; }
        /// <summary>
        /// Term (1-4) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TERM { get; internal set; }
        /// <summary>
        /// Week (1-15) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? WEEK { get; internal set; }
        /// <summary>
        /// Day no in the cycle (1-10) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DAY_CYCLE { get; internal set; }
        /// <summary>
        /// (Was QUILT) Code identifying current timetabling quilt [Uppercase Alphanumeric: u8]
        /// </summary>
        public string CURRENT_QUILT { get; internal set; }
        /// <summary>
        /// Navigation property for [CURRENT_QUILT] => [TH_Entity].[THKEY]
        /// (Was QUILT) Code identifying current timetabling quilt
        /// </summary>
        public TH_Entity CURRENT_QUILT_TH { get { return CURRENT_QUILT == null ? null : Context.TH.FindByTHKEY(CURRENT_QUILT); } }
        /// <summary>
        /// (Was ATT_LOADED) Generate half day attendances? (Y/N/U) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HALF_DAY_GENERATED { get; internal set; }
        /// <summary>
        /// Generate period attendances? (Y/N/U) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERIOD_GENERATED { get; internal set; }
        /// <summary>
        /// ERM = imported else Cases21 [Uppercase Alphanumeric: u3]
        /// </summary>
        public string PAR_SOURCE { get; internal set; }
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
