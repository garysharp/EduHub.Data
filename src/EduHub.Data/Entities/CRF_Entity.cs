using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Financial Transaction
    /// </summary>
    public class CRF_Entity : EntityBase
    {
        /// <summary>
        /// System transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Transaction ID of original order
        /// transaction [Integer (32bit signed nullable): l]
        /// </summary>
        public int? OTID { get; internal set; }
        /// <summary>
        /// Creditor key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [CR_Entity].[CRKEY]
        /// Creditor key
        /// </summary>
        public CR_Entity CODE_CR { get { return CODE == null ? null : Context.CR.FindByCRKEY(CODE); } }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Creditor ledger period number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction type.
        /// Must be one of the following:
        /// I - Invoice
        /// C - Credit Note
        /// J - Journal
        /// R - Receipt
        /// P - Payment
        /// O - Order
        /// D - Delivery [Alphanumeric: a1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Transaction date
        /// Trtype = O: Order date
        /// Trtype = D: Delivery date
        /// Trtype = I: Invoice date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Transaction reference
        /// Trtype = 0: Order number [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Ledger type GL or IV [Uppercase Alphanumeric: u2]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// GL code or IV code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// TRTYPE for through posting to subledgers [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRXTRTYPE { get; internal set; }
        /// <summary>
        /// Transaction unit cost
        /// Trtype = O: Order unit cost
        /// Trtype = D: Order price
        /// Trtype = I: Invoice unit cost [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRCOST { get; internal set; }
        /// <summary>
        /// Transaction quantity
        /// Trtype = O: Total qty ordered
        /// Trtype = D: Qty delvd on this line
        /// Trtype = I: Qty invcd on this line [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRQTY { get; internal set; }
        /// <summary>
        /// Quantity delivered - order line [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRQTYD { get; internal set; }
        /// <summary>
        /// Quantity invoiced - order line [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRQTYI { get; internal set; }
        /// <summary>
        /// Quantity cancelled - delivery line [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRQTYDX { get; internal set; }
        /// <summary>
        /// Quantity over invoiced-invoice line [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRQTYIX { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AUTODELIVER { get; internal set; }
        /// <summary>
        /// Transaction amount (extension) [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Transaction amount used in Journals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DEBIT { get; internal set; }
        /// <summary>
        /// Transaction amount used in Journals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CREDIT { get; internal set; }
        /// <summary>
        /// Amount paid to date
        /// or amount allocated (credits) [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRPAID { get; internal set; }
        /// <summary>
        /// Invoice allocated to (credits)
        /// Trtype = I: Invoice ref number [Alphanumeric: a10]
        /// </summary>
        public string TRINV { get; internal set; }
        /// <summary>
        /// Delete indicator (CREDITS) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRDELETE { get; internal set; }
        /// <summary>
        /// Transaction description [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Transaction hold or pay flag [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRHOLD { get; internal set; }
        /// <summary>
        /// Order number being satisfied
        ///  [Alphanumeric: a10]
        /// </summary>
        public string TRORDER { get; internal set; }
        /// <summary>
        /// Bank account in the GL [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRBANK { get; internal set; }
        /// <summary>
        /// Actual cheque number (written back)
        ///  [Alphanumeric: a10]
        /// </summary>
        public string CHQ_NO { get; internal set; }
        /// <summary>
        /// Authorising person [Uppercase Alphanumeric: u5]
        /// </summary>
        public string ORDER_BY { get; internal set; }
        /// <summary>
        /// Order completed (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string COMPLETED { get; internal set; }
        /// <summary>
        /// Order unit [Alphanumeric: a10]
        /// </summary>
        public string TRUNIT { get; internal set; }
        /// <summary>
        /// Requisition date
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? REQ_DATE { get; internal set; }
        /// <summary>
        /// Supplier catalogue [Alphanumeric: a15]
        /// </summary>
        public string CATALOGUE { get; internal set; }
        /// <summary>
        /// Delivery instructions [Alphanumeric: a30]
        /// </summary>
        public string DELIVERY { get; internal set; }
        /// <summary>
        /// Flag whether a cheque requires to
        /// be printed
        /// 'Y' - Print cheque [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }
        /// <summary>
        /// Sales tax indicator [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TAX { get; internal set; }
        /// <summary>
        /// Amount before GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Equals TRAMT,added for
        /// compatibility with mixed batches [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
        /// <summary>
        /// Amount of GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Relate to KGST [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// Relate to KGST
        /// </summary>
        public KGST_Entity GST_TYPE_KGST { get { return GST_TYPE == null ? null : Context.KGST.FindByKGSTKEY(GST_TYPE); } }
        /// <summary>
        /// Rate of GST [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// is the user reclaiming this [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// Amount of Withholding TAX for this
        /// invoice line [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? WITHHOLD_AMOUNT { get; internal set; }
        /// <summary>
        /// Actual date of invoice [Date Time nullable: d]
        /// </summary>
        public DateTime? INV_DATE { get; internal set; }
        /// <summary>
        /// Due date for payment
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? DUE_DATE { get; internal set; }
        /// <summary>
        /// Receipt type for Bank deposit
        /// information [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RTYPE { get; internal set; }
        /// <summary>
        /// for Receipts [Alphanumeric: a20]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// BSB number of cheque [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Navigation property for [BSB] => [KAB_Entity].[BSB]
        /// BSB number of cheque
        /// </summary>
        public KAB_Entity BSB_KAB { get { return BSB == null ? null : Context.KAB.FindByBSB(BSB); } }
        /// <summary>
        /// Bank of cheque [Alphanumeric: a20]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Bank Branch of cheque [Alphanumeric: a20]
        /// </summary>
        public string BRANCH { get; internal set; }
        /// <summary>
        /// Account number of cheque [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }
        /// <summary>
        /// Expected delivery date [Date Time nullable: d]
        /// </summary>
        public DateTime? EXPECTED_DATE { get; internal set; }
        /// <summary>
        /// Delivery address code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DEL_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [DEL_CODE] => [KAD_Entity].[KADKEY]
        /// Delivery address code
        /// </summary>
        public KAD_Entity DEL_CODE_KAD { get { return DEL_CODE == null ? null : Context.KAD.FindByKADKEY(DEL_CODE); } }
        /// <summary>
        /// Delivery docket number
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DEL_DOCKET_NO { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string ATKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [ATKEY] => [AR_Entity].[ARKEY]
        /// 
        /// </summary>
        public AR_Entity ATKEY_AR { get { return ATKEY == null ? null : Context.AR.FindByARKEY(ATKEY); } }
        /// <summary>
        /// Y/N field used in creditors asset invoice [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TINCLUDE { get; internal set; }
        /// <summary>
        /// Posting to TDep: Cost ex GST
        /// Also used for the cost base for depreciation [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTRNETT { get; internal set; }
        /// <summary>
        /// Tax value of Asset transaction [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTRAMT { get; internal set; }
        /// <summary>
        /// Amount of GST for tax transactions, Posted to tax ORIG_GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TGST_AMOUNT { get; internal set; }
        /// <summary>
        /// Memo field for asset repairs [Memo: m]
        /// </summary>
        public string AMEMO { get; internal set; }
        /// <summary>
        /// Copy Amemo field to Asset? Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AMEMO_COPY { get; internal set; }
        /// <summary>
        /// Date for next service for asset repairs [Date Time nullable: d]
        /// </summary>
        public DateTime? NEXT_SVC_DATE { get; internal set; }
        /// <summary>
        /// Master transaction ID (Internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MASTERTID { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ALLOCTID { get; internal set; }
        /// <summary>
        /// Direct Deposit or Cheque [Uppercase Alphanumeric: u2]
        /// </summary>
        public string PAY_METHOD { get; internal set; }
        /// <summary>
        /// Withhold Rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? WITHHOLD_RATE { get; internal set; }
        /// <summary>
        /// The number of months deleteable
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRDEL_MONTHS { get; internal set; }
        /// <summary>
        /// Line number in the batch [Integer (32bit signed nullable): l]
        /// </summary>
        public int? LINE_NO { get; internal set; }
        /// <summary>
        /// Determines through posts
        /// 0 = Don't show T/P
        /// 1 = Show T/P [Integer (32bit signed nullable): l]
        /// </summary>
        public int? FLAG { get; internal set; }
        /// <summary>
        /// Used in Reverse Payments to obtain the invoice GST type. [Uppercase Alphanumeric: u4]
        /// </summary>
        public string INVOICEGST { get; internal set; }
        /// <summary>
        /// Navigation property for [INVOICEGST] => [KGST_Entity].[KGSTKEY]
        /// Used in Reverse Payments to obtain the invoice GST type.
        /// </summary>
        public KGST_Entity INVOICEGST_KGST { get { return INVOICEGST == null ? null : Context.KGST.FindByKGSTKEY(INVOICEGST); } }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB { get { return SUBPROGRAM == null ? null : Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM); } }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT { get { return INITIATIVE == null ? null : Context.KGLINIT.FindByINITIATIVE(INITIATIVE); } }
        /// <summary>
        /// Only filled in for cancelled payment/receipt [Uppercase Alphanumeric: u3]
        /// </summary>
        public string CANCELLED { get; internal set; }
        /// <summary>
        /// is this order line from PRMS [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PRMS_TID { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
