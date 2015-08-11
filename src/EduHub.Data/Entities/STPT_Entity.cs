using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Part-Time Enrolments
    /// </summary>
    public class STPT_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STPTKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [STPTKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STPTKEY_ST { get { return STPTKEY == null ? null : Context.ST.FindBySTKEY(STPTKEY); } }
        /// <summary>
        /// ID of school (could be home school) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string SCHL_NUM { get; internal set; }
        /// <summary>
        /// Navigation property for [SCHL_NUM] => [SKGS_Entity].[SCHOOL]
        /// ID of school (could be home school)
        /// </summary>
        public SKGS_Entity SCHL_NUM_SKGS { get { return SCHL_NUM == null ? null : Context.SKGS.FindBySCHOOL(SCHL_NUM); } }
        /// <summary>
        /// Time fraction SRP funding for current calendar year [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SGB_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Time fraction of student's attendance [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ACTUAL_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Is this school claiming this student for SRP funding [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENROLLED { get; internal set; }
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
