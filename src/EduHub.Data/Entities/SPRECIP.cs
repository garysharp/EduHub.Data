using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPRECIP : EduHubEntity
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
        /// Database table key comes from
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string RECIPIENT_TABLE { get; internal set; }

        /// <summary>
        /// Recipient Key
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string RECIPIENT_KEY { get; internal set; }

        /// <summary>
        /// Recipient mobile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string RECIPIENT_NUMBER { get; internal set; }

        /// <summary>
        /// read reciept required
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string READ_RECEIPT { get; internal set; }

        /// <summary>
        /// Database table source key comes from
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SOURCE_TABLE { get; internal set; }

        /// <summary>
        /// Source Key - Record that caused the SMS to be sent (eg absentee, sickbay etc)
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SOURCE_KEY { get; internal set; }

        /// <summary>
        /// Send Status, P = Pending, S = Sent, E = Error
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STATUS { get; internal set; }

        /// <summary>
        /// any messages produced by RMCS when sending
        /// [Alphanumeric (100)]
        /// </summary>
        public string STATUS_MESSAGE { get; internal set; }

        /// <summary>
        /// date/time message was sent
        /// </summary>
        public DateTime? SEND_DATE { get; internal set; }

        /// <summary>
        /// date recieved by recipient (if read receipt required)
        /// </summary>
        public DateTime? DELIVERED_DATE { get; internal set; }

        /// <summary>
        /// SMS Provider Message Id
        /// </summary>
        public int? MESSAGEID { get; internal set; }

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
        /// SPSMS (SMS messages) related entity by [SPRECIP.CODE]-&gt;[SPSMS.SPSMSKEY]
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
