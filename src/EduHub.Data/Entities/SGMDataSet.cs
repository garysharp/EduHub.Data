using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Special Group Meetings Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGMDataSet : SetBase<SGM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGM"; } }

        internal SGMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_MEETING_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SGM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_DATE));
            Index_MEETING_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SGM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_ROOM));
            Index_SGMKEY = new Lazy<Dictionary<string, IReadOnlyList<SGM>>>(() => this.ToGroupedDictionary(i => i.SGMKEY));
            Index_SGMKEY_MEETING_DATE_MEETING_TIME = new Lazy<Dictionary<Tuple<string, DateTime?, short?>, SGM>>(() => this.ToDictionary(i => Tuple.Create(i.SGMKEY, i.MEETING_DATE, i.MEETING_TIME)));
            Index_TID = new Lazy<Dictionary<int, SGM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGM" /> fields for each CSV column header</returns>
        protected override Action<SGM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGMKEY":
                        mapper[i] = (e, v) => e.SGMKEY = v;
                        break;
                    case "MEETING_DATE":
                        mapper[i] = (e, v) => e.MEETING_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MEETING_TIME":
                        mapper[i] = (e, v) => e.MEETING_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PURPOSE_BRIEF":
                        mapper[i] = (e, v) => e.PURPOSE_BRIEF = v;
                        break;
                    case "PURPOSE_DETAIL":
                        mapper[i] = (e, v) => e.PURPOSE_DETAIL = v;
                        break;
                    case "MEETING_ROOM":
                        mapper[i] = (e, v) => e.MEETING_ROOM = v;
                        break;
                    case "MINUTES_MEMO":
                        mapper[i] = (e, v) => e.MINUTES_MEMO = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SGM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGM" /> items to added or update the base <see cref="SGM" /> items</param>
        /// <returns>A merged list of <see cref="SGM" /> items</returns>
        protected override List<SGM> ApplyDeltaItems(List<SGM> Items, List<SGM> DeltaItems)
        {
            Dictionary<Tuple<string, DateTime?, short?>, int> Index_SGMKEY_MEETING_DATE_MEETING_TIME = Items.ToIndexDictionary(i => Tuple.Create(i.SGMKEY, i.MEETING_DATE, i.MEETING_TIME));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGM deltaItem in DeltaItems)
            {
                int index;

                if (Index_SGMKEY_MEETING_DATE_MEETING_TIME.TryGetValue(Tuple.Create(deltaItem.SGMKEY, deltaItem.MEETING_DATE, deltaItem.MEETING_TIME), out index))
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
                .OrderBy(i => i.SGMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SGM>>> Index_MEETING_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SGM>>> Index_MEETING_ROOM;
        private Lazy<Dictionary<string, IReadOnlyList<SGM>>> Index_SGMKEY;
        private Lazy<Dictionary<Tuple<string, DateTime?, short?>, SGM>> Index_SGMKEY_MEETING_DATE_MEETING_TIME;
        private Lazy<Dictionary<int, SGM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGM by MEETING_DATE field
        /// </summary>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <returns>List of related SGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> FindByMEETING_DATE(DateTime? MEETING_DATE)
        {
            return Index_MEETING_DATE.Value[MEETING_DATE];
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_DATE field
        /// </summary>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="Value">List of related SGM entities</param>
        /// <returns>True if the list of related SGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_DATE(DateTime? MEETING_DATE, out IReadOnlyList<SGM> Value)
        {
            return Index_MEETING_DATE.Value.TryGetValue(MEETING_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_DATE field
        /// </summary>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <returns>List of related SGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> TryFindByMEETING_DATE(DateTime? MEETING_DATE)
        {
            IReadOnlyList<SGM> value;
            if (Index_MEETING_DATE.Value.TryGetValue(MEETING_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SGM</param>
        /// <returns>List of related SGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> FindByMEETING_ROOM(string MEETING_ROOM)
        {
            return Index_MEETING_ROOM.Value[MEETING_ROOM];
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SGM</param>
        /// <param name="Value">List of related SGM entities</param>
        /// <returns>True if the list of related SGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_ROOM(string MEETING_ROOM, out IReadOnlyList<SGM> Value)
        {
            return Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SGM</param>
        /// <returns>List of related SGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> TryFindByMEETING_ROOM(string MEETING_ROOM)
        {
            IReadOnlyList<SGM> value;
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
        /// Find SGM by SGMKEY field
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <returns>List of related SGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> FindBySGMKEY(string SGMKEY)
        {
            return Index_SGMKEY.Value[SGMKEY];
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY field
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="Value">List of related SGM entities</param>
        /// <returns>True if the list of related SGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMKEY(string SGMKEY, out IReadOnlyList<SGM> Value)
        {
            return Index_SGMKEY.Value.TryGetValue(SGMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY field
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <returns>List of related SGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> TryFindBySGMKEY(string SGMKEY)
        {
            IReadOnlyList<SGM> value;
            if (Index_SGMKEY.Value.TryGetValue(SGMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGM by SGMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SGM</param>
        /// <returns>Related SGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM FindBySGMKEY_MEETING_DATE_MEETING_TIME(string SGMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            return Index_SGMKEY_MEETING_DATE_MEETING_TIME.Value[Tuple.Create(SGMKEY, MEETING_DATE, MEETING_TIME)];
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SGM</param>
        /// <param name="Value">Related SGM entity</param>
        /// <returns>True if the related SGM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMKEY_MEETING_DATE_MEETING_TIME(string SGMKEY, DateTime? MEETING_DATE, short? MEETING_TIME, out SGM Value)
        {
            return Index_SGMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SGMKEY, MEETING_DATE, MEETING_TIME), out Value);
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SGM</param>
        /// <returns>Related SGM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM TryFindBySGMKEY_MEETING_DATE_MEETING_TIME(string SGMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            SGM value;
            if (Index_SGMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SGMKEY, MEETING_DATE, MEETING_TIME), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGM</param>
        /// <returns>Related SGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGM</param>
        /// <param name="Value">Related SGM entity</param>
        /// <returns>True if the related SGM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGM</param>
        /// <returns>Related SGM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM TryFindByTID(int TID)
        {
            SGM value;
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
