#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fuel Tax Credit Rates
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFTC : EduHubEntity
    {

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<CRFTC> Cache_KFTCKEY_CRFTC_FTC_CODE;
#endif

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

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// CRFTC (Creditor Fuel Tax Credits) related entities by [KFTC.KFTCKEY]-&gt;[CRFTC.FTC_CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRFTC> KFTCKEY_CRFTC_FTC_CODE
        {
            get
            {
                if (Cache_KFTCKEY_CRFTC_FTC_CODE == null &&
                    !Context.CRFTC.TryFindByFTC_CODE(KFTCKEY, out Cache_KFTCKEY_CRFTC_FTC_CODE))
                {
                    Cache_KFTCKEY_CRFTC_FTC_CODE = new List<CRFTC>().AsReadOnly();
                }

                return Cache_KFTCKEY_CRFTC_FTC_CODE;
            }
        }

#endif
        #endregion

    }
}
#endif
