using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Links URL
    /// </summary>
    public class SEC_URL : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int SCHOOLURLID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string LINKNAME { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (200)]
        /// </summary>
        public string MAINURL { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
