using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Billing Template Transactions
    /// </summary>
    public class SABT_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SABTKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SABTKEY] => [SAB_Entity].[SABKEY]
        /// Key
        /// </summary>
        public SAB_Entity SABTKEY_SAB { get { return SABTKEY == null ? null : Context.SAB.FindBySABKEY(SABTKEY); } }
        /// <summary>
        /// Link [Uppercase Alphanumeric: u10]
        /// </summary>
        public string LINKKEY { get; internal set; }
        /// <summary>
        /// Fee code for the student [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FEE_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [FEE_CODE] => [SA_Entity].[SAKEY]
        /// Fee code for the student
        /// </summary>
        public SA_Entity FEE_CODE_SA { get { return FEE_CODE == null ? null : Context.SA.FindBySAKEY(FEE_CODE); } }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
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
