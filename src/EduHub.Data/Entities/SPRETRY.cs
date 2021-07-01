using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Retries
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPRETRY : EduHubEntity
    {

        #region Navigation Property Cache

        private SPSMS Cache_CODE_SPSMS;

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
        /// SMS Key
        /// </summary>
        public int CODE { get; internal set; }

        /// <summary>
        /// SPRECIP TID key of recipient record that is being resent.
        /// </summary>
        public int? SPRECIP { get; internal set; }

        /// <summary>
        /// Original value for SPRECIP.SEND_DATE at the time of the error and the retry.
        /// </summary>
        public DateTime? RETRY { get; internal set; }

        /// <summary>
        /// Original value for SPRECIP.STATUS_MESSAGE at the time of failure and retry.
        /// [Alphanumeric (100)]
        /// </summary>
        public string STATUS_MESSAGE { get; internal set; }

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

        #region Navigation Properties

        /// <summary>
        /// SPSMS (SMS messages) related entity by [SPRETRY.CODE]-&gt;[SPSMS.SPSMSKEY]
        /// SMS Key
        /// </summary>
        public SPSMS CODE_SPSMS
        {
            get
            {
                if (Cache_CODE_SPSMS == null)
                {
                    Cache_CODE_SPSMS = Context.SPSMS.FindBySPSMSKEY(CODE);
                }

                return Cache_CODE_SPSMS;
            }
        }

        #endregion

    }
}
