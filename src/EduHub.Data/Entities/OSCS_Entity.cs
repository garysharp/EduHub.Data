using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CASES Past Students
    /// </summary>
    public class OSCS_Entity : EntityBase
    {
#region Navigation Property Cache
        private KGT_Entity _ADULT_A_COUNTRY_KGT;
        private KGT_Entity _ADULT_B_COUNTRY_KGT;
        private KGG_Entity _ZEROMTH_CAT_KGG;
        private KGD_Entity _ZEROMTH_CAT_DEST_KGD;
        private KGT_Entity _BIRTH_COUNTRY_KGT;
        private KGL_Entity _HOME_LANG_KGL;
        private KGG_Entity _SIXMTH_CAT_KGG;
        private KGD_Entity _SIXMTH_CAT_DEST_KGD;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int OSCSKEY { get; internal set; }
        /// <summary>
        /// Surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First given name [Alphanumeric: a20]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second given name [Alphanumeric: a20]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Street address [Alphanumeric: a50]
        /// </summary>
        public string ADDRESS { get; internal set; }
        /// <summary>
        /// Suburb [Alphanumeric: a20]
        /// </summary>
        public string SUBURB { get; internal set; }
        /// <summary>
        /// Full name of state of address [Titlecase: t17]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Postcode [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Home telephone number of student including area code [Uppercase Alphanumeric: u20]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Date of birth [Date Time nullable: d]
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Student gender [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Date of entry to school [Date Time nullable: d]
        /// </summary>
        public DateTime? ENTRY { get; internal set; }
        /// <summary>
        /// Student's current home group [Uppercase Alphanumeric: u3]
        /// </summary>
        public string CURR_HOME_GROUP { get; internal set; }
        /// <summary>
        /// Student's previous home group [Uppercase Alphanumeric: u3]
        /// </summary>
        public string PREV_HOME_GROUP { get; internal set; }
        /// <summary>
        /// Total of all absences for this student as at February census [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ABS_ALL_FEB { get; internal set; }
        /// <summary>
        /// Total unapproved absences for this student as at February census [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ABS_UNAP_FEB { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ELIG_DAYS_FEB { get; internal set; }
        /// <summary>
        /// Total of all absences for this student as at August census [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ABS_ALL_AUG { get; internal set; }
        /// <summary>
        /// Total unapproved absences for this student as at August census [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ABS_UNAP_AUG { get; internal set; }
        /// <summary>
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ELIG_DAYS_AUG { get; internal set; }
        /// <summary>
        /// Fees owed to the school in respect of this student [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? FEES_OWED { get; internal set; }
        /// <summary>
        /// Fees paid to the school in respect of this student [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? FEES_PAID { get; internal set; }
        /// <summary>
        /// Entity number of the school from which the student came to this school [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ENT_NUMFEEDER { get; internal set; }
        /// <summary>
        /// School number of the school from which the student came to this school [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUM_FEEDER { get; internal set; }
        /// <summary>
        /// Full School number of the school from which the student came to this school [Uppercase Alphanumeric: u8]
        /// </summary>
        public string FEEDER_SCHOOL { get; internal set; }
        /// <summary>
        /// School number of the student's current(?) school [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUM_CURRENT { get; internal set; }
        /// <summary>
        /// Full School number of the student's current(?) school [Uppercase Alphanumeric: u8]
        /// </summary>
        public string CURRENT_SCHOOL { get; internal set; }
        /// <summary>
        /// Campus number of the campus at which the student was [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Entity number of the student's next school [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ENT_NUMNEXTSCHL { get; internal set; }
        /// <summary>
        /// School number of the student's next school [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUM_NEXTSCHL { get; internal set; }
        /// <summary>
        /// Full School number of the school from which the student's next school [Uppercase Alphanumeric: u8]
        /// </summary>
        public string NEXT_SCHOOL { get; internal set; }
        /// <summary>
        /// Street address of this student's new address [Alphanumeric: a50]
        /// </summary>
        public string NEW_ADDRESS { get; internal set; }
        /// <summary>
        /// Suburb of this student's new address [Alphanumeric: a20]
        /// </summary>
        public string NEW_SUBURB { get; internal set; }
        /// <summary>
        /// Full name of state of this student's new address [Titlecase: t17]
        /// </summary>
        public string NEW_STATE { get; internal set; }
        /// <summary>
        /// Post code of this student's new address [Alphanumeric: a4]
        /// </summary>
        public string NEW_POSTCODE { get; internal set; }
        /// <summary>
        /// New home telephone number of student including area code [Uppercase Alphanumeric: u20]
        /// </summary>
        public string NEW_TELEPHONE { get; internal set; }
        /// <summary>
        /// Date on which the student transferred from this school [Date Time nullable: d]
        /// </summary>
        public DateTime? TRAN_DATE { get; internal set; }
        /// <summary>
        /// Title (Ms, Mr, etc.) of first parent/guardian of this student [Titlecase: t4]
        /// </summary>
        public string ADULT_A_TITLE { get; internal set; }
        /// <summary>
        /// Name of first parent/guardian of this student [Uppercase Alphanumeric: u30]
        /// </summary>
        public string ADULT_A_NAME { get; internal set; }
        /// <summary>
        /// (Was M_COUNTRY) Country of birth of first parent/guardian of this student [Uppercase Alphanumeric: u6]
        /// </summary>
        public string ADULT_A_COUNTRY { get; internal set; }
        /// <summary>
        /// (Was M_RELATION) Relationship of first parent/guardian to this student [Alphanumeric: a20]
        /// </summary>
        public string ADULT_A_RELATION { get; internal set; }
        /// <summary>
        /// Title (Ms, Mr, etc.) of second parent/guardian of this student [Titlecase: t4]
        /// </summary>
        public string ADULT_B_TITLE { get; internal set; }
        /// <summary>
        /// Name of second parent/guardian of this student [Uppercase Alphanumeric: u30]
        /// </summary>
        public string ADULT_B_NAME { get; internal set; }
        /// <summary>
        /// Country of birth of second parent/guardian of this student [Uppercase Alphanumeric: u6]
        /// </summary>
        public string ADULT_B_COUNTRY { get; internal set; }
        /// <summary>
        /// Relationship of second parent/guardian to this student [Alphanumeric: a20]
        /// </summary>
        public string ADULT_B_RELATION { get; internal set; }
        /// <summary>
        /// Transfer reason [Alphanumeric: a50]
        /// </summary>
        public string REASON_TRAN1N { get; internal set; }
        /// <summary>
        /// Alternative/additional transfer reason [Alphanumeric: a50]
        /// </summary>
        public string REASON_TRAN2N { get; internal set; }
        /// <summary>
        /// Current year level [Uppercase Alphanumeric: u4]
        /// </summary>
        public string CURR_YEAR_LEVEL { get; internal set; }
        /// <summary>
        /// Previous year level [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PREV_YEAR_LEVEL { get; internal set; }
        /// <summary>
        /// External exam code (BoS no): possibly not required [Integer (32bit signed nullable): l]
        /// </summary>
        public int? VCE_NUM { get; internal set; }
        /// <summary>
        /// Was this student included in the census? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE_CENSUS { get; internal set; }
        /// <summary>
        /// Status indicator [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HMS_DATA_IN { get; internal set; }
        /// <summary>
        /// Family occupation status group (1-5) [Uppercase Alphanumeric: u2]
        /// </summary>
        public string FAM_OCCUPATION { get; internal set; }
        /// <summary>
        /// MIPS Destination Category on exit [Uppercase Alphanumeric: u2]
        /// </summary>
        public string ZEROMTH_CAT { get; internal set; }
        /// <summary>
        /// MIPS Destination on exit [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ZEROMTH_DEST { get; internal set; }
        /// <summary>
        /// MIPS Category & Destination on exit [Uppercase Alphanumeric: u6]
        /// </summary>
        public string ZEROMTH_CAT_DEST { get; internal set; }
        /// <summary>
        /// Date MIPS Destination & Category Updated [Date Time nullable: d]
        /// </summary>
        public DateTime? ZEROMTH_DATE { get; internal set; }
        /// <summary>
        /// Visa expiry date [Date Time nullable: d]
        /// </summary>
        public DateTime? VISA_EXPIRY { get; internal set; }
        /// <summary>
        /// Fraction of time this student spent at this school [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Was this student enrolled at this school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENROLLED { get; internal set; }
        /// <summary>
        /// School number of a school attended part-time by this student [Integer (16bit signed nullable): i]
        /// </summary>
        public short? A_SCHL_NUM { get; internal set; }
        /// <summary>
        /// Full School number of a school attended part-time by this student [Uppercase Alphanumeric: u8]
        /// </summary>
        public string A_SCHOOL_NUM { get; internal set; }
        /// <summary>
        /// Fraction of time this student spent at that school [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? A_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Was this student enrolled at that school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string A_ENROLLED { get; internal set; }
        /// <summary>
        /// School number of a school attended part-time by this student [Integer (16bit signed nullable): i]
        /// </summary>
        public short? B_SCHL_NUM { get; internal set; }
        /// <summary>
        /// Full School number of a school attended part-time by this student [Uppercase Alphanumeric: u8]
        /// </summary>
        public string B_SCHOOL_NUM { get; internal set; }
        /// <summary>
        /// Fraction of time this student spent at that school [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? B_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Was this student enrolled at that school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string B_ENROLLED { get; internal set; }
        /// <summary>
        /// School number of a school attended part-time by this student [Integer (16bit signed nullable): i]
        /// </summary>
        public short? C_SCHL_NUM { get; internal set; }
        /// <summary>
        /// Full School number of a school attended part-time by this student [Uppercase Alphanumeric: u8]
        /// </summary>
        public string C_SCHOOL_NUM { get; internal set; }
        /// <summary>
        /// Fraction of time this student spent at that school [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? C_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Was this student enrolled at that school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string C_ENROLLED { get; internal set; }
        /// <summary>
        /// School number of a school attended part-time by this student [Integer (16bit signed nullable): i]
        /// </summary>
        public short? D_SCHL_NUM { get; internal set; }
        /// <summary>
        /// Full School number of a school attended part-time by this student [Uppercase Alphanumeric: u8]
        /// </summary>
        public string D_SCHOOL_NUM { get; internal set; }
        /// <summary>
        /// Fraction of time this student spent at that school [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? D_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Was this student enrolled at that school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string D_ENROLLED { get; internal set; }
        /// <summary>
        /// Status code [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STUD_TYPE { get; internal set; }
        /// <summary>
        /// Country of birth [Uppercase Alphanumeric: u6]
        /// </summary>
        public string BIRTH_COUNTRY { get; internal set; }
        /// <summary>
        /// Date of arrival in Australia [Date Time nullable: d]
        /// </summary>
        public DateTime? ARRIVAL { get; internal set; }
        /// <summary>
        /// Date of first enrolment in an Australian school [Date Time nullable: d]
        /// </summary>
        public DateTime? AUSSIE_SCHOOL { get; internal set; }
        /// <summary>
        /// Student speaks English? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENG_SPEAK { get; internal set; }
        /// <summary>
        /// The language spoken at home [Uppercase Alphanumeric: u7]
        /// </summary>
        public string HOME_LANG { get; internal set; }
        /// <summary>
        /// Was this student an applicant for, or in receipt of, EMA? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ED_ALLOW { get; internal set; }
        /// <summary>
        /// Youth allowance (<25) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string YOUTH_ALLOW { get; internal set; }
        /// <summary>
        /// Did this student take religious instruction? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string REL_INSTR { get; internal set; }
        /// <summary>
        /// Indigenous origin (Aboriginal/Torres Strait Islander/Both/Neither/Unknown) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string KOORIE { get; internal set; }
        /// <summary>
        /// Aide required to assist integration into school? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INTEGRATION { get; internal set; }
        /// <summary>
        /// Did student repeat a year level? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string REPEAT { get; internal set; }
        /// <summary>
        /// Religious denomination of this student [Uppercase Alphanumeric: u15]
        /// </summary>
        public string RELIG_DENOM { get; internal set; }
        /// <summary>
        /// Disability ID of this student [Uppercase Alphanumeric: u6]
        /// </summary>
        public string DISABILITY_ID { get; internal set; }
        /// <summary>
        /// Did this student have a disability? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DISABILITY { get; internal set; }
        /// <summary>
        /// Did this student have a hearing impairment? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HEARING_IMPAIR { get; internal set; }
        /// <summary>
        /// Did this student have a vision impairment? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string VISUAL_IMPAIR { get; internal set; }
        /// <summary>
        /// Did this student have a speech impairment? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SPEECH_IMPAIR { get; internal set; }
        /// <summary>
        /// Did this student have a physical impairment? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PHYSICAL_IMPAIR { get; internal set; }
        /// <summary>
        /// Overall Immunisation status of this student [Uppercase Alphanumeric: u1]
        /// </summary>
        public string IMMUNIZE { get; internal set; }
        /// <summary>
        /// Diphtheria immunisation status of this student [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DIPTHERIA_S { get; internal set; }
        /// <summary>
        /// Tetanus immunisation status of this student [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TETANUS_S { get; internal set; }
        /// <summary>
        /// Polio immunisation status of this student [Uppercase Alphanumeric: u1]
        /// </summary>
        public string POLIO_S { get; internal set; }
        /// <summary>
        /// Measles immunisation status of this student [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MEASLES_S { get; internal set; }
        /// <summary>
        /// Mumps immunisation status of this student [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MUMPS_S { get; internal set; }
        /// <summary>
        /// Measles, Mumps and Rubella immunisation status [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MMR_S { get; internal set; }
        /// <summary>
        /// HIB immunisation status [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HIB_S { get; internal set; }
        /// <summary>
        /// Pertussis immunisation status [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERTUSSIS_S { get; internal set; }
        /// <summary>
        /// Australian residence status: (Permanent/Temporary) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RESIDENT_STATUS { get; internal set; }
        /// <summary>
        /// Visa Sub-class [Uppercase Alphanumeric: u3]
        /// </summary>
        public string VISA_CLASS { get; internal set; }
        /// <summary>
        /// (Was VISA_SUBCLASS) Visa statistical code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string VISA_STAT_CODE { get; internal set; }
        /// <summary>
        /// Student entitled to Student Resource Package (SRP) funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ORDINARY_STUDENT { get; internal set; }
        /// <summary>
        /// Student's living arrangement(At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FAM_STRUC_TYPE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CENSUSDAY_FEB { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CENSUSDAY_AUG { get; internal set; }
        /// <summary>
        /// MIPS Destination Category after 6 months [Uppercase Alphanumeric: u2]
        /// </summary>
        public string SIXMTH_CAT { get; internal set; }
        /// <summary>
        /// MIPS Destination after 6 months [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SIXMTH_DEST { get; internal set; }
        /// <summary>
        /// MIPS Category & Destination after six month [Uppercase Alphanumeric: u6]
        /// </summary>
        public string SIXMTH_CAT_DEST { get; internal set; }
        /// <summary>
        /// Date 6 months MIPS Destination & Category Updated [Date Time nullable: d]
        /// </summary>
        public DateTime? SIXMTH_DATE { get; internal set; }
        /// <summary>
        /// International Student Id. [Uppercase Alphanumeric: u7]
        /// </summary>
        public string ISU_STD_NO { get; internal set; }
        /// <summary>
        /// Was Student present on Census Day (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CENSUSDAY { get; internal set; }
        /// <summary>
        /// Last Absence Day [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_ABSENCE { get; internal set; }
        /// <summary>
        /// Total YTD absences for Student [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? YTD_ABSENCE { get; internal set; }
        /// <summary>
        /// Total YTD Approved absences for student [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? YTD_APPROVED { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [ADULT_A_COUNTRY] => [KGT_Entity].[COUNTRY]
        /// (Was M_COUNTRY) Country of birth of first parent/guardian of this student
        /// </summary>
        public KGT_Entity ADULT_A_COUNTRY_KGT {
            get
            {
                if (ADULT_A_COUNTRY != null)
                {
                    if (_ADULT_A_COUNTRY_KGT == null)
                    {
                        _ADULT_A_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(ADULT_A_COUNTRY);
                    }
                    return _ADULT_A_COUNTRY_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ADULT_B_COUNTRY] => [KGT_Entity].[COUNTRY]
        /// Country of birth of second parent/guardian of this student
        /// </summary>
        public KGT_Entity ADULT_B_COUNTRY_KGT {
            get
            {
                if (ADULT_B_COUNTRY != null)
                {
                    if (_ADULT_B_COUNTRY_KGT == null)
                    {
                        _ADULT_B_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(ADULT_B_COUNTRY);
                    }
                    return _ADULT_B_COUNTRY_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ZEROMTH_CAT] => [KGG_Entity].[KGGKEY]
        /// MIPS Destination Category on exit
        /// </summary>
        public KGG_Entity ZEROMTH_CAT_KGG {
            get
            {
                if (ZEROMTH_CAT != null)
                {
                    if (_ZEROMTH_CAT_KGG == null)
                    {
                        _ZEROMTH_CAT_KGG = Context.KGG.FindByKGGKEY(ZEROMTH_CAT);
                    }
                    return _ZEROMTH_CAT_KGG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ZEROMTH_CAT_DEST] => [KGD_Entity].[KGDKEY]
        /// MIPS Category & Destination on exit
        /// </summary>
        public KGD_Entity ZEROMTH_CAT_DEST_KGD {
            get
            {
                if (ZEROMTH_CAT_DEST != null)
                {
                    if (_ZEROMTH_CAT_DEST_KGD == null)
                    {
                        _ZEROMTH_CAT_DEST_KGD = Context.KGD.FindByKGDKEY(ZEROMTH_CAT_DEST);
                    }
                    return _ZEROMTH_CAT_DEST_KGD;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BIRTH_COUNTRY] => [KGT_Entity].[COUNTRY]
        /// Country of birth
        /// </summary>
        public KGT_Entity BIRTH_COUNTRY_KGT {
            get
            {
                if (BIRTH_COUNTRY != null)
                {
                    if (_BIRTH_COUNTRY_KGT == null)
                    {
                        _BIRTH_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(BIRTH_COUNTRY);
                    }
                    return _BIRTH_COUNTRY_KGT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [HOME_LANG] => [KGL_Entity].[KGLKEY]
        /// The language spoken at home
        /// </summary>
        public KGL_Entity HOME_LANG_KGL {
            get
            {
                if (HOME_LANG != null)
                {
                    if (_HOME_LANG_KGL == null)
                    {
                        _HOME_LANG_KGL = Context.KGL.FindByKGLKEY(HOME_LANG);
                    }
                    return _HOME_LANG_KGL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SIXMTH_CAT] => [KGG_Entity].[KGGKEY]
        /// MIPS Destination Category after 6 months
        /// </summary>
        public KGG_Entity SIXMTH_CAT_KGG {
            get
            {
                if (SIXMTH_CAT != null)
                {
                    if (_SIXMTH_CAT_KGG == null)
                    {
                        _SIXMTH_CAT_KGG = Context.KGG.FindByKGGKEY(SIXMTH_CAT);
                    }
                    return _SIXMTH_CAT_KGG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SIXMTH_CAT_DEST] => [KGD_Entity].[KGDKEY]
        /// MIPS Category & Destination after six month
        /// </summary>
        public KGD_Entity SIXMTH_CAT_DEST_KGD {
            get
            {
                if (SIXMTH_CAT_DEST != null)
                {
                    if (_SIXMTH_CAT_DEST_KGD == null)
                    {
                        _SIXMTH_CAT_DEST_KGD = Context.KGD.FindByKGDKEY(SIXMTH_CAT_DEST);
                    }
                    return _SIXMTH_CAT_DEST_KGD;
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
