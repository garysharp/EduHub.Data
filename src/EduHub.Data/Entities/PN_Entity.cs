using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups
    /// </summary>
    public class PN_Entity : EntityBase
    {
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
        /// Navigation property for [PPDKEY] => [PPD_Entity].[PPDKEY]
        /// PAYG Payer details
        /// </summary>
        public PPD_Entity PPDKEY_PPD { get { return PPDKEY == null ? null : Context.PPD.FindByPPDKEY(PPDKEY); } }
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
        /// Navigation property for [DD_GLCODE] => [KBANK_Entity].[GLCODE]
        /// Direct Deposit GL Bank Account
        /// 
        /// </summary>
        public KBANK_Entity DD_GLCODE_KBANK { get { return DD_GLCODE == null ? null : Context.KBANK.FindByGLCODE(DD_GLCODE); } }
        /// <summary>
        /// Salary    expense code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Navigation property for [GLCODE] => [GL_Entity].[CODE]
        /// Salary    expense code
        /// </summary>
        public GL_Entity GLCODE_GL { get { return GLCODE == null ? null : Context.GL.FindByCODE(GLCODE); } }
        /// <summary>
        /// Wages     clearing account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLBANK { get; internal set; }
        /// <summary>
        /// Navigation property for [GLBANK] => [GL_Entity].[CODE]
        /// Wages     clearing account
        /// </summary>
        public GL_Entity GLBANK_GL { get { return GLBANK == null ? null : Context.GL.FindByCODE(GLBANK); } }
        /// <summary>
        /// Group Tax clearing account
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLTAX { get; internal set; }
        /// <summary>
        /// Navigation property for [GLTAX] => [GL_Entity].[CODE]
        /// Group Tax clearing account
        /// 
        /// </summary>
        public GL_Entity GLTAX_GL { get { return GLTAX == null ? null : Context.GL.FindByCODE(GLTAX); } }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB { get { return SUBPROGRAM == null ? null : Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM); } }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT { get { return INITIATIVE == null ? null : Context.KGLINIT.FindByINITIATIVE(INITIATIVE); } }
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
