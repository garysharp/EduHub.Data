using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Details
    /// </summary>
    public partial class TTEI : EntityBase
    {
#region Navigation Property Cache
        private TT _GKEY_TT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Grid involved in exam
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Exam start date
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Exam end date
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Maximum exam population
        /// </summary>
        public short? MAX_SIZE { get; internal set; }
        /// <summary>
        /// Maximum number of lines in exam grid
        /// </summary>
        public short? MAX_LINES { get; internal set; }
        /// <summary>
        /// Use fixed exam grid
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string USE_FIXED { get; internal set; }
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

#region Navigation Properties

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TTEI.GKEY]-&gt;[TT.TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT GKEY_TT
        {
            get
            {
                if (GKEY != null)
                {
                    if (_GKEY_TT == null)
                    {
                        _GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                    }
                    return _GKEY_TT;
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
