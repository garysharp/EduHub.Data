using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super LTD History Data Set
    /// </summary>
    public sealed partial class PESHDataSet : SetBase<PESH>
    {


        internal PESHDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PESH"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PESH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PESH" /> fields for each CSV column header</returns>
        protected override Action<PESH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PESH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AMOUNT_OPBAL":
                        mapper[i] = (e, v) => e.AMOUNT_OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AMOUNT_YTD":
                        mapper[i] = (e, v) => e.AMOUNT_YTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AMOUNT_LTD":
                        mapper[i] = (e, v) => e.AMOUNT_LTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH01":
                        mapper[i] = (e, v) => e.SUPER_MTH01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH02":
                        mapper[i] = (e, v) => e.SUPER_MTH02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH03":
                        mapper[i] = (e, v) => e.SUPER_MTH03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH04":
                        mapper[i] = (e, v) => e.SUPER_MTH04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH05":
                        mapper[i] = (e, v) => e.SUPER_MTH05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH06":
                        mapper[i] = (e, v) => e.SUPER_MTH06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH07":
                        mapper[i] = (e, v) => e.SUPER_MTH07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH08":
                        mapper[i] = (e, v) => e.SUPER_MTH08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH09":
                        mapper[i] = (e, v) => e.SUPER_MTH09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH10":
                        mapper[i] = (e, v) => e.SUPER_MTH10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH11":
                        mapper[i] = (e, v) => e.SUPER_MTH11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH12":
                        mapper[i] = (e, v) => e.SUPER_MTH12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV01":
                        mapper[i] = (e, v) => e.SUPER_PROV01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV02":
                        mapper[i] = (e, v) => e.SUPER_PROV02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV03":
                        mapper[i] = (e, v) => e.SUPER_PROV03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV04":
                        mapper[i] = (e, v) => e.SUPER_PROV04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV05":
                        mapper[i] = (e, v) => e.SUPER_PROV05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV06":
                        mapper[i] = (e, v) => e.SUPER_PROV06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV07":
                        mapper[i] = (e, v) => e.SUPER_PROV07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV08":
                        mapper[i] = (e, v) => e.SUPER_PROV08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV09":
                        mapper[i] = (e, v) => e.SUPER_PROV09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV10":
                        mapper[i] = (e, v) => e.SUPER_PROV10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV11":
                        mapper[i] = (e, v) => e.SUPER_PROV11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV12":
                        mapper[i] = (e, v) => e.SUPER_PROV12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PAID_YTD":
                        mapper[i] = (e, v) => e.SUPER_PAID_YTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PAID_TODATE":
                        mapper[i] = (e, v) => e.SUPER_PAID_TODATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUPER_UNPAID_LYR":
                        mapper[i] = (e, v) => e.SUPER_UNPAID_LYR = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }
    }
}
