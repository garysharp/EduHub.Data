using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Financial Transactions
    /// </summary>
    public partial class DFF : EntityBase
    {
#region Navigation Property Cache
        private DF _CODE_DF;
        private ST _TRSTUD_ST;
        private ST _STUDENT_ST;
        private KGST _GST_TYPE_KGST;
        private KAB _BSB_KAB;
        private SA _FEE_CODE_SA;
        private SU _SUBJECT_SU;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLINIT _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Family key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Student key - only used for split billing
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRSTUD { get; internal set; }
        /// <summary>
        /// Student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// BPAY reference number
        /// [Alphanumeric (20)]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Unique reference number for this Bpay transaction
        /// [Alphanumeric (21)]
        /// </summary>
        public string REFERENCE_NO { get; internal set; }
        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Family ledger period number
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction type
        /// I - Invoice
        /// C - Credit Note
        /// J - Journal
        /// R - Receipts
        /// P - Payments
        /// [Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }
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
        /// Ledger type GL,IV
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// GL or IV code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// Transaction unit cost
        /// </summary>
        public decimal? TRCOST { get; internal set; }
        /// <summary>
        /// Transaction quantity
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Transaction value
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Amount paid to date...
        /// or allocated
        /// </summary>
        public decimal? TRPAID { get; internal set; }
        /// <summary>
        /// Invoice allocated to
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRINV { get; internal set; }
        /// <summary>
        /// Delete indicator
        /// </summary>
        public short? TRDELETE { get; internal set; }
        /// <summary>
        /// Transaction description
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Used to specify how many months since transaction was fully allocated and
        /// to determine if transaction is ready to be deleted at EOY
        /// </summary>
        public short? TRDEL_MONTHS { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PERCENTAGE { get; internal set; }
        /// <summary>
        /// Bank account for multiple
        /// bank accounts
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRBANK { get; internal set; }
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
        /// for adjustment notes - date of
        /// original invoice
        /// </summary>
        public DateTime? ORIG_DATE { get; internal set; }
        /// <summary>
        /// For adjustment notes - amount of
        /// original invoice
        /// </summary>
        public decimal? ORIG_GROSS { get; internal set; }
        /// <summary>
        /// Bank drawer
        /// [Alphanumeric (30)]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Cheque BSB number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank description
        /// [Alphanumeric (20)]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Bank branch
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
        /// Split code for the transaction
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SPLIT_ITEM { get; internal set; }
        /// <summary>
        /// Fee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE { get; internal set; }
        /// <summary>
        /// Transaction method
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRMETHOD { get; internal set; }
        /// <summary>
        /// Master transaction ID (Internal)
        /// </summary>
        public int? MASTERTID { get; internal set; }
        /// <summary>
        /// Allocation Transaction ID
        /// </summary>
        public int? ALLOCTID { get; internal set; }
        /// <summary>
        /// Subject with fee (levy)
        /// 
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT { get; internal set; }
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
        /// Is this a voluntary or compulsory charge
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VOLUNTARY { get; internal set; }
        /// <summary>
        /// Need to identify if this is CSEF receipt
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMA_RECEIPT { get; internal set; }
        /// <summary>
        /// Period the CSEF receipts applies for
        /// </summary>
        public short? EMA_PERIOD { get; internal set; }
        /// <summary>
        /// Filled whe processing to allow update of
        /// delete flag on KEMA when only GL receipt
        /// </summary>
        public int? EMA_TID { get; internal set; }
        /// <summary>
        /// Is set when journal for CSEF receipts is done
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GL_PROCESSED { get; internal set; }
        /// <summary>
        /// For payments
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }
        /// <summary>
        /// Has online receipt been printed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RECEIPT_PRINTED { get; internal set; }
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
        /// Include transaction on Statements
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STATEMENT_PRINT { get; internal set; }
        /// <summary>
        /// AEGIS 4375 For dipslay in allocations screen
        /// [Alphanumeric (30)]
        /// </summary>
        public string ST_SURNAME { get; internal set; }
        /// <summary>
        /// As above
        /// [Alphanumeric (20)]
        /// </summary>
        public string ST_FIRSTNAME { get; internal set; }
        /// <summary>
        /// As above
        /// [Alphanumeric (30)]
        /// </summary>
        public string FEE_DESCRIPTION { get; internal set; }
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
        /// DF (Families) related entity by [DFF.CODE]-&gt;[DF.DFKEY]
        /// Family key
        /// </summary>
        public DF CODE_DF
        {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_DF == null)
                    {
                        _CODE_DF = Context.DF.FindByDFKEY(CODE);
                    }
                    return _CODE_DF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// ST (Students) related entity by [DFF.TRSTUD]-&gt;[ST.STKEY]
        /// Student key - only used for split billing
        /// </summary>
        public ST TRSTUD_ST
        {
            get
            {
                if (TRSTUD != null)
                {
                    if (_TRSTUD_ST == null)
                    {
                        _TRSTUD_ST = Context.ST.FindBySTKEY(TRSTUD);
                    }
                    return _TRSTUD_ST;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// ST (Students) related entity by [DFF.STUDENT]-&gt;[ST.STKEY]
        /// Student key
        /// </summary>
        public ST STUDENT_ST
        {
            get
            {
                if (STUDENT != null)
                {
                    if (_STUDENT_ST == null)
                    {
                        _STUDENT_ST = Context.ST.FindBySTKEY(STUDENT);
                    }
                    return _STUDENT_ST;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entity by [DFF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// Relate to KGST
        /// </summary>
        public KGST GST_TYPE_KGST
        {
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
        /// KAB (BSB Numbers) related entity by [DFF.BSB]-&gt;[KAB.BSB]
        /// Cheque BSB number
        /// </summary>
        public KAB BSB_KAB
        {
            get
            {
                if (BSB != null)
                {
                    if (_BSB_KAB == null)
                    {
                        _BSB_KAB = Context.KAB.FindByBSB(BSB);
                    }
                    return _BSB_KAB;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SA (Fees) related entity by [DFF.FEE_CODE]-&gt;[SA.SAKEY]
        /// Fee code
        /// </summary>
        public SA FEE_CODE_SA
        {
            get
            {
                if (FEE_CODE != null)
                {
                    if (_FEE_CODE_SA == null)
                    {
                        _FEE_CODE_SA = Context.SA.FindBySAKEY(FEE_CODE);
                    }
                    return _FEE_CODE_SA;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [DFF.SUBJECT]-&gt;[SU.SUKEY]
        /// Subject with fee (levy)
        /// 
        /// </summary>
        public SU SUBJECT_SU
        {
            get
            {
                if (SUBJECT != null)
                {
                    if (_SUBJECT_SU == null)
                    {
                        _SUBJECT_SU = Context.SU.FindBySUKEY(SUBJECT);
                    }
                    return _SUBJECT_SU;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [DFF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
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
        /// KGLINIT (General Ledger Initiatives) related entity by [DFF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
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
