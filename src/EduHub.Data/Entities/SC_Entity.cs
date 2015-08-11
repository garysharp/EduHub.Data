using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Courses
    /// </summary>
    public class SC_Entity : EntityBase
    {
        /// <summary>
        /// Course code (same type as SU) [Uppercase Alphanumeric: u5]
        /// </summary>
        public string COURSE { get; internal set; }
        /// <summary>
        /// Course name [Alphanumeric: a30]
        /// </summary>
        public string NAME { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ01 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ01] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ01_SU { get { return SUBJ01 == null ? null : Context.SU.FindBySUKEY(SUBJ01); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ02 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ02] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ02_SU { get { return SUBJ02 == null ? null : Context.SU.FindBySUKEY(SUBJ02); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ03 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ03] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ03_SU { get { return SUBJ03 == null ? null : Context.SU.FindBySUKEY(SUBJ03); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ04 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ04] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ04_SU { get { return SUBJ04 == null ? null : Context.SU.FindBySUKEY(SUBJ04); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ05 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ05] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ05_SU { get { return SUBJ05 == null ? null : Context.SU.FindBySUKEY(SUBJ05); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ06 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ06] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ06_SU { get { return SUBJ06 == null ? null : Context.SU.FindBySUKEY(SUBJ06); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ07 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ07] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ07_SU { get { return SUBJ07 == null ? null : Context.SU.FindBySUKEY(SUBJ07); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ08 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ08] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ08_SU { get { return SUBJ08 == null ? null : Context.SU.FindBySUKEY(SUBJ08); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ09 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ09] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ09_SU { get { return SUBJ09 == null ? null : Context.SU.FindBySUKEY(SUBJ09); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ10 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ10] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ10_SU { get { return SUBJ10 == null ? null : Context.SU.FindBySUKEY(SUBJ10); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ11 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ11] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ11_SU { get { return SUBJ11 == null ? null : Context.SU.FindBySUKEY(SUBJ11); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ12 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ12] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ12_SU { get { return SUBJ12 == null ? null : Context.SU.FindBySUKEY(SUBJ12); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ13 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ13] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ13_SU { get { return SUBJ13 == null ? null : Context.SU.FindBySUKEY(SUBJ13); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ14 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ14] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ14_SU { get { return SUBJ14 == null ? null : Context.SU.FindBySUKEY(SUBJ14); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ15 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ15] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ15_SU { get { return SUBJ15 == null ? null : Context.SU.FindBySUKEY(SUBJ15); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ16 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ16] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ16_SU { get { return SUBJ16 == null ? null : Context.SU.FindBySUKEY(SUBJ16); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ17 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ17] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ17_SU { get { return SUBJ17 == null ? null : Context.SU.FindBySUKEY(SUBJ17); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ18 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ18] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ18_SU { get { return SUBJ18 == null ? null : Context.SU.FindBySUKEY(SUBJ18); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ19 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ19] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ19_SU { get { return SUBJ19 == null ? null : Context.SU.FindBySUKEY(SUBJ19); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ20 { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ20] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ20_SU { get { return SUBJ20 == null ? null : Context.SU.FindBySUKEY(SUBJ20); } }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS01 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS02 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS03 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS04 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS05 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS06 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS07 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS08 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS09 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS10 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS11 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS12 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS13 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS14 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS15 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS16 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS17 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS18 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS19 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS20 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK01 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK02 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK03 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK04 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK05 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK06 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK07 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK08 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK09 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK10 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK11 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK12 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK13 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK14 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK15 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK16 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK17 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK18 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK19 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK20 { get; internal set; }
        /// <summary>
        /// Default academic year of subjects [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR] => [KCY_Entity].[KCYKEY]
        /// Default academic year of subjects
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR_KCY { get { return SUBJECT_ACADEMIC_YEAR == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR); } }
        /// <summary>
        /// Default semester of subjsects [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEMESTER { get; internal set; }
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
