using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_STDataSet : DataSetBase<SCEN_ST>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ST"; } }

        internal SCEN_STDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ST>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ST" /> fields for each CSV column header</returns>
        protected override Action<SCEN_ST, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        /// <summary>
        /// Merges <see cref="SCEN_ST" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_ST" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_ST" /> items to added or update the base <see cref="SCEN_ST" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_ST" /> items</returns>
        protected override List<SCEN_ST> ApplyDeltaItems(List<SCEN_ST> Items, List<SCEN_ST> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_ST deltaItem in DeltaItems)
            {
                int index;

                if (Index_ID.TryGetValue(deltaItem.ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SCEN_ST>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ST</param>
        /// <returns>Related SCEN_ST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ST FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ST</param>
        /// <param name="Value">Related SCEN_ST entity</param>
        /// <returns>True if the related SCEN_ST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ST Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ST</param>
        /// <returns>Related SCEN_ST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ST TryFindByID(int ID)
        {
            SCEN_ST value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns SQL which checks for the existence of a SCEN_ST table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_ST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_ST](
        [ID] int IDENTITY NOT NULL,
        [C_SOURCE] varchar(4) NULL,
        [STKEY] varchar(10) NULL,
        [REGISTRATION] int NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [SECOND_NAME] varchar(20) NULL,
        [GENDER] varchar(1) NULL,
        [C_AGE_1st_JAN] varchar(6) NULL,
        [C_AGE_1st_JULY] varchar(6) NULL,
        [AUSSIE_SCHOOL] datetime NULL,
        [BIRTHDATE] datetime NULL,
        [DISABILITY] varchar(1) NULL,
        [DISABILITY_ID] varchar(6) NULL,
        [ENTRY] datetime NULL,
        [STATUS] varchar(4) NULL,
        [HOME_GROUP] varchar(3) NULL,
        [KGC_HOME_GROUP] varchar(3) NULL,
        [HOME_LANG] varchar(7) NULL,
        [KGL_ASCL] varchar(4) NULL,
        [KGL_DESCRIPTION] varchar(75) NULL,
        [LOTE_HOME_CODE] varchar(7) NULL,
        [KGL_LOTE_HOME_ASCL] varchar(4) NULL,
        [KGL_LOTE_HOME_DESCRIPTION] varchar(75) NULL,
        [IMMUNIZE] varchar(1) NULL,
        [DIPTHERIA_S] varchar(1) NULL,
        [TETANUS_S] varchar(1) NULL,
        [POLIO_S] varchar(1) NULL,
        [PERTUSSIS_S] varchar(1) NULL,
        [HAEMOPHILUSB_S] varchar(1) NULL,
        [MMR_S] varchar(1) NULL,
        [IMMUN_CERT_STATUS] varchar(1) NULL,
        [KOORIE] varchar(1) NULL,
        [C_MOBILITY] varchar(1) NULL,
        [SGB_FUNDED] varchar(1) NULL,
        [BIRTH_COUNTRY] varchar(6) NULL,
        [KGT_SACC] varchar(4) NULL,
        [KGT_DESCRIPTION] varchar(40) NULL,
        [KGT_ENGLISH_SPEAKING] varchar(1) NULL,
        [RESIDENT_STATUS] varchar(1) NULL,
        [PERMANENT_BASIS] varchar(1) NULL,
        [VISA_SUBCLASS] varchar(3) NULL,
        [VISA_STAT_CODE] varchar(4) NULL,
        [KCV_VISA_SUBCLASS] varchar(3) NULL,
        [KCV_SGB_FUNDED] varchar(1) NULL,
        [KCV_CHECK_STAT_CODE] varchar(1) NULL,
        [KCV_VISA_RESIDENCY] varchar(1) NULL,
        [C_SRP_STATUS] varchar(5) NULL,
        [EXIT_DATE] datetime NULL,
        [KCY_NUM_EQVT] smallint NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [KCY_KCYKEY] varchar(4) NULL,
        [LIVING_ARR] varchar(1) NULL,
        [C_LIVING_ARR] varchar(1) NULL,
        [PREVIOUS_SCHOOL] varchar(8) NULL,
        [SKGS_PREVIOUS_SCHOOL_ENTITY] varchar(2) NULL,
        [SKGS_PREVIOUS_SCHOOL_ID] varchar(4) NULL,
        [C_FEEDER_ENTITY] varchar(2) NULL,
        [C_FEEDER_SCHOOL_NUMBER] varchar(4) NULL,
        [C_FEEDER_SCHOOL_NAME] varchar(40) NULL,
        [CAMPUS] int NULL,
        [SKGS_CAMPUS_NAME] varchar(40) NULL,
        [SKGS_SCHOOL_TYPE] varchar(33) NULL,
        [FAMILY] varchar(10) NULL,
        [RELATION_A] varchar(20) NULL,
        [DF_GENDER_A] varchar(1) NULL,
        [DF_SURNAME_A] varchar(30) NULL,
        [DF_TITLE_A] varchar(4) NULL,
        [DF_NAME_A] varchar(30) NULL,
        [DF_BIRTH_COUNTRY_A] varchar(6) NULL,
        [DF_KGT_SACC_A] varchar(4) NULL,
        [DF_KGT_DESCRIPTION_A] varchar(40) NULL,
        [DF_KGT_ENGLISH_SPEAKING_A] varchar(1) NULL,
        [DF_OCCUP_STATUS_A] varchar(1) NULL,
        [DF_LOTE_HOME_CODE_A] varchar(7) NULL,
        [DF_KGL_LOTE_HOME_ASCL_A] varchar(4) NULL,
        [DF_KGL_LOTE_HOME_DESCRIPTION_A] varchar(75) NULL,
        [DF_GENDER_B] varchar(1) NULL,
        [DF_SURNAME_B] varchar(30) NULL,
        [DF_TITLE_B] varchar(4) NULL,
        [DF_NAME_B] varchar(30) NULL,
        [DF_BIRTH_COUNTRY_B] varchar(6) NULL,
        [DF_KGT_ENGLISH_SPEAKING_B] varchar(1) NULL,
        [DF_KGT_SACC_B] varchar(4) NULL,
        [DF_KGT_DESCRIPTION_B] varchar(40) NULL,
        [DF_OCCUP_STATUS_B] varchar(1) NULL,
        [DF_LOTE_HOME_CODE_B] varchar(7) NULL,
        [DF_KGL_LOTE_HOME_ASCL_B] varchar(4) NULL,
        [DF_KGL_LOTE_HOME_DESCRIPTION_B] varchar(75) NULL,
        [C_FAM_OCCUPATION] varchar(1) NULL,
        [C_LBOTE] varchar(1) NULL,
        [C_YTD_ABSENCE] float NULL,
        [C_CENSUSDAY] varchar(1) NULL,
        [C_YTD_APPROVED] float NULL,
        [C_LAST_ABS_DAY] datetime NULL,
        [C_START_SCHOOL_YEAR] datetime NULL,
        [C_ELIGIBLE_S_DAYS] smallint NULL,
        [C_LBOTE_MCEETYA] varchar(1) NULL,
        [FULLTIME] varchar(1) NULL,
        [SGB_TIME_FRACTION] float NULL,
        [STPT_SCHL_NUM01] varchar(8) NULL,
        [STPT_SCHL_NUM02] varchar(8) NULL,
        [STPT_SCHL_NUM03] varchar(8) NULL,
        [STPT_SCHL_NUM04] varchar(8) NULL,
        [SKGS_STPT_ENTITY01] varchar(2) NULL,
        [SKGS_STPT_ENTITY02] varchar(2) NULL,
        [SKGS_STPT_ENTITY03] varchar(2) NULL,
        [SKGS_STPT_ENTITY04] varchar(2) NULL,
        [SKGS_STPT_SCHOOL_ID01] varchar(4) NULL,
        [SKGS_STPT_SCHOOL_ID02] varchar(4) NULL,
        [SKGS_STPT_SCHOOL_ID03] varchar(4) NULL,
        [SKGS_STPT_SCHOOL_ID04] varchar(4) NULL,
        [SKGS_STPT_SCHOOL_NAME01] varchar(40) NULL,
        [SKGS_STPT_SCHOOL_NAME02] varchar(40) NULL,
        [SKGS_STPT_SCHOOL_NAME03] varchar(40) NULL,
        [SKGS_STPT_SCHOOL_NAME04] varchar(40) NULL,
        [STPT_SGB_TIME_FRACTION01] float NULL,
        [STPT_SGB_TIME_FRACTION02] float NULL,
        [STPT_SGB_TIME_FRACTION03] float NULL,
        [STPT_SGB_TIME_FRACTION04] float NULL,
        [POSTCODE] varchar(4) NULL,
        [REPEAT] varchar(1) NULL,
        [INTERNATIONAL_ST_ID] varchar(7) NULL,
        [LCREATED] datetime NULL,
        [VSN] varchar(12) NULL,
        [DF_SCH_ED_A] varchar(1) NULL,
        [DF_SCH_ED_B] varchar(1) NULL,
        [DF_NON_SCH_ED_A] varchar(1) NULL,
        [DF_NON_SCH_ED_B] varchar(1) NULL,
        [ADDRESS_B] varchar(30) NULL,
        [ADDRESS_C] varchar(30) NULL,
        CONSTRAINT [SCEN_ST_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ST data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_STDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_STDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_ST> Items;
            private int CurrentIndex;
            private SCEN_ST CurrentItem;

            public SCEN_STDataReader(List<SCEN_ST> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 131; } }
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
                    case 0: // ID
                        return CurrentItem.ID;
                    case 1: // C_SOURCE
                        return CurrentItem.C_SOURCE;
                    case 2: // STKEY
                        return CurrentItem.STKEY;
                    case 3: // REGISTRATION
                        return CurrentItem.REGISTRATION;
                    case 4: // SURNAME
                        return CurrentItem.SURNAME;
                    case 5: // FIRST_NAME
                        return CurrentItem.FIRST_NAME;
                    case 6: // SECOND_NAME
                        return CurrentItem.SECOND_NAME;
                    case 7: // GENDER
                        return CurrentItem.GENDER;
                    case 8: // C_AGE_1st_JAN
                        return CurrentItem.C_AGE_1st_JAN;
                    case 9: // C_AGE_1st_JULY
                        return CurrentItem.C_AGE_1st_JULY;
                    case 10: // AUSSIE_SCHOOL
                        return CurrentItem.AUSSIE_SCHOOL;
                    case 11: // BIRTHDATE
                        return CurrentItem.BIRTHDATE;
                    case 12: // DISABILITY
                        return CurrentItem.DISABILITY;
                    case 13: // DISABILITY_ID
                        return CurrentItem.DISABILITY_ID;
                    case 14: // ENTRY
                        return CurrentItem.ENTRY;
                    case 15: // STATUS
                        return CurrentItem.STATUS;
                    case 16: // HOME_GROUP
                        return CurrentItem.HOME_GROUP;
                    case 17: // KGC_HOME_GROUP
                        return CurrentItem.KGC_HOME_GROUP;
                    case 18: // HOME_LANG
                        return CurrentItem.HOME_LANG;
                    case 19: // KGL_ASCL
                        return CurrentItem.KGL_ASCL;
                    case 20: // KGL_DESCRIPTION
                        return CurrentItem.KGL_DESCRIPTION;
                    case 21: // LOTE_HOME_CODE
                        return CurrentItem.LOTE_HOME_CODE;
                    case 22: // KGL_LOTE_HOME_ASCL
                        return CurrentItem.KGL_LOTE_HOME_ASCL;
                    case 23: // KGL_LOTE_HOME_DESCRIPTION
                        return CurrentItem.KGL_LOTE_HOME_DESCRIPTION;
                    case 24: // IMMUNIZE
                        return CurrentItem.IMMUNIZE;
                    case 25: // DIPTHERIA_S
                        return CurrentItem.DIPTHERIA_S;
                    case 26: // TETANUS_S
                        return CurrentItem.TETANUS_S;
                    case 27: // POLIO_S
                        return CurrentItem.POLIO_S;
                    case 28: // PERTUSSIS_S
                        return CurrentItem.PERTUSSIS_S;
                    case 29: // HAEMOPHILUSB_S
                        return CurrentItem.HAEMOPHILUSB_S;
                    case 30: // MMR_S
                        return CurrentItem.MMR_S;
                    case 31: // IMMUN_CERT_STATUS
                        return CurrentItem.IMMUN_CERT_STATUS;
                    case 32: // KOORIE
                        return CurrentItem.KOORIE;
                    case 33: // C_MOBILITY
                        return CurrentItem.C_MOBILITY;
                    case 34: // SGB_FUNDED
                        return CurrentItem.SGB_FUNDED;
                    case 35: // BIRTH_COUNTRY
                        return CurrentItem.BIRTH_COUNTRY;
                    case 36: // KGT_SACC
                        return CurrentItem.KGT_SACC;
                    case 37: // KGT_DESCRIPTION
                        return CurrentItem.KGT_DESCRIPTION;
                    case 38: // KGT_ENGLISH_SPEAKING
                        return CurrentItem.KGT_ENGLISH_SPEAKING;
                    case 39: // RESIDENT_STATUS
                        return CurrentItem.RESIDENT_STATUS;
                    case 40: // PERMANENT_BASIS
                        return CurrentItem.PERMANENT_BASIS;
                    case 41: // VISA_SUBCLASS
                        return CurrentItem.VISA_SUBCLASS;
                    case 42: // VISA_STAT_CODE
                        return CurrentItem.VISA_STAT_CODE;
                    case 43: // KCV_VISA_SUBCLASS
                        return CurrentItem.KCV_VISA_SUBCLASS;
                    case 44: // KCV_SGB_FUNDED
                        return CurrentItem.KCV_SGB_FUNDED;
                    case 45: // KCV_CHECK_STAT_CODE
                        return CurrentItem.KCV_CHECK_STAT_CODE;
                    case 46: // KCV_VISA_RESIDENCY
                        return CurrentItem.KCV_VISA_RESIDENCY;
                    case 47: // C_SRP_STATUS
                        return CurrentItem.C_SRP_STATUS;
                    case 48: // EXIT_DATE
                        return CurrentItem.EXIT_DATE;
                    case 49: // KCY_NUM_EQVT
                        return CurrentItem.KCY_NUM_EQVT;
                    case 50: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR;
                    case 51: // KCY_KCYKEY
                        return CurrentItem.KCY_KCYKEY;
                    case 52: // LIVING_ARR
                        return CurrentItem.LIVING_ARR;
                    case 53: // C_LIVING_ARR
                        return CurrentItem.C_LIVING_ARR;
                    case 54: // PREVIOUS_SCHOOL
                        return CurrentItem.PREVIOUS_SCHOOL;
                    case 55: // SKGS_PREVIOUS_SCHOOL_ENTITY
                        return CurrentItem.SKGS_PREVIOUS_SCHOOL_ENTITY;
                    case 56: // SKGS_PREVIOUS_SCHOOL_ID
                        return CurrentItem.SKGS_PREVIOUS_SCHOOL_ID;
                    case 57: // C_FEEDER_ENTITY
                        return CurrentItem.C_FEEDER_ENTITY;
                    case 58: // C_FEEDER_SCHOOL_NUMBER
                        return CurrentItem.C_FEEDER_SCHOOL_NUMBER;
                    case 59: // C_FEEDER_SCHOOL_NAME
                        return CurrentItem.C_FEEDER_SCHOOL_NAME;
                    case 60: // CAMPUS
                        return CurrentItem.CAMPUS;
                    case 61: // SKGS_CAMPUS_NAME
                        return CurrentItem.SKGS_CAMPUS_NAME;
                    case 62: // SKGS_SCHOOL_TYPE
                        return CurrentItem.SKGS_SCHOOL_TYPE;
                    case 63: // FAMILY
                        return CurrentItem.FAMILY;
                    case 64: // RELATION_A
                        return CurrentItem.RELATION_A;
                    case 65: // DF_GENDER_A
                        return CurrentItem.DF_GENDER_A;
                    case 66: // DF_SURNAME_A
                        return CurrentItem.DF_SURNAME_A;
                    case 67: // DF_TITLE_A
                        return CurrentItem.DF_TITLE_A;
                    case 68: // DF_NAME_A
                        return CurrentItem.DF_NAME_A;
                    case 69: // DF_BIRTH_COUNTRY_A
                        return CurrentItem.DF_BIRTH_COUNTRY_A;
                    case 70: // DF_KGT_SACC_A
                        return CurrentItem.DF_KGT_SACC_A;
                    case 71: // DF_KGT_DESCRIPTION_A
                        return CurrentItem.DF_KGT_DESCRIPTION_A;
                    case 72: // DF_KGT_ENGLISH_SPEAKING_A
                        return CurrentItem.DF_KGT_ENGLISH_SPEAKING_A;
                    case 73: // DF_OCCUP_STATUS_A
                        return CurrentItem.DF_OCCUP_STATUS_A;
                    case 74: // DF_LOTE_HOME_CODE_A
                        return CurrentItem.DF_LOTE_HOME_CODE_A;
                    case 75: // DF_KGL_LOTE_HOME_ASCL_A
                        return CurrentItem.DF_KGL_LOTE_HOME_ASCL_A;
                    case 76: // DF_KGL_LOTE_HOME_DESCRIPTION_A
                        return CurrentItem.DF_KGL_LOTE_HOME_DESCRIPTION_A;
                    case 77: // DF_GENDER_B
                        return CurrentItem.DF_GENDER_B;
                    case 78: // DF_SURNAME_B
                        return CurrentItem.DF_SURNAME_B;
                    case 79: // DF_TITLE_B
                        return CurrentItem.DF_TITLE_B;
                    case 80: // DF_NAME_B
                        return CurrentItem.DF_NAME_B;
                    case 81: // DF_BIRTH_COUNTRY_B
                        return CurrentItem.DF_BIRTH_COUNTRY_B;
                    case 82: // DF_KGT_ENGLISH_SPEAKING_B
                        return CurrentItem.DF_KGT_ENGLISH_SPEAKING_B;
                    case 83: // DF_KGT_SACC_B
                        return CurrentItem.DF_KGT_SACC_B;
                    case 84: // DF_KGT_DESCRIPTION_B
                        return CurrentItem.DF_KGT_DESCRIPTION_B;
                    case 85: // DF_OCCUP_STATUS_B
                        return CurrentItem.DF_OCCUP_STATUS_B;
                    case 86: // DF_LOTE_HOME_CODE_B
                        return CurrentItem.DF_LOTE_HOME_CODE_B;
                    case 87: // DF_KGL_LOTE_HOME_ASCL_B
                        return CurrentItem.DF_KGL_LOTE_HOME_ASCL_B;
                    case 88: // DF_KGL_LOTE_HOME_DESCRIPTION_B
                        return CurrentItem.DF_KGL_LOTE_HOME_DESCRIPTION_B;
                    case 89: // C_FAM_OCCUPATION
                        return CurrentItem.C_FAM_OCCUPATION;
                    case 90: // C_LBOTE
                        return CurrentItem.C_LBOTE;
                    case 91: // C_YTD_ABSENCE
                        return CurrentItem.C_YTD_ABSENCE;
                    case 92: // C_CENSUSDAY
                        return CurrentItem.C_CENSUSDAY;
                    case 93: // C_YTD_APPROVED
                        return CurrentItem.C_YTD_APPROVED;
                    case 94: // C_LAST_ABS_DAY
                        return CurrentItem.C_LAST_ABS_DAY;
                    case 95: // C_START_SCHOOL_YEAR
                        return CurrentItem.C_START_SCHOOL_YEAR;
                    case 96: // C_ELIGIBLE_S_DAYS
                        return CurrentItem.C_ELIGIBLE_S_DAYS;
                    case 97: // C_LBOTE_MCEETYA
                        return CurrentItem.C_LBOTE_MCEETYA;
                    case 98: // FULLTIME
                        return CurrentItem.FULLTIME;
                    case 99: // SGB_TIME_FRACTION
                        return CurrentItem.SGB_TIME_FRACTION;
                    case 100: // STPT_SCHL_NUM01
                        return CurrentItem.STPT_SCHL_NUM01;
                    case 101: // STPT_SCHL_NUM02
                        return CurrentItem.STPT_SCHL_NUM02;
                    case 102: // STPT_SCHL_NUM03
                        return CurrentItem.STPT_SCHL_NUM03;
                    case 103: // STPT_SCHL_NUM04
                        return CurrentItem.STPT_SCHL_NUM04;
                    case 104: // SKGS_STPT_ENTITY01
                        return CurrentItem.SKGS_STPT_ENTITY01;
                    case 105: // SKGS_STPT_ENTITY02
                        return CurrentItem.SKGS_STPT_ENTITY02;
                    case 106: // SKGS_STPT_ENTITY03
                        return CurrentItem.SKGS_STPT_ENTITY03;
                    case 107: // SKGS_STPT_ENTITY04
                        return CurrentItem.SKGS_STPT_ENTITY04;
                    case 108: // SKGS_STPT_SCHOOL_ID01
                        return CurrentItem.SKGS_STPT_SCHOOL_ID01;
                    case 109: // SKGS_STPT_SCHOOL_ID02
                        return CurrentItem.SKGS_STPT_SCHOOL_ID02;
                    case 110: // SKGS_STPT_SCHOOL_ID03
                        return CurrentItem.SKGS_STPT_SCHOOL_ID03;
                    case 111: // SKGS_STPT_SCHOOL_ID04
                        return CurrentItem.SKGS_STPT_SCHOOL_ID04;
                    case 112: // SKGS_STPT_SCHOOL_NAME01
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME01;
                    case 113: // SKGS_STPT_SCHOOL_NAME02
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME02;
                    case 114: // SKGS_STPT_SCHOOL_NAME03
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME03;
                    case 115: // SKGS_STPT_SCHOOL_NAME04
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME04;
                    case 116: // STPT_SGB_TIME_FRACTION01
                        return CurrentItem.STPT_SGB_TIME_FRACTION01;
                    case 117: // STPT_SGB_TIME_FRACTION02
                        return CurrentItem.STPT_SGB_TIME_FRACTION02;
                    case 118: // STPT_SGB_TIME_FRACTION03
                        return CurrentItem.STPT_SGB_TIME_FRACTION03;
                    case 119: // STPT_SGB_TIME_FRACTION04
                        return CurrentItem.STPT_SGB_TIME_FRACTION04;
                    case 120: // POSTCODE
                        return CurrentItem.POSTCODE;
                    case 121: // REPEAT
                        return CurrentItem.REPEAT;
                    case 122: // INTERNATIONAL_ST_ID
                        return CurrentItem.INTERNATIONAL_ST_ID;
                    case 123: // LCREATED
                        return CurrentItem.LCREATED;
                    case 124: // VSN
                        return CurrentItem.VSN;
                    case 125: // DF_SCH_ED_A
                        return CurrentItem.DF_SCH_ED_A;
                    case 126: // DF_SCH_ED_B
                        return CurrentItem.DF_SCH_ED_B;
                    case 127: // DF_NON_SCH_ED_A
                        return CurrentItem.DF_NON_SCH_ED_A;
                    case 128: // DF_NON_SCH_ED_B
                        return CurrentItem.DF_NON_SCH_ED_B;
                    case 129: // ADDRESS_B
                        return CurrentItem.ADDRESS_B;
                    case 130: // ADDRESS_C
                        return CurrentItem.ADDRESS_C;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // C_SOURCE
                        return CurrentItem.C_SOURCE == null;
                    case 2: // STKEY
                        return CurrentItem.STKEY == null;
                    case 3: // REGISTRATION
                        return CurrentItem.REGISTRATION == null;
                    case 4: // SURNAME
                        return CurrentItem.SURNAME == null;
                    case 5: // FIRST_NAME
                        return CurrentItem.FIRST_NAME == null;
                    case 6: // SECOND_NAME
                        return CurrentItem.SECOND_NAME == null;
                    case 7: // GENDER
                        return CurrentItem.GENDER == null;
                    case 8: // C_AGE_1st_JAN
                        return CurrentItem.C_AGE_1st_JAN == null;
                    case 9: // C_AGE_1st_JULY
                        return CurrentItem.C_AGE_1st_JULY == null;
                    case 10: // AUSSIE_SCHOOL
                        return CurrentItem.AUSSIE_SCHOOL == null;
                    case 11: // BIRTHDATE
                        return CurrentItem.BIRTHDATE == null;
                    case 12: // DISABILITY
                        return CurrentItem.DISABILITY == null;
                    case 13: // DISABILITY_ID
                        return CurrentItem.DISABILITY_ID == null;
                    case 14: // ENTRY
                        return CurrentItem.ENTRY == null;
                    case 15: // STATUS
                        return CurrentItem.STATUS == null;
                    case 16: // HOME_GROUP
                        return CurrentItem.HOME_GROUP == null;
                    case 17: // KGC_HOME_GROUP
                        return CurrentItem.KGC_HOME_GROUP == null;
                    case 18: // HOME_LANG
                        return CurrentItem.HOME_LANG == null;
                    case 19: // KGL_ASCL
                        return CurrentItem.KGL_ASCL == null;
                    case 20: // KGL_DESCRIPTION
                        return CurrentItem.KGL_DESCRIPTION == null;
                    case 21: // LOTE_HOME_CODE
                        return CurrentItem.LOTE_HOME_CODE == null;
                    case 22: // KGL_LOTE_HOME_ASCL
                        return CurrentItem.KGL_LOTE_HOME_ASCL == null;
                    case 23: // KGL_LOTE_HOME_DESCRIPTION
                        return CurrentItem.KGL_LOTE_HOME_DESCRIPTION == null;
                    case 24: // IMMUNIZE
                        return CurrentItem.IMMUNIZE == null;
                    case 25: // DIPTHERIA_S
                        return CurrentItem.DIPTHERIA_S == null;
                    case 26: // TETANUS_S
                        return CurrentItem.TETANUS_S == null;
                    case 27: // POLIO_S
                        return CurrentItem.POLIO_S == null;
                    case 28: // PERTUSSIS_S
                        return CurrentItem.PERTUSSIS_S == null;
                    case 29: // HAEMOPHILUSB_S
                        return CurrentItem.HAEMOPHILUSB_S == null;
                    case 30: // MMR_S
                        return CurrentItem.MMR_S == null;
                    case 31: // IMMUN_CERT_STATUS
                        return CurrentItem.IMMUN_CERT_STATUS == null;
                    case 32: // KOORIE
                        return CurrentItem.KOORIE == null;
                    case 33: // C_MOBILITY
                        return CurrentItem.C_MOBILITY == null;
                    case 34: // SGB_FUNDED
                        return CurrentItem.SGB_FUNDED == null;
                    case 35: // BIRTH_COUNTRY
                        return CurrentItem.BIRTH_COUNTRY == null;
                    case 36: // KGT_SACC
                        return CurrentItem.KGT_SACC == null;
                    case 37: // KGT_DESCRIPTION
                        return CurrentItem.KGT_DESCRIPTION == null;
                    case 38: // KGT_ENGLISH_SPEAKING
                        return CurrentItem.KGT_ENGLISH_SPEAKING == null;
                    case 39: // RESIDENT_STATUS
                        return CurrentItem.RESIDENT_STATUS == null;
                    case 40: // PERMANENT_BASIS
                        return CurrentItem.PERMANENT_BASIS == null;
                    case 41: // VISA_SUBCLASS
                        return CurrentItem.VISA_SUBCLASS == null;
                    case 42: // VISA_STAT_CODE
                        return CurrentItem.VISA_STAT_CODE == null;
                    case 43: // KCV_VISA_SUBCLASS
                        return CurrentItem.KCV_VISA_SUBCLASS == null;
                    case 44: // KCV_SGB_FUNDED
                        return CurrentItem.KCV_SGB_FUNDED == null;
                    case 45: // KCV_CHECK_STAT_CODE
                        return CurrentItem.KCV_CHECK_STAT_CODE == null;
                    case 46: // KCV_VISA_RESIDENCY
                        return CurrentItem.KCV_VISA_RESIDENCY == null;
                    case 47: // C_SRP_STATUS
                        return CurrentItem.C_SRP_STATUS == null;
                    case 48: // EXIT_DATE
                        return CurrentItem.EXIT_DATE == null;
                    case 49: // KCY_NUM_EQVT
                        return CurrentItem.KCY_NUM_EQVT == null;
                    case 50: // SCHOOL_YEAR
                        return CurrentItem.SCHOOL_YEAR == null;
                    case 51: // KCY_KCYKEY
                        return CurrentItem.KCY_KCYKEY == null;
                    case 52: // LIVING_ARR
                        return CurrentItem.LIVING_ARR == null;
                    case 53: // C_LIVING_ARR
                        return CurrentItem.C_LIVING_ARR == null;
                    case 54: // PREVIOUS_SCHOOL
                        return CurrentItem.PREVIOUS_SCHOOL == null;
                    case 55: // SKGS_PREVIOUS_SCHOOL_ENTITY
                        return CurrentItem.SKGS_PREVIOUS_SCHOOL_ENTITY == null;
                    case 56: // SKGS_PREVIOUS_SCHOOL_ID
                        return CurrentItem.SKGS_PREVIOUS_SCHOOL_ID == null;
                    case 57: // C_FEEDER_ENTITY
                        return CurrentItem.C_FEEDER_ENTITY == null;
                    case 58: // C_FEEDER_SCHOOL_NUMBER
                        return CurrentItem.C_FEEDER_SCHOOL_NUMBER == null;
                    case 59: // C_FEEDER_SCHOOL_NAME
                        return CurrentItem.C_FEEDER_SCHOOL_NAME == null;
                    case 60: // CAMPUS
                        return CurrentItem.CAMPUS == null;
                    case 61: // SKGS_CAMPUS_NAME
                        return CurrentItem.SKGS_CAMPUS_NAME == null;
                    case 62: // SKGS_SCHOOL_TYPE
                        return CurrentItem.SKGS_SCHOOL_TYPE == null;
                    case 63: // FAMILY
                        return CurrentItem.FAMILY == null;
                    case 64: // RELATION_A
                        return CurrentItem.RELATION_A == null;
                    case 65: // DF_GENDER_A
                        return CurrentItem.DF_GENDER_A == null;
                    case 66: // DF_SURNAME_A
                        return CurrentItem.DF_SURNAME_A == null;
                    case 67: // DF_TITLE_A
                        return CurrentItem.DF_TITLE_A == null;
                    case 68: // DF_NAME_A
                        return CurrentItem.DF_NAME_A == null;
                    case 69: // DF_BIRTH_COUNTRY_A
                        return CurrentItem.DF_BIRTH_COUNTRY_A == null;
                    case 70: // DF_KGT_SACC_A
                        return CurrentItem.DF_KGT_SACC_A == null;
                    case 71: // DF_KGT_DESCRIPTION_A
                        return CurrentItem.DF_KGT_DESCRIPTION_A == null;
                    case 72: // DF_KGT_ENGLISH_SPEAKING_A
                        return CurrentItem.DF_KGT_ENGLISH_SPEAKING_A == null;
                    case 73: // DF_OCCUP_STATUS_A
                        return CurrentItem.DF_OCCUP_STATUS_A == null;
                    case 74: // DF_LOTE_HOME_CODE_A
                        return CurrentItem.DF_LOTE_HOME_CODE_A == null;
                    case 75: // DF_KGL_LOTE_HOME_ASCL_A
                        return CurrentItem.DF_KGL_LOTE_HOME_ASCL_A == null;
                    case 76: // DF_KGL_LOTE_HOME_DESCRIPTION_A
                        return CurrentItem.DF_KGL_LOTE_HOME_DESCRIPTION_A == null;
                    case 77: // DF_GENDER_B
                        return CurrentItem.DF_GENDER_B == null;
                    case 78: // DF_SURNAME_B
                        return CurrentItem.DF_SURNAME_B == null;
                    case 79: // DF_TITLE_B
                        return CurrentItem.DF_TITLE_B == null;
                    case 80: // DF_NAME_B
                        return CurrentItem.DF_NAME_B == null;
                    case 81: // DF_BIRTH_COUNTRY_B
                        return CurrentItem.DF_BIRTH_COUNTRY_B == null;
                    case 82: // DF_KGT_ENGLISH_SPEAKING_B
                        return CurrentItem.DF_KGT_ENGLISH_SPEAKING_B == null;
                    case 83: // DF_KGT_SACC_B
                        return CurrentItem.DF_KGT_SACC_B == null;
                    case 84: // DF_KGT_DESCRIPTION_B
                        return CurrentItem.DF_KGT_DESCRIPTION_B == null;
                    case 85: // DF_OCCUP_STATUS_B
                        return CurrentItem.DF_OCCUP_STATUS_B == null;
                    case 86: // DF_LOTE_HOME_CODE_B
                        return CurrentItem.DF_LOTE_HOME_CODE_B == null;
                    case 87: // DF_KGL_LOTE_HOME_ASCL_B
                        return CurrentItem.DF_KGL_LOTE_HOME_ASCL_B == null;
                    case 88: // DF_KGL_LOTE_HOME_DESCRIPTION_B
                        return CurrentItem.DF_KGL_LOTE_HOME_DESCRIPTION_B == null;
                    case 89: // C_FAM_OCCUPATION
                        return CurrentItem.C_FAM_OCCUPATION == null;
                    case 90: // C_LBOTE
                        return CurrentItem.C_LBOTE == null;
                    case 91: // C_YTD_ABSENCE
                        return CurrentItem.C_YTD_ABSENCE == null;
                    case 92: // C_CENSUSDAY
                        return CurrentItem.C_CENSUSDAY == null;
                    case 93: // C_YTD_APPROVED
                        return CurrentItem.C_YTD_APPROVED == null;
                    case 94: // C_LAST_ABS_DAY
                        return CurrentItem.C_LAST_ABS_DAY == null;
                    case 95: // C_START_SCHOOL_YEAR
                        return CurrentItem.C_START_SCHOOL_YEAR == null;
                    case 96: // C_ELIGIBLE_S_DAYS
                        return CurrentItem.C_ELIGIBLE_S_DAYS == null;
                    case 97: // C_LBOTE_MCEETYA
                        return CurrentItem.C_LBOTE_MCEETYA == null;
                    case 98: // FULLTIME
                        return CurrentItem.FULLTIME == null;
                    case 99: // SGB_TIME_FRACTION
                        return CurrentItem.SGB_TIME_FRACTION == null;
                    case 100: // STPT_SCHL_NUM01
                        return CurrentItem.STPT_SCHL_NUM01 == null;
                    case 101: // STPT_SCHL_NUM02
                        return CurrentItem.STPT_SCHL_NUM02 == null;
                    case 102: // STPT_SCHL_NUM03
                        return CurrentItem.STPT_SCHL_NUM03 == null;
                    case 103: // STPT_SCHL_NUM04
                        return CurrentItem.STPT_SCHL_NUM04 == null;
                    case 104: // SKGS_STPT_ENTITY01
                        return CurrentItem.SKGS_STPT_ENTITY01 == null;
                    case 105: // SKGS_STPT_ENTITY02
                        return CurrentItem.SKGS_STPT_ENTITY02 == null;
                    case 106: // SKGS_STPT_ENTITY03
                        return CurrentItem.SKGS_STPT_ENTITY03 == null;
                    case 107: // SKGS_STPT_ENTITY04
                        return CurrentItem.SKGS_STPT_ENTITY04 == null;
                    case 108: // SKGS_STPT_SCHOOL_ID01
                        return CurrentItem.SKGS_STPT_SCHOOL_ID01 == null;
                    case 109: // SKGS_STPT_SCHOOL_ID02
                        return CurrentItem.SKGS_STPT_SCHOOL_ID02 == null;
                    case 110: // SKGS_STPT_SCHOOL_ID03
                        return CurrentItem.SKGS_STPT_SCHOOL_ID03 == null;
                    case 111: // SKGS_STPT_SCHOOL_ID04
                        return CurrentItem.SKGS_STPT_SCHOOL_ID04 == null;
                    case 112: // SKGS_STPT_SCHOOL_NAME01
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME01 == null;
                    case 113: // SKGS_STPT_SCHOOL_NAME02
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME02 == null;
                    case 114: // SKGS_STPT_SCHOOL_NAME03
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME03 == null;
                    case 115: // SKGS_STPT_SCHOOL_NAME04
                        return CurrentItem.SKGS_STPT_SCHOOL_NAME04 == null;
                    case 116: // STPT_SGB_TIME_FRACTION01
                        return CurrentItem.STPT_SGB_TIME_FRACTION01 == null;
                    case 117: // STPT_SGB_TIME_FRACTION02
                        return CurrentItem.STPT_SGB_TIME_FRACTION02 == null;
                    case 118: // STPT_SGB_TIME_FRACTION03
                        return CurrentItem.STPT_SGB_TIME_FRACTION03 == null;
                    case 119: // STPT_SGB_TIME_FRACTION04
                        return CurrentItem.STPT_SGB_TIME_FRACTION04 == null;
                    case 120: // POSTCODE
                        return CurrentItem.POSTCODE == null;
                    case 121: // REPEAT
                        return CurrentItem.REPEAT == null;
                    case 122: // INTERNATIONAL_ST_ID
                        return CurrentItem.INTERNATIONAL_ST_ID == null;
                    case 123: // LCREATED
                        return CurrentItem.LCREATED == null;
                    case 124: // VSN
                        return CurrentItem.VSN == null;
                    case 125: // DF_SCH_ED_A
                        return CurrentItem.DF_SCH_ED_A == null;
                    case 126: // DF_SCH_ED_B
                        return CurrentItem.DF_SCH_ED_B == null;
                    case 127: // DF_NON_SCH_ED_A
                        return CurrentItem.DF_NON_SCH_ED_A == null;
                    case 128: // DF_NON_SCH_ED_B
                        return CurrentItem.DF_NON_SCH_ED_B == null;
                    case 129: // ADDRESS_B
                        return CurrentItem.ADDRESS_B == null;
                    case 130: // ADDRESS_C
                        return CurrentItem.ADDRESS_C == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // C_SOURCE
                        return "C_SOURCE";
                    case 2: // STKEY
                        return "STKEY";
                    case 3: // REGISTRATION
                        return "REGISTRATION";
                    case 4: // SURNAME
                        return "SURNAME";
                    case 5: // FIRST_NAME
                        return "FIRST_NAME";
                    case 6: // SECOND_NAME
                        return "SECOND_NAME";
                    case 7: // GENDER
                        return "GENDER";
                    case 8: // C_AGE_1st_JAN
                        return "C_AGE_1st_JAN";
                    case 9: // C_AGE_1st_JULY
                        return "C_AGE_1st_JULY";
                    case 10: // AUSSIE_SCHOOL
                        return "AUSSIE_SCHOOL";
                    case 11: // BIRTHDATE
                        return "BIRTHDATE";
                    case 12: // DISABILITY
                        return "DISABILITY";
                    case 13: // DISABILITY_ID
                        return "DISABILITY_ID";
                    case 14: // ENTRY
                        return "ENTRY";
                    case 15: // STATUS
                        return "STATUS";
                    case 16: // HOME_GROUP
                        return "HOME_GROUP";
                    case 17: // KGC_HOME_GROUP
                        return "KGC_HOME_GROUP";
                    case 18: // HOME_LANG
                        return "HOME_LANG";
                    case 19: // KGL_ASCL
                        return "KGL_ASCL";
                    case 20: // KGL_DESCRIPTION
                        return "KGL_DESCRIPTION";
                    case 21: // LOTE_HOME_CODE
                        return "LOTE_HOME_CODE";
                    case 22: // KGL_LOTE_HOME_ASCL
                        return "KGL_LOTE_HOME_ASCL";
                    case 23: // KGL_LOTE_HOME_DESCRIPTION
                        return "KGL_LOTE_HOME_DESCRIPTION";
                    case 24: // IMMUNIZE
                        return "IMMUNIZE";
                    case 25: // DIPTHERIA_S
                        return "DIPTHERIA_S";
                    case 26: // TETANUS_S
                        return "TETANUS_S";
                    case 27: // POLIO_S
                        return "POLIO_S";
                    case 28: // PERTUSSIS_S
                        return "PERTUSSIS_S";
                    case 29: // HAEMOPHILUSB_S
                        return "HAEMOPHILUSB_S";
                    case 30: // MMR_S
                        return "MMR_S";
                    case 31: // IMMUN_CERT_STATUS
                        return "IMMUN_CERT_STATUS";
                    case 32: // KOORIE
                        return "KOORIE";
                    case 33: // C_MOBILITY
                        return "C_MOBILITY";
                    case 34: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 35: // BIRTH_COUNTRY
                        return "BIRTH_COUNTRY";
                    case 36: // KGT_SACC
                        return "KGT_SACC";
                    case 37: // KGT_DESCRIPTION
                        return "KGT_DESCRIPTION";
                    case 38: // KGT_ENGLISH_SPEAKING
                        return "KGT_ENGLISH_SPEAKING";
                    case 39: // RESIDENT_STATUS
                        return "RESIDENT_STATUS";
                    case 40: // PERMANENT_BASIS
                        return "PERMANENT_BASIS";
                    case 41: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 42: // VISA_STAT_CODE
                        return "VISA_STAT_CODE";
                    case 43: // KCV_VISA_SUBCLASS
                        return "KCV_VISA_SUBCLASS";
                    case 44: // KCV_SGB_FUNDED
                        return "KCV_SGB_FUNDED";
                    case 45: // KCV_CHECK_STAT_CODE
                        return "KCV_CHECK_STAT_CODE";
                    case 46: // KCV_VISA_RESIDENCY
                        return "KCV_VISA_RESIDENCY";
                    case 47: // C_SRP_STATUS
                        return "C_SRP_STATUS";
                    case 48: // EXIT_DATE
                        return "EXIT_DATE";
                    case 49: // KCY_NUM_EQVT
                        return "KCY_NUM_EQVT";
                    case 50: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 51: // KCY_KCYKEY
                        return "KCY_KCYKEY";
                    case 52: // LIVING_ARR
                        return "LIVING_ARR";
                    case 53: // C_LIVING_ARR
                        return "C_LIVING_ARR";
                    case 54: // PREVIOUS_SCHOOL
                        return "PREVIOUS_SCHOOL";
                    case 55: // SKGS_PREVIOUS_SCHOOL_ENTITY
                        return "SKGS_PREVIOUS_SCHOOL_ENTITY";
                    case 56: // SKGS_PREVIOUS_SCHOOL_ID
                        return "SKGS_PREVIOUS_SCHOOL_ID";
                    case 57: // C_FEEDER_ENTITY
                        return "C_FEEDER_ENTITY";
                    case 58: // C_FEEDER_SCHOOL_NUMBER
                        return "C_FEEDER_SCHOOL_NUMBER";
                    case 59: // C_FEEDER_SCHOOL_NAME
                        return "C_FEEDER_SCHOOL_NAME";
                    case 60: // CAMPUS
                        return "CAMPUS";
                    case 61: // SKGS_CAMPUS_NAME
                        return "SKGS_CAMPUS_NAME";
                    case 62: // SKGS_SCHOOL_TYPE
                        return "SKGS_SCHOOL_TYPE";
                    case 63: // FAMILY
                        return "FAMILY";
                    case 64: // RELATION_A
                        return "RELATION_A";
                    case 65: // DF_GENDER_A
                        return "DF_GENDER_A";
                    case 66: // DF_SURNAME_A
                        return "DF_SURNAME_A";
                    case 67: // DF_TITLE_A
                        return "DF_TITLE_A";
                    case 68: // DF_NAME_A
                        return "DF_NAME_A";
                    case 69: // DF_BIRTH_COUNTRY_A
                        return "DF_BIRTH_COUNTRY_A";
                    case 70: // DF_KGT_SACC_A
                        return "DF_KGT_SACC_A";
                    case 71: // DF_KGT_DESCRIPTION_A
                        return "DF_KGT_DESCRIPTION_A";
                    case 72: // DF_KGT_ENGLISH_SPEAKING_A
                        return "DF_KGT_ENGLISH_SPEAKING_A";
                    case 73: // DF_OCCUP_STATUS_A
                        return "DF_OCCUP_STATUS_A";
                    case 74: // DF_LOTE_HOME_CODE_A
                        return "DF_LOTE_HOME_CODE_A";
                    case 75: // DF_KGL_LOTE_HOME_ASCL_A
                        return "DF_KGL_LOTE_HOME_ASCL_A";
                    case 76: // DF_KGL_LOTE_HOME_DESCRIPTION_A
                        return "DF_KGL_LOTE_HOME_DESCRIPTION_A";
                    case 77: // DF_GENDER_B
                        return "DF_GENDER_B";
                    case 78: // DF_SURNAME_B
                        return "DF_SURNAME_B";
                    case 79: // DF_TITLE_B
                        return "DF_TITLE_B";
                    case 80: // DF_NAME_B
                        return "DF_NAME_B";
                    case 81: // DF_BIRTH_COUNTRY_B
                        return "DF_BIRTH_COUNTRY_B";
                    case 82: // DF_KGT_ENGLISH_SPEAKING_B
                        return "DF_KGT_ENGLISH_SPEAKING_B";
                    case 83: // DF_KGT_SACC_B
                        return "DF_KGT_SACC_B";
                    case 84: // DF_KGT_DESCRIPTION_B
                        return "DF_KGT_DESCRIPTION_B";
                    case 85: // DF_OCCUP_STATUS_B
                        return "DF_OCCUP_STATUS_B";
                    case 86: // DF_LOTE_HOME_CODE_B
                        return "DF_LOTE_HOME_CODE_B";
                    case 87: // DF_KGL_LOTE_HOME_ASCL_B
                        return "DF_KGL_LOTE_HOME_ASCL_B";
                    case 88: // DF_KGL_LOTE_HOME_DESCRIPTION_B
                        return "DF_KGL_LOTE_HOME_DESCRIPTION_B";
                    case 89: // C_FAM_OCCUPATION
                        return "C_FAM_OCCUPATION";
                    case 90: // C_LBOTE
                        return "C_LBOTE";
                    case 91: // C_YTD_ABSENCE
                        return "C_YTD_ABSENCE";
                    case 92: // C_CENSUSDAY
                        return "C_CENSUSDAY";
                    case 93: // C_YTD_APPROVED
                        return "C_YTD_APPROVED";
                    case 94: // C_LAST_ABS_DAY
                        return "C_LAST_ABS_DAY";
                    case 95: // C_START_SCHOOL_YEAR
                        return "C_START_SCHOOL_YEAR";
                    case 96: // C_ELIGIBLE_S_DAYS
                        return "C_ELIGIBLE_S_DAYS";
                    case 97: // C_LBOTE_MCEETYA
                        return "C_LBOTE_MCEETYA";
                    case 98: // FULLTIME
                        return "FULLTIME";
                    case 99: // SGB_TIME_FRACTION
                        return "SGB_TIME_FRACTION";
                    case 100: // STPT_SCHL_NUM01
                        return "STPT_SCHL_NUM01";
                    case 101: // STPT_SCHL_NUM02
                        return "STPT_SCHL_NUM02";
                    case 102: // STPT_SCHL_NUM03
                        return "STPT_SCHL_NUM03";
                    case 103: // STPT_SCHL_NUM04
                        return "STPT_SCHL_NUM04";
                    case 104: // SKGS_STPT_ENTITY01
                        return "SKGS_STPT_ENTITY01";
                    case 105: // SKGS_STPT_ENTITY02
                        return "SKGS_STPT_ENTITY02";
                    case 106: // SKGS_STPT_ENTITY03
                        return "SKGS_STPT_ENTITY03";
                    case 107: // SKGS_STPT_ENTITY04
                        return "SKGS_STPT_ENTITY04";
                    case 108: // SKGS_STPT_SCHOOL_ID01
                        return "SKGS_STPT_SCHOOL_ID01";
                    case 109: // SKGS_STPT_SCHOOL_ID02
                        return "SKGS_STPT_SCHOOL_ID02";
                    case 110: // SKGS_STPT_SCHOOL_ID03
                        return "SKGS_STPT_SCHOOL_ID03";
                    case 111: // SKGS_STPT_SCHOOL_ID04
                        return "SKGS_STPT_SCHOOL_ID04";
                    case 112: // SKGS_STPT_SCHOOL_NAME01
                        return "SKGS_STPT_SCHOOL_NAME01";
                    case 113: // SKGS_STPT_SCHOOL_NAME02
                        return "SKGS_STPT_SCHOOL_NAME02";
                    case 114: // SKGS_STPT_SCHOOL_NAME03
                        return "SKGS_STPT_SCHOOL_NAME03";
                    case 115: // SKGS_STPT_SCHOOL_NAME04
                        return "SKGS_STPT_SCHOOL_NAME04";
                    case 116: // STPT_SGB_TIME_FRACTION01
                        return "STPT_SGB_TIME_FRACTION01";
                    case 117: // STPT_SGB_TIME_FRACTION02
                        return "STPT_SGB_TIME_FRACTION02";
                    case 118: // STPT_SGB_TIME_FRACTION03
                        return "STPT_SGB_TIME_FRACTION03";
                    case 119: // STPT_SGB_TIME_FRACTION04
                        return "STPT_SGB_TIME_FRACTION04";
                    case 120: // POSTCODE
                        return "POSTCODE";
                    case 121: // REPEAT
                        return "REPEAT";
                    case 122: // INTERNATIONAL_ST_ID
                        return "INTERNATIONAL_ST_ID";
                    case 123: // LCREATED
                        return "LCREATED";
                    case 124: // VSN
                        return "VSN";
                    case 125: // DF_SCH_ED_A
                        return "DF_SCH_ED_A";
                    case 126: // DF_SCH_ED_B
                        return "DF_SCH_ED_B";
                    case 127: // DF_NON_SCH_ED_A
                        return "DF_NON_SCH_ED_A";
                    case 128: // DF_NON_SCH_ED_B
                        return "DF_NON_SCH_ED_B";
                    case 129: // ADDRESS_B
                        return "ADDRESS_B";
                    case 130: // ADDRESS_C
                        return "ADDRESS_C";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "C_SOURCE":
                        return 1;
                    case "STKEY":
                        return 2;
                    case "REGISTRATION":
                        return 3;
                    case "SURNAME":
                        return 4;
                    case "FIRST_NAME":
                        return 5;
                    case "SECOND_NAME":
                        return 6;
                    case "GENDER":
                        return 7;
                    case "C_AGE_1st_JAN":
                        return 8;
                    case "C_AGE_1st_JULY":
                        return 9;
                    case "AUSSIE_SCHOOL":
                        return 10;
                    case "BIRTHDATE":
                        return 11;
                    case "DISABILITY":
                        return 12;
                    case "DISABILITY_ID":
                        return 13;
                    case "ENTRY":
                        return 14;
                    case "STATUS":
                        return 15;
                    case "HOME_GROUP":
                        return 16;
                    case "KGC_HOME_GROUP":
                        return 17;
                    case "HOME_LANG":
                        return 18;
                    case "KGL_ASCL":
                        return 19;
                    case "KGL_DESCRIPTION":
                        return 20;
                    case "LOTE_HOME_CODE":
                        return 21;
                    case "KGL_LOTE_HOME_ASCL":
                        return 22;
                    case "KGL_LOTE_HOME_DESCRIPTION":
                        return 23;
                    case "IMMUNIZE":
                        return 24;
                    case "DIPTHERIA_S":
                        return 25;
                    case "TETANUS_S":
                        return 26;
                    case "POLIO_S":
                        return 27;
                    case "PERTUSSIS_S":
                        return 28;
                    case "HAEMOPHILUSB_S":
                        return 29;
                    case "MMR_S":
                        return 30;
                    case "IMMUN_CERT_STATUS":
                        return 31;
                    case "KOORIE":
                        return 32;
                    case "C_MOBILITY":
                        return 33;
                    case "SGB_FUNDED":
                        return 34;
                    case "BIRTH_COUNTRY":
                        return 35;
                    case "KGT_SACC":
                        return 36;
                    case "KGT_DESCRIPTION":
                        return 37;
                    case "KGT_ENGLISH_SPEAKING":
                        return 38;
                    case "RESIDENT_STATUS":
                        return 39;
                    case "PERMANENT_BASIS":
                        return 40;
                    case "VISA_SUBCLASS":
                        return 41;
                    case "VISA_STAT_CODE":
                        return 42;
                    case "KCV_VISA_SUBCLASS":
                        return 43;
                    case "KCV_SGB_FUNDED":
                        return 44;
                    case "KCV_CHECK_STAT_CODE":
                        return 45;
                    case "KCV_VISA_RESIDENCY":
                        return 46;
                    case "C_SRP_STATUS":
                        return 47;
                    case "EXIT_DATE":
                        return 48;
                    case "KCY_NUM_EQVT":
                        return 49;
                    case "SCHOOL_YEAR":
                        return 50;
                    case "KCY_KCYKEY":
                        return 51;
                    case "LIVING_ARR":
                        return 52;
                    case "C_LIVING_ARR":
                        return 53;
                    case "PREVIOUS_SCHOOL":
                        return 54;
                    case "SKGS_PREVIOUS_SCHOOL_ENTITY":
                        return 55;
                    case "SKGS_PREVIOUS_SCHOOL_ID":
                        return 56;
                    case "C_FEEDER_ENTITY":
                        return 57;
                    case "C_FEEDER_SCHOOL_NUMBER":
                        return 58;
                    case "C_FEEDER_SCHOOL_NAME":
                        return 59;
                    case "CAMPUS":
                        return 60;
                    case "SKGS_CAMPUS_NAME":
                        return 61;
                    case "SKGS_SCHOOL_TYPE":
                        return 62;
                    case "FAMILY":
                        return 63;
                    case "RELATION_A":
                        return 64;
                    case "DF_GENDER_A":
                        return 65;
                    case "DF_SURNAME_A":
                        return 66;
                    case "DF_TITLE_A":
                        return 67;
                    case "DF_NAME_A":
                        return 68;
                    case "DF_BIRTH_COUNTRY_A":
                        return 69;
                    case "DF_KGT_SACC_A":
                        return 70;
                    case "DF_KGT_DESCRIPTION_A":
                        return 71;
                    case "DF_KGT_ENGLISH_SPEAKING_A":
                        return 72;
                    case "DF_OCCUP_STATUS_A":
                        return 73;
                    case "DF_LOTE_HOME_CODE_A":
                        return 74;
                    case "DF_KGL_LOTE_HOME_ASCL_A":
                        return 75;
                    case "DF_KGL_LOTE_HOME_DESCRIPTION_A":
                        return 76;
                    case "DF_GENDER_B":
                        return 77;
                    case "DF_SURNAME_B":
                        return 78;
                    case "DF_TITLE_B":
                        return 79;
                    case "DF_NAME_B":
                        return 80;
                    case "DF_BIRTH_COUNTRY_B":
                        return 81;
                    case "DF_KGT_ENGLISH_SPEAKING_B":
                        return 82;
                    case "DF_KGT_SACC_B":
                        return 83;
                    case "DF_KGT_DESCRIPTION_B":
                        return 84;
                    case "DF_OCCUP_STATUS_B":
                        return 85;
                    case "DF_LOTE_HOME_CODE_B":
                        return 86;
                    case "DF_KGL_LOTE_HOME_ASCL_B":
                        return 87;
                    case "DF_KGL_LOTE_HOME_DESCRIPTION_B":
                        return 88;
                    case "C_FAM_OCCUPATION":
                        return 89;
                    case "C_LBOTE":
                        return 90;
                    case "C_YTD_ABSENCE":
                        return 91;
                    case "C_CENSUSDAY":
                        return 92;
                    case "C_YTD_APPROVED":
                        return 93;
                    case "C_LAST_ABS_DAY":
                        return 94;
                    case "C_START_SCHOOL_YEAR":
                        return 95;
                    case "C_ELIGIBLE_S_DAYS":
                        return 96;
                    case "C_LBOTE_MCEETYA":
                        return 97;
                    case "FULLTIME":
                        return 98;
                    case "SGB_TIME_FRACTION":
                        return 99;
                    case "STPT_SCHL_NUM01":
                        return 100;
                    case "STPT_SCHL_NUM02":
                        return 101;
                    case "STPT_SCHL_NUM03":
                        return 102;
                    case "STPT_SCHL_NUM04":
                        return 103;
                    case "SKGS_STPT_ENTITY01":
                        return 104;
                    case "SKGS_STPT_ENTITY02":
                        return 105;
                    case "SKGS_STPT_ENTITY03":
                        return 106;
                    case "SKGS_STPT_ENTITY04":
                        return 107;
                    case "SKGS_STPT_SCHOOL_ID01":
                        return 108;
                    case "SKGS_STPT_SCHOOL_ID02":
                        return 109;
                    case "SKGS_STPT_SCHOOL_ID03":
                        return 110;
                    case "SKGS_STPT_SCHOOL_ID04":
                        return 111;
                    case "SKGS_STPT_SCHOOL_NAME01":
                        return 112;
                    case "SKGS_STPT_SCHOOL_NAME02":
                        return 113;
                    case "SKGS_STPT_SCHOOL_NAME03":
                        return 114;
                    case "SKGS_STPT_SCHOOL_NAME04":
                        return 115;
                    case "STPT_SGB_TIME_FRACTION01":
                        return 116;
                    case "STPT_SGB_TIME_FRACTION02":
                        return 117;
                    case "STPT_SGB_TIME_FRACTION03":
                        return 118;
                    case "STPT_SGB_TIME_FRACTION04":
                        return 119;
                    case "POSTCODE":
                        return 120;
                    case "REPEAT":
                        return 121;
                    case "INTERNATIONAL_ST_ID":
                        return 122;
                    case "LCREATED":
                        return 123;
                    case "VSN":
                        return 124;
                    case "DF_SCH_ED_A":
                        return 125;
                    case "DF_SCH_ED_B":
                        return 126;
                    case "DF_NON_SCH_ED_A":
                        return 127;
                    case "DF_NON_SCH_ED_B":
                        return 128;
                    case "ADDRESS_B":
                        return 129;
                    case "ADDRESS_C":
                        return 130;
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
