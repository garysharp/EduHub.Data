using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Sub-Category
    /// </summary>
    public partial class AKB : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string BRANCH { get; internal set; }
        /// <summary>
        /// Description of branch
        /// 
        /// [Alphanumeric (40)]
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
        /// AR (Assets) related entities by [AR.BRANCH]-&gt;[AKB.BRANCH]
        /// </summary>
        public IReadOnlyList<AR> AR_BRANCH
        {
            get
            {
                return Context.AKB.FindARByBRANCH(BRANCH);
            }
        }
#endregion
    }
}
