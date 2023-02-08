#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Audit Data Changes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSAD : EduHubEntity
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
        /// Primary key
        /// </summary>
        public int QSADKEY { get; internal set; }

        /// <summary>
        /// Name of table to audit
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TABLE_NAME { get; internal set; }

        /// <summary>
        /// Name of column to audit
        /// [Uppercase Alphanumeric (32)]
        /// </summary>
        public string COLUMN_NAME { get; internal set; }

        /// <summary>
        /// Change type - I/U/D
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHANGE_TYPE { get; internal set; }

        /// <summary>
        /// Key of record changed
        /// [Alphanumeric (20)]
        /// </summary>
        public string RECORD_KEY_VALUE { get; internal set; }

        /// <summary>
        /// Description of record changed
        /// [Alphanumeric (60)]
        /// </summary>
        public string RECORD_DESCRIPTION { get; internal set; }

        /// <summary>
        /// Before value of modified column
        /// [Alphanumeric (255)]
        /// </summary>
        public string BEFORE_VALUE { get; internal set; }

        /// <summary>
        /// After value of modified column
        /// [Alphanumeric (255)]
        /// </summary>
        public string AFTER_VALUE { get; internal set; }

        /// <summary>
        /// Operator who made change
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string USER_NAME { get; internal set; }

        /// <summary>
        /// Timestamp for change
        /// </summary>
        public DateTime? CHANGE_TIMESTAMP { get; internal set; }

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
#endif
