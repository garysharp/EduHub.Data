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

        #region Foreign Navigation Properties

        private IReadOnlyList<SPRECIP> Cache_SPSMSKEY_SPRECIP_CODE;
        private IReadOnlyList<SPREPLY> Cache_SPSMSKEY_SPREPLY_CODE;

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

        #endregion

    }
}
