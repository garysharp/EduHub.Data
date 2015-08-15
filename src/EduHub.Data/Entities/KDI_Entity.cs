using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions
    /// </summary>
    public class KDI_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Key of the dimension [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KDIKEY { get; internal set; }
        /// <summary>
        /// Key of the domain that this dimension is linked to [Uppercase Alphanumeric: u5]
        /// </summary>
        public string KDOKEY { get; internal set; }
        /// <summary>
        /// Description as per VACC [Alphanumeric: a255]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Minimum level of dimension assessment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? MIN_SCORE { get; internal set; }
        /// <summary>
        /// Maximum level of dimension assessment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? MAX_SCORE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
