using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Delivery Addresses
    /// </summary>
    public class KAD_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KADKEY { get; internal set; }
        /// <summary>
        /// Delivery address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Delivery address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Delivery address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
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
