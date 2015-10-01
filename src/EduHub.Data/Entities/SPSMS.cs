using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS messages
    /// </summary>
    public class SPSMS : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Key
        /// </summary>
        public int SPSMSKEY { get; internal set; }
        /// <summary>
        /// Message to send
        /// 
        /// [Alphanumeric (160)]
        /// </summary>
        public string MESSAGE { get; internal set; }
        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime? CREATED_DATE { get; internal set; }
        /// <summary>
        /// Who created the message.
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CREATED_BY { get; internal set; }
        /// <summary>
        /// Notify the originator of the SMS of any reply
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NOTIFY_REPLIES { get; internal set; }
        /// <summary>
        /// Set to Y if SMS automatically generated.
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AUTO_MESSAGE { get; internal set; }
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
#endregion
    }
}
