using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels
    /// </summary>
    public partial class KCY : EntityBase
    {
#region Navigation Property Cache
        private SF _TEACHER_SF;
        private SF _TEACHER_B_SF;
        private KCY _NEXT_YR_KCY;
#endregion

#region Field Properties
        /// <summary>
        /// Year level code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string KCYKEY { get; internal set; }
        /// <summary>
        /// Year level title
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Numeric year level value that supports array indexing and age validation
        /// </summary>
        public short? NUM_EQVT { get; internal set; }
        /// <summary>
        /// Short description
        /// [Alphanumeric (10)]
        /// </summary>
        public string SHORT_DESC { get; internal set; }
        /// <summary>
        /// Staff code of first or only year level Coordinator
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Staff code of second year level Coordinator (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER_B { get; internal set; }
        /// <summary>
        /// Year level to which promoted from this year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string NEXT_YR { get; internal set; }
        /// <summary>
        /// This year level is final year level at school? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FINAL_YR { get; internal set; }
        /// <summary>
        /// Are CSF results required for this year level? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CSF_REQUIRED { get; internal set; }
        /// <summary>
        /// Are Half day absences recorded for this year? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HALF_DAY_ABS { get; internal set; }
        /// <summary>
        /// Are Period absences recorded for this year? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERIOD_ABS { get; internal set; }
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
        /// SF (Staff) related entity by [KCY.TEACHER]-&gt;[SF.SFKEY]
        /// Staff code of first or only year level Coordinator
        /// </summary>
        public SF TEACHER_SF
        {
            get
            {
                if (TEACHER != null)
                {
                    if (_TEACHER_SF == null)
                    {
                        _TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                    }
                    return _TEACHER_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [KCY.TEACHER_B]-&gt;[SF.SFKEY]
        /// Staff code of second year level Coordinator (if any)
        /// </summary>
        public SF TEACHER_B_SF
        {
            get
            {
                if (TEACHER_B != null)
                {
                    if (_TEACHER_B_SF == null)
                    {
                        _TEACHER_B_SF = Context.SF.FindBySFKEY(TEACHER_B);
                    }
                    return _TEACHER_B_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [KCY.NEXT_YR]-&gt;[KCY.KCYKEY]
        /// Year level to which promoted from this year level
        /// </summary>
        public KCY NEXT_YR_KCY
        {
            get
            {
                if (NEXT_YR != null)
                {
                    if (_NEXT_YR_KCY == null)
                    {
                        _NEXT_YR_KCY = Context.KCY.FindByKCYKEY(NEXT_YR);
                    }
                    return _NEXT_YR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entities by [KCY.NEXT_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<KCY> KCY_NEXT_YR
        {
            get
            {
                return Context.KCY.FindKCYByNEXT_YR(KCYKEY);
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KGC.MIN_AC_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<KGC> KGC_MIN_AC_YR
        {
            get
            {
                return Context.KCY.FindKGCByMIN_AC_YR(KCYKEY);
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KGC.MAX_AC_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<KGC> KGC_MAX_AC_YR
        {
            get
            {
                return Context.KCY.FindKGCByMAX_AC_YR(KCYKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJECT_ACADEMIC_YEAR
        {
            get
            {
                return Context.KCY.FindSCBySUBJECT_ACADEMIC_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// SCSFAG (CSF Data Aggregates) related entities by [SCSFAG.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SCSFAG> SCSFAG_ST_YEAR_LEVEL
        {
            get
            {
                return Context.KCY.FindSCSFAGByST_YEAR_LEVEL(KCYKEY);
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [SG.CAND_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SG> SG_CAND_FIRST_YR
        {
            get
            {
                return Context.KCY.FindSGByCAND_FIRST_YR(KCYKEY);
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [SG.CAND_LAST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SG> SG_CAND_LAST_YR
        {
            get
            {
                return Context.KCY.FindSGByCAND_LAST_YR(KCYKEY);
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [SG.FUT_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SG> SG_FUT_FIRST_YR
        {
            get
            {
                return Context.KCY.FindSGByFUT_FIRST_YR(KCYKEY);
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [SG.FUT_LAST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SG> SG_FUT_LAST_YR
        {
            get
            {
                return Context.KCY.FindSGByFUT_LAST_YR(KCYKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_SCHOOL_YEAR
        {
            get
            {
                return Context.KCY.FindSTBySCHOOL_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// ST_TFR (ST Transfer) related entities by [ST_TFR.SCHOOL_YEAR_NEW]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<ST_TFR> ST_TFR_SCHOOL_YEAR_NEW
        {
            get
            {
                return Context.KCY.FindST_TFRBySCHOOL_YEAR_NEW(KCYKEY);
            }
        }

        /// <summary>
        /// STMA (Subject Selections &amp; Marks) related entities by [STMA.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<STMA> STMA_SCHOOL_YEAR
        {
            get
            {
                return Context.KCY.FindSTMABySCHOOL_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.ST_SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<STRE> STRE_ST_SCHOOL_YEAR
        {
            get
            {
                return Context.KCY.FindSTREByST_SCHOOL_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// STVDI (VELS Dimension Results) related entities by [STVDI.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<STVDI> STVDI_SCHOOL_YEAR
        {
            get
            {
                return Context.KCY.FindSTVDIBySCHOOL_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// STVDO (VELS Domain Results) related entities by [STVDO.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<STVDO> STVDO_SCHOOL_YEAR
        {
            get
            {
                return Context.KCY.FindSTVDOBySCHOOL_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [SU.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SU> SU_SUBJECT_ACADEMIC_YEAR
        {
            get
            {
                return Context.KCY.FindSUBySUBJECT_ACADEMIC_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// SVAG (VELS Aggregated Dimensions) related entities by [SVAG.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SVAG> SVAG_SCHOOL_YEAR
        {
            get
            {
                return Context.KCY.FindSVAGBySCHOOL_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [SXAB.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SXAB> SXAB_ST_YEAR_LEVEL
        {
            get
            {
                return Context.KCY.FindSXABByST_YEAR_LEVEL(KCYKEY);
            }
        }

        /// <summary>
        /// SXABCONV (Converted Student Half-Day Absences) related entities by [SXABCONV.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SXABCONV> SXABCONV_ST_YEAR_LEVEL
        {
            get
            {
                return Context.KCY.FindSXABCONVByST_YEAR_LEVEL(KCYKEY);
            }
        }

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [SXAS.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<SXAS> SXAS_ST_YEAR_LEVEL
        {
            get
            {
                return Context.KCY.FindSXASByST_YEAR_LEVEL(KCYKEY);
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [TE.START_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TE> TE_START_YEAR
        {
            get
            {
                return Context.KCY.FindTEBySTART_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [TE.END_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TE> TE_END_YEAR
        {
            get
            {
                return Context.KCY.FindTEByEND_YEAR(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR01]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR01
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR01(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR02]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR02
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR02(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR03]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR03
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR03(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR04]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR04
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR04(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR05]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR05
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR05(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR06]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR06
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR06(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR07]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR07
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR07(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR08]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR08
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR08(KCYKEY);
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [TT.SUBJECT_ACADEMIC_YEAR09]-&gt;[KCY.KCYKEY]
        /// </summary>
        public IReadOnlyList<TT> TT_SUBJECT_ACADEMIC_YEAR09
        {
            get
            {
                return Context.KCY.FindTTBySUBJECT_ACADEMIC_YEAR09(KCYKEY);
            }
        }
#endregion
    }
}
