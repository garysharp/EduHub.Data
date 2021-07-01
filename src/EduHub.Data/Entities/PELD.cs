using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PELD : EduHubEntity
    {

        #region Navigation Property Cache

        private PLT Cache_PLTKEY_PLT;
        private PE Cache_PEKEY_PE;
        private PLC Cache_LEAVE_CODE_PLC;

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
        /// Transaction ID (unique)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// PLT KEY
        /// [Uppercase Alphanumeric (16)]
        /// </summary>
        public string PLTKEY { get; internal set; }

        /// <summary>
        /// EMPLOYEE KEY
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEKEY { get; internal set; }

        /// <summary>
        /// Leave Type Code eg Sick,LSL,RDO
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }

        /// <summary>
        /// Date the entitlement started
        /// Default is employee start date
        /// </summary>
        public DateTime? LEAVE_STARTDATE { get; internal set; }

        /// <summary>
        /// Date leave was last calculated
        /// </summary>
        public DateTime? LAST_CALC_DATE { get; internal set; }

        /// <summary>
        /// Date of last anniversary
        /// </summary>
        public DateTime? LAST_ANNIV_DATE { get; internal set; }

        /// <summary>
        /// Date of next anniversary
        /// </summary>
        public DateTime? ANNIVERSARY_DATE { get; internal set; }

        /// <summary>
        /// Hours of accumulated entitlement
        /// </summary>
        public double? LEAVE_ENT_HOURS { get; internal set; }

        /// <summary>
        /// Hours of prorata hours
        /// </summary>
        public double? LEAVE_PRORATA_HOURS { get; internal set; }

        /// <summary>
        /// Step within the period length
        /// employement
        /// </summary>
        public short? PERIOD_LENGTH_STEP { get; internal set; }

        /// <summary>
        /// Worked hours
        /// </summary>
        public double? WORKED { get; internal set; }

        /// <summary>
        /// Hours should have worked
        /// </summary>
        public double? STANDARD { get; internal set; }

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
        /// PLT (Leave Group Types) related entity by [PELD.PLTKEY]-&gt;[PLT.PLTKEY]
        /// PLT KEY
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
        /// PE (Employees) related entity by [PELD.PEKEY]-&gt;[PE.PEKEY]
        /// EMPLOYEE KEY
        /// </summary>
        public PE PEKEY_PE
        {
            get
            {
                if (Cache_PEKEY_PE == null)
                {
                    Cache_PEKEY_PE = Context.PE.FindByPEKEY(PEKEY);
                }

                return Cache_PEKEY_PE;
            }
        }

        /// <summary>
        /// PLC (Leave Code Description) related entity by [PELD.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// Leave Type Code eg Sick,LSL,RDO
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
