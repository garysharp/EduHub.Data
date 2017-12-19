using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Purchase Requisitions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRPR : EduHubEntity
    {

        #region Navigation Property Cache

        private CR Cache_CODE_CR;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;
        private SF Cache_STAFF_ORDER_BY_SF;
        private SF Cache_APPROVED_BY_SF;

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
        /// System transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Creditor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Transaction type.
        /// Must be :
        ///   O - Order
        /// [Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }

        /// <summary>
        /// Transaction date
        ///   Trtype = O: Order date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// Transaction reference
        ///   Trtype = 0: Order number
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }

        /// <summary>
        /// Ledger type GL or IV
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }

        /// <summary>
        /// GL code or IV code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRXCODE { get; internal set; }

        /// <summary>
        /// Must already exist as a SUBPROGRAM
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// Not mandatory
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

        /// <summary>
        /// Transaction unit cost
        ///  Trtype = O: Order unit cost
        /// </summary>
        public decimal? TRCOST { get; internal set; }

        /// <summary>
        /// Transaction quantity
        ///  Trtype = O: Total qty ordered
        /// </summary>
        public int? TRQTY { get; internal set; }

        /// <summary>
        /// Transaction description
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// Order number being satisfied
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRORDER { get; internal set; }

        /// <summary>
        /// Ordering person
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF_ORDER_BY { get; internal set; }

        /// <summary>
        /// Order has been approved by
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string APPROVED_BY { get; internal set; }

        /// <summary>
        /// Purchase Order Comment
        /// [Memo]
        /// </summary>
        public string POCOMMENT { get; internal set; }

        /// <summary>
        /// Amount before GST
        /// </summary>
        public decimal? TRNETT { get; internal set; }

        /// <summary>
        /// Line number in the batch
        /// </summary>
        public int? LINE_NO { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// CR (Accounts Payable) related entity by [CRPR.CODE]-&gt;[CR.CRKEY]
        /// Creditor key
        /// </summary>
        public CR CODE_CR
        {
            get
            {
                if (Cache_CODE_CR == null)
                {
                    Cache_CODE_CR = Context.CR.FindByCRKEY(CODE);
                }

                return Cache_CODE_CR;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [CRPR.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// Must already exist as a SUBPROGRAM
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
            get
            {
                if (SUBPROGRAM == null)
                {
                    return null;
                }
                if (Cache_SUBPROGRAM_KGLSUB == null)
                {
                    Cache_SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                }

                return Cache_SUBPROGRAM_KGLSUB;
            }
        }

        /// <summary>
        /// KGLINIT (General Ledger Initiatives) related entity by [CRPR.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Not mandatory
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
            get
            {
                if (INITIATIVE == null)
                {
                    return null;
                }
                if (Cache_INITIATIVE_KGLINIT == null)
                {
                    Cache_INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                }

                return Cache_INITIATIVE_KGLINIT;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [CRPR.STAFF_ORDER_BY]-&gt;[SF.SFKEY]
        /// Ordering person
        /// </summary>
        public SF STAFF_ORDER_BY_SF
        {
            get
            {
                if (STAFF_ORDER_BY == null)
                {
                    return null;
                }
                if (Cache_STAFF_ORDER_BY_SF == null)
                {
                    Cache_STAFF_ORDER_BY_SF = Context.SF.FindBySFKEY(STAFF_ORDER_BY);
                }

                return Cache_STAFF_ORDER_BY_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [CRPR.APPROVED_BY]-&gt;[SF.SFKEY]
        /// Order has been approved by
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

    }
}
