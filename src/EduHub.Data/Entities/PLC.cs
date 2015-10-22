using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description
    /// </summary>
    public partial class PLC : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Leave Group Identifier
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string PLCKEY { get; internal set; }
        /// <summary>
        /// Leave Type Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string LEAVE_DESC { get; internal set; }
        /// <summary>
        /// Leave Category (Annual, Sick...)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Active Y/N?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// PELA (Employee Leave Audit) related entities by [PELA.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        public IReadOnlyList<PELA> PELA_LEAVE_CODE
        {
            get
            {
                return Context.PLC.FindPELAByLEAVE_CODE(PLCKEY);
            }
        }

        /// <summary>
        /// PELD (Employee Leave Details) related entities by [PELD.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        public IReadOnlyList<PELD> PELD_LEAVE_CODE
        {
            get
            {
                return Context.PLC.FindPELDByLEAVE_CODE(PLCKEY);
            }
        }

        /// <summary>
        /// PILI (Pay Item Leave Items) related entities by [PILI.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        public IReadOnlyList<PILI> PILI_LEAVE_CODE
        {
            get
            {
                return Context.PLC.FindPILIByLEAVE_CODE(PLCKEY);
            }
        }

        /// <summary>
        /// PLT (Leave Group Types) related entities by [PLT.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        public IReadOnlyList<PLT> PLT_LEAVE_CODE
        {
            get
            {
                return Context.PLC.FindPLTByLEAVE_CODE(PLCKEY);
            }
        }
#endregion
    }
}
