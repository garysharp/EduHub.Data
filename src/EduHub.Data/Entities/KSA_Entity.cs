using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Areas of Teaching
    /// </summary>
    public class KSA_Entity : EntityBase
    {
        /// <summary>
        /// Code to identify Area of Teaching [Uppercase Alphanumeric: u4]
        /// </summary>
        public string KSAKEY { get; internal set; }
        /// <summary>
        /// Descriptive name [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
