using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects
    /// </summary>
    public partial class SU : EntityBase
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
        /// KSF (Faculties) related entity by [SU.FACULTY]-&gt;[KSF.KSFKEY]
        /// Faculty
        /// </summary>
        public KSF FACULTY_KSF
        {
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
        /// SU (Subjects) related entity by [SU.PROMOTE]-&gt;[SU.SUKEY]
        /// Subject that normally follows this subject in a course (eg Physics 11 is followed by Physics 12)
        /// </summary>
        public SU PROMOTE_SU
        {
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
        /// KCY (Year Levels) related entity by [SU.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// (Was ACADEMIC_YEAR) Offered to students at this year level: if blank or matches one of the values in a TT record, the subject is eligible for that template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR_KCY
        {
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
        /// SA (Fees) related entity by [SU.FEE_CODE]-&gt;[SA.SAKEY]
        /// Fee code
        /// </summary>
        public SA FEE_CODE_SA
        {
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

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [DFF.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<DFF> DFF_SUBJECT
        {
            get
            {
                return Context.SU.FindDFFBySUBJECT(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ01]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ01
        {
            get
            {
                return Context.SU.FindSCBySUBJ01(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ02]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ02
        {
            get
            {
                return Context.SU.FindSCBySUBJ02(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ03]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ03
        {
            get
            {
                return Context.SU.FindSCBySUBJ03(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ04]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ04
        {
            get
            {
                return Context.SU.FindSCBySUBJ04(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ05]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ05
        {
            get
            {
                return Context.SU.FindSCBySUBJ05(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ06]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ06
        {
            get
            {
                return Context.SU.FindSCBySUBJ06(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ07]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ07
        {
            get
            {
                return Context.SU.FindSCBySUBJ07(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ08]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ08
        {
            get
            {
                return Context.SU.FindSCBySUBJ08(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ09]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ09
        {
            get
            {
                return Context.SU.FindSCBySUBJ09(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ10]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ10
        {
            get
            {
                return Context.SU.FindSCBySUBJ10(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ11]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ11
        {
            get
            {
                return Context.SU.FindSCBySUBJ11(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ12]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ12
        {
            get
            {
                return Context.SU.FindSCBySUBJ12(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ13]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ13
        {
            get
            {
                return Context.SU.FindSCBySUBJ13(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ14]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ14
        {
            get
            {
                return Context.SU.FindSCBySUBJ14(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ15]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ15
        {
            get
            {
                return Context.SU.FindSCBySUBJ15(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ16]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ16
        {
            get
            {
                return Context.SU.FindSCBySUBJ16(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ17]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ17
        {
            get
            {
                return Context.SU.FindSCBySUBJ17(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ18]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ18
        {
            get
            {
                return Context.SU.FindSCBySUBJ18(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ19]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ19
        {
            get
            {
                return Context.SU.FindSCBySUBJ19(SUKEY);
            }
        }

        /// <summary>
        /// SC (Courses) related entities by [SC.SUBJ20]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SC> SC_SUBJ20
        {
            get
            {
                return Context.SU.FindSCBySUBJ20(SUKEY);
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SCL.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SCL> SCL_SUBJECT
        {
            get
            {
                return Context.SU.FindSCLBySUBJECT(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT01]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT01
        {
            get
            {
                return Context.SU.FindSFBySUBJECT01(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT02]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT02
        {
            get
            {
                return Context.SU.FindSFBySUBJECT02(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT03]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT03
        {
            get
            {
                return Context.SU.FindSFBySUBJECT03(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT04]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT04
        {
            get
            {
                return Context.SU.FindSFBySUBJECT04(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT05]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT05
        {
            get
            {
                return Context.SU.FindSFBySUBJECT05(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT06]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT06
        {
            get
            {
                return Context.SU.FindSFBySUBJECT06(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT07]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT07
        {
            get
            {
                return Context.SU.FindSFBySUBJECT07(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT08]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT08
        {
            get
            {
                return Context.SU.FindSFBySUBJECT08(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT09]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT09
        {
            get
            {
                return Context.SU.FindSFBySUBJECT09(SUKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.SUBJECT10]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_SUBJECT10
        {
            get
            {
                return Context.SU.FindSFBySUBJECT10(SUKEY);
            }
        }

        /// <summary>
        /// SGSC (Subject/Class Eligibility Criteria) related entities by [SGSC.SULINK]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SGSC> SGSC_SULINK
        {
            get
            {
                return Context.SU.FindSGSCBySULINK(SUKEY);
            }
        }

        /// <summary>
        /// STMA (Subject Selections &amp; Marks) related entities by [STMA.MKEY]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<STMA> STMA_MKEY
        {
            get
            {
                return Context.SU.FindSTMAByMKEY(SUKEY);
            }
        }

        /// <summary>
        /// SU (Subjects) related entities by [SU.PROMOTE]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SU> SU_PROMOTE
        {
            get
            {
                return Context.SU.FindSUByPROMOTE(SUKEY);
            }
        }

        /// <summary>
        /// SUBL (Subject Book List) related entities by [SUBL.BLKEY]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SUBL> SUBL_BLKEY
        {
            get
            {
                return Context.SU.FindSUBLByBLKEY(SUKEY);
            }
        }

        /// <summary>
        /// SUPR (Subject Prerequisites) related entities by [SUPR.SUPRKEY]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SUPR> SUPR_SUPRKEY
        {
            get
            {
                return Context.SU.FindSUPRBySUPRKEY(SUKEY);
            }
        }

        /// <summary>
        /// SUPR (Subject Prerequisites) related entities by [SUPR.PREREQUISITE]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<SUPR> SUPR_PREREQUISITE
        {
            get
            {
                return Context.SU.FindSUPRByPREREQUISITE(SUKEY);
            }
        }

        /// <summary>
        /// TCTB (Teacher Absences) related entities by [TCTB.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<TCTB> TCTB_SUBJ
        {
            get
            {
                return Context.SU.FindTCTBBySUBJ(SUKEY);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_SUBJ
        {
            get
            {
                return Context.SU.FindTCTQBySUBJ(SUKEY);
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [TE.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<TE> TE_SUBJ
        {
            get
            {
                return Context.SU.FindTEBySUBJ(SUKEY);
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [THTQ.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<THTQ> THTQ_SUBJ
        {
            get
            {
                return Context.SU.FindTHTQBySUBJ(SUKEY);
            }
        }

        /// <summary>
        /// TTES (Exam Subjects) related entities by [TTES.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<TTES> TTES_SUBJ
        {
            get
            {
                return Context.SU.FindTTESBySUBJ(SUKEY);
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [TTTG.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<TTTG> TTTG_SUBJ
        {
            get
            {
                return Context.SU.FindTTTGBySUBJ(SUKEY);
            }
        }

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [TXAS.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        public IReadOnlyList<TXAS> TXAS_SUBJECT
        {
            get
            {
                return Context.SU.FindTXASBySUBJECT(SUKEY);
            }
        }
#endregion
    }
}
