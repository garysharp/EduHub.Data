using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Converted Student Half-Day Absences
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SXABCONV : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_STKEY_ST;
        private KCY Cache_ST_YEAR_LEVEL_KCY;
        private KCT Cache_AM_TYPE_KCT;
        private KCT Cache_PM_TYPE_KCT;

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
        /// ST (Students) related entity by [SXABCONV.STKEY]-&gt;[ST.STKEY]
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
        /// KCY (Year Levels) related entity by [SXABCONV.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
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
        /// KCT (Absence Types) related entity by [SXABCONV.AM_TYPE]-&gt;[KCT.KCTKEY]
        /// Expected attendance type in the morning
        /// </summary>
        public KCT AM_TYPE_KCT
        {
            get
            {
                if (AM_TYPE == null)
                {
                    return null;
                }
                if (Cache_AM_TYPE_KCT == null)
                {
                    Cache_AM_TYPE_KCT = Context.KCT.FindByKCTKEY(AM_TYPE.Value);
                }

                return Cache_AM_TYPE_KCT;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [SXABCONV.PM_TYPE]-&gt;[KCT.KCTKEY]
        /// Expected attendance type in the afternoon
        /// </summary>
        public KCT PM_TYPE_KCT
        {
            get
            {
                if (PM_TYPE == null)
                {
                    return null;
                }
                if (Cache_PM_TYPE_KCT == null)
                {
                    Cache_PM_TYPE_KCT = Context.KCT.FindByKCTKEY(PM_TYPE.Value);
                }

                return Cache_PM_TYPE_KCT;
            }
        }

        #endregion

    }
}
