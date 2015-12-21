using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSC : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SF> Cache_KSCKEY_SF_POS_CODE_A;
        private IReadOnlyList<SF> Cache_KSCKEY_SF_POS_CODE_B;

        #endregion

        #region Field Properties

        /// <summary>
        /// Position code
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KSCKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string SF_POSITION { get; internal set; }

        /// <summary>
        /// Period allowance for this position
        /// </summary>
        public short? ALLOTMENT { get; internal set; }

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
        /// SF (Staff) related entities by [KSC.KSCKEY]-&gt;[SF.POS_CODE_A]
        /// Position code
        /// </summary>
        public IReadOnlyList<SF> KSCKEY_SF_POS_CODE_A
        {
            get
            {
                if (Cache_KSCKEY_SF_POS_CODE_A == null &&
                    !Context.SF.TryFindByPOS_CODE_A(KSCKEY, out Cache_KSCKEY_SF_POS_CODE_A))
                {
                    Cache_KSCKEY_SF_POS_CODE_A = new List<SF>().AsReadOnly();
                }

                return Cache_KSCKEY_SF_POS_CODE_A;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KSC.KSCKEY]-&gt;[SF.POS_CODE_B]
        /// Position code
        /// </summary>
        public IReadOnlyList<SF> KSCKEY_SF_POS_CODE_B
        {
            get
            {
                if (Cache_KSCKEY_SF_POS_CODE_B == null &&
                    !Context.SF.TryFindByPOS_CODE_B(KSCKEY, out Cache_KSCKEY_SF_POS_CODE_B))
                {
                    Cache_KSCKEY_SF_POS_CODE_B = new List<SF>().AsReadOnly();
                }

                return Cache_KSCKEY_SF_POS_CODE_B;
            }
        }

        #endregion

    }
}
