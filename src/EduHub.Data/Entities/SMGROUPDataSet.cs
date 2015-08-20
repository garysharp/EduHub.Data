using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms group Data Set
    /// </summary>
    public sealed class SMGROUPDataSet : SetBase<SMGROUP>
    {

        internal SMGROUPDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMGROUP"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMGROUP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMGROUP" /> fields for each CSV column header</returns>
        protected override Action<SMGROUP, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SMGROUP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GROUPKEY":
                        mapper[i] = (e, v) => e.GROUPKEY = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
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
