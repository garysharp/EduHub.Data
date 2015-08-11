using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Audit
    /// </summary>
    public class PELA_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee identification code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PEKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [PEKEY] => [PE_Entity].[PEKEY]
        /// Employee identification code
        /// </summary>
        public PE_Entity PEKEY_PE { get { return PEKEY == null ? null : Context.PE.FindByPEKEY(PEKEY); } }
        /// <summary>
        /// Leave type code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [LEAVE_CODE] => [PLC_Entity].[PLCKEY]
        /// Leave type code
        /// </summary>
        public PLC_Entity LEAVE_CODE_PLC { get { return LEAVE_CODE == null ? null : Context.PLC.FindByPLCKEY(LEAVE_CODE); } }
        /// <summary>
        /// Hours (from PEF) [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Date ent. started def. emp. start date [Date Time nullable: d]
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
        /// Adjust hours of accum entitlement [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? LEAVE_ENT_HOURS { get; internal set; }
        /// <summary>
        /// Adjustment hours of prorata hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? LEAVE_PRORATA_HOURS { get; internal set; }
        /// <summary>
        /// Step within the period length [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_LENGTH_STEP { get; internal set; }
        /// <summary>
        /// Penalty days [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PENALTY_DAYS { get; internal set; }
        /// <summary>
        /// Date leave started [Date Time nullable: d]
        /// </summary>
        public DateTime? DATE_START { get; internal set; }
        /// <summary>
        /// Date leave ended [Date Time nullable: d]
        /// </summary>
        public DateTime? DATE_END { get; internal set; }
        /// <summary>
        /// Type of Maintenance(Takeup,adjust,credit.. [Uppercase Alphanumeric: u8]
        /// </summary>
        public string CHANGE_TYPE { get; internal set; }
        /// <summary>
        /// Description associated with maintenance [Alphanumeric: a35]
        /// </summary>
        public string COMMENTS { get; internal set; }
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
