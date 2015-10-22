using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Item Leave Items
    /// </summary>
    public partial class PILI : EntityBase
    {
#region Navigation Property Cache
        private PI _PIKEY_PI;
        private PLT _PLTKEY_PLT;
        private PLG _LEAVE_GROUP_PLG;
        private PLC _LEAVE_CODE_PLC;
#endregion

#region Field Properties
        /// <summary>
        /// TID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// PIKEY to PI table
        /// </summary>
        public short? PIKEY { get; internal set; }
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
                if (PIKEY.HasValue)
                {
                    if (_PIKEY_PI == null)
                    {
                        _PIKEY_PI = Context.PI.FindByPIKEY(PIKEY.Value);
                    }
                    return _PIKEY_PI;
                }
                else
                {
                    return null;
                }
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
                if (PLTKEY != null)
                {
                    if (_PLTKEY_PLT == null)
                    {
                        _PLTKEY_PLT = Context.PLT.FindByPLTKEY(PLTKEY);
                    }
                    return _PLTKEY_PLT;
                }
                else
                {
                    return null;
                }
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
                if (LEAVE_GROUP != null)
                {
                    if (_LEAVE_GROUP_PLG == null)
                    {
                        _LEAVE_GROUP_PLG = Context.PLG.FindByLEAVE_GROUP(LEAVE_GROUP);
                    }
                    return _LEAVE_GROUP_PLG;
                }
                else
                {
                    return null;
                }
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
                if (LEAVE_CODE != null)
                {
                    if (_LEAVE_CODE_PLC == null)
                    {
                        _LEAVE_CODE_PLC = Context.PLC.FindByPLCKEY(LEAVE_CODE);
                    }
                    return _LEAVE_CODE_PLC;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
