#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Items
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PI : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private PG Cache_PAYG_BOX_PG;
        private PI Cache_BASEITEM_PI;
        private PSA Cache_AWARD_PSA;
#endif
        private GL Cache_CLR_GLCODE_GL;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<PEF> Cache_PIKEY_PEF_PAYITEM;
        private IReadOnlyList<PEFH> Cache_PIKEY_PEFH_PAYITEM;
        private IReadOnlyList<PEPS> Cache_PIKEY_PEPS_PAYITEM;
        private IReadOnlyList<PEPU> Cache_PIKEY_PEPU_PAYITEM;
        private IReadOnlyList<PEPUH> Cache_PIKEY_PEPUH_PAYITEM;
        private IReadOnlyList<PETP> Cache_PIKEY_PETP_PAYITEM;
        private IReadOnlyList<PI> Cache_PIKEY_PI_BASEITEM;
        private IReadOnlyList<PILI> Cache_PIKEY_PILI_PIKEY;
#endif

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
        ///  B = denominator
        /// </summary>
        public decimal? ACCRUE_RATEB01 { get; internal set; }

        /// <summary>
        /// A = numerator
        ///  B = denominator
        /// </summary>
        public decimal? ACCRUE_RATEB02 { get; internal set; }

        /// <summary>
        /// A = numerator
        ///  B = denominator
        /// </summary>
        public decimal? ACCRUE_RATEB03 { get; internal set; }

        /// <summary>
        /// A = numerator
        ///  B = denominator
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
        /// </summary>
        public decimal? DVALUE { get; internal set; }

        /// <summary>
        /// SGL  applies?
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

#if !EduHubScoped
        /// <summary>
        /// PG (PAYG Payment Summary Box) related entity by [PI.PAYG_BOX]-&gt;[PG.PAYG_BOX]
        /// PAYG Payment summary box no.
        /// </summary>
        public PG PAYG_BOX_PG
        {
            get
            {
                if (PAYG_BOX == null)
                {
                    return null;
                }
                if (Cache_PAYG_BOX_PG == null)
                {
                    Cache_PAYG_BOX_PG = Context.PG.FindByPAYG_BOX(PAYG_BOX.Value);
                }

                return Cache_PAYG_BOX_PG;
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
                if (BASEITEM == null)
                {
                    return null;
                }
                if (Cache_BASEITEM_PI == null)
                {
                    Cache_BASEITEM_PI = Context.PI.FindByPIKEY(BASEITEM.Value);
                }

                return Cache_BASEITEM_PI;
            }
        }

        /// <summary>
        /// PSA (Award Details) related entity by [PI.AWARD]-&gt;[PSA.PSAKEY]
        /// Award this item belongs to
        /// </summary>
        public PSA AWARD_PSA
        {
            get
            {
                if (AWARD == null)
                {
                    return null;
                }
                if (Cache_AWARD_PSA == null)
                {
                    Cache_AWARD_PSA = Context.PSA.FindByPSAKEY(AWARD);
                }

                return Cache_AWARD_PSA;
            }
        }

