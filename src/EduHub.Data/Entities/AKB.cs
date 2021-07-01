using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Sub-Category
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKB : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_BRANCH_AR_BRANCH;

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
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string BRANCH { get; internal set; }

        /// <summary>
        /// Description of branch
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
        /// AR (Assets) related entities by [AKB.BRANCH]-&gt;[AR.BRANCH]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<AR> BRANCH_AR_BRANCH
        {
            get
            {
                if (Cache_BRANCH_AR_BRANCH == null &&
                    !Context.AR.TryFindByBRANCH(BRANCH, out Cache_BRANCH_AR_BRANCH))
                {
                    Cache_BRANCH_AR_BRANCH = new List<AR>().AsReadOnly();
                }

                return Cache_BRANCH_AR_BRANCH;
            }
        }

        #endregion

    }
}
