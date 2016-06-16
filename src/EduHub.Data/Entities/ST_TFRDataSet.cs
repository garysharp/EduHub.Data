using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// ST Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ST_TFRDataSet : EduHubDataSet<ST_TFR>
    {
        /// <inheritdoc />
        public override string Name { get { return "ST_TFR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal ST_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOME_GROUP_NEW = new Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>>(() => this.ToGroupedNullDictionary(i => i.HOME_GROUP_NEW));
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_SCHOOL_YEAR_NEW = new Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR_NEW));
            Index_ST_TRANS_ID = new Lazy<NullDictionary<string, ST_TFR>>(() => this.ToNullDictionary(i => i.ST_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, ST_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST_TFR" /> fields for each CSV column header</returns>
        internal override Action<ST_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ST_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "STKEY_NEW":
                        mapper[i] = (e, v) => e.STKEY_NEW = v;
                        break;
                    case "DUP_FAMILY":
                        mapper[i] = (e, v) => e.DUP_FAMILY = v;
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
                    case "PREF_NAME":
                        mapper[i] = (e, v) => e.PREF_NAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "FAMILY_DUP":
                        mapper[i] = (e, v) => e.FAMILY_DUP = v;
                        break;
                    case "FAMILY_DUP_ACT":
                        mapper[i] = (e, v) => e.FAMILY_DUP_ACT = v;
                        break;
                    case "ACADEMIC_A":
                        mapper[i] = (e, v) => e.ACADEMIC_A = v;
                        break;
                    case "LIVING_A":
                        mapper[i] = (e, v) => e.LIVING_A = v;
                        break;
                    case "RELATION_A01":
                        mapper[i] = (e, v) => e.RELATION_A01 = v;
                        break;
                    case "RELATION_A02":
                        mapper[i] = (e, v) => e.RELATION_A02 = v;
                        break;
                    case "CONTACT_A":
                        mapper[i] = (e, v) => e.CONTACT_A = v;
                        break;
                    case "FAMB":
                        mapper[i] = (e, v) => e.FAMB = v;
                        break;
                    case "FAMB_DUP":
                        mapper[i] = (e, v) => e.FAMB_DUP = v;
                        break;
                    case "FAMB_DUP_ACT":
                        mapper[i] = (e, v) => e.FAMB_DUP_ACT = v;
                        break;
                    case "ACADEMIC_B":
                        mapper[i] = (e, v) => e.ACADEMIC_B = v;
                        break;
                    case "LIVING_B":
                        mapper[i] = (e, v) => e.LIVING_B = v;
                        break;
                    case "RELATION_B01":
                        mapper[i] = (e, v) => e.RELATION_B01 = v;
                        break;
                    case "RELATION_B02":
                        mapper[i] = (e, v) => e.RELATION_B02 = v;
                        break;
                    case "CONTACT_B":
                        mapper[i] = (e, v) => e.CONTACT_B = v;
                        break;
                    case "FAMC":
                        mapper[i] = (e, v) => e.FAMC = v;
                        break;
                    case "FAMC_DUP":
                        mapper[i] = (e, v) => e.FAMC_DUP = v;
                        break;
                    case "FAMC_DUP_ACT":
                        mapper[i] = (e, v) => e.FAMC_DUP_ACT = v;
                        break;
                    case "ACADEMIC_C":
                        mapper[i] = (e, v) => e.ACADEMIC_C = v;
                        break;
                    case "LIVING_C":
                        mapper[i] = (e, v) => e.LIVING_C = v;
                        break;
                    case "RELATION_C01":
                        mapper[i] = (e, v) => e.RELATION_C01 = v;
                        break;
                    case "RELATION_C02":
                        mapper[i] = (e, v) => e.RELATION_C02 = v;
                        break;
                    case "CONTACT_C":
                        mapper[i] = (e, v) => e.CONTACT_C = v;
                        break;
                    case "LIVING_ARR":
                        mapper[i] = (e, v) => e.LIVING_ARR = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PROOF_DOB":
                        mapper[i] = (e, v) => e.PROOF_DOB = v;
                        break;
                    case "RESIDENT_STATUS":
                        mapper[i] = (e, v) => e.RESIDENT_STATUS = v;
                        break;
                    case "PERMANENT_BASIS":
                        mapper[i] = (e, v) => e.PERMANENT_BASIS = v;
                        break;
                    case "ARRIVAL":
                        mapper[i] = (e, v) => e.ARRIVAL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AUSSIE_SCHOOL":
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INTEGRATION":
                        mapper[i] = (e, v) => e.INTEGRATION = v;
                        break;
                    case "FAM_ORDER":
                        mapper[i] = (e, v) => e.FAM_ORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "SCHOOL_YEAR_NEW":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR_NEW = v;
                        break;
                    case "HOME_GROUP_NEW":
                        mapper[i] = (e, v) => e.HOME_GROUP_NEW = v;
                        break;
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "VISA_STAT_CODE":
                        mapper[i] = (e, v) => e.VISA_STAT_CODE = v;
                        break;
                    case "VISA_EXPIRY":
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "ENG_SPEAK":
                        mapper[i] = (e, v) => e.ENG_SPEAK = v;
                        break;
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "OVERSEAS":
                        mapper[i] = (e, v) => e.OVERSEAS = v;
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "ACCESS":
                        mapper[i] = (e, v) => e.ACCESS = v;
                        break;
                    case "ACCESS_TYPE":
                        mapper[i] = (e, v) => e.ACCESS_TYPE = v;
                        break;
                    case "ACCESS_ALERT":
                        mapper[i] = (e, v) => e.ACCESS_ALERT = v;
                        break;
                    case "RISK_ALERT":
                        mapper[i] = (e, v) => e.RISK_ALERT = v;
                        break;
                    case "RISK_MEMO":
                        mapper[i] = (e, v) => e.RISK_MEMO = v;
                        break;
                    case "DOCTOR":
                        mapper[i] = (e, v) => e.DOCTOR = v;
                        break;
                    case "EMERG_NAME01":
                        mapper[i] = (e, v) => e.EMERG_NAME01 = v;
                        break;
                    case "EMERG_NAME02":
                        mapper[i] = (e, v) => e.EMERG_NAME02 = v;
                        break;
                    case "EMERG_LANG01":
                        mapper[i] = (e, v) => e.EMERG_LANG01 = v;
                        break;
                    case "EMERG_LANG02":
                        mapper[i] = (e, v) => e.EMERG_LANG02 = v;
                        break;
                    case "EMERG_RELATION01":
                        mapper[i] = (e, v) => e.EMERG_RELATION01 = v;
                        break;
                    case "EMERG_RELATION02":
                        mapper[i] = (e, v) => e.EMERG_RELATION02 = v;
                        break;
                    case "EMERG_CONTACT01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT01 = v;
                        break;
                    case "EMERG_CONTACT02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT02 = v;
                        break;
                    case "ACC_DECLARATION":
                        mapper[i] = (e, v) => e.ACC_DECLARATION = v;
                        break;
                    case "MEDICARE_NO":
                        mapper[i] = (e, v) => e.MEDICARE_NO = v;
                        break;
                    case "INTERNATIONAL_ST_ID":
                        mapper[i] = (e, v) => e.INTERNATIONAL_ST_ID = v;
                        break;
                    case "MEDICAL_ALERT":
                        mapper[i] = (e, v) => e.MEDICAL_ALERT = v;
                        break;
                    case "MEDICAL_CONDITION":
                        mapper[i] = (e, v) => e.MEDICAL_CONDITION = v;
                        break;
                    case "ACTIVITY_RESTRICTION":
                        mapper[i] = (e, v) => e.ACTIVITY_RESTRICTION = v;
                        break;
                    case "IMMUNISE_CERT_STATUS":
                        mapper[i] = (e, v) => e.IMMUNISE_CERT_STATUS = v;
                        break;
                    case "IMMUN_CERT_SIGHTED":
                        mapper[i] = (e, v) => e.IMMUN_CERT_SIGHTED = v;
                        break;
                    case "IMMUNISE_PERMISSION":
                        mapper[i] = (e, v) => e.IMMUNISE_PERMISSION = v;
                        break;
                    case "IMMUNIZE":
                        mapper[i] = (e, v) => e.IMMUNIZE = v;
                        break;
                    case "OK_TO_PUBLISH":
                        mapper[i] = (e, v) => e.OK_TO_PUBLISH = v;
                        break;
                    case "PIC_LW_DATE":
                        mapper[i] = (e, v) => e.PIC_LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PIC_STATUS":
                        mapper[i] = (e, v) => e.PIC_STATUS = v;
                        break;
                    case "YEARS_PREVIOUS_EDUCATION":
                        mapper[i] = (e, v) => e.YEARS_PREVIOUS_EDUCATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "YEARS_INTERRUPTION_EDUCATION":
                        mapper[i] = (e, v) => e.YEARS_INTERRUPTION_EDUCATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LANGUAGE_PREVIOUS_SCHOOLING":
                        mapper[i] = (e, v) => e.LANGUAGE_PREVIOUS_SCHOOLING = v;
                        break;
                    case "LOTE_HOME_CODE":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE = v;
                        break;
                    case "VSN":
                        mapper[i] = (e, v) => e.VSN = v;
                        break;
                    case "SPEC_CURR":
                        mapper[i] = (e, v) => e.SPEC_CURR = v;
                        break;
                    case "LEGAL_LIMIT_DECISION":
                        mapper[i] = (e, v) => e.LEGAL_LIMIT_DECISION = v;
                        break;
                    case "LEGAL_LIMIT_CONTACT":
                        mapper[i] = (e, v) => e.LEGAL_LIMIT_CONTACT = v;
                        break;
                    case "LEGAL_LIMITATION":
                        mapper[i] = (e, v) => e.LEGAL_LIMITATION = v;
                        break;
                    case "DOC_COPIES":
                        mapper[i] = (e, v) => e.DOC_COPIES = v;
                        break;
                    case "LISTED_IN_SOCS":
                        mapper[i] = (e, v) => e.LISTED_IN_SOCS = v;
                        break;
                    case "SUPPORT_SERVICES":
                        mapper[i] = (e, v) => e.SUPPORT_SERVICES = v;
                        break;
                    case "STUDENT_SUPPORT":
                        mapper[i] = (e, v) => e.STUDENT_SUPPORT = v;
                        break;
                    case "STUDENT_OTHER_SUPPORT":
                        mapper[i] = (e, v) => e.STUDENT_OTHER_SUPPORT = v;
                        break;
                    case "SUPPORT_GROUP":
                        mapper[i] = (e, v) => e.SUPPORT_GROUP = v;
                        break;
                    case "CHILD_PROTECTION":
                        mapper[i] = (e, v) => e.CHILD_PROTECTION = v;
                        break;
                    case "ATTENDANCE_CONCERNS":
                        mapper[i] = (e, v) => e.ATTENDANCE_CONCERNS = v;
                        break;
                    case "DISCIPLINARY_ACTION":
                        mapper[i] = (e, v) => e.DISCIPLINARY_ACTION = v;
                        break;
                    case "WELFARE_RISKS":
                        mapper[i] = (e, v) => e.WELFARE_RISKS = v;
                        break;
                    case "EFFORT":
                        mapper[i] = (e, v) => e.EFFORT = v;
                        break;
                    case "CLASS_BEHAVIOUR":
                        mapper[i] = (e, v) => e.CLASS_BEHAVIOUR = v;
                        break;
                    case "ORGANISATION":
                        mapper[i] = (e, v) => e.ORGANISATION = v;
                        break;
                    case "SOCIAL_BEHAVIOUR":
                        mapper[i] = (e, v) => e.SOCIAL_BEHAVIOUR = v;
                        break;
                    case "LEARNING_SUPPORT":
                        mapper[i] = (e, v) => e.LEARNING_SUPPORT = v;
                        break;
                    case "NEW_ARRIVALS_PROGRAM":
                        mapper[i] = (e, v) => e.NEW_ARRIVALS_PROGRAM = v;
                        break;
                    case "REFUGEE_BACKGROUND":
                        mapper[i] = (e, v) => e.REFUGEE_BACKGROUND = v;
                        break;
                    case "TRANSFER_DOCS_SENT":
                        mapper[i] = (e, v) => e.TRANSFER_DOCS_SENT = v;
                        break;
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DFA_TRANS_ID":
                        mapper[i] = (e, v) => e.DFA_TRANS_ID = v;
                        break;
                    case "DFB_TRANS_ID":
                        mapper[i] = (e, v) => e.DFB_TRANS_ID = v;
                        break;
                    case "DFC_TRANS_ID":
                        mapper[i] = (e, v) => e.DFC_TRANS_ID = v;
                        break;
                    case "KCD_TRANS_ID":
                        mapper[i] = (e, v) => e.KCD_TRANS_ID = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="ST_TFR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="ST_TFR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="ST_TFR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{ST_TFR}"/> of entities</returns>
        internal override IEnumerable<ST_TFR> ApplyDeltaEntities(IEnumerable<ST_TFR> Entities, List<ST_TFR> DeltaEntities)
        {
            HashSet<string> Index_ST_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.ST_TRANS_ID));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ORIG_SCHOOL;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_ST_TRANS_ID.Remove(entity.ST_TRANS_ID);
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.ORIG_SCHOOL.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>> Index_HOME_GROUP_NEW;
        private Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<ST_TFR>>> Index_SCHOOL_YEAR_NEW;
        private Lazy<NullDictionary<string, ST_TFR>> Index_ST_TRANS_ID;
        private Lazy<Dictionary<int, ST_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find ST_TFR by HOME_GROUP_NEW field
        /// </summary>
        /// <param name="HOME_GROUP_NEW">HOME_GROUP_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> FindByHOME_GROUP_NEW(string HOME_GROUP_NEW)
        {
            return Index_HOME_GROUP_NEW.Value[HOME_GROUP_NEW];
        }

        /// <summary>
        /// Attempt to find ST_TFR by HOME_GROUP_NEW field
        /// </summary>
        /// <param name="HOME_GROUP_NEW">HOME_GROUP_NEW value used to find ST_TFR</param>
        /// <param name="Value">List of related ST_TFR entities</param>
        /// <returns>True if the list of related ST_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_GROUP_NEW(string HOME_GROUP_NEW, out IReadOnlyList<ST_TFR> Value)
        {
            return Index_HOME_GROUP_NEW.Value.TryGetValue(HOME_GROUP_NEW, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by HOME_GROUP_NEW field
        /// </summary>
        /// <param name="HOME_GROUP_NEW">HOME_GROUP_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> TryFindByHOME_GROUP_NEW(string HOME_GROUP_NEW)
        {
            IReadOnlyList<ST_TFR> value;
            if (Index_HOME_GROUP_NEW.Value.TryGetValue(HOME_GROUP_NEW, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find ST_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find ST_TFR</param>
        /// <param name="Value">List of related ST_TFR entities</param>
        /// <returns>True if the list of related ST_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<ST_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<ST_TFR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by SCHOOL_YEAR_NEW field
        /// </summary>
        /// <param name="SCHOOL_YEAR_NEW">SCHOOL_YEAR_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> FindBySCHOOL_YEAR_NEW(string SCHOOL_YEAR_NEW)
        {
            return Index_SCHOOL_YEAR_NEW.Value[SCHOOL_YEAR_NEW];
        }

        /// <summary>
        /// Attempt to find ST_TFR by SCHOOL_YEAR_NEW field
        /// </summary>
        /// <param name="SCHOOL_YEAR_NEW">SCHOOL_YEAR_NEW value used to find ST_TFR</param>
        /// <param name="Value">List of related ST_TFR entities</param>
        /// <returns>True if the list of related ST_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR_NEW(string SCHOOL_YEAR_NEW, out IReadOnlyList<ST_TFR> Value)
        {
            return Index_SCHOOL_YEAR_NEW.Value.TryGetValue(SCHOOL_YEAR_NEW, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by SCHOOL_YEAR_NEW field
        /// </summary>
        /// <param name="SCHOOL_YEAR_NEW">SCHOOL_YEAR_NEW value used to find ST_TFR</param>
        /// <returns>List of related ST_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFR> TryFindBySCHOOL_YEAR_NEW(string SCHOOL_YEAR_NEW)
        {
            IReadOnlyList<ST_TFR> value;
            if (Index_SCHOOL_YEAR_NEW.Value.TryGetValue(SCHOOL_YEAR_NEW, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR FindByST_TRANS_ID(string ST_TRANS_ID)
        {
            return Index_ST_TRANS_ID.Value[ST_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find ST_TFR by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFR</param>
        /// <param name="Value">Related ST_TFR entity</param>
        /// <returns>True if the related ST_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_TRANS_ID(string ST_TRANS_ID, out ST_TFR Value)
        {
            return Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR TryFindByST_TRANS_ID(string ST_TRANS_ID)
        {
            ST_TFR value;
            if (Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find ST_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFR</param>
        /// <param name="Value">Related ST_TFR entity</param>
        /// <returns>True if the related ST_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out ST_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFR</param>
        /// <returns>Related ST_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFR TryFindByTID(int TID)
        {
            ST_TFR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a ST_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[ST_TFR](
        [TID] int IDENTITY NOT NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [STKEY] varchar(10) NULL,
        [STKEY_NEW] varchar(10) NULL,
        [DUP_FAMILY] varchar(1) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [SECOND_NAME] varchar(20) NULL,
        [PREF_NAME] varchar(20) NULL,
        [TITLE] varchar(4) NULL,
        [FAMILY] varchar(10) NULL,
        [FAMILY_DUP] varchar(10) NULL,
        [FAMILY_DUP_ACT] varchar(1) NULL,
        [ACADEMIC_A] varchar(1) NULL,
        [LIVING_A] varchar(1) NULL,
        [RELATION_A01] varchar(20) NULL,
        [RELATION_A02] varchar(20) NULL,
        [CONTACT_A] varchar(1) NULL,
        [FAMB] varchar(10) NULL,
        [FAMB_DUP] varchar(10) NULL,
        [FAMB_DUP_ACT] varchar(1) NULL,
        [ACADEMIC_B] varchar(1) NULL,
        [LIVING_B] varchar(1) NULL,
        [RELATION_B01] varchar(20) NULL,
        [RELATION_B02] varchar(20) NULL,
        [CONTACT_B] varchar(1) NULL,
        [FAMC] varchar(10) NULL,
        [FAMC_DUP] varchar(10) NULL,
        [FAMC_DUP_ACT] varchar(1) NULL,
        [ACADEMIC_C] varchar(1) NULL,
        [LIVING_C] varchar(1) NULL,
        [RELATION_C01] varchar(20) NULL,
        [RELATION_C02] varchar(20) NULL,
        [CONTACT_C] varchar(1) NULL,
        [LIVING_ARR] varchar(1) NULL,
        [E_MAIL] varchar(60) NULL,
        [MOBILE] varchar(20) NULL,
        [MAP_TYPE] varchar(1) NULL,
        [MAP_NUM] varchar(4) NULL,
        [X_AXIS] varchar(2) NULL,
        [Y_AXIS] varchar(2) NULL,
        [GENDER] varchar(1) NULL,
        [BIRTHDATE] datetime NULL,
        [PROOF_DOB] varchar(1) NULL,
        [RESIDENT_STATUS] varchar(1) NULL,
        [PERMANENT_BASIS] varchar(1) NULL,
        [ARRIVAL] datetime NULL,
        [AUSSIE_SCHOOL] datetime NULL,
        [INTEGRATION] varchar(1) NULL,
        [FAM_ORDER] smallint NULL,
        [SGB_FUNDED] varchar(1) NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [SCHOOL_YEAR_NEW] varchar(4) NULL,
        [HOME_GROUP_NEW] varchar(3) NULL,
        [RELIGION] varchar(12) NULL,
        [VISA_SUBCLASS] varchar(3) NULL,
        [VISA_STAT_CODE] varchar(4) NULL,
        [VISA_EXPIRY] datetime NULL,
        [BIRTH_COUNTRY] varchar(6) NULL,
        [ENG_SPEAK] varchar(1) NULL,
        [HOME_LANG] varchar(7) NULL,
        [OVERSEAS] varchar(1) NULL,
        [KOORIE] varchar(1) NULL,
        [ACCESS] text NULL,
        [ACCESS_TYPE] varchar(20) NULL,
        [ACCESS_ALERT] varchar(1) NULL,
        [RISK_ALERT] varchar(1) NULL,
        [RISK_MEMO] text NULL,
        [DOCTOR] varchar(10) NULL,
        [EMERG_NAME01] varchar(30) NULL,
        [EMERG_NAME02] varchar(30) NULL,
        [EMERG_LANG01] varchar(7) NULL,
        [EMERG_LANG02] varchar(7) NULL,
        [EMERG_RELATION01] varchar(11) NULL,
        [EMERG_RELATION02] varchar(11) NULL,
        [EMERG_CONTACT01] text NULL,
        [EMERG_CONTACT02] text NULL,
        [ACC_DECLARATION] varchar(1) NULL,
        [MEDICARE_NO] varchar(12) NULL,
        [INTERNATIONAL_ST_ID] varchar(7) NULL,
        [MEDICAL_ALERT] varchar(1) NULL,
        [MEDICAL_CONDITION] varchar(1) NULL,
        [ACTIVITY_RESTRICTION] text NULL,
        [IMMUNISE_CERT_STATUS] varchar(1) NULL,
        [IMMUN_CERT_SIGHTED] varchar(1) NULL,
        [IMMUNISE_PERMISSION] varchar(1) NULL,
        [IMMUNIZE] varchar(1) NULL,
        [OK_TO_PUBLISH] varchar(1) NULL,
        [PIC_LW_DATE] datetime NULL,
        [PIC_STATUS] varchar(1) NULL,
        [YEARS_PREVIOUS_EDUCATION] smallint NULL,
        [YEARS_INTERRUPTION_EDUCATION] smallint NULL,
        [LANGUAGE_PREVIOUS_SCHOOLING] varchar(7) NULL,
        [LOTE_HOME_CODE] varchar(7) NULL,
        [VSN] varchar(12) NULL,
        [SPEC_CURR] varchar(2) NULL,
        [LEGAL_LIMIT_DECISION] varchar(1) NULL,
        [LEGAL_LIMIT_CONTACT] varchar(1) NULL,
        [LEGAL_LIMITATION] text NULL,
        [DOC_COPIES] varchar(1) NULL,
        [LISTED_IN_SOCS] varchar(1) NULL,
        [SUPPORT_SERVICES] varchar(1) NULL,
        [STUDENT_SUPPORT] varchar(1) NULL,
        [STUDENT_OTHER_SUPPORT] varchar(1) NULL,
        [SUPPORT_GROUP] varchar(1) NULL,
        [CHILD_PROTECTION] varchar(1) NULL,
        [ATTENDANCE_CONCERNS] varchar(1) NULL,
        [DISCIPLINARY_ACTION] varchar(1) NULL,
        [WELFARE_RISKS] varchar(1) NULL,
        [EFFORT] varchar(15) NULL,
        [CLASS_BEHAVIOUR] varchar(15) NULL,
        [ORGANISATION] varchar(15) NULL,
        [SOCIAL_BEHAVIOUR] varchar(15) NULL,
        [LEARNING_SUPPORT] varchar(1) NULL,
        [NEW_ARRIVALS_PROGRAM] varchar(1) NULL,
        [REFUGEE_BACKGROUND] varchar(1) NULL,
        [TRANSFER_DOCS_SENT] varchar(1) NULL,
        [ENTRY] datetime NULL,
        [DFA_TRANS_ID] varchar(30) NULL,
        [DFB_TRANS_ID] varchar(30) NULL,
        [DFC_TRANS_ID] varchar(30) NULL,
        [KCD_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [ST_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [ST_TFR_Index_HOME_GROUP_NEW] ON [dbo].[ST_TFR]
    (
            [HOME_GROUP_NEW] ASC
    );
    CREATE CLUSTERED INDEX [ST_TFR_Index_ORIG_SCHOOL] ON [dbo].[ST_TFR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_TFR_Index_SCHOOL_YEAR_NEW] ON [dbo].[ST_TFR]
    (
            [SCHOOL_YEAR_NEW] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_TFR_Index_ST_TRANS_ID] ON [dbo].[ST_TFR]
    (
            [ST_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_HOME_GROUP_NEW')
    ALTER INDEX [Index_HOME_GROUP_NEW] ON [dbo].[ST_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_SCHOOL_YEAR_NEW')
    ALTER INDEX [Index_SCHOOL_YEAR_NEW] ON [dbo].[ST_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_ST_TRANS_ID')
    ALTER INDEX [Index_ST_TRANS_ID] ON [dbo].[ST_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[ST_TFR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_HOME_GROUP_NEW')
    ALTER INDEX [Index_HOME_GROUP_NEW] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_SCHOOL_YEAR_NEW')
    ALTER INDEX [Index_SCHOOL_YEAR_NEW] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_ST_TRANS_ID')
    ALTER INDEX [Index_ST_TRANS_ID] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="ST_TFR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="ST_TFR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<ST_TFR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_ST_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ST_TRANS_ID.Add(entity.ST_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[ST_TFR] WHERE");


            // Index_ST_TRANS_ID
            builder.Append("[ST_TRANS_ID] IN (");
            for (int index = 0; index < Index_ST_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ST_TRANS_ID
                var parameterST_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterST_TRANS_ID);
                command.Parameters.Add(parameterST_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_ST_TRANS_ID[index] ?? DBNull.Value;
            }
            builder.AppendLine(") OR");

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
        /// Provides a <see cref="IDataReader"/> for the ST_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ST_TFR data set</returns>
        public override EduHubDataSetDataReader<ST_TFR> GetDataSetDataReader()
        {
            return new ST_TFRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the ST_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ST_TFR data set</returns>
        public override EduHubDataSetDataReader<ST_TFR> GetDataSetDataReader(List<ST_TFR> Entities)
        {
            return new ST_TFRDataReader(new EduHubDataSetLoadedReader<ST_TFR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class ST_TFRDataReader : EduHubDataSetDataReader<ST_TFR>
        {
            public ST_TFRDataReader(IEduHubDataSetReader<ST_TFR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 128; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 2: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 3: // STKEY
                        return Current.STKEY;
                    case 4: // STKEY_NEW
                        return Current.STKEY_NEW;
                    case 5: // DUP_FAMILY
                        return Current.DUP_FAMILY;
                    case 6: // SURNAME
                        return Current.SURNAME;
                    case 7: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 8: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 9: // PREF_NAME
                        return Current.PREF_NAME;
                    case 10: // TITLE
                        return Current.TITLE;
                    case 11: // FAMILY
                        return Current.FAMILY;
                    case 12: // FAMILY_DUP
                        return Current.FAMILY_DUP;
                    case 13: // FAMILY_DUP_ACT
                        return Current.FAMILY_DUP_ACT;
                    case 14: // ACADEMIC_A
                        return Current.ACADEMIC_A;
                    case 15: // LIVING_A
                        return Current.LIVING_A;
                    case 16: // RELATION_A01
                        return Current.RELATION_A01;
                    case 17: // RELATION_A02
                        return Current.RELATION_A02;
                    case 18: // CONTACT_A
                        return Current.CONTACT_A;
                    case 19: // FAMB
                        return Current.FAMB;
                    case 20: // FAMB_DUP
                        return Current.FAMB_DUP;
                    case 21: // FAMB_DUP_ACT
                        return Current.FAMB_DUP_ACT;
                    case 22: // ACADEMIC_B
                        return Current.ACADEMIC_B;
                    case 23: // LIVING_B
                        return Current.LIVING_B;
                    case 24: // RELATION_B01
                        return Current.RELATION_B01;
                    case 25: // RELATION_B02
                        return Current.RELATION_B02;
                    case 26: // CONTACT_B
                        return Current.CONTACT_B;
                    case 27: // FAMC
                        return Current.FAMC;
                    case 28: // FAMC_DUP
                        return Current.FAMC_DUP;
                    case 29: // FAMC_DUP_ACT
                        return Current.FAMC_DUP_ACT;
                    case 30: // ACADEMIC_C
                        return Current.ACADEMIC_C;
                    case 31: // LIVING_C
                        return Current.LIVING_C;
                    case 32: // RELATION_C01
                        return Current.RELATION_C01;
                    case 33: // RELATION_C02
                        return Current.RELATION_C02;
                    case 34: // CONTACT_C
                        return Current.CONTACT_C;
                    case 35: // LIVING_ARR
                        return Current.LIVING_ARR;
                    case 36: // E_MAIL
                        return Current.E_MAIL;
                    case 37: // MOBILE
                        return Current.MOBILE;
                    case 38: // MAP_TYPE
                        return Current.MAP_TYPE;
                    case 39: // MAP_NUM
                        return Current.MAP_NUM;
                    case 40: // X_AXIS
                        return Current.X_AXIS;
                    case 41: // Y_AXIS
                        return Current.Y_AXIS;
                    case 42: // GENDER
                        return Current.GENDER;
                    case 43: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 44: // PROOF_DOB
                        return Current.PROOF_DOB;
                    case 45: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS;
                    case 46: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS;
                    case 47: // ARRIVAL
                        return Current.ARRIVAL;
                    case 48: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL;
                    case 49: // INTEGRATION
                        return Current.INTEGRATION;
                    case 50: // FAM_ORDER
                        return Current.FAM_ORDER;
                    case 51: // SGB_FUNDED
                        return Current.SGB_FUNDED;
                    case 52: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 53: // SCHOOL_YEAR_NEW
                        return Current.SCHOOL_YEAR_NEW;
                    case 54: // HOME_GROUP_NEW
                        return Current.HOME_GROUP_NEW;
                    case 55: // RELIGION
                        return Current.RELIGION;
                    case 56: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS;
                    case 57: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE;
                    case 58: // VISA_EXPIRY
                        return Current.VISA_EXPIRY;
                    case 59: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY;
                    case 60: // ENG_SPEAK
                        return Current.ENG_SPEAK;
                    case 61: // HOME_LANG
                        return Current.HOME_LANG;
                    case 62: // OVERSEAS
                        return Current.OVERSEAS;
                    case 63: // KOORIE
                        return Current.KOORIE;
                    case 64: // ACCESS
                        return Current.ACCESS;
                    case 65: // ACCESS_TYPE
                        return Current.ACCESS_TYPE;
                    case 66: // ACCESS_ALERT
                        return Current.ACCESS_ALERT;
                    case 67: // RISK_ALERT
                        return Current.RISK_ALERT;
                    case 68: // RISK_MEMO
                        return Current.RISK_MEMO;
                    case 69: // DOCTOR
                        return Current.DOCTOR;
                    case 70: // EMERG_NAME01
                        return Current.EMERG_NAME01;
                    case 71: // EMERG_NAME02
                        return Current.EMERG_NAME02;
                    case 72: // EMERG_LANG01
                        return Current.EMERG_LANG01;
                    case 73: // EMERG_LANG02
                        return Current.EMERG_LANG02;
                    case 74: // EMERG_RELATION01
                        return Current.EMERG_RELATION01;
                    case 75: // EMERG_RELATION02
                        return Current.EMERG_RELATION02;
                    case 76: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01;
                    case 77: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02;
                    case 78: // ACC_DECLARATION
                        return Current.ACC_DECLARATION;
                    case 79: // MEDICARE_NO
                        return Current.MEDICARE_NO;
                    case 80: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID;
                    case 81: // MEDICAL_ALERT
                        return Current.MEDICAL_ALERT;
                    case 82: // MEDICAL_CONDITION
                        return Current.MEDICAL_CONDITION;
                    case 83: // ACTIVITY_RESTRICTION
                        return Current.ACTIVITY_RESTRICTION;
                    case 84: // IMMUNISE_CERT_STATUS
                        return Current.IMMUNISE_CERT_STATUS;
                    case 85: // IMMUN_CERT_SIGHTED
                        return Current.IMMUN_CERT_SIGHTED;
                    case 86: // IMMUNISE_PERMISSION
                        return Current.IMMUNISE_PERMISSION;
                    case 87: // IMMUNIZE
                        return Current.IMMUNIZE;
                    case 88: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH;
                    case 89: // PIC_LW_DATE
                        return Current.PIC_LW_DATE;
                    case 90: // PIC_STATUS
                        return Current.PIC_STATUS;
                    case 91: // YEARS_PREVIOUS_EDUCATION
                        return Current.YEARS_PREVIOUS_EDUCATION;
                    case 92: // YEARS_INTERRUPTION_EDUCATION
                        return Current.YEARS_INTERRUPTION_EDUCATION;
                    case 93: // LANGUAGE_PREVIOUS_SCHOOLING
                        return Current.LANGUAGE_PREVIOUS_SCHOOLING;
                    case 94: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE;
                    case 95: // VSN
                        return Current.VSN;
                    case 96: // SPEC_CURR
                        return Current.SPEC_CURR;
                    case 97: // LEGAL_LIMIT_DECISION
                        return Current.LEGAL_LIMIT_DECISION;
                    case 98: // LEGAL_LIMIT_CONTACT
                        return Current.LEGAL_LIMIT_CONTACT;
                    case 99: // LEGAL_LIMITATION
                        return Current.LEGAL_LIMITATION;
                    case 100: // DOC_COPIES
                        return Current.DOC_COPIES;
                    case 101: // LISTED_IN_SOCS
                        return Current.LISTED_IN_SOCS;
                    case 102: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES;
                    case 103: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT;
                    case 104: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT;
                    case 105: // SUPPORT_GROUP
                        return Current.SUPPORT_GROUP;
                    case 106: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION;
                    case 107: // ATTENDANCE_CONCERNS
                        return Current.ATTENDANCE_CONCERNS;
                    case 108: // DISCIPLINARY_ACTION
                        return Current.DISCIPLINARY_ACTION;
                    case 109: // WELFARE_RISKS
                        return Current.WELFARE_RISKS;
                    case 110: // EFFORT
                        return Current.EFFORT;
                    case 111: // CLASS_BEHAVIOUR
                        return Current.CLASS_BEHAVIOUR;
                    case 112: // ORGANISATION
                        return Current.ORGANISATION;
                    case 113: // SOCIAL_BEHAVIOUR
                        return Current.SOCIAL_BEHAVIOUR;
                    case 114: // LEARNING_SUPPORT
                        return Current.LEARNING_SUPPORT;
                    case 115: // NEW_ARRIVALS_PROGRAM
                        return Current.NEW_ARRIVALS_PROGRAM;
                    case 116: // REFUGEE_BACKGROUND
                        return Current.REFUGEE_BACKGROUND;
                    case 117: // TRANSFER_DOCS_SENT
                        return Current.TRANSFER_DOCS_SENT;
                    case 118: // ENTRY
                        return Current.ENTRY;
                    case 119: // DFA_TRANS_ID
                        return Current.DFA_TRANS_ID;
                    case 120: // DFB_TRANS_ID
                        return Current.DFB_TRANS_ID;
                    case 121: // DFC_TRANS_ID
                        return Current.DFC_TRANS_ID;
                    case 122: // KCD_TRANS_ID
                        return Current.KCD_TRANS_ID;
                    case 123: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 124: // IMP_DATE
                        return Current.IMP_DATE;
                    case 125: // LW_DATE
                        return Current.LW_DATE;
                    case 126: // LW_TIME
                        return Current.LW_TIME;
                    case 127: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 3: // STKEY
                        return Current.STKEY == null;
                    case 4: // STKEY_NEW
                        return Current.STKEY_NEW == null;
                    case 5: // DUP_FAMILY
                        return Current.DUP_FAMILY == null;
                    case 6: // SURNAME
                        return Current.SURNAME == null;
                    case 7: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 8: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 9: // PREF_NAME
                        return Current.PREF_NAME == null;
                    case 10: // TITLE
                        return Current.TITLE == null;
                    case 11: // FAMILY
                        return Current.FAMILY == null;
                    case 12: // FAMILY_DUP
                        return Current.FAMILY_DUP == null;
                    case 13: // FAMILY_DUP_ACT
                        return Current.FAMILY_DUP_ACT == null;
                    case 14: // ACADEMIC_A
                        return Current.ACADEMIC_A == null;
                    case 15: // LIVING_A
                        return Current.LIVING_A == null;
                    case 16: // RELATION_A01
                        return Current.RELATION_A01 == null;
                    case 17: // RELATION_A02
                        return Current.RELATION_A02 == null;
                    case 18: // CONTACT_A
                        return Current.CONTACT_A == null;
                    case 19: // FAMB
                        return Current.FAMB == null;
                    case 20: // FAMB_DUP
                        return Current.FAMB_DUP == null;
                    case 21: // FAMB_DUP_ACT
                        return Current.FAMB_DUP_ACT == null;
                    case 22: // ACADEMIC_B
                        return Current.ACADEMIC_B == null;
                    case 23: // LIVING_B
                        return Current.LIVING_B == null;
                    case 24: // RELATION_B01
                        return Current.RELATION_B01 == null;
                    case 25: // RELATION_B02
                        return Current.RELATION_B02 == null;
                    case 26: // CONTACT_B
                        return Current.CONTACT_B == null;
                    case 27: // FAMC
                        return Current.FAMC == null;
                    case 28: // FAMC_DUP
                        return Current.FAMC_DUP == null;
                    case 29: // FAMC_DUP_ACT
                        return Current.FAMC_DUP_ACT == null;
                    case 30: // ACADEMIC_C
                        return Current.ACADEMIC_C == null;
                    case 31: // LIVING_C
                        return Current.LIVING_C == null;
                    case 32: // RELATION_C01
                        return Current.RELATION_C01 == null;
                    case 33: // RELATION_C02
                        return Current.RELATION_C02 == null;
                    case 34: // CONTACT_C
                        return Current.CONTACT_C == null;
                    case 35: // LIVING_ARR
                        return Current.LIVING_ARR == null;
                    case 36: // E_MAIL
                        return Current.E_MAIL == null;
                    case 37: // MOBILE
                        return Current.MOBILE == null;
                    case 38: // MAP_TYPE
                        return Current.MAP_TYPE == null;
                    case 39: // MAP_NUM
                        return Current.MAP_NUM == null;
                    case 40: // X_AXIS
                        return Current.X_AXIS == null;
                    case 41: // Y_AXIS
                        return Current.Y_AXIS == null;
                    case 42: // GENDER
                        return Current.GENDER == null;
                    case 43: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 44: // PROOF_DOB
                        return Current.PROOF_DOB == null;
                    case 45: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS == null;
                    case 46: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS == null;
                    case 47: // ARRIVAL
                        return Current.ARRIVAL == null;
                    case 48: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL == null;
                    case 49: // INTEGRATION
                        return Current.INTEGRATION == null;
                    case 50: // FAM_ORDER
                        return Current.FAM_ORDER == null;
                    case 51: // SGB_FUNDED
                        return Current.SGB_FUNDED == null;
                    case 52: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 53: // SCHOOL_YEAR_NEW
                        return Current.SCHOOL_YEAR_NEW == null;
                    case 54: // HOME_GROUP_NEW
                        return Current.HOME_GROUP_NEW == null;
                    case 55: // RELIGION
                        return Current.RELIGION == null;
                    case 56: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS == null;
                    case 57: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE == null;
                    case 58: // VISA_EXPIRY
                        return Current.VISA_EXPIRY == null;
                    case 59: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY == null;
                    case 60: // ENG_SPEAK
                        return Current.ENG_SPEAK == null;
                    case 61: // HOME_LANG
                        return Current.HOME_LANG == null;
                    case 62: // OVERSEAS
                        return Current.OVERSEAS == null;
                    case 63: // KOORIE
                        return Current.KOORIE == null;
                    case 64: // ACCESS
                        return Current.ACCESS == null;
                    case 65: // ACCESS_TYPE
                        return Current.ACCESS_TYPE == null;
                    case 66: // ACCESS_ALERT
                        return Current.ACCESS_ALERT == null;
                    case 67: // RISK_ALERT
                        return Current.RISK_ALERT == null;
                    case 68: // RISK_MEMO
                        return Current.RISK_MEMO == null;
                    case 69: // DOCTOR
                        return Current.DOCTOR == null;
                    case 70: // EMERG_NAME01
                        return Current.EMERG_NAME01 == null;
                    case 71: // EMERG_NAME02
                        return Current.EMERG_NAME02 == null;
                    case 72: // EMERG_LANG01
                        return Current.EMERG_LANG01 == null;
                    case 73: // EMERG_LANG02
                        return Current.EMERG_LANG02 == null;
                    case 74: // EMERG_RELATION01
                        return Current.EMERG_RELATION01 == null;
                    case 75: // EMERG_RELATION02
                        return Current.EMERG_RELATION02 == null;
                    case 76: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01 == null;
                    case 77: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02 == null;
                    case 78: // ACC_DECLARATION
                        return Current.ACC_DECLARATION == null;
                    case 79: // MEDICARE_NO
                        return Current.MEDICARE_NO == null;
                    case 80: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID == null;
                    case 81: // MEDICAL_ALERT
                        return Current.MEDICAL_ALERT == null;
                    case 82: // MEDICAL_CONDITION
                        return Current.MEDICAL_CONDITION == null;
                    case 83: // ACTIVITY_RESTRICTION
                        return Current.ACTIVITY_RESTRICTION == null;
                    case 84: // IMMUNISE_CERT_STATUS
                        return Current.IMMUNISE_CERT_STATUS == null;
                    case 85: // IMMUN_CERT_SIGHTED
                        return Current.IMMUN_CERT_SIGHTED == null;
                    case 86: // IMMUNISE_PERMISSION
                        return Current.IMMUNISE_PERMISSION == null;
                    case 87: // IMMUNIZE
                        return Current.IMMUNIZE == null;
                    case 88: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH == null;
                    case 89: // PIC_LW_DATE
                        return Current.PIC_LW_DATE == null;
                    case 90: // PIC_STATUS
                        return Current.PIC_STATUS == null;
                    case 91: // YEARS_PREVIOUS_EDUCATION
                        return Current.YEARS_PREVIOUS_EDUCATION == null;
                    case 92: // YEARS_INTERRUPTION_EDUCATION
                        return Current.YEARS_INTERRUPTION_EDUCATION == null;
                    case 93: // LANGUAGE_PREVIOUS_SCHOOLING
                        return Current.LANGUAGE_PREVIOUS_SCHOOLING == null;
                    case 94: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE == null;
                    case 95: // VSN
                        return Current.VSN == null;
                    case 96: // SPEC_CURR
                        return Current.SPEC_CURR == null;
                    case 97: // LEGAL_LIMIT_DECISION
                        return Current.LEGAL_LIMIT_DECISION == null;
                    case 98: // LEGAL_LIMIT_CONTACT
                        return Current.LEGAL_LIMIT_CONTACT == null;
                    case 99: // LEGAL_LIMITATION
                        return Current.LEGAL_LIMITATION == null;
                    case 100: // DOC_COPIES
                        return Current.DOC_COPIES == null;
                    case 101: // LISTED_IN_SOCS
                        return Current.LISTED_IN_SOCS == null;
                    case 102: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES == null;
                    case 103: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT == null;
                    case 104: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT == null;
                    case 105: // SUPPORT_GROUP
                        return Current.SUPPORT_GROUP == null;
                    case 106: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION == null;
                    case 107: // ATTENDANCE_CONCERNS
                        return Current.ATTENDANCE_CONCERNS == null;
                    case 108: // DISCIPLINARY_ACTION
                        return Current.DISCIPLINARY_ACTION == null;
                    case 109: // WELFARE_RISKS
                        return Current.WELFARE_RISKS == null;
                    case 110: // EFFORT
                        return Current.EFFORT == null;
                    case 111: // CLASS_BEHAVIOUR
                        return Current.CLASS_BEHAVIOUR == null;
                    case 112: // ORGANISATION
                        return Current.ORGANISATION == null;
                    case 113: // SOCIAL_BEHAVIOUR
                        return Current.SOCIAL_BEHAVIOUR == null;
                    case 114: // LEARNING_SUPPORT
                        return Current.LEARNING_SUPPORT == null;
                    case 115: // NEW_ARRIVALS_PROGRAM
                        return Current.NEW_ARRIVALS_PROGRAM == null;
                    case 116: // REFUGEE_BACKGROUND
                        return Current.REFUGEE_BACKGROUND == null;
                    case 117: // TRANSFER_DOCS_SENT
                        return Current.TRANSFER_DOCS_SENT == null;
                    case 118: // ENTRY
                        return Current.ENTRY == null;
                    case 119: // DFA_TRANS_ID
                        return Current.DFA_TRANS_ID == null;
                    case 120: // DFB_TRANS_ID
                        return Current.DFB_TRANS_ID == null;
                    case 121: // DFC_TRANS_ID
                        return Current.DFC_TRANS_ID == null;
                    case 122: // KCD_TRANS_ID
                        return Current.KCD_TRANS_ID == null;
                    case 123: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 124: // IMP_DATE
                        return Current.IMP_DATE == null;
                    case 125: // LW_DATE
                        return Current.LW_DATE == null;
                    case 126: // LW_TIME
                        return Current.LW_TIME == null;
                    case 127: // LW_USER
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
                    case 1: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 2: // ORIG_SCHOOL
                        return "ORIG_SCHOOL";
                    case 3: // STKEY
                        return "STKEY";
                    case 4: // STKEY_NEW
                        return "STKEY_NEW";
                    case 5: // DUP_FAMILY
                        return "DUP_FAMILY";
                    case 6: // SURNAME
                        return "SURNAME";
                    case 7: // FIRST_NAME
                        return "FIRST_NAME";
                    case 8: // SECOND_NAME
                        return "SECOND_NAME";
                    case 9: // PREF_NAME
                        return "PREF_NAME";
                    case 10: // TITLE
                        return "TITLE";
                    case 11: // FAMILY
                        return "FAMILY";
                    case 12: // FAMILY_DUP
                        return "FAMILY_DUP";
                    case 13: // FAMILY_DUP_ACT
                        return "FAMILY_DUP_ACT";
                    case 14: // ACADEMIC_A
                        return "ACADEMIC_A";
                    case 15: // LIVING_A
                        return "LIVING_A";
                    case 16: // RELATION_A01
                        return "RELATION_A01";
                    case 17: // RELATION_A02
                        return "RELATION_A02";
                    case 18: // CONTACT_A
                        return "CONTACT_A";
                    case 19: // FAMB
                        return "FAMB";
                    case 20: // FAMB_DUP
                        return "FAMB_DUP";
                    case 21: // FAMB_DUP_ACT
                        return "FAMB_DUP_ACT";
                    case 22: // ACADEMIC_B
                        return "ACADEMIC_B";
                    case 23: // LIVING_B
                        return "LIVING_B";
                    case 24: // RELATION_B01
                        return "RELATION_B01";
                    case 25: // RELATION_B02
                        return "RELATION_B02";
                    case 26: // CONTACT_B
                        return "CONTACT_B";
                    case 27: // FAMC
                        return "FAMC";
                    case 28: // FAMC_DUP
                        return "FAMC_DUP";
                    case 29: // FAMC_DUP_ACT
                        return "FAMC_DUP_ACT";
                    case 30: // ACADEMIC_C
                        return "ACADEMIC_C";
                    case 31: // LIVING_C
                        return "LIVING_C";
                    case 32: // RELATION_C01
                        return "RELATION_C01";
                    case 33: // RELATION_C02
                        return "RELATION_C02";
                    case 34: // CONTACT_C
                        return "CONTACT_C";
                    case 35: // LIVING_ARR
                        return "LIVING_ARR";
                    case 36: // E_MAIL
                        return "E_MAIL";
                    case 37: // MOBILE
                        return "MOBILE";
                    case 38: // MAP_TYPE
                        return "MAP_TYPE";
                    case 39: // MAP_NUM
                        return "MAP_NUM";
                    case 40: // X_AXIS
                        return "X_AXIS";
                    case 41: // Y_AXIS
                        return "Y_AXIS";
                    case 42: // GENDER
                        return "GENDER";
                    case 43: // BIRTHDATE
                        return "BIRTHDATE";
                    case 44: // PROOF_DOB
                        return "PROOF_DOB";
                    case 45: // RESIDENT_STATUS
                        return "RESIDENT_STATUS";
                    case 46: // PERMANENT_BASIS
                        return "PERMANENT_BASIS";
                    case 47: // ARRIVAL
                        return "ARRIVAL";
                    case 48: // AUSSIE_SCHOOL
                        return "AUSSIE_SCHOOL";
                    case 49: // INTEGRATION
                        return "INTEGRATION";
                    case 50: // FAM_ORDER
                        return "FAM_ORDER";
                    case 51: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 52: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 53: // SCHOOL_YEAR_NEW
                        return "SCHOOL_YEAR_NEW";
                    case 54: // HOME_GROUP_NEW
                        return "HOME_GROUP_NEW";
                    case 55: // RELIGION
                        return "RELIGION";
                    case 56: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 57: // VISA_STAT_CODE
                        return "VISA_STAT_CODE";
                    case 58: // VISA_EXPIRY
                        return "VISA_EXPIRY";
                    case 59: // BIRTH_COUNTRY
                        return "BIRTH_COUNTRY";
                    case 60: // ENG_SPEAK
                        return "ENG_SPEAK";
                    case 61: // HOME_LANG
                        return "HOME_LANG";
                    case 62: // OVERSEAS
                        return "OVERSEAS";
                    case 63: // KOORIE
                        return "KOORIE";
                    case 64: // ACCESS
                        return "ACCESS";
                    case 65: // ACCESS_TYPE
                        return "ACCESS_TYPE";
                    case 66: // ACCESS_ALERT
                        return "ACCESS_ALERT";
                    case 67: // RISK_ALERT
                        return "RISK_ALERT";
                    case 68: // RISK_MEMO
                        return "RISK_MEMO";
                    case 69: // DOCTOR
                        return "DOCTOR";
                    case 70: // EMERG_NAME01
                        return "EMERG_NAME01";
                    case 71: // EMERG_NAME02
                        return "EMERG_NAME02";
                    case 72: // EMERG_LANG01
                        return "EMERG_LANG01";
                    case 73: // EMERG_LANG02
                        return "EMERG_LANG02";
                    case 74: // EMERG_RELATION01
                        return "EMERG_RELATION01";
                    case 75: // EMERG_RELATION02
                        return "EMERG_RELATION02";
                    case 76: // EMERG_CONTACT01
                        return "EMERG_CONTACT01";
                    case 77: // EMERG_CONTACT02
                        return "EMERG_CONTACT02";
                    case 78: // ACC_DECLARATION
                        return "ACC_DECLARATION";
                    case 79: // MEDICARE_NO
                        return "MEDICARE_NO";
                    case 80: // INTERNATIONAL_ST_ID
                        return "INTERNATIONAL_ST_ID";
                    case 81: // MEDICAL_ALERT
                        return "MEDICAL_ALERT";
                    case 82: // MEDICAL_CONDITION
                        return "MEDICAL_CONDITION";
                    case 83: // ACTIVITY_RESTRICTION
                        return "ACTIVITY_RESTRICTION";
                    case 84: // IMMUNISE_CERT_STATUS
                        return "IMMUNISE_CERT_STATUS";
                    case 85: // IMMUN_CERT_SIGHTED
                        return "IMMUN_CERT_SIGHTED";
                    case 86: // IMMUNISE_PERMISSION
                        return "IMMUNISE_PERMISSION";
                    case 87: // IMMUNIZE
                        return "IMMUNIZE";
                    case 88: // OK_TO_PUBLISH
                        return "OK_TO_PUBLISH";
                    case 89: // PIC_LW_DATE
                        return "PIC_LW_DATE";
                    case 90: // PIC_STATUS
                        return "PIC_STATUS";
                    case 91: // YEARS_PREVIOUS_EDUCATION
                        return "YEARS_PREVIOUS_EDUCATION";
                    case 92: // YEARS_INTERRUPTION_EDUCATION
                        return "YEARS_INTERRUPTION_EDUCATION";
                    case 93: // LANGUAGE_PREVIOUS_SCHOOLING
                        return "LANGUAGE_PREVIOUS_SCHOOLING";
                    case 94: // LOTE_HOME_CODE
                        return "LOTE_HOME_CODE";
                    case 95: // VSN
                        return "VSN";
                    case 96: // SPEC_CURR
                        return "SPEC_CURR";
                    case 97: // LEGAL_LIMIT_DECISION
                        return "LEGAL_LIMIT_DECISION";
                    case 98: // LEGAL_LIMIT_CONTACT
                        return "LEGAL_LIMIT_CONTACT";
                    case 99: // LEGAL_LIMITATION
                        return "LEGAL_LIMITATION";
                    case 100: // DOC_COPIES
                        return "DOC_COPIES";
                    case 101: // LISTED_IN_SOCS
                        return "LISTED_IN_SOCS";
                    case 102: // SUPPORT_SERVICES
                        return "SUPPORT_SERVICES";
                    case 103: // STUDENT_SUPPORT
                        return "STUDENT_SUPPORT";
                    case 104: // STUDENT_OTHER_SUPPORT
                        return "STUDENT_OTHER_SUPPORT";
                    case 105: // SUPPORT_GROUP
                        return "SUPPORT_GROUP";
                    case 106: // CHILD_PROTECTION
                        return "CHILD_PROTECTION";
                    case 107: // ATTENDANCE_CONCERNS
                        return "ATTENDANCE_CONCERNS";
                    case 108: // DISCIPLINARY_ACTION
                        return "DISCIPLINARY_ACTION";
                    case 109: // WELFARE_RISKS
                        return "WELFARE_RISKS";
                    case 110: // EFFORT
                        return "EFFORT";
                    case 111: // CLASS_BEHAVIOUR
                        return "CLASS_BEHAVIOUR";
                    case 112: // ORGANISATION
                        return "ORGANISATION";
                    case 113: // SOCIAL_BEHAVIOUR
                        return "SOCIAL_BEHAVIOUR";
                    case 114: // LEARNING_SUPPORT
                        return "LEARNING_SUPPORT";
                    case 115: // NEW_ARRIVALS_PROGRAM
                        return "NEW_ARRIVALS_PROGRAM";
                    case 116: // REFUGEE_BACKGROUND
                        return "REFUGEE_BACKGROUND";
                    case 117: // TRANSFER_DOCS_SENT
                        return "TRANSFER_DOCS_SENT";
                    case 118: // ENTRY
                        return "ENTRY";
                    case 119: // DFA_TRANS_ID
                        return "DFA_TRANS_ID";
                    case 120: // DFB_TRANS_ID
                        return "DFB_TRANS_ID";
                    case 121: // DFC_TRANS_ID
                        return "DFC_TRANS_ID";
                    case 122: // KCD_TRANS_ID
                        return "KCD_TRANS_ID";
                    case 123: // IMP_STATUS
                        return "IMP_STATUS";
                    case 124: // IMP_DATE
                        return "IMP_DATE";
                    case 125: // LW_DATE
                        return "LW_DATE";
                    case 126: // LW_TIME
                        return "LW_TIME";
                    case 127: // LW_USER
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
                    case "ST_TRANS_ID":
                        return 1;
                    case "ORIG_SCHOOL":
                        return 2;
                    case "STKEY":
                        return 3;
                    case "STKEY_NEW":
                        return 4;
                    case "DUP_FAMILY":
                        return 5;
                    case "SURNAME":
                        return 6;
                    case "FIRST_NAME":
                        return 7;
                    case "SECOND_NAME":
                        return 8;
                    case "PREF_NAME":
                        return 9;
                    case "TITLE":
                        return 10;
                    case "FAMILY":
                        return 11;
                    case "FAMILY_DUP":
                        return 12;
                    case "FAMILY_DUP_ACT":
                        return 13;
                    case "ACADEMIC_A":
                        return 14;
                    case "LIVING_A":
                        return 15;
                    case "RELATION_A01":
                        return 16;
                    case "RELATION_A02":
                        return 17;
                    case "CONTACT_A":
                        return 18;
                    case "FAMB":
                        return 19;
                    case "FAMB_DUP":
                        return 20;
                    case "FAMB_DUP_ACT":
                        return 21;
                    case "ACADEMIC_B":
                        return 22;
                    case "LIVING_B":
                        return 23;
                    case "RELATION_B01":
                        return 24;
                    case "RELATION_B02":
                        return 25;
                    case "CONTACT_B":
                        return 26;
                    case "FAMC":
                        return 27;
                    case "FAMC_DUP":
                        return 28;
                    case "FAMC_DUP_ACT":
                        return 29;
                    case "ACADEMIC_C":
                        return 30;
                    case "LIVING_C":
                        return 31;
                    case "RELATION_C01":
                        return 32;
                    case "RELATION_C02":
                        return 33;
                    case "CONTACT_C":
                        return 34;
                    case "LIVING_ARR":
                        return 35;
                    case "E_MAIL":
                        return 36;
                    case "MOBILE":
                        return 37;
                    case "MAP_TYPE":
                        return 38;
                    case "MAP_NUM":
                        return 39;
                    case "X_AXIS":
                        return 40;
                    case "Y_AXIS":
                        return 41;
                    case "GENDER":
                        return 42;
                    case "BIRTHDATE":
                        return 43;
                    case "PROOF_DOB":
                        return 44;
                    case "RESIDENT_STATUS":
                        return 45;
                    case "PERMANENT_BASIS":
                        return 46;
                    case "ARRIVAL":
                        return 47;
                    case "AUSSIE_SCHOOL":
                        return 48;
                    case "INTEGRATION":
                        return 49;
                    case "FAM_ORDER":
                        return 50;
                    case "SGB_FUNDED":
                        return 51;
                    case "SCHOOL_YEAR":
                        return 52;
                    case "SCHOOL_YEAR_NEW":
                        return 53;
                    case "HOME_GROUP_NEW":
                        return 54;
                    case "RELIGION":
                        return 55;
                    case "VISA_SUBCLASS":
                        return 56;
                    case "VISA_STAT_CODE":
                        return 57;
                    case "VISA_EXPIRY":
                        return 58;
                    case "BIRTH_COUNTRY":
                        return 59;
                    case "ENG_SPEAK":
                        return 60;
                    case "HOME_LANG":
                        return 61;
                    case "OVERSEAS":
                        return 62;
                    case "KOORIE":
                        return 63;
                    case "ACCESS":
                        return 64;
                    case "ACCESS_TYPE":
                        return 65;
                    case "ACCESS_ALERT":
                        return 66;
                    case "RISK_ALERT":
                        return 67;
                    case "RISK_MEMO":
                        return 68;
                    case "DOCTOR":
                        return 69;
                    case "EMERG_NAME01":
                        return 70;
                    case "EMERG_NAME02":
                        return 71;
                    case "EMERG_LANG01":
                        return 72;
                    case "EMERG_LANG02":
                        return 73;
                    case "EMERG_RELATION01":
                        return 74;
                    case "EMERG_RELATION02":
                        return 75;
                    case "EMERG_CONTACT01":
                        return 76;
                    case "EMERG_CONTACT02":
                        return 77;
                    case "ACC_DECLARATION":
                        return 78;
                    case "MEDICARE_NO":
                        return 79;
                    case "INTERNATIONAL_ST_ID":
                        return 80;
                    case "MEDICAL_ALERT":
                        return 81;
                    case "MEDICAL_CONDITION":
                        return 82;
                    case "ACTIVITY_RESTRICTION":
                        return 83;
                    case "IMMUNISE_CERT_STATUS":
                        return 84;
                    case "IMMUN_CERT_SIGHTED":
                        return 85;
                    case "IMMUNISE_PERMISSION":
                        return 86;
                    case "IMMUNIZE":
                        return 87;
                    case "OK_TO_PUBLISH":
                        return 88;
                    case "PIC_LW_DATE":
                        return 89;
                    case "PIC_STATUS":
                        return 90;
                    case "YEARS_PREVIOUS_EDUCATION":
                        return 91;
                    case "YEARS_INTERRUPTION_EDUCATION":
                        return 92;
                    case "LANGUAGE_PREVIOUS_SCHOOLING":
                        return 93;
                    case "LOTE_HOME_CODE":
                        return 94;
                    case "VSN":
                        return 95;
                    case "SPEC_CURR":
                        return 96;
                    case "LEGAL_LIMIT_DECISION":
                        return 97;
                    case "LEGAL_LIMIT_CONTACT":
                        return 98;
                    case "LEGAL_LIMITATION":
                        return 99;
                    case "DOC_COPIES":
                        return 100;
                    case "LISTED_IN_SOCS":
                        return 101;
                    case "SUPPORT_SERVICES":
                        return 102;
                    case "STUDENT_SUPPORT":
                        return 103;
                    case "STUDENT_OTHER_SUPPORT":
                        return 104;
                    case "SUPPORT_GROUP":
                        return 105;
                    case "CHILD_PROTECTION":
                        return 106;
                    case "ATTENDANCE_CONCERNS":
                        return 107;
                    case "DISCIPLINARY_ACTION":
                        return 108;
                    case "WELFARE_RISKS":
                        return 109;
                    case "EFFORT":
                        return 110;
                    case "CLASS_BEHAVIOUR":
                        return 111;
                    case "ORGANISATION":
                        return 112;
                    case "SOCIAL_BEHAVIOUR":
                        return 113;
                    case "LEARNING_SUPPORT":
                        return 114;
                    case "NEW_ARRIVALS_PROGRAM":
                        return 115;
                    case "REFUGEE_BACKGROUND":
                        return 116;
                    case "TRANSFER_DOCS_SENT":
                        return 117;
                    case "ENTRY":
                        return 118;
                    case "DFA_TRANS_ID":
                        return 119;
                    case "DFB_TRANS_ID":
                        return 120;
                    case "DFC_TRANS_ID":
                        return 121;
                    case "KCD_TRANS_ID":
                        return 122;
                    case "IMP_STATUS":
                        return 123;
                    case "IMP_DATE":
                        return 124;
                    case "LW_DATE":
                        return 125;
                    case "LW_TIME":
                        return 126;
                    case "LW_USER":
                        return 127;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
