using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations
    /// </summary>
    public class KGD_Entity : EntityBase
    {
        /// <summary>
        /// Combination of KGG.KGGKEY and Destination [Uppercase Alphanumeric: u6]
        /// </summary>
        public string KGDKEY { get; internal set; }
        /// <summary>
        /// Description of destination [Alphanumeric: a50]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Description of category (to aid selection from moroinfo) [Alphanumeric: a50]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Is this Destination open or closed [Uppercase Alphanumeric: u1]
        /// </summary>
        public string OPEN_CLOSED { get; internal set; }
        
        
    }
}
