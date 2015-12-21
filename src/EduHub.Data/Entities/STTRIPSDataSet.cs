using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Trips Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STTRIPSDataSet : EduHubDataSet<STTRIPS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STTRIPS"; } }

        internal STTRIPSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AM_PICKUP_ADDRESS_ID = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.AM_PICKUP_ADDRESS_ID));
            Index_AM_ROUTE_ID = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.AM_ROUTE_ID));
            Index_AM_SETDOWN_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.AM_SETDOWN_CAMPUS));
            Index_AM_TRANSPORT_MODE = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.AM_TRANSPORT_MODE));
            Index_PM_PICKUP_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.PM_PICKUP_CAMPUS));
            Index_PM_ROUTE_ID = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.PM_ROUTE_ID));
            Index_PM_SETDOWN_ADDRESS_ID = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.PM_SETDOWN_ADDRESS_ID));
            Index_PM_TRANSPORT_MODE = new Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedNullDictionary(i => i.PM_TRANSPORT_MODE));
            Index_STUDENT_ID = new Lazy<Dictionary<string, IReadOnlyList<STTRIPS>>>(() => this.ToGroupedDictionary(i => i.STUDENT_ID));
            Index_STUDENT_ID_TRAVEL_DAY = new Lazy<Dictionary<Tuple<string, string>, STTRIPS>>(() => this.ToDictionary(i => Tuple.Create(i.STUDENT_ID, i.TRAVEL_DAY)));
            Index_TID = new Lazy<Dictionary<int, STTRIPS>>(() => this.ToDictionary(i => i.TID));
        }

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
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
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

        /// <summary>
        /// Merges <see cref="STTRIPS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STTRIPS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STTRIPS" /> items to added or update the base <see cref="STTRIPS" /> items</param>
        /// <returns>A merged list of <see cref="STTRIPS" /> items</returns>
        protected override List<STTRIPS> ApplyDeltaItems(List<STTRIPS> Items, List<STTRIPS> DeltaItems)
        {
            Dictionary<Tuple<string, string>, int> Index_STUDENT_ID_TRAVEL_DAY = Items.ToIndexDictionary(i => Tuple.Create(i.STUDENT_ID, i.TRAVEL_DAY));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STTRIPS deltaItem in DeltaItems)
            {
                int index;

                if (Index_STUDENT_ID_TRAVEL_DAY.TryGetValue(Tuple.Create(deltaItem.STUDENT_ID, deltaItem.TRAVEL_DAY), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.STUDENT_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_AM_PICKUP_ADDRESS_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_AM_ROUTE_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_AM_SETDOWN_CAMPUS;
        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_AM_TRANSPORT_MODE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_PM_PICKUP_CAMPUS;
        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_PM_ROUTE_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_PM_SETDOWN_ADDRESS_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<STTRIPS>>> Index_PM_TRANSPORT_MODE;
        private Lazy<Dictionary<string, IReadOnlyList<STTRIPS>>> Index_STUDENT_ID;
        private Lazy<Dictionary<Tuple<string, string>, STTRIPS>> Index_STUDENT_ID_TRAVEL_DAY;
        private Lazy<Dictionary<int, STTRIPS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STTRIPS by AM_PICKUP_ADDRESS_ID field
        /// </summary>
        /// <param name="AM_PICKUP_ADDRESS_ID">AM_PICKUP_ADDRESS_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByAM_PICKUP_ADDRESS_ID(int? AM_PICKUP_ADDRESS_ID)
        {
            return Index_AM_PICKUP_ADDRESS_ID.Value[AM_PICKUP_ADDRESS_ID];
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_PICKUP_ADDRESS_ID field
        /// </summary>
        /// <param name="AM_PICKUP_ADDRESS_ID">AM_PICKUP_ADDRESS_ID value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_PICKUP_ADDRESS_ID(int? AM_PICKUP_ADDRESS_ID, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_AM_PICKUP_ADDRESS_ID.Value.TryGetValue(AM_PICKUP_ADDRESS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_PICKUP_ADDRESS_ID field
        /// </summary>
        /// <param name="AM_PICKUP_ADDRESS_ID">AM_PICKUP_ADDRESS_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByAM_PICKUP_ADDRESS_ID(int? AM_PICKUP_ADDRESS_ID)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_AM_PICKUP_ADDRESS_ID.Value.TryGetValue(AM_PICKUP_ADDRESS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by AM_ROUTE_ID field
        /// </summary>
        /// <param name="AM_ROUTE_ID">AM_ROUTE_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByAM_ROUTE_ID(int? AM_ROUTE_ID)
        {
            return Index_AM_ROUTE_ID.Value[AM_ROUTE_ID];
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_ROUTE_ID field
        /// </summary>
        /// <param name="AM_ROUTE_ID">AM_ROUTE_ID value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_ROUTE_ID(int? AM_ROUTE_ID, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_AM_ROUTE_ID.Value.TryGetValue(AM_ROUTE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_ROUTE_ID field
        /// </summary>
        /// <param name="AM_ROUTE_ID">AM_ROUTE_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByAM_ROUTE_ID(int? AM_ROUTE_ID)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_AM_ROUTE_ID.Value.TryGetValue(AM_ROUTE_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by AM_SETDOWN_CAMPUS field
        /// </summary>
        /// <param name="AM_SETDOWN_CAMPUS">AM_SETDOWN_CAMPUS value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByAM_SETDOWN_CAMPUS(int? AM_SETDOWN_CAMPUS)
        {
            return Index_AM_SETDOWN_CAMPUS.Value[AM_SETDOWN_CAMPUS];
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_SETDOWN_CAMPUS field
        /// </summary>
        /// <param name="AM_SETDOWN_CAMPUS">AM_SETDOWN_CAMPUS value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_SETDOWN_CAMPUS(int? AM_SETDOWN_CAMPUS, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_AM_SETDOWN_CAMPUS.Value.TryGetValue(AM_SETDOWN_CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_SETDOWN_CAMPUS field
        /// </summary>
        /// <param name="AM_SETDOWN_CAMPUS">AM_SETDOWN_CAMPUS value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByAM_SETDOWN_CAMPUS(int? AM_SETDOWN_CAMPUS)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_AM_SETDOWN_CAMPUS.Value.TryGetValue(AM_SETDOWN_CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by AM_TRANSPORT_MODE field
        /// </summary>
        /// <param name="AM_TRANSPORT_MODE">AM_TRANSPORT_MODE value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByAM_TRANSPORT_MODE(int? AM_TRANSPORT_MODE)
        {
            return Index_AM_TRANSPORT_MODE.Value[AM_TRANSPORT_MODE];
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_TRANSPORT_MODE field
        /// </summary>
        /// <param name="AM_TRANSPORT_MODE">AM_TRANSPORT_MODE value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_TRANSPORT_MODE(int? AM_TRANSPORT_MODE, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_AM_TRANSPORT_MODE.Value.TryGetValue(AM_TRANSPORT_MODE, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by AM_TRANSPORT_MODE field
        /// </summary>
        /// <param name="AM_TRANSPORT_MODE">AM_TRANSPORT_MODE value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByAM_TRANSPORT_MODE(int? AM_TRANSPORT_MODE)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_AM_TRANSPORT_MODE.Value.TryGetValue(AM_TRANSPORT_MODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by PM_PICKUP_CAMPUS field
        /// </summary>
        /// <param name="PM_PICKUP_CAMPUS">PM_PICKUP_CAMPUS value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByPM_PICKUP_CAMPUS(int? PM_PICKUP_CAMPUS)
        {
            return Index_PM_PICKUP_CAMPUS.Value[PM_PICKUP_CAMPUS];
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_PICKUP_CAMPUS field
        /// </summary>
        /// <param name="PM_PICKUP_CAMPUS">PM_PICKUP_CAMPUS value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_PICKUP_CAMPUS(int? PM_PICKUP_CAMPUS, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_PM_PICKUP_CAMPUS.Value.TryGetValue(PM_PICKUP_CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_PICKUP_CAMPUS field
        /// </summary>
        /// <param name="PM_PICKUP_CAMPUS">PM_PICKUP_CAMPUS value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByPM_PICKUP_CAMPUS(int? PM_PICKUP_CAMPUS)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_PM_PICKUP_CAMPUS.Value.TryGetValue(PM_PICKUP_CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by PM_ROUTE_ID field
        /// </summary>
        /// <param name="PM_ROUTE_ID">PM_ROUTE_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByPM_ROUTE_ID(int? PM_ROUTE_ID)
        {
            return Index_PM_ROUTE_ID.Value[PM_ROUTE_ID];
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_ROUTE_ID field
        /// </summary>
        /// <param name="PM_ROUTE_ID">PM_ROUTE_ID value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_ROUTE_ID(int? PM_ROUTE_ID, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_PM_ROUTE_ID.Value.TryGetValue(PM_ROUTE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_ROUTE_ID field
        /// </summary>
        /// <param name="PM_ROUTE_ID">PM_ROUTE_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByPM_ROUTE_ID(int? PM_ROUTE_ID)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_PM_ROUTE_ID.Value.TryGetValue(PM_ROUTE_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by PM_SETDOWN_ADDRESS_ID field
        /// </summary>
        /// <param name="PM_SETDOWN_ADDRESS_ID">PM_SETDOWN_ADDRESS_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByPM_SETDOWN_ADDRESS_ID(int? PM_SETDOWN_ADDRESS_ID)
        {
            return Index_PM_SETDOWN_ADDRESS_ID.Value[PM_SETDOWN_ADDRESS_ID];
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_SETDOWN_ADDRESS_ID field
        /// </summary>
        /// <param name="PM_SETDOWN_ADDRESS_ID">PM_SETDOWN_ADDRESS_ID value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_SETDOWN_ADDRESS_ID(int? PM_SETDOWN_ADDRESS_ID, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_PM_SETDOWN_ADDRESS_ID.Value.TryGetValue(PM_SETDOWN_ADDRESS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_SETDOWN_ADDRESS_ID field
        /// </summary>
        /// <param name="PM_SETDOWN_ADDRESS_ID">PM_SETDOWN_ADDRESS_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByPM_SETDOWN_ADDRESS_ID(int? PM_SETDOWN_ADDRESS_ID)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_PM_SETDOWN_ADDRESS_ID.Value.TryGetValue(PM_SETDOWN_ADDRESS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by PM_TRANSPORT_MODE field
        /// </summary>
        /// <param name="PM_TRANSPORT_MODE">PM_TRANSPORT_MODE value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindByPM_TRANSPORT_MODE(int? PM_TRANSPORT_MODE)
        {
            return Index_PM_TRANSPORT_MODE.Value[PM_TRANSPORT_MODE];
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_TRANSPORT_MODE field
        /// </summary>
        /// <param name="PM_TRANSPORT_MODE">PM_TRANSPORT_MODE value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_TRANSPORT_MODE(int? PM_TRANSPORT_MODE, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_PM_TRANSPORT_MODE.Value.TryGetValue(PM_TRANSPORT_MODE, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by PM_TRANSPORT_MODE field
        /// </summary>
        /// <param name="PM_TRANSPORT_MODE">PM_TRANSPORT_MODE value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindByPM_TRANSPORT_MODE(int? PM_TRANSPORT_MODE)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_PM_TRANSPORT_MODE.Value.TryGetValue(PM_TRANSPORT_MODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by STUDENT_ID field
        /// </summary>
        /// <param name="STUDENT_ID">STUDENT_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> FindBySTUDENT_ID(string STUDENT_ID)
        {
            return Index_STUDENT_ID.Value[STUDENT_ID];
        }

        /// <summary>
        /// Attempt to find STTRIPS by STUDENT_ID field
        /// </summary>
        /// <param name="STUDENT_ID">STUDENT_ID value used to find STTRIPS</param>
        /// <param name="Value">List of related STTRIPS entities</param>
        /// <returns>True if the list of related STTRIPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT_ID(string STUDENT_ID, out IReadOnlyList<STTRIPS> Value)
        {
            return Index_STUDENT_ID.Value.TryGetValue(STUDENT_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by STUDENT_ID field
        /// </summary>
        /// <param name="STUDENT_ID">STUDENT_ID value used to find STTRIPS</param>
        /// <returns>List of related STTRIPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STTRIPS> TryFindBySTUDENT_ID(string STUDENT_ID)
        {
            IReadOnlyList<STTRIPS> value;
            if (Index_STUDENT_ID.Value.TryGetValue(STUDENT_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by STUDENT_ID and TRAVEL_DAY fields
        /// </summary>
        /// <param name="STUDENT_ID">STUDENT_ID value used to find STTRIPS</param>
        /// <param name="TRAVEL_DAY">TRAVEL_DAY value used to find STTRIPS</param>
        /// <returns>Related STTRIPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STTRIPS FindBySTUDENT_ID_TRAVEL_DAY(string STUDENT_ID, string TRAVEL_DAY)
        {
            return Index_STUDENT_ID_TRAVEL_DAY.Value[Tuple.Create(STUDENT_ID, TRAVEL_DAY)];
        }

        /// <summary>
        /// Attempt to find STTRIPS by STUDENT_ID and TRAVEL_DAY fields
        /// </summary>
        /// <param name="STUDENT_ID">STUDENT_ID value used to find STTRIPS</param>
        /// <param name="TRAVEL_DAY">TRAVEL_DAY value used to find STTRIPS</param>
        /// <param name="Value">Related STTRIPS entity</param>
        /// <returns>True if the related STTRIPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT_ID_TRAVEL_DAY(string STUDENT_ID, string TRAVEL_DAY, out STTRIPS Value)
        {
            return Index_STUDENT_ID_TRAVEL_DAY.Value.TryGetValue(Tuple.Create(STUDENT_ID, TRAVEL_DAY), out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by STUDENT_ID and TRAVEL_DAY fields
        /// </summary>
        /// <param name="STUDENT_ID">STUDENT_ID value used to find STTRIPS</param>
        /// <param name="TRAVEL_DAY">TRAVEL_DAY value used to find STTRIPS</param>
        /// <returns>Related STTRIPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STTRIPS TryFindBySTUDENT_ID_TRAVEL_DAY(string STUDENT_ID, string TRAVEL_DAY)
        {
            STTRIPS value;
            if (Index_STUDENT_ID_TRAVEL_DAY.Value.TryGetValue(Tuple.Create(STUDENT_ID, TRAVEL_DAY), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STTRIPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STTRIPS</param>
        /// <returns>Related STTRIPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STTRIPS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STTRIPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STTRIPS</param>
        /// <param name="Value">Related STTRIPS entity</param>
        /// <returns>True if the related STTRIPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STTRIPS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STTRIPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STTRIPS</param>
        /// <returns>Related STTRIPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STTRIPS TryFindByTID(int TID)
        {
            STTRIPS value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns SQL which checks for the existence of a STTRIPS table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STTRIPS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STTRIPS](
        [TID] int IDENTITY NOT NULL,
        [STUDENT_ID] varchar(10) NOT NULL,
        [TRANSPORT_START_DATE] datetime NULL,
        [TRANSPORT_END_DATE] datetime NULL,
        [TRAVEL_IN_WHEELCHAIR] varchar(1) NULL,
        [TRAVEL_DAY] varchar(2) NULL,
        [TRAVEL_NOTES] text NULL,
        [AM_ROUTE_ID] int NULL,
        [AM_TRANSPORT_MODE] int NULL,
        [AM_ROUTE_EVERY_DAY] varchar(1) NULL,
        [AM_PICKUP_TIME] smallint NULL,
        [AM_PICKUP_ADDRESS_ID] int NULL,
        [AM_PICKUP_ADD_SAME_AS_HOME] varchar(1) NULL,
        [AM_PICKUP_DIRECTIONS] varchar(2) NULL,
        [AM_PICKUP_ADD_MAP_TYPE] varchar(1) NULL,
        [AM_PICKUP_ADD_MAP_NO] varchar(4) NULL,
        [AM_PICKUP_ADD_MAP_X_REF] varchar(4) NULL,
        [AM_PICKUP_ADD_DESCP] text NULL,
        [AM_SETDOWN_TIME] smallint NULL,
        [AM_SETDOWN_CAMPUS] int NULL,
        [PM_ROUTE_ID] int NULL,
        [PM_TRANSPORT_MODE] int NULL,
        [PM_ROUTE_EVERY_DAY] varchar(1) NULL,
        [PM_PICKUP_TIME] smallint NULL,
        [PM_PICKUP_CAMPUS] int NULL,
        [PM_SETDOWN_TIME] smallint NULL,
        [PM_SETDOWN_ADDRESS_ID] int NULL,
        [PM_STDWN_AM_PKUP_ADD_SAME] varchar(1) NULL,
        [PM_SETDOWN_DIRECTIONS] varchar(2) NULL,
        [PM_SETDOWN_ADD_MAP_TYPE] varchar(1) NULL,
        [PM_SETDOWN_ADD_MAP_NO] varchar(4) NULL,
        [PM_SETDOWN_ADD_MAP_X_REF] varchar(4) NULL,
        [PM_SETDOWN_ADD_DESCP] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STTRIPS_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_AM_PICKUP_ADDRESS_ID] ON [dbo].[STTRIPS]
    (
            [AM_PICKUP_ADDRESS_ID] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_AM_ROUTE_ID] ON [dbo].[STTRIPS]
    (
            [AM_ROUTE_ID] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_AM_SETDOWN_CAMPUS] ON [dbo].[STTRIPS]
    (
            [AM_SETDOWN_CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_AM_TRANSPORT_MODE] ON [dbo].[STTRIPS]
    (
            [AM_TRANSPORT_MODE] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_PM_PICKUP_CAMPUS] ON [dbo].[STTRIPS]
    (
            [PM_PICKUP_CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_PM_ROUTE_ID] ON [dbo].[STTRIPS]
    (
            [PM_ROUTE_ID] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_PM_SETDOWN_ADDRESS_ID] ON [dbo].[STTRIPS]
    (
            [PM_SETDOWN_ADDRESS_ID] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_PM_TRANSPORT_MODE] ON [dbo].[STTRIPS]
    (
            [PM_TRANSPORT_MODE] ASC
    );
    CREATE CLUSTERED INDEX [STTRIPS_Index_STUDENT_ID] ON [dbo].[STTRIPS]
    (
            [STUDENT_ID] ASC
    );
    CREATE NONCLUSTERED INDEX [STTRIPS_Index_STUDENT_ID_TRAVEL_DAY] ON [dbo].[STTRIPS]
    (
            [STUDENT_ID] ASC,
            [TRAVEL_DAY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STTRIPS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STTRIPS data set</returns>
        public override IDataReader GetDataReader()
        {
            return new STTRIPSDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STTRIPSDataReader : IDataReader, IDataRecord
        {
            private List<STTRIPS> Items;
            private int CurrentIndex;
            private STTRIPS CurrentItem;

            public STTRIPSDataReader(List<STTRIPS> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 36; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // STUDENT_ID
                        return CurrentItem.STUDENT_ID;
                    case 2: // TRANSPORT_START_DATE
                        return CurrentItem.TRANSPORT_START_DATE;
                    case 3: // TRANSPORT_END_DATE
                        return CurrentItem.TRANSPORT_END_DATE;
                    case 4: // TRAVEL_IN_WHEELCHAIR
                        return CurrentItem.TRAVEL_IN_WHEELCHAIR;
                    case 5: // TRAVEL_DAY
                        return CurrentItem.TRAVEL_DAY;
                    case 6: // TRAVEL_NOTES
                        return CurrentItem.TRAVEL_NOTES;
                    case 7: // AM_ROUTE_ID
                        return CurrentItem.AM_ROUTE_ID;
                    case 8: // AM_TRANSPORT_MODE
                        return CurrentItem.AM_TRANSPORT_MODE;
                    case 9: // AM_ROUTE_EVERY_DAY
                        return CurrentItem.AM_ROUTE_EVERY_DAY;
                    case 10: // AM_PICKUP_TIME
                        return CurrentItem.AM_PICKUP_TIME;
                    case 11: // AM_PICKUP_ADDRESS_ID
                        return CurrentItem.AM_PICKUP_ADDRESS_ID;
                    case 12: // AM_PICKUP_ADD_SAME_AS_HOME
                        return CurrentItem.AM_PICKUP_ADD_SAME_AS_HOME;
                    case 13: // AM_PICKUP_DIRECTIONS
                        return CurrentItem.AM_PICKUP_DIRECTIONS;
                    case 14: // AM_PICKUP_ADD_MAP_TYPE
                        return CurrentItem.AM_PICKUP_ADD_MAP_TYPE;
                    case 15: // AM_PICKUP_ADD_MAP_NO
                        return CurrentItem.AM_PICKUP_ADD_MAP_NO;
                    case 16: // AM_PICKUP_ADD_MAP_X_REF
                        return CurrentItem.AM_PICKUP_ADD_MAP_X_REF;
                    case 17: // AM_PICKUP_ADD_DESCP
                        return CurrentItem.AM_PICKUP_ADD_DESCP;
                    case 18: // AM_SETDOWN_TIME
                        return CurrentItem.AM_SETDOWN_TIME;
                    case 19: // AM_SETDOWN_CAMPUS
                        return CurrentItem.AM_SETDOWN_CAMPUS;
                    case 20: // PM_ROUTE_ID
                        return CurrentItem.PM_ROUTE_ID;
                    case 21: // PM_TRANSPORT_MODE
                        return CurrentItem.PM_TRANSPORT_MODE;
                    case 22: // PM_ROUTE_EVERY_DAY
                        return CurrentItem.PM_ROUTE_EVERY_DAY;
                    case 23: // PM_PICKUP_TIME
                        return CurrentItem.PM_PICKUP_TIME;
                    case 24: // PM_PICKUP_CAMPUS
                        return CurrentItem.PM_PICKUP_CAMPUS;
                    case 25: // PM_SETDOWN_TIME
                        return CurrentItem.PM_SETDOWN_TIME;
                    case 26: // PM_SETDOWN_ADDRESS_ID
                        return CurrentItem.PM_SETDOWN_ADDRESS_ID;
                    case 27: // PM_STDWN_AM_PKUP_ADD_SAME
                        return CurrentItem.PM_STDWN_AM_PKUP_ADD_SAME;
                    case 28: // PM_SETDOWN_DIRECTIONS
                        return CurrentItem.PM_SETDOWN_DIRECTIONS;
                    case 29: // PM_SETDOWN_ADD_MAP_TYPE
                        return CurrentItem.PM_SETDOWN_ADD_MAP_TYPE;
                    case 30: // PM_SETDOWN_ADD_MAP_NO
                        return CurrentItem.PM_SETDOWN_ADD_MAP_NO;
                    case 31: // PM_SETDOWN_ADD_MAP_X_REF
                        return CurrentItem.PM_SETDOWN_ADD_MAP_X_REF;
                    case 32: // PM_SETDOWN_ADD_DESCP
                        return CurrentItem.PM_SETDOWN_ADD_DESCP;
                    case 33: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 34: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 35: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRANSPORT_START_DATE
                        return CurrentItem.TRANSPORT_START_DATE == null;
                    case 3: // TRANSPORT_END_DATE
                        return CurrentItem.TRANSPORT_END_DATE == null;
                    case 4: // TRAVEL_IN_WHEELCHAIR
                        return CurrentItem.TRAVEL_IN_WHEELCHAIR == null;
                    case 5: // TRAVEL_DAY
                        return CurrentItem.TRAVEL_DAY == null;
                    case 6: // TRAVEL_NOTES
                        return CurrentItem.TRAVEL_NOTES == null;
                    case 7: // AM_ROUTE_ID
                        return CurrentItem.AM_ROUTE_ID == null;
                    case 8: // AM_TRANSPORT_MODE
                        return CurrentItem.AM_TRANSPORT_MODE == null;
                    case 9: // AM_ROUTE_EVERY_DAY
                        return CurrentItem.AM_ROUTE_EVERY_DAY == null;
                    case 10: // AM_PICKUP_TIME
                        return CurrentItem.AM_PICKUP_TIME == null;
                    case 11: // AM_PICKUP_ADDRESS_ID
                        return CurrentItem.AM_PICKUP_ADDRESS_ID == null;
                    case 12: // AM_PICKUP_ADD_SAME_AS_HOME
                        return CurrentItem.AM_PICKUP_ADD_SAME_AS_HOME == null;
                    case 13: // AM_PICKUP_DIRECTIONS
                        return CurrentItem.AM_PICKUP_DIRECTIONS == null;
                    case 14: // AM_PICKUP_ADD_MAP_TYPE
                        return CurrentItem.AM_PICKUP_ADD_MAP_TYPE == null;
                    case 15: // AM_PICKUP_ADD_MAP_NO
                        return CurrentItem.AM_PICKUP_ADD_MAP_NO == null;
                    case 16: // AM_PICKUP_ADD_MAP_X_REF
                        return CurrentItem.AM_PICKUP_ADD_MAP_X_REF == null;
                    case 17: // AM_PICKUP_ADD_DESCP
                        return CurrentItem.AM_PICKUP_ADD_DESCP == null;
                    case 18: // AM_SETDOWN_TIME
                        return CurrentItem.AM_SETDOWN_TIME == null;
                    case 19: // AM_SETDOWN_CAMPUS
                        return CurrentItem.AM_SETDOWN_CAMPUS == null;
                    case 20: // PM_ROUTE_ID
                        return CurrentItem.PM_ROUTE_ID == null;
                    case 21: // PM_TRANSPORT_MODE
                        return CurrentItem.PM_TRANSPORT_MODE == null;
                    case 22: // PM_ROUTE_EVERY_DAY
                        return CurrentItem.PM_ROUTE_EVERY_DAY == null;
                    case 23: // PM_PICKUP_TIME
                        return CurrentItem.PM_PICKUP_TIME == null;
                    case 24: // PM_PICKUP_CAMPUS
                        return CurrentItem.PM_PICKUP_CAMPUS == null;
                    case 25: // PM_SETDOWN_TIME
                        return CurrentItem.PM_SETDOWN_TIME == null;
                    case 26: // PM_SETDOWN_ADDRESS_ID
                        return CurrentItem.PM_SETDOWN_ADDRESS_ID == null;
                    case 27: // PM_STDWN_AM_PKUP_ADD_SAME
                        return CurrentItem.PM_STDWN_AM_PKUP_ADD_SAME == null;
                    case 28: // PM_SETDOWN_DIRECTIONS
                        return CurrentItem.PM_SETDOWN_DIRECTIONS == null;
                    case 29: // PM_SETDOWN_ADD_MAP_TYPE
                        return CurrentItem.PM_SETDOWN_ADD_MAP_TYPE == null;
                    case 30: // PM_SETDOWN_ADD_MAP_NO
                        return CurrentItem.PM_SETDOWN_ADD_MAP_NO == null;
                    case 31: // PM_SETDOWN_ADD_MAP_X_REF
                        return CurrentItem.PM_SETDOWN_ADD_MAP_X_REF == null;
                    case 32: // PM_SETDOWN_ADD_DESCP
                        return CurrentItem.PM_SETDOWN_ADD_DESCP == null;
                    case 33: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 34: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 35: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // STUDENT_ID
                        return "STUDENT_ID";
                    case 2: // TRANSPORT_START_DATE
                        return "TRANSPORT_START_DATE";
                    case 3: // TRANSPORT_END_DATE
                        return "TRANSPORT_END_DATE";
                    case 4: // TRAVEL_IN_WHEELCHAIR
                        return "TRAVEL_IN_WHEELCHAIR";
                    case 5: // TRAVEL_DAY
                        return "TRAVEL_DAY";
                    case 6: // TRAVEL_NOTES
                        return "TRAVEL_NOTES";
                    case 7: // AM_ROUTE_ID
                        return "AM_ROUTE_ID";
                    case 8: // AM_TRANSPORT_MODE
                        return "AM_TRANSPORT_MODE";
                    case 9: // AM_ROUTE_EVERY_DAY
                        return "AM_ROUTE_EVERY_DAY";
                    case 10: // AM_PICKUP_TIME
                        return "AM_PICKUP_TIME";
                    case 11: // AM_PICKUP_ADDRESS_ID
                        return "AM_PICKUP_ADDRESS_ID";
                    case 12: // AM_PICKUP_ADD_SAME_AS_HOME
                        return "AM_PICKUP_ADD_SAME_AS_HOME";
                    case 13: // AM_PICKUP_DIRECTIONS
                        return "AM_PICKUP_DIRECTIONS";
                    case 14: // AM_PICKUP_ADD_MAP_TYPE
                        return "AM_PICKUP_ADD_MAP_TYPE";
                    case 15: // AM_PICKUP_ADD_MAP_NO
                        return "AM_PICKUP_ADD_MAP_NO";
                    case 16: // AM_PICKUP_ADD_MAP_X_REF
                        return "AM_PICKUP_ADD_MAP_X_REF";
                    case 17: // AM_PICKUP_ADD_DESCP
                        return "AM_PICKUP_ADD_DESCP";
                    case 18: // AM_SETDOWN_TIME
                        return "AM_SETDOWN_TIME";
                    case 19: // AM_SETDOWN_CAMPUS
                        return "AM_SETDOWN_CAMPUS";
                    case 20: // PM_ROUTE_ID
                        return "PM_ROUTE_ID";
                    case 21: // PM_TRANSPORT_MODE
                        return "PM_TRANSPORT_MODE";
                    case 22: // PM_ROUTE_EVERY_DAY
                        return "PM_ROUTE_EVERY_DAY";
                    case 23: // PM_PICKUP_TIME
                        return "PM_PICKUP_TIME";
                    case 24: // PM_PICKUP_CAMPUS
                        return "PM_PICKUP_CAMPUS";
                    case 25: // PM_SETDOWN_TIME
                        return "PM_SETDOWN_TIME";
                    case 26: // PM_SETDOWN_ADDRESS_ID
                        return "PM_SETDOWN_ADDRESS_ID";
                    case 27: // PM_STDWN_AM_PKUP_ADD_SAME
                        return "PM_STDWN_AM_PKUP_ADD_SAME";
                    case 28: // PM_SETDOWN_DIRECTIONS
                        return "PM_SETDOWN_DIRECTIONS";
                    case 29: // PM_SETDOWN_ADD_MAP_TYPE
                        return "PM_SETDOWN_ADD_MAP_TYPE";
                    case 30: // PM_SETDOWN_ADD_MAP_NO
                        return "PM_SETDOWN_ADD_MAP_NO";
                    case 31: // PM_SETDOWN_ADD_MAP_X_REF
                        return "PM_SETDOWN_ADD_MAP_X_REF";
                    case 32: // PM_SETDOWN_ADD_DESCP
                        return "PM_SETDOWN_ADD_DESCP";
                    case 33: // LW_DATE
                        return "LW_DATE";
                    case 34: // LW_TIME
                        return "LW_TIME";
                    case 35: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "STUDENT_ID":
                        return 1;
                    case "TRANSPORT_START_DATE":
                        return 2;
                    case "TRANSPORT_END_DATE":
                        return 3;
                    case "TRAVEL_IN_WHEELCHAIR":
                        return 4;
                    case "TRAVEL_DAY":
                        return 5;
                    case "TRAVEL_NOTES":
                        return 6;
                    case "AM_ROUTE_ID":
                        return 7;
                    case "AM_TRANSPORT_MODE":
                        return 8;
                    case "AM_ROUTE_EVERY_DAY":
                        return 9;
                    case "AM_PICKUP_TIME":
                        return 10;
                    case "AM_PICKUP_ADDRESS_ID":
                        return 11;
                    case "AM_PICKUP_ADD_SAME_AS_HOME":
                        return 12;
                    case "AM_PICKUP_DIRECTIONS":
                        return 13;
                    case "AM_PICKUP_ADD_MAP_TYPE":
                        return 14;
                    case "AM_PICKUP_ADD_MAP_NO":
                        return 15;
                    case "AM_PICKUP_ADD_MAP_X_REF":
                        return 16;
                    case "AM_PICKUP_ADD_DESCP":
                        return 17;
                    case "AM_SETDOWN_TIME":
                        return 18;
                    case "AM_SETDOWN_CAMPUS":
                        return 19;
                    case "PM_ROUTE_ID":
                        return 20;
                    case "PM_TRANSPORT_MODE":
                        return 21;
                    case "PM_ROUTE_EVERY_DAY":
                        return 22;
                    case "PM_PICKUP_TIME":
                        return 23;
                    case "PM_PICKUP_CAMPUS":
                        return 24;
                    case "PM_SETDOWN_TIME":
                        return 25;
                    case "PM_SETDOWN_ADDRESS_ID":
                        return 26;
                    case "PM_STDWN_AM_PKUP_ADD_SAME":
                        return 27;
                    case "PM_SETDOWN_DIRECTIONS":
                        return 28;
                    case "PM_SETDOWN_ADD_MAP_TYPE":
                        return 29;
                    case "PM_SETDOWN_ADD_MAP_NO":
                        return 30;
                    case "PM_SETDOWN_ADD_MAP_X_REF":
                        return 31;
                    case "PM_SETDOWN_ADD_DESCP":
                        return 32;
                    case "LW_DATE":
                        return 33;
                    case "LW_TIME":
                        return 34;
                    case "LW_USER":
                        return 35;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
