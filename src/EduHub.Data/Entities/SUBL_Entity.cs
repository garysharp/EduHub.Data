using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Book List
    /// </summary>
    public class SUBL_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string BLKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [BLKEY] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity BLKEY_SU { get { return BLKEY == null ? null : Context.SU.FindBySUKEY(BLKEY); } }
        /// <summary>
        /// Book ISBN identifier [Uppercase Alphanumeric: u13]
        /// </summary>
        public string BOOK { get; internal set; }
        /// <summary>
        /// Navigation property for [BOOK] => [BKH_Entity].[BKHKEY]
        /// Book ISBN identifier
        /// </summary>
        public BKH_Entity BOOK_BKH { get { return BOOK == null ? null : Context.BKH.FindByBKHKEY(BOOK); } }
        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string TTPERIOD { get; internal set; }
        /// <summary>
        /// Tag required [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TAG { get; internal set; }
        /// <summary>
        /// Semester required [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// Number of items required [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_REQUIRED { get; internal set; }
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
