using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAB : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<ARF> Cache_BSB_ARF_BSB;
        private IReadOnlyList<CR> Cache_BSB_CR_BSB;
        private IReadOnlyList<CRF> Cache_BSB_CRF_BSB;
        private IReadOnlyList<DFF> Cache_BSB_DFF_BSB;
        private IReadOnlyList<DRF> Cache_BSB_DRF_BSB;
        private IReadOnlyList<GLCF> Cache_BSB_GLCF_BSB;
        private IReadOnlyList<GLF> Cache_BSB_GLF_BSB;
        private IReadOnlyList<PEPM> Cache_BSB_PEPM_BSB;

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
        /// Prime Key
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }

        /// <summary>
        /// Bank name
        /// [Alphanumeric (10)]
        /// </summary>
        public string BANK { get; internal set; }

        /// <summary>
        /// Bank address
        /// [Alphanumeric (50)]
        /// </summary>
        public string ADDRESS { get; internal set; }

        /// <summary>
        /// Bank suburb
        /// [Alphanumeric (30)]
        /// </summary>
        public string SUBURB { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [KAB.BSB]-&gt;[ARF.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<ARF> BSB_ARF_BSB
        {
            get
            {
                if (Cache_BSB_ARF_BSB == null &&
                    !Context.ARF.TryFindByBSB(BSB, out Cache_BSB_ARF_BSB))
                {
                    Cache_BSB_ARF_BSB = new List<ARF>().AsReadOnly();
                }

                return Cache_BSB_ARF_BSB;
            }
        }

        /// <summary>
        /// CR (Accounts Payable) related entities by [KAB.BSB]-&gt;[CR.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CR> BSB_CR_BSB
        {
            get
            {
                if (Cache_BSB_CR_BSB == null &&
                    !Context.CR.TryFindByBSB(BSB, out Cache_BSB_CR_BSB))
                {
                    Cache_BSB_CR_BSB = new List<CR>().AsReadOnly();
                }

                return Cache_BSB_CR_BSB;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [KAB.BSB]-&gt;[CRF.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRF> BSB_CRF_BSB
        {
            get
            {
                if (Cache_BSB_CRF_BSB == null &&
                    !Context.CRF.TryFindByBSB(BSB, out Cache_BSB_CRF_BSB))
                {
                    Cache_BSB_CRF_BSB = new List<CRF>().AsReadOnly();
                }

                return Cache_BSB_CRF_BSB;
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [KAB.BSB]-&gt;[DFF.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<DFF> BSB_DFF_BSB
        {
            get
            {
                if (Cache_BSB_DFF_BSB == null &&
                    !Context.DFF.TryFindByBSB(BSB, out Cache_BSB_DFF_BSB))
                {
                    Cache_BSB_DFF_BSB = new List<DFF>().AsReadOnly();
                }

                return Cache_BSB_DFF_BSB;
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [KAB.BSB]-&gt;[DRF.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<DRF> BSB_DRF_BSB
        {
            get
            {
                if (Cache_BSB_DRF_BSB == null &&
                    !Context.DRF.TryFindByBSB(BSB, out Cache_BSB_DRF_BSB))
                {
                    Cache_BSB_DRF_BSB = new List<DRF>().AsReadOnly();
                }

                return Cache_BSB_DRF_BSB;
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [KAB.BSB]-&gt;[GLCF.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<GLCF> BSB_GLCF_BSB
        {
            get
            {
                if (Cache_BSB_GLCF_BSB == null &&
                    !Context.GLCF.TryFindByBSB(BSB, out Cache_BSB_GLCF_BSB))
                {
                    Cache_BSB_GLCF_BSB = new List<GLCF>().AsReadOnly();
                }

                return Cache_BSB_GLCF_BSB;
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [KAB.BSB]-&gt;[GLF.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<GLF> BSB_GLF_BSB
        {
            get
            {
                if (Cache_BSB_GLF_BSB == null &&
                    !Context.GLF.TryFindByBSB(BSB, out Cache_BSB_GLF_BSB))
                {
                    Cache_BSB_GLF_BSB = new List<GLF>().AsReadOnly();
                }

                return Cache_BSB_GLF_BSB;
            }
        }

        /// <summary>
        /// PEPM (Pay Methods) related entities by [KAB.BSB]-&gt;[PEPM.BSB]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<PEPM> BSB_PEPM_BSB
        {
            get
            {
                if (Cache_BSB_PEPM_BSB == null &&
                    !Context.PEPM.TryFindByBSB(BSB, out Cache_BSB_PEPM_BSB))
                {
                    Cache_BSB_PEPM_BSB = new List<PEPM>().AsReadOnly();
                }

                return Cache_BSB_PEPM_BSB;
            }
        }

        #endregion

    }
}
