using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Instigators
    /// </summary>
    public partial class SDP : EntityBase
    {
#region Navigation Property Cache
        private SID _INCIDENT_KEY_SID;
        private ST _STUDENT_KEY_ST;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int SDPKEY { get; internal set; }
        /// <summary>
        /// Number of the incident
        /// </summary>
        public int? INCIDENT_KEY { get; internal set; }
        /// <summary>
        /// Incident descriptor (copied from SID record for the MOREINFO band)
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string INCIDENT_TYPE { get; internal set; }
        /// <summary>
        /// Incident date (copied from SID record for the MOREINFO band)
        /// </summary>
        public DateTime? INCIDENT_DATE { get; internal set; }
        /// <summary>
        /// Code of student who instigated the incident
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT_KEY { get; internal set; }
        /// <summary>
        /// Description of the student's involvement
        /// [Memo]
        /// </summary>
        public string INVOLVEMENT_DESC { get; internal set; }
        /// <summary>
        /// Date on which to follow up the incident
        /// </summary>
        public DateTime? FOLLOW_UP_DATE { get; internal set; }
        /// <summary>
        /// Details of follow-up required
        /// [Memo]
        /// </summary>
        public string FOLLOW_UP_DETAILS { get; internal set; }
        /// <summary>
        /// Outcome of follow-up
        /// [Memo]
        /// </summary>
        public string FOLLOW_UP_OUTCOME { get; internal set; }
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
        /// SID (Disciplinary Incidents) related entity by [SDP.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// Number of the incident
        /// </summary>
        public SID INCIDENT_KEY_SID
        {
            get
            {
                if (INCIDENT_KEY.HasValue)
                {
                    if (_INCIDENT_KEY_SID == null)
                    {
                        _INCIDENT_KEY_SID = Context.SID.FindBySIDKEY(INCIDENT_KEY.Value);
                    }
                    return _INCIDENT_KEY_SID;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// ST (Students) related entity by [SDP.STUDENT_KEY]-&gt;[ST.STKEY]
        /// Code of student who instigated the incident
        /// </summary>
        public ST STUDENT_KEY_ST
        {
            get
            {
                if (STUDENT_KEY != null)
                {
                    if (_STUDENT_KEY_ST == null)
                    {
                        _STUDENT_KEY_ST = Context.ST.FindBySTKEY(STUDENT_KEY);
                    }
                    return _STUDENT_KEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SDPA (Disciplinary Actions) related entities by [SDPA.SDP_STUDENT]-&gt;[SDP.SDPKEY]
        /// </summary>
        public IReadOnlyList<SDPA> SDPA_SDP_STUDENT
        {
            get
            {
                return Context.SDP.FindSDPABySDP_STUDENT(SDPKEY);
            }
        }
#endregion
    }
}
