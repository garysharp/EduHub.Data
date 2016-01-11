using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Half-Day Absences
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SXAB : EduHubEntity
    {

        #region Navigation Property Cache

        private TXHG Cache_TXHG_TID_TXHG;
        private ST Cache_STKEY_ST;
        private KCY Cache_ST_YEAR_LEVEL_KCY;
        private KCT Cache_AM_EXP_TYPE_KCT;
        private KCT Cache_AM_ACT_TYPE_KCT;
        private KCT Cache_PM_EXP_TYPE_KCT;
        private KCT Cache_PM_ACT_TYPE_KCT;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

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
        /// Key of SMS recipient record sent relating to AM absence
        /// </summary>
        public int? SMS_AM_KEY { get; internal set; }

        /// <summary>
        /// Key of SMS recipient record sent relating to PM absence
        /// </summary>
        public int? SMS_PM_KEY { get; internal set; }

        /// <summary>
        /// Key of Email recipient record sent relating to AM absence
        /// </summary>
        public int? EMAIL_AM_KEY { get; internal set; }

        /// <summary>
        /// Key of Email recipient record sent relating to PM absence
        /// </summary>
        public int? EMAIL_PM_KEY { get; internal set; }

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
        /// TXHG (Home Group Daily Attendance Records) related entity by [SXAB.TXHG_TID]-&gt;[TXHG.TXHG_ID]
        /// TID of corresponding Home Group Daily Attendance record &lt;&lt; may require referential integrity controls
        /// </summary>
        public TXHG TXHG_TID_TXHG
        {
            get
            {
                if (TXHG_TID == null)
                {
                    return null;
                }
                if (Cache_TXHG_TID_TXHG == null)
                {
                    Cache_TXHG_TID_TXHG = Context.TXHG.FindByTXHG_ID(TXHG_TID.Value);
                }

                return Cache_TXHG_TID_TXHG;
            }
        }

        /// <summary>
        /// ST (Students) related entity by [SXAB.STKEY]-&gt;[ST.STKEY]
        /// Student ID
        /// </summary>
        public ST STKEY_ST
        {
            get
            {
                if (STKEY == null)
                {
                    return null;
                }
                if (Cache_STKEY_ST == null)
                {
                    Cache_STKEY_ST = Context.ST.FindBySTKEY(STKEY);
                }

                return Cache_STKEY_ST;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [SXAB.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// Year level at time of absence
        /// </summary>
        public KCY ST_YEAR_LEVEL_KCY
        {
            get
            {
                if (ST_YEAR_LEVEL == null)
                {
                    return null;
                }
                if (Cache_ST_YEAR_LEVEL_KCY == null)
                {
                    Cache_ST_YEAR_LEVEL_KCY = Context.KCY.FindByKCYKEY(ST_YEAR_LEVEL);
                }

                return Cache_ST_YEAR_LEVEL_KCY;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [SXAB.AM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// Expected attendance type in the morning
        /// </summary>
        public KCT AM_EXP_TYPE_KCT
        {
            get
            {
                if (AM_EXP_TYPE == null)
                {
                    return null;
                }
                if (Cache_AM_EXP_TYPE_KCT == null)
                {
                    Cache_AM_EXP_TYPE_KCT = Context.KCT.FindByKCTKEY(AM_EXP_TYPE.Value);
                }

                return Cache_AM_EXP_TYPE_KCT;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [SXAB.AM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// Actual attendance type in the morning
        /// </summary>
        public KCT AM_ACT_TYPE_KCT
        {
            get
            {
                if (AM_ACT_TYPE == null)
                {
                    return null;
                }
                if (Cache_AM_ACT_TYPE_KCT == null)
                {
                    Cache_AM_ACT_TYPE_KCT = Context.KCT.FindByKCTKEY(AM_ACT_TYPE.Value);
                }

                return Cache_AM_ACT_TYPE_KCT;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [SXAB.PM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// Expected attendance type in the afternoon
        /// </summary>
        public KCT PM_EXP_TYPE_KCT
        {
            get
            {
                if (PM_EXP_TYPE == null)
                {
                    return null;
                }
                if (Cache_PM_EXP_TYPE_KCT == null)
                {
                    Cache_PM_EXP_TYPE_KCT = Context.KCT.FindByKCTKEY(PM_EXP_TYPE.Value);
                }

                return Cache_PM_EXP_TYPE_KCT;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [SXAB.PM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// Actual attendance type in the afternoon
        /// </summary>
        public KCT PM_ACT_TYPE_KCT
        {
            get
            {
                if (PM_ACT_TYPE == null)
                {
                    return null;
                }
                if (Cache_PM_ACT_TYPE_KCT == null)
                {
                    Cache_PM_ACT_TYPE_KCT = Context.KCT.FindByKCTKEY(PM_ACT_TYPE.Value);
                }

                return Cache_PM_ACT_TYPE_KCT;
            }
        }

        #endregion

    }
}
