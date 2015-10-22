using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CASES Past Students Data Set
    /// </summary>
    public sealed partial class OSCSDataSet : SetBase<OSCS>
    {
        private Lazy<Dictionary<int, OSCS>> OSCSKEYIndex;


        internal OSCSDataSet(EduHubContext Context)
            : base(Context)
        {
            OSCSKEYIndex = new Lazy<Dictionary<int, OSCS>>(() => this.ToDictionary(e => e.OSCSKEY));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "OSCS"; } }

        /// <summary>
        /// Find OSCS by OSCSKEY key field
        /// </summary>
        /// <param name="Key">OSCSKEY value used to find OSCS</param>
        /// <returns>Related OSCS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">OSCSKEY value didn't match any OSCS entities</exception>
        public OSCS FindByOSCSKEY(int Key)
        {
            OSCS result;
            if (OSCSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find OSCS by OSCSKEY key field
        /// </summary>
        /// <param name="Key">OSCSKEY value used to find OSCS</param>
        /// <param name="Value">Related OSCS entity</param>
        /// <returns>True if the OSCS entity is found</returns>
        public bool TryFindByOSCSKEY(int Key, out OSCS Value)
        {
            return OSCSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find OSCS by OSCSKEY key field
        /// </summary>
        /// <param name="Key">OSCSKEY value used to find OSCS</param>
        /// <returns>Related OSCS entity, or null if not found</returns>
        public OSCS TryFindByOSCSKEY(int Key)
        {
            OSCS result;
            if (OSCSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
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
    }
}
