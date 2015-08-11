using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Financial Transactions
    /// </summary>
    public class DFF_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Family key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [DF_Entity].[DFKEY]
        /// Family key
        /// </summary>
        public DF_Entity CODE_DF { get { return CODE == null ? null : Context.DF.FindByDFKEY(CODE); } }
        /// <summary>
        /// Student key - only used for split billing [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRSTUD { get; internal set; }
        /// <summary>
        /// Navigation property for [TRSTUD] => [ST_Entity].[STKEY]
        /// Student key - only used for split billing
        /// </summary>
        public ST_Entity TRSTUD_ST { get { return TRSTUD == null ? null : Context.ST.FindBySTKEY(TRSTUD); } }
        /// <summary>
        /// Student key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// Navigation property for [STUDENT] => [ST_Entity].[STKEY]
        /// Student key
        /// </summary>
        public ST_Entity STUDENT_ST { get { return STUDENT == null ? null : Context.ST.FindBySTKEY(STUDENT); } }
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
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// Relate to KGST
        /// </summary>
        public KGST_Entity GST_TYPE_KGST { get { return GST_TYPE == null ? null : Context.KGST.FindByKGSTKEY(GST_TYPE); } }
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
        /// Navigation property for [BSB] => [KAB_Entity].[BSB]
        /// Cheque BSB number
        /// </summary>
        public KAB_Entity BSB_KAB { get { return BSB == null ? null : Context.KAB.FindByBSB(BSB); } }
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
        /// Navigation property for [FEE_CODE] => [SA_Entity].[SAKEY]
        /// Fee code
        /// </summary>
        public SA_Entity FEE_CODE_SA { get { return FEE_CODE == null ? null : Context.SA.FindBySAKEY(FEE_CODE); } }
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
        /// Navigation property for [SUBJECT] => [SU_Entity].[SUKEY]
        /// Subject with fee (levy)
        /// 
        /// </summary>
        public SU_Entity SUBJECT_SU { get { return SUBJECT == null ? null : Context.SU.FindBySUKEY(SUBJECT); } }
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
        
        
    }
}
