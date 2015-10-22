using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Billing Template Transactions
    /// </summary>
    public partial class SABT : EntityBase
    {
#region Navigation Property Cache
        private SAB _SABTKEY_SAB;
        private SA _FEE_CODE_SA;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
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
                if (SABTKEY != null)
                {
                    if (_SABTKEY_SAB == null)
                    {
                        _SABTKEY_SAB = Context.SAB.FindBySABKEY(SABTKEY);
                    }
                    return _SABTKEY_SAB;
                }
                else
                {
                    return null;
                }
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
                if (FEE_CODE != null)
                {
                    if (_FEE_CODE_SA == null)
                    {
                        _FEE_CODE_SA = Context.SA.FindBySAKEY(FEE_CODE);
                    }
                    return _FEE_CODE_SA;
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
