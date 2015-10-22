using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Items
    /// </summary>
    public partial class PI : EntityBase
    {
#region Navigation Property Cache
        private PG _PAYG_BOX_PG;
        private PI _BASEITEM_PI;
        private PSA _AWARD_PSA;
        private GL _CLR_GLCODE_GL;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLINIT _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Pay item key
        /// </summary>
        public short PIKEY { get; internal set; }
        /// <summary>
        /// oldname=PAYTYPE; * PN KEY  0 if available to all
        /// </summary>
        public short? PAYCODE { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Addition or Deduction
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSTYPE { get; internal set; }
        /// <summary>
        /// This item taxable? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TAXABLE { get; internal set; }
        /// <summary>
        /// Hrs, Kms, Day, Prd, etc
        /// [Alphanumeric (3)]
        /// </summary>
        public string UNIT { get; internal set; }
        /// <summary>
        /// Category (eg SICK,HOLS,NORM)
        /// [Alphanumeric (5)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// PAYG Payment summary box no.
        /// </summary>
        public short? PAYG_BOX { get; internal set; }
        /// <summary>
        /// Direct tax rate for this item
        /// </summary>
        public double? TAXRATE { get; internal set; }
        /// <summary>
        /// Annual tax free amount
        /// </summary>
        public decimal? TAXFREE { get; internal set; }
        /// <summary>
        /// Base item to get rate from
        /// </summary>
        public short? BASEITEM { get; internal set; }
        /// <summary>
        /// %age to multiply base item by
        /// </summary>
        public double? BASELOAD { get; internal set; }
        /// <summary>
        /// Is Pay item based on (in respect to KPHR table)
        /// H = Hourly pay rate
        /// T = Hourly tool rate
        /// F = Daily fares &amp; travel rate
        /// O = Other
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BASETYPE { get; internal set; }
        /// <summary>
        /// Award this item belongs to
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AWARD { get; internal set; }
        /// <summary>
        /// This item accrued to? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACCRUED { get; internal set; }
        /// <summary>
        /// Items which get accrued
        /// </summary>
        public short? ACCRUE_ITEM01 { get; internal set; }
        /// <summary>
        /// Items which get accrued
        /// </summary>
        public short? ACCRUE_ITEM02 { get; internal set; }
        /// <summary>
        /// Items which get accrued
        /// </summary>
        public short? ACCRUE_ITEM03 { get; internal set; }
        /// <summary>
        /// Items which get accrued
        /// </summary>
        public short? ACCRUE_ITEM04 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue
        /// </summary>
        public decimal? ACCRUE_RATEA01 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue
        /// </summary>
        public decimal? ACCRUE_RATEA02 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue
        /// </summary>
        public decimal? ACCRUE_RATEA03 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue
        /// </summary>
        public decimal? ACCRUE_RATEA04 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        /// 
        /// </summary>
        public decimal? ACCRUE_RATEB01 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        /// 
        /// </summary>
        public decimal? ACCRUE_RATEB02 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        /// 
        /// </summary>
        public decimal? ACCRUE_RATEB03 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        /// 
        /// </summary>
        public decimal? ACCRUE_RATEB04 { get; internal set; }
        /// <summary>
        /// Calc VALUE = RATE*HOURS? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AUTOCALC { get; internal set; }
        /// <summary>
        /// Default hours
        /// </summary>
        public double? DHOURS { get; internal set; }
        /// <summary>
        /// Default rate
        /// </summary>
        public double? DRATE { get; internal set; }
        /// <summary>
        /// Number of pays per year
        /// 1  = hourly, annual
        /// 12 = monthly
        /// 26 = fortnightly
        /// 52 = weekly
        /// </summary>
        public short? DPAY_YEAR { get; internal set; }
        /// <summary>
        /// Default qty / pay
        /// ANNUAL SALARY =
        /// (DRATE * DPAY_YEAR * DPAY_QTY)
        /// </summary>
        public double? DPAY_QTY { get; internal set; }
        /// <summary>
        /// Default value
        /// 
        /// </summary>
        public decimal? DVALUE { get; internal set; }
        /// <summary>
        /// SGL  applies?
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SUPER_LEVY { get; internal set; }
        /// <summary>
        /// Use  for personal super calc?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERS_SUPER { get; internal set; }
        /// <summary>
        /// Rate for personal super
        /// Zero for the item that
        /// accumulates personal super
        /// </summary>
        public double? PERS_SUPER_RATE { get; internal set; }
        /// <summary>
        /// Whether taking leave only
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AFFECTS_LEAVE { get; internal set; }
        /// <summary>
        /// Negative affect LEAVE_CODE
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Percentage affect on leave
        /// 
        /// </summary>
        public double? PERCENT_AFFECT { get; internal set; }
        /// <summary>
        /// Clearing GL code (not used)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CLR_GLCODE { get; internal set; }
        /// <summary>
        /// Short Description
        /// [Alphanumeric (10)]
        /// </summary>
        public string SHORT_DESC { get; internal set; }
        /// <summary>
        /// Leave Loading item? Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LEAVELOAD_ITEM { get; internal set; }
        /// <summary>
        /// Base item for Leave Laoding? Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LEAVE_BASEITEM { get; internal set; }
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
        /// Normal pay percentage split for holiday pay
        /// </summary>
        public double? NORMAL_SPLIT { get; internal set; }
        /// <summary>
        /// LPA pay percentage split for holiday pay
        /// </summary>
        public double? LPA_SPLIT { get; internal set; }
        /// <summary>
        /// Record annulaised loading percetage used in loading calculation
        /// </summary>
        public double? ANNUALISED_LOADING { get; internal set; }
        /// <summary>
        /// Active? Y/N
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
        /// PG (PAYG Payment Summary Box) related entity by [PI.PAYG_BOX]-&gt;[PG.PAYG_BOX]
        /// PAYG Payment summary box no.
        /// </summary>
        public PG PAYG_BOX_PG
        {
            get
            {
                if (PAYG_BOX.HasValue)
                {
                    if (_PAYG_BOX_PG == null)
                    {
                        _PAYG_BOX_PG = Context.PG.FindByPAYG_BOX(PAYG_BOX.Value);
                    }
                    return _PAYG_BOX_PG;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// PI (Pay Items) related entity by [PI.BASEITEM]-&gt;[PI.PIKEY]
        /// Base item to get rate from
        /// </summary>
        public PI BASEITEM_PI
        {
            get
            {
                if (BASEITEM.HasValue)
                {
                    if (_BASEITEM_PI == null)
                    {
                        _BASEITEM_PI = Context.PI.FindByPIKEY(BASEITEM.Value);
                    }
                    return _BASEITEM_PI;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// PSA (Award Details) related entity by [PI.AWARD]-&gt;[PSA.PSAKEY]
        /// Award this item belongs to
        /// 
        /// </summary>
        public PSA AWARD_PSA
        {
            get
            {
                if (AWARD != null)
                {
                    if (_AWARD_PSA == null)
                    {
                        _AWARD_PSA = Context.PSA.FindByPSAKEY(AWARD);
                    }
                    return _AWARD_PSA;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [PI.CLR_GLCODE]-&gt;[GL.CODE]
        /// Clearing GL code (not used)
        /// </summary>
        public GL CLR_GLCODE_GL
        {
            get
            {
                if (CLR_GLCODE != null)
                {
                    if (_CLR_GLCODE_GL == null)
                    {
                        _CLR_GLCODE_GL = Context.GL.FindByCODE(CLR_GLCODE);
                    }
                    return _CLR_GLCODE_GL;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [PI.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PI.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
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

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PEF.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PEF> PEF_PAYITEM
        {
            get
            {
                return Context.PI.FindPEFByPAYITEM(PIKEY);
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PEFH.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PEFH> PEFH_PAYITEM
        {
            get
            {
                return Context.PI.FindPEFHByPAYITEM(PIKEY);
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PEPS.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PEPS> PEPS_PAYITEM
        {
            get
            {
                return Context.PI.FindPEPSByPAYITEM(PIKEY);
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [PEPU.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PEPU> PEPU_PAYITEM
        {
            get
            {
                return Context.PI.FindPEPUByPAYITEM(PIKEY);
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [PEPUH.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PEPUH> PEPUH_PAYITEM
        {
            get
            {
                return Context.PI.FindPEPUHByPAYITEM(PIKEY);
            }
        }

        /// <summary>
        /// PETP (Termination Payment) related entities by [PETP.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PETP> PETP_PAYITEM
        {
            get
            {
                return Context.PI.FindPETPByPAYITEM(PIKEY);
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [PI.BASEITEM]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PI> PI_BASEITEM
        {
            get
            {
                return Context.PI.FindPIByBASEITEM(PIKEY);
            }
        }

        /// <summary>
        /// PILI (Pay Item Leave Items) related entities by [PILI.PIKEY]-&gt;[PI.PIKEY]
        /// </summary>
        public IReadOnlyList<PILI> PILI_PIKEY
        {
            get
            {
                return Context.PI.FindPILIByPIKEY(PIKEY);
            }
        }
#endregion
    }
}
