#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Locations
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKL : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_LOCATION_AR_LOCATION;
#if !EduHubScoped
        private IReadOnlyList<ARF> Cache_LOCATION_ARF_LOCATION;
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
        /// &lt;No documentation available&gt;
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
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AFLAG { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
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

        #region Foreign Navigation Properties

        /// <summary>
        /// AR (Assets) related entities by [AKL.LOCATION]-&gt;[AR.LOCATION]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<AR> LOCATION_AR_LOCATION
        {
            get
            {
                if (Cache_LOCATION_AR_LOCATION == null &&
                    !Context.AR.TryFindByLOCATION(LOCATION, out Cache_LOCATION_AR_LOCATION))
                {
                    Cache_LOCATION_AR_LOCATION = new List<AR>().AsReadOnly();
                }

                return Cache_LOCATION_AR_LOCATION;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [AKL.LOCATION]-&gt;[ARF.LOCATION]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<ARF> LOCATION_ARF_LOCATION
        {
            get
            {
                if (Cache_LOCATION_ARF_LOCATION == null &&
                    !Context.ARF.TryFindByLOCATION(LOCATION, out Cache_LOCATION_ARF_LOCATION))
                {
                    Cache_LOCATION_ARF_LOCATION = new List<ARF>().AsReadOnly();
                }

                return Cache_LOCATION_ARF_LOCATION;
            }
        }

#endif
        #endregion

    }
}
#endif
