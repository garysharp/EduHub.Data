using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Association Member Attendances
    /// </summary>
    public class SAMA_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// ID of school association member [Integer (32bit signed nullable): l]
        /// </summary>
        public int? SAMAKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SAMAKEY] => [SAM_Entity].[SAMKEY]
        /// ID of school association member
        /// </summary>
        public SAM_Entity SAMAKEY_SAM { get { return SAMAKEY.HasValue ? Context.SAM.FindBySAMKEY(SAMAKEY.Value) : null; } }
        /// <summary>
        /// ID of school association meeting [Integer (32bit signed nullable): l]
        /// </summary>
        public int? SCAM_TID { get; internal set; }
        /// <summary>
        /// Attended? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ATTENDED { get; internal set; }
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
