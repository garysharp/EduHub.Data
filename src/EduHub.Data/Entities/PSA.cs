using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Award Details
    /// </summary>
    public partial class PSA : EntityBase
    {
#region Field Properties
        /// <summary>
        /// oldname=PSKEY; * Award Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PSAKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Type of award. Inlist
        /// 
        /// [Alphanumeric (3)]
        /// </summary>
        public string AWARD_TYPE { get; internal set; }
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
        /// PI (Pay Items) related entities by [PI.AWARD]-&gt;[PSA.PSAKEY]
        /// </summary>
        public IReadOnlyList<PI> PI_AWARD
        {
            get
            {
                return Context.PSA.FindPIByAWARD(PSAKEY);
            }
        }
#endregion
    }
}
