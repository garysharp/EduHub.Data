using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Commitments
    /// </summary>
    public class GLFBANK_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Owner account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [GLBANK_Entity].[GLCODE]
        /// Owner account
        /// </summary>
        public GLBANK_Entity CODE_GLBANK { get { return CODE == null ? null : Context.GLBANK.FindByGLCODE(CODE); } }
        /// <summary>
        /// Unique identifier per committed fund [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FUND_ID { get; internal set; }
        /// <summary>
        /// Name of fund [Alphanumeric: a50]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Amount of this fund [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// L or G only [Alphanumeric: a1]
        /// </summary>
        public string TIME_FRAME { get; internal set; }
        /// <summary>
        /// Last year's amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LY_AMOUNT { get; internal set; }
        /// <summary>
        /// Last year's time frame [Alphanumeric: a1]
        /// </summary>
        public string LY_TIME_FRAME { get; internal set; }
        /// <summary>
        /// Temp field for SP2 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRBATCH { get; internal set; }
        /// <summary>
        /// Temp field for SP2 [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
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
