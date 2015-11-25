using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Role Codes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KROLE : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<KREPORT> Cache_KROLEKEY_KREPORT_ROLE_CODE;

        #endregion

        #region Field Properties

        /// <summary>
        /// Code
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string KROLEKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Role for the code
        /// [Uppercase Alphanumeric (32)]
        /// </summary>
        public string ROLE_NAME { get; internal set; }

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
        /// KREPORT (Reports for emailing) related entities by [KROLE.KROLEKEY]-&gt;[KREPORT.ROLE_CODE]
        /// Code
        /// </summary>
        public IReadOnlyList<KREPORT> KROLEKEY_KREPORT_ROLE_CODE
        {
            get
            {
                if (Cache_KROLEKEY_KREPORT_ROLE_CODE == null &&
                    !Context.KREPORT.TryFindByROLE_CODE(KROLEKEY, out Cache_KROLEKEY_KREPORT_ROLE_CODE))
                {
                    Cache_KROLEKEY_KREPORT_ROLE_CODE = new List<KREPORT>().AsReadOnly();
                }

                return Cache_KROLEKEY_KREPORT_ROLE_CODE;
            }
        }

        #endregion

    }
}
