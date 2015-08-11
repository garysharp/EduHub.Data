using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored SQL
    /// </summary>
    public class QS_Entity : EntityBase
    {
        /// <summary>
        /// SQL statement ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string QSKEY { get; internal set; }
        /// <summary>
        /// SQL title [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string SQLTEXT { get; internal set; }
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
