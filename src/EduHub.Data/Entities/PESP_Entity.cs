using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super Payment Transactions
    /// </summary>
    public class PESP_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (unique) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [PE_Entity].[PEKEY]
        /// Employee code
        /// </summary>
        public PE_Entity CODE_PE { get { return CODE == null ? null : Context.PE.FindByPEKEY(CODE); } }
        /// <summary>
        /// "G" = SGC levy "U" = Personal super Added for Aegis 7247 [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Superannuation fund [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Date payment was made, eg cheque date [Date Time nullable: d]
        /// </summary>
        public DateTime? PAYMENT_DATE { get; internal set; }
        /// <summary>
        /// Superannuation payment amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PAYMENT_AMOUNT { get; internal set; }
        /// <summary>
        /// Start date the super payment relates to [Date Time nullable: d]
        /// </summary>
        public DateTime? SUPER_FROM_DATE { get; internal set; }
        /// <summary>
        /// To date the super payment relates to [Date Time nullable: d]
        /// </summary>
        public DateTime? SUPER_TO_DATE { get; internal set; }
        /// <summary>
        /// Date payment details were entered into [Date Time nullable: d]
        /// </summary>
        public DateTime? PROCESS_DATE { get; internal set; }
        /// <summary>
        /// Date employee advised [Date Time nullable: d]
        /// </summary>
        public DateTime? DATE_ADVISED { get; internal set; }
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
