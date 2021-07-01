using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLG : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<PE> Cache_LEAVE_GROUP_PE_LEAVE_GROUP;
        private IReadOnlyList<PILI> Cache_LEAVE_GROUP_PILI_LEAVE_GROUP;
        private IReadOnlyList<PLT> Cache_LEAVE_GROUP_PLT_LEAVE_GROUP;

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

        #region Foreign Navigation Properties

        /// <summary>
        /// PE (Employees) related entities by [PLG.LEAVE_GROUP]-&gt;[PE.LEAVE_GROUP]
        /// Leave Group Identifier
        /// </summary>
        public IReadOnlyList<PE> LEAVE_GROUP_PE_LEAVE_GROUP
        {
            get
            {
                if (Cache_LEAVE_GROUP_PE_LEAVE_GROUP == null &&
                    !Context.PE.TryFindByLEAVE_GROUP(LEAVE_GROUP, out Cache_LEAVE_GROUP_PE_LEAVE_GROUP))
                {
                    Cache_LEAVE_GROUP_PE_LEAVE_GROUP = new List<PE>().AsReadOnly();
                }

                return Cache_LEAVE_GROUP_PE_LEAVE_GROUP;
            }
        }

        /// <summary>
        /// PILI (Pay Item Leave Items) related entities by [PLG.LEAVE_GROUP]-&gt;[PILI.LEAVE_GROUP]
        /// Leave Group Identifier
        /// </summary>
        public IReadOnlyList<PILI> LEAVE_GROUP_PILI_LEAVE_GROUP
        {
            get
            {
                if (Cache_LEAVE_GROUP_PILI_LEAVE_GROUP == null &&
                    !Context.PILI.TryFindByLEAVE_GROUP(LEAVE_GROUP, out Cache_LEAVE_GROUP_PILI_LEAVE_GROUP))
                {
                    Cache_LEAVE_GROUP_PILI_LEAVE_GROUP = new List<PILI>().AsReadOnly();
                }

                return Cache_LEAVE_GROUP_PILI_LEAVE_GROUP;
            }
        }

        /// <summary>
        /// PLT (Leave Group Types) related entities by [PLG.LEAVE_GROUP]-&gt;[PLT.LEAVE_GROUP]
        /// Leave Group Identifier
        /// </summary>
        public IReadOnlyList<PLT> LEAVE_GROUP_PLT_LEAVE_GROUP
        {
            get
            {
                if (Cache_LEAVE_GROUP_PLT_LEAVE_GROUP == null &&
                    !Context.PLT.TryFindByLEAVE_GROUP(LEAVE_GROUP, out Cache_LEAVE_GROUP_PLT_LEAVE_GROUP))
                {
                    Cache_LEAVE_GROUP_PLT_LEAVE_GROUP = new List<PLT>().AsReadOnly();
                }

                return Cache_LEAVE_GROUP_PLT_LEAVE_GROUP;
            }
        }

        #endregion

    }
}
