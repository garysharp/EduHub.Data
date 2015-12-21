using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Multiple Day Absences
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STRA : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_STKEY_ST;
        private KCT Cache_ABS_TYPE_KCT;

        #endregion

        #region Field Properties

        /// <summary>
        /// Unique ID for this record
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STKEY { get; internal set; }

        /// <summary>
        /// Date of first day of period of absence
        /// </summary>
        public DateTime? START_DATE { get; internal set; }

        /// <summary>
        /// Start Absence AM or PM for Half Day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string START_AM_PM { get; internal set; }

        /// <summary>
        /// Date of last day of period of absence
        /// </summary>
        public DateTime? END_DATE { get; internal set; }

        /// <summary>
        /// End Absence AM or PM for Half Day
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string END_AM_PM { get; internal set; }

        /// <summary>
        /// Comments on absence
        /// [Alphanumeric (30)]
        /// </summary>
        public string COMMENTS { get; internal set; }

        /// <summary>
        /// Type of absence if known
        /// </summary>
        public short? ABS_TYPE { get; internal set; }

        /// <summary>
        /// First absent period (period absences)
        /// </summary>
        public short? START_PERIOD { get; internal set; }

        /// <summary>
        /// Last absent period (period absences)
        /// </summary>
        public short? END_PERIOD { get; internal set; }

        /// <summary>
        /// Every day = D or recurring Weekly = W
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FREQUENCY { get; internal set; }

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
        /// ST (Students) related entity by [STRA.STKEY]-&gt;[ST.STKEY]
        /// Student ID
        /// </summary>
        public ST STKEY_ST
        {
            get
            {
                if (Cache_STKEY_ST == null)
                {
                    Cache_STKEY_ST = Context.ST.FindBySTKEY(STKEY);
                }

                return Cache_STKEY_ST;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [STRA.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// Type of absence if known
        /// </summary>
        public KCT ABS_TYPE_KCT
        {
            get
            {
                if (ABS_TYPE == null)
                {
                    return null;
                }
                if (Cache_ABS_TYPE_KCT == null)
                {
                    Cache_ABS_TYPE_KCT = Context.KCT.FindByKCTKEY(ABS_TYPE.Value);
                }

                return Cache_ABS_TYPE_KCT;
            }
        }

        #endregion

    }
}
