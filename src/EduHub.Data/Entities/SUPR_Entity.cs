using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Prerequisites
    /// </summary>
    public class SUPR_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Subject code of this subject [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUPRKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SUPRKEY] => [SU_Entity].[SUKEY]
        /// Subject code of this subject
        /// </summary>
        public SU_Entity SUPRKEY_SU { get { return SUPRKEY == null ? null : Context.SU.FindBySUKEY(SUPRKEY); } }
        /// <summary>
        /// Subject code of this subject's prerequisite [Uppercase Alphanumeric: u5]
        /// </summary>
        public string PREREQUISITE { get; internal set; }
        /// <summary>
        /// Navigation property for [PREREQUISITE] => [SU_Entity].[SUKEY]
        /// Subject code of this subject's prerequisite
        /// </summary>
        public SU_Entity PREREQUISITE_SU { get { return PREREQUISITE == null ? null : Context.SU.FindBySUKEY(PREREQUISITE); } }
        /// <summary>
        /// Result as prerequisite (not implemented) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RESULT { get; internal set; }
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
