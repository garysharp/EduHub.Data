using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Grid Data Set
    /// </summary>
    public sealed class TTEXDataSet : SetBase<TTEX>
    {

        internal TTEXDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEX"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEX" /> fields for each CSV column header</returns>
        protected override Action<TTEX, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TTEX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTES_TID":
                        mapper[i] = (e, v) => e.TTES_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXAM_ROW":
                        mapper[i] = (e, v) => e.EXAM_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_COL":
                        mapper[i] = (e, v) => e.EXAM_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_ROW":
                        mapper[i] = (e, v) => e.EXAM_FIX_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_COL":
                        mapper[i] = (e, v) => e.EXAM_FIX_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_ROOM":
                        mapper[i] = (e, v) => e.EXAM_ROOM = v;
                        break;
                    case "EXAM_DESCRIPTION":
                        mapper[i] = (e, v) => e.EXAM_DESCRIPTION = v;
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
