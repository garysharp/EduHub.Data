using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Groupings
    /// </summary>
    public class SG_Entity : EntityBase
    {
        /// <summary>
        /// Student Grouping code [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGKEY { get; internal set; }
        /// <summary>
        /// (Was PURPOSE) Name of Student Grouping [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// (Was ALLOC_TYPE) Group type: S=Special Group, E=Excursion Group, P=Position [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GROUP_TYPE { get; internal set; }
        /// <summary>
        /// Group category for use by school if required (eg "Club", "Sports Team", "Orchestra") [Alphanumeric: a20]
        /// </summary>
        public string GROUP_CATEGORY { get; internal set; }
        /// <summary>
        /// Other group that this group has been copied from (if any): NOTE this should NOT be a foreign key to SG as once the group is created no link is required [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SOURCE_SG { get; internal set; }
        /// <summary>
        /// Can students that do not conform to the criteria be assigned to this group? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STRICT_CRITERIA { get; internal set; }
        /// <summary>
        /// (Was NUMBER_IND) Maximum number of students (0 acceptable) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAX_NUMBER_STUD { get; internal set; }
        /// <summary>
        /// (Was MAKEUP) Description of year levels/forms, etc [Memo: m]
        /// </summary>
        public string STRUCTURE { get; internal set; }
        /// <summary>
        /// The date the group started or will start [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// The date the group ended or will end [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// The date (if any) on which all current memberships of the group or position will lapse [Date Time nullable: d]
        /// </summary>
        public DateTime? CESSATION_DATE { get; internal set; }
        /// <summary>
        /// Is this Position for a House or Home group? H=House, G=Home group, N=Neither [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HOUSE_HOMEGROUP { get; internal set; }
        /// <summary>
        /// C=current, F = future, B = both [Alphanumeric: a1]
        /// </summary>
        public string SCOPE { get; internal set; }
        /// <summary>
        /// Minimum qualifying campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? FROM_CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [FROM_CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Minimum qualifying campus
        /// </summary>
        public SCI_Entity FROM_CAMPUS_SCI { get { return FROM_CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(FROM_CAMPUS.Value) : null; } }
        /// <summary>
        /// Maximum qualifying campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TO_CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [TO_CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Maximum qualifying campus
        /// </summary>
        public SCI_Entity TO_CAMPUS_SCI { get { return TO_CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(TO_CAMPUS.Value) : null; } }
        /// <summary>
        /// Minimum qualifying year level [Uppercase Alphanumeric: u4]
        /// </summary>
        public string CAND_FIRST_YR { get; internal set; }
        /// <summary>
        /// Navigation property for [CAND_FIRST_YR] => [KCY_Entity].[KCYKEY]
        /// Minimum qualifying year level
        /// </summary>
        public KCY_Entity CAND_FIRST_YR_KCY { get { return CAND_FIRST_YR == null ? null : Context.KCY.FindByKCYKEY(CAND_FIRST_YR); } }
        /// <summary>
        /// Maximum qualifying year level [Uppercase Alphanumeric: u4]
        /// </summary>
        public string CAND_LAST_YR { get; internal set; }
        /// <summary>
        /// Navigation property for [CAND_LAST_YR] => [KCY_Entity].[KCYKEY]
        /// Maximum qualifying year level
        /// </summary>
        public KCY_Entity CAND_LAST_YR_KCY { get { return CAND_LAST_YR == null ? null : Context.KCY.FindByKCYKEY(CAND_LAST_YR); } }
        /// <summary>
        /// Minimum qualifying year fo FUT students [Uppercase Alphanumeric: u4]
        /// </summary>
        public string FUT_FIRST_YR { get; internal set; }
        /// <summary>
        /// Navigation property for [FUT_FIRST_YR] => [KCY_Entity].[KCYKEY]
        /// Minimum qualifying year fo FUT students
        /// </summary>
        public KCY_Entity FUT_FIRST_YR_KCY { get { return FUT_FIRST_YR == null ? null : Context.KCY.FindByKCYKEY(FUT_FIRST_YR); } }
        /// <summary>
        /// Maximum qualifying year fo FUT students [Uppercase Alphanumeric: u4]
        /// </summary>
        public string FUT_LAST_YR { get; internal set; }
        /// <summary>
        /// Navigation property for [FUT_LAST_YR] => [KCY_Entity].[KCYKEY]
        /// Maximum qualifying year fo FUT students
        /// </summary>
        public KCY_Entity FUT_LAST_YR_KCY { get { return FUT_LAST_YR == null ? null : Context.KCY.FindByKCYKEY(FUT_LAST_YR); } }
        /// <summary>
        /// Minimum qualifying age [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CAND_FIRST_AGE { get; internal set; }
        /// <summary>
        /// Maximum qualifying age [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CAND_LAST_AGE { get; internal set; }
        /// <summary>
        /// Date from which to calculate age [Date Time nullable: d]
        /// </summary>
        public DateTime? AGE_DATE { get; internal set; }
        /// <summary>
        /// Earliest qualifying date of birth (calculated non-editable) [Date Time nullable: d]
        /// </summary>
        public DateTime? FIRST_DOB { get; internal set; }
        /// <summary>
        /// Latest qualifying date of birth (calculated non-editable) [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_DOB { get; internal set; }
        /// <summary>
        /// First or only qualifying gender [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDERA { get; internal set; }
        /// <summary>
        /// Second qualifying gender (if any) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDERB { get; internal set; }
        /// <summary>
        /// Qualifying House (if any) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HOUSE { get; internal set; }
        /// <summary>
        /// Navigation property for [HOUSE] => [KGH_Entity].[KGHKEY]
        /// Qualifying House (if any)
        /// </summary>
        public KGH_Entity HOUSE_KGH { get { return HOUSE == null ? null : Context.KGH.FindByKGHKEY(HOUSE); } }
        /// <summary>
        /// First day of excursion [Date Time nullable: d]
        /// </summary>
        public DateTime? DAYONE { get; internal set; }
        /// <summary>
        /// First period on DAYONE taken up by the excursion [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DO_FIRST_PERD { get; internal set; }
        /// <summary>
        /// Last day of excursion [Date Time nullable: d]
        /// </summary>
        public DateTime? LASTDAY { get; internal set; }
        /// <summary>
        /// Last period on LASTDAY taken up by the excursion [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LD_LAST_PERD { get; internal set; }
        /// <summary>
        /// Day One of excursion started in the AM or PM [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYONE_AM_PM { get; internal set; }
        /// <summary>
        /// Last Day of excursion ended in the AM or PM [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LASTDAY_AM_PM { get; internal set; }
        /// <summary>
        /// Attendance Type for Excursion [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ABS_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [ABS_TYPE] => [KCT_Entity].[KCTKEY]
        /// Attendance Type for Excursion
        /// </summary>
        public KCT_Entity ABS_TYPE_KCT { get { return ABS_TYPE.HasValue ? Context.KCT.FindByKCTKEY(ABS_TYPE.Value) : null; } }
        /// <summary>
        /// Copy of previous absence code - used in SG11032 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PREV_ABS_TYPE { get; internal set; }
        /// <summary>
        /// Every day in the date range or Recurring once a week [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FREQUENCY { get; internal set; }
        /// <summary>
        /// Excursion destination [Alphanumeric: a40]
        /// </summary>
        public string DESTINATION { get; internal set; }
        /// <summary>
        /// Address of venue [Alphanumeric: a40]
        /// </summary>
        public string VENUE_ADDRESS { get; internal set; }
        /// <summary>
        /// General Ledger code for excursion charges [Uppercase Alphanumeric: u10]
        /// </summary>
        public string EXC_GLCODE { get; internal set; }
        /// <summary>
        /// Feedback on excursion only [Memo: m]
        /// </summary>
        public string FEEDBACK { get; internal set; }
        /// <summary>
        /// Special requirements [Memo: m]
        /// </summary>
        public string SPECIAL_NEEDS { get; internal set; }
        /// <summary>
        /// Excursion purpose [Alphanumeric: a80]
        /// </summary>
        public string EXC_PURPOSE { get; internal set; }
        /// <summary>
        /// Excursion service provider name [Alphanumeric: a80]
        /// </summary>
        public string EXC_SERVICE_PROVIDER { get; internal set; }
        /// <summary>
        /// Method of excursion transport (Walking/Bicycle/School Bus/Public Bus/Train/Tram/Driven/Self driven/Taxi/Other) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSPORT_METHOD { get; internal set; }
        /// <summary>
        /// Excursion transport provider name [Alphanumeric: a80]
        /// </summary>
        public string EXC_TRANSPORT_PROVIDER { get; internal set; }
        /// <summary>
        /// Standard cost for transport [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? FIXED_TRANS_COST { get; internal set; }
        /// <summary>
        /// Additional cost of transport per student [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PER_ST_TRANS_COST { get; internal set; }
        /// <summary>
        /// Standard venue cost [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? FIXED_VENUE_COST { get; internal set; }
        /// <summary>
        /// Additional cost of venue per student [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PER_ST_VENUE_COST { get; internal set; }
        /// <summary>
        /// Details of any other costs associated with excursion [Memo: m]
        /// </summary>
        public string OTHER_COSTS { get; internal set; }
        /// <summary>
        /// (Was EXCURSION_AMT) Fee to be paid per student: not calculated [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? EXC_AMOUNT { get; internal set; }
        /// <summary>
        /// Staff may be members of group? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STAFF_MEMBERS { get; internal set; }
        /// <summary>
        /// Parents/guardians may be members of group? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PARENT_MEMBERS { get; internal set; }
        /// <summary>
        /// Staff member or Parent/guardian in charge? SF=Staff Member, DF=Parent/guardian [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RESP_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Reference in table SF or DF to person in charge [Uppercase Alphanumeric: u10]
        /// </summary>
        public string ADULT_RESPONSIBLE { get; internal set; }
        /// <summary>
        /// (If parent/guardian in charge) Identifies which of the two adults in the family is in charge: << should be renamed RESP_PARENT [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RESP_PARENT_GENDER { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
