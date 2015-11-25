using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Grid Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTTGDataSet : SetBase<TTTG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTTG"; } }

        internal TTTGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_IDENT = new Lazy<NullDictionary<int?, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.IDENT));
            Index_R1ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.R1ROOM));
            Index_R2ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.R2ROOM));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_T1TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.T1TEACH));
            Index_T2TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.T2TEACH));
            Index_TID = new Lazy<Dictionary<int, TTTG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTTG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTTG" /> fields for each CSV column header</returns>
        protected override Action<TTTG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTTG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FIRST_CLASS":
                        mapper[i] = (e, v) => e.FIRST_CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NSET":
                        mapper[i] = (e, v) => e.NSET = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SIZE":
                        mapper[i] = (e, v) => e.CLASS_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXIMUM":
                        mapper[i] = (e, v) => e.MAXIMUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MINIMUM":
                        mapper[i] = (e, v) => e.MINIMUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MINLINE":
                        mapper[i] = (e, v) => e.MINLINE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXLINE":
                        mapper[i] = (e, v) => e.MAXLINE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MCOLOUR":
                        mapper[i] = (e, v) => e.MCOLOUR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOLOUR":
                        mapper[i] = (e, v) => e.GCOLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS":
                        mapper[i] = (e, v) => e.UNITS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "T1TEACH":
                        mapper[i] = (e, v) => e.T1TEACH = v;
                        break;
                    case "T2TEACH":
                        mapper[i] = (e, v) => e.T2TEACH = v;
                        break;
                    case "R1ROOM":
                        mapper[i] = (e, v) => e.R1ROOM = v;
                        break;
                    case "R2ROOM":
                        mapper[i] = (e, v) => e.R2ROOM = v;
                        break;
                    case "RESOURCES01":
                        mapper[i] = (e, v) => e.RESOURCES01 = v;
                        break;
                    case "RESOURCES02":
                        mapper[i] = (e, v) => e.RESOURCES02 = v;
                        break;
                    case "RESOURCES03":
                        mapper[i] = (e, v) => e.RESOURCES03 = v;
                        break;
                    case "RESOURCES04":
                        mapper[i] = (e, v) => e.RESOURCES04 = v;
                        break;
                    case "RESOURCES05":
                        mapper[i] = (e, v) => e.RESOURCES05 = v;
                        break;
                    case "RESOURCES06":
                        mapper[i] = (e, v) => e.RESOURCES06 = v;
                        break;
                    case "RESOURCES07":
                        mapper[i] = (e, v) => e.RESOURCES07 = v;
                        break;
                    case "RESOURCES08":
                        mapper[i] = (e, v) => e.RESOURCES08 = v;
                        break;
                    case "RESOURCES09":
                        mapper[i] = (e, v) => e.RESOURCES09 = v;
                        break;
                    case "LAB":
                        mapper[i] = (e, v) => e.LAB = v;
                        break;
                    case "FROW":
                        mapper[i] = (e, v) => e.FROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FCOL":
                        mapper[i] = (e, v) => e.FCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HROW":
                        mapper[i] = (e, v) => e.HROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HCOL":
                        mapper[i] = (e, v) => e.HCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BLOCK":
                        mapper[i] = (e, v) => e.BLOCK = v;
                        break;
                    case "LOCK":
                        mapper[i] = (e, v) => e.LOCK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TCHAIN":
                        mapper[i] = (e, v) => e.TCHAIN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LCHAIN":
                        mapper[i] = (e, v) => e.LCHAIN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIED_COL":
                        mapper[i] = (e, v) => e.TIED_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LINK_COL":
                        mapper[i] = (e, v) => e.LINK_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_ROW_CLASSES":
                        mapper[i] = (e, v) => e.MAX_ROW_CLASSES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROW_GROUP":
                        mapper[i] = (e, v) => e.ROW_GROUP = v;
                        break;
                    case "DOUBLE_PERIODS":
                        mapper[i] = (e, v) => e.DOUBLE_PERIODS = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="TTTG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TTTG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TTTG" /> items to added or update the base <see cref="TTTG" /> items</param>
        /// <returns>A merged list of <see cref="TTTG" /> items</returns>
        protected override List<TTTG> ApplyDeltaItems(List<TTTG> Items, List<TTTG> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TTTG deltaItem in DeltaItems)
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
                .OrderBy(i => i.GKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> Index_GKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<TTTG>>> Index_IDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_R1ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_R2ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_SUBJ;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_T1TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_T2TEACH;
        private Lazy<Dictionary<int, TTTG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTTG by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTTG by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTTG> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTTG> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTTG by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByIDENT(int? IDENT)
        {
            return Index_IDENT.Value[IDENT];
        }

        /// <summary>
        /// Attempt to find TTTG by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByIDENT(int? IDENT, out IReadOnlyList<TTTG> Value)
        {
            return Index_IDENT.Value.TryGetValue(IDENT, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByIDENT(int? IDENT)
        {
            IReadOnlyList<TTTG> value;
            if (Index_IDENT.Value.TryGetValue(IDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTTG by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByR1ROOM(string R1ROOM)
        {
            return Index_R1ROOM.Value[R1ROOM];
        }

        /// <summary>
        /// Attempt to find TTTG by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR1ROOM(string R1ROOM, out IReadOnlyList<TTTG> Value)
        {
            return Index_R1ROOM.Value.TryGetValue(R1ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByR1ROOM(string R1ROOM)
        {
            IReadOnlyList<TTTG> value;
            if (Index_R1ROOM.Value.TryGetValue(R1ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTTG by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByR2ROOM(string R2ROOM)
        {
            return Index_R2ROOM.Value[R2ROOM];
        }

        /// <summary>
        /// Attempt to find TTTG by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR2ROOM(string R2ROOM, out IReadOnlyList<TTTG> Value)
        {
            return Index_R2ROOM.Value.TryGetValue(R2ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByR2ROOM(string R2ROOM)
        {
            IReadOnlyList<TTTG> value;
            if (Index_R2ROOM.Value.TryGetValue(R2ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTTG by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TTTG by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TTTG> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TTTG> value;
            if (Index_SUBJ.Value.TryGetValue(SUBJ, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTTG by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByT1TEACH(string T1TEACH)
        {
            return Index_T1TEACH.Value[T1TEACH];
        }

        /// <summary>
        /// Attempt to find TTTG by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT1TEACH(string T1TEACH, out IReadOnlyList<TTTG> Value)
        {
            return Index_T1TEACH.Value.TryGetValue(T1TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByT1TEACH(string T1TEACH)
        {
            IReadOnlyList<TTTG> value;
            if (Index_T1TEACH.Value.TryGetValue(T1TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTTG by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByT2TEACH(string T2TEACH)
        {
            return Index_T2TEACH.Value[T2TEACH];
        }

        /// <summary>
        /// Attempt to find TTTG by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT2TEACH(string T2TEACH, out IReadOnlyList<TTTG> Value)
        {
            return Index_T2TEACH.Value.TryGetValue(T2TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByT2TEACH(string T2TEACH)
        {
            IReadOnlyList<TTTG> value;
            if (Index_T2TEACH.Value.TryGetValue(T2TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTTG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTTG</param>
        /// <returns>Related TTTG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTTG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTTG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTTG</param>
        /// <param name="Value">Related TTTG entity</param>
        /// <returns>True if the related TTTG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTTG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTTG</param>
        /// <returns>Related TTTG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTTG TryFindByTID(int TID)
        {
            TTTG value;
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
