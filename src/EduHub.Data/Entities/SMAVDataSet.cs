using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availablity Extras Data Set
    /// </summary>
    public sealed partial class SMAVDataSet : SetBase<SMAV>
    {


        internal SMAVDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMAV"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMAV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMAV" /> fields for each CSV column header</returns>
        protected override Action<SMAV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMAV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AVAILABLE_DATE":
                        mapper[i] = (e, v) => e.AVAILABLE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
