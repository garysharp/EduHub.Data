using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Item Leave Items
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PILI : EntityBase
    {

        #region Navigation Property Cache

        private PI Cache_PIKEY_PI;
        private PLT Cache_PLTKEY_PLT;
        private PLG Cache_LEAVE_GROUP_PLG;
        private PLC Cache_LEAVE_CODE_PLC;

        #endregion

        #region Field Properties

        /// <summary>
        /// TID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// PIKEY to PI table
        /// </summary>
        public short PIKEY { get; internal set; }

        /// <summary>
        /// PLT key
        /// [Uppercase Alphanumeric (16)]
        /// </summary>
        public string PLTKEY { get; internal set; }

        /// <summary>
        /// Group code
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }

        /// <summary>
        /// Leave code
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }

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
        /// PI (Pay Items) related entity by [PILI.PIKEY]-&gt;[PI.PIKEY]
        /// PIKEY to PI table
        /// </summary>
        public PI PIKEY_PI
        {
            get
            {
                if (Cache_PIKEY_PI == null)
                {
                    Cache_PIKEY_PI = Context.PI.FindByPIKEY(PIKEY);
                }

                return Cache_PIKEY_PI;
            }
        }

        /// <summary>
        /// PLT (Leave Group Types) related entity by [PILI.PLTKEY]-&gt;[PLT.PLTKEY]
        /// PLT key
        /// </summary>
        public PLT PLTKEY_PLT
        {
            get
            {
                if (PLTKEY == null)
                {
                    return null;
                }
                if (Cache_PLTKEY_PLT == null)
                {
                    Cache_PLTKEY_PLT = Context.PLT.FindByPLTKEY(PLTKEY);
                }

                return Cache_PLTKEY_PLT;
            }
        }

        /// <summary>
        /// PLG (Leave Management Group) related entity by [PILI.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// Group code
        /// </summary>
        public PLG LEAVE_GROUP_PLG
        {
            get
            {
                if (LEAVE_GROUP == null)
                {
                    return null;
                }
                if (Cache_LEAVE_GROUP_PLG == null)
                {
                    Cache_LEAVE_GROUP_PLG = Context.PLG.FindByLEAVE_GROUP(LEAVE_GROUP);
                }

                return Cache_LEAVE_GROUP_PLG;
            }
        }

        /// <summary>
        /// PLC (Leave Code Description) related entity by [PILI.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// Leave code
        /// </summary>
        public PLC LEAVE_CODE_PLC
        {
            get
            {
                if (LEAVE_CODE == null)
                {
                    return null;
                }
                if (Cache_LEAVE_CODE_PLC == null)
                {
                    Cache_LEAVE_CODE_PLC = Context.PLC.FindByPLCKEY(LEAVE_CODE);
                }

                return Cache_LEAVE_CODE_PLC;
            }
        }

        #endregion

    }
}
