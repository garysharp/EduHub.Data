using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Purchasing Group Link
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQREL : EduHubEntity
    {

        #region Navigation Property Cache

        private RQPG Cache_RQPGKEY_RQPG;
        private SF Cache_SFKEY_SF;

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
        /// &lt;No documentation available&gt;
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Purchasing Group
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string RQPGKEY { get; internal set; }

        /// <summary>
        /// Staff
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SFKEY { get; internal set; }

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
        /// RQPG (Purchasing Group) related entity by [RQREL.RQPGKEY]-&gt;[RQPG.RQPGKEY]
        /// Purchasing Group
        /// </summary>
        public RQPG RQPGKEY_RQPG
        {
            get
            {
                if (Cache_RQPGKEY_RQPG == null)
                {
                    Cache_RQPGKEY_RQPG = Context.RQPG.FindByRQPGKEY(RQPGKEY);
                }

                return Cache_RQPGKEY_RQPG;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [RQREL.SFKEY]-&gt;[SF.SFKEY]
        /// Staff
        /// </summary>
        public SF SFKEY_SF
        {
            get
            {
                if (SFKEY == null)
                {
                    return null;
                }
                if (Cache_SFKEY_SF == null)
                {
                    Cache_SFKEY_SF = Context.SF.FindBySFKEY(SFKEY);
                }

                return Cache_SFKEY_SF;
            }
        }

        #endregion

    }
}
