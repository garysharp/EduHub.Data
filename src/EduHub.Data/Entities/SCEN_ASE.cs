using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Excluded Data
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ASE : EduHubEntity
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
        /// </summary>
        public short? ID_RETURN { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? REGISTRATION { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ASE_TYPE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CREATEUSER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? CREATED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LUPDATEUSER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? LUPDATED { get; internal set; }

        #endregion

    }
}
