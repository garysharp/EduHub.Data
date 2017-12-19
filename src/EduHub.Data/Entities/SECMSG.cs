using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCases Messages
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SECMSG : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Key
        /// </summary>
        public int ID { get; internal set; }

        /// <summary>
        /// Message to send
        /// [Alphanumeric (180)]
        /// </summary>
        public string MESSAGE { get; internal set; }

        /// <summary>
        /// Date the message was last edited
        /// </summary>
        public DateTime? LAST_EDITED { get; internal set; }

        /// <summary>
        /// Logon ID of CASES21 user that created the message
        /// [Alphanumeric (128)]
        /// </summary>
        public string CREATOR { get; internal set; }

        /// <summary>
        /// Date after which the message will no longer be displayed
        /// </summary>
        public DateTime? EXPIRY { get; internal set; }

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

    }
}
