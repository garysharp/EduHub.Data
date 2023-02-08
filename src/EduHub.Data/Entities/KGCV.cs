#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eMaze Calendar Framework
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGCV : EduHubEntity
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
        /// Prime Key
        /// [Alphanumeric (4)]
        /// </summary>
        public string START_TIME { get; internal set; }

        /// <summary>
        /// Prime Key
        /// [Alphanumeric (4)]
        /// </summary>
        public string END_TIME { get; internal set; }

        /// <summary>
        /// Prime Key
        /// </summary>
        public short? VIEW_INCREMENT { get; internal set; }

        /// <summary>
        /// Group title
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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
#endif
