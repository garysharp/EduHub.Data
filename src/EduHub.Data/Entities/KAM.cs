using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions
    /// </summary>
    public class KAM : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Code to identify standard disciplinary action
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string KAMKEY { get; internal set; }
        /// <summary>
        /// Brief description of disciplinary action
        /// [Alphanumeric (40)]
        /// </summary>
        public string BRIEF { get; internal set; }
        /// <summary>
        /// Full description of disciplinary action
        /// [Memo]
        /// </summary>
        public string DETAIL { get; internal set; }
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
#endregion
    }
}
