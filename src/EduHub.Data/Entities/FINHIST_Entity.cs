using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial History
    /// </summary>
    public class FINHIST_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// SQL identity [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        /// Table where change was made eg CR, DF [Alphanumeric: a10]
        /// </summary>
        public string LEDGER { get; internal set; }
        /// <summary>
        /// ID of entity [Alphanumeric: a10]
        /// </summary>
        public string ENTITY { get; internal set; }
        /// <summary>
        /// transaction ID if necessary [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRANSACTION_ID { get; internal set; }
        /// <summary>
        /// Bank/State/Branch number [Alphanumeric: a6]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank Account Number [Alphanumeric: a15]
        /// </summary>
        public string ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Bank Account Name [Alphanumeric: a60]
        /// </summary>
        public string ACCOUNT_NAME { get; internal set; }
        /// <summary>
        /// BPAY biller code [Alphanumeric: a10]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// BPAY reference [Alphanumeric: a20]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Historical date/time when record was created [Date Time nullable: d]
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }
        /// <summary>
        /// Last write time - might be updated if entity changes due to a change of ID [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
