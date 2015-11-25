using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Headers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THDataSet : SetBase<TH>
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

    }
}
