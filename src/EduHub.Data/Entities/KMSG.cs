using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CASES21 MESSAGES
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KMSG : EduHubEntity
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
        /// Prime key
        /// </summary>
        public int KMSGKEY { get; internal set; }

        /// <summary>
        /// Send Date
        /// </summary>
        public DateTime? SEND_DATE { get; internal set; }

        /// <summary>
        /// Message Subject
        /// [Alphanumeric (100)]
        /// </summary>
        public string SUBJECT { get; internal set; }

        /// <summary>
        /// Message Body
        /// [Memo]
        /// </summary>
        public string MESSAGE { get; internal set; }

        /// <summary>
        /// Expiry date
        /// </summary>
        public DateTime? EXPIRY { get; internal set; }

        /// <summary>
        /// Frequency (Number of days)
        /// </summary>
        public short? FREQUENCY { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
