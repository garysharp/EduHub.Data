using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PRMS Order Details
    /// </summary>
    public class KPRMS_Entity : EntityBase
    {
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// PRMS Order number [Alphanumeric: a10]
        /// </summary>
        public string PRMS_ORDERNO { get; internal set; }
        /// <summary>
        /// Order date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Order Line number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ORDER_LINENO { get; internal set; }
        /// <summary>
        /// Order description [Alphanumeric: a30]
        /// </summary>
        public string ORDER_DESC { get; internal set; }
        /// <summary>
        /// GL Code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Program code [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Subprogram code [Uppercase Alphanumeric: u4]
        /// </summary>
        public string GLSUBPROG { get; internal set; }
        /// <summary>
        /// Initiative code [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLINIT { get; internal set; }
        /// <summary>
        /// order qty for this line [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Order line amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT { get; internal set; }
        /// <summary>
        /// Creditor key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CRKEY { get; internal set; }
        /// <summary>
        /// GST Code, default "AT" [Alphanumeric: a4]
        /// </summary>
        public string GST_CODE { get; internal set; }
        /// <summary>
        /// GST rate [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_RATE { get; internal set; }
        /// <summary>
        /// Not required if validation for ABN is done on                                                                               * import [Uppercase Alphanumeric: u15]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Not required if validation for School code is
        /// done on import [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_ID { get; internal set; }
        /// <summary>
        /// Processed/flagged for deletion set
        /// to 'Y' else null
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }
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
