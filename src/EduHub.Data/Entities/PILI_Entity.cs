using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Item Leave Items
    /// </summary>
    public class PILI_Entity : EntityBase
    {
        /// <summary>
        /// TID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// PIKEY to PI table [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PIKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [PIKEY] => [PI_Entity].[PIKEY]
        /// PIKEY to PI table
        /// </summary>
        public PI_Entity PIKEY_PI { get { return PIKEY.HasValue ? Context.PI.FindByPIKEY(PIKEY.Value) : null; } }
        /// <summary>
        /// PLT key [Uppercase Alphanumeric: u16]
        /// </summary>
        public string PLTKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [PLTKEY] => [PLT_Entity].[PLTKEY]
        /// PLT key
        /// </summary>
        public PLT_Entity PLTKEY_PLT { get { return PLTKEY == null ? null : Context.PLT.FindByPLTKEY(PLTKEY); } }
        /// <summary>
        /// Group code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Navigation property for [LEAVE_GROUP] => [PLG_Entity].[LEAVE_GROUP]
        /// Group code
        /// </summary>
        public PLG_Entity LEAVE_GROUP_PLG { get { return LEAVE_GROUP == null ? null : Context.PLG.FindByLEAVE_GROUP(LEAVE_GROUP); } }
        /// <summary>
        /// Leave code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [LEAVE_CODE] => [PLC_Entity].[PLCKEY]
        /// Leave code
        /// </summary>
        public PLC_Entity LEAVE_CODE_PLC { get { return LEAVE_CODE == null ? null : Context.PLC.FindByPLCKEY(LEAVE_CODE); } }
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
        
        
    }
}
