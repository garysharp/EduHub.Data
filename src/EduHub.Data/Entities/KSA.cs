using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Areas of Teaching
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSA : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SF> Cache_KSAKEY_SF_MAJORA;
        private IReadOnlyList<SF> Cache_KSAKEY_SF_MAJORB;
        private IReadOnlyList<SF> Cache_KSAKEY_SF_MAJORC;

        #endregion

        #region Field Properties

        /// <summary>
        /// Code to identify Area of Teaching
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string KSAKEY { get; internal set; }

        /// <summary>
        /// Descriptive name
        /// [Alphanumeric (30)]
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
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SF (Staff) related entities by [KSA.KSAKEY]-&gt;[SF.MAJORA]
        /// Code to identify Area of Teaching
        /// </summary>
        public IReadOnlyList<SF> KSAKEY_SF_MAJORA
        {
            get
            {
                if (Cache_KSAKEY_SF_MAJORA == null &&
                    !Context.SF.TryFindByMAJORA(KSAKEY, out Cache_KSAKEY_SF_MAJORA))
                {
                    Cache_KSAKEY_SF_MAJORA = new List<SF>().AsReadOnly();
                }

                return Cache_KSAKEY_SF_MAJORA;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KSA.KSAKEY]-&gt;[SF.MAJORB]
        /// Code to identify Area of Teaching
        /// </summary>
        public IReadOnlyList<SF> KSAKEY_SF_MAJORB
        {
            get
            {
                if (Cache_KSAKEY_SF_MAJORB == null &&
                    !Context.SF.TryFindByMAJORB(KSAKEY, out Cache_KSAKEY_SF_MAJORB))
                {
                    Cache_KSAKEY_SF_MAJORB = new List<SF>().AsReadOnly();
                }

                return Cache_KSAKEY_SF_MAJORB;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KSA.KSAKEY]-&gt;[SF.MAJORC]
        /// Code to identify Area of Teaching
        /// </summary>
        public IReadOnlyList<SF> KSAKEY_SF_MAJORC
        {
            get
            {
                if (Cache_KSAKEY_SF_MAJORC == null &&
                    !Context.SF.TryFindByMAJORC(KSAKEY, out Cache_KSAKEY_SF_MAJORC))
                {
                    Cache_KSAKEY_SF_MAJORC = new List<SF>().AsReadOnly();
                }

                return Cache_KSAKEY_SF_MAJORC;
            }
        }

        #endregion

    }
}
