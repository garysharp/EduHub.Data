using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Task Message
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTM : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return null;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Stored procedure name
        /// [Alphanumeric (30)]
        /// </summary>
        public string KTMKEY { get; internal set; }

        /// <summary>
        /// Message detail
        /// [Alphanumeric (200)]
        /// </summary>
        public string MESSAGE { get; internal set; }

        #endregion

    }
}
