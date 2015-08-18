using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups
    /// </summary>
    public class PN : EntityBase
    {
#region Navigation Property Cache
        private PPD _PPDKEY_PPD;
        private KBANK _DD_GLCODE_KBANK;
        private GL _GLCODE_GL;
        private GL _GLBANK_GL;
        private GL _GLTAX_GL;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLINIT _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Payroll code
        /// </summary>
        public short PNKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// M, F or W
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSTYPE { get; internal set; }
        /// <summary>
        /// First paydate of the year
        /// </summary>
        public DateTime? FIRSTDATE { get; internal set; }
        /// <summary>
        /// Next paydate of the year
        /// </summary>
        public DateTime? NEXTDATE { get; internal set; }
        /// <summary>
        /// Number of pays for year
        /// </summary>
        public short? NO_PAYS { get; internal set; }
        /// <summary>
        /// Roundoff point:...
        /// from 0.01 to 100.00
        /// </summary>
        public decimal? ROUNDOFF { get; internal set; }
        /// <summary>
        /// PAYG Payer details
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PPDKEY { get; internal set; }
        /// <summary>
        /// PAY_TYPE = A or T
        /// A = Autopay process
        /// T = Timesheet entry process
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PAY_TYPE { get; internal set; }
        /// <summary>
        /// oldname=ACN_NUMBER;
        /// Employer ACN number (incl spaces)
        /// [Alphanumeric (12)]
        /// </summary>
        public string ACN { get; internal set; }
        /// <summary>
        /// Employer ABN number
        /// 
        /// [Alphanumeric (16)]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Direct Deposit GL Bank Account
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DD_GLCODE { get; internal set; }
        /// <summary>
        /// Salary    expense code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Wages     clearing account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLBANK { get; internal set; }
        /// <summary>
        /// Group Tax clearing account
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLTAX { get; internal set; }
        /// <summary>
        /// For every transaction there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }
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
        /// Navigation property for [PPDKEY] => [PPD].[PPDKEY]
        /// PAYG Payer details
        /// </summary>
        public PPD PPDKEY_PPD {
            get
            {
                if (PPDKEY != null)
                {
                    if (_PPDKEY_PPD == null)
                    {
                        _PPDKEY_PPD = Context.PPD.FindByPPDKEY(PPDKEY);
                    }
                    return _PPDKEY_PPD;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DD_GLCODE] => [KBANK].[GLCODE]
        /// Direct Deposit GL Bank Account
        /// 
        /// </summary>
        public KBANK DD_GLCODE_KBANK {
            get
            {
                if (DD_GLCODE != null)
                {
                    if (_DD_GLCODE_KBANK == null)
                    {
                        _DD_GLCODE_KBANK = Context.KBANK.FindByGLCODE(DD_GLCODE);
                    }
                    return _DD_GLCODE_KBANK;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GLCODE] => [GL].[CODE]
        /// Salary    expense code
        /// </summary>
        public GL GLCODE_GL {
            get
            {
                if (GLCODE != null)
                {
                    if (_GLCODE_GL == null)
                    {
                        _GLCODE_GL = Context.GL.FindByCODE(GLCODE);
                    }
                    return _GLCODE_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GLBANK] => [GL].[CODE]
        /// Wages     clearing account
        /// </summary>
        public GL GLBANK_GL {
            get
            {
                if (GLBANK != null)
                {
                    if (_GLBANK_GL == null)
                    {
                        _GLBANK_GL = Context.GL.FindByCODE(GLBANK);
                    }
                    return _GLBANK_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GLTAX] => [GL].[CODE]
        /// Group Tax clearing account
        /// 
        /// </summary>
        public GL GLTAX_GL {
            get
            {
                if (GLTAX != null)
                {
                    if (_GLTAX_GL == null)
                    {
                        _GLTAX_GL = Context.GL.FindByCODE(GLTAX);
                    }
                    return _GLTAX_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB {
            get
            {
                if (SUBPROGRAM != null)
                {
                    if (_SUBPROGRAM_KGLSUB == null)
                    {
                        _SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                    }
                    return _SUBPROGRAM_KGLSUB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT {
            get
            {
                if (INITIATIVE != null)
                {
                    if (_INITIATIVE_KGLINIT == null)
                    {
                        _INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                    }
                    return _INITIATIVE_KGLINIT;
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
