#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Holding Table for Incorrect Schools
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSKGS : EduHubEntity
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
        /// Prime key
        /// </summary>
        public int KSKGSKEY { get; internal set; }

        /// <summary>
        /// School ID (Data recorded in Table name\Field name for Record key
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHOOL { get; internal set; }

        /// <summary>
        /// School Name
        /// [Alphanumeric (40)]
        /// </summary>
        public string NAME { get; internal set; }

        /// <summary>
        /// Message Body
        /// [Alphanumeric (10)]
        /// </summary>
        public string TABLE_NAME { get; internal set; }

        /// <summary>
        /// Expiry date
        /// [Alphanumeric (30)]
        /// </summary>
        public string FIELD_NAME { get; internal set; }

        /// <summary>
        /// Prime key of Table name\field name
        /// [Alphanumeric (20)]
        /// </summary>
        public string RECORD_KEY { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
#endif
