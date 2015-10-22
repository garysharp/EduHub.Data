using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Staff
    /// </summary>
    public partial class TTEF : EntityBase
    {
#region Navigation Property Cache
        private TT _GKEY_TT;
        private SF _STAFF_SF;
        private SM _ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Grid involved in exam
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Exam period to which this staff belongs
        /// </summary>
        public int? TTEP_TID { get; internal set; }
        /// <summary>
        /// Staff start time
        /// </summary>
        public DateTime? TIME_START { get; internal set; }
        /// <summary>
        /// Staff end time
        /// </summary>
        public DateTime? TIME_END { get; internal set; }
        /// <summary>
        /// Staff member
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Room where Exam is to be held
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
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
        /// TT (Timetable Grid Templates) related entity by [TTEF.GKEY]-&gt;[TT.TTKEY]
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

        /// <summary>
        /// SF (Staff) related entity by [TTEF.STAFF]-&gt;[SF.SFKEY]
        /// Staff member
        /// </summary>
        public SF STAFF_SF
        {
            get
            {
                if (STAFF != null)
                {
                    if (_STAFF_SF == null)
                    {
                        _STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                    }
                    return _STAFF_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [TTEF.ROOM]-&gt;[SM.ROOM]
        /// Room where Exam is to be held
        /// </summary>
        public SM ROOM_SM
        {
            get
            {
                if (ROOM != null)
                {
                    if (_ROOM_SM == null)
                    {
                        _ROOM_SM = Context.SM.FindByROOM(ROOM);
                    }
                    return _ROOM_SM;
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
