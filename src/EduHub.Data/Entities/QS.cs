using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored SQL
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QS : EduHubEntity
    {

        #region Field Properties

        /// <summary>
        /// SQL statement ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string QSKEY { get; internal set; }

        /// <summary>
        /// SQL title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Memo]
        /// </summary>
        public string SQLTEXT { get; internal set; }

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
