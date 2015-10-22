using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains
    /// </summary>
    public partial class KDO : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Key of the domain
        /// [Uppercase Alphanumeric (5)]
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

#region Navigation Properties

        /// <summary>
        /// STVDI (VELS Dimension Results) related entities by [STVDI.VDOMAIN]-&gt;[KDO.KDOKEY]
        /// </summary>
        public IReadOnlyList<STVDI> STVDI_VDOMAIN
        {
            get
            {
                return Context.KDO.FindSTVDIByVDOMAIN(KDOKEY);
            }
        }

        /// <summary>
        /// STVDO (VELS Domain Results) related entities by [STVDO.VDOMAIN]-&gt;[KDO.KDOKEY]
        /// </summary>
        public IReadOnlyList<STVDO> STVDO_VDOMAIN
        {
            get
            {
                return Context.KDO.FindSTVDOByVDOMAIN(KDOKEY);
            }
        }
#endregion
    }
}
