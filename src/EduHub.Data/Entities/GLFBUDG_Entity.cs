using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SP2 dummy table
    /// </summary>
    public class GLFBUDG_Entity : EntityBase
    {
#region Navigation Property Cache
        private GLBUDG_Entity _BKEY_GLBUDG;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// GLBUDG link [Uppercase Alphanumeric: u15]
        /// </summary>
        public string BKEY { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Transaction amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
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
        /// Navigation property for [BKEY] => [GLBUDG_Entity].[BUDGETKEY]
        /// GLBUDG link
        /// </summary>
        public GLBUDG_Entity BKEY_GLBUDG {
            get
            {
                if (BKEY != null)
                {
                    if (_BKEY_GLBUDG == null)
                    {
                        _BKEY_GLBUDG = Context.GLBUDG.FindByBUDGETKEY(BKEY);
                    }
                    return _BKEY_GLBUDG;
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
