using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Grid
    /// </summary>
    public class TTEX_Entity : EntityBase
    {
#region Navigation Property Cache
        private TT_Entity _GKEY_TT;
        private SM_Entity _EXAM_ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Grid involved in exam [Uppercase Alphanumeric: u8]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Subject record [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TTES_TID { get; internal set; }
        /// <summary>
        /// Exam grid row [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXAM_ROW { get; internal set; }
        /// <summary>
        /// Exam grid column [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXAM_COL { get; internal set; }
        /// <summary>
        /// Exam grid fixed row [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXAM_FIX_ROW { get; internal set; }
        /// <summary>
        /// Exam grid fixed column [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXAM_FIX_COL { get; internal set; }
        /// <summary>
        /// Room for subject under TTES [Uppercase Alphanumeric: u4]
        /// </summary>
        public string EXAM_ROOM { get; internal set; }
        /// <summary>
        /// Description of Exam [Alphanumeric: a15]
        /// </summary>
        public string EXAM_DESCRIPTION { get; internal set; }
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
        /// Navigation property for [GKEY] => [TT_Entity].[TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT_Entity GKEY_TT {
            get
            {
                if (GKEY != null)
                {
                    if (_GKEY_TT == null)
                    {
                        _GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                    }
                    return _GKEY_TT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXAM_ROOM] => [SM_Entity].[ROOM]
        /// Room for subject under TTES
        /// </summary>
        public SM_Entity EXAM_ROOM_SM {
            get
            {
                if (EXAM_ROOM != null)
                {
                    if (_EXAM_ROOM_SM == null)
                    {
                        _EXAM_ROOM_SM = Context.SM.FindByROOM(EXAM_ROOM);
                    }
                    return _EXAM_ROOM_SM;
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
