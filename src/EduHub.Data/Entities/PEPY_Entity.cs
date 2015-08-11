using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee History
    /// </summary>
    public class PEPY_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (unique) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [PE_Entity].[PEKEY]
        /// Employee code
        /// </summary>
        public PE_Entity CODE_PE { get { return CODE == null ? null : Context.PE.FindByPEKEY(CODE); } }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? TRANSDATE { get; internal set; }
        /// <summary>
        /// Originator [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Generic purpose for notes [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PURPOSE { get; internal set; }
        /// <summary>
        /// Navigation property for [PURPOSE] => [KPN_Entity].[KPNKEY]
        /// Generic purpose for notes
        /// </summary>
        public KPN_Entity PURPOSE_KPN { get { return PURPOSE == null ? null : Context.KPN.FindByKPNKEY(PURPOSE); } }
        /// <summary>
        /// Employee notes
        ///  [Memo: m]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last user name [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
