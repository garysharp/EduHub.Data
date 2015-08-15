using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fuel Tax Credit Rates
    /// </summary>
    public class KFTC_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u3]
        /// </summary>
        public string KFTCKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a80]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Credit Rate in dollars [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? FTC_RATE { get; internal set; }
        /// <summary>
        /// FTC refund posting account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_CODE { get; internal set; }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// This rate is inactive Y/N - Aegis 9158
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INACTIVE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
