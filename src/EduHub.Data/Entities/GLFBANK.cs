using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Commitments
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBANK : EduHubEntity
    {

        #region Navigation Property Cache

        private GLBANK Cache_CODE_GLBANK;

        #endregion

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Owner account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Unique identifier per committed fund
        /// </summary>
        public short? FUND_ID { get; internal set; }

        /// <summary>
        /// Name of fund
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Amount of this fund
        /// </summary>
        public decimal? AMOUNT { get; internal set; }

        /// <summary>
        /// L or G only
        /// [Alphanumeric (1)]
        /// </summary>
        public string TIME_FRAME { get; internal set; }

        /// <summary>
        /// Last year's amount
        /// </summary>
        public decimal? LY_AMOUNT { get; internal set; }

        /// <summary>
        /// Last year's time frame
        /// [Alphanumeric (1)]
        /// </summary>
        public string LY_TIME_FRAME { get; internal set; }

        /// <summary>
        /// Temp field for SP2
        /// </summary>
        public short? TRBATCH { get; internal set; }

        /// <summary>
        /// Temp field for SP2
        /// </summary>
        public decimal? TRAMT { get; internal set; }

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
        /// GLBANK (Bank Account Details) related entity by [GLFBANK.CODE]-&gt;[GLBANK.GLCODE]
        /// Owner account
        /// </summary>
        public GLBANK CODE_GLBANK
        {
            get
            {
                if (Cache_CODE_GLBANK == null)
                {
                    Cache_CODE_GLBANK = Context.GLBANK.FindByGLCODE(CODE);
                }

                return Cache_CODE_GLBANK;
            }
        }

        #endregion

    }
}
