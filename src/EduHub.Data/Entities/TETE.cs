﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Instances
    /// </summary>
    public partial class TETE : EntityBase
    {
#region Navigation Property Cache
        private TE _TETEKEY_TE;
        private SM _LOCATION_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Owner relation
        /// </summary>
        public int? TETEKEY { get; internal set; }
        /// <summary>
        /// Event date
        /// </summary>
        public DateTime? EVENT_DATE { get; internal set; }
        /// <summary>
        /// Extra comments
        /// [Memo]
        /// </summary>
        public string COMMENTS { get; internal set; }
        /// <summary>
        /// Start time of event
        /// </summary>
        public DateTime? TIME_FROM { get; internal set; }
        /// <summary>
        /// End time of event
        /// </summary>
        public DateTime? TIME_TO { get; internal set; }
        /// <summary>
        /// Person responible for the event
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CONVENOR { get; internal set; }
        /// <summary>
        /// Convenor table name
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CONVENOR_TYPE { get; internal set; }
        /// <summary>
        /// Location of the event
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string LOCATION { get; internal set; }
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
        /// TE (Calendar Events) related entity by [TETE.TETEKEY]-&gt;[TE.TEKEY]
        /// Owner relation
        /// </summary>
        public TE TETEKEY_TE
        {
            get
            {
                if (TETEKEY.HasValue)
                {
                    if (_TETEKEY_TE == null)
                    {
                        _TETEKEY_TE = Context.TE.FindByTEKEY(TETEKEY.Value);
                    }
                    return _TETEKEY_TE;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [TETE.LOCATION]-&gt;[SM.ROOM]
        /// Location of the event
        /// </summary>
        public SM LOCATION_SM
        {
            get
            {
                if (LOCATION != null)
                {
                    if (_LOCATION_SM == null)
                    {
                        _LOCATION_SM = Context.SM.FindByROOM(LOCATION);
                    }
                    return _LOCATION_SM;
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
