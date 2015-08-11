using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Multiple Day Absences
    /// </summary>
    public class STRA_Entity : EntityBase
    {
        /// <summary>
        /// Unique ID for this record [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [STKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STKEY_ST { get { return STKEY == null ? null : Context.ST.FindBySTKEY(STKEY); } }
        /// <summary>
        /// Date of first day of period of absence [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Start Absence AM or PM for Half Day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string START_AM_PM { get; internal set; }
        /// <summary>
        /// Date of last day of period of absence [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// End Absence AM or PM for Half Day [Uppercase Alphanumeric: u1]
        /// </summary>
        public string END_AM_PM { get; internal set; }
        /// <summary>
        /// Comments on absence [Alphanumeric: a30]
        /// </summary>
        public string COMMENTS { get; internal set; }
        /// <summary>
        /// Type of absence if known [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ABS_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [ABS_TYPE] => [KCT_Entity].[KCTKEY]
        /// Type of absence if known
        /// </summary>
        public KCT_Entity ABS_TYPE_KCT { get { return ABS_TYPE.HasValue ? Context.KCT.FindByKCTKEY(ABS_TYPE.Value) : null; } }
        /// <summary>
        /// First absent period (period absences) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? START_PERIOD { get; internal set; }
        /// <summary>
        /// Last absent period (period absences) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? END_PERIOD { get; internal set; }
        /// <summary>
        /// Every day = D or recurring Weekly = W [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FREQUENCY { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
