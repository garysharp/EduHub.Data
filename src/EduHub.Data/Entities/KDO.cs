using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDO : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<STVDI> Cache_KDOKEY_STVDI_VDOMAIN;
        private IReadOnlyList<STVDO> Cache_KDOKEY_STVDO_VDOMAIN;

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
        /// Key of the domain
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KDOKEY { get; internal set; }

        /// <summary>
        /// Description as per VACC
        /// [Alphanumeric (255)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// First year.semester of AusVELS curriculum e.g. 2013.1
        /// [Alphanumeric (6)]
        /// </summary>
        public string AUSVELS_START { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// STVDI (VELS Dimension Results) related entities by [KDO.KDOKEY]-&gt;[STVDI.VDOMAIN]
        /// Key of the domain
        /// </summary>
        public IReadOnlyList<STVDI> KDOKEY_STVDI_VDOMAIN
        {
            get
            {
                if (Cache_KDOKEY_STVDI_VDOMAIN == null &&
                    !Context.STVDI.TryFindByVDOMAIN(KDOKEY, out Cache_KDOKEY_STVDI_VDOMAIN))
                {
                    Cache_KDOKEY_STVDI_VDOMAIN = new List<STVDI>().AsReadOnly();
                }

                return Cache_KDOKEY_STVDI_VDOMAIN;
            }
        }

        /// <summary>
        /// STVDO (VELS Domain Results) related entities by [KDO.KDOKEY]-&gt;[STVDO.VDOMAIN]
        /// Key of the domain
        /// </summary>
        public IReadOnlyList<STVDO> KDOKEY_STVDO_VDOMAIN
        {
            get
            {
                if (Cache_KDOKEY_STVDO_VDOMAIN == null &&
                    !Context.STVDO.TryFindByVDOMAIN(KDOKEY, out Cache_KDOKEY_STVDO_VDOMAIN))
                {
                    Cache_KDOKEY_STVDO_VDOMAIN = new List<STVDO>().AsReadOnly();
                }

                return Cache_KDOKEY_STVDO_VDOMAIN;
            }
        }

        #endregion

    }
}
