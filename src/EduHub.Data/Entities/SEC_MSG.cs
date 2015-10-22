using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Message
    /// </summary>
    public partial class SEC_MSG : EntityBase
    {
#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int SCHOOLMSGID { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string MSGTEXT { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string EDITBYUSERID { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EDITDATE { get; internal set; }
#endregion
    }
}
