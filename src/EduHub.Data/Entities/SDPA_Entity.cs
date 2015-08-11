using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Actions
    /// </summary>
    public class SDPA_Entity : EntityBase
    {
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Number of the relevant Incident Instigator record [Integer (32bit signed nullable): l]
        /// </summary>
        public int? SDP_STUDENT { get; internal set; }
        /// <summary>
        /// Navigation property for [SDP_STUDENT] => [SDP_Entity].[SDPKEY]
        /// Number of the relevant Incident Instigator record
        /// </summary>
        public SDP_Entity SDP_STUDENT_SDP { get { return SDP_STUDENT.HasValue ? Context.SDP.FindBySDPKEY(SDP_STUDENT.Value) : null; } }
        /// <summary>
        /// Staff code of staff member responsible for this disciplinary action [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TAKEN_BY { get; internal set; }
        /// <summary>
        /// Navigation property for [TAKEN_BY] => [SF_Entity].[SFKEY]
        /// Staff code of staff member responsible for this disciplinary action
        /// </summary>
        public SF_Entity TAKEN_BY_SF { get { return TAKEN_BY == null ? null : Context.SF.FindBySFKEY(TAKEN_BY); } }
        /// <summary>
        /// Code identifying type of disciplinary action [Uppercase Alphanumeric: u5]
        /// </summary>
        public string ACTION_TAKEN { get; internal set; }
        /// <summary>
        /// Navigation property for [ACTION_TAKEN] => [KAM_Entity].[KAMKEY]
        /// Code identifying type of disciplinary action
        /// </summary>
        public KAM_Entity ACTION_TAKEN_KAM { get { return ACTION_TAKEN == null ? null : Context.KAM.FindByKAMKEY(ACTION_TAKEN); } }
        /// <summary>
        /// Details of any disciplinary action [Memo: m]
        /// </summary>
        public string OTHER_ACTION { get; internal set; }
        /// <summary>
        /// Did the student comply with the disciplinary action? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string COMPLIED { get; internal set; }
        /// <summary>
        /// Have the student's parent(s) been informed? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PARENT_INFORMED { get; internal set; }
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
