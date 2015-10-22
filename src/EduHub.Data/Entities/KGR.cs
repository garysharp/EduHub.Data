using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religions
    /// </summary>
    public partial class KGR : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Religion code
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string RELIGION { get; internal set; }
        /// <summary>
        /// Religion description
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
        /// SF (Staff) related entities by [SF.RELIGION]-&gt;[KGR.RELIGION]
        /// </summary>
        public IReadOnlyList<SF> SF_RELIGION
        {
            get
            {
                return Context.KGR.FindSFByRELIGION(RELIGION);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.RELIGION]-&gt;[KGR.RELIGION]
        /// </summary>
        public IReadOnlyList<ST> ST_RELIGION
        {
            get
            {
                return Context.KGR.FindSTByRELIGION(RELIGION);
            }
        }
#endregion
    }
}
