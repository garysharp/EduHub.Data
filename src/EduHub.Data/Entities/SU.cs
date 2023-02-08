using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SU : EduHubEntity
    {

        #region Navigation Property Cache

        private KSF Cache_FACULTY_KSF;
        private SU Cache_PROMOTE_SU;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR_KCY;
        private SA Cache_FEE_CODE_SA;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<DFF> Cache_SUKEY_DFF_SUBJECT;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ01;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ02;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ03;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ04;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ05;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ06;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ07;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ08;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ09;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ10;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ11;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ12;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ13;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ14;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ15;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ16;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ17;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ18;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ19;
        private IReadOnlyList<SC> Cache_SUKEY_SC_SUBJ20;
        private IReadOnlyList<SCL> Cache_SUKEY_SCL_SUBJECT;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT01;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT02;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT03;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT04;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT05;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT06;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT07;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT08;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT09;
        private IReadOnlyList<SF> Cache_SUKEY_SF_SUBJECT10;
#if !EduHubScoped
        private IReadOnlyList<SGSC> Cache_SUKEY_SGSC_SULINK;
#endif
        private IReadOnlyList<STMA> Cache_SUKEY_STMA_MKEY;
        private IReadOnlyList<SU> Cache_SUKEY_SU_PROMOTE;
#if !EduHubScoped
        private IReadOnlyList<SUBL> Cache_SUKEY_SUBL_BLKEY;
        private IReadOnlyList<SUPR> Cache_SUKEY_SUPR_SUPRKEY;
        private IReadOnlyList<SUPR> Cache_SUKEY_SUPR_PREREQUISITE;
#endif
        private IReadOnlyList<TCTB> Cache_SUKEY_TCTB_SUBJ;
        private IReadOnlyList<TCTQ> Cache_SUKEY_TCTQ_SUBJ;
        private IReadOnlyList<TE> Cache_SUKEY_TE_SUBJ;
        private IReadOnlyList<THTQ> Cache_SUKEY_THTQ_SUBJ;
#if !EduHubScoped
        private IReadOnlyList<TTES> Cache_SUKEY_TTES_SUBJ;
#endif
        private IReadOnlyList<TTTG> Cache_SUKEY_TTTG_SUBJ;
        private IReadOnlyList<TXAS> Cache_SUKEY_TXAS_SUBJECT;

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
        /// KSF (Faculties) related entity by [SU.FACULTY]-&gt;[KSF.KSFKEY]
        /// Faculty
        /// </summary>
        public KSF FACULTY_KSF
        {
            get
            {
                if (FACULTY == null)
                {
                    return null;
                }
                if (Cache_FACULTY_KSF == null)
                {
                    Cache_FACULTY_KSF = Context.KSF.FindByKSFKEY(FACULTY);
                }

                return Cache_FACULTY_KSF;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SU.PROMOTE]-&gt;[SU.SUKEY]
        /// Subject that normally follows this subject in a course (eg Physics 11 is followed by Physics 12)
        /// </summary>
        public SU PROMOTE_SU
        {
            get
            {
                if (PROMOTE == null)
                {
                    return null;
                }
                if (Cache_PROMOTE_SU == null)
                {
                    Cache_PROMOTE_SU = Context.SU.FindBySUKEY(PROMOTE);
                }

                return Cache_PROMOTE_SU;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [SU.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// (Was ACADEMIC_YEAR) Offered to students at this year level: if blank or matches one of the values in a TT record, the subject is eligible for that template
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

        /// <summary>
        /// SA (Fees) related entity by [SU.FEE_CODE]-&gt;[SA.SAKEY]
        /// Fee code
        /// </summary>
        public SA FEE_CODE_SA
        {
            get
            {
                if (FEE_CODE == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_SA == null)
                {
                    Cache_FEE_CODE_SA = Context.SA.FindBySAKEY(FEE_CODE);
                }

                return Cache_FEE_CODE_SA;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [SU.SUKEY]-&gt;[DFF.SUBJECT]
        /// Subject code
        /// </summary>
        public IReadOnlyList<DFF> SUKEY_DFF_SUBJECT
        {
            get
            {
                if (Cache_SUKEY_DFF_SUBJECT == null &&
                    !Context.DFF.TryFindBySUBJECT(SUKEY, out Cache_SUKEY_DFF_SUBJECT))
                {
                    Cache_SUKEY_DFF_SUBJECT = new List<DFF>().AsReadOnly();
                }

                return Cache_SUKEY_DFF_SUBJECT;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ01]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ01
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ01 == null &&
                    !Context.SC.TryFindBySUBJ01(SUKEY, out Cache_SUKEY_SC_SUBJ01))
                {
                    Cache_SUKEY_SC_SUBJ01 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ01;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ02]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ02
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ02 == null &&
                    !Context.SC.TryFindBySUBJ02(SUKEY, out Cache_SUKEY_SC_SUBJ02))
                {
                    Cache_SUKEY_SC_SUBJ02 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ02;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ03]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ03
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ03 == null &&
                    !Context.SC.TryFindBySUBJ03(SUKEY, out Cache_SUKEY_SC_SUBJ03))
                {
                    Cache_SUKEY_SC_SUBJ03 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ03;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ04]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ04
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ04 == null &&
                    !Context.SC.TryFindBySUBJ04(SUKEY, out Cache_SUKEY_SC_SUBJ04))
                {
                    Cache_SUKEY_SC_SUBJ04 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ04;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ05]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ05
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ05 == null &&
                    !Context.SC.TryFindBySUBJ05(SUKEY, out Cache_SUKEY_SC_SUBJ05))
                {
                    Cache_SUKEY_SC_SUBJ05 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ05;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ06]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ06
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ06 == null &&
                    !Context.SC.TryFindBySUBJ06(SUKEY, out Cache_SUKEY_SC_SUBJ06))
                {
                    Cache_SUKEY_SC_SUBJ06 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ06;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ07]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ07
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ07 == null &&
                    !Context.SC.TryFindBySUBJ07(SUKEY, out Cache_SUKEY_SC_SUBJ07))
                {
                    Cache_SUKEY_SC_SUBJ07 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ07;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ08]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ08
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ08 == null &&
                    !Context.SC.TryFindBySUBJ08(SUKEY, out Cache_SUKEY_SC_SUBJ08))
                {
                    Cache_SUKEY_SC_SUBJ08 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ08;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ09]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ09
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ09 == null &&
                    !Context.SC.TryFindBySUBJ09(SUKEY, out Cache_SUKEY_SC_SUBJ09))
                {
                    Cache_SUKEY_SC_SUBJ09 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ09;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ10]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ10
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ10 == null &&
                    !Context.SC.TryFindBySUBJ10(SUKEY, out Cache_SUKEY_SC_SUBJ10))
                {
                    Cache_SUKEY_SC_SUBJ10 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ10;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ11]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ11
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ11 == null &&
                    !Context.SC.TryFindBySUBJ11(SUKEY, out Cache_SUKEY_SC_SUBJ11))
                {
                    Cache_SUKEY_SC_SUBJ11 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ11;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ12]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ12
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ12 == null &&
                    !Context.SC.TryFindBySUBJ12(SUKEY, out Cache_SUKEY_SC_SUBJ12))
                {
                    Cache_SUKEY_SC_SUBJ12 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ12;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ13]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ13
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ13 == null &&
                    !Context.SC.TryFindBySUBJ13(SUKEY, out Cache_SUKEY_SC_SUBJ13))
                {
                    Cache_SUKEY_SC_SUBJ13 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ13;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ14]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ14
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ14 == null &&
                    !Context.SC.TryFindBySUBJ14(SUKEY, out Cache_SUKEY_SC_SUBJ14))
                {
                    Cache_SUKEY_SC_SUBJ14 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ14;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ15]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ15
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ15 == null &&
                    !Context.SC.TryFindBySUBJ15(SUKEY, out Cache_SUKEY_SC_SUBJ15))
                {
                    Cache_SUKEY_SC_SUBJ15 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ15;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ16]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ16
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ16 == null &&
                    !Context.SC.TryFindBySUBJ16(SUKEY, out Cache_SUKEY_SC_SUBJ16))
                {
                    Cache_SUKEY_SC_SUBJ16 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ16;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ17]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ17
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ17 == null &&
                    !Context.SC.TryFindBySUBJ17(SUKEY, out Cache_SUKEY_SC_SUBJ17))
                {
                    Cache_SUKEY_SC_SUBJ17 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ17;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ18]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ18
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ18 == null &&
                    !Context.SC.TryFindBySUBJ18(SUKEY, out Cache_SUKEY_SC_SUBJ18))
                {
                    Cache_SUKEY_SC_SUBJ18 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ18;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ19]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ19
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ19 == null &&
                    !Context.SC.TryFindBySUBJ19(SUKEY, out Cache_SUKEY_SC_SUBJ19))
                {
                    Cache_SUKEY_SC_SUBJ19 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ19;
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SU.SUKEY]-&gt;[SC.SUBJ20]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SC> SUKEY_SC_SUBJ20
        {
            get
            {
                if (Cache_SUKEY_SC_SUBJ20 == null &&
                    !Context.SC.TryFindBySUBJ20(SUKEY, out Cache_SUKEY_SC_SUBJ20))
                {
                    Cache_SUKEY_SC_SUBJ20 = new List<SC>().AsReadOnly();
                }

                return Cache_SUKEY_SC_SUBJ20;
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SU.SUKEY]-&gt;[SCL.SUBJECT]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SCL> SUKEY_SCL_SUBJECT
        {
            get
            {
                if (Cache_SUKEY_SCL_SUBJECT == null &&
                    !Context.SCL.TryFindBySUBJECT(SUKEY, out Cache_SUKEY_SCL_SUBJECT))
                {
                    Cache_SUKEY_SCL_SUBJECT = new List<SCL>().AsReadOnly();
                }

                return Cache_SUKEY_SCL_SUBJECT;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT01]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT01
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT01 == null &&
                    !Context.SF.TryFindBySUBJECT01(SUKEY, out Cache_SUKEY_SF_SUBJECT01))
                {
                    Cache_SUKEY_SF_SUBJECT01 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT01;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT02]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT02
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT02 == null &&
                    !Context.SF.TryFindBySUBJECT02(SUKEY, out Cache_SUKEY_SF_SUBJECT02))
                {
                    Cache_SUKEY_SF_SUBJECT02 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT02;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT03]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT03
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT03 == null &&
                    !Context.SF.TryFindBySUBJECT03(SUKEY, out Cache_SUKEY_SF_SUBJECT03))
                {
                    Cache_SUKEY_SF_SUBJECT03 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT03;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT04]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT04
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT04 == null &&
                    !Context.SF.TryFindBySUBJECT04(SUKEY, out Cache_SUKEY_SF_SUBJECT04))
                {
                    Cache_SUKEY_SF_SUBJECT04 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT04;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT05]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT05
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT05 == null &&
                    !Context.SF.TryFindBySUBJECT05(SUKEY, out Cache_SUKEY_SF_SUBJECT05))
                {
                    Cache_SUKEY_SF_SUBJECT05 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT05;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT06]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT06
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT06 == null &&
                    !Context.SF.TryFindBySUBJECT06(SUKEY, out Cache_SUKEY_SF_SUBJECT06))
                {
                    Cache_SUKEY_SF_SUBJECT06 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT06;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT07]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT07
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT07 == null &&
                    !Context.SF.TryFindBySUBJECT07(SUKEY, out Cache_SUKEY_SF_SUBJECT07))
                {
                    Cache_SUKEY_SF_SUBJECT07 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT07;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT08]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT08
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT08 == null &&
                    !Context.SF.TryFindBySUBJECT08(SUKEY, out Cache_SUKEY_SF_SUBJECT08))
                {
                    Cache_SUKEY_SF_SUBJECT08 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT08;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT09]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT09
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT09 == null &&
                    !Context.SF.TryFindBySUBJECT09(SUKEY, out Cache_SUKEY_SF_SUBJECT09))
                {
                    Cache_SUKEY_SF_SUBJECT09 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT09;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SU.SUKEY]-&gt;[SF.SUBJECT10]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SF> SUKEY_SF_SUBJECT10
        {
            get
            {
                if (Cache_SUKEY_SF_SUBJECT10 == null &&
                    !Context.SF.TryFindBySUBJECT10(SUKEY, out Cache_SUKEY_SF_SUBJECT10))
                {
                    Cache_SUKEY_SF_SUBJECT10 = new List<SF>().AsReadOnly();
                }

                return Cache_SUKEY_SF_SUBJECT10;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// SGSC (Subject/Class Eligibility Criteria) related entities by [SU.SUKEY]-&gt;[SGSC.SULINK]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SGSC> SUKEY_SGSC_SULINK
        {
            get
            {
                if (Cache_SUKEY_SGSC_SULINK == null &&
                    !Context.SGSC.TryFindBySULINK(SUKEY, out Cache_SUKEY_SGSC_SULINK))
                {
                    Cache_SUKEY_SGSC_SULINK = new List<SGSC>().AsReadOnly();
                }

                return Cache_SUKEY_SGSC_SULINK;
            }
        }

#endif
        /// <summary>
        /// STMA (Subject Selections &amp; Marks) related entities by [SU.SUKEY]-&gt;[STMA.MKEY]
        /// Subject code
        /// </summary>
        public IReadOnlyList<STMA> SUKEY_STMA_MKEY
        {
            get
            {
                if (Cache_SUKEY_STMA_MKEY == null &&
                    !Context.STMA.TryFindByMKEY(SUKEY, out Cache_SUKEY_STMA_MKEY))
                {
                    Cache_SUKEY_STMA_MKEY = new List<STMA>().AsReadOnly();
                }

                return Cache_SUKEY_STMA_MKEY;
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [SU.SUKEY]-&gt;[SU.PROMOTE]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SU> SUKEY_SU_PROMOTE
        {
            get
            {
                if (Cache_SUKEY_SU_PROMOTE == null &&
                    !Context.SU.TryFindByPROMOTE(SUKEY, out Cache_SUKEY_SU_PROMOTE))
                {
                    Cache_SUKEY_SU_PROMOTE = new List<SU>().AsReadOnly();
                }

                return Cache_SUKEY_SU_PROMOTE;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// SUBL (Subject Book List) related entities by [SU.SUKEY]-&gt;[SUBL.BLKEY]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SUBL> SUKEY_SUBL_BLKEY
        {
            get
            {
                if (Cache_SUKEY_SUBL_BLKEY == null &&
                    !Context.SUBL.TryFindByBLKEY(SUKEY, out Cache_SUKEY_SUBL_BLKEY))
                {
                    Cache_SUKEY_SUBL_BLKEY = new List<SUBL>().AsReadOnly();
                }

                return Cache_SUKEY_SUBL_BLKEY;
            }
        }

        /// <summary>
        /// SUPR (Subject Prerequisites) related entities by [SU.SUKEY]-&gt;[SUPR.SUPRKEY]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SUPR> SUKEY_SUPR_SUPRKEY
        {
            get
            {
                if (Cache_SUKEY_SUPR_SUPRKEY == null &&
                    !Context.SUPR.TryFindBySUPRKEY(SUKEY, out Cache_SUKEY_SUPR_SUPRKEY))
                {
                    Cache_SUKEY_SUPR_SUPRKEY = new List<SUPR>().AsReadOnly();
                }

                return Cache_SUKEY_SUPR_SUPRKEY;
            }
        }

        /// <summary>
        /// SUPR (Subject Prerequisites) related entities by [SU.SUKEY]-&gt;[SUPR.PREREQUISITE]
        /// Subject code
        /// </summary>
        public IReadOnlyList<SUPR> SUKEY_SUPR_PREREQUISITE
        {
            get
            {
                if (Cache_SUKEY_SUPR_PREREQUISITE == null &&
                    !Context.SUPR.TryFindByPREREQUISITE(SUKEY, out Cache_SUKEY_SUPR_PREREQUISITE))
                {
                    Cache_SUKEY_SUPR_PREREQUISITE = new List<SUPR>().AsReadOnly();
                }

                return Cache_SUKEY_SUPR_PREREQUISITE;
            }
        }

#endif
        /// <summary>
        /// TCTB (Teacher Absences) related entities by [SU.SUKEY]-&gt;[TCTB.SUBJ]
        /// Subject code
        /// </summary>
        public IReadOnlyList<TCTB> SUKEY_TCTB_SUBJ
        {
            get
            {
                if (Cache_SUKEY_TCTB_SUBJ == null &&
                    !Context.TCTB.TryFindBySUBJ(SUKEY, out Cache_SUKEY_TCTB_SUBJ))
                {
                    Cache_SUKEY_TCTB_SUBJ = new List<TCTB>().AsReadOnly();
                }

                return Cache_SUKEY_TCTB_SUBJ;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [SU.SUKEY]-&gt;[TCTQ.SUBJ]
        /// Subject code
        /// </summary>
        public IReadOnlyList<TCTQ> SUKEY_TCTQ_SUBJ
        {
            get
            {
                if (Cache_SUKEY_TCTQ_SUBJ == null &&
                    !Context.TCTQ.TryFindBySUBJ(SUKEY, out Cache_SUKEY_TCTQ_SUBJ))
                {
                    Cache_SUKEY_TCTQ_SUBJ = new List<TCTQ>().AsReadOnly();
                }

                return Cache_SUKEY_TCTQ_SUBJ;
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [SU.SUKEY]-&gt;[TE.SUBJ]
        /// Subject code
        /// </summary>
        public IReadOnlyList<TE> SUKEY_TE_SUBJ
        {
            get
            {
                if (Cache_SUKEY_TE_SUBJ == null &&
                    !Context.TE.TryFindBySUBJ(SUKEY, out Cache_SUKEY_TE_SUBJ))
                {
                    Cache_SUKEY_TE_SUBJ = new List<TE>().AsReadOnly();
                }

                return Cache_SUKEY_TE_SUBJ;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [SU.SUKEY]-&gt;[THTQ.SUBJ]
        /// Subject code
        /// </summary>
        public IReadOnlyList<THTQ> SUKEY_THTQ_SUBJ
        {
            get
            {
                if (Cache_SUKEY_THTQ_SUBJ == null &&
                    !Context.THTQ.TryFindBySUBJ(SUKEY, out Cache_SUKEY_THTQ_SUBJ))
                {
                    Cache_SUKEY_THTQ_SUBJ = new List<THTQ>().AsReadOnly();
                }

                return Cache_SUKEY_THTQ_SUBJ;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// TTES (Exam Subjects) related entities by [SU.SUKEY]-&gt;[TTES.SUBJ]
        /// Subject code
        /// </summary>
        public IReadOnlyList<TTES> SUKEY_TTES_SUBJ
        {
            get
            {
                if (Cache_SUKEY_TTES_SUBJ == null &&
                    !Context.TTES.TryFindBySUBJ(SUKEY, out Cache_SUKEY_TTES_SUBJ))
                {
                    Cache_SUKEY_TTES_SUBJ = new List<TTES>().AsReadOnly();
                }

                return Cache_SUKEY_TTES_SUBJ;
            }
        }

#endif
        /// <summary>
        /// TTTG (Grid Subjects) related entities by [SU.SUKEY]-&gt;[TTTG.SUBJ]
        /// Subject code
        /// </summary>
        public IReadOnlyList<TTTG> SUKEY_TTTG_SUBJ
        {
            get
            {
                if (Cache_SUKEY_TTTG_SUBJ == null &&
                    !Context.TTTG.TryFindBySUBJ(SUKEY, out Cache_SUKEY_TTTG_SUBJ))
                {
                    Cache_SUKEY_TTTG_SUBJ = new List<TTTG>().AsReadOnly();
                }

                return Cache_SUKEY_TTTG_SUBJ;
            }
        }

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [SU.SUKEY]-&gt;[TXAS.SUBJECT]
        /// Subject code
        /// </summary>
        public IReadOnlyList<TXAS> SUKEY_TXAS_SUBJECT
        {
            get
            {
                if (Cache_SUKEY_TXAS_SUBJECT == null &&
                    !Context.TXAS.TryFindBySUBJECT(SUKEY, out Cache_SUKEY_TXAS_SUBJECT))
                {
                    Cache_SUKEY_TXAS_SUBJECT = new List<TXAS>().AsReadOnly();
                }

                return Cache_SUKEY_TXAS_SUBJECT;
            }
        }

        #endregion

    }
}
