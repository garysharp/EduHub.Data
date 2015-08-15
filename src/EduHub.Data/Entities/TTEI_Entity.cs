using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Details
    /// </summary>
    public class TTEI_Entity : EntityBase
    {
#region Navigation Property Cache
        private TT_Entity _GKEY_TT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Grid involved in exam [Uppercase Alphanumeric: u8]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Exam start date [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Exam end date [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Maximum exam population [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAX_SIZE { get; internal set; }
        /// <summary>
        /// Maximum number of lines in exam grid [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAX_LINES { get; internal set; }
        /// <summary>
        /// Use fixed exam grid [Uppercase Alphanumeric: u1]
        /// </summary>
        public string USE_FIXED { get; internal set; }
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
#endregion
    }
}
