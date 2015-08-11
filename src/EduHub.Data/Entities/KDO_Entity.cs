using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains
    /// </summary>
    public class KDO_Entity : EntityBase
    {
        /// <summary>
        /// Key of the domain [Uppercase Alphanumeric: u5]
        /// </summary>
        public string KDOKEY { get; internal set; }
        /// <summary>
        /// Description as per VACC [Alphanumeric: a255]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// First year.semester of AusVELS curriculum e.g. 2013.1 [Alphanumeric: a6]
        /// </summary>
        public string AUSVELS_START { get; internal set; }
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
