using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Instigators
    /// </summary>
    public class SDP_Entity : EntityBase
    {
#region Navigation Property Cache
        private SID_Entity _INCIDENT_KEY_SID;
        private ST_Entity _STUDENT_KEY_ST;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int SDPKEY { get; internal set; }
        /// <summary>
        /// Number of the incident [Integer (32bit signed nullable): l]
        /// </summary>
        public int? INCIDENT_KEY { get; internal set; }
        /// <summary>
        /// Incident descriptor (copied from SID record for the MOREINFO band) [Uppercase Alphanumeric: u5]
        /// </summary>
        public string INCIDENT_TYPE { get; internal set; }
        /// <summary>
        /// Incident date (copied from SID record for the MOREINFO band) [Date Time nullable: d]
        /// </summary>
        public DateTime? INCIDENT_DATE { get; internal set; }
        /// <summary>
        /// Code of student who instigated the incident [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT_KEY { get; internal set; }
        /// <summary>
        /// Description of the student's involvement [Memo: m]
        /// </summary>
        public string INVOLVEMENT_DESC { get; internal set; }
        /// <summary>
        /// Date on which to follow up the incident [Date Time nullable: d]
        /// </summary>
        public DateTime? FOLLOW_UP_DATE { get; internal set; }
        /// <summary>
        /// Details of follow-up required [Memo: m]
        /// </summary>
        public string FOLLOW_UP_DETAILS { get; internal set; }
        /// <summary>
        /// Outcome of follow-up [Memo: m]
        /// </summary>
        public string FOLLOW_UP_OUTCOME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [INCIDENT_KEY] => [SID_Entity].[SIDKEY]
        /// Number of the incident
        /// </summary>
        public SID_Entity INCIDENT_KEY_SID {
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
        /// Navigation property for [STUDENT_KEY] => [ST_Entity].[STKEY]
        /// Code of student who instigated the incident
        /// </summary>
        public ST_Entity STUDENT_KEY_ST {
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
#endregion
    }
}
