using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Meetings
    /// </summary>
    public class SCAM : EntityBase
    {
#region Navigation Property Cache
        private SCA _SCAMKEY_SCA;
        private SCI _MEETING_LOCATION_SCI;
        private SM _MEETING_ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Short name of association
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SCAMKEY { get; internal set; }
        /// <summary>
        /// (Was MEET_DATE) Date of meeting
        /// </summary>
        public DateTime? MEETING_DATE { get; internal set; }
        /// <summary>
        /// (Was MEET_TIME) Time of meeting
        /// </summary>
        public short? MEETING_TIME { get; internal set; }
        /// <summary>
        /// (Was MEET_PURPOSE) Purpose of the meeting
        /// [Memo]
        /// </summary>
        public string MEETING_PURPOSE { get; internal set; }
        /// <summary>
        /// (Was MEET_LOCATION) Campus where meeting is held
        /// </summary>
        public int? MEETING_LOCATION { get; internal set; }
        /// <summary>
        /// (Was MEET_ROOM) Room where meeting is held
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MEETING_ROOM { get; internal set; }
        /// <summary>
        /// Minutes of the meeting
        /// [Memo]
        /// </summary>
        public string MINUTES_MEMO { get; internal set; }
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
        /// Navigation property for [SCAMKEY] => [SCA].[SCAKEY]
        /// Short name of association
        /// </summary>
        public SCA SCAMKEY_SCA {
            get
            {
                if (SCAMKEY != null)
                {
                    if (_SCAMKEY_SCA == null)
                    {
                        _SCAMKEY_SCA = Context.SCA.FindBySCAKEY(SCAMKEY);
                    }
                    return _SCAMKEY_SCA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MEETING_LOCATION] => [SCI].[SCIKEY]
        /// (Was MEET_LOCATION) Campus where meeting is held
        /// </summary>
        public SCI MEETING_LOCATION_SCI {
            get
            {
                if (MEETING_LOCATION.HasValue)
                {
                    if (_MEETING_LOCATION_SCI == null)
                    {
                        _MEETING_LOCATION_SCI = Context.SCI.FindBySCIKEY(MEETING_LOCATION.Value);
                    }
                    return _MEETING_LOCATION_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MEETING_ROOM] => [SM].[ROOM]
        /// (Was MEET_ROOM) Room where meeting is held
        /// </summary>
        public SM MEETING_ROOM_SM {
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
