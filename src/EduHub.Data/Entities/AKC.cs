using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories
    /// </summary>
    public partial class AKC : EntityBase
    {
#region Navigation Property Cache
        private GL _GLCODE_ASS_GL;
        private GL _GLCODE_PRV_GL;
        private GL _GLCODE_EXP_GL;
        private GL _GL_REVALS_BS_GL;
        private GL _GL_REVALS_PL_GL;
        private GL _GL_REVALS_ASS_GL;
        private GL _GL_DISP_PROF_GL;
        private GL _GL_DISP_PROC_GL;
        private GL _APTE_GLCODE_GL;
        private KADM _DEPN_AMETHOD_KADM;
        private KADM _DEPN_TMETHOD_KADM;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key (formerly GROUP)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Description of category
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// GL Asset Code  (Capital)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE_ASS { get; internal set; }
        /// <summary>
        /// GL Asset Provision for Depn
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE_PRV { get; internal set; }
        /// <summary>
        /// GL Asset Depreciation Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE_EXP { get; internal set; }
        /// <summary>
        /// GL Asset Revaluations put to
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_REVALS_BS { get; internal set; }
        /// <summary>
        /// GL Asset Revaluations put to P &amp; L
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_REVALS_PL { get; internal set; }
        /// <summary>
        /// GL Code for asset cost of Reval's
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_REVALS_ASS { get; internal set; }
        /// <summary>
        /// GL Asset Profit/Loss on Sale
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_DISP_PROF { get; internal set; }
        /// <summary>
        /// GL Postings Proceeds from Disposals (PL)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_DISP_PROC { get; internal set; }
        /// <summary>
        /// GL acct where pte use % of depn will be posted
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string APTE_GLCODE { get; internal set; }
        /// <summary>
        /// Percentage of private use for accounting
        /// </summary>
        public double? PTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Default deprn method for accounts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DEPN_AMETHOD { get; internal set; }
        /// <summary>
        /// Default deprn method for taxation
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DEPN_TMETHOD { get; internal set; }
        /// <summary>
        /// Default deprn rate for accounts
        /// </summary>
        public double? DEPN_ARATE { get; internal set; }
        /// <summary>
        /// Percentage of private use for accounting
        /// </summary>
        public double? APTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Default deprn rate for taxation
        /// </summary>
        public double? DEPN_TRATE { get; internal set; }
        /// <summary>
        /// Percentage of private use for tax
        /// </summary>
        public double? TPTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Expected life of asset
        /// </summary>
        public short? EXPECTED_LIFE { get; internal set; }
        /// <summary>
        /// Send to DE&amp;T Flag
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SEND_TO_FLAG { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// V48 destination category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string MAP_CATEGORY { get; internal set; }
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
        /// GL (General Ledger) related entity by [AKC.GLCODE_ASS]-&gt;[GL.CODE]
        /// GL Asset Code  (Capital)
        /// </summary>
        public GL GLCODE_ASS_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.GLCODE_PRV]-&gt;[GL.CODE]
        /// GL Asset Provision for Depn
        /// </summary>
        public GL GLCODE_PRV_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.GLCODE_EXP]-&gt;[GL.CODE]
        /// GL Asset Depreciation Code
        /// </summary>
        public GL GLCODE_EXP_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.GL_REVALS_BS]-&gt;[GL.CODE]
        /// GL Asset Revaluations put to
        /// </summary>
        public GL GL_REVALS_BS_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.GL_REVALS_PL]-&gt;[GL.CODE]
        /// GL Asset Revaluations put to P &amp; L
        /// </summary>
        public GL GL_REVALS_PL_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.GL_REVALS_ASS]-&gt;[GL.CODE]
        /// GL Code for asset cost of Reval's
        /// </summary>
        public GL GL_REVALS_ASS_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.GL_DISP_PROF]-&gt;[GL.CODE]
        /// GL Asset Profit/Loss on Sale
        /// </summary>
        public GL GL_DISP_PROF_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.GL_DISP_PROC]-&gt;[GL.CODE]
        /// GL Postings Proceeds from Disposals (PL)
        /// </summary>
        public GL GL_DISP_PROC_GL
        {
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
        /// GL (General Ledger) related entity by [AKC.APTE_GLCODE]-&gt;[GL.CODE]
        /// GL acct where pte use % of depn will be posted
        /// </summary>
        public GL APTE_GLCODE_GL
        {
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
        /// KADM (Asset Depreciation Methods) related entity by [AKC.DEPN_AMETHOD]-&gt;[KADM.KADMKEY]
        /// Default deprn method for accounts
        /// </summary>
        public KADM DEPN_AMETHOD_KADM
        {
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
        /// KADM (Asset Depreciation Methods) related entity by [AKC.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// Default deprn method for taxation
        /// </summary>
        public KADM DEPN_TMETHOD_KADM
        {
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

        /// <summary>
        /// AR (Assets) related entities by [AR.CATEGORY]-&gt;[AKC.CATEGORY]
        /// </summary>
        public IReadOnlyList<AR> AR_CATEGORY
        {
            get
            {
                return Context.AKC.FindARByCATEGORY(CATEGORY);
            }
        }
#endregion
    }
}
