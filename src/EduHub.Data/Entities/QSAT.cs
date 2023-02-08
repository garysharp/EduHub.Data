#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Auditable Tables
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSAT : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private QSAG Cache_GROUPING_QSAG;
#endif

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<QSAC> Cache_TABLE_NAME_QSAC_TABLE_NAME;
#endif

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
        /// Table ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TABLE_NAME { get; internal set; }

        /// <summary>
        /// Table description
        /// [Alphanumeric (32)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Grouping on Tables
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GROUPING { get; internal set; }

        /// <summary>
        /// Name of primary key column
        /// [Uppercase Alphanumeric (32)]
        /// </summary>
        public string KEY_COLUMN { get; internal set; }

        /// <summary>
        /// Name of best record description column
        /// [Uppercase Alphanumeric (32)]
        /// </summary>
        public string DESCRIPTION_COLUMN { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// QSAG (Audit Group Tables) related entity by [QSAT.GROUPING]-&gt;[QSAG.QSAGKEY]
        /// Grouping on Tables
        /// </summary>
        public QSAG GROUPING_QSAG
        {
            get
            {
                if (GROUPING == null)
                {
                    return null;
                }
                if (Cache_GROUPING_QSAG == null)
                {
                    Cache_GROUPING_QSAG = Context.QSAG.FindByQSAGKEY(GROUPING);
                }

                return Cache_GROUPING_QSAG;
            }
        }

#endif
        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// QSAC (Audit Control) related entities by [QSAT.TABLE_NAME]-&gt;[QSAC.TABLE_NAME]
        /// Table ID
        /// </summary>
        public IReadOnlyList<QSAC> TABLE_NAME_QSAC_TABLE_NAME
        {
            get
            {
                if (Cache_TABLE_NAME_QSAC_TABLE_NAME == null &&
                    !Context.QSAC.TryFindByTABLE_NAME(TABLE_NAME, out Cache_TABLE_NAME_QSAC_TABLE_NAME))
                {
                    Cache_TABLE_NAME_QSAC_TABLE_NAME = new List<QSAC>().AsReadOnly();
                }

                return Cache_TABLE_NAME_QSAC_TABLE_NAME;
            }
        }

#endif
        #endregion

    }
}
#endif
