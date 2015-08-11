using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Budgets
    /// </summary>
    public class GLBUDG_Entity : EntityBase
    {
        /// <summary>
        /// Combination of subprog,prog,code,init [Uppercase Alphanumeric: u15]
        /// </summary>
        public string BUDGETKEY { get; internal set; }
        /// <summary>
        /// Must already exist as a SUBPROGRAM [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// eg, INCOME [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// GL Account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [GL_Entity].[CODE]
        /// GL Account
        /// </summary>
        public GL_Entity CODE_GL { get { return CODE == null ? null : Context.GL.FindByCODE(CODE); } }
        /// <summary>
        /// Program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GL_PROGRAM { get; internal set; }
        /// <summary>
        /// Not mandatory [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Not mandatory
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT { get { return INITIATIVE == null ? null : Context.KGLINIT.FindByINITIATIVE(INITIATIVE); } }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR01 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR02 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR03 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR04 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR05 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR06 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR07 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR08 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR09 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR10 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR11 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CURR12 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OPBAL { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR01 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR02 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR03 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR04 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR05 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR06 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR07 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR08 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR09 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR10 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR11 { get; internal set; }
        /// <summary>
        /// Not used but required fields [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTYR12 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG01 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG02 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG03 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG04 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG05 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG06 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG07 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG08 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG09 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG10 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG11 { get; internal set; }
        /// <summary>
        /// Monthly budgets this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? BUDG12 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG01 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG02 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG03 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG04 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG05 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG06 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG07 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG08 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG09 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG10 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG11 { get; internal set; }
        /// <summary>
        /// Monthly budgets next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXTBUDG12 { get; internal set; }
        /// <summary>
        /// Annual budget this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ANNUALBUDG { get; internal set; }
        /// <summary>
        /// Annual budget next year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? NEXT_ANN_BUDG { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG01 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG02 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG03 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG04 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG05 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG06 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG07 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG08 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG09 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG10 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG11 { get; internal set; }
        /// <summary>
        /// Monthly budgets last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LASTBUDG12 { get; internal set; }
        /// <summary>
        /// Annual budget last year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LAST_ANN_BUDG { get; internal set; }
        /// <summary>
        /// Imported Y/N [Alphanumeric: a1]
        /// </summary>
        public string IMPORTED { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
