using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Headers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THDataSet : DataSetBase<TH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TH"; } }

        internal THDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_THKEY = new Lazy<Dictionary<string, TH>>(() => this.ToDictionary(i => i.THKEY));
            Index_TT01KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT01KEY));
            Index_TT02KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT02KEY));
            Index_TT03KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT03KEY));
            Index_TT04KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT04KEY));
            Index_TT05KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT05KEY));
            Index_TT06KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT06KEY));
            Index_TT07KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT07KEY));
            Index_TT08KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT08KEY));
            Index_TT09KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT09KEY));
            Index_TT10KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT10KEY));
            Index_TT11KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT11KEY));
            Index_TT12KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT12KEY));
            Index_TT13KEY = new Lazy<NullDictionary<string, IReadOnlyList<TH>>>(() => this.ToGroupedNullDictionary(i => i.TT13KEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TH" /> fields for each CSV column header</returns>
        protected override Action<TH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "THKEY":
                        mapper[i] = (e, v) => e.THKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SELECTABLE":
                        mapper[i] = (e, v) => e.SELECTABLE = v;
                        break;
                    case "THROWS":
                        mapper[i] = (e, v) => e.THROWS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "THCOLS":
                        mapper[i] = (e, v) => e.THCOLS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TH_RLABEL01":
                        mapper[i] = (e, v) => e.TH_RLABEL01 = v;
                        break;
                    case "TH_RLABEL02":
                        mapper[i] = (e, v) => e.TH_RLABEL02 = v;
                        break;
                    case "TH_RLABEL03":
                        mapper[i] = (e, v) => e.TH_RLABEL03 = v;
                        break;
                    case "TH_RLABEL04":
                        mapper[i] = (e, v) => e.TH_RLABEL04 = v;
                        break;
                    case "TH_RLABEL05":
                        mapper[i] = (e, v) => e.TH_RLABEL05 = v;
                        break;
                    case "TH_RLABEL06":
                        mapper[i] = (e, v) => e.TH_RLABEL06 = v;
                        break;
                    case "TH_RLABEL07":
                        mapper[i] = (e, v) => e.TH_RLABEL07 = v;
                        break;
                    case "TH_RLABEL08":
                        mapper[i] = (e, v) => e.TH_RLABEL08 = v;
                        break;
                    case "TH_RLABEL09":
                        mapper[i] = (e, v) => e.TH_RLABEL09 = v;
                        break;
                    case "TH_RLABEL10":
                        mapper[i] = (e, v) => e.TH_RLABEL10 = v;
                        break;
                    case "TH_RLABEL11":
                        mapper[i] = (e, v) => e.TH_RLABEL11 = v;
                        break;
                    case "TH_RLABEL12":
                        mapper[i] = (e, v) => e.TH_RLABEL12 = v;
                        break;
                    case "TH_CLABEL01":
                        mapper[i] = (e, v) => e.TH_CLABEL01 = v;
                        break;
                    case "TH_CLABEL02":
                        mapper[i] = (e, v) => e.TH_CLABEL02 = v;
                        break;
                    case "TH_CLABEL03":
                        mapper[i] = (e, v) => e.TH_CLABEL03 = v;
                        break;
                    case "TH_CLABEL04":
                        mapper[i] = (e, v) => e.TH_CLABEL04 = v;
                        break;
                    case "TH_CLABEL05":
                        mapper[i] = (e, v) => e.TH_CLABEL05 = v;
                        break;
                    case "TH_CLABEL06":
                        mapper[i] = (e, v) => e.TH_CLABEL06 = v;
                        break;
                    case "TH_CLABEL07":
                        mapper[i] = (e, v) => e.TH_CLABEL07 = v;
                        break;
                    case "TH_CLABEL08":
                        mapper[i] = (e, v) => e.TH_CLABEL08 = v;
                        break;
                    case "TH_CLABEL09":
                        mapper[i] = (e, v) => e.TH_CLABEL09 = v;
                        break;
                    case "TH_CLABEL10":
                        mapper[i] = (e, v) => e.TH_CLABEL10 = v;
                        break;
                    case "TH_CLABEL11":
                        mapper[i] = (e, v) => e.TH_CLABEL11 = v;
                        break;
                    case "TH_CLABEL12":
                        mapper[i] = (e, v) => e.TH_CLABEL12 = v;
                        break;
                    case "TH_CLABEL13":
                        mapper[i] = (e, v) => e.TH_CLABEL13 = v;
                        break;
                    case "TH_CLABEL14":
                        mapper[i] = (e, v) => e.TH_CLABEL14 = v;
                        break;
                    case "TH_CLABEL15":
                        mapper[i] = (e, v) => e.TH_CLABEL15 = v;
                        break;
                    case "TEACHING_PERIOD01":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD02":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD03":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD04":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD05":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD06":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD07":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD08":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD09":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD10":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD11":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD12":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TT01KEY":
                        mapper[i] = (e, v) => e.TT01KEY = v;
                        break;
                    case "TT02KEY":
                        mapper[i] = (e, v) => e.TT02KEY = v;
                        break;
                    case "TT03KEY":
                        mapper[i] = (e, v) => e.TT03KEY = v;
                        break;
                    case "TT04KEY":
                        mapper[i] = (e, v) => e.TT04KEY = v;
                        break;
                    case "TT05KEY":
                        mapper[i] = (e, v) => e.TT05KEY = v;
                        break;
                    case "TT06KEY":
                        mapper[i] = (e, v) => e.TT06KEY = v;
                        break;
                    case "TT07KEY":
                        mapper[i] = (e, v) => e.TT07KEY = v;
                        break;
                    case "TT08KEY":
                        mapper[i] = (e, v) => e.TT08KEY = v;
                        break;
                    case "TT09KEY":
                        mapper[i] = (e, v) => e.TT09KEY = v;
                        break;
                    case "TT10KEY":
                        mapper[i] = (e, v) => e.TT10KEY = v;
                        break;
                    case "TT11KEY":
                        mapper[i] = (e, v) => e.TT11KEY = v;
                        break;
                    case "TT12KEY":
                        mapper[i] = (e, v) => e.TT12KEY = v;
                        break;
                    case "TT13KEY":
                        mapper[i] = (e, v) => e.TT13KEY = v;
                        break;
                    case "THVIEW_QUILT01":
                        mapper[i] = (e, v) => e.THVIEW_QUILT01 = v;
                        break;
                    case "THVIEW_QUILT02":
                        mapper[i] = (e, v) => e.THVIEW_QUILT02 = v;
                        break;
                    case "THVIEW_QUILT03":
                        mapper[i] = (e, v) => e.THVIEW_QUILT03 = v;
                        break;
                    case "THVIEW_QUILT04":
                        mapper[i] = (e, v) => e.THVIEW_QUILT04 = v;
                        break;
                    case "THVIEW_QUILT05":
                        mapper[i] = (e, v) => e.THVIEW_QUILT05 = v;
                        break;
                    case "THVIEW_QUILT06":
                        mapper[i] = (e, v) => e.THVIEW_QUILT06 = v;
                        break;
                    case "THVIEW_QUILT07":
                        mapper[i] = (e, v) => e.THVIEW_QUILT07 = v;
                        break;
                    case "THVIEW_QUILT08":
                        mapper[i] = (e, v) => e.THVIEW_QUILT08 = v;
                        break;
                    case "THVIEW_QUILT09":
                        mapper[i] = (e, v) => e.THVIEW_QUILT09 = v;
                        break;
                    case "THVIEW_QUILT10":
                        mapper[i] = (e, v) => e.THVIEW_QUILT10 = v;
                        break;
                    case "THVIEW_QUILT11":
                        mapper[i] = (e, v) => e.THVIEW_QUILT11 = v;
                        break;
                    case "THVIEW_QUILT12":
                        mapper[i] = (e, v) => e.THVIEW_QUILT12 = v;
                        break;
                    case "THVIEW_QUILT13":
                        mapper[i] = (e, v) => e.THVIEW_QUILT13 = v;
                        break;
                    case "THVIEW_EXTRA01":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA01 = v;
                        break;
                    case "THVIEW_EXTRA02":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA02 = v;
                        break;
                    case "THVIEW_EXTRA03":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA03 = v;
                        break;
                    case "THVIEW_EXTRA04":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA04 = v;
                        break;
                    case "THVIEW_EXTRA05":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA05 = v;
                        break;
                    case "THVIEW_EXTRA06":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA06 = v;
                        break;
                    case "THVIEW_EXTRA07":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA07 = v;
                        break;
                    case "THVIEW_EXTRA08":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA08 = v;
                        break;
                    case "THVIEW_EXTRA09":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA09 = v;
                        break;
                    case "THVIEW_EXTRA10":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA10 = v;
                        break;
                    case "THVIEW_EXTRA11":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA11 = v;
                        break;
                    case "THVIEW_EXTRA12":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA12 = v;
                        break;
                    case "THVIEW_EXTRA13":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA13 = v;
                        break;
                    case "THVIEW_EXAM01":
                        mapper[i] = (e, v) => e.THVIEW_EXAM01 = v;
                        break;
                    case "THVIEW_EXAM02":
                        mapper[i] = (e, v) => e.THVIEW_EXAM02 = v;
                        break;
                    case "THVIEW_EXAM03":
                        mapper[i] = (e, v) => e.THVIEW_EXAM03 = v;
                        break;
                    case "THVIEW_EXAM04":
                        mapper[i] = (e, v) => e.THVIEW_EXAM04 = v;
                        break;
                    case "THVIEW_EXAM05":
                        mapper[i] = (e, v) => e.THVIEW_EXAM05 = v;
                        break;
                    case "THVIEW_EXAM06":
                        mapper[i] = (e, v) => e.THVIEW_EXAM06 = v;
                        break;
                    case "THVIEW_EXAM07":
                        mapper[i] = (e, v) => e.THVIEW_EXAM07 = v;
                        break;
                    case "THVIEW_EXAM08":
                        mapper[i] = (e, v) => e.THVIEW_EXAM08 = v;
                        break;
                    case "THVIEW_EXAM09":
                        mapper[i] = (e, v) => e.THVIEW_EXAM09 = v;
                        break;
                    case "THVIEW_EXAM10":
                        mapper[i] = (e, v) => e.THVIEW_EXAM10 = v;
                        break;
                    case "THVIEW_EXAM11":
                        mapper[i] = (e, v) => e.THVIEW_EXAM11 = v;
                        break;
                    case "THVIEW_EXAM12":
                        mapper[i] = (e, v) => e.THVIEW_EXAM12 = v;
                        break;
                    case "THVIEW_EXAM13":
                        mapper[i] = (e, v) => e.THVIEW_EXAM13 = v;
                        break;
                    case "CALENDAR_START01":
                        mapper[i] = (e, v) => e.CALENDAR_START01 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_START02":
                        mapper[i] = (e, v) => e.CALENDAR_START02 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_START03":
                        mapper[i] = (e, v) => e.CALENDAR_START03 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_START04":
                        mapper[i] = (e, v) => e.CALENDAR_START04 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END01":
                        mapper[i] = (e, v) => e.CALENDAR_END01 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END02":
                        mapper[i] = (e, v) => e.CALENDAR_END02 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END03":
                        mapper[i] = (e, v) => e.CALENDAR_END03 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END04":
                        mapper[i] = (e, v) => e.CALENDAR_END04 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_COLOUR":
                        mapper[i] = (e, v) => e.CALENDAR_COLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CALENDAR_PLACE_METHOD":
                        mapper[i] = (e, v) => e.CALENDAR_PLACE_METHOD = v;
                        break;
                    case "CALENDAR_DAYS01":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS01 = v;
                        break;
                    case "CALENDAR_DAYS02":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS02 = v;
                        break;
                    case "CALENDAR_DAYS03":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS03 = v;
                        break;
                    case "CALENDAR_DAYS04":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS04 = v;
                        break;
                    case "CALENDAR_DAYS05":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS05 = v;
                        break;
                    case "CALENDAR_DAYS06":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS06 = v;
                        break;
                    case "CALENDAR_DAYS07":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS07 = v;
                        break;
                    case "CALENDAR_ROW":
                        mapper[i] = (e, v) => e.CALENDAR_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CALENDAR_VIEW":
                        mapper[i] = (e, v) => e.CALENDAR_VIEW = v;
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
        /// Merges <see cref="TH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TH" /> items to added or update the base <see cref="TH" /> items</param>
        /// <returns>A merged list of <see cref="TH" /> items</returns>
        protected override List<TH> ApplyDeltaItems(List<TH> Items, List<TH> DeltaItems)
        {
            Dictionary<string, int> Index_THKEY = Items.ToIndexDictionary(i => i.THKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TH deltaItem in DeltaItems)
            {
                int index;

                if (Index_THKEY.TryGetValue(deltaItem.THKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.THKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<DateTime?, IReadOnlyList<TH>>> Index_LW_DATE;
        private Lazy<Dictionary<string, TH>> Index_THKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT01KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT02KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT03KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT04KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT05KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT06KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT07KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT08KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT09KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT10KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT11KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT12KEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TH>>> Index_TT13KEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TH by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find TH by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<TH> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find TH by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<TH> value;
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
        /// Find TH by THKEY field
        /// </summary>
        /// <param name="THKEY">THKEY value used to find TH</param>
        /// <returns>Related TH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TH FindByTHKEY(string THKEY)
        {
            return Index_THKEY.Value[THKEY];
        }

        /// <summary>
        /// Attempt to find TH by THKEY field
        /// </summary>
        /// <param name="THKEY">THKEY value used to find TH</param>
        /// <param name="Value">Related TH entity</param>
        /// <returns>True if the related TH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTHKEY(string THKEY, out TH Value)
        {
            return Index_THKEY.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by THKEY field
        /// </summary>
        /// <param name="THKEY">THKEY value used to find TH</param>
        /// <returns>Related TH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TH TryFindByTHKEY(string THKEY)
        {
            TH value;
            if (Index_THKEY.Value.TryGetValue(THKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT01KEY field
        /// </summary>
        /// <param name="TT01KEY">TT01KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT01KEY(string TT01KEY)
        {
            return Index_TT01KEY.Value[TT01KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT01KEY field
        /// </summary>
        /// <param name="TT01KEY">TT01KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT01KEY(string TT01KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT01KEY.Value.TryGetValue(TT01KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT01KEY field
        /// </summary>
        /// <param name="TT01KEY">TT01KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT01KEY(string TT01KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT01KEY.Value.TryGetValue(TT01KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT02KEY field
        /// </summary>
        /// <param name="TT02KEY">TT02KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT02KEY(string TT02KEY)
        {
            return Index_TT02KEY.Value[TT02KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT02KEY field
        /// </summary>
        /// <param name="TT02KEY">TT02KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT02KEY(string TT02KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT02KEY.Value.TryGetValue(TT02KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT02KEY field
        /// </summary>
        /// <param name="TT02KEY">TT02KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT02KEY(string TT02KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT02KEY.Value.TryGetValue(TT02KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT03KEY field
        /// </summary>
        /// <param name="TT03KEY">TT03KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT03KEY(string TT03KEY)
        {
            return Index_TT03KEY.Value[TT03KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT03KEY field
        /// </summary>
        /// <param name="TT03KEY">TT03KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT03KEY(string TT03KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT03KEY.Value.TryGetValue(TT03KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT03KEY field
        /// </summary>
        /// <param name="TT03KEY">TT03KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT03KEY(string TT03KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT03KEY.Value.TryGetValue(TT03KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT04KEY field
        /// </summary>
        /// <param name="TT04KEY">TT04KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT04KEY(string TT04KEY)
        {
            return Index_TT04KEY.Value[TT04KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT04KEY field
        /// </summary>
        /// <param name="TT04KEY">TT04KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT04KEY(string TT04KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT04KEY.Value.TryGetValue(TT04KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT04KEY field
        /// </summary>
        /// <param name="TT04KEY">TT04KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT04KEY(string TT04KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT04KEY.Value.TryGetValue(TT04KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT05KEY field
        /// </summary>
        /// <param name="TT05KEY">TT05KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT05KEY(string TT05KEY)
        {
            return Index_TT05KEY.Value[TT05KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT05KEY field
        /// </summary>
        /// <param name="TT05KEY">TT05KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT05KEY(string TT05KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT05KEY.Value.TryGetValue(TT05KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT05KEY field
        /// </summary>
        /// <param name="TT05KEY">TT05KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT05KEY(string TT05KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT05KEY.Value.TryGetValue(TT05KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT06KEY field
        /// </summary>
        /// <param name="TT06KEY">TT06KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT06KEY(string TT06KEY)
        {
            return Index_TT06KEY.Value[TT06KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT06KEY field
        /// </summary>
        /// <param name="TT06KEY">TT06KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT06KEY(string TT06KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT06KEY.Value.TryGetValue(TT06KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT06KEY field
        /// </summary>
        /// <param name="TT06KEY">TT06KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT06KEY(string TT06KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT06KEY.Value.TryGetValue(TT06KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT07KEY field
        /// </summary>
        /// <param name="TT07KEY">TT07KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT07KEY(string TT07KEY)
        {
            return Index_TT07KEY.Value[TT07KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT07KEY field
        /// </summary>
        /// <param name="TT07KEY">TT07KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT07KEY(string TT07KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT07KEY.Value.TryGetValue(TT07KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT07KEY field
        /// </summary>
        /// <param name="TT07KEY">TT07KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT07KEY(string TT07KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT07KEY.Value.TryGetValue(TT07KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT08KEY field
        /// </summary>
        /// <param name="TT08KEY">TT08KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT08KEY(string TT08KEY)
        {
            return Index_TT08KEY.Value[TT08KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT08KEY field
        /// </summary>
        /// <param name="TT08KEY">TT08KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT08KEY(string TT08KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT08KEY.Value.TryGetValue(TT08KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT08KEY field
        /// </summary>
        /// <param name="TT08KEY">TT08KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT08KEY(string TT08KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT08KEY.Value.TryGetValue(TT08KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT09KEY field
        /// </summary>
        /// <param name="TT09KEY">TT09KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT09KEY(string TT09KEY)
        {
            return Index_TT09KEY.Value[TT09KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT09KEY field
        /// </summary>
        /// <param name="TT09KEY">TT09KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT09KEY(string TT09KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT09KEY.Value.TryGetValue(TT09KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT09KEY field
        /// </summary>
        /// <param name="TT09KEY">TT09KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT09KEY(string TT09KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT09KEY.Value.TryGetValue(TT09KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT10KEY field
        /// </summary>
        /// <param name="TT10KEY">TT10KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT10KEY(string TT10KEY)
        {
            return Index_TT10KEY.Value[TT10KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT10KEY field
        /// </summary>
        /// <param name="TT10KEY">TT10KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT10KEY(string TT10KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT10KEY.Value.TryGetValue(TT10KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT10KEY field
        /// </summary>
        /// <param name="TT10KEY">TT10KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT10KEY(string TT10KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT10KEY.Value.TryGetValue(TT10KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT11KEY field
        /// </summary>
        /// <param name="TT11KEY">TT11KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT11KEY(string TT11KEY)
        {
            return Index_TT11KEY.Value[TT11KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT11KEY field
        /// </summary>
        /// <param name="TT11KEY">TT11KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT11KEY(string TT11KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT11KEY.Value.TryGetValue(TT11KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT11KEY field
        /// </summary>
        /// <param name="TT11KEY">TT11KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT11KEY(string TT11KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT11KEY.Value.TryGetValue(TT11KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT12KEY field
        /// </summary>
        /// <param name="TT12KEY">TT12KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT12KEY(string TT12KEY)
        {
            return Index_TT12KEY.Value[TT12KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT12KEY field
        /// </summary>
        /// <param name="TT12KEY">TT12KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT12KEY(string TT12KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT12KEY.Value.TryGetValue(TT12KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT12KEY field
        /// </summary>
        /// <param name="TT12KEY">TT12KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT12KEY(string TT12KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT12KEY.Value.TryGetValue(TT12KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TH by TT13KEY field
        /// </summary>
        /// <param name="TT13KEY">TT13KEY value used to find TH</param>
        /// <returns>List of related TH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> FindByTT13KEY(string TT13KEY)
        {
            return Index_TT13KEY.Value[TT13KEY];
        }

        /// <summary>
        /// Attempt to find TH by TT13KEY field
        /// </summary>
        /// <param name="TT13KEY">TT13KEY value used to find TH</param>
        /// <param name="Value">List of related TH entities</param>
        /// <returns>True if the list of related TH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTT13KEY(string TT13KEY, out IReadOnlyList<TH> Value)
        {
            return Index_TT13KEY.Value.TryGetValue(TT13KEY, out Value);
        }

        /// <summary>
        /// Attempt to find TH by TT13KEY field
        /// </summary>
        /// <param name="TT13KEY">TT13KEY value used to find TH</param>
        /// <returns>List of related TH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TH> TryFindByTT13KEY(string TT13KEY)
        {
            IReadOnlyList<TH> value;
            if (Index_TT13KEY.Value.TryGetValue(TT13KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns SQL which checks for the existence of a TH table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TH](
        [THKEY] varchar(8) NOT NULL,
        [TITLE] varchar(30) NULL,
        [SELECTABLE] varchar(1) NULL,
        [THROWS] smallint NULL,
        [THCOLS] smallint NULL,
        [TH_RLABEL01] varchar(10) NULL,
        [TH_RLABEL02] varchar(10) NULL,
        [TH_RLABEL03] varchar(10) NULL,
        [TH_RLABEL04] varchar(10) NULL,
        [TH_RLABEL05] varchar(10) NULL,
        [TH_RLABEL06] varchar(10) NULL,
        [TH_RLABEL07] varchar(10) NULL,
        [TH_RLABEL08] varchar(10) NULL,
        [TH_RLABEL09] varchar(10) NULL,
        [TH_RLABEL10] varchar(10) NULL,
        [TH_RLABEL11] varchar(10) NULL,
        [TH_RLABEL12] varchar(10) NULL,
        [TH_CLABEL01] varchar(10) NULL,
        [TH_CLABEL02] varchar(10) NULL,
        [TH_CLABEL03] varchar(10) NULL,
        [TH_CLABEL04] varchar(10) NULL,
        [TH_CLABEL05] varchar(10) NULL,
        [TH_CLABEL06] varchar(10) NULL,
        [TH_CLABEL07] varchar(10) NULL,
        [TH_CLABEL08] varchar(10) NULL,
        [TH_CLABEL09] varchar(10) NULL,
        [TH_CLABEL10] varchar(10) NULL,
        [TH_CLABEL11] varchar(10) NULL,
        [TH_CLABEL12] varchar(10) NULL,
        [TH_CLABEL13] varchar(10) NULL,
        [TH_CLABEL14] varchar(10) NULL,
        [TH_CLABEL15] varchar(10) NULL,
        [TEACHING_PERIOD01] smallint NULL,
        [TEACHING_PERIOD02] smallint NULL,
        [TEACHING_PERIOD03] smallint NULL,
        [TEACHING_PERIOD04] smallint NULL,
        [TEACHING_PERIOD05] smallint NULL,
        [TEACHING_PERIOD06] smallint NULL,
        [TEACHING_PERIOD07] smallint NULL,
        [TEACHING_PERIOD08] smallint NULL,
        [TEACHING_PERIOD09] smallint NULL,
        [TEACHING_PERIOD10] smallint NULL,
        [TEACHING_PERIOD11] smallint NULL,
        [TEACHING_PERIOD12] smallint NULL,
        [TT01KEY] varchar(8) NULL,
        [TT02KEY] varchar(8) NULL,
        [TT03KEY] varchar(8) NULL,
        [TT04KEY] varchar(8) NULL,
        [TT05KEY] varchar(8) NULL,
        [TT06KEY] varchar(8) NULL,
        [TT07KEY] varchar(8) NULL,
        [TT08KEY] varchar(8) NULL,
        [TT09KEY] varchar(8) NULL,
        [TT10KEY] varchar(8) NULL,
        [TT11KEY] varchar(8) NULL,
        [TT12KEY] varchar(8) NULL,
        [TT13KEY] varchar(8) NULL,
        [THVIEW_QUILT01] varchar(1) NULL,
        [THVIEW_QUILT02] varchar(1) NULL,
        [THVIEW_QUILT03] varchar(1) NULL,
        [THVIEW_QUILT04] varchar(1) NULL,
        [THVIEW_QUILT05] varchar(1) NULL,
        [THVIEW_QUILT06] varchar(1) NULL,
        [THVIEW_QUILT07] varchar(1) NULL,
        [THVIEW_QUILT08] varchar(1) NULL,
        [THVIEW_QUILT09] varchar(1) NULL,
        [THVIEW_QUILT10] varchar(1) NULL,
        [THVIEW_QUILT11] varchar(1) NULL,
        [THVIEW_QUILT12] varchar(1) NULL,
        [THVIEW_QUILT13] varchar(1) NULL,
        [THVIEW_EXTRA01] varchar(1) NULL,
        [THVIEW_EXTRA02] varchar(1) NULL,
        [THVIEW_EXTRA03] varchar(1) NULL,
        [THVIEW_EXTRA04] varchar(1) NULL,
        [THVIEW_EXTRA05] varchar(1) NULL,
        [THVIEW_EXTRA06] varchar(1) NULL,
        [THVIEW_EXTRA07] varchar(1) NULL,
        [THVIEW_EXTRA08] varchar(1) NULL,
        [THVIEW_EXTRA09] varchar(1) NULL,
        [THVIEW_EXTRA10] varchar(1) NULL,
        [THVIEW_EXTRA11] varchar(1) NULL,
        [THVIEW_EXTRA12] varchar(1) NULL,
        [THVIEW_EXTRA13] varchar(1) NULL,
        [THVIEW_EXAM01] varchar(1) NULL,
        [THVIEW_EXAM02] varchar(1) NULL,
        [THVIEW_EXAM03] varchar(1) NULL,
        [THVIEW_EXAM04] varchar(1) NULL,
        [THVIEW_EXAM05] varchar(1) NULL,
        [THVIEW_EXAM06] varchar(1) NULL,
        [THVIEW_EXAM07] varchar(1) NULL,
        [THVIEW_EXAM08] varchar(1) NULL,
        [THVIEW_EXAM09] varchar(1) NULL,
        [THVIEW_EXAM10] varchar(1) NULL,
        [THVIEW_EXAM11] varchar(1) NULL,
        [THVIEW_EXAM12] varchar(1) NULL,
        [THVIEW_EXAM13] varchar(1) NULL,
        [CALENDAR_START01] datetime NULL,
        [CALENDAR_START02] datetime NULL,
        [CALENDAR_START03] datetime NULL,
        [CALENDAR_START04] datetime NULL,
        [CALENDAR_END01] datetime NULL,
        [CALENDAR_END02] datetime NULL,
        [CALENDAR_END03] datetime NULL,
        [CALENDAR_END04] datetime NULL,
        [CALENDAR_COLOUR] int NULL,
        [CALENDAR_PLACE_METHOD] varchar(1) NULL,
        [CALENDAR_DAYS01] varchar(1) NULL,
        [CALENDAR_DAYS02] varchar(1) NULL,
        [CALENDAR_DAYS03] varchar(1) NULL,
        [CALENDAR_DAYS04] varchar(1) NULL,
        [CALENDAR_DAYS05] varchar(1) NULL,
        [CALENDAR_DAYS06] varchar(1) NULL,
        [CALENDAR_DAYS07] varchar(1) NULL,
        [CALENDAR_ROW] smallint NULL,
        [CALENDAR_VIEW] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TH_Index_THKEY] PRIMARY KEY CLUSTERED (
            [THKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TH_Index_LW_DATE] ON [dbo].[TH]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT01KEY] ON [dbo].[TH]
    (
            [TT01KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT02KEY] ON [dbo].[TH]
    (
            [TT02KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT03KEY] ON [dbo].[TH]
    (
            [TT03KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT04KEY] ON [dbo].[TH]
    (
            [TT04KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT05KEY] ON [dbo].[TH]
    (
            [TT05KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT06KEY] ON [dbo].[TH]
    (
            [TT06KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT07KEY] ON [dbo].[TH]
    (
            [TT07KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT08KEY] ON [dbo].[TH]
    (
            [TT08KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT09KEY] ON [dbo].[TH]
    (
            [TT09KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT10KEY] ON [dbo].[TH]
    (
            [TT10KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT11KEY] ON [dbo].[TH]
    (
            [TT11KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT12KEY] ON [dbo].[TH]
    (
            [TT12KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TH_Index_TT13KEY] ON [dbo].[TH]
    (
            [TT13KEY] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TH data set</returns>
        public override IDataReader GetDataReader()
        {
            return new THDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class THDataReader : IDataReader, IDataRecord
        {
            private List<TH> Items;
            private int CurrentIndex;
            private TH CurrentItem;

            public THDataReader(List<TH> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 118; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // THKEY
                        return CurrentItem.THKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // SELECTABLE
                        return CurrentItem.SELECTABLE;
                    case 3: // THROWS
                        return CurrentItem.THROWS;
                    case 4: // THCOLS
                        return CurrentItem.THCOLS;
                    case 5: // TH_RLABEL01
                        return CurrentItem.TH_RLABEL01;
                    case 6: // TH_RLABEL02
                        return CurrentItem.TH_RLABEL02;
                    case 7: // TH_RLABEL03
                        return CurrentItem.TH_RLABEL03;
                    case 8: // TH_RLABEL04
                        return CurrentItem.TH_RLABEL04;
                    case 9: // TH_RLABEL05
                        return CurrentItem.TH_RLABEL05;
                    case 10: // TH_RLABEL06
                        return CurrentItem.TH_RLABEL06;
                    case 11: // TH_RLABEL07
                        return CurrentItem.TH_RLABEL07;
                    case 12: // TH_RLABEL08
                        return CurrentItem.TH_RLABEL08;
                    case 13: // TH_RLABEL09
                        return CurrentItem.TH_RLABEL09;
                    case 14: // TH_RLABEL10
                        return CurrentItem.TH_RLABEL10;
                    case 15: // TH_RLABEL11
                        return CurrentItem.TH_RLABEL11;
                    case 16: // TH_RLABEL12
                        return CurrentItem.TH_RLABEL12;
                    case 17: // TH_CLABEL01
                        return CurrentItem.TH_CLABEL01;
                    case 18: // TH_CLABEL02
                        return CurrentItem.TH_CLABEL02;
                    case 19: // TH_CLABEL03
                        return CurrentItem.TH_CLABEL03;
                    case 20: // TH_CLABEL04
                        return CurrentItem.TH_CLABEL04;
                    case 21: // TH_CLABEL05
                        return CurrentItem.TH_CLABEL05;
                    case 22: // TH_CLABEL06
                        return CurrentItem.TH_CLABEL06;
                    case 23: // TH_CLABEL07
                        return CurrentItem.TH_CLABEL07;
                    case 24: // TH_CLABEL08
                        return CurrentItem.TH_CLABEL08;
                    case 25: // TH_CLABEL09
                        return CurrentItem.TH_CLABEL09;
                    case 26: // TH_CLABEL10
                        return CurrentItem.TH_CLABEL10;
                    case 27: // TH_CLABEL11
                        return CurrentItem.TH_CLABEL11;
                    case 28: // TH_CLABEL12
                        return CurrentItem.TH_CLABEL12;
                    case 29: // TH_CLABEL13
                        return CurrentItem.TH_CLABEL13;
                    case 30: // TH_CLABEL14
                        return CurrentItem.TH_CLABEL14;
                    case 31: // TH_CLABEL15
                        return CurrentItem.TH_CLABEL15;
                    case 32: // TEACHING_PERIOD01
                        return CurrentItem.TEACHING_PERIOD01;
                    case 33: // TEACHING_PERIOD02
                        return CurrentItem.TEACHING_PERIOD02;
                    case 34: // TEACHING_PERIOD03
                        return CurrentItem.TEACHING_PERIOD03;
                    case 35: // TEACHING_PERIOD04
                        return CurrentItem.TEACHING_PERIOD04;
                    case 36: // TEACHING_PERIOD05
                        return CurrentItem.TEACHING_PERIOD05;
                    case 37: // TEACHING_PERIOD06
                        return CurrentItem.TEACHING_PERIOD06;
                    case 38: // TEACHING_PERIOD07
                        return CurrentItem.TEACHING_PERIOD07;
                    case 39: // TEACHING_PERIOD08
                        return CurrentItem.TEACHING_PERIOD08;
                    case 40: // TEACHING_PERIOD09
                        return CurrentItem.TEACHING_PERIOD09;
                    case 41: // TEACHING_PERIOD10
                        return CurrentItem.TEACHING_PERIOD10;
                    case 42: // TEACHING_PERIOD11
                        return CurrentItem.TEACHING_PERIOD11;
                    case 43: // TEACHING_PERIOD12
                        return CurrentItem.TEACHING_PERIOD12;
                    case 44: // TT01KEY
                        return CurrentItem.TT01KEY;
                    case 45: // TT02KEY
                        return CurrentItem.TT02KEY;
                    case 46: // TT03KEY
                        return CurrentItem.TT03KEY;
                    case 47: // TT04KEY
                        return CurrentItem.TT04KEY;
                    case 48: // TT05KEY
                        return CurrentItem.TT05KEY;
                    case 49: // TT06KEY
                        return CurrentItem.TT06KEY;
                    case 50: // TT07KEY
                        return CurrentItem.TT07KEY;
                    case 51: // TT08KEY
                        return CurrentItem.TT08KEY;
                    case 52: // TT09KEY
                        return CurrentItem.TT09KEY;
                    case 53: // TT10KEY
                        return CurrentItem.TT10KEY;
                    case 54: // TT11KEY
                        return CurrentItem.TT11KEY;
                    case 55: // TT12KEY
                        return CurrentItem.TT12KEY;
                    case 56: // TT13KEY
                        return CurrentItem.TT13KEY;
                    case 57: // THVIEW_QUILT01
                        return CurrentItem.THVIEW_QUILT01;
                    case 58: // THVIEW_QUILT02
                        return CurrentItem.THVIEW_QUILT02;
                    case 59: // THVIEW_QUILT03
                        return CurrentItem.THVIEW_QUILT03;
                    case 60: // THVIEW_QUILT04
                        return CurrentItem.THVIEW_QUILT04;
                    case 61: // THVIEW_QUILT05
                        return CurrentItem.THVIEW_QUILT05;
                    case 62: // THVIEW_QUILT06
                        return CurrentItem.THVIEW_QUILT06;
                    case 63: // THVIEW_QUILT07
                        return CurrentItem.THVIEW_QUILT07;
                    case 64: // THVIEW_QUILT08
                        return CurrentItem.THVIEW_QUILT08;
                    case 65: // THVIEW_QUILT09
                        return CurrentItem.THVIEW_QUILT09;
                    case 66: // THVIEW_QUILT10
                        return CurrentItem.THVIEW_QUILT10;
                    case 67: // THVIEW_QUILT11
                        return CurrentItem.THVIEW_QUILT11;
                    case 68: // THVIEW_QUILT12
                        return CurrentItem.THVIEW_QUILT12;
                    case 69: // THVIEW_QUILT13
                        return CurrentItem.THVIEW_QUILT13;
                    case 70: // THVIEW_EXTRA01
                        return CurrentItem.THVIEW_EXTRA01;
                    case 71: // THVIEW_EXTRA02
                        return CurrentItem.THVIEW_EXTRA02;
                    case 72: // THVIEW_EXTRA03
                        return CurrentItem.THVIEW_EXTRA03;
                    case 73: // THVIEW_EXTRA04
                        return CurrentItem.THVIEW_EXTRA04;
                    case 74: // THVIEW_EXTRA05
                        return CurrentItem.THVIEW_EXTRA05;
                    case 75: // THVIEW_EXTRA06
                        return CurrentItem.THVIEW_EXTRA06;
                    case 76: // THVIEW_EXTRA07
                        return CurrentItem.THVIEW_EXTRA07;
                    case 77: // THVIEW_EXTRA08
                        return CurrentItem.THVIEW_EXTRA08;
                    case 78: // THVIEW_EXTRA09
                        return CurrentItem.THVIEW_EXTRA09;
                    case 79: // THVIEW_EXTRA10
                        return CurrentItem.THVIEW_EXTRA10;
                    case 80: // THVIEW_EXTRA11
                        return CurrentItem.THVIEW_EXTRA11;
                    case 81: // THVIEW_EXTRA12
                        return CurrentItem.THVIEW_EXTRA12;
                    case 82: // THVIEW_EXTRA13
                        return CurrentItem.THVIEW_EXTRA13;
                    case 83: // THVIEW_EXAM01
                        return CurrentItem.THVIEW_EXAM01;
                    case 84: // THVIEW_EXAM02
                        return CurrentItem.THVIEW_EXAM02;
                    case 85: // THVIEW_EXAM03
                        return CurrentItem.THVIEW_EXAM03;
                    case 86: // THVIEW_EXAM04
                        return CurrentItem.THVIEW_EXAM04;
                    case 87: // THVIEW_EXAM05
                        return CurrentItem.THVIEW_EXAM05;
                    case 88: // THVIEW_EXAM06
                        return CurrentItem.THVIEW_EXAM06;
                    case 89: // THVIEW_EXAM07
                        return CurrentItem.THVIEW_EXAM07;
                    case 90: // THVIEW_EXAM08
                        return CurrentItem.THVIEW_EXAM08;
                    case 91: // THVIEW_EXAM09
                        return CurrentItem.THVIEW_EXAM09;
                    case 92: // THVIEW_EXAM10
                        return CurrentItem.THVIEW_EXAM10;
                    case 93: // THVIEW_EXAM11
                        return CurrentItem.THVIEW_EXAM11;
                    case 94: // THVIEW_EXAM12
                        return CurrentItem.THVIEW_EXAM12;
                    case 95: // THVIEW_EXAM13
                        return CurrentItem.THVIEW_EXAM13;
                    case 96: // CALENDAR_START01
                        return CurrentItem.CALENDAR_START01;
                    case 97: // CALENDAR_START02
                        return CurrentItem.CALENDAR_START02;
                    case 98: // CALENDAR_START03
                        return CurrentItem.CALENDAR_START03;
                    case 99: // CALENDAR_START04
                        return CurrentItem.CALENDAR_START04;
                    case 100: // CALENDAR_END01
                        return CurrentItem.CALENDAR_END01;
                    case 101: // CALENDAR_END02
                        return CurrentItem.CALENDAR_END02;
                    case 102: // CALENDAR_END03
                        return CurrentItem.CALENDAR_END03;
                    case 103: // CALENDAR_END04
                        return CurrentItem.CALENDAR_END04;
                    case 104: // CALENDAR_COLOUR
                        return CurrentItem.CALENDAR_COLOUR;
                    case 105: // CALENDAR_PLACE_METHOD
                        return CurrentItem.CALENDAR_PLACE_METHOD;
                    case 106: // CALENDAR_DAYS01
                        return CurrentItem.CALENDAR_DAYS01;
                    case 107: // CALENDAR_DAYS02
                        return CurrentItem.CALENDAR_DAYS02;
                    case 108: // CALENDAR_DAYS03
                        return CurrentItem.CALENDAR_DAYS03;
                    case 109: // CALENDAR_DAYS04
                        return CurrentItem.CALENDAR_DAYS04;
                    case 110: // CALENDAR_DAYS05
                        return CurrentItem.CALENDAR_DAYS05;
                    case 111: // CALENDAR_DAYS06
                        return CurrentItem.CALENDAR_DAYS06;
                    case 112: // CALENDAR_DAYS07
                        return CurrentItem.CALENDAR_DAYS07;
                    case 113: // CALENDAR_ROW
                        return CurrentItem.CALENDAR_ROW;
                    case 114: // CALENDAR_VIEW
                        return CurrentItem.CALENDAR_VIEW;
                    case 115: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 116: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 117: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // SELECTABLE
                        return CurrentItem.SELECTABLE == null;
                    case 3: // THROWS
                        return CurrentItem.THROWS == null;
                    case 4: // THCOLS
                        return CurrentItem.THCOLS == null;
                    case 5: // TH_RLABEL01
                        return CurrentItem.TH_RLABEL01 == null;
                    case 6: // TH_RLABEL02
                        return CurrentItem.TH_RLABEL02 == null;
                    case 7: // TH_RLABEL03
                        return CurrentItem.TH_RLABEL03 == null;
                    case 8: // TH_RLABEL04
                        return CurrentItem.TH_RLABEL04 == null;
                    case 9: // TH_RLABEL05
                        return CurrentItem.TH_RLABEL05 == null;
                    case 10: // TH_RLABEL06
                        return CurrentItem.TH_RLABEL06 == null;
                    case 11: // TH_RLABEL07
                        return CurrentItem.TH_RLABEL07 == null;
                    case 12: // TH_RLABEL08
                        return CurrentItem.TH_RLABEL08 == null;
                    case 13: // TH_RLABEL09
                        return CurrentItem.TH_RLABEL09 == null;
                    case 14: // TH_RLABEL10
                        return CurrentItem.TH_RLABEL10 == null;
                    case 15: // TH_RLABEL11
                        return CurrentItem.TH_RLABEL11 == null;
                    case 16: // TH_RLABEL12
                        return CurrentItem.TH_RLABEL12 == null;
                    case 17: // TH_CLABEL01
                        return CurrentItem.TH_CLABEL01 == null;
                    case 18: // TH_CLABEL02
                        return CurrentItem.TH_CLABEL02 == null;
                    case 19: // TH_CLABEL03
                        return CurrentItem.TH_CLABEL03 == null;
                    case 20: // TH_CLABEL04
                        return CurrentItem.TH_CLABEL04 == null;
                    case 21: // TH_CLABEL05
                        return CurrentItem.TH_CLABEL05 == null;
                    case 22: // TH_CLABEL06
                        return CurrentItem.TH_CLABEL06 == null;
                    case 23: // TH_CLABEL07
                        return CurrentItem.TH_CLABEL07 == null;
                    case 24: // TH_CLABEL08
                        return CurrentItem.TH_CLABEL08 == null;
                    case 25: // TH_CLABEL09
                        return CurrentItem.TH_CLABEL09 == null;
                    case 26: // TH_CLABEL10
                        return CurrentItem.TH_CLABEL10 == null;
                    case 27: // TH_CLABEL11
                        return CurrentItem.TH_CLABEL11 == null;
                    case 28: // TH_CLABEL12
                        return CurrentItem.TH_CLABEL12 == null;
                    case 29: // TH_CLABEL13
                        return CurrentItem.TH_CLABEL13 == null;
                    case 30: // TH_CLABEL14
                        return CurrentItem.TH_CLABEL14 == null;
                    case 31: // TH_CLABEL15
                        return CurrentItem.TH_CLABEL15 == null;
                    case 32: // TEACHING_PERIOD01
                        return CurrentItem.TEACHING_PERIOD01 == null;
                    case 33: // TEACHING_PERIOD02
                        return CurrentItem.TEACHING_PERIOD02 == null;
                    case 34: // TEACHING_PERIOD03
                        return CurrentItem.TEACHING_PERIOD03 == null;
                    case 35: // TEACHING_PERIOD04
                        return CurrentItem.TEACHING_PERIOD04 == null;
                    case 36: // TEACHING_PERIOD05
                        return CurrentItem.TEACHING_PERIOD05 == null;
                    case 37: // TEACHING_PERIOD06
                        return CurrentItem.TEACHING_PERIOD06 == null;
                    case 38: // TEACHING_PERIOD07
                        return CurrentItem.TEACHING_PERIOD07 == null;
                    case 39: // TEACHING_PERIOD08
                        return CurrentItem.TEACHING_PERIOD08 == null;
                    case 40: // TEACHING_PERIOD09
                        return CurrentItem.TEACHING_PERIOD09 == null;
                    case 41: // TEACHING_PERIOD10
                        return CurrentItem.TEACHING_PERIOD10 == null;
                    case 42: // TEACHING_PERIOD11
                        return CurrentItem.TEACHING_PERIOD11 == null;
                    case 43: // TEACHING_PERIOD12
                        return CurrentItem.TEACHING_PERIOD12 == null;
                    case 44: // TT01KEY
                        return CurrentItem.TT01KEY == null;
                    case 45: // TT02KEY
                        return CurrentItem.TT02KEY == null;
                    case 46: // TT03KEY
                        return CurrentItem.TT03KEY == null;
                    case 47: // TT04KEY
                        return CurrentItem.TT04KEY == null;
                    case 48: // TT05KEY
                        return CurrentItem.TT05KEY == null;
                    case 49: // TT06KEY
                        return CurrentItem.TT06KEY == null;
                    case 50: // TT07KEY
                        return CurrentItem.TT07KEY == null;
                    case 51: // TT08KEY
                        return CurrentItem.TT08KEY == null;
                    case 52: // TT09KEY
                        return CurrentItem.TT09KEY == null;
                    case 53: // TT10KEY
                        return CurrentItem.TT10KEY == null;
                    case 54: // TT11KEY
                        return CurrentItem.TT11KEY == null;
                    case 55: // TT12KEY
                        return CurrentItem.TT12KEY == null;
                    case 56: // TT13KEY
                        return CurrentItem.TT13KEY == null;
                    case 57: // THVIEW_QUILT01
                        return CurrentItem.THVIEW_QUILT01 == null;
                    case 58: // THVIEW_QUILT02
                        return CurrentItem.THVIEW_QUILT02 == null;
                    case 59: // THVIEW_QUILT03
                        return CurrentItem.THVIEW_QUILT03 == null;
                    case 60: // THVIEW_QUILT04
                        return CurrentItem.THVIEW_QUILT04 == null;
                    case 61: // THVIEW_QUILT05
                        return CurrentItem.THVIEW_QUILT05 == null;
                    case 62: // THVIEW_QUILT06
                        return CurrentItem.THVIEW_QUILT06 == null;
                    case 63: // THVIEW_QUILT07
                        return CurrentItem.THVIEW_QUILT07 == null;
                    case 64: // THVIEW_QUILT08
                        return CurrentItem.THVIEW_QUILT08 == null;
                    case 65: // THVIEW_QUILT09
                        return CurrentItem.THVIEW_QUILT09 == null;
                    case 66: // THVIEW_QUILT10
                        return CurrentItem.THVIEW_QUILT10 == null;
                    case 67: // THVIEW_QUILT11
                        return CurrentItem.THVIEW_QUILT11 == null;
                    case 68: // THVIEW_QUILT12
                        return CurrentItem.THVIEW_QUILT12 == null;
                    case 69: // THVIEW_QUILT13
                        return CurrentItem.THVIEW_QUILT13 == null;
                    case 70: // THVIEW_EXTRA01
                        return CurrentItem.THVIEW_EXTRA01 == null;
                    case 71: // THVIEW_EXTRA02
                        return CurrentItem.THVIEW_EXTRA02 == null;
                    case 72: // THVIEW_EXTRA03
                        return CurrentItem.THVIEW_EXTRA03 == null;
                    case 73: // THVIEW_EXTRA04
                        return CurrentItem.THVIEW_EXTRA04 == null;
                    case 74: // THVIEW_EXTRA05
                        return CurrentItem.THVIEW_EXTRA05 == null;
                    case 75: // THVIEW_EXTRA06
                        return CurrentItem.THVIEW_EXTRA06 == null;
                    case 76: // THVIEW_EXTRA07
                        return CurrentItem.THVIEW_EXTRA07 == null;
                    case 77: // THVIEW_EXTRA08
                        return CurrentItem.THVIEW_EXTRA08 == null;
                    case 78: // THVIEW_EXTRA09
                        return CurrentItem.THVIEW_EXTRA09 == null;
                    case 79: // THVIEW_EXTRA10
                        return CurrentItem.THVIEW_EXTRA10 == null;
                    case 80: // THVIEW_EXTRA11
                        return CurrentItem.THVIEW_EXTRA11 == null;
                    case 81: // THVIEW_EXTRA12
                        return CurrentItem.THVIEW_EXTRA12 == null;
                    case 82: // THVIEW_EXTRA13
                        return CurrentItem.THVIEW_EXTRA13 == null;
                    case 83: // THVIEW_EXAM01
                        return CurrentItem.THVIEW_EXAM01 == null;
                    case 84: // THVIEW_EXAM02
                        return CurrentItem.THVIEW_EXAM02 == null;
                    case 85: // THVIEW_EXAM03
                        return CurrentItem.THVIEW_EXAM03 == null;
                    case 86: // THVIEW_EXAM04
                        return CurrentItem.THVIEW_EXAM04 == null;
                    case 87: // THVIEW_EXAM05
                        return CurrentItem.THVIEW_EXAM05 == null;
                    case 88: // THVIEW_EXAM06
                        return CurrentItem.THVIEW_EXAM06 == null;
                    case 89: // THVIEW_EXAM07
                        return CurrentItem.THVIEW_EXAM07 == null;
                    case 90: // THVIEW_EXAM08
                        return CurrentItem.THVIEW_EXAM08 == null;
                    case 91: // THVIEW_EXAM09
                        return CurrentItem.THVIEW_EXAM09 == null;
                    case 92: // THVIEW_EXAM10
                        return CurrentItem.THVIEW_EXAM10 == null;
                    case 93: // THVIEW_EXAM11
                        return CurrentItem.THVIEW_EXAM11 == null;
                    case 94: // THVIEW_EXAM12
                        return CurrentItem.THVIEW_EXAM12 == null;
                    case 95: // THVIEW_EXAM13
                        return CurrentItem.THVIEW_EXAM13 == null;
                    case 96: // CALENDAR_START01
                        return CurrentItem.CALENDAR_START01 == null;
                    case 97: // CALENDAR_START02
                        return CurrentItem.CALENDAR_START02 == null;
                    case 98: // CALENDAR_START03
                        return CurrentItem.CALENDAR_START03 == null;
                    case 99: // CALENDAR_START04
                        return CurrentItem.CALENDAR_START04 == null;
                    case 100: // CALENDAR_END01
                        return CurrentItem.CALENDAR_END01 == null;
                    case 101: // CALENDAR_END02
                        return CurrentItem.CALENDAR_END02 == null;
                    case 102: // CALENDAR_END03
                        return CurrentItem.CALENDAR_END03 == null;
                    case 103: // CALENDAR_END04
                        return CurrentItem.CALENDAR_END04 == null;
                    case 104: // CALENDAR_COLOUR
                        return CurrentItem.CALENDAR_COLOUR == null;
                    case 105: // CALENDAR_PLACE_METHOD
                        return CurrentItem.CALENDAR_PLACE_METHOD == null;
                    case 106: // CALENDAR_DAYS01
                        return CurrentItem.CALENDAR_DAYS01 == null;
                    case 107: // CALENDAR_DAYS02
                        return CurrentItem.CALENDAR_DAYS02 == null;
                    case 108: // CALENDAR_DAYS03
                        return CurrentItem.CALENDAR_DAYS03 == null;
                    case 109: // CALENDAR_DAYS04
                        return CurrentItem.CALENDAR_DAYS04 == null;
                    case 110: // CALENDAR_DAYS05
                        return CurrentItem.CALENDAR_DAYS05 == null;
                    case 111: // CALENDAR_DAYS06
                        return CurrentItem.CALENDAR_DAYS06 == null;
                    case 112: // CALENDAR_DAYS07
                        return CurrentItem.CALENDAR_DAYS07 == null;
                    case 113: // CALENDAR_ROW
                        return CurrentItem.CALENDAR_ROW == null;
                    case 114: // CALENDAR_VIEW
                        return CurrentItem.CALENDAR_VIEW == null;
                    case 115: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 116: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 117: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // THKEY
                        return "THKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // SELECTABLE
                        return "SELECTABLE";
                    case 3: // THROWS
                        return "THROWS";
                    case 4: // THCOLS
                        return "THCOLS";
                    case 5: // TH_RLABEL01
                        return "TH_RLABEL01";
                    case 6: // TH_RLABEL02
                        return "TH_RLABEL02";
                    case 7: // TH_RLABEL03
                        return "TH_RLABEL03";
                    case 8: // TH_RLABEL04
                        return "TH_RLABEL04";
                    case 9: // TH_RLABEL05
                        return "TH_RLABEL05";
                    case 10: // TH_RLABEL06
                        return "TH_RLABEL06";
                    case 11: // TH_RLABEL07
                        return "TH_RLABEL07";
                    case 12: // TH_RLABEL08
                        return "TH_RLABEL08";
                    case 13: // TH_RLABEL09
                        return "TH_RLABEL09";
                    case 14: // TH_RLABEL10
                        return "TH_RLABEL10";
                    case 15: // TH_RLABEL11
                        return "TH_RLABEL11";
                    case 16: // TH_RLABEL12
                        return "TH_RLABEL12";
                    case 17: // TH_CLABEL01
                        return "TH_CLABEL01";
                    case 18: // TH_CLABEL02
                        return "TH_CLABEL02";
                    case 19: // TH_CLABEL03
                        return "TH_CLABEL03";
                    case 20: // TH_CLABEL04
                        return "TH_CLABEL04";
                    case 21: // TH_CLABEL05
                        return "TH_CLABEL05";
                    case 22: // TH_CLABEL06
                        return "TH_CLABEL06";
                    case 23: // TH_CLABEL07
                        return "TH_CLABEL07";
                    case 24: // TH_CLABEL08
                        return "TH_CLABEL08";
                    case 25: // TH_CLABEL09
                        return "TH_CLABEL09";
                    case 26: // TH_CLABEL10
                        return "TH_CLABEL10";
                    case 27: // TH_CLABEL11
                        return "TH_CLABEL11";
                    case 28: // TH_CLABEL12
                        return "TH_CLABEL12";
                    case 29: // TH_CLABEL13
                        return "TH_CLABEL13";
                    case 30: // TH_CLABEL14
                        return "TH_CLABEL14";
                    case 31: // TH_CLABEL15
                        return "TH_CLABEL15";
                    case 32: // TEACHING_PERIOD01
                        return "TEACHING_PERIOD01";
                    case 33: // TEACHING_PERIOD02
                        return "TEACHING_PERIOD02";
                    case 34: // TEACHING_PERIOD03
                        return "TEACHING_PERIOD03";
                    case 35: // TEACHING_PERIOD04
                        return "TEACHING_PERIOD04";
                    case 36: // TEACHING_PERIOD05
                        return "TEACHING_PERIOD05";
                    case 37: // TEACHING_PERIOD06
                        return "TEACHING_PERIOD06";
                    case 38: // TEACHING_PERIOD07
                        return "TEACHING_PERIOD07";
                    case 39: // TEACHING_PERIOD08
                        return "TEACHING_PERIOD08";
                    case 40: // TEACHING_PERIOD09
                        return "TEACHING_PERIOD09";
                    case 41: // TEACHING_PERIOD10
                        return "TEACHING_PERIOD10";
                    case 42: // TEACHING_PERIOD11
                        return "TEACHING_PERIOD11";
                    case 43: // TEACHING_PERIOD12
                        return "TEACHING_PERIOD12";
                    case 44: // TT01KEY
                        return "TT01KEY";
                    case 45: // TT02KEY
                        return "TT02KEY";
                    case 46: // TT03KEY
                        return "TT03KEY";
                    case 47: // TT04KEY
                        return "TT04KEY";
                    case 48: // TT05KEY
                        return "TT05KEY";
                    case 49: // TT06KEY
                        return "TT06KEY";
                    case 50: // TT07KEY
                        return "TT07KEY";
                    case 51: // TT08KEY
                        return "TT08KEY";
                    case 52: // TT09KEY
                        return "TT09KEY";
                    case 53: // TT10KEY
                        return "TT10KEY";
                    case 54: // TT11KEY
                        return "TT11KEY";
                    case 55: // TT12KEY
                        return "TT12KEY";
                    case 56: // TT13KEY
                        return "TT13KEY";
                    case 57: // THVIEW_QUILT01
                        return "THVIEW_QUILT01";
                    case 58: // THVIEW_QUILT02
                        return "THVIEW_QUILT02";
                    case 59: // THVIEW_QUILT03
                        return "THVIEW_QUILT03";
                    case 60: // THVIEW_QUILT04
                        return "THVIEW_QUILT04";
                    case 61: // THVIEW_QUILT05
                        return "THVIEW_QUILT05";
                    case 62: // THVIEW_QUILT06
                        return "THVIEW_QUILT06";
                    case 63: // THVIEW_QUILT07
                        return "THVIEW_QUILT07";
                    case 64: // THVIEW_QUILT08
                        return "THVIEW_QUILT08";
                    case 65: // THVIEW_QUILT09
                        return "THVIEW_QUILT09";
                    case 66: // THVIEW_QUILT10
                        return "THVIEW_QUILT10";
                    case 67: // THVIEW_QUILT11
                        return "THVIEW_QUILT11";
                    case 68: // THVIEW_QUILT12
                        return "THVIEW_QUILT12";
                    case 69: // THVIEW_QUILT13
                        return "THVIEW_QUILT13";
                    case 70: // THVIEW_EXTRA01
                        return "THVIEW_EXTRA01";
                    case 71: // THVIEW_EXTRA02
                        return "THVIEW_EXTRA02";
                    case 72: // THVIEW_EXTRA03
                        return "THVIEW_EXTRA03";
                    case 73: // THVIEW_EXTRA04
                        return "THVIEW_EXTRA04";
                    case 74: // THVIEW_EXTRA05
                        return "THVIEW_EXTRA05";
                    case 75: // THVIEW_EXTRA06
                        return "THVIEW_EXTRA06";
                    case 76: // THVIEW_EXTRA07
                        return "THVIEW_EXTRA07";
                    case 77: // THVIEW_EXTRA08
                        return "THVIEW_EXTRA08";
                    case 78: // THVIEW_EXTRA09
                        return "THVIEW_EXTRA09";
                    case 79: // THVIEW_EXTRA10
                        return "THVIEW_EXTRA10";
                    case 80: // THVIEW_EXTRA11
                        return "THVIEW_EXTRA11";
                    case 81: // THVIEW_EXTRA12
                        return "THVIEW_EXTRA12";
                    case 82: // THVIEW_EXTRA13
                        return "THVIEW_EXTRA13";
                    case 83: // THVIEW_EXAM01
                        return "THVIEW_EXAM01";
                    case 84: // THVIEW_EXAM02
                        return "THVIEW_EXAM02";
                    case 85: // THVIEW_EXAM03
                        return "THVIEW_EXAM03";
                    case 86: // THVIEW_EXAM04
                        return "THVIEW_EXAM04";
                    case 87: // THVIEW_EXAM05
                        return "THVIEW_EXAM05";
                    case 88: // THVIEW_EXAM06
                        return "THVIEW_EXAM06";
                    case 89: // THVIEW_EXAM07
                        return "THVIEW_EXAM07";
                    case 90: // THVIEW_EXAM08
                        return "THVIEW_EXAM08";
                    case 91: // THVIEW_EXAM09
                        return "THVIEW_EXAM09";
                    case 92: // THVIEW_EXAM10
                        return "THVIEW_EXAM10";
                    case 93: // THVIEW_EXAM11
                        return "THVIEW_EXAM11";
                    case 94: // THVIEW_EXAM12
                        return "THVIEW_EXAM12";
                    case 95: // THVIEW_EXAM13
                        return "THVIEW_EXAM13";
                    case 96: // CALENDAR_START01
                        return "CALENDAR_START01";
                    case 97: // CALENDAR_START02
                        return "CALENDAR_START02";
                    case 98: // CALENDAR_START03
                        return "CALENDAR_START03";
                    case 99: // CALENDAR_START04
                        return "CALENDAR_START04";
                    case 100: // CALENDAR_END01
                        return "CALENDAR_END01";
                    case 101: // CALENDAR_END02
                        return "CALENDAR_END02";
                    case 102: // CALENDAR_END03
                        return "CALENDAR_END03";
                    case 103: // CALENDAR_END04
                        return "CALENDAR_END04";
                    case 104: // CALENDAR_COLOUR
                        return "CALENDAR_COLOUR";
                    case 105: // CALENDAR_PLACE_METHOD
                        return "CALENDAR_PLACE_METHOD";
                    case 106: // CALENDAR_DAYS01
                        return "CALENDAR_DAYS01";
                    case 107: // CALENDAR_DAYS02
                        return "CALENDAR_DAYS02";
                    case 108: // CALENDAR_DAYS03
                        return "CALENDAR_DAYS03";
                    case 109: // CALENDAR_DAYS04
                        return "CALENDAR_DAYS04";
                    case 110: // CALENDAR_DAYS05
                        return "CALENDAR_DAYS05";
                    case 111: // CALENDAR_DAYS06
                        return "CALENDAR_DAYS06";
                    case 112: // CALENDAR_DAYS07
                        return "CALENDAR_DAYS07";
                    case 113: // CALENDAR_ROW
                        return "CALENDAR_ROW";
                    case 114: // CALENDAR_VIEW
                        return "CALENDAR_VIEW";
                    case 115: // LW_DATE
                        return "LW_DATE";
                    case 116: // LW_TIME
                        return "LW_TIME";
                    case 117: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "THKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "SELECTABLE":
                        return 2;
                    case "THROWS":
                        return 3;
                    case "THCOLS":
                        return 4;
                    case "TH_RLABEL01":
                        return 5;
                    case "TH_RLABEL02":
                        return 6;
                    case "TH_RLABEL03":
                        return 7;
                    case "TH_RLABEL04":
                        return 8;
                    case "TH_RLABEL05":
                        return 9;
                    case "TH_RLABEL06":
                        return 10;
                    case "TH_RLABEL07":
                        return 11;
                    case "TH_RLABEL08":
                        return 12;
                    case "TH_RLABEL09":
                        return 13;
                    case "TH_RLABEL10":
                        return 14;
                    case "TH_RLABEL11":
                        return 15;
                    case "TH_RLABEL12":
                        return 16;
                    case "TH_CLABEL01":
                        return 17;
                    case "TH_CLABEL02":
                        return 18;
                    case "TH_CLABEL03":
                        return 19;
                    case "TH_CLABEL04":
                        return 20;
                    case "TH_CLABEL05":
                        return 21;
                    case "TH_CLABEL06":
                        return 22;
                    case "TH_CLABEL07":
                        return 23;
                    case "TH_CLABEL08":
                        return 24;
                    case "TH_CLABEL09":
                        return 25;
                    case "TH_CLABEL10":
                        return 26;
                    case "TH_CLABEL11":
                        return 27;
                    case "TH_CLABEL12":
                        return 28;
                    case "TH_CLABEL13":
                        return 29;
                    case "TH_CLABEL14":
                        return 30;
                    case "TH_CLABEL15":
                        return 31;
                    case "TEACHING_PERIOD01":
                        return 32;
                    case "TEACHING_PERIOD02":
                        return 33;
                    case "TEACHING_PERIOD03":
                        return 34;
                    case "TEACHING_PERIOD04":
                        return 35;
                    case "TEACHING_PERIOD05":
                        return 36;
                    case "TEACHING_PERIOD06":
                        return 37;
                    case "TEACHING_PERIOD07":
                        return 38;
                    case "TEACHING_PERIOD08":
                        return 39;
                    case "TEACHING_PERIOD09":
                        return 40;
                    case "TEACHING_PERIOD10":
                        return 41;
                    case "TEACHING_PERIOD11":
                        return 42;
                    case "TEACHING_PERIOD12":
                        return 43;
                    case "TT01KEY":
                        return 44;
                    case "TT02KEY":
                        return 45;
                    case "TT03KEY":
                        return 46;
                    case "TT04KEY":
                        return 47;
                    case "TT05KEY":
                        return 48;
                    case "TT06KEY":
                        return 49;
                    case "TT07KEY":
                        return 50;
                    case "TT08KEY":
                        return 51;
                    case "TT09KEY":
                        return 52;
                    case "TT10KEY":
                        return 53;
                    case "TT11KEY":
                        return 54;
                    case "TT12KEY":
                        return 55;
                    case "TT13KEY":
                        return 56;
                    case "THVIEW_QUILT01":
                        return 57;
                    case "THVIEW_QUILT02":
                        return 58;
                    case "THVIEW_QUILT03":
                        return 59;
                    case "THVIEW_QUILT04":
                        return 60;
                    case "THVIEW_QUILT05":
                        return 61;
                    case "THVIEW_QUILT06":
                        return 62;
                    case "THVIEW_QUILT07":
                        return 63;
                    case "THVIEW_QUILT08":
                        return 64;
                    case "THVIEW_QUILT09":
                        return 65;
                    case "THVIEW_QUILT10":
                        return 66;
                    case "THVIEW_QUILT11":
                        return 67;
                    case "THVIEW_QUILT12":
                        return 68;
                    case "THVIEW_QUILT13":
                        return 69;
                    case "THVIEW_EXTRA01":
                        return 70;
                    case "THVIEW_EXTRA02":
                        return 71;
                    case "THVIEW_EXTRA03":
                        return 72;
                    case "THVIEW_EXTRA04":
                        return 73;
                    case "THVIEW_EXTRA05":
                        return 74;
                    case "THVIEW_EXTRA06":
                        return 75;
                    case "THVIEW_EXTRA07":
                        return 76;
                    case "THVIEW_EXTRA08":
                        return 77;
                    case "THVIEW_EXTRA09":
                        return 78;
                    case "THVIEW_EXTRA10":
                        return 79;
                    case "THVIEW_EXTRA11":
                        return 80;
                    case "THVIEW_EXTRA12":
                        return 81;
                    case "THVIEW_EXTRA13":
                        return 82;
                    case "THVIEW_EXAM01":
                        return 83;
                    case "THVIEW_EXAM02":
                        return 84;
                    case "THVIEW_EXAM03":
                        return 85;
                    case "THVIEW_EXAM04":
                        return 86;
                    case "THVIEW_EXAM05":
                        return 87;
                    case "THVIEW_EXAM06":
                        return 88;
                    case "THVIEW_EXAM07":
                        return 89;
                    case "THVIEW_EXAM08":
                        return 90;
                    case "THVIEW_EXAM09":
                        return 91;
                    case "THVIEW_EXAM10":
                        return 92;
                    case "THVIEW_EXAM11":
                        return 93;
                    case "THVIEW_EXAM12":
                        return 94;
                    case "THVIEW_EXAM13":
                        return 95;
                    case "CALENDAR_START01":
                        return 96;
                    case "CALENDAR_START02":
                        return 97;
                    case "CALENDAR_START03":
                        return 98;
                    case "CALENDAR_START04":
                        return 99;
                    case "CALENDAR_END01":
                        return 100;
                    case "CALENDAR_END02":
                        return 101;
                    case "CALENDAR_END03":
                        return 102;
                    case "CALENDAR_END04":
                        return 103;
                    case "CALENDAR_COLOUR":
                        return 104;
                    case "CALENDAR_PLACE_METHOD":
                        return 105;
                    case "CALENDAR_DAYS01":
                        return 106;
                    case "CALENDAR_DAYS02":
                        return 107;
                    case "CALENDAR_DAYS03":
                        return 108;
                    case "CALENDAR_DAYS04":
                        return 109;
                    case "CALENDAR_DAYS05":
                        return 110;
                    case "CALENDAR_DAYS06":
                        return 111;
                    case "CALENDAR_DAYS07":
                        return 112;
                    case "CALENDAR_ROW":
                        return 113;
                    case "CALENDAR_VIEW":
                        return 114;
                    case "LW_DATE":
                        return 115;
                    case "LW_TIME":
                        return 116;
                    case "LW_USER":
                        return 117;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
