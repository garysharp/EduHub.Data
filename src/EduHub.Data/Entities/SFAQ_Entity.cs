using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability in Quilt
    /// </summary>
    public class SFAQ_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Staff key [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SFAQKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SFAQKEY] => [SF_Entity].[SFKEY]
        /// Staff key
        /// </summary>
        public SF_Entity SFAQKEY_SF { get { return SFAQKEY == null ? null : Context.SF.FindBySFKEY(SFAQKEY); } }
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
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
