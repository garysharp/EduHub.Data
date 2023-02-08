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
                    case "STKEY_DUP":
                        mapper[i] = (e, v) => e.STKEY_DUP = v;
                        break;
                    case "STKEY_DUP_ACT":
                        mapper[i] = (e, v) => e.STKEY_DUP_ACT = v;
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
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.ARRIVAL = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "AUSSIE_SCHOOL":
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                    case "EMERG_CONTACT_MEMO01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO01 = v;
                        break;
                    case "EMERG_CONTACT_MEMO02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO02 = v;
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
                        mapper[i] = (e, v) => e.PIC_LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "VET":
                        mapper[i] = (e, v) => e.VET = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
                        break;
                    case "TEACHER_RECOMMENDATION":
                        mapper[i] = (e, v) => e.TEACHER_RECOMMENDATION = v;
                        break;
                    case "TRANSITION_STATEMENT":
                        mapper[i] = (e, v) => e.TRANSITION_STATEMENT = v;
                        break;
                    case "FIRST_REG_NO":
                        mapper[i] = (e, v) => e.FIRST_REG_NO = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "DISABILITY_ID":
                        mapper[i] = (e, v) => e.DISABILITY_ID = v;
                        break;
                    case "CRIS_ID":
                        mapper[i] = (e, v) => e.CRIS_ID = v;
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION_NEW":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION_NEW = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "YOUNG_CARER":
                        mapper[i] = (e, v) => e.YOUNG_CARER = v;
                        break;
                    case "GENDER_DESC":
                        mapper[i] = (e, v) => e.GENDER_DESC = v;
                        break;
                    case "MYLNS_LITERACY":
                        mapper[i] = (e, v) => e.MYLNS_LITERACY = v;
                        break;
                    case "MYLNS_NUMERACY":
                        mapper[i] = (e, v) => e.MYLNS_NUMERACY = v;
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
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "STUDENT_SI_ID":
                        mapper[i] = (e, v) => e.STUDENT_SI_ID = v;
                        break;
                    case "ENROLMENT_SI_ID":
                        mapper[i] = (e, v) => e.ENROLMENT_SI_ID = v;
                        break;
                    case "APPLICATION_SI_ID":
                        mapper[i] = (e, v) => e.APPLICATION_SI_ID = v;
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
        [STKEY_DUP] varchar(10) NULL,
        [STKEY_DUP_ACT] varchar(1) NULL,
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
        [ACCESS] varchar(MAX) NULL,
        [ACCESS_TYPE] varchar(20) NULL,
        [ACCESS_ALERT] varchar(1) NULL,
        [RISK_ALERT] varchar(1) NULL,
        [RISK_MEMO] varchar(MAX) NULL,
        [DOCTOR] varchar(10) NULL,
        [EMERG_NAME01] varchar(30) NULL,
        [EMERG_NAME02] varchar(30) NULL,
        [EMERG_LANG01] varchar(7) NULL,
        [EMERG_LANG02] varchar(7) NULL,
        [EMERG_RELATION01] varchar(20) NULL,
        [EMERG_RELATION02] varchar(20) NULL,
        [EMERG_CONTACT01] varchar(20) NULL,
        [EMERG_CONTACT02] varchar(20) NULL,
        [EMERG_CONTACT_MEMO01] varchar(MAX) NULL,
        [EMERG_CONTACT_MEMO02] varchar(MAX) NULL,
        [ACC_DECLARATION] varchar(1) NULL,
        [MEDICARE_NO] varchar(12) NULL,
        [INTERNATIONAL_ST_ID] varchar(7) NULL,
        [MEDICAL_ALERT] varchar(1) NULL,
        [HEARING_IMPAIR] varchar(1) NULL,
        [VISUAL_IMPAIR] varchar(1) NULL,
        [SPEECH_IMPAIR] varchar(1) NULL,
        [PHYSICAL_IMPAIR] varchar(1) NULL,
        [MEDICAL_CONDITION] varchar(1) NULL,
        [ACTIVITY_RESTRICTION] varchar(MAX) NULL,
        [IMMUNISE_CERT_STATUS] varchar(2) NULL,
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
        [LEGAL_LIMITATION] varchar(MAX) NULL,
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
        [VET] varchar(1) NULL,
        [USI] varchar(10) NULL,
        [TEACHER_RECOMMENDATION] varchar(1) NULL,
        [TRANSITION_STATEMENT] varchar(1) NULL,
        [FIRST_REG_NO] varchar(15) NULL,
        [DISABILITY] varchar(1) NULL,
        [DISABILITY_ID] varchar(6) NULL,
        [CRIS_ID] varchar(9) NULL,
        [ACTUAL_TIME_FRACTION] float NULL,
        [ACTUAL_TIME_FRACTION_NEW] float NULL,
        [YOUNG_CARER] varchar(40) NULL,
        [GENDER_DESC] varchar(100) NULL,
        [MYLNS_LITERACY] varchar(1) NULL,
        [MYLNS_NUMERACY] varchar(1) NULL,
        [DFA_TRANS_ID] varchar(30) NULL,
        [DFB_TRANS_ID] varchar(30) NULL,
        [DFC_TRANS_ID] varchar(30) NULL,
        [KCD_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [STUDENT_SI_ID] varchar(20) NULL,
        [ENROLMENT_SI_ID] varchar(20) NULL,
        [APPLICATION_SI_ID] varchar(20) NULL,
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_HOME_GROUP_NEW')
    ALTER INDEX [ST_TFR_Index_HOME_GROUP_NEW] ON [dbo].[ST_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_SCHOOL_YEAR_NEW')
    ALTER INDEX [ST_TFR_Index_SCHOOL_YEAR_NEW] ON [dbo].[ST_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_ST_TRANS_ID')
    ALTER INDEX [ST_TFR_Index_ST_TRANS_ID] ON [dbo].[ST_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_TID')
    ALTER INDEX [ST_TFR_Index_TID] ON [dbo].[ST_TFR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_HOME_GROUP_NEW')
    ALTER INDEX [ST_TFR_Index_HOME_GROUP_NEW] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_SCHOOL_YEAR_NEW')
    ALTER INDEX [ST_TFR_Index_SCHOOL_YEAR_NEW] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_ST_TRANS_ID')
    ALTER INDEX [ST_TFR_Index_ST_TRANS_ID] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFR]') AND name = N'ST_TFR_Index_TID')
    ALTER INDEX [ST_TFR_Index_TID] ON [dbo].[ST_TFR] REBUILD PARTITION = ALL;
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

            public override int FieldCount { get { return 153; } }

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
                    case 5: // STKEY_DUP
                        return Current.STKEY_DUP;
                    case 6: // STKEY_DUP_ACT
                        return Current.STKEY_DUP_ACT;
                    case 7: // DUP_FAMILY
                        return Current.DUP_FAMILY;
                    case 8: // SURNAME
                        return Current.SURNAME;
                    case 9: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 10: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 11: // PREF_NAME
                        return Current.PREF_NAME;
                    case 12: // TITLE
                        return Current.TITLE;
                    case 13: // FAMILY
                        return Current.FAMILY;
                    case 14: // FAMILY_DUP
                        return Current.FAMILY_DUP;
                    case 15: // FAMILY_DUP_ACT
                        return Current.FAMILY_DUP_ACT;
                    case 16: // ACADEMIC_A
                        return Current.ACADEMIC_A;
                    case 17: // LIVING_A
                        return Current.LIVING_A;
                    case 18: // RELATION_A01
                        return Current.RELATION_A01;
                    case 19: // RELATION_A02
                        return Current.RELATION_A02;
                    case 20: // CONTACT_A
                        return Current.CONTACT_A;
                    case 21: // FAMB
                        return Current.FAMB;
                    case 22: // FAMB_DUP
                        return Current.FAMB_DUP;
                    case 23: // FAMB_DUP_ACT
                        return Current.FAMB_DUP_ACT;
                    case 24: // ACADEMIC_B
                        return Current.ACADEMIC_B;
                    case 25: // LIVING_B
                        return Current.LIVING_B;
                    case 26: // RELATION_B01
                        return Current.RELATION_B01;
                    case 27: // RELATION_B02
                        return Current.RELATION_B02;
                    case 28: // CONTACT_B
                        return Current.CONTACT_B;
                    case 29: // FAMC
                        return Current.FAMC;
                    case 30: // FAMC_DUP
                        return Current.FAMC_DUP;
                    case 31: // FAMC_DUP_ACT
                        return Current.FAMC_DUP_ACT;
                    case 32: // ACADEMIC_C
                        return Current.ACADEMIC_C;
                    case 33: // LIVING_C
                        return Current.LIVING_C;
                    case 34: // RELATION_C01
                        return Current.RELATION_C01;
                    case 35: // RELATION_C02
                        return Current.RELATION_C02;
                    case 36: // CONTACT_C
                        return Current.CONTACT_C;
                    case 37: // LIVING_ARR
                        return Current.LIVING_ARR;
                    case 38: // E_MAIL
                        return Current.E_MAIL;
                    case 39: // MOBILE
                        return Current.MOBILE;
                    case 40: // MAP_TYPE
                        return Current.MAP_TYPE;
                    case 41: // MAP_NUM
                        return Current.MAP_NUM;
                    case 42: // X_AXIS
                        return Current.X_AXIS;
                    case 43: // Y_AXIS
                        return Current.Y_AXIS;
                    case 44: // GENDER
                        return Current.GENDER;
                    case 45: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 46: // PROOF_DOB
                        return Current.PROOF_DOB;
                    case 47: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS;
                    case 48: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS;
                    case 49: // ARRIVAL
                        return Current.ARRIVAL;
                    case 50: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL;
                    case 51: // INTEGRATION
                        return Current.INTEGRATION;
                    case 52: // FAM_ORDER
                        return Current.FAM_ORDER;
                    case 53: // SGB_FUNDED
                        return Current.SGB_FUNDED;
                    case 54: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 55: // SCHOOL_YEAR_NEW
                        return Current.SCHOOL_YEAR_NEW;
                    case 56: // HOME_GROUP_NEW
                        return Current.HOME_GROUP_NEW;
                    case 57: // RELIGION
                        return Current.RELIGION;
                    case 58: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS;
                    case 59: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE;
                    case 60: // VISA_EXPIRY
                        return Current.VISA_EXPIRY;
                    case 61: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY;
                    case 62: // ENG_SPEAK
                        return Current.ENG_SPEAK;
                    case 63: // HOME_LANG
                        return Current.HOME_LANG;
                    case 64: // OVERSEAS
                        return Current.OVERSEAS;
                    case 65: // KOORIE
                        return Current.KOORIE;
                    case 66: // ACCESS
                        return Current.ACCESS;
                    case 67: // ACCESS_TYPE
                        return Current.ACCESS_TYPE;
                    case 68: // ACCESS_ALERT
                        return Current.ACCESS_ALERT;
                    case 69: // RISK_ALERT
                        return Current.RISK_ALERT;
                    case 70: // RISK_MEMO
                        return Current.RISK_MEMO;
                    case 71: // DOCTOR
                        return Current.DOCTOR;
                    case 72: // EMERG_NAME01
                        return Current.EMERG_NAME01;
                    case 73: // EMERG_NAME02
                        return Current.EMERG_NAME02;
                    case 74: // EMERG_LANG01
                        return Current.EMERG_LANG01;
                    case 75: // EMERG_LANG02
                        return Current.EMERG_LANG02;
                    case 76: // EMERG_RELATION01
                        return Current.EMERG_RELATION01;
                    case 77: // EMERG_RELATION02
                        return Current.EMERG_RELATION02;
                    case 78: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01;
                    case 79: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02;
                    case 80: // EMERG_CONTACT_MEMO01
                        return Current.EMERG_CONTACT_MEMO01;
                    case 81: // EMERG_CONTACT_MEMO02
                        return Current.EMERG_CONTACT_MEMO02;
                    case 82: // ACC_DECLARATION
                        return Current.ACC_DECLARATION;
                    case 83: // MEDICARE_NO
                        return Current.MEDICARE_NO;
                    case 84: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID;
                    case 85: // MEDICAL_ALERT
                        return Current.MEDICAL_ALERT;
                    case 86: // HEARING_IMPAIR
                        return Current.HEARING_IMPAIR;
                    case 87: // VISUAL_IMPAIR
                        return Current.VISUAL_IMPAIR;
                    case 88: // SPEECH_IMPAIR
                        return Current.SPEECH_IMPAIR;
                    case 89: // PHYSICAL_IMPAIR
                        return Current.PHYSICAL_IMPAIR;
                    case 90: // MEDICAL_CONDITION
                        return Current.MEDICAL_CONDITION;
                    case 91: // ACTIVITY_RESTRICTION
                        return Current.ACTIVITY_RESTRICTION;
                    case 92: // IMMUNISE_CERT_STATUS
                        return Current.IMMUNISE_CERT_STATUS;
                    case 93: // IMMUN_CERT_SIGHTED
                        return Current.IMMUN_CERT_SIGHTED;
                    case 94: // IMMUNISE_PERMISSION
                        return Current.IMMUNISE_PERMISSION;
                    case 95: // IMMUNIZE
                        return Current.IMMUNIZE;
                    case 96: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH;
                    case 97: // PIC_LW_DATE
                        return Current.PIC_LW_DATE;
                    case 98: // PIC_STATUS
                        return Current.PIC_STATUS;
                    case 99: // YEARS_PREVIOUS_EDUCATION
                        return Current.YEARS_PREVIOUS_EDUCATION;
                    case 100: // YEARS_INTERRUPTION_EDUCATION
                        return Current.YEARS_INTERRUPTION_EDUCATION;
                    case 101: // LANGUAGE_PREVIOUS_SCHOOLING
                        return Current.LANGUAGE_PREVIOUS_SCHOOLING;
                    case 102: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE;
                    case 103: // VSN
                        return Current.VSN;
                    case 104: // SPEC_CURR
                        return Current.SPEC_CURR;
                    case 105: // LEGAL_LIMIT_DECISION
                        return Current.LEGAL_LIMIT_DECISION;
                    case 106: // LEGAL_LIMIT_CONTACT
                        return Current.LEGAL_LIMIT_CONTACT;
                    case 107: // LEGAL_LIMITATION
                        return Current.LEGAL_LIMITATION;
                    case 108: // DOC_COPIES
                        return Current.DOC_COPIES;
                    case 109: // LISTED_IN_SOCS
                        return Current.LISTED_IN_SOCS;
                    case 110: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES;
                    case 111: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT;
                    case 112: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT;
                    case 113: // SUPPORT_GROUP
                        return Current.SUPPORT_GROUP;
                    case 114: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION;
                    case 115: // ATTENDANCE_CONCERNS
                        return Current.ATTENDANCE_CONCERNS;
                    case 116: // DISCIPLINARY_ACTION
                        return Current.DISCIPLINARY_ACTION;
                    case 117: // WELFARE_RISKS
                        return Current.WELFARE_RISKS;
                    case 118: // EFFORT
                        return Current.EFFORT;
                    case 119: // CLASS_BEHAVIOUR
                        return Current.CLASS_BEHAVIOUR;
                    case 120: // ORGANISATION
                        return Current.ORGANISATION;
                    case 121: // SOCIAL_BEHAVIOUR
                        return Current.SOCIAL_BEHAVIOUR;
                    case 122: // LEARNING_SUPPORT
                        return Current.LEARNING_SUPPORT;
                    case 123: // NEW_ARRIVALS_PROGRAM
                        return Current.NEW_ARRIVALS_PROGRAM;
                    case 124: // REFUGEE_BACKGROUND
                        return Current.REFUGEE_BACKGROUND;
                    case 125: // TRANSFER_DOCS_SENT
                        return Current.TRANSFER_DOCS_SENT;
                    case 126: // ENTRY
                        return Current.ENTRY;
                    case 127: // VET
                        return Current.VET;
                    case 128: // USI
                        return Current.USI;
                    case 129: // TEACHER_RECOMMENDATION
                        return Current.TEACHER_RECOMMENDATION;
                    case 130: // TRANSITION_STATEMENT
                        return Current.TRANSITION_STATEMENT;
                    case 131: // FIRST_REG_NO
                        return Current.FIRST_REG_NO;
                    case 132: // DISABILITY
                        return Current.DISABILITY;
                    case 133: // DISABILITY_ID
                        return Current.DISABILITY_ID;
                    case 134: // CRIS_ID
                        return Current.CRIS_ID;
                    case 135: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION;
                    case 136: // ACTUAL_TIME_FRACTION_NEW
                        return Current.ACTUAL_TIME_FRACTION_NEW;
                    case 137: // YOUNG_CARER
                        return Current.YOUNG_CARER;
                    case 138: // GENDER_DESC
                        return Current.GENDER_DESC;
                    case 139: // MYLNS_LITERACY
                        return Current.MYLNS_LITERACY;
                    case 140: // MYLNS_NUMERACY
                        return Current.MYLNS_NUMERACY;
                    case 141: // DFA_TRANS_ID
                        return Current.DFA_TRANS_ID;
                    case 142: // DFB_TRANS_ID
                        return Current.DFB_TRANS_ID;
                    case 143: // DFC_TRANS_ID
                        return Current.DFC_TRANS_ID;
                    case 144: // KCD_TRANS_ID
                        return Current.KCD_TRANS_ID;
                    case 145: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 146: // IMP_DATE
                        return Current.IMP_DATE;
                    case 147: // STUDENT_SI_ID
                        return Current.STUDENT_SI_ID;
                    case 148: // ENROLMENT_SI_ID
                        return Current.ENROLMENT_SI_ID;
                    case 149: // APPLICATION_SI_ID
                        return Current.APPLICATION_SI_ID;
                    case 150: // LW_DATE
                        return Current.LW_DATE;
                    case 151: // LW_TIME
                        return Current.LW_TIME;
                    case 152: // LW_USER
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
                    case 5: // STKEY_DUP
                        return Current.STKEY_DUP == null;
                    case 6: // STKEY_DUP_ACT
                        return Current.STKEY_DUP_ACT == null;
                    case 7: // DUP_FAMILY
                        return Current.DUP_FAMILY == null;
                    case 8: // SURNAME
                        return Current.SURNAME == null;
                    case 9: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 10: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 11: // PREF_NAME
                        return Current.PREF_NAME == null;
                    case 12: // TITLE
                        return Current.TITLE == null;
                    case 13: // FAMILY
                        return Current.FAMILY == null;
                    case 14: // FAMILY_DUP
                        return Current.FAMILY_DUP == null;
                    case 15: // FAMILY_DUP_ACT
                        return Current.FAMILY_DUP_ACT == null;
                    case 16: // ACADEMIC_A
                        return Current.ACADEMIC_A == null;
                    case 17: // LIVING_A
                        return Current.LIVING_A == null;
                    case 18: // RELATION_A01
                        return Current.RELATION_A01 == null;
                    case 19: // RELATION_A02
                        return Current.RELATION_A02 == null;
                    case 20: // CONTACT_A
                        return Current.CONTACT_A == null;
                    case 21: // FAMB
                        return Current.FAMB == null;
                    case 22: // FAMB_DUP
                        return Current.FAMB_DUP == null;
                    case 23: // FAMB_DUP_ACT
                        return Current.FAMB_DUP_ACT == null;
                    case 24: // ACADEMIC_B
                        return Current.ACADEMIC_B == null;
                    case 25: // LIVING_B
                        return Current.LIVING_B == null;
                    case 26: // RELATION_B01
                        return Current.RELATION_B01 == null;
                    case 27: // RELATION_B02
                        return Current.RELATION_B02 == null;
                    case 28: // CONTACT_B
                        return Current.CONTACT_B == null;
                    case 29: // FAMC
                        return Current.FAMC == null;
                    case 30: // FAMC_DUP
                        return Current.FAMC_DUP == null;
                    case 31: // FAMC_DUP_ACT
                        return Current.FAMC_DUP_ACT == null;
                    case 32: // ACADEMIC_C
                        return Current.ACADEMIC_C == null;
                    case 33: // LIVING_C
                        return Current.LIVING_C == null;
                    case 34: // RELATION_C01
                        return Current.RELATION_C01 == null;
                    case 35: // RELATION_C02
                        return Current.RELATION_C02 == null;
                    case 36: // CONTACT_C
                        return Current.CONTACT_C == null;
                    case 37: // LIVING_ARR
                        return Current.LIVING_ARR == null;
                    case 38: // E_MAIL
                        return Current.E_MAIL == null;
                    case 39: // MOBILE
                        return Current.MOBILE == null;
                    case 40: // MAP_TYPE
                        return Current.MAP_TYPE == null;
                    case 41: // MAP_NUM
                        return Current.MAP_NUM == null;
                    case 42: // X_AXIS
                        return Current.X_AXIS == null;
                    case 43: // Y_AXIS
                        return Current.Y_AXIS == null;
                    case 44: // GENDER
                        return Current.GENDER == null;
                    case 45: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 46: // PROOF_DOB
                        return Current.PROOF_DOB == null;
                    case 47: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS == null;
                    case 48: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS == null;
                    case 49: // ARRIVAL
                        return Current.ARRIVAL == null;
                    case 50: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL == null;
                    case 51: // INTEGRATION
                        return Current.INTEGRATION == null;
                    case 52: // FAM_ORDER
                        return Current.FAM_ORDER == null;
                    case 53: // SGB_FUNDED
                        return Current.SGB_FUNDED == null;
                    case 54: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 55: // SCHOOL_YEAR_NEW
                        return Current.SCHOOL_YEAR_NEW == null;
                    case 56: // HOME_GROUP_NEW
                        return Current.HOME_GROUP_NEW == null;
                    case 57: // RELIGION
                        return Current.RELIGION == null;
                    case 58: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS == null;
                    case 59: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE == null;
                    case 60: // VISA_EXPIRY
                        return Current.VISA_EXPIRY == null;
                    case 61: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY == null;
                    case 62: // ENG_SPEAK
                        return Current.ENG_SPEAK == null;
                    case 63: // HOME_LANG
                        return Current.HOME_LANG == null;
                    case 64: // OVERSEAS
                        return Current.OVERSEAS == null;
                    case 65: // KOORIE
                        return Current.KOORIE == null;
                    case 66: // ACCESS
                        return Current.ACCESS == null;
                    case 67: // ACCESS_TYPE
                        return Current.ACCESS_TYPE == null;
                    case 68: // ACCESS_ALERT
                        return Current.ACCESS_ALERT == null;
                    case 69: // RISK_ALERT
                        return Current.RISK_ALERT == null;
                    case 70: // RISK_MEMO
                        return Current.RISK_MEMO == null;
                    case 71: // DOCTOR
                        return Current.DOCTOR == null;
                    case 72: // EMERG_NAME01
                        return Current.EMERG_NAME01 == null;
                    case 73: // EMERG_NAME02
                        return Current.EMERG_NAME02 == null;
                    case 74: // EMERG_LANG01
                        return Current.EMERG_LANG01 == null;
                    case 75: // EMERG_LANG02
                        return Current.EMERG_LANG02 == null;
                    case 76: // EMERG_RELATION01
                        return Current.EMERG_RELATION01 == null;
                    case 77: // EMERG_RELATION02
                        return Current.EMERG_RELATION02 == null;
                    case 78: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01 == null;
                    case 79: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02 == null;
                    case 80: // EMERG_CONTACT_MEMO01
                        return Current.EMERG_CONTACT_MEMO01 == null;
                    case 81: // EMERG_CONTACT_MEMO02
                        return Current.EMERG_CONTACT_MEMO02 == null;
                    case 82: // ACC_DECLARATION
                        return Current.ACC_DECLARATION == null;
                    case 83: // MEDICARE_NO
                        return Current.MEDICARE_NO == null;
                    case 84: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID == null;
                    case 85: // MEDICAL_ALERT
                        return Current.MEDICAL_ALERT == null;
                    case 86: // HEARING_IMPAIR
                        return Current.HEARING_IMPAIR == null;
                    case 87: // VISUAL_IMPAIR
                        return Current.VISUAL_IMPAIR == null;
                    case 88: // SPEECH_IMPAIR
                        return Current.SPEECH_IMPAIR == null;
                    case 89: // PHYSICAL_IMPAIR
                        return Current.PHYSICAL_IMPAIR == null;
                    case 90: // MEDICAL_CONDITION
                        return Current.MEDICAL_CONDITION == null;
                    case 91: // ACTIVITY_RESTRICTION
                        return Current.ACTIVITY_RESTRICTION == null;
                    case 92: // IMMUNISE_CERT_STATUS
                        return Current.IMMUNISE_CERT_STATUS == null;
                    case 93: // IMMUN_CERT_SIGHTED
                        return Current.IMMUN_CERT_SIGHTED == null;
                    case 94: // IMMUNISE_PERMISSION
                        return Current.IMMUNISE_PERMISSION == null;
                    case 95: // IMMUNIZE
                        return Current.IMMUNIZE == null;
                    case 96: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH == null;
                    case 97: // PIC_LW_DATE
                        return Current.PIC_LW_DATE == null;
                    case 98: // PIC_STATUS
                        return Current.PIC_STATUS == null;
                    case 99: // YEARS_PREVIOUS_EDUCATION
                        return Current.YEARS_PREVIOUS_EDUCATION == null;
                    case 100: // YEARS_INTERRUPTION_EDUCATION
                        return Current.YEARS_INTERRUPTION_EDUCATION == null;
                    case 101: // LANGUAGE_PREVIOUS_SCHOOLING
                        return Current.LANGUAGE_PREVIOUS_SCHOOLING == null;
                    case 102: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE == null;
                    case 103: // VSN
                        return Current.VSN == null;
                    case 104: // SPEC_CURR
                        return Current.SPEC_CURR == null;
                    case 105: // LEGAL_LIMIT_DECISION
                        return Current.LEGAL_LIMIT_DECISION == null;
                    case 106: // LEGAL_LIMIT_CONTACT
                        return Current.LEGAL_LIMIT_CONTACT == null;
                    case 107: // LEGAL_LIMITATION
                        return Current.LEGAL_LIMITATION == null;
                    case 108: // DOC_COPIES
                        return Current.DOC_COPIES == null;
                    case 109: // LISTED_IN_SOCS
                        return Current.LISTED_IN_SOCS == null;
                    case 110: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES == null;
                    case 111: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT == null;
                    case 112: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT == null;
                    case 113: // SUPPORT_GROUP
                        return Current.SUPPORT_GROUP == null;
                    case 114: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION == null;
                    case 115: // ATTENDANCE_CONCERNS
                        return Current.ATTENDANCE_CONCERNS == null;
                    case 116: // DISCIPLINARY_ACTION
                        return Current.DISCIPLINARY_ACTION == null;
                    case 117: // WELFARE_RISKS
                        return Current.WELFARE_RISKS == null;
                    case 118: // EFFORT
                        return Current.EFFORT == null;
                    case 119: // CLASS_BEHAVIOUR
                        return Current.CLASS_BEHAVIOUR == null;
                    case 120: // ORGANISATION
                        return Current.ORGANISATION == null;
                    case 121: // SOCIAL_BEHAVIOUR
                        return Current.SOCIAL_BEHAVIOUR == null;
                    case 122: // LEARNING_SUPPORT
                        return Current.LEARNING_SUPPORT == null;
                    case 123: // NEW_ARRIVALS_PROGRAM
                        return Current.NEW_ARRIVALS_PROGRAM == null;
                    case 124: // REFUGEE_BACKGROUND
                        return Current.REFUGEE_BACKGROUND == null;
                    case 125: // TRANSFER_DOCS_SENT
                        return Current.TRANSFER_DOCS_SENT == null;
                    case 126: // ENTRY
                        return Current.ENTRY == null;
                    case 127: // VET
                        return Current.VET == null;
                    case 128: // USI
                        return Current.USI == null;
                    case 129: // TEACHER_RECOMMENDATION
                        return Current.TEACHER_RECOMMENDATION == null;
                    case 130: // TRANSITION_STATEMENT
                        return Current.TRANSITION_STATEMENT == null;
                    case 131: // FIRST_REG_NO
                        return Current.FIRST_REG_NO == null;
                    case 132: // DISABILITY
                        return Current.DISABILITY == null;
                    case 133: // DISABILITY_ID
                        return Current.DISABILITY_ID == null;
                    case 134: // CRIS_ID
                        return Current.CRIS_ID == null;
                    case 135: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION == null;
                    case 136: // ACTUAL_TIME_FRACTION_NEW
                        return Current.ACTUAL_TIME_FRACTION_NEW == null;
                    case 137: // YOUNG_CARER
                        return Current.YOUNG_CARER == null;
                    case 138: // GENDER_DESC
                        return Current.GENDER_DESC == null;
                    case 139: // MYLNS_LITERACY
                        return Current.MYLNS_LITERACY == null;
                    case 140: // MYLNS_NUMERACY
                        return Current.MYLNS_NUMERACY == null;
                    case 141: // DFA_TRANS_ID
                        return Current.DFA_TRANS_ID == null;
                    case 142: // DFB_TRANS_ID
                        return Current.DFB_TRANS_ID == null;
                    case 143: // DFC_TRANS_ID
                        return Current.DFC_TRANS_ID == null;
                    case 144: // KCD_TRANS_ID
                        return Current.KCD_TRANS_ID == null;
                    case 145: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 146: // IMP_DATE
                        return Current.IMP_DATE == null;
                    case 147: // STUDENT_SI_ID
                        return Current.STUDENT_SI_ID == null;
                    case 148: // ENROLMENT_SI_ID
                        return Current.ENROLMENT_SI_ID == null;
                    case 149: // APPLICATION_SI_ID
                        return Current.APPLICATION_SI_ID == null;
                    case 150: // LW_DATE
                        return Current.LW_DATE == null;
                    case 151: // LW_TIME
                        return Current.LW_TIME == null;
                    case 152: // LW_USER
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
                    case 5: // STKEY_DUP
                        return "STKEY_DUP";
                    case 6: // STKEY_DUP_ACT
                        return "STKEY_DUP_ACT";
                    case 7: // DUP_FAMILY
                        return "DUP_FAMILY";
                    case 8: // SURNAME
                        return "SURNAME";
                    case 9: // FIRST_NAME
                        return "FIRST_NAME";
                    case 10: // SECOND_NAME
                        return "SECOND_NAME";
                    case 11: // PREF_NAME
                        return "PREF_NAME";
                    case 12: // TITLE
                        return "TITLE";
                    case 13: // FAMILY
                        return "FAMILY";
                    case 14: // FAMILY_DUP
                        return "FAMILY_DUP";
                    case 15: // FAMILY_DUP_ACT
                        return "FAMILY_DUP_ACT";
                    case 16: // ACADEMIC_A
                        return "ACADEMIC_A";
                    case 17: // LIVING_A
                        return "LIVING_A";
                    case 18: // RELATION_A01
                        return "RELATION_A01";
                    case 19: // RELATION_A02
                        return "RELATION_A02";
                    case 20: // CONTACT_A
                        return "CONTACT_A";
                    case 21: // FAMB
                        return "FAMB";
                    case 22: // FAMB_DUP
                        return "FAMB_DUP";
                    case 23: // FAMB_DUP_ACT
                        return "FAMB_DUP_ACT";
                    case 24: // ACADEMIC_B
                        return "ACADEMIC_B";
                    case 25: // LIVING_B
                        return "LIVING_B";
                    case 26: // RELATION_B01
                        return "RELATION_B01";
                    case 27: // RELATION_B02
                        return "RELATION_B02";
                    case 28: // CONTACT_B
                        return "CONTACT_B";
                    case 29: // FAMC
                        return "FAMC";
                    case 30: // FAMC_DUP
                        return "FAMC_DUP";
                    case 31: // FAMC_DUP_ACT
                        return "FAMC_DUP_ACT";
                    case 32: // ACADEMIC_C
                        return "ACADEMIC_C";
                    case 33: // LIVING_C
                        return "LIVING_C";
                    case 34: // RELATION_C01
                        return "RELATION_C01";
                    case 35: // RELATION_C02
                        return "RELATION_C02";
                    case 36: // CONTACT_C
                        return "CONTACT_C";
                    case 37: // LIVING_ARR
                        return "LIVING_ARR";
                    case 38: // E_MAIL
                        return "E_MAIL";
                    case 39: // MOBILE
                        return "MOBILE";
                    case 40: // MAP_TYPE
                        return "MAP_TYPE";
                    case 41: // MAP_NUM
                        return "MAP_NUM";
                    case 42: // X_AXIS
                        return "X_AXIS";
                    case 43: // Y_AXIS
                        return "Y_AXIS";
                    case 44: // GENDER
                        return "GENDER";
                    case 45: // BIRTHDATE
                        return "BIRTHDATE";
                    case 46: // PROOF_DOB
                        return "PROOF_DOB";
                    case 47: // RESIDENT_STATUS
                        return "RESIDENT_STATUS";
                    case 48: // PERMANENT_BASIS
                        return "PERMANENT_BASIS";
                    case 49: // ARRIVAL
                        return "ARRIVAL";
                    case 50: // AUSSIE_SCHOOL
                        return "AUSSIE_SCHOOL";
                    case 51: // INTEGRATION
                        return "INTEGRATION";
                    case 52: // FAM_ORDER
                        return "FAM_ORDER";
                    case 53: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 54: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 55: // SCHOOL_YEAR_NEW
                        return "SCHOOL_YEAR_NEW";
                    case 56: // HOME_GROUP_NEW
                        return "HOME_GROUP_NEW";
                    case 57: // RELIGION
                        return "RELIGION";
                    case 58: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 59: // VISA_STAT_CODE
                        return "VISA_STAT_CODE";
                    case 60: // VISA_EXPIRY
                        return "VISA_EXPIRY";
                    case 61: // BIRTH_COUNTRY
                        return "BIRTH_COUNTRY";
                    case 62: // ENG_SPEAK
                        return "ENG_SPEAK";
                    case 63: // HOME_LANG
                        return "HOME_LANG";
                    case 64: // OVERSEAS
                        return "OVERSEAS";
                    case 65: // KOORIE
                        return "KOORIE";
                    case 66: // ACCESS
                        return "ACCESS";
                    case 67: // ACCESS_TYPE
                        return "ACCESS_TYPE";
                    case 68: // ACCESS_ALERT
                        return "ACCESS_ALERT";
                    case 69: // RISK_ALERT
                        return "RISK_ALERT";
                    case 70: // RISK_MEMO
                        return "RISK_MEMO";
                    case 71: // DOCTOR
                        return "DOCTOR";
                    case 72: // EMERG_NAME01
                        return "EMERG_NAME01";
                    case 73: // EMERG_NAME02
                        return "EMERG_NAME02";
                    case 74: // EMERG_LANG01
                        return "EMERG_LANG01";
                    case 75: // EMERG_LANG02
                        return "EMERG_LANG02";
                    case 76: // EMERG_RELATION01
                        return "EMERG_RELATION01";
                    case 77: // EMERG_RELATION02
                        return "EMERG_RELATION02";
                    case 78: // EMERG_CONTACT01
                        return "EMERG_CONTACT01";
                    case 79: // EMERG_CONTACT02
                        return "EMERG_CONTACT02";
                    case 80: // EMERG_CONTACT_MEMO01
                        return "EMERG_CONTACT_MEMO01";
                    case 81: // EMERG_CONTACT_MEMO02
                        return "EMERG_CONTACT_MEMO02";
                    case 82: // ACC_DECLARATION
                        return "ACC_DECLARATION";
                    case 83: // MEDICARE_NO
                        return "MEDICARE_NO";
                    case 84: // INTERNATIONAL_ST_ID
                        return "INTERNATIONAL_ST_ID";
                    case 85: // MEDICAL_ALERT
                        return "MEDICAL_ALERT";
                    case 86: // HEARING_IMPAIR
                        return "HEARING_IMPAIR";
                    case 87: // VISUAL_IMPAIR
                        return "VISUAL_IMPAIR";
                    case 88: // SPEECH_IMPAIR
                        return "SPEECH_IMPAIR";
                    case 89: // PHYSICAL_IMPAIR
                        return "PHYSICAL_IMPAIR";
                    case 90: // MEDICAL_CONDITION
                        return "MEDICAL_CONDITION";
                    case 91: // ACTIVITY_RESTRICTION
                        return "ACTIVITY_RESTRICTION";
                    case 92: // IMMUNISE_CERT_STATUS
                        return "IMMUNISE_CERT_STATUS";
                    case 93: // IMMUN_CERT_SIGHTED
                        return "IMMUN_CERT_SIGHTED";
                    case 94: // IMMUNISE_PERMISSION
                        return "IMMUNISE_PERMISSION";
                    case 95: // IMMUNIZE
                        return "IMMUNIZE";
                    case 96: // OK_TO_PUBLISH
                        return "OK_TO_PUBLISH";
                    case 97: // PIC_LW_DATE
                        return "PIC_LW_DATE";
                    case 98: // PIC_STATUS
                        return "PIC_STATUS";
                    case 99: // YEARS_PREVIOUS_EDUCATION
                        return "YEARS_PREVIOUS_EDUCATION";
                    case 100: // YEARS_INTERRUPTION_EDUCATION
                        return "YEARS_INTERRUPTION_EDUCATION";
                    case 101: // LANGUAGE_PREVIOUS_SCHOOLING
                        return "LANGUAGE_PREVIOUS_SCHOOLING";
                    case 102: // LOTE_HOME_CODE
                        return "LOTE_HOME_CODE";
                    case 103: // VSN
                        return "VSN";
                    case 104: // SPEC_CURR
                        return "SPEC_CURR";
                    case 105: // LEGAL_LIMIT_DECISION
                        return "LEGAL_LIMIT_DECISION";
                    case 106: // LEGAL_LIMIT_CONTACT
                        return "LEGAL_LIMIT_CONTACT";
                    case 107: // LEGAL_LIMITATION
                        return "LEGAL_LIMITATION";
                    case 108: // DOC_COPIES
                        return "DOC_COPIES";
                    case 109: // LISTED_IN_SOCS
                        return "LISTED_IN_SOCS";
                    case 110: // SUPPORT_SERVICES
                        return "SUPPORT_SERVICES";
                    case 111: // STUDENT_SUPPORT
                        return "STUDENT_SUPPORT";
                    case 112: // STUDENT_OTHER_SUPPORT
                        return "STUDENT_OTHER_SUPPORT";
                    case 113: // SUPPORT_GROUP
                        return "SUPPORT_GROUP";
                    case 114: // CHILD_PROTECTION
                        return "CHILD_PROTECTION";
                    case 115: // ATTENDANCE_CONCERNS
                        return "ATTENDANCE_CONCERNS";
                    case 116: // DISCIPLINARY_ACTION
                        return "DISCIPLINARY_ACTION";
                    case 117: // WELFARE_RISKS
                        return "WELFARE_RISKS";
                    case 118: // EFFORT
                        return "EFFORT";
                    case 119: // CLASS_BEHAVIOUR
                        return "CLASS_BEHAVIOUR";
                    case 120: // ORGANISATION
                        return "ORGANISATION";
                    case 121: // SOCIAL_BEHAVIOUR
                        return "SOCIAL_BEHAVIOUR";
                    case 122: // LEARNING_SUPPORT
                        return "LEARNING_SUPPORT";
                    case 123: // NEW_ARRIVALS_PROGRAM
                        return "NEW_ARRIVALS_PROGRAM";
                    case 124: // REFUGEE_BACKGROUND
                        return "REFUGEE_BACKGROUND";
                    case 125: // TRANSFER_DOCS_SENT
                        return "TRANSFER_DOCS_SENT";
                    case 126: // ENTRY
                        return "ENTRY";
                    case 127: // VET
                        return "VET";
                    case 128: // USI
                        return "USI";
                    case 129: // TEACHER_RECOMMENDATION
                        return "TEACHER_RECOMMENDATION";
                    case 130: // TRANSITION_STATEMENT
                        return "TRANSITION_STATEMENT";
                    case 131: // FIRST_REG_NO
                        return "FIRST_REG_NO";
                    case 132: // DISABILITY
                        return "DISABILITY";
                    case 133: // DISABILITY_ID
                        return "DISABILITY_ID";
                    case 134: // CRIS_ID
                        return "CRIS_ID";
                    case 135: // ACTUAL_TIME_FRACTION
                        return "ACTUAL_TIME_FRACTION";
                    case 136: // ACTUAL_TIME_FRACTION_NEW
                        return "ACTUAL_TIME_FRACTION_NEW";
                    case 137: // YOUNG_CARER
                        return "YOUNG_CARER";
                    case 138: // GENDER_DESC
                        return "GENDER_DESC";
                    case 139: // MYLNS_LITERACY
                        return "MYLNS_LITERACY";
                    case 140: // MYLNS_NUMERACY
                        return "MYLNS_NUMERACY";
                    case 141: // DFA_TRANS_ID
                        return "DFA_TRANS_ID";
                    case 142: // DFB_TRANS_ID
                        return "DFB_TRANS_ID";
                    case 143: // DFC_TRANS_ID
                        return "DFC_TRANS_ID";
                    case 144: // KCD_TRANS_ID
                        return "KCD_TRANS_ID";
                    case 145: // IMP_STATUS
                        return "IMP_STATUS";
                    case 146: // IMP_DATE
                        return "IMP_DATE";
                    case 147: // STUDENT_SI_ID
                        return "STUDENT_SI_ID";
                    case 148: // ENROLMENT_SI_ID
                        return "ENROLMENT_SI_ID";
                    case 149: // APPLICATION_SI_ID
                        return "APPLICATION_SI_ID";
                    case 150: // LW_DATE
                        return "LW_DATE";
                    case 151: // LW_TIME
                        return "LW_TIME";
                    case 152: // LW_USER
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
                    case "STKEY_DUP":
                        return 5;
                    case "STKEY_DUP_ACT":
                        return 6;
                    case "DUP_FAMILY":
                        return 7;
                    case "SURNAME":
                        return 8;
                    case "FIRST_NAME":
                        return 9;
                    case "SECOND_NAME":
                        return 10;
                    case "PREF_NAME":
                        return 11;
                    case "TITLE":
                        return 12;
                    case "FAMILY":
                        return 13;
                    case "FAMILY_DUP":
                        return 14;
                    case "FAMILY_DUP_ACT":
                        return 15;
                    case "ACADEMIC_A":
                        return 16;
                    case "LIVING_A":
                        return 17;
                    case "RELATION_A01":
                        return 18;
                    case "RELATION_A02":
                        return 19;
                    case "CONTACT_A":
                        return 20;
                    case "FAMB":
                        return 21;
                    case "FAMB_DUP":
                        return 22;
                    case "FAMB_DUP_ACT":
                        return 23;
                    case "ACADEMIC_B":
                        return 24;
                    case "LIVING_B":
                        return 25;
                    case "RELATION_B01":
                        return 26;
                    case "RELATION_B02":
                        return 27;
                    case "CONTACT_B":
                        return 28;
                    case "FAMC":
                        return 29;
                    case "FAMC_DUP":
                        return 30;
                    case "FAMC_DUP_ACT":
                        return 31;
                    case "ACADEMIC_C":
                        return 32;
                    case "LIVING_C":
                        return 33;
                    case "RELATION_C01":
                        return 34;
                    case "RELATION_C02":
                        return 35;
                    case "CONTACT_C":
                        return 36;
                    case "LIVING_ARR":
                        return 37;
                    case "E_MAIL":
                        return 38;
                    case "MOBILE":
                        return 39;
                    case "MAP_TYPE":
                        return 40;
                    case "MAP_NUM":
                        return 41;
                    case "X_AXIS":
                        return 42;
                    case "Y_AXIS":
                        return 43;
                    case "GENDER":
                        return 44;
                    case "BIRTHDATE":
                        return 45;
                    case "PROOF_DOB":
                        return 46;
                    case "RESIDENT_STATUS":
                        return 47;
                    case "PERMANENT_BASIS":
                        return 48;
                    case "ARRIVAL":
                        return 49;
                    case "AUSSIE_SCHOOL":
                        return 50;
                    case "INTEGRATION":
                        return 51;
                    case "FAM_ORDER":
                        return 52;
                    case "SGB_FUNDED":
                        return 53;
                    case "SCHOOL_YEAR":
                        return 54;
                    case "SCHOOL_YEAR_NEW":
                        return 55;
                    case "HOME_GROUP_NEW":
                        return 56;
                    case "RELIGION":
                        return 57;
                    case "VISA_SUBCLASS":
                        return 58;
                    case "VISA_STAT_CODE":
                        return 59;
                    case "VISA_EXPIRY":
                        return 60;
                    case "BIRTH_COUNTRY":
                        return 61;
                    case "ENG_SPEAK":
                        return 62;
                    case "HOME_LANG":
                        return 63;
                    case "OVERSEAS":
                        return 64;
                    case "KOORIE":
                        return 65;
                    case "ACCESS":
                        return 66;
                    case "ACCESS_TYPE":
                        return 67;
                    case "ACCESS_ALERT":
                        return 68;
                    case "RISK_ALERT":
                        return 69;
                    case "RISK_MEMO":
                        return 70;
                    case "DOCTOR":
                        return 71;
                    case "EMERG_NAME01":
                        return 72;
                    case "EMERG_NAME02":
                        return 73;
                    case "EMERG_LANG01":
                        return 74;
                    case "EMERG_LANG02":
                        return 75;
                    case "EMERG_RELATION01":
                        return 76;
                    case "EMERG_RELATION02":
                        return 77;
                    case "EMERG_CONTACT01":
                        return 78;
                    case "EMERG_CONTACT02":
                        return 79;
                    case "EMERG_CONTACT_MEMO01":
                        return 80;
                    case "EMERG_CONTACT_MEMO02":
                        return 81;
                    case "ACC_DECLARATION":
                        return 82;
                    case "MEDICARE_NO":
                        return 83;
                    case "INTERNATIONAL_ST_ID":
                        return 84;
                    case "MEDICAL_ALERT":
                        return 85;
                    case "HEARING_IMPAIR":
                        return 86;
                    case "VISUAL_IMPAIR":
                        return 87;
                    case "SPEECH_IMPAIR":
                        return 88;
                    case "PHYSICAL_IMPAIR":
                        return 89;
                    case "MEDICAL_CONDITION":
                        return 90;
                    case "ACTIVITY_RESTRICTION":
                        return 91;
                    case "IMMUNISE_CERT_STATUS":
                        return 92;
                    case "IMMUN_CERT_SIGHTED":
                        return 93;
                    case "IMMUNISE_PERMISSION":
                        return 94;
                    case "IMMUNIZE":
                        return 95;
                    case "OK_TO_PUBLISH":
                        return 96;
                    case "PIC_LW_DATE":
                        return 97;
                    case "PIC_STATUS":
                        return 98;
                    case "YEARS_PREVIOUS_EDUCATION":
                        return 99;
                    case "YEARS_INTERRUPTION_EDUCATION":
                        return 100;
                    case "LANGUAGE_PREVIOUS_SCHOOLING":
                        return 101;
                    case "LOTE_HOME_CODE":
                        return 102;
                    case "VSN":
                        return 103;
                    case "SPEC_CURR":
                        return 104;
                    case "LEGAL_LIMIT_DECISION":
                        return 105;
                    case "LEGAL_LIMIT_CONTACT":
                        return 106;
                    case "LEGAL_LIMITATION":
                        return 107;
                    case "DOC_COPIES":
                        return 108;
                    case "LISTED_IN_SOCS":
                        return 109;
                    case "SUPPORT_SERVICES":
                        return 110;
                    case "STUDENT_SUPPORT":
                        return 111;
                    case "STUDENT_OTHER_SUPPORT":
                        return 112;
                    case "SUPPORT_GROUP":
                        return 113;
                    case "CHILD_PROTECTION":
                        return 114;
                    case "ATTENDANCE_CONCERNS":
                        return 115;
                    case "DISCIPLINARY_ACTION":
                        return 116;
                    case "WELFARE_RISKS":
                        return 117;
                    case "EFFORT":
                        return 118;
                    case "CLASS_BEHAVIOUR":
                        return 119;
                    case "ORGANISATION":
                        return 120;
                    case "SOCIAL_BEHAVIOUR":
                        return 121;
                    case "LEARNING_SUPPORT":
                        return 122;
                    case "NEW_ARRIVALS_PROGRAM":
                        return 123;
                    case "REFUGEE_BACKGROUND":
                        return 124;
                    case "TRANSFER_DOCS_SENT":
                        return 125;
                    case "ENTRY":
                        return 126;
                    case "VET":
                        return 127;
                    case "USI":
                        return 128;
                    case "TEACHER_RECOMMENDATION":
                        return 129;
                    case "TRANSITION_STATEMENT":
                        return 130;
                    case "FIRST_REG_NO":
                        return 131;
                    case "DISABILITY":
                        return 132;
                    case "DISABILITY_ID":
                        return 133;
                    case "CRIS_ID":
                        return 134;
                    case "ACTUAL_TIME_FRACTION":
                        return 135;
                    case "ACTUAL_TIME_FRACTION_NEW":
                        return 136;
                    case "YOUNG_CARER":
                        return 137;
                    case "GENDER_DESC":
                        return 138;
                    case "MYLNS_LITERACY":
                        return 139;
                    case "MYLNS_NUMERACY":
                        return 140;
                    case "DFA_TRANS_ID":
                        return 141;
                    case "DFB_TRANS_ID":
                        return 142;
                    case "DFC_TRANS_ID":
                        return 143;
                    case "KCD_TRANS_ID":
                        return 144;
                    case "IMP_STATUS":
                        return 145;
                    case "IMP_DATE":
                        return 146;
                    case "STUDENT_SI_ID":
                        return 147;
                    case "ENROLMENT_SI_ID":
                        return 148;
                    case "APPLICATION_SI_ID":
                        return 149;
                    case "LW_DATE":
                        return 150;
                    case "LW_TIME":
                        return 151;
                    case "LW_USER":
                        return 152;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
