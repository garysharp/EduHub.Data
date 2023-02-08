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
    /// Archived Census Student Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ASTDataSet : EduHubDataSet<SCEN_AST>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_AST"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_ASTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_AST>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_AST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_AST" /> fields for each CSV column header</returns>
        internal override Action<SCEN_AST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_AST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
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
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "DISABILITY_ID":
                        mapper[i] = (e, v) => e.DISABILITY_ID = v;
                        break;
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.EXIT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (short?)null : short.Parse(v);
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
                        mapper[i] = (e, v) => e.C_LAST_ABS_DAY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "C_START_SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.C_START_SCHOOL_YEAR = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.LCREATED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SCEN_AST" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_AST" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_AST" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_AST}"/> of entities</returns>
        internal override IEnumerable<SCEN_AST> ApplyDeltaEntities(IEnumerable<SCEN_AST> Entities, List<SCEN_AST> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SCEN_AST>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_AST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_AST</param>
        /// <returns>Related SCEN_AST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_AST FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_AST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_AST</param>
        /// <param name="Value">Related SCEN_AST entity</param>
        /// <returns>True if the related SCEN_AST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_AST Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_AST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_AST</param>
        /// <returns>Related SCEN_AST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_AST TryFindByID(int ID)
        {
            SCEN_AST value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_AST table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_AST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_AST](
        [ID] int IDENTITY NOT NULL,
        [ID_RETURN] int NULL,
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
        [CAMPUS] smallint NULL,
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
        CONSTRAINT [SCEN_AST_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ASTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ASTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_AST"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_AST"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_AST> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_AST] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_AST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_AST data set</returns>
        public override EduHubDataSetDataReader<SCEN_AST> GetDataSetDataReader()
        {
            return new SCEN_ASTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_AST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_AST data set</returns>
        public override EduHubDataSetDataReader<SCEN_AST> GetDataSetDataReader(List<SCEN_AST> Entities)
        {
            return new SCEN_ASTDataReader(new EduHubDataSetLoadedReader<SCEN_AST>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_ASTDataReader : EduHubDataSetDataReader<SCEN_AST>
        {
            public SCEN_ASTDataReader(IEduHubDataSetReader<SCEN_AST> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 132; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // ID_RETURN
                        return Current.ID_RETURN;
                    case 2: // C_SOURCE
                        return Current.C_SOURCE;
                    case 3: // STKEY
                        return Current.STKEY;
                    case 4: // REGISTRATION
                        return Current.REGISTRATION;
                    case 5: // SURNAME
                        return Current.SURNAME;
                    case 6: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 7: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 8: // GENDER
                        return Current.GENDER;
                    case 9: // C_AGE_1st_JAN
                        return Current.C_AGE_1st_JAN;
                    case 10: // C_AGE_1st_JULY
                        return Current.C_AGE_1st_JULY;
                    case 11: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL;
                    case 12: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 13: // DISABILITY
                        return Current.DISABILITY;
                    case 14: // DISABILITY_ID
                        return Current.DISABILITY_ID;
                    case 15: // ENTRY
                        return Current.ENTRY;
                    case 16: // STATUS
                        return Current.STATUS;
                    case 17: // HOME_GROUP
                        return Current.HOME_GROUP;
                    case 18: // KGC_HOME_GROUP
                        return Current.KGC_HOME_GROUP;
                    case 19: // HOME_LANG
                        return Current.HOME_LANG;
                    case 20: // KGL_ASCL
                        return Current.KGL_ASCL;
                    case 21: // KGL_DESCRIPTION
                        return Current.KGL_DESCRIPTION;
                    case 22: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE;
                    case 23: // KGL_LOTE_HOME_ASCL
                        return Current.KGL_LOTE_HOME_ASCL;
                    case 24: // KGL_LOTE_HOME_DESCRIPTION
                        return Current.KGL_LOTE_HOME_DESCRIPTION;
                    case 25: // IMMUNIZE
                        return Current.IMMUNIZE;
                    case 26: // DIPTHERIA_S
                        return Current.DIPTHERIA_S;
                    case 27: // TETANUS_S
                        return Current.TETANUS_S;
                    case 28: // POLIO_S
                        return Current.POLIO_S;
                    case 29: // PERTUSSIS_S
                        return Current.PERTUSSIS_S;
                    case 30: // HAEMOPHILUSB_S
                        return Current.HAEMOPHILUSB_S;
                    case 31: // MMR_S
                        return Current.MMR_S;
                    case 32: // IMMUN_CERT_STATUS
                        return Current.IMMUN_CERT_STATUS;
                    case 33: // KOORIE
                        return Current.KOORIE;
                    case 34: // C_MOBILITY
                        return Current.C_MOBILITY;
                    case 35: // SGB_FUNDED
                        return Current.SGB_FUNDED;
                    case 36: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY;
                    case 37: // KGT_SACC
                        return Current.KGT_SACC;
                    case 38: // KGT_DESCRIPTION
                        return Current.KGT_DESCRIPTION;
                    case 39: // KGT_ENGLISH_SPEAKING
                        return Current.KGT_ENGLISH_SPEAKING;
                    case 40: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS;
                    case 41: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS;
                    case 42: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS;
                    case 43: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE;
                    case 44: // KCV_VISA_SUBCLASS
                        return Current.KCV_VISA_SUBCLASS;
                    case 45: // KCV_SGB_FUNDED
                        return Current.KCV_SGB_FUNDED;
                    case 46: // KCV_CHECK_STAT_CODE
                        return Current.KCV_CHECK_STAT_CODE;
                    case 47: // KCV_VISA_RESIDENCY
                        return Current.KCV_VISA_RESIDENCY;
                    case 48: // C_SRP_STATUS
                        return Current.C_SRP_STATUS;
                    case 49: // EXIT_DATE
                        return Current.EXIT_DATE;
                    case 50: // KCY_NUM_EQVT
                        return Current.KCY_NUM_EQVT;
                    case 51: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 52: // KCY_KCYKEY
                        return Current.KCY_KCYKEY;
                    case 53: // LIVING_ARR
                        return Current.LIVING_ARR;
                    case 54: // C_LIVING_ARR
                        return Current.C_LIVING_ARR;
                    case 55: // PREVIOUS_SCHOOL
                        return Current.PREVIOUS_SCHOOL;
                    case 56: // SKGS_PREVIOUS_SCHOOL_ENTITY
                        return Current.SKGS_PREVIOUS_SCHOOL_ENTITY;
                    case 57: // SKGS_PREVIOUS_SCHOOL_ID
                        return Current.SKGS_PREVIOUS_SCHOOL_ID;
                    case 58: // C_FEEDER_ENTITY
                        return Current.C_FEEDER_ENTITY;
                    case 59: // C_FEEDER_SCHOOL_NUMBER
                        return Current.C_FEEDER_SCHOOL_NUMBER;
                    case 60: // C_FEEDER_SCHOOL_NAME
                        return Current.C_FEEDER_SCHOOL_NAME;
                    case 61: // CAMPUS
                        return Current.CAMPUS;
                    case 62: // SKGS_CAMPUS_NAME
                        return Current.SKGS_CAMPUS_NAME;
                    case 63: // SKGS_SCHOOL_TYPE
                        return Current.SKGS_SCHOOL_TYPE;
                    case 64: // FAMILY
                        return Current.FAMILY;
                    case 65: // RELATION_A
                        return Current.RELATION_A;
                    case 66: // DF_GENDER_A
                        return Current.DF_GENDER_A;
                    case 67: // DF_SURNAME_A
                        return Current.DF_SURNAME_A;
                    case 68: // DF_TITLE_A
                        return Current.DF_TITLE_A;
                    case 69: // DF_NAME_A
                        return Current.DF_NAME_A;
                    case 70: // DF_BIRTH_COUNTRY_A
                        return Current.DF_BIRTH_COUNTRY_A;
                    case 71: // DF_KGT_SACC_A
                        return Current.DF_KGT_SACC_A;
                    case 72: // DF_KGT_DESCRIPTION_A
                        return Current.DF_KGT_DESCRIPTION_A;
                    case 73: // DF_KGT_ENGLISH_SPEAKING_A
                        return Current.DF_KGT_ENGLISH_SPEAKING_A;
                    case 74: // DF_OCCUP_STATUS_A
                        return Current.DF_OCCUP_STATUS_A;
                    case 75: // DF_LOTE_HOME_CODE_A
                        return Current.DF_LOTE_HOME_CODE_A;
                    case 76: // DF_KGL_LOTE_HOME_ASCL_A
                        return Current.DF_KGL_LOTE_HOME_ASCL_A;
                    case 77: // DF_KGL_LOTE_HOME_DESCRIPTION_A
                        return Current.DF_KGL_LOTE_HOME_DESCRIPTION_A;
                    case 78: // DF_GENDER_B
                        return Current.DF_GENDER_B;
                    case 79: // DF_SURNAME_B
                        return Current.DF_SURNAME_B;
                    case 80: // DF_TITLE_B
                        return Current.DF_TITLE_B;
                    case 81: // DF_NAME_B
                        return Current.DF_NAME_B;
                    case 82: // DF_BIRTH_COUNTRY_B
                        return Current.DF_BIRTH_COUNTRY_B;
                    case 83: // DF_KGT_ENGLISH_SPEAKING_B
                        return Current.DF_KGT_ENGLISH_SPEAKING_B;
                    case 84: // DF_KGT_SACC_B
                        return Current.DF_KGT_SACC_B;
                    case 85: // DF_KGT_DESCRIPTION_B
                        return Current.DF_KGT_DESCRIPTION_B;
                    case 86: // DF_OCCUP_STATUS_B
                        return Current.DF_OCCUP_STATUS_B;
                    case 87: // DF_LOTE_HOME_CODE_B
                        return Current.DF_LOTE_HOME_CODE_B;
                    case 88: // DF_KGL_LOTE_HOME_ASCL_B
                        return Current.DF_KGL_LOTE_HOME_ASCL_B;
                    case 89: // DF_KGL_LOTE_HOME_DESCRIPTION_B
                        return Current.DF_KGL_LOTE_HOME_DESCRIPTION_B;
                    case 90: // C_FAM_OCCUPATION
                        return Current.C_FAM_OCCUPATION;
                    case 91: // C_LBOTE
                        return Current.C_LBOTE;
                    case 92: // C_YTD_ABSENCE
                        return Current.C_YTD_ABSENCE;
                    case 93: // C_CENSUSDAY
                        return Current.C_CENSUSDAY;
                    case 94: // C_YTD_APPROVED
                        return Current.C_YTD_APPROVED;
                    case 95: // C_LAST_ABS_DAY
                        return Current.C_LAST_ABS_DAY;
                    case 96: // C_START_SCHOOL_YEAR
                        return Current.C_START_SCHOOL_YEAR;
                    case 97: // C_ELIGIBLE_S_DAYS
                        return Current.C_ELIGIBLE_S_DAYS;
                    case 98: // C_LBOTE_MCEETYA
                        return Current.C_LBOTE_MCEETYA;
                    case 99: // FULLTIME
                        return Current.FULLTIME;
                    case 100: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION;
                    case 101: // STPT_SCHL_NUM01
                        return Current.STPT_SCHL_NUM01;
                    case 102: // STPT_SCHL_NUM02
                        return Current.STPT_SCHL_NUM02;
                    case 103: // STPT_SCHL_NUM03
                        return Current.STPT_SCHL_NUM03;
                    case 104: // STPT_SCHL_NUM04
                        return Current.STPT_SCHL_NUM04;
                    case 105: // SKGS_STPT_ENTITY01
                        return Current.SKGS_STPT_ENTITY01;
                    case 106: // SKGS_STPT_ENTITY02
                        return Current.SKGS_STPT_ENTITY02;
                    case 107: // SKGS_STPT_ENTITY03
                        return Current.SKGS_STPT_ENTITY03;
                    case 108: // SKGS_STPT_ENTITY04
                        return Current.SKGS_STPT_ENTITY04;
                    case 109: // SKGS_STPT_SCHOOL_ID01
                        return Current.SKGS_STPT_SCHOOL_ID01;
                    case 110: // SKGS_STPT_SCHOOL_ID02
                        return Current.SKGS_STPT_SCHOOL_ID02;
                    case 111: // SKGS_STPT_SCHOOL_ID03
                        return Current.SKGS_STPT_SCHOOL_ID03;
                    case 112: // SKGS_STPT_SCHOOL_ID04
                        return Current.SKGS_STPT_SCHOOL_ID04;
                    case 113: // SKGS_STPT_SCHOOL_NAME01
                        return Current.SKGS_STPT_SCHOOL_NAME01;
                    case 114: // SKGS_STPT_SCHOOL_NAME02
                        return Current.SKGS_STPT_SCHOOL_NAME02;
                    case 115: // SKGS_STPT_SCHOOL_NAME03
                        return Current.SKGS_STPT_SCHOOL_NAME03;
                    case 116: // SKGS_STPT_SCHOOL_NAME04
                        return Current.SKGS_STPT_SCHOOL_NAME04;
                    case 117: // STPT_SGB_TIME_FRACTION01
                        return Current.STPT_SGB_TIME_FRACTION01;
                    case 118: // STPT_SGB_TIME_FRACTION02
                        return Current.STPT_SGB_TIME_FRACTION02;
                    case 119: // STPT_SGB_TIME_FRACTION03
                        return Current.STPT_SGB_TIME_FRACTION03;
                    case 120: // STPT_SGB_TIME_FRACTION04
                        return Current.STPT_SGB_TIME_FRACTION04;
                    case 121: // POSTCODE
                        return Current.POSTCODE;
                    case 122: // REPEAT
                        return Current.REPEAT;
                    case 123: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID;
                    case 124: // LCREATED
                        return Current.LCREATED;
                    case 125: // VSN
                        return Current.VSN;
                    case 126: // DF_SCH_ED_A
                        return Current.DF_SCH_ED_A;
                    case 127: // DF_SCH_ED_B
                        return Current.DF_SCH_ED_B;
                    case 128: // DF_NON_SCH_ED_A
                        return Current.DF_NON_SCH_ED_A;
                    case 129: // DF_NON_SCH_ED_B
                        return Current.DF_NON_SCH_ED_B;
                    case 130: // ADDRESS_B
                        return Current.ADDRESS_B;
                    case 131: // ADDRESS_C
                        return Current.ADDRESS_C;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ID_RETURN
                        return Current.ID_RETURN == null;
                    case 2: // C_SOURCE
                        return Current.C_SOURCE == null;
                    case 3: // STKEY
                        return Current.STKEY == null;
                    case 4: // REGISTRATION
                        return Current.REGISTRATION == null;
                    case 5: // SURNAME
                        return Current.SURNAME == null;
                    case 6: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 7: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 8: // GENDER
                        return Current.GENDER == null;
                    case 9: // C_AGE_1st_JAN
                        return Current.C_AGE_1st_JAN == null;
                    case 10: // C_AGE_1st_JULY
                        return Current.C_AGE_1st_JULY == null;
                    case 11: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL == null;
                    case 12: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 13: // DISABILITY
                        return Current.DISABILITY == null;
                    case 14: // DISABILITY_ID
                        return Current.DISABILITY_ID == null;
                    case 15: // ENTRY
                        return Current.ENTRY == null;
                    case 16: // STATUS
                        return Current.STATUS == null;
                    case 17: // HOME_GROUP
                        return Current.HOME_GROUP == null;
                    case 18: // KGC_HOME_GROUP
                        return Current.KGC_HOME_GROUP == null;
                    case 19: // HOME_LANG
                        return Current.HOME_LANG == null;
                    case 20: // KGL_ASCL
                        return Current.KGL_ASCL == null;
                    case 21: // KGL_DESCRIPTION
                        return Current.KGL_DESCRIPTION == null;
                    case 22: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE == null;
                    case 23: // KGL_LOTE_HOME_ASCL
                        return Current.KGL_LOTE_HOME_ASCL == null;
                    case 24: // KGL_LOTE_HOME_DESCRIPTION
                        return Current.KGL_LOTE_HOME_DESCRIPTION == null;
                    case 25: // IMMUNIZE
                        return Current.IMMUNIZE == null;
                    case 26: // DIPTHERIA_S
                        return Current.DIPTHERIA_S == null;
                    case 27: // TETANUS_S
                        return Current.TETANUS_S == null;
                    case 28: // POLIO_S
                        return Current.POLIO_S == null;
                    case 29: // PERTUSSIS_S
                        return Current.PERTUSSIS_S == null;
                    case 30: // HAEMOPHILUSB_S
                        return Current.HAEMOPHILUSB_S == null;
                    case 31: // MMR_S
                        return Current.MMR_S == null;
                    case 32: // IMMUN_CERT_STATUS
                        return Current.IMMUN_CERT_STATUS == null;
                    case 33: // KOORIE
                        return Current.KOORIE == null;
                    case 34: // C_MOBILITY
                        return Current.C_MOBILITY == null;
                    case 35: // SGB_FUNDED
                        return Current.SGB_FUNDED == null;
                    case 36: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY == null;
                    case 37: // KGT_SACC
                        return Current.KGT_SACC == null;
                    case 38: // KGT_DESCRIPTION
                        return Current.KGT_DESCRIPTION == null;
                    case 39: // KGT_ENGLISH_SPEAKING
                        return Current.KGT_ENGLISH_SPEAKING == null;
                    case 40: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS == null;
                    case 41: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS == null;
                    case 42: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS == null;
                    case 43: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE == null;
                    case 44: // KCV_VISA_SUBCLASS
                        return Current.KCV_VISA_SUBCLASS == null;
                    case 45: // KCV_SGB_FUNDED
                        return Current.KCV_SGB_FUNDED == null;
                    case 46: // KCV_CHECK_STAT_CODE
                        return Current.KCV_CHECK_STAT_CODE == null;
                    case 47: // KCV_VISA_RESIDENCY
                        return Current.KCV_VISA_RESIDENCY == null;
                    case 48: // C_SRP_STATUS
                        return Current.C_SRP_STATUS == null;
                    case 49: // EXIT_DATE
                        return Current.EXIT_DATE == null;
                    case 50: // KCY_NUM_EQVT
                        return Current.KCY_NUM_EQVT == null;
                    case 51: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 52: // KCY_KCYKEY
                        return Current.KCY_KCYKEY == null;
                    case 53: // LIVING_ARR
                        return Current.LIVING_ARR == null;
                    case 54: // C_LIVING_ARR
                        return Current.C_LIVING_ARR == null;
                    case 55: // PREVIOUS_SCHOOL
                        return Current.PREVIOUS_SCHOOL == null;
                    case 56: // SKGS_PREVIOUS_SCHOOL_ENTITY
                        return Current.SKGS_PREVIOUS_SCHOOL_ENTITY == null;
                    case 57: // SKGS_PREVIOUS_SCHOOL_ID
                        return Current.SKGS_PREVIOUS_SCHOOL_ID == null;
                    case 58: // C_FEEDER_ENTITY
                        return Current.C_FEEDER_ENTITY == null;
                    case 59: // C_FEEDER_SCHOOL_NUMBER
                        return Current.C_FEEDER_SCHOOL_NUMBER == null;
                    case 60: // C_FEEDER_SCHOOL_NAME
                        return Current.C_FEEDER_SCHOOL_NAME == null;
                    case 61: // CAMPUS
                        return Current.CAMPUS == null;
                    case 62: // SKGS_CAMPUS_NAME
                        return Current.SKGS_CAMPUS_NAME == null;
                    case 63: // SKGS_SCHOOL_TYPE
                        return Current.SKGS_SCHOOL_TYPE == null;
                    case 64: // FAMILY
                        return Current.FAMILY == null;
                    case 65: // RELATION_A
                        return Current.RELATION_A == null;
                    case 66: // DF_GENDER_A
                        return Current.DF_GENDER_A == null;
                    case 67: // DF_SURNAME_A
                        return Current.DF_SURNAME_A == null;
                    case 68: // DF_TITLE_A
                        return Current.DF_TITLE_A == null;
                    case 69: // DF_NAME_A
                        return Current.DF_NAME_A == null;
                    case 70: // DF_BIRTH_COUNTRY_A
                        return Current.DF_BIRTH_COUNTRY_A == null;
                    case 71: // DF_KGT_SACC_A
                        return Current.DF_KGT_SACC_A == null;
                    case 72: // DF_KGT_DESCRIPTION_A
                        return Current.DF_KGT_DESCRIPTION_A == null;
                    case 73: // DF_KGT_ENGLISH_SPEAKING_A
                        return Current.DF_KGT_ENGLISH_SPEAKING_A == null;
                    case 74: // DF_OCCUP_STATUS_A
                        return Current.DF_OCCUP_STATUS_A == null;
                    case 75: // DF_LOTE_HOME_CODE_A
                        return Current.DF_LOTE_HOME_CODE_A == null;
                    case 76: // DF_KGL_LOTE_HOME_ASCL_A
                        return Current.DF_KGL_LOTE_HOME_ASCL_A == null;
                    case 77: // DF_KGL_LOTE_HOME_DESCRIPTION_A
                        return Current.DF_KGL_LOTE_HOME_DESCRIPTION_A == null;
                    case 78: // DF_GENDER_B
                        return Current.DF_GENDER_B == null;
                    case 79: // DF_SURNAME_B
                        return Current.DF_SURNAME_B == null;
                    case 80: // DF_TITLE_B
                        return Current.DF_TITLE_B == null;
                    case 81: // DF_NAME_B
                        return Current.DF_NAME_B == null;
                    case 82: // DF_BIRTH_COUNTRY_B
                        return Current.DF_BIRTH_COUNTRY_B == null;
                    case 83: // DF_KGT_ENGLISH_SPEAKING_B
                        return Current.DF_KGT_ENGLISH_SPEAKING_B == null;
                    case 84: // DF_KGT_SACC_B
                        return Current.DF_KGT_SACC_B == null;
                    case 85: // DF_KGT_DESCRIPTION_B
                        return Current.DF_KGT_DESCRIPTION_B == null;
                    case 86: // DF_OCCUP_STATUS_B
                        return Current.DF_OCCUP_STATUS_B == null;
                    case 87: // DF_LOTE_HOME_CODE_B
                        return Current.DF_LOTE_HOME_CODE_B == null;
                    case 88: // DF_KGL_LOTE_HOME_ASCL_B
                        return Current.DF_KGL_LOTE_HOME_ASCL_B == null;
                    case 89: // DF_KGL_LOTE_HOME_DESCRIPTION_B
                        return Current.DF_KGL_LOTE_HOME_DESCRIPTION_B == null;
                    case 90: // C_FAM_OCCUPATION
                        return Current.C_FAM_OCCUPATION == null;
                    case 91: // C_LBOTE
                        return Current.C_LBOTE == null;
                    case 92: // C_YTD_ABSENCE
                        return Current.C_YTD_ABSENCE == null;
                    case 93: // C_CENSUSDAY
                        return Current.C_CENSUSDAY == null;
                    case 94: // C_YTD_APPROVED
                        return Current.C_YTD_APPROVED == null;
                    case 95: // C_LAST_ABS_DAY
                        return Current.C_LAST_ABS_DAY == null;
                    case 96: // C_START_SCHOOL_YEAR
                        return Current.C_START_SCHOOL_YEAR == null;
                    case 97: // C_ELIGIBLE_S_DAYS
                        return Current.C_ELIGIBLE_S_DAYS == null;
                    case 98: // C_LBOTE_MCEETYA
                        return Current.C_LBOTE_MCEETYA == null;
                    case 99: // FULLTIME
                        return Current.FULLTIME == null;
                    case 100: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION == null;
                    case 101: // STPT_SCHL_NUM01
                        return Current.STPT_SCHL_NUM01 == null;
                    case 102: // STPT_SCHL_NUM02
                        return Current.STPT_SCHL_NUM02 == null;
                    case 103: // STPT_SCHL_NUM03
                        return Current.STPT_SCHL_NUM03 == null;
                    case 104: // STPT_SCHL_NUM04
                        return Current.STPT_SCHL_NUM04 == null;
                    case 105: // SKGS_STPT_ENTITY01
                        return Current.SKGS_STPT_ENTITY01 == null;
                    case 106: // SKGS_STPT_ENTITY02
                        return Current.SKGS_STPT_ENTITY02 == null;
                    case 107: // SKGS_STPT_ENTITY03
                        return Current.SKGS_STPT_ENTITY03 == null;
                    case 108: // SKGS_STPT_ENTITY04
                        return Current.SKGS_STPT_ENTITY04 == null;
                    case 109: // SKGS_STPT_SCHOOL_ID01
                        return Current.SKGS_STPT_SCHOOL_ID01 == null;
                    case 110: // SKGS_STPT_SCHOOL_ID02
                        return Current.SKGS_STPT_SCHOOL_ID02 == null;
                    case 111: // SKGS_STPT_SCHOOL_ID03
                        return Current.SKGS_STPT_SCHOOL_ID03 == null;
                    case 112: // SKGS_STPT_SCHOOL_ID04
                        return Current.SKGS_STPT_SCHOOL_ID04 == null;
                    case 113: // SKGS_STPT_SCHOOL_NAME01
                        return Current.SKGS_STPT_SCHOOL_NAME01 == null;
                    case 114: // SKGS_STPT_SCHOOL_NAME02
                        return Current.SKGS_STPT_SCHOOL_NAME02 == null;
                    case 115: // SKGS_STPT_SCHOOL_NAME03
                        return Current.SKGS_STPT_SCHOOL_NAME03 == null;
                    case 116: // SKGS_STPT_SCHOOL_NAME04
                        return Current.SKGS_STPT_SCHOOL_NAME04 == null;
                    case 117: // STPT_SGB_TIME_FRACTION01
                        return Current.STPT_SGB_TIME_FRACTION01 == null;
                    case 118: // STPT_SGB_TIME_FRACTION02
                        return Current.STPT_SGB_TIME_FRACTION02 == null;
                    case 119: // STPT_SGB_TIME_FRACTION03
                        return Current.STPT_SGB_TIME_FRACTION03 == null;
                    case 120: // STPT_SGB_TIME_FRACTION04
                        return Current.STPT_SGB_TIME_FRACTION04 == null;
                    case 121: // POSTCODE
                        return Current.POSTCODE == null;
                    case 122: // REPEAT
                        return Current.REPEAT == null;
                    case 123: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID == null;
                    case 124: // LCREATED
                        return Current.LCREATED == null;
                    case 125: // VSN
                        return Current.VSN == null;
                    case 126: // DF_SCH_ED_A
                        return Current.DF_SCH_ED_A == null;
                    case 127: // DF_SCH_ED_B
                        return Current.DF_SCH_ED_B == null;
                    case 128: // DF_NON_SCH_ED_A
                        return Current.DF_NON_SCH_ED_A == null;
                    case 129: // DF_NON_SCH_ED_B
                        return Current.DF_NON_SCH_ED_B == null;
                    case 130: // ADDRESS_B
                        return Current.ADDRESS_B == null;
                    case 131: // ADDRESS_C
                        return Current.ADDRESS_C == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // ID_RETURN
                        return "ID_RETURN";
                    case 2: // C_SOURCE
                        return "C_SOURCE";
                    case 3: // STKEY
                        return "STKEY";
                    case 4: // REGISTRATION
                        return "REGISTRATION";
                    case 5: // SURNAME
                        return "SURNAME";
                    case 6: // FIRST_NAME
                        return "FIRST_NAME";
                    case 7: // SECOND_NAME
                        return "SECOND_NAME";
                    case 8: // GENDER
                        return "GENDER";
                    case 9: // C_AGE_1st_JAN
                        return "C_AGE_1st_JAN";
                    case 10: // C_AGE_1st_JULY
                        return "C_AGE_1st_JULY";
                    case 11: // AUSSIE_SCHOOL
                        return "AUSSIE_SCHOOL";
                    case 12: // BIRTHDATE
                        return "BIRTHDATE";
                    case 13: // DISABILITY
                        return "DISABILITY";
                    case 14: // DISABILITY_ID
                        return "DISABILITY_ID";
                    case 15: // ENTRY
                        return "ENTRY";
                    case 16: // STATUS
                        return "STATUS";
                    case 17: // HOME_GROUP
                        return "HOME_GROUP";
                    case 18: // KGC_HOME_GROUP
                        return "KGC_HOME_GROUP";
                    case 19: // HOME_LANG
                        return "HOME_LANG";
                    case 20: // KGL_ASCL
                        return "KGL_ASCL";
                    case 21: // KGL_DESCRIPTION
                        return "KGL_DESCRIPTION";
                    case 22: // LOTE_HOME_CODE
                        return "LOTE_HOME_CODE";
                    case 23: // KGL_LOTE_HOME_ASCL
                        return "KGL_LOTE_HOME_ASCL";
                    case 24: // KGL_LOTE_HOME_DESCRIPTION
                        return "KGL_LOTE_HOME_DESCRIPTION";
                    case 25: // IMMUNIZE
                        return "IMMUNIZE";
                    case 26: // DIPTHERIA_S
                        return "DIPTHERIA_S";
                    case 27: // TETANUS_S
                        return "TETANUS_S";
                    case 28: // POLIO_S
                        return "POLIO_S";
                    case 29: // PERTUSSIS_S
                        return "PERTUSSIS_S";
                    case 30: // HAEMOPHILUSB_S
                        return "HAEMOPHILUSB_S";
                    case 31: // MMR_S
                        return "MMR_S";
                    case 32: // IMMUN_CERT_STATUS
                        return "IMMUN_CERT_STATUS";
                    case 33: // KOORIE
                        return "KOORIE";
                    case 34: // C_MOBILITY
                        return "C_MOBILITY";
                    case 35: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 36: // BIRTH_COUNTRY
                        return "BIRTH_COUNTRY";
                    case 37: // KGT_SACC
                        return "KGT_SACC";
                    case 38: // KGT_DESCRIPTION
                        return "KGT_DESCRIPTION";
                    case 39: // KGT_ENGLISH_SPEAKING
                        return "KGT_ENGLISH_SPEAKING";
                    case 40: // RESIDENT_STATUS
                        return "RESIDENT_STATUS";
                    case 41: // PERMANENT_BASIS
                        return "PERMANENT_BASIS";
                    case 42: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 43: // VISA_STAT_CODE
                        return "VISA_STAT_CODE";
                    case 44: // KCV_VISA_SUBCLASS
                        return "KCV_VISA_SUBCLASS";
                    case 45: // KCV_SGB_FUNDED
                        return "KCV_SGB_FUNDED";
                    case 46: // KCV_CHECK_STAT_CODE
                        return "KCV_CHECK_STAT_CODE";
                    case 47: // KCV_VISA_RESIDENCY
                        return "KCV_VISA_RESIDENCY";
                    case 48: // C_SRP_STATUS
                        return "C_SRP_STATUS";
                    case 49: // EXIT_DATE
                        return "EXIT_DATE";
                    case 50: // KCY_NUM_EQVT
                        return "KCY_NUM_EQVT";
                    case 51: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 52: // KCY_KCYKEY
                        return "KCY_KCYKEY";
                    case 53: // LIVING_ARR
                        return "LIVING_ARR";
                    case 54: // C_LIVING_ARR
                        return "C_LIVING_ARR";
                    case 55: // PREVIOUS_SCHOOL
                        return "PREVIOUS_SCHOOL";
                    case 56: // SKGS_PREVIOUS_SCHOOL_ENTITY
                        return "SKGS_PREVIOUS_SCHOOL_ENTITY";
                    case 57: // SKGS_PREVIOUS_SCHOOL_ID
                        return "SKGS_PREVIOUS_SCHOOL_ID";
                    case 58: // C_FEEDER_ENTITY
                        return "C_FEEDER_ENTITY";
                    case 59: // C_FEEDER_SCHOOL_NUMBER
                        return "C_FEEDER_SCHOOL_NUMBER";
                    case 60: // C_FEEDER_SCHOOL_NAME
                        return "C_FEEDER_SCHOOL_NAME";
                    case 61: // CAMPUS
                        return "CAMPUS";
                    case 62: // SKGS_CAMPUS_NAME
                        return "SKGS_CAMPUS_NAME";
                    case 63: // SKGS_SCHOOL_TYPE
                        return "SKGS_SCHOOL_TYPE";
                    case 64: // FAMILY
                        return "FAMILY";
                    case 65: // RELATION_A
                        return "RELATION_A";
                    case 66: // DF_GENDER_A
                        return "DF_GENDER_A";
                    case 67: // DF_SURNAME_A
                        return "DF_SURNAME_A";
                    case 68: // DF_TITLE_A
                        return "DF_TITLE_A";
                    case 69: // DF_NAME_A
                        return "DF_NAME_A";
                    case 70: // DF_BIRTH_COUNTRY_A
                        return "DF_BIRTH_COUNTRY_A";
                    case 71: // DF_KGT_SACC_A
                        return "DF_KGT_SACC_A";
                    case 72: // DF_KGT_DESCRIPTION_A
                        return "DF_KGT_DESCRIPTION_A";
                    case 73: // DF_KGT_ENGLISH_SPEAKING_A
                        return "DF_KGT_ENGLISH_SPEAKING_A";
                    case 74: // DF_OCCUP_STATUS_A
                        return "DF_OCCUP_STATUS_A";
                    case 75: // DF_LOTE_HOME_CODE_A
                        return "DF_LOTE_HOME_CODE_A";
                    case 76: // DF_KGL_LOTE_HOME_ASCL_A
                        return "DF_KGL_LOTE_HOME_ASCL_A";
                    case 77: // DF_KGL_LOTE_HOME_DESCRIPTION_A
                        return "DF_KGL_LOTE_HOME_DESCRIPTION_A";
                    case 78: // DF_GENDER_B
                        return "DF_GENDER_B";
                    case 79: // DF_SURNAME_B
                        return "DF_SURNAME_B";
                    case 80: // DF_TITLE_B
                        return "DF_TITLE_B";
                    case 81: // DF_NAME_B
                        return "DF_NAME_B";
                    case 82: // DF_BIRTH_COUNTRY_B
                        return "DF_BIRTH_COUNTRY_B";
                    case 83: // DF_KGT_ENGLISH_SPEAKING_B
                        return "DF_KGT_ENGLISH_SPEAKING_B";
                    case 84: // DF_KGT_SACC_B
                        return "DF_KGT_SACC_B";
                    case 85: // DF_KGT_DESCRIPTION_B
                        return "DF_KGT_DESCRIPTION_B";
                    case 86: // DF_OCCUP_STATUS_B
                        return "DF_OCCUP_STATUS_B";
                    case 87: // DF_LOTE_HOME_CODE_B
                        return "DF_LOTE_HOME_CODE_B";
                    case 88: // DF_KGL_LOTE_HOME_ASCL_B
                        return "DF_KGL_LOTE_HOME_ASCL_B";
                    case 89: // DF_KGL_LOTE_HOME_DESCRIPTION_B
                        return "DF_KGL_LOTE_HOME_DESCRIPTION_B";
                    case 90: // C_FAM_OCCUPATION
                        return "C_FAM_OCCUPATION";
                    case 91: // C_LBOTE
                        return "C_LBOTE";
                    case 92: // C_YTD_ABSENCE
                        return "C_YTD_ABSENCE";
                    case 93: // C_CENSUSDAY
                        return "C_CENSUSDAY";
                    case 94: // C_YTD_APPROVED
                        return "C_YTD_APPROVED";
                    case 95: // C_LAST_ABS_DAY
                        return "C_LAST_ABS_DAY";
                    case 96: // C_START_SCHOOL_YEAR
                        return "C_START_SCHOOL_YEAR";
                    case 97: // C_ELIGIBLE_S_DAYS
                        return "C_ELIGIBLE_S_DAYS";
                    case 98: // C_LBOTE_MCEETYA
                        return "C_LBOTE_MCEETYA";
                    case 99: // FULLTIME
                        return "FULLTIME";
                    case 100: // SGB_TIME_FRACTION
                        return "SGB_TIME_FRACTION";
                    case 101: // STPT_SCHL_NUM01
                        return "STPT_SCHL_NUM01";
                    case 102: // STPT_SCHL_NUM02
                        return "STPT_SCHL_NUM02";
                    case 103: // STPT_SCHL_NUM03
                        return "STPT_SCHL_NUM03";
                    case 104: // STPT_SCHL_NUM04
                        return "STPT_SCHL_NUM04";
                    case 105: // SKGS_STPT_ENTITY01
                        return "SKGS_STPT_ENTITY01";
                    case 106: // SKGS_STPT_ENTITY02
                        return "SKGS_STPT_ENTITY02";
                    case 107: // SKGS_STPT_ENTITY03
                        return "SKGS_STPT_ENTITY03";
                    case 108: // SKGS_STPT_ENTITY04
                        return "SKGS_STPT_ENTITY04";
                    case 109: // SKGS_STPT_SCHOOL_ID01
                        return "SKGS_STPT_SCHOOL_ID01";
                    case 110: // SKGS_STPT_SCHOOL_ID02
                        return "SKGS_STPT_SCHOOL_ID02";
                    case 111: // SKGS_STPT_SCHOOL_ID03
                        return "SKGS_STPT_SCHOOL_ID03";
                    case 112: // SKGS_STPT_SCHOOL_ID04
                        return "SKGS_STPT_SCHOOL_ID04";
                    case 113: // SKGS_STPT_SCHOOL_NAME01
                        return "SKGS_STPT_SCHOOL_NAME01";
                    case 114: // SKGS_STPT_SCHOOL_NAME02
                        return "SKGS_STPT_SCHOOL_NAME02";
                    case 115: // SKGS_STPT_SCHOOL_NAME03
                        return "SKGS_STPT_SCHOOL_NAME03";
                    case 116: // SKGS_STPT_SCHOOL_NAME04
                        return "SKGS_STPT_SCHOOL_NAME04";
                    case 117: // STPT_SGB_TIME_FRACTION01
                        return "STPT_SGB_TIME_FRACTION01";
                    case 118: // STPT_SGB_TIME_FRACTION02
                        return "STPT_SGB_TIME_FRACTION02";
                    case 119: // STPT_SGB_TIME_FRACTION03
                        return "STPT_SGB_TIME_FRACTION03";
                    case 120: // STPT_SGB_TIME_FRACTION04
                        return "STPT_SGB_TIME_FRACTION04";
                    case 121: // POSTCODE
                        return "POSTCODE";
                    case 122: // REPEAT
                        return "REPEAT";
                    case 123: // INTERNATIONAL_ST_ID
                        return "INTERNATIONAL_ST_ID";
                    case 124: // LCREATED
                        return "LCREATED";
                    case 125: // VSN
                        return "VSN";
                    case 126: // DF_SCH_ED_A
                        return "DF_SCH_ED_A";
                    case 127: // DF_SCH_ED_B
                        return "DF_SCH_ED_B";
                    case 128: // DF_NON_SCH_ED_A
                        return "DF_NON_SCH_ED_A";
                    case 129: // DF_NON_SCH_ED_B
                        return "DF_NON_SCH_ED_B";
                    case 130: // ADDRESS_B
                        return "ADDRESS_B";
                    case 131: // ADDRESS_C
                        return "ADDRESS_C";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "ID_RETURN":
                        return 1;
                    case "C_SOURCE":
                        return 2;
                    case "STKEY":
                        return 3;
                    case "REGISTRATION":
                        return 4;
                    case "SURNAME":
                        return 5;
                    case "FIRST_NAME":
                        return 6;
                    case "SECOND_NAME":
                        return 7;
                    case "GENDER":
                        return 8;
                    case "C_AGE_1st_JAN":
                        return 9;
                    case "C_AGE_1st_JULY":
                        return 10;
                    case "AUSSIE_SCHOOL":
                        return 11;
                    case "BIRTHDATE":
                        return 12;
                    case "DISABILITY":
                        return 13;
                    case "DISABILITY_ID":
                        return 14;
                    case "ENTRY":
                        return 15;
                    case "STATUS":
                        return 16;
                    case "HOME_GROUP":
                        return 17;
                    case "KGC_HOME_GROUP":
                        return 18;
                    case "HOME_LANG":
                        return 19;
                    case "KGL_ASCL":
                        return 20;
                    case "KGL_DESCRIPTION":
                        return 21;
                    case "LOTE_HOME_CODE":
                        return 22;
                    case "KGL_LOTE_HOME_ASCL":
                        return 23;
                    case "KGL_LOTE_HOME_DESCRIPTION":
                        return 24;
                    case "IMMUNIZE":
                        return 25;
                    case "DIPTHERIA_S":
                        return 26;
                    case "TETANUS_S":
                        return 27;
                    case "POLIO_S":
                        return 28;
                    case "PERTUSSIS_S":
                        return 29;
                    case "HAEMOPHILUSB_S":
                        return 30;
                    case "MMR_S":
                        return 31;
                    case "IMMUN_CERT_STATUS":
                        return 32;
                    case "KOORIE":
                        return 33;
                    case "C_MOBILITY":
                        return 34;
                    case "SGB_FUNDED":
                        return 35;
                    case "BIRTH_COUNTRY":
                        return 36;
                    case "KGT_SACC":
                        return 37;
                    case "KGT_DESCRIPTION":
                        return 38;
                    case "KGT_ENGLISH_SPEAKING":
                        return 39;
                    case "RESIDENT_STATUS":
                        return 40;
                    case "PERMANENT_BASIS":
                        return 41;
                    case "VISA_SUBCLASS":
                        return 42;
                    case "VISA_STAT_CODE":
                        return 43;
                    case "KCV_VISA_SUBCLASS":
                        return 44;
                    case "KCV_SGB_FUNDED":
                        return 45;
                    case "KCV_CHECK_STAT_CODE":
                        return 46;
                    case "KCV_VISA_RESIDENCY":
                        return 47;
                    case "C_SRP_STATUS":
                        return 48;
                    case "EXIT_DATE":
                        return 49;
                    case "KCY_NUM_EQVT":
                        return 50;
                    case "SCHOOL_YEAR":
                        return 51;
                    case "KCY_KCYKEY":
                        return 52;
                    case "LIVING_ARR":
                        return 53;
                    case "C_LIVING_ARR":
                        return 54;
                    case "PREVIOUS_SCHOOL":
                        return 55;
                    case "SKGS_PREVIOUS_SCHOOL_ENTITY":
                        return 56;
                    case "SKGS_PREVIOUS_SCHOOL_ID":
                        return 57;
                    case "C_FEEDER_ENTITY":
                        return 58;
                    case "C_FEEDER_SCHOOL_NUMBER":
                        return 59;
                    case "C_FEEDER_SCHOOL_NAME":
                        return 60;
                    case "CAMPUS":
                        return 61;
                    case "SKGS_CAMPUS_NAME":
                        return 62;
                    case "SKGS_SCHOOL_TYPE":
                        return 63;
                    case "FAMILY":
                        return 64;
                    case "RELATION_A":
                        return 65;
                    case "DF_GENDER_A":
                        return 66;
                    case "DF_SURNAME_A":
                        return 67;
                    case "DF_TITLE_A":
                        return 68;
                    case "DF_NAME_A":
                        return 69;
                    case "DF_BIRTH_COUNTRY_A":
                        return 70;
                    case "DF_KGT_SACC_A":
                        return 71;
                    case "DF_KGT_DESCRIPTION_A":
                        return 72;
                    case "DF_KGT_ENGLISH_SPEAKING_A":
                        return 73;
                    case "DF_OCCUP_STATUS_A":
                        return 74;
                    case "DF_LOTE_HOME_CODE_A":
                        return 75;
                    case "DF_KGL_LOTE_HOME_ASCL_A":
                        return 76;
                    case "DF_KGL_LOTE_HOME_DESCRIPTION_A":
                        return 77;
                    case "DF_GENDER_B":
                        return 78;
                    case "DF_SURNAME_B":
                        return 79;
                    case "DF_TITLE_B":
                        return 80;
                    case "DF_NAME_B":
                        return 81;
                    case "DF_BIRTH_COUNTRY_B":
                        return 82;
                    case "DF_KGT_ENGLISH_SPEAKING_B":
                        return 83;
                    case "DF_KGT_SACC_B":
                        return 84;
                    case "DF_KGT_DESCRIPTION_B":
                        return 85;
                    case "DF_OCCUP_STATUS_B":
                        return 86;
                    case "DF_LOTE_HOME_CODE_B":
                        return 87;
                    case "DF_KGL_LOTE_HOME_ASCL_B":
                        return 88;
                    case "DF_KGL_LOTE_HOME_DESCRIPTION_B":
                        return 89;
                    case "C_FAM_OCCUPATION":
                        return 90;
                    case "C_LBOTE":
                        return 91;
                    case "C_YTD_ABSENCE":
                        return 92;
                    case "C_CENSUSDAY":
                        return 93;
                    case "C_YTD_APPROVED":
                        return 94;
                    case "C_LAST_ABS_DAY":
                        return 95;
                    case "C_START_SCHOOL_YEAR":
                        return 96;
                    case "C_ELIGIBLE_S_DAYS":
                        return 97;
                    case "C_LBOTE_MCEETYA":
                        return 98;
                    case "FULLTIME":
                        return 99;
                    case "SGB_TIME_FRACTION":
                        return 100;
                    case "STPT_SCHL_NUM01":
                        return 101;
                    case "STPT_SCHL_NUM02":
                        return 102;
                    case "STPT_SCHL_NUM03":
                        return 103;
                    case "STPT_SCHL_NUM04":
                        return 104;
                    case "SKGS_STPT_ENTITY01":
                        return 105;
                    case "SKGS_STPT_ENTITY02":
                        return 106;
                    case "SKGS_STPT_ENTITY03":
                        return 107;
                    case "SKGS_STPT_ENTITY04":
                        return 108;
                    case "SKGS_STPT_SCHOOL_ID01":
                        return 109;
                    case "SKGS_STPT_SCHOOL_ID02":
                        return 110;
                    case "SKGS_STPT_SCHOOL_ID03":
                        return 111;
                    case "SKGS_STPT_SCHOOL_ID04":
                        return 112;
                    case "SKGS_STPT_SCHOOL_NAME01":
                        return 113;
                    case "SKGS_STPT_SCHOOL_NAME02":
                        return 114;
                    case "SKGS_STPT_SCHOOL_NAME03":
                        return 115;
                    case "SKGS_STPT_SCHOOL_NAME04":
                        return 116;
                    case "STPT_SGB_TIME_FRACTION01":
                        return 117;
                    case "STPT_SGB_TIME_FRACTION02":
                        return 118;
                    case "STPT_SGB_TIME_FRACTION03":
                        return 119;
                    case "STPT_SGB_TIME_FRACTION04":
                        return 120;
                    case "POSTCODE":
                        return 121;
                    case "REPEAT":
                        return 122;
                    case "INTERNATIONAL_ST_ID":
                        return 123;
                    case "LCREATED":
                        return 124;
                    case "VSN":
                        return 125;
                    case "DF_SCH_ED_A":
                        return 126;
                    case "DF_SCH_ED_B":
                        return 127;
                    case "DF_NON_SCH_ED_A":
                        return 128;
                    case "DF_NON_SCH_ED_B":
                        return 129;
                    case "ADDRESS_B":
                        return 130;
                    case "ADDRESS_C":
                        return 131;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
