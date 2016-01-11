using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Field-Display Metadata for Census Return Data
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_RFD : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return null;
            }
        }

        #region Field Properties

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public int ID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string COLUMNNAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string COLUMNDISPLAYNAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string RFD_TYPE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? TYPEORDER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? DEFAULTCOLUMNDISPLAYORDER { get; internal set; }

        #endregion

    }
}
