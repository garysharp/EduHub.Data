using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Instances Data Set
    /// </summary>
    public sealed class TETEDataSet : SetBase<TETE>
    {

        internal TETEDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TETE"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETE" /> fields for each CSV column header</returns>
        protected override Action<TETE, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TETEKEY":
                        mapper[i] = (e, v) => e.TETEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EVENT_DATE":
                        mapper[i] = (e, v) => e.EVENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
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
