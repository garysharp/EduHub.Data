using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Details
    /// </summary>
    public class PELD_Entity : EntityBase
    {
#region Navigation Property Cache
        private PLT_Entity _PLTKEY_PLT;
        private PE_Entity _PEKEY_PE;
        private PLC_Entity _LEAVE_CODE_PLC;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (unique) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// PLT KEY [Uppercase Alphanumeric: u16]
        /// </summary>
        public string PLTKEY { get; internal set; }
        /// <summary>
        /// EMPLOYEE KEY [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEKEY { get; internal set; }
        /// <summary>
        /// Leave Type Code eg Sick,LSL,RDO [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Date the entitlement started
        /// Default is employee start date [Date Time nullable: d]
        /// </summary>
        public DateTime? LEAVE_STARTDATE { get; internal set; }
        /// <summary>
        /// Date leave was last calculated [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_CALC_DATE { get; internal set; }
        /// <summary>
        /// Date of last anniversary [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_ANNIV_DATE { get; internal set; }
        /// <summary>
        /// Date of next anniversary [Date Time nullable: d]
        /// </summary>
        public DateTime? ANNIVERSARY_DATE { get; internal set; }
        /// <summary>
        /// Hours of accumulated entitlement [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? LEAVE_ENT_HOURS { get; internal set; }
        /// <summary>
        /// Hours of prorata hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? LEAVE_PRORATA_HOURS { get; internal set; }
        /// <summary>
        /// Step within the period length
        /// employement [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH_STEP { get; internal set; }
        /// <summary>
        /// Worked hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? WORKED { get; internal set; }
        /// <summary>
        /// Hours should have worked [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? STANDARD { get; internal set; }
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
        /// Navigation property for [PLTKEY] => [PLT_Entity].[PLTKEY]
        /// PLT KEY
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
        /// Navigation property for [PEKEY] => [PE_Entity].[PEKEY]
        /// EMPLOYEE KEY
        /// </summary>
        public PE_Entity PEKEY_PE {
            get
            {
                if (PEKEY != null)
                {
                    if (_PEKEY_PE == null)
                    {
                        _PEKEY_PE = Context.PE.FindByPEKEY(PEKEY);
                    }
                    return _PEKEY_PE;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [LEAVE_CODE] => [PLC_Entity].[PLCKEY]
        /// Leave Type Code eg Sick,LSL,RDO
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
