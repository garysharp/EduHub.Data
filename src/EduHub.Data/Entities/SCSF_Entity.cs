using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Strands
    /// </summary>
    public class SCSF_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// CSF Outcome Code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SCSFKEY { get; internal set; }
        /// <summary>
        /// Key Learning Area description [Alphanumeric: a40]
        /// </summary>
        public string KLA { get; internal set; }
        /// <summary>
        /// Strand description [Titlecase: t40]
        /// </summary>
        public string STRAND { get; internal set; }
        /// <summary>
        /// Sub-strand description [Titlecase: t40]
        /// </summary>
        public string SUB_STRAND { get; internal set; }
        /// <summary>
        /// Is this Strand activated? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ENABLED { get; internal set; }
        /// <summary>
        /// Is assessment of this Strand compulsory for DEECD? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DEET_REQUIRED { get; internal set; }
        /// <summary>
        /// CSF low level (1 to 6) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LOW_LEVEL { get; internal set; }
        /// <summary>
        /// CSF high level(1 to 6) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? HIGH_LEVEL { get; internal set; }
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
#endregion

#region Navigation Properties
#endregion
    }
}
