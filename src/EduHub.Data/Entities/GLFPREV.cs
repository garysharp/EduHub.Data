using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Last Years GL Financial Trans
    /// </summary>
    public class GLFPREV : EntityBase
    {
#region Navigation Property Cache
        private GLPREV _CODE_GLPREV;
        private KGST _GST_TYPE_KGST;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLPROG _GLPROGRAM_KGLPROG;
        private KGLINIT _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// General Ledger Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// GX period number eg. 199208
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction type
        /// J - Journal
        /// R - Receipt
        /// P - Payment
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Transaction quantity
        /// </summary>
        public int? TRQTY { get; internal set; }
        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Transaction reference
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Transaction description
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Ledger type eg DF, IV, AR, CR, DM
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// Post code for through posting to subledgers
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// TRTYPE for through posting to subledgers
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRXTRTYPE { get; internal set; }
        /// <summary>
        /// DR/CR short/key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRSHORT { get; internal set; }
        /// <summary>
        /// Not used in JX leave for
        /// compatibility
        /// Bank account for multiple bank
        /// accounts
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRBANK { get; internal set; }
        /// <summary>
        /// Bank reconciliation flag
        /// Y - reconciled
        /// N - not yet reconciled
        /// Not used for RX set leave for
        /// compatibility
        /// [Alphanumeric (1)]
        /// </summary>
        public string RECONCILE { get; internal set; }
        /// <summary>
        /// Transaction is flagged as reconcile pending
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RECONCILE_FLAGGED { get; internal set; }
        /// <summary>
        /// Date that the transaction was reconciled
        /// </summary>
        public DateTime? RECONCILE_DATE { get; internal set; }
        /// <summary>
        /// User that reconciled the transaction
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string RECONCILE_USER { get; internal set; }
        /// <summary>
        /// The date of the bank statement that the transaction appeared in
        /// </summary>
        public DateTime? RECONCILE_STATEMENT { get; internal set; }
        /// <summary>
        /// "Y" - print cheque
        /// [Alphanumeric (1)]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }
        /// <summary>
        /// Cheque number
        /// [Alphanumeric (10)]
        /// </summary>
        public string CHEQUE_NO { get; internal set; }
        /// <summary>
        /// Payee for cheques
        /// [Alphanumeric (30)]
        /// </summary>
        public string PAYEE { get; internal set; }
        /// <summary>
        /// Payee address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Payee address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Creditor transaction's TID No
        /// </summary>
        public int? CHQ_TID { get; internal set; }
        /// <summary>
        /// where does this appear in the BAS
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GST_BOX { get; internal set; }
        /// <summary>
        /// what Period was this Reported
        /// </summary>
        public int? GST_PERD { get; internal set; }
        /// <summary>
        /// GST Dollar amount for this
        /// transaction
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Added for software compatibilty
        /// See gl receipts
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Gross amount which includes GST
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
        /// <summary>
        /// what rate was the GST apllied
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// What type of GST
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// Is this being claimed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// S, PO, PC indicates type of
        /// purchase or sale
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string GST_SALE_PURCH { get; internal set; }
        /// <summary>
        /// Source tid from creditors or GL
        /// </summary>
        public int? SOURCE_TID { get; internal set; }
        /// <summary>
        /// Amount of Withholding TAX for this
        /// invoice line
        /// </summary>
        public decimal? WITHHOLD_AMOUNT { get; internal set; }
        /// <summary>
        /// Required for GL payments with
        /// withheld amounts
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string WITHHOLD_TYPE { get; internal set; }
        /// <summary>
        /// Withhold Rate
        /// </summary>
        public double? WITHHOLD_RATE { get; internal set; }
        /// <summary>
        /// Was this transaction retianed by
        /// the eoy
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EOY_KEPT { get; internal set; }
        /// <summary>
        /// Bank client
        /// [Alphanumeric (20)]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Bank/State/Branch (Cheque)
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank name
        /// [Alphanumeric (20)]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Branch location
        /// [Alphanumeric (20)]
        /// </summary>
        public string BRANCH { get; internal set; }
        /// <summary>
        /// Bank account number
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RTYPE { get; internal set; }
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
        /// Mandatory field
        /// </summary>
        public decimal? DEBIT_TOTAL { get; internal set; }
        /// <summary>
        /// Mandatory field
        /// 
        /// </summary>
        public decimal? CREDIT_TOTAL { get; internal set; }
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
        /// To allow journals processing
        /// </summary>
        public decimal? DEBIT { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CREDIT { get; internal set; }
        /// <summary>
        /// Only filled in for cancelled payment/receipt
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string CANCELLED { get; internal set; }
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
        /// Navigation property for [CODE] => [GLPREV].[CODE]
        /// General Ledger Code
        /// </summary>
        public GLPREV CODE_GLPREV {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_GLPREV == null)
                    {
                        _CODE_GLPREV = Context.GLPREV.FindByCODE(CODE);
                    }
                    return _CODE_GLPREV;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GST_TYPE] => [KGST].[KGSTKEY]
        /// What type of GST
        /// </summary>
        public KGST GST_TYPE_KGST {
            get
            {
                if (GST_TYPE != null)
                {
                    if (_GST_TYPE_KGST == null)
                    {
                        _GST_TYPE_KGST = Context.KGST.FindByKGSTKEY(GST_TYPE);
                    }
                    return _GST_TYPE_KGST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB {
            get
            {
                if (SUBPROGRAM != null)
                {
                    if (_SUBPROGRAM_KGLSUB == null)
                    {
                        _SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                    }
                    return _SUBPROGRAM_KGLSUB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GLPROGRAM] => [KGLPROG].[GLPROGRAM]
        /// A subprogram always belongs to a program
        /// </summary>
        public KGLPROG GLPROGRAM_KGLPROG {
            get
            {
                if (GLPROGRAM != null)
                {
                    if (_GLPROGRAM_KGLPROG == null)
                    {
                        _GLPROGRAM_KGLPROG = Context.KGLPROG.FindByGLPROGRAM(GLPROGRAM);
                    }
                    return _GLPROGRAM_KGLPROG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT {
            get
            {
                if (INITIATIVE != null)
                {
                    if (_INITIATIVE_KGLINIT == null)
                    {
                        _INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                    }
                    return _INITIATIVE_KGLINIT;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
