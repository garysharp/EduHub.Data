using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Attendees
    /// </summary>
    public partial class TETN : EntityBase
    {
#region Navigation Property Cache
        private TE _TETNKEY_TE;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Event number
        /// </summary>
        public int? TETNKEY { get; internal set; }
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
        /// 
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
                if (TETNKEY.HasValue)
                {
                    if (_TETNKEY_TE == null)
                    {
                        _TETNKEY_TE = Context.TE.FindByTEKEY(TETNKEY.Value);
                    }
                    return _TETNKEY_TE;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
