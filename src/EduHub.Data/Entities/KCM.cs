using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medical Conditions
    /// </summary>
    public partial class KCM : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Medical Condition code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCMKEY { get; internal set; }
        /// <summary>
        /// Long description
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
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// SMC (Student Medical Conditions) related entities by [SMC.MED_CONDITION]-&gt;[KCM.KCMKEY]
        /// </summary>
        public IReadOnlyList<SMC> SMC_MED_CONDITION
        {
            get
            {
                return Context.KCM.FindSMCByMED_CONDITION(KCMKEY);
            }
        }
#endregion
    }
}
