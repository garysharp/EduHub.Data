using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Grid Templates
    /// </summary>
    public class TT_Entity : EntityBase
    {
        /// <summary>
        /// Template code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TTKEY { get; internal set; }
        /// <summary>
        /// Template title [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Can this template be selected by general users [Alphanumeric: a1]
        /// </summary>
        public string SELECTABLE { get; internal set; }
        /// <summary>
        /// Campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG01 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG02 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG03 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG04 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG05 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG06 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG07 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG08 { get; internal set; }
        /// <summary>
        /// Timetable reference tags [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TAG09 { get; internal set; }
        /// <summary>
        /// Subject levy billing period (eg 199703 represents 97 term 3) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERIOD { get; internal set; }
        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TTPERIOD { get; internal set; }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR01 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR01] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR01_KCY { get { return SUBJECT_ACADEMIC_YEAR01 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR01); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR02 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR02] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR02_KCY { get { return SUBJECT_ACADEMIC_YEAR02 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR02); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR03 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR03] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR03_KCY { get { return SUBJECT_ACADEMIC_YEAR03 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR03); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR04 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR04] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR04_KCY { get { return SUBJECT_ACADEMIC_YEAR04 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR04); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR05 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR05] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR05_KCY { get { return SUBJECT_ACADEMIC_YEAR05 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR05); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR06 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR06] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR06_KCY { get { return SUBJECT_ACADEMIC_YEAR06 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR06); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR07 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR07] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR07_KCY { get { return SUBJECT_ACADEMIC_YEAR07 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR07); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR08 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR08] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR08_KCY { get { return SUBJECT_ACADEMIC_YEAR08 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR08); } }
        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR09 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR09] => [KCY_Entity].[KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR09_KCY { get { return SUBJECT_ACADEMIC_YEAR09 == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR09); } }
        /// <summary>
        /// Semester/term/quarter: if SEMESTER in an SU record is zero or matches this value, the subject is eligible for this template [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// Timetabling year/semester when this reserve subject should be available [Uppercase Alphanumeric: u8]
        /// </summary>
        public string RESERVE { get; internal set; }
        /// <summary>
        /// Student course set [Uppercase Alphanumeric: u8]
        /// </summary>
        public string COSET { get; internal set; }
        /// <summary>
        /// Maximum number of grid rows (lines) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXROW { get; internal set; }
        /// <summary>
        /// Maximum number of grid columns [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXCOL { get; internal set; }
        /// <summary>
        /// Relax value [Integer (16bit signed nullable): i]
        /// </summary>
        public short? RELAX { get; internal set; }
        /// <summary>
        /// Maximum number of drop-outs allowed [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXDROP { get; internal set; }
        /// <summary>
        /// Maximum number of solutions to store [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXSTORE { get; internal set; }
        /// <summary>
        /// Use teacher clashes? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string UTEACH { get; internal set; }
        /// <summary>
        /// Use room clashes? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string UROOM { get; internal set; }
        /// <summary>
        /// Use resource clashes? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string URESOURCES { get; internal set; }
        /// <summary>
        /// Use fixed grid? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string UFIXED { get; internal set; }
        /// <summary>
        /// Use linked subjects? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ULINKS { get; internal set; }
        /// <summary>
        /// Use tied subjects? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string UTIED { get; internal set; }
        /// <summary>
        /// Use min/maxline ranges? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string URANGE { get; internal set; }
        /// <summary>
        /// Strategy: High, Low, Both, All, Exhaustive, Reduction [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STRATEGY { get; internal set; }
        /// <summary>
        /// Sort subjects on grid line? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GRIDSORT { get; internal set; }
        /// <summary>
        /// Student put in smallest available set? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SHARE { get; internal set; }
        /// <summary>
        /// Students rearranged if set allocated to is full? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SHUFFLE { get; internal set; }
        /// <summary>
        /// Method of placing unit subjects into solution grid (don't use units/use units with placement restrictions/use units without placement restrictions) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string UUNITS { get; internal set; }
        /// <summary>
        ///  [Grid (byte array): bg]
        /// </summary>
        public byte[] GSOLS { get; internal set; }
        /// <summary>
        /// Added Dec 1997 [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HOMEGRID { get; internal set; }
        /// <summary>
        /// User value for priority of clash [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHER_CLASH_FACTOR { get; internal set; }
        /// <summary>
        /// (The higher the number the less [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ROOM_CLASH_FACTOR { get; internal set; }
        /// <summary>
        /// likely that item will clash) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? RESOURCE_CLASH_FACTOR { get; internal set; }
        /// <summary>
        /// (Student max 9, rest 999) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? STUDENT_DROP_FACTOR { get; internal set; }
        /// <summary>
        /// Default for TTTG.MAXIMUM [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAX_CLASS_SIZE { get; internal set; }
        /// <summary>
        /// Maximum teacher clashes for a quilt generated grid [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXTCLASH { get; internal set; }
        /// <summary>
        /// Maximum room clashes for a quilt generated grid [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXRCLASH { get; internal set; }
        /// <summary>
        /// Maximum resource clashes for a quilt generated grid [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXXCLASH { get; internal set; }
        /// <summary>
        /// Maximum balance factor for a quilt generated grid [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXBALANCE { get; internal set; }
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
