using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Attendees Data Set
    /// </summary>
    public sealed partial class TETNDataSet : SetBase<TETN>
    {


        internal TETNDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TETN"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETN" /> fields for each CSV column header</returns>
        protected override Action<TETN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TETN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TETNKEY":
                        mapper[i] = (e, v) => e.TETNKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TETELINK":
                        mapper[i] = (e, v) => e.TETELINK = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ATTENDEE":
                        mapper[i] = (e, v) => e.ATTENDEE = v;
                        break;
                    case "ATTENDEE_TYPE":
                        mapper[i] = (e, v) => e.ATTENDEE_TYPE = v;
                        break;
                    case "ATTENDEE_DETAIL":
                        mapper[i] = (e, v) => e.ATTENDEE_DETAIL = v;
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
