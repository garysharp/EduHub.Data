using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PS : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<PEF> Cache_PSKEY_PEF_PAY_STEP;
        private IReadOnlyList<PEFH> Cache_PSKEY_PEFH_PAY_STEP;
        private IReadOnlyList<PEPS> Cache_PSKEY_PEPS_PAY_STEP;
        private IReadOnlyList<PSF> Cache_PSKEY_PSF_PSKEY;

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
        /// Pay Step or Pay Class code
        /// </summary>
        public short PSKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Pay Type : Hourly or Annual Pay (Annual by default)
        /// [Alphanumeric (1)]
        /// </summary>
        public string PAY_TYPE { get; internal set; }

        /// <summary>
        /// Date from which this step/class is current
        /// </summary>
        public DateTime? EFFECTIVE_DATE { get; internal set; }

        /// <summary>
        /// Annual Earnings
        /// </summary>
        public decimal? ANNUAL_RATE { get; internal set; }

        /// <summary>
        /// Monthly Earnings
        /// </summary>
        public decimal? MONTHLY_RATE { get; internal set; }

        /// <summary>
        /// Fortnightly Earnings
        /// </summary>
        public decimal? FORTNIGHTLY_RATE { get; internal set; }

        /// <summary>
        /// Weekly Earnings
        /// </summary>
        public decimal? WEEKLY_RATE { get; internal set; }

        /// <summary>
        /// Hourly Rate for Wkly &amp; Fortnightly
        /// </summary>
        public decimal? HOURLY_RATE { get; internal set; }

        /// <summary>
        /// Standard Weekly Hours
        /// </summary>
        public decimal? STD_WEEKLY_HOURS { get; internal set; }

        /// <summary>
        /// Standard Monthly Hours
        /// </summary>
        public decimal? STD_MONTHLY_HOURS { get; internal set; }

        /// <summary>
        /// Selectable in drop lists Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }

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
        /// PEF (Payroll Transactions) related entities by [PS.PSKEY]-&gt;[PEF.PAY_STEP]
        /// Pay Step or Pay Class code
        /// </summary>
        public IReadOnlyList<PEF> PSKEY_PEF_PAY_STEP
        {
            get
            {
                if (Cache_PSKEY_PEF_PAY_STEP == null &&
                    !Context.PEF.TryFindByPAY_STEP(PSKEY, out Cache_PSKEY_PEF_PAY_STEP))
                {
                    Cache_PSKEY_PEF_PAY_STEP = new List<PEF>().AsReadOnly();
                }

                return Cache_PSKEY_PEF_PAY_STEP;
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PS.PSKEY]-&gt;[PEFH.PAY_STEP]
        /// Pay Step or Pay Class code
        /// </summary>
        public IReadOnlyList<PEFH> PSKEY_PEFH_PAY_STEP
        {
            get
            {
                if (Cache_PSKEY_PEFH_PAY_STEP == null &&
                    !Context.PEFH.TryFindByPAY_STEP(PSKEY, out Cache_PSKEY_PEFH_PAY_STEP))
                {
                    Cache_PSKEY_PEFH_PAY_STEP = new List<PEFH>().AsReadOnly();
                }

                return Cache_PSKEY_PEFH_PAY_STEP;
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PS.PSKEY]-&gt;[PEPS.PAY_STEP]
        /// Pay Step or Pay Class code
        /// </summary>
        public IReadOnlyList<PEPS> PSKEY_PEPS_PAY_STEP
        {
            get
            {
                if (Cache_PSKEY_PEPS_PAY_STEP == null &&
                    !Context.PEPS.TryFindByPAY_STEP(PSKEY, out Cache_PSKEY_PEPS_PAY_STEP))
                {
                    Cache_PSKEY_PEPS_PAY_STEP = new List<PEPS>().AsReadOnly();
                }

                return Cache_PSKEY_PEPS_PAY_STEP;
            }
        }

        /// <summary>
        /// PSF (Future Pay Steps or Pay Class) related entities by [PS.PSKEY]-&gt;[PSF.PSKEY]
        /// Pay Step or Pay Class code
        /// </summary>
        public IReadOnlyList<PSF> PSKEY_PSF_PSKEY
        {
            get
            {
                if (Cache_PSKEY_PSF_PSKEY == null &&
                    !Context.PSF.TryFindByPSKEY(PSKEY, out Cache_PSKEY_PSF_PSKEY))
                {
                    Cache_PSKEY_PSF_PSKEY = new List<PSF>().AsReadOnly();
                }

                return Cache_PSKEY_PSF_PSKEY;
            }
        }

        #endregion

    }
}
