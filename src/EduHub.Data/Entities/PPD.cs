using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payer Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPD : EntityBase
    {

        #region Navigation Property Cache

        private KGT Cache_COUNTRY_KGT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<CR> Cache_PPDKEY_CR_PPDKEY;
        private IReadOnlyList<PN> Cache_PPDKEY_PN_PPDKEY;

        #endregion

        #region Field Properties

        /// <summary>
        /// Payer code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PPDKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Payer Australian Business Number
        /// or Withholding Payer Number
        /// [Alphanumeric (11)]
        /// </summary>
        public string ABN_OR_WPN { get; internal set; }

        /// <summary>
        /// Number type A = ABN, W = WPN
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NUMBER_TYPE { get; internal set; }

        /// <summary>
        /// Branch number, for ABN if no branch number
        /// default is 001
        /// for WPN default is 000
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string BRANCH_NUMBER { get; internal set; }

        /// <summary>
        /// Financial year
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string FINANCIAL_YEAR { get; internal set; }

        /// <summary>
        /// Payer name as it appears on the
        /// payer's ANB or WPN registration
        /// [Uppercase Alphanumeric (40)]
        /// </summary>
        public string NAME { get; internal set; }

        /// <summary>
        /// Payer Trading Name (full name)
        /// [Uppercase Alphanumeric (40)]
        /// </summary>
        public string TRADING_NAME { get; internal set; }

        /// <summary>
        /// Payer Address Line 1
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string L1_ADDRESS { get; internal set; }

        /// <summary>
        /// Payer Address Line 2
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string L2_ADDRESS { get; internal set; }

        /// <summary>
        /// Suburb, town, city
        /// [Uppercase Alphanumeric (27)]
        /// </summary>
        public string SUBURB { get; internal set; }

        /// <summary>
        /// State or territory
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Post Code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Country
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string COUNTRY { get; internal set; }

        /// <summary>
        /// Contact Name
        /// [Uppercase Alphanumeric (25)]
        /// </summary>
        public string CONTACT_NAME { get; internal set; }

        /// <summary>
        /// Contact Telephone Number
        /// [Alphanumeric (15)]
        /// </summary>
        public string PHONE { get; internal set; }

        /// <summary>
        /// Contact Facsimile Number
        /// [Alphanumeric (15)]
        /// </summary>
        public string FACSIMILE { get; internal set; }

        /// <summary>
        /// Payer Signature
        /// [Alphanumeric (25)]
        /// </summary>
        public string SIGNATURE { get; internal set; }

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
        /// KGT (Countries) related entity by [PPD.COUNTRY]-&gt;[KGT.COUNTRY]
        /// Country
        /// </summary>
        public KGT COUNTRY_KGT
        {
            get
            {
                if (COUNTRY == null)
                {
                    return null;
                }
                if (Cache_COUNTRY_KGT == null)
                {
                    Cache_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(COUNTRY);
                }

                return Cache_COUNTRY_KGT;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// CR (Accounts Payable) related entities by [PPD.PPDKEY]-&gt;[CR.PPDKEY]
        /// Payer code
        /// </summary>
        public IReadOnlyList<CR> PPDKEY_CR_PPDKEY
        {
            get
            {
                if (Cache_PPDKEY_CR_PPDKEY == null &&
                    !Context.CR.TryFindByPPDKEY(PPDKEY, out Cache_PPDKEY_CR_PPDKEY))
                {
                    Cache_PPDKEY_CR_PPDKEY = new List<CR>().AsReadOnly();
                }

                return Cache_PPDKEY_CR_PPDKEY;
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [PPD.PPDKEY]-&gt;[PN.PPDKEY]
        /// Payer code
        /// </summary>
        public IReadOnlyList<PN> PPDKEY_PN_PPDKEY
        {
            get
            {
                if (Cache_PPDKEY_PN_PPDKEY == null &&
                    !Context.PN.TryFindByPPDKEY(PPDKEY, out Cache_PPDKEY_PN_PPDKEY))
                {
                    Cache_PPDKEY_PN_PPDKEY = new List<PN>().AsReadOnly();
                }

                return Cache_PPDKEY_PN_PPDKEY;
            }
        }

        #endregion

    }
}
