using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// EMA Receipt details
    /// </summary>
    public class KEMA : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Unique id number
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Family ID
        /// [Alphanumeric (10)]
        /// </summary>
        public string FAMILY_KEY { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (15)]
        /// </summary>
        public string STREGISTRATION { get; internal set; }
        /// <summary>
        /// To allow ST update
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_PERIOD { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? EMA_TRAMT { get; internal set; }
        /// <summary>
        /// Processed/flagged for deletion set
        /// to 'Y' else null
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }
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
#endregion
    }
}
