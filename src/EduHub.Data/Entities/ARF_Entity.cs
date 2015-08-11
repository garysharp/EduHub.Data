using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Financial Transactions
    /// </summary>
    public class ARF_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Asset code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [AR_Entity].[ARKEY]
        /// Asset code
        /// </summary>
        public AR_Entity CODE_AR { get { return CODE == null ? null : Context.AR.FindByARKEY(CODE); } }
        /// <summary>
        /// Transaction reference [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Creditors code
        /// or Bank account/Finance account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// Code for GL through Postings for additions [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_TRXCODE { get; internal set; }
        /// <summary>
        /// Ledger type GL,CR [Uppercase Alphanumeric: u2]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// Ledger for through post for GL transactions
        /// for mixtures of GL and AR transactons [Uppercase Alphanumeric: u2]
        /// </summary>
        public string GL_TRXLEDGER { get; internal set; }
        /// <summary>
        /// Transaction date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Transaction type:
        /// A = Additions
        /// D = Depreciation
        /// V = Revaluation
        /// G = GST only Journal
        /// R = Reclaim GST Journal
        /// S = Disposal/Sale
        /// L = stocktake Loss
        /// T = stocktake Gain
        /// N = stocktake No Change
        /// C = Service record
        /// X = Asset parameters adjustment,
        /// eg. change in depn rate or method
        /// E = Log entry [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Description of transaction [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Transaction period [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Bank Account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRBANK { get; internal set; }
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
        /// Receipt/Payment type
        /// CA = Cash payment
        /// FI = Financed from another GL account [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RTYPE { get; internal set; }
        /// <summary>
        /// Posting to Actuals: Quanitity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRQTY { get; internal set; }
        /// <summary>
        /// Quantity recorded at stocktake [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ST_QTY { get; internal set; }
        /// <summary>
        /// Results of last service [Memo: m]
        /// </summary>
        public string AMEMO { get; internal set; }
        /// <summary>
        /// Copy Amemo field to Asset? Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AMEMO_COPY { get; internal set; }
        /// <summary>
        /// Date for next service [Date Time nullable: d]
        /// </summary>
        public DateTime? NEXT_SVC_DATE { get; internal set; }
        /// <summary>
        /// Net unit cost [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRCOST { get; internal set; }
        /// <summary>
        /// Amount before GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Purchase/disposal price [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Added for software compatibility [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
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
        /// Posting to Actuals: Cost ex GST
        /// Also used for the cost base for dep'n [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACOST { get; internal set; }
        /// <summary>
        /// Amount of GST, Posted to Accounting ORIG_GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Amount of GST included in disposal sale price [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT_SALE { get; internal set; }
        /// <summary>
        /// Posting to Accounting Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AUNCL_GST { get; internal set; }
        /// <summary>
        /// Posting to ADep: Depreciation [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ADEPN { get; internal set; }
        /// <summary>
        /// Pte % of accounting depn [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? APTE_DEPN { get; internal set; }
        /// <summary>
        /// Asset Flag at time of transaction [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AFLAG { get; internal set; }
        /// <summary>
        /// Date this depreciation started from [Date Time nullable: d]
        /// </summary>
        public DateTime? ADEPN_BEGIN { get; internal set; }
        /// <summary>
        /// Rate of depreciation [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ARATE { get; internal set; }
        /// <summary>
        /// Method of depreciation [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AMETHOD { get; internal set; }
        /// <summary>
        /// Navigation property for [AMETHOD] => [KADM_Entity].[KADMKEY]
        /// Method of depreciation
        /// </summary>
        public KADM_Entity AMETHOD_KADM { get { return AMETHOD == null ? null : Context.KADM.FindByKADMKEY(AMETHOD); } }
        /// <summary>
        /// Posting to Actuals: Revaluation Adjustments [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AREVALS { get; internal set; }
        /// <summary>
        /// Posting to ADep: Last Units Reading [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AUNITS { get; internal set; }
        /// <summary>
        /// Y/N field used in creditors asset invoice [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TINCLUDE { get; internal set; }
        /// <summary>
        /// Posting to TDep: Cost ex GST
        /// Also used for the cost base for depreciation [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TCOST { get; internal set; }
        /// <summary>
        /// Tax value of Asset transaction incl. GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTRNETT { get; internal set; }
        /// <summary>
        /// Tax value of Asset transaction excl. GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTRAMT { get; internal set; }
        /// <summary>
        /// Amount of GST for tax transactions, Posted to tax ORIG_GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TGST_AMOUNT { get; internal set; }
        /// <summary>
        /// Posting to Tax Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TUNCL_GST { get; internal set; }
        /// <summary>
        /// Posting to TDep: Depreciation [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TDEPN { get; internal set; }
        /// <summary>
        /// Pte % of tax depn [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TPTE_DEPN { get; internal set; }
        /// <summary>
        /// Asset Flag at time of transaction [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TFLAG { get; internal set; }
        /// <summary>
        /// Date this depreciation started from [Date Time nullable: d]
        /// </summary>
        public DateTime? TDEPN_BEGIN { get; internal set; }
        /// <summary>
        /// Rate of depreciation [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRATE { get; internal set; }
        /// <summary>
        /// Method of depreciation [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TMETHOD { get; internal set; }
        /// <summary>
        /// Navigation property for [TMETHOD] => [KADM_Entity].[KADMKEY]
        /// Method of depreciation
        /// </summary>
        public KADM_Entity TMETHOD_KADM { get { return TMETHOD == null ? null : Context.KADM.FindByKADMKEY(TMETHOD); } }
        /// <summary>
        /// Tax consideration [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TCON { get; internal set; }
        /// <summary>
        /// Account consideration [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACON { get; internal set; }
        /// <summary>
        /// Original amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRORIG { get; internal set; }
        /// <summary>
        /// ACC depreciation - last yrs [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ADEPLY { get; internal set; }
        /// <summary>
        /// ACC depreciation - this yr [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ADEPTY { get; internal set; }
        /// <summary>
        /// Account written down value [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AWDV { get; internal set; }
        /// <summary>
        /// Creditor key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CRKEY { get; internal set; }
        /// <summary>
        /// Capitalisable repair/install cost? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRINSTALL { get; internal set; }
        /// <summary>
        /// Tax depreciation - this yr [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TDEPTY { get; internal set; }
        /// <summary>
        /// Tax depreciation - last yrs [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TDEPLY { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TWDV { get; internal set; }
        /// <summary>
        /// Line number in the batch [Integer (32bit signed nullable): l]
        /// </summary>
        public int? LINE_NO { get; internal set; }
        /// <summary>
        /// Determines through posts
        /// 0 = Don't show T/P
        /// 1 = Show T/P
        ///  [Integer (32bit signed nullable): l]
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
        /// Asset Release Type [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RELEASE_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [RELEASE_TYPE] => [AKR_Entity].[AKRKEY]
        /// Asset Release Type
        /// </summary>
        public AKR_Entity RELEASE_TYPE_AKR { get { return RELEASE_TYPE == null ? null : Context.AKR.FindByAKRKEY(RELEASE_TYPE); } }
        /// <summary>
        /// Who the money was received from [Alphanumeric: a50]
        /// </summary>
        public string RECEIVED_FROM { get; internal set; }
        /// <summary>
        /// Asset location [Uppercase Alphanumeric: u10]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Navigation property for [LOCATION] => [AKL_Entity].[LOCATION]
        /// Asset location
        /// </summary>
        public AKL_Entity LOCATION_AKL { get { return LOCATION == null ? null : Context.AKL.FindByLOCATION(LOCATION); } }
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
