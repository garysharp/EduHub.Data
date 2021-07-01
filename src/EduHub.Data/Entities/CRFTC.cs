using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Fuel Tax Credits
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRFTC : EduHubEntity
    {

        #region Navigation Property Cache

        private CR Cache_CODE_CR;
        private KFTC Cache_FTC_CODE_KFTC;

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
        /// System transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Creditor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }

        /// <summary>
        /// Transaction reference
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }

        /// <summary>
        /// Fuel Type
        /// [Alphanumeric (5)]
        /// </summary>
        public string FUEL_TYPE { get; internal set; }

        /// <summary>
        /// Fuel Tax Credit code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string FTC_CODE { get; internal set; }

        /// <summary>
        /// Total litres purchased
        /// </summary>
        public double? TOT_LITRES { get; internal set; }

        /// <summary>
        /// Percentage claimed
        /// </summary>
        public double? CLAIM_PERC { get; internal set; }

        /// <summary>
        /// Litres claimed
        /// </summary>
        public double? CLAIM_LITRES { get; internal set; }

        /// <summary>
        /// Amount claimable
        /// </summary>
        public decimal? CLAIM_AMOUNT { get; internal set; }

        /// <summary>
        /// GL period this was claimed in
        /// </summary>
        public int? CLAIM_PERIOD { get; internal set; }

        /// <summary>
        /// Notes
        /// [Memo]
        /// </summary>
        public string NOTES { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// CR (Accounts Payable) related entity by [CRFTC.CODE]-&gt;[CR.CRKEY]
        /// Creditor key
        /// </summary>
        public CR CODE_CR
        {
            get
            {
                if (Cache_CODE_CR == null)
                {
                    Cache_CODE_CR = Context.CR.FindByCRKEY(CODE);
                }

                return Cache_CODE_CR;
            }
        }

        /// <summary>
        /// KFTC (Fuel Tax Credit Rates) related entity by [CRFTC.FTC_CODE]-&gt;[KFTC.KFTCKEY]
        /// Fuel Tax Credit code
        /// </summary>
        public KFTC FTC_CODE_KFTC
        {
            get
            {
                if (FTC_CODE == null)
                {
                    return null;
                }
                if (Cache_FTC_CODE_KFTC == null)
                {
                    Cache_FTC_CODE_KFTC = Context.KFTC.FindByKFTCKEY(FTC_CODE);
                }

                return Cache_FTC_CODE_KFTC;
            }
        }

        #endregion

    }
}
