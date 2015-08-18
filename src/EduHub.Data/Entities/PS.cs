using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class
    /// </summary>
    public class PS : EntityBase
    {
#region Navigation Property Cache
#endregion

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
        /// Hourly Rate for Wkly & Fortnightly
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
#endregion
    }
}
