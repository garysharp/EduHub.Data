using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Part-Time Enrolments Data Set
    /// </summary>
    public sealed partial class STPTDataSet : SetBase<STPT>
    {


        internal STPTDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STPT"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPT" /> fields for each CSV column header</returns>
        protected override Action<STPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STPTKEY":
                        mapper[i] = (e, v) => e.STPTKEY = v;
                        break;
                    case "SCHL_NUM":
                        mapper[i] = (e, v) => e.SCHL_NUM = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ENROLLED":
                        mapper[i] = (e, v) => e.ENROLLED = v;
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
