using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Trips Data Set
    /// </summary>
    public sealed partial class STTRIPSDataSet : SetBase<STTRIPS>
    {


        internal STTRIPSDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STTRIPS"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STTRIPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STTRIPS" /> fields for each CSV column header</returns>
        protected override Action<STTRIPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STTRIPS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STUDENT_ID":
                        mapper[i] = (e, v) => e.STUDENT_ID = v;
                        break;
                    case "TRANSPORT_START_DATE":
                        mapper[i] = (e, v) => e.TRANSPORT_START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRANSPORT_END_DATE":
                        mapper[i] = (e, v) => e.TRANSPORT_END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRAVEL_IN_WHEELCHAIR":
                        mapper[i] = (e, v) => e.TRAVEL_IN_WHEELCHAIR = v;
                        break;
                    case "TRAVEL_DAY":
                        mapper[i] = (e, v) => e.TRAVEL_DAY = v;
                        break;
                    case "TRAVEL_NOTES":
                        mapper[i] = (e, v) => e.TRAVEL_NOTES = v;
                        break;
                    case "AM_ROUTE_ID":
                        mapper[i] = (e, v) => e.AM_ROUTE_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM_TRANSPORT_MODE":
                        mapper[i] = (e, v) => e.AM_TRANSPORT_MODE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM_ROUTE_EVERY_DAY":
                        mapper[i] = (e, v) => e.AM_ROUTE_EVERY_DAY = v;
                        break;
                    case "AM_PICKUP_TIME":
                        mapper[i] = (e, v) => e.AM_PICKUP_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_PICKUP_ADDRESS_ID":
                        mapper[i] = (e, v) => e.AM_PICKUP_ADDRESS_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM_PICKUP_ADD_SAME_AS_HOME":
                        mapper[i] = (e, v) => e.AM_PICKUP_ADD_SAME_AS_HOME = v;
                        break;
                    case "AM_PICKUP_DIRECTIONS":
                        mapper[i] = (e, v) => e.AM_PICKUP_DIRECTIONS = v;
                        break;
                    case "AM_PICKUP_ADD_MAP_TYPE":
                        mapper[i] = (e, v) => e.AM_PICKUP_ADD_MAP_TYPE = v;
                        break;
                    case "AM_PICKUP_ADD_MAP_NO":
                        mapper[i] = (e, v) => e.AM_PICKUP_ADD_MAP_NO = v;
                        break;
                    case "AM_PICKUP_ADD_MAP_X_REF":
                        mapper[i] = (e, v) => e.AM_PICKUP_ADD_MAP_X_REF = v;
                        break;
                    case "AM_PICKUP_ADD_DESCP":
                        mapper[i] = (e, v) => e.AM_PICKUP_ADD_DESCP = v;
                        break;
                    case "AM_SETDOWN_TIME":
                        mapper[i] = (e, v) => e.AM_SETDOWN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_SETDOWN_CAMPUS":
                        mapper[i] = (e, v) => e.AM_SETDOWN_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM_ROUTE_ID":
                        mapper[i] = (e, v) => e.PM_ROUTE_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM_TRANSPORT_MODE":
                        mapper[i] = (e, v) => e.PM_TRANSPORT_MODE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM_ROUTE_EVERY_DAY":
                        mapper[i] = (e, v) => e.PM_ROUTE_EVERY_DAY = v;
                        break;
                    case "PM_PICKUP_TIME":
                        mapper[i] = (e, v) => e.PM_PICKUP_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_PICKUP_CAMPUS":
                        mapper[i] = (e, v) => e.PM_PICKUP_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM_SETDOWN_TIME":
                        mapper[i] = (e, v) => e.PM_SETDOWN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_SETDOWN_ADDRESS_ID":
                        mapper[i] = (e, v) => e.PM_SETDOWN_ADDRESS_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM_STDWN_AM_PKUP_ADD_SAME":
                        mapper[i] = (e, v) => e.PM_STDWN_AM_PKUP_ADD_SAME = v;
                        break;
                    case "PM_SETDOWN_DIRECTIONS":
                        mapper[i] = (e, v) => e.PM_SETDOWN_DIRECTIONS = v;
                        break;
                    case "PM_SETDOWN_ADD_MAP_TYPE":
                        mapper[i] = (e, v) => e.PM_SETDOWN_ADD_MAP_TYPE = v;
                        break;
                    case "PM_SETDOWN_ADD_MAP_NO":
                        mapper[i] = (e, v) => e.PM_SETDOWN_ADD_MAP_NO = v;
                        break;
                    case "PM_SETDOWN_ADD_MAP_X_REF":
                        mapper[i] = (e, v) => e.PM_SETDOWN_ADD_MAP_X_REF = v;
                        break;
                    case "PM_SETDOWN_ADD_DESCP":
                        mapper[i] = (e, v) => e.PM_SETDOWN_ADD_DESCP = v;
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
