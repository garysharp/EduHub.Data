using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Period Information
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTD : EduHubEntity
    {

        #region Navigation Property Cache

        private TC Cache_TCTDKEY_TC;
        private TH Cache_QKEY_TH;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Owner relation
        /// </summary>
        public DateTime TCTDKEY { get; internal set; }

        /// <summary>
        /// Associated Quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }

        /// <summary>
        /// Time slot number
        /// </summary>
        public short? TIME_INDEX { get; internal set; }

        /// <summary>
        /// Start time of each period hhmm 24 hr clock
        /// </summary>
        public DateTime? TIME_START { get; internal set; }

        /// <summary>
        /// End time of each period hhmm 24 hr clock
        /// </summary>
        public DateTime? TIME_END { get; internal set; }

        /// <summary>
        /// What the time slot is for
        /// </summary>
        public short? TIME_TYPE { get; internal set; }

        /// <summary>
        /// A caption for the timeslot
        /// [Alphanumeric (20)]
        /// </summary>
        public string TIME_NAME { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// TC (Calendar) related entity by [TCTD.TCTDKEY]-&gt;[TC.TCKEY]
        /// Owner relation
        /// </summary>
        public TC TCTDKEY_TC
        {
            get
            {
                if (Cache_TCTDKEY_TC == null)
                {
                    Cache_TCTDKEY_TC = Context.TC.FindByTCKEY(TCTDKEY);
                }

                return Cache_TCTDKEY_TC;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entity by [TCTD.QKEY]-&gt;[TH.THKEY]
        /// Associated Quilt
        /// </summary>
        public TH QKEY_TH
        {
            get
            {
                if (QKEY == null)
                {
                    return null;
                }
                if (Cache_QKEY_TH == null)
                {
                    Cache_QKEY_TH = Context.TH.FindByTHKEY(QKEY);
                }

                return Cache_QKEY_TH;
            }
        }

        #endregion

    }
}
