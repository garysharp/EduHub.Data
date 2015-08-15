using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Tax Scales
    /// </summary>
    public class PX_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Tax scale number [Integer (16bit signed): i]
        /// </summary>
        public short PXKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION01 { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION02 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME01 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME02 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME03 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME04 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME05 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME06 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME07 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME08 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME09 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME10 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME11 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME12 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME13 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME14 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME15 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME16 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME17 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME18 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME19 { get; internal set; }
        /// <summary>
        /// End incomes for 8 brackets [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ENDINCOME20 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA01 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA02 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA03 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA04 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA05 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA06 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA07 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA08 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA09 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA10 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA11 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA12 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA13 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA14 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA15 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA16 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA17 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA18 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA19 { get; internal set; }
        /// <summary>
        /// Coefficient A [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFA20 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB01 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB02 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB03 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB04 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB05 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB06 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB07 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB08 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB09 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB10 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB11 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB12 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB13 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB14 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB15 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB16 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB17 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB18 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB19 { get; internal set; }
        /// <summary>
        /// Coefficient B [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? COEFB20 { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? TRANSDATE { get; internal set; }
        /// <summary>
        /// Includes HECS Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HECS { get; internal set; }
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
#endregion
    }
}
