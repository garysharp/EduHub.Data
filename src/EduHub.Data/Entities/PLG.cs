using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group
    /// </summary>
    public class PLG : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Leave Group Identifier
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Leave Group Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string LEAVE_GROUP_DESC { get; internal set; }
        /// <summary>
        /// Normal weekly hours
        /// </summary>
        public double? WEEKLY_HOURS { get; internal set; }
        /// <summary>
        /// Normal hours per day
        /// </summary>
        public double? DAILY_HOURS { get; internal set; }
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
