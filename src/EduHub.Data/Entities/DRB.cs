using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts for Sundry Debtors
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRB : EduHubEntity
    {

        #region Navigation Property Cache

        private DR Cache_DR_CODE_DR;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Sundry Debtor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DR_CODE { get; internal set; }

        /// <summary>
        /// Unique payment reference number
        /// [Alphanumeric (21)]
        /// </summary>
        public string REFERENCE_NO { get; internal set; }

        /// <summary>
        /// Family Bill Pay Reference number
        /// [Alphanumeric (20)]
        /// </summary>
        public string CUST_REFERENCE { get; internal set; }

        /// <summary>
        /// BPAY Import record type required
        /// for import
        /// [Alphanumeric (2)]
        /// </summary>
        public string RECORD_TYPE { get; internal set; }

        /// <summary>
        /// School biller code required for
        /// import
        /// [Alphanumeric (10)]
        /// </summary>
        public string BILLER_CODE { get; internal set; }

        /// <summary>
        /// Type of payment
        /// 05 = Payment
        /// 15 = Error Correction
        /// 25 = Reversal
        /// [Alphanumeric (2)]
        /// </summary>
        public string PAYMENT_TYPE { get; internal set; }

        /// <summary>
        /// Receipt value
        /// </summary>
        public decimal? AMOUNT { get; internal set; }

        /// <summary>
        /// Receipt date
        /// </summary>
        public DateTime? PAYMENT_DATE { get; internal set; }

        /// <summary>
        /// Processed/flagged for deletion set
        /// to 'Y' else null
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }

        /// <summary>
        /// TID of invoice being paid for imported invoice payments
        /// </summary>
        public int? INVOICE_TID { get; internal set; }

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
        /// DR (Accounts Receivable) related entity by [DRB.DR_CODE]-&gt;[DR.DRKEY]
        /// Sundry Debtor key
        /// </summary>
        public DR DR_CODE_DR
        {
            get
            {
                if (Cache_DR_CODE_DR == null)
                {
                    Cache_DR_CODE_DR = Context.DR.FindByDRKEY(DR_CODE);
                }

                return Cache_DR_CODE_DR;
            }
        }

        #endregion

    }
}
