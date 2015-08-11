using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super LTD History
    /// </summary>
    public class PESH_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (unique) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [CODE] => [PE_Entity].[PEKEY]
        /// Employee code
        /// </summary>
        public PE_Entity CODE_PE { get { return CODE == null ? null : Context.PE.FindByPEKEY(CODE); } }
        /// <summary>
        /// "G" = SGC levy
        /// "U" = Personal super [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Superannuation fund [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number
        ///  [Uppercase Alphanumeric: u20]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Last pay date
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LASTPAYDATE { get; internal set; }
        /// <summary>
        /// Opening balance for this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT_OPBAL { get; internal set; }
        /// <summary>
        /// Year to Date super amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT_YTD { get; internal set; }
        /// <summary>
        /// Life to Date super amount [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AMOUNT_LTD { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH01 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH02 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH03 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH04 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH05 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH06 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH07 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH08 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH09 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH10 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH11 { get; internal set; }
        /// <summary>
        /// Super each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_MTH12 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV01 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV02 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV03 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV04 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV05 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV06 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV07 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV08 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV09 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV10 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV11 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PROV12 { get; internal set; }
        /// <summary>
        /// Amount of Super paid to Super Fund YTD for SGC levy [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_PAID_YTD { get; internal set; }
        /// <summary>
        /// Date that SGC Levy has been paid up to [Date Time nullable: d]
        /// </summary>
        public DateTime? SUPER_PAID_TODATE { get; internal set; }
        /// <summary>
        /// Amount of super as yet unpaid  for last financial year
        ///  [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? SUPER_UNPAID_LYR { get; internal set; }
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
