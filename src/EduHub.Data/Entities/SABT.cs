using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Billing Template Transactions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SABT : EduHubEntity
    {

        #region Navigation Property Cache

        private SAB Cache_SABTKEY_SAB;
        private SA Cache_FEE_CODE_SA;

        #endregion

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SABTKEY { get; internal set; }

        /// <summary>
        /// Link
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string LINKKEY { get; internal set; }

        /// <summary>
        /// Fee code for the student
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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
        /// SAB (Fees - Billing Templates) related entity by [SABT.SABTKEY]-&gt;[SAB.SABKEY]
        /// Key
        /// </summary>
        public SAB SABTKEY_SAB
        {
            get
            {
                if (Cache_SABTKEY_SAB == null)
                {
                    Cache_SABTKEY_SAB = Context.SAB.FindBySABKEY(SABTKEY);
                }

                return Cache_SABTKEY_SAB;
            }
        }

        /// <summary>
        /// SA (Fees) related entity by [SABT.FEE_CODE]-&gt;[SA.SAKEY]
        /// Fee code for the student
        /// </summary>
        public SA FEE_CODE_SA
        {
            get
            {
                if (FEE_CODE == null)
                {
                    return null;
                }
                if (Cache_FEE_CODE_SA == null)
                {
                    Cache_FEE_CODE_SA = Context.SA.FindBySAKEY(FEE_CODE);
                }

                return Cache_FEE_CODE_SA;
            }
        }

        #endregion

    }
}
