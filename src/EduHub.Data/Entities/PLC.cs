using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLC : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<PELA> Cache_PLCKEY_PELA_LEAVE_CODE;
        private IReadOnlyList<PELD> Cache_PLCKEY_PELD_LEAVE_CODE;
        private IReadOnlyList<PILI> Cache_PLCKEY_PILI_LEAVE_CODE;
        private IReadOnlyList<PLT> Cache_PLCKEY_PLT_LEAVE_CODE;

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

        #region Foreign Navigation Properties

        /// <summary>
        /// PELA (Employee Leave Audit) related entities by [PLC.PLCKEY]-&gt;[PELA.LEAVE_CODE]
        /// Leave Group Identifier
        /// </summary>
        public IReadOnlyList<PELA> PLCKEY_PELA_LEAVE_CODE
        {
            get
            {
                if (Cache_PLCKEY_PELA_LEAVE_CODE == null &&
                    !Context.PELA.TryFindByLEAVE_CODE(PLCKEY, out Cache_PLCKEY_PELA_LEAVE_CODE))
                {
                    Cache_PLCKEY_PELA_LEAVE_CODE = new List<PELA>().AsReadOnly();
                }

                return Cache_PLCKEY_PELA_LEAVE_CODE;
            }
        }

        /// <summary>
        /// PELD (Employee Leave Details) related entities by [PLC.PLCKEY]-&gt;[PELD.LEAVE_CODE]
        /// Leave Group Identifier
        /// </summary>
        public IReadOnlyList<PELD> PLCKEY_PELD_LEAVE_CODE
        {
            get
            {
                if (Cache_PLCKEY_PELD_LEAVE_CODE == null &&
                    !Context.PELD.TryFindByLEAVE_CODE(PLCKEY, out Cache_PLCKEY_PELD_LEAVE_CODE))
                {
                    Cache_PLCKEY_PELD_LEAVE_CODE = new List<PELD>().AsReadOnly();
                }

                return Cache_PLCKEY_PELD_LEAVE_CODE;
            }
        }

        /// <summary>
        /// PILI (Pay Item Leave Items) related entities by [PLC.PLCKEY]-&gt;[PILI.LEAVE_CODE]
        /// Leave Group Identifier
        /// </summary>
        public IReadOnlyList<PILI> PLCKEY_PILI_LEAVE_CODE
        {
            get
            {
                if (Cache_PLCKEY_PILI_LEAVE_CODE == null &&
                    !Context.PILI.TryFindByLEAVE_CODE(PLCKEY, out Cache_PLCKEY_PILI_LEAVE_CODE))
                {
                    Cache_PLCKEY_PILI_LEAVE_CODE = new List<PILI>().AsReadOnly();
                }

                return Cache_PLCKEY_PILI_LEAVE_CODE;
            }
        }

        /// <summary>
        /// PLT (Leave Group Types) related entities by [PLC.PLCKEY]-&gt;[PLT.LEAVE_CODE]
        /// Leave Group Identifier
        /// </summary>
        public IReadOnlyList<PLT> PLCKEY_PLT_LEAVE_CODE
        {
            get
            {
                if (Cache_PLCKEY_PLT_LEAVE_CODE == null &&
                    !Context.PLT.TryFindByLEAVE_CODE(PLCKEY, out Cache_PLCKEY_PLT_LEAVE_CODE))
                {
                    Cache_PLCKEY_PLT_LEAVE_CODE = new List<PLT>().AsReadOnly();
                }

                return Cache_PLCKEY_PLT_LEAVE_CODE;
            }
        }

        #endregion

    }
}
