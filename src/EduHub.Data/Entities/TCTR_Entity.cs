using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Replacements
    /// </summary>
    public class TCTR_Entity : EntityBase
    {
#region Navigation Property Cache
        private TC_Entity _TCTRKEY_TC;
        private SF_Entity _TEACH_SF;
        private SM_Entity _ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Replacement date [Date Time nullable: d]
        /// </summary>
        public DateTime? TCTRKEY { get; internal set; }
        /// <summary>
        /// TCTQ record that the replacement is for [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TCTQ_TID { get; internal set; }
        /// <summary>
        /// Replacement teacher [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACH { get; internal set; }
        /// <summary>
        /// Replacement room [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [TCTRKEY] => [TC_Entity].[TCKEY]
        /// Replacement date
        /// </summary>
        public TC_Entity TCTRKEY_TC {
            get
            {
                if (TCTRKEY.HasValue)
                {
                    if (_TCTRKEY_TC == null)
                    {
                        _TCTRKEY_TC = Context.TC.FindByTCKEY(TCTRKEY.Value);
                    }
                    return _TCTRKEY_TC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACH] => [SF_Entity].[SFKEY]
        /// Replacement teacher
        /// </summary>
        public SF_Entity TEACH_SF {
            get
            {
                if (TEACH != null)
                {
                    if (_TEACH_SF == null)
                    {
                        _TEACH_SF = Context.SF.FindBySFKEY(TEACH);
                    }
                    return _TEACH_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Replacement room
        /// </summary>
        public SM_Entity ROOM_SM {
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
