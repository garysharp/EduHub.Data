using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Locations
    /// </summary>
    public class AKL : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Description of location
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Current estimate of units
        /// </summary>
        public int? ESTIMATE_UNITS { get; internal set; }
        /// <summary>
        /// Current period units
        /// </summary>
        public int? PERIOD_UNITS { get; internal set; }
        /// <summary>
        /// Life to date units used
        /// </summary>
        public int? UNITS_TO_DATE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? ACUTOFF { get; internal set; }
        /// <summary>
        /// Dummy items required
        /// </summary>
        public DateTime? DATEFU { get; internal set; }
        /// <summary>
        /// for EOP
        /// </summary>
        public DateTime? PURDATE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AFLAG { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TFLAG { get; internal set; }
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
