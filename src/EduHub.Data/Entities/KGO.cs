using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Occupations
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGO : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<STSUP> Cache_KGOKEY_STSUP_SUPPORT_ROLE;

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
        /// Occupation key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KGOKEY { get; internal set; }

        /// <summary>
        /// Occupation title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// STSUP (Support Persons) related entities by [KGO.KGOKEY]-&gt;[STSUP.SUPPORT_ROLE]
        /// Occupation key
        /// </summary>
        public IReadOnlyList<STSUP> KGOKEY_STSUP_SUPPORT_ROLE
        {
            get
            {
                if (Cache_KGOKEY_STSUP_SUPPORT_ROLE == null &&
                    !Context.STSUP.TryFindBySUPPORT_ROLE(KGOKEY, out Cache_KGOKEY_STSUP_SUPPORT_ROLE))
                {
                    Cache_KGOKEY_STSUP_SUPPORT_ROLE = new List<STSUP>().AsReadOnly();
                }

                return Cache_KGOKEY_STSUP_SUPPORT_ROLE;
            }
        }

        #endregion

    }
}
