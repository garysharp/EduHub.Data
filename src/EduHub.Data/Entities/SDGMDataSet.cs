using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDGMDataSet : SetBase<SDGM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDGM"; } }

        internal SDGMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PERSON_LINK = new Lazy<NullDictionary<string, IReadOnlyList<SDGM>>>(() => this.ToGroupedNullDictionary(i => i.PERSON_LINK));
            Index_SDGMKEY = new Lazy<Dictionary<string, IReadOnlyList<SDGM>>>(() => this.ToGroupedDictionary(i => i.SDGMKEY));
            Index_TID = new Lazy<Dictionary<int, SDGM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDGM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDGM" /> fields for each CSV column header</returns>
        protected override Action<SDGM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDGM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SDGMKEY":
                        mapper[i] = (e, v) => e.SDGMKEY = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OTHER_COMMENTS":
                        mapper[i] = (e, v) => e.OTHER_COMMENTS = v;
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
        /// Merges <see cref="SDGM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDGM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDGM" /> items to added or update the base <see cref="SDGM" /> items</param>
        /// <returns>A merged list of <see cref="SDGM" /> items</returns>
        protected override List<SDGM> ApplyDeltaItems(List<SDGM> Items, List<SDGM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDGM deltaItem in DeltaItems)
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
                .OrderBy(i => i.SDGMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SDGM>>> Index_PERSON_LINK;
        private Lazy<Dictionary<string, IReadOnlyList<SDGM>>> Index_SDGMKEY;
        private Lazy<Dictionary<int, SDGM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <returns>List of related SDGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> FindByPERSON_LINK(string PERSON_LINK)
        {
            return Index_PERSON_LINK.Value[PERSON_LINK];
        }

        /// <summary>
        /// Attempt to find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <param name="Value">List of related SDGM entities</param>
        /// <returns>True if the list of related SDGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPERSON_LINK(string PERSON_LINK, out IReadOnlyList<SDGM> Value)
        {
            return Index_PERSON_LINK.Value.TryGetValue(PERSON_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <returns>List of related SDGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> TryFindByPERSON_LINK(string PERSON_LINK)
        {
            IReadOnlyList<SDGM> value;
            if (Index_PERSON_LINK.Value.TryGetValue(PERSON_LINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <returns>List of related SDGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> FindBySDGMKEY(string SDGMKEY)
        {
            return Index_SDGMKEY.Value[SDGMKEY];
        }

        /// <summary>
        /// Attempt to find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <param name="Value">List of related SDGM entities</param>
        /// <returns>True if the list of related SDGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDGMKEY(string SDGMKEY, out IReadOnlyList<SDGM> Value)
        {
            return Index_SDGMKEY.Value.TryGetValue(SDGMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <returns>List of related SDGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> TryFindBySDGMKEY(string SDGMKEY)
        {
            IReadOnlyList<SDGM> value;
            if (Index_SDGMKEY.Value.TryGetValue(SDGMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <returns>Related SDGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDGM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <param name="Value">Related SDGM entity</param>
        /// <returns>True if the related SDGM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SDGM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <returns>Related SDGM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDGM TryFindByTID(int TID)
        {
            SDGM value;
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
