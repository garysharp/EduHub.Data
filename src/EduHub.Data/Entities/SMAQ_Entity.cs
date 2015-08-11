using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availability in Quilt
    /// </summary>
    public class SMAQ_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Room key [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SMAQKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SMAQKEY] => [SM_Entity].[ROOM]
        /// Room key
        /// </summary>
        public SM_Entity SMAQKEY_SM { get { return SMAQKEY == null ? null : Context.SM.FindByROOM(SMAQKEY); } }
        /// <summary>
        /// Quilt [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [QKEY] => [TH_Entity].[THKEY]
        /// Quilt
        /// </summary>
        public TH_Entity QKEY_TH { get { return QKEY == null ? null : Context.TH.FindByTHKEY(QKEY); } }
        /// <summary>
        /// Day of the timetable cycle [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DAY_NUMBER { get; internal set; }
        /// <summary>
        /// Start available period [Integer (16bit signed nullable): i]
        /// </summary>
        public short? START_PERIOD { get; internal set; }
        /// <summary>
        /// End available period [Integer (16bit signed nullable): i]
        /// </summary>
        public short? END_PERIOD { get; internal set; }
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
