using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability for Calendar Extras
    /// </summary>
    public partial class SFAV : EntityBase
    {
#region Navigation Property Cache
        private SF _TEACH_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Staff key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACH { get; internal set; }
        /// <summary>
        /// Day of the timetable cycle
        /// </summary>
        public short? DAY_NUMBER { get; internal set; }
        /// <summary>
        /// Start time of availability
        /// </summary>
        public DateTime? START_TIME { get; internal set; }
        /// <summary>
        /// Finish time of availability
        /// </summary>
        public DateTime? END_TIME { get; internal set; }
        /// <summary>
        /// Exception date for emergency teachers
        /// </summary>
        public DateTime? AVAILABLE_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// SF (Staff) related entity by [SFAV.TEACH]-&gt;[SF.SFKEY]
        /// Staff key
        /// </summary>
        public SF TEACH_SF
        {
            get
            {
                if (TEACH != null)
                {
                    if (_TEACH_SF == null)
                    {
                        _TEACH_SF = Context.SF.FindBySFKEY(TEACH);
                    }
                    return _TEACH_SF;
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
