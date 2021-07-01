using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Trade Type
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<CRTT> Cache_KTTKEY_CRTT_TRADE_TYPE;

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
        /// Trade type key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KTTKEY { get; internal set; }

        /// <summary>
        /// Trade type description
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
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// CRTT (Creditor Trade Types) related entities by [KTT.KTTKEY]-&gt;[CRTT.TRADE_TYPE]
        /// Trade type key
        /// </summary>
        public IReadOnlyList<CRTT> KTTKEY_CRTT_TRADE_TYPE
        {
            get
            {
                if (Cache_KTTKEY_CRTT_TRADE_TYPE == null &&
                    !Context.CRTT.TryFindByTRADE_TYPE(KTTKEY, out Cache_KTTKEY_CRTT_TRADE_TYPE))
                {
                    Cache_KTTKEY_CRTT_TRADE_TYPE = new List<CRTT>().AsReadOnly();
                }

                return Cache_KTTKEY_CRTT_TRADE_TYPE;
            }
        }

        #endregion

    }
}
