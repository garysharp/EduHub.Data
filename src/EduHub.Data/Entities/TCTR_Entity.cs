using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Replacements
    /// </summary>
    public class TCTR_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Replacement date [Date Time nullable: d]
        /// </summary>
        public DateTime? TCTRKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TCTRKEY] => [TC_Entity].[TCKEY]
        /// Replacement date
        /// </summary>
        public TC_Entity TCTRKEY_TC { get { return TCTRKEY.HasValue ? Context.TC.FindByTCKEY(TCTRKEY.Value) : null; } }
        /// <summary>
        /// TCTQ record that the replacement is for [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TCTQ_TID { get; internal set; }
        /// <summary>
        /// Replacement teacher [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACH] => [SF_Entity].[SFKEY]
        /// Replacement teacher
        /// </summary>
        public SF_Entity TEACH_SF { get { return TEACH == null ? null : Context.SF.FindBySFKEY(TEACH); } }
        /// <summary>
        /// Replacement room [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Replacement room
        /// </summary>
        public SM_Entity ROOM_SM { get { return ROOM == null ? null : Context.SM.FindByROOM(ROOM); } }
        /// <summary>
        /// Comments [Memo: m]
        /// </summary>
        public string COMMENT_R { get; internal set; }
        /// <summary>
        /// Is replacement to be counted as an extra [Uppercase Alphanumeric: u1]
        /// </summary>
        public string COUNT_EXTRAS { get; internal set; }
        /// <summary>
        /// % count 0 - 100 of a full extra [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? EXTRAS_VALUE { get; internal set; }
        /// <summary>
        /// The absentee record that this belongs to [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ABSENTEE_TID { get; internal set; }
        /// <summary>
        /// Flag if replacement teacher is a clash [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TEACHER_CLASH { get; internal set; }
        /// <summary>
        /// Flag if replacement room is a clash [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ROOM_CLASH { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
