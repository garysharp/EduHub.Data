using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fee Groups
    /// </summary>
    public class SDG_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Short name of Fee Group [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SDGKEY { get; internal set; }
        /// <summary>
        /// Long name of Fee Group [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Member Type = Other/Employee/Both [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MEMBER_TYPE { get; internal set; }
        /// <summary>
        /// Comments [Memo: m]
        /// </summary>
        public string SDG_MEMO { get; internal set; }
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
