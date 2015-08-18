using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions
    /// </summary>
    public class KDI : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Key of the dimension
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KDIKEY { get; internal set; }
        /// <summary>
        /// Key of the domain that this dimension is linked to
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string KDOKEY { get; internal set; }
        /// <summary>
        /// Description as per VACC
        /// [Alphanumeric (255)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Minimum level of dimension assessment
        /// </summary>
        public double? MIN_SCORE { get; internal set; }
        /// <summary>
        /// Maximum level of dimension assessment
        /// </summary>
        public double? MAX_SCORE { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
