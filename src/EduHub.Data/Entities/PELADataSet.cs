using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Audit Data Set
    /// </summary>
    public sealed partial class PELADataSet : SetBase<PELA>
    {


        internal PELADataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PELA"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PELA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PELA" /> fields for each CSV column header</returns>
        protected override Action<PELA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PELA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_STARTDATE":
                        mapper[i] = (e, v) => e.LEAVE_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_CALC_DATE":
                        mapper[i] = (e, v) => e.LAST_CALC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_ANNIV_DATE":
                        mapper[i] = (e, v) => e.LAST_ANNIV_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNIVERSARY_DATE":
                        mapper[i] = (e, v) => e.ANNIVERSARY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LEAVE_ENT_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_ENT_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_PRORATA_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_PRORATA_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH_STEP":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PENALTY_DAYS":
                        mapper[i] = (e, v) => e.PENALTY_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATE_START":
                        mapper[i] = (e, v) => e.DATE_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DATE_END":
                        mapper[i] = (e, v) => e.DATE_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CHANGE_TYPE":
                        mapper[i] = (e, v) => e.CHANGE_TYPE = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
