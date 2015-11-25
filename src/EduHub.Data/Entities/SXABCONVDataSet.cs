using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Converted Student Half-Day Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SXABCONVDataSet : SetBase<SXABCONV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SXABCONV"; } }

        internal SXABCONVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SXABCONV_ID = new Lazy<Dictionary<int, SXABCONV>>(() => this.ToDictionary(i => i.SXABCONV_ID));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_STKEY_ABSENCE_DATE = new Lazy<Dictionary<Tuple<string, DateTime?>, SXABCONV>>(() => this.ToDictionary(i => Tuple.Create(i.STKEY, i.ABSENCE_DATE)));
            Index_STKEY = new Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.STKEY));
            Index_ST_YEAR_LEVEL = new Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.ST_YEAR_LEVEL));
            Index_AM_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.AM_TYPE));
            Index_PM_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>>(() => this.ToGroupedNullDictionary(i => i.PM_TYPE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SXABCONV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SXABCONV" /> fields for each CSV column header</returns>
        protected override Action<SXABCONV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SXABCONV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SXABCONV_ID":
                        mapper[i] = (e, v) => e.SXABCONV_ID = int.Parse(v);
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
                    case "AM_TYPE":
                        mapper[i] = (e, v) => e.AM_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_ATTENDED":
                        mapper[i] = (e, v) => e.AM_ATTENDED = v;
                        break;
                    case "AM_APPROVED":
                        mapper[i] = (e, v) => e.AM_APPROVED = v;
                        break;
                    case "PM_TYPE":
                        mapper[i] = (e, v) => e.PM_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_ATTENDED":
                        mapper[i] = (e, v) => e.PM_ATTENDED = v;
                        break;
                    case "PM_APPROVED":
                        mapper[i] = (e, v) => e.PM_APPROVED = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RECORD_SOURCE":
                        mapper[i] = (e, v) => e.RECORD_SOURCE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        #region Index Fields

        private Lazy<Dictionary<int, SXABCONV>> Index_SXABCONV_ID;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SXABCONV>>> Index_LW_DATE;
        private Lazy<Dictionary<Tuple<string, DateTime?>, SXABCONV>> Index_STKEY_ABSENCE_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>> Index_STKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SXABCONV>>> Index_ST_YEAR_LEVEL;
        private Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>> Index_AM_TYPE;
        private Lazy<NullDictionary<short?, IReadOnlyList<SXABCONV>>> Index_PM_TYPE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SXABCONV by SXABCONV_ID field
        /// </summary>
        /// <param name="SXABCONV_ID">SXABCONV_ID value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV FindBySXABCONV_ID(int SXABCONV_ID)
        {
            return Index_SXABCONV_ID.Value[SXABCONV_ID];
        }

        /// <summary>
        /// Attempt to find SXABCONV by SXABCONV_ID field
        /// </summary>
        /// <param name="SXABCONV_ID">SXABCONV_ID value used to find SXABCONV</param>
        /// <param name="Value">Related SXABCONV entity</param>
        /// <returns>True if the related SXABCONV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySXABCONV_ID(int SXABCONV_ID, out SXABCONV Value)
        {
            return Index_SXABCONV_ID.Value.TryGetValue(SXABCONV_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by SXABCONV_ID field
        /// </summary>
        /// <param name="SXABCONV_ID">SXABCONV_ID value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV TryFindBySXABCONV_ID(int SXABCONV_ID)
        {
            SXABCONV value;
            if (Index_SXABCONV_ID.Value.TryGetValue(SXABCONV_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXABCONV by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SXABCONV by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SXABCONV> value;
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
        /// Find SXABCONV by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV FindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE)
        {
            return Index_STKEY_ABSENCE_DATE.Value[Tuple.Create(STKEY, ABSENCE_DATE)];
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXABCONV</param>
        /// <param name="Value">Related SXABCONV entity</param>
        /// <returns>True if the related SXABCONV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE, out SXABCONV Value)
        {
            return Index_STKEY_ABSENCE_DATE.Value.TryGetValue(Tuple.Create(STKEY, ABSENCE_DATE), out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY and ABSENCE_DATE fields
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="ABSENCE_DATE">ABSENCE_DATE value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXABCONV TryFindBySTKEY_ABSENCE_DATE(string STKEY, DateTime? ABSENCE_DATE)
        {
            SXABCONV value;
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
        /// Find SXABCONV by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindBySTKEY(string STKEY)
        {
            IReadOnlyList<SXABCONV> value;
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
        /// Find SXABCONV by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            return Index_ST_YEAR_LEVEL.Value[ST_YEAR_LEVEL];
        }

        /// <summary>
        /// Attempt to find SXABCONV by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            IReadOnlyList<SXABCONV> value;
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
        /// Find SXABCONV by AM_TYPE field
        /// </summary>
        /// <param name="AM_TYPE">AM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByAM_TYPE(short? AM_TYPE)
        {
            return Index_AM_TYPE.Value[AM_TYPE];
        }

        /// <summary>
        /// Attempt to find SXABCONV by AM_TYPE field
        /// </summary>
        /// <param name="AM_TYPE">AM_TYPE value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAM_TYPE(short? AM_TYPE, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_AM_TYPE.Value.TryGetValue(AM_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by AM_TYPE field
        /// </summary>
        /// <param name="AM_TYPE">AM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByAM_TYPE(short? AM_TYPE)
        {
            IReadOnlyList<SXABCONV> value;
            if (Index_AM_TYPE.Value.TryGetValue(AM_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXABCONV by PM_TYPE field
        /// </summary>
        /// <param name="PM_TYPE">PM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> FindByPM_TYPE(short? PM_TYPE)
        {
            return Index_PM_TYPE.Value[PM_TYPE];
        }

        /// <summary>
        /// Attempt to find SXABCONV by PM_TYPE field
        /// </summary>
        /// <param name="PM_TYPE">PM_TYPE value used to find SXABCONV</param>
        /// <param name="Value">List of related SXABCONV entities</param>
        /// <returns>True if the list of related SXABCONV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPM_TYPE(short? PM_TYPE, out IReadOnlyList<SXABCONV> Value)
        {
            return Index_PM_TYPE.Value.TryGetValue(PM_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by PM_TYPE field
        /// </summary>
        /// <param name="PM_TYPE">PM_TYPE value used to find SXABCONV</param>
        /// <returns>List of related SXABCONV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXABCONV> TryFindByPM_TYPE(short? PM_TYPE)
        {
            IReadOnlyList<SXABCONV> value;
            if (Index_PM_TYPE.Value.TryGetValue(PM_TYPE, out value))
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
