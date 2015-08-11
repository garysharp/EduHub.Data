using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Meetings
    /// </summary>
    public class SCAM_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Short name of association [Uppercase Alphanumeric: u15]
        /// </summary>
        public string SCAMKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SCAMKEY] => [SCA_Entity].[SCAKEY]
        /// Short name of association
        /// </summary>
        public SCA_Entity SCAMKEY_SCA { get { return SCAMKEY == null ? null : Context.SCA.FindBySCAKEY(SCAMKEY); } }
        /// <summary>
        /// (Was MEET_DATE) Date of meeting [Date Time nullable: d]
        /// </summary>
        public DateTime? MEETING_DATE { get; internal set; }
        /// <summary>
        /// (Was MEET_TIME) Time of meeting [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MEETING_TIME { get; internal set; }
        /// <summary>
        /// (Was MEET_PURPOSE) Purpose of the meeting [Memo: m]
        /// </summary>
        public string MEETING_PURPOSE { get; internal set; }
        /// <summary>
        /// (Was MEET_LOCATION) Campus where meeting is held [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MEETING_LOCATION { get; internal set; }
        /// <summary>
        /// Navigation property for [MEETING_LOCATION] => [SCI_Entity].[SCIKEY]
        /// (Was MEET_LOCATION) Campus where meeting is held
        /// </summary>
        public SCI_Entity MEETING_LOCATION_SCI { get { return MEETING_LOCATION.HasValue ? Context.SCI.FindBySCIKEY(MEETING_LOCATION.Value) : null; } }
        /// <summary>
        /// (Was MEET_ROOM) Room where meeting is held [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MEETING_ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [MEETING_ROOM] => [SM_Entity].[ROOM]
        /// (Was MEET_ROOM) Room where meeting is held
        /// </summary>
        public SM_Entity MEETING_ROOM_SM { get { return MEETING_ROOM == null ? null : Context.SM.FindByROOM(MEETING_ROOM); } }
        /// <summary>
        /// Minutes of the meeting [Memo: m]
        /// </summary>
        public string MINUTES_MEMO { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
