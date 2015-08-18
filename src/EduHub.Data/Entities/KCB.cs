using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications
    /// </summary>
    public class KCB : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Behaviour code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCBKEY { get; internal set; }
        /// <summary>
        /// Behaviour description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Is this positive (P) or negative (N) behaviour?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string POS_NEG { get; internal set; }
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
