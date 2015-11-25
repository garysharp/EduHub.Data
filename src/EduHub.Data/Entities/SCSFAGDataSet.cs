using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Data Aggregates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCSFAGDataSet : SetBase<SCSFAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCSFAG"; } }

        internal SCSFAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCSFKEY = new Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>>(() => this.ToGroupedDictionary(i => i.SCSFKEY));
            Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY = new Lazy<Dictionary<Tuple<string, string, int?, string, string>, SCSFAG>>(() => this.ToDictionary(i => Tuple.Create(i.SCSFKEY, i.YEAR_SEMESTER, i.ST_CAMPUS, i.ST_YEAR_LEVEL, i.ST_CATEGORY)));
            Index_ST_YEAR_LEVEL = new Lazy<NullDictionary<string, IReadOnlyList<SCSFAG>>>(() => this.ToGroupedNullDictionary(i => i.ST_YEAR_LEVEL));
            Index_TID = new Lazy<Dictionary<int, SCSFAG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSFAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSFAG" /> fields for each CSV column header</returns>
        protected override Action<SCSFAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCSFAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "ST_CAMPUS":
                        mapper[i] = (e, v) => e.ST_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ST_CATEGORY":
                        mapper[i] = (e, v) => e.ST_CATEGORY = v;
                        break;
                    case "TOTAL_IN_GROUP":
                        mapper[i] = (e, v) => e.TOTAL_IN_GROUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT01":
                        mapper[i] = (e, v) => e.NUMBER_AT01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT02":
                        mapper[i] = (e, v) => e.NUMBER_AT02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT03":
                        mapper[i] = (e, v) => e.NUMBER_AT03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT04":
                        mapper[i] = (e, v) => e.NUMBER_AT04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT05":
                        mapper[i] = (e, v) => e.NUMBER_AT05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT06":
                        mapper[i] = (e, v) => e.NUMBER_AT06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT07":
                        mapper[i] = (e, v) => e.NUMBER_AT07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT08":
                        mapper[i] = (e, v) => e.NUMBER_AT08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT09":
                        mapper[i] = (e, v) => e.NUMBER_AT09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT10":
                        mapper[i] = (e, v) => e.NUMBER_AT10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT11":
                        mapper[i] = (e, v) => e.NUMBER_AT11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT12":
                        mapper[i] = (e, v) => e.NUMBER_AT12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT13":
                        mapper[i] = (e, v) => e.NUMBER_AT13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT14":
                        mapper[i] = (e, v) => e.NUMBER_AT14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT15":
                        mapper[i] = (e, v) => e.NUMBER_AT15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT16":
                        mapper[i] = (e, v) => e.NUMBER_AT16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT17":
                        mapper[i] = (e, v) => e.NUMBER_AT17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT18":
                        mapper[i] = (e, v) => e.NUMBER_AT18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT19":
                        mapper[i] = (e, v) => e.NUMBER_AT19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT20":
                        mapper[i] = (e, v) => e.NUMBER_AT20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT21":
                        mapper[i] = (e, v) => e.NUMBER_AT21 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT22":
                        mapper[i] = (e, v) => e.NUMBER_AT22 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT23":
                        mapper[i] = (e, v) => e.NUMBER_AT23 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT24":
                        mapper[i] = (e, v) => e.NUMBER_AT24 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT25":
                        mapper[i] = (e, v) => e.NUMBER_AT25 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT26":
                        mapper[i] = (e, v) => e.NUMBER_AT26 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT27":
                        mapper[i] = (e, v) => e.NUMBER_AT27 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT28":
                        mapper[i] = (e, v) => e.NUMBER_AT28 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_MEAN":
                        mapper[i] = (e, v) => e.SCHOOL_MEAN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MIN":
                        mapper[i] = (e, v) => e.SCHOOL_MIN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MAX":
                        mapper[i] = (e, v) => e.SCHOOL_MAX = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_15TH":
                        mapper[i] = (e, v) => e.SCHOOL_15TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_25TH":
                        mapper[i] = (e, v) => e.SCHOOL_25TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_75TH":
                        mapper[i] = (e, v) => e.SCHOOL_75TH = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SCSFAG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCSFAG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCSFAG" /> items to added or update the base <see cref="SCSFAG" /> items</param>
        /// <returns>A merged list of <see cref="SCSFAG" /> items</returns>
        protected override List<SCSFAG> ApplyDeltaItems(List<SCSFAG> Items, List<SCSFAG> DeltaItems)
        {
            Dictionary<Tuple<string, string, int?, string, string>, int> Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY = Items.ToIndexDictionary(i => Tuple.Create(i.SCSFKEY, i.YEAR_SEMESTER, i.ST_CAMPUS, i.ST_YEAR_LEVEL, i.ST_CATEGORY));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCSFAG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.TryGetValue(Tuple.Create(deltaItem.SCSFKEY, deltaItem.YEAR_SEMESTER, deltaItem.ST_CAMPUS, deltaItem.ST_YEAR_LEVEL, deltaItem.ST_CATEGORY), out index))
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
                .OrderBy(i => i.SCSFKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>> Index_SCSFKEY;
        private Lazy<Dictionary<Tuple<string, string, int?, string, string>, SCSFAG>> Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<SCSFAG>>> Index_ST_YEAR_LEVEL;
        private Lazy<Dictionary<int, SCSFAG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> FindBySCSFKEY(string SCSFKEY)
        {
            return Index_SCSFKEY.Value[SCSFKEY];
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="Value">List of related SCSFAG entities</param>
        /// <returns>True if the list of related SCSFAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY(string SCSFKEY, out IReadOnlyList<SCSFAG> Value)
        {
            return Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> TryFindBySCSFKEY(string SCSFKEY)
        {
            IReadOnlyList<SCSFAG> value;
            if (Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG FindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY)
        {
            return Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value[Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY)];
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <param name="Value">Related SCSFAG entity</param>
        /// <returns>True if the related SCSFAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY, out SCSFAG Value)
        {
            return Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value.TryGetValue(Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY), out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG TryFindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY)
        {
            SCSFAG value;
            if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value.TryGetValue(Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> FindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            return Index_ST_YEAR_LEVEL.Value[ST_YEAR_LEVEL];
        }

        /// <summary>
        /// Attempt to find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="Value">List of related SCSFAG entities</param>
        /// <returns>True if the list of related SCSFAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL, out IReadOnlyList<SCSFAG> Value)
        {
            return Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            IReadOnlyList<SCSFAG> value;
            if (Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <param name="Value">Related SCSFAG entity</param>
        /// <returns>True if the related SCSFAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SCSFAG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG TryFindByTID(int TID)
        {
            SCSFAG value;
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
