using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Audit Group Tables
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSAG : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<QSAT> Cache_QSAGKEY_QSAT_GROUPING;

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
        /// Group Table ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string QSAGKEY { get; internal set; }

        /// <summary>
        /// Group Table description
        /// [Alphanumeric (32)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// QSAT (Auditable Tables) related entities by [QSAG.QSAGKEY]-&gt;[QSAT.GROUPING]
        /// Group Table ID
        /// </summary>
        public IReadOnlyList<QSAT> QSAGKEY_QSAT_GROUPING
        {
            get
            {
                if (Cache_QSAGKEY_QSAT_GROUPING == null &&
                    !Context.QSAT.TryFindByGROUPING(QSAGKEY, out Cache_QSAGKEY_QSAT_GROUPING))
                {
                    Cache_QSAGKEY_QSAT_GROUPING = new List<QSAT>().AsReadOnly();
                }

                return Cache_QSAGKEY_QSAT_GROUPING;
            }
        }

        #endregion

    }
}
