using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// On line receipt history
    /// </summary>
    public partial class SIRH : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Transaction ID
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SIRHKEY { get; internal set; }
        /// <summary>
        /// Family ID/GL Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// DF or GL
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }
        /// <summary>
        /// Transaction reference � Receipt number
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Receipt detail
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// receipt date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Receipt total
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Receipt type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RTYPE { get; internal set; }
        /// <summary>
        /// Operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string RECEIPT_USER { get; internal set; }
        /// <summary>
        /// Online receipt printed date
        /// </summary>
        public DateTime? RECEIPT_DATE { get; internal set; }
        /// <summary>
        /// Online receipt printed time
        /// </summary>
        public short? RECEIPT_TIME { get; internal set; }
        /// <summary>
        /// New transaction reference number
        /// [Alphanumeric (10)]
        /// </summary>
        public string NEW_TRREF { get; internal set; }
        /// <summary>
        /// Flag available for data entry, Y denotes an error
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ERROR_FLAG { get; internal set; }
        /// <summary>
        /// Memo field available for data entry
        /// [Memo]
        /// </summary>
        public string ERROR_COMMENT { get; internal set; }
        /// <summary>
        /// User-ID of last person to modify ERROR_FLAG
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string ERROR_USER { get; internal set; }
        /// <summary>
        /// ID of format used to generate the receipt
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string FORMAT_ID { get; internal set; }
        /// <summary>
        /// Alternate key showing insert order
        /// </summary>
        public int? PRINT_ID { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion
    }
}
