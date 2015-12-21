using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Note Categories
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPN : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<PEPY> Cache_KPNKEY_PEPY_PURPOSE;

        #endregion

        #region Field Properties

        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KPNKEY { get; internal set; }

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
        /// PEPY (Employee History) related entities by [KPN.KPNKEY]-&gt;[PEPY.PURPOSE]
        /// Key
        /// </summary>
        public IReadOnlyList<PEPY> KPNKEY_PEPY_PURPOSE
        {
            get
            {
                if (Cache_KPNKEY_PEPY_PURPOSE == null &&
                    !Context.PEPY.TryFindByPURPOSE(KPNKEY, out Cache_KPNKEY_PEPY_PURPOSE))
                {
                    Cache_KPNKEY_PEPY_PURPOSE = new List<PEPY>().AsReadOnly();
                }

                return Cache_KPNKEY_PEPY_PURPOSE;
            }
        }

        #endregion

    }
}
