using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Categories
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TEC : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<TE> Cache_CATEGORY_TE_CATEGORY;

        #endregion

        #region Field Properties

        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CATEGORY { get; internal set; }

        /// <summary>
        /// Title
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
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// TE (Calendar Events) related entities by [TEC.CATEGORY]-&gt;[TE.CATEGORY]
        /// Key
        /// </summary>
        public IReadOnlyList<TE> CATEGORY_TE_CATEGORY
        {
            get
            {
                if (Cache_CATEGORY_TE_CATEGORY == null &&
                    !Context.TE.TryFindByCATEGORY(CATEGORY, out Cache_CATEGORY_TE_CATEGORY))
                {
                    Cache_CATEGORY_TE_CATEGORY = new List<TE>().AsReadOnly();
                }

                return Cache_CATEGORY_TE_CATEGORY;
            }
        }

        #endregion

    }
}
