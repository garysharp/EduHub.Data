using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Budgets
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLBUDG : EduHubEntity
    {

        #region Navigation Property Cache

        private GL Cache_CODE_GL;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<GLFBUDG> Cache_BUDGETKEY_GLFBUDG_BKEY;

        #endregion

        #region Field Properties

        /// <summary>
        /// Combination of subprog,prog,code,init
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string BUDGETKEY { get; internal set; }

        /// <summary>
        /// Must already exist as a SUBPROGRAM
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// eg, INCOME
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// GL Account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GL_PROGRAM { get; internal set; }

        /// <summary>
        /// Not mandatory
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR01 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR02 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR03 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR04 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR05 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR06 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR07 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR08 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR09 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR10 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR11 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? CURR12 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? OPBAL { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR01 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR02 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR03 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR04 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR05 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR06 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR07 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR08 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR09 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR10 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR11 { get; internal set; }

        /// <summary>
        /// Not used but required fields
        /// </summary>
        public decimal? LASTYR12 { get; internal set; }

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
        /// Imported Y/N
        /// [Alphanumeric (1)]
        /// </summary>
        public string IMPORTED { get; internal set; }

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
        /// GL (General Ledger) related entity by [GLBUDG.CODE]-&gt;[GL.CODE]
        /// GL Account
        /// </summary>
        public GL CODE_GL
        {
            get
            {
                if (CODE == null)
                {
                    return null;
                }
                if (Cache_CODE_GL == null)
                {
                    Cache_CODE_GL = Context.GL.FindByCODE(CODE);
                }

                return Cache_CODE_GL;
            }
        }

        /// <summary>
        /// KGLINIT (General Ledger Initiatives) related entity by [GLBUDG.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Not mandatory
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
            get
            {
                if (INITIATIVE == null)
                {
                    return null;
                }
                if (Cache_INITIATIVE_KGLINIT == null)
                {
                    Cache_INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                }

                return Cache_INITIATIVE_KGLINIT;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// GLFBUDG (SP2 dummy table) related entities by [GLBUDG.BUDGETKEY]-&gt;[GLFBUDG.BKEY]
        /// Combination of subprog,prog,code,init
        /// </summary>
        public IReadOnlyList<GLFBUDG> BUDGETKEY_GLFBUDG_BKEY
        {
            get
            {
                if (Cache_BUDGETKEY_GLFBUDG_BKEY == null &&
                    !Context.GLFBUDG.TryFindByBKEY(BUDGETKEY, out Cache_BUDGETKEY_GLFBUDG_BKEY))
                {
                    Cache_BUDGETKEY_GLFBUDG_BKEY = new List<GLFBUDG>().AsReadOnly();
                }

                return Cache_BUDGETKEY_GLFBUDG_BKEY;
            }
        }

        #endregion

    }
}
