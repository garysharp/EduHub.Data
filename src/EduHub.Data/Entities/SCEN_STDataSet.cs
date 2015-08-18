using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Data Data Set
    /// </summary>
    public sealed class SCEN_STDataSet : SetBase<SCEN_ST>
    {
        private Lazy<Dictionary<int, SCEN_ST>> IDIndex;

        internal SCEN_STDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_ST>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ST"; } }

        /// <summary>
        /// Find SCEN_ST by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ST</param>
        /// <returns>Related SCEN_ST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_ST entities</exception>
        public SCEN_ST FindByID(int Key)
        {
            SCEN_ST result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCEN_ST by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ST</param>
        /// <param name="Value">Related SCEN_ST entity</param>
        /// <returns>True if the SCEN_ST Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_ST Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ST by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ST</param>
        /// <returns>Related SCEN_ST entity, or null if not found</returns>
        public SCEN_ST TryFindByID(int Key)
        {
            SCEN_ST result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_ST, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_ST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "C_SOURCE":
                        mapper[i] = (e, v) => e.C_SOURCE = v;
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (int?)null : int.Parse(v);
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
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "C_AGE_1st_JAN":
                        mapper[i] = (e, v) => e.C_AGE_1st_JAN = v;
                        break;
                    case "C_AGE_1st_JULY":
                        mapper[i] = (e, v) => e.C_AGE_1st_JULY = v;
                        break;
                    case "AUSSIE_SCHOOL":
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "DISABILITY_ID":
                        mapper[i] = (e, v) => e.DISABILITY_ID = v;
                        break;
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "KGC_HOME_GROUP":
                        mapper[i] = (e, v) => e.KGC_HOME_GROUP = v;
                        break;
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "KGL_ASCL":
                        mapper[i] = (e, v) => e.KGL_ASCL = v;
                        break;
                    case "KGL_DESCRIPTION":
                        mapper[i] = (e, v) => e.KGL_DESCRIPTION = v;
                        break;
                    case "LOTE_HOME_CODE":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE = v;
                        break;
                    case "KGL_LOTE_HOME_ASCL":
                        mapper[i] = (e, v) => e.KGL_LOTE_HOME_ASCL = v;
                        break;
                    case "KGL_LOTE_HOME_DESCRIPTION":
                        mapper[i] = (e, v) => e.KGL_LOTE_HOME_DESCRIPTION = v;
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
                    case "PERTUSSIS_S":
                        mapper[i] = (e, v) => e.PERTUSSIS_S = v;
                        break;
                    case "HAEMOPHILUSB_S":
                        mapper[i] = (e, v) => e.HAEMOPHILUSB_S = v;
                        break;
                    case "MMR_S":
                        mapper[i] = (e, v) => e.MMR_S = v;
                        break;
                    case "IMMUN_CERT_STATUS":
                        mapper[i] = (e, v) => e.IMMUN_CERT_STATUS = v;
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "C_MOBILITY":
                        mapper[i] = (e, v) => e.C_MOBILITY = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "KGT_SACC":
                        mapper[i] = (e, v) => e.KGT_SACC = v;
                        break;
                    case "KGT_DESCRIPTION":
                        mapper[i] = (e, v) => e.KGT_DESCRIPTION = v;
                        break;
                    case "KGT_ENGLISH_SPEAKING":
                        mapper[i] = (e, v) => e.KGT_ENGLISH_SPEAKING = v;
                        break;
                    case "RESIDENT_STATUS":
                        mapper[i] = (e, v) => e.RESIDENT_STATUS = v;
                        break;
                    case "PERMANENT_BASIS":
                        mapper[i] = (e, v) => e.PERMANENT_BASIS = v;
                        break;
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "VISA_STAT_CODE":
                        mapper[i] = (e, v) => e.VISA_STAT_CODE = v;
                        break;
                    case "KCV_VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.KCV_VISA_SUBCLASS = v;
                        break;
                    case "KCV_SGB_FUNDED":
                        mapper[i] = (e, v) => e.KCV_SGB_FUNDED = v;
                        break;
                    case "KCV_CHECK_STAT_CODE":
                        mapper[i] = (e, v) => e.KCV_CHECK_STAT_CODE = v;
                        break;
                    case "KCV_VISA_RESIDENCY":
                        mapper[i] = (e, v) => e.KCV_VISA_RESIDENCY = v;
                        break;
                    case "C_SRP_STATUS":
                        mapper[i] = (e, v) => e.C_SRP_STATUS = v;
                        break;
                    case "EXIT_DATE":
                        mapper[i] = (e, v) => e.EXIT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "KCY_NUM_EQVT":
                        mapper[i] = (e, v) => e.KCY_NUM_EQVT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "KCY_KCYKEY":
                        mapper[i] = (e, v) => e.KCY_KCYKEY = v;
                        break;
                    case "LIVING_ARR":
                        mapper[i] = (e, v) => e.LIVING_ARR = v;
                        break;
                    case "C_LIVING_ARR":
                        mapper[i] = (e, v) => e.C_LIVING_ARR = v;
                        break;
                    case "PREVIOUS_SCHOOL":
                        mapper[i] = (e, v) => e.PREVIOUS_SCHOOL = v;
                        break;
                    case "SKGS_PREVIOUS_SCHOOL_ENTITY":
                        mapper[i] = (e, v) => e.SKGS_PREVIOUS_SCHOOL_ENTITY = v;
                        break;
                    case "SKGS_PREVIOUS_SCHOOL_ID":
                        mapper[i] = (e, v) => e.SKGS_PREVIOUS_SCHOOL_ID = v;
                        break;
                    case "C_FEEDER_ENTITY":
                        mapper[i] = (e, v) => e.C_FEEDER_ENTITY = v;
                        break;
                    case "C_FEEDER_SCHOOL_NUMBER":
                        mapper[i] = (e, v) => e.C_FEEDER_SCHOOL_NUMBER = v;
                        break;
                    case "C_FEEDER_SCHOOL_NAME":
                        mapper[i] = (e, v) => e.C_FEEDER_SCHOOL_NAME = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SKGS_CAMPUS_NAME":
                        mapper[i] = (e, v) => e.SKGS_CAMPUS_NAME = v;
                        break;
                    case "SKGS_SCHOOL_TYPE":
                        mapper[i] = (e, v) => e.SKGS_SCHOOL_TYPE = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "RELATION_A":
                        mapper[i] = (e, v) => e.RELATION_A = v;
                        break;
                    case "DF_GENDER_A":
                        mapper[i] = (e, v) => e.DF_GENDER_A = v;
                        break;
                    case "DF_SURNAME_A":
                        mapper[i] = (e, v) => e.DF_SURNAME_A = v;
                        break;
                    case "DF_TITLE_A":
                        mapper[i] = (e, v) => e.DF_TITLE_A = v;
                        break;
                    case "DF_NAME_A":
                        mapper[i] = (e, v) => e.DF_NAME_A = v;
                        break;
                    case "DF_BIRTH_COUNTRY_A":
                        mapper[i] = (e, v) => e.DF_BIRTH_COUNTRY_A = v;
                        break;
                    case "DF_KGT_SACC_A":
                        mapper[i] = (e, v) => e.DF_KGT_SACC_A = v;
                        break;
                    case "DF_KGT_DESCRIPTION_A":
                        mapper[i] = (e, v) => e.DF_KGT_DESCRIPTION_A = v;
                        break;
                    case "DF_KGT_ENGLISH_SPEAKING_A":
                        mapper[i] = (e, v) => e.DF_KGT_ENGLISH_SPEAKING_A = v;
                        break;
                    case "DF_OCCUP_STATUS_A":
                        mapper[i] = (e, v) => e.DF_OCCUP_STATUS_A = v;
                        break;
                    case "DF_LOTE_HOME_CODE_A":
                        mapper[i] = (e, v) => e.DF_LOTE_HOME_CODE_A = v;
                        break;
                    case "DF_KGL_LOTE_HOME_ASCL_A":
                        mapper[i] = (e, v) => e.DF_KGL_LOTE_HOME_ASCL_A = v;
                        break;
                    case "DF_KGL_LOTE_HOME_DESCRIPTION_A":
                        mapper[i] = (e, v) => e.DF_KGL_LOTE_HOME_DESCRIPTION_A = v;
                        break;
                    case "DF_GENDER_B":
                        mapper[i] = (e, v) => e.DF_GENDER_B = v;
                        break;
                    case "DF_SURNAME_B":
                        mapper[i] = (e, v) => e.DF_SURNAME_B = v;
                        break;
                    case "DF_TITLE_B":
                        mapper[i] = (e, v) => e.DF_TITLE_B = v;
                        break;
                    case "DF_NAME_B":
                        mapper[i] = (e, v) => e.DF_NAME_B = v;
                        break;
                    case "DF_BIRTH_COUNTRY_B":
                        mapper[i] = (e, v) => e.DF_BIRTH_COUNTRY_B = v;
                        break;
                    case "DF_KGT_ENGLISH_SPEAKING_B":
                        mapper[i] = (e, v) => e.DF_KGT_ENGLISH_SPEAKING_B = v;
                        break;
                    case "DF_KGT_SACC_B":
                        mapper[i] = (e, v) => e.DF_KGT_SACC_B = v;
                        break;
                    case "DF_KGT_DESCRIPTION_B":
                        mapper[i] = (e, v) => e.DF_KGT_DESCRIPTION_B = v;
                        break;
                    case "DF_OCCUP_STATUS_B":
                        mapper[i] = (e, v) => e.DF_OCCUP_STATUS_B = v;
                        break;
                    case "DF_LOTE_HOME_CODE_B":
                        mapper[i] = (e, v) => e.DF_LOTE_HOME_CODE_B = v;
                        break;
                    case "DF_KGL_LOTE_HOME_ASCL_B":
                        mapper[i] = (e, v) => e.DF_KGL_LOTE_HOME_ASCL_B = v;
                        break;
                    case "DF_KGL_LOTE_HOME_DESCRIPTION_B":
                        mapper[i] = (e, v) => e.DF_KGL_LOTE_HOME_DESCRIPTION_B = v;
                        break;
                    case "C_FAM_OCCUPATION":
                        mapper[i] = (e, v) => e.C_FAM_OCCUPATION = v;
                        break;
                    case "C_LBOTE":
                        mapper[i] = (e, v) => e.C_LBOTE = v;
                        break;
                    case "C_YTD_ABSENCE":
                        mapper[i] = (e, v) => e.C_YTD_ABSENCE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "C_CENSUSDAY":
                        mapper[i] = (e, v) => e.C_CENSUSDAY = v;
                        break;
                    case "C_YTD_APPROVED":
                        mapper[i] = (e, v) => e.C_YTD_APPROVED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "C_LAST_ABS_DAY":
                        mapper[i] = (e, v) => e.C_LAST_ABS_DAY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "C_START_SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.C_START_SCHOOL_YEAR = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "C_ELIGIBLE_S_DAYS":
                        mapper[i] = (e, v) => e.C_ELIGIBLE_S_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "C_LBOTE_MCEETYA":
                        mapper[i] = (e, v) => e.C_LBOTE_MCEETYA = v;
                        break;
                    case "FULLTIME":
                        mapper[i] = (e, v) => e.FULLTIME = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_SCHL_NUM01":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM01 = v;
                        break;
                    case "STPT_SCHL_NUM02":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM02 = v;
                        break;
                    case "STPT_SCHL_NUM03":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM03 = v;
                        break;
                    case "STPT_SCHL_NUM04":
                        mapper[i] = (e, v) => e.STPT_SCHL_NUM04 = v;
                        break;
                    case "SKGS_STPT_ENTITY01":
                        mapper[i] = (e, v) => e.SKGS_STPT_ENTITY01 = v;
                        break;
                    case "SKGS_STPT_ENTITY02":
                        mapper[i] = (e, v) => e.SKGS_STPT_ENTITY02 = v;
                        break;
                    case "SKGS_STPT_ENTITY03":
                        mapper[i] = (e, v) => e.SKGS_STPT_ENTITY03 = v;
                        break;
                    case "SKGS_STPT_ENTITY04":
                        mapper[i] = (e, v) => e.SKGS_STPT_ENTITY04 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_ID01":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_ID01 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_ID02":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_ID02 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_ID03":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_ID03 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_ID04":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_ID04 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_NAME01":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_NAME01 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_NAME02":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_NAME02 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_NAME03":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_NAME03 = v;
                        break;
                    case "SKGS_STPT_SCHOOL_NAME04":
                        mapper[i] = (e, v) => e.SKGS_STPT_SCHOOL_NAME04 = v;
                        break;
                    case "STPT_SGB_TIME_FRACTION01":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_SGB_TIME_FRACTION02":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_SGB_TIME_FRACTION03":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STPT_SGB_TIME_FRACTION04":
                        mapper[i] = (e, v) => e.STPT_SGB_TIME_FRACTION04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "REPEAT":
                        mapper[i] = (e, v) => e.REPEAT = v;
                        break;
                    case "INTERNATIONAL_ST_ID":
                        mapper[i] = (e, v) => e.INTERNATIONAL_ST_ID = v;
                        break;
                    case "LCREATED":
                        mapper[i] = (e, v) => e.LCREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "VSN":
                        mapper[i] = (e, v) => e.VSN = v;
                        break;
                    case "DF_SCH_ED_A":
                        mapper[i] = (e, v) => e.DF_SCH_ED_A = v;
                        break;
                    case "DF_SCH_ED_B":
                        mapper[i] = (e, v) => e.DF_SCH_ED_B = v;
                        break;
                    case "DF_NON_SCH_ED_A":
                        mapper[i] = (e, v) => e.DF_NON_SCH_ED_A = v;
                        break;
                    case "DF_NON_SCH_ED_B":
                        mapper[i] = (e, v) => e.DF_NON_SCH_ED_B = v;
                        break;
                    case "ADDRESS_B":
                        mapper[i] = (e, v) => e.ADDRESS_B = v;
                        break;
                    case "ADDRESS_C":
                        mapper[i] = (e, v) => e.ADDRESS_C = v;
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
