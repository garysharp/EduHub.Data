using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Group Types
    /// </summary>
    public class PLT_Entity : EntityBase
    {
#region Navigation Property Cache
        private PLG_Entity _LEAVE_GROUP_PLG;
        private PLC_Entity _LEAVE_CODE_PLC;
#endregion

#region Field Properties
        /// <summary>
        /// Leave Type Key [Uppercase Alphanumeric: u16]
        /// </summary>
        public string PLTKEY { get; internal set; }
        /// <summary>
        /// Leave Group Identifier [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }
        /// <summary>
        /// Leave Type Code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Entitlement calculation method [Uppercase Alphanumeric: u8]
        /// </summary>
        public string CALC_METHOD { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT01 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT02 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT03 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT04 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT05 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT06 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT07 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT08 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT09 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT10 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT11 { get; internal set; }
        /// <summary>
        /// Period Entitlement Allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERIOD_ALLOT12 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH01 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH02 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH03 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH04 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH05 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH06 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH07 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH08 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH09 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH10 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH11 { get; internal set; }
        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH12 { get; internal set; }
        /// <summary>
        /// Period units (Months/years) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PERIOD_UNITS { get; internal set; }
        /// <summary>
        /// Annual Entitlement allotment [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ANNUAL_ENTITLEMENT { get; internal set; }
        /// <summary>
        /// Yes/No indicating if the entitlement
        /// should be carried forward on
        /// anniversaries [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ROLL_OVER { get; internal set; }
        /// <summary>
        /// Percentage carried forward after
        /// anniversaries [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ROLL_PERCENT { get; internal set; }
        /// <summary>
        /// Leave Loading Applicable? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LEAVE_LOADING { get; internal set; }
        /// <summary>
        /// Leave Loading Percentage [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? LOADING_PERCENT { get; internal set; }
        /// <summary>
        /// Active Y/N? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
        /// Navigation property for [LEAVE_GROUP] => [PLG_Entity].[LEAVE_GROUP]
        /// Leave Group Identifier
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
        /// Leave Type Code
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
