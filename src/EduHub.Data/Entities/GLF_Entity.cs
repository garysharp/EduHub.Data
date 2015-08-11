using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Transactions
    /// </summary>
    public class GLF_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// General Ledger Code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [GL_Entity].[CODE]
        /// General Ledger Code
        /// </summary>
        public GL_Entity CODE_GL { get { return CODE == null ? null : Context.GL.FindByCODE(CODE); } }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// GL period number eg 199208 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction type
        /// J - Journal
        /// R - Receipt
        /// P - Payment [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Transaction quantity [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRQTY { get; internal set; }
        /// <summary>
        /// Transaction date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Transaction reference [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Transaction amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Transaction description [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Source Ledger type
        /// eg. DF, IV, AR, CR, DM [Uppercase Alphanumeric: u2]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// Post code for through posting to subledgers [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// TRTYPE for through posting to subledgers [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRXTRTYPE { get; internal set; }
        /// <summary>
        /// DR/CR short/key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRSHORT { get; internal set; }
        /// <summary>
        /// Bank account for multiple bank
        /// accounts [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRBANK { get; internal set; }
        /// <summary>
        /// Bank reconciliation flag
        /// Y - reconciled
        /// N - not yet reconciled [Alphanumeric: a1]
        /// </summary>
        public string RECONCILE { get; internal set; }
        /// <summary>
        /// Transaction is flagged as reconcile pending [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RECONCILE_FLAGGED { get; internal set; }
        /// <summary>
        /// Date that the transaction was reconciled [Date Time nullable: d]
        /// </summary>
        public DateTime? RECONCILE_DATE { get; internal set; }
        /// <summary>
        /// User that reconciled the transaction [Uppercase Alphanumeric: u128]
        /// </summary>
        public string RECONCILE_USER { get; internal set; }
        /// <summary>
        /// The date of the bank statement that the transaction appeared in [Date Time nullable: d]
        /// </summary>
        public DateTime? RECONCILE_STATEMENT { get; internal set; }
        /// <summary>
        /// "Y" - print cheque [Alphanumeric: a1]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }
        /// <summary>
        /// Cheque number [Alphanumeric: a10]
        /// </summary>
        public string CHEQUE_NO { get; internal set; }
        /// <summary>
        /// Payee for cheques [Alphanumeric: a30]
        /// </summary>
        public string PAYEE { get; internal set; }
        /// <summary>
        /// Payee address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Payee address [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// OLDNAME=CRF_TID * Creditor transaction's
        /// TID No [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CHQ_TID { get; internal set; }
        /// <summary>
        /// Where does this appear in the BAS [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GST_BOX { get; internal set; }
        /// <summary>
        /// What Period was this Reported [Integer (32bit signed nullable): l]
        /// </summary>
        public int? GST_PERD { get; internal set; }
        /// <summary>
        /// GST Dollar amount for this
        /// transaction [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Added for software compatibility
        /// see GL Receipts [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Gross amount which includes GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
        /// <summary>
        /// what rate was the GST apllied [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// What type of GST [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// What type of GST
        /// </summary>
        public KGST_Entity GST_TYPE_KGST { get { return GST_TYPE == null ? null : Context.KGST.FindByKGSTKEY(GST_TYPE); } }
        /// <summary>
        /// Is this being claimed? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// S, PO, PC indicates type of
        /// purchase or sale [Uppercase Alphanumeric: u2]
        /// </summary>
        public string GST_SALE_PURCH { get; internal set; }
        /// <summary>
        /// Source transaction that produced
        /// this though post [Integer (32bit signed nullable): l]
        /// </summary>
        public int? SOURCE_TID { get; internal set; }
        /// <summary>
        /// Amount of Withholding TAX for this
        /// invoice line [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? WITHHOLD_AMOUNT { get; internal set; }
        /// <summary>
        /// Required for GL payments with
        /// withheld amounts [Uppercase Alphanumeric: u4]
        /// </summary>
        public string WITHHOLD_TYPE { get; internal set; }
        /// <summary>
        /// Withhold Rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? WITHHOLD_RATE { get; internal set; }
        /// <summary>
        /// Was this transaction remitted by
        /// the EOY [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EOY_KEPT { get; internal set; }
        /// <summary>
        /// Drawer [Alphanumeric: a20]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Cheque BSB number [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Navigation property for [BSB] => [KAB_Entity].[BSB]
        /// Cheque BSB number
        /// </summary>
        public KAB_Entity BSB_KAB { get { return BSB == null ? null : Context.KAB.FindByBSB(BSB); } }
        /// <summary>
        /// Bank [Alphanumeric: a20]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Branch [Alphanumeric: a20]
        /// </summary>
        public string BRANCH { get; internal set; }
        /// <summary>
        /// Account number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }
        /// <summary>
        /// Receipt type [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RTYPE { get; internal set; }
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
        /// Mandatory field [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DEBIT_TOTAL { get; internal set; }
        /// <summary>
        /// Mandatory field
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CREDIT_TOTAL { get; internal set; }
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
        /// Navigation property for [GLPROGRAM] => [KGLPROG_Entity].[GLPROGRAM]
        /// A subprogram always belongs to a program
        /// </summary>
        public KGLPROG_Entity GLPROGRAM_KGLPROG { get { return GLPROGRAM == null ? null : Context.KGLPROG.FindByGLPROGRAM(GLPROGRAM); } }
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
        /// To allow journals processing [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DEBIT { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CREDIT { get; internal set; }
        /// <summary>
        /// Only filled in for cancelled payment/receipt [Uppercase Alphanumeric: u3]
        /// </summary>
        public string CANCELLED { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
