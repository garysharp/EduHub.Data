using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Last Years GL Combined Financial Trans
    /// </summary>
    public class GLCFPREV_Entity : EntityBase
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
        /// Navigation property for [CODE] => [GLPREV_Entity].[CODE]
        /// General Ledger Code
        /// </summary>
        public GLPREV_Entity CODE_GLPREV { get { return CODE == null ? null : Context.GLPREV.FindByCODE(CODE); } }
        /// <summary>
        /// Optional Family Code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Student key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRSTUD { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// GX period number eg. 199208 [Integer (32bit signed nullable): l]
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
        /// Transaction unit cost [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRCOST { get; internal set; }
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
        /// Ledger type eg DF, IV, AR, CR, DM [Uppercase Alphanumeric: u2]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// receipt Option, Shortcut, ledger *  for acquisitions of stock or assets
        ///  [Uppercase Alphanumeric: u2]
        /// </summary>
        public string POST_OPTION { get; internal set; }
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
        /// Not used in JX leave for
        /// compatibility
        /// Bank account for multiple bank
        /// accounts [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRBANK { get; internal set; }
        /// <summary>
        /// Bank reconciliation flag
        /// Y - reconciled
        /// N - not yet reconciled
        /// Not used for RX set leave for
        /// compatibility [Alphanumeric: a1]
        /// </summary>
        public string RECONCILE { get; internal set; }
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
        /// Creditor transaction's TID No [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CHQ_TID { get; internal set; }
        /// <summary>
        /// where does this appear in the BAS [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GST_BOX { get; internal set; }
        /// <summary>
        /// what Period was this Reported [Integer (32bit signed nullable): l]
        /// </summary>
        public int? GST_PERD { get; internal set; }
        /// <summary>
        /// GST Dollar amount for this
        /// transaction [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Added for software compatibilty
        /// See gl receipts [Currency (128bit scaled integer nullable): c]
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
        /// Is this being claimed [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// S, PO, PC indicates type of
        /// purchase or sale [Uppercase Alphanumeric: u2]
        /// </summary>
        public string GST_SALE_PURCH { get; internal set; }
        /// <summary>
        /// Source tid from creditors or GL [Integer (32bit signed nullable): l]
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
        /// Was this transaction retianed by
        /// the eoy [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EOY_KEPT { get; internal set; }
        /// <summary>
        /// Bank client [Alphanumeric: a20]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Bank/State/Branch (Cheque) [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank name [Alphanumeric: a20]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Branch location [Alphanumeric: a20]
        /// </summary>
        public string BRANCH { get; internal set; }
        /// <summary>
        /// Bank account number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RTYPE { get; internal set; }
        /// <summary>
        /// Appeal fund [Uppercase Alphanumeric: u10]
        /// </summary>
        public string APPEAL { get; internal set; }
        /// <summary>
        /// Event Key [Uppercase Alphanumeric: u4]
        /// </summary>
        public string EVENT { get; internal set; }
        /// <summary>
        /// Fundraising Receipt type
        /// G - Gift
        /// P - Pledge
        /// B - Bequest
        /// F - Function/Event [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FRTYPE { get; internal set; }
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
        /// Date for next service for asset repairs
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? NEXT_SVC_DATE { get; internal set; }
        /// <summary>
        /// Mandatory field [Integer (32bit signed nullable): l]
        /// </summary>
        public int? LINE_NO { get; internal set; }
        /// <summary>
        /// Mandatory field [Integer (32bit signed nullable): l]
        /// </summary>
        public int? FLAG { get; internal set; }
        /// <summary>
        /// Mandatory field [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DEBIT_TOTAL { get; internal set; }
        /// <summary>
        /// Mandatory field [Currency (128bit scaled integer nullable): c]
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
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT { get { return INITIATIVE == null ? null : Context.KGLINIT.FindByINITIATIVE(INITIATIVE); } }
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
