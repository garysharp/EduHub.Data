using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Groupings
    /// </summary>
    public partial class SG : EntityBase
    {
#region Navigation Property Cache
        private SCI _FROM_CAMPUS_SCI;
        private SCI _TO_CAMPUS_SCI;
        private KCY _CAND_FIRST_YR_KCY;
        private KCY _CAND_LAST_YR_KCY;
        private KCY _FUT_FIRST_YR_KCY;
        private KCY _FUT_LAST_YR_KCY;
        private KGH _HOUSE_KGH;
        private KCT _ABS_TYPE_KCT;
#endregion

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
                if (FROM_CAMPUS.HasValue)
                {
                    if (_FROM_CAMPUS_SCI == null)
                    {
                        _FROM_CAMPUS_SCI = Context.SCI.FindBySCIKEY(FROM_CAMPUS.Value);
                    }
                    return _FROM_CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
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
                if (TO_CAMPUS.HasValue)
                {
                    if (_TO_CAMPUS_SCI == null)
                    {
                        _TO_CAMPUS_SCI = Context.SCI.FindBySCIKEY(TO_CAMPUS.Value);
                    }
                    return _TO_CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
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
                if (CAND_FIRST_YR != null)
                {
                    if (_CAND_FIRST_YR_KCY == null)
                    {
                        _CAND_FIRST_YR_KCY = Context.KCY.FindByKCYKEY(CAND_FIRST_YR);
                    }
                    return _CAND_FIRST_YR_KCY;
                }
                else
                {
                    return null;
                }
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
                if (CAND_LAST_YR != null)
                {
                    if (_CAND_LAST_YR_KCY == null)
                    {
                        _CAND_LAST_YR_KCY = Context.KCY.FindByKCYKEY(CAND_LAST_YR);
                    }
                    return _CAND_LAST_YR_KCY;
                }
                else
                {
                    return null;
                }
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
                if (FUT_FIRST_YR != null)
                {
                    if (_FUT_FIRST_YR_KCY == null)
                    {
                        _FUT_FIRST_YR_KCY = Context.KCY.FindByKCYKEY(FUT_FIRST_YR);
                    }
                    return _FUT_FIRST_YR_KCY;
                }
                else
                {
                    return null;
                }
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
                if (FUT_LAST_YR != null)
                {
                    if (_FUT_LAST_YR_KCY == null)
                    {
                        _FUT_LAST_YR_KCY = Context.KCY.FindByKCYKEY(FUT_LAST_YR);
                    }
                    return _FUT_LAST_YR_KCY;
                }
                else
                {
                    return null;
                }
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
                if (HOUSE != null)
                {
                    if (_HOUSE_KGH == null)
                    {
                        _HOUSE_KGH = Context.KGH.FindByKGHKEY(HOUSE);
                    }
                    return _HOUSE_KGH;
                }
                else
                {
                    return null;
                }
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
                if (ABS_TYPE.HasValue)
                {
                    if (_ABS_TYPE_KCT == null)
                    {
                        _ABS_TYPE_KCT = Context.KCT.FindByKCTKEY(ABS_TYPE.Value);
                    }
                    return _ABS_TYPE_KCT;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SGAM (Adult Group Members) related entities by [SGAM.SGAMKEY]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGAM> SGAM_SGAMKEY
        {
            get
            {
                return Context.SG.FindSGAMBySGAMKEY(SGKEY);
            }
        }

        /// <summary>
        /// SGHG (Home Group Eligibility Criteria) related entities by [SGHG.SGHGKEY]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGHG> SGHG_SGHGKEY
        {
            get
            {
                return Context.SG.FindSGHGBySGHGKEY(SGKEY);
            }
        }

        /// <summary>
        /// SGM (Special Group Meetings) related entities by [SGM.SGMKEY]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGM> SGM_SGMKEY
        {
            get
            {
                return Context.SG.FindSGMBySGMKEY(SGKEY);
            }
        }

        /// <summary>
        /// SGMA (Group Meeting Attendance) related entities by [SGMA.SGMAKEY]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGMA> SGMA_SGMAKEY
        {
            get
            {
                return Context.SG.FindSGMABySGMAKEY(SGKEY);
            }
        }

        /// <summary>
        /// SGSC (Subject/Class Eligibility Criteria) related entities by [SGSC.SGSCKEY]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGSC> SGSC_SGSCKEY
        {
            get
            {
                return Context.SG.FindSGSCBySGSCKEY(SGKEY);
            }
        }

        /// <summary>
        /// SGSG (Group Membership Eligibility Criteria) related entities by [SGSG.SGSGKEY]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGSG> SGSG_SGSGKEY
        {
            get
            {
                return Context.SG.FindSGSGBySGSGKEY(SGKEY);
            }
        }

        /// <summary>
        /// SGSG (Group Membership Eligibility Criteria) related entities by [SGSG.SGLINK]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGSG> SGSG_SGLINK
        {
            get
            {
                return Context.SG.FindSGSGBySGLINK(SGKEY);
            }
        }

        /// <summary>
        /// SGTRX (Temporary Group Transactions) related entities by [SGTRX.SGTRXKEY]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SGTRX> SGTRX_SGTRXKEY
        {
            get
            {
                return Context.SG.FindSGTRXBySGTRXKEY(SGKEY);
            }
        }

        /// <summary>
        /// SPU (Publications) related entities by [SPU.MAILING_LIST]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<SPU> SPU_MAILING_LIST
        {
            get
            {
                return Context.SG.FindSPUByMAILING_LIST(SGKEY);
            }
        }

        /// <summary>
        /// STPO (Position or Group Memberships) related entities by [STPO.SGLINK]-&gt;[SG.SGKEY]
        /// </summary>
        public IReadOnlyList<STPO> STPO_SGLINK
        {
            get
            {
                return Context.SG.FindSTPOBySGLINK(SGKEY);
            }
        }
#endregion
    }
}
