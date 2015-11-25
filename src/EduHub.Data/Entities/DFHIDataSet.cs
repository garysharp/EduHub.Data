using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFHIDataSet : SetBase<DFHI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFHI"; } }

        internal DFHIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FKEY = new Lazy<Dictionary<string, IReadOnlyList<DFHI>>>(() => this.ToGroupedDictionary(i => i.FKEY));
            Index_TID = new Lazy<Dictionary<int, DFHI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFHI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFHI" /> fields for each CSV column header</returns>
        protected override Action<DFHI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FKEY":
                        mapper[i] = (e, v) => e.FKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HKEY":
                        mapper[i] = (e, v) => e.HKEY = v;
                        break;
                    case "NAME_A":
                        mapper[i] = (e, v) => e.NAME_A = v;
                        break;
                    case "SURNAME_A":
                        mapper[i] = (e, v) => e.SURNAME_A = v;
                        break;
                    case "TITLE_A":
                        mapper[i] = (e, v) => e.TITLE_A = v;
                        break;
                    case "GENDER_A":
                        mapper[i] = (e, v) => e.GENDER_A = v;
                        break;
                    case "NAME_B":
                        mapper[i] = (e, v) => e.NAME_B = v;
                        break;
                    case "SURNAME_B":
                        mapper[i] = (e, v) => e.SURNAME_B = v;
                        break;
                    case "TITLE_B":
                        mapper[i] = (e, v) => e.TITLE_B = v;
                        break;
                    case "GENDER_B":
                        mapper[i] = (e, v) => e.GENDER_B = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="DFHI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DFHI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DFHI" /> items to added or update the base <see cref="DFHI" /> items</param>
        /// <returns>A merged list of <see cref="DFHI" /> items</returns>
        protected override List<DFHI> ApplyDeltaItems(List<DFHI> Items, List<DFHI> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DFHI deltaItem in DeltaItems)
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
                .OrderBy(i => i.FKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DFHI>>> Index_FKEY;
        private Lazy<Dictionary<int, DFHI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <returns>List of related DFHI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFHI> FindByFKEY(string FKEY)
        {
            return Index_FKEY.Value[FKEY];
        }

        /// <summary>
        /// Attempt to find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <param name="Value">List of related DFHI entities</param>
        /// <returns>True if the list of related DFHI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFKEY(string FKEY, out IReadOnlyList<DFHI> Value)
        {
            return Index_FKEY.Value.TryGetValue(FKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <returns>List of related DFHI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFHI> TryFindByFKEY(string FKEY)
        {
            IReadOnlyList<DFHI> value;
            if (Index_FKEY.Value.TryGetValue(FKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <returns>Related DFHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFHI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <param name="Value">Related DFHI entity</param>
        /// <returns>True if the related DFHI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFHI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <returns>Related DFHI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFHI TryFindByTID(int TID)
        {
            DFHI value;
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
