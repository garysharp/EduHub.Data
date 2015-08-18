using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Financial Transactions
    /// </summary>
    public class ARF : EntityBase
    {
#region Navigation Property Cache
        private AR _CODE_AR;
        private KAB _BSB_KAB;
        private KGST _GST_TYPE_KGST;
        private KADM _AMETHOD_KADM;
        private KADM _TMETHOD_KADM;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLINIT _INITIATIVE_KGLINIT;
        private AKR _RELEASE_TYPE_AKR;
        private AKL _LOCATION_AKL;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Asset code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Transaction reference
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Creditors code
        /// or Bank account/Finance account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRXCODE { get; internal set; }
        /// <summary>
        /// Code for GL through Postings for additions
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_TRXCODE { get; internal set; }
        /// <summary>
        /// Ledger type GL,CR
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// Ledger for through post for GL transactions
        /// for mixtures of GL and AR transactons
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string GL_TRXLEDGER { get; internal set; }
        /// <summary>
        /// Transaction date
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
        /// E = Log entry
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Description of transaction
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Transaction period
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Bank Account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRBANK { get; internal set; }
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
        /// Receipt/Payment type
        /// CA = Cash payment
        /// FI = Financed from another GL account
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RTYPE { get; internal set; }
        /// <summary>
        /// Posting to Actuals: Quanitity
        /// </summary>
        public short? TRQTY { get; internal set; }
        /// <summary>
        /// Quantity recorded at stocktake
        /// </summary>
        public short? ST_QTY { get; internal set; }
        /// <summary>
        /// Results of last service
        /// [Memo]
        /// </summary>
        public string AMEMO { get; internal set; }
        /// <summary>
        /// Copy Amemo field to Asset? Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AMEMO_COPY { get; internal set; }
        /// <summary>
        /// Date for next service
        /// </summary>
        public DateTime? NEXT_SVC_DATE { get; internal set; }
        /// <summary>
        /// Net unit cost
        /// </summary>
        public decimal? TRCOST { get; internal set; }
        /// <summary>
        /// Amount before GST
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Purchase/disposal price
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Added for software compatibility
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
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
        /// is the user reclaiming this
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }
        /// <summary>
        /// Posting to Actuals: Cost ex GST
        /// Also used for the cost base for dep'n
        /// </summary>
        public decimal? ACOST { get; internal set; }
        /// <summary>
        /// Amount of GST, Posted to Accounting ORIG_GST
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Amount of GST included in disposal sale price
        /// </summary>
        public decimal? GST_AMOUNT_SALE { get; internal set; }
        /// <summary>
        /// Posting to Accounting Unclaimed GST
        /// </summary>
        public decimal? AUNCL_GST { get; internal set; }
        /// <summary>
        /// Posting to ADep: Depreciation
        /// </summary>
        public decimal? ADEPN { get; internal set; }
        /// <summary>
        /// Pte % of accounting depn
        /// </summary>
        public decimal? APTE_DEPN { get; internal set; }
        /// <summary>
        /// Asset Flag at time of transaction
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AFLAG { get; internal set; }
        /// <summary>
        /// Date this depreciation started from
        /// </summary>
        public DateTime? ADEPN_BEGIN { get; internal set; }
        /// <summary>
        /// Rate of depreciation
        /// </summary>
        public double? ARATE { get; internal set; }
        /// <summary>
        /// Method of depreciation
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AMETHOD { get; internal set; }
        /// <summary>
        /// Posting to Actuals: Revaluation Adjustments
        /// </summary>
        public decimal? AREVALS { get; internal set; }
        /// <summary>
        /// Posting to ADep: Last Units Reading
        /// </summary>
        public int? AUNITS { get; internal set; }
        /// <summary>
        /// Y/N field used in creditors asset invoice
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TINCLUDE { get; internal set; }
        /// <summary>
        /// Posting to TDep: Cost ex GST
        /// Also used for the cost base for depreciation
        /// </summary>
        public decimal? TCOST { get; internal set; }
        /// <summary>
        /// Tax value of Asset transaction incl. GST
        /// </summary>
        public decimal? TTRNETT { get; internal set; }
        /// <summary>
        /// Tax value of Asset transaction excl. GST
        /// </summary>
        public decimal? TTRAMT { get; internal set; }
        /// <summary>
        /// Amount of GST for tax transactions, Posted to tax ORIG_GST
        /// </summary>
        public decimal? TGST_AMOUNT { get; internal set; }
        /// <summary>
        /// Posting to Tax Unclaimed GST
        /// </summary>
        public decimal? TUNCL_GST { get; internal set; }
        /// <summary>
        /// Posting to TDep: Depreciation
        /// </summary>
        public decimal? TDEPN { get; internal set; }
        /// <summary>
        /// Pte % of tax depn
        /// </summary>
        public decimal? TPTE_DEPN { get; internal set; }
        /// <summary>
        /// Asset Flag at time of transaction
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TFLAG { get; internal set; }
        /// <summary>
        /// Date this depreciation started from
        /// </summary>
        public DateTime? TDEPN_BEGIN { get; internal set; }
        /// <summary>
        /// Rate of depreciation
        /// </summary>
        public double? TRATE { get; internal set; }
        /// <summary>
        /// Method of depreciation
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TMETHOD { get; internal set; }
        /// <summary>
        /// Tax consideration
        /// </summary>
        public decimal? TCON { get; internal set; }
        /// <summary>
        /// Account consideration
        /// </summary>
        public decimal? ACON { get; internal set; }
        /// <summary>
        /// Original amount
        /// </summary>
        public decimal? TRORIG { get; internal set; }
        /// <summary>
        /// ACC depreciation - last yrs
        /// </summary>
        public decimal? ADEPLY { get; internal set; }
        /// <summary>
        /// ACC depreciation - this yr
        /// </summary>
        public decimal? ADEPTY { get; internal set; }
        /// <summary>
        /// Account written down value
        /// </summary>
        public decimal? AWDV { get; internal set; }
        /// <summary>
        /// Creditor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CRKEY { get; internal set; }
        /// <summary>
        /// Capitalisable repair/install cost? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRINSTALL { get; internal set; }
        /// <summary>
        /// Tax depreciation - this yr
        /// </summary>
        public decimal? TDEPTY { get; internal set; }
        /// <summary>
        /// Tax depreciation - last yrs
        /// </summary>
        public decimal? TDEPLY { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TWDV { get; internal set; }
        /// <summary>
        /// Line number in the batch
        /// </summary>
        public int? LINE_NO { get; internal set; }
        /// <summary>
        /// Determines through posts
        /// 0 = Don't show T/P
        /// 1 = Show T/P
        /// 
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
        /// Asset Release Type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RELEASE_TYPE { get; internal set; }
        /// <summary>
        /// Who the money was received from
        /// [Alphanumeric (50)]
        /// </summary>
        public string RECEIVED_FROM { get; internal set; }
        /// <summary>
        /// Asset location
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string LOCATION { get; internal set; }
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
        /// Navigation property for [CODE] => [AR].[ARKEY]
        /// Asset code
        /// </summary>
        public AR CODE_AR {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_AR == null)
                    {
                        _CODE_AR = Context.AR.FindByARKEY(CODE);
                    }
                    return _CODE_AR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BSB] => [KAB].[BSB]
        /// Cheque BSB number
        /// </summary>
        public KAB BSB_KAB {
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
        /// Navigation property for [GST_TYPE] => [KGST].[KGSTKEY]
        /// Relate to KGST
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
        /// Navigation property for [AMETHOD] => [KADM].[KADMKEY]
        /// Method of depreciation
        /// </summary>
        public KADM AMETHOD_KADM {
            get
            {
                if (AMETHOD != null)
                {
                    if (_AMETHOD_KADM == null)
                    {
                        _AMETHOD_KADM = Context.KADM.FindByKADMKEY(AMETHOD);
                    }
                    return _AMETHOD_KADM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TMETHOD] => [KADM].[KADMKEY]
        /// Method of depreciation
        /// </summary>
        public KADM TMETHOD_KADM {
            get
            {
                if (TMETHOD != null)
                {
                    if (_TMETHOD_KADM == null)
                    {
                        _TMETHOD_KADM = Context.KADM.FindByKADMKEY(TMETHOD);
                    }
                    return _TMETHOD_KADM;
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
        /// <summary>
        /// Navigation property for [RELEASE_TYPE] => [AKR].[AKRKEY]
        /// Asset Release Type
        /// </summary>
        public AKR RELEASE_TYPE_AKR {
            get
            {
                if (RELEASE_TYPE != null)
                {
                    if (_RELEASE_TYPE_AKR == null)
                    {
                        _RELEASE_TYPE_AKR = Context.AKR.FindByAKRKEY(RELEASE_TYPE);
                    }
                    return _RELEASE_TYPE_AKR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LOCATION] => [AKL].[LOCATION]
        /// Asset location
        /// </summary>
        public AKL LOCATION_AKL {
            get
            {
                if (LOCATION != null)
                {
                    if (_LOCATION_AKL == null)
                    {
                        _LOCATION_AKL = Context.AKL.FindByLOCATION(LOCATION);
                    }
                    return _LOCATION_AKL;
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
