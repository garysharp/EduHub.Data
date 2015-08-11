using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Error Log
    /// </summary>
    public class SEC_ELOG_Entity : EntityBase
    {
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ERRORCOUNT { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u255]
        /// </summary>
        public string ERRORDESCRIPTION { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u50]
        /// </summary>
        public string ERRORTYPE { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? ERRORTIME { get; internal set; }
        
        
    }
}
