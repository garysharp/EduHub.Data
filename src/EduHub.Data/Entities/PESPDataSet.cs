using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super Payment Transactions Data Set
    /// </summary>
    public sealed class PESPDataSet : SetBase<PESP>
    {

        internal PESPDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PESP"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PESP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PESP" /> fields for each CSV column header</returns>
        protected override Action<PESP, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PESP, string>[Headers.Count];

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
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYMENT_AMOUNT":
                        mapper[i] = (e, v) => e.PAYMENT_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_FROM_DATE":
                        mapper[i] = (e, v) => e.SUPER_FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUPER_TO_DATE":
                        mapper[i] = (e, v) => e.SUPER_TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PROCESS_DATE":
                        mapper[i] = (e, v) => e.PROCESS_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DATE_ADVISED":
                        mapper[i] = (e, v) => e.DATE_ADVISED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
