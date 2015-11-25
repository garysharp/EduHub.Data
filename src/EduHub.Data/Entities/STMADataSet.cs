using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Selections &amp; Marks Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STMADataSet : SetBase<STMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STMA"; } }

        internal STMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CKEY = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.CKEY));
            Index_IDENT = new Lazy<NullDictionary<int?, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.IDENT));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_MKEY = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.MKEY));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STMA>>(() => this.ToDictionary(i => i.TID));
            Index_TTPERIOD = new Lazy<NullDictionary<string, IReadOnlyList<STMA>>>(() => this.ToGroupedNullDictionary(i => i.TTPERIOD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STMA" /> fields for each CSV column header</returns>
        protected override Action<STMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "MKEY":
                        mapper[i] = (e, v) => e.MKEY = v;
                        break;
                    case "CKEY":
                        mapper[i] = (e, v) => e.CKEY = v;
                        break;
                    case "PRIORITY":
                        mapper[i] = (e, v) => e.PRIORITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FULLNAME":
                        mapper[i] = (e, v) => e.FULLNAME = v;
                        break;
                    case "TEACHER_NAME":
                        mapper[i] = (e, v) => e.TEACHER_NAME = v;
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LOCK":
                        mapper[i] = (e, v) => e.LOCK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRPERIOD":
                        mapper[i] = (e, v) => e.TRPERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "CYEAR":
                        mapper[i] = (e, v) => e.CYEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DROPOUT":
                        mapper[i] = (e, v) => e.DROPOUT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GRADE01":
                        mapper[i] = (e, v) => e.GRADE01 = v;
                        break;
                    case "GRADE02":
                        mapper[i] = (e, v) => e.GRADE02 = v;
                        break;
                    case "GRADE03":
                        mapper[i] = (e, v) => e.GRADE03 = v;
                        break;
                    case "GRADE04":
                        mapper[i] = (e, v) => e.GRADE04 = v;
                        break;
                    case "GRADE05":
                        mapper[i] = (e, v) => e.GRADE05 = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "COMMENTB":
                        mapper[i] = (e, v) => e.COMMENTB = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "TOT_CLASS_PERIODS":
                        mapper[i] = (e, v) => e.TOT_CLASS_PERIODS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOT_APPROVED_ABS":
                        mapper[i] = (e, v) => e.TOT_APPROVED_ABS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOT_UNAPPROVED_ABS":
                        mapper[i] = (e, v) => e.TOT_UNAPPROVED_ABS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EQUIVALENT_KLA":
                        mapper[i] = (e, v) => e.EQUIVALENT_KLA = v;
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
        /// Merges <see cref="STMA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STMA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STMA" /> items to added or update the base <see cref="STMA" /> items</param>
        /// <returns>A merged list of <see cref="STMA" /> items</returns>
        protected override List<STMA> ApplyDeltaItems(List<STMA> Items, List<STMA> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STMA deltaItem in DeltaItems)
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
                .OrderBy(i => i.SKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_CKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<STMA>>> Index_IDENT;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<STMA>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_MKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_SCHOOL_YEAR;
        private Lazy<Dictionary<string, IReadOnlyList<STMA>>> Index_SKEY;
        private Lazy<Dictionary<int, STMA>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STMA>>> Index_TTPERIOD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STMA by CKEY field
        /// </summary>
        /// <param name="CKEY">CKEY value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByCKEY(string CKEY)
        {
            return Index_CKEY.Value[CKEY];
        }

        /// <summary>
        /// Attempt to find STMA by CKEY field
        /// </summary>
        /// <param name="CKEY">CKEY value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCKEY(string CKEY, out IReadOnlyList<STMA> Value)
        {
            return Index_CKEY.Value.TryGetValue(CKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by CKEY field
        /// </summary>
        /// <param name="CKEY">CKEY value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByCKEY(string CKEY)
        {
            IReadOnlyList<STMA> value;
            if (Index_CKEY.Value.TryGetValue(CKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByIDENT(int? IDENT)
        {
            return Index_IDENT.Value[IDENT];
        }

        /// <summary>
        /// Attempt to find STMA by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByIDENT(int? IDENT, out IReadOnlyList<STMA> Value)
        {
            return Index_IDENT.Value.TryGetValue(IDENT, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByIDENT(int? IDENT)
        {
            IReadOnlyList<STMA> value;
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
        /// Find STMA by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find STMA by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<STMA> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<STMA> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by MKEY field
        /// </summary>
        /// <param name="MKEY">MKEY value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByMKEY(string MKEY)
        {
            return Index_MKEY.Value[MKEY];
        }

        /// <summary>
        /// Attempt to find STMA by MKEY field
        /// </summary>
        /// <param name="MKEY">MKEY value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMKEY(string MKEY, out IReadOnlyList<STMA> Value)
        {
            return Index_MKEY.Value.TryGetValue(MKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by MKEY field
        /// </summary>
        /// <param name="MKEY">MKEY value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByMKEY(string MKEY)
        {
            IReadOnlyList<STMA> value;
            if (Index_MKEY.Value.TryGetValue(MKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            return Index_SCHOOL_YEAR.Value[SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find STMA by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR(string SCHOOL_YEAR, out IReadOnlyList<STMA> Value)
        {
            return Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            IReadOnlyList<STMA> value;
            if (Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STMA by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STMA> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STMA> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMA</param>
        /// <returns>Related STMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMA</param>
        /// <param name="Value">Related STMA entity</param>
        /// <returns>True if the related STMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMA</param>
        /// <returns>Related STMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMA TryFindByTID(int TID)
        {
            STMA value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMA by TTPERIOD field
        /// </summary>
        /// <param name="TTPERIOD">TTPERIOD value used to find STMA</param>
        /// <returns>List of related STMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> FindByTTPERIOD(string TTPERIOD)
        {
            return Index_TTPERIOD.Value[TTPERIOD];
        }

        /// <summary>
        /// Attempt to find STMA by TTPERIOD field
        /// </summary>
        /// <param name="TTPERIOD">TTPERIOD value used to find STMA</param>
        /// <param name="Value">List of related STMA entities</param>
        /// <returns>True if the list of related STMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTTPERIOD(string TTPERIOD, out IReadOnlyList<STMA> Value)
        {
            return Index_TTPERIOD.Value.TryGetValue(TTPERIOD, out Value);
        }

        /// <summary>
        /// Attempt to find STMA by TTPERIOD field
        /// </summary>
        /// <param name="TTPERIOD">TTPERIOD value used to find STMA</param>
        /// <returns>List of related STMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMA> TryFindByTTPERIOD(string TTPERIOD)
        {
            IReadOnlyList<STMA> value;
            if (Index_TTPERIOD.Value.TryGetValue(TTPERIOD, out value))
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
