using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Victims/Recipients
    /// </summary>
    public class SIDV_Entity : EntityBase
    {
#region Navigation Property Cache
        private SID_Entity _INCIDENT_KEY_SID;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Number of the incident that the victim/recipient was involved in [Integer (32bit signed nullable): l]
        /// </summary>
        public int? INCIDENT_KEY { get; internal set; }
        /// <summary>
        /// Type of person affected by the incident: ST=Student, SF=Staff member, null=Other [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RECIPIENT_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person affected by the incident (if student or staff member) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string RECIPIENT { get; internal set; }
        /// <summary>
        /// Name of person affected by the incident (if not student or staff member) [Uppercase Alphanumeric: u64]
        /// </summary>
        public string RECIPIENT_NAME { get; internal set; }
        /// <summary>
        /// Address of person affected by the incident (if not student or staff member) [Memo: m]
        /// </summary>
        public string RECIPIENT_ADDRESS { get; internal set; }
        /// <summary>
        /// Phone number of person affected by the incident (if not student or staff member) [Uppercase Alphanumeric: u20]
        /// </summary>
        public string RECIPIENT_PHONE { get; internal set; }
        /// <summary>
        /// Details of how the person was affected [Memo: m]
        /// </summary>
        public string HOW_AFFECTED { get; internal set; }
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
        /// Number of the incident that the victim/recipient was involved in
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
#endregion
    }
}
