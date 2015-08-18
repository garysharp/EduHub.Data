using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes
    /// </summary>
    public class TRPMODE : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Transport Modes
        /// </summary>
        public int TRANSPORT_MODE_ID { get; internal set; }
        /// <summary>
        /// Transport Desc
        /// [Alphanumeric (60)]
        /// </summary>
        public string TRANSPORT_MODE_DESC { get; internal set; }
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
