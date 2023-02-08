#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAM : EduHubEntity
    {

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<SDPA> Cache_KAMKEY_SDPA_ACTION_TAKEN;
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
        /// Code to identify standard disciplinary action
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string KAMKEY { get; internal set; }

        /// <summary>
        /// Brief description of disciplinary action
        /// [Alphanumeric (40)]
        /// </summary>
        public string BRIEF { get; internal set; }

        /// <summary>
        /// Full description of disciplinary action
        /// [Memo]
        /// </summary>
        public string DETAIL { get; internal set; }

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

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// SDPA (Disciplinary Actions) related entities by [KAM.KAMKEY]-&gt;[SDPA.ACTION_TAKEN]
        /// Code to identify standard disciplinary action
        /// </summary>
        public IReadOnlyList<SDPA> KAMKEY_SDPA_ACTION_TAKEN
        {
            get
            {
                if (Cache_KAMKEY_SDPA_ACTION_TAKEN == null &&
                    !Context.SDPA.TryFindByACTION_TAKEN(KAMKEY, out Cache_KAMKEY_SDPA_ACTION_TAKEN))
                {
                    Cache_KAMKEY_SDPA_ACTION_TAKEN = new List<SDPA>().AsReadOnly();
                }

                return Cache_KAMKEY_SDPA_ACTION_TAKEN;
            }
        }

#endif
        #endregion

    }
}
#endif
