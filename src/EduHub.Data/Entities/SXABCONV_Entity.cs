using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Converted Student Half-Day Absences
    /// </summary>
    public class SXABCONV_Entity : EntityBase
    {
        /// <summary>
        /// Unique record ID [Integer (32bit signed): l]
        /// </summary>
        public int SXABCONV_ID { get; internal set; }
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
        /// Year level at time of absence [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ST_YEAR_LEVEL { get; internal set; }
        /// <summary>
        /// Navigation property for [ST_YEAR_LEVEL] => [KCY_Entity].[KCYKEY]
        /// Year level at time of absence
        /// </summary>
        public KCY_Entity ST_YEAR_LEVEL_KCY { get { return ST_YEAR_LEVEL == null ? null : Context.KCY.FindByKCYKEY(ST_YEAR_LEVEL); } }
        /// <summary>
        /// Date of absence [Date Time nullable: d]
        /// </summary>
        public DateTime? ABSENCE_DATE { get; internal set; }
        /// <summary>
        /// Expected attendance type in the morning [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM_TYPE] => [KCT_Entity].[KCTKEY]
        /// Expected attendance type in the morning
        /// </summary>
        public KCT_Entity AM_TYPE_KCT { get { return AM_TYPE.HasValue ? Context.KCT.FindByKCTKEY(AM_TYPE.Value) : null; } }
        /// <summary>
        /// Did student actually attend in the morning? P=Present, A=Absent [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AM_ATTENDED { get; internal set; }
        /// <summary>
        /// Has an absence in the morning been approved? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AM_APPROVED { get; internal set; }
        /// <summary>
        /// Expected attendance type in the afternoon [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM_TYPE] => [KCT_Entity].[KCTKEY]
        /// Expected attendance type in the afternoon
        /// </summary>
        public KCT_Entity PM_TYPE_KCT { get { return PM_TYPE.HasValue ? Context.KCT.FindByKCTKEY(PM_TYPE.Value) : null; } }
        /// <summary>
        /// Did student actually attend in the afternoon? P=Present, A=Absent [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PM_ATTENDED { get; internal set; }
        /// <summary>
        /// Has an absence in the afternoon been approved? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PM_APPROVED { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Source of the record - either C21_SXAB or 3rd party product [Uppercase Alphanumeric: u20]
        /// </summary>
        public string RECORD_SOURCE { get; internal set; }
        
        
    }
}
