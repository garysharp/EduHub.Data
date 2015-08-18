using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Grid Subjects
    /// </summary>
    public class TTTG : EntityBase
    {
#region Navigation Property Cache
        private TT _GKEY_TT;
        private SU _SUBJ_SU;
        private SF _T1TEACH_SF;
        private SF _T2TEACH_SF;
        private SM _R1ROOM_SM;
        private SM _R2ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
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
        /// The first (lowest) class number for this Subject
        /// </summary>
        public short? FIRST_CLASS { get; internal set; }
        /// <summary>
        /// Number of sets allocated
        /// </summary>
        public short? NSET { get; internal set; }
        /// <summary>
        /// Unique subject/class identifier on a particular timetable
        /// </summary>
        public int IDENT { get; internal set; }
        /// <summary>
        /// Actual set size (TBI)
        /// </summary>
        public short? CLASS_SIZE { get; internal set; }
        /// <summary>
        /// Maximum set size
        /// </summary>
        public short? MAXIMUM { get; internal set; }
        /// <summary>
        /// Minimum set size
        /// </summary>
        public short? MINIMUM { get; internal set; }
        /// <summary>
        /// Minimum line range
        /// </summary>
        public short? MINLINE { get; internal set; }
        /// <summary>
        /// Maximum line range
        /// </summary>
        public short? MAXLINE { get; internal set; }
        /// <summary>
        /// Mono colour
        /// </summary>
        public short? MCOLOUR { get; internal set; }
        /// <summary>
        /// Graphics colour
        /// </summary>
        public int? GCOLOUR { get; internal set; }
        /// <summary>
        /// Number of units (NSW)
        /// </summary>
        public short? UNITS { get; internal set; }
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
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES01 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES02 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES03 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES04 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES05 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES06 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES07 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES08 { get; internal set; }
        /// <summary>
        /// Resources
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES09 { get; internal set; }
        /// <summary>
        /// Grid Label
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string LAB { get; internal set; }
        /// <summary>
        /// Fixed grid row (line)
        /// </summary>
        public short? FROW { get; internal set; }
        /// <summary>
        /// Fixed grid column
        /// </summary>
        public short? FCOL { get; internal set; }
        /// <summary>
        /// Home grid row (line)
        /// </summary>
        public short? HROW { get; internal set; }
        /// <summary>
        /// Home grid column
        /// </summary>
        public short? HCOL { get; internal set; }
        /// <summary>
        /// Block control
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BLOCK { get; internal set; }
        /// <summary>
        /// Lock status on grid line: 0=Unlock, 1=Lock subject, 2=Lock line, 3=Lock both line & subject
        /// </summary>
        public short? LOCK { get; internal set; }
        /// <summary>
        /// Tied chain no
        /// </summary>
        public short? TCHAIN { get; internal set; }
        /// <summary>
        /// Link chain no
        /// </summary>
        public short? LCHAIN { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify
        /// </summary>
        public short? TIED_COL { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify
        /// </summary>
        public short? LINK_COL { get; internal set; }
        /// <summary>
        /// Max # classes that subject can have on any row
        /// </summary>
        public short? MAX_ROW_CLASSES { get; internal set; }
        /// <summary>
        /// Describe lines on a grid with a block equivalent
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string ROW_GROUP { get; internal set; }
        /// <summary>
        /// # Double periods. Applies if Unit value > 1
        /// </summary>
        public short? DOUBLE_PERIODS { get; internal set; }
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
        /// Navigation property for [GKEY] => [TT].[TTKEY]
        /// Link to Timetable Grid Template
        /// </summary>
        public TT GKEY_TT {
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
        /// Navigation property for [SUBJ] => [SU].[SUKEY]
        /// Link to Subject
        /// </summary>
        public SU SUBJ_SU {
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
        /// Navigation property for [T1TEACH] => [SF].[SFKEY]
        /// Staff code of first or only teacher for this period
        /// </summary>
        public SF T1TEACH_SF {
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
        /// Navigation property for [T2TEACH] => [SF].[SFKEY]
        /// Staff code of second teacher for this period (if any)
        /// </summary>
        public SF T2TEACH_SF {
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
        /// Navigation property for [R1ROOM] => [SM].[ROOM]
        /// Room code of first or only room for this period
        /// </summary>
        public SM R1ROOM_SM {
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
        /// Navigation property for [R2ROOM] => [SM].[ROOM]
        /// Room code of second room for this period (if any)
        /// </summary>
        public SM R2ROOM_SM {
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
#endregion
    }
}
