using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class
    /// </summary>
    public class PS_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Pay Step or Pay Class code [Integer (16bit signed): i]
        /// </summary>
        public short PSKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Pay Type : Hourly or Annual Pay (Annual by default) [Alphanumeric: a1]
        /// </summary>
        public string PAY_TYPE { get; internal set; }
        /// <summary>
        /// Date from which this step/class is current [Date Time nullable: d]
        /// </summary>
        public DateTime? EFFECTIVE_DATE { get; internal set; }
        /// <summary>
        /// Annual Earnings [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ANNUAL_RATE { get; internal set; }
        /// <summary>
        /// Monthly Earnings [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? MONTHLY_RATE { get; internal set; }
        /// <summary>
        /// Fortnightly Earnings [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? FORTNIGHTLY_RATE { get; internal set; }
        /// <summary>
        /// Weekly Earnings [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? WEEKLY_RATE { get; internal set; }
        /// <summary>
        /// Hourly Rate for Wkly & Fortnightly [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? HOURLY_RATE { get; internal set; }
        /// <summary>
        /// Standard Weekly Hours [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? STD_WEEKLY_HOURS { get; internal set; }
        /// <summary>
        /// Standard Monthly Hours [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? STD_MONTHLY_HOURS { get; internal set; }
        /// <summary>
        /// Selectable in drop lists Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
#endregion

#region Navigation Properties
#endregion
    }
}
