using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payment Summary Box
    /// </summary>
    public partial class PG : EntityBase
    {
#region Field Properties
        /// <summary>
        /// PAYG Payment summary Box
        /// </summary>
        public short PAYG_BOX { get; internal set; }
        /// <summary>
        /// Description of group
        /// 
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
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
        /// PI (Pay Items) related entities by [PI.PAYG_BOX]-&gt;[PG.PAYG_BOX]
        /// </summary>
        public IReadOnlyList<PI> PI_PAYG_BOX
        {
            get
            {
                return Context.PG.FindPIByPAYG_BOX(PAYG_BOX);
            }
        }
#endregion
    }
}
