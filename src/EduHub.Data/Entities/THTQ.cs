using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Entries
    /// </summary>
    public partial class THTQ : EntityBase
    {
#region Navigation Property Cache
        private TH _QKEY_TH;
        private TT _GKEY_TT;
        private SU _SUBJ_SU;
        private SF _T1TEACH_SF;
        private SF _T2TEACH_SF;
        private SM _R1ROOM_SM;
        private SM _R2ROOM_SM;
        private SF _EXTRA_TEACH_SF;
        private SM _EXTRA_ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
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
        public int IDENT { get; internal set; }
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
                if (QKEY != null)
                {
                    if (_QKEY_TH == null)
                    {
                        _QKEY_TH = Context.TH.FindByTHKEY(QKEY);
                    }
                    return _QKEY_TH;
                }
                else
                {
                    return null;
                }
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
                if (GKEY != null)
                {
                    if (_GKEY_TT == null)
                    {
                        _GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                    }
                    return _GKEY_TT;
                }
                else
                {
                    return null;
                }
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
                if (SUBJ != null)
                {
                    if (_SUBJ_SU == null)
                    {
                        _SUBJ_SU = Context.SU.FindBySUKEY(SUBJ);
                    }
                    return _SUBJ_SU;
                }
                else
                {
                    return null;
                }
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
                if (T1TEACH != null)
                {
                    if (_T1TEACH_SF == null)
                    {
                        _T1TEACH_SF = Context.SF.FindBySFKEY(T1TEACH);
                    }
                    return _T1TEACH_SF;
                }
                else
                {
                    return null;
                }
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
                if (T2TEACH != null)
                {
                    if (_T2TEACH_SF == null)
                    {
                        _T2TEACH_SF = Context.SF.FindBySFKEY(T2TEACH);
                    }
                    return _T2TEACH_SF;
                }
                else
                {
                    return null;
                }
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
                if (R1ROOM != null)
                {
                    if (_R1ROOM_SM == null)
                    {
                        _R1ROOM_SM = Context.SM.FindByROOM(R1ROOM);
                    }
                    return _R1ROOM_SM;
                }
                else
                {
                    return null;
                }
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
                if (R2ROOM != null)
                {
                    if (_R2ROOM_SM == null)
                    {
                        _R2ROOM_SM = Context.SM.FindByROOM(R2ROOM);
                    }
                    return _R2ROOM_SM;
                }
                else
                {
                    return null;
                }
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
                if (EXTRA_TEACH != null)
                {
                    if (_EXTRA_TEACH_SF == null)
                    {
                        _EXTRA_TEACH_SF = Context.SF.FindBySFKEY(EXTRA_TEACH);
                    }
                    return _EXTRA_TEACH_SF;
                }
                else
                {
                    return null;
                }
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
                if (EXTRA_ROOM != null)
                {
                    if (_EXTRA_ROOM_SM == null)
                    {
                        _EXTRA_ROOM_SM = Context.SM.FindByROOM(EXTRA_ROOM);
                    }
                    return _EXTRA_ROOM_SM;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
