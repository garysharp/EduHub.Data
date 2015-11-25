using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Attendees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TETNDataSet : SetBase<TETN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TETN"; } }

        internal TETNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TETNKEY = new Lazy<Dictionary<int, IReadOnlyList<TETN>>>(() => this.ToGroupedDictionary(i => i.TETNKEY));
            Index_TID = new Lazy<Dictionary<int, TETN>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETN" /> fields for each CSV column header</returns>
        protected override Action<TETN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TETN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TETNKEY":
                        mapper[i] = (e, v) => e.TETNKEY = int.Parse(v);
                        break;
                    case "TETELINK":
                        mapper[i] = (e, v) => e.TETELINK = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ATTENDEE":
                        mapper[i] = (e, v) => e.ATTENDEE = v;
                        break;
                    case "ATTENDEE_TYPE":
                        mapper[i] = (e, v) => e.ATTENDEE_TYPE = v;
                        break;
                    case "ATTENDEE_DETAIL":
                        mapper[i] = (e, v) => e.ATTENDEE_DETAIL = v;
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
        /// Merges <see cref="TETN" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TETN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TETN" /> items to added or update the base <see cref="TETN" /> items</param>
        /// <returns>A merged list of <see cref="TETN" /> items</returns>
        protected override List<TETN> ApplyDeltaItems(List<TETN> Items, List<TETN> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TETN deltaItem in DeltaItems)
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
                .OrderBy(i => i.TETNKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<TETN>>> Index_TETNKEY;
        private Lazy<Dictionary<int, TETN>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <returns>List of related TETN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> FindByTETNKEY(int TETNKEY)
        {
            return Index_TETNKEY.Value[TETNKEY];
        }

        /// <summary>
        /// Attempt to find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <param name="Value">List of related TETN entities</param>
        /// <returns>True if the list of related TETN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTETNKEY(int TETNKEY, out IReadOnlyList<TETN> Value)
        {
            return Index_TETNKEY.Value.TryGetValue(TETNKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <returns>List of related TETN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> TryFindByTETNKEY(int TETNKEY)
        {
            IReadOnlyList<TETN> value;
            if (Index_TETNKEY.Value.TryGetValue(TETNKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <returns>Related TETN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETN FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <param name="Value">Related TETN entity</param>
        /// <returns>True if the related TETN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TETN Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <returns>Related TETN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETN TryFindByTID(int TID)
        {
            TETN value;
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
