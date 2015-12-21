using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Attendees
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TETN : EduHubEntity
    {

        #region Navigation Property Cache

        private TE Cache_TETNKEY_TE;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Event number
        /// </summary>
        public int TETNKEY { get; internal set; }

        /// <summary>
        /// Link to TID of an event instance
        /// </summary>
        public int? TETELINK { get; internal set; }

        /// <summary>
        /// Attendee type
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ATTENDEE { get; internal set; }

        /// <summary>
        /// Attendee table name
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ATTENDEE_TYPE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (30)]
        /// </summary>
        public string ATTENDEE_DETAIL { get; internal set; }

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
        /// TE (Calendar Events) related entity by [TETN.TETNKEY]-&gt;[TE.TEKEY]
        /// Event number
        /// </summary>
        public TE TETNKEY_TE
        {
            get
            {
                if (Cache_TETNKEY_TE == null)
                {
                    Cache_TETNKEY_TE = Context.TE.FindByTEKEY(TETNKEY);
                }

                return Cache_TETNKEY_TE;
            }
        }

        #endregion

    }
}
