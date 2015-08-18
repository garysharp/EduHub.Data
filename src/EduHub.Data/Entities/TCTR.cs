using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Replacements
    /// </summary>
    public class TCTR : EntityBase
    {
#region Navigation Property Cache
        private TC _TCTRKEY_TC;
        private SF _TEACH_SF;
        private SM _ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Replacement date
        /// </summary>
        public DateTime? TCTRKEY { get; internal set; }
        /// <summary>
        /// TCTQ record that the replacement is for
        /// </summary>
        public int? TCTQ_TID { get; internal set; }
        /// <summary>
        /// Replacement teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACH { get; internal set; }
        /// <summary>
        /// Replacement room
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Comments
        /// [Memo]
        /// </summary>
        public string COMMENT_R { get; internal set; }
        /// <summary>
        /// Is replacement to be counted as an extra
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string COUNT_EXTRAS { get; internal set; }
        /// <summary>
        /// % count 0 - 100 of a full extra
        /// </summary>
        public double? EXTRAS_VALUE { get; internal set; }
        /// <summary>
        /// The absentee record that this belongs to
        /// </summary>
        public int? ABSENTEE_TID { get; internal set; }
        /// <summary>
        /// Flag if replacement teacher is a clash
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TEACHER_CLASH { get; internal set; }
        /// <summary>
        /// Flag if replacement room is a clash
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROOM_CLASH { get; internal set; }
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
        /// Navigation property for [TCTRKEY] => [TC].[TCKEY]
        /// Replacement date
        /// </summary>
        public TC TCTRKEY_TC {
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
        /// Navigation property for [TEACH] => [SF].[SFKEY]
        /// Replacement teacher
        /// </summary>
        public SF TEACH_SF {
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
        /// Navigation property for [ROOM] => [SM].[ROOM]
        /// Replacement room
        /// </summary>
        public SM ROOM_SM {
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
