#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Reply Recipients
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SP_RECIP : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private SP_REPLY Cache_CODE_SP_REPLY;
#endif
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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// SMS Reply Recipient Group key
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Staff key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SFKEY { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// SP_REPLY (SMS Reply Recipient Groups) related entity by [SP_RECIP.CODE]-&gt;[SP_REPLY.CODE]
        /// SMS Reply Recipient Group key
        /// </summary>
        public SP_REPLY CODE_SP_REPLY
        {
            get
            {
                if (Cache_CODE_SP_REPLY == null)
                {
                    Cache_CODE_SP_REPLY = Context.SP_REPLY.FindByCODE(CODE);
                }

                return Cache_CODE_SP_REPLY;
            }
        }

#endif
        /// <summary>
        /// SF (Staff) related entity by [SP_RECIP.SFKEY]-&gt;[SF.SFKEY]
        /// Staff key
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
#endif
