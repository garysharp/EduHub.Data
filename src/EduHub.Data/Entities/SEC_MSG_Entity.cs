using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Message
    /// </summary>
    public class SEC_MSG_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int SCHOOLMSGID { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string MSGTEXT { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string EDITBYUSERID { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? EDITDATE { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
