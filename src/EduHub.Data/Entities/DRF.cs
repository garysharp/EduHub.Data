using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// DR Transactions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRF : EduHubEntity
    {

        #region Navigation Property Cache

        private DR Cache_CODE_DR;
        private QB Cache_TRBATCH_QB;
        private KGST Cache_GST_TYPE_KGST;
        private KAB Cache_BSB_KAB;
        private SDFC Cache_FEE_CODE_SDFC;
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
        /// Allocated transaction
        /// </summary>
        public int? ALLOCTID { get; internal set; }

        /// <summary>
        /// DR KEY
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// BATCH NUMBER
        /// </summary>
        public int? TRBATCH { get; internal set; }

        /// <summary>
        /// DR PERIOD NUMBER eg 199802
        /// </summary>
        public int? TRPERD { get; internal set; }

        /// <summary>
        /// Transaction type
        ///  I = Invoice
        ///  C = Credit Note
        ///  J = Journal
        ///  R = Receipt
        ///  P = Payment (Unusual)
        /// [Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }

        /// <summary>
        /// TRANS DATE
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// TRANS REF (Invoice NUMBER)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }

        /// <summary>
        /// Ledger type GL or JO
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }

        /// <summary>
        /// Account code either GL or JO
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRXCODE { get; internal set; }

        /// <summary>
        /// Unit Cost
        /// </summary>
        public decimal? TRCOST { get; internal set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public double? TRQTY { get; internal set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal? TRAMT { get; internal set; }

        /// <summary>
        /// Added for software compatibility
        /// see GL Receipts
        /// </summary>
        public decimal? TRNETT { get; internal set; }

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
        /// GST Dollar amount for this transaction
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }

        /// <summary>
        /// Gross amount which includes GST
        /// </summary>
        public decimal? TRGROSS { get; internal set; }

        /// <summary>
        /// what rate was the GST apllied
        /// </summary>
        public double? GST_RATE { get; internal set; }

        /// <summary>
        /// WHAT TYPE OF GST
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GST_TYPE { get; internal set; }

        /// <summary>
        /// IS THIS BEING CLAIMED
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }

        /// <summary>
        /// S, PO, PC INDICATES TYPE OF PURCHASE OR SALE
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string GST_SALE_PURCH { get; internal set; }

        /// <summary>
        /// Amount of Withholding TAX for this invoice line
        /// </summary>
        public decimal? WITHHOLD_AMOUNT { get; internal set; }

        /// <summary>
        /// Required for GL payments with withheld amounts
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string WITHHOLD_TYPE { get; internal set; }

        /// <summary>
        /// AMOUNT PAID SO FAR
        /// </summary>
        public decimal? TRPAID { get; internal set; }

        /// <summary>
        /// TRANS DESCRIPTION
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// Invoice ALLOCATED TO CREDITS
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRINV { get; internal set; }

        /// <summary>
        /// DELETE INDICATOR
        /// </summary>
        public short? TRDELETE { get; internal set; }

        /// <summary>
        /// Commission rate this line
        /// </summary>
        public double? TRRATE { get; internal set; }

        /// <summary>
        /// Cost price of item
        /// </summary>
        public decimal? COSTPRICE { get; internal set; }

        /// <summary>
        /// Amount commission paid
        /// </summary>
        public decimal? COMMPAID { get; internal set; }

        /// <summary>
        /// Date commission paid
        /// </summary>
        public DateTime? COMMDATE { get; internal set; }

        /// <summary>
        /// Bank account for multiple
        /// bank accounts
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRBANK { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RTYPE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (30)]
        /// </summary>
        public string DRAWER { get; internal set; }

        /// <summary>
        /// Cheque BSB number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }

        /// <summary>
        /// Receipt details
        /// [Alphanumeric (20)]
        /// </summary>
        public string BANK { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (20)]
        /// </summary>
        public string BRANCH { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }

        /// <summary>
        /// Master transaction ID (Internal)
        /// </summary>
        public int? MASTERTID { get; internal set; }

        /// <summary>
        /// Line number in the batch
        /// </summary>
        public int? LINE_NO { get; internal set; }

        /// <summary>
        /// Determines through posts
        /// 0 = Don't show T/P
        /// </summary>
        public int? FLAG { get; internal set; }

        /// <summary>
        /// Fee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE { get; internal set; }

        /// <summary>
        /// As above
        /// [Alphanumeric (30)]
        /// </summary>
        public string FEE_DESCRIPTION { get; internal set; }

        /// <summary>
        /// Include transaction on Statements
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STATEMENT_PRINT { get; internal set; }

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
        /// For journals only
        /// </summary>
        public decimal? DEBIT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? CREDIT { get; internal set; }

        /// <summary>
        /// For Payments
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }

        /// <summary>
        /// Only filled in for cancelled payment/receipt
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string CANCELLED { get; internal set; }

        /// <summary>
        /// Has online receipt been printed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RECEIPT_PRINTED { get; internal set; }

        /// <summary>
        /// Seed number for BPAY reference
        /// </summary>
        public int? BPAY_SEQUENCE { get; internal set; }

        /// <summary>
        /// BPAY Reference number with check digit
        /// [Alphanumeric (20)]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }

        /// <summary>
        /// Unique reference number for this Bpay transaction
        /// [Alphanumeric (21)]
        /// </summary>
        public string REFERENCE_NO { get; internal set; }

        /// <summary>
        /// Transaction method
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRMETHOD { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last user name
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// DR (Accounts Receivable) related entity by [DRF.CODE]-&gt;[DR.DRKEY]
        /// DR KEY
        /// </summary>
        public DR CODE_DR
        {
            get
            {
                if (Cache_CODE_DR == null)
                {
                    Cache_CODE_DR = Context.DR.FindByDRKEY(CODE);
                }

                return Cache_CODE_DR;
            }
        }

        /// <summary>
        /// QB (Batch Headers) related entity by [DRF.TRBATCH]-&gt;[QB.QBKEY]
        /// BATCH NUMBER
        /// </summary>
        public QB TRBATCH_QB
        {
            get
            {
                if (TRBATCH == null)
                {
                    return null;
                }
                if (Cache_TRBATCH_QB == null)
                {
                    Cache_TRBATCH_QB = Context.QB.FindByQBKEY(TRBATCH.Value);
                }

                return Cache_TRBATCH_QB;
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entity by [DRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// WHAT TYPE OF GST
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
        /// KAB (BSB Numbers) related entity by [DRF.BSB]-&gt;[KAB.BSB]
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
        /// SDFC (Sundry Debtor Fees) related entity by [DRF.FEE_CODE]-&gt;[SDFC.SDFCKEY]
        /// Fee code
        /// </summary>
        public SDFC FEE_CODE_SDFC
        {
            get
            {
                if (FEE_CODE == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_SDFC == null)
                {
                    Cache_FEE_CODE_SDFC = Context.SDFC.FindBySDFCKEY(FEE_CODE);
                }

                return Cache_FEE_CODE_SDFC;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [DRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
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
        /// KGLINIT (General Ledger Initiatives) related entity by [DRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
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
