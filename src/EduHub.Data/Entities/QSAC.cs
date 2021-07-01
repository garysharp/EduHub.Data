using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Audit Control
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSAC : EduHubEntity
    {

        #region Navigation Property Cache

        private QSAT Cache_TABLE_NAME_QSAT;

        #endregion

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
        public int QSACKEY { get; internal set; }

        /// <summary>
        /// ID of table to audit
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TABLE_NAME { get; internal set; }

        /// <summary>
        /// Name of column to audit
        /// [Alphanumeric (32)]
        /// </summary>
        public string COLUMN_NAME { get; internal set; }

        /// <summary>
        /// Number of months to retain data
        /// </summary>
        public short? RETAIN_MONTHS { get; internal set; }

        /// <summary>
        /// Audit inserts Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AUDIT_INSERTS { get; internal set; }

        /// <summary>
        /// Audit updates Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AUDIT_UPDATES { get; internal set; }

        /// <summary>
        /// Audit deletes Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AUDIT_DELETES { get; internal set; }

        /// <summary>
        /// Enable auditing Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENABLED { get; internal set; }

        /// <summary>
        /// Indicates that purpose of audit is for data management Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FOR_MANAGEMENT_USE { get; internal set; }

        /// <summary>
        /// Indicates that purpose of audit is for auditor Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FOR_AUDITOR_USE { get; internal set; }

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

        #region Navigation Properties

        /// <summary>
        /// QSAT (Auditable Tables) related entity by [QSAC.TABLE_NAME]-&gt;[QSAT.TABLE_NAME]
        /// ID of table to audit
        /// </summary>
        public QSAT TABLE_NAME_QSAT
        {
            get
            {
                if (TABLE_NAME == null)
                {
                    return null;
                }
                if (Cache_TABLE_NAME_QSAT == null)
                {
                    Cache_TABLE_NAME_QSAT = Context.QSAT.FindByTABLE_NAME(TABLE_NAME);
                }

                return Cache_TABLE_NAME_QSAT;
            }
        }

        #endregion

    }
}
