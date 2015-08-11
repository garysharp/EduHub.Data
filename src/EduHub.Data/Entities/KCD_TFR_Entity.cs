using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCD Transfer
    /// </summary>
    public class KCD_TFR_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Orignating School [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }
        /// <summary>
        /// Navigation property for [ORIG_SCHOOL] => [SKGS_Entity].[SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS_Entity ORIG_SCHOOL_SKGS { get { return ORIG_SCHOOL == null ? null : Context.SKGS.FindBySCHOOL(ORIG_SCHOOL); } }
        /// <summary>
        /// Unique DF Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string KCD_TRANS_ID { get; internal set; }
        /// <summary>
        /// Doctor code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KCDKEY { get; internal set; }
        /// <summary>
        /// New Doctor Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KCDKEY_NEW { get; internal set; }
        /// <summary>
        /// Name of doctor or practice [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Individual or Group practice [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DR_GROUP { get; internal set; }
        /// <summary>
        /// Two address lines [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb [Alphanumeric: a30]
        /// </summary>
        public string SUBURB { get; internal set; }
        /// <summary>
        /// State code [Uppercase Alphanumeric: u3]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Postcode [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Phone no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Fax no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string FAX { get; internal set; }
        /// <summary>
        /// Link to KAP to allow for access to postcodes when entering an address: NOTE this should NOT be a foreign key to KAP as the user is free to enter different data in ADDRESS03 and POSTCODE [Alphanumeric: a34]
        /// </summary>
        public string KAP_LINK { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a34]
        /// </summary>
        public string KAP_LINK_NEW { get; internal set; }
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
        
        
    }
}
