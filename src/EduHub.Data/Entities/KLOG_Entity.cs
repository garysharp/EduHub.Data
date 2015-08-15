using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Trace log for finance import and export
    /// </summary>
    public class KLOG_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// message severity [Integer (32bit signed nullable): l]
        /// </summary>
        public int? SEVERITY { get; internal set; }
        /// <summary>
        /// Message text [Memo: m]
        /// </summary>
        public string MESSAGE { get; internal set; }
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
#endregion
    }
}
