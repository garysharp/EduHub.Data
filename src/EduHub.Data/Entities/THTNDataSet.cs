using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Labels Data Set
    /// </summary>
    public sealed partial class THTNDataSet : SetBase<THTN>
    {


        internal THTNDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "THTN"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="THTN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="THTN" /> fields for each CSV column header</returns>
        protected override Action<THTN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<THTN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "LABEL_NUMBER":
                        mapper[i] = (e, v) => e.LABEL_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LABEL_TYPE":
                        mapper[i] = (e, v) => e.LABEL_TYPE = v;
                        break;
                    case "LABEL_NAME":
                        mapper[i] = (e, v) => e.LABEL_NAME = v;
                        break;
                    case "LABEL_COLOUR":
                        mapper[i] = (e, v) => e.LABEL_COLOUR = v == null ? (int?)null : int.Parse(v);
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
