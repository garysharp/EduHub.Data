using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Periods
    /// </summary>
    public class TTEP_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Grid involved in exam [Uppercase Alphanumeric: u8]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [GKEY] => [TT_Entity].[TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT_Entity GKEY_TT { get { return GKEY == null ? null : Context.TT.FindByTTKEY(GKEY); } }
        /// <summary>
        /// Exam grid to which this period belongs [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TTEI_TID { get; internal set; }
        /// <summary>
        /// Day number for exam period [Date Time nullable: d]
        /// </summary>
        public DateTime? EXAM_DATE { get; internal set; }
        /// <summary>
        /// Period start time [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_START { get; internal set; }
        /// <summary>
        /// Period end time [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_END { get; internal set; }
        /// <summary>
        /// Exam grid row for period [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXAM_ROW { get; internal set; }
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
