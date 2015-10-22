using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Sub Programs
    /// </summary>
    public partial class KGLSUB : EntityBase
    {
#region Navigation Property Cache
        private KGLPROG _GL_PROGRAM_KGLPROG;
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
                if (GL_PROGRAM != null)
                {
                    if (_GL_PROGRAM_KGLPROG == null)
                    {
                        _GL_PROGRAM_KGLPROG = Context.KGLPROG.FindByGLPROGRAM(GL_PROGRAM);
                    }
                    return _GL_PROGRAM_KGLPROG;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [ARF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<ARF> ARF_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindARFBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [CRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<CRF> CRF_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindCRFBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// DFF (Family Financial Transactions) related entities by [DFF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<DFF> DFF_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindDFFBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// DRF (DR Transactions) related entities by [DRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<DRF> DRF_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindDRFBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [GLCF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<GLCF> GLCF_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindGLCFBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// GLCFPREV (Last Years GL Combined Financial Trans) related entities by [GLCFPREV.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<GLCFPREV> GLCFPREV_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindGLCFPREVBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [GLF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<GLF> GLF_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindGLFBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [GLFPREV.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<GLFPREV> GLFPREV_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindGLFPREVBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entities by [PC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PC> PC_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPCBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [PD.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PD> PD_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPDBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PEF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PEF> PEF_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPEFBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PEFH.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PEFH> PEFH_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPEFHBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PEPS.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PEPS> PEPS_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPEPSBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [PEPU.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PEPU> PEPU_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPEPUBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [PEPUH.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PEPUH> PEPUH_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPEPUHBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [PI.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PI> PI_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPIBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [PN.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<PN> PN_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindPNBySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [SA.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<SA> SA_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindSABySUBPROGRAM(SUBPROGRAM);
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [SDFC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        public IReadOnlyList<SDFC> SDFC_SUBPROGRAM
        {
            get
            {
                return Context.KGLSUB.FindSDFCBySUBPROGRAM(SUBPROGRAM);
            }
        }
#endregion
    }
}
