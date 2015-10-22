using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Initiatives
    /// </summary>
    public partial class KGLINIT : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Type key, eg I
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// eg, INCOME
        /// [Alphanumeric (50)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Allow account to be used(Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
        /// ARF (Asset Financial Transactions) related entities by [ARF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<ARF> ARF_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindARFByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [CRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<CRF> CRF_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindCRFByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [DFF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<DFF> DFF_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindDFFByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [DRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<DRF> DRF_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindDRFByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// GLBUDG (General Ledger Budgets) related entities by [GLBUDG.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<GLBUDG> GLBUDG_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindGLBUDGByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [GLCF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<GLCF> GLCF_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindGLCFByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// GLCFPREV (Last Years GL Combined Financial Trans) related entities by [GLCFPREV.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<GLCFPREV> GLCFPREV_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindGLCFPREVByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [GLF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<GLF> GLF_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindGLFByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [GLFPREV.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<GLFPREV> GLFPREV_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindGLFPREVByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entities by [PC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PC> PC_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPCByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [PD.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PD> PD_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPDByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PEF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PEF> PEF_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPEFByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PEFH.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PEFH> PEFH_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPEFHByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PEPS.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PEPS> PEPS_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPEPSByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [PEPU.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PEPU> PEPU_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPEPUByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [PEPUH.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PEPUH> PEPUH_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPEPUHByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [PI.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PI> PI_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPIByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [PN.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<PN> PN_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindPNByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [SA.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<SA> SA_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindSAByINITIATIVE(INITIATIVE);
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [SDFC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        public IReadOnlyList<SDFC> SDFC_INITIATIVE
        {
            get
            {
                return Context.KGLINIT.FindSDFCByINITIATIVE(INITIATIVE);
            }
        }
#endregion
    }
}
