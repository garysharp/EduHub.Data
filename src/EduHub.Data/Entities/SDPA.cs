using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Actions
    /// </summary>
    public class SDPA : EntityBase
    {
#region Navigation Property Cache
        private SDP _SDP_STUDENT_SDP;
        private SF _TAKEN_BY_SF;
        private KAM _ACTION_TAKEN_KAM;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Number of the relevant Incident Instigator record
        /// </summary>
        public int? SDP_STUDENT { get; internal set; }
        /// <summary>
        /// Staff code of staff member responsible for this disciplinary action
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TAKEN_BY { get; internal set; }
        /// <summary>
        /// Code identifying type of disciplinary action
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string ACTION_TAKEN { get; internal set; }
        /// <summary>
        /// Details of any disciplinary action
        /// [Memo]
        /// </summary>
        public string OTHER_ACTION { get; internal set; }
        /// <summary>
        /// Did the student comply with the disciplinary action? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string COMPLIED { get; internal set; }
        /// <summary>
        /// Have the student's parent(s) been informed? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PARENT_INFORMED { get; internal set; }
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
        /// Navigation property for [SDP_STUDENT] => [SDP].[SDPKEY]
        /// Number of the relevant Incident Instigator record
        /// </summary>
        public SDP SDP_STUDENT_SDP {
            get
            {
                if (SDP_STUDENT.HasValue)
                {
                    if (_SDP_STUDENT_SDP == null)
                    {
                        _SDP_STUDENT_SDP = Context.SDP.FindBySDPKEY(SDP_STUDENT.Value);
                    }
                    return _SDP_STUDENT_SDP;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TAKEN_BY] => [SF].[SFKEY]
        /// Staff code of staff member responsible for this disciplinary action
        /// </summary>
        public SF TAKEN_BY_SF {
            get
            {
                if (TAKEN_BY != null)
                {
                    if (_TAKEN_BY_SF == null)
                    {
                        _TAKEN_BY_SF = Context.SF.FindBySFKEY(TAKEN_BY);
                    }
                    return _TAKEN_BY_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ACTION_TAKEN] => [KAM].[KAMKEY]
        /// Code identifying type of disciplinary action
        /// </summary>
        public KAM ACTION_TAKEN_KAM {
            get
            {
                if (ACTION_TAKEN != null)
                {
                    if (_ACTION_TAKEN_KAM == null)
                    {
                        _ACTION_TAKEN_KAM = Context.KAM.FindByKAMKEY(ACTION_TAKEN);
                    }
                    return _ACTION_TAKEN_KAM;
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
