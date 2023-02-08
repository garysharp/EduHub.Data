#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payment Summary Box
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PG : EduHubEntity
    {

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<PI> Cache_PAYG_BOX_PI_PAYG_BOX;
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
        /// PAYG Payment summary Box
        /// </summary>
        public short PAYG_BOX { get; internal set; }

        /// <summary>
        /// Description of group
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

#if !EduHubScoped
        /// <summary>
        /// PI (Pay Items) related entities by [PG.PAYG_BOX]-&gt;[PI.PAYG_BOX]
        /// PAYG Payment summary Box
        /// </summary>
        public IReadOnlyList<PI> PAYG_BOX_PI_PAYG_BOX
        {
            get
            {
                if (Cache_PAYG_BOX_PI_PAYG_BOX == null &&
                    !Context.PI.TryFindByPAYG_BOX(PAYG_BOX, out Cache_PAYG_BOX_PI_PAYG_BOX))
                {
                    Cache_PAYG_BOX_PI_PAYG_BOX = new List<PI>().AsReadOnly();
                }

                return Cache_PAYG_BOX_PI_PAYG_BOX;
            }
        }

#endif
        #endregion

    }
}
#endif
