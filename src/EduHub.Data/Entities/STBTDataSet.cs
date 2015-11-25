using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Usage Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STBTDataSet : SetBase<STBT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STBT"; } }

        internal STBTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AM1_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM1_ROUTE));
            Index_AM1_SD_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM1_SD_SITE));
            Index_AM2_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM2_ROUTE));
            Index_AM2_SD_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM2_SD_SITE));
            Index_AM3_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM3_ROUTE));
            Index_AM3_SD_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM3_SD_SITE));
            Index_AM4_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM4_ROUTE));
            Index_AM4_SD_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM4_SD_SITE));
            Index_AM5_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM5_ROUTE));
            Index_AM5_SD_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.AM5_SD_SITE));
            Index_PM1_PU_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM1_PU_SITE));
            Index_PM1_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM1_ROUTE));
            Index_PM2_PU_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM2_PU_SITE));
            Index_PM2_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM2_ROUTE));
            Index_PM3_PU_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM3_PU_SITE));
            Index_PM3_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM3_ROUTE));
            Index_PM4_PU_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM4_PU_SITE));
            Index_PM4_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM4_ROUTE));
            Index_PM5_PU_SITE = new Lazy<NullDictionary<int?, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM5_PU_SITE));
            Index_PM5_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.PM5_ROUTE));
            Index_ROUTE = new Lazy<NullDictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedNullDictionary(i => i.ROUTE));
            Index_STBTKEY = new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() => this.ToGroupedDictionary(i => i.STBTKEY));
            Index_TID = new Lazy<Dictionary<int, STBT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STBT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STBT" /> fields for each CSV column header</returns>
        protected override Action<STBT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STBT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STBTKEY":
                        mapper[i] = (e, v) => e.STBTKEY = v;
                        break;
                    case "ROUTE":
                        mapper[i] = (e, v) => e.ROUTE = v;
                        break;
                    case "DAYS_USED01":
                        mapper[i] = (e, v) => e.DAYS_USED01 = v;
                        break;
                    case "DAYS_USED02":
                        mapper[i] = (e, v) => e.DAYS_USED02 = v;
                        break;
                    case "DAYS_USED03":
                        mapper[i] = (e, v) => e.DAYS_USED03 = v;
                        break;
                    case "DAYS_USED04":
                        mapper[i] = (e, v) => e.DAYS_USED04 = v;
                        break;
                    case "DAYS_USED05":
                        mapper[i] = (e, v) => e.DAYS_USED05 = v;
                        break;
                    case "TRANSPORT_NOTES":
                        mapper[i] = (e, v) => e.TRANSPORT_NOTES = v;
                        break;
                    case "DATE_STARTED":
                        mapper[i] = (e, v) => e.DATE_STARTED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TERMINATED":
                        mapper[i] = (e, v) => e.TERMINATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AM1_PICKUP":
                        mapper[i] = (e, v) => e.AM1_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM1_PU_SITE":
                        mapper[i] = (e, v) => e.AM1_PU_SITE = v;
                        break;
                    case "AM1_SETDOWN":
                        mapper[i] = (e, v) => e.AM1_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM1_SD_SITE":
                        mapper[i] = (e, v) => e.AM1_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM1_ROUTE":
                        mapper[i] = (e, v) => e.AM1_ROUTE = v;
                        break;
                    case "PM1_PICKUP":
                        mapper[i] = (e, v) => e.PM1_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM1_PU_SITE":
                        mapper[i] = (e, v) => e.PM1_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM1_SETDOWN":
                        mapper[i] = (e, v) => e.PM1_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM1_SD_SITE":
                        mapper[i] = (e, v) => e.PM1_SD_SITE = v;
                        break;
                    case "PM1_ROUTE":
                        mapper[i] = (e, v) => e.PM1_ROUTE = v;
                        break;
                    case "AM2_PICKUP":
                        mapper[i] = (e, v) => e.AM2_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM2_PU_SITE":
                        mapper[i] = (e, v) => e.AM2_PU_SITE = v;
                        break;
                    case "AM2_SETDOWN":
                        mapper[i] = (e, v) => e.AM2_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM2_SD_SITE":
                        mapper[i] = (e, v) => e.AM2_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM2_ROUTE":
                        mapper[i] = (e, v) => e.AM2_ROUTE = v;
                        break;
                    case "PM2_PICKUP":
                        mapper[i] = (e, v) => e.PM2_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM2_PU_SITE":
                        mapper[i] = (e, v) => e.PM2_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM2_SETDOWN":
                        mapper[i] = (e, v) => e.PM2_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM2_SD_SITE":
                        mapper[i] = (e, v) => e.PM2_SD_SITE = v;
                        break;
                    case "PM2_ROUTE":
                        mapper[i] = (e, v) => e.PM2_ROUTE = v;
                        break;
                    case "AM3_PICKUP":
                        mapper[i] = (e, v) => e.AM3_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM3_PU_SITE":
                        mapper[i] = (e, v) => e.AM3_PU_SITE = v;
                        break;
                    case "AM3_SETDOWN":
                        mapper[i] = (e, v) => e.AM3_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM3_SD_SITE":
                        mapper[i] = (e, v) => e.AM3_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM3_ROUTE":
                        mapper[i] = (e, v) => e.AM3_ROUTE = v;
                        break;
                    case "PM3_PICKUP":
                        mapper[i] = (e, v) => e.PM3_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM3_PU_SITE":
                        mapper[i] = (e, v) => e.PM3_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM3_SETDOWN":
                        mapper[i] = (e, v) => e.PM3_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM3_SD_SITE":
                        mapper[i] = (e, v) => e.PM3_SD_SITE = v;
                        break;
                    case "PM3_ROUTE":
                        mapper[i] = (e, v) => e.PM3_ROUTE = v;
                        break;
                    case "AM4_PICKUP":
                        mapper[i] = (e, v) => e.AM4_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM4_PU_SITE":
                        mapper[i] = (e, v) => e.AM4_PU_SITE = v;
                        break;
                    case "AM4_SETDOWN":
                        mapper[i] = (e, v) => e.AM4_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM4_SD_SITE":
                        mapper[i] = (e, v) => e.AM4_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM4_ROUTE":
                        mapper[i] = (e, v) => e.AM4_ROUTE = v;
                        break;
                    case "PM4_PICKUP":
                        mapper[i] = (e, v) => e.PM4_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM4_PU_SITE":
                        mapper[i] = (e, v) => e.PM4_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM4_SETDOWN":
                        mapper[i] = (e, v) => e.PM4_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM4_SD_SITE":
                        mapper[i] = (e, v) => e.PM4_SD_SITE = v;
                        break;
                    case "PM4_ROUTE":
                        mapper[i] = (e, v) => e.PM4_ROUTE = v;
                        break;
                    case "AM5_PICKUP":
                        mapper[i] = (e, v) => e.AM5_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM5_PU_SITE":
                        mapper[i] = (e, v) => e.AM5_PU_SITE = v;
                        break;
                    case "AM5_SETDOWN":
                        mapper[i] = (e, v) => e.AM5_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM5_SD_SITE":
                        mapper[i] = (e, v) => e.AM5_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM5_ROUTE":
                        mapper[i] = (e, v) => e.AM5_ROUTE = v;
                        break;
                    case "PM5_PICKUP":
                        mapper[i] = (e, v) => e.PM5_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM5_PU_SITE":
                        mapper[i] = (e, v) => e.PM5_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM5_SETDOWN":
                        mapper[i] = (e, v) => e.PM5_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM5_SD_SITE":
                        mapper[i] = (e, v) => e.PM5_SD_SITE = v;
                        break;
                    case "PM5_ROUTE":
                        mapper[i] = (e, v) => e.PM5_ROUTE = v;
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
        /// Merges <see cref="STBT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="STBT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="STBT" /> items to added or update the base <see cref="STBT" /> items</param>
        /// <returns>A merged list of <see cref="STBT" /> items</returns>
        protected override List<STBT> ApplyDeltaItems(List<STBT> Items, List<STBT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (STBT deltaItem in DeltaItems)
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
                .OrderBy(i => i.STBTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_AM1_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_AM1_SD_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_AM2_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_AM2_SD_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_AM3_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_AM3_SD_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_AM4_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_AM4_SD_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_AM5_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_AM5_SD_SITE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_PM1_PU_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_PM1_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_PM2_PU_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_PM2_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_PM3_PU_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_PM3_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_PM4_PU_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_PM4_ROUTE;
        private Lazy<NullDictionary<int?, IReadOnlyList<STBT>>> Index_PM5_PU_SITE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_PM5_ROUTE;
        private Lazy<NullDictionary<string, IReadOnlyList<STBT>>> Index_ROUTE;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> Index_STBTKEY;
        private Lazy<Dictionary<int, STBT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STBT by AM1_ROUTE field
        /// </summary>
        /// <param name="AM1_ROUTE">AM1_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM1_ROUTE(string AM1_ROUTE)
        {
            return Index_AM1_ROUTE.Value[AM1_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by AM1_ROUTE field
        /// </summary>
        /// <param name="AM1_ROUTE">AM1_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM1_ROUTE(string AM1_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM1_ROUTE.Value.TryGetValue(AM1_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM1_ROUTE field
        /// </summary>
        /// <param name="AM1_ROUTE">AM1_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM1_ROUTE(string AM1_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM1_ROUTE.Value.TryGetValue(AM1_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM1_SD_SITE field
        /// </summary>
        /// <param name="AM1_SD_SITE">AM1_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM1_SD_SITE(int? AM1_SD_SITE)
        {
            return Index_AM1_SD_SITE.Value[AM1_SD_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by AM1_SD_SITE field
        /// </summary>
        /// <param name="AM1_SD_SITE">AM1_SD_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM1_SD_SITE(int? AM1_SD_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM1_SD_SITE.Value.TryGetValue(AM1_SD_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM1_SD_SITE field
        /// </summary>
        /// <param name="AM1_SD_SITE">AM1_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM1_SD_SITE(int? AM1_SD_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM1_SD_SITE.Value.TryGetValue(AM1_SD_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM2_ROUTE field
        /// </summary>
        /// <param name="AM2_ROUTE">AM2_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM2_ROUTE(string AM2_ROUTE)
        {
            return Index_AM2_ROUTE.Value[AM2_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by AM2_ROUTE field
        /// </summary>
        /// <param name="AM2_ROUTE">AM2_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM2_ROUTE(string AM2_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM2_ROUTE.Value.TryGetValue(AM2_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM2_ROUTE field
        /// </summary>
        /// <param name="AM2_ROUTE">AM2_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM2_ROUTE(string AM2_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM2_ROUTE.Value.TryGetValue(AM2_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM2_SD_SITE field
        /// </summary>
        /// <param name="AM2_SD_SITE">AM2_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM2_SD_SITE(int? AM2_SD_SITE)
        {
            return Index_AM2_SD_SITE.Value[AM2_SD_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by AM2_SD_SITE field
        /// </summary>
        /// <param name="AM2_SD_SITE">AM2_SD_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM2_SD_SITE(int? AM2_SD_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM2_SD_SITE.Value.TryGetValue(AM2_SD_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM2_SD_SITE field
        /// </summary>
        /// <param name="AM2_SD_SITE">AM2_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM2_SD_SITE(int? AM2_SD_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM2_SD_SITE.Value.TryGetValue(AM2_SD_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM3_ROUTE field
        /// </summary>
        /// <param name="AM3_ROUTE">AM3_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM3_ROUTE(string AM3_ROUTE)
        {
            return Index_AM3_ROUTE.Value[AM3_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by AM3_ROUTE field
        /// </summary>
        /// <param name="AM3_ROUTE">AM3_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM3_ROUTE(string AM3_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM3_ROUTE.Value.TryGetValue(AM3_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM3_ROUTE field
        /// </summary>
        /// <param name="AM3_ROUTE">AM3_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM3_ROUTE(string AM3_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM3_ROUTE.Value.TryGetValue(AM3_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM3_SD_SITE field
        /// </summary>
        /// <param name="AM3_SD_SITE">AM3_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM3_SD_SITE(int? AM3_SD_SITE)
        {
            return Index_AM3_SD_SITE.Value[AM3_SD_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by AM3_SD_SITE field
        /// </summary>
        /// <param name="AM3_SD_SITE">AM3_SD_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM3_SD_SITE(int? AM3_SD_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM3_SD_SITE.Value.TryGetValue(AM3_SD_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM3_SD_SITE field
        /// </summary>
        /// <param name="AM3_SD_SITE">AM3_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM3_SD_SITE(int? AM3_SD_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM3_SD_SITE.Value.TryGetValue(AM3_SD_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM4_ROUTE field
        /// </summary>
        /// <param name="AM4_ROUTE">AM4_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM4_ROUTE(string AM4_ROUTE)
        {
            return Index_AM4_ROUTE.Value[AM4_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by AM4_ROUTE field
        /// </summary>
        /// <param name="AM4_ROUTE">AM4_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM4_ROUTE(string AM4_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM4_ROUTE.Value.TryGetValue(AM4_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM4_ROUTE field
        /// </summary>
        /// <param name="AM4_ROUTE">AM4_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM4_ROUTE(string AM4_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM4_ROUTE.Value.TryGetValue(AM4_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM4_SD_SITE field
        /// </summary>
        /// <param name="AM4_SD_SITE">AM4_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM4_SD_SITE(int? AM4_SD_SITE)
        {
            return Index_AM4_SD_SITE.Value[AM4_SD_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by AM4_SD_SITE field
        /// </summary>
        /// <param name="AM4_SD_SITE">AM4_SD_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM4_SD_SITE(int? AM4_SD_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM4_SD_SITE.Value.TryGetValue(AM4_SD_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM4_SD_SITE field
        /// </summary>
        /// <param name="AM4_SD_SITE">AM4_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM4_SD_SITE(int? AM4_SD_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM4_SD_SITE.Value.TryGetValue(AM4_SD_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM5_ROUTE field
        /// </summary>
        /// <param name="AM5_ROUTE">AM5_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM5_ROUTE(string AM5_ROUTE)
        {
            return Index_AM5_ROUTE.Value[AM5_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by AM5_ROUTE field
        /// </summary>
        /// <param name="AM5_ROUTE">AM5_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM5_ROUTE(string AM5_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM5_ROUTE.Value.TryGetValue(AM5_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM5_ROUTE field
        /// </summary>
        /// <param name="AM5_ROUTE">AM5_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM5_ROUTE(string AM5_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM5_ROUTE.Value.TryGetValue(AM5_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by AM5_SD_SITE field
        /// </summary>
        /// <param name="AM5_SD_SITE">AM5_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByAM5_SD_SITE(int? AM5_SD_SITE)
        {
            return Index_AM5_SD_SITE.Value[AM5_SD_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by AM5_SD_SITE field
        /// </summary>
        /// <param name="AM5_SD_SITE">AM5_SD_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM5_SD_SITE(int? AM5_SD_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_AM5_SD_SITE.Value.TryGetValue(AM5_SD_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by AM5_SD_SITE field
        /// </summary>
        /// <param name="AM5_SD_SITE">AM5_SD_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByAM5_SD_SITE(int? AM5_SD_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_AM5_SD_SITE.Value.TryGetValue(AM5_SD_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM1_PU_SITE field
        /// </summary>
        /// <param name="PM1_PU_SITE">PM1_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM1_PU_SITE(int? PM1_PU_SITE)
        {
            return Index_PM1_PU_SITE.Value[PM1_PU_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by PM1_PU_SITE field
        /// </summary>
        /// <param name="PM1_PU_SITE">PM1_PU_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM1_PU_SITE(int? PM1_PU_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM1_PU_SITE.Value.TryGetValue(PM1_PU_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM1_PU_SITE field
        /// </summary>
        /// <param name="PM1_PU_SITE">PM1_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM1_PU_SITE(int? PM1_PU_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM1_PU_SITE.Value.TryGetValue(PM1_PU_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM1_ROUTE field
        /// </summary>
        /// <param name="PM1_ROUTE">PM1_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM1_ROUTE(string PM1_ROUTE)
        {
            return Index_PM1_ROUTE.Value[PM1_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by PM1_ROUTE field
        /// </summary>
        /// <param name="PM1_ROUTE">PM1_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM1_ROUTE(string PM1_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM1_ROUTE.Value.TryGetValue(PM1_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM1_ROUTE field
        /// </summary>
        /// <param name="PM1_ROUTE">PM1_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM1_ROUTE(string PM1_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM1_ROUTE.Value.TryGetValue(PM1_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM2_PU_SITE field
        /// </summary>
        /// <param name="PM2_PU_SITE">PM2_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM2_PU_SITE(int? PM2_PU_SITE)
        {
            return Index_PM2_PU_SITE.Value[PM2_PU_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by PM2_PU_SITE field
        /// </summary>
        /// <param name="PM2_PU_SITE">PM2_PU_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM2_PU_SITE(int? PM2_PU_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM2_PU_SITE.Value.TryGetValue(PM2_PU_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM2_PU_SITE field
        /// </summary>
        /// <param name="PM2_PU_SITE">PM2_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM2_PU_SITE(int? PM2_PU_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM2_PU_SITE.Value.TryGetValue(PM2_PU_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM2_ROUTE field
        /// </summary>
        /// <param name="PM2_ROUTE">PM2_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM2_ROUTE(string PM2_ROUTE)
        {
            return Index_PM2_ROUTE.Value[PM2_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by PM2_ROUTE field
        /// </summary>
        /// <param name="PM2_ROUTE">PM2_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM2_ROUTE(string PM2_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM2_ROUTE.Value.TryGetValue(PM2_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM2_ROUTE field
        /// </summary>
        /// <param name="PM2_ROUTE">PM2_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM2_ROUTE(string PM2_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM2_ROUTE.Value.TryGetValue(PM2_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM3_PU_SITE field
        /// </summary>
        /// <param name="PM3_PU_SITE">PM3_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM3_PU_SITE(int? PM3_PU_SITE)
        {
            return Index_PM3_PU_SITE.Value[PM3_PU_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by PM3_PU_SITE field
        /// </summary>
        /// <param name="PM3_PU_SITE">PM3_PU_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM3_PU_SITE(int? PM3_PU_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM3_PU_SITE.Value.TryGetValue(PM3_PU_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM3_PU_SITE field
        /// </summary>
        /// <param name="PM3_PU_SITE">PM3_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM3_PU_SITE(int? PM3_PU_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM3_PU_SITE.Value.TryGetValue(PM3_PU_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM3_ROUTE field
        /// </summary>
        /// <param name="PM3_ROUTE">PM3_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM3_ROUTE(string PM3_ROUTE)
        {
            return Index_PM3_ROUTE.Value[PM3_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by PM3_ROUTE field
        /// </summary>
        /// <param name="PM3_ROUTE">PM3_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM3_ROUTE(string PM3_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM3_ROUTE.Value.TryGetValue(PM3_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM3_ROUTE field
        /// </summary>
        /// <param name="PM3_ROUTE">PM3_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM3_ROUTE(string PM3_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM3_ROUTE.Value.TryGetValue(PM3_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM4_PU_SITE field
        /// </summary>
        /// <param name="PM4_PU_SITE">PM4_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM4_PU_SITE(int? PM4_PU_SITE)
        {
            return Index_PM4_PU_SITE.Value[PM4_PU_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by PM4_PU_SITE field
        /// </summary>
        /// <param name="PM4_PU_SITE">PM4_PU_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM4_PU_SITE(int? PM4_PU_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM4_PU_SITE.Value.TryGetValue(PM4_PU_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM4_PU_SITE field
        /// </summary>
        /// <param name="PM4_PU_SITE">PM4_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM4_PU_SITE(int? PM4_PU_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM4_PU_SITE.Value.TryGetValue(PM4_PU_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM4_ROUTE field
        /// </summary>
        /// <param name="PM4_ROUTE">PM4_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM4_ROUTE(string PM4_ROUTE)
        {
            return Index_PM4_ROUTE.Value[PM4_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by PM4_ROUTE field
        /// </summary>
        /// <param name="PM4_ROUTE">PM4_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM4_ROUTE(string PM4_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM4_ROUTE.Value.TryGetValue(PM4_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM4_ROUTE field
        /// </summary>
        /// <param name="PM4_ROUTE">PM4_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM4_ROUTE(string PM4_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM4_ROUTE.Value.TryGetValue(PM4_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM5_PU_SITE field
        /// </summary>
        /// <param name="PM5_PU_SITE">PM5_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM5_PU_SITE(int? PM5_PU_SITE)
        {
            return Index_PM5_PU_SITE.Value[PM5_PU_SITE];
        }

        /// <summary>
        /// Attempt to find STBT by PM5_PU_SITE field
        /// </summary>
        /// <param name="PM5_PU_SITE">PM5_PU_SITE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM5_PU_SITE(int? PM5_PU_SITE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM5_PU_SITE.Value.TryGetValue(PM5_PU_SITE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM5_PU_SITE field
        /// </summary>
        /// <param name="PM5_PU_SITE">PM5_PU_SITE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM5_PU_SITE(int? PM5_PU_SITE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM5_PU_SITE.Value.TryGetValue(PM5_PU_SITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by PM5_ROUTE field
        /// </summary>
        /// <param name="PM5_ROUTE">PM5_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByPM5_ROUTE(string PM5_ROUTE)
        {
            return Index_PM5_ROUTE.Value[PM5_ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by PM5_ROUTE field
        /// </summary>
        /// <param name="PM5_ROUTE">PM5_ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM5_ROUTE(string PM5_ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_PM5_ROUTE.Value.TryGetValue(PM5_ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by PM5_ROUTE field
        /// </summary>
        /// <param name="PM5_ROUTE">PM5_ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByPM5_ROUTE(string PM5_ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_PM5_ROUTE.Value.TryGetValue(PM5_ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by ROUTE field
        /// </summary>
        /// <param name="ROUTE">ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindByROUTE(string ROUTE)
        {
            return Index_ROUTE.Value[ROUTE];
        }

        /// <summary>
        /// Attempt to find STBT by ROUTE field
        /// </summary>
        /// <param name="ROUTE">ROUTE value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROUTE(string ROUTE, out IReadOnlyList<STBT> Value)
        {
            return Index_ROUTE.Value.TryGetValue(ROUTE, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by ROUTE field
        /// </summary>
        /// <param name="ROUTE">ROUTE value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindByROUTE(string ROUTE)
        {
            IReadOnlyList<STBT> value;
            if (Index_ROUTE.Value.TryGetValue(ROUTE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by STBTKEY field
        /// </summary>
        /// <param name="STBTKEY">STBTKEY value used to find STBT</param>
        /// <returns>List of related STBT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> FindBySTBTKEY(string STBTKEY)
        {
            return Index_STBTKEY.Value[STBTKEY];
        }

        /// <summary>
        /// Attempt to find STBT by STBTKEY field
        /// </summary>
        /// <param name="STBTKEY">STBTKEY value used to find STBT</param>
        /// <param name="Value">List of related STBT entities</param>
        /// <returns>True if the list of related STBT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTBTKEY(string STBTKEY, out IReadOnlyList<STBT> Value)
        {
            return Index_STBTKEY.Value.TryGetValue(STBTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by STBTKEY field
        /// </summary>
        /// <param name="STBTKEY">STBTKEY value used to find STBT</param>
        /// <returns>List of related STBT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STBT> TryFindBySTBTKEY(string STBTKEY)
        {
            IReadOnlyList<STBT> value;
            if (Index_STBTKEY.Value.TryGetValue(STBTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STBT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STBT</param>
        /// <returns>Related STBT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STBT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STBT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STBT</param>
        /// <param name="Value">Related STBT entity</param>
        /// <returns>True if the related STBT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STBT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STBT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STBT</param>
        /// <returns>Related STBT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STBT TryFindByTID(int TID)
        {
            STBT value;
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
