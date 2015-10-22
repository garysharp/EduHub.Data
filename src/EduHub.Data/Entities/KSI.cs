using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Institutions
    /// </summary>
    public partial class KSI : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Institution code
        /// [Alphanumeric (30)]
        /// </summary>
        public string KSIKEY { get; internal set; }
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
        /// SFQA (Staff Qualifications) related entities by [SFQA.INSTITUTION]-&gt;[KSI.KSIKEY]
        /// </summary>
        public IReadOnlyList<SFQA> SFQA_INSTITUTION
        {
            get
            {
                return Context.KSI.FindSFQAByINSTITUTION(KSIKEY);
            }
        }
#endregion
    }
}
