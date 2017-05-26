using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Emergency Templates
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEMRG : EduHubEntity
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
        /// Prime Key
        /// [Alphanumeric (10)]
        /// </summary>
        public string _SPEMRG { get; internal set; }

        /// <summary>
        /// SMS Template Description
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Emergency message to send
        /// [Alphanumeric (160)]
        /// </summary>
        public string MESSAGE { get; internal set; }

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
