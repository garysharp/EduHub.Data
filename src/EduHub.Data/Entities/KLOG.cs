using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Trace log for finance import and export
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KLOG : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// message severity
        /// </summary>
        public int? SEVERITY { get; internal set; }

        /// <summary>
        /// Message text
        /// [Memo]
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
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
