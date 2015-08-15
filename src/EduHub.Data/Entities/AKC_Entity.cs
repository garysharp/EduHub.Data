using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories
    /// </summary>
    public class AKC_Entity : EntityBase
    {
#region Navigation Property Cache
        private GL_Entity _GLCODE_ASS_GL;
        private GL_Entity _GLCODE_PRV_GL;
        private GL_Entity _GLCODE_EXP_GL;
        private GL_Entity _GL_REVALS_BS_GL;
        private GL_Entity _GL_REVALS_PL_GL;
        private GL_Entity _GL_REVALS_ASS_GL;
        private GL_Entity _GL_DISP_PROF_GL;
        private GL_Entity _GL_DISP_PROC_GL;
        private GL_Entity _APTE_GLCODE_GL;
        private KADM_Entity _DEPN_AMETHOD_KADM;
        private KADM_Entity _DEPN_TMETHOD_KADM;
#endregion

#region Field Properties
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
        /// GL Asset Provision for Depn [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE_PRV { get; internal set; }
        /// <summary>
        /// GL Asset Depreciation Code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE_EXP { get; internal set; }
        /// <summary>
        /// GL Asset Revaluations put to [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_REVALS_BS { get; internal set; }
        /// <summary>
        /// GL Asset Revaluations put to P & L [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_REVALS_PL { get; internal set; }
        /// <summary>
        /// GL Code for asset cost of Reval's [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_REVALS_ASS { get; internal set; }
        /// <summary>
        /// GL Asset Profit/Loss on Sale [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_DISP_PROF { get; internal set; }
        /// <summary>
        /// GL Postings Proceeds from Disposals (PL) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GL_DISP_PROC { get; internal set; }
        /// <summary>
        /// GL acct where pte use % of depn will be posted [Uppercase Alphanumeric: u10]
        /// </summary>
        public string APTE_GLCODE { get; internal set; }
        /// <summary>
        /// Percentage of private use for accounting [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Default deprn method for accounts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DEPN_AMETHOD { get; internal set; }
        /// <summary>
        /// Default deprn method for taxation [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DEPN_TMETHOD { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [GLCODE_ASS] => [GL_Entity].[CODE]
        /// GL Asset Code  (Capital)
        /// </summary>
        public GL_Entity GLCODE_ASS_GL {
            get
            {
                if (GLCODE_ASS != null)
                {
                    if (_GLCODE_ASS_GL == null)
                    {
                        _GLCODE_ASS_GL = Context.GL.FindByCODE(GLCODE_ASS);
                    }
                    return _GLCODE_ASS_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GLCODE_PRV] => [GL_Entity].[CODE]
        /// GL Asset Provision for Depn
        /// </summary>
        public GL_Entity GLCODE_PRV_GL {
            get
            {
                if (GLCODE_PRV != null)
                {
                    if (_GLCODE_PRV_GL == null)
                    {
                        _GLCODE_PRV_GL = Context.GL.FindByCODE(GLCODE_PRV);
                    }
                    return _GLCODE_PRV_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GLCODE_EXP] => [GL_Entity].[CODE]
        /// GL Asset Depreciation Code
        /// </summary>
        public GL_Entity GLCODE_EXP_GL {
            get
            {
                if (GLCODE_EXP != null)
                {
                    if (_GLCODE_EXP_GL == null)
                    {
                        _GLCODE_EXP_GL = Context.GL.FindByCODE(GLCODE_EXP);
                    }
                    return _GLCODE_EXP_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GL_REVALS_BS] => [GL_Entity].[CODE]
        /// GL Asset Revaluations put to
        /// </summary>
        public GL_Entity GL_REVALS_BS_GL {
            get
            {
                if (GL_REVALS_BS != null)
                {
                    if (_GL_REVALS_BS_GL == null)
                    {
                        _GL_REVALS_BS_GL = Context.GL.FindByCODE(GL_REVALS_BS);
                    }
                    return _GL_REVALS_BS_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GL_REVALS_PL] => [GL_Entity].[CODE]
        /// GL Asset Revaluations put to P & L
        /// </summary>
        public GL_Entity GL_REVALS_PL_GL {
            get
            {
                if (GL_REVALS_PL != null)
                {
                    if (_GL_REVALS_PL_GL == null)
                    {
                        _GL_REVALS_PL_GL = Context.GL.FindByCODE(GL_REVALS_PL);
                    }
                    return _GL_REVALS_PL_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GL_REVALS_ASS] => [GL_Entity].[CODE]
        /// GL Code for asset cost of Reval's
        /// </summary>
        public GL_Entity GL_REVALS_ASS_GL {
            get
            {
                if (GL_REVALS_ASS != null)
                {
                    if (_GL_REVALS_ASS_GL == null)
                    {
                        _GL_REVALS_ASS_GL = Context.GL.FindByCODE(GL_REVALS_ASS);
                    }
                    return _GL_REVALS_ASS_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GL_DISP_PROF] => [GL_Entity].[CODE]
        /// GL Asset Profit/Loss on Sale
        /// </summary>
        public GL_Entity GL_DISP_PROF_GL {
            get
            {
                if (GL_DISP_PROF != null)
                {
                    if (_GL_DISP_PROF_GL == null)
                    {
                        _GL_DISP_PROF_GL = Context.GL.FindByCODE(GL_DISP_PROF);
                    }
                    return _GL_DISP_PROF_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GL_DISP_PROC] => [GL_Entity].[CODE]
        /// GL Postings Proceeds from Disposals (PL)
        /// </summary>
        public GL_Entity GL_DISP_PROC_GL {
            get
            {
                if (GL_DISP_PROC != null)
                {
                    if (_GL_DISP_PROC_GL == null)
                    {
                        _GL_DISP_PROC_GL = Context.GL.FindByCODE(GL_DISP_PROC);
                    }
                    return _GL_DISP_PROC_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [APTE_GLCODE] => [GL_Entity].[CODE]
        /// GL acct where pte use % of depn will be posted
        /// </summary>
        public GL_Entity APTE_GLCODE_GL {
            get
            {
                if (APTE_GLCODE != null)
                {
                    if (_APTE_GLCODE_GL == null)
                    {
                        _APTE_GLCODE_GL = Context.GL.FindByCODE(APTE_GLCODE);
                    }
                    return _APTE_GLCODE_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DEPN_AMETHOD] => [KADM_Entity].[KADMKEY]
        /// Default deprn method for accounts
        /// </summary>
        public KADM_Entity DEPN_AMETHOD_KADM {
            get
            {
                if (DEPN_AMETHOD != null)
                {
                    if (_DEPN_AMETHOD_KADM == null)
                    {
                        _DEPN_AMETHOD_KADM = Context.KADM.FindByKADMKEY(DEPN_AMETHOD);
                    }
                    return _DEPN_AMETHOD_KADM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DEPN_TMETHOD] => [KADM_Entity].[KADMKEY]
        /// Default deprn method for taxation
        /// </summary>
        public KADM_Entity DEPN_TMETHOD_KADM {
            get
            {
                if (DEPN_TMETHOD != null)
                {
                    if (_DEPN_TMETHOD_KADM == null)
                    {
                        _DEPN_TMETHOD_KADM = Context.KADM.FindByKADMKEY(DEPN_TMETHOD);
                    }
                    return _DEPN_TMETHOD_KADM;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
