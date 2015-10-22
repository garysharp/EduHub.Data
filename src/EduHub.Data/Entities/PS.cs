using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class
    /// </summary>
    public partial class PS : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PEF.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        public IReadOnlyList<PEF> PEF_PAY_STEP
        {
            get
            {
                return Context.PS.FindPEFByPAY_STEP(PSKEY);
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PEFH.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        public IReadOnlyList<PEFH> PEFH_PAY_STEP
        {
            get
            {
                return Context.PS.FindPEFHByPAY_STEP(PSKEY);
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PEPS.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        public IReadOnlyList<PEPS> PEPS_PAY_STEP
        {
            get
            {
                return Context.PS.FindPEPSByPAY_STEP(PSKEY);
            }
        }

        /// <summary>
        /// PSF (Future Pay Steps or Pay Class) related entities by [PSF.PSKEY]-&gt;[PS.PSKEY]
        /// </summary>
        public IReadOnlyList<PSF> PSF_PSKEY
        {
            get
            {
                return Context.PS.FindPSFByPSKEY(PSKEY);
            }
        }
#endregion
    }
}
