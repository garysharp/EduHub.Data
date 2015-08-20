using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Periods Data Set
    /// </summary>
    public sealed class TTEPDataSet : SetBase<TTEP>
    {

        internal TTEPDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEP"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEP" /> fields for each CSV column header</returns>
        protected override Action<TTEP, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TTEP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEI_TID":
                        mapper[i] = (e, v) => e.TTEI_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXAM_DATE":
                        mapper[i] = (e, v) => e.EXAM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXAM_ROW":
                        mapper[i] = (e, v) => e.EXAM_ROW = v == null ? (short?)null : short.Parse(v);
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
