using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Selections &amp; Marks
    /// </summary>
    public partial class STMA : EntityBase
    {
#region Navigation Property Cache
        private ST _SKEY_ST;
        private SU _MKEY_SU;
        private SC _CKEY_SC;
        private KCY _SCHOOL_YEAR_KCY;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string MKEY { get; internal set; }
        /// <summary>
        /// Course code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string CKEY { get; internal set; }
        /// <summary>
        /// student's priority for this subject choice
        /// </summary>
        public short? PRIORITY { get; internal set; }
        /// <summary>
        /// Class: distinguishes different groups of students taking the same subject on the same timetable
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Full name of subject
        /// [Titlecase (30)]
        /// </summary>
        public string FULLNAME { get; internal set; }
        /// <summary>
        /// Teacher taking subject
        /// [Titlecase (30)]
        /// </summary>
        public string TEACHER_NAME { get; internal set; }
        /// <summary>
        /// Software-generated reference to Grid Subject
        /// </summary>
        public int IDENT { get; internal set; }
        /// <summary>
        /// Lock
        /// </summary>
        public short? LOCK { get; internal set; }
        /// <summary>
        /// Subject levy billing period (eg 199703 indicates 1997 term 3): automatically filled from TT.TRPERIOD at creation
        /// </summary>
        public int? TRPERIOD { get; internal set; }
        /// <summary>
        /// Timetabling year/semester in which the subject is completed (eg 1998S1, 1998): automatically filled from TT.TTPERIOD at creation
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TTPERIOD { get; internal set; }
        /// <summary>
        /// Calendar year
        /// </summary>
        public short? CYEAR { get; internal set; }
        /// <summary>
        /// Date record created
        /// </summary>
        public DateTime? CREATED { get; internal set; }
        /// <summary>
        /// Dropout indicator (0/1) which indicates a student has failed to fit all subjects they requested for a specific timetable
        /// </summary>
        public short? DROPOUT { get; internal set; }
        /// <summary>
        /// Results per semester
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GRADE01 { get; internal set; }
        /// <summary>
        /// Results per semester
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GRADE02 { get; internal set; }
        /// <summary>
        /// Results per semester
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GRADE03 { get; internal set; }
        /// <summary>
        /// Results per semester
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GRADE04 { get; internal set; }
        /// <summary>
        /// Results per semester
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GRADE05 { get; internal set; }
        /// <summary>
        /// Comments for Semester 1
        /// [Memo]
        /// </summary>
        public string COMMENTA { get; internal set; }
        /// <summary>
        /// Comments for Semester 2
        /// [Memo]
        /// </summary>
        public string COMMENTB { get; internal set; }
        /// <summary>
        /// Specific year level: (V) (NRM)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// No of periods class ran
        /// </summary>
        public short? TOT_CLASS_PERIODS { get; internal set; }
        /// <summary>
        /// No of approved absences from this subject
        /// </summary>
        public short? TOT_APPROVED_ABS { get; internal set; }
        /// <summary>
        /// No of unapproved absences from this subject
        /// </summary>
        public short? TOT_UNAPPROVED_ABS { get; internal set; }
        /// <summary>
        /// KLA code, copied from Subject table
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string EQUIVALENT_KLA { get; internal set; }
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
        /// ST (Students) related entity by [STMA.SKEY]-&gt;[ST.STKEY]
        /// Student ID
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (SKEY != null)
                {
                    if (_SKEY_ST == null)
                    {
                        _SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                    }
                    return _SKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [STMA.MKEY]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU MKEY_SU
        {
            get
            {
                if (MKEY != null)
                {
                    if (_MKEY_SU == null)
                    {
                        _MKEY_SU = Context.SU.FindBySUKEY(MKEY);
                    }
                    return _MKEY_SU;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SC (Courses) related entity by [STMA.CKEY]-&gt;[SC.COURSE]
        /// Course code
        /// </summary>
        public SC CKEY_SC
        {
            get
            {
                if (CKEY != null)
                {
                    if (_CKEY_SC == null)
                    {
                        _CKEY_SC = Context.SC.FindByCOURSE(CKEY);
                    }
                    return _CKEY_SC;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [STMA.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// Specific year level: (V) (NRM)
        /// </summary>
        public KCY SCHOOL_YEAR_KCY
        {
            get
            {
                if (SCHOOL_YEAR != null)
                {
                    if (_SCHOOL_YEAR_KCY == null)
                    {
                        _SCHOOL_YEAR_KCY = Context.KCY.FindByKCYKEY(SCHOOL_YEAR);
                    }
                    return _SCHOOL_YEAR_KCY;
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
