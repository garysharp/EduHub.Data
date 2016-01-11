using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 User Sessions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_USR : EduHubEntity
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
        /// &lt;No documentation available&gt;
        /// </summary>
        public int ROWID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string SESSIONID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string USERID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? DATECREATED { get; internal set; }

        #endregion

    }
}
