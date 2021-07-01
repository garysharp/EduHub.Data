using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Courses
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SC : EduHubEntity
    {

        #region Navigation Property Cache

        private SU Cache_SUBJ01_SU;
        private SU Cache_SUBJ02_SU;
        private SU Cache_SUBJ03_SU;
        private SU Cache_SUBJ04_SU;
        private SU Cache_SUBJ05_SU;
        private SU Cache_SUBJ06_SU;
        private SU Cache_SUBJ07_SU;
        private SU Cache_SUBJ08_SU;
        private SU Cache_SUBJ09_SU;
        private SU Cache_SUBJ10_SU;
        private SU Cache_SUBJ11_SU;
        private SU Cache_SUBJ12_SU;
        private SU Cache_SUBJ13_SU;
        private SU Cache_SUBJ14_SU;
        private SU Cache_SUBJ15_SU;
        private SU Cache_SUBJ16_SU;
        private SU Cache_SUBJ17_SU;
        private SU Cache_SUBJ18_SU;
        private SU Cache_SUBJ19_SU;
        private SU Cache_SUBJ20_SU;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR_KCY;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<STMA> Cache_COURSE_STMA_CKEY;

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
        /// Course code (same type as SU)
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string COURSE { get; internal set; }

        /// <summary>
        /// Course name
        /// [Alphanumeric (30)]
        /// </summary>
        public string NAME { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ01 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ02 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ03 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ04 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ05 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ06 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ07 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ08 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ09 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ10 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ11 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ12 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ13 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ14 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ15 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ16 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ17 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ18 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ19 { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ20 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS01 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS02 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS03 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS04 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS05 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS06 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS07 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS08 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS09 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS10 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS11 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS12 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS13 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS14 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS15 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS16 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS17 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS18 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS19 { get; internal set; }

        /// <summary>
        /// Class set
        /// </summary>
        public short? CLASS20 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK01 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK02 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK03 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK04 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK05 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK06 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK07 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK08 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK09 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK10 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK11 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK12 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK13 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK14 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK15 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK16 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK17 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK18 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK19 { get; internal set; }

        /// <summary>
        /// Whether a student is locked into the class
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOCK20 { get; internal set; }

        /// <summary>
        /// Default academic year of subjects
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR { get; internal set; }

        /// <summary>
        /// Default semester of subjsects
        /// </summary>
        public short? SEMESTER { get; internal set; }

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
        /// SU (Subjects) related entity by [SC.SUBJ01]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ01_SU
        {
            get
            {
                if (SUBJ01 == null)
                {
                    return null;
                }
                if (Cache_SUBJ01_SU == null)
                {
                    Cache_SUBJ01_SU = Context.SU.FindBySUKEY(SUBJ01);
                }

                return Cache_SUBJ01_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ02]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ02_SU
        {
            get
            {
                if (SUBJ02 == null)
                {
                    return null;
                }
                if (Cache_SUBJ02_SU == null)
                {
                    Cache_SUBJ02_SU = Context.SU.FindBySUKEY(SUBJ02);
                }

                return Cache_SUBJ02_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ03]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ03_SU
        {
            get
            {
                if (SUBJ03 == null)
                {
                    return null;
                }
                if (Cache_SUBJ03_SU == null)
                {
                    Cache_SUBJ03_SU = Context.SU.FindBySUKEY(SUBJ03);
                }

                return Cache_SUBJ03_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ04]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ04_SU
        {
            get
            {
                if (SUBJ04 == null)
                {
                    return null;
                }
                if (Cache_SUBJ04_SU == null)
                {
                    Cache_SUBJ04_SU = Context.SU.FindBySUKEY(SUBJ04);
                }

                return Cache_SUBJ04_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ05]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ05_SU
        {
            get
            {
                if (SUBJ05 == null)
                {
                    return null;
                }
                if (Cache_SUBJ05_SU == null)
                {
                    Cache_SUBJ05_SU = Context.SU.FindBySUKEY(SUBJ05);
                }

                return Cache_SUBJ05_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ06]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ06_SU
        {
            get
            {
                if (SUBJ06 == null)
                {
                    return null;
                }
                if (Cache_SUBJ06_SU == null)
                {
                    Cache_SUBJ06_SU = Context.SU.FindBySUKEY(SUBJ06);
                }

                return Cache_SUBJ06_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ07]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ07_SU
        {
            get
            {
                if (SUBJ07 == null)
                {
                    return null;
                }
                if (Cache_SUBJ07_SU == null)
                {
                    Cache_SUBJ07_SU = Context.SU.FindBySUKEY(SUBJ07);
                }

                return Cache_SUBJ07_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ08]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ08_SU
        {
            get
            {
                if (SUBJ08 == null)
                {
                    return null;
                }
                if (Cache_SUBJ08_SU == null)
                {
                    Cache_SUBJ08_SU = Context.SU.FindBySUKEY(SUBJ08);
                }

                return Cache_SUBJ08_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ09]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ09_SU
        {
            get
            {
                if (SUBJ09 == null)
                {
                    return null;
                }
                if (Cache_SUBJ09_SU == null)
                {
                    Cache_SUBJ09_SU = Context.SU.FindBySUKEY(SUBJ09);
                }

                return Cache_SUBJ09_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ10]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ10_SU
        {
            get
            {
                if (SUBJ10 == null)
                {
                    return null;
                }
                if (Cache_SUBJ10_SU == null)
                {
                    Cache_SUBJ10_SU = Context.SU.FindBySUKEY(SUBJ10);
                }

                return Cache_SUBJ10_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ11]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ11_SU
        {
            get
            {
                if (SUBJ11 == null)
                {
                    return null;
                }
                if (Cache_SUBJ11_SU == null)
                {
                    Cache_SUBJ11_SU = Context.SU.FindBySUKEY(SUBJ11);
                }

                return Cache_SUBJ11_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ12]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ12_SU
        {
            get
            {
                if (SUBJ12 == null)
                {
                    return null;
                }
                if (Cache_SUBJ12_SU == null)
                {
                    Cache_SUBJ12_SU = Context.SU.FindBySUKEY(SUBJ12);
                }

                return Cache_SUBJ12_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ13]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ13_SU
        {
            get
            {
                if (SUBJ13 == null)
                {
                    return null;
                }
                if (Cache_SUBJ13_SU == null)
                {
                    Cache_SUBJ13_SU = Context.SU.FindBySUKEY(SUBJ13);
                }

                return Cache_SUBJ13_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ14]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ14_SU
        {
            get
            {
                if (SUBJ14 == null)
                {
                    return null;
                }
                if (Cache_SUBJ14_SU == null)
                {
                    Cache_SUBJ14_SU = Context.SU.FindBySUKEY(SUBJ14);
                }

                return Cache_SUBJ14_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ15]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ15_SU
        {
            get
            {
                if (SUBJ15 == null)
                {
                    return null;
                }
                if (Cache_SUBJ15_SU == null)
                {
                    Cache_SUBJ15_SU = Context.SU.FindBySUKEY(SUBJ15);
                }

                return Cache_SUBJ15_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ16]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ16_SU
        {
            get
            {
                if (SUBJ16 == null)
                {
                    return null;
                }
                if (Cache_SUBJ16_SU == null)
                {
                    Cache_SUBJ16_SU = Context.SU.FindBySUKEY(SUBJ16);
                }

                return Cache_SUBJ16_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ17]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ17_SU
        {
            get
            {
                if (SUBJ17 == null)
                {
                    return null;
                }
                if (Cache_SUBJ17_SU == null)
                {
                    Cache_SUBJ17_SU = Context.SU.FindBySUKEY(SUBJ17);
                }

                return Cache_SUBJ17_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ18]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ18_SU
        {
            get
            {
                if (SUBJ18 == null)
                {
                    return null;
                }
                if (Cache_SUBJ18_SU == null)
                {
                    Cache_SUBJ18_SU = Context.SU.FindBySUKEY(SUBJ18);
                }

                return Cache_SUBJ18_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ19]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ19_SU
        {
            get
            {
                if (SUBJ19 == null)
                {
                    return null;
                }
                if (Cache_SUBJ19_SU == null)
                {
                    Cache_SUBJ19_SU = Context.SU.FindBySUKEY(SUBJ19);
                }

                return Cache_SUBJ19_SU;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SC.SUBJ20]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJ20_SU
        {
            get
            {
                if (SUBJ20 == null)
                {
                    return null;
                }
                if (Cache_SUBJ20_SU == null)
                {
                    Cache_SUBJ20_SU = Context.SU.FindBySUKEY(SUBJ20);
                }

                return Cache_SUBJ20_SU;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [SC.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// Default academic year of subjects
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR_KCY;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// STMA (Subject Selections &amp; Marks) related entities by [SC.COURSE]-&gt;[STMA.CKEY]
        /// Course code (same type as SU)
        /// </summary>
        public IReadOnlyList<STMA> COURSE_STMA_CKEY
        {
            get
            {
                if (Cache_COURSE_STMA_CKEY == null &&
                    !Context.STMA.TryFindByCKEY(COURSE, out Cache_COURSE_STMA_CKEY))
                {
                    Cache_COURSE_STMA_CKEY = new List<STMA>().AsReadOnly();
                }

                return Cache_COURSE_STMA_CKEY;
            }
        }

        #endregion

    }
}
