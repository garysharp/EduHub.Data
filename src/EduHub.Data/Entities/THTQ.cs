using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Entries
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THTQ : EduHubEntity
    {

        #region Navigation Property Cache

        private TH Cache_QKEY_TH;
        private TT Cache_GKEY_TT;
        private SU Cache_SUBJ_SU;
        private SF Cache_T1TEACH_SF;
        private SF Cache_T2TEACH_SF;
        private SM Cache_R1ROOM_SM;
        private SM Cache_R2ROOM_SM;
        private SF Cache_EXTRA_TEACH_SF;
        private SM Cache_EXTRA_ROOM_SM;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Link to Timetable Quilt Header
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }

        /// <summary>
        /// Link to Timetable Grid Template
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }

        /// <summary>
        /// Link to Subject
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ { get; internal set; }

        /// <summary>
        /// Set
        /// </summary>
        public short? CLASS { get; internal set; }

        /// <summary>
        /// Occurrence of the subject
        /// </summary>
        public short? OCCUR { get; internal set; }

        /// <summary>
        /// Max occurrences in the quilt
        /// </summary>
        public short? FREQ { get; internal set; }

        /// <summary>
        /// Grid line label
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string ROW_LABEL { get; internal set; }

        /// <summary>
        /// Allows quilt labels to be "tied"
        /// </summary>
        public short? TIED { get; internal set; }

        /// <summary>
        /// Unique subject identifier (TTTG.IDENT)
        /// </summary>
        public int? IDENT { get; internal set; }

        /// <summary>
        /// Actual set size (TBI)
        /// </summary>
        public short? CLASS_SIZE { get; internal set; }

        /// <summary>
        /// Staff code of first or only teacher for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string T1TEACH { get; internal set; }

        /// <summary>
        /// Staff code of second teacher for this period (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string T2TEACH { get; internal set; }

        /// <summary>
        /// Room code of first or only room for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string R1ROOM { get; internal set; }

        /// <summary>
        /// Room code of second room for this period (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string R2ROOM { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES01 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES02 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES03 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES04 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES05 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES06 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES07 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES08 { get; internal set; }

        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES09 { get; internal set; }

        /// <summary>
        /// Staff code of last replacement teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EXTRA_TEACH { get; internal set; }

        /// <summary>
        /// Room code of last replacement room
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EXTRA_ROOM { get; internal set; }

        /// <summary>
        /// Quilt cell row
        /// </summary>
        public short? QROW { get; internal set; }

        /// <summary>
        /// Quilt cell col
        /// </summary>
        public short? QCOL { get; internal set; }

        /// <summary>
        /// Grid row (TTTG.HROW)
        /// </summary>
        public short? GROW { get; internal set; }

        /// <summary>
        /// Grid col (TTTG.HCOL)
        /// </summary>
        public short? GCOL { get; internal set; }

        /// <summary>
        /// Subject link chain no (TTTG.LCHAIN)
        /// </summary>
        public short? LINK { get; internal set; }

        /// <summary>
        /// Inserted by Schema Verify
        /// </summary>
        public short? COMPOSITE { get; internal set; }

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
        /// TH (Timetable Quilt Headers) related entity by [THTQ.QKEY]-&gt;[TH.THKEY]
        /// Link to Timetable Quilt Header
        /// </summary>
        public TH QKEY_TH
        {
            get
            {
                if (Cache_QKEY_TH == null)
                {
                    Cache_QKEY_TH = Context.TH.FindByTHKEY(QKEY);
                }

                return Cache_QKEY_TH;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [THTQ.GKEY]-&gt;[TT.TTKEY]
        /// Link to Timetable Grid Template
        /// </summary>
        public TT GKEY_TT
        {
            get
            {
                if (GKEY == null)
                {
                    return null;
                }
                if (Cache_GKEY_TT == null)
                {
                    Cache_GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                }

                return Cache_GKEY_TT;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [THTQ.SUBJ]-&gt;[SU.SUKEY]
        /// Link to Subject
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
        /// SF (Staff) related entity by [THTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// Staff code of first or only teacher for this period
        /// </summary>
        public SF T1TEACH_SF
        {
            get
            {
                if (T1TEACH == null)
                {
                    return null;
                }
                if (Cache_T1TEACH_SF == null)
                {
                    Cache_T1TEACH_SF = Context.SF.FindBySFKEY(T1TEACH);
                }

                return Cache_T1TEACH_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [THTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// Staff code of second teacher for this period (if any)
        /// </summary>
        public SF T2TEACH_SF
        {
            get
            {
                if (T2TEACH == null)
                {
                    return null;
                }
                if (Cache_T2TEACH_SF == null)
                {
                    Cache_T2TEACH_SF = Context.SF.FindBySFKEY(T2TEACH);
                }

                return Cache_T2TEACH_SF;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [THTQ.R1ROOM]-&gt;[SM.ROOM]
        /// Room code of first or only room for this period
        /// </summary>
        public SM R1ROOM_SM
        {
            get
            {
                if (R1ROOM == null)
                {
                    return null;
                }
                if (Cache_R1ROOM_SM == null)
                {
                    Cache_R1ROOM_SM = Context.SM.FindByROOM(R1ROOM);
                }

                return Cache_R1ROOM_SM;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [THTQ.R2ROOM]-&gt;[SM.ROOM]
        /// Room code of second room for this period (if any)
        /// </summary>
        public SM R2ROOM_SM
        {
            get
            {
                if (R2ROOM == null)
                {
                    return null;
                }
                if (Cache_R2ROOM_SM == null)
                {
                    Cache_R2ROOM_SM = Context.SM.FindByROOM(R2ROOM);
                }

                return Cache_R2ROOM_SM;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [THTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// Staff code of last replacement teacher
        /// </summary>
        public SF EXTRA_TEACH_SF
        {
            get
            {
                if (EXTRA_TEACH == null)
                {
                    return null;
                }
                if (Cache_EXTRA_TEACH_SF == null)
                {
                    Cache_EXTRA_TEACH_SF = Context.SF.FindBySFKEY(EXTRA_TEACH);
                }

                return Cache_EXTRA_TEACH_SF;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [THTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// Room code of last replacement room
        /// </summary>
        public SM EXTRA_ROOM_SM
        {
            get
            {
                if (EXTRA_ROOM == null)
                {
                    return null;
                }
                if (Cache_EXTRA_ROOM_SM == null)
                {
                    Cache_EXTRA_ROOM_SM = Context.SM.FindByROOM(EXTRA_ROOM);
                }

                return Cache_EXTRA_ROOM_SM;
            }
        }

        #endregion

    }
}
