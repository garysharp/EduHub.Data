using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Trips Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STTRIPSDataSet : SetBase<STTRIPS>
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

    }
}
