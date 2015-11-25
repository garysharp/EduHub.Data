using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fees
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDFC : EntityBase
    {

        #region Navigation Property Cache

        private GL Cache_GLCODE_GL;
        private KGST Cache_GST_TYPE_KGST;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<DRF> Cache_SDFCKEY_DRF_FEE_CODE;

        #endregion

        #region Field Properties

        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SDFCKEY { get; internal set; }

        /// <summary>
        /// Fees table title
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Group for reports only
        /// [Alphanumeric (10)]
        /// </summary>
        public string SDGROUP { get; internal set; }

        /// <summary>
        /// Fees tables to be used for auto transactions?
        /// [Alphanumeric (1)]
        /// </summary>
        public string STATEMENT { get; internal set; }

        /// <summary>
        /// Method of fees calculation
        /// [Alphanumeric (1)]
        /// </summary>
        public string METHOD { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? AMOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? GROSS_AMOUNT { get; internal set; }

        /// <summary>
        /// One GL key for each category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }

        /// <summary>
        /// What GST applies to this fee
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GST_TYPE { get; internal set; }

        /// <summary>
        /// For every fee there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// Fee might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

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
        /// GL (General Ledger) related entity by [SDFC.GLCODE]-&gt;[GL.CODE]
        /// One GL key for each category
        /// </summary>
        public GL GLCODE_GL
        {
            get
            {
                if (GLCODE == null)
                {
                    return null;
                }
                if (Cache_GLCODE_GL == null)
                {
                    Cache_GLCODE_GL = Context.GL.FindByCODE(GLCODE);
                }

                return Cache_GLCODE_GL;
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entity by [SDFC.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// What GST applies to this fee
        /// </summary>
        public KGST GST_TYPE_KGST
        {
            get
            {
                if (GST_TYPE == null)
                {
                    return null;
                }
                if (Cache_GST_TYPE_KGST == null)
                {
                    Cache_GST_TYPE_KGST = Context.KGST.FindByKGSTKEY(GST_TYPE);
                }

                return Cache_GST_TYPE_KGST;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [SDFC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every fee there is a subprogram
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

        /// <summary>
        /// KGLINIT (General Ledger Initiatives) related entity by [SDFC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Fee might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
            get
            {
                if (INITIATIVE == null)
                {
                    return null;
                }
                if (Cache_INITIATIVE_KGLINIT == null)
                {
                    Cache_INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                }

                return Cache_INITIATIVE_KGLINIT;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// DRF (DR Transactions) related entities by [SDFC.SDFCKEY]-&gt;[DRF.FEE_CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<DRF> SDFCKEY_DRF_FEE_CODE
        {
            get
            {
                if (Cache_SDFCKEY_DRF_FEE_CODE == null &&
                    !Context.DRF.TryFindByFEE_CODE(SDFCKEY, out Cache_SDFCKEY_DRF_FEE_CODE))
                {
                    Cache_SDFCKEY_DRF_FEE_CODE = new List<DRF>().AsReadOnly();
                }

                return Cache_SDFCKEY_DRF_FEE_CODE;
            }
        }

        #endregion

    }
}
