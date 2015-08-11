using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Membership Eligibility Criteria
    /// </summary>
    public class SGSG_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of group for which this is a criterion [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGSGKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SGSGKEY] => [SG_Entity].[SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG_Entity SGSGKEY_SG { get { return SGSGKEY == null ? null : Context.SG.FindBySGKEY(SGSGKEY); } }
        /// <summary>
        /// Code of group membership of which is a criterion for membership in group SGSGKEY [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGLINK { get; internal set; }
        /// <summary>
        /// Navigation property for [SGLINK] => [SG_Entity].[SGKEY]
        /// Code of group membership of which is a criterion for membership in group SGSGKEY
        /// </summary>
        public SG_Entity SGLINK_SG { get { return SGLINK == null ? null : Context.SG.FindBySGKEY(SGLINK); } }
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
