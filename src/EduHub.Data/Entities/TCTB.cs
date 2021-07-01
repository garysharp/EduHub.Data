using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Absences
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTB : EduHubEntity
    {

        #region Navigation Property Cache

        private TC Cache_TCTBKEY_TC;
        private SU Cache_SUBJ_SU;
        private SF Cache_TEACHER_SF;
        private SM Cache_ROOM_SM;
        private TCAT Cache_ABSENCE_TYPE_TCAT;

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
        /// Absent date
        /// </summary>
        public DateTime TCTBKEY { get; internal set; }

        /// <summary>
        /// Subject key
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ { get; internal set; }

        /// <summary>
        /// Class of subject that is away
        /// </summary>
        public short? CLASS { get; internal set; }

        /// <summary>
        /// Teacher that is absent
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }

        /// <summary>
        /// Room that is not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }

        /// <summary>
        /// If subject absence, is teacher available
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TEACHER_AVAILABLE { get; internal set; }

        /// <summary>
        /// If subject absence, is room available
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROOM_AVAILABLE { get; internal set; }

        /// <summary>
        /// Start time of absence
        /// </summary>
        public DateTime? TIME_FROM { get; internal set; }

        /// <summary>
        /// End time of absence
        /// </summary>
        public DateTime? TIME_TO { get; internal set; }

        /// <summary>
        /// Comments
        /// [Memo]
        /// </summary>
        public string COMMENT_A { get; internal set; }

        /// <summary>
        /// Absence type code. Defaults to "CURRICULUM" if absence created by an Event
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ABSENCE_TYPE { get; internal set; }

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
        /// TC (Calendar) related entity by [TCTB.TCTBKEY]-&gt;[TC.TCKEY]
        /// Absent date
        /// </summary>
        public TC TCTBKEY_TC
        {
            get
            {
                if (Cache_TCTBKEY_TC == null)
                {
                    Cache_TCTBKEY_TC = Context.TC.FindByTCKEY(TCTBKEY);
                }

                return Cache_TCTBKEY_TC;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [TCTB.SUBJ]-&gt;[SU.SUKEY]
        /// Subject key
        /// </summary>
        public SU SUBJ_SU
        {
            get
            {
                if (SUBJ == null)
                {
                    return null;
                }
                if (Cache_SUBJ_SU == null)
                {
                    Cache_SUBJ_SU = Context.SU.FindBySUKEY(SUBJ);
                }

                return Cache_SUBJ_SU;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [TCTB.TEACHER]-&gt;[SF.SFKEY]
        /// Teacher that is absent
        /// </summary>
        public SF TEACHER_SF
        {
            get
            {
                if (TEACHER == null)
                {
                    return null;
                }
                if (Cache_TEACHER_SF == null)
                {
                    Cache_TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                }

                return Cache_TEACHER_SF;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [TCTB.ROOM]-&gt;[SM.ROOM]
        /// Room that is not available
        /// </summary>
        public SM ROOM_SM
        {
            get
            {
                if (ROOM == null)
                {
                    return null;
                }
                if (Cache_ROOM_SM == null)
                {
                    Cache_ROOM_SM = Context.SM.FindByROOM(ROOM);
                }

                return Cache_ROOM_SM;
            }
        }

        /// <summary>
        /// TCAT (Staff Absence Types) related entity by [TCTB.ABSENCE_TYPE]-&gt;[TCAT.TCATKEY]
        /// Absence type code. Defaults to "CURRICULUM" if absence created by an Event
        /// </summary>
        public TCAT ABSENCE_TYPE_TCAT
        {
            get
            {
                if (ABSENCE_TYPE == null)
                {
                    return null;
                }
                if (Cache_ABSENCE_TYPE_TCAT == null)
                {
                    Cache_ABSENCE_TYPE_TCAT = Context.TCAT.FindByTCATKEY(ABSENCE_TYPE);
                }

                return Cache_ABSENCE_TYPE_TCAT;
            }
        }

        #endregion

    }
}
