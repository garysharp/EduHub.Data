using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Purchasing Card
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCPC : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_STAFF_SF;
        private SCI Cache_CAMPUS_SCI;

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
        /// Creditor Purchasing Card Sequence
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Staff
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }

        /// <summary>
        /// Cardholder Name
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string CARDHOLDER_NAME { get; internal set; }

        /// <summary>
        /// Card No (last 4 digits)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string CARD_NO { get; internal set; }

        /// <summary>
        /// Position
        /// [Alphanumeric (10)]
        /// </summary>
        public string STAFF_POSITION { get; internal set; }

        /// <summary>
        /// Issue Date
        /// </summary>
        public DateTime? ISSUE_DATE { get; internal set; }

        /// <summary>
        /// Expiry Month 1-12
        /// </summary>
        public short? EXPIRY_MONTH { get; internal set; }

        /// <summary>
        /// Expiry Year
        /// </summary>
        public short? EXPIRY_YEAR { get; internal set; }

        /// <summary>
        /// Campus
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Undertaking by Cardholder
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string UNDERTAKING_CARDHOLDER { get; internal set; }

        /// <summary>
        /// Card Limit per Month
        /// </summary>
        public decimal? CARD_LIMIT { get; internal set; }

        /// <summary>
        /// Change Comments
        /// [Memo]
        /// </summary>
        public string CHANGE_LIMIT { get; internal set; }

        /// <summary>
        /// Cancellation Date
        /// </summary>
        public DateTime? CANCELLATION_DATE { get; internal set; }

        /// <summary>
        /// 3 stage field - Yes, No, null
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }

        /// <summary>
        /// Has this been previously processed? Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PROCESSED { get; internal set; }

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
        /// SF (Staff) related entity by [KCPC.STAFF]-&gt;[SF.SFKEY]
        /// Staff
        /// </summary>
        public SF STAFF_SF
        {
            get
            {
                if (STAFF == null)
                {
                    return null;
                }
                if (Cache_STAFF_SF == null)
                {
                    Cache_STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                }

                return Cache_STAFF_SF;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [KCPC.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        #endregion

    }
}
