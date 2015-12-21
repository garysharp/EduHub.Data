using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Initiatives
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLINIT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<ARF> Cache_INITIATIVE_ARF_INITIATIVE;
        private IReadOnlyList<CRF> Cache_INITIATIVE_CRF_INITIATIVE;
        private IReadOnlyList<DFF> Cache_INITIATIVE_DFF_INITIATIVE;
        private IReadOnlyList<DRF> Cache_INITIATIVE_DRF_INITIATIVE;
        private IReadOnlyList<GLBUDG> Cache_INITIATIVE_GLBUDG_INITIATIVE;
        private IReadOnlyList<GLCF> Cache_INITIATIVE_GLCF_INITIATIVE;
        private IReadOnlyList<GLCFPREV> Cache_INITIATIVE_GLCFPREV_INITIATIVE;
        private IReadOnlyList<GLF> Cache_INITIATIVE_GLF_INITIATIVE;
        private IReadOnlyList<GLFPREV> Cache_INITIATIVE_GLFPREV_INITIATIVE;
        private IReadOnlyList<PC> Cache_INITIATIVE_PC_INITIATIVE;
        private IReadOnlyList<PD> Cache_INITIATIVE_PD_INITIATIVE;
        private IReadOnlyList<PEF> Cache_INITIATIVE_PEF_INITIATIVE;
        private IReadOnlyList<PEFH> Cache_INITIATIVE_PEFH_INITIATIVE;
        private IReadOnlyList<PEPS> Cache_INITIATIVE_PEPS_INITIATIVE;
        private IReadOnlyList<PEPU> Cache_INITIATIVE_PEPU_INITIATIVE;
        private IReadOnlyList<PEPUH> Cache_INITIATIVE_PEPUH_INITIATIVE;
        private IReadOnlyList<PI> Cache_INITIATIVE_PI_INITIATIVE;
        private IReadOnlyList<PN> Cache_INITIATIVE_PN_INITIATIVE;
        private IReadOnlyList<SA> Cache_INITIATIVE_SA_INITIATIVE;
        private IReadOnlyList<SDFC> Cache_INITIATIVE_SDFC_INITIATIVE;

        #endregion

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

        #region Foreign Navigation Properties

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [KGLINIT.INITIATIVE]-&gt;[ARF.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<ARF> INITIATIVE_ARF_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_ARF_INITIATIVE == null &&
                    !Context.ARF.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_ARF_INITIATIVE))
                {
                    Cache_INITIATIVE_ARF_INITIATIVE = new List<ARF>().AsReadOnly();
                }

                return Cache_INITIATIVE_ARF_INITIATIVE;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [KGLINIT.INITIATIVE]-&gt;[CRF.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<CRF> INITIATIVE_CRF_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_CRF_INITIATIVE == null &&
                    !Context.CRF.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_CRF_INITIATIVE))
                {
                    Cache_INITIATIVE_CRF_INITIATIVE = new List<CRF>().AsReadOnly();
                }

                return Cache_INITIATIVE_CRF_INITIATIVE;
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [KGLINIT.INITIATIVE]-&gt;[DFF.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<DFF> INITIATIVE_DFF_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_DFF_INITIATIVE == null &&
                    !Context.DFF.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_DFF_INITIATIVE))
                {
                    Cache_INITIATIVE_DFF_INITIATIVE = new List<DFF>().AsReadOnly();
                }

                return Cache_INITIATIVE_DFF_INITIATIVE;
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [KGLINIT.INITIATIVE]-&gt;[DRF.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<DRF> INITIATIVE_DRF_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_DRF_INITIATIVE == null &&
                    !Context.DRF.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_DRF_INITIATIVE))
                {
                    Cache_INITIATIVE_DRF_INITIATIVE = new List<DRF>().AsReadOnly();
                }

                return Cache_INITIATIVE_DRF_INITIATIVE;
            }
        }

        /// <summary>
        /// GLBUDG (General Ledger Budgets) related entities by [KGLINIT.INITIATIVE]-&gt;[GLBUDG.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLBUDG> INITIATIVE_GLBUDG_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_GLBUDG_INITIATIVE == null &&
                    !Context.GLBUDG.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_GLBUDG_INITIATIVE))
                {
                    Cache_INITIATIVE_GLBUDG_INITIATIVE = new List<GLBUDG>().AsReadOnly();
                }

                return Cache_INITIATIVE_GLBUDG_INITIATIVE;
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [KGLINIT.INITIATIVE]-&gt;[GLCF.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLCF> INITIATIVE_GLCF_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_GLCF_INITIATIVE == null &&
                    !Context.GLCF.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_GLCF_INITIATIVE))
                {
                    Cache_INITIATIVE_GLCF_INITIATIVE = new List<GLCF>().AsReadOnly();
                }

                return Cache_INITIATIVE_GLCF_INITIATIVE;
            }
        }

        /// <summary>
        /// GLCFPREV (Last Years GL Combined Financial Trans) related entities by [KGLINIT.INITIATIVE]-&gt;[GLCFPREV.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLCFPREV> INITIATIVE_GLCFPREV_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_GLCFPREV_INITIATIVE == null &&
                    !Context.GLCFPREV.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_GLCFPREV_INITIATIVE))
                {
                    Cache_INITIATIVE_GLCFPREV_INITIATIVE = new List<GLCFPREV>().AsReadOnly();
                }

                return Cache_INITIATIVE_GLCFPREV_INITIATIVE;
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [KGLINIT.INITIATIVE]-&gt;[GLF.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLF> INITIATIVE_GLF_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_GLF_INITIATIVE == null &&
                    !Context.GLF.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_GLF_INITIATIVE))
                {
                    Cache_INITIATIVE_GLF_INITIATIVE = new List<GLF>().AsReadOnly();
                }

                return Cache_INITIATIVE_GLF_INITIATIVE;
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [KGLINIT.INITIATIVE]-&gt;[GLFPREV.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLFPREV> INITIATIVE_GLFPREV_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_GLFPREV_INITIATIVE == null &&
                    !Context.GLFPREV.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_GLFPREV_INITIATIVE))
                {
                    Cache_INITIATIVE_GLFPREV_INITIATIVE = new List<GLFPREV>().AsReadOnly();
                }

                return Cache_INITIATIVE_GLFPREV_INITIATIVE;
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entities by [KGLINIT.INITIATIVE]-&gt;[PC.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PC> INITIATIVE_PC_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PC_INITIATIVE == null &&
                    !Context.PC.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PC_INITIATIVE))
                {
                    Cache_INITIATIVE_PC_INITIATIVE = new List<PC>().AsReadOnly();
                }

                return Cache_INITIATIVE_PC_INITIATIVE;
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [KGLINIT.INITIATIVE]-&gt;[PD.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PD> INITIATIVE_PD_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PD_INITIATIVE == null &&
                    !Context.PD.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PD_INITIATIVE))
                {
                    Cache_INITIATIVE_PD_INITIATIVE = new List<PD>().AsReadOnly();
                }

                return Cache_INITIATIVE_PD_INITIATIVE;
            }
        }

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [KGLINIT.INITIATIVE]-&gt;[PEF.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEF> INITIATIVE_PEF_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PEF_INITIATIVE == null &&
                    !Context.PEF.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PEF_INITIATIVE))
                {
                    Cache_INITIATIVE_PEF_INITIATIVE = new List<PEF>().AsReadOnly();
                }

                return Cache_INITIATIVE_PEF_INITIATIVE;
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [KGLINIT.INITIATIVE]-&gt;[PEFH.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEFH> INITIATIVE_PEFH_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PEFH_INITIATIVE == null &&
                    !Context.PEFH.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PEFH_INITIATIVE))
                {
                    Cache_INITIATIVE_PEFH_INITIATIVE = new List<PEFH>().AsReadOnly();
                }

                return Cache_INITIATIVE_PEFH_INITIATIVE;
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [KGLINIT.INITIATIVE]-&gt;[PEPS.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEPS> INITIATIVE_PEPS_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PEPS_INITIATIVE == null &&
                    !Context.PEPS.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PEPS_INITIATIVE))
                {
                    Cache_INITIATIVE_PEPS_INITIATIVE = new List<PEPS>().AsReadOnly();
                }

                return Cache_INITIATIVE_PEPS_INITIATIVE;
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [KGLINIT.INITIATIVE]-&gt;[PEPU.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEPU> INITIATIVE_PEPU_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PEPU_INITIATIVE == null &&
                    !Context.PEPU.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PEPU_INITIATIVE))
                {
                    Cache_INITIATIVE_PEPU_INITIATIVE = new List<PEPU>().AsReadOnly();
                }

                return Cache_INITIATIVE_PEPU_INITIATIVE;
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [KGLINIT.INITIATIVE]-&gt;[PEPUH.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEPUH> INITIATIVE_PEPUH_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PEPUH_INITIATIVE == null &&
                    !Context.PEPUH.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PEPUH_INITIATIVE))
                {
                    Cache_INITIATIVE_PEPUH_INITIATIVE = new List<PEPUH>().AsReadOnly();
                }

                return Cache_INITIATIVE_PEPUH_INITIATIVE;
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [KGLINIT.INITIATIVE]-&gt;[PI.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PI> INITIATIVE_PI_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PI_INITIATIVE == null &&
                    !Context.PI.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PI_INITIATIVE))
                {
                    Cache_INITIATIVE_PI_INITIATIVE = new List<PI>().AsReadOnly();
                }

                return Cache_INITIATIVE_PI_INITIATIVE;
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [KGLINIT.INITIATIVE]-&gt;[PN.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PN> INITIATIVE_PN_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_PN_INITIATIVE == null &&
                    !Context.PN.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_PN_INITIATIVE))
                {
                    Cache_INITIATIVE_PN_INITIATIVE = new List<PN>().AsReadOnly();
                }

                return Cache_INITIATIVE_PN_INITIATIVE;
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [KGLINIT.INITIATIVE]-&gt;[SA.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<SA> INITIATIVE_SA_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_SA_INITIATIVE == null &&
                    !Context.SA.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_SA_INITIATIVE))
                {
                    Cache_INITIATIVE_SA_INITIATIVE = new List<SA>().AsReadOnly();
                }

                return Cache_INITIATIVE_SA_INITIATIVE;
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [KGLINIT.INITIATIVE]-&gt;[SDFC.INITIATIVE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<SDFC> INITIATIVE_SDFC_INITIATIVE
        {
            get
            {
                if (Cache_INITIATIVE_SDFC_INITIATIVE == null &&
                    !Context.SDFC.TryFindByINITIATIVE(INITIATIVE, out Cache_INITIATIVE_SDFC_INITIATIVE))
                {
                    Cache_INITIATIVE_SDFC_INITIATIVE = new List<SDFC>().AsReadOnly();
                }

                return Cache_INITIATIVE_SDFC_INITIATIVE;
            }
        }

        #endregion

    }
}
