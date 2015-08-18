using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Grid Templates
    /// </summary>
    public class TT : EntityBase
    {
#region Navigation Property Cache
        private SCI _CAMPUS_SCI;
        private KCY _SUBJECT_ACADEMIC_YEAR01_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR02_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR03_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR04_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR05_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR06_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR07_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR08_KCY;
        private KCY _SUBJECT_ACADEMIC_YEAR09_KCY;
#endregion

#region Field Properties
        /// <summary>
        /// Template code
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TTKEY { get; internal set; }
        /// <summary>
        /// Template title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Can this template be selected by general users
        /// [Alphanumeric (1)]
        /// </summary>
        public string SELECTABLE { get; internal set; }
        /// <summary>
        /// Campus
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG01 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG02 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG03 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG04 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG05 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG06 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG07 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG08 { get; internal set; }
        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG09 { get; internal set; }
        /// <summary>
        /// Subject levy billing period (eg 199703 represents 97 term 3)
        /// </summary>
        public int? TRPERIOD { get; internal set; }
        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TTPERIOD { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR01 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR02 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR03 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR04 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR05 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR06 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR07 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR08 { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR09 { get; internal set; }
        /// <summary>
        /// Semester/term/quarter: if SEMESTER in an SU record is zero or matches this value, the subject is eligible for this template
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// Timetabling year/semester when this reserve subject should be available
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string RESERVE { get; internal set; }
        /// <summary>
        /// Student course set
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string COSET { get; internal set; }
        /// <summary>
        /// Maximum number of grid rows (lines)
        /// </summary>
        public short? MAXROW { get; internal set; }
        /// <summary>
        /// Maximum number of grid columns
        /// </summary>
        public short? MAXCOL { get; internal set; }
        /// <summary>
        /// Relax value
        /// </summary>
        public short? RELAX { get; internal set; }
        /// <summary>
        /// Maximum number of drop-outs allowed
        /// </summary>
        public short? MAXDROP { get; internal set; }
        /// <summary>
        /// Maximum number of solutions to store
        /// </summary>
        public short? MAXSTORE { get; internal set; }
        /// <summary>
        /// Use teacher clashes? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UTEACH { get; internal set; }
        /// <summary>
        /// Use room clashes? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UROOM { get; internal set; }
        /// <summary>
        /// Use resource clashes? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string URESOURCES { get; internal set; }
        /// <summary>
        /// Use fixed grid? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UFIXED { get; internal set; }
        /// <summary>
        /// Use linked subjects? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ULINKS { get; internal set; }
        /// <summary>
        /// Use tied subjects? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UTIED { get; internal set; }
        /// <summary>
        /// Use min/maxline ranges? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string URANGE { get; internal set; }
        /// <summary>
        /// Strategy: High, Low, Both, All, Exhaustive, Reduction
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STRATEGY { get; internal set; }
        /// <summary>
        /// Sort subjects on grid line? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GRIDSORT { get; internal set; }
        /// <summary>
        /// Student put in smallest available set? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SHARE { get; internal set; }
        /// <summary>
        /// Students rearranged if set allocated to is full? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SHUFFLE { get; internal set; }
        /// <summary>
        /// Method of placing unit subjects into solution grid (don't use units/use units with placement restrictions/use units without placement restrictions)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UUNITS { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[] GSOLS { get; internal set; }
        /// <summary>
        /// Added Dec 1997
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HOMEGRID { get; internal set; }
        /// <summary>
        /// User value for priority of clash
        /// </summary>
        public short? TEACHER_CLASH_FACTOR { get; internal set; }
        /// <summary>
        /// (The higher the number the less
        /// </summary>
        public short? ROOM_CLASH_FACTOR { get; internal set; }
        /// <summary>
        /// likely that item will clash)
        /// </summary>
        public short? RESOURCE_CLASH_FACTOR { get; internal set; }
        /// <summary>
        /// (Student max 9, rest 999)
        /// </summary>
        public short? STUDENT_DROP_FACTOR { get; internal set; }
        /// <summary>
        /// Default for TTTG.MAXIMUM
        /// </summary>
        public short? MAX_CLASS_SIZE { get; internal set; }
        /// <summary>
        /// Maximum teacher clashes for a quilt generated grid
        /// </summary>
        public short? MAXTCLASH { get; internal set; }
        /// <summary>
        /// Maximum room clashes for a quilt generated grid
        /// </summary>
        public short? MAXRCLASH { get; internal set; }
        /// <summary>
        /// Maximum resource clashes for a quilt generated grid
        /// </summary>
        public short? MAXXCLASH { get; internal set; }
        /// <summary>
        /// Maximum balance factor for a quilt generated grid
        /// </summary>
        public short? MAXBALANCE { get; internal set; }
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
        /// Navigation property for [CAMPUS] => [SCI].[SCIKEY]
        /// Campus
        /// </summary>
        public SCI CAMPUS_SCI {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR01] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR01_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR01 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR01_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR01_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR01);
                    }
                    return _SUBJECT_ACADEMIC_YEAR01_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR02] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR02_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR02 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR02_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR02_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR02);
                    }
                    return _SUBJECT_ACADEMIC_YEAR02_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR03] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR03_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR03 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR03_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR03_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR03);
                    }
                    return _SUBJECT_ACADEMIC_YEAR03_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR04] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR04_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR04 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR04_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR04_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR04);
                    }
                    return _SUBJECT_ACADEMIC_YEAR04_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR05] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR05_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR05 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR05_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR05_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR05);
                    }
                    return _SUBJECT_ACADEMIC_YEAR05_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR06] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR06_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR06 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR06_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR06_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR06);
                    }
                    return _SUBJECT_ACADEMIC_YEAR06_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR07] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR07_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR07 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR07_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR07_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR07);
                    }
                    return _SUBJECT_ACADEMIC_YEAR07_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR08] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR08_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR08 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR08_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR08_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR08);
                    }
                    return _SUBJECT_ACADEMIC_YEAR08_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR09] => [KCY].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR09_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR09 != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR09_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR09_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR09);
                    }
                    return _SUBJECT_ACADEMIC_YEAR09_KCY;
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
