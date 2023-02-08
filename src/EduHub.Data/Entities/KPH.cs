#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Holding Table for Reformatting phone numbers
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPH : EduHubEntity
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
        public int KPHKEY { get; internal set; }

        /// <summary>
        /// Table of record
        /// [Alphanumeric (15)]
        /// </summary>
        public string TABLE_NAME { get; internal set; }

        /// <summary>
        /// Column/field of phone data
        /// [Alphanumeric (50)]
        /// </summary>
        public string FIELD_NAME { get; internal set; }

        /// <summary>
        /// Land (Landline), Mobile, Fax,
        /// [Alphanumeric (10)]
        /// </summary>
        public string FIELD_TYPE { get; internal set; }

        /// <summary>
        /// Name of Prime key field (Prime key field where data recorded in Table name\Field name)
        /// [Alphanumeric (30)]
        /// </summary>
        public string KEY_FIELD { get; internal set; }

        /// <summary>
        /// Value of Prime key of record (Data recorded in Table name\Field name for RECORD_KEY)
        /// [Alphanumeric (30)]
        /// </summary>
        public string KEY_VALUE { get; internal set; }

        /// <summary>
        /// Original phone number before 20char truncation (if applic) &amp; formatting
        /// [Alphanumeric (31)]
        /// </summary>
        public string OLD_VALUE { get; internal set; }

        /// <summary>
        /// New phone number after 20char truncation (if applic) &amp; formatting
        /// [Alphanumeric (31)]
        /// </summary>
        public string NEW_VALUE { get; internal set; }

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
