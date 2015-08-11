using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description
    /// </summary>
    public class PLC_Entity : EntityBase
    {
        /// <summary>
        /// Leave Group Identifier [Uppercase Alphanumeric: u8]
        /// </summary>
        public string PLCKEY { get; internal set; }
        /// <summary>
        /// Leave Type Description [Alphanumeric: a30]
        /// </summary>
        public string LEAVE_DESC { get; internal set; }
        /// <summary>
        /// Leave Category (Annual, Sick...) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string CATEGORY { get; internal set; }
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
