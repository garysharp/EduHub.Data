using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Relationship
    /// </summary>
    public class KPCR_Entity : EntityBase
    {
        /// <summary>
        /// Contact relationship Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KPCRKEY { get; internal set; }
        /// <summary>
        /// Contact Relation description
        ///  [Alphanumeric: a30]
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
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
