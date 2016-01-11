using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Class Information
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTQ : EduHubEntity
    {

        #region Navigation Property Cache

        private TC Cache_TCTQKEY_TC;
        private TH Cache_QKEY_TH;
        private SU Cache_SUBJ_SU;
        private SF Cache_T1TEACH_SF;
        private SF Cache_T2TEACH_SF;
        private SM Cache_R1ROOM_SM;
        private SM Cache_R2ROOM_SM;
        private SF Cache_EXTRA_TEACH_SF;
        private SM Cache_EXTRA_ROOM_SM;
        private TT Cache_GKEY_TT;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// (was TQTCKEY) Owner relation
        /// </summary>
        public DateTime TCTQKEY { get; internal set; }

        /// <summary>
        /// Associated Quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }

        /// <summary>
        /// Subject
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ { get; internal set; }

        /// <summary>
        /// Class number
        /// </summary>
        public short? CLASS { get; internal set; }

        /// <summary>
        /// Ident number
        /// </summary>
        public int? IDENT { get; internal set; }

        /// <summary>
        /// Actual class size
        /// </summary>
        public short? CLASS_SIZE { get; internal set; }

        /// <summary>
        /// 1st teacher for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string T1TEACH { get; internal set; }

        /// <summary>
        /// 2nd teacher for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string T2TEACH { get; internal set; }

        /// <summary>
        /// 1st room for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string R1ROOM { get; internal set; }

        /// <summary>
        /// 2nd room for this period
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
        /// Teacher replacement
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EXTRA_TEACH { get; internal set; }

        /// <summary>
        /// Room for replacement
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
        /// Flag indicating if this is a composite class
        /// </summary>
        public short? COMPOSITE { get; internal set; }

        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }

        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public short? GROW { get; internal set; }

        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public short? GCOL { get; internal set; }

        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public int? GCOLOUR { get; internal set; }

        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public short? OCCUR { get; internal set; }

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
        /// TC (Calendar) related entity by [TCTQ.TCTQKEY]-&gt;[TC.TCKEY]
        /// (was TQTCKEY) Owner relation
        /// </summary>
        public TC TCTQKEY_TC
        {
            get
            {
                if (Cache_TCTQKEY_TC == null)
                {
                    Cache_TCTQKEY_TC = Context.TC.FindByTCKEY(TCTQKEY);
                }

                return Cache_TCTQKEY_TC;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entity by [TCTQ.QKEY]-&gt;[TH.THKEY]
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

        /// <summary>
        /// SU (Subjects) related entity by [TCTQ.SUBJ]-&gt;[SU.SUKEY]
        /// Subject
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
        /// SF (Staff) related entity by [TCTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// 1st teacher for this period
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
        /// SF (Staff) related entity by [TCTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// 2nd teacher for this period
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
        /// SM (Rooms) related entity by [TCTQ.R1ROOM]-&gt;[SM.ROOM]
        /// 1st room for this period
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
        /// SM (Rooms) related entity by [TCTQ.R2ROOM]-&gt;[SM.ROOM]
        /// 2nd room for this period
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
        /// SF (Staff) related entity by [TCTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// Teacher replacement
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
        /// SM (Rooms) related entity by [TCTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// Room for replacement
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

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TCTQ.GKEY]-&gt;[TT.TTKEY]
        /// Inserted by Schema Verify for 8.15.1
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

        #endregion

    }
}
