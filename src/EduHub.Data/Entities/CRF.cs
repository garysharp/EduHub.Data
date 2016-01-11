using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Financial Transaction
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRF : EduHubEntity
    {

        #region Navigation Property Cache

        private CR Cache_CODE_CR;
        private KGST Cache_GST_TYPE_KGST;
        private KAB Cache_BSB_KAB;
        private KAD Cache_DEL_CODE_KAD;
        private AR Cache_ATKEY_AR;
        private KGST Cache_INVOICEGST_KGST;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// System transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Transaction ID of original order
        /// transaction
        /// </summary>
        public int? OTID { get; internal set; }

        /// <summary>
        /// Creditor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }

        /// <summary>
        /// Creditor ledger period number
        /// </summary>
        public int? TRPERD { get; internal set; }

        /// <summary>
        /// Transaction type.
        /// Must be one of the following:
        ///   I - Invoice
        ///   C - Credit Note
        ///   J - Journal
        ///   R - Receipt
        ///   P - Payment
        ///   O - Order
        ///   D - Delivery
        /// [Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }

        /// <summary>
        /// Transaction date
        ///   Trtype = O: Order date
        ///   Trtype = D: Delivery date
        ///   Trtype = I: Invoice date
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
        /// TRTYPE for through posting to subledgers
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRXTRTYPE { get; internal set; }

        /// <summary>
        /// Transaction unit cost
        ///  Trtype = O: Order unit cost
        ///  Trtype = D: Order price
        ///  Trtype = I: Invoice unit cost
        /// </summary>
        public decimal? TRCOST { get; internal set; }

        /// <summary>
        /// Transaction quantity
        ///  Trtype = O: Total qty ordered
        ///  Trtype = D: Qty delvd on this line
        ///  Trtype = I: Qty invcd on this line
        /// </summary>
        public int? TRQTY { get; internal set; }

        /// <summary>
        /// Quantity delivered - order line
        /// </summary>
        public int? TRQTYD { get; internal set; }

        /// <summary>
        /// Quantity invoiced - order line
        /// </summary>
        public int? TRQTYI { get; internal set; }

        /// <summary>
        /// Quantity cancelled - delivery line
        /// </summary>
        public int? TRQTYDX { get; internal set; }

        /// <summary>
        /// Quantity over invoiced-invoice line
        /// </summary>
        public int? TRQTYIX { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AUTODELIVER { get; internal set; }

        /// <summary>
        /// Transaction amount (extension)
        /// </summary>
        public decimal? TRAMT { get; internal set; }

        /// <summary>
        /// Transaction amount used in Journals
        /// </summary>
        public decimal? DEBIT { get; internal set; }

        /// <summary>
        /// Transaction amount used in Journals
        /// </summary>
        public decimal? CREDIT { get; internal set; }

        /// <summary>
        /// Amount paid to date
        /// or amount allocated (credits)
        /// </summary>
        public decimal? TRPAID { get; internal set; }

        /// <summary>
        /// Invoice allocated to (credits)
        ///   Trtype = I: Invoice ref number
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRINV { get; internal set; }

        /// <summary>
        /// Delete indicator (CREDITS)
        /// </summary>
        public short? TRDELETE { get; internal set; }

        /// <summary>
        /// Transaction description
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// Transaction hold or pay flag
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRHOLD { get; internal set; }

        /// <summary>
        /// Order number being satisfied
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRORDER { get; internal set; }

        /// <summary>
        /// Bank account in the GL
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRBANK { get; internal set; }

        /// <summary>
        /// Actual cheque number (written back)
        /// [Alphanumeric (10)]
        /// </summary>
        public string CHQ_NO { get; internal set; }

        /// <summary>
        /// Authorising person
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string ORDER_BY { get; internal set; }

        /// <summary>
        /// Order completed (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string COMPLETED { get; internal set; }

        /// <summary>
        /// Order unit
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRUNIT { get; internal set; }

        /// <summary>
        /// Requisition date
        /// </summary>
        public DateTime? REQ_DATE { get; internal set; }

        /// <summary>
        /// Supplier catalogue
        /// [Alphanumeric (15)]
        /// </summary>
        public string CATALOGUE { get; internal set; }

        /// <summary>
        /// Delivery instructions
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELIVERY { get; internal set; }

        /// <summary>
        /// Flag whether a cheque requires to
        /// be printed
        /// 'Y' - Print cheque
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }

        /// <summary>
        /// Sales tax indicator
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TAX { get; internal set; }

        /// <summary>
        /// Amount before GST
        /// </summary>
        public decimal? TRNETT { get; internal set; }

        /// <summary>
        /// Equals TRAMT,added for
        /// compatibility with mixed batches
        /// </summary>
        public decimal? TRGROSS { get; internal set; }

        /// <summary>
        /// Amount of GST
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }

        /// <summary>
        /// Relate to KGST
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GST_TYPE { get; internal set; }

        /// <summary>
        /// Rate of GST
        /// </summary>
        public double? GST_RATE { get; internal set; }

        /// <summary>
        /// is the user reclaiming this
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }

        /// <summary>
        /// Amount of Withholding TAX for this
        /// invoice line
        /// </summary>
        public decimal? WITHHOLD_AMOUNT { get; internal set; }

        /// <summary>
        /// Actual date of invoice
        /// </summary>
        public DateTime? INV_DATE { get; internal set; }

        /// <summary>
        /// Due date for payment
        /// </summary>
        public DateTime? DUE_DATE { get; internal set; }

        /// <summary>
        /// Receipt type for Bank deposit
        /// information
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RTYPE { get; internal set; }

        /// <summary>
        /// for Receipts
        /// [Alphanumeric (20)]
        /// </summary>
        public string DRAWER { get; internal set; }

        /// <summary>
        /// BSB number of cheque
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }

        /// <summary>
        /// Bank of cheque
        /// [Alphanumeric (20)]
        /// </summary>
        public string BANK { get; internal set; }

        /// <summary>
        /// Bank Branch of cheque
        /// [Alphanumeric (20)]
        /// </summary>
        public string BRANCH { get; internal set; }

        /// <summary>
        /// Account number of cheque
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }

        /// <summary>
        /// Expected delivery date
        /// </summary>
        public DateTime? EXPECTED_DATE { get; internal set; }

        /// <summary>
        /// Delivery address code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEL_CODE { get; internal set; }

        /// <summary>
        /// Delivery docket number
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEL_DOCKET_NO { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ATKEY { get; internal set; }

        /// <summary>
        /// Y/N field used in creditors asset invoice
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TINCLUDE { get; internal set; }

        /// <summary>
        /// Posting to TDep: Cost ex GST
        /// Also used for the cost base for depreciation
        /// </summary>
        public decimal? TTRNETT { get; internal set; }

        /// <summary>
        /// Tax value of Asset transaction
        /// </summary>
        public decimal? TTRAMT { get; internal set; }

        /// <summary>
        /// Amount of GST for tax transactions, Posted to tax ORIG_GST
        /// </summary>
        public decimal? TGST_AMOUNT { get; internal set; }

        /// <summary>
        /// Memo field for asset repairs
        /// [Memo]
        /// </summary>
        public string AMEMO { get; internal set; }

        /// <summary>
        /// Copy Amemo field to Asset? Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AMEMO_COPY { get; internal set; }

        /// <summary>
        /// Date for next service for asset repairs
        /// </summary>
        public DateTime? NEXT_SVC_DATE { get; internal set; }

        /// <summary>
        /// Master transaction ID (Internal)
        /// </summary>
        public int? MASTERTID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public int? ALLOCTID { get; internal set; }

        /// <summary>
        /// Direct Deposit or Cheque
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string PAY_METHOD { get; internal set; }

        /// <summary>
        /// Withhold Rate
        /// </summary>
        public double? WITHHOLD_RATE { get; internal set; }

        /// <summary>
        /// The number of months deleteable
        /// </summary>
        public short? TRDEL_MONTHS { get; internal set; }

        /// <summary>
        /// Line number in the batch
        /// </summary>
        public int? LINE_NO { get; internal set; }

        /// <summary>
        /// Determines through posts
        /// 0 = Don't show T/P
        /// 1 = Show T/P
        /// </summary>
        public int? FLAG { get; internal set; }

        /// <summary>
        /// Used in Reverse Payments to obtain the invoice GST type.
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string INVOICEGST { get; internal set; }

        /// <summary>
        /// For every transaction there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// Transaction might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

        /// <summary>
        /// Only filled in for cancelled payment/receipt
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string CANCELLED { get; internal set; }

        /// <summary>
        /// is this order line from PRMS
        /// </summary>
        public int? PRMS_TID { get; internal set; }

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
        /// CR (Accounts Payable) related entity by [CRF.CODE]-&gt;[CR.CRKEY]
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
        /// KGST (GST Percentages) related entity by [CRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// Relate to KGST
        /// </summary>
        public KGST GST_TYPE_KGST
        {
            get
            {
                if (GST_TYPE == null)
                {
                    return null;
                }
                if (Cache_GST_TYPE_KGST == null)
                {
                    Cache_GST_TYPE_KGST = Context.KGST.FindByKGSTKEY(GST_TYPE);
                }

                return Cache_GST_TYPE_KGST;
            }
        }

        /// <summary>
        /// KAB (BSB Numbers) related entity by [CRF.BSB]-&gt;[KAB.BSB]
        /// BSB number of cheque
        /// </summary>
        public KAB BSB_KAB
        {
            get
            {
                if (BSB == null)
                {
                    return null;
                }
                if (Cache_BSB_KAB == null)
                {
                    Cache_BSB_KAB = Context.KAB.FindByBSB(BSB);
                }

                return Cache_BSB_KAB;
            }
        }

        /// <summary>
        /// KAD (Delivery Addresses) related entity by [CRF.DEL_CODE]-&gt;[KAD.KADKEY]
        /// Delivery address code
        /// </summary>
        public KAD DEL_CODE_KAD
        {
            get
            {
                if (DEL_CODE == null)
                {
                    return null;
                }
                if (Cache_DEL_CODE_KAD == null)
                {
                    Cache_DEL_CODE_KAD = Context.KAD.FindByKADKEY(DEL_CODE);
                }

                return Cache_DEL_CODE_KAD;
            }
        }

        /// <summary>
        /// AR (Assets) related entity by [CRF.ATKEY]-&gt;[AR.ARKEY]
        /// &lt;No documentation available&gt;
        /// </summary>
        public AR ATKEY_AR
        {
            get
            {
                if (ATKEY == null)
                {
                    return null;
                }
                if (Cache_ATKEY_AR == null)
                {
                    Cache_ATKEY_AR = Context.AR.FindByARKEY(ATKEY);
                }

                return Cache_ATKEY_AR;
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entity by [CRF.INVOICEGST]-&gt;[KGST.KGSTKEY]
        /// Used in Reverse Payments to obtain the invoice GST type.
        /// </summary>
        public KGST INVOICEGST_KGST
        {
            get
            {
                if (INVOICEGST == null)
                {
                    return null;
                }
                if (Cache_INVOICEGST_KGST == null)
                {
                    Cache_INVOICEGST_KGST = Context.KGST.FindByKGSTKEY(INVOICEGST);
                }

                return Cache_INVOICEGST_KGST;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [CRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every transaction there is a subprogram
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
        /// KGLINIT (General Ledger Initiatives) related entity by [CRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Transaction might belong to an Initiative
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

        #endregion

    }
}
