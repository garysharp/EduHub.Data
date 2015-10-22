using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Special Group Meetings
    /// </summary>
    public partial class SGM : EntityBase
    {
#region Navigation Property Cache
        private SG _SGMKEY_SG;
        private SM _MEETING_ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of group holding this meeting
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGMKEY { get; internal set; }
        /// <summary>
        /// Date of meeting
        /// </summary>
        public DateTime MEETING_DATE { get; internal set; }
        /// <summary>
        /// Time of meeting
        /// </summary>
        public short? MEETING_TIME { get; internal set; }
        /// <summary>
        /// Brief description of meeting purpose
        /// [Alphanumeric (20)]
        /// </summary>
        public string PURPOSE_BRIEF { get; internal set; }
        /// <summary>
        /// Detailed description of meeting purpose
        /// [Memo]
        /// </summary>
        public string PURPOSE_DETAIL { get; internal set; }
        /// <summary>
        /// Room in which the meeting is held
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MEETING_ROOM { get; internal set; }
        /// <summary>
        /// Minutes of the meeting
        /// [Memo]
        /// </summary>
        public string MINUTES_MEMO { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// SG (Student Groupings) related entity by [SGM.SGMKEY]-&gt;[SG.SGKEY]
        /// Code of group holding this meeting
        /// </summary>
        public SG SGMKEY_SG
        {
            get
            {
                if (SGMKEY != null)
                {
                    if (_SGMKEY_SG == null)
                    {
                        _SGMKEY_SG = Context.SG.FindBySGKEY(SGMKEY);
                    }
                    return _SGMKEY_SG;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [SGM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// Room in which the meeting is held
        /// </summary>
        public SM MEETING_ROOM_SM
        {
            get
            {
                if (MEETING_ROOM != null)
                {
                    if (_MEETING_ROOM_SM == null)
                    {
                        _MEETING_ROOM_SM = Context.SM.FindByROOM(MEETING_ROOM);
                    }
                    return _MEETING_ROOM_SM;
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
