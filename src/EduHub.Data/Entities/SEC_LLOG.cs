using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Login Log
    /// </summary>
    public partial class SEC_LLOG : EntityBase
    {
#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int LOGINLOGID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string SERVER { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string VERSION { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string USERID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (150)]
        /// </summary>
        public string USERNAME { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (100)]
        /// </summary>
        public string BROWSER { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SCREENSIZE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string RESULT { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (16)]
        /// </summary>
        public string IPADDRESS { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (50)]
        /// </summary>
        public string SESSIONID { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? LOGGEDOUT { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LOGINTIME { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LOGOUTTIME { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? LOGGEDPERIOD { get; internal set; }
#endregion
    }
}
