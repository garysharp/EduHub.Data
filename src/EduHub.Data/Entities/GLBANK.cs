using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLBANK : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<BANKSIG> Cache_GLCODE_BANKSIG_GLCODE;
        private IReadOnlyList<GLFBANK> Cache_GLCODE_GLFBANK_CODE;

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
        public string GLCODE { get; internal set; }

        /// <summary>
        /// Sequence number for GLF transactions
        /// </summary>
        public int GLBANKKEY { get; internal set; }

        /// <summary>
        /// Bank Account Types - Inlisted
        /// </summary>
        public short? ACCOUNT_TYPE { get; internal set; }

        /// <summary>
        /// Account interest rate
        /// </summary>
        public double? INTEREST_RATE { get; internal set; }

        /// <summary>
        /// Account investment date
        /// </summary>
        public DateTime? INVESTMENT_DATE { get; internal set; }

        /// <summary>
        /// Account maturity date (if applicable)
        /// </summary>
        public DateTime? MATURITY_DATE { get; internal set; }

        /// <summary>
        /// Account interest earned for the School Year
        /// </summary>
        public decimal? INTEREST_EARNED { get; internal set; }

        /// <summary>
        /// Optional comments
        /// [Alphanumeric (250)]
        /// </summary>
        public string COMMENTS { get; internal set; }

        /// <summary>
        /// Comments for Commitment Summary
        /// [Alphanumeric (250)]
        /// </summary>
        public string COMMENTS_COMMIT { get; internal set; }

        /// <summary>
        /// All accounts in KBANK
        /// </summary>
        public decimal? TOTAL_BANK_BALANCE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? LY_BANK_BALANCE { get; internal set; }

        /// <summary>
        /// SRP cash grant
        /// </summary>
        public decimal? CASH_GRANT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? LY_CASH_GRANT { get; internal set; }

        /// <summary>
        /// Calculated ($10000 or 25% of Cash grant)
        /// </summary>
        public decimal? OPERATING_RESERVE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? LY_OPERATING_RESERVE { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR01 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR02 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR03 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR04 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR05 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR06 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR07 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR08 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR09 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR10 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR11 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR12 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR01 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR02 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR03 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR04 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR05 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR06 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR07 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR08 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR09 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR10 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR11 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR12 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? OPBAL { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// BANKSIG (Bank Signatories) related entities by [GLBANK.GLCODE]-&gt;[BANKSIG.GLCODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<BANKSIG> GLCODE_BANKSIG_GLCODE
        {
            get
            {
                if (Cache_GLCODE_BANKSIG_GLCODE == null &&
                    !Context.BANKSIG.TryFindByGLCODE(GLCODE, out Cache_GLCODE_BANKSIG_GLCODE))
                {
                    Cache_GLCODE_BANKSIG_GLCODE = new List<BANKSIG>().AsReadOnly();
                }

                return Cache_GLCODE_BANKSIG_GLCODE;
            }
        }

        /// <summary>
        /// GLFBANK (Financial Commitments) related entities by [GLBANK.GLCODE]-&gt;[GLFBANK.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<GLFBANK> GLCODE_GLFBANK_CODE
        {
            get
            {
                if (Cache_GLCODE_GLFBANK_CODE == null &&
                    !Context.GLFBANK.TryFindByCODE(GLCODE, out Cache_GLCODE_GLFBANK_CODE))
                {
                    Cache_GLCODE_GLFBANK_CODE = new List<GLFBANK>().AsReadOnly();
                }

                return Cache_GLCODE_GLFBANK_CODE;
            }
        }

        #endregion

    }
}
