using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups
    /// </summary>
    public class PN_Entity : EntityBase
    {
#region Navigation Property Cache
        private PPD_Entity _PPDKEY_PPD;
        private KBANK_Entity _DD_GLCODE_KBANK;
        private GL_Entity _GLCODE_GL;
        private GL_Entity _GLBANK_GL;
        private GL_Entity _GLTAX_GL;
        private KGLSUB_Entity _SUBPROGRAM_KGLSUB;
        private KGLINIT_Entity _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Payroll code [Integer (16bit signed): i]
        /// </summary>
        public short PNKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// M, F or W [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSTYPE { get; internal set; }
        /// <summary>
        /// First paydate of the year [Date Time nullable: d]
        /// </summary>
        public DateTime? FIRSTDATE { get; internal set; }
        /// <summary>
        /// Next paydate of the year [Date Time nullable: d]
        /// </summary>
        public DateTime? NEXTDATE { get; internal set; }
        /// <summary>
        /// Number of pays for year [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NO_PAYS { get; internal set; }
        /// <summary>
        /// Roundoff point:...
        /// from 0.01 to 100.00 [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ROUNDOFF { get; internal set; }
        /// <summary>
        /// PAYG Payer details [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PPDKEY { get; internal set; }
        /// <summary>
        /// PAY_TYPE = A or T
        /// A = Autopay process
        /// T = Timesheet entry process [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PAY_TYPE { get; internal set; }
        /// <summary>
        /// oldname=ACN_NUMBER;
        /// Employer ACN number (incl spaces) [Alphanumeric: a12]
        /// </summary>
        public string ACN { get; internal set; }
        /// <summary>
        /// Employer ABN number
        ///  [Alphanumeric: a16]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Direct Deposit GL Bank Account
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DD_GLCODE { get; internal set; }
        /// <summary>
        /// Salary    expense code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Wages     clearing account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLBANK { get; internal set; }
        /// <summary>
        /// Group Tax clearing account
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLTAX { get; internal set; }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
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
        /// Navigation property for [PPDKEY] => [PPD_Entity].[PPDKEY]
        /// PAYG Payer details
        /// </summary>
        public PPD_Entity PPDKEY_PPD {
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
        /// Navigation property for [DD_GLCODE] => [KBANK_Entity].[GLCODE]
        /// Direct Deposit GL Bank Account
        /// 
        /// </summary>
        public KBANK_Entity DD_GLCODE_KBANK {
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
        /// Navigation property for [GLCODE] => [GL_Entity].[CODE]
        /// Salary    expense code
        /// </summary>
        public GL_Entity GLCODE_GL {
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
        /// Navigation property for [GLBANK] => [GL_Entity].[CODE]
        /// Wages     clearing account
        /// </summary>
        public GL_Entity GLBANK_GL {
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
        /// Navigation property for [GLTAX] => [GL_Entity].[CODE]
        /// Group Tax clearing account
        /// 
        /// </summary>
        public GL_Entity GLTAX_GL {
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
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB {
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
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT {
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
