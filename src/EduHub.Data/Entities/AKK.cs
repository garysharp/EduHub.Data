using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Key Holders
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKK : EduHubEntity
    {

        #region Navigation Property Cache

        private AR Cache_CODE_AR;
        private SF Cache_STAFF_SF;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Asset code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Staff
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }

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

        #region Navigation Properties

        /// <summary>
        /// AR (Assets) related entity by [AKK.CODE]-&gt;[AR.ARKEY]
        /// Asset code
        /// </summary>
        public AR CODE_AR
        {
            get
            {
                if (Cache_CODE_AR == null)
                {
                    Cache_CODE_AR = Context.AR.FindByARKEY(CODE);
                }

                return Cache_CODE_AR;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [AKK.STAFF]-&gt;[SF.SFKEY]
        /// Staff
        /// </summary>
        public SF STAFF_SF
        {
            get
            {
                if (STAFF == null)
                {
                    return null;
                }
                if (Cache_STAFF_SF == null)
                {
                    Cache_STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                }

                return Cache_STAFF_SF;
            }
        }

        #endregion

    }
}
