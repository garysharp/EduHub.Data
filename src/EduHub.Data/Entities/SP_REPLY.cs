using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Reply Recipient Groups
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SP_REPLY : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SF> Cache_CODE_SF_SMS_REPLY;
        private IReadOnlyList<SP_RECIP> Cache_CODE_SP_RECIP_CODE;
        private IReadOnlyList<SPSMS> Cache_CODE_SPSMS_REPLY_CODE;

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
        /// SMS Reply Recipient Group key
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string Description { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// SF (Staff) related entities by [SP_REPLY.CODE]-&gt;[SF.SMS_REPLY]
        /// SMS Reply Recipient Group key
        /// </summary>
        public IReadOnlyList<SF> CODE_SF_SMS_REPLY
        {
            get
            {
                if (Cache_CODE_SF_SMS_REPLY == null &&
                    !Context.SF.TryFindBySMS_REPLY(CODE, out Cache_CODE_SF_SMS_REPLY))
                {
                    Cache_CODE_SF_SMS_REPLY = new List<SF>().AsReadOnly();
                }

                return Cache_CODE_SF_SMS_REPLY;
            }
        }

        /// <summary>
        /// SP_RECIP (SMS Reply Recipients) related entities by [SP_REPLY.CODE]-&gt;[SP_RECIP.CODE]
        /// SMS Reply Recipient Group key
        /// </summary>
        public IReadOnlyList<SP_RECIP> CODE_SP_RECIP_CODE
        {
            get
            {
                if (Cache_CODE_SP_RECIP_CODE == null &&
                    !Context.SP_RECIP.TryFindByCODE(CODE, out Cache_CODE_SP_RECIP_CODE))
                {
                    Cache_CODE_SP_RECIP_CODE = new List<SP_RECIP>().AsReadOnly();
                }

                return Cache_CODE_SP_RECIP_CODE;
            }
        }

        /// <summary>
        /// SPSMS (SMS messages) related entities by [SP_REPLY.CODE]-&gt;[SPSMS.REPLY_CODE]
        /// SMS Reply Recipient Group key
        /// </summary>
        public IReadOnlyList<SPSMS> CODE_SPSMS_REPLY_CODE
        {
            get
            {
                if (Cache_CODE_SPSMS_REPLY_CODE == null &&
                    !Context.SPSMS.TryFindByREPLY_CODE(CODE, out Cache_CODE_SPSMS_REPLY_CODE))
                {
                    Cache_CODE_SPSMS_REPLY_CODE = new List<SPSMS>().AsReadOnly();
                }

                return Cache_CODE_SPSMS_REPLY_CODE;
            }
        }

        #endregion

    }
}
