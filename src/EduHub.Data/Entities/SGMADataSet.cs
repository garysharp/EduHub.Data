using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Meeting Attendance Data Set
    /// </summary>
    public sealed class SGMADataSet : SetBase<SGMA>
    {

        internal SGMADataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGMA"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGMA" /> fields for each CSV column header</returns>
        protected override Action<SGMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SGMAKEY":
                        mapper[i] = (e, v) => e.SGMAKEY = v;
                        break;
                    case "SGM_TID":
                        mapper[i] = (e, v) => e.SGM_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEMBER_PERSON_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_PERSON_TYPE = v;
                        break;
                    case "MEMBER_LINK":
                        mapper[i] = (e, v) => e.MEMBER_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
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
