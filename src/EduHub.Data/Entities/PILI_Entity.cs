using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Item Leave Items
    /// </summary>
    public class PILI_Entity : EntityBase
    {
#region Navigation Property Cache
        private PI_Entity _PIKEY_PI;
        private PLT_Entity _PLTKEY_PLT;
        private PLG_Entity _LEAVE_GROUP_PLG;
        private PLC_Entity _LEAVE_CODE_PLC;
#endregion

#region Field Properties
        /// <summary>
        /// TID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// PIKEY to PI table [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PIKEY { get; internal set; }
        /// <summary>
        /// PLT key [Uppercase Alphanumeric: u16]
        /// </summary>
        public string PLTKEY { get; internal set; }
        /// <summary>
        /// Group code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Leave code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [PIKEY] => [PI_Entity].[PIKEY]
        /// PIKEY to PI table
        /// </summary>
        public PI_Entity PIKEY_PI {
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
        /// Navigation property for [PLTKEY] => [PLT_Entity].[PLTKEY]
        /// PLT key
        /// </summary>
        public PLT_Entity PLTKEY_PLT {
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
        /// Navigation property for [LEAVE_GROUP] => [PLG_Entity].[LEAVE_GROUP]
        /// Group code
        /// </summary>
        public PLG_Entity LEAVE_GROUP_PLG {
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
        /// Navigation property for [LEAVE_CODE] => [PLC_Entity].[PLCKEY]
        /// Leave code
        /// </summary>
        public PLC_Entity LEAVE_CODE_PLC {
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
