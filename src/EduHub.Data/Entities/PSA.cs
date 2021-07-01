using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Award Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSA : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<PI> Cache_PSAKEY_PI_AWARD;

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
        /// oldname=PSKEY; * Award Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PSAKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Type of award. Inlist
        /// [Alphanumeric (3)]
        /// </summary>
        public string AWARD_TYPE { get; internal set; }

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
        /// PI (Pay Items) related entities by [PSA.PSAKEY]-&gt;[PI.AWARD]
        /// oldname=PSKEY; * Award Code
        /// </summary>
        public IReadOnlyList<PI> PSAKEY_PI_AWARD
        {
            get
            {
                if (Cache_PSAKEY_PI_AWARD == null &&
                    !Context.PI.TryFindByAWARD(PSAKEY, out Cache_PSAKEY_PI_AWARD))
                {
                    Cache_PSAKEY_PI_AWARD = new List<PI>().AsReadOnly();
                }

                return Cache_PSAKEY_PI_AWARD;
            }
        }

        #endregion

    }
}
