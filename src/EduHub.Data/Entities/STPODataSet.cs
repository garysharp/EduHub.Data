using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Position or Group Memberships Data Set
    /// </summary>
    public sealed class STPODataSet : SetBase<STPO>
    {

        internal STPODataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STPO"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPO" /> fields for each CSV column header</returns>
        protected override Action<STPO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STPOKEY":
                        mapper[i] = (e, v) => e.STPOKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PERFORMANCE":
                        mapper[i] = (e, v) => e.PERFORMANCE = v;
                        break;
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "OTHER":
                        mapper[i] = (e, v) => e.OTHER = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
                        break;
                    case "PERMISSION":
                        mapper[i] = (e, v) => e.PERMISSION = v;
                        break;
                    case "SCH_PERMISSION":
                        mapper[i] = (e, v) => e.SCH_PERMISSION = v;
                        break;
                    case "FULLY_PAID":
                        mapper[i] = (e, v) => e.FULLY_PAID = v;
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
