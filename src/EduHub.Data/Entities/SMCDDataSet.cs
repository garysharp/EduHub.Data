using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medication Doses Data Set
    /// </summary>
    public sealed partial class SMCDDataSet : SetBase<SMCD>
    {


        internal SMCDDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMCD"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMCD" /> fields for each CSV column header</returns>
        protected override Action<SMCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMCD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SMCDKEY":
                        mapper[i] = (e, v) => e.SMCDKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ADMIN_DATE":
                        mapper[i] = (e, v) => e.ADMIN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ADMIN_TIME":
                        mapper[i] = (e, v) => e.ADMIN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DOSE":
                        mapper[i] = (e, v) => e.DOSE = v;
                        break;
                    case "ADMIN_BY_OTHER":
                        mapper[i] = (e, v) => e.ADMIN_BY_OTHER = v;
                        break;
                    case "ADMIN_NOTES":
                        mapper[i] = (e, v) => e.ADMIN_NOTES = v;
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
