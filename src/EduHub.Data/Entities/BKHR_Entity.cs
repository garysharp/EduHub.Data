using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Book Hire Records
    /// </summary>
    public class BKHR_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Book code of book [Uppercase Alphanumeric: u13]
        /// </summary>
        public string BKHRKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [BKHRKEY] => [BKH_Entity].[BKHKEY]
        /// Book code of book
        /// </summary>
        public BKH_Entity BKHRKEY_BKH { get { return BKHRKEY == null ? null : Context.BKH.FindByBKHKEY(BKHRKEY); } }
        /// <summary>
        /// Copy number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? REF_NUMBER { get; internal set; }
        /// <summary>
        /// Student ID of student making loan [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// Navigation property for [STUDENT] => [ST_Entity].[STKEY]
        /// Student ID of student making loan
        /// </summary>
        public ST_Entity STUDENT_ST { get { return STUDENT == null ? null : Context.ST.FindBySTKEY(STUDENT); } }
        /// <summary>
        /// Staff code of staff member making loan [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Navigation property for [STAFF] => [SF_Entity].[SFKEY]
        /// Staff code of staff member making loan
        /// </summary>
        public SF_Entity STAFF_SF { get { return STAFF == null ? null : Context.SF.FindBySFKEY(STAFF); } }
        /// <summary>
        /// Date of loan [Date Time nullable: d]
        /// </summary>
        public DateTime? ISSUE_DATE { get; internal set; }
        /// <summary>
        /// Date due to be returned [Date Time nullable: d]
        /// </summary>
        public DateTime? DUE_DATE { get; internal set; }
        /// <summary>
        /// Date of return [Date Time nullable: d]
        /// </summary>
        public DateTime? RETURNED_DATE { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string CONDITION { get; internal set; }
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
