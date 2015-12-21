using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Group Types
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLT : EduHubEntity
    {

        #region Navigation Property Cache

        private PLG Cache_LEAVE_GROUP_PLG;
        private PLC Cache_LEAVE_CODE_PLC;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<PELD> Cache_PLTKEY_PELD_PLTKEY;
        private IReadOnlyList<PILI> Cache_PLTKEY_PILI_PLTKEY;

        #endregion

        #region Field Properties

        /// <summary>
        /// Leave Type Key
        /// [Uppercase Alphanumeric (16)]
        /// </summary>
        public string PLTKEY { get; internal set; }

        /// <summary>
        /// Leave Group Identifier
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_GROUP { get; internal set; }

        /// <summary>
        /// Leave Type Code
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }

        /// <summary>
        /// Entitlement calculation method
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CALC_METHOD { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT01 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT02 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT03 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT04 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT05 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT06 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT07 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT08 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT09 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT10 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT11 { get; internal set; }

        /// <summary>
        /// Period Entitlement Allotment
        /// </summary>
        public double? PERIOD_ALLOT12 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH01 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH02 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH03 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH04 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH05 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH06 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH07 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH08 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH09 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH10 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH11 { get; internal set; }

        /// <summary>
        /// Number of periods associate with the
        /// equivalent period allotment
        /// </summary>
        public short? PERIOD_LENGTH12 { get; internal set; }

        /// <summary>
        /// Period units (Months/years)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PERIOD_UNITS { get; internal set; }

        /// <summary>
        /// Annual Entitlement allotment
        /// </summary>
        public double? ANNUAL_ENTITLEMENT { get; internal set; }

        /// <summary>
        /// Yes/No indicating if the entitlement
        /// should be carried forward on
        /// anniversaries
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROLL_OVER { get; internal set; }

        /// <summary>
        /// Percentage carried forward after
        /// anniversaries
        /// </summary>
        public double? ROLL_PERCENT { get; internal set; }

        /// <summary>
        /// Leave Loading Applicable?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LEAVE_LOADING { get; internal set; }

        /// <summary>
        /// Leave Loading Percentage
        /// </summary>
        public double? LOADING_PERCENT { get; internal set; }

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
        /// PLG (Leave Management Group) related entity by [PLT.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// Leave Group Identifier
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
        /// PLC (Leave Code Description) related entity by [PLT.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// Leave Type Code
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

        #region Foreign Navigation Properties

        /// <summary>
        /// PELD (Employee Leave Details) related entities by [PLT.PLTKEY]-&gt;[PELD.PLTKEY]
        /// Leave Type Key
        /// </summary>
        public IReadOnlyList<PELD> PLTKEY_PELD_PLTKEY
        {
            get
            {
                if (Cache_PLTKEY_PELD_PLTKEY == null &&
                    !Context.PELD.TryFindByPLTKEY(PLTKEY, out Cache_PLTKEY_PELD_PLTKEY))
                {
                    Cache_PLTKEY_PELD_PLTKEY = new List<PELD>().AsReadOnly();
                }

                return Cache_PLTKEY_PELD_PLTKEY;
            }
        }

        /// <summary>
        /// PILI (Pay Item Leave Items) related entities by [PLT.PLTKEY]-&gt;[PILI.PLTKEY]
        /// Leave Type Key
        /// </summary>
        public IReadOnlyList<PILI> PLTKEY_PILI_PLTKEY
        {
            get
            {
                if (Cache_PLTKEY_PILI_PLTKEY == null &&
                    !Context.PILI.TryFindByPLTKEY(PLTKEY, out Cache_PLTKEY_PILI_PLTKEY))
                {
                    Cache_PLTKEY_PILI_PLTKEY = new List<PILI>().AsReadOnly();
                }

                return Cache_PLTKEY_PILI_PLTKEY;
            }
        }

        #endregion

    }
}
