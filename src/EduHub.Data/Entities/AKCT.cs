using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Tax
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKCT : EduHubEntity
    {

        #region Navigation Property Cache

        private KADM Cache_DEPN_TMETHOD_KADM;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_CATEGORY_AR_TAX_CATEGORY;

        #endregion

        #region Field Properties

        /// <summary>
        /// Prime Key (formerly GROUP)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CATEGORY { get; internal set; }

        /// <summary>
        /// Description of category
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Default deprn method for taxation
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DEPN_TMETHOD { get; internal set; }

        /// <summary>
        /// Default deprn rate for taxation
        /// </summary>
        public double? DEPN_TRATE { get; internal set; }

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
        /// KADM (Asset Depreciation Methods) related entity by [AKCT.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// Default deprn method for taxation
        /// </summary>
        public KADM DEPN_TMETHOD_KADM
        {
            get
            {
                if (DEPN_TMETHOD == null)
                {
                    return null;
                }
                if (Cache_DEPN_TMETHOD_KADM == null)
                {
                    Cache_DEPN_TMETHOD_KADM = Context.KADM.FindByKADMKEY(DEPN_TMETHOD);
                }

                return Cache_DEPN_TMETHOD_KADM;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// AR (Assets) related entities by [AKCT.CATEGORY]-&gt;[AR.TAX_CATEGORY]
        /// Prime Key (formerly GROUP)
        /// </summary>
        public IReadOnlyList<AR> CATEGORY_AR_TAX_CATEGORY
        {
            get
            {
                if (Cache_CATEGORY_AR_TAX_CATEGORY == null &&
                    !Context.AR.TryFindByTAX_CATEGORY(CATEGORY, out Cache_CATEGORY_AR_TAX_CATEGORY))
                {
                    Cache_CATEGORY_AR_TAX_CATEGORY = new List<AR>().AsReadOnly();
                }

                return Cache_CATEGORY_AR_TAX_CATEGORY;
            }
        }

        #endregion

    }
}
