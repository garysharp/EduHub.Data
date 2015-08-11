using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Labels
    /// </summary>
    public class THTN_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Link to Timetable Quilt Header [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [QKEY] => [TH_Entity].[THKEY]
        /// Link to Timetable Quilt Header
        /// </summary>
        public TH_Entity QKEY_TH { get { return QKEY == null ? null : Context.TH.FindByTHKEY(QKEY); } }
        /// <summary>
        /// Number > 0 for quilt label,< 0 extra labels [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LABEL_NUMBER { get; internal set; }
        /// <summary>
        /// R for Row, C for Column [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LABEL_TYPE { get; internal set; }
        /// <summary>
        /// Name for the label [Alphanumeric: a20]
        /// </summary>
        public string LABEL_NAME { get; internal set; }
        /// <summary>
        /// Display colour for the label [Integer (32bit signed nullable): l]
        /// </summary>
        public int? LABEL_COLOUR { get; internal set; }
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
