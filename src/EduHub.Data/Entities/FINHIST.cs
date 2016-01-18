using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial History
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FINHIST : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// SQL identity
        /// </summary>
        public int ID { get; internal set; }

        /// <summary>
        /// Table where change was made eg CR, DF
        /// [Alphanumeric (10)]
        /// </summary>
        public string LEDGER { get; internal set; }

        /// <summary>
        /// ID of entity
        /// [Alphanumeric (10)]
        /// </summary>
        public string ENTITY { get; internal set; }

        /// <summary>
        /// transaction ID if necessary
        /// </summary>
        public int? TRANSACTION_ID { get; internal set; }

        /// <summary>
        /// Bank/State/Branch number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }

        /// <summary>
        /// Bank Account Number
        /// [Alphanumeric (15)]
        /// </summary>
        public string ACCOUNT_NO { get; internal set; }

        /// <summary>
        /// Bank Account Name
        /// [Alphanumeric (60)]
        /// </summary>
        public string ACCOUNT_NAME { get; internal set; }

        /// <summary>
        /// BPAY biller code
        /// [Alphanumeric (10)]
        /// </summary>
        public string BILLER_CODE { get; internal set; }

        /// <summary>
        /// BPAY reference
        /// [Alphanumeric (20)]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }

        /// <summary>
        /// Historical date/time when record was created
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }

        /// <summary>
        /// Last write time - might be updated if entity changes due to a change of ID
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
