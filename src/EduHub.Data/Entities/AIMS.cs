using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// AIMS Data
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AIMS : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// SQL identity
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Table where change was made eg CR, DF
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CRKEY { get; internal set; }

        /// <summary>
        /// ID of entity
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string AIMSKEY { get; internal set; }

        /// <summary>
        /// Creditor name as stored in AIMS
        /// [Alphanumeric (50)]
        /// </summary>
        public string NAME { get; internal set; }

        /// <summary>
        /// Creditor address lines
        /// [Alphanumeric (50)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Creditor address lines
        /// [Alphanumeric (50)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Creditor suburb
        /// [Alphanumeric (50)]
        /// </summary>
        public string SUBURB { get; internal set; }

        /// <summary>
        /// Creditor state
        /// [Alphanumeric (4)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Creditor Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Creditor telephone
        /// [Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }

        /// <summary>
        /// Fax
        /// [Alphanumeric (20)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Creditor ABN
        /// [Alphanumeric (15)]
        /// </summary>
        public string ABN { get; internal set; }

        /// <summary>
        /// Mobile number
        /// [Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// Creditor Email
        /// [Alphanumeric (60)]
        /// </summary>
        public string EMAIL { get; internal set; }

        /// <summary>
        /// Order date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// AIMS Order ID
        /// [Alphanumeric (20)]
        /// </summary>
        public string ORDERID { get; internal set; }

        /// <summary>
        /// AIMS Order amount
        /// </summary>
        public decimal? ORDER_AMT { get; internal set; }

        /// <summary>
        /// GST Type
        /// [Alphanumeric (4)]
        /// </summary>
        public string GST_TYPE { get; internal set; }

        /// <summary>
        /// Line number
        /// </summary>
        public short? LINE { get; internal set; }

        /// <summary>
        /// Order Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// GL Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }

        /// <summary>
        /// GL Program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// GL Sub Program
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// GL Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

        /// <summary>
        /// GST Rate
        /// </summary>
        public double? GST_RATE { get; internal set; }

        /// <summary>
        /// GST Ca FLag
        /// [Alphanumeric (20)]
        /// </summary>
        public string GST_CA { get; internal set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public short? TRQTY { get; internal set; }

        /// <summary>
        /// Delete flag
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
