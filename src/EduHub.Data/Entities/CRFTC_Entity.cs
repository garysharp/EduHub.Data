using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Fuel Tax Credits
    /// </summary>
    public class CRFTC_Entity : EntityBase
    {
#region Navigation Property Cache
        private CR_Entity _CODE_CR;
        private KFTC_Entity _FTC_CODE_KFTC;
#endregion

#region Field Properties
        /// <summary>
        /// System transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Creditor key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Transaction date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Transaction reference [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Fuel Type [Alphanumeric: a5]
        /// </summary>
        public string FUEL_TYPE { get; internal set; }
        /// <summary>
        /// Fuel Tax Credit code [Uppercase Alphanumeric: u3]
        /// </summary>
        public string FTC_CODE { get; internal set; }
        /// <summary>
        /// Total litres purchased [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TOT_LITRES { get; internal set; }
        /// <summary>
        /// Percentage claimed [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? CLAIM_PERC { get; internal set; }
        /// <summary>
        /// Litres claimed [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? CLAIM_LITRES { get; internal set; }
        /// <summary>
        /// Amount claimable [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? CLAIM_AMOUNT { get; internal set; }
        /// <summary>
        /// GL period this was claimed in [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CLAIM_PERIOD { get; internal set; }
        /// <summary>
        /// Notes [Memo: m]
        /// </summary>
        public string NOTES { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [CR_Entity].[CRKEY]
        /// Creditor key
        /// </summary>
        public CR_Entity CODE_CR {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_CR == null)
                    {
                        _CODE_CR = Context.CR.FindByCRKEY(CODE);
                    }
                    return _CODE_CR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FTC_CODE] => [KFTC_Entity].[KFTCKEY]
        /// Fuel Tax Credit code
        /// </summary>
        public KFTC_Entity FTC_CODE_KFTC {
            get
            {
                if (FTC_CODE != null)
                {
                    if (_FTC_CODE_KFTC == null)
                    {
                        _FTC_CODE_KFTC = Context.KFTC.FindByKFTCKEY(FTC_CODE);
                    }
                    return _FTC_CODE_KFTC;
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
