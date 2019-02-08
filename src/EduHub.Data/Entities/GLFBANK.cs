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
        private KFUND Cache_FUND_ID_KFUND;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;

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
        /// Subprogram (V60)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// Commencement Date
        /// </summary>
        public DateTime? COMMENCEMENT { get; internal set; }

        /// <summary>
        /// Completion Date
        /// </summary>
        public DateTime? COMPLETION { get; internal set; }

        /// <summary>
        /// Total cost of project
        /// </summary>
        public decimal? PROJECT_COST { get; internal set; }

        /// <summary>
        /// Co-contribution required from School to VSBA
        /// </summary>
        public decimal? VSBA_CO_CONTRIBUTION { get; internal set; }

        /// <summary>
        /// VSBA Notified Y.N or N/A
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string VSBA_NOTIFIED { get; internal set; }

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

        /// <summary>
        /// KFUND (GL Bank Fund) related entity by [GLFBANK.FUND_ID]-&gt;[KFUND.FUND_ID]
        /// Unique identifier per committed fund
        /// </summary>
        public KFUND FUND_ID_KFUND
        {
            get
            {
                if (FUND_ID == null)
                {
                    return null;
                }
                if (Cache_FUND_ID_KFUND == null)
                {
                    Cache_FUND_ID_KFUND = Context.KFUND.FindByFUND_ID(FUND_ID.Value);
                }

                return Cache_FUND_ID_KFUND;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [GLFBANK.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// Subprogram (V60)
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
            get
            {
                if (SUBPROGRAM == null)
                {
                    return null;
                }
                if (Cache_SUBPROGRAM_KGLSUB == null)
                {
                    Cache_SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                }

                return Cache_SUBPROGRAM_KGLSUB;
            }
        }

        #endregion

    }
}
