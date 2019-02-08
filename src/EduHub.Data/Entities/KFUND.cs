using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GL Bank Fund
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFUND : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<GLFBANK> Cache_FUND_ID_GLFBANK_FUND_ID;

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
        /// Fund ID, eg I
        /// </summary>
        public short FUND_ID { get; internal set; }

        /// <summary>
        /// eg, INCOME
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Allow account to be used(Y/N)
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
        /// GLFBANK (Financial Commitments) related entities by [KFUND.FUND_ID]-&gt;[GLFBANK.FUND_ID]
        /// Fund ID, eg I
        /// </summary>
        public IReadOnlyList<GLFBANK> FUND_ID_GLFBANK_FUND_ID
        {
            get
            {
                if (Cache_FUND_ID_GLFBANK_FUND_ID == null &&
                    !Context.GLFBANK.TryFindByFUND_ID(FUND_ID, out Cache_FUND_ID_GLFBANK_FUND_ID))
                {
                    Cache_FUND_ID_GLFBANK_FUND_ID = new List<GLFBANK>().AsReadOnly();
                }

                return Cache_FUND_ID_GLFBANK_FUND_ID;
            }
        }

        #endregion

    }
}
