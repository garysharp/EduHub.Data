using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members Data Set
    /// </summary>
    public sealed partial class SDGMDataSet : SetBase<SDGM>
    {


        internal SDGMDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDGM"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDGM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDGM" /> fields for each CSV column header</returns>
        protected override Action<SDGM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDGM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SDGMKEY":
                        mapper[i] = (e, v) => e.SDGMKEY = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OTHER_COMMENTS":
                        mapper[i] = (e, v) => e.OTHER_COMMENTS = v;
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
