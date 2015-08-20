using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject/Class Eligibility Criteria Data Set
    /// </summary>
    public sealed class SGSCDataSet : SetBase<SGSC>
    {

        internal SGSCDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGSC"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGSC" /> fields for each CSV column header</returns>
        protected override Action<SGSC, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SGSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SGSCKEY":
                        mapper[i] = (e, v) => e.SGSCKEY = v;
                        break;
                    case "SULINK":
                        mapper[i] = (e, v) => e.SULINK = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
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
