using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Half-Day Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SXABDataSet : DataSetBase<SXAB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SXAB"; } }

        internal SXABDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AM_ACT_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.AM_ACT_TYPE));
            Index_AM_EXP_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.AM_EXP_TYPE));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_PM_ACT_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.PM_ACT_TYPE));
            Index_PM_EXP_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.PM_EXP_TYPE));
            Index_ST_YEAR_LEVEL = new Lazy<NullDictionary<string, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.ST_YEAR_LEVEL));
            Index_STKEY = new Lazy<NullDictionary<string, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.STKEY));
            Index_STKEY_ABSENCE_DATE = new Lazy<Dictionary<Tuple<string, DateTime?>, SXAB>>(() => this.ToDictionary(i => Tuple.Create(i.STKEY, i.ABSENCE_DATE)));
            Index_SXAB_ID = new Lazy<Dictionary<int, SXAB>>(() => this.ToDictionary(i => i.SXAB_ID));
            Index_TXHG_TID = new Lazy<NullDictionary<int?, IReadOnlyList<SXAB>>>(() => this.ToGroupedNullDictionary(i => i.TXHG_TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SXAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SXAB" /> fields for each CSV column header</returns>
        protected override Action<SXAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SXAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SXAB_ID":
                        mapper[i] = (e, v) => e.SXAB_ID = int.Parse(v);
                        break;
                    case "TXHG_TID":
                        mapper[i] = (e, v) => e.TXHG_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ABSENCE_DATE":
                        mapper[i] = (e, v) => e.ABSENCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ABSENCE_COMMENT":
                        mapper[i] = (e, v) => e.ABSENCE_COMMENT = v;
                        break;
                    case "AM_EXP_TYPE":
                        mapper[i] = (e, v) => e.AM_EXP_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_ATTENDED":
                        mapper[i] = (e, v) => e.AM_ATTENDED = v;
                        break;
                    case "AM_ACT_TYPE":
                        mapper[i] = (e, v) => e.AM_ACT_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_APPROVED":
                        mapper[i] = (e, v) => e.AM_APPROVED = v;
                        break;
                    case "AM_LATE_ARRIVAL":
                        mapper[i] = (e, v) => e.AM_LATE_ARRIVAL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_EARLY_LEFT":
                        mapper[i] = (e, v) => e.AM_EARLY_LEFT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_EXP_TYPE":
                        mapper[i] = (e, v) => e.PM_EXP_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_ATTENDED":
                        mapper[i] = (e, v) => e.PM_ATTENDED = v;
                        break;
                    case "PM_ACT_TYPE":
                        mapper[i] = (e, v) => e.PM_ACT_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_APPROVED":
                        mapper[i] = (e, v) => e.PM_APPROVED = v;
                        break;
                    case "PM_LATE_ARRIVAL":
                        mapper[i] = (e, v) => e.PM_LATE_ARRIVAL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_EARLY_LEFT":
                        mapper[i] = (e, v) => e.PM_EARLY_LEFT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "CONTACT_METHOD":
                        mapper[i] = (e, v) => e.CONTACT_METHOD = v;
                        break;
                    case "SICKBAY":
                        mapper[i] = (e, v) => e.SICKBAY = v;
                        break;
                    case "LAST_ACTION":
                        mapper[i] = (e, v) => e.LAST_ACTION = v;
                        break;
                    case "SMS_AM_KEY":
                        mapper[i] = (e, v) => e.SMS_AM_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SMS_PM_KEY":
                        mapper[i] = (e, v) => e.SMS_PM_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMAIL_AM_KEY":
                        mapper[i] = (e, v) => e.EMAIL_AM_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMAIL_PM_KEY":
                        mapper[i] = (e, v) => e.EMAIL_PM_KEY = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="SXAB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SXAB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SXAB" /> items to added or update the base <see cref="SXAB" /> items</param>
        /// <returns>A merged list of <see cref="SXAB" /> items</returns>
        protected override List<SXAB> ApplyDeltaItems(List<SXAB> Items, List<SXAB> DeltaItems)
        {
            Dictionary<Tuple<string, DateTime?>, int> Index_STKEY_ABSENCE_DATE = Items.ToIndexDictionary(i => Tuple.Create(i.STKEY, i.ABSENCE_DATE));
            Dictionary<int, int> Index_SXAB_ID = Items.ToIndexDictionary(i => i.SXAB_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SXAB deltaItem in DeltaItems)
            {
                int index;

                if (Index_STKEY_ABSENCE_DATE.TryGetValue(Tuple.Create(deltaItem.STKEY, deltaItem.ABSENCE_DATE), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_SXAB_ID.TryGetValue(deltaItem.SXAB_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SXAB_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>> Index_AM_ACT_TYPE;
        private Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>> Index_AM_EXP_TYPE;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SXAB>>> Index_LW_DATE;
        private Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>> Index_PM_ACT_TYPE;
        private Lazy<NullDictionary<short?, IReadOnlyList<SXAB>>> Index_PM_EXP_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SXAB>>> Index_ST_YEAR_LEVEL;
        private Lazy<NullDictionary<string, IReadOnlyList<SXAB>>> Index_STKEY;
        private Lazy<Dictionary<Tuple<string, DateTime?>, SXAB>> Index_STKEY_ABSENCE_DATE;
        private Lazy<Dictionary<int, SXAB>> Index_SXAB_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<SXAB>>> Index_TXHG_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SXAB by AM_ACT_TYPE field
        /// </summary>
        /// <param name="AM_ACT_TYPE">AM_ACT_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindByAM_ACT_TYPE(short? AM_ACT_TYPE)
        {
            return Index_AM_ACT_TYPE.Value[AM_ACT_TYPE];
        }

        /// <summary>
        /// Attempt to find SXAB by AM_ACT_TYPE field
        /// </summary>
        /// <param name="AM_ACT_TYPE">AM_ACT_TYPE value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_ACT_TYPE(short? AM_ACT_TYPE, out IReadOnlyList<SXAB> Value)
        {
            return Index_AM_ACT_TYPE.Value.TryGetValue(AM_ACT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by AM_ACT_TYPE field
        /// </summary>
        /// <param name="AM_ACT_TYPE">AM_ACT_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindByAM_ACT_TYPE(short? AM_ACT_TYPE)
        {
            IReadOnlyList<SXAB> value;
            if (Index_AM_ACT_TYPE.Value.TryGetValue(AM_ACT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAB by AM_EXP_TYPE field
        /// </summary>
        /// <param name="AM_EXP_TYPE">AM_EXP_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindByAM_EXP_TYPE(short? AM_EXP_TYPE)
        {
            return Index_AM_EXP_TYPE.Value[AM_EXP_TYPE];
        }

        /// <summary>
        /// Attempt to find SXAB by AM_EXP_TYPE field
        /// </summary>
        /// <param name="AM_EXP_TYPE">AM_EXP_TYPE value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_EXP_TYPE(short? AM_EXP_TYPE, out IReadOnlyList<SXAB> Value)
        {
            return Index_AM_EXP_TYPE.Value.TryGetValue(AM_EXP_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by AM_EXP_TYPE field
        /// </summary>
        /// <param name="AM_EXP_TYPE">AM_EXP_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindByAM_EXP_TYPE(short? AM_EXP_TYPE)
        {
            IReadOnlyList<SXAB> value;
            if (Index_AM_EXP_TYPE.Value.TryGetValue(AM_EXP_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAB by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SXAB by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SXAB> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SXAB> value;
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
        /// Find SXAB by PM_ACT_TYPE field
        /// </summary>
        /// <param name="PM_ACT_TYPE">PM_ACT_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindByPM_ACT_TYPE(short? PM_ACT_TYPE)
        {
            return Index_PM_ACT_TYPE.Value[PM_ACT_TYPE];
        }

        /// <summary>
        /// Attempt to find SXAB by PM_ACT_TYPE field
        /// </summary>
        /// <param name="PM_ACT_TYPE">PM_ACT_TYPE value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_ACT_TYPE(short? PM_ACT_TYPE, out IReadOnlyList<SXAB> Value)
        {
            return Index_PM_ACT_TYPE.Value.TryGetValue(PM_ACT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by PM_ACT_TYPE field
        /// </summary>
        /// <param name="PM_ACT_TYPE">PM_ACT_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindByPM_ACT_TYPE(short? PM_ACT_TYPE)
        {
            IReadOnlyList<SXAB> value;
            if (Index_PM_ACT_TYPE.Value.TryGetValue(PM_ACT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAB by PM_EXP_TYPE field
        /// </summary>
        /// <param name="PM_EXP_TYPE">PM_EXP_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindByPM_EXP_TYPE(short? PM_EXP_TYPE)
        {
            return Index_PM_EXP_TYPE.Value[PM_EXP_TYPE];
        }

        /// <summary>
        /// Attempt to find SXAB by PM_EXP_TYPE field
        /// </summary>
        /// <param name="PM_EXP_TYPE">PM_EXP_TYPE value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_EXP_TYPE(short? PM_EXP_TYPE, out IReadOnlyList<SXAB> Value)
        {
            return Index_PM_EXP_TYPE.Value.TryGetValue(PM_EXP_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by PM_EXP_TYPE field
        /// </summary>
        /// <param name="PM_EXP_TYPE">PM_EXP_TYPE value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindByPM_EXP_TYPE(short? PM_EXP_TYPE)
        {
            IReadOnlyList<SXAB> value;
            if (Index_PM_EXP_TYPE.Value.TryGetValue(PM_EXP_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAB by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            return Index_ST_YEAR_LEVEL.Value[ST_YEAR_LEVEL];
        }

        /// <summary>
        /// Attempt to find SXAB by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL, out IReadOnlyList<SXAB> Value)
        {
            return Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            IReadOnlyList<SXAB> value;
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
        /// Find SXAB by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find SXAB by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out IReadOnlyList<SXAB> Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindBySTKEY(string STKEY)
        {
            IReadOnlyList<SXAB> value;
            if (Index_STKEY.Value.TryGetValue(STKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAB by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXAB</param>
        /// <returns>Related SXAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXAB FindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE)
        {
            return Index_STKEY_ABSENCE_DATE.Value[Tuple.Create(STKEY, ABSENCE_DATE)];
        }

        /// <summary>
        /// Attempt to find SXAB by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXAB</param>
        /// <param name="Value">Related SXAB entity</param>
        /// <returns>True if the related SXAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE, out SXAB Value)
        {
            return Index_STKEY_ABSENCE_DATE.Value.TryGetValue(Tuple.Create(STKEY, ABSENCE_DATE), out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXAB</param>
        /// <returns>Related SXAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXAB TryFindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE)
        {
            SXAB value;
            if (Index_STKEY_ABSENCE_DATE.Value.TryGetValue(Tuple.Create(STKEY, ABSENCE_DATE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAB by SXAB_ID field
        /// </summary>
        /// <param name="SXAB_ID">SXAB_ID value used to find SXAB</param>
        /// <returns>Related SXAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXAB FindBySXAB_ID(int SXAB_ID)
        {
            return Index_SXAB_ID.Value[SXAB_ID];
        }

        /// <summary>
        /// Attempt to find SXAB by SXAB_ID field
        /// </summary>
        /// <param name="SXAB_ID">SXAB_ID value used to find SXAB</param>
        /// <param name="Value">Related SXAB entity</param>
        /// <returns>True if the related SXAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySXAB_ID(int SXAB_ID, out SXAB Value)
        {
            return Index_SXAB_ID.Value.TryGetValue(SXAB_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by SXAB_ID field
        /// </summary>
        /// <param name="SXAB_ID">SXAB_ID value used to find SXAB</param>
        /// <returns>Related SXAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXAB TryFindBySXAB_ID(int SXAB_ID)
        {
            SXAB value;
            if (Index_SXAB_ID.Value.TryGetValue(SXAB_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAB by TXHG_TID field
        /// </summary>
        /// <param name="TXHG_TID">TXHG_TID value used to find SXAB</param>
        /// <returns>List of related SXAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> FindByTXHG_TID(int? TXHG_TID)
        {
            return Index_TXHG_TID.Value[TXHG_TID];
        }

        /// <summary>
        /// Attempt to find SXAB by TXHG_TID field
        /// </summary>
        /// <param name="TXHG_TID">TXHG_TID value used to find SXAB</param>
        /// <param name="Value">List of related SXAB entities</param>
        /// <returns>True if the list of related SXAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTXHG_TID(int? TXHG_TID, out IReadOnlyList<SXAB> Value)
        {
            return Index_TXHG_TID.Value.TryGetValue(TXHG_TID, out Value);
        }

        /// <summary>
        /// Attempt to find SXAB by TXHG_TID field
        /// </summary>
        /// <param name="TXHG_TID">TXHG_TID value used to find SXAB</param>
        /// <returns>List of related SXAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAB> TryFindByTXHG_TID(int? TXHG_TID)
        {
            IReadOnlyList<SXAB> value;
            if (Index_TXHG_TID.Value.TryGetValue(TXHG_TID, out value))
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
        /// Returns SQL which checks for the existence of a SXAB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SXAB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SXAB](
        [SXAB_ID] int IDENTITY NOT NULL,
        [TXHG_TID] int NULL,
        [STKEY] varchar(10) NULL,
        [ST_YEAR_LEVEL] varchar(4) NULL,
        [ABSENCE_DATE] datetime NULL,
        [ABSENCE_COMMENT] varchar(30) NULL,
        [AM_EXP_TYPE] smallint NULL,
        [AM_ATTENDED] varchar(1) NULL,
        [AM_ACT_TYPE] smallint NULL,
        [AM_APPROVED] varchar(1) NULL,
        [AM_LATE_ARRIVAL] smallint NULL,
        [AM_EARLY_LEFT] smallint NULL,
        [PM_EXP_TYPE] smallint NULL,
        [PM_ATTENDED] varchar(1) NULL,
        [PM_ACT_TYPE] smallint NULL,
        [PM_APPROVED] varchar(1) NULL,
        [PM_LATE_ARRIVAL] smallint NULL,
        [PM_EARLY_LEFT] smallint NULL,
        [CONTACT] varchar(1) NULL,
        [CONTACT_METHOD] varchar(1) NULL,
        [SICKBAY] varchar(1) NULL,
        [LAST_ACTION] varchar(1) NULL,
        [SMS_AM_KEY] int NULL,
        [SMS_PM_KEY] int NULL,
        [EMAIL_AM_KEY] int NULL,
        [EMAIL_PM_KEY] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SXAB_Index_SXAB_ID] PRIMARY KEY CLUSTERED (
            [SXAB_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_AM_ACT_TYPE] ON [dbo].[SXAB]
    (
            [AM_ACT_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_AM_EXP_TYPE] ON [dbo].[SXAB]
    (
            [AM_EXP_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_LW_DATE] ON [dbo].[SXAB]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_PM_ACT_TYPE] ON [dbo].[SXAB]
    (
            [PM_ACT_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_PM_EXP_TYPE] ON [dbo].[SXAB]
    (
            [PM_EXP_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_ST_YEAR_LEVEL] ON [dbo].[SXAB]
    (
            [ST_YEAR_LEVEL] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_STKEY] ON [dbo].[SXAB]
    (
            [STKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_STKEY_ABSENCE_DATE] ON [dbo].[SXAB]
    (
            [STKEY] ASC,
            [ABSENCE_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAB_Index_TXHG_TID] ON [dbo].[SXAB]
    (
            [TXHG_TID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SXAB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SXAB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SXABDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SXABDataReader : IDataReader, IDataRecord
        {
            private List<SXAB> Items;
            private int CurrentIndex;
            private SXAB CurrentItem;

            public SXABDataReader(List<SXAB> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 29; } }
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
                    case 0: // SXAB_ID
                        return CurrentItem.SXAB_ID;
                    case 1: // TXHG_TID
                        return CurrentItem.TXHG_TID;
                    case 2: // STKEY
                        return CurrentItem.STKEY;
                    case 3: // ST_YEAR_LEVEL
                        return CurrentItem.ST_YEAR_LEVEL;
                    case 4: // ABSENCE_DATE
                        return CurrentItem.ABSENCE_DATE;
                    case 5: // ABSENCE_COMMENT
                        return CurrentItem.ABSENCE_COMMENT;
                    case 6: // AM_EXP_TYPE
                        return CurrentItem.AM_EXP_TYPE;
                    case 7: // AM_ATTENDED
                        return CurrentItem.AM_ATTENDED;
                    case 8: // AM_ACT_TYPE
                        return CurrentItem.AM_ACT_TYPE;
                    case 9: // AM_APPROVED
                        return CurrentItem.AM_APPROVED;
                    case 10: // AM_LATE_ARRIVAL
                        return CurrentItem.AM_LATE_ARRIVAL;
                    case 11: // AM_EARLY_LEFT
                        return CurrentItem.AM_EARLY_LEFT;
                    case 12: // PM_EXP_TYPE
                        return CurrentItem.PM_EXP_TYPE;
                    case 13: // PM_ATTENDED
                        return CurrentItem.PM_ATTENDED;
                    case 14: // PM_ACT_TYPE
                        return CurrentItem.PM_ACT_TYPE;
                    case 15: // PM_APPROVED
                        return CurrentItem.PM_APPROVED;
                    case 16: // PM_LATE_ARRIVAL
                        return CurrentItem.PM_LATE_ARRIVAL;
                    case 17: // PM_EARLY_LEFT
                        return CurrentItem.PM_EARLY_LEFT;
                    case 18: // CONTACT
                        return CurrentItem.CONTACT;
                    case 19: // CONTACT_METHOD
                        return CurrentItem.CONTACT_METHOD;
                    case 20: // SICKBAY
                        return CurrentItem.SICKBAY;
                    case 21: // LAST_ACTION
                        return CurrentItem.LAST_ACTION;
                    case 22: // SMS_AM_KEY
                        return CurrentItem.SMS_AM_KEY;
                    case 23: // SMS_PM_KEY
                        return CurrentItem.SMS_PM_KEY;
                    case 24: // EMAIL_AM_KEY
                        return CurrentItem.EMAIL_AM_KEY;
                    case 25: // EMAIL_PM_KEY
                        return CurrentItem.EMAIL_PM_KEY;
                    case 26: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 27: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 28: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TXHG_TID
                        return CurrentItem.TXHG_TID == null;
                    case 2: // STKEY
                        return CurrentItem.STKEY == null;
                    case 3: // ST_YEAR_LEVEL
                        return CurrentItem.ST_YEAR_LEVEL == null;
                    case 4: // ABSENCE_DATE
                        return CurrentItem.ABSENCE_DATE == null;
                    case 5: // ABSENCE_COMMENT
                        return CurrentItem.ABSENCE_COMMENT == null;
                    case 6: // AM_EXP_TYPE
                        return CurrentItem.AM_EXP_TYPE == null;
                    case 7: // AM_ATTENDED
                        return CurrentItem.AM_ATTENDED == null;
                    case 8: // AM_ACT_TYPE
                        return CurrentItem.AM_ACT_TYPE == null;
                    case 9: // AM_APPROVED
                        return CurrentItem.AM_APPROVED == null;
                    case 10: // AM_LATE_ARRIVAL
                        return CurrentItem.AM_LATE_ARRIVAL == null;
                    case 11: // AM_EARLY_LEFT
                        return CurrentItem.AM_EARLY_LEFT == null;
                    case 12: // PM_EXP_TYPE
                        return CurrentItem.PM_EXP_TYPE == null;
                    case 13: // PM_ATTENDED
                        return CurrentItem.PM_ATTENDED == null;
                    case 14: // PM_ACT_TYPE
                        return CurrentItem.PM_ACT_TYPE == null;
                    case 15: // PM_APPROVED
                        return CurrentItem.PM_APPROVED == null;
                    case 16: // PM_LATE_ARRIVAL
                        return CurrentItem.PM_LATE_ARRIVAL == null;
                    case 17: // PM_EARLY_LEFT
                        return CurrentItem.PM_EARLY_LEFT == null;
                    case 18: // CONTACT
                        return CurrentItem.CONTACT == null;
                    case 19: // CONTACT_METHOD
                        return CurrentItem.CONTACT_METHOD == null;
                    case 20: // SICKBAY
                        return CurrentItem.SICKBAY == null;
                    case 21: // LAST_ACTION
                        return CurrentItem.LAST_ACTION == null;
                    case 22: // SMS_AM_KEY
                        return CurrentItem.SMS_AM_KEY == null;
                    case 23: // SMS_PM_KEY
                        return CurrentItem.SMS_PM_KEY == null;
                    case 24: // EMAIL_AM_KEY
                        return CurrentItem.EMAIL_AM_KEY == null;
                    case 25: // EMAIL_PM_KEY
                        return CurrentItem.EMAIL_PM_KEY == null;
                    case 26: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 27: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 28: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SXAB_ID
                        return "SXAB_ID";
                    case 1: // TXHG_TID
                        return "TXHG_TID";
                    case 2: // STKEY
                        return "STKEY";
                    case 3: // ST_YEAR_LEVEL
                        return "ST_YEAR_LEVEL";
                    case 4: // ABSENCE_DATE
                        return "ABSENCE_DATE";
                    case 5: // ABSENCE_COMMENT
                        return "ABSENCE_COMMENT";
                    case 6: // AM_EXP_TYPE
                        return "AM_EXP_TYPE";
                    case 7: // AM_ATTENDED
                        return "AM_ATTENDED";
                    case 8: // AM_ACT_TYPE
                        return "AM_ACT_TYPE";
                    case 9: // AM_APPROVED
                        return "AM_APPROVED";
                    case 10: // AM_LATE_ARRIVAL
                        return "AM_LATE_ARRIVAL";
                    case 11: // AM_EARLY_LEFT
                        return "AM_EARLY_LEFT";
                    case 12: // PM_EXP_TYPE
                        return "PM_EXP_TYPE";
                    case 13: // PM_ATTENDED
                        return "PM_ATTENDED";
                    case 14: // PM_ACT_TYPE
                        return "PM_ACT_TYPE";
                    case 15: // PM_APPROVED
                        return "PM_APPROVED";
                    case 16: // PM_LATE_ARRIVAL
                        return "PM_LATE_ARRIVAL";
                    case 17: // PM_EARLY_LEFT
                        return "PM_EARLY_LEFT";
                    case 18: // CONTACT
                        return "CONTACT";
                    case 19: // CONTACT_METHOD
                        return "CONTACT_METHOD";
                    case 20: // SICKBAY
                        return "SICKBAY";
                    case 21: // LAST_ACTION
                        return "LAST_ACTION";
                    case 22: // SMS_AM_KEY
                        return "SMS_AM_KEY";
                    case 23: // SMS_PM_KEY
                        return "SMS_PM_KEY";
                    case 24: // EMAIL_AM_KEY
                        return "EMAIL_AM_KEY";
                    case 25: // EMAIL_PM_KEY
                        return "EMAIL_PM_KEY";
                    case 26: // LW_DATE
                        return "LW_DATE";
                    case 27: // LW_TIME
                        return "LW_TIME";
                    case 28: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SXAB_ID":
                        return 0;
                    case "TXHG_TID":
                        return 1;
                    case "STKEY":
                        return 2;
                    case "ST_YEAR_LEVEL":
                        return 3;
                    case "ABSENCE_DATE":
                        return 4;
                    case "ABSENCE_COMMENT":
                        return 5;
                    case "AM_EXP_TYPE":
                        return 6;
                    case "AM_ATTENDED":
                        return 7;
                    case "AM_ACT_TYPE":
                        return 8;
                    case "AM_APPROVED":
                        return 9;
                    case "AM_LATE_ARRIVAL":
                        return 10;
                    case "AM_EARLY_LEFT":
                        return 11;
                    case "PM_EXP_TYPE":
                        return 12;
                    case "PM_ATTENDED":
                        return 13;
                    case "PM_ACT_TYPE":
                        return 14;
                    case "PM_APPROVED":
                        return 15;
                    case "PM_LATE_ARRIVAL":
                        return 16;
                    case "PM_EARLY_LEFT":
                        return 17;
                    case "CONTACT":
                        return 18;
                    case "CONTACT_METHOD":
                        return 19;
                    case "SICKBAY":
                        return 20;
                    case "LAST_ACTION":
                        return 21;
                    case "SMS_AM_KEY":
                        return 22;
                    case "SMS_PM_KEY":
                        return 23;
                    case "EMAIL_AM_KEY":
                        return 24;
                    case "EMAIL_PM_KEY":
                        return 25;
                    case "LW_DATE":
                        return 26;
                    case "LW_TIME":
                        return 27;
                    case "LW_USER":
                        return 28;
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
