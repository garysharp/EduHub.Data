using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Receivable
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DR : EduHubEntity
    {

        #region Navigation Property Cache

        private SA Cache_DRTABLEA_SA;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<DRB> Cache_DRKEY_DRB_DR_CODE;
        private IReadOnlyList<DRF> Cache_DRKEY_DRF_CODE;
        private IReadOnlyList<SDGM> Cache_DRKEY_SDGM_PERSON_LINK;
        private IReadOnlyList<SF> Cache_DRKEY_SF_DEBTOR_ID;

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
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRKEY { get; internal set; }

        /// <summary>
        /// Debtor name
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Outstanding allocation amount
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }

        /// <summary>
        /// Charges to date
        /// </summary>
        public decimal? CHARGES { get; internal set; }

        /// <summary>
        /// Charges this year
        /// </summary>
        public decimal? CHARGES_YTD { get; internal set; }

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
        /// Opening balances
        /// </summary>
        public decimal? OPBAL { get; internal set; }

        /// <summary>
        /// Last receipt amount
        /// </summary>
        public decimal? LASTREC { get; internal set; }

        /// <summary>
        /// Last receipt date
        /// </summary>
        public DateTime? LASTRECDATE { get; internal set; }

        /// <summary>
        /// Open item (1) or...
        /// Brought forward (0)
        /// </summary>
        public short? ACCTYPE { get; internal set; }

        /// <summary>
        /// CONTACT NAME
        /// [Alphanumeric (30)]
        /// </summary>
        public string CONTACT { get; internal set; }

        /// <summary>
        /// T = Trade Debtor (not used)
        /// I = Internal Debtor
        /// 1 = AUS Debtor
        /// 2 = NSW Debtor
        /// 6 = WA  Debtor
        /// 9 = FRV Debtor
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DRTYPE { get; internal set; }

        /// <summary>
        /// Table
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRTABLEA { get; internal set; }

        /// <summary>
        /// Business name
        /// [Alphanumeric (30)]
        /// </summary>
        public string BUSNAME { get; internal set; }

        /// <summary>
        /// Business address of Debtor
        /// [Alphanumeric (30)]
        /// </summary>
        public string BUSADD01 { get; internal set; }

        /// <summary>
        /// Business address of Debtor
        /// [Alphanumeric (30)]
        /// </summary>
        public string BUSADD02 { get; internal set; }

        /// <summary>
        /// Business state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string BUSSTATE { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Telephone number
        /// [Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }

        /// <summary>
        /// Facsimile
        /// [Alphanumeric (15)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Mobile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// Email address for emailing financial statements direct to the Sundry Debtor
        /// [Alphanumeric (60)]
        /// </summary>
        public string BILLING_EMAIL { get; internal set; }

        /// <summary>
        /// Mailing name
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILNAME { get; internal set; }

        /// <summary>
        /// Mailing address
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILADD01 { get; internal set; }

        /// <summary>
        /// Mailing address
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILADD02 { get; internal set; }

        /// <summary>
        /// Mailing state
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string MAILSTATE { get; internal set; }

        /// <summary>
        /// Mailing postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string MAILPOST { get; internal set; }

        /// <summary>
        /// Delivery name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELNAME { get; internal set; }

        /// <summary>
        /// Delivery address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Delivery address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Delivery postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string DELIVPOST { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Memo]
        /// </summary>
        public string REMARK { get; internal set; }

        /// <summary>
        /// Inventory price level
        /// </summary>
        public short? PRICELEVEL { get; internal set; }

        /// <summary>
        /// Y/N flag for memos
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEMO_FLAG { get; internal set; }

        /// <summary>
        /// Notes about this client
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRSHORT { get; internal set; }

        /// <summary>
        /// Staff customer support rep
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string CSR { get; internal set; }

        /// <summary>
        /// Debtor group
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DRGROUP { get; internal set; }

        /// <summary>
        /// Date first commenced as client
        /// </summary>
        public DateTime? COMMENCE { get; internal set; }

        /// <summary>
        /// Number of DRF transactions
        /// </summary>
        public double? DRFCOUNT { get; internal set; }

        /// <summary>
        /// Does debtor require tax invoices for GST
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TAX_INVOICE { get; internal set; }

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
        /// SA (Fees) related entity by [DR.DRTABLEA]-&gt;[SA.SAKEY]
        /// Table
        /// </summary>
        public SA DRTABLEA_SA
        {
            get
            {
                if (DRTABLEA == null)
                {
                    return null;
                }
                if (Cache_DRTABLEA_SA == null)
                {
                    Cache_DRTABLEA_SA = Context.SA.FindBySAKEY(DRTABLEA);
                }

                return Cache_DRTABLEA_SA;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// DRB (BPAY Receipts for Sundry Debtors) related entities by [DR.DRKEY]-&gt;[DRB.DR_CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<DRB> DRKEY_DRB_DR_CODE
        {
            get
            {
                if (Cache_DRKEY_DRB_DR_CODE == null &&
                    !Context.DRB.TryFindByDR_CODE(DRKEY, out Cache_DRKEY_DRB_DR_CODE))
                {
                    Cache_DRKEY_DRB_DR_CODE = new List<DRB>().AsReadOnly();
                }

                return Cache_DRKEY_DRB_DR_CODE;
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [DR.DRKEY]-&gt;[DRF.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<DRF> DRKEY_DRF_CODE
        {
            get
            {
                if (Cache_DRKEY_DRF_CODE == null &&
                    !Context.DRF.TryFindByCODE(DRKEY, out Cache_DRKEY_DRF_CODE))
                {
                    Cache_DRKEY_DRF_CODE = new List<DRF>().AsReadOnly();
                }

                return Cache_DRKEY_DRF_CODE;
            }
        }

        /// <summary>
        /// SDGM (Adult Group Members) related entities by [DR.DRKEY]-&gt;[SDGM.PERSON_LINK]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SDGM> DRKEY_SDGM_PERSON_LINK
        {
            get
            {
                if (Cache_DRKEY_SDGM_PERSON_LINK == null &&
                    !Context.SDGM.TryFindByPERSON_LINK(DRKEY, out Cache_DRKEY_SDGM_PERSON_LINK))
                {
                    Cache_DRKEY_SDGM_PERSON_LINK = new List<SDGM>().AsReadOnly();
                }

                return Cache_DRKEY_SDGM_PERSON_LINK;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [DR.DRKEY]-&gt;[SF.DEBTOR_ID]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<SF> DRKEY_SF_DEBTOR_ID
        {
            get
            {
                if (Cache_DRKEY_SF_DEBTOR_ID == null &&
                    !Context.SF.TryFindByDEBTOR_ID(DRKEY, out Cache_DRKEY_SF_DEBTOR_ID))
                {
                    Cache_DRKEY_SF_DEBTOR_ID = new List<SF>().AsReadOnly();
                }

                return Cache_DRKEY_SF_DEBTOR_ID;
            }
        }

        #endregion

    }
}
