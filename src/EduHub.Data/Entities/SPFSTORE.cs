using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// File Store for streaming files to eMaze
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPFSTORE : EduHubEntity
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
        /// file id
        /// </summary>
        public int FILE_ID { get; internal set; }

        /// <summary>
        /// File name and Relative Path to Root Location ID
        /// [Alphanumeric (500)]
        /// </summary>
        public string PHYSICAL_LOCATION { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (255)]
        /// </summary>
        public string ROOT_ID { get; internal set; }

        /// <summary>
        /// Display name for the file
        /// [Alphanumeric (50)]
        /// </summary>
        public string DISPLAY_NAME { get; internal set; }

        /// <summary>
        /// Mime type
        /// [Alphanumeric (100)]
        /// </summary>
        public string MIME_TYPE { get; internal set; }

        /// <summary>
        /// MazeFormat 0, 1 eMaze User Link (Not for Maze use)
        /// </summary>
        public int ASSOCIATION_TYPE { get; internal set; }

        /// <summary>
        /// File name and Path
        /// [Alphanumeric (200)]
        /// </summary>
        public string PAGE_ID { get; internal set; }

        /// <summary>
        /// the size of the file in bytes
        /// </summary>
        public int? FILE_SIZE { get; internal set; }

        /// <summary>
        /// file extension
        /// [Alphanumeric (10)]
        /// </summary>
        public string FILE_EXTENSION { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime LW_DATE { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
