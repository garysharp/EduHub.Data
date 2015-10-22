using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fuel Tax Credit Rates
    /// </summary>
    public partial class KFTC : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KFTCKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (80)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Credit Rate in dollars
        /// </summary>
        public double? FTC_RATE { get; internal set; }
        /// <summary>
        /// FTC refund posting account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_CODE { get; internal set; }
        /// <summary>
        /// For every transaction there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// This rate is inactive Y/N - Aegis 9158
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INACTIVE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// CRFTC (Creditor Fuel Tax Credits) related entities by [CRFTC.FTC_CODE]-&gt;[KFTC.KFTCKEY]
        /// </summary>
        public IReadOnlyList<CRFTC> CRFTC_FTC_CODE
        {
            get
            {
                return Context.KFTC.FindCRFTCByFTC_CODE(KFTCKEY);
            }
        }
#endregion
    }
}
