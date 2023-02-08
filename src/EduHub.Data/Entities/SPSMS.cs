#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS messages
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPSMS : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private SP_REPLY Cache_REPLY_CODE_SP_REPLY;
#endif

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<SPRECIP> Cache_SPSMSKEY_SPRECIP_CODE;
        private IReadOnlyList<SPREPLY> Cache_SPSMSKEY_SPREPLY_CODE;
        private IReadOnlyList<SPRETRY> Cache_SPSMSKEY_SPRETRY_CODE;
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
        /// Key
        /// </summary>
        public int SPSMSKEY { get; internal set; }

        /// <summary>
        /// Message to send
        /// [Alphanumeric (160)]
        /// </summary>
        public string MESSAGE { get; internal set; }

        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime? CREATED_DATE { get; internal set; }

        /// <summary>
        /// Who created the message.
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CREATED_BY { get; internal set; }

        /// <summary>
        /// Notify the originator of the SMS of any reply
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NOTIFY_REPLIES { get; internal set; }

        /// <summary>
        /// Set to Y if SMS automatically generated.
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AUTO_MESSAGE { get; internal set; }

        /// <summary>
        /// Emergency SMS Flag
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMERGENCY { get; internal set; }

        /// <summary>
        /// SMS Reply Recipient Group key
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string REPLY_CODE { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// SP_REPLY (SMS Reply Recipient Groups) related entity by [SPSMS.REPLY_CODE]-&gt;[SP_REPLY.CODE]
        /// SMS Reply Recipient Group key
        /// </summary>
        public SP_REPLY REPLY_CODE_SP_REPLY
        {
            get
            {
                if (REPLY_CODE == null)
                {
                    return null;
                }
                if (Cache_REPLY_CODE_SP_REPLY == null)
                {
                    Cache_REPLY_CODE_SP_REPLY = Context.SP_REPLY.FindByCODE(REPLY_CODE);
                }

                return Cache_REPLY_CODE_SP_REPLY;
            }
        }

#endif
        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// SPRECIP (SMS Recipients) related entities by [SPSMS.SPSMSKEY]-&gt;[SPRECIP.CODE]
        /// Key
        /// </summary>
        public IReadOnlyList<SPRECIP> SPSMSKEY_SPRECIP_CODE
        {
            get
            {
                if (Cache_SPSMSKEY_SPRECIP_CODE == null &&
                    !Context.SPRECIP.TryFindByCODE(SPSMSKEY, out Cache_SPSMSKEY_SPRECIP_CODE))
                {
                    Cache_SPSMSKEY_SPRECIP_CODE = new List<SPRECIP>().AsReadOnly();
                }

                return Cache_SPSMSKEY_SPRECIP_CODE;
            }
        }

        /// <summary>
        /// SPREPLY (SMS Recipients) related entities by [SPSMS.SPSMSKEY]-&gt;[SPREPLY.CODE]
        /// Key
        /// </summary>
        public IReadOnlyList<SPREPLY> SPSMSKEY_SPREPLY_CODE
        {
            get
            {
                if (Cache_SPSMSKEY_SPREPLY_CODE == null &&
                    !Context.SPREPLY.TryFindByCODE(SPSMSKEY, out Cache_SPSMSKEY_SPREPLY_CODE))
                {
                    Cache_SPSMSKEY_SPREPLY_CODE = new List<SPREPLY>().AsReadOnly();
                }

                return Cache_SPSMSKEY_SPREPLY_CODE;
            }
        }

        /// <summary>
        /// SPRETRY (SMS Retries) related entities by [SPSMS.SPSMSKEY]-&gt;[SPRETRY.CODE]
        /// Key
        /// </summary>
        public IReadOnlyList<SPRETRY> SPSMSKEY_SPRETRY_CODE
        {
            get
            {
                if (Cache_SPSMSKEY_SPRETRY_CODE == null &&
                    !Context.SPRETRY.TryFindByCODE(SPSMSKEY, out Cache_SPSMSKEY_SPRETRY_CODE))
                {
                    Cache_SPSMSKEY_SPRETRY_CODE = new List<SPRETRY>().AsReadOnly();
                }

                return Cache_SPSMSKEY_SPRETRY_CODE;
            }
        }

#endif
        #endregion

    }
}
#endif
