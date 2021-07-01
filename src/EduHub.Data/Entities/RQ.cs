using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Purchase Requisition
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQ : EduHubEntity
    {

        #region Navigation Property Cache

        private CR Cache_CODE_CR;
        private SF Cache_ORDER_BY_SF;
        private SF Cache_APPROVED_BY_SF;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<RQT> Cache_TRORDER_RQT_TRORDER;

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
        /// Prime Key
        /// </summary>
        public int TRORDER { get; internal set; }

        /// <summary>
        /// Creditor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// date raised
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// Ledger ie. GL
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }

        /// <summary>
        /// Purchase Order Comment
        /// [Memo]
        /// </summary>
        public string PRCOMMENT { get; internal set; }

        /// <summary>
        /// PR raised by staff member
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ORDER_BY { get; internal set; }

        /// <summary>
        /// Pending, Approved, Declined or Not Submitted
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STATUS { get; internal set; }

        /// <summary>
        /// Officer who Approved, Declined or Cancelled
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string APPROVED_BY { get; internal set; }

        /// <summary>
        /// Date of Approval, Decline or Cancelled
        /// </summary>
        public DateTime? APPROVED_DATE { get; internal set; }

        /// <summary>
        /// Reason for Declining or Cancelling Requisition
        /// [Memo]
        /// </summary>
        public string DECLINED_COMMENT { get; internal set; }

        /// <summary>
        /// Purchase Order raised
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRINTED { get; internal set; }

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
        /// CR (Accounts Payable) related entity by [RQ.CODE]-&gt;[CR.CRKEY]
        /// Creditor key
        /// </summary>
        public CR CODE_CR
        {
            get
            {
                if (CODE == null)
                {
                    return null;
                }
                if (Cache_CODE_CR == null)
                {
                    Cache_CODE_CR = Context.CR.FindByCRKEY(CODE);
                }

                return Cache_CODE_CR;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [RQ.ORDER_BY]-&gt;[SF.SFKEY]
        /// PR raised by staff member
        /// </summary>
        public SF ORDER_BY_SF
        {
            get
            {
                if (ORDER_BY == null)
                {
                    return null;
                }
                if (Cache_ORDER_BY_SF == null)
                {
                    Cache_ORDER_BY_SF = Context.SF.FindBySFKEY(ORDER_BY);
                }

                return Cache_ORDER_BY_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [RQ.APPROVED_BY]-&gt;[SF.SFKEY]
        /// Officer who Approved, Declined or Cancelled
        /// </summary>
        public SF APPROVED_BY_SF
        {
            get
            {
                if (APPROVED_BY == null)
                {
                    return null;
                }
                if (Cache_APPROVED_BY_SF == null)
                {
                    Cache_APPROVED_BY_SF = Context.SF.FindBySFKEY(APPROVED_BY);
                }

                return Cache_APPROVED_BY_SF;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// RQT (Purchase Requisition Transaction) related entities by [RQ.TRORDER]-&gt;[RQT.TRORDER]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<RQT> TRORDER_RQT_TRORDER
        {
            get
            {
                if (Cache_TRORDER_RQT_TRORDER == null &&
                    !Context.RQT.TryFindByTRORDER(TRORDER, out Cache_TRORDER_RQT_TRORDER))
                {
                    Cache_TRORDER_RQT_TRORDER = new List<RQT>().AsReadOnly();
                }

                return Cache_TRORDER_RQT_TRORDER;
            }
        }

        #endregion

    }
}
