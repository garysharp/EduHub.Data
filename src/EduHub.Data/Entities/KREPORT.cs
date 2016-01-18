using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Reports for emailing
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KREPORT : EduHubEntity
    {

        #region Navigation Property Cache

        private KROLE Cache_ROLE_CODE_KROLE;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SPEMAIL> Cache_KREPORTKEY_SPEMAIL_REPORT;

        #endregion

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
        /// Report name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KREPORTKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Role for the code
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string ROLE_CODE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (80)]
        /// </summary>
        public string REPORT_NAME { get; internal set; }

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

        #region Navigation Properties

        /// <summary>
        /// KROLE (Role Codes) related entity by [KREPORT.ROLE_CODE]-&gt;[KROLE.KROLEKEY]
        /// Role for the code
        /// </summary>
        public KROLE ROLE_CODE_KROLE
        {
            get
            {
                if (ROLE_CODE == null)
                {
                    return null;
                }
                if (Cache_ROLE_CODE_KROLE == null)
                {
                    Cache_ROLE_CODE_KROLE = Context.KROLE.FindByKROLEKEY(ROLE_CODE);
                }

                return Cache_ROLE_CODE_KROLE;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SPEMAIL (Report email templates) related entities by [KREPORT.KREPORTKEY]-&gt;[SPEMAIL.REPORT]
        /// Report name
        /// </summary>
        public IReadOnlyList<SPEMAIL> KREPORTKEY_SPEMAIL_REPORT
        {
            get
            {
                if (Cache_KREPORTKEY_SPEMAIL_REPORT == null &&
                    !Context.SPEMAIL.TryFindByREPORT(KREPORTKEY, out Cache_KREPORTKEY_SPEMAIL_REPORT))
                {
                    Cache_KREPORTKEY_SPEMAIL_REPORT = new List<SPEMAIL>().AsReadOnly();
                }

                return Cache_KREPORTKEY_SPEMAIL_REPORT;
            }
        }

        #endregion

    }
}
