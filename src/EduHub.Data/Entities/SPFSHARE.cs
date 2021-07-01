using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// File Sharing
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPFSHARE : EduHubEntity
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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// file name (used for searching
        /// [Alphanumeric (50)]
        /// </summary>
        public string FILE_NAME { get; internal set; }

        /// <summary>
        /// Brief Description
        /// [Alphanumeric (100)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// FILE_ID from SPFSTORE
        /// </summary>
        public int? FILE_ID { get; internal set; }

        /// <summary>
        /// Grouping Category for the file e.g CCurriculum, FFinancial, XCalendar, SSchool Community, PSchool Policy
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string CATEGORY { get; internal set; }

        /// <summary>
        /// Date of entry
        /// </summary>
        public DateTime? CREATED_DATE { get; internal set; }

        /// <summary>
        /// Date of entry
        /// </summary>
        public DateTime? EXPIRY_DATE { get; internal set; }

        /// <summary>
        /// Summary description or synopsis of file
        /// [Memo]
        /// </summary>
        public string SUMMARY { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
