using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payer Details
    /// </summary>
    public class PPD_Entity : EntityBase
    {
#region Navigation Property Cache
        private KGT_Entity _COUNTRY_KGT;
#endregion

#region Field Properties
        /// <summary>
        /// Payer code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PPDKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Payer Australian Business Number
        /// or Withholding Payer Number [Alphanumeric: a11]
        /// </summary>
        public string ABN_OR_WPN { get; internal set; }
        /// <summary>
        /// Number type A = ABN, W = WPN [Uppercase Alphanumeric: u1]
        /// </summary>
        public string NUMBER_TYPE { get; internal set; }
        /// <summary>
        /// Branch number, for ABN if no branch number
        /// default is 001
        /// for WPN default is 000 [Uppercase Alphanumeric: u3]
        /// </summary>
        public string BRANCH_NUMBER { get; internal set; }
        /// <summary>
        /// Financial year [Uppercase Alphanumeric: u4]
        /// </summary>
        public string FINANCIAL_YEAR { get; internal set; }
        /// <summary>
        /// Payer name as it appears on the
        /// payer's ANB or WPN registration [Uppercase Alphanumeric: u40]
        /// </summary>
        public string NAME { get; internal set; }
        /// <summary>
        /// Payer Trading Name (full name) [Uppercase Alphanumeric: u40]
        /// </summary>
        public string TRADING_NAME { get; internal set; }
        /// <summary>
        /// Payer Address Line 1 [Uppercase Alphanumeric: u38]
        /// </summary>
        public string L1_ADDRESS { get; internal set; }
        /// <summary>
        /// Payer Address Line 2 [Uppercase Alphanumeric: u38]
        /// </summary>
        public string L2_ADDRESS { get; internal set; }
        /// <summary>
        /// Suburb, town, city [Uppercase Alphanumeric: u27]
        /// </summary>
        public string SUBURB { get; internal set; }
        /// <summary>
        /// State or territory [Uppercase Alphanumeric: u3]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Post Code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Country [Uppercase Alphanumeric: u6]
        /// </summary>
        public string COUNTRY { get; internal set; }
        /// <summary>
        /// Contact Name [Uppercase Alphanumeric: u25]
        /// </summary>
        public string CONTACT_NAME { get; internal set; }
        /// <summary>
        /// Contact Telephone Number [Alphanumeric: a15]
        /// </summary>
        public string PHONE { get; internal set; }
        /// <summary>
        /// Contact Facsimile Number [Alphanumeric: a15]
        /// </summary>
        public string FACSIMILE { get; internal set; }
        /// <summary>
        /// Payer Signature [Alphanumeric: a25]
        /// </summary>
        public string SIGNATURE { get; internal set; }
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
        /// Navigation property for [COUNTRY] => [KGT_Entity].[COUNTRY]
        /// Country
        /// </summary>
        public KGT_Entity COUNTRY_KGT {
            get
            {
                if (COUNTRY != null)
                {
                    if (_COUNTRY_KGT == null)
                    {
                        _COUNTRY_KGT = Context.KGT.FindByCOUNTRY(COUNTRY);
                    }
                    return _COUNTRY_KGT;
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
