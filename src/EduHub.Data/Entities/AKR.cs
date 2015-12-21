using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Release Types
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKR : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_AKRKEY_AR_RELEASE_TYPE;
        private IReadOnlyList<ARF> Cache_AKRKEY_ARF_RELEASE_TYPE;

        #endregion

        #region Field Properties

        /// <summary>
        /// Asset Release Type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string AKRKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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
        /// AR (Assets) related entities by [AKR.AKRKEY]-&gt;[AR.RELEASE_TYPE]
        /// Asset Release Type
        /// </summary>
        public IReadOnlyList<AR> AKRKEY_AR_RELEASE_TYPE
        {
            get
            {
                if (Cache_AKRKEY_AR_RELEASE_TYPE == null &&
                    !Context.AR.TryFindByRELEASE_TYPE(AKRKEY, out Cache_AKRKEY_AR_RELEASE_TYPE))
                {
                    Cache_AKRKEY_AR_RELEASE_TYPE = new List<AR>().AsReadOnly();
                }

                return Cache_AKRKEY_AR_RELEASE_TYPE;
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [AKR.AKRKEY]-&gt;[ARF.RELEASE_TYPE]
        /// Asset Release Type
        /// </summary>
        public IReadOnlyList<ARF> AKRKEY_ARF_RELEASE_TYPE
        {
            get
            {
                if (Cache_AKRKEY_ARF_RELEASE_TYPE == null &&
                    !Context.ARF.TryFindByRELEASE_TYPE(AKRKEY, out Cache_AKRKEY_ARF_RELEASE_TYPE))
                {
                    Cache_AKRKEY_ARF_RELEASE_TYPE = new List<ARF>().AsReadOnly();
                }

                return Cache_AKRKEY_ARF_RELEASE_TYPE;
            }
        }

        #endregion

    }
}
