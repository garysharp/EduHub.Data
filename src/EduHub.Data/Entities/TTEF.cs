using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Staff
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEF : EntityBase
    {

        #region Navigation Property Cache

        private TT Cache_GKEY_TT;
        private SF Cache_STAFF_SF;
        private SM Cache_ROOM_SM;

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
                if (Cache_GKEY_TT == null)
                {
                    Cache_GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                }

                return Cache_GKEY_TT;
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
                if (STAFF == null)
                {
                    return null;
                }
                if (Cache_STAFF_SF == null)
                {
                    Cache_STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                }

                return Cache_STAFF_SF;
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
                if (ROOM == null)
                {
                    return null;
                }
                if (Cache_ROOM_SM == null)
                {
                    Cache_ROOM_SM = Context.SM.FindByROOM(ROOM);
                }

                return Cache_ROOM_SM;
            }
        }

        #endregion

    }
}
