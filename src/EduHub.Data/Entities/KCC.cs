using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Dates for Absences
    /// </summary>
    public partial class KCC : EntityBase
    {
#region Navigation Property Cache
        private TH _CURRENT_QUILT_TH;
#endregion

#region Field Properties
        /// <summary>
        /// Date
        /// </summary>
        public DateTime KCCKEY { get; internal set; }
        /// <summary>
        /// Monday, Tuesday, etc
        /// [Titlecase (10)]
        /// </summary>
        public string DAYTODAY { get; internal set; }
        /// <summary>
        /// School, Holiday, Weekend
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAY_TYPE { get; internal set; }
        /// <summary>
        /// Day of the year
        /// </summary>
        public short? JULIAN { get; internal set; }
        /// <summary>
        /// Semester (1-2)
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// Year of the calendar date
        /// </summary>
        public short? DAY_YEAR { get; internal set; }
        /// <summary>
        /// Month of the calendar date
        /// </summary>
        public short? DAY_MONTH { get; internal set; }
        /// <summary>
        /// Term (1-4)
        /// </summary>
        public short? TERM { get; internal set; }
        /// <summary>
        /// Week (1-15)
        /// </summary>
        public short? WEEK { get; internal set; }
        /// <summary>
        /// Day no in the cycle (1-10)
        /// </summary>
        public short? DAY_CYCLE { get; internal set; }
        /// <summary>
        /// (Was QUILT) Code identifying current timetabling quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CURRENT_QUILT { get; internal set; }
        /// <summary>
        /// (Was ATT_LOADED) Generate half day attendances? (Y/N/U)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HALF_DAY_GENERATED { get; internal set; }
        /// <summary>
        /// Generate period attendances? (Y/N/U)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERIOD_GENERATED { get; internal set; }
        /// <summary>
        /// ERM = imported else Cases21
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string PAR_SOURCE { get; internal set; }
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

        /// <summary>
        /// TH (Timetable Quilt Headers) related entity by [KCC.CURRENT_QUILT]-&gt;[TH.THKEY]
        /// (Was QUILT) Code identifying current timetabling quilt
        /// </summary>
        public TH CURRENT_QUILT_TH
        {
            get
            {
                if (CURRENT_QUILT != null)
                {
                    if (_CURRENT_QUILT_TH == null)
                    {
                        _CURRENT_QUILT_TH = Context.TH.FindByTHKEY(CURRENT_QUILT);
                    }
                    return _CURRENT_QUILT_TH;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
