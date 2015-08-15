using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// EMA Receipt details
    /// </summary>
    public class KEMA_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Unique id number [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Family ID [Alphanumeric: a10]
        /// </summary>
        public string FAMILY_KEY { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a15]
        /// </summary>
        public string STREGISTRATION { get; internal set; }
        /// <summary>
        /// To allow ST update [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EMA_PERIOD { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? EMA_TRAMT { get; internal set; }
        /// <summary>
        /// Processed/flagged for deletion set
        /// to 'Y' else null
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }
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
