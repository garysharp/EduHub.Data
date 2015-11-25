using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medication Doses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMCDDataSet : SetBase<SMCD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMCD"; } }

        internal SMCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SMCDKEY = new Lazy<Dictionary<int, IReadOnlyList<SMCD>>>(() => this.ToGroupedDictionary(i => i.SMCDKEY));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<SMCD>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, SMCD>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMCD" /> fields for each CSV column header</returns>
        protected override Action<SMCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMCD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SMCDKEY":
                        mapper[i] = (e, v) => e.SMCDKEY = int.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ADMIN_DATE":
                        mapper[i] = (e, v) => e.ADMIN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ADMIN_TIME":
                        mapper[i] = (e, v) => e.ADMIN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DOSE":
                        mapper[i] = (e, v) => e.DOSE = v;
                        break;
                    case "ADMIN_BY_OTHER":
                        mapper[i] = (e, v) => e.ADMIN_BY_OTHER = v;
                        break;
                    case "ADMIN_NOTES":
                        mapper[i] = (e, v) => e.ADMIN_NOTES = v;
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
        /// Merges <see cref="SMCD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SMCD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SMCD" /> items to added or update the base <see cref="SMCD" /> items</param>
        /// <returns>A merged list of <see cref="SMCD" /> items</returns>
        protected override List<SMCD> ApplyDeltaItems(List<SMCD> Items, List<SMCD> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SMCD deltaItem in DeltaItems)
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
                .OrderBy(i => i.SMCDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SMCD>>> Index_SMCDKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SMCD>>> Index_STAFF;
        private Lazy<Dictionary<int, SMCD>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMCD by SMCDKEY field
        /// </summary>
        /// <param name="SMCDKEY">SMCDKEY value used to find SMCD</param>
        /// <returns>List of related SMCD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> FindBySMCDKEY(int SMCDKEY)
        {
            return Index_SMCDKEY.Value[SMCDKEY];
        }

        /// <summary>
        /// Attempt to find SMCD by SMCDKEY field
        /// </summary>
        /// <param name="SMCDKEY">SMCDKEY value used to find SMCD</param>
        /// <param name="Value">List of related SMCD entities</param>
        /// <returns>True if the list of related SMCD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMCDKEY(int SMCDKEY, out IReadOnlyList<SMCD> Value)
        {
            return Index_SMCDKEY.Value.TryGetValue(SMCDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMCD by SMCDKEY field
        /// </summary>
        /// <param name="SMCDKEY">SMCDKEY value used to find SMCD</param>
        /// <returns>List of related SMCD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> TryFindBySMCDKEY(int SMCDKEY)
        {
            IReadOnlyList<SMCD> value;
            if (Index_SMCDKEY.Value.TryGetValue(SMCDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMCD by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SMCD</param>
        /// <returns>List of related SMCD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find SMCD by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SMCD</param>
        /// <param name="Value">List of related SMCD entities</param>
        /// <returns>True if the list of related SMCD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<SMCD> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find SMCD by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SMCD</param>
        /// <returns>List of related SMCD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<SMCD> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMCD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMCD</param>
        /// <returns>Related SMCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMCD FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMCD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMCD</param>
        /// <param name="Value">Related SMCD entity</param>
        /// <returns>True if the related SMCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMCD Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMCD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMCD</param>
        /// <returns>Related SMCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMCD TryFindByTID(int TID)
        {
            SMCD value;
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
