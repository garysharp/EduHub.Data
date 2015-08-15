using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Details
    /// </summary>
    public class GLBANK_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Sequence number for GLF transactions [Integer (32bit signed): l]
        /// </summary>
        public int GLBANKKEY { get; internal set; }
        /// <summary>
        /// Bank Account Types - Inlisted [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCOUNT_TYPE { get; internal set; }
        /// <summary>
        /// Account interest rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? INTEREST_RATE { get; internal set; }
        /// <summary>
        /// Account investment date [Date Time nullable: d]
        /// </summary>
        public DateTime? INVESTMENT_DATE { get; internal set; }
        /// <summary>
        /// Account maturity date (if applicable) [Date Time nullable: d]
        /// </summary>
        public DateTime? MATURITY_DATE { get; internal set; }
        /// <summary>
        /// Account interest earned for the School Year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? INTEREST_EARNED { get; internal set; }
        /// <summary>
        /// Optional comments [Alphanumeric: a250]
        /// </summary>
        public string COMMENTS { get; internal set; }
        /// <summary>
        /// All accounts in KBANK [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOTAL_BANK_BALANCE { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LY_BANK_BALANCE { get; internal set; }
        /// <summary>
        /// SRP cash grant [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CASH_GRANT { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LY_CASH_GRANT { get; internal set; }
        /// <summary>
        /// Calculated ($10000 or 25% of Cash grant) [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OPERATING_RESERVE { get; internal set; }
        /// <summary>
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LY_OPERATING_RESERVE { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR01 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR02 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR03 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR04 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR05 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR06 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR07 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR08 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR09 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR10 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR11 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR12 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR01 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR02 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR03 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR04 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR05 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR06 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR07 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR08 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR09 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR10 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR11 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR12 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OPBAL { get; internal set; }
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
