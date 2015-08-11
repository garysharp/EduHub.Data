using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject/Class Eligibility Criteria
    /// </summary>
    public class SGSC_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of group for which this is a criterion [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGSCKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SGSCKEY] => [SG_Entity].[SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG_Entity SGSCKEY_SG { get { return SGSCKEY == null ? null : Context.SG.FindBySGKEY(SGSCKEY); } }
        /// <summary>
        /// Code of subject which is a criterion for membership in group SGSGKEY [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SULINK { get; internal set; }
        /// <summary>
        /// Navigation property for [SULINK] => [SU_Entity].[SUKEY]
        /// Code of subject which is a criterion for membership in group SGSGKEY
        /// </summary>
        public SU_Entity SULINK_SU { get { return SULINK == null ? null : Context.SU.FindBySUKEY(SULINK); } }
        /// <summary>
        /// Code of class which is a criterion for membership in group SGSGKEY [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TTPERIOD { get; internal set; }
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
