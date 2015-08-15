using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Locations
    /// </summary>
    public class AKL_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Description of location [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Current estimate of units [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ESTIMATE_UNITS { get; internal set; }
        /// <summary>
        /// Current period units [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PERIOD_UNITS { get; internal set; }
        /// <summary>
        /// Life to date units used [Integer (32bit signed nullable): l]
        /// </summary>
        public int? UNITS_TO_DATE { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACUTOFF { get; internal set; }
        /// <summary>
        /// Dummy items required [Date Time nullable: d]
        /// </summary>
        public DateTime? DATEFU { get; internal set; }
        /// <summary>
        /// for EOP [Date Time nullable: d]
        /// </summary>
        public DateTime? PURDATE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AFLAG { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TFLAG { get; internal set; }
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
