using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description
    /// </summary>
    public class PLC : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Leave Group Identifier
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string PLCKEY { get; internal set; }
        /// <summary>
        /// Leave Type Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string LEAVE_DESC { get; internal set; }
        /// <summary>
        /// Leave Category (Annual, Sick...)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Active Y/N?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
