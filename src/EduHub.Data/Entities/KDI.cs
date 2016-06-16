using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDI : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<STVDI> Cache_KDIKEY_STVDI_VDIMENSION;
        private IReadOnlyList<STVDO> Cache_KDIKEY_STVDO_VDIMENSION;
        private IReadOnlyList<SVAG> Cache_KDIKEY_SVAG_VDIMENSION;

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
        /// Key of the dimension
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KDIKEY { get; internal set; }

        /// <summary>
        /// Key of the domain that this dimension is linked to
        /// [Uppercase Alphanumeric (10)]
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
        /// Curriculum
        /// [Alphanumeric (7)]
        /// </summary>
        public string CURRICULUM { get; internal set; }

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
        /// STVDI (VELS Dimension Results) related entities by [KDI.KDIKEY]-&gt;[STVDI.VDIMENSION]
        /// Key of the dimension
        /// </summary>
        public IReadOnlyList<STVDI> KDIKEY_STVDI_VDIMENSION
        {
            get
            {
                if (Cache_KDIKEY_STVDI_VDIMENSION == null &&
                    !Context.STVDI.TryFindByVDIMENSION(KDIKEY, out Cache_KDIKEY_STVDI_VDIMENSION))
                {
                    Cache_KDIKEY_STVDI_VDIMENSION = new List<STVDI>().AsReadOnly();
                }

                return Cache_KDIKEY_STVDI_VDIMENSION;
            }
        }

        /// <summary>
        /// STVDO (VELS Domain Results) related entities by [KDI.KDIKEY]-&gt;[STVDO.VDIMENSION]
        /// Key of the dimension
        /// </summary>
        public IReadOnlyList<STVDO> KDIKEY_STVDO_VDIMENSION
        {
            get
            {
                if (Cache_KDIKEY_STVDO_VDIMENSION == null &&
                    !Context.STVDO.TryFindByVDIMENSION(KDIKEY, out Cache_KDIKEY_STVDO_VDIMENSION))
                {
                    Cache_KDIKEY_STVDO_VDIMENSION = new List<STVDO>().AsReadOnly();
                }

                return Cache_KDIKEY_STVDO_VDIMENSION;
            }
        }

        /// <summary>
        /// SVAG (VELS Aggregated Dimensions) related entities by [KDI.KDIKEY]-&gt;[SVAG.VDIMENSION]
        /// Key of the dimension
        /// </summary>
        public IReadOnlyList<SVAG> KDIKEY_SVAG_VDIMENSION
        {
            get
            {
                if (Cache_KDIKEY_SVAG_VDIMENSION == null &&
                    !Context.SVAG.TryFindByVDIMENSION(KDIKEY, out Cache_KDIKEY_SVAG_VDIMENSION))
                {
                    Cache_KDIKEY_SVAG_VDIMENSION = new List<SVAG>().AsReadOnly();
                }

                return Cache_KDIKEY_SVAG_VDIMENSION;
            }
        }

        #endregion

    }
}
