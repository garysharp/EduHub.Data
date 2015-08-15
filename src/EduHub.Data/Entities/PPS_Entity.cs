using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Supplier Details
    /// </summary>
    public class PPS_Entity : EntityBase
    {
#region Navigation Property Cache
        private KGT_Entity _COUNTRY_KGT;
        private KGT_Entity _POSTAL_COUNTRY_KGT;
#endregion

#region Field Properties
        /// <summary>
        /// Supplier code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PPSKEY { get; internal set; }
        /// <summary>
        /// ABN Number of the Supplier [Uppercase Alphanumeric: u11]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Supplier Name [Uppercase Alphanumeric: u76]
        /// </summary>
        public string NAME { get; internal set; }
        /// <summary>
        /// Supplier contact name [Uppercase Alphanumeric: u38]
        /// </summary>
        public string CONTACT_NAME { get; internal set; }
        /// <summary>
        /// Supplier contact telephone or mobile number [Uppercase Alphanumeric: u15]
        /// </summary>
        public string CONTACT_PHONE { get; internal set; }
        /// <summary>
        /// Supplier facsimile number [Uppercase Alphanumeric: u15]
        /// </summary>
        public string FACSIMILE { get; internal set; }
        /// <summary>
        /// Supplier file reference [Uppercase Alphanumeric: u16]
        /// </summary>
        public string FILE_REFERENCE { get; internal set; }
        /// <summary>
        /// Supplier street address line 1 [Uppercase Alphanumeric: u38]
        /// </summary>
        public string L1_ADDRESS { get; internal set; }
        /// <summary>
        /// Supplier street address line 2 [Uppercase Alphanumeric: u38]
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
        /// Postcode [Uppercase Alphanumeric: u4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Country [Uppercase Alphanumeric: u6]
        /// </summary>
        public string COUNTRY { get; internal set; }
        /// <summary>
        /// Supplier postal address line 1 [Uppercase Alphanumeric: u38]
        /// </summary>
        public string POSTAL_L1_ADD { get; internal set; }
        /// <summary>
        /// Supplier postal address line 2 [Uppercase Alphanumeric: u38]
        /// </summary>
        public string POSTAL_L2_ADD { get; internal set; }
        /// <summary>
        /// Supplier postal Suburb, town, city [Uppercase Alphanumeric: u27]
        /// </summary>
        public string POSTAL_SUBURB { get; internal set; }
        /// <summary>
        /// Supplier postal State or territory [Uppercase Alphanumeric: u3]
        /// </summary>
        public string POSTAL_STATE { get; internal set; }
        /// <summary>
        /// Supplier postal Postcode [Uppercase Alphanumeric: u4]
        /// </summary>
        public string POSTAL_POSTCODE { get; internal set; }
        /// <summary>
        /// Supplier postal Country [Uppercase Alphanumeric: u6]
        /// </summary>
        public string POSTAL_COUNTRY { get; internal set; }
        /// <summary>
        /// Supplier e-mail address [Alphanumeric: a76]
        /// </summary>
        public string EMAIL_ADDRESS { get; internal set; }
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
        /// <summary>
        /// Navigation property for [POSTAL_COUNTRY] => [KGT_Entity].[COUNTRY]
        /// Supplier postal Country
        /// </summary>
        public KGT_Entity POSTAL_COUNTRY_KGT {
            get
            {
                if (POSTAL_COUNTRY != null)
                {
                    if (_POSTAL_COUNTRY_KGT == null)
                    {
                        _POSTAL_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(POSTAL_COUNTRY);
                    }
                    return _POSTAL_COUNTRY_KGT;
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
