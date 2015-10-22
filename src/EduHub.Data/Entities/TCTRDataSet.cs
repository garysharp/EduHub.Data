using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Replacements Data Set
    /// </summary>
    public sealed partial class TCTRDataSet : SetBase<TCTR>
    {


        internal TCTRDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTR"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTR" /> fields for each CSV column header</returns>
        protected override Action<TCTR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TCTRKEY":
                        mapper[i] = (e, v) => e.TCTRKEY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TCTQ_TID":
                        mapper[i] = (e, v) => e.TCTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "COMMENT_R":
                        mapper[i] = (e, v) => e.COMMENT_R = v;
                        break;
                    case "COUNT_EXTRAS":
                        mapper[i] = (e, v) => e.COUNT_EXTRAS = v;
                        break;
                    case "EXTRAS_VALUE":
                        mapper[i] = (e, v) => e.EXTRAS_VALUE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABSENTEE_TID":
                        mapper[i] = (e, v) => e.ABSENTEE_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER_CLASH":
                        mapper[i] = (e, v) => e.TEACHER_CLASH = v;
                        break;
                    case "ROOM_CLASH":
                        mapper[i] = (e, v) => e.ROOM_CLASH = v;
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
