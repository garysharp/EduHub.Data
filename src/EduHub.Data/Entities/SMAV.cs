using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availablity Extras
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMAV : EduHubEntity
    {

        #region Navigation Property Cache

        private SM Cache_ROOM_SM;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Room key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }

        /// <summary>
        /// Day of timetable cycle
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
        /// SM (Rooms) related entity by [SMAV.ROOM]-&gt;[SM.ROOM]
        /// Room key
        /// </summary>
        public SM ROOM_SM
        {
            get
            {
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
