using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Half-Day Absences
    /// </summary>
    public class SXAB : EntityBase
    {
#region Navigation Property Cache
        private TXHG _TXHG_TID_TXHG;
        private ST _STKEY_ST;
        private KCY _ST_YEAR_LEVEL_KCY;
        private KCT _AM_EXP_TYPE_KCT;
        private KCT _AM_ACT_TYPE_KCT;
        private KCT _PM_EXP_TYPE_KCT;
        private KCT _PM_ACT_TYPE_KCT;
#endregion

#region Field Properties
        /// <summary>
        /// Unique record ID
        /// </summary>
        public int SXAB_ID { get; internal set; }
        /// <summary>
        /// TID of corresponding Home Group Daily Attendance record &lt;&lt; may require referential integrity controls
        /// </summary>
        public int? TXHG_TID { get; internal set; }
        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// Year level at time of absence
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ST_YEAR_LEVEL { get; internal set; }
        /// <summary>
        /// Date of absence
        /// </summary>
        public DateTime? ABSENCE_DATE { get; internal set; }
        /// <summary>
        /// Short comment
        /// [Alphanumeric (30)]
        /// </summary>
        public string ABSENCE_COMMENT { get; internal set; }
        /// <summary>
        /// Expected attendance type in the morning
        /// </summary>
        public short? AM_EXP_TYPE { get; internal set; }
        /// <summary>
        /// Did student actually attend in the morning? P=Present, A=Absent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AM_ATTENDED { get; internal set; }
        /// <summary>
        /// Actual attendance type in the morning
        /// </summary>
        public short? AM_ACT_TYPE { get; internal set; }
        /// <summary>
        /// Has an absence in the morning been approved? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AM_APPROVED { get; internal set; }
        /// <summary>
        /// Actual time of arrival in the morning if late (hh:mm)
        /// </summary>
        public short? AM_LATE_ARRIVAL { get; internal set; }
        /// <summary>
        /// Actual time of departure in the morning if early (hh:mm)
        /// </summary>
        public short? AM_EARLY_LEFT { get; internal set; }
        /// <summary>
        /// Expected attendance type in the afternoon
        /// </summary>
        public short? PM_EXP_TYPE { get; internal set; }
        /// <summary>
        /// Did student actually attend in the afternoon? P=Present, A=Absent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PM_ATTENDED { get; internal set; }
        /// <summary>
        /// Actual attendance type in the afternoon
        /// </summary>
        public short? PM_ACT_TYPE { get; internal set; }
        /// <summary>
        /// Has an absence in the afternoon been approved? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PM_APPROVED { get; internal set; }
        /// <summary>
        /// Actual time of arrival in the afternoon if late (hh:mm)
        /// </summary>
        public short? PM_LATE_ARRIVAL { get; internal set; }
        /// <summary>
        /// Actual time of departure in the afternoon if early (hh:mm)
        /// </summary>
        public short? PM_EARLY_LEFT { get; internal set; }
        /// <summary>
        /// Indicates whether contact been made by parent or school
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT { get; internal set; }
        /// <summary>
        /// Method of contact
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONTACT_METHOD { get; internal set; }
        /// <summary>
        /// Attended sick bay? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SICKBAY { get; internal set; }
        /// <summary>
        /// Last user action in tick box
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LAST_ACTION { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [TXHG_TID] => [TXHG].[TXHG_ID]
        /// TID of corresponding Home Group Daily Attendance record &lt;&lt; may require referential integrity controls
        /// </summary>
        public TXHG TXHG_TID_TXHG {
            get
            {
                if (TXHG_TID.HasValue)
                {
                    if (_TXHG_TID_TXHG == null)
                    {
                        _TXHG_TID_TXHG = Context.TXHG.FindByTXHG_ID(TXHG_TID.Value);
                    }
                    return _TXHG_TID_TXHG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STKEY] => [ST].[STKEY]
        /// Student ID
        /// </summary>
        public ST STKEY_ST {
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
        /// Navigation property for [ST_YEAR_LEVEL] => [KCY].[KCYKEY]
        /// Year level at time of absence
        /// </summary>
        public KCY ST_YEAR_LEVEL_KCY {
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
        /// Navigation property for [AM_EXP_TYPE] => [KCT].[KCTKEY]
        /// Expected attendance type in the morning
        /// </summary>
        public KCT AM_EXP_TYPE_KCT {
            get
            {
                if (AM_EXP_TYPE.HasValue)
                {
                    if (_AM_EXP_TYPE_KCT == null)
                    {
                        _AM_EXP_TYPE_KCT = Context.KCT.FindByKCTKEY(AM_EXP_TYPE.Value);
                    }
                    return _AM_EXP_TYPE_KCT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM_ACT_TYPE] => [KCT].[KCTKEY]
        /// Actual attendance type in the morning
        /// </summary>
        public KCT AM_ACT_TYPE_KCT {
            get
            {
                if (AM_ACT_TYPE.HasValue)
                {
                    if (_AM_ACT_TYPE_KCT == null)
                    {
                        _AM_ACT_TYPE_KCT = Context.KCT.FindByKCTKEY(AM_ACT_TYPE.Value);
                    }
                    return _AM_ACT_TYPE_KCT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM_EXP_TYPE] => [KCT].[KCTKEY]
        /// Expected attendance type in the afternoon
        /// </summary>
        public KCT PM_EXP_TYPE_KCT {
            get
            {
                if (PM_EXP_TYPE.HasValue)
                {
                    if (_PM_EXP_TYPE_KCT == null)
                    {
                        _PM_EXP_TYPE_KCT = Context.KCT.FindByKCTKEY(PM_EXP_TYPE.Value);
                    }
                    return _PM_EXP_TYPE_KCT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM_ACT_TYPE] => [KCT].[KCTKEY]
        /// Actual attendance type in the afternoon
        /// </summary>
        public KCT PM_ACT_TYPE_KCT {
            get
            {
                if (PM_ACT_TYPE.HasValue)
                {
                    if (_PM_ACT_TYPE_KCT == null)
                    {
                        _PM_ACT_TYPE_KCT = Context.KCT.FindByKCTKEY(PM_ACT_TYPE.Value);
                    }
                    return _PM_ACT_TYPE_KCT;
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
