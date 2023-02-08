#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SID : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private KCB Cache_INCIDENT_TYPE_KCB;
#endif
        private SCI Cache_CAMPUS_SCI;

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<SDP> Cache_SIDKEY_SDP_INCIDENT_KEY;
        private IReadOnlyList<SIDV> Cache_SIDKEY_SIDV_INCIDENT_KEY;
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

#if !EduHubScoped
        /// <summary>
        /// KCB (Behaviour Classifications) related entity by [SID.INCIDENT_TYPE]-&gt;[KCB.KCBKEY]
        /// Type of incident
        /// </summary>
        public KCB INCIDENT_TYPE_KCB
        {
            get
            {
                if (INCIDENT_TYPE == null)
                {
                    return null;
                }
                if (Cache_INCIDENT_TYPE_KCB == null)
                {
                    Cache_INCIDENT_TYPE_KCB = Context.KCB.FindByKCBKEY(INCIDENT_TYPE);
                }

                return Cache_INCIDENT_TYPE_KCB;
            }
        }

#endif
        /// <summary>
        /// SCI (School Information) related entity by [SID.CAMPUS]-&gt;[SCI.SCIKEY]
        /// School campus at which incident took place
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// SDP (Incident Instigators) related entities by [SID.SIDKEY]-&gt;[SDP.INCIDENT_KEY]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SDP> SIDKEY_SDP_INCIDENT_KEY
        {
            get
            {
                if (Cache_SIDKEY_SDP_INCIDENT_KEY == null &&
                    !Context.SDP.TryFindByINCIDENT_KEY(SIDKEY, out Cache_SIDKEY_SDP_INCIDENT_KEY))
                {
                    Cache_SIDKEY_SDP_INCIDENT_KEY = new List<SDP>().AsReadOnly();
                }

                return Cache_SIDKEY_SDP_INCIDENT_KEY;
            }
        }

        /// <summary>
        /// SIDV (Incident Victims/Recipients) related entities by [SID.SIDKEY]-&gt;[SIDV.INCIDENT_KEY]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SIDV> SIDKEY_SIDV_INCIDENT_KEY
        {
            get
            {
                if (Cache_SIDKEY_SIDV_INCIDENT_KEY == null &&
                    !Context.SIDV.TryFindByINCIDENT_KEY(SIDKEY, out Cache_SIDKEY_SIDV_INCIDENT_KEY))
                {
                    Cache_SIDKEY_SIDV_INCIDENT_KEY = new List<SIDV>().AsReadOnly();
                }

                return Cache_SIDKEY_SIDV_INCIDENT_KEY;
            }
        }

#endif
        #endregion

    }
}
#endif
