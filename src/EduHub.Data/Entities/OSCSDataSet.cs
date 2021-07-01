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
    /// CASES Past Students Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class OSCSDataSet : EduHubDataSet<OSCS>
    {
        /// <inheritdoc />
        public override string Name { get { return "OSCS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal OSCSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ADULT_A_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ADULT_A_COUNTRY));
            Index_ADULT_B_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ADULT_B_COUNTRY));
            Index_BIRTH_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY));
            Index_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANG));
            Index_OSCSKEY = new Lazy<Dictionary<int, OSCS>>(() => this.ToDictionary(i => i.OSCSKEY));
            Index_SIXMTH_CAT = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.SIXMTH_CAT));
            Index_SIXMTH_CAT_DEST = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.SIXMTH_CAT_DEST));
            Index_ZEROMTH_CAT = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ZEROMTH_CAT));
            Index_ZEROMTH_CAT_DEST = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ZEROMTH_CAT_DEST));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="OSCS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="OSCS" /> fields for each CSV column header</returns>
        internal override Action<OSCS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<OSCS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "OSCSKEY":
                        mapper[i] = (e, v) => e.OSCSKEY = int.Parse(v);
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CURR_HOME_GROUP":
                        mapper[i] = (e, v) => e.CURR_HOME_GROUP = v;
                        break;
                    case "PREV_HOME_GROUP":
                        mapper[i] = (e, v) => e.PREV_HOME_GROUP = v;
                        break;
                    case "ABS_ALL_FEB":
                        mapper[i] = (e, v) => e.ABS_ALL_FEB = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABS_UNAP_FEB":
                        mapper[i] = (e, v) => e.ABS_UNAP_FEB = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ELIG_DAYS_FEB":
                        mapper[i] = (e, v) => e.ELIG_DAYS_FEB = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABS_ALL_AUG":
                        mapper[i] = (e, v) => e.ABS_ALL_AUG = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABS_UNAP_AUG":
                        mapper[i] = (e, v) => e.ABS_UNAP_AUG = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ELIG_DAYS_AUG":
                        mapper[i] = (e, v) => e.ELIG_DAYS_AUG = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "FEES_OWED":
                        mapper[i] = (e, v) => e.FEES_OWED = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FEES_PAID":
                        mapper[i] = (e, v) => e.FEES_PAID = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENT_NUMFEEDER":
                        mapper[i] = (e, v) => e.ENT_NUMFEEDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUM_FEEDER":
                        mapper[i] = (e, v) => e.NUM_FEEDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEEDER_SCHOOL":
                        mapper[i] = (e, v) => e.FEEDER_SCHOOL = v;
                        break;
                    case "NUM_CURRENT":
                        mapper[i] = (e, v) => e.NUM_CURRENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CURRENT_SCHOOL":
                        mapper[i] = (e, v) => e.CURRENT_SCHOOL = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ENT_NUMNEXTSCHL":
                        mapper[i] = (e, v) => e.ENT_NUMNEXTSCHL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUM_NEXTSCHL":
                        mapper[i] = (e, v) => e.NUM_NEXTSCHL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NEXT_SCHOOL":
                        mapper[i] = (e, v) => e.NEXT_SCHOOL = v;
                        break;
                    case "NEW_ADDRESS":
                        mapper[i] = (e, v) => e.NEW_ADDRESS = v;
                        break;
                    case "NEW_SUBURB":
                        mapper[i] = (e, v) => e.NEW_SUBURB = v;
                        break;
                    case "NEW_STATE":
                        mapper[i] = (e, v) => e.NEW_STATE = v;
                        break;
                    case "NEW_POSTCODE":
                        mapper[i] = (e, v) => e.NEW_POSTCODE = v;
                        break;
                    case "NEW_TELEPHONE":
                        mapper[i] = (e, v) => e.NEW_TELEPHONE = v;
                        break;
                    case "TRAN_DATE":
                        mapper[i] = (e, v) => e.TRAN_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ADULT_A_TITLE":
                        mapper[i] = (e, v) => e.ADULT_A_TITLE = v;
                        break;
                    case "ADULT_A_NAME":
                        mapper[i] = (e, v) => e.ADULT_A_NAME = v;
                        break;
                    case "ADULT_A_COUNTRY":
                        mapper[i] = (e, v) => e.ADULT_A_COUNTRY = v;
                        break;
                    case "ADULT_A_RELATION":
                        mapper[i] = (e, v) => e.ADULT_A_RELATION = v;
                        break;
                    case "ADULT_B_TITLE":
                        mapper[i] = (e, v) => e.ADULT_B_TITLE = v;
                        break;
                    case "ADULT_B_NAME":
                        mapper[i] = (e, v) => e.ADULT_B_NAME = v;
                        break;
                    case "ADULT_B_COUNTRY":
                        mapper[i] = (e, v) => e.ADULT_B_COUNTRY = v;
                        break;
                    case "ADULT_B_RELATION":
                        mapper[i] = (e, v) => e.ADULT_B_RELATION = v;
                        break;
                    case "REASON_TRAN1N":
                        mapper[i] = (e, v) => e.REASON_TRAN1N = v;
                        break;
                    case "REASON_TRAN2N":
                        mapper[i] = (e, v) => e.REASON_TRAN2N = v;
                        break;
                    case "CURR_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.CURR_YEAR_LEVEL = v;
                        break;
                    case "PREV_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.PREV_YEAR_LEVEL = v;
                        break;
                    case "VCE_NUM":
                        mapper[i] = (e, v) => e.VCE_NUM = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INCLUDE_CENSUS":
                        mapper[i] = (e, v) => e.INCLUDE_CENSUS = v;
                        break;
                    case "HMS_DATA_IN":
                        mapper[i] = (e, v) => e.HMS_DATA_IN = v;
                        break;
                    case "FAM_OCCUPATION":
                        mapper[i] = (e, v) => e.FAM_OCCUPATION = v;
                        break;
                    case "ZEROMTH_CAT":
                        mapper[i] = (e, v) => e.ZEROMTH_CAT = v;
                        break;
                    case "ZEROMTH_DEST":
                        mapper[i] = (e, v) => e.ZEROMTH_DEST = v;
                        break;
                    case "ZEROMTH_CAT_DEST":
                        mapper[i] = (e, v) => e.ZEROMTH_CAT_DEST = v;
                        break;
                    case "ZEROMTH_DATE":
                        mapper[i] = (e, v) => e.ZEROMTH_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "VISA_EXPIRY":
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TIME_FRACTION":
                        mapper[i] = (e, v) => e.TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ENROLLED":
                        mapper[i] = (e, v) => e.ENROLLED = v;
                        break;
                    case "A_SCHL_NUM":
                        mapper[i] = (e, v) => e.A_SCHL_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "A_SCHOOL_NUM":
                        mapper[i] = (e, v) => e.A_SCHOOL_NUM = v;
                        break;
                    case "A_TIME_FRACTION":
                        mapper[i] = (e, v) => e.A_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "A_ENROLLED":
                        mapper[i] = (e, v) => e.A_ENROLLED = v;
                        break;
                    case "B_SCHL_NUM":
                        mapper[i] = (e, v) => e.B_SCHL_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "B_SCHOOL_NUM":
                        mapper[i] = (e, v) => e.B_SCHOOL_NUM = v;
                        break;
                    case "B_TIME_FRACTION":
                        mapper[i] = (e, v) => e.B_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "B_ENROLLED":
                        mapper[i] = (e, v) => e.B_ENROLLED = v;
                        break;
                    case "C_SCHL_NUM":
                        mapper[i] = (e, v) => e.C_SCHL_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "C_SCHOOL_NUM":
                        mapper[i] = (e, v) => e.C_SCHOOL_NUM = v;
                        break;
                    case "C_TIME_FRACTION":
                        mapper[i] = (e, v) => e.C_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "C_ENROLLED":
                        mapper[i] = (e, v) => e.C_ENROLLED = v;
                        break;
                    case "D_SCHL_NUM":
                        mapper[i] = (e, v) => e.D_SCHL_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "D_SCHOOL_NUM":
                        mapper[i] = (e, v) => e.D_SCHOOL_NUM = v;
                        break;
                    case "D_TIME_FRACTION":
                        mapper[i] = (e, v) => e.D_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "D_ENROLLED":
                        mapper[i] = (e, v) => e.D_ENROLLED = v;
                        break;
                    case "STUD_TYPE":
                        mapper[i] = (e, v) => e.STUD_TYPE = v;
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "ARRIVAL":
                        mapper[i] = (e, v) => e.ARRIVAL = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "AUSSIE_SCHOOL":
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ENG_SPEAK":
                        mapper[i] = (e, v) => e.ENG_SPEAK = v;
                        break;
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "ED_ALLOW":
                        mapper[i] = (e, v) => e.ED_ALLOW = v;
                        break;
                    case "YOUTH_ALLOW":
                        mapper[i] = (e, v) => e.YOUTH_ALLOW = v;
                        break;
                    case "REL_INSTR":
                        mapper[i] = (e, v) => e.REL_INSTR = v;
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "INTEGRATION":
                        mapper[i] = (e, v) => e.INTEGRATION = v;
                        break;
                    case "REPEAT":
                        mapper[i] = (e, v) => e.REPEAT = v;
                        break;
                    case "RELIG_DENOM":
                        mapper[i] = (e, v) => e.RELIG_DENOM = v;
                        break;
                    case "DISABILITY_ID":
                        mapper[i] = (e, v) => e.DISABILITY_ID = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "HEARING_IMPAIR":
                        mapper[i] = (e, v) => e.HEARING_IMPAIR = v;
                        break;
                    case "VISUAL_IMPAIR":
                        mapper[i] = (e, v) => e.VISUAL_IMPAIR = v;
                        break;
                    case "SPEECH_IMPAIR":
                        mapper[i] = (e, v) => e.SPEECH_IMPAIR = v;
                        break;
                    case "PHYSICAL_IMPAIR":
                        mapper[i] = (e, v) => e.PHYSICAL_IMPAIR = v;
                        break;
                    case "IMMUNIZE":
                        mapper[i] = (e, v) => e.IMMUNIZE = v;
                        break;
                    case "DIPTHERIA_S":
                        mapper[i] = (e, v) => e.DIPTHERIA_S = v;
                        break;
                    case "TETANUS_S":
                        mapper[i] = (e, v) => e.TETANUS_S = v;
                        break;
                    case "POLIO_S":
                        mapper[i] = (e, v) => e.POLIO_S = v;
                        break;
                    case "MEASLES_S":
                        mapper[i] = (e, v) => e.MEASLES_S = v;
                        break;
                    case "MUMPS_S":
                        mapper[i] = (e, v) => e.MUMPS_S = v;
                        break;
                    case "MMR_S":
                        mapper[i] = (e, v) => e.MMR_S = v;
                        break;
                    case "HIB_S":
                        mapper[i] = (e, v) => e.HIB_S = v;
                        break;
                    case "PERTUSSIS_S":
                        mapper[i] = (e, v) => e.PERTUSSIS_S = v;
                        break;
                    case "RESIDENT_STATUS":
                        mapper[i] = (e, v) => e.RESIDENT_STATUS = v;
                        break;
                    case "VISA_CLASS":
                        mapper[i] = (e, v) => e.VISA_CLASS = v;
                        break;
                    case "VISA_STAT_CODE":
                        mapper[i] = (e, v) => e.VISA_STAT_CODE = v;
                        break;
                    case "ORDINARY_STUDENT":
                        mapper[i] = (e, v) => e.ORDINARY_STUDENT = v;
                        break;
                    case "FAM_STRUC_TYPE":
                        mapper[i] = (e, v) => e.FAM_STRUC_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CENSUSDAY_FEB":
                        mapper[i] = (e, v) => e.CENSUSDAY_FEB = v;
                        break;
                    case "CENSUSDAY_AUG":
                        mapper[i] = (e, v) => e.CENSUSDAY_AUG = v;
                        break;
                    case "SIXMTH_CAT":
                        mapper[i] = (e, v) => e.SIXMTH_CAT = v;
                        break;
                    case "SIXMTH_DEST":
                        mapper[i] = (e, v) => e.SIXMTH_DEST = v;
                        break;
                    case "SIXMTH_CAT_DEST":
                        mapper[i] = (e, v) => e.SIXMTH_CAT_DEST = v;
                        break;
                    case "SIXMTH_DATE":
                        mapper[i] = (e, v) => e.SIXMTH_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ISU_STD_NO":
                        mapper[i] = (e, v) => e.ISU_STD_NO = v;
                        break;
                    case "CENSUSDAY":
                        mapper[i] = (e, v) => e.CENSUSDAY = v;
                        break;
                    case "LAST_ABSENCE":
                        mapper[i] = (e, v) => e.LAST_ABSENCE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "YTD_ABSENCE":
                        mapper[i] = (e, v) => e.YTD_ABSENCE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "YTD_APPROVED":
                        mapper[i] = (e, v) => e.YTD_APPROVED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
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
        /// Merges <see cref="OSCS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="OSCS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="OSCS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{OSCS}"/> of entities</returns>
        internal override IEnumerable<OSCS> ApplyDeltaEntities(IEnumerable<OSCS> Entities, List<OSCS> DeltaEntities)
        {
            HashSet<int> Index_OSCSKEY = new HashSet<int>(DeltaEntities.Select(i => i.OSCSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.OSCSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_OSCSKEY.Remove(entity.OSCSKEY);
                            
                            if (entity.OSCSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ADULT_A_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ADULT_B_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_BIRTH_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_HOME_LANG;
        private Lazy<Dictionary<int, OSCS>> Index_OSCSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_SIXMTH_CAT;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_SIXMTH_CAT_DEST;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ZEROMTH_CAT;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ZEROMTH_CAT_DEST;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find OSCS by ADULT_A_COUNTRY field
        /// </summary>
        /// <param name="ADULT_A_COUNTRY">ADULT_A_COUNTRY value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindByADULT_A_COUNTRY(string ADULT_A_COUNTRY)
        {
            return Index_ADULT_A_COUNTRY.Value[ADULT_A_COUNTRY];
        }

        /// <summary>
        /// Attempt to find OSCS by ADULT_A_COUNTRY field
        /// </summary>
        /// <param name="ADULT_A_COUNTRY">ADULT_A_COUNTRY value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByADULT_A_COUNTRY(string ADULT_A_COUNTRY, out IReadOnlyList<OSCS> Value)
        {
            return Index_ADULT_A_COUNTRY.Value.TryGetValue(ADULT_A_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by ADULT_A_COUNTRY field
        /// </summary>
        /// <param name="ADULT_A_COUNTRY">ADULT_A_COUNTRY value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindByADULT_A_COUNTRY(string ADULT_A_COUNTRY)
        {
            IReadOnlyList<OSCS> value;
            if (Index_ADULT_A_COUNTRY.Value.TryGetValue(ADULT_A_COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by ADULT_B_COUNTRY field
        /// </summary>
        /// <param name="ADULT_B_COUNTRY">ADULT_B_COUNTRY value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindByADULT_B_COUNTRY(string ADULT_B_COUNTRY)
        {
            return Index_ADULT_B_COUNTRY.Value[ADULT_B_COUNTRY];
        }

        /// <summary>
        /// Attempt to find OSCS by ADULT_B_COUNTRY field
        /// </summary>
        /// <param name="ADULT_B_COUNTRY">ADULT_B_COUNTRY value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByADULT_B_COUNTRY(string ADULT_B_COUNTRY, out IReadOnlyList<OSCS> Value)
        {
            return Index_ADULT_B_COUNTRY.Value.TryGetValue(ADULT_B_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by ADULT_B_COUNTRY field
        /// </summary>
        /// <param name="ADULT_B_COUNTRY">ADULT_B_COUNTRY value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindByADULT_B_COUNTRY(string ADULT_B_COUNTRY)
        {
            IReadOnlyList<OSCS> value;
            if (Index_ADULT_B_COUNTRY.Value.TryGetValue(ADULT_B_COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindByBIRTH_COUNTRY(string BIRTH_COUNTRY)
        {
            return Index_BIRTH_COUNTRY.Value[BIRTH_COUNTRY];
        }

        /// <summary>
        /// Attempt to find OSCS by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBIRTH_COUNTRY(string BIRTH_COUNTRY, out IReadOnlyList<OSCS> Value)
        {
            return Index_BIRTH_COUNTRY.Value.TryGetValue(BIRTH_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindByBIRTH_COUNTRY(string BIRTH_COUNTRY)
        {
            IReadOnlyList<OSCS> value;
            if (Index_BIRTH_COUNTRY.Value.TryGetValue(BIRTH_COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindByHOME_LANG(string HOME_LANG)
        {
            return Index_HOME_LANG.Value[HOME_LANG];
        }

        /// <summary>
        /// Attempt to find OSCS by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_LANG(string HOME_LANG, out IReadOnlyList<OSCS> Value)
        {
            return Index_HOME_LANG.Value.TryGetValue(HOME_LANG, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindByHOME_LANG(string HOME_LANG)
        {
            IReadOnlyList<OSCS> value;
            if (Index_HOME_LANG.Value.TryGetValue(HOME_LANG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by OSCSKEY field
        /// </summary>
        /// <param name="OSCSKEY">OSCSKEY value used to find OSCS</param>
        /// <returns>Related OSCS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public OSCS FindByOSCSKEY(int OSCSKEY)
        {
            return Index_OSCSKEY.Value[OSCSKEY];
        }

        /// <summary>
        /// Attempt to find OSCS by OSCSKEY field
        /// </summary>
        /// <param name="OSCSKEY">OSCSKEY value used to find OSCS</param>
        /// <param name="Value">Related OSCS entity</param>
        /// <returns>True if the related OSCS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByOSCSKEY(int OSCSKEY, out OSCS Value)
        {
            return Index_OSCSKEY.Value.TryGetValue(OSCSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by OSCSKEY field
        /// </summary>
        /// <param name="OSCSKEY">OSCSKEY value used to find OSCS</param>
        /// <returns>Related OSCS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public OSCS TryFindByOSCSKEY(int OSCSKEY)
        {
            OSCS value;
            if (Index_OSCSKEY.Value.TryGetValue(OSCSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by SIXMTH_CAT field
        /// </summary>
        /// <param name="SIXMTH_CAT">SIXMTH_CAT value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindBySIXMTH_CAT(string SIXMTH_CAT)
        {
            return Index_SIXMTH_CAT.Value[SIXMTH_CAT];
        }

        /// <summary>
        /// Attempt to find OSCS by SIXMTH_CAT field
        /// </summary>
        /// <param name="SIXMTH_CAT">SIXMTH_CAT value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIXMTH_CAT(string SIXMTH_CAT, out IReadOnlyList<OSCS> Value)
        {
            return Index_SIXMTH_CAT.Value.TryGetValue(SIXMTH_CAT, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by SIXMTH_CAT field
        /// </summary>
        /// <param name="SIXMTH_CAT">SIXMTH_CAT value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindBySIXMTH_CAT(string SIXMTH_CAT)
        {
            IReadOnlyList<OSCS> value;
            if (Index_SIXMTH_CAT.Value.TryGetValue(SIXMTH_CAT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by SIXMTH_CAT_DEST field
        /// </summary>
        /// <param name="SIXMTH_CAT_DEST">SIXMTH_CAT_DEST value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindBySIXMTH_CAT_DEST(string SIXMTH_CAT_DEST)
        {
            return Index_SIXMTH_CAT_DEST.Value[SIXMTH_CAT_DEST];
        }

        /// <summary>
        /// Attempt to find OSCS by SIXMTH_CAT_DEST field
        /// </summary>
        /// <param name="SIXMTH_CAT_DEST">SIXMTH_CAT_DEST value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIXMTH_CAT_DEST(string SIXMTH_CAT_DEST, out IReadOnlyList<OSCS> Value)
        {
            return Index_SIXMTH_CAT_DEST.Value.TryGetValue(SIXMTH_CAT_DEST, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by SIXMTH_CAT_DEST field
        /// </summary>
        /// <param name="SIXMTH_CAT_DEST">SIXMTH_CAT_DEST value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindBySIXMTH_CAT_DEST(string SIXMTH_CAT_DEST)
        {
            IReadOnlyList<OSCS> value;
            if (Index_SIXMTH_CAT_DEST.Value.TryGetValue(SIXMTH_CAT_DEST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by ZEROMTH_CAT field
        /// </summary>
        /// <param name="ZEROMTH_CAT">ZEROMTH_CAT value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindByZEROMTH_CAT(string ZEROMTH_CAT)
        {
            return Index_ZEROMTH_CAT.Value[ZEROMTH_CAT];
        }

        /// <summary>
        /// Attempt to find OSCS by ZEROMTH_CAT field
        /// </summary>
        /// <param name="ZEROMTH_CAT">ZEROMTH_CAT value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByZEROMTH_CAT(string ZEROMTH_CAT, out IReadOnlyList<OSCS> Value)
        {
            return Index_ZEROMTH_CAT.Value.TryGetValue(ZEROMTH_CAT, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by ZEROMTH_CAT field
        /// </summary>
        /// <param name="ZEROMTH_CAT">ZEROMTH_CAT value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindByZEROMTH_CAT(string ZEROMTH_CAT)
        {
            IReadOnlyList<OSCS> value;
            if (Index_ZEROMTH_CAT.Value.TryGetValue(ZEROMTH_CAT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find OSCS by ZEROMTH_CAT_DEST field
        /// </summary>
        /// <param name="ZEROMTH_CAT_DEST">ZEROMTH_CAT_DEST value used to find OSCS</param>
        /// <returns>List of related OSCS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> FindByZEROMTH_CAT_DEST(string ZEROMTH_CAT_DEST)
        {
            return Index_ZEROMTH_CAT_DEST.Value[ZEROMTH_CAT_DEST];
        }

        /// <summary>
        /// Attempt to find OSCS by ZEROMTH_CAT_DEST field
        /// </summary>
        /// <param name="ZEROMTH_CAT_DEST">ZEROMTH_CAT_DEST value used to find OSCS</param>
        /// <param name="Value">List of related OSCS entities</param>
        /// <returns>True if the list of related OSCS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByZEROMTH_CAT_DEST(string ZEROMTH_CAT_DEST, out IReadOnlyList<OSCS> Value)
        {
            return Index_ZEROMTH_CAT_DEST.Value.TryGetValue(ZEROMTH_CAT_DEST, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by ZEROMTH_CAT_DEST field
        /// </summary>
        /// <param name="ZEROMTH_CAT_DEST">ZEROMTH_CAT_DEST value used to find OSCS</param>
        /// <returns>List of related OSCS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<OSCS> TryFindByZEROMTH_CAT_DEST(string ZEROMTH_CAT_DEST)
        {
            IReadOnlyList<OSCS> value;
            if (Index_ZEROMTH_CAT_DEST.Value.TryGetValue(ZEROMTH_CAT_DEST, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a OSCS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[OSCS](
        [OSCSKEY] int IDENTITY NOT NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [SECOND_NAME] varchar(20) NULL,
        [ADDRESS] varchar(50) NULL,
        [SUBURB] varchar(20) NULL,
        [STATE] varchar(17) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [BIRTHDATE] datetime NULL,
        [GENDER] varchar(1) NULL,
        [ENTRY] datetime NULL,
        [CURR_HOME_GROUP] varchar(3) NULL,
        [PREV_HOME_GROUP] varchar(3) NULL,
        [ABS_ALL_FEB] float NULL,
        [ABS_UNAP_FEB] float NULL,
        [ELIG_DAYS_FEB] float NULL,
        [ABS_ALL_AUG] float NULL,
        [ABS_UNAP_AUG] float NULL,
        [ELIG_DAYS_AUG] float NULL,
        [FEES_OWED] money NULL,
        [FEES_PAID] money NULL,
        [ENT_NUMFEEDER] smallint NULL,
        [NUM_FEEDER] smallint NULL,
        [FEEDER_SCHOOL] varchar(8) NULL,
        [NUM_CURRENT] smallint NULL,
        [CURRENT_SCHOOL] varchar(8) NULL,
        [CAMPUS] int NULL,
        [ENT_NUMNEXTSCHL] smallint NULL,
        [NUM_NEXTSCHL] smallint NULL,
        [NEXT_SCHOOL] varchar(8) NULL,
        [NEW_ADDRESS] varchar(50) NULL,
        [NEW_SUBURB] varchar(20) NULL,
        [NEW_STATE] varchar(17) NULL,
        [NEW_POSTCODE] varchar(4) NULL,
        [NEW_TELEPHONE] varchar(20) NULL,
        [TRAN_DATE] datetime NULL,
        [ADULT_A_TITLE] varchar(4) NULL,
        [ADULT_A_NAME] varchar(30) NULL,
        [ADULT_A_COUNTRY] varchar(6) NULL,
        [ADULT_A_RELATION] varchar(20) NULL,
        [ADULT_B_TITLE] varchar(4) NULL,
        [ADULT_B_NAME] varchar(30) NULL,
        [ADULT_B_COUNTRY] varchar(6) NULL,
        [ADULT_B_RELATION] varchar(20) NULL,
        [REASON_TRAN1N] varchar(50) NULL,
        [REASON_TRAN2N] varchar(50) NULL,
        [CURR_YEAR_LEVEL] varchar(4) NULL,
        [PREV_YEAR_LEVEL] varchar(4) NULL,
        [VCE_NUM] int NULL,
        [INCLUDE_CENSUS] varchar(1) NULL,
        [HMS_DATA_IN] varchar(1) NULL,
        [FAM_OCCUPATION] varchar(2) NULL,
        [ZEROMTH_CAT] varchar(2) NULL,
        [ZEROMTH_DEST] varchar(4) NULL,
        [ZEROMTH_CAT_DEST] varchar(6) NULL,
        [ZEROMTH_DATE] datetime NULL,
        [VISA_EXPIRY] datetime NULL,
        [TIME_FRACTION] float NULL,
        [ENROLLED] varchar(1) NULL,
        [A_SCHL_NUM] smallint NULL,
        [A_SCHOOL_NUM] varchar(8) NULL,
        [A_TIME_FRACTION] float NULL,
        [A_ENROLLED] varchar(1) NULL,
        [B_SCHL_NUM] smallint NULL,
        [B_SCHOOL_NUM] varchar(8) NULL,
        [B_TIME_FRACTION] float NULL,
        [B_ENROLLED] varchar(1) NULL,
        [C_SCHL_NUM] smallint NULL,
        [C_SCHOOL_NUM] varchar(8) NULL,
        [C_TIME_FRACTION] float NULL,
        [C_ENROLLED] varchar(1) NULL,
        [D_SCHL_NUM] smallint NULL,
        [D_SCHOOL_NUM] varchar(8) NULL,
        [D_TIME_FRACTION] float NULL,
        [D_ENROLLED] varchar(1) NULL,
        [STUD_TYPE] varchar(1) NULL,
        [BIRTH_COUNTRY] varchar(6) NULL,
        [ARRIVAL] datetime NULL,
        [AUSSIE_SCHOOL] datetime NULL,
        [ENG_SPEAK] varchar(1) NULL,
        [HOME_LANG] varchar(7) NULL,
        [ED_ALLOW] varchar(1) NULL,
        [YOUTH_ALLOW] varchar(1) NULL,
        [REL_INSTR] varchar(1) NULL,
        [KOORIE] varchar(1) NULL,
        [INTEGRATION] varchar(1) NULL,
        [REPEAT] varchar(1) NULL,
        [RELIG_DENOM] varchar(15) NULL,
        [DISABILITY_ID] varchar(6) NULL,
        [DISABILITY] varchar(1) NULL,
        [HEARING_IMPAIR] varchar(1) NULL,
        [VISUAL_IMPAIR] varchar(1) NULL,
        [SPEECH_IMPAIR] varchar(1) NULL,
        [PHYSICAL_IMPAIR] varchar(1) NULL,
        [IMMUNIZE] varchar(1) NULL,
        [DIPTHERIA_S] varchar(1) NULL,
        [TETANUS_S] varchar(1) NULL,
        [POLIO_S] varchar(1) NULL,
        [MEASLES_S] varchar(1) NULL,
        [MUMPS_S] varchar(1) NULL,
        [MMR_S] varchar(1) NULL,
        [HIB_S] varchar(1) NULL,
        [PERTUSSIS_S] varchar(1) NULL,
        [RESIDENT_STATUS] varchar(1) NULL,
        [VISA_CLASS] varchar(3) NULL,
        [VISA_STAT_CODE] varchar(4) NULL,
        [ORDINARY_STUDENT] varchar(1) NULL,
        [FAM_STRUC_TYPE] smallint NULL,
        [CENSUSDAY_FEB] varchar(1) NULL,
        [CENSUSDAY_AUG] varchar(1) NULL,
        [SIXMTH_CAT] varchar(2) NULL,
        [SIXMTH_DEST] varchar(4) NULL,
        [SIXMTH_CAT_DEST] varchar(6) NULL,
        [SIXMTH_DATE] datetime NULL,
        [ISU_STD_NO] varchar(7) NULL,
        [CENSUSDAY] varchar(1) NULL,
        [LAST_ABSENCE] datetime NULL,
        [YTD_ABSENCE] float NULL,
        [YTD_APPROVED] float NULL,
        [MOBILE] varchar(15) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [OSCS_Index_OSCSKEY] PRIMARY KEY CLUSTERED (
            [OSCSKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_ADULT_A_COUNTRY] ON [dbo].[OSCS]
    (
            [ADULT_A_COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_ADULT_B_COUNTRY] ON [dbo].[OSCS]
    (
            [ADULT_B_COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_BIRTH_COUNTRY] ON [dbo].[OSCS]
    (
            [BIRTH_COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_HOME_LANG] ON [dbo].[OSCS]
    (
            [HOME_LANG] ASC
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_SIXMTH_CAT] ON [dbo].[OSCS]
    (
            [SIXMTH_CAT] ASC
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_SIXMTH_CAT_DEST] ON [dbo].[OSCS]
    (
            [SIXMTH_CAT_DEST] ASC
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_ZEROMTH_CAT] ON [dbo].[OSCS]
    (
            [ZEROMTH_CAT] ASC
    );
    CREATE NONCLUSTERED INDEX [OSCS_Index_ZEROMTH_CAT_DEST] ON [dbo].[OSCS]
    (
            [ZEROMTH_CAT_DEST] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ADULT_A_COUNTRY')
    ALTER INDEX [Index_ADULT_A_COUNTRY] ON [dbo].[OSCS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ADULT_B_COUNTRY')
    ALTER INDEX [Index_ADULT_B_COUNTRY] ON [dbo].[OSCS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_BIRTH_COUNTRY')
    ALTER INDEX [Index_BIRTH_COUNTRY] ON [dbo].[OSCS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_HOME_LANG')
    ALTER INDEX [Index_HOME_LANG] ON [dbo].[OSCS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_SIXMTH_CAT')
    ALTER INDEX [Index_SIXMTH_CAT] ON [dbo].[OSCS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_SIXMTH_CAT_DEST')
    ALTER INDEX [Index_SIXMTH_CAT_DEST] ON [dbo].[OSCS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ZEROMTH_CAT')
    ALTER INDEX [Index_ZEROMTH_CAT] ON [dbo].[OSCS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ZEROMTH_CAT_DEST')
    ALTER INDEX [Index_ZEROMTH_CAT_DEST] ON [dbo].[OSCS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ADULT_A_COUNTRY')
    ALTER INDEX [Index_ADULT_A_COUNTRY] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ADULT_B_COUNTRY')
    ALTER INDEX [Index_ADULT_B_COUNTRY] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_BIRTH_COUNTRY')
    ALTER INDEX [Index_BIRTH_COUNTRY] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_HOME_LANG')
    ALTER INDEX [Index_HOME_LANG] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_SIXMTH_CAT')
    ALTER INDEX [Index_SIXMTH_CAT] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_SIXMTH_CAT_DEST')
    ALTER INDEX [Index_SIXMTH_CAT_DEST] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ZEROMTH_CAT')
    ALTER INDEX [Index_ZEROMTH_CAT] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[OSCS]') AND name = N'Index_ZEROMTH_CAT_DEST')
    ALTER INDEX [Index_ZEROMTH_CAT_DEST] ON [dbo].[OSCS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="OSCS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="OSCS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<OSCS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_OSCSKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_OSCSKEY.Add(entity.OSCSKEY);
            }

            builder.AppendLine("DELETE [dbo].[OSCS] WHERE");


            // Index_OSCSKEY
            builder.Append("[OSCSKEY] IN (");
            for (int index = 0; index < Index_OSCSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // OSCSKEY
                var parameterOSCSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterOSCSKEY);
                command.Parameters.Add(parameterOSCSKEY, SqlDbType.Int).Value = Index_OSCSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the OSCS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the OSCS data set</returns>
        public override EduHubDataSetDataReader<OSCS> GetDataSetDataReader()
        {
            return new OSCSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the OSCS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the OSCS data set</returns>
        public override EduHubDataSetDataReader<OSCS> GetDataSetDataReader(List<OSCS> Entities)
        {
            return new OSCSDataReader(new EduHubDataSetLoadedReader<OSCS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class OSCSDataReader : EduHubDataSetDataReader<OSCS>
        {
            public OSCSDataReader(IEduHubDataSetReader<OSCS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 124; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // OSCSKEY
                        return Current.OSCSKEY;
                    case 1: // SURNAME
                        return Current.SURNAME;
                    case 2: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 3: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 4: // ADDRESS
                        return Current.ADDRESS;
                    case 5: // SUBURB
                        return Current.SUBURB;
                    case 6: // STATE
                        return Current.STATE;
                    case 7: // POSTCODE
                        return Current.POSTCODE;
                    case 8: // TELEPHONE
                        return Current.TELEPHONE;
                    case 9: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 10: // GENDER
                        return Current.GENDER;
                    case 11: // ENTRY
                        return Current.ENTRY;
                    case 12: // CURR_HOME_GROUP
                        return Current.CURR_HOME_GROUP;
                    case 13: // PREV_HOME_GROUP
                        return Current.PREV_HOME_GROUP;
                    case 14: // ABS_ALL_FEB
                        return Current.ABS_ALL_FEB;
                    case 15: // ABS_UNAP_FEB
                        return Current.ABS_UNAP_FEB;
                    case 16: // ELIG_DAYS_FEB
                        return Current.ELIG_DAYS_FEB;
                    case 17: // ABS_ALL_AUG
                        return Current.ABS_ALL_AUG;
                    case 18: // ABS_UNAP_AUG
                        return Current.ABS_UNAP_AUG;
                    case 19: // ELIG_DAYS_AUG
                        return Current.ELIG_DAYS_AUG;
                    case 20: // FEES_OWED
                        return Current.FEES_OWED;
                    case 21: // FEES_PAID
                        return Current.FEES_PAID;
                    case 22: // ENT_NUMFEEDER
                        return Current.ENT_NUMFEEDER;
                    case 23: // NUM_FEEDER
                        return Current.NUM_FEEDER;
                    case 24: // FEEDER_SCHOOL
                        return Current.FEEDER_SCHOOL;
                    case 25: // NUM_CURRENT
                        return Current.NUM_CURRENT;
                    case 26: // CURRENT_SCHOOL
                        return Current.CURRENT_SCHOOL;
                    case 27: // CAMPUS
                        return Current.CAMPUS;
                    case 28: // ENT_NUMNEXTSCHL
                        return Current.ENT_NUMNEXTSCHL;
                    case 29: // NUM_NEXTSCHL
                        return Current.NUM_NEXTSCHL;
                    case 30: // NEXT_SCHOOL
                        return Current.NEXT_SCHOOL;
                    case 31: // NEW_ADDRESS
                        return Current.NEW_ADDRESS;
                    case 32: // NEW_SUBURB
                        return Current.NEW_SUBURB;
                    case 33: // NEW_STATE
                        return Current.NEW_STATE;
                    case 34: // NEW_POSTCODE
                        return Current.NEW_POSTCODE;
                    case 35: // NEW_TELEPHONE
                        return Current.NEW_TELEPHONE;
                    case 36: // TRAN_DATE
                        return Current.TRAN_DATE;
                    case 37: // ADULT_A_TITLE
                        return Current.ADULT_A_TITLE;
                    case 38: // ADULT_A_NAME
                        return Current.ADULT_A_NAME;
                    case 39: // ADULT_A_COUNTRY
                        return Current.ADULT_A_COUNTRY;
                    case 40: // ADULT_A_RELATION
                        return Current.ADULT_A_RELATION;
                    case 41: // ADULT_B_TITLE
                        return Current.ADULT_B_TITLE;
                    case 42: // ADULT_B_NAME
                        return Current.ADULT_B_NAME;
                    case 43: // ADULT_B_COUNTRY
                        return Current.ADULT_B_COUNTRY;
                    case 44: // ADULT_B_RELATION
                        return Current.ADULT_B_RELATION;
                    case 45: // REASON_TRAN1N
                        return Current.REASON_TRAN1N;
                    case 46: // REASON_TRAN2N
                        return Current.REASON_TRAN2N;
                    case 47: // CURR_YEAR_LEVEL
                        return Current.CURR_YEAR_LEVEL;
                    case 48: // PREV_YEAR_LEVEL
                        return Current.PREV_YEAR_LEVEL;
                    case 49: // VCE_NUM
                        return Current.VCE_NUM;
                    case 50: // INCLUDE_CENSUS
                        return Current.INCLUDE_CENSUS;
                    case 51: // HMS_DATA_IN
                        return Current.HMS_DATA_IN;
                    case 52: // FAM_OCCUPATION
                        return Current.FAM_OCCUPATION;
                    case 53: // ZEROMTH_CAT
                        return Current.ZEROMTH_CAT;
                    case 54: // ZEROMTH_DEST
                        return Current.ZEROMTH_DEST;
                    case 55: // ZEROMTH_CAT_DEST
                        return Current.ZEROMTH_CAT_DEST;
                    case 56: // ZEROMTH_DATE
                        return Current.ZEROMTH_DATE;
                    case 57: // VISA_EXPIRY
                        return Current.VISA_EXPIRY;
                    case 58: // TIME_FRACTION
                        return Current.TIME_FRACTION;
                    case 59: // ENROLLED
                        return Current.ENROLLED;
                    case 60: // A_SCHL_NUM
                        return Current.A_SCHL_NUM;
                    case 61: // A_SCHOOL_NUM
                        return Current.A_SCHOOL_NUM;
                    case 62: // A_TIME_FRACTION
                        return Current.A_TIME_FRACTION;
                    case 63: // A_ENROLLED
                        return Current.A_ENROLLED;
                    case 64: // B_SCHL_NUM
                        return Current.B_SCHL_NUM;
                    case 65: // B_SCHOOL_NUM
                        return Current.B_SCHOOL_NUM;
                    case 66: // B_TIME_FRACTION
                        return Current.B_TIME_FRACTION;
                    case 67: // B_ENROLLED
                        return Current.B_ENROLLED;
                    case 68: // C_SCHL_NUM
                        return Current.C_SCHL_NUM;
                    case 69: // C_SCHOOL_NUM
                        return Current.C_SCHOOL_NUM;
                    case 70: // C_TIME_FRACTION
                        return Current.C_TIME_FRACTION;
                    case 71: // C_ENROLLED
                        return Current.C_ENROLLED;
                    case 72: // D_SCHL_NUM
                        return Current.D_SCHL_NUM;
                    case 73: // D_SCHOOL_NUM
                        return Current.D_SCHOOL_NUM;
                    case 74: // D_TIME_FRACTION
                        return Current.D_TIME_FRACTION;
                    case 75: // D_ENROLLED
                        return Current.D_ENROLLED;
                    case 76: // STUD_TYPE
                        return Current.STUD_TYPE;
                    case 77: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY;
                    case 78: // ARRIVAL
                        return Current.ARRIVAL;
                    case 79: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL;
                    case 80: // ENG_SPEAK
                        return Current.ENG_SPEAK;
                    case 81: // HOME_LANG
                        return Current.HOME_LANG;
                    case 82: // ED_ALLOW
                        return Current.ED_ALLOW;
                    case 83: // YOUTH_ALLOW
                        return Current.YOUTH_ALLOW;
                    case 84: // REL_INSTR
                        return Current.REL_INSTR;
                    case 85: // KOORIE
                        return Current.KOORIE;
                    case 86: // INTEGRATION
                        return Current.INTEGRATION;
                    case 87: // REPEAT
                        return Current.REPEAT;
                    case 88: // RELIG_DENOM
                        return Current.RELIG_DENOM;
                    case 89: // DISABILITY_ID
                        return Current.DISABILITY_ID;
                    case 90: // DISABILITY
                        return Current.DISABILITY;
                    case 91: // HEARING_IMPAIR
                        return Current.HEARING_IMPAIR;
                    case 92: // VISUAL_IMPAIR
                        return Current.VISUAL_IMPAIR;
                    case 93: // SPEECH_IMPAIR
                        return Current.SPEECH_IMPAIR;
                    case 94: // PHYSICAL_IMPAIR
                        return Current.PHYSICAL_IMPAIR;
                    case 95: // IMMUNIZE
                        return Current.IMMUNIZE;
                    case 96: // DIPTHERIA_S
                        return Current.DIPTHERIA_S;
                    case 97: // TETANUS_S
                        return Current.TETANUS_S;
                    case 98: // POLIO_S
                        return Current.POLIO_S;
                    case 99: // MEASLES_S
                        return Current.MEASLES_S;
                    case 100: // MUMPS_S
                        return Current.MUMPS_S;
                    case 101: // MMR_S
                        return Current.MMR_S;
                    case 102: // HIB_S
                        return Current.HIB_S;
                    case 103: // PERTUSSIS_S
                        return Current.PERTUSSIS_S;
                    case 104: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS;
                    case 105: // VISA_CLASS
                        return Current.VISA_CLASS;
                    case 106: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE;
                    case 107: // ORDINARY_STUDENT
                        return Current.ORDINARY_STUDENT;
                    case 108: // FAM_STRUC_TYPE
                        return Current.FAM_STRUC_TYPE;
                    case 109: // CENSUSDAY_FEB
                        return Current.CENSUSDAY_FEB;
                    case 110: // CENSUSDAY_AUG
                        return Current.CENSUSDAY_AUG;
                    case 111: // SIXMTH_CAT
                        return Current.SIXMTH_CAT;
                    case 112: // SIXMTH_DEST
                        return Current.SIXMTH_DEST;
                    case 113: // SIXMTH_CAT_DEST
                        return Current.SIXMTH_CAT_DEST;
                    case 114: // SIXMTH_DATE
                        return Current.SIXMTH_DATE;
                    case 115: // ISU_STD_NO
                        return Current.ISU_STD_NO;
                    case 116: // CENSUSDAY
                        return Current.CENSUSDAY;
                    case 117: // LAST_ABSENCE
                        return Current.LAST_ABSENCE;
                    case 118: // YTD_ABSENCE
                        return Current.YTD_ABSENCE;
                    case 119: // YTD_APPROVED
                        return Current.YTD_APPROVED;
                    case 120: // MOBILE
                        return Current.MOBILE;
                    case 121: // LW_DATE
                        return Current.LW_DATE;
                    case 122: // LW_TIME
                        return Current.LW_TIME;
                    case 123: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SURNAME
                        return Current.SURNAME == null;
                    case 2: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 3: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 4: // ADDRESS
                        return Current.ADDRESS == null;
                    case 5: // SUBURB
                        return Current.SUBURB == null;
                    case 6: // STATE
                        return Current.STATE == null;
                    case 7: // POSTCODE
                        return Current.POSTCODE == null;
                    case 8: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 9: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 10: // GENDER
                        return Current.GENDER == null;
                    case 11: // ENTRY
                        return Current.ENTRY == null;
                    case 12: // CURR_HOME_GROUP
                        return Current.CURR_HOME_GROUP == null;
                    case 13: // PREV_HOME_GROUP
                        return Current.PREV_HOME_GROUP == null;
                    case 14: // ABS_ALL_FEB
                        return Current.ABS_ALL_FEB == null;
                    case 15: // ABS_UNAP_FEB
                        return Current.ABS_UNAP_FEB == null;
                    case 16: // ELIG_DAYS_FEB
                        return Current.ELIG_DAYS_FEB == null;
                    case 17: // ABS_ALL_AUG
                        return Current.ABS_ALL_AUG == null;
                    case 18: // ABS_UNAP_AUG
                        return Current.ABS_UNAP_AUG == null;
                    case 19: // ELIG_DAYS_AUG
                        return Current.ELIG_DAYS_AUG == null;
                    case 20: // FEES_OWED
                        return Current.FEES_OWED == null;
                    case 21: // FEES_PAID
                        return Current.FEES_PAID == null;
                    case 22: // ENT_NUMFEEDER
                        return Current.ENT_NUMFEEDER == null;
                    case 23: // NUM_FEEDER
                        return Current.NUM_FEEDER == null;
                    case 24: // FEEDER_SCHOOL
                        return Current.FEEDER_SCHOOL == null;
                    case 25: // NUM_CURRENT
                        return Current.NUM_CURRENT == null;
                    case 26: // CURRENT_SCHOOL
                        return Current.CURRENT_SCHOOL == null;
                    case 27: // CAMPUS
                        return Current.CAMPUS == null;
                    case 28: // ENT_NUMNEXTSCHL
                        return Current.ENT_NUMNEXTSCHL == null;
                    case 29: // NUM_NEXTSCHL
                        return Current.NUM_NEXTSCHL == null;
                    case 30: // NEXT_SCHOOL
                        return Current.NEXT_SCHOOL == null;
                    case 31: // NEW_ADDRESS
                        return Current.NEW_ADDRESS == null;
                    case 32: // NEW_SUBURB
                        return Current.NEW_SUBURB == null;
                    case 33: // NEW_STATE
                        return Current.NEW_STATE == null;
                    case 34: // NEW_POSTCODE
                        return Current.NEW_POSTCODE == null;
                    case 35: // NEW_TELEPHONE
                        return Current.NEW_TELEPHONE == null;
                    case 36: // TRAN_DATE
                        return Current.TRAN_DATE == null;
                    case 37: // ADULT_A_TITLE
                        return Current.ADULT_A_TITLE == null;
                    case 38: // ADULT_A_NAME
                        return Current.ADULT_A_NAME == null;
                    case 39: // ADULT_A_COUNTRY
                        return Current.ADULT_A_COUNTRY == null;
                    case 40: // ADULT_A_RELATION
                        return Current.ADULT_A_RELATION == null;
                    case 41: // ADULT_B_TITLE
                        return Current.ADULT_B_TITLE == null;
                    case 42: // ADULT_B_NAME
                        return Current.ADULT_B_NAME == null;
                    case 43: // ADULT_B_COUNTRY
                        return Current.ADULT_B_COUNTRY == null;
                    case 44: // ADULT_B_RELATION
                        return Current.ADULT_B_RELATION == null;
                    case 45: // REASON_TRAN1N
                        return Current.REASON_TRAN1N == null;
                    case 46: // REASON_TRAN2N
                        return Current.REASON_TRAN2N == null;
                    case 47: // CURR_YEAR_LEVEL
                        return Current.CURR_YEAR_LEVEL == null;
                    case 48: // PREV_YEAR_LEVEL
                        return Current.PREV_YEAR_LEVEL == null;
                    case 49: // VCE_NUM
                        return Current.VCE_NUM == null;
                    case 50: // INCLUDE_CENSUS
                        return Current.INCLUDE_CENSUS == null;
                    case 51: // HMS_DATA_IN
                        return Current.HMS_DATA_IN == null;
                    case 52: // FAM_OCCUPATION
                        return Current.FAM_OCCUPATION == null;
                    case 53: // ZEROMTH_CAT
                        return Current.ZEROMTH_CAT == null;
                    case 54: // ZEROMTH_DEST
                        return Current.ZEROMTH_DEST == null;
                    case 55: // ZEROMTH_CAT_DEST
                        return Current.ZEROMTH_CAT_DEST == null;
                    case 56: // ZEROMTH_DATE
                        return Current.ZEROMTH_DATE == null;
                    case 57: // VISA_EXPIRY
                        return Current.VISA_EXPIRY == null;
                    case 58: // TIME_FRACTION
                        return Current.TIME_FRACTION == null;
                    case 59: // ENROLLED
                        return Current.ENROLLED == null;
                    case 60: // A_SCHL_NUM
                        return Current.A_SCHL_NUM == null;
                    case 61: // A_SCHOOL_NUM
                        return Current.A_SCHOOL_NUM == null;
                    case 62: // A_TIME_FRACTION
                        return Current.A_TIME_FRACTION == null;
                    case 63: // A_ENROLLED
                        return Current.A_ENROLLED == null;
                    case 64: // B_SCHL_NUM
                        return Current.B_SCHL_NUM == null;
                    case 65: // B_SCHOOL_NUM
                        return Current.B_SCHOOL_NUM == null;
                    case 66: // B_TIME_FRACTION
                        return Current.B_TIME_FRACTION == null;
                    case 67: // B_ENROLLED
                        return Current.B_ENROLLED == null;
                    case 68: // C_SCHL_NUM
                        return Current.C_SCHL_NUM == null;
                    case 69: // C_SCHOOL_NUM
                        return Current.C_SCHOOL_NUM == null;
                    case 70: // C_TIME_FRACTION
                        return Current.C_TIME_FRACTION == null;
                    case 71: // C_ENROLLED
                        return Current.C_ENROLLED == null;
                    case 72: // D_SCHL_NUM
                        return Current.D_SCHL_NUM == null;
                    case 73: // D_SCHOOL_NUM
                        return Current.D_SCHOOL_NUM == null;
                    case 74: // D_TIME_FRACTION
                        return Current.D_TIME_FRACTION == null;
                    case 75: // D_ENROLLED
                        return Current.D_ENROLLED == null;
                    case 76: // STUD_TYPE
                        return Current.STUD_TYPE == null;
                    case 77: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY == null;
                    case 78: // ARRIVAL
                        return Current.ARRIVAL == null;
                    case 79: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL == null;
                    case 80: // ENG_SPEAK
                        return Current.ENG_SPEAK == null;
                    case 81: // HOME_LANG
                        return Current.HOME_LANG == null;
                    case 82: // ED_ALLOW
                        return Current.ED_ALLOW == null;
                    case 83: // YOUTH_ALLOW
                        return Current.YOUTH_ALLOW == null;
                    case 84: // REL_INSTR
                        return Current.REL_INSTR == null;
                    case 85: // KOORIE
                        return Current.KOORIE == null;
                    case 86: // INTEGRATION
                        return Current.INTEGRATION == null;
                    case 87: // REPEAT
                        return Current.REPEAT == null;
                    case 88: // RELIG_DENOM
                        return Current.RELIG_DENOM == null;
                    case 89: // DISABILITY_ID
                        return Current.DISABILITY_ID == null;
                    case 90: // DISABILITY
                        return Current.DISABILITY == null;
                    case 91: // HEARING_IMPAIR
                        return Current.HEARING_IMPAIR == null;
                    case 92: // VISUAL_IMPAIR
                        return Current.VISUAL_IMPAIR == null;
                    case 93: // SPEECH_IMPAIR
                        return Current.SPEECH_IMPAIR == null;
                    case 94: // PHYSICAL_IMPAIR
                        return Current.PHYSICAL_IMPAIR == null;
                    case 95: // IMMUNIZE
                        return Current.IMMUNIZE == null;
                    case 96: // DIPTHERIA_S
                        return Current.DIPTHERIA_S == null;
                    case 97: // TETANUS_S
                        return Current.TETANUS_S == null;
                    case 98: // POLIO_S
                        return Current.POLIO_S == null;
                    case 99: // MEASLES_S
                        return Current.MEASLES_S == null;
                    case 100: // MUMPS_S
                        return Current.MUMPS_S == null;
                    case 101: // MMR_S
                        return Current.MMR_S == null;
                    case 102: // HIB_S
                        return Current.HIB_S == null;
                    case 103: // PERTUSSIS_S
                        return Current.PERTUSSIS_S == null;
                    case 104: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS == null;
                    case 105: // VISA_CLASS
                        return Current.VISA_CLASS == null;
                    case 106: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE == null;
                    case 107: // ORDINARY_STUDENT
                        return Current.ORDINARY_STUDENT == null;
                    case 108: // FAM_STRUC_TYPE
                        return Current.FAM_STRUC_TYPE == null;
                    case 109: // CENSUSDAY_FEB
                        return Current.CENSUSDAY_FEB == null;
                    case 110: // CENSUSDAY_AUG
                        return Current.CENSUSDAY_AUG == null;
                    case 111: // SIXMTH_CAT
                        return Current.SIXMTH_CAT == null;
                    case 112: // SIXMTH_DEST
                        return Current.SIXMTH_DEST == null;
                    case 113: // SIXMTH_CAT_DEST
                        return Current.SIXMTH_CAT_DEST == null;
                    case 114: // SIXMTH_DATE
                        return Current.SIXMTH_DATE == null;
                    case 115: // ISU_STD_NO
                        return Current.ISU_STD_NO == null;
                    case 116: // CENSUSDAY
                        return Current.CENSUSDAY == null;
                    case 117: // LAST_ABSENCE
                        return Current.LAST_ABSENCE == null;
                    case 118: // YTD_ABSENCE
                        return Current.YTD_ABSENCE == null;
                    case 119: // YTD_APPROVED
                        return Current.YTD_APPROVED == null;
                    case 120: // MOBILE
                        return Current.MOBILE == null;
                    case 121: // LW_DATE
                        return Current.LW_DATE == null;
                    case 122: // LW_TIME
                        return Current.LW_TIME == null;
                    case 123: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // OSCSKEY
                        return "OSCSKEY";
                    case 1: // SURNAME
                        return "SURNAME";
                    case 2: // FIRST_NAME
                        return "FIRST_NAME";
                    case 3: // SECOND_NAME
                        return "SECOND_NAME";
                    case 4: // ADDRESS
                        return "ADDRESS";
                    case 5: // SUBURB
                        return "SUBURB";
                    case 6: // STATE
                        return "STATE";
                    case 7: // POSTCODE
                        return "POSTCODE";
                    case 8: // TELEPHONE
                        return "TELEPHONE";
                    case 9: // BIRTHDATE
                        return "BIRTHDATE";
                    case 10: // GENDER
                        return "GENDER";
                    case 11: // ENTRY
                        return "ENTRY";
                    case 12: // CURR_HOME_GROUP
                        return "CURR_HOME_GROUP";
                    case 13: // PREV_HOME_GROUP
                        return "PREV_HOME_GROUP";
                    case 14: // ABS_ALL_FEB
                        return "ABS_ALL_FEB";
                    case 15: // ABS_UNAP_FEB
                        return "ABS_UNAP_FEB";
                    case 16: // ELIG_DAYS_FEB
                        return "ELIG_DAYS_FEB";
                    case 17: // ABS_ALL_AUG
                        return "ABS_ALL_AUG";
                    case 18: // ABS_UNAP_AUG
                        return "ABS_UNAP_AUG";
                    case 19: // ELIG_DAYS_AUG
                        return "ELIG_DAYS_AUG";
                    case 20: // FEES_OWED
                        return "FEES_OWED";
                    case 21: // FEES_PAID
                        return "FEES_PAID";
                    case 22: // ENT_NUMFEEDER
                        return "ENT_NUMFEEDER";
                    case 23: // NUM_FEEDER
                        return "NUM_FEEDER";
                    case 24: // FEEDER_SCHOOL
                        return "FEEDER_SCHOOL";
                    case 25: // NUM_CURRENT
                        return "NUM_CURRENT";
                    case 26: // CURRENT_SCHOOL
                        return "CURRENT_SCHOOL";
                    case 27: // CAMPUS
                        return "CAMPUS";
                    case 28: // ENT_NUMNEXTSCHL
                        return "ENT_NUMNEXTSCHL";
                    case 29: // NUM_NEXTSCHL
                        return "NUM_NEXTSCHL";
                    case 30: // NEXT_SCHOOL
                        return "NEXT_SCHOOL";
                    case 31: // NEW_ADDRESS
                        return "NEW_ADDRESS";
                    case 32: // NEW_SUBURB
                        return "NEW_SUBURB";
                    case 33: // NEW_STATE
                        return "NEW_STATE";
                    case 34: // NEW_POSTCODE
                        return "NEW_POSTCODE";
                    case 35: // NEW_TELEPHONE
                        return "NEW_TELEPHONE";
                    case 36: // TRAN_DATE
                        return "TRAN_DATE";
                    case 37: // ADULT_A_TITLE
                        return "ADULT_A_TITLE";
                    case 38: // ADULT_A_NAME
                        return "ADULT_A_NAME";
                    case 39: // ADULT_A_COUNTRY
                        return "ADULT_A_COUNTRY";
                    case 40: // ADULT_A_RELATION
                        return "ADULT_A_RELATION";
                    case 41: // ADULT_B_TITLE
                        return "ADULT_B_TITLE";
                    case 42: // ADULT_B_NAME
                        return "ADULT_B_NAME";
                    case 43: // ADULT_B_COUNTRY
                        return "ADULT_B_COUNTRY";
                    case 44: // ADULT_B_RELATION
                        return "ADULT_B_RELATION";
                    case 45: // REASON_TRAN1N
                        return "REASON_TRAN1N";
                    case 46: // REASON_TRAN2N
                        return "REASON_TRAN2N";
                    case 47: // CURR_YEAR_LEVEL
                        return "CURR_YEAR_LEVEL";
                    case 48: // PREV_YEAR_LEVEL
                        return "PREV_YEAR_LEVEL";
                    case 49: // VCE_NUM
                        return "VCE_NUM";
                    case 50: // INCLUDE_CENSUS
                        return "INCLUDE_CENSUS";
                    case 51: // HMS_DATA_IN
                        return "HMS_DATA_IN";
                    case 52: // FAM_OCCUPATION
                        return "FAM_OCCUPATION";
                    case 53: // ZEROMTH_CAT
                        return "ZEROMTH_CAT";
                    case 54: // ZEROMTH_DEST
                        return "ZEROMTH_DEST";
                    case 55: // ZEROMTH_CAT_DEST
                        return "ZEROMTH_CAT_DEST";
                    case 56: // ZEROMTH_DATE
                        return "ZEROMTH_DATE";
                    case 57: // VISA_EXPIRY
                        return "VISA_EXPIRY";
                    case 58: // TIME_FRACTION
                        return "TIME_FRACTION";
                    case 59: // ENROLLED
                        return "ENROLLED";
                    case 60: // A_SCHL_NUM
                        return "A_SCHL_NUM";
                    case 61: // A_SCHOOL_NUM
                        return "A_SCHOOL_NUM";
                    case 62: // A_TIME_FRACTION
                        return "A_TIME_FRACTION";
                    case 63: // A_ENROLLED
                        return "A_ENROLLED";
                    case 64: // B_SCHL_NUM
                        return "B_SCHL_NUM";
                    case 65: // B_SCHOOL_NUM
                        return "B_SCHOOL_NUM";
                    case 66: // B_TIME_FRACTION
                        return "B_TIME_FRACTION";
                    case 67: // B_ENROLLED
                        return "B_ENROLLED";
                    case 68: // C_SCHL_NUM
                        return "C_SCHL_NUM";
                    case 69: // C_SCHOOL_NUM
                        return "C_SCHOOL_NUM";
                    case 70: // C_TIME_FRACTION
                        return "C_TIME_FRACTION";
                    case 71: // C_ENROLLED
                        return "C_ENROLLED";
                    case 72: // D_SCHL_NUM
                        return "D_SCHL_NUM";
                    case 73: // D_SCHOOL_NUM
                        return "D_SCHOOL_NUM";
                    case 74: // D_TIME_FRACTION
                        return "D_TIME_FRACTION";
                    case 75: // D_ENROLLED
                        return "D_ENROLLED";
                    case 76: // STUD_TYPE
                        return "STUD_TYPE";
                    case 77: // BIRTH_COUNTRY
                        return "BIRTH_COUNTRY";
                    case 78: // ARRIVAL
                        return "ARRIVAL";
                    case 79: // AUSSIE_SCHOOL
                        return "AUSSIE_SCHOOL";
                    case 80: // ENG_SPEAK
                        return "ENG_SPEAK";
                    case 81: // HOME_LANG
                        return "HOME_LANG";
                    case 82: // ED_ALLOW
                        return "ED_ALLOW";
                    case 83: // YOUTH_ALLOW
                        return "YOUTH_ALLOW";
                    case 84: // REL_INSTR
                        return "REL_INSTR";
                    case 85: // KOORIE
                        return "KOORIE";
                    case 86: // INTEGRATION
                        return "INTEGRATION";
                    case 87: // REPEAT
                        return "REPEAT";
                    case 88: // RELIG_DENOM
                        return "RELIG_DENOM";
                    case 89: // DISABILITY_ID
                        return "DISABILITY_ID";
                    case 90: // DISABILITY
                        return "DISABILITY";
                    case 91: // HEARING_IMPAIR
                        return "HEARING_IMPAIR";
                    case 92: // VISUAL_IMPAIR
                        return "VISUAL_IMPAIR";
                    case 93: // SPEECH_IMPAIR
                        return "SPEECH_IMPAIR";
                    case 94: // PHYSICAL_IMPAIR
                        return "PHYSICAL_IMPAIR";
                    case 95: // IMMUNIZE
                        return "IMMUNIZE";
                    case 96: // DIPTHERIA_S
                        return "DIPTHERIA_S";
                    case 97: // TETANUS_S
                        return "TETANUS_S";
                    case 98: // POLIO_S
                        return "POLIO_S";
                    case 99: // MEASLES_S
                        return "MEASLES_S";
                    case 100: // MUMPS_S
                        return "MUMPS_S";
                    case 101: // MMR_S
                        return "MMR_S";
                    case 102: // HIB_S
                        return "HIB_S";
                    case 103: // PERTUSSIS_S
                        return "PERTUSSIS_S";
                    case 104: // RESIDENT_STATUS
                        return "RESIDENT_STATUS";
                    case 105: // VISA_CLASS
                        return "VISA_CLASS";
                    case 106: // VISA_STAT_CODE
                        return "VISA_STAT_CODE";
                    case 107: // ORDINARY_STUDENT
                        return "ORDINARY_STUDENT";
                    case 108: // FAM_STRUC_TYPE
                        return "FAM_STRUC_TYPE";
                    case 109: // CENSUSDAY_FEB
                        return "CENSUSDAY_FEB";
                    case 110: // CENSUSDAY_AUG
                        return "CENSUSDAY_AUG";
                    case 111: // SIXMTH_CAT
                        return "SIXMTH_CAT";
                    case 112: // SIXMTH_DEST
                        return "SIXMTH_DEST";
                    case 113: // SIXMTH_CAT_DEST
                        return "SIXMTH_CAT_DEST";
                    case 114: // SIXMTH_DATE
                        return "SIXMTH_DATE";
                    case 115: // ISU_STD_NO
                        return "ISU_STD_NO";
                    case 116: // CENSUSDAY
                        return "CENSUSDAY";
                    case 117: // LAST_ABSENCE
                        return "LAST_ABSENCE";
                    case 118: // YTD_ABSENCE
                        return "YTD_ABSENCE";
                    case 119: // YTD_APPROVED
                        return "YTD_APPROVED";
                    case 120: // MOBILE
                        return "MOBILE";
                    case 121: // LW_DATE
                        return "LW_DATE";
                    case 122: // LW_TIME
                        return "LW_TIME";
                    case 123: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "OSCSKEY":
                        return 0;
                    case "SURNAME":
                        return 1;
                    case "FIRST_NAME":
                        return 2;
                    case "SECOND_NAME":
                        return 3;
                    case "ADDRESS":
                        return 4;
                    case "SUBURB":
                        return 5;
                    case "STATE":
                        return 6;
                    case "POSTCODE":
                        return 7;
                    case "TELEPHONE":
                        return 8;
                    case "BIRTHDATE":
                        return 9;
                    case "GENDER":
                        return 10;
                    case "ENTRY":
                        return 11;
                    case "CURR_HOME_GROUP":
                        return 12;
                    case "PREV_HOME_GROUP":
                        return 13;
                    case "ABS_ALL_FEB":
                        return 14;
                    case "ABS_UNAP_FEB":
                        return 15;
                    case "ELIG_DAYS_FEB":
                        return 16;
                    case "ABS_ALL_AUG":
                        return 17;
                    case "ABS_UNAP_AUG":
                        return 18;
                    case "ELIG_DAYS_AUG":
                        return 19;
                    case "FEES_OWED":
                        return 20;
                    case "FEES_PAID":
                        return 21;
                    case "ENT_NUMFEEDER":
                        return 22;
                    case "NUM_FEEDER":
                        return 23;
                    case "FEEDER_SCHOOL":
                        return 24;
                    case "NUM_CURRENT":
                        return 25;
                    case "CURRENT_SCHOOL":
                        return 26;
                    case "CAMPUS":
                        return 27;
                    case "ENT_NUMNEXTSCHL":
                        return 28;
                    case "NUM_NEXTSCHL":
                        return 29;
                    case "NEXT_SCHOOL":
                        return 30;
                    case "NEW_ADDRESS":
                        return 31;
                    case "NEW_SUBURB":
                        return 32;
                    case "NEW_STATE":
                        return 33;
                    case "NEW_POSTCODE":
                        return 34;
                    case "NEW_TELEPHONE":
                        return 35;
                    case "TRAN_DATE":
                        return 36;
                    case "ADULT_A_TITLE":
                        return 37;
                    case "ADULT_A_NAME":
                        return 38;
                    case "ADULT_A_COUNTRY":
                        return 39;
                    case "ADULT_A_RELATION":
                        return 40;
                    case "ADULT_B_TITLE":
                        return 41;
                    case "ADULT_B_NAME":
                        return 42;
                    case "ADULT_B_COUNTRY":
                        return 43;
                    case "ADULT_B_RELATION":
                        return 44;
                    case "REASON_TRAN1N":
                        return 45;
                    case "REASON_TRAN2N":
                        return 46;
                    case "CURR_YEAR_LEVEL":
                        return 47;
                    case "PREV_YEAR_LEVEL":
                        return 48;
                    case "VCE_NUM":
                        return 49;
                    case "INCLUDE_CENSUS":
                        return 50;
                    case "HMS_DATA_IN":
                        return 51;
                    case "FAM_OCCUPATION":
                        return 52;
                    case "ZEROMTH_CAT":
                        return 53;
                    case "ZEROMTH_DEST":
                        return 54;
                    case "ZEROMTH_CAT_DEST":
                        return 55;
                    case "ZEROMTH_DATE":
                        return 56;
                    case "VISA_EXPIRY":
                        return 57;
                    case "TIME_FRACTION":
                        return 58;
                    case "ENROLLED":
                        return 59;
                    case "A_SCHL_NUM":
                        return 60;
                    case "A_SCHOOL_NUM":
                        return 61;
                    case "A_TIME_FRACTION":
                        return 62;
                    case "A_ENROLLED":
                        return 63;
                    case "B_SCHL_NUM":
                        return 64;
                    case "B_SCHOOL_NUM":
                        return 65;
                    case "B_TIME_FRACTION":
                        return 66;
                    case "B_ENROLLED":
                        return 67;
                    case "C_SCHL_NUM":
                        return 68;
                    case "C_SCHOOL_NUM":
                        return 69;
                    case "C_TIME_FRACTION":
                        return 70;
                    case "C_ENROLLED":
                        return 71;
                    case "D_SCHL_NUM":
                        return 72;
                    case "D_SCHOOL_NUM":
                        return 73;
                    case "D_TIME_FRACTION":
                        return 74;
                    case "D_ENROLLED":
                        return 75;
                    case "STUD_TYPE":
                        return 76;
                    case "BIRTH_COUNTRY":
                        return 77;
                    case "ARRIVAL":
                        return 78;
                    case "AUSSIE_SCHOOL":
                        return 79;
                    case "ENG_SPEAK":
                        return 80;
                    case "HOME_LANG":
                        return 81;
                    case "ED_ALLOW":
                        return 82;
                    case "YOUTH_ALLOW":
                        return 83;
                    case "REL_INSTR":
                        return 84;
                    case "KOORIE":
                        return 85;
                    case "INTEGRATION":
                        return 86;
                    case "REPEAT":
                        return 87;
                    case "RELIG_DENOM":
                        return 88;
                    case "DISABILITY_ID":
                        return 89;
                    case "DISABILITY":
                        return 90;
                    case "HEARING_IMPAIR":
                        return 91;
                    case "VISUAL_IMPAIR":
                        return 92;
                    case "SPEECH_IMPAIR":
                        return 93;
                    case "PHYSICAL_IMPAIR":
                        return 94;
                    case "IMMUNIZE":
                        return 95;
                    case "DIPTHERIA_S":
                        return 96;
                    case "TETANUS_S":
                        return 97;
                    case "POLIO_S":
                        return 98;
                    case "MEASLES_S":
                        return 99;
                    case "MUMPS_S":
                        return 100;
                    case "MMR_S":
                        return 101;
                    case "HIB_S":
                        return 102;
                    case "PERTUSSIS_S":
                        return 103;
                    case "RESIDENT_STATUS":
                        return 104;
                    case "VISA_CLASS":
                        return 105;
                    case "VISA_STAT_CODE":
                        return 106;
                    case "ORDINARY_STUDENT":
                        return 107;
                    case "FAM_STRUC_TYPE":
                        return 108;
                    case "CENSUSDAY_FEB":
                        return 109;
                    case "CENSUSDAY_AUG":
                        return 110;
                    case "SIXMTH_CAT":
                        return 111;
                    case "SIXMTH_DEST":
                        return 112;
                    case "SIXMTH_CAT_DEST":
                        return 113;
                    case "SIXMTH_DATE":
                        return 114;
                    case "ISU_STD_NO":
                        return 115;
                    case "CENSUSDAY":
                        return 116;
                    case "LAST_ABSENCE":
                        return 117;
                    case "YTD_ABSENCE":
                        return 118;
                    case "YTD_APPROVED":
                        return 119;
                    case "MOBILE":
                        return 120;
                    case "LW_DATE":
                        return 121;
                    case "LW_TIME":
                        return 122;
                    case "LW_USER":
                        return 123;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
