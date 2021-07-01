using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report WWW templates
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPWWW : EduHubEntity
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
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SPWWWKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (60)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Report file name (without  extension)
        /// [Alphanumeric (80)]
        /// </summary>
        public string REPORT_NAME { get; internal set; }

        /// <summary>
        /// Default Display name for the file
        /// [Alphanumeric (50)]
        /// </summary>
        public string DISPLAY_NAME { get; internal set; }

        /// <summary>
        /// Default Relative path, excluding filename
        /// [Alphanumeric (255)]
        /// </summary>
        public string PATH { get; internal set; }

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
