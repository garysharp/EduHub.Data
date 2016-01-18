using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Transactions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEF : EduHubEntity
    {

        #region Navigation Property Cache

        private PE Cache_CODE_PE;
        private PI Cache_PAYITEM_PI;
        private PC Cache_TRCENTRE_PC;
        private PS Cache_PAY_STEP_PS;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

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
        /// &lt;No documentation available&gt;
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Pay item code
        /// </summary>
        public short? PAYITEM { get; internal set; }

        /// <summary>
        /// Cost centre
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRCENTRE { get; internal set; }

        /// <summary>
        /// E = Employee pay
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }

        /// <summary>
        /// Batch number
        /// </summary>
        public int? TRBATCH { get; internal set; }

        /// <summary>
        /// Payroll group
        /// </summary>
        public short? TRPAYCODE { get; internal set; }

        /// <summary>
        /// Payroll period number
        /// </summary>
        public int? TRPAYPERD { get; internal set; }

        /// <summary>
        /// Transaction period (not used)
        /// </summary>
        public int? TRPERD { get; internal set; }

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// Reference
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }

        /// <summary>
        /// Pay rate
        /// </summary>
        public double? TRCOST { get; internal set; }

        /// <summary>
        /// Hours
        /// </summary>
        public double? TRQTY { get; internal set; }

        /// <summary>
        /// Dollar value (always positive)
        /// </summary>
        public decimal? TRAMT { get; internal set; }

        /// <summary>
        /// Addition or Deduction. This controls the arithmetic of TRAMT
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRPITYPE { get; internal set; }

        /// <summary>
        /// Hrs, Kms, Day, Prd, etc
        /// [Alphanumeric (3)]
        /// </summary>
        public string TRUNIT { get; internal set; }

        /// <summary>
        /// Detail
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// Next pay date for employee
        /// </summary>
        public DateTime? TRNEXTPAYDATE { get; internal set; }

        /// <summary>
        /// Next pay period
        /// </summary>
        public int? TRNEXTPAYPERD { get; internal set; }

        /// <summary>
        /// No. of pay spans
        /// </summary>
        public short? TRPAYSPAN { get; internal set; }

        /// <summary>
        /// No. of tax spans
        /// </summary>
        public double? TRTAXSPAN { get; internal set; }

        /// <summary>
        /// Next pay date for this payroll group
        /// </summary>
        public DateTime? PNNEXTPAYDATE { get; internal set; }

        /// <summary>
        /// Super fund key (SGL or Personal)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUPER_FUND { get; internal set; }

        /// <summary>
        /// Super fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }

        /// <summary>
        /// Field for format only
        /// </summary>
        public double? WORKED_HOURS { get; internal set; }

        /// <summary>
        /// Pay Rate Step number
        /// </summary>
        public short? PAY_STEP { get; internal set; }

        /// <summary>
        /// Not used (required for a financial table)
        /// </summary>
        public decimal? TRNETT { get; internal set; }

        /// <summary>
        /// Not used (required for a financial table)
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }

        /// <summary>
        /// Not used (required for a financial table)
        /// </summary>
        public decimal? TRGROSS { get; internal set; }

        /// <summary>
        /// "A" Addition or "D" Deduction
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PAYSIGNTYPE { get; internal set; }

        /// <summary>
        /// Indicates which record is tax record
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SYSTEM_TAX { get; internal set; }

        /// <summary>
        /// Line number in the batch
        /// </summary>
        public int? LINE_NO { get; internal set; }

        /// <summary>
        /// Determines through posts 0 = Don't show T/P 1 = Show T/P
        /// </summary>
        public int? FLAG { get; internal set; }

        /// <summary>
        /// R or T for Redundancy, invalidity or approved early retirement
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TERMINATION_TYPE { get; internal set; }

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
        /// Holiday pay split precentage, Normal or LPA.  Used for leave accruals
        /// </summary>
        public double? SPLIT_PERCENT { get; internal set; }

        /// <summary>
        /// Alter hours, used in PE31001 to assist with LPA/Annual split calc
        /// </summary>
        public double? ALTER_TRQTY { get; internal set; }

        /// <summary>
        /// Record annulaised loading percetage used in loading calculation
        /// </summary>
        public double? ANNUALISED_LOADING { get; internal set; }

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
        /// PE (Employees) related entity by [PEF.CODE]-&gt;[PE.PEKEY]
        /// Employee code
        /// </summary>
        public PE CODE_PE
        {
            get
            {
                if (Cache_CODE_PE == null)
                {
                    Cache_CODE_PE = Context.PE.FindByPEKEY(CODE);
                }

                return Cache_CODE_PE;
            }
        }

        /// <summary>
        /// PI (Pay Items) related entity by [PEF.PAYITEM]-&gt;[PI.PIKEY]
        /// Pay item code
        /// </summary>
        public PI PAYITEM_PI
        {
            get
            {
                if (PAYITEM == null)
                {
                    return null;
                }
                if (Cache_PAYITEM_PI == null)
                {
                    Cache_PAYITEM_PI = Context.PI.FindByPIKEY(PAYITEM.Value);
                }

                return Cache_PAYITEM_PI;
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entity by [PEF.TRCENTRE]-&gt;[PC.PCKEY]
        /// Cost centre
        /// </summary>
        public PC TRCENTRE_PC
        {
            get
            {
                if (TRCENTRE == null)
                {
                    return null;
                }
                if (Cache_TRCENTRE_PC == null)
                {
                    Cache_TRCENTRE_PC = Context.PC.FindByPCKEY(TRCENTRE);
                }

                return Cache_TRCENTRE_PC;
            }
        }

        /// <summary>
        /// PS (Pay Steps or Pay Class) related entity by [PEF.PAY_STEP]-&gt;[PS.PSKEY]
        /// Pay Rate Step number
        /// </summary>
        public PS PAY_STEP_PS
        {
            get
            {
                if (PAY_STEP == null)
                {
                    return null;
                }
                if (Cache_PAY_STEP_PS == null)
                {
                    Cache_PAY_STEP_PS = Context.PS.FindByPSKEY(PAY_STEP.Value);
                }

                return Cache_PAY_STEP_PS;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [PEF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PEF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
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

    }
}
