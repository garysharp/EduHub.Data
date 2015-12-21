using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Grid
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEX : EduHubEntity
    {

        #region Navigation Property Cache

        private TT Cache_GKEY_TT;
        private SM Cache_EXAM_ROOM_SM;

        #endregion

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
        /// Subject record
        /// </summary>
        public int? TTES_TID { get; internal set; }

        /// <summary>
        /// Exam grid row
        /// </summary>
        public short? EXAM_ROW { get; internal set; }

        /// <summary>
        /// Exam grid column
        /// </summary>
        public short? EXAM_COL { get; internal set; }

        /// <summary>
        /// Exam grid fixed row
        /// </summary>
        public short? EXAM_FIX_ROW { get; internal set; }

        /// <summary>
        /// Exam grid fixed column
        /// </summary>
        public short? EXAM_FIX_COL { get; internal set; }

        /// <summary>
        /// Room for subject under TTES
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EXAM_ROOM { get; internal set; }

        /// <summary>
        /// Description of Exam
        /// [Alphanumeric (15)]
        /// </summary>
        public string EXAM_DESCRIPTION { get; internal set; }

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
        /// TT (Timetable Grid Templates) related entity by [TTEX.GKEY]-&gt;[TT.TTKEY]
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

        /// <summary>
        /// SM (Rooms) related entity by [TTEX.EXAM_ROOM]-&gt;[SM.ROOM]
        /// Room for subject under TTES
        /// </summary>
        public SM EXAM_ROOM_SM
        {
            get
            {
                if (EXAM_ROOM == null)
                {
                    return null;
                }
                if (Cache_EXAM_ROOM_SM == null)
                {
                    Cache_EXAM_ROOM_SM = Context.SM.FindByROOM(EXAM_ROOM);
                }

                return Cache_EXAM_ROOM_SM;
            }
        }

        #endregion

    }
}
