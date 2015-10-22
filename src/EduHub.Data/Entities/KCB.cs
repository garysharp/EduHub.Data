using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications
    /// </summary>
    public partial class KCB : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// SID (Disciplinary Incidents) related entities by [SID.INCIDENT_TYPE]-&gt;[KCB.KCBKEY]
        /// </summary>
        public IReadOnlyList<SID> SID_INCIDENT_TYPE
        {
            get
            {
                return Context.KCB.FindSIDByINCIDENT_TYPE(KCBKEY);
            }
        }

        /// <summary>
        /// STMB (Student Merit Behaviour Details) related entities by [STMB.B_CODE]-&gt;[KCB.KCBKEY]
        /// </summary>
        public IReadOnlyList<STMB> STMB_B_CODE
        {
            get
            {
                return Context.KCB.FindSTMBByB_CODE(KCBKEY);
            }
        }
#endregion
    }
}
