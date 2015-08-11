using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Special Group Meetings
    /// </summary>
    public class SGM_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of group holding this meeting [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGMKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SGMKEY] => [SG_Entity].[SGKEY]
        /// Code of group holding this meeting
        /// </summary>
        public SG_Entity SGMKEY_SG { get { return SGMKEY == null ? null : Context.SG.FindBySGKEY(SGMKEY); } }
        /// <summary>
        /// Date of meeting [Date Time: d]
        /// </summary>
        public DateTime MEETING_DATE { get; internal set; }
        /// <summary>
        /// Time of meeting [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MEETING_TIME { get; internal set; }
        /// <summary>
        /// Brief description of meeting purpose [Alphanumeric: a20]
        /// </summary>
        public string PURPOSE_BRIEF { get; internal set; }
        /// <summary>
        /// Detailed description of meeting purpose [Memo: m]
        /// </summary>
        public string PURPOSE_DETAIL { get; internal set; }
        /// <summary>
        /// Room in which the meeting is held [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MEETING_ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [MEETING_ROOM] => [SM_Entity].[ROOM]
        /// Room in which the meeting is held
        /// </summary>
        public SM_Entity MEETING_ROOM_SM { get { return MEETING_ROOM == null ? null : Context.SM.FindByROOM(MEETING_ROOM); } }
        /// <summary>
        /// Minutes of the meeting [Memo: m]
        /// </summary>
        public string MINUTES_MEMO { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
