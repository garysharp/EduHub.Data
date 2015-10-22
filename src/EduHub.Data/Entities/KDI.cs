using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions
    /// </summary>
    public partial class KDI : EntityBase
    {
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

        /// <summary>
        /// STVDI (VELS Dimension Results) related entities by [STVDI.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        public IReadOnlyList<STVDI> STVDI_VDIMENSION
        {
            get
            {
                return Context.KDI.FindSTVDIByVDIMENSION(KDIKEY);
            }
        }

        /// <summary>
        /// STVDO (VELS Domain Results) related entities by [STVDO.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        public IReadOnlyList<STVDO> STVDO_VDIMENSION
        {
            get
            {
                return Context.KDI.FindSTVDOByVDIMENSION(KDIKEY);
            }
        }

        /// <summary>
        /// SVAG (VELS Aggregated Dimensions) related entities by [SVAG.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        public IReadOnlyList<SVAG> SVAG_VDIMENSION
        {
            get
            {
                return Context.KDI.FindSVAGByVDIMENSION(KDIKEY);
            }
        }
#endregion
    }
}
