#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard and Last Pays
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPS : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private PE Cache_CODE_PE;
        private PI Cache_PAYITEM_PI;
        private PS Cache_PAY_STEP_PS;
        private PF Cache_SUPER_FUND_PF;
        private PC Cache_TRCENTRE_PC;
#endif
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
        /// Transaction ID (unique)
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
        /// Pay rate
        /// </summary>
        public double? TRCOST { get; internal set; }

        /// <summary>
        /// Hours
        /// </summary>
        public double? TRQTY { get; internal set; }

        /// <summary>
        /// Dollar value
        /// </summary>
        public decimal? TRAMT { get; internal set; }

        /// <summary>
        /// Detail
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// S = Standard L = Last
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FLAG { get; internal set; }

        /// <summary>
        /// No. of pay spans
        /// </summary>
        public short? TRPAYSPAN { get; internal set; }

        /// <summary>
        /// No. of tax spans
        /// </summary>
        public short? TRTAXSPAN { get; internal set; }

        /// <summary>
        /// Date of Pay
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// Timesheet Number
        /// [Alphanumeric (15)]
        /// </summary>
        public string TIMESHEET_NO { get; internal set; }

        /// <summary>
        /// Pay Rate Step
        /// </summary>
        public short? PAY_STEP { get; internal set; }

        /// <summary>
        /// Super fund key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUPER_FUND { get; internal set; }

        /// <summary>
        /// Super fund member number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }

        /// <summary>
        /// Percentage contribution
        /// </summary>
        public double? SUPER_PERCENT { get; internal set; }

        /// <summary>
        /// Cost Centre
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRCENTRE { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// PE (Employees) related entity by [PEPS.CODE]-&gt;[PE.PEKEY]
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
        /// PI (Pay Items) related entity by [PEPS.PAYITEM]-&gt;[PI.PIKEY]
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
        /// PS (Pay Steps or Pay Class) related entity by [PEPS.PAY_STEP]-&gt;[PS.PSKEY]
        /// Pay Rate Step
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
        /// PF (Superannuation Funds) related entity by [PEPS.SUPER_FUND]-&gt;[PF.PFKEY]
        /// Super fund key
        /// </summary>
        public PF SUPER_FUND_PF
        {
            get
            {
                if (SUPER_FUND == null)
                {
                    return null;
                }
                if (Cache_SUPER_FUND_PF == null)
                {
                    Cache_SUPER_FUND_PF = Context.PF.FindByPFKEY(SUPER_FUND);
                }

                return Cache_SUPER_FUND_PF;
            }
        }

        /// <summary>
        /// PC (Cost Centres) related entity by [PEPS.TRCENTRE]-&gt;[PC.PCKEY]
        /// Cost Centre
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

#endif
        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [PEPS.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PEPS.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
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
#endif
