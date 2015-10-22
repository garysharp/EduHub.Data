using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger
    /// </summary>
    public partial class GL : EntityBase
    {
#region Navigation Property Cache
        private KGLT _GL_TYPE_KGLT;
#endregion

#region Field Properties
        /// <summary>
        /// General Ledger code (Prime Key)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Account title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Opening balance
        /// </summary>
        public decimal? OPBAL { get; internal set; }
        /// <summary>
        /// Last year opening balance
        /// </summary>
        public decimal? LYROPBAL { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR01 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR02 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR03 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR04 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR05 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR06 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR07 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR08 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR09 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR10 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR11 { get; internal set; }
        /// <summary>
        /// OLDNAME=LAST;* Last year monthly balances
        /// </summary>
        public decimal? LASTYR12 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR01 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR02 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR03 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR04 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR05 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR06 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR07 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR08 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR09 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR10 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR11 { get; internal set; }
        /// <summary>
        /// This year monthly balances
        /// </summary>
        public decimal? CURR12 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG01 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG02 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG03 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG04 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG05 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG06 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG07 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG08 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG09 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG10 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG11 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year
        /// </summary>
        public decimal? BUDG12 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG01 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG02 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG03 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG04 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG05 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG06 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG07 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG08 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG09 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG10 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG11 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year
        /// </summary>
        public decimal? NEXTBUDG12 { get; internal set; }
        /// <summary>
        /// Annual budget this year
        /// </summary>
        public decimal? ANNUALBUDG { get; internal set; }
        /// <summary>
        /// Annual budget next year
        /// </summary>
        public decimal? NEXT_ANN_BUDG { get; internal set; }
        /// <summary>
        /// Revised annual budget this year
        /// </summary>
        public decimal? REV_ANN_BUDG { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG01 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG02 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG03 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG04 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG05 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG06 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG07 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG08 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG09 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG10 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG11 { get; internal set; }
        /// <summary>
        /// Monthly revised budgets this year
        /// </summary>
        public decimal? REV_BUDG12 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG01 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG02 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG03 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG04 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG05 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG06 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG07 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG08 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG09 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG10 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG11 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year
        /// </summary>
        public decimal? LASTBUDG12 { get; internal set; }
        /// <summary>
        /// Annual budget last year
        /// </summary>
        public decimal? LAST_ANN_BUDG { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT01 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT02 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT03 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT04 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT05 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT06 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT07 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT08 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT09 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT10 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT11 { get; internal set; }
        /// <summary>
        /// Orders committed against this code
        /// </summary>
        public decimal? COMMITMENT12 { get; internal set; }
        /// <summary>
        /// Highest transaction date
        /// </summary>
        public DateTime? HIDATE { get; internal set; }
        /// <summary>
        /// Income/expense/Liabitiy etc
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_TYPE { get; internal set; }
        /// <summary>
        /// Allow account to be used(Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// Allow editing of description by users
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string USER_DEFINABLE { get; internal set; }
        /// <summary>
        /// Potential FBT liability when this code is used Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FBT { get; internal set; }
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
        /// KGLT (General Ledger Account Types) related entity by [GL.GL_TYPE]-&gt;[KGLT.GL_TYPE]
        /// Income/expense/Liabitiy etc
        /// </summary>
        public KGLT GL_TYPE_KGLT
        {
            get
            {
                if (GL_TYPE != null)
                {
                    if (_GL_TYPE_KGLT == null)
                    {
                        _GL_TYPE_KGLT = Context.KGLT.FindByGL_TYPE(GL_TYPE);
                    }
                    return _GL_TYPE_KGLT;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GLCODE_ASS]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GLCODE_ASS
        {
            get
            {
                return Context.GL.FindAKCByGLCODE_ASS(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GLCODE_PRV]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GLCODE_PRV
        {
            get
            {
                return Context.GL.FindAKCByGLCODE_PRV(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GLCODE_EXP]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GLCODE_EXP
        {
            get
            {
                return Context.GL.FindAKCByGLCODE_EXP(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GL_REVALS_BS]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GL_REVALS_BS
        {
            get
            {
                return Context.GL.FindAKCByGL_REVALS_BS(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GL_REVALS_PL]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GL_REVALS_PL
        {
            get
            {
                return Context.GL.FindAKCByGL_REVALS_PL(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GL_REVALS_ASS]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GL_REVALS_ASS
        {
            get
            {
                return Context.GL.FindAKCByGL_REVALS_ASS(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GL_DISP_PROF]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GL_DISP_PROF
        {
            get
            {
                return Context.GL.FindAKCByGL_DISP_PROF(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.GL_DISP_PROC]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_GL_DISP_PROC
        {
            get
            {
                return Context.GL.FindAKCByGL_DISP_PROC(CODE);
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [AKC.APTE_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AKC> AKC_APTE_GLCODE
        {
            get
            {
                return Context.GL.FindAKCByAPTE_GLCODE(CODE);
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [AR.PTE_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<AR> AR_PTE_GLCODE
        {
            get
            {
                return Context.GL.FindARByPTE_GLCODE(CODE);
            }
        }

        /// <summary>
        /// GLBUDG (General Ledger Budgets) related entities by [GLBUDG.CODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<GLBUDG> GLBUDG_CODE
        {
            get
            {
                return Context.GL.FindGLBUDGByCODE(CODE);
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [GLCF.CODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<GLCF> GLCF_CODE
        {
            get
            {
                return Context.GL.FindGLCFByCODE(CODE);
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [GLF.CODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<GLF> GLF_CODE
        {
            get
            {
                return Context.GL.FindGLFByCODE(CODE);
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entities by [KGST.GLGST_CODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<KGST> KGST_GLGST_CODE
        {
            get
            {
                return Context.GL.FindKGSTByGLGST_CODE(CODE);
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entities by [PC.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PC> PC_GLCODE
        {
            get
            {
                return Context.GL.FindPCByGLCODE(CODE);
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [PD.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PD> PD_GLCODE
        {
            get
            {
                return Context.GL.FindPDByGLCODE(CODE);
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [PD.GLBANK]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PD> PD_GLBANK
        {
            get
            {
                return Context.GL.FindPDByGLBANK(CODE);
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [PD.GLTAX]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PD> PD_GLTAX
        {
            get
            {
                return Context.GL.FindPDByGLTAX(CODE);
            }
        }

        /// <summary>
        /// PF (Superannuation Funds) related entities by [PF.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PF> PF_GLCODE
        {
            get
            {
                return Context.GL.FindPFByGLCODE(CODE);
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [PI.CLR_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PI> PI_CLR_GLCODE
        {
            get
            {
                return Context.GL.FindPIByCLR_GLCODE(CODE);
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [PN.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PN> PN_GLCODE
        {
            get
            {
                return Context.GL.FindPNByGLCODE(CODE);
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [PN.GLBANK]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PN> PN_GLBANK
        {
            get
            {
                return Context.GL.FindPNByGLBANK(CODE);
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [PN.GLTAX]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<PN> PN_GLTAX
        {
            get
            {
                return Context.GL.FindPNByGLTAX(CODE);
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [SA.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<SA> SA_GLCODE
        {
            get
            {
                return Context.GL.FindSAByGLCODE(CODE);
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [SDFC.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        public IReadOnlyList<SDFC> SDFC_GLCODE
        {
            get
            {
                return Context.GL.FindSDFCByGLCODE(CODE);
            }
        }
#endregion
    }
}
