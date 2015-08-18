using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations
    /// </summary>
    public class KGD : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Combination of KGG.KGGKEY and Destination
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KGDKEY { get; internal set; }
        /// <summary>
        /// Description of destination
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Description of category (to aid selection from moroinfo)
        /// [Alphanumeric (50)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Is this Destination open or closed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OPEN_CLOSED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
