using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Subjects Data Set
    /// </summary>
    public sealed class TTESDataSet : SetBase<TTES>
    {

        internal TTESDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTES"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTES" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTES" /> fields for each CSV column header</returns>
        protected override Action<TTES, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTES, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEI_TID":
                        mapper[i] = (e, v) => e.TTEI_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "UNITS":
                        mapper[i] = (e, v) => e.UNITS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INCLUDE01":
                        mapper[i] = (e, v) => e.INCLUDE01 = v;
                        break;
                    case "INCLUDE02":
                        mapper[i] = (e, v) => e.INCLUDE02 = v;
                        break;
                    case "INCLUDE03":
                        mapper[i] = (e, v) => e.INCLUDE03 = v;
                        break;
                    case "INCLUDE04":
                        mapper[i] = (e, v) => e.INCLUDE04 = v;
                        break;
                    case "INCLUDE05":
                        mapper[i] = (e, v) => e.INCLUDE05 = v;
                        break;
                    case "INCLUDE06":
                        mapper[i] = (e, v) => e.INCLUDE06 = v;
                        break;
                    case "INCLUDE07":
                        mapper[i] = (e, v) => e.INCLUDE07 = v;
                        break;
                    case "INCLUDE08":
                        mapper[i] = (e, v) => e.INCLUDE08 = v;
                        break;
                    case "INCLUDE09":
                        mapper[i] = (e, v) => e.INCLUDE09 = v;
                        break;
                    case "INCLUDE10":
                        mapper[i] = (e, v) => e.INCLUDE10 = v;
                        break;
                    case "INCLUDE11":
                        mapper[i] = (e, v) => e.INCLUDE11 = v;
                        break;
                    case "INCLUDE12":
                        mapper[i] = (e, v) => e.INCLUDE12 = v;
                        break;
                    case "INCLUDE13":
                        mapper[i] = (e, v) => e.INCLUDE13 = v;
                        break;
                    case "INCLUDE14":
                        mapper[i] = (e, v) => e.INCLUDE14 = v;
                        break;
                    case "INCLUDE15":
                        mapper[i] = (e, v) => e.INCLUDE15 = v;
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
