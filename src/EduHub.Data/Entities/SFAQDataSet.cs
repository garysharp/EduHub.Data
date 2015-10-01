using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability in Quilt Data Set
    /// </summary>
    public sealed class SFAQDataSet : SetBase<SFAQ>
    {

        internal SFAQDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SFAQ"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFAQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFAQ" /> fields for each CSV column header</returns>
        protected override Action<SFAQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFAQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SFAQKEY":
                        mapper[i] = (e, v) => e.SFAQKEY = v;
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
