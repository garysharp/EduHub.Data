using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers
    /// </summary>
    public partial class KAB : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [ARF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<ARF> ARF_BSB
        {
            get
            {
                return Context.KAB.FindARFByBSB(BSB);
            }
        }

        /// <summary>
        /// CR (Accounts Payable) related entities by [CR.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<CR> CR_BSB
        {
            get
            {
                return Context.KAB.FindCRByBSB(BSB);
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [CRF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<CRF> CRF_BSB
        {
            get
            {
                return Context.KAB.FindCRFByBSB(BSB);
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [DFF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<DFF> DFF_BSB
        {
            get
            {
                return Context.KAB.FindDFFByBSB(BSB);
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [DRF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<DRF> DRF_BSB
        {
            get
            {
                return Context.KAB.FindDRFByBSB(BSB);
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [GLCF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<GLCF> GLCF_BSB
        {
            get
            {
                return Context.KAB.FindGLCFByBSB(BSB);
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [GLF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<GLF> GLF_BSB
        {
            get
            {
                return Context.KAB.FindGLFByBSB(BSB);
            }
        }

        /// <summary>
        /// PEPM (Pay Methods) related entities by [PEPM.BSB]-&gt;[KAB.BSB]
        /// </summary>
        public IReadOnlyList<PEPM> PEPM_BSB
        {
            get
            {
                return Context.KAB.FindPEPMByBSB(BSB);
            }
        }
#endregion
    }
}
