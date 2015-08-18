using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Converted Student Half-Day Absences
    /// </summary>
    public class SXABCONV : EntityBase
    {
#region Navigation Property Cache
        private ST _STKEY_ST;
        private KCY _ST_YEAR_LEVEL_KCY;
        private KCT _AM_TYPE_KCT;
        private KCT _PM_TYPE_KCT;
#endregion

#region Field Properties
        /// <summary>
        /// Unique record ID
        /// </summary>
        public int SXABCONV_ID { get; internal set; }
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
        /// Expected attendance type in the morning
        /// </summary>
        public short? AM_TYPE { get; internal set; }
        /// <summary>
        /// Did student actually attend in the morning? P=Present, A=Absent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AM_ATTENDED { get; internal set; }
        /// <summary>
        /// Has an absence in the morning been approved? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AM_APPROVED { get; internal set; }
        /// <summary>
        /// Expected attendance type in the afternoon
        /// </summary>
        public short? PM_TYPE { get; internal set; }
        /// <summary>
        /// Did student actually attend in the afternoon? P=Present, A=Absent
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PM_ATTENDED { get; internal set; }
        /// <summary>
        /// Has an absence in the afternoon been approved? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PM_APPROVED { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Source of the record - either C21_SXAB or 3rd party product
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string RECORD_SOURCE { get; internal set; }
#endregion

#region Navigation Properties
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
        /// Navigation property for [AM_TYPE] => [KCT].[KCTKEY]
        /// Expected attendance type in the morning
        /// </summary>
        public KCT AM_TYPE_KCT {
            get
            {
                if (AM_TYPE.HasValue)
                {
                    if (_AM_TYPE_KCT == null)
                    {
                        _AM_TYPE_KCT = Context.KCT.FindByKCTKEY(AM_TYPE.Value);
                    }
                    return _AM_TYPE_KCT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM_TYPE] => [KCT].[KCTKEY]
        /// Expected attendance type in the afternoon
        /// </summary>
        public KCT PM_TYPE_KCT {
            get
            {
                if (PM_TYPE.HasValue)
                {
                    if (_PM_TYPE_KCT == null)
                    {
                        _PM_TYPE_KCT = Context.KCT.FindByKCTKEY(PM_TYPE.Value);
                    }
                    return _PM_TYPE_KCT;
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
