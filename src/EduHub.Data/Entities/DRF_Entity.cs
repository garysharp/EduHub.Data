using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// DR Transactions
    /// </summary>
    public class DRF_Entity : EntityBase
    {
#region Navigation Property Cache
        private DR_Entity _CODE_DR;
        private QB_Entity _TRBATCH_QB;
        private KGST_Entity _GST_TYPE_KGST;
        private KAB_Entity _BSB_KAB;
        private SDFC_Entity _FEE_CODE_SDFC;
        private KGLSUB_Entity _SUBPROGRAM_KGLSUB;
        private KGLINIT_Entity _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Allocated transaction [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ALLOCTID { get; internal set; }
        /// <summary>
        /// DR KEY [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// BATCH NUMBER [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// DR PERIOD NUMBER eg 199802 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction type
        /// I = Invoice
        /// C = Credit Note
        /// J = Journal
        /// R = Receipt
        /// P = Payment (Unusual) [Alphanumeric: a1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// TRANS DATE [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// TRANS REF (Invoice NUMBER) [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Ledger type GL or JO [Uppercase Alphanumeric: u2]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// Account code either GL or JO [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// Unit Cost [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRCOST { get; internal set; }
        /// <summary>
        /// Quantity [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Transaction amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Added for software compatibility
        /// see GL Receipts [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// where does this appear in the BAS [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GST_BOX { get; internal set; }
        /// <summary>
        /// what Period was this Reported [Integer (32bit signed nullable): l]
        /// </summary>
        public int? GST_PERD { get; internal set; }
        /// <summary>
        /// GST Dollar amount for this transaction [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Gross amount which includes GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
        /// <summary>
        /// what rate was the GST apllied [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? GST_RATE { get; internal set; }
        /// <summary>
        /// WHAT TYPE OF GST [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GST_TYPE { get; internal set; }
        /// <summary>
        /// IS THIS BEING CLAIMED [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// S, PO, PC INDICATES TYPE OF PURCHASE OR SALE [Uppercase Alphanumeric: u2]
        /// </summary>
        public string GST_SALE_PURCH { get; internal set; }
        /// <summary>
        /// Amount of Withholding TAX for this invoice line [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? WITHHOLD_AMOUNT { get; internal set; }
        /// <summary>
        /// Required for GL payments with withheld amounts [Uppercase Alphanumeric: u4]
        /// </summary>
        public string WITHHOLD_TYPE { get; internal set; }
        /// <summary>
        /// AMOUNT PAID SO FAR [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRPAID { get; internal set; }
        /// <summary>
        /// TRANS DESCRIPTION [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Invoice ALLOCATED TO CREDITS [Alphanumeric: a10]
        /// </summary>
        public string TRINV { get; internal set; }
        /// <summary>
        /// DELETE INDICATOR
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRDELETE { get; internal set; }
        /// <summary>
        /// Commission rate this line
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRRATE { get; internal set; }
        /// <summary>
        /// Cost price of item [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? COSTPRICE { get; internal set; }
        /// <summary>
        /// Amount commission paid [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? COMMPAID { get; internal set; }
        /// <summary>
        /// Date commission paid
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? COMMDATE { get; internal set; }
        /// <summary>
        /// Bank account for multiple
        /// bank accounts
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRBANK { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RTYPE { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a30]
        /// </summary>
        public string DRAWER { get; internal set; }
        /// <summary>
        /// Cheque BSB number [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Receipt details [Alphanumeric: a20]
        /// </summary>
        public string BANK { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a20]
        /// </summary>
        public string BRANCH { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ACCOUNT_NUMBER { get; internal set; }
        /// <summary>
        /// Master transaction ID (Internal)
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? MASTERTID { get; internal set; }
        /// <summary>
        /// Line number in the batch [Integer (32bit signed nullable): l]
        /// </summary>
        public int? LINE_NO { get; internal set; }
        /// <summary>
        /// Determines through posts
        /// 0 = Don't show T/P [Integer (32bit signed nullable): l]
        /// </summary>
        public int? FLAG { get; internal set; }
        /// <summary>
        /// Fee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FEE_CODE { get; internal set; }
        /// <summary>
        /// As above [Alphanumeric: a30]
        /// </summary>
        public string FEE_DESCRIPTION { get; internal set; }
        /// <summary>
        /// Include transaction on Statements [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STATEMENT_PRINT { get; internal set; }
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
        /// For journals only [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DEBIT { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CREDIT { get; internal set; }
        /// <summary>
        /// For Payments [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINT_CHEQUE { get; internal set; }
        /// <summary>
        /// Only filled in for cancelled payment/receipt [Uppercase Alphanumeric: u3]
        /// </summary>
        public string CANCELLED { get; internal set; }
        /// <summary>
        /// Has online receipt been printed [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RECEIPT_PRINTED { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last user name [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [DR_Entity].[DRKEY]
        /// DR KEY
        /// </summary>
        public DR_Entity CODE_DR {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_DR == null)
                    {
                        _CODE_DR = Context.DR.FindByDRKEY(CODE);
                    }
                    return _CODE_DR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TRBATCH] => [QB_Entity].[QBKEY]
        /// BATCH NUMBER
        /// </summary>
        public QB_Entity TRBATCH_QB {
            get
            {
                if (TRBATCH.HasValue)
                {
                    if (_TRBATCH_QB == null)
                    {
                        _TRBATCH_QB = Context.QB.FindByQBKEY(TRBATCH.Value);
                    }
                    return _TRBATCH_QB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GST_TYPE] => [KGST_Entity].[KGSTKEY]
        /// WHAT TYPE OF GST
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
        /// Navigation property for [FEE_CODE] => [SDFC_Entity].[SDFCKEY]
        /// Fee code
        /// </summary>
        public SDFC_Entity FEE_CODE_SDFC {
            get
            {
                if (FEE_CODE != null)
                {
                    if (_FEE_CODE_SDFC == null)
                    {
                        _FEE_CODE_SDFC = Context.SDFC.FindBySDFCKEY(FEE_CODE);
                    }
                    return _FEE_CODE_SDFC;
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
