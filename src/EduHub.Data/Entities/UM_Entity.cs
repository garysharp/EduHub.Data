using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Addresses
    /// </summary>
    public class UM_Entity : EntityBase
    {
#region Navigation Property Cache
        private KGT_Entity _COUNTRY_KGT;
#endregion

#region Field Properties
        /// <summary>
        /// Address ID [Integer (32bit signed): l]
        /// </summary>
        public int UMKEY { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas addresses) [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas addresses) [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas addresses) [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
        /// <summary>
        /// State code (if Australian address) [Uppercase Alphanumeric: u3]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Postcode (if Australian address) [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Phone no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Home Mobile no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// This phone no is silent? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SILENT { get; internal set; }
        /// <summary>
        /// Fax no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string FAX { get; internal set; }
        /// <summary>
        /// Link to KAP to allow for access to postcodes when entering an address: NOTE this should NOT be a foreign key to KAP as the user is free to enter different data in ADDRESS03 and POSTCODE [Alphanumeric: a34]
        /// </summary>
        public string KAP_LINK { get; internal set; }
        /// <summary>
        /// Country (default '1101' code for Australia) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string COUNTRY { get; internal set; }
        /// <summary>
        /// Australia Post address identifier [Integer (32bit signed nullable): l]
        /// </summary>
        public int? DPID { get; internal set; }
        /// <summary>
        /// Australia Post barcode numbers [Alphanumeric: a37]
        /// </summary>
        public string BARCODE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [COUNTRY] => [KGT_Entity].[COUNTRY]
        /// Country (default '1101' code for Australia)
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
