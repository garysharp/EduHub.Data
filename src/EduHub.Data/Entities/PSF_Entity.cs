using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Pay Steps or Pay Class
    /// </summary>
    public class PSF_Entity : EntityBase
    {
        /// <summary>
        /// TID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Pay Step or Pay Class code [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PSKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [PSKEY] => [PS_Entity].[PSKEY]
        /// Pay Step or Pay Class code
        /// </summary>
        public PS_Entity PSKEY_PS { get { return PSKEY.HasValue ? Context.PS.FindByPSKEY(PSKEY.Value) : null; } }
        /// <summary>
        /// Date from which this step/class
        /// will be current. Does not automatically
        /// update rates from this date [Date Time nullable: d]
        /// </summary>
        public DateTime? EFFECTIVE_FROM_DATE { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? EFFECTIVE_TO_DATE { get; internal set; }
        /// <summary>
        /// Annual Earnings [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ANNUAL_RATE { get; internal set; }
        /// <summary>
        /// Hourly Rate for Wkly & Fortnightly [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? HOURLY_RATE { get; internal set; }
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
