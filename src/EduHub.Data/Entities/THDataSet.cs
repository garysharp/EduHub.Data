using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Headers Data Set
    /// </summary>
    public sealed class THDataSet : SetBase<TH>
    {
        private Lazy<Dictionary<string, TH>> THKEYIndex;

        internal THDataSet(EduHubContext Context)
            : base(Context)
        {
            THKEYIndex = new Lazy<Dictionary<string, TH>>(() => this.ToDictionary(e => e.THKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TH"; } }

        /// <summary>
        /// Find TH by THKEY key field
        /// </summary>
        /// <param name="Key">THKEY value used to find TH</param>
        /// <returns>Related TH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">THKEY value didn't match any TH entities</exception>
        public TH FindByTHKEY(string Key)
        {
            TH result;
            if (THKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TH by THKEY key field
        /// </summary>
        /// <param name="Key">THKEY value used to find TH</param>
        /// <param name="Value">Related TH entity</param>
        /// <returns>True if the TH entity is found</returns>
        public bool TryFindByTHKEY(string Key, out TH Value)
        {
            return THKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TH by THKEY key field
        /// </summary>
        /// <param name="Key">THKEY value used to find TH</param>
        /// <returns>Related TH entity, or null if not found</returns>
        public TH TryFindByTHKEY(string Key)
        {
            TH result;
            if (THKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
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
    }
}
