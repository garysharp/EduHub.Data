using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Billing Template Transactions
    /// </summary>
    public class SABT_Entity : EntityBase
    {
#region Navigation Property Cache
        private SAB_Entity _SABTKEY_SAB;
        private SA_Entity _FEE_CODE_SA;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SABTKEY { get; internal set; }
        /// <summary>
        /// Link [Uppercase Alphanumeric: u10]
        /// </summary>
        public string LINKKEY { get; internal set; }
        /// <summary>
        /// Fee code for the student [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FEE_CODE { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SABTKEY] => [SAB_Entity].[SABKEY]
        /// Key
        /// </summary>
        public SAB_Entity SABTKEY_SAB {
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
        /// Navigation property for [FEE_CODE] => [SA_Entity].[SAKEY]
        /// Fee code for the student
        /// </summary>
        public SA_Entity FEE_CODE_SA {
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
