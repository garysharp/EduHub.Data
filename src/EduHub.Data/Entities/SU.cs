using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects
    /// </summary>
    public class SU : EntityBase
    {
#region Navigation Property Cache
        private KSF _FACULTY_KSF;
        private SU _PROMOTE_SU;
        private KCY _SUBJECT_ACADEMIC_YEAR_KCY;
        private SA _FEE_CODE_SA;
#endregion

#region Field Properties
        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUKEY { get; internal set; }
        /// <summary>
        /// Subject name
        /// [Titlecase (30)]
        /// </summary>
        public string FULLNAME { get; internal set; }
        /// <summary>
        /// Subject short name for screen displays and reports
        /// [Alphanumeric (10)]
        /// </summary>
        public string SHORTNAME { get; internal set; }
        /// <summary>
        /// Faculty
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY { get; internal set; }
        /// <summary>
        /// Subject that normally follows this subject in a course (eg Physics 11 is followed by Physics 12)
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string PROMOTE { get; internal set; }
        /// <summary>
        /// Description of subject for parents
        /// [Memo]
        /// </summary>
        public string OVERVIEW { get; internal set; }
        /// <summary>
        /// Dummy field to enable recording of subject priority
        /// </summary>
        public short? PRIORITY { get; internal set; }
        /// <summary>
        /// (Was ACADEMIC_YEAR) Offered to students at this year level: if blank or matches one of the values in a TT record, the subject is eligible for that template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR { get; internal set; }
        /// <summary>
        /// (Was SEMESTER_OFFERED) Semester/term/quarter in which offered: if 0 or matches the value in a TT record, the subject is eligible for that template
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// Ultranet. T=Term, S=Semester (default), Y=Year
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DURATION { get; internal set; }
        /// <summary>
        /// Is this subject currently active (available for use in timetabling)? (U=Active, other value=Inactive)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SUBJECT_TYPE { get; internal set; }
        /// <summary>
        /// Used to Order Subjects for BarCode Printing
        /// </summary>
        public short? PRINT_SEQ_NO { get; internal set; }
        /// <summary>
        /// Core or elective flag
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ELECTIVE { get; internal set; }
        /// <summary>
        /// VCAA code of this subject for use in VASS export
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string VCAA_ID { get; internal set; }
        /// <summary>
        /// Fee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE { get; internal set; }
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
        /// Navigation property for [FACULTY] => [KSF].[KSFKEY]
        /// Faculty
        /// </summary>
        public KSF FACULTY_KSF {
            get
            {
                if (FACULTY != null)
                {
                    if (_FACULTY_KSF == null)
                    {
                        _FACULTY_KSF = Context.KSF.FindByKSFKEY(FACULTY);
                    }
                    return _FACULTY_KSF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PROMOTE] => [SU].[SUKEY]
        /// Subject that normally follows this subject in a course (eg Physics 11 is followed by Physics 12)
        /// </summary>
        public SU PROMOTE_SU {
            get
            {
                if (PROMOTE != null)
                {
                    if (_PROMOTE_SU == null)
                    {
                        _PROMOTE_SU = Context.SU.FindBySUKEY(PROMOTE);
                    }
                    return _PROMOTE_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR] => [KCY].[KCYKEY]
        /// (Was ACADEMIC_YEAR) Offered to students at this year level: if blank or matches one of the values in a TT record, the subject is eligible for that template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR);
                    }
                    return _SUBJECT_ACADEMIC_YEAR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FEE_CODE] => [SA].[SAKEY]
        /// Fee code
        /// </summary>
        public SA FEE_CODE_SA {
            get
            {
                if (FEE_CODE != null)
                {
                    if (_FEE_CODE_SA == null)
                    {
                        _FEE_CODE_SA = Context.SA.FindBySAKEY(FEE_CODE);
                    }
                    return _FEE_CODE_SA;
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
