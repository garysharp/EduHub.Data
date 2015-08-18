using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Audit
    /// </summary>
    public class PELA : EntityBase
    {
#region Navigation Property Cache
        private PE _PEKEY_PE;
        private PLC _LEAVE_CODE_PLC;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee identification code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PEKEY { get; internal set; }
        /// <summary>
        /// Leave type code
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Hours (from PEF)
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Date ent. started def. emp. start date
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
        /// Adjust hours of accum entitlement
        /// </summary>
        public double? LEAVE_ENT_HOURS { get; internal set; }
        /// <summary>
        /// Adjustment hours of prorata hours
        /// </summary>
        public double? LEAVE_PRORATA_HOURS { get; internal set; }
        /// <summary>
        /// Step within the period length
        /// </summary>
        public short? PERIOD_LENGTH_STEP { get; internal set; }
        /// <summary>
        /// Penalty days
        /// </summary>
        public short? PENALTY_DAYS { get; internal set; }
        /// <summary>
        /// Date leave started
        /// </summary>
        public DateTime? DATE_START { get; internal set; }
        /// <summary>
        /// Date leave ended
        /// </summary>
        public DateTime? DATE_END { get; internal set; }
        /// <summary>
        /// Type of Maintenance(Takeup,adjust,credit..
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CHANGE_TYPE { get; internal set; }
        /// <summary>
        /// Description associated with maintenance
        /// [Alphanumeric (35)]
        /// </summary>
        public string COMMENTS { get; internal set; }
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
        /// Navigation property for [PEKEY] => [PE].[PEKEY]
        /// Employee identification code
        /// </summary>
        public PE PEKEY_PE {
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
        /// Navigation property for [LEAVE_CODE] => [PLC].[PLCKEY]
        /// Leave type code
        /// </summary>
        public PLC LEAVE_CODE_PLC {
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
