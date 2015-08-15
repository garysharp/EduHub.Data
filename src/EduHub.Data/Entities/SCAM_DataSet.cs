using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Meetings Data Set
    /// </summary>
    public sealed class SCAM_DataSet : SetBase<SCAM_Entity>
    {

        internal SCAM_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCAM"; } }

        protected override Action<SCAM_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCAM_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SCAMKEY":
                        mapper[i] = (e, v) => e.SCAMKEY = v;
                        break;
                    case "MEETING_DATE":
                        mapper[i] = (e, v) => e.MEETING_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MEETING_TIME":
                        mapper[i] = (e, v) => e.MEETING_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MEETING_PURPOSE":
                        mapper[i] = (e, v) => e.MEETING_PURPOSE = v;
                        break;
                    case "MEETING_LOCATION":
                        mapper[i] = (e, v) => e.MEETING_LOCATION = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEETING_ROOM":
                        mapper[i] = (e, v) => e.MEETING_ROOM = v;
                        break;
                    case "MINUTES_MEMO":
                        mapper[i] = (e, v) => e.MINUTES_MEMO = v;
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
