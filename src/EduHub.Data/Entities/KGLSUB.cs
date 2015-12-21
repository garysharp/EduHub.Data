using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Sub Programs
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLSUB : EduHubEntity
    {

        #region Navigation Property Cache

        private KGLPROG Cache_GL_PROGRAM_KGLPROG;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<ARF> Cache_SUBPROGRAM_ARF_SUBPROGRAM;
        private IReadOnlyList<CRF> Cache_SUBPROGRAM_CRF_SUBPROGRAM;
        private IReadOnlyList<DFF> Cache_SUBPROGRAM_DFF_SUBPROGRAM;
        private IReadOnlyList<DRF> Cache_SUBPROGRAM_DRF_SUBPROGRAM;
        private IReadOnlyList<GLCF> Cache_SUBPROGRAM_GLCF_SUBPROGRAM;
        private IReadOnlyList<GLCFPREV> Cache_SUBPROGRAM_GLCFPREV_SUBPROGRAM;
        private IReadOnlyList<GLF> Cache_SUBPROGRAM_GLF_SUBPROGRAM;
        private IReadOnlyList<GLFPREV> Cache_SUBPROGRAM_GLFPREV_SUBPROGRAM;
        private IReadOnlyList<PC> Cache_SUBPROGRAM_PC_SUBPROGRAM;
        private IReadOnlyList<PD> Cache_SUBPROGRAM_PD_SUBPROGRAM;
        private IReadOnlyList<PEF> Cache_SUBPROGRAM_PEF_SUBPROGRAM;
        private IReadOnlyList<PEFH> Cache_SUBPROGRAM_PEFH_SUBPROGRAM;
        private IReadOnlyList<PEPS> Cache_SUBPROGRAM_PEPS_SUBPROGRAM;
        private IReadOnlyList<PEPU> Cache_SUBPROGRAM_PEPU_SUBPROGRAM;
        private IReadOnlyList<PEPUH> Cache_SUBPROGRAM_PEPUH_SUBPROGRAM;
        private IReadOnlyList<PI> Cache_SUBPROGRAM_PI_SUBPROGRAM;
        private IReadOnlyList<PN> Cache_SUBPROGRAM_PN_SUBPROGRAM;
        private IReadOnlyList<SA> Cache_SUBPROGRAM_SA_SUBPROGRAM;
        private IReadOnlyList<SDFC> Cache_SUBPROGRAM_SDFC_SUBPROGRAM;

        #endregion

        #region Field Properties

        /// <summary>
        /// Type key, eg I
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// eg, INCOME
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Each subprogram belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GL_PROGRAM { get; internal set; }

        /// <summary>
        /// Allow account to be used(Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }

        /// <summary>
        /// To allow editing of the description
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string USER_DEFINABLE { get; internal set; }

        /// <summary>
        /// To prevent re-activation of old codes
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESERVED { get; internal set; }

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
        /// KGLPROG (General Ledger Programs) related entity by [KGLSUB.GL_PROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// Each subprogram belongs to a program
        /// </summary>
        public KGLPROG GL_PROGRAM_KGLPROG
        {
            get
            {
                if (GL_PROGRAM == null)
                {
                    return null;
                }
                if (Cache_GL_PROGRAM_KGLPROG == null)
                {
                    Cache_GL_PROGRAM_KGLPROG = Context.KGLPROG.FindByGLPROGRAM(GL_PROGRAM);
                }

                return Cache_GL_PROGRAM_KGLPROG;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [KGLSUB.SUBPROGRAM]-&gt;[ARF.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<ARF> SUBPROGRAM_ARF_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_ARF_SUBPROGRAM == null &&
                    !Context.ARF.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_ARF_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_ARF_SUBPROGRAM = new List<ARF>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_ARF_SUBPROGRAM;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [KGLSUB.SUBPROGRAM]-&gt;[CRF.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<CRF> SUBPROGRAM_CRF_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_CRF_SUBPROGRAM == null &&
                    !Context.CRF.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_CRF_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_CRF_SUBPROGRAM = new List<CRF>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_CRF_SUBPROGRAM;
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [KGLSUB.SUBPROGRAM]-&gt;[DFF.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<DFF> SUBPROGRAM_DFF_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_DFF_SUBPROGRAM == null &&
                    !Context.DFF.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_DFF_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_DFF_SUBPROGRAM = new List<DFF>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_DFF_SUBPROGRAM;
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [KGLSUB.SUBPROGRAM]-&gt;[DRF.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<DRF> SUBPROGRAM_DRF_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_DRF_SUBPROGRAM == null &&
                    !Context.DRF.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_DRF_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_DRF_SUBPROGRAM = new List<DRF>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_DRF_SUBPROGRAM;
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [KGLSUB.SUBPROGRAM]-&gt;[GLCF.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLCF> SUBPROGRAM_GLCF_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_GLCF_SUBPROGRAM == null &&
                    !Context.GLCF.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_GLCF_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_GLCF_SUBPROGRAM = new List<GLCF>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_GLCF_SUBPROGRAM;
            }
        }

        /// <summary>
        /// GLCFPREV (Last Years GL Combined Financial Trans) related entities by [KGLSUB.SUBPROGRAM]-&gt;[GLCFPREV.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLCFPREV> SUBPROGRAM_GLCFPREV_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_GLCFPREV_SUBPROGRAM == null &&
                    !Context.GLCFPREV.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_GLCFPREV_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_GLCFPREV_SUBPROGRAM = new List<GLCFPREV>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_GLCFPREV_SUBPROGRAM;
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [KGLSUB.SUBPROGRAM]-&gt;[GLF.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLF> SUBPROGRAM_GLF_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_GLF_SUBPROGRAM == null &&
                    !Context.GLF.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_GLF_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_GLF_SUBPROGRAM = new List<GLF>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_GLF_SUBPROGRAM;
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [KGLSUB.SUBPROGRAM]-&gt;[GLFPREV.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLFPREV> SUBPROGRAM_GLFPREV_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_GLFPREV_SUBPROGRAM == null &&
                    !Context.GLFPREV.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_GLFPREV_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_GLFPREV_SUBPROGRAM = new List<GLFPREV>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_GLFPREV_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PC.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PC> SUBPROGRAM_PC_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PC_SUBPROGRAM == null &&
                    !Context.PC.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PC_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PC_SUBPROGRAM = new List<PC>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PC_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PD.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PD> SUBPROGRAM_PD_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PD_SUBPROGRAM == null &&
                    !Context.PD.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PD_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PD_SUBPROGRAM = new List<PD>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PD_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PEF.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEF> SUBPROGRAM_PEF_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PEF_SUBPROGRAM == null &&
                    !Context.PEF.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PEF_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PEF_SUBPROGRAM = new List<PEF>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PEF_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PEFH.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEFH> SUBPROGRAM_PEFH_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PEFH_SUBPROGRAM == null &&
                    !Context.PEFH.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PEFH_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PEFH_SUBPROGRAM = new List<PEFH>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PEFH_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PEPS.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEPS> SUBPROGRAM_PEPS_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PEPS_SUBPROGRAM == null &&
                    !Context.PEPS.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PEPS_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PEPS_SUBPROGRAM = new List<PEPS>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PEPS_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PEPU.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEPU> SUBPROGRAM_PEPU_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PEPU_SUBPROGRAM == null &&
                    !Context.PEPU.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PEPU_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PEPU_SUBPROGRAM = new List<PEPU>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PEPU_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PEPUH.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PEPUH> SUBPROGRAM_PEPUH_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PEPUH_SUBPROGRAM == null &&
                    !Context.PEPUH.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PEPUH_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PEPUH_SUBPROGRAM = new List<PEPUH>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PEPUH_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PI.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PI> SUBPROGRAM_PI_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PI_SUBPROGRAM == null &&
                    !Context.PI.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PI_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PI_SUBPROGRAM = new List<PI>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PI_SUBPROGRAM;
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [KGLSUB.SUBPROGRAM]-&gt;[PN.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<PN> SUBPROGRAM_PN_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_PN_SUBPROGRAM == null &&
                    !Context.PN.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_PN_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_PN_SUBPROGRAM = new List<PN>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_PN_SUBPROGRAM;
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [KGLSUB.SUBPROGRAM]-&gt;[SA.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<SA> SUBPROGRAM_SA_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_SA_SUBPROGRAM == null &&
                    !Context.SA.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_SA_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_SA_SUBPROGRAM = new List<SA>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_SA_SUBPROGRAM;
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [KGLSUB.SUBPROGRAM]-&gt;[SDFC.SUBPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<SDFC> SUBPROGRAM_SDFC_SUBPROGRAM
        {
            get
            {
                if (Cache_SUBPROGRAM_SDFC_SUBPROGRAM == null &&
                    !Context.SDFC.TryFindBySUBPROGRAM(SUBPROGRAM, out Cache_SUBPROGRAM_SDFC_SUBPROGRAM))
                {
                    Cache_SUBPROGRAM_SDFC_SUBPROGRAM = new List<SDFC>().AsReadOnly();
                }

                return Cache_SUBPROGRAM_SDFC_SUBPROGRAM;
            }
        }

        #endregion

    }
}
