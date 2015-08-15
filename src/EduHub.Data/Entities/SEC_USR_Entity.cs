using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 User Sessions
    /// </summary>
    public class SEC_USR_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ROWID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string SESSIONID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u50]
        /// </summary>
        public string USERID { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? DATECREATED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
