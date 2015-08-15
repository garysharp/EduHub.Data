using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Scheduled Sessions
    /// </summary>
    public class SXAS_Entity : EntityBase
    {
#region Navigation Property Cache
        private TXAS_Entity _TXAS_ID_TXAS;
        private ST_Entity _STKEY_ST;
        private KCY_Entity _ST_YEAR_LEVEL_KCY;
        private KCT_Entity _EXP_ABS_TYPE_KCT;
        private KCT_Entity _ACT_ABS_TYPE_KCT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// ID of actual session [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TXAS_ID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// Student's year level at time of absence [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ST_YEAR_LEVEL { get; internal set; }
        /// <summary>
        /// Expected attendance type [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXP_ABS_TYPE { get; internal set; }
        /// <summary>
        /// attend state? P=Present, A=Absent, L=Late [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ATTENDED { get; internal set; }
        /// <summary>
        /// Actual absence type [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACT_ABS_TYPE { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [TXAS_ID] => [TXAS_Entity].[TID]
        /// ID of actual session
        /// </summary>
        public TXAS_Entity TXAS_ID_TXAS {
            get
            {
                if (TXAS_ID.HasValue)
                {
                    if (_TXAS_ID_TXAS == null)
                    {
                        _TXAS_ID_TXAS = Context.TXAS.FindByTID(TXAS_ID.Value);
                    }
                    return _TXAS_ID_TXAS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STKEY_ST {
            get
            {
                if (STKEY != null)
                {
                    if (_STKEY_ST == null)
                    {
                        _STKEY_ST = Context.ST.FindBySTKEY(STKEY);
                    }
                    return _STKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_YEAR_LEVEL] => [KCY_Entity].[KCYKEY]
        /// Student's year level at time of absence
        /// </summary>
        public KCY_Entity ST_YEAR_LEVEL_KCY {
            get
            {
                if (ST_YEAR_LEVEL != null)
                {
                    if (_ST_YEAR_LEVEL_KCY == null)
                    {
                        _ST_YEAR_LEVEL_KCY = Context.KCY.FindByKCYKEY(ST_YEAR_LEVEL);
                    }
                    return _ST_YEAR_LEVEL_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXP_ABS_TYPE] => [KCT_Entity].[KCTKEY]
        /// Expected attendance type
        /// </summary>
        public KCT_Entity EXP_ABS_TYPE_KCT {
            get
            {
                if (EXP_ABS_TYPE.HasValue)
                {
                    if (_EXP_ABS_TYPE_KCT == null)
                    {
                        _EXP_ABS_TYPE_KCT = Context.KCT.FindByKCTKEY(EXP_ABS_TYPE.Value);
                    }
                    return _EXP_ABS_TYPE_KCT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ACT_ABS_TYPE] => [KCT_Entity].[KCTKEY]
        /// Actual absence type
        /// </summary>
        public KCT_Entity ACT_ABS_TYPE_KCT {
            get
            {
                if (ACT_ABS_TYPE.HasValue)
                {
                    if (_ACT_ABS_TYPE_KCT == null)
                    {
                        _ACT_ABS_TYPE_KCT = Context.KCT.FindByKCTKEY(ACT_ABS_TYPE.Value);
                    }
                    return _ACT_ABS_TYPE_KCT;
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
