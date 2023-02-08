#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Victims/Recipients
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIDV : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private SID Cache_INCIDENT_KEY_SID;
#endif

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Sequence no
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Number of the incident that the victim/recipient was involved in
        /// </summary>
        public int INCIDENT_KEY { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// SID (Disciplinary Incidents) related entity by [SIDV.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// Number of the incident that the victim/recipient was involved in
        /// </summary>
        public SID INCIDENT_KEY_SID
        {
            get
            {
                if (Cache_INCIDENT_KEY_SID == null)
                {
                    Cache_INCIDENT_KEY_SID = Context.SID.FindBySIDKEY(INCIDENT_KEY);
                }

                return Cache_INCIDENT_KEY_SID;
            }
        }

#endif
        #endregion

    }
}
#endif
