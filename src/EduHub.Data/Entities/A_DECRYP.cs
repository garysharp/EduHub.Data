#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Decrypted data IMPORT
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class A_DECRYP : EduHubEntity
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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// enote LINE_TYPE of decrypted data, eg. BPAY
        /// [Alphanumeric (10)]
        /// </summary>
        public string LINE_TYPE { get; internal set; }

        /// <summary>
        /// raw data after decrypted
        /// [Alphanumeric (200)]
        /// </summary>
        public string RECORD { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        #endregion

    }
}
#endif
