using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Batch Headers
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QB : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<DRF> Cache_QBKEY_DRF_TRBATCH;

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
        /// Batch number (Prime Key)
        /// </summary>
        public int QBKEY { get; internal set; }

        /// <summary>
        /// Batch comment
        /// [Alphanumeric (40)]
        /// </summary>
        public string NARRATIVE { get; internal set; }

        /// <summary>
        /// Batch total
        /// </summary>
        public decimal? TOTAL { get; internal set; }

        /// <summary>
        /// Class
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string CLASS { get; internal set; }

        /// <summary>
        /// Number of transactions
        /// </summary>
        public int? QUANTITY { get; internal set; }

        /// <summary>
        /// Batch type
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BATCHTYPE { get; internal set; }

        /// <summary>
        /// Transaction type
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSTYPE { get; internal set; }

        /// <summary>
        /// Batch data
        /// </summary>
        public byte[] BATCHDATA { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BATCHPRINTED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BANKPRINTED { get; internal set; }

        /// <summary>
        /// Mandatory field
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BATCHTRACE { get; internal set; }

        /// <summary>
        /// 0 = normal, 1 = forward,2 = standing,3 = reversal
        /// </summary>
        public short? BATCHCLASS { get; internal set; }

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
        /// DRF (DR Transactions) related entities by [QB.QBKEY]-&gt;[DRF.TRBATCH]
        /// Batch number (Prime Key)
        /// </summary>
        public IReadOnlyList<DRF> QBKEY_DRF_TRBATCH
        {
            get
            {
                if (Cache_QBKEY_DRF_TRBATCH == null &&
                    !Context.DRF.TryFindByTRBATCH(QBKEY, out Cache_QBKEY_DRF_TRBATCH))
                {
                    Cache_QBKEY_DRF_TRBATCH = new List<DRF>().AsReadOnly();
                }

                return Cache_QBKEY_DRF_TRBATCH;
            }
        }

        #endregion

    }
}
