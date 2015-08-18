using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods
    /// </summary>
    public class KADM : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Method Code
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string KADMKEY { get; internal set; }
        /// <summary>
        /// Method Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Detail description of calculation,
        /// eg. calculation examples
        /// [Memo]
        /// </summary>
        public string DETAIL { get; internal set; }
        /// <summary>
        /// Date-Based method Y/N?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DATE_BASED { get; internal set; }
        /// <summary>
        /// Is this method used for tax depreciation Y/N?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TAX { get; internal set; }
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
