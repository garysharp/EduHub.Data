using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fee Groups
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDG : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SDGM> Cache_SDGKEY_SDGM_SDGMKEY;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Short name of Fee Group
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SDGKEY { get; internal set; }

        /// <summary>
        /// Long name of Fee Group
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Member Type = Other/Employee/Both
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MEMBER_TYPE { get; internal set; }

        /// <summary>
        /// Comments
        /// [Memo]
        /// </summary>
        public string SDG_MEMO { get; internal set; }

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
        /// SDGM (Adult Group Members) related entities by [SDG.SDGKEY]-&gt;[SDGM.SDGMKEY]
        /// Short name of Fee Group
        /// </summary>
        public IReadOnlyList<SDGM> SDGKEY_SDGM_SDGMKEY
        {
            get
            {
                if (Cache_SDGKEY_SDGM_SDGMKEY == null &&
                    !Context.SDGM.TryFindBySDGMKEY(SDGKEY, out Cache_SDGKEY_SDGM_SDGMKEY))
                {
                    Cache_SDGKEY_SDGM_SDGMKEY = new List<SDGM>().AsReadOnly();
                }

                return Cache_SDGKEY_SDGM_SDGMKEY;
            }
        }

        #endregion

    }
}
