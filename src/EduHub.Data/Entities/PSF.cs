#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Pay Steps or Pay Class
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSF : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private PS Cache_PSKEY_PS;
#endif

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// TID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Pay Step or Pay Class code
        /// </summary>
        public short PSKEY { get; internal set; }

        /// <summary>
        /// Date from which this step/class
        /// will be current. Does not automatically
        /// update rates from this date
        /// </summary>
        public DateTime? EFFECTIVE_FROM_DATE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? EFFECTIVE_TO_DATE { get; internal set; }

        /// <summary>
        /// Annual Earnings
        /// </summary>
        public decimal? ANNUAL_RATE { get; internal set; }

        /// <summary>
        /// Hourly Rate for Wkly &amp; Fortnightly
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

#if !EduHubScoped
        /// <summary>
        /// PS (Pay Steps or Pay Class) related entity by [PSF.PSKEY]-&gt;[PS.PSKEY]
        /// Pay Step or Pay Class code
        /// </summary>
        public PS PSKEY_PS
        {
            get
            {
                if (Cache_PSKEY_PS == null)
                {
                    Cache_PSKEY_PS = Context.PS.FindByPSKEY(PSKEY);
                }

                return Cache_PSKEY_PS;
            }
        }

#endif
        #endregion

    }
}
#endif
