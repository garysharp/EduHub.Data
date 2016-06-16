using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Import Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PGID : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_IMPORTED_BY_SF;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<PGLI> Cache_GLID_PGLI_FILE_ID;

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
        /// &lt;No documentation available&gt;
        /// </summary>
        public int GLID { get; internal set; }

        /// <summary>
        /// School ID
        /// [Alphanumeric (8)]
        /// </summary>
        public string SCHOOL_LINK { get; internal set; }

        /// <summary>
        /// Name of file imported to GLI
        /// [Alphanumeric (30)]
        /// </summary>
        public string FILE_IMPORTED { get; internal set; }

        /// <summary>
        /// Date eduPay file imported
        /// </summary>
        public DateTime DATE_IMPORTED { get; internal set; }

        /// <summary>
        /// Number of rows imported
        /// </summary>
        public int ROWS_IMPORTED { get; internal set; }

        /// <summary>
        /// Staff key of operator importing.
        /// If null this indicates it was imported by job. So the field allows nulls.
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string IMPORTED_BY { get; internal set; }

        /// <summary>
        /// Possible values are Success, or Failed
        /// [Alphanumeric (7)]
        /// </summary>
        public string IMPORT_STATUS { get; internal set; }

        /// <summary>
        /// Has failure notification been sent?  Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FAILURE_NOTIFICATION { get; internal set; }

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
        /// SF (Staff) related entity by [PGID.IMPORTED_BY]-&gt;[SF.SFKEY]
        /// Staff key of operator importing.
        /// If null this indicates it was imported by job. So the field allows nulls.
        /// </summary>
        public SF IMPORTED_BY_SF
        {
            get
            {
                if (IMPORTED_BY == null)
                {
                    return null;
                }
                if (Cache_IMPORTED_BY_SF == null)
                {
                    Cache_IMPORTED_BY_SF = Context.SF.FindBySFKEY(IMPORTED_BY);
                }

                return Cache_IMPORTED_BY_SF;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// PGLI (General Ledger Import) related entities by [PGID.GLID]-&gt;[PGLI.FILE_ID]
        /// &lt;No documentation available&gt;
        /// </summary>
        public IReadOnlyList<PGLI> GLID_PGLI_FILE_ID
        {
            get
            {
                if (Cache_GLID_PGLI_FILE_ID == null &&
                    !Context.PGLI.TryFindByFILE_ID(GLID, out Cache_GLID_PGLI_FILE_ID))
                {
                    Cache_GLID_PGLI_FILE_ID = new List<PGLI>().AsReadOnly();
                }

                return Cache_GLID_PGLI_FILE_ID;
            }
        }

        #endregion

    }
}
