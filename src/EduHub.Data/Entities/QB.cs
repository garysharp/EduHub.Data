using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Batch Headers
    /// </summary>
    public partial class QB : EntityBase
    {
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
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BATCHPRINTED { get; internal set; }
        /// <summary>
        /// 
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

#region Navigation Properties

        /// <summary>
        /// DRF (DR Transactions) related entities by [DRF.TRBATCH]-&gt;[QB.QBKEY]
        /// </summary>
        public IReadOnlyList<DRF> DRF_TRBATCH
        {
            get
            {
                return Context.QB.FindDRFByTRBATCH(QBKEY);
            }
        }
#endregion
    }
}
