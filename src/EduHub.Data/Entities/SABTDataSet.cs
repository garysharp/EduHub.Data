using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Billing Template Transactions Data Set
    /// </summary>
    public sealed class SABTDataSet : SetBase<SABT>
    {

        internal SABTDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SABT"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SABT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SABT" /> fields for each CSV column header</returns>
        protected override Action<SABT, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SABT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SABTKEY":
                        mapper[i] = (e, v) => e.SABTKEY = v;
                        break;
                    case "LINKKEY":
                        mapper[i] = (e, v) => e.LINKKEY = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
