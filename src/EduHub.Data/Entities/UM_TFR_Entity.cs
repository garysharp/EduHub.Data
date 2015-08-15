using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// UM Transfer
    /// </summary>
    public class UM_TFR_Entity : EntityBase
    {
#region Navigation Property Cache
        private SKGS_Entity _ORIG_SCHOOL_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Orignating School [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }
        /// <summary>
        /// Unique UM Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string UM_TRANS_ID { get; internal set; }
        /// <summary>
        /// Address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? UMKEY { get; internal set; }
        /// <summary>
        /// New UMKEY [Integer (32bit signed nullable): l]
        /// </summary>
        public int? UMKEY_NEW { get; internal set; }
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
        /// Current Status of Import [Uppercase Alphanumeric: u15]
        /// </summary>
        public string IMP_STATUS { get; internal set; }
        /// <summary>
        /// Actual Date data transfered into live table [Date Time nullable: d]
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }
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
        /// Navigation property for [ORIG_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS_Entity ORIG_SCHOOL_SKGS {
            get
            {
                if (ORIG_SCHOOL != null)
                {
                    if (_ORIG_SCHOOL_SKGS == null)
                    {
                        _ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                    }
                    return _ORIG_SCHOOL_SKGS;
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
