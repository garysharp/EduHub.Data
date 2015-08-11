using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medication Doses
    /// </summary>
    public class SMCD_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Medical condition ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? SMCDKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SMCDKEY] => [SMC_Entity].[SMCKEY]
        /// Medical condition ID
        /// </summary>
        public SMC_Entity SMCDKEY_SMC { get { return SMCDKEY.HasValue ? Context.SMC.FindBySMCKEY(SMCDKEY.Value) : null; } }
        /// <summary>
        /// Staff code of staff member who administered dosage (if any) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Navigation property for [STAFF] => [SF_Entity].[SFKEY]
        /// Staff code of staff member who administered dosage (if any)
        /// </summary>
        public SF_Entity STAFF_SF { get { return STAFF == null ? null : Context.SF.FindBySFKEY(STAFF); } }
        /// <summary>
        /// Date administered [Date Time nullable: d]
        /// </summary>
        public DateTime? ADMIN_DATE { get; internal set; }
        /// <summary>
        /// Time administered [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ADMIN_TIME { get; internal set; }
        /// <summary>
        /// Dose administered [Alphanumeric: a30]
        /// </summary>
        public string DOSE { get; internal set; }
        /// <summary>
        /// Person who administered dosage (if not staff) [Alphanumeric: a30]
        /// </summary>
        public string ADMIN_BY_OTHER { get; internal set; }
        /// <summary>
        /// Ad hoc notes [Memo: m]
        /// </summary>
        public string ADMIN_NOTES { get; internal set; }
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
