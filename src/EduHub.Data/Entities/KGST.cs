using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGST : EduHubEntity
    {

        #region Navigation Property Cache

        private GL Cache_GLGST_CODE_GL;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<ARF> Cache_KGSTKEY_ARF_GST_TYPE;
        private IReadOnlyList<CRF> Cache_KGSTKEY_CRF_GST_TYPE;
        private IReadOnlyList<CRF> Cache_KGSTKEY_CRF_INVOICEGST;
        private IReadOnlyList<DFF> Cache_KGSTKEY_DFF_GST_TYPE;
        private IReadOnlyList<DFVT> Cache_KGSTKEY_DFVT_GST_TYPE;
        private IReadOnlyList<DRF> Cache_KGSTKEY_DRF_GST_TYPE;
        private IReadOnlyList<GLCF> Cache_KGSTKEY_GLCF_GST_TYPE;
        private IReadOnlyList<GLCFPREV> Cache_KGSTKEY_GLCFPREV_GST_TYPE;
        private IReadOnlyList<GLF> Cache_KGSTKEY_GLF_GST_TYPE;
        private IReadOnlyList<GLFPREV> Cache_KGSTKEY_GLFPREV_GST_TYPE;
        private IReadOnlyList<SA> Cache_KGSTKEY_SA_GST_TYPE;
        private IReadOnlyList<SDFC> Cache_KGSTKEY_SDFC_GST_TYPE;

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
        /// Key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string KGSTKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Sales or Purchases (Capital or Ordinary)
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SALE_PURCH { get; internal set; }

        /// <summary>
        /// Percentage of Tax
        /// </summary>
        public double? GST_RATE { get; internal set; }

        /// <summary>
        /// Any non null will include this in the BAS
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GST_BOX { get; internal set; }

        /// <summary>
        /// GST posting account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLGST_CODE { get; internal set; }

        /// <summary>
        /// Input Claimed?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GST_RECLAIM { get; internal set; }

        /// <summary>
        /// GST code to be used for a correction to a prior period transaction
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PRIOR_PERIOD_GST { get; internal set; }

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
        /// GL (General Ledger) related entity by [KGST.GLGST_CODE]-&gt;[GL.CODE]
        /// GST posting account
        /// </summary>
        public GL GLGST_CODE_GL
        {
            get
            {
                if (GLGST_CODE == null)
                {
                    return null;
                }
                if (Cache_GLGST_CODE_GL == null)
                {
                    Cache_GLGST_CODE_GL = Context.GL.FindByCODE(GLGST_CODE);
                }

                return Cache_GLGST_CODE_GL;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [KGST.KGSTKEY]-&gt;[ARF.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<ARF> KGSTKEY_ARF_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_ARF_GST_TYPE == null &&
                    !Context.ARF.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_ARF_GST_TYPE))
                {
                    Cache_KGSTKEY_ARF_GST_TYPE = new List<ARF>().AsReadOnly();
                }

                return Cache_KGSTKEY_ARF_GST_TYPE;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [KGST.KGSTKEY]-&gt;[CRF.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<CRF> KGSTKEY_CRF_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_CRF_GST_TYPE == null &&
                    !Context.CRF.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_CRF_GST_TYPE))
                {
                    Cache_KGSTKEY_CRF_GST_TYPE = new List<CRF>().AsReadOnly();
                }

                return Cache_KGSTKEY_CRF_GST_TYPE;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [KGST.KGSTKEY]-&gt;[CRF.INVOICEGST]
        /// Key
        /// </summary>
        public IReadOnlyList<CRF> KGSTKEY_CRF_INVOICEGST
        {
            get
            {
                if (Cache_KGSTKEY_CRF_INVOICEGST == null &&
                    !Context.CRF.TryFindByINVOICEGST(KGSTKEY, out Cache_KGSTKEY_CRF_INVOICEGST))
                {
                    Cache_KGSTKEY_CRF_INVOICEGST = new List<CRF>().AsReadOnly();
                }

                return Cache_KGSTKEY_CRF_INVOICEGST;
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [KGST.KGSTKEY]-&gt;[DFF.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<DFF> KGSTKEY_DFF_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_DFF_GST_TYPE == null &&
                    !Context.DFF.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_DFF_GST_TYPE))
                {
                    Cache_KGSTKEY_DFF_GST_TYPE = new List<DFF>().AsReadOnly();
                }

                return Cache_KGSTKEY_DFF_GST_TYPE;
            }
        }

        /// <summary>
        /// DFVT (Family Voluntary Transactions) related entities by [KGST.KGSTKEY]-&gt;[DFVT.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<DFVT> KGSTKEY_DFVT_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_DFVT_GST_TYPE == null &&
                    !Context.DFVT.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_DFVT_GST_TYPE))
                {
                    Cache_KGSTKEY_DFVT_GST_TYPE = new List<DFVT>().AsReadOnly();
                }

                return Cache_KGSTKEY_DFVT_GST_TYPE;
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [KGST.KGSTKEY]-&gt;[DRF.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<DRF> KGSTKEY_DRF_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_DRF_GST_TYPE == null &&
                    !Context.DRF.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_DRF_GST_TYPE))
                {
                    Cache_KGSTKEY_DRF_GST_TYPE = new List<DRF>().AsReadOnly();
                }

                return Cache_KGSTKEY_DRF_GST_TYPE;
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [KGST.KGSTKEY]-&gt;[GLCF.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<GLCF> KGSTKEY_GLCF_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_GLCF_GST_TYPE == null &&
                    !Context.GLCF.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_GLCF_GST_TYPE))
                {
                    Cache_KGSTKEY_GLCF_GST_TYPE = new List<GLCF>().AsReadOnly();
                }

                return Cache_KGSTKEY_GLCF_GST_TYPE;
            }
        }

        /// <summary>
        /// GLCFPREV (Last Years GL Combined Financial Trans) related entities by [KGST.KGSTKEY]-&gt;[GLCFPREV.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<GLCFPREV> KGSTKEY_GLCFPREV_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_GLCFPREV_GST_TYPE == null &&
                    !Context.GLCFPREV.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_GLCFPREV_GST_TYPE))
                {
                    Cache_KGSTKEY_GLCFPREV_GST_TYPE = new List<GLCFPREV>().AsReadOnly();
                }

                return Cache_KGSTKEY_GLCFPREV_GST_TYPE;
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [KGST.KGSTKEY]-&gt;[GLF.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<GLF> KGSTKEY_GLF_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_GLF_GST_TYPE == null &&
                    !Context.GLF.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_GLF_GST_TYPE))
                {
                    Cache_KGSTKEY_GLF_GST_TYPE = new List<GLF>().AsReadOnly();
                }

                return Cache_KGSTKEY_GLF_GST_TYPE;
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [KGST.KGSTKEY]-&gt;[GLFPREV.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<GLFPREV> KGSTKEY_GLFPREV_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_GLFPREV_GST_TYPE == null &&
                    !Context.GLFPREV.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_GLFPREV_GST_TYPE))
                {
                    Cache_KGSTKEY_GLFPREV_GST_TYPE = new List<GLFPREV>().AsReadOnly();
                }

                return Cache_KGSTKEY_GLFPREV_GST_TYPE;
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [KGST.KGSTKEY]-&gt;[SA.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<SA> KGSTKEY_SA_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_SA_GST_TYPE == null &&
                    !Context.SA.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_SA_GST_TYPE))
                {
                    Cache_KGSTKEY_SA_GST_TYPE = new List<SA>().AsReadOnly();
                }

                return Cache_KGSTKEY_SA_GST_TYPE;
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [KGST.KGSTKEY]-&gt;[SDFC.GST_TYPE]
        /// Key
        /// </summary>
        public IReadOnlyList<SDFC> KGSTKEY_SDFC_GST_TYPE
        {
            get
            {
                if (Cache_KGSTKEY_SDFC_GST_TYPE == null &&
                    !Context.SDFC.TryFindByGST_TYPE(KGSTKEY, out Cache_KGSTKEY_SDFC_GST_TYPE))
                {
                    Cache_KGSTKEY_SDFC_GST_TYPE = new List<SDFC>().AsReadOnly();
                }

                return Cache_KGSTKEY_SDFC_GST_TYPE;
            }
        }

        #endregion

    }
}
