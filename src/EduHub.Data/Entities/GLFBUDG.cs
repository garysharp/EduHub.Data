using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SP2 dummy table
    /// </summary>
    public class GLFBUDG : EntityBase
    {
#region Navigation Property Cache
        private GLBUDG _BKEY_GLBUDG;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// GLBUDG link
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string BKEY { get; internal set; }
        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal? TRAMT { get; internal set; }
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
        /// Navigation property for [BKEY] => [GLBUDG].[BUDGETKEY]
        /// GLBUDG link
        /// </summary>
        public GLBUDG BKEY_GLBUDG {
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
