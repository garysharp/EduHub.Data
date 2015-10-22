using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Available Qualifications
    /// </summary>
    public partial class KSQ : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Qualification code
        /// [Alphanumeric (30)]
        /// </summary>
        public string KSQKEY { get; internal set; }
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
        /// SFQA (Staff Qualifications) related entities by [SFQA.QUALIFICATION]-&gt;[KSQ.KSQKEY]
        /// </summary>
        public IReadOnlyList<SFQA> SFQA_QUALIFICATION
        {
            get
            {
                return Context.KSQ.FindSFQAByQUALIFICATION(KSQKEY);
            }
        }
#endregion
    }
}
