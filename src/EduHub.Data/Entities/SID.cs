using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents
    /// </summary>
    public partial class SID : EntityBase
    {
#region Navigation Property Cache
        private KCB _INCIDENT_TYPE_KCB;
        private SCI _CAMPUS_SCI;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int SIDKEY { get; internal set; }
        /// <summary>
        /// Date of incident
        /// </summary>
        public DateTime? SID_DATE { get; internal set; }
        /// <summary>
        /// Time of incident
        /// </summary>
        public short? SID_TIME { get; internal set; }
        /// <summary>
        /// Type of incident
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string INCIDENT_TYPE { get; internal set; }
        /// <summary>
        /// Description of incident
        /// [Memo]
        /// </summary>
        public string INCIDENT_DESC { get; internal set; }
        /// <summary>
        /// Memo field for office use only and not to be used for reports
        /// [Memo]
        /// </summary>
        public string OFFICE_USE_ONLY { get; internal set; }
        /// <summary>
        /// School campus at which incident took place
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Address at which incident took place (if not at school)
        /// [Memo]
        /// </summary>
        public string EXT_ADDRESS { get; internal set; }
        /// <summary>
        /// Type of person reporting incident: ST=Student, SF=Staff member, null=Other
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RESP_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person reporting incident (if student or staff member)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string RESP_PERSON { get; internal set; }
        /// <summary>
        /// Name of reporting person (if not student or staff member)
        /// [Uppercase Alphanumeric (64)]
        /// </summary>
        public string RESP_PERSON_NAME { get; internal set; }
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
        /// KCB (Behaviour Classifications) related entity by [SID.INCIDENT_TYPE]-&gt;[KCB.KCBKEY]
        /// Type of incident
        /// </summary>
        public KCB INCIDENT_TYPE_KCB
        {
            get
            {
                if (INCIDENT_TYPE != null)
                {
                    if (_INCIDENT_TYPE_KCB == null)
                    {
                        _INCIDENT_TYPE_KCB = Context.KCB.FindByKCBKEY(INCIDENT_TYPE);
                    }
                    return _INCIDENT_TYPE_KCB;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SID.CAMPUS]-&gt;[SCI.SCIKEY]
        /// School campus at which incident took place
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SDP (Incident Instigators) related entities by [SDP.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// </summary>
        public IReadOnlyList<SDP> SDP_INCIDENT_KEY
        {
            get
            {
                return Context.SID.FindSDPByINCIDENT_KEY(SIDKEY);
            }
        }

        /// <summary>
        /// SIDV (Incident Victims/Recipients) related entities by [SIDV.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// </summary>
        public IReadOnlyList<SIDV> SIDV_INCIDENT_KEY
        {
            get
            {
                return Context.SID.FindSIDVByINCIDENT_KEY(SIDKEY);
            }
        }
#endregion
    }
}
