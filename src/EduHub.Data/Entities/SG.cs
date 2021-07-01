using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Groupings
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SG : EduHubEntity
    {

        #region Navigation Property Cache

        private SCI Cache_FROM_CAMPUS_SCI;
        private SCI Cache_TO_CAMPUS_SCI;
        private KCY Cache_CAND_FIRST_YR_KCY;
        private KCY Cache_CAND_LAST_YR_KCY;
        private KCY Cache_FUT_FIRST_YR_KCY;
        private KCY Cache_FUT_LAST_YR_KCY;
        private KGH Cache_HOUSE_KGH;
        private KCT Cache_ABS_TYPE_KCT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SGAM> Cache_SGKEY_SGAM_SGAMKEY;
        private IReadOnlyList<SGHG> Cache_SGKEY_SGHG_SGHGKEY;
        private IReadOnlyList<SGM> Cache_SGKEY_SGM_SGMKEY;
        private IReadOnlyList<SGMA> Cache_SGKEY_SGMA_SGMAKEY;
        private IReadOnlyList<SGSC> Cache_SGKEY_SGSC_SGSCKEY;
        private IReadOnlyList<SGSG> Cache_SGKEY_SGSG_SGSGKEY;
        private IReadOnlyList<SGSG> Cache_SGKEY_SGSG_SGLINK;
        private IReadOnlyList<SGTRX> Cache_SGKEY_SGTRX_SGTRXKEY;
        private IReadOnlyList<SPU> Cache_SGKEY_SPU_MAILING_LIST;
        private IReadOnlyList<STPO> Cache_SGKEY_STPO_SGLINK;

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
        /// Student Grouping code
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGKEY { get; internal set; }

        /// <summary>
        /// (Was PURPOSE) Name of Student Grouping
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// (Was ALLOC_TYPE) Group type: S=Special Group, E=Excursion Group, P=Position
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GROUP_TYPE { get; internal set; }

        /// <summary>
        /// Group category for use by school if required (eg "Club", "Sports Team", "Orchestra")
        /// [Alphanumeric (20)]
        /// </summary>
        public string GROUP_CATEGORY { get; internal set; }

        /// <summary>
        /// Other group that this group has been copied from (if any): NOTE this should NOT be a foreign key to SG as once the group is created no link is required
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SOURCE_SG { get; internal set; }

        /// <summary>
        /// Can students that do not conform to the criteria be assigned to this group? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STRICT_CRITERIA { get; internal set; }

        /// <summary>
        /// (Was NUMBER_IND) Maximum number of students (0 acceptable)
        /// </summary>
        public short? MAX_NUMBER_STUD { get; internal set; }

        /// <summary>
        /// (Was MAKEUP) Description of year levels/forms, etc
        /// [Memo]
        /// </summary>
        public string STRUCTURE { get; internal set; }

        /// <summary>
        /// The date the group started or will start
        /// </summary>
        public DateTime? START_DATE { get; internal set; }

        /// <summary>
        /// The date the group ended or will end
        /// </summary>
        public DateTime? END_DATE { get; internal set; }

        /// <summary>
        /// The date (if any) on which all current memberships of the group or position will lapse
        /// </summary>
        public DateTime? CESSATION_DATE { get; internal set; }

        /// <summary>
        /// Is this Position for a House or Home group? H=House, G=Home group, N=Neither
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HOUSE_HOMEGROUP { get; internal set; }

        /// <summary>
        /// C=current, F = future, B = both
        /// [Alphanumeric (1)]
        /// </summary>
        public string SCOPE { get; internal set; }

        /// <summary>
        /// Minimum qualifying campus
        /// </summary>
        public int? FROM_CAMPUS { get; internal set; }

        /// <summary>
        /// Maximum qualifying campus
        /// </summary>
        public int? TO_CAMPUS { get; internal set; }

        /// <summary>
        /// Minimum qualifying year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string CAND_FIRST_YR { get; internal set; }

        /// <summary>
        /// Maximum qualifying year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string CAND_LAST_YR { get; internal set; }

        /// <summary>
        /// Minimum qualifying year fo FUT students
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string FUT_FIRST_YR { get; internal set; }

        /// <summary>
        /// Maximum qualifying year fo FUT students
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string FUT_LAST_YR { get; internal set; }

        /// <summary>
        /// Minimum qualifying age
        /// </summary>
        public short? CAND_FIRST_AGE { get; internal set; }

        /// <summary>
        /// Maximum qualifying age
        /// </summary>
        public short? CAND_LAST_AGE { get; internal set; }

        /// <summary>
        /// Date from which to calculate age
        /// </summary>
        public DateTime? AGE_DATE { get; internal set; }

        /// <summary>
        /// Earliest qualifying date of birth (calculated non-editable)
        /// </summary>
        public DateTime? FIRST_DOB { get; internal set; }

        /// <summary>
        /// Latest qualifying date of birth (calculated non-editable)
        /// </summary>
        public DateTime? LAST_DOB { get; internal set; }

        /// <summary>
        /// First or only qualifying gender
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDERA { get; internal set; }

        /// <summary>
        /// Second qualifying gender (if any)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDERB { get; internal set; }

        /// <summary>
        /// Qualifying House (if any)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HOUSE { get; internal set; }

        /// <summary>
        /// First day of excursion
        /// </summary>
        public DateTime? DAYONE { get; internal set; }

        /// <summary>
        /// First period on DAYONE taken up by the excursion
        /// </summary>
        public short? DO_FIRST_PERD { get; internal set; }

        /// <summary>
        /// Last day of excursion
        /// </summary>
        public DateTime? LASTDAY { get; internal set; }

        /// <summary>
        /// Last period on LASTDAY taken up by the excursion
        /// </summary>
        public short? LD_LAST_PERD { get; internal set; }

        /// <summary>
        /// Day One of excursion started in the AM or PM
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYONE_AM_PM { get; internal set; }

        /// <summary>
        /// Last Day of excursion ended in the AM or PM
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LASTDAY_AM_PM { get; internal set; }

        /// <summary>
        /// Attendance Type for Excursion
        /// </summary>
        public short? ABS_TYPE { get; internal set; }

        /// <summary>
        /// Copy of previous absence code - used in SG11032
        /// </summary>
        public short? PREV_ABS_TYPE { get; internal set; }

        /// <summary>
        /// Every day in the date range or Recurring once a week
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FREQUENCY { get; internal set; }

        /// <summary>
        /// Excursion destination
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESTINATION { get; internal set; }

        /// <summary>
        /// Address of venue
        /// [Alphanumeric (40)]
        /// </summary>
        public string VENUE_ADDRESS { get; internal set; }

        /// <summary>
        /// General Ledger code for excursion charges
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string EXC_GLCODE { get; internal set; }

        /// <summary>
        /// Feedback on excursion only
        /// [Memo]
        /// </summary>
        public string FEEDBACK { get; internal set; }

        /// <summary>
        /// Special requirements
        /// [Memo]
        /// </summary>
        public string SPECIAL_NEEDS { get; internal set; }

        /// <summary>
        /// Excursion purpose
        /// [Alphanumeric (80)]
        /// </summary>
        public string EXC_PURPOSE { get; internal set; }

        /// <summary>
        /// Excursion service provider name
        /// [Alphanumeric (80)]
        /// </summary>
        public string EXC_SERVICE_PROVIDER { get; internal set; }

        /// <summary>
        /// Method of excursion transport (Walking/Bicycle/School Bus/Public Bus/Train/Tram/Driven/Self driven/Taxi/Other)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSPORT_METHOD { get; internal set; }

        /// <summary>
        /// Excursion transport provider name
        /// [Alphanumeric (80)]
        /// </summary>
        public string EXC_TRANSPORT_PROVIDER { get; internal set; }

        /// <summary>
        /// Standard cost for transport
        /// </summary>
        public decimal? FIXED_TRANS_COST { get; internal set; }

        /// <summary>
        /// Additional cost of transport per student
        /// </summary>
        public decimal? PER_ST_TRANS_COST { get; internal set; }

        /// <summary>
        /// Standard venue cost
        /// </summary>
        public decimal? FIXED_VENUE_COST { get; internal set; }

        /// <summary>
        /// Additional cost of venue per student
        /// </summary>
        public decimal? PER_ST_VENUE_COST { get; internal set; }

        /// <summary>
        /// Details of any other costs associated with excursion
        /// [Memo]
        /// </summary>
        public string OTHER_COSTS { get; internal set; }

        /// <summary>
        /// (Was EXCURSION_AMT) Fee to be paid per student: not calculated
        /// </summary>
        public decimal? EXC_AMOUNT { get; internal set; }

        /// <summary>
        /// Staff may be members of group? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STAFF_MEMBERS { get; internal set; }

        /// <summary>
        /// Parents/guardians may be members of group? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PARENT_MEMBERS { get; internal set; }

        /// <summary>
        /// Staff member or Parent/guardian in charge? SF=Staff Member, DF=Parent/guardian
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RESP_PERSON_TYPE { get; internal set; }

        /// <summary>
        /// Reference in table SF or DF to person in charge
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ADULT_RESPONSIBLE { get; internal set; }

        /// <summary>
        /// (If parent/guardian in charge) Identifies which of the two adults in the family is in charge: &lt;&lt; should be renamed RESP_PARENT
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESP_PARENT_GENDER { get; internal set; }

        /// <summary>
        /// Enrolled in VET (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VET { get; internal set; }

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
        /// SCI (School Information) related entity by [SG.FROM_CAMPUS]-&gt;[SCI.SCIKEY]
        /// Minimum qualifying campus
        /// </summary>
        public SCI FROM_CAMPUS_SCI
        {
            get
            {
                if (FROM_CAMPUS == null)
                {
                    return null;
                }
                if (Cache_FROM_CAMPUS_SCI == null)
                {
                    Cache_FROM_CAMPUS_SCI = Context.SCI.FindBySCIKEY(FROM_CAMPUS.Value);
                }

                return Cache_FROM_CAMPUS_SCI;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SG.TO_CAMPUS]-&gt;[SCI.SCIKEY]
        /// Maximum qualifying campus
        /// </summary>
        public SCI TO_CAMPUS_SCI
        {
            get
            {
                if (TO_CAMPUS == null)
                {
                    return null;
                }
                if (Cache_TO_CAMPUS_SCI == null)
                {
                    Cache_TO_CAMPUS_SCI = Context.SCI.FindBySCIKEY(TO_CAMPUS.Value);
                }

                return Cache_TO_CAMPUS_SCI;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [SG.CAND_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// Minimum qualifying year level
        /// </summary>
        public KCY CAND_FIRST_YR_KCY
        {
            get
            {
                if (CAND_FIRST_YR == null)
                {
                    return null;
                }
                if (Cache_CAND_FIRST_YR_KCY == null)
                {
                    Cache_CAND_FIRST_YR_KCY = Context.KCY.FindByKCYKEY(CAND_FIRST_YR);
                }

                return Cache_CAND_FIRST_YR_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [SG.CAND_LAST_YR]-&gt;[KCY.KCYKEY]
        /// Maximum qualifying year level
        /// </summary>
        public KCY CAND_LAST_YR_KCY
        {
            get
            {
                if (CAND_LAST_YR == null)
                {
                    return null;
                }
                if (Cache_CAND_LAST_YR_KCY == null)
                {
                    Cache_CAND_LAST_YR_KCY = Context.KCY.FindByKCYKEY(CAND_LAST_YR);
                }

                return Cache_CAND_LAST_YR_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [SG.FUT_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// Minimum qualifying year fo FUT students
        /// </summary>
        public KCY FUT_FIRST_YR_KCY
        {
            get
            {
                if (FUT_FIRST_YR == null)
                {
                    return null;
                }
                if (Cache_FUT_FIRST_YR_KCY == null)
                {
                    Cache_FUT_FIRST_YR_KCY = Context.KCY.FindByKCYKEY(FUT_FIRST_YR);
                }

                return Cache_FUT_FIRST_YR_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [SG.FUT_LAST_YR]-&gt;[KCY.KCYKEY]
        /// Maximum qualifying year fo FUT students
        /// </summary>
        public KCY FUT_LAST_YR_KCY
        {
            get
            {
                if (FUT_LAST_YR == null)
                {
                    return null;
                }
                if (Cache_FUT_LAST_YR_KCY == null)
                {
                    Cache_FUT_LAST_YR_KCY = Context.KCY.FindByKCYKEY(FUT_LAST_YR);
                }

                return Cache_FUT_LAST_YR_KCY;
            }
        }

        /// <summary>
        /// KGH (Houses) related entity by [SG.HOUSE]-&gt;[KGH.KGHKEY]
        /// Qualifying House (if any)
        /// </summary>
        public KGH HOUSE_KGH
        {
            get
            {
                if (HOUSE == null)
                {
                    return null;
                }
                if (Cache_HOUSE_KGH == null)
                {
                    Cache_HOUSE_KGH = Context.KGH.FindByKGHKEY(HOUSE);
                }

                return Cache_HOUSE_KGH;
            }
        }

        /// <summary>
        /// KCT (Absence Types) related entity by [SG.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// Attendance Type for Excursion
        /// </summary>
        public KCT ABS_TYPE_KCT
        {
            get
            {
                if (ABS_TYPE == null)
                {
                    return null;
                }
                if (Cache_ABS_TYPE_KCT == null)
                {
                    Cache_ABS_TYPE_KCT = Context.KCT.FindByKCTKEY(ABS_TYPE.Value);
                }

                return Cache_ABS_TYPE_KCT;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SGAM (Adult Group Members) related entities by [SG.SGKEY]-&gt;[SGAM.SGAMKEY]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGAM> SGKEY_SGAM_SGAMKEY
        {
            get
            {
                if (Cache_SGKEY_SGAM_SGAMKEY == null &&
                    !Context.SGAM.TryFindBySGAMKEY(SGKEY, out Cache_SGKEY_SGAM_SGAMKEY))
                {
                    Cache_SGKEY_SGAM_SGAMKEY = new List<SGAM>().AsReadOnly();
                }

                return Cache_SGKEY_SGAM_SGAMKEY;
            }
        }

        /// <summary>
        /// SGHG (Home Group Eligibility Criteria) related entities by [SG.SGKEY]-&gt;[SGHG.SGHGKEY]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGHG> SGKEY_SGHG_SGHGKEY
        {
            get
            {
                if (Cache_SGKEY_SGHG_SGHGKEY == null &&
                    !Context.SGHG.TryFindBySGHGKEY(SGKEY, out Cache_SGKEY_SGHG_SGHGKEY))
                {
                    Cache_SGKEY_SGHG_SGHGKEY = new List<SGHG>().AsReadOnly();
                }

                return Cache_SGKEY_SGHG_SGHGKEY;
            }
        }

        /// <summary>
        /// SGM (Special Group Meetings) related entities by [SG.SGKEY]-&gt;[SGM.SGMKEY]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGM> SGKEY_SGM_SGMKEY
        {
            get
            {
                if (Cache_SGKEY_SGM_SGMKEY == null &&
                    !Context.SGM.TryFindBySGMKEY(SGKEY, out Cache_SGKEY_SGM_SGMKEY))
                {
                    Cache_SGKEY_SGM_SGMKEY = new List<SGM>().AsReadOnly();
                }

                return Cache_SGKEY_SGM_SGMKEY;
            }
        }

        /// <summary>
        /// SGMA (Group Meeting Attendance) related entities by [SG.SGKEY]-&gt;[SGMA.SGMAKEY]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGMA> SGKEY_SGMA_SGMAKEY
        {
            get
            {
                if (Cache_SGKEY_SGMA_SGMAKEY == null &&
                    !Context.SGMA.TryFindBySGMAKEY(SGKEY, out Cache_SGKEY_SGMA_SGMAKEY))
                {
                    Cache_SGKEY_SGMA_SGMAKEY = new List<SGMA>().AsReadOnly();
                }

                return Cache_SGKEY_SGMA_SGMAKEY;
            }
        }

        /// <summary>
        /// SGSC (Subject/Class Eligibility Criteria) related entities by [SG.SGKEY]-&gt;[SGSC.SGSCKEY]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGSC> SGKEY_SGSC_SGSCKEY
        {
            get
            {
                if (Cache_SGKEY_SGSC_SGSCKEY == null &&
                    !Context.SGSC.TryFindBySGSCKEY(SGKEY, out Cache_SGKEY_SGSC_SGSCKEY))
                {
                    Cache_SGKEY_SGSC_SGSCKEY = new List<SGSC>().AsReadOnly();
                }

                return Cache_SGKEY_SGSC_SGSCKEY;
            }
        }

        /// <summary>
        /// SGSG (Group Membership Eligibility Criteria) related entities by [SG.SGKEY]-&gt;[SGSG.SGSGKEY]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGSG> SGKEY_SGSG_SGSGKEY
        {
            get
            {
                if (Cache_SGKEY_SGSG_SGSGKEY == null &&
                    !Context.SGSG.TryFindBySGSGKEY(SGKEY, out Cache_SGKEY_SGSG_SGSGKEY))
                {
                    Cache_SGKEY_SGSG_SGSGKEY = new List<SGSG>().AsReadOnly();
                }

                return Cache_SGKEY_SGSG_SGSGKEY;
            }
        }

        /// <summary>
        /// SGSG (Group Membership Eligibility Criteria) related entities by [SG.SGKEY]-&gt;[SGSG.SGLINK]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGSG> SGKEY_SGSG_SGLINK
        {
            get
            {
                if (Cache_SGKEY_SGSG_SGLINK == null &&
                    !Context.SGSG.TryFindBySGLINK(SGKEY, out Cache_SGKEY_SGSG_SGLINK))
                {
                    Cache_SGKEY_SGSG_SGLINK = new List<SGSG>().AsReadOnly();
                }

                return Cache_SGKEY_SGSG_SGLINK;
            }
        }

        /// <summary>
        /// SGTRX (Temporary Group Transactions) related entities by [SG.SGKEY]-&gt;[SGTRX.SGTRXKEY]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SGTRX> SGKEY_SGTRX_SGTRXKEY
        {
            get
            {
                if (Cache_SGKEY_SGTRX_SGTRXKEY == null &&
                    !Context.SGTRX.TryFindBySGTRXKEY(SGKEY, out Cache_SGKEY_SGTRX_SGTRXKEY))
                {
                    Cache_SGKEY_SGTRX_SGTRXKEY = new List<SGTRX>().AsReadOnly();
                }

                return Cache_SGKEY_SGTRX_SGTRXKEY;
            }
        }

        /// <summary>
        /// SPU (Publications) related entities by [SG.SGKEY]-&gt;[SPU.MAILING_LIST]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<SPU> SGKEY_SPU_MAILING_LIST
        {
            get
            {
                if (Cache_SGKEY_SPU_MAILING_LIST == null &&
                    !Context.SPU.TryFindByMAILING_LIST(SGKEY, out Cache_SGKEY_SPU_MAILING_LIST))
                {
                    Cache_SGKEY_SPU_MAILING_LIST = new List<SPU>().AsReadOnly();
                }

                return Cache_SGKEY_SPU_MAILING_LIST;
            }
        }

        /// <summary>
        /// STPO (Position or Group Memberships) related entities by [SG.SGKEY]-&gt;[STPO.SGLINK]
        /// Student Grouping code
        /// </summary>
        public IReadOnlyList<STPO> SGKEY_STPO_SGLINK
        {
            get
            {
                if (Cache_SGKEY_STPO_SGLINK == null &&
                    !Context.STPO.TryFindBySGLINK(SGKEY, out Cache_SGKEY_STPO_SGLINK))
                {
                    Cache_SGKEY_STPO_SGLINK = new List<STPO>().AsReadOnly();
                }

                return Cache_SGKEY_STPO_SGLINK;
            }
        }

        #endregion

    }
}
