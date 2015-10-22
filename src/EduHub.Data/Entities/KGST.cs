using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages
    /// </summary>
    public partial class KGST : EntityBase
    {
#region Navigation Property Cache
        private GL _GLGST_CODE_GL;
#endregion

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
                if (GLGST_CODE != null)
                {
                    if (_GLGST_CODE_GL == null)
                    {
                        _GLGST_CODE_GL = Context.GL.FindByCODE(GLGST_CODE);
                    }
                    return _GLGST_CODE_GL;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [ARF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<ARF> ARF_GST_TYPE
        {
            get
            {
                return Context.KGST.FindARFByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [CRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<CRF> CRF_GST_TYPE
        {
            get
            {
                return Context.KGST.FindCRFByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [CRF.INVOICEGST]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<CRF> CRF_INVOICEGST
        {
            get
            {
                return Context.KGST.FindCRFByINVOICEGST(KGSTKEY);
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [DFF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<DFF> DFF_GST_TYPE
        {
            get
            {
                return Context.KGST.FindDFFByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// DFVT (Family Voluntary Transactions) related entities by [DFVT.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<DFVT> DFVT_GST_TYPE
        {
            get
            {
                return Context.KGST.FindDFVTByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [DRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<DRF> DRF_GST_TYPE
        {
            get
            {
                return Context.KGST.FindDRFByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [GLCF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<GLCF> GLCF_GST_TYPE
        {
            get
            {
                return Context.KGST.FindGLCFByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// GLCFPREV (Last Years GL Combined Financial Trans) related entities by [GLCFPREV.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<GLCFPREV> GLCFPREV_GST_TYPE
        {
            get
            {
                return Context.KGST.FindGLCFPREVByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [GLF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<GLF> GLF_GST_TYPE
        {
            get
            {
                return Context.KGST.FindGLFByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [GLFPREV.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<GLFPREV> GLFPREV_GST_TYPE
        {
            get
            {
                return Context.KGST.FindGLFPREVByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [SA.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<SA> SA_GST_TYPE
        {
            get
            {
                return Context.KGST.FindSAByGST_TYPE(KGSTKEY);
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [SDFC.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        public IReadOnlyList<SDFC> SDFC_GST_TYPE
        {
            get
            {
                return Context.KGST.FindSDFCByGST_TYPE(KGSTKEY);
            }
        }
#endregion
    }
}
