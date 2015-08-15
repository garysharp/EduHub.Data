using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Financial Transactions
    /// </summary>
    public class DFF_Entity : EntityBase
    {
#region Navigation Property Cache
        private DF_Entity _CODE_DF;
        private ST_Entity _TRSTUD_ST;
        private ST_Entity _STUDENT_ST;
        private KGST_Entity _GST_TYPE_KGST;
        private KAB_Entity _BSB_KAB;
        private SA_Entity _FEE_CODE_SA;
        private SU_Entity _SUBJECT_SU;
        private KGLSUB_Entity _SUBPROGRAM_KGLSUB;
        private KGLINIT_Entity _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Family key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Student key - only used for split billing [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRSTUD { get; internal set; }
        /// <summary>
        /// Student key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// BPAY reference number [Alphanumeric: a20]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Unique reference number for this Bpay transaction [Alphanumeric: a21]
        /// </summary>
        public string REFERENCE_NO { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Family ledger period number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction type
        /// I - Invoice
        /// C - Credit Note
        /// J - Journal
        /// R - Receipts
        /// P - Payments [Alphanumeric: a1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Transaction date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Transaction reference [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Ledger type GL,IV [Uppercase Alphanumeric: u2]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// GL or IV code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// Transaction unit cost [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRCOST { get; internal set; }
        /// <summary>
        /// Transaction quantity [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Transaction value [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Amount paid to date...
        /// or allocated [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRPAID { get; internal set; }
        /// <summary>
        /// Invoice allocated to [Alphanumeric: a10]
        /// </summary>
        public string TRINV { get; internal set; }
        /// <summary>
        /// Delete indicator [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRDELETE { get; internal set; }
        /// <summary>
        /// Transaction description [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Used to specify how many months since transaction was fully allocated and
        /// to determine if transaction is ready to be deleted at EOY [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRDEL_MONTHS { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERCENTAGE { get; internal set; }
        /// <summary>
        /// Bank account for multiple
        /// bank accounts [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRBANK { get; internal set; }
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
        /// Rate of GST [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// for adjustment notes - date of
        /// original invoice [Date Time nullable: d]
        /// </summary>
        public DateTime? ORIG_DATE { get; internal set; }
        /// <summary>
        /// For adjustment notes - amount of
        /// original invoice [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ORIG_GROSS { get; internal set; }
        /// <summary>
        /// Bank drawer [Alphanumeric: a30]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Cheque BSB number [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank description [Alphanumeric: a20]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        /// Bank branch [Alphanumeric: a20]
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
        /// Split code for the transaction
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SPLIT_ITEM { get; internal set; }
        /// <summary>
        /// Fee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FEE_CODE { get; internal set; }
        /// <summary>
        /// Transaction method [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRMETHOD { get; internal set; }
        /// <summary>
        /// Master transaction ID (Internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MASTERTID { get; internal set; }
        /// <summary>
        /// Allocation Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ALLOCTID { get; internal set; }
        /// <summary>
        /// Subject with fee (levy)
        ///  [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT { get; internal set; }
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
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Is this a voluntary or compulsory charge [Uppercase Alphanumeric: u1]
        /// </summary>
        public string VOLUNTARY { get; internal set; }
        /// <summary>
        /// Need to identify if this is EMA receipt [Uppercase Alphanumeric: u1]
        /// </summary>
        public string EMA_RECEIPT { get; internal set; }
        /// <summary>
        /// Period the EMA receipts applies for [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EMA_PERIOD { get; internal set; }
        /// <summary>
        /// Filled whe processing to allow update of
        /// delete flag on KEMA when only GL receipt [Integer (32bit signed nullable): l]
        /// </summary>
        public int? EMA_TID { get; internal set; }
        /// <summary>
        /// Is set when journal for EMA receipts is done [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GL_PROCESSED { get; internal set; }
        /// <summary>
        /// For payments [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }
        /// <summary>
        /// Has online receipt been printed [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RECEIPT_PRINTED { get; internal set; }
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
        /// Include transaction on Statements [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STATEMENT_PRINT { get; internal set; }
        /// <summary>
        /// AEGIS 4375 For dipslay in allocations screen [Alphanumeric: a30]
        /// </summary>
        public string ST_SURNAME { get; internal set; }
        /// <summary>
        /// As above [Alphanumeric: a20]
        /// </summary>
        public string ST_FIRSTNAME { get; internal set; }
        /// <summary>
        /// As above [Alphanumeric: a30]
        /// </summary>
        public string FEE_DESCRIPTION { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [DF_Entity].[DFKEY]
        /// Family key
        /// </summary>
        public DF_Entity CODE_DF {
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
        /// Navigation property for [TRSTUD] => [ST_Entity].[STKEY]
        /// Student key - only used for split billing
        /// </summary>
        public ST_Entity TRSTUD_ST {
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
        /// Navigation property for [STUDENT] => [ST_Entity].[STKEY]
        /// Student key
        /// </summary>
        public ST_Entity STUDENT_ST {
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
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// Relate to KGST
        /// </summary>
        public KGST_Entity GST_TYPE_KGST {
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
        /// Navigation property for [BSB] => [KAB_Entity].[BSB]
        /// Cheque BSB number
        /// </summary>
        public KAB_Entity BSB_KAB {
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
        /// Navigation property for [FEE_CODE] => [SA_Entity].[SAKEY]
        /// Fee code
        /// </summary>
        public SA_Entity FEE_CODE_SA {
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
        /// Navigation property for [SUBJECT] => [SU_Entity].[SUKEY]
        /// Subject with fee (levy)
        /// 
        /// </summary>
        public SU_Entity SUBJECT_SU {
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
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB {
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
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT {
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
