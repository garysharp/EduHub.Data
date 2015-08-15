using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers
    /// </summary>
    public class KAB_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank name [Alphanumeric: a10]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Bank address [Alphanumeric: a50]
        /// </summary>
        public string ADDRESS { get; internal set; }
        /// <summary>
        /// Bank suburb [Alphanumeric: a30]
        /// </summary>
        public string SUBURB { get; internal set; }
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
