using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Types
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_AKTKEY_AR_ASSET_TYPE;

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
        /// Asset Type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string AKTKEY { get; internal set; }

        /// <summary>
        /// Description
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
        /// AR (Assets) related entities by [AKT.AKTKEY]-&gt;[AR.ASSET_TYPE]
        /// Asset Type
        /// </summary>
        public IReadOnlyList<AR> AKTKEY_AR_ASSET_TYPE
        {
            get
            {
                if (Cache_AKTKEY_AR_ASSET_TYPE == null &&
                    !Context.AR.TryFindByASSET_TYPE(AKTKEY, out Cache_AKTKEY_AR_ASSET_TYPE))
                {
                    Cache_AKTKEY_AR_ASSET_TYPE = new List<AR>().AsReadOnly();
                }

                return Cache_AKTKEY_AR_ASSET_TYPE;
            }
        }

        #endregion

    }
}
