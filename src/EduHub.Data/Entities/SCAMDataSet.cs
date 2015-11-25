using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Meetings Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCAMDataSet : SetBase<SCAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCAM"; } }

        internal SCAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_MEETING_LOCATION = new Lazy<NullDictionary<int?, IReadOnlyList<SCAM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_LOCATION));
            Index_MEETING_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SCAM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_ROOM));
            Index_SCAMKEY = new Lazy<Dictionary<string, IReadOnlyList<SCAM>>>(() => this.ToGroupedDictionary(i => i.SCAMKEY));
            Index_SCAMKEY_MEETING_DATE_MEETING_TIME = new Lazy<Dictionary<Tuple<string, DateTime?, short?>, SCAM>>(() => this.ToDictionary(i => Tuple.Create(i.SCAMKEY, i.MEETING_DATE, i.MEETING_TIME)));
            Index_TID = new Lazy<Dictionary<int, SCAM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCAM" /> fields for each CSV column header</returns>
        protected override Action<SCAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
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

        /// <summary>
        /// Merges <see cref="SCAM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCAM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCAM" /> items to added or update the base <see cref="SCAM" /> items</param>
        /// <returns>A merged list of <see cref="SCAM" /> items</returns>
        protected override List<SCAM> ApplyDeltaItems(List<SCAM> Items, List<SCAM> DeltaItems)
        {
            Dictionary<Tuple<string, DateTime?, short?>, int> Index_SCAMKEY_MEETING_DATE_MEETING_TIME = Items.ToIndexDictionary(i => Tuple.Create(i.SCAMKEY, i.MEETING_DATE, i.MEETING_TIME));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCAM deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCAMKEY_MEETING_DATE_MEETING_TIME.TryGetValue(Tuple.Create(deltaItem.SCAMKEY, deltaItem.MEETING_DATE, deltaItem.MEETING_TIME), out index))
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
                .OrderBy(i => i.SCAMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SCAM>>> Index_MEETING_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<SCAM>>> Index_MEETING_ROOM;
        private Lazy<Dictionary<string, IReadOnlyList<SCAM>>> Index_SCAMKEY;
        private Lazy<Dictionary<Tuple<string, DateTime?, short?>, SCAM>> Index_SCAMKEY_MEETING_DATE_MEETING_TIME;
        private Lazy<Dictionary<int, SCAM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindByMEETING_LOCATION(int? MEETING_LOCATION)
        {
            return Index_MEETING_LOCATION.Value[MEETING_LOCATION];
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_LOCATION(int? MEETING_LOCATION, out IReadOnlyList<SCAM> Value)
        {
            return Index_MEETING_LOCATION.Value.TryGetValue(MEETING_LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindByMEETING_LOCATION(int? MEETING_LOCATION)
        {
            IReadOnlyList<SCAM> value;
            if (Index_MEETING_LOCATION.Value.TryGetValue(MEETING_LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindByMEETING_ROOM(string MEETING_ROOM)
        {
            return Index_MEETING_ROOM.Value[MEETING_ROOM];
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_ROOM(string MEETING_ROOM, out IReadOnlyList<SCAM> Value)
        {
            return Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindByMEETING_ROOM(string MEETING_ROOM)
        {
            IReadOnlyList<SCAM> value;
            if (Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindBySCAMKEY(string SCAMKEY)
        {
            return Index_SCAMKEY.Value[SCAMKEY];
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAMKEY(string SCAMKEY, out IReadOnlyList<SCAM> Value)
        {
            return Index_SCAMKEY.Value.TryGetValue(SCAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindBySCAMKEY(string SCAMKEY)
        {
            IReadOnlyList<SCAM> value;
            if (Index_SCAMKEY.Value.TryGetValue(SCAMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <returns>Related SCAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM FindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            return Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value[Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME)];
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <param name="Value">Related SCAM entity</param>
        /// <returns>True if the related SCAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME, out SCAM Value)
        {
            return Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME), out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <returns>Related SCAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM TryFindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            SCAM value;
            if (Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <returns>Related SCAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <param name="Value">Related SCAM entity</param>
        /// <returns>True if the related SCAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SCAM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <returns>Related SCAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM TryFindByTID(int TID)
        {
            SCAM value;
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
