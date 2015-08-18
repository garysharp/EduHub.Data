using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages
    /// </summary>
    public class KGL : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Language code
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string KGLKEY { get; internal set; }
        /// <summary>
        /// Long description
        /// [Alphanumeric (75)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Are standard notices available in this language? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NOTICES_AVAILABLE { get; internal set; }
        /// <summary>
        /// Numeric "Australian Standard Classification of Languages" as defined by Australian Bureau of Statistics
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ASCL { get; internal set; }
        /// <summary>
        /// CASES code to be used when returning data to Census
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string CASESKEY { get; internal set; }
        /// <summary>
        /// Is KGLKEY the code to which CASESKEY should be converted in converting from CASES to CASES21? (Y/blank)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CASES_CASES21_CONV { get; internal set; }
        /// <summary>
        /// Is this code obsolete (no longer in use)? (Y/blank)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OBSOLETE { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
