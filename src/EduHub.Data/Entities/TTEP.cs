using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Periods
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEP : EduHubEntity
    {

        #region Navigation Property Cache

        private TT Cache_GKEY_TT;

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
        /// Grid involved in exam
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }

        /// <summary>
        /// Exam grid to which this period belongs
        /// </summary>
        public int? TTEI_TID { get; internal set; }

        /// <summary>
        /// Day number for exam period
        /// </summary>
        public DateTime? EXAM_DATE { get; internal set; }

        /// <summary>
        /// Period start time
        /// </summary>
        public DateTime? TIME_START { get; internal set; }

        /// <summary>
        /// Period end time
        /// </summary>
        public DateTime? TIME_END { get; internal set; }

        /// <summary>
        /// Exam grid row for period
        /// </summary>
        public short? EXAM_ROW { get; internal set; }

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
        /// TT (Timetable Grid Templates) related entity by [TTEP.GKEY]-&gt;[TT.TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT GKEY_TT
        {
            get
            {
                if (Cache_GKEY_TT == null)
                {
                    Cache_GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                }

                return Cache_GKEY_TT;
            }
        }

        #endregion

    }
}
