using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Last Years General Ledger
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLPREV : EduHubEntity
    {

        #region Navigation Property Cache

        private KGLT Cache_GL_TYPE_KGLT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<GLCFPREV> Cache_CODE_GLCFPREV_CODE;
        private IReadOnlyList<GLFPREV> Cache_CODE_GLFPREV_CODE;

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
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR01 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR02 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR03 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR04 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR05 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR06 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR07 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR08 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR09 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR10 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
        /// </summary>
        public decimal? LASTYR11 { get; internal set; }

        /// <summary>
        /// Last year monthly balances
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
        /// Allow account to be processed (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BATCHABLE { get; internal set; }

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
        /// KGLT (General Ledger Account Types) related entity by [GLPREV.GL_TYPE]-&gt;[KGLT.GL_TYPE]
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
        /// GLCFPREV (Last Years GL Combined Financial Trans) related entities by [GLPREV.CODE]-&gt;[GLCFPREV.CODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<GLCFPREV> CODE_GLCFPREV_CODE
        {
            get
            {
                if (Cache_CODE_GLCFPREV_CODE == null &&
                    !Context.GLCFPREV.TryFindByCODE(CODE, out Cache_CODE_GLCFPREV_CODE))
                {
                    Cache_CODE_GLCFPREV_CODE = new List<GLCFPREV>().AsReadOnly();
                }

                return Cache_CODE_GLCFPREV_CODE;
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [GLPREV.CODE]-&gt;[GLFPREV.CODE]
        /// General Ledger code (Prime Key)
        /// </summary>
        public IReadOnlyList<GLFPREV> CODE_GLFPREV_CODE
        {
            get
            {
                if (Cache_CODE_GLFPREV_CODE == null &&
                    !Context.GLFPREV.TryFindByCODE(CODE, out Cache_CODE_GLFPREV_CODE))
                {
                    Cache_CODE_GLFPREV_CODE = new List<GLFPREV>().AsReadOnly();
                }

                return Cache_CODE_GLFPREV_CODE;
            }
        }

        #endregion

    }
}
