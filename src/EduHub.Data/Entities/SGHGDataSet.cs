using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Eligibility Criteria Data Set
    /// </summary>
    public sealed class SGHGDataSet : SetBase<SGHG>
    {

        internal SGHGDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGHG"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGHG" /> fields for each CSV column header</returns>
        protected override Action<SGHG, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SGHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SGHGKEY":
                        mapper[i] = (e, v) => e.SGHGKEY = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
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
