using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCB : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SID> Cache_KCBKEY_SID_INCIDENT_TYPE;
        private IReadOnlyList<STMB> Cache_KCBKEY_STMB_B_CODE;

        #endregion

        #region Field Properties

        /// <summary>
        /// Behaviour code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCBKEY { get; internal set; }

        /// <summary>
        /// Behaviour description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Is this positive (P) or negative (N) behaviour?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string POS_NEG { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// SID (Disciplinary Incidents) related entities by [KCB.KCBKEY]-&gt;[SID.INCIDENT_TYPE]
        /// Behaviour code
        /// </summary>
        public IReadOnlyList<SID> KCBKEY_SID_INCIDENT_TYPE
        {
            get
            {
                if (Cache_KCBKEY_SID_INCIDENT_TYPE == null &&
                    !Context.SID.TryFindByINCIDENT_TYPE(KCBKEY, out Cache_KCBKEY_SID_INCIDENT_TYPE))
                {
                    Cache_KCBKEY_SID_INCIDENT_TYPE = new List<SID>().AsReadOnly();
                }

                return Cache_KCBKEY_SID_INCIDENT_TYPE;
            }
        }

        /// <summary>
        /// STMB (Student Merit Behaviour Details) related entities by [KCB.KCBKEY]-&gt;[STMB.B_CODE]
        /// Behaviour code
        /// </summary>
        public IReadOnlyList<STMB> KCBKEY_STMB_B_CODE
        {
            get
            {
                if (Cache_KCBKEY_STMB_B_CODE == null &&
                    !Context.STMB.TryFindByB_CODE(KCBKEY, out Cache_KCBKEY_STMB_B_CODE))
                {
                    Cache_KCBKEY_STMB_B_CODE = new List<STMB>().AsReadOnly();
                }

                return Cache_KCBKEY_STMB_B_CODE;
            }
        }

        #endregion

    }
}
