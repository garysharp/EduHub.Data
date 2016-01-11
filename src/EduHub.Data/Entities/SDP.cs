using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Instigators
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDP : EduHubEntity
    {

        #region Navigation Property Cache

        private SID Cache_INCIDENT_KEY_SID;
        private ST Cache_STUDENT_KEY_ST;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SDPA> Cache_SDPKEY_SDPA_SDP_STUDENT;

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
                if (INCIDENT_KEY == null)
                {
                    return null;
                }
                if (Cache_INCIDENT_KEY_SID == null)
                {
                    Cache_INCIDENT_KEY_SID = Context.SID.FindBySIDKEY(INCIDENT_KEY.Value);
                }

                return Cache_INCIDENT_KEY_SID;
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
                if (STUDENT_KEY == null)
                {
                    return null;
                }
                if (Cache_STUDENT_KEY_ST == null)
                {
                    Cache_STUDENT_KEY_ST = Context.ST.FindBySTKEY(STUDENT_KEY);
                }

                return Cache_STUDENT_KEY_ST;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SDPA (Disciplinary Actions) related entities by [SDP.SDPKEY]-&gt;[SDPA.SDP_STUDENT]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SDPA> SDPKEY_SDPA_SDP_STUDENT
        {
            get
            {
                if (Cache_SDPKEY_SDPA_SDP_STUDENT == null &&
                    !Context.SDPA.TryFindBySDP_STUDENT(SDPKEY, out Cache_SDPKEY_SDPA_SDP_STUDENT))
                {
                    Cache_SDPKEY_SDPA_SDP_STUDENT = new List<SDPA>().AsReadOnly();
                }

                return Cache_SDPKEY_SDPA_SDP_STUDENT;
            }
        }

        #endregion

    }
}
