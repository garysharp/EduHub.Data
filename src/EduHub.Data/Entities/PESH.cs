using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super LTD History
    /// </summary>
    public class PESH : EntityBase
    {
#region Navigation Property Cache
        private PE _CODE_PE;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (unique)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// "G" = SGC levy
        /// "U" = Personal super
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Superannuation fund
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number
        /// 
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Last pay date
        /// 
        /// </summary>
        public DateTime? LASTPAYDATE { get; internal set; }
        /// <summary>
        /// Opening balance for this year
        /// </summary>
        public decimal? AMOUNT_OPBAL { get; internal set; }
        /// <summary>
        /// Year to Date super amount
        /// </summary>
        public decimal? AMOUNT_YTD { get; internal set; }
        /// <summary>
        /// Life to Date super amount
        /// </summary>
        public decimal? AMOUNT_LTD { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH01 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH02 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH03 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH04 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH05 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH06 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH07 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH08 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH09 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH10 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH11 { get; internal set; }
        /// <summary>
        /// Super each month
        /// </summary>
        public decimal? SUPER_MTH12 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV01 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV02 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV03 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV04 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV05 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV06 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV07 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV08 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV09 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV10 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV11 { get; internal set; }
        /// <summary>
        /// SGL provisional liability each month
        /// </summary>
        public decimal? SUPER_PROV12 { get; internal set; }
        /// <summary>
        /// Amount of Super paid to Super Fund YTD for SGC levy
        /// </summary>
        public decimal? SUPER_PAID_YTD { get; internal set; }
        /// <summary>
        /// Date that SGC Levy has been paid up to
        /// </summary>
        public DateTime? SUPER_PAID_TODATE { get; internal set; }
        /// <summary>
        /// Amount of super as yet unpaid  for last financial year
        /// 
        /// </summary>
        public decimal? SUPER_UNPAID_LYR { get; internal set; }
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
        /// Navigation property for [CODE] => [PE].[PEKEY]
        /// Employee code
        /// </summary>
        public PE CODE_PE {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_PE == null)
                    {
                        _CODE_PE = Context.PE.FindByPEKEY(CODE);
                    }
                    return _CODE_PE;
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
