using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Meetings
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCAM : EduHubEntity
    {

        #region Navigation Property Cache

        private SCA Cache_SCAMKEY_SCA;
        private SCI Cache_MEETING_LOCATION_SCI;
        private SM Cache_MEETING_ROOM_SM;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

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
        /// SCA (School Associations) related entity by [SCAM.SCAMKEY]-&gt;[SCA.SCAKEY]
        /// Short name of association
        /// </summary>
        public SCA SCAMKEY_SCA
        {
            get
            {
                if (Cache_SCAMKEY_SCA == null)
                {
                    Cache_SCAMKEY_SCA = Context.SCA.FindBySCAKEY(SCAMKEY);
                }

                return Cache_SCAMKEY_SCA;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SCAM.MEETING_LOCATION]-&gt;[SCI.SCIKEY]
        /// (Was MEET_LOCATION) Campus where meeting is held
        /// </summary>
        public SCI MEETING_LOCATION_SCI
        {
            get
            {
                if (MEETING_LOCATION == null)
                {
                    return null;
                }
                if (Cache_MEETING_LOCATION_SCI == null)
                {
                    Cache_MEETING_LOCATION_SCI = Context.SCI.FindBySCIKEY(MEETING_LOCATION.Value);
                }

                return Cache_MEETING_LOCATION_SCI;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [SCAM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// (Was MEET_ROOM) Room where meeting is held
        /// </summary>
        public SM MEETING_ROOM_SM
        {
            get
            {
                if (MEETING_ROOM == null)
                {
                    return null;
                }
                if (Cache_MEETING_ROOM_SM == null)
                {
                    Cache_MEETING_ROOM_SM = Context.SM.FindByROOM(MEETING_ROOM);
                }

                return Cache_MEETING_ROOM_SM;
            }
        }

        #endregion

    }
}
