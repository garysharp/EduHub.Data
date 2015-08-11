using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Login Log
    /// </summary>
    public class SEC_LLOG_Entity : EntityBase
    {
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int LOGINLOGID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u50]
        /// </summary>
        public string SERVER { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string VERSION { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u50]
        /// </summary>
        public string USERID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u150]
        /// </summary>
        public string USERNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u100]
        /// </summary>
        public string BROWSER { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SCREENSIZE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u20]
        /// </summary>
        public string RESULT { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u16]
        /// </summary>
        public string IPADDRESS { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u50]
        /// </summary>
        public string SESSIONID { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LOGGEDOUT { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LOGINTIME { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LOGOUTTIME { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LOGGEDPERIOD { get; internal set; }
        
        
    }
}
