using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account
    /// </summary>
    public class KBANK : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// General Ledger code (Prime Key)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Bank account description
        /// [Alphanumeric (25)]
        /// </summary>
        public string GLTITLE { get; internal set; }
        /// <summary>
        /// BPAY Biller code
        /// [Alphanumeric (10)]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// Bank name
        /// [Alphanumeric (23)]
        /// </summary>
        public string BANK_NAME { get; internal set; }
        /// <summary>
        /// Branch of Bank
        /// [Alphanumeric (25)]
        /// </summary>
        public string BANK_BRANCH { get; internal set; }
        /// <summary>
        /// Bank branch address (2 lines)
        /// [Alphanumeric (30)]
        /// </summary>
        public string BANK_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Bank branch address (2 lines)
        /// [Alphanumeric (30)]
        /// </summary>
        public string BANK_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Bank account name
        /// [Alphanumeric (45)]
        /// </summary>
        public string BANK_ACCOUNT_NAME { get; internal set; }
        /// <summary>
        /// Bank account BSB number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BANK_ACCOUNT_BSB { get; internal set; }
        /// <summary>
        /// Bank account number
        /// [Alphanumeric (15)]
        /// </summary>
        public string BANK_ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Bank Abbreviation for
        /// Direct Deposits
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string BANK_ABBREVIATION { get; internal set; }
        /// <summary>
        /// Bank nominated user ID Number for
        /// Direct Deposits
        /// [Alphanumeric (6)]
        /// </summary>
        public string APCA_NUMBER { get; internal set; }
        /// <summary>
        /// Direct Credit file to balance to
        /// zero
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BALANCE_ENTRY { get; internal set; }
        /// <summary>
        /// Check for bank reconciliation
        /// </summary>
        public DateTime? LAST_RECONCILE_DATE { get; internal set; }
        /// <summary>
        /// Check for bank reconciliation
        /// </summary>
        public decimal? LAST_RECONCILE_DIFF { get; internal set; }
        /// <summary>
        /// Depended on GL code being active or not
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
#endregion
    }
}
