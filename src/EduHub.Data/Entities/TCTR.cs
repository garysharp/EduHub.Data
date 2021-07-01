using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Replacements
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTR : EduHubEntity
    {

        #region Navigation Property Cache

        private TC Cache_TCTRKEY_TC;
        private SF Cache_TEACH_SF;
        private SM Cache_ROOM_SM;

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
        /// Replacement date
        /// </summary>
        public DateTime TCTRKEY { get; internal set; }

        /// <summary>
        /// TCTQ record that the replacement is for
        /// </summary>
        public int? TCTQ_TID { get; internal set; }

        /// <summary>
        /// Replacement teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACH { get; internal set; }

        /// <summary>
        /// Replacement room
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }

        /// <summary>
        /// Comments
        /// [Memo]
        /// </summary>
        public string COMMENT_R { get; internal set; }

        /// <summary>
        /// Is replacement to be counted as an extra
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string COUNT_EXTRAS { get; internal set; }

        /// <summary>
        /// % count 0 - 100 of a full extra
        /// </summary>
        public double? EXTRAS_VALUE { get; internal set; }

        /// <summary>
        /// The absentee record that this belongs to
        /// </summary>
        public int? ABSENTEE_TID { get; internal set; }

        /// <summary>
        /// Flag if replacement teacher is a clash
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TEACHER_CLASH { get; internal set; }

        /// <summary>
        /// Flag if replacement room is a clash
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROOM_CLASH { get; internal set; }

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
        /// TC (Calendar) related entity by [TCTR.TCTRKEY]-&gt;[TC.TCKEY]
        /// Replacement date
        /// </summary>
        public TC TCTRKEY_TC
        {
            get
            {
                if (Cache_TCTRKEY_TC == null)
                {
                    Cache_TCTRKEY_TC = Context.TC.FindByTCKEY(TCTRKEY);
                }

                return Cache_TCTRKEY_TC;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [TCTR.TEACH]-&gt;[SF.SFKEY]
        /// Replacement teacher
        /// </summary>
        public SF TEACH_SF
        {
            get
            {
                if (TEACH == null)
                {
                    return null;
                }
                if (Cache_TEACH_SF == null)
                {
                    Cache_TEACH_SF = Context.SF.FindBySFKEY(TEACH);
                }

                return Cache_TEACH_SF;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [TCTR.ROOM]-&gt;[SM.ROOM]
        /// Replacement room
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

        #endregion

    }
}
