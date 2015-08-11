using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Instances
    /// </summary>
    public class TETE_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Owner relation [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TETEKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TETEKEY] => [TE_Entity].[TEKEY]
        /// Owner relation
        /// </summary>
        public TE_Entity TETEKEY_TE { get { return TETEKEY.HasValue ? Context.TE.FindByTEKEY(TETEKEY.Value) : null; } }
        /// <summary>
        /// Event date [Date Time nullable: d]
        /// </summary>
        public DateTime? EVENT_DATE { get; internal set; }
        /// <summary>
        /// Extra comments [Memo: m]
        /// </summary>
        public string COMMENTS { get; internal set; }
        /// <summary>
        /// Start time of event [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_FROM { get; internal set; }
        /// <summary>
        /// End time of event [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_TO { get; internal set; }
        /// <summary>
        /// Person responible for the event [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CONVENOR { get; internal set; }
        /// <summary>
        /// Convenor table name [Uppercase Alphanumeric: u8]
        /// </summary>
        public string CONVENOR_TYPE { get; internal set; }
        /// <summary>
        /// Location of the event [Uppercase Alphanumeric: u4]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Navigation property for [LOCATION] => [SM_Entity].[ROOM]
        /// Location of the event
        /// </summary>
        public SM_Entity LOCATION_SM { get { return LOCATION == null ? null : Context.SM.FindByROOM(LOCATION); } }
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