#endif
        /// <summary>
        /// GL (General Ledger) related entity by [PI.CLR_GLCODE]-&gt;[GL.CODE]
        /// Clearing GL code (not used)
        /// </summary>
        public GL CLR_GLCODE_GL
        {
            get
            {
                if (CLR_GLCODE == null)
                {
                    return null;
                }
                if (Cache_CLR_GLCODE_GL == null)
                {
                    Cache_CLR_GLCODE_GL = Context.GL.FindByCODE(CLR_GLCODE);
                }

                return Cache_CLR_GLCODE_GL;
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PI.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
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

#if !EduHubScoped
        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PI.PIKEY]-&gt;[PEF.PAYITEM]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PEF> PIKEY_PEF_PAYITEM
        {
            get
            {
                if (Cache_PIKEY_PEF_PAYITEM == null &&
                    !Context.PEF.TryFindByPAYITEM(PIKEY, out Cache_PIKEY_PEF_PAYITEM))
                {
                    Cache_PIKEY_PEF_PAYITEM = new List<PEF>().AsReadOnly();
                }

                return Cache_PIKEY_PEF_PAYITEM;
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PI.PIKEY]-&gt;[PEFH.PAYITEM]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PEFH> PIKEY_PEFH_PAYITEM
        {
            get
            {
                if (Cache_PIKEY_PEFH_PAYITEM == null &&
                    !Context.PEFH.TryFindByPAYITEM(PIKEY, out Cache_PIKEY_PEFH_PAYITEM))
                {
                    Cache_PIKEY_PEFH_PAYITEM = new List<PEFH>().AsReadOnly();
                }

                return Cache_PIKEY_PEFH_PAYITEM;
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PI.PIKEY]-&gt;[PEPS.PAYITEM]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PEPS> PIKEY_PEPS_PAYITEM
        {
            get
            {
                if (Cache_PIKEY_PEPS_PAYITEM == null &&
                    !Context.PEPS.TryFindByPAYITEM(PIKEY, out Cache_PIKEY_PEPS_PAYITEM))
                {
                    Cache_PIKEY_PEPS_PAYITEM = new List<PEPS>().AsReadOnly();
                }

                return Cache_PIKEY_PEPS_PAYITEM;
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [PI.PIKEY]-&gt;[PEPU.PAYITEM]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PEPU> PIKEY_PEPU_PAYITEM
        {
            get
            {
                if (Cache_PIKEY_PEPU_PAYITEM == null &&
                    !Context.PEPU.TryFindByPAYITEM(PIKEY, out Cache_PIKEY_PEPU_PAYITEM))
                {
                    Cache_PIKEY_PEPU_PAYITEM = new List<PEPU>().AsReadOnly();
                }

                return Cache_PIKEY_PEPU_PAYITEM;
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [PI.PIKEY]-&gt;[PEPUH.PAYITEM]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PEPUH> PIKEY_PEPUH_PAYITEM
        {
            get
            {
                if (Cache_PIKEY_PEPUH_PAYITEM == null &&
                    !Context.PEPUH.TryFindByPAYITEM(PIKEY, out Cache_PIKEY_PEPUH_PAYITEM))
                {
                    Cache_PIKEY_PEPUH_PAYITEM = new List<PEPUH>().AsReadOnly();
                }

                return Cache_PIKEY_PEPUH_PAYITEM;
            }
        }

        /// <summary>
        /// PETP (Termination Payment) related entities by [PI.PIKEY]-&gt;[PETP.PAYITEM]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PETP> PIKEY_PETP_PAYITEM
        {
            get
            {
                if (Cache_PIKEY_PETP_PAYITEM == null &&
                    !Context.PETP.TryFindByPAYITEM(PIKEY, out Cache_PIKEY_PETP_PAYITEM))
                {
                    Cache_PIKEY_PETP_PAYITEM = new List<PETP>().AsReadOnly();
                }

                return Cache_PIKEY_PETP_PAYITEM;
            }
        }

        /// <summary>
        /// PI (Pay Items) related entities by [PI.PIKEY]-&gt;[PI.BASEITEM]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PI> PIKEY_PI_BASEITEM
        {
            get
            {
                if (Cache_PIKEY_PI_BASEITEM == null &&
                    !Context.PI.TryFindByBASEITEM(PIKEY, out Cache_PIKEY_PI_BASEITEM))
                {
                    Cache_PIKEY_PI_BASEITEM = new List<PI>().AsReadOnly();
                }

                return Cache_PIKEY_PI_BASEITEM;
            }
        }

        /// <summary>
        /// PILI (Pay Item Leave Items) related entities by [PI.PIKEY]-&gt;[PILI.PIKEY]
        /// Pay item key
        /// </summary>
        public IReadOnlyList<PILI> PIKEY_PILI_PIKEY
        {
            get
            {
                if (Cache_PIKEY_PILI_PIKEY == null &&
                    !Context.PILI.TryFindByPIKEY(PIKEY, out Cache_PIKEY_PILI_PIKEY))
                {
                    Cache_PIKEY_PILI_PIKEY = new List<PILI>().AsReadOnly();
                }

                return Cache_PIKEY_PILI_PIKEY;
            }
        }

#endif
        #endregion

    }
}
#endif
