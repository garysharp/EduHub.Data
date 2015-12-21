using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Prerequisites
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUPR : EduHubEntity
    {

        #region Navigation Property Cache

        private SU Cache_SUPRKEY_SU;
        private SU Cache_PREREQUISITE_SU;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Subject code of this subject
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUPRKEY { get; internal set; }

        /// <summary>
        /// Subject code of this subject's prerequisite
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string PREREQUISITE { get; internal set; }

        /// <summary>
        /// Result as prerequisite (not implemented)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESULT { get; internal set; }

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
        /// SU (Subjects) related entity by [SUPR.SUPRKEY]-&gt;[SU.SUKEY]
        /// Subject code of this subject
        /// </summary>
        public SU SUPRKEY_SU
        {
            get
            {
                if (Cache_SUPRKEY_SU == null)
                {
                    Cache_SUPRKEY_SU = Context.SU.FindBySUKEY(SUPRKEY);
                }

                return Cache_SUPRKEY_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SUPR.PREREQUISITE]-&gt;[SU.SUKEY]
        /// Subject code of this subject's prerequisite
        /// </summary>
        public SU PREREQUISITE_SU
        {
            get
            {
                if (PREREQUISITE == null)
                {
                    return null;
                }
                if (Cache_PREREQUISITE_SU == null)
                {
                    Cache_PREREQUISITE_SU = Context.SU.FindBySUKEY(PREREQUISITE);
                }

                return Cache_PREREQUISITE_SU;
            }
        }

        #endregion

    }
}
