using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PN : EduHubEntity
    {

        #region Navigation Property Cache

        private PPD Cache_PPDKEY_PPD;
        private KBANK Cache_DD_GLCODE_KBANK;
        private GL Cache_GLCODE_GL;
        private GL Cache_GLBANK_GL;
        private GL Cache_GLTAX_GL;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<PE> Cache_PNKEY_PE_PAYCODE;

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
        /// [Alphanumeric (16)]
        /// </summary>
        public string ABN { get; internal set; }

        /// <summary>
        /// Direct Deposit GL Bank Account
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
        /// PPD (PAYG Payer Details) related entity by [PN.PPDKEY]-&gt;[PPD.PPDKEY]
        /// PAYG Payer details
        /// </summary>
        public PPD PPDKEY_PPD
        {
            get
            {
                if (PPDKEY == null)
                {
                    return null;
                }
                if (Cache_PPDKEY_PPD == null)
                {
                    Cache_PPDKEY_PPD = Context.PPD.FindByPPDKEY(PPDKEY);
                }

                return Cache_PPDKEY_PPD;
            }
        }

        /// <summary>
        /// KBANK (Bank Account) related entity by [PN.DD_GLCODE]-&gt;[KBANK.GLCODE]
        /// Direct Deposit GL Bank Account
        /// </summary>
        public KBANK DD_GLCODE_KBANK
        {
            get
            {
                if (DD_GLCODE == null)
                {
                    return null;
                }
                if (Cache_DD_GLCODE_KBANK == null)
                {
                    Cache_DD_GLCODE_KBANK = Context.KBANK.FindByGLCODE(DD_GLCODE);
                }

                return Cache_DD_GLCODE_KBANK;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [PN.GLCODE]-&gt;[GL.CODE]
        /// Salary    expense code
        /// </summary>
        public GL GLCODE_GL
        {
            get
            {
                if (GLCODE == null)
                {
                    return null;
                }
                if (Cache_GLCODE_GL == null)
                {
                    Cache_GLCODE_GL = Context.GL.FindByCODE(GLCODE);
                }

                return Cache_GLCODE_GL;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [PN.GLBANK]-&gt;[GL.CODE]
        /// Wages     clearing account
        /// </summary>
        public GL GLBANK_GL
        {
            get
            {
                if (GLBANK == null)
                {
                    return null;
                }
                if (Cache_GLBANK_GL == null)
                {
                    Cache_GLBANK_GL = Context.GL.FindByCODE(GLBANK);
                }

                return Cache_GLBANK_GL;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [PN.GLTAX]-&gt;[GL.CODE]
        /// Group Tax clearing account
        /// </summary>
        public GL GLTAX_GL
        {
            get
            {
                if (GLTAX == null)
                {
                    return null;
                }
                if (Cache_GLTAX_GL == null)
                {
                    Cache_GLTAX_GL = Context.GL.FindByCODE(GLTAX);
                }

                return Cache_GLTAX_GL;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [PN.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
            get
            {
                if (SUBPROGRAM == null)
                {
                    return null;
                }
                if (Cache_SUBPROGRAM_KGLSUB == null)
                {
                    Cache_SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                }

                return Cache_SUBPROGRAM_KGLSUB;
            }
        }

        /// <summary>
        /// KGLINIT (General Ledger Initiatives) related entity by [PN.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Transaction might belong to an Initiative
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
        /// PE (Employees) related entities by [PN.PNKEY]-&gt;[PE.PAYCODE]
        /// Payroll code
        /// </summary>
        public IReadOnlyList<PE> PNKEY_PE_PAYCODE
        {
            get
            {
                if (Cache_PNKEY_PE_PAYCODE == null &&
                    !Context.PE.TryFindByPAYCODE(PNKEY, out Cache_PNKEY_PE_PAYCODE))
                {
                    Cache_PNKEY_PE_PAYCODE = new List<PE>().AsReadOnly();
                }

                return Cache_PNKEY_PE_PAYCODE;
            }
        }

        #endregion

    }
}
