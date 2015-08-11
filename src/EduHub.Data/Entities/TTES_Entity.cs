using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Subjects
    /// </summary>
    public class TTES_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Grid involved in exam [Uppercase Alphanumeric: u8]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [GKEY] => [TT_Entity].[TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT_Entity GKEY_TT { get { return GKEY == null ? null : Context.TT.FindByTTKEY(GKEY); } }
        /// <summary>
        /// Exam grid to which this subject belongs [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TTEI_TID { get; internal set; }
        /// <summary>
        /// Subject [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ] => [SU_Entity].[SUKEY]
        /// Subject
        /// </summary>
        public SU_Entity SUBJ_SU { get { return SUBJ == null ? null : Context.SU.FindBySUKEY(SUBJ); } }
        /// <summary>
        /// Number of times examined [Integer (16bit signed nullable): i]
        /// </summary>
        public short? UNITS { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE01 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE02 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE03 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE04 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE05 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE06 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE07 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE08 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE09 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE10 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE11 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE12 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE13 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE14 { get; internal set; }
        /// <summary>
        /// Include up to 15 classes (INLIST) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string INCLUDE15 { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
