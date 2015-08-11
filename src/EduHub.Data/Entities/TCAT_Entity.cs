using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types
    /// </summary>
    public class TCAT_Entity : EntityBase
    {
        /// <summary>
        /// Staff Absence Type Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TCATKEY { get; internal set; }
        /// <summary>
        /// Staff Absence Type Title [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
