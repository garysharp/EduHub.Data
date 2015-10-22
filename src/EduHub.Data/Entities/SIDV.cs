using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Victims/Recipients
    /// </summary>
    public partial class SIDV : EntityBase
    {
#region Navigation Property Cache
        private SID _INCIDENT_KEY_SID;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Number of the incident that the victim/recipient was involved in
        /// </summary>
        public int? INCIDENT_KEY { get; internal set; }
        /// <summary>
        /// Type of person affected by the incident: ST=Student, SF=Staff member, null=Other
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RECIPIENT_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person affected by the incident (if student or staff member)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string RECIPIENT { get; internal set; }
        /// <summary>
        /// Name of person affected by the incident (if not student or staff member)
        /// [Uppercase Alphanumeric (64)]
        /// </summary>
        public string RECIPIENT_NAME { get; internal set; }
        /// <summary>
        /// Address of person affected by the incident (if not student or staff member)
        /// [Memo]
        /// </summary>
        public string RECIPIENT_ADDRESS { get; internal set; }
        /// <summary>
        /// Phone number of person affected by the incident (if not student or staff member)
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string RECIPIENT_PHONE { get; internal set; }
        /// <summary>
        /// Details of how the person was affected
        /// [Memo]
        /// </summary>
        public string HOW_AFFECTED { get; internal set; }
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
        /// SID (Disciplinary Incidents) related entity by [SIDV.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// Number of the incident that the victim/recipient was involved in
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
#endregion
    }
}
