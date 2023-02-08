#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Signatories
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BANKSIG : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private GLBANK Cache_GLCODE_GLBANK;
#endif

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// General Ledger code (Prime Key)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (30)]
        /// </summary>
        public string SIGNATORY { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (30)]
        /// </summary>
        public string BANK_ROLE { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// GLBANK (Bank Account Details) related entity by [BANKSIG.GLCODE]-&gt;[GLBANK.GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public GLBANK GLCODE_GLBANK
        {
            get
            {
                if (Cache_GLCODE_GLBANK == null)
                {
                    Cache_GLCODE_GLBANK = Context.GLBANK.FindByGLCODE(GLCODE);
                }

                return Cache_GLCODE_GLBANK;
            }
        }

#endif
        #endregion

    }
}
#endif
