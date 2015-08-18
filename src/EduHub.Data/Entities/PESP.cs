using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super Payment Transactions
    /// </summary>
    public class PESP : EntityBase
    {
#region Navigation Property Cache
        private PE _CODE_PE;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (unique)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// "G" = SGC levy "U" = Personal super Added for Aegis 7247
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Superannuation fund
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Date payment was made, eg cheque date
        /// </summary>
        public DateTime? PAYMENT_DATE { get; internal set; }
        /// <summary>
        /// Superannuation payment amount
        /// </summary>
        public decimal? PAYMENT_AMOUNT { get; internal set; }
        /// <summary>
        /// Start date the super payment relates to
        /// </summary>
        public DateTime? SUPER_FROM_DATE { get; internal set; }
        /// <summary>
        /// To date the super payment relates to
        /// </summary>
        public DateTime? SUPER_TO_DATE { get; internal set; }
        /// <summary>
        /// Date payment details were entered into
        /// </summary>
        public DateTime? PROCESS_DATE { get; internal set; }
        /// <summary>
        /// Date employee advised
        /// </summary>
        public DateTime? DATE_ADVISED { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [PE].[PEKEY]
        /// Employee code
        /// </summary>
        public PE CODE_PE {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_PE == null)
                    {
                        _CODE_PE = Context.PE.FindByPEKEY(CODE);
                    }
                    return _CODE_PE;
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
