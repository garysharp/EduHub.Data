using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods
    /// </summary>
    public class KADM_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Method Code [Uppercase Alphanumeric: u1]
        /// </summary>
        public string KADMKEY { get; internal set; }
        /// <summary>
        /// Method Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Detail description of calculation,
        /// eg. calculation examples [Memo: m]
        /// </summary>
        public string DETAIL { get; internal set; }
        /// <summary>
        /// Date-Based method Y/N? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DATE_BASED { get; internal set; }
        /// <summary>
        /// Is this method used for tax depreciation Y/N? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TAX { get; internal set; }
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
