using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Invoice Allocations Data Set
    /// </summary>
    public sealed partial class STSBDataSet : SetBase<STSB>
    {


        internal STSBDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STSB"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSB" /> fields for each CSV column header</returns>
        protected override Action<STSB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "PERCENTAGE":
                        mapper[i] = (e, v) => e.PERCENTAGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SPLIT_ITEM":
                        mapper[i] = (e, v) => e.SPLIT_ITEM = v;
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "SPLIT_ITEM_SU":
                        mapper[i] = (e, v) => e.SPLIT_ITEM_SU = v;
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
