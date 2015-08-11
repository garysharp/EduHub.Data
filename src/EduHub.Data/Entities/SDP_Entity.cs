using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Instigators
    /// </summary>
    public class SDP_Entity : EntityBase
    {
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int SDPKEY { get; internal set; }
        /// <summary>
        /// Number of the incident [Integer (32bit signed nullable): l]
        /// </summary>
        public int? INCIDENT_KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [INCIDENT_KEY] => [SID_Entity].[SIDKEY]
        /// Number of the incident
        /// </summary>
        public SID_Entity INCIDENT_KEY_SID { get { return INCIDENT_KEY.HasValue ? Context.SID.FindBySIDKEY(INCIDENT_KEY.Value) : null; } }
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
        /// Navigation property for [STUDENT_KEY] => [ST_Entity].[STKEY]
        /// Code of student who instigated the incident
        /// </summary>
        public ST_Entity STUDENT_KEY_ST { get { return STUDENT_KEY == null ? null : Context.ST.FindBySTKEY(STUDENT_KEY); } }
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
        
        
    }
}
