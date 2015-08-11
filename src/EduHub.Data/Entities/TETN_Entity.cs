using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Attendees
    /// </summary>
    public class TETN_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Event number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TETNKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TETNKEY] => [TE_Entity].[TEKEY]
        /// Event number
        /// </summary>
        public TE_Entity TETNKEY_TE { get { return TETNKEY.HasValue ? Context.TE.FindByTEKEY(TETNKEY.Value) : null; } }
        /// <summary>
        /// Link to TID of an event instance [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TETELINK { get; internal set; }
        /// <summary>
        /// Attendee type [Uppercase Alphanumeric: u10]
        /// </summary>
        public string ATTENDEE { get; internal set; }
        /// <summary>
        /// Attendee table name [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ATTENDEE_TYPE { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a30]
        /// </summary>
        public string ATTENDEE_DETAIL { get; internal set; }
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
