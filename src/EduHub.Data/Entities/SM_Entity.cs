using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms
    /// </summary>
    public class SM_Entity : EntityBase
    {
        /// <summary>
        /// Room code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Room name [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Maximum capacity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEATING { get; internal set; }
        /// <summary>
        /// Description of room [Alphanumeric: a40]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Is this room available for timetabled activities? R=available, otherwise not [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ROOM_TYPE { get; internal set; }
        /// <summary>
        /// Code of the faculty responsible for this room [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY { get; internal set; }
        /// <summary>
        /// Navigation property for [FACULTY] => [KSF_Entity].[KSFKEY]
        /// Code of the faculty responsible for this room
        /// </summary>
        public KSF_Entity FACULTY_KSF { get { return FACULTY == null ? null : Context.KSF.FindByKSFKEY(FACULTY); } }
        /// <summary>
        /// (V) (NRM) << What exactly is this field for? [Uppercase Alphanumeric: u4]
        /// </summary>
        public string AREA_CODE { get; internal set; }
        /// <summary>
        /// ID of the campus on which this room is located [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// ID of the campus on which this room is located
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        /// Code of the staff member responsible for this room (V) (NRM) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [STAFF_CODE] => [SF_Entity].[SFKEY]
        /// Code of the staff member responsible for this room (V) (NRM)
        /// </summary>
        public SF_Entity STAFF_CODE_SF { get { return STAFF_CODE == null ? null : Context.SF.FindBySFKEY(STAFF_CODE); } }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string COMMENTA { get; internal set; }
        /// <summary>
        /// Type of board provided (blackboard, whiteboard, etc.) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string BOARD { get; internal set; }
        /// <summary>
        /// Does this room have blackout provision? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BLACKOUT { get; internal set; }
        /// <summary>
        /// Normal load for this room [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }
        /// <summary>
        /// Flag indicating if this is a single room or a group of rooms [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GROUP_INDICATOR { get; internal set; }
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
