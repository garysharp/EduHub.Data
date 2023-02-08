#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPREPLY : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private SPSMS Cache_CODE_SPSMS;
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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// SMS Key
        /// </summary>
        public int CODE { get; internal set; }

        /// <summary>
        /// TID From SPRECIP
        /// </summary>
        public int? SPRECIP_TID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (255)]
        /// </summary>
        public string MESSAGE { get; internal set; }

        /// <summary>
        /// phone number reply came from
        /// [Alphanumeric (20)]
        /// </summary>
        public string PHONE_NUMBER { get; internal set; }

        /// <summary>
        /// date recieved by recipient (if read receipt required)
        /// </summary>
        public DateTime? RECEIVED_DATE { get; internal set; }

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
        /// SPSMS (SMS messages) related entity by [SPREPLY.CODE]-&gt;[SPSMS.SPSMSKEY]
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

#endif
        #endregion

    }
}
#endif
