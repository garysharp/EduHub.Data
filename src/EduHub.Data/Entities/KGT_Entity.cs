using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries
    /// </summary>
    public class KGT_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Country code [Uppercase Alphanumeric: u6]
        /// </summary>
        public string COUNTRY { get; internal set; }
        /// <summary>
        /// Country description [Alphanumeric: a40]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Indicates whether English is the country's first language (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENGLISH_SPEAKING { get; internal set; }
        /// <summary>
        /// Numeric "Standard Australian Classification of Countries" code as defined by Australian Bureau of Statistics [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SACC { get; internal set; }
        /// <summary>
        /// Is this code obsolete (no longer in use)? (Y/blank) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OBSOLETE { get; internal set; }
        /// <summary>
        /// Identifies if Country is a refugee type for EAL (refer Aegis 7210). [Uppercase Alphanumeric: u1]
        /// </summary>
        public string REFUGEE { get; internal set; }
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
