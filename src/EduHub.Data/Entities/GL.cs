using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GL : EduHubEntity
    {

        #region Navigation Property Cache

        private KGLT Cache_GL_TYPE_KGLT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<AKC> Cache_CODE_AKC_GLCODE_ASS;
        private IReadOnlyList<AKC> Cache_CODE_AKC_GLCODE_PRV;
        private IReadOnlyList<AKC> Cache_CODE_AKC_GLCODE_EXP;
        private IReadOnlyList<AKC> Cache_CODE_AKC_GL_REVALS_BS;
        private IReadOnlyList<AKC> Cache_CODE_AKC_GL_REVALS_PL;
        private IReadOnlyList<AKC> Cache_CODE_AKC_GL_REVALS_ASS;
        private IReadOnlyList<AKC> Cache_CODE_AKC_GL_DISP_PROF;
        private IReadOnlyList<AKC> Cache_CODE_AKC_GL_DISP_PROC;
        private IReadOnlyList<AKC> Cache_CODE_AKC_APTE_GLCODE;
        private IReadOnlyList<AR> Cache_CODE_AR_PTE_GLCODE;
        private IReadOnlyList<GLBUDG> Cache_CODE_GLBUDG_CODE;
        private IReadOnlyList<GLCF> Cache_CODE_GLCF_CODE;
        private IReadOnlyList<GLF> Cache_CODE_GLF_CODE;
        private IReadOnlyList<KGST> Cache_CODE_KGST_GLGST_CODE;
        private IReadOnlyList<PC> Cache_CODE_PC_GLCODE;
        private IReadOnlyList<PD> Cache_CODE_PD_GLCODE;
        private IReadOnlyList<PD> Cache_CODE_PD_GLBANK;
        private IReadOnlyList<PD> Cache_CODE_PD_GLTAX;
        private IReadOnlyList<PF> Cache_CODE_PF_GLCODE;
        private IReadOnlyList<PI> Cache_CODE_PI_CLR_GLCODE;
        private IReadOnlyList<PN> Cache_CODE_PN_GLCODE;
        private IReadOnlyList<PN> Cache_CODE_PN_GLBANK;
        private IReadOnlyList<PN> Cache_CODE_PN_GLTAX;
        private IReadOnlyList<SA> Cache_CODE_SA_GLCODE;
        private IReadOnlyList<SDFC> Cache_CODE_SDFC_GLCODE;

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
                if (GL_TYPE == null)
                {
                    return null;
                }
                if (Cache_GL_TYPE_KGLT == null)
                {
                    Cache_GL_TYPE_KGLT = Context.KGLT.FindByGL_TYPE(GL_TYPE);
                }

                return Cache_GL_TYPE_KGLT;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GLCODE_ASS]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GLCODE_ASS
        {
            get
            {
                if (Cache_CODE_AKC_GLCODE_ASS == null &&
                    !Context.AKC.TryFindByGLCODE_ASS(CODE, out Cache_CODE_AKC_GLCODE_ASS))
                {
                    Cache_CODE_AKC_GLCODE_ASS = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GLCODE_ASS;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GLCODE_PRV]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GLCODE_PRV
        {
            get
            {
                if (Cache_CODE_AKC_GLCODE_PRV == null &&
                    !Context.AKC.TryFindByGLCODE_PRV(CODE, out Cache_CODE_AKC_GLCODE_PRV))
                {
                    Cache_CODE_AKC_GLCODE_PRV = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GLCODE_PRV;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GLCODE_EXP]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GLCODE_EXP
        {
            get
            {
                if (Cache_CODE_AKC_GLCODE_EXP == null &&
                    !Context.AKC.TryFindByGLCODE_EXP(CODE, out Cache_CODE_AKC_GLCODE_EXP))
                {
                    Cache_CODE_AKC_GLCODE_EXP = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GLCODE_EXP;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GL_REVALS_BS]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GL_REVALS_BS
        {
            get
            {
                if (Cache_CODE_AKC_GL_REVALS_BS == null &&
                    !Context.AKC.TryFindByGL_REVALS_BS(CODE, out Cache_CODE_AKC_GL_REVALS_BS))
                {
                    Cache_CODE_AKC_GL_REVALS_BS = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GL_REVALS_BS;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GL_REVALS_PL]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GL_REVALS_PL
        {
            get
            {
                if (Cache_CODE_AKC_GL_REVALS_PL == null &&
                    !Context.AKC.TryFindByGL_REVALS_PL(CODE, out Cache_CODE_AKC_GL_REVALS_PL))
                {
                    Cache_CODE_AKC_GL_REVALS_PL = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GL_REVALS_PL;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GL_REVALS_ASS]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GL_REVALS_ASS
        {
            get
            {
                if (Cache_CODE_AKC_GL_REVALS_ASS == null &&
                    !Context.AKC.TryFindByGL_REVALS_ASS(CODE, out Cache_CODE_AKC_GL_REVALS_ASS))
                {
                    Cache_CODE_AKC_GL_REVALS_ASS = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GL_REVALS_ASS;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GL_DISP_PROF]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GL_DISP_PROF
        {
            get
            {
                if (Cache_CODE_AKC_GL_DISP_PROF == null &&
                    !Context.AKC.TryFindByGL_DISP_PROF(CODE, out Cache_CODE_AKC_GL_DISP_PROF))
                {
                    Cache_CODE_AKC_GL_DISP_PROF = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GL_DISP_PROF;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.GL_DISP_PROC]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_GL_DISP_PROC
        {
            get
            {
                if (Cache_CODE_AKC_GL_DISP_PROC == null &&
                    !Context.AKC.TryFindByGL_DISP_PROC(CODE, out Cache_CODE_AKC_GL_DISP_PROC))
                {
                    Cache_CODE_AKC_GL_DISP_PROC = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_GL_DISP_PROC;
            }
        }

        /// <summary>
        /// AKC (Assets - Categories) related entities by [GL.CODE]-&gt;[AKC.APTE_GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AKC> CODE_AKC_APTE_GLCODE
        {
            get
            {
                if (Cache_CODE_AKC_APTE_GLCODE == null &&
                    !Context.AKC.TryFindByAPTE_GLCODE(CODE, out Cache_CODE_AKC_APTE_GLCODE))
                {
                    Cache_CODE_AKC_APTE_GLCODE = new List<AKC>().AsReadOnly();
                }

                return Cache_CODE_AKC_APTE_GLCODE;
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [GL.CODE]-&gt;[AR.PTE_GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<AR> CODE_AR_PTE_GLCODE
        {
            get
            {
                if (Cache_CODE_AR_PTE_GLCODE == null &&
                    !Context.AR.TryFindByPTE_GLCODE(CODE, out Cache_CODE_AR_PTE_GLCODE))
                {
                    Cache_CODE_AR_PTE_GLCODE = new List<AR>().AsReadOnly();
                }

                return Cache_CODE_AR_PTE_GLCODE;
            }
        }

        /// <summary>
        /// GLBUDG (General Ledger Budgets) related entities by [GL.CODE]-&gt;[GLBUDG.CODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<GLBUDG> CODE_GLBUDG_CODE
        {
            get
            {
                if (Cache_CODE_GLBUDG_CODE == null &&
                    !Context.GLBUDG.TryFindByCODE(CODE, out Cache_CODE_GLBUDG_CODE))
                {
                    Cache_CODE_GLBUDG_CODE = new List<GLBUDG>().AsReadOnly();
                }

                return Cache_CODE_GLBUDG_CODE;
            }
        }

        /// <summary>
        /// GLCF (GL Combined Financial Trans) related entities by [GL.CODE]-&gt;[GLCF.CODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<GLCF> CODE_GLCF_CODE
        {
            get
            {
                if (Cache_CODE_GLCF_CODE == null &&
                    !Context.GLCF.TryFindByCODE(CODE, out Cache_CODE_GLCF_CODE))
                {
                    Cache_CODE_GLCF_CODE = new List<GLCF>().AsReadOnly();
                }

                return Cache_CODE_GLCF_CODE;
            }
        }

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [GL.CODE]-&gt;[GLF.CODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<GLF> CODE_GLF_CODE
        {
            get
            {
                if (Cache_CODE_GLF_CODE == null &&
                    !Context.GLF.TryFindByCODE(CODE, out Cache_CODE_GLF_CODE))
                {
                    Cache_CODE_GLF_CODE = new List<GLF>().AsReadOnly();
                }

                return Cache_CODE_GLF_CODE;
            }
        }

        /// <summary>
        /// KGST (GST Percentages) related entities by [GL.CODE]-&gt;[KGST.GLGST_CODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<KGST> CODE_KGST_GLGST_CODE
        {
            get
            {
                if (Cache_CODE_KGST_GLGST_CODE == null &&
                    !Context.KGST.TryFindByGLGST_CODE(CODE, out Cache_CODE_KGST_GLGST_CODE))
                {
                    Cache_CODE_KGST_GLGST_CODE = new List<KGST>().AsReadOnly();
                }

                return Cache_CODE_KGST_GLGST_CODE;
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entities by [GL.CODE]-&gt;[PC.GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PC> CODE_PC_GLCODE
        {
            get
            {
                if (Cache_CODE_PC_GLCODE == null &&
                    !Context.PC.TryFindByGLCODE(CODE, out Cache_CODE_PC_GLCODE))
                {
                    Cache_CODE_PC_GLCODE = new List<PC>().AsReadOnly();
                }

                return Cache_CODE_PC_GLCODE;
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [GL.CODE]-&gt;[PD.GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PD> CODE_PD_GLCODE
        {
            get
            {
                if (Cache_CODE_PD_GLCODE == null &&
                    !Context.PD.TryFindByGLCODE(CODE, out Cache_CODE_PD_GLCODE))
                {
                    Cache_CODE_PD_GLCODE = new List<PD>().AsReadOnly();
                }

                return Cache_CODE_PD_GLCODE;
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [GL.CODE]-&gt;[PD.GLBANK]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PD> CODE_PD_GLBANK
        {
            get
            {
                if (Cache_CODE_PD_GLBANK == null &&
                    !Context.PD.TryFindByGLBANK(CODE, out Cache_CODE_PD_GLBANK))
                {
                    Cache_CODE_PD_GLBANK = new List<PD>().AsReadOnly();
                }

                return Cache_CODE_PD_GLBANK;
            }
        }

        /// <summary>
        /// PD (Departments) related entities by [GL.CODE]-&gt;[PD.GLTAX]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PD> CODE_PD_GLTAX
        {
            get
            {
                if (Cache_CODE_PD_GLTAX == null &&
                    !Context.PD.TryFindByGLTAX(CODE, out Cache_CODE_PD_GLTAX))
                {
                    Cache_CODE_PD_GLTAX = new List<PD>().AsReadOnly();
                }

                return Cache_CODE_PD_GLTAX;
            }
        }

        /// <summary>
        /// PF (Superannuation Funds) related entities by [GL.CODE]-&gt;[PF.GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PF> CODE_PF_GLCODE
        {
            get
            {
                if (Cache_CODE_PF_GLCODE == null &&
                    !Context.PF.TryFindByGLCODE(CODE, out Cache_CODE_PF_GLCODE))
                {
                    Cache_CODE_PF_GLCODE = new List<PF>().AsReadOnly();
                }

                return Cache_CODE_PF_GLCODE;
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [GL.CODE]-&gt;[PI.CLR_GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PI> CODE_PI_CLR_GLCODE
        {
            get
            {
                if (Cache_CODE_PI_CLR_GLCODE == null &&
                    !Context.PI.TryFindByCLR_GLCODE(CODE, out Cache_CODE_PI_CLR_GLCODE))
                {
                    Cache_CODE_PI_CLR_GLCODE = new List<PI>().AsReadOnly();
                }

                return Cache_CODE_PI_CLR_GLCODE;
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [GL.CODE]-&gt;[PN.GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PN> CODE_PN_GLCODE
        {
            get
            {
                if (Cache_CODE_PN_GLCODE == null &&
                    !Context.PN.TryFindByGLCODE(CODE, out Cache_CODE_PN_GLCODE))
                {
                    Cache_CODE_PN_GLCODE = new List<PN>().AsReadOnly();
                }

                return Cache_CODE_PN_GLCODE;
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [GL.CODE]-&gt;[PN.GLBANK]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PN> CODE_PN_GLBANK
        {
            get
            {
                if (Cache_CODE_PN_GLBANK == null &&
                    !Context.PN.TryFindByGLBANK(CODE, out Cache_CODE_PN_GLBANK))
                {
                    Cache_CODE_PN_GLBANK = new List<PN>().AsReadOnly();
                }

                return Cache_CODE_PN_GLBANK;
            }
        }

        /// <summary>
        /// PN (Payroll Groups) related entities by [GL.CODE]-&gt;[PN.GLTAX]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<PN> CODE_PN_GLTAX
        {
            get
            {
                if (Cache_CODE_PN_GLTAX == null &&
                    !Context.PN.TryFindByGLTAX(CODE, out Cache_CODE_PN_GLTAX))
                {
                    Cache_CODE_PN_GLTAX = new List<PN>().AsReadOnly();
                }

                return Cache_CODE_PN_GLTAX;
            }
        }

        /// <summary>
        /// SA (Fees) related entities by [GL.CODE]-&gt;[SA.GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<SA> CODE_SA_GLCODE
        {
            get
            {
                if (Cache_CODE_SA_GLCODE == null &&
                    !Context.SA.TryFindByGLCODE(CODE, out Cache_CODE_SA_GLCODE))
                {
                    Cache_CODE_SA_GLCODE = new List<SA>().AsReadOnly();
                }

                return Cache_CODE_SA_GLCODE;
            }
        }

        /// <summary>
        /// SDFC (Sundry Debtor Fees) related entities by [GL.CODE]-&gt;[SDFC.GLCODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<SDFC> CODE_SDFC_GLCODE
        {
            get
            {
                if (Cache_CODE_SDFC_GLCODE == null &&
                    !Context.SDFC.TryFindByGLCODE(CODE, out Cache_CODE_SDFC_GLCODE))
                {
                    Cache_CODE_SDFC_GLCODE = new List<SDFC>().AsReadOnly();
                }

                return Cache_CODE_SDFC_GLCODE;
            }
        }

        #endregion

    }
}
