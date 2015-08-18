using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories
    /// </summary>
    public class KGG : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Category Code
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string KGGKEY { get; internal set; }
        /// <summary>
        /// Description of category
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Reference for sorting
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string EDFLAG_ORDER { get; internal set; }
        /// <summary>
        /// Is this Category open or closed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OPEN_CLOSED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
