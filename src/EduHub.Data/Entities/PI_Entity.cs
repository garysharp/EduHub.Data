using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Items
    /// </summary>
    public class PI_Entity : EntityBase
    {
        /// <summary>
        /// Pay item key [Integer (16bit signed): i]
        /// </summary>
        public short PIKEY { get; internal set; }
        /// <summary>
        /// oldname=PAYTYPE; * PN KEY  0 if available to all [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PAYCODE { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Addition or Deduction [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSTYPE { get; internal set; }
        /// <summary>
        /// This item taxable? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TAXABLE { get; internal set; }
        /// <summary>
        /// Hrs, Kms, Day, Prd, etc [Alphanumeric: a3]
        /// </summary>
        public string UNIT { get; internal set; }
        /// <summary>
        /// Category (eg SICK,HOLS,NORM) [Alphanumeric: a5]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// PAYG Payment summary box no. [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PAYG_BOX { get; internal set; }
        /// <summary>
        /// Navigation property for [PAYG_BOX] => [PG_Entity].[PAYG_BOX]
        /// PAYG Payment summary box no.
        /// </summary>
        public PG_Entity PAYG_BOX_PG { get { return PAYG_BOX.HasValue ? Context.PG.FindByPAYG_BOX(PAYG_BOX.Value) : null; } }
        /// <summary>
        /// Direct tax rate for this item [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TAXRATE { get; internal set; }
        /// <summary>
        /// Annual tax free amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TAXFREE { get; internal set; }
        /// <summary>
        /// Base item to get rate from [Integer (16bit signed nullable): i]
        /// </summary>
        public short? BASEITEM { get; internal set; }
        /// <summary>
        /// Navigation property for [BASEITEM] => [PI_Entity].[PIKEY]
        /// Base item to get rate from
        /// </summary>
        public PI_Entity BASEITEM_PI { get { return BASEITEM.HasValue ? Context.PI.FindByPIKEY(BASEITEM.Value) : null; } }
        /// <summary>
        /// %age to multiply base item by [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? BASELOAD { get; internal set; }
        /// <summary>
        /// Is Pay item based on (in respect to KPHR table)
        /// H = Hourly pay rate
        /// T = Hourly tool rate
        /// F = Daily fares & travel rate
        /// O = Other [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BASETYPE { get; internal set; }
        /// <summary>
        /// Award this item belongs to
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AWARD { get; internal set; }
        /// <summary>
        /// Navigation property for [AWARD] => [PSA_Entity].[PSAKEY]
        /// Award this item belongs to
        /// 
        /// </summary>
        public PSA_Entity AWARD_PSA { get { return AWARD == null ? null : Context.PSA.FindByPSAKEY(AWARD); } }
        /// <summary>
        /// This item accrued to? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACCRUED { get; internal set; }
        /// <summary>
        /// Items which get accrued [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCRUE_ITEM01 { get; internal set; }
        /// <summary>
        /// Items which get accrued [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCRUE_ITEM02 { get; internal set; }
        /// <summary>
        /// Items which get accrued [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCRUE_ITEM03 { get; internal set; }
        /// <summary>
        /// Items which get accrued [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCRUE_ITEM04 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEA01 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEA02 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEA03 { get; internal set; }
        /// <summary>
        /// Rate at which they accrue [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEA04 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEB01 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEB02 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEB03 { get; internal set; }
        /// <summary>
        /// A = numerator
        /// B = denominator
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ACCRUE_RATEB04 { get; internal set; }
        /// <summary>
        /// Calc VALUE = RATE*HOURS? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AUTOCALC { get; internal set; }
        /// <summary>
        /// Default hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DHOURS { get; internal set; }
        /// <summary>
        /// Default rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DRATE { get; internal set; }
        /// <summary>
        /// Number of pays per year
        /// 1  = hourly, annual
        /// 12 = monthly
        /// 26 = fortnightly
        /// 52 = weekly [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DPAY_YEAR { get; internal set; }
        /// <summary>
        /// Default qty / pay
        /// ANNUAL SALARY =
        /// (DRATE * DPAY_YEAR * DPAY_QTY) [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DPAY_QTY { get; internal set; }
        /// <summary>
        /// Default value
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? DVALUE { get; internal set; }
        /// <summary>
        /// SGL  applies?
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SUPER_LEVY { get; internal set; }
        /// <summary>
        /// Use  for personal super calc? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERS_SUPER { get; internal set; }
        /// <summary>
        /// Rate for personal super
        /// Zero for the item that
        /// accumulates personal super [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERS_SUPER_RATE { get; internal set; }
        /// <summary>
        /// Whether taking leave only [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AFFECTS_LEAVE { get; internal set; }
        /// <summary>
        /// Negative affect LEAVE_CODE [Uppercase Alphanumeric: u8]
        /// </summary>
        public string LEAVE_CODE { get; internal set; }
        /// <summary>
        /// Percentage affect on leave
        ///  [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PERCENT_AFFECT { get; internal set; }
        /// <summary>
        /// Clearing GL code (not used) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CLR_GLCODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CLR_GLCODE] => [GL_Entity].[CODE]
        /// Clearing GL code (not used)
        /// </summary>
        public GL_Entity CLR_GLCODE_GL { get { return CLR_GLCODE == null ? null : Context.GL.FindByCODE(CLR_GLCODE); } }
        /// <summary>
        /// Short Description [Alphanumeric: a10]
        /// </summary>
        public string SHORT_DESC { get; internal set; }
        /// <summary>
        /// Leave Loading item? Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LEAVELOAD_ITEM { get; internal set; }
        /// <summary>
        /// Base item for Leave Laoding? Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LEAVE_BASEITEM { get; internal set; }
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
        /// Normal pay percentage split for holiday pay [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? NORMAL_SPLIT { get; internal set; }
        /// <summary>
        /// LPA pay percentage split for holiday pay [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? LPA_SPLIT { get; internal set; }
        /// <summary>
        /// Record annulaised loading percetage used in loading calculation [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ANNUALISED_LOADING { get; internal set; }
        /// <summary>
        /// Active? Y/N
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
