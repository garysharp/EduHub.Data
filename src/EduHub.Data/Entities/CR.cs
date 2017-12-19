using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CR : EduHubEntity
    {

        #region Navigation Property Cache

        private KAB Cache_BSB_KAB;
        private PPD Cache_PPDKEY_PPD;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_CRKEY_AR_ORIG_SUPPLIER;
        private IReadOnlyList<AR> Cache_CRKEY_AR_CURR_SUPPLIER;
        private IReadOnlyList<CRF> Cache_CRKEY_CRF_CODE;
        private IReadOnlyList<CRFTC> Cache_CRKEY_CRFTC_CODE;
        private IReadOnlyList<CRPR> Cache_CRKEY_CRPR_CODE;
        private IReadOnlyList<CRTT> Cache_CRKEY_CRTT_CRKEY;
        private IReadOnlyList<RQ> Cache_CRKEY_RQ_CODE;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CRKEY { get; internal set; }

        /// <summary>
        /// Creditor title
        /// [Alphanumeric (40)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Outstanding allocation amount
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }

        /// <summary>
        /// MTD purchases
        /// </summary>
        public decimal? MTDPURCH { get; internal set; }

        /// <summary>
        /// YTD purchases
        /// </summary>
        public decimal? YTDPURCH { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED01 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED02 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED03 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED04 { get; internal set; }

        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED05 { get; internal set; }

        /// <summary>
        /// Opening balance
        /// </summary>
        public decimal? OPBAL { get; internal set; }

        /// <summary>
        /// Credit limit
        /// </summary>
        public decimal? CRLIMIT { get; internal set; }

        /// <summary>
        /// Last payment date
        /// </summary>
        public DateTime? LASTPAYDATE { get; internal set; }

        /// <summary>
        /// Last payment amount
        /// </summary>
        public decimal? LASTPAY { get; internal set; }

        /// <summary>
        /// Account type
        ///   0 - Balance forward
        ///   1 - Open item
        /// </summary>
        public short? ACCTYPE { get; internal set; }

        /// <summary>
        /// Trading terms in days
        /// </summary>
        public short? TERMS { get; internal set; }

        /// <summary>
        /// Discount percentage
        /// </summary>
        public double? DISCOUNT { get; internal set; }

        /// <summary>
        /// Contact name
        /// [Alphanumeric (30)]
        /// </summary>
        public string CONTACT { get; internal set; }

        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }

        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Phone number
        /// [Alphanumeric (15)]
        /// </summary>
        public string TELEPHONE { get; internal set; }

        /// <summary>
        /// Facsimile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Email Address for orders
        /// [Alphanumeric (60)]
        /// </summary>
        public string CR_EMAIL { get; internal set; }

        /// <summary>
        /// Email address for payments
        /// [Alphanumeric (60)]
        /// </summary>
        public string EMAIL_FOR_PAYMENTS { get; internal set; }

        /// <summary>
        /// Mobile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// Committed future purchases
        /// </summary>
        public decimal? COMMITMENT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STOP_FLAG { get; internal set; }

        /// <summary>
        /// Australian Business number
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string ABN { get; internal set; }

        /// <summary>
        /// Pay As You Go rate
        /// </summary>
        public double? PAYG_RATE { get; internal set; }

        /// <summary>
        /// Bank/State/Branch number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }

        /// <summary>
        /// Bank Account Number
        /// [Alphanumeric (15)]
        /// </summary>
        public string ACCOUNT_NO { get; internal set; }

        /// <summary>
        /// Bank Account Name
        /// [Alphanumeric (60)]
        /// </summary>
        public string ACCOUNT_NAME { get; internal set; }

        /// <summary>
        /// Lodgement Reference
        /// [Alphanumeric (18)]
        /// </summary>
        public string LODGE_REF { get; internal set; }

        /// <summary>
        /// BPAY biller code
        /// [Alphanumeric (10)]
        /// </summary>
        public string BILLER_CODE { get; internal set; }

        /// <summary>
        /// BPAY reference
        /// [Alphanumeric (20)]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO01 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO02 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO03 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO04 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO05 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO06 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO07 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO08 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO09 { get; internal set; }

        /// <summary>
        /// Trade related information
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string TRADE_INFO10 { get; internal set; }

        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// First name
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// Second name
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }

        /// <summary>
        /// Birthdate
        /// </summary>
        public DateTime? PAYG_BIRTHDATE { get; internal set; }

        /// <summary>
        /// Startdate
        /// </summary>
        public DateTime? PAYG_STARTDATE { get; internal set; }

        /// <summary>
        /// Contract enddate
        /// </summary>
        public DateTime? PAYG_TERMDATE { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string PAYG_ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string PAYG_ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PAYG_SUBURB { get; internal set; }

        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string PAYG_STATE { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PAYG_POST { get; internal set; }

        /// <summary>
        /// Country
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PAYG_COUNTRY { get; internal set; }

        /// <summary>
        /// Payer code in PPD
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PPDKEY { get; internal set; }

        /// <summary>
        /// PR needs to be approved by purchasing manager
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PR_APPROVE { get; internal set; }

        /// <summary>
        /// Is this a PRMS creditor
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRMS_FLAG { get; internal set; }

        /// <summary>
        /// Last write date for PRMS fields
        /// </summary>
        public DateTime? LW_PRMSINFO_DATE { get; internal set; }

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
        /// KAB (BSB Numbers) related entity by [CR.BSB]-&gt;[KAB.BSB]
        /// Bank/State/Branch number
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
        /// PPD (PAYG Payer Details) related entity by [CR.PPDKEY]-&gt;[PPD.PPDKEY]
        /// Payer code in PPD
        /// </summary>
        public PPD PPDKEY_PPD
        {
            get
            {
                if (PPDKEY == null)
                {
                    return null;
                }
                if (Cache_PPDKEY_PPD == null)
                {
                    Cache_PPDKEY_PPD = Context.PPD.FindByPPDKEY(PPDKEY);
                }

                return Cache_PPDKEY_PPD;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// AR (Assets) related entities by [CR.CRKEY]-&gt;[AR.ORIG_SUPPLIER]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<AR> CRKEY_AR_ORIG_SUPPLIER
        {
            get
            {
                if (Cache_CRKEY_AR_ORIG_SUPPLIER == null &&
                    !Context.AR.TryFindByORIG_SUPPLIER(CRKEY, out Cache_CRKEY_AR_ORIG_SUPPLIER))
                {
                    Cache_CRKEY_AR_ORIG_SUPPLIER = new List<AR>().AsReadOnly();
                }

                return Cache_CRKEY_AR_ORIG_SUPPLIER;
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [CR.CRKEY]-&gt;[AR.CURR_SUPPLIER]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<AR> CRKEY_AR_CURR_SUPPLIER
        {
            get
            {
                if (Cache_CRKEY_AR_CURR_SUPPLIER == null &&
                    !Context.AR.TryFindByCURR_SUPPLIER(CRKEY, out Cache_CRKEY_AR_CURR_SUPPLIER))
                {
                    Cache_CRKEY_AR_CURR_SUPPLIER = new List<AR>().AsReadOnly();
                }

                return Cache_CRKEY_AR_CURR_SUPPLIER;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [CR.CRKEY]-&gt;[CRF.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRF> CRKEY_CRF_CODE
        {
            get
            {
                if (Cache_CRKEY_CRF_CODE == null &&
                    !Context.CRF.TryFindByCODE(CRKEY, out Cache_CRKEY_CRF_CODE))
                {
                    Cache_CRKEY_CRF_CODE = new List<CRF>().AsReadOnly();
                }

                return Cache_CRKEY_CRF_CODE;
            }
        }

        /// <summary>
        /// CRFTC (Creditor Fuel Tax Credits) related entities by [CR.CRKEY]-&gt;[CRFTC.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRFTC> CRKEY_CRFTC_CODE
        {
            get
            {
                if (Cache_CRKEY_CRFTC_CODE == null &&
                    !Context.CRFTC.TryFindByCODE(CRKEY, out Cache_CRKEY_CRFTC_CODE))
                {
                    Cache_CRKEY_CRFTC_CODE = new List<CRFTC>().AsReadOnly();
                }

                return Cache_CRKEY_CRFTC_CODE;
            }
        }

        /// <summary>
        /// CRPR (Creditor Purchase Requisitions) related entities by [CR.CRKEY]-&gt;[CRPR.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRPR> CRKEY_CRPR_CODE
        {
            get
            {
                if (Cache_CRKEY_CRPR_CODE == null &&
                    !Context.CRPR.TryFindByCODE(CRKEY, out Cache_CRKEY_CRPR_CODE))
                {
                    Cache_CRKEY_CRPR_CODE = new List<CRPR>().AsReadOnly();
                }

                return Cache_CRKEY_CRPR_CODE;
            }
        }

        /// <summary>
        /// CRTT (Creditor Trade Types) related entities by [CR.CRKEY]-&gt;[CRTT.CRKEY]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRTT> CRKEY_CRTT_CRKEY
        {
            get
            {
                if (Cache_CRKEY_CRTT_CRKEY == null &&
                    !Context.CRTT.TryFindByCRKEY(CRKEY, out Cache_CRKEY_CRTT_CRKEY))
                {
                    Cache_CRKEY_CRTT_CRKEY = new List<CRTT>().AsReadOnly();
                }

                return Cache_CRKEY_CRTT_CRKEY;
            }
        }

        /// <summary>
        /// RQ (Purchase Requisition) related entities by [CR.CRKEY]-&gt;[RQ.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<RQ> CRKEY_RQ_CODE
        {
            get
            {
                if (Cache_CRKEY_RQ_CODE == null &&
                    !Context.RQ.TryFindByCODE(CRKEY, out Cache_CRKEY_RQ_CODE))
                {
                    Cache_CRKEY_RQ_CODE = new List<RQ>().AsReadOnly();
                }

                return Cache_CRKEY_RQ_CODE;
            }
        }

        #endregion

    }
}
