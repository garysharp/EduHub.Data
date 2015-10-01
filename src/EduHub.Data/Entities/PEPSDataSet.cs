using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard and Last Pays Data Set
    /// </summary>
    public sealed class PEPSDataSet : SetBase<PEPS>
    {

        internal PEPSDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPS"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPS" /> fields for each CSV column header</returns>
        protected override Action<PEPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v;
                        break;
                    case "TRPAYSPAN":
                        mapper[i] = (e, v) => e.TRPAYSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRTAXSPAN":
                        mapper[i] = (e, v) => e.TRTAXSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIMESHEET_NO":
                        mapper[i] = (e, v) => e.TIMESHEET_NO = v;
                        break;
                    case "PAY_STEP":
                        mapper[i] = (e, v) => e.PAY_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "SUPER_PERCENT":
                        mapper[i] = (e, v) => e.SUPER_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRCENTRE":
                        mapper[i] = (e, v) => e.TRCENTRE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "SPLIT_PERCENT":
                        mapper[i] = (e, v) => e.SPLIT_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ALTER_TRQTY":
                        mapper[i] = (e, v) => e.ALTER_TRQTY = v == null ? (double?)null : double.Parse(v);
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
