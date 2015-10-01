using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members Data Set
    /// </summary>
    public sealed class SGAMDataSet : SetBase<SGAM>
    {

        internal SGAMDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGAM"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGAM" /> fields for each CSV column header</returns>
        protected override Action<SGAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SGAMKEY":
                        mapper[i] = (e, v) => e.SGAMKEY = v;
                        break;
                    case "ADULT_PERSON_TYPE":
                        mapper[i] = (e, v) => e.ADULT_PERSON_TYPE = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "RESPONSIBLE":
                        mapper[i] = (e, v) => e.RESPONSIBLE = v;
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
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
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
