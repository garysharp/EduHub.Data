using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Half-Day Absences
    /// </summary>
    public class SXAB_Entity : EntityBase
    {
        /// <summary>
        /// Unique record ID [Integer (32bit signed): l]
        /// </summary>
        public int SXAB_ID { get; internal set; }
        /// <summary>
        /// TID of corresponding Home Group Daily Attendance record << may require referential integrity controls [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TXHG_TID { get; internal set; }
        /// <summary>
        /// Navigation property for [TXHG_TID] => [TXHG_Entity].[TXHG_ID]
        /// TID of corresponding Home Group Daily Attendance record << may require referential integrity controls
        /// </summary>
        public TXHG_Entity TXHG_TID_TXHG { get { return TXHG_TID.HasValue ? Context.TXHG.FindByTXHG_ID(TXHG_TID.Value) : null; } }
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
        /// Short comment [Alphanumeric: a30]
        /// </summary>
        public string ABSENCE_COMMENT { get; internal set; }
        /// <summary>
        /// Expected attendance type in the morning [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_EXP_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM_EXP_TYPE] => [KCT_Entity].[KCTKEY]
        /// Expected attendance type in the morning
        /// </summary>
        public KCT_Entity AM_EXP_TYPE_KCT { get { return AM_EXP_TYPE.HasValue ? Context.KCT.FindByKCTKEY(AM_EXP_TYPE.Value) : null; } }
        /// <summary>
        /// Did student actually attend in the morning? P=Present, A=Absent [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AM_ATTENDED { get; internal set; }
        /// <summary>
        /// Actual attendance type in the morning [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_ACT_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM_ACT_TYPE] => [KCT_Entity].[KCTKEY]
        /// Actual attendance type in the morning
        /// </summary>
        public KCT_Entity AM_ACT_TYPE_KCT { get { return AM_ACT_TYPE.HasValue ? Context.KCT.FindByKCTKEY(AM_ACT_TYPE.Value) : null; } }
        /// <summary>
        /// Has an absence in the morning been approved? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AM_APPROVED { get; internal set; }
        /// <summary>
        /// Actual time of arrival in the morning if late (hh:mm) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_LATE_ARRIVAL { get; internal set; }
        /// <summary>
        /// Actual time of departure in the morning if early (hh:mm) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_EARLY_LEFT { get; internal set; }
        /// <summary>
        /// Expected attendance type in the afternoon [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_EXP_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM_EXP_TYPE] => [KCT_Entity].[KCTKEY]
        /// Expected attendance type in the afternoon
        /// </summary>
        public KCT_Entity PM_EXP_TYPE_KCT { get { return PM_EXP_TYPE.HasValue ? Context.KCT.FindByKCTKEY(PM_EXP_TYPE.Value) : null; } }
        /// <summary>
        /// Did student actually attend in the afternoon? P=Present, A=Absent [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PM_ATTENDED { get; internal set; }
        /// <summary>
        /// Actual attendance type in the afternoon [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_ACT_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM_ACT_TYPE] => [KCT_Entity].[KCTKEY]
        /// Actual attendance type in the afternoon
        /// </summary>
        public KCT_Entity PM_ACT_TYPE_KCT { get { return PM_ACT_TYPE.HasValue ? Context.KCT.FindByKCTKEY(PM_ACT_TYPE.Value) : null; } }
        /// <summary>
        /// Has an absence in the afternoon been approved? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PM_APPROVED { get; internal set; }
        /// <summary>
        /// Actual time of arrival in the afternoon if late (hh:mm) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_LATE_ARRIVAL { get; internal set; }
        /// <summary>
        /// Actual time of departure in the afternoon if early (hh:mm) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_EARLY_LEFT { get; internal set; }
        /// <summary>
        /// Indicates whether contact been made by parent or school [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT { get; internal set; }
        /// <summary>
        /// Method of contact [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CONTACT_METHOD { get; internal set; }
        /// <summary>
        /// Attended sick bay? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SICKBAY { get; internal set; }
        /// <summary>
        /// Last user action in tick box [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LAST_ACTION { get; internal set; }
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
