using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group
    /// </summary>
    public partial class PLG : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Leave Group Identifier
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Leave Group Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string LEAVE_GROUP_DESC { get; internal set; }
        /// <summary>
        /// Normal weekly hours
        /// </summary>
        public double? WEEKLY_HOURS { get; internal set; }
        /// <summary>
        /// Normal hours per day
        /// </summary>
        public double? DAILY_HOURS { get; internal set; }
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
        /// PE (Employees) related entities by [PE.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        public IReadOnlyList<PE> PE_LEAVE_GROUP
        {
            get
            {
                return Context.PLG.FindPEByLEAVE_GROUP(LEAVE_GROUP);
            }
        }

        /// <summary>
        /// PILI (Pay Item Leave Items) related entities by [PILI.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        public IReadOnlyList<PILI> PILI_LEAVE_GROUP
        {
            get
            {
                return Context.PLG.FindPILIByLEAVE_GROUP(LEAVE_GROUP);
            }
        }

        /// <summary>
        /// PLT (Leave Group Types) related entities by [PLT.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        public IReadOnlyList<PLT> PLT_LEAVE_GROUP
        {
            get
            {
                return Context.PLG.FindPLTByLEAVE_GROUP(LEAVE_GROUP);
            }
        }
#endregion
    }
}
