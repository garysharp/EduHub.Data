using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CASES Past Students Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class OSCSDataSet : SetBase<OSCS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "OSCS"; } }

        internal OSCSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_OSCSKEY = new Lazy<Dictionary<int, OSCS>>(() => this.ToDictionary(i => i.OSCSKEY));
            Index_ADULT_A_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ADULT_A_COUNTRY));
            Index_ADULT_B_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ADULT_B_COUNTRY));
            Index_ZEROMTH_CAT = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ZEROMTH_CAT));
            Index_ZEROMTH_CAT_DEST = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.ZEROMTH_CAT_DEST));
            Index_BIRTH_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY));
            Index_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANG));
            Index_SIXMTH_CAT = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.SIXMTH_CAT));
            Index_SIXMTH_CAT_DEST = new Lazy<NullDictionary<string, IReadOnlyList<OSCS>>>(() => this.ToGroupedNullDictionary(i => i.SIXMTH_CAT_DEST));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="OSCS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="OSCS" /> fields for each CSV column header</returns>
        protected override Action<OSCS, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.TRAN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.ZEROMTH_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "VISA_EXPIRY":
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.ARRIVAL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AUSSIE_SCHOOL":
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.SIXMTH_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ISU_STD_NO":
                        mapper[i] = (e, v) => e.ISU_STD_NO = v;
                        break;
                    case "CENSUSDAY":
                        mapper[i] = (e, v) => e.CENSUSDAY = v;
                        break;
                    case "LAST_ABSENCE":
                        mapper[i] = (e, v) => e.LAST_ABSENCE = v == null ? (DateTime?)null : DateTime.Parse(v);
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

        #region Index Fields

        private Lazy<Dictionary<int, OSCS>> Index_OSCSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ADULT_A_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ADULT_B_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ZEROMTH_CAT;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_ZEROMTH_CAT_DEST;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_BIRTH_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_HOME_LANG;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_SIXMTH_CAT;
        private Lazy<NullDictionary<string, IReadOnlyList<OSCS>>> Index_SIXMTH_CAT_DEST;

        #endregion

        #region Index Methods

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

        #endregion

    }
}
