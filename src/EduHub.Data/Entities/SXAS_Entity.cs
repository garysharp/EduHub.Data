using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Scheduled Sessions
    /// </summary>
    public class SXAS_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// ID of actual session [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TXAS_ID { get; internal set; }
        /// <summary>
        /// Navigation property for [TXAS_ID] => [TXAS_Entity].[TID]
        /// ID of actual session
        /// </summary>
        public TXAS_Entity TXAS_ID_TXAS { get { return TXAS_ID.HasValue ? Context.TXAS.FindByTID(TXAS_ID.Value) : null; } }
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
        /// Student's year level at time of absence [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ST_YEAR_LEVEL { get; internal set; }
        /// <summary>
        /// Navigation property for [ST_YEAR_LEVEL] => [KCY_Entity].[KCYKEY]
        /// Student's year level at time of absence
        /// </summary>
        public KCY_Entity ST_YEAR_LEVEL_KCY { get { return ST_YEAR_LEVEL == null ? null : Context.KCY.FindByKCYKEY(ST_YEAR_LEVEL); } }
        /// <summary>
        /// Expected attendance type [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXP_ABS_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [EXP_ABS_TYPE] => [KCT_Entity].[KCTKEY]
        /// Expected attendance type
        /// </summary>
        public KCT_Entity EXP_ABS_TYPE_KCT { get { return EXP_ABS_TYPE.HasValue ? Context.KCT.FindByKCTKEY(EXP_ABS_TYPE.Value) : null; } }
        /// <summary>
        /// attend state? P=Present, A=Absent, L=Late [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ATTENDED { get; internal set; }
        /// <summary>
        /// Actual absence type [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACT_ABS_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [ACT_ABS_TYPE] => [KCT_Entity].[KCTKEY]
        /// Actual absence type
        /// </summary>
        public KCT_Entity ACT_ABS_TYPE_KCT { get { return ACT_ABS_TYPE.HasValue ? Context.KCT.FindByKCTKEY(ACT_ABS_TYPE.Value) : null; } }
        /// <summary>
        /// Was an absence from this session approved? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string APPROVED { get; internal set; }
        /// <summary>
        /// Short Comment [Alphanumeric: a30]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// The action taken or needing to be taken: L=Letter, P=Phone [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTION_TAKEN { get; internal set; }
        /// <summary>
        /// The date of the absence (used for expected absences) [Date Time nullable: d]
        /// </summary>
        public DateTime? ABSENCE_DATE { get; internal set; }
        /// <summary>
        /// The period number of the absence (used for expected absences) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ABSENCE_PERIOD { get; internal set; }
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
