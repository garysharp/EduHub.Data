using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability in Quilt Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFAQDataSet : SetBase<SFAQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SFAQ"; } }

        internal SFAQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<SFAQ>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
            Index_SFAQKEY = new Lazy<Dictionary<string, IReadOnlyList<SFAQ>>>(() => this.ToGroupedDictionary(i => i.SFAQKEY));
            Index_TID = new Lazy<Dictionary<int, SFAQ>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFAQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFAQ" /> fields for each CSV column header</returns>
        protected override Action<SFAQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFAQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SFAQKEY":
                        mapper[i] = (e, v) => e.SFAQKEY = v;
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SFAQ" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SFAQ" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SFAQ" /> items to added or update the base <see cref="SFAQ" /> items</param>
        /// <returns>A merged list of <see cref="SFAQ" /> items</returns>
        protected override List<SFAQ> ApplyDeltaItems(List<SFAQ> Items, List<SFAQ> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SFAQ deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SFAQKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SFAQ>>> Index_QKEY;
        private Lazy<Dictionary<string, IReadOnlyList<SFAQ>>> Index_SFAQKEY;
        private Lazy<Dictionary<int, SFAQ>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <param name="Value">List of related SFAQ entities</param>
        /// <returns>True if the list of related SFAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<SFAQ> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<SFAQ> value;
            if (Index_QKEY.Value.TryGetValue(QKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> FindBySFAQKEY(string SFAQKEY)
        {
            return Index_SFAQKEY.Value[SFAQKEY];
        }

        /// <summary>
        /// Attempt to find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <param name="Value">List of related SFAQ entities</param>
        /// <returns>True if the list of related SFAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFAQKEY(string SFAQKEY, out IReadOnlyList<SFAQ> Value)
        {
            return Index_SFAQKEY.Value.TryGetValue(SFAQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> TryFindBySFAQKEY(string SFAQKEY)
        {
            IReadOnlyList<SFAQ> value;
            if (Index_SFAQKEY.Value.TryGetValue(SFAQKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <returns>Related SFAQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAQ FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <param name="Value">Related SFAQ entity</param>
        /// <returns>True if the related SFAQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFAQ Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <returns>Related SFAQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAQ TryFindByTID(int TID)
        {
            SFAQ value;
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
