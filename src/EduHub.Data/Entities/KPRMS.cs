using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PRMS Order Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPRMS : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// PRMS Order number
        /// [Alphanumeric (10)]
        /// </summary>
        public string PRMS_ORDERNO { get; internal set; }

        /// <summary>
        /// Order date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// Order Line number
        /// </summary>
        public short? ORDER_LINENO { get; internal set; }

        /// <summary>
        /// Order description
        /// [Alphanumeric (30)]
        /// </summary>
        public string ORDER_DESC { get; internal set; }

        /// <summary>
        /// GL Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }

        /// <summary>
        /// Program code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// Subprogram code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GLSUBPROG { get; internal set; }

        /// <summary>
        /// Initiative code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLINIT { get; internal set; }

        /// <summary>
        /// order qty for this line
        /// </summary>
        public double? TRQTY { get; internal set; }

        /// <summary>
        /// Order line amount
        /// </summary>
        public decimal? AMOUNT { get; internal set; }

        /// <summary>
        /// Creditor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CRKEY { get; internal set; }

        /// <summary>
        /// GST Code, default "AT"
        /// [Alphanumeric (4)]
        /// </summary>
        public string GST_CODE { get; internal set; }

        /// <summary>
        /// GST rate
        /// </summary>
        public decimal? GST_RATE { get; internal set; }

        /// <summary>
        /// Not required if validation for ABN is done on                                                                               * import
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string ABN { get; internal set; }

        /// <summary>
        /// Not required if validation for School code is
        /// done on import
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_ID { get; internal set; }

        /// <summary>
        /// Processed/flagged for deletion set
        /// to 'Y' else null
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }

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
