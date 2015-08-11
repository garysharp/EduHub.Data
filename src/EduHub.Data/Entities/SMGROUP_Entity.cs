using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms group
    /// </summary>
    public class SMGROUP_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Group key in SM [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GROUPKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [GROUPKEY] => [SM_Entity].[ROOM]
        /// Group key in SM
        /// </summary>
        public SM_Entity GROUPKEY_SM { get { return GROUPKEY == null ? null : Context.SM.FindByROOM(GROUPKEY); } }
        /// <summary>
        /// Room in the group [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Room in the group
        /// </summary>
        public SM_Entity ROOM_SM { get { return ROOM == null ? null : Context.SM.FindByROOM(ROOM); } }
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
