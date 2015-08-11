using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group
    /// </summary>
    public class PLG_Entity : EntityBase
    {
        /// <summary>
        /// Leave Group Identifier [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Leave Group Description [Alphanumeric: a30]
        /// </summary>
        public string LEAVE_GROUP_DESC { get; internal set; }
        /// <summary>
        /// Normal weekly hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? WEEKLY_HOURS { get; internal set; }
        /// <summary>
        /// Normal hours per day [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DAILY_HOURS { get; internal set; }
        /// <summary>
        /// Active Y/N? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
        
        
    }
}
