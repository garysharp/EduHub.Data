using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Links URL
    /// </summary>
    public class SEC_URL_Entity : EntityBase
    {
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int SCHOOLURLID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u50]
        /// </summary>
        public string LINKNAME { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u200]
        /// </summary>
        public string MAINURL { get; internal set; }
        
        
    }
}
