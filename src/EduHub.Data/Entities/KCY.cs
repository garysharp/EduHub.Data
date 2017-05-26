using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCY : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_TEACHER_SF;
        private SF Cache_TEACHER_B_SF;
        private KCY Cache_NEXT_YR_KCY;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<KCY> Cache_KCYKEY_KCY_NEXT_YR;
        private IReadOnlyList<KGC> Cache_KCYKEY_KGC_MIN_AC_YR;
        private IReadOnlyList<KGC> Cache_KCYKEY_KGC_MAX_AC_YR;
        private IReadOnlyList<SC> Cache_KCYKEY_SC_SUBJECT_ACADEMIC_YEAR;
        private IReadOnlyList<SCSFAG> Cache_KCYKEY_SCSFAG_ST_YEAR_LEVEL;
        private IReadOnlyList<SG> Cache_KCYKEY_SG_CAND_FIRST_YR;
        private IReadOnlyList<SG> Cache_KCYKEY_SG_CAND_LAST_YR;
        private IReadOnlyList<SG> Cache_KCYKEY_SG_FUT_FIRST_YR;
        private IReadOnlyList<SG> Cache_KCYKEY_SG_FUT_LAST_YR;
        private IReadOnlyList<ST> Cache_KCYKEY_ST_SCHOOL_YEAR;
        private IReadOnlyList<ST_TFR> Cache_KCYKEY_ST_TFR_SCHOOL_YEAR_NEW;
        private IReadOnlyList<STMA> Cache_KCYKEY_STMA_SCHOOL_YEAR;
        private IReadOnlyList<STRE> Cache_KCYKEY_STRE_ST_SCHOOL_YEAR;
        private IReadOnlyList<SU> Cache_KCYKEY_SU_SUBJECT_ACADEMIC_YEAR;
        private IReadOnlyList<SXAB> Cache_KCYKEY_SXAB_ST_YEAR_LEVEL;
        private IReadOnlyList<SXABCONV> Cache_KCYKEY_SXABCONV_ST_YEAR_LEVEL;
        private IReadOnlyList<SXAS> Cache_KCYKEY_SXAS_ST_YEAR_LEVEL;
        private IReadOnlyList<TE> Cache_KCYKEY_TE_START_YEAR;
        private IReadOnlyList<TE> Cache_KCYKEY_TE_END_YEAR;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR01;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR02;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR03;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR04;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR05;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR06;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR07;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR08;
        private IReadOnlyList<TT> Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR09;

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
        /// Birthdate from
        /// </summary>
        public DateTime? BIRTHDATE_FROM { get; internal set; }

        /// <summary>
        /// Birthdate to
        /// </summary>
        public DateTime? BIRTHDATE_TO { get; internal set; }

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
        /// SF (Staff) related entity by [KCY.TEACHER_B]-&gt;[SF.SFKEY]
        /// Staff code of second year level Coordinator (if any)
        /// </summary>
        public SF TEACHER_B_SF
        {
            get
            {
                if (TEACHER_B == null)
                {
                    return null;
                }
                if (Cache_TEACHER_B_SF == null)
                {
                    Cache_TEACHER_B_SF = Context.SF.FindBySFKEY(TEACHER_B);
                }

                return Cache_TEACHER_B_SF;
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
                if (NEXT_YR == null)
                {
                    return null;
                }
                if (Cache_NEXT_YR_KCY == null)
                {
                    Cache_NEXT_YR_KCY = Context.KCY.FindByKCYKEY(NEXT_YR);
                }

                return Cache_NEXT_YR_KCY;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// KCY (Year Levels) related entities by [KCY.KCYKEY]-&gt;[KCY.NEXT_YR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<KCY> KCYKEY_KCY_NEXT_YR
        {
            get
            {
                if (Cache_KCYKEY_KCY_NEXT_YR == null &&
                    !Context.KCY.TryFindByNEXT_YR(KCYKEY, out Cache_KCYKEY_KCY_NEXT_YR))
                {
                    Cache_KCYKEY_KCY_NEXT_YR = new List<KCY>().AsReadOnly();
                }

                return Cache_KCYKEY_KCY_NEXT_YR;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KCY.KCYKEY]-&gt;[KGC.MIN_AC_YR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<KGC> KCYKEY_KGC_MIN_AC_YR
        {
            get
            {
                if (Cache_KCYKEY_KGC_MIN_AC_YR == null &&
                    !Context.KGC.TryFindByMIN_AC_YR(KCYKEY, out Cache_KCYKEY_KGC_MIN_AC_YR))
                {
                    Cache_KCYKEY_KGC_MIN_AC_YR = new List<KGC>().AsReadOnly();
                }

                return Cache_KCYKEY_KGC_MIN_AC_YR;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KCY.KCYKEY]-&gt;[KGC.MAX_AC_YR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<KGC> KCYKEY_KGC_MAX_AC_YR
        {
            get
            {
                if (Cache_KCYKEY_KGC_MAX_AC_YR == null &&
                    !Context.KGC.TryFindByMAX_AC_YR(KCYKEY, out Cache_KCYKEY_KGC_MAX_AC_YR))
                {
                    Cache_KCYKEY_KGC_MAX_AC_YR = new List<KGC>().AsReadOnly();
                }

                return Cache_KCYKEY_KGC_MAX_AC_YR;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [KCY.KCYKEY]-&gt;[SC.SUBJECT_ACADEMIC_YEAR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SC> KCYKEY_SC_SUBJECT_ACADEMIC_YEAR
        {
            get
            {
                if (Cache_KCYKEY_SC_SUBJECT_ACADEMIC_YEAR == null &&
                    !Context.SC.TryFindBySUBJECT_ACADEMIC_YEAR(KCYKEY, out Cache_KCYKEY_SC_SUBJECT_ACADEMIC_YEAR))
                {
                    Cache_KCYKEY_SC_SUBJECT_ACADEMIC_YEAR = new List<SC>().AsReadOnly();
                }

                return Cache_KCYKEY_SC_SUBJECT_ACADEMIC_YEAR;
            }
        }

        /// <summary>
        /// SCSFAG (CSF Data Aggregates) related entities by [KCY.KCYKEY]-&gt;[SCSFAG.ST_YEAR_LEVEL]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SCSFAG> KCYKEY_SCSFAG_ST_YEAR_LEVEL
        {
            get
            {
                if (Cache_KCYKEY_SCSFAG_ST_YEAR_LEVEL == null &&
                    !Context.SCSFAG.TryFindByST_YEAR_LEVEL(KCYKEY, out Cache_KCYKEY_SCSFAG_ST_YEAR_LEVEL))
                {
                    Cache_KCYKEY_SCSFAG_ST_YEAR_LEVEL = new List<SCSFAG>().AsReadOnly();
                }

                return Cache_KCYKEY_SCSFAG_ST_YEAR_LEVEL;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [KCY.KCYKEY]-&gt;[SG.CAND_FIRST_YR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SG> KCYKEY_SG_CAND_FIRST_YR
        {
            get
            {
                if (Cache_KCYKEY_SG_CAND_FIRST_YR == null &&
                    !Context.SG.TryFindByCAND_FIRST_YR(KCYKEY, out Cache_KCYKEY_SG_CAND_FIRST_YR))
                {
                    Cache_KCYKEY_SG_CAND_FIRST_YR = new List<SG>().AsReadOnly();
                }

                return Cache_KCYKEY_SG_CAND_FIRST_YR;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [KCY.KCYKEY]-&gt;[SG.CAND_LAST_YR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SG> KCYKEY_SG_CAND_LAST_YR
        {
            get
            {
                if (Cache_KCYKEY_SG_CAND_LAST_YR == null &&
                    !Context.SG.TryFindByCAND_LAST_YR(KCYKEY, out Cache_KCYKEY_SG_CAND_LAST_YR))
                {
                    Cache_KCYKEY_SG_CAND_LAST_YR = new List<SG>().AsReadOnly();
                }

                return Cache_KCYKEY_SG_CAND_LAST_YR;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [KCY.KCYKEY]-&gt;[SG.FUT_FIRST_YR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SG> KCYKEY_SG_FUT_FIRST_YR
        {
            get
            {
                if (Cache_KCYKEY_SG_FUT_FIRST_YR == null &&
                    !Context.SG.TryFindByFUT_FIRST_YR(KCYKEY, out Cache_KCYKEY_SG_FUT_FIRST_YR))
                {
                    Cache_KCYKEY_SG_FUT_FIRST_YR = new List<SG>().AsReadOnly();
                }

                return Cache_KCYKEY_SG_FUT_FIRST_YR;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [KCY.KCYKEY]-&gt;[SG.FUT_LAST_YR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SG> KCYKEY_SG_FUT_LAST_YR
        {
            get
            {
                if (Cache_KCYKEY_SG_FUT_LAST_YR == null &&
                    !Context.SG.TryFindByFUT_LAST_YR(KCYKEY, out Cache_KCYKEY_SG_FUT_LAST_YR))
                {
                    Cache_KCYKEY_SG_FUT_LAST_YR = new List<SG>().AsReadOnly();
                }

                return Cache_KCYKEY_SG_FUT_LAST_YR;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KCY.KCYKEY]-&gt;[ST.SCHOOL_YEAR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<ST> KCYKEY_ST_SCHOOL_YEAR
        {
            get
            {
                if (Cache_KCYKEY_ST_SCHOOL_YEAR == null &&
                    !Context.ST.TryFindBySCHOOL_YEAR(KCYKEY, out Cache_KCYKEY_ST_SCHOOL_YEAR))
                {
                    Cache_KCYKEY_ST_SCHOOL_YEAR = new List<ST>().AsReadOnly();
                }

                return Cache_KCYKEY_ST_SCHOOL_YEAR;
            }
        }

        /// <summary>
        /// ST_TFR (ST Transfer) related entities by [KCY.KCYKEY]-&gt;[ST_TFR.SCHOOL_YEAR_NEW]
        /// Year level code
        /// </summary>
        public IReadOnlyList<ST_TFR> KCYKEY_ST_TFR_SCHOOL_YEAR_NEW
        {
            get
            {
                if (Cache_KCYKEY_ST_TFR_SCHOOL_YEAR_NEW == null &&
                    !Context.ST_TFR.TryFindBySCHOOL_YEAR_NEW(KCYKEY, out Cache_KCYKEY_ST_TFR_SCHOOL_YEAR_NEW))
                {
                    Cache_KCYKEY_ST_TFR_SCHOOL_YEAR_NEW = new List<ST_TFR>().AsReadOnly();
                }

                return Cache_KCYKEY_ST_TFR_SCHOOL_YEAR_NEW;
            }
        }

        /// <summary>
        /// STMA (Subject Selections &amp; Marks) related entities by [KCY.KCYKEY]-&gt;[STMA.SCHOOL_YEAR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<STMA> KCYKEY_STMA_SCHOOL_YEAR
        {
            get
            {
                if (Cache_KCYKEY_STMA_SCHOOL_YEAR == null &&
                    !Context.STMA.TryFindBySCHOOL_YEAR(KCYKEY, out Cache_KCYKEY_STMA_SCHOOL_YEAR))
                {
                    Cache_KCYKEY_STMA_SCHOOL_YEAR = new List<STMA>().AsReadOnly();
                }

                return Cache_KCYKEY_STMA_SCHOOL_YEAR;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [KCY.KCYKEY]-&gt;[STRE.ST_SCHOOL_YEAR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<STRE> KCYKEY_STRE_ST_SCHOOL_YEAR
        {
            get
            {
                if (Cache_KCYKEY_STRE_ST_SCHOOL_YEAR == null &&
                    !Context.STRE.TryFindByST_SCHOOL_YEAR(KCYKEY, out Cache_KCYKEY_STRE_ST_SCHOOL_YEAR))
                {
                    Cache_KCYKEY_STRE_ST_SCHOOL_YEAR = new List<STRE>().AsReadOnly();
                }

                return Cache_KCYKEY_STRE_ST_SCHOOL_YEAR;
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [KCY.KCYKEY]-&gt;[SU.SUBJECT_ACADEMIC_YEAR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SU> KCYKEY_SU_SUBJECT_ACADEMIC_YEAR
        {
            get
            {
                if (Cache_KCYKEY_SU_SUBJECT_ACADEMIC_YEAR == null &&
                    !Context.SU.TryFindBySUBJECT_ACADEMIC_YEAR(KCYKEY, out Cache_KCYKEY_SU_SUBJECT_ACADEMIC_YEAR))
                {
                    Cache_KCYKEY_SU_SUBJECT_ACADEMIC_YEAR = new List<SU>().AsReadOnly();
                }

                return Cache_KCYKEY_SU_SUBJECT_ACADEMIC_YEAR;
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [KCY.KCYKEY]-&gt;[SXAB.ST_YEAR_LEVEL]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SXAB> KCYKEY_SXAB_ST_YEAR_LEVEL
        {
            get
            {
                if (Cache_KCYKEY_SXAB_ST_YEAR_LEVEL == null &&
                    !Context.SXAB.TryFindByST_YEAR_LEVEL(KCYKEY, out Cache_KCYKEY_SXAB_ST_YEAR_LEVEL))
                {
                    Cache_KCYKEY_SXAB_ST_YEAR_LEVEL = new List<SXAB>().AsReadOnly();
                }

                return Cache_KCYKEY_SXAB_ST_YEAR_LEVEL;
            }
        }

        /// <summary>
        /// SXABCONV (Converted Student Half-Day Absences) related entities by [KCY.KCYKEY]-&gt;[SXABCONV.ST_YEAR_LEVEL]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SXABCONV> KCYKEY_SXABCONV_ST_YEAR_LEVEL
        {
            get
            {
                if (Cache_KCYKEY_SXABCONV_ST_YEAR_LEVEL == null &&
                    !Context.SXABCONV.TryFindByST_YEAR_LEVEL(KCYKEY, out Cache_KCYKEY_SXABCONV_ST_YEAR_LEVEL))
                {
                    Cache_KCYKEY_SXABCONV_ST_YEAR_LEVEL = new List<SXABCONV>().AsReadOnly();
                }

                return Cache_KCYKEY_SXABCONV_ST_YEAR_LEVEL;
            }
        }

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [KCY.KCYKEY]-&gt;[SXAS.ST_YEAR_LEVEL]
        /// Year level code
        /// </summary>
        public IReadOnlyList<SXAS> KCYKEY_SXAS_ST_YEAR_LEVEL
        {
            get
            {
                if (Cache_KCYKEY_SXAS_ST_YEAR_LEVEL == null &&
                    !Context.SXAS.TryFindByST_YEAR_LEVEL(KCYKEY, out Cache_KCYKEY_SXAS_ST_YEAR_LEVEL))
                {
                    Cache_KCYKEY_SXAS_ST_YEAR_LEVEL = new List<SXAS>().AsReadOnly();
                }

                return Cache_KCYKEY_SXAS_ST_YEAR_LEVEL;
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [KCY.KCYKEY]-&gt;[TE.START_YEAR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TE> KCYKEY_TE_START_YEAR
        {
            get
            {
                if (Cache_KCYKEY_TE_START_YEAR == null &&
                    !Context.TE.TryFindBySTART_YEAR(KCYKEY, out Cache_KCYKEY_TE_START_YEAR))
                {
                    Cache_KCYKEY_TE_START_YEAR = new List<TE>().AsReadOnly();
                }

                return Cache_KCYKEY_TE_START_YEAR;
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [KCY.KCYKEY]-&gt;[TE.END_YEAR]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TE> KCYKEY_TE_END_YEAR
        {
            get
            {
                if (Cache_KCYKEY_TE_END_YEAR == null &&
                    !Context.TE.TryFindByEND_YEAR(KCYKEY, out Cache_KCYKEY_TE_END_YEAR))
                {
                    Cache_KCYKEY_TE_END_YEAR = new List<TE>().AsReadOnly();
                }

                return Cache_KCYKEY_TE_END_YEAR;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR01]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR01
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR01 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR01(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR01))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR01 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR01;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR02]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR02
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR02 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR02(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR02))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR02 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR02;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR03]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR03
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR03 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR03(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR03))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR03 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR03;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR04]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR04
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR04 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR04(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR04))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR04 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR04;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR05]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR05
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR05 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR05(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR05))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR05 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR05;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR06]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR06
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR06 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR06(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR06))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR06 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR06;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR07]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR07
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR07 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR07(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR07))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR07 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR07;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR08]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR08
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR08 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR08(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR08))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR08 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR08;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entities by [KCY.KCYKEY]-&gt;[TT.SUBJECT_ACADEMIC_YEAR09]
        /// Year level code
        /// </summary>
        public IReadOnlyList<TT> KCYKEY_TT_SUBJECT_ACADEMIC_YEAR09
        {
            get
            {
                if (Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR09 == null &&
                    !Context.TT.TryFindBySUBJECT_ACADEMIC_YEAR09(KCYKEY, out Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR09))
                {
                    Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR09 = new List<TT>().AsReadOnly();
                }

                return Cache_KCYKEY_TT_SUBJECT_ACADEMIC_YEAR09;
            }
        }

        #endregion

    }
}
