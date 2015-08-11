using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCM Transfer
    /// </summary>
    public class KCM_TFR_Entity : EntityBase
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
        /// Unique KCM Transfer ID [Uppercase Alphanumeric: u30]
        /// </summary>
        public string KCM_TRANS_ID { get; internal set; }
        /// <summary>
        /// Medical Condition code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KCMKEY { get; internal set; }
        /// <summary>
        /// New Meidcal Cond code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KCMKEY_NEW { get; internal set; }
        /// <summary>
        /// Long description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
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
