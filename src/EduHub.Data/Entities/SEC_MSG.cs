using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Message
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_MSG : EduHubEntity
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
        public int SCHOOLMSGID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Memo]
        /// </summary>
        public string MSGTEXT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string EDITBYUSERID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? EDITDATE { get; internal set; }

        #endregion

    }
}
