using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGHGDataSet : SetBase<SGHG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGHG"; } }

        internal SGHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGCLINK = new Lazy<NullDictionary<string, IReadOnlyList<SGHG>>>(() => this.ToGroupedNullDictionary(i => i.KGCLINK));
            Index_SGHGKEY = new Lazy<Dictionary<string, IReadOnlyList<SGHG>>>(() => this.ToGroupedDictionary(i => i.SGHGKEY));
            Index_TID = new Lazy<Dictionary<int, SGHG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGHG" /> fields for each CSV column header</returns>
        protected override Action<SGHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGHGKEY":
                        mapper[i] = (e, v) => e.SGHGKEY = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
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
        /// Merges <see cref="SGHG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGHG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGHG" /> items to added or update the base <see cref="SGHG" /> items</param>
        /// <returns>A merged list of <see cref="SGHG" /> items</returns>
        protected override List<SGHG> ApplyDeltaItems(List<SGHG> Items, List<SGHG> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGHG deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGHGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SGHG>>> Index_KGCLINK;
        private Lazy<Dictionary<string, IReadOnlyList<SGHG>>> Index_SGHGKEY;
        private Lazy<Dictionary<int, SGHG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <returns>List of related SGHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> FindByKGCLINK(string KGCLINK)
        {
            return Index_KGCLINK.Value[KGCLINK];
        }

        /// <summary>
        /// Attempt to find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <param name="Value">List of related SGHG entities</param>
        /// <returns>True if the list of related SGHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCLINK(string KGCLINK, out IReadOnlyList<SGHG> Value)
        {
            return Index_KGCLINK.Value.TryGetValue(KGCLINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <returns>List of related SGHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> TryFindByKGCLINK(string KGCLINK)
        {
            IReadOnlyList<SGHG> value;
            if (Index_KGCLINK.Value.TryGetValue(KGCLINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <returns>List of related SGHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> FindBySGHGKEY(string SGHGKEY)
        {
            return Index_SGHGKEY.Value[SGHGKEY];
        }

        /// <summary>
        /// Attempt to find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <param name="Value">List of related SGHG entities</param>
        /// <returns>True if the list of related SGHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGHGKEY(string SGHGKEY, out IReadOnlyList<SGHG> Value)
        {
            return Index_SGHGKEY.Value.TryGetValue(SGHGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <returns>List of related SGHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> TryFindBySGHGKEY(string SGHGKEY)
        {
            IReadOnlyList<SGHG> value;
            if (Index_SGHGKEY.Value.TryGetValue(SGHGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <returns>Related SGHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGHG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <param name="Value">Related SGHG entity</param>
        /// <returns>True if the related SGHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGHG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <returns>Related SGHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGHG TryFindByTID(int TID)
        {
            SGHG value;
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
