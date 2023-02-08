#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Usage Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STBTDataSet : EduHubDataSet<STBT>
    {
        /// <inheritdoc />
        public override string Name { get { return "STBT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

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
        internal override Action<STBT, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.DATE_STARTED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TERMINATED":
                        mapper[i] = (e, v) => e.TERMINATED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// <param name="Entities">Iterator for base <see cref="STBT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STBT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STBT}"/> of entities</returns>
        internal override IEnumerable<STBT> ApplyDeltaEntities(IEnumerable<STBT> Entities, List<STBT> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.STBTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.STBTKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
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

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STBT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STBT](
        [TID] int IDENTITY NOT NULL,
        [STBTKEY] varchar(10) NOT NULL,
        [ROUTE] varchar(6) NULL,
        [DAYS_USED01] varchar(1) NULL,
        [DAYS_USED02] varchar(1) NULL,
        [DAYS_USED03] varchar(1) NULL,
        [DAYS_USED04] varchar(1) NULL,
        [DAYS_USED05] varchar(1) NULL,
        [TRANSPORT_NOTES] varchar(MAX) NULL,
        [DATE_STARTED] datetime NULL,
        [TERMINATED] datetime NULL,
        [AM1_PICKUP] smallint NULL,
        [AM1_PU_SITE] varchar(4) NULL,
        [AM1_SETDOWN] smallint NULL,
        [AM1_SD_SITE] int NULL,
        [AM1_ROUTE] varchar(6) NULL,
        [PM1_PICKUP] smallint NULL,
        [PM1_PU_SITE] int NULL,
        [PM1_SETDOWN] smallint NULL,
        [PM1_SD_SITE] varchar(4) NULL,
        [PM1_ROUTE] varchar(6) NULL,
        [AM2_PICKUP] smallint NULL,
        [AM2_PU_SITE] varchar(4) NULL,
        [AM2_SETDOWN] smallint NULL,
        [AM2_SD_SITE] int NULL,
        [AM2_ROUTE] varchar(6) NULL,
        [PM2_PICKUP] smallint NULL,
        [PM2_PU_SITE] int NULL,
        [PM2_SETDOWN] smallint NULL,
        [PM2_SD_SITE] varchar(4) NULL,
        [PM2_ROUTE] varchar(6) NULL,
        [AM3_PICKUP] smallint NULL,
        [AM3_PU_SITE] varchar(4) NULL,
        [AM3_SETDOWN] smallint NULL,
        [AM3_SD_SITE] int NULL,
        [AM3_ROUTE] varchar(6) NULL,
        [PM3_PICKUP] smallint NULL,
        [PM3_PU_SITE] int NULL,
        [PM3_SETDOWN] smallint NULL,
        [PM3_SD_SITE] varchar(4) NULL,
        [PM3_ROUTE] varchar(6) NULL,
        [AM4_PICKUP] smallint NULL,
        [AM4_PU_SITE] varchar(4) NULL,
        [AM4_SETDOWN] smallint NULL,
        [AM4_SD_SITE] int NULL,
        [AM4_ROUTE] varchar(6) NULL,
        [PM4_PICKUP] smallint NULL,
        [PM4_PU_SITE] int NULL,
        [PM4_SETDOWN] smallint NULL,
        [PM4_SD_SITE] varchar(4) NULL,
        [PM4_ROUTE] varchar(6) NULL,
        [AM5_PICKUP] smallint NULL,
        [AM5_PU_SITE] varchar(4) NULL,
        [AM5_SETDOWN] smallint NULL,
        [AM5_SD_SITE] int NULL,
        [AM5_ROUTE] varchar(6) NULL,
        [PM5_PICKUP] smallint NULL,
        [PM5_PU_SITE] int NULL,
        [PM5_SETDOWN] smallint NULL,
        [PM5_SD_SITE] varchar(4) NULL,
        [PM5_ROUTE] varchar(6) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STBT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM1_ROUTE] ON [dbo].[STBT]
    (
            [AM1_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM1_SD_SITE] ON [dbo].[STBT]
    (
            [AM1_SD_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM2_ROUTE] ON [dbo].[STBT]
    (
            [AM2_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM2_SD_SITE] ON [dbo].[STBT]
    (
            [AM2_SD_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM3_ROUTE] ON [dbo].[STBT]
    (
            [AM3_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM3_SD_SITE] ON [dbo].[STBT]
    (
            [AM3_SD_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM4_ROUTE] ON [dbo].[STBT]
    (
            [AM4_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM4_SD_SITE] ON [dbo].[STBT]
    (
            [AM4_SD_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM5_ROUTE] ON [dbo].[STBT]
    (
            [AM5_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_AM5_SD_SITE] ON [dbo].[STBT]
    (
            [AM5_SD_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM1_PU_SITE] ON [dbo].[STBT]
    (
            [PM1_PU_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM1_ROUTE] ON [dbo].[STBT]
    (
            [PM1_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM2_PU_SITE] ON [dbo].[STBT]
    (
            [PM2_PU_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM2_ROUTE] ON [dbo].[STBT]
    (
            [PM2_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM3_PU_SITE] ON [dbo].[STBT]
    (
            [PM3_PU_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM3_ROUTE] ON [dbo].[STBT]
    (
            [PM3_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM4_PU_SITE] ON [dbo].[STBT]
    (
            [PM4_PU_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM4_ROUTE] ON [dbo].[STBT]
    (
            [PM4_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM5_PU_SITE] ON [dbo].[STBT]
    (
            [PM5_PU_SITE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_PM5_ROUTE] ON [dbo].[STBT]
    (
            [PM5_ROUTE] ASC
    );
    CREATE NONCLUSTERED INDEX [STBT_Index_ROUTE] ON [dbo].[STBT]
    (
            [ROUTE] ASC
    );
    CREATE CLUSTERED INDEX [STBT_Index_STBTKEY] ON [dbo].[STBT]
    (
            [STBTKEY] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM1_ROUTE')
    ALTER INDEX [STBT_Index_AM1_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM1_SD_SITE')
    ALTER INDEX [STBT_Index_AM1_SD_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM2_ROUTE')
    ALTER INDEX [STBT_Index_AM2_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM2_SD_SITE')
    ALTER INDEX [STBT_Index_AM2_SD_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM3_ROUTE')
    ALTER INDEX [STBT_Index_AM3_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM3_SD_SITE')
    ALTER INDEX [STBT_Index_AM3_SD_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM4_ROUTE')
    ALTER INDEX [STBT_Index_AM4_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM4_SD_SITE')
    ALTER INDEX [STBT_Index_AM4_SD_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM5_ROUTE')
    ALTER INDEX [STBT_Index_AM5_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM5_SD_SITE')
    ALTER INDEX [STBT_Index_AM5_SD_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM1_PU_SITE')
    ALTER INDEX [STBT_Index_PM1_PU_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM1_ROUTE')
    ALTER INDEX [STBT_Index_PM1_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM2_PU_SITE')
    ALTER INDEX [STBT_Index_PM2_PU_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM2_ROUTE')
    ALTER INDEX [STBT_Index_PM2_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM3_PU_SITE')
    ALTER INDEX [STBT_Index_PM3_PU_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM3_ROUTE')
    ALTER INDEX [STBT_Index_PM3_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM4_PU_SITE')
    ALTER INDEX [STBT_Index_PM4_PU_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM4_ROUTE')
    ALTER INDEX [STBT_Index_PM4_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM5_PU_SITE')
    ALTER INDEX [STBT_Index_PM5_PU_SITE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM5_ROUTE')
    ALTER INDEX [STBT_Index_PM5_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_ROUTE')
    ALTER INDEX [STBT_Index_ROUTE] ON [dbo].[STBT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_TID')
    ALTER INDEX [STBT_Index_TID] ON [dbo].[STBT] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM1_ROUTE')
    ALTER INDEX [STBT_Index_AM1_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM1_SD_SITE')
    ALTER INDEX [STBT_Index_AM1_SD_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM2_ROUTE')
    ALTER INDEX [STBT_Index_AM2_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM2_SD_SITE')
    ALTER INDEX [STBT_Index_AM2_SD_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM3_ROUTE')
    ALTER INDEX [STBT_Index_AM3_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM3_SD_SITE')
    ALTER INDEX [STBT_Index_AM3_SD_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM4_ROUTE')
    ALTER INDEX [STBT_Index_AM4_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM4_SD_SITE')
    ALTER INDEX [STBT_Index_AM4_SD_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM5_ROUTE')
    ALTER INDEX [STBT_Index_AM5_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_AM5_SD_SITE')
    ALTER INDEX [STBT_Index_AM5_SD_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM1_PU_SITE')
    ALTER INDEX [STBT_Index_PM1_PU_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM1_ROUTE')
    ALTER INDEX [STBT_Index_PM1_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM2_PU_SITE')
    ALTER INDEX [STBT_Index_PM2_PU_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM2_ROUTE')
    ALTER INDEX [STBT_Index_PM2_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM3_PU_SITE')
    ALTER INDEX [STBT_Index_PM3_PU_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM3_ROUTE')
    ALTER INDEX [STBT_Index_PM3_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM4_PU_SITE')
    ALTER INDEX [STBT_Index_PM4_PU_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM4_ROUTE')
    ALTER INDEX [STBT_Index_PM4_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM5_PU_SITE')
    ALTER INDEX [STBT_Index_PM5_PU_SITE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_PM5_ROUTE')
    ALTER INDEX [STBT_Index_PM5_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_ROUTE')
    ALTER INDEX [STBT_Index_ROUTE] ON [dbo].[STBT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STBT]') AND name = N'STBT_Index_TID')
    ALTER INDEX [STBT_Index_TID] ON [dbo].[STBT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STBT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STBT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STBT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STBT] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STBT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STBT data set</returns>
        public override EduHubDataSetDataReader<STBT> GetDataSetDataReader()
        {
            return new STBTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STBT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STBT data set</returns>
        public override EduHubDataSetDataReader<STBT> GetDataSetDataReader(List<STBT> Entities)
        {
            return new STBTDataReader(new EduHubDataSetLoadedReader<STBT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STBTDataReader : EduHubDataSetDataReader<STBT>
        {
            public STBTDataReader(IEduHubDataSetReader<STBT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 64; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // STBTKEY
                        return Current.STBTKEY;
                    case 2: // ROUTE
                        return Current.ROUTE;
                    case 3: // DAYS_USED01
                        return Current.DAYS_USED01;
                    case 4: // DAYS_USED02
                        return Current.DAYS_USED02;
                    case 5: // DAYS_USED03
                        return Current.DAYS_USED03;
                    case 6: // DAYS_USED04
                        return Current.DAYS_USED04;
                    case 7: // DAYS_USED05
                        return Current.DAYS_USED05;
                    case 8: // TRANSPORT_NOTES
                        return Current.TRANSPORT_NOTES;
                    case 9: // DATE_STARTED
                        return Current.DATE_STARTED;
                    case 10: // TERMINATED
                        return Current.TERMINATED;
                    case 11: // AM1_PICKUP
                        return Current.AM1_PICKUP;
                    case 12: // AM1_PU_SITE
                        return Current.AM1_PU_SITE;
                    case 13: // AM1_SETDOWN
                        return Current.AM1_SETDOWN;
                    case 14: // AM1_SD_SITE
                        return Current.AM1_SD_SITE;
                    case 15: // AM1_ROUTE
                        return Current.AM1_ROUTE;
                    case 16: // PM1_PICKUP
                        return Current.PM1_PICKUP;
                    case 17: // PM1_PU_SITE
                        return Current.PM1_PU_SITE;
                    case 18: // PM1_SETDOWN
                        return Current.PM1_SETDOWN;
                    case 19: // PM1_SD_SITE
                        return Current.PM1_SD_SITE;
                    case 20: // PM1_ROUTE
                        return Current.PM1_ROUTE;
                    case 21: // AM2_PICKUP
                        return Current.AM2_PICKUP;
                    case 22: // AM2_PU_SITE
                        return Current.AM2_PU_SITE;
                    case 23: // AM2_SETDOWN
                        return Current.AM2_SETDOWN;
                    case 24: // AM2_SD_SITE
                        return Current.AM2_SD_SITE;
                    case 25: // AM2_ROUTE
                        return Current.AM2_ROUTE;
                    case 26: // PM2_PICKUP
                        return Current.PM2_PICKUP;
                    case 27: // PM2_PU_SITE
                        return Current.PM2_PU_SITE;
                    case 28: // PM2_SETDOWN
                        return Current.PM2_SETDOWN;
                    case 29: // PM2_SD_SITE
                        return Current.PM2_SD_SITE;
                    case 30: // PM2_ROUTE
                        return Current.PM2_ROUTE;
                    case 31: // AM3_PICKUP
                        return Current.AM3_PICKUP;
                    case 32: // AM3_PU_SITE
                        return Current.AM3_PU_SITE;
                    case 33: // AM3_SETDOWN
                        return Current.AM3_SETDOWN;
                    case 34: // AM3_SD_SITE
                        return Current.AM3_SD_SITE;
                    case 35: // AM3_ROUTE
                        return Current.AM3_ROUTE;
                    case 36: // PM3_PICKUP
                        return Current.PM3_PICKUP;
                    case 37: // PM3_PU_SITE
                        return Current.PM3_PU_SITE;
                    case 38: // PM3_SETDOWN
                        return Current.PM3_SETDOWN;
                    case 39: // PM3_SD_SITE
                        return Current.PM3_SD_SITE;
                    case 40: // PM3_ROUTE
                        return Current.PM3_ROUTE;
                    case 41: // AM4_PICKUP
                        return Current.AM4_PICKUP;
                    case 42: // AM4_PU_SITE
                        return Current.AM4_PU_SITE;
                    case 43: // AM4_SETDOWN
                        return Current.AM4_SETDOWN;
                    case 44: // AM4_SD_SITE
                        return Current.AM4_SD_SITE;
                    case 45: // AM4_ROUTE
                        return Current.AM4_ROUTE;
                    case 46: // PM4_PICKUP
                        return Current.PM4_PICKUP;
                    case 47: // PM4_PU_SITE
                        return Current.PM4_PU_SITE;
                    case 48: // PM4_SETDOWN
                        return Current.PM4_SETDOWN;
                    case 49: // PM4_SD_SITE
                        return Current.PM4_SD_SITE;
                    case 50: // PM4_ROUTE
                        return Current.PM4_ROUTE;
                    case 51: // AM5_PICKUP
                        return Current.AM5_PICKUP;
                    case 52: // AM5_PU_SITE
                        return Current.AM5_PU_SITE;
                    case 53: // AM5_SETDOWN
                        return Current.AM5_SETDOWN;
                    case 54: // AM5_SD_SITE
                        return Current.AM5_SD_SITE;
                    case 55: // AM5_ROUTE
                        return Current.AM5_ROUTE;
                    case 56: // PM5_PICKUP
                        return Current.PM5_PICKUP;
                    case 57: // PM5_PU_SITE
                        return Current.PM5_PU_SITE;
                    case 58: // PM5_SETDOWN
                        return Current.PM5_SETDOWN;
                    case 59: // PM5_SD_SITE
                        return Current.PM5_SD_SITE;
                    case 60: // PM5_ROUTE
                        return Current.PM5_ROUTE;
                    case 61: // LW_DATE
                        return Current.LW_DATE;
                    case 62: // LW_TIME
                        return Current.LW_TIME;
                    case 63: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // ROUTE
                        return Current.ROUTE == null;
                    case 3: // DAYS_USED01
                        return Current.DAYS_USED01 == null;
                    case 4: // DAYS_USED02
                        return Current.DAYS_USED02 == null;
                    case 5: // DAYS_USED03
                        return Current.DAYS_USED03 == null;
                    case 6: // DAYS_USED04
                        return Current.DAYS_USED04 == null;
                    case 7: // DAYS_USED05
                        return Current.DAYS_USED05 == null;
                    case 8: // TRANSPORT_NOTES
                        return Current.TRANSPORT_NOTES == null;
                    case 9: // DATE_STARTED
                        return Current.DATE_STARTED == null;
                    case 10: // TERMINATED
                        return Current.TERMINATED == null;
                    case 11: // AM1_PICKUP
                        return Current.AM1_PICKUP == null;
                    case 12: // AM1_PU_SITE
                        return Current.AM1_PU_SITE == null;
                    case 13: // AM1_SETDOWN
                        return Current.AM1_SETDOWN == null;
                    case 14: // AM1_SD_SITE
                        return Current.AM1_SD_SITE == null;
                    case 15: // AM1_ROUTE
                        return Current.AM1_ROUTE == null;
                    case 16: // PM1_PICKUP
                        return Current.PM1_PICKUP == null;
                    case 17: // PM1_PU_SITE
                        return Current.PM1_PU_SITE == null;
                    case 18: // PM1_SETDOWN
                        return Current.PM1_SETDOWN == null;
                    case 19: // PM1_SD_SITE
                        return Current.PM1_SD_SITE == null;
                    case 20: // PM1_ROUTE
                        return Current.PM1_ROUTE == null;
                    case 21: // AM2_PICKUP
                        return Current.AM2_PICKUP == null;
                    case 22: // AM2_PU_SITE
                        return Current.AM2_PU_SITE == null;
                    case 23: // AM2_SETDOWN
                        return Current.AM2_SETDOWN == null;
                    case 24: // AM2_SD_SITE
                        return Current.AM2_SD_SITE == null;
                    case 25: // AM2_ROUTE
                        return Current.AM2_ROUTE == null;
                    case 26: // PM2_PICKUP
                        return Current.PM2_PICKUP == null;
                    case 27: // PM2_PU_SITE
                        return Current.PM2_PU_SITE == null;
                    case 28: // PM2_SETDOWN
                        return Current.PM2_SETDOWN == null;
                    case 29: // PM2_SD_SITE
                        return Current.PM2_SD_SITE == null;
                    case 30: // PM2_ROUTE
                        return Current.PM2_ROUTE == null;
                    case 31: // AM3_PICKUP
                        return Current.AM3_PICKUP == null;
                    case 32: // AM3_PU_SITE
                        return Current.AM3_PU_SITE == null;
                    case 33: // AM3_SETDOWN
                        return Current.AM3_SETDOWN == null;
                    case 34: // AM3_SD_SITE
                        return Current.AM3_SD_SITE == null;
                    case 35: // AM3_ROUTE
                        return Current.AM3_ROUTE == null;
                    case 36: // PM3_PICKUP
                        return Current.PM3_PICKUP == null;
                    case 37: // PM3_PU_SITE
                        return Current.PM3_PU_SITE == null;
                    case 38: // PM3_SETDOWN
                        return Current.PM3_SETDOWN == null;
                    case 39: // PM3_SD_SITE
                        return Current.PM3_SD_SITE == null;
                    case 40: // PM3_ROUTE
                        return Current.PM3_ROUTE == null;
                    case 41: // AM4_PICKUP
                        return Current.AM4_PICKUP == null;
                    case 42: // AM4_PU_SITE
                        return Current.AM4_PU_SITE == null;
                    case 43: // AM4_SETDOWN
                        return Current.AM4_SETDOWN == null;
                    case 44: // AM4_SD_SITE
                        return Current.AM4_SD_SITE == null;
                    case 45: // AM4_ROUTE
                        return Current.AM4_ROUTE == null;
                    case 46: // PM4_PICKUP
                        return Current.PM4_PICKUP == null;
                    case 47: // PM4_PU_SITE
                        return Current.PM4_PU_SITE == null;
                    case 48: // PM4_SETDOWN
                        return Current.PM4_SETDOWN == null;
                    case 49: // PM4_SD_SITE
                        return Current.PM4_SD_SITE == null;
                    case 50: // PM4_ROUTE
                        return Current.PM4_ROUTE == null;
                    case 51: // AM5_PICKUP
                        return Current.AM5_PICKUP == null;
                    case 52: // AM5_PU_SITE
                        return Current.AM5_PU_SITE == null;
                    case 53: // AM5_SETDOWN
                        return Current.AM5_SETDOWN == null;
                    case 54: // AM5_SD_SITE
                        return Current.AM5_SD_SITE == null;
                    case 55: // AM5_ROUTE
                        return Current.AM5_ROUTE == null;
                    case 56: // PM5_PICKUP
                        return Current.PM5_PICKUP == null;
                    case 57: // PM5_PU_SITE
                        return Current.PM5_PU_SITE == null;
                    case 58: // PM5_SETDOWN
                        return Current.PM5_SETDOWN == null;
                    case 59: // PM5_SD_SITE
                        return Current.PM5_SD_SITE == null;
                    case 60: // PM5_ROUTE
                        return Current.PM5_ROUTE == null;
                    case 61: // LW_DATE
                        return Current.LW_DATE == null;
                    case 62: // LW_TIME
                        return Current.LW_TIME == null;
                    case 63: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // STBTKEY
                        return "STBTKEY";
                    case 2: // ROUTE
                        return "ROUTE";
                    case 3: // DAYS_USED01
                        return "DAYS_USED01";
                    case 4: // DAYS_USED02
                        return "DAYS_USED02";
                    case 5: // DAYS_USED03
                        return "DAYS_USED03";
                    case 6: // DAYS_USED04
                        return "DAYS_USED04";
                    case 7: // DAYS_USED05
                        return "DAYS_USED05";
                    case 8: // TRANSPORT_NOTES
                        return "TRANSPORT_NOTES";
                    case 9: // DATE_STARTED
                        return "DATE_STARTED";
                    case 10: // TERMINATED
                        return "TERMINATED";
                    case 11: // AM1_PICKUP
                        return "AM1_PICKUP";
                    case 12: // AM1_PU_SITE
                        return "AM1_PU_SITE";
                    case 13: // AM1_SETDOWN
                        return "AM1_SETDOWN";
                    case 14: // AM1_SD_SITE
                        return "AM1_SD_SITE";
                    case 15: // AM1_ROUTE
                        return "AM1_ROUTE";
                    case 16: // PM1_PICKUP
                        return "PM1_PICKUP";
                    case 17: // PM1_PU_SITE
                        return "PM1_PU_SITE";
                    case 18: // PM1_SETDOWN
                        return "PM1_SETDOWN";
                    case 19: // PM1_SD_SITE
                        return "PM1_SD_SITE";
                    case 20: // PM1_ROUTE
                        return "PM1_ROUTE";
                    case 21: // AM2_PICKUP
                        return "AM2_PICKUP";
                    case 22: // AM2_PU_SITE
                        return "AM2_PU_SITE";
                    case 23: // AM2_SETDOWN
                        return "AM2_SETDOWN";
                    case 24: // AM2_SD_SITE
                        return "AM2_SD_SITE";
                    case 25: // AM2_ROUTE
                        return "AM2_ROUTE";
                    case 26: // PM2_PICKUP
                        return "PM2_PICKUP";
                    case 27: // PM2_PU_SITE
                        return "PM2_PU_SITE";
                    case 28: // PM2_SETDOWN
                        return "PM2_SETDOWN";
                    case 29: // PM2_SD_SITE
                        return "PM2_SD_SITE";
                    case 30: // PM2_ROUTE
                        return "PM2_ROUTE";
                    case 31: // AM3_PICKUP
                        return "AM3_PICKUP";
                    case 32: // AM3_PU_SITE
                        return "AM3_PU_SITE";
                    case 33: // AM3_SETDOWN
                        return "AM3_SETDOWN";
                    case 34: // AM3_SD_SITE
                        return "AM3_SD_SITE";
                    case 35: // AM3_ROUTE
                        return "AM3_ROUTE";
                    case 36: // PM3_PICKUP
                        return "PM3_PICKUP";
                    case 37: // PM3_PU_SITE
                        return "PM3_PU_SITE";
                    case 38: // PM3_SETDOWN
                        return "PM3_SETDOWN";
                    case 39: // PM3_SD_SITE
                        return "PM3_SD_SITE";
                    case 40: // PM3_ROUTE
                        return "PM3_ROUTE";
                    case 41: // AM4_PICKUP
                        return "AM4_PICKUP";
                    case 42: // AM4_PU_SITE
                        return "AM4_PU_SITE";
                    case 43: // AM4_SETDOWN
                        return "AM4_SETDOWN";
                    case 44: // AM4_SD_SITE
                        return "AM4_SD_SITE";
                    case 45: // AM4_ROUTE
                        return "AM4_ROUTE";
                    case 46: // PM4_PICKUP
                        return "PM4_PICKUP";
                    case 47: // PM4_PU_SITE
                        return "PM4_PU_SITE";
                    case 48: // PM4_SETDOWN
                        return "PM4_SETDOWN";
                    case 49: // PM4_SD_SITE
                        return "PM4_SD_SITE";
                    case 50: // PM4_ROUTE
                        return "PM4_ROUTE";
                    case 51: // AM5_PICKUP
                        return "AM5_PICKUP";
                    case 52: // AM5_PU_SITE
                        return "AM5_PU_SITE";
                    case 53: // AM5_SETDOWN
                        return "AM5_SETDOWN";
                    case 54: // AM5_SD_SITE
                        return "AM5_SD_SITE";
                    case 55: // AM5_ROUTE
                        return "AM5_ROUTE";
                    case 56: // PM5_PICKUP
                        return "PM5_PICKUP";
                    case 57: // PM5_PU_SITE
                        return "PM5_PU_SITE";
                    case 58: // PM5_SETDOWN
                        return "PM5_SETDOWN";
                    case 59: // PM5_SD_SITE
                        return "PM5_SD_SITE";
                    case 60: // PM5_ROUTE
                        return "PM5_ROUTE";
                    case 61: // LW_DATE
                        return "LW_DATE";
                    case 62: // LW_TIME
                        return "LW_TIME";
                    case 63: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "STBTKEY":
                        return 1;
                    case "ROUTE":
                        return 2;
                    case "DAYS_USED01":
                        return 3;
                    case "DAYS_USED02":
                        return 4;
                    case "DAYS_USED03":
                        return 5;
                    case "DAYS_USED04":
                        return 6;
                    case "DAYS_USED05":
                        return 7;
                    case "TRANSPORT_NOTES":
                        return 8;
                    case "DATE_STARTED":
                        return 9;
                    case "TERMINATED":
                        return 10;
                    case "AM1_PICKUP":
                        return 11;
                    case "AM1_PU_SITE":
                        return 12;
                    case "AM1_SETDOWN":
                        return 13;
                    case "AM1_SD_SITE":
                        return 14;
                    case "AM1_ROUTE":
                        return 15;
                    case "PM1_PICKUP":
                        return 16;
                    case "PM1_PU_SITE":
                        return 17;
                    case "PM1_SETDOWN":
                        return 18;
                    case "PM1_SD_SITE":
                        return 19;
                    case "PM1_ROUTE":
                        return 20;
                    case "AM2_PICKUP":
                        return 21;
                    case "AM2_PU_SITE":
                        return 22;
                    case "AM2_SETDOWN":
                        return 23;
                    case "AM2_SD_SITE":
                        return 24;
                    case "AM2_ROUTE":
                        return 25;
                    case "PM2_PICKUP":
                        return 26;
                    case "PM2_PU_SITE":
                        return 27;
                    case "PM2_SETDOWN":
                        return 28;
                    case "PM2_SD_SITE":
                        return 29;
                    case "PM2_ROUTE":
                        return 30;
                    case "AM3_PICKUP":
                        return 31;
                    case "AM3_PU_SITE":
                        return 32;
                    case "AM3_SETDOWN":
                        return 33;
                    case "AM3_SD_SITE":
                        return 34;
                    case "AM3_ROUTE":
                        return 35;
                    case "PM3_PICKUP":
                        return 36;
                    case "PM3_PU_SITE":
                        return 37;
                    case "PM3_SETDOWN":
                        return 38;
                    case "PM3_SD_SITE":
                        return 39;
                    case "PM3_ROUTE":
                        return 40;
                    case "AM4_PICKUP":
                        return 41;
                    case "AM4_PU_SITE":
                        return 42;
                    case "AM4_SETDOWN":
                        return 43;
                    case "AM4_SD_SITE":
                        return 44;
                    case "AM4_ROUTE":
                        return 45;
                    case "PM4_PICKUP":
                        return 46;
                    case "PM4_PU_SITE":
                        return 47;
                    case "PM4_SETDOWN":
                        return 48;
                    case "PM4_SD_SITE":
                        return 49;
                    case "PM4_ROUTE":
                        return 50;
                    case "AM5_PICKUP":
                        return 51;
                    case "AM5_PU_SITE":
                        return 52;
                    case "AM5_SETDOWN":
                        return 53;
                    case "AM5_SD_SITE":
                        return 54;
                    case "AM5_ROUTE":
                        return 55;
                    case "PM5_PICKUP":
                        return 56;
                    case "PM5_PU_SITE":
                        return 57;
                    case "PM5_SETDOWN":
                        return 58;
                    case "PM5_SD_SITE":
                        return 59;
                    case "PM5_ROUTE":
                        return 60;
                    case "LW_DATE":
                        return 61;
                    case "LW_TIME":
                        return 62;
                    case "LW_USER":
                        return 63;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
