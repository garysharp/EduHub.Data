using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Pay Steps or Pay Class
    /// </summary>
    public class PSF : EntityBase
    {
#region Navigation Property Cache
        private PS _PSKEY_PS;
#endregion

#region Field Properties
        /// <summary>
        /// TID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Pay Step or Pay Class code
        /// </summary>
        public short? PSKEY { get; internal set; }
        /// <summary>
        /// Date from which this step/class
        /// will be current. Does not automatically
        /// update rates from this date
        /// </summary>
        public DateTime? EFFECTIVE_FROM_DATE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EFFECTIVE_TO_DATE { get; internal set; }
        /// <summary>
        /// Annual Earnings
        /// </summary>
        public decimal? ANNUAL_RATE { get; internal set; }
        /// <summary>
        /// Hourly Rate for Wkly & Fortnightly
        /// </summary>
        public decimal? HOURLY_RATE { get; internal set; }
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
        /// <summary>
        /// Navigation property for [PSKEY] => [PS].[PSKEY]
        /// Pay Step or Pay Class code
        /// </summary>
        public PS PSKEY_PS {
            get
            {
                if (PSKEY.HasValue)
                {
                    if (_PSKEY_PS == null)
                    {
                        _PSKEY_PS = Context.PS.FindByPSKEY(PSKEY.Value);
                    }
                    return _PSKEY_PS;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
