using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Book List Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUBLDataSet : SetBase<SUBL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SUBL"; } }

        internal SUBLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BLKEY = new Lazy<Dictionary<string, IReadOnlyList<SUBL>>>(() => this.ToGroupedDictionary(i => i.BLKEY));
            Index_BOOK = new Lazy<NullDictionary<string, IReadOnlyList<SUBL>>>(() => this.ToGroupedNullDictionary(i => i.BOOK));
            Index_TID = new Lazy<Dictionary<int, SUBL>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SUBL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SUBL" /> fields for each CSV column header</returns>
        protected override Action<SUBL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SUBL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BLKEY":
                        mapper[i] = (e, v) => e.BLKEY = v;
                        break;
                    case "BOOK":
                        mapper[i] = (e, v) => e.BOOK = v;
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "TAG":
                        mapper[i] = (e, v) => e.TAG = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_REQUIRED":
                        mapper[i] = (e, v) => e.NUMBER_REQUIRED = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SUBL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SUBL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SUBL" /> items to added or update the base <see cref="SUBL" /> items</param>
        /// <returns>A merged list of <see cref="SUBL" /> items</returns>
        protected override List<SUBL> ApplyDeltaItems(List<SUBL> Items, List<SUBL> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SUBL deltaItem in DeltaItems)
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
                .OrderBy(i => i.BLKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SUBL>>> Index_BLKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SUBL>>> Index_BOOK;
        private Lazy<Dictionary<int, SUBL>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <returns>List of related SUBL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> FindByBLKEY(string BLKEY)
        {
            return Index_BLKEY.Value[BLKEY];
        }

        /// <summary>
        /// Attempt to find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <param name="Value">List of related SUBL entities</param>
        /// <returns>True if the list of related SUBL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBLKEY(string BLKEY, out IReadOnlyList<SUBL> Value)
        {
            return Index_BLKEY.Value.TryGetValue(BLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <returns>List of related SUBL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> TryFindByBLKEY(string BLKEY)
        {
            IReadOnlyList<SUBL> value;
            if (Index_BLKEY.Value.TryGetValue(BLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <returns>List of related SUBL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> FindByBOOK(string BOOK)
        {
            return Index_BOOK.Value[BOOK];
        }

        /// <summary>
        /// Attempt to find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <param name="Value">List of related SUBL entities</param>
        /// <returns>True if the list of related SUBL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBOOK(string BOOK, out IReadOnlyList<SUBL> Value)
        {
            return Index_BOOK.Value.TryGetValue(BOOK, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <returns>List of related SUBL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> TryFindByBOOK(string BOOK)
        {
            IReadOnlyList<SUBL> value;
            if (Index_BOOK.Value.TryGetValue(BOOK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <returns>Related SUBL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUBL FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <param name="Value">Related SUBL entity</param>
        /// <returns>True if the related SUBL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SUBL Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <returns>Related SUBL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUBL TryFindByTID(int TID)
        {
            SUBL value;
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
