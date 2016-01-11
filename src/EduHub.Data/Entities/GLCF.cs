using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GL Combined Financial Trans
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLCF : EduHubEntity
    {

        #region Navigation Property Cache

        private GL Cache_CODE_GL;
        private KGST Cache_GST_TYPE_KGST;
        private KAB Cache_BSB_KAB;
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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// General Ledger Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// General Ledger Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FAMILY { get; internal set; }

        /// <summary>
        /// Student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRSTUD { get; internal set; }

        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }

        /// <summary>
        /// GL period number eg 199208
        /// </summary>
        public int? TRPERD { get; internal set; }

        /// <summary>
        /// Transaction type
        ///  J - Journal
        ///  R - Receipt
        ///  P - Payment
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }

        /// <summary>
        /// Transaction quantity
        /// </summary>
        public int? TRQTY { get; internal set; }

        /// <summary>
        /// Transaction unit cost
        /// </summary>
        public decimal? TRCOST { get; internal set; }

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
        /// Source Ledger type
        /// eg. DF, IV, AR, CR, DM
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }

        /// <summary>
        /// receipt Option, Shortcut, ledger    *  for acquisitions of stock or assets
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string POST_OPTION { get; internal set; }

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
        /// Bank account for multiple bank
        /// accounts
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRBANK { get; internal set; }

        /// <summary>
        /// Bank reconciliation flag
        ///   Y - reconciled
        ///   N - not yet reconciled
        /// [Alphanumeric (1)]
        /// </summary>
        public string RECONCILE { get; internal set; }

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
        /// OLDNAME=CRF_TID * Creditor transaction's
        /// TID No
        /// </summary>
        public int? CHQ_TID { get; internal set; }

        /// <summary>
        /// Where does this appear in the BAS
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GST_BOX { get; internal set; }

        /// <summary>
        /// What Period was this Reported
        /// </summary>
        public int? GST_PERD { get; internal set; }

        /// <summary>
        /// GST Dollar amount for this
        /// transaction
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }

        /// <summary>
        /// Added for software compatibility
        /// see GL Receipts
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
        /// Is this being claimed?
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
        /// Source transaction that produced
        /// this though post
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
        /// Was this transaction remitted by
        /// the EOY
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EOY_KEPT { get; internal set; }

        /// <summary>
        /// Drawer
        /// [Alphanumeric (20)]
        /// </summary>
        public string DRAWER { get; internal set; }

        /// <summary>
        /// Cheque BSB number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }

        /// <summary>
        /// Bank
        /// [Alphanumeric (20)]
        /// </summary>
        public string BANK { get; internal set; }

        /// <summary>
        /// Branch
        /// [Alphanumeric (20)]
        /// </summary>
        public string BRANCH { get; internal set; }

        /// <summary>
        /// Account number
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }

        /// <summary>
        /// Receipt type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RTYPE { get; internal set; }

        /// <summary>
        /// Appeal fund
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string APPEAL { get; internal set; }

        /// <summary>
        /// Event Key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EVENT { get; internal set; }

        /// <summary>
        /// Fundraising Receipt type
        ///   G - Gift
        ///   P - Pledge
        ///   B - Bequest
        ///   F - Function/Event
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FRTYPE { get; internal set; }

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
        /// Mandatory field
        /// </summary>
        public int? LINE_NO { get; internal set; }

        /// <summary>
        /// Mandatory field
        /// </summary>
        public int? FLAG { get; internal set; }

        /// <summary>
        /// Mandatory field
        /// </summary>
        public decimal? DEBIT_TOTAL { get; internal set; }

        /// <summary>
        /// Mandatory field
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
        /// GL (General Ledger) related entity by [GLCF.CODE]-&gt;[GL.CODE]
        /// General Ledger Code
        /// </summary>
        public GL CODE_GL
        {
            get
            {
                if (Cache_CODE_GL == null)
                {
                    Cache_CODE_GL = Context.GL.FindByCODE(CODE);
                }

                return Cache_CODE_GL;
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entity by [GLCF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// What type of GST
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
        /// KAB (BSB Numbers) related entity by [GLCF.BSB]-&gt;[KAB.BSB]
        /// Cheque BSB number
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
        /// KGLSUB (General Ledger Sub Programs) related entity by [GLCF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
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
        /// KGLINIT (General Ledger Initiatives) related entity by [GLCF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
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
