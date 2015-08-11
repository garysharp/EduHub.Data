using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories
    /// </summary>
    public class AKC_Entity : EntityBase
    {
        /// <summary>
        /// Prime Key (formerly GROUP) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Description of category [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// GL Asset Code  (Capital) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE_ASS { get; internal set; }
        /// <summary>
        /// Navigation property for [GLCODE_ASS] => [GL_Entity].[CODE]
        /// GL Asset Code  (Capital)
        /// </summary>
        public GL_Entity GLCODE_ASS_GL { get { return GLCODE_ASS == null ? null : Context.GL.FindByCODE(GLCODE_ASS); } }
        /// <summary>
        /// GL Asset Provision for Depn [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE_PRV { get; internal set; }
        /// <summary>
        /// Navigation property for [GLCODE_PRV] => [GL_Entity].[CODE]
        /// GL Asset Provision for Depn
        /// </summary>
        public GL_Entity GLCODE_PRV_GL { get { return GLCODE_PRV == null ? null : Context.GL.FindByCODE(GLCODE_PRV); } }
        /// <summary>
        /// GL Asset Depreciation Code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE_EXP { get; internal set; }
        /// <summary>
        /// Navigation property for [GLCODE_EXP] => [GL_Entity].[CODE]
        /// GL Asset Depreciation Code
        /// </summary>
        public GL_Entity GLCODE_EXP_GL { get { return GLCODE_EXP == null ? null : Context.GL.FindByCODE(GLCODE_EXP); } }
        /// <summary>
        /// GL Asset Revaluations put to [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_REVALS_BS { get; internal set; }
        /// <summary>
        /// Navigation property for [GL_REVALS_BS] => [GL_Entity].[CODE]
        /// GL Asset Revaluations put to
        /// </summary>
        public GL_Entity GL_REVALS_BS_GL { get { return GL_REVALS_BS == null ? null : Context.GL.FindByCODE(GL_REVALS_BS); } }
        /// <summary>
        /// GL Asset Revaluations put to P & L [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_REVALS_PL { get; internal set; }
        /// <summary>
        /// Navigation property for [GL_REVALS_PL] => [GL_Entity].[CODE]
        /// GL Asset Revaluations put to P & L
        /// </summary>
        public GL_Entity GL_REVALS_PL_GL { get { return GL_REVALS_PL == null ? null : Context.GL.FindByCODE(GL_REVALS_PL); } }
        /// <summary>
        /// GL Code for asset cost of Reval's [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_REVALS_ASS { get; internal set; }
        /// <summary>
        /// Navigation property for [GL_REVALS_ASS] => [GL_Entity].[CODE]
        /// GL Code for asset cost of Reval's
        /// </summary>
        public GL_Entity GL_REVALS_ASS_GL { get { return GL_REVALS_ASS == null ? null : Context.GL.FindByCODE(GL_REVALS_ASS); } }
        /// <summary>
        /// GL Asset Profit/Loss on Sale [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_DISP_PROF { get; internal set; }
        /// <summary>
        /// Navigation property for [GL_DISP_PROF] => [GL_Entity].[CODE]
        /// GL Asset Profit/Loss on Sale
        /// </summary>
        public GL_Entity GL_DISP_PROF_GL { get { return GL_DISP_PROF == null ? null : Context.GL.FindByCODE(GL_DISP_PROF); } }
        /// <summary>
        /// GL Postings Proceeds from Disposals (PL) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_DISP_PROC { get; internal set; }
        /// <summary>
        /// Navigation property for [GL_DISP_PROC] => [GL_Entity].[CODE]
        /// GL Postings Proceeds from Disposals (PL)
        /// </summary>
        public GL_Entity GL_DISP_PROC_GL { get { return GL_DISP_PROC == null ? null : Context.GL.FindByCODE(GL_DISP_PROC); } }
        /// <summary>
        /// GL acct where pte use % of depn will be posted [Uppercase Alphanumeric: u10]
        /// </summary>
        public string APTE_GLCODE { get; internal set; }
        /// <summary>
        /// Navigation property for [APTE_GLCODE] => [GL_Entity].[CODE]
        /// GL acct where pte use % of depn will be posted
        /// </summary>
        public GL_Entity APTE_GLCODE_GL { get { return APTE_GLCODE == null ? null : Context.GL.FindByCODE(APTE_GLCODE); } }
        /// <summary>
        /// Percentage of private use for accounting [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Default deprn method for accounts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DEPN_AMETHOD { get; internal set; }
        /// <summary>
        /// Navigation property for [DEPN_AMETHOD] => [KADM_Entity].[KADMKEY]
        /// Default deprn method for accounts
        /// </summary>
        public KADM_Entity DEPN_AMETHOD_KADM { get { return DEPN_AMETHOD == null ? null : Context.KADM.FindByKADMKEY(DEPN_AMETHOD); } }
        /// <summary>
        /// Default deprn method for taxation [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DEPN_TMETHOD { get; internal set; }
        /// <summary>
        /// Navigation property for [DEPN_TMETHOD] => [KADM_Entity].[KADMKEY]
        /// Default deprn method for taxation
        /// </summary>
        public KADM_Entity DEPN_TMETHOD_KADM { get { return DEPN_TMETHOD == null ? null : Context.KADM.FindByKADMKEY(DEPN_TMETHOD); } }
        /// <summary>
        /// Default deprn rate for accounts [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DEPN_ARATE { get; internal set; }
        /// <summary>
        /// Percentage of private use for accounting [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? APTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Default deprn rate for taxation [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DEPN_TRATE { get; internal set; }
        /// <summary>
        /// Percentage of private use for tax [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TPTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Expected life of asset [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXPECTED_LIFE { get; internal set; }
        /// <summary>
        /// Send to DE&T Flag [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SEND_TO_FLAG { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// V48 destination category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string MAP_CATEGORY { get; internal set; }
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
