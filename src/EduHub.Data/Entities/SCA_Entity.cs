using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Associations
    /// </summary>
    public class SCA_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Short name of association [Uppercase Alphanumeric: u15]
        /// </summary>
        public string SCAKEY { get; internal set; }
        /// <summary>
        /// Long name of association [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Date incorporated [Date Time nullable: d]
        /// </summary>
        public DateTime? FIRST_DATE { get; internal set; }
        /// <summary>
        /// Date ceased [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_DATE { get; internal set; }
        /// <summary>
        /// Comments [Memo: m]
        /// </summary>
        public string SCA_MEMO { get; internal set; }
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
#endregion
    }
}
