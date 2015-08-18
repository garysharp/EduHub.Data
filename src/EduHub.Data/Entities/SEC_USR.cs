using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 User Sessions
    /// </summary>
    public class SEC_USR : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int ROWID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string SESSIONID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string USERID { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DATECREATED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
