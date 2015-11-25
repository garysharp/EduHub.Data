using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Students Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STDataSet : SetBase<ST>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "ST"; } }

        internal STDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_STKEY = new Lazy<Dictionary<string, ST>>(() => this.ToDictionary(i => i.STKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_FAMILY = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.FAMILY));
            Index_FAMB = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.FAMB));
            Index_FAMC = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.FAMC));
            Index_REGISTRATION = new Lazy<Dictionary<int, IReadOnlyList<ST>>>(() => this.ToGroupedDictionary(i => i.REGISTRATION));
            Index_PREVIOUS_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.PREVIOUS_SCHOOL));
            Index_TAG = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.TAG));
            Index_HOME_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.HOME_GROUP));
            Index_NEXT_HG = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_HG));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_HOUSE = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.HOUSE));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_RELIGION = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.RELIGION));
            Index_REL_INSTR = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.REL_INSTR));
            Index_VISA_SUBCLASS = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.VISA_SUBCLASS));
            Index_BIRTH_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY));
            Index_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANG));
            Index_DOCTOR = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.DOCTOR));
            Index_EMERG_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG01));
            Index_EMERG_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG02));
            Index_LANGUAGE_PREVIOUS_SCHOOLING = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.LANGUAGE_PREVIOUS_SCHOOLING));
            Index_NEXT_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_SCHOOL));
            Index_EXIT_CAT01 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_CAT01));
            Index_EXIT_CAT02 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_CAT02));
            Index_EXIT_DEST01 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_DEST01));
            Index_EXIT_DEST02 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_DEST02));
            Index_INAC_ABS_CODE = new Lazy<NullDictionary<short?, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.INAC_ABS_CODE));
            Index_LOTE_HOME_CODE = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.LOTE_HOME_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST" /> fields for each CSV column header</returns>
        protected override Action<ST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
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
                    case "DIST_SCHL":
                        mapper[i] = (e, v) => e.DIST_SCHL = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRANSPORT":
                        mapper[i] = (e, v) => e.TRANSPORT = v;
                        break;
                    case "CAR_REGO":
                        mapper[i] = (e, v) => e.CAR_REGO = v;
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
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = int.Parse(v);
                        break;
                    case "FIRST_REG_NO":
                        mapper[i] = (e, v) => e.FIRST_REG_NO = v;
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
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXIT_DATE":
                        mapper[i] = (e, v) => e.EXIT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                    case "DATELEFT":
                        mapper[i] = (e, v) => e.DATELEFT = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXPIRY_DATE":
                        mapper[i] = (e, v) => e.EXPIRY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ID_CARD_VALID":
                        mapper[i] = (e, v) => e.ID_CARD_VALID = v;
                        break;
                    case "PREVIOUS_SCHOOL":
                        mapper[i] = (e, v) => e.PREVIOUS_SCHOOL = v;
                        break;
                    case "FAM_ORDER":
                        mapper[i] = (e, v) => e.FAM_ORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "ED_ALLOW":
                        mapper[i] = (e, v) => e.ED_ALLOW = v;
                        break;
                    case "EMA_AMT1P":
                        mapper[i] = (e, v) => e.EMA_AMT1P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMA_AMT2P":
                        mapper[i] = (e, v) => e.EMA_AMT2P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CASES_EMA_ID":
                        mapper[i] = (e, v) => e.CASES_EMA_ID = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "TAG":
                        mapper[i] = (e, v) => e.TAG = v;
                        break;
                    case "ENROLMENT_YEAR":
                        mapper[i] = (e, v) => e.ENROLMENT_YEAR = v;
                        break;
                    case "ADV_SCHL_YR":
                        mapper[i] = (e, v) => e.ADV_SCHL_YR = v;
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "NEXT_HG":
                        mapper[i] = (e, v) => e.NEXT_HG = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LOCKER_NUM":
                        mapper[i] = (e, v) => e.LOCKER_NUM = v;
                        break;
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "REL_INSTR":
                        mapper[i] = (e, v) => e.REL_INSTR = v;
                        break;
                    case "VCE_ID":
                        mapper[i] = (e, v) => e.VCE_ID = v;
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
                    case "REPEAT":
                        mapper[i] = (e, v) => e.REPEAT = v;
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
                    case "YOUTH_ALLOW":
                        mapper[i] = (e, v) => e.YOUTH_ALLOW = v;
                        break;
                    case "AB_STUDY":
                        mapper[i] = (e, v) => e.AB_STUDY = v;
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
                    case "AMBULANCE_SUBSCRIBER":
                        mapper[i] = (e, v) => e.AMBULANCE_SUBSCRIBER = v;
                        break;
                    case "MEDICARE_NO":
                        mapper[i] = (e, v) => e.MEDICARE_NO = v;
                        break;
                    case "INTERNATIONAL_ST_ID":
                        mapper[i] = (e, v) => e.INTERNATIONAL_ST_ID = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "DISABILITY_ID":
                        mapper[i] = (e, v) => e.DISABILITY_ID = v;
                        break;
                    case "PSDREQ":
                        mapper[i] = (e, v) => e.PSDREQ = v;
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
                    case "DISABILITY_ADJUSTMENT_ASSESSED":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT_ASSESSED = v;
                        break;
                    case "DISABILITY_ADJUSTMENT":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT = v;
                        break;
                    case "DISABILITY_TYPE":
                        mapper[i] = (e, v) => e.DISABILITY_TYPE = v;
                        break;
                    case "DISABILITY_ADJUSTMENT_LEVEL":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT_LEVEL = v;
                        break;
                    case "DISABILITY_ADJUSTMENT_LW_DATE":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT_LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HEAD_LICE_CHECK":
                        mapper[i] = (e, v) => e.HEAD_LICE_CHECK = v;
                        break;
                    case "ANNUAL_TOT":
                        mapper[i] = (e, v) => e.ANNUAL_TOT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STUDENT_PIC":
                        mapper[i] = (e, v) => e.STUDENT_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "PUBLISH_PHOTO_MEDIA":
                        mapper[i] = (e, v) => e.PUBLISH_PHOTO_MEDIA = v;
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
                    case "LIBRARY_FLAG":
                        mapper[i] = (e, v) => e.LIBRARY_FLAG = v;
                        break;
                    case "REGISTRAR_FLAG":
                        mapper[i] = (e, v) => e.REGISTRAR_FLAG = v;
                        break;
                    case "CLEAR1_FLAG":
                        mapper[i] = (e, v) => e.CLEAR1_FLAG = v;
                        break;
                    case "CLEAR2_FLAG":
                        mapper[i] = (e, v) => e.CLEAR2_FLAG = v;
                        break;
                    case "CLEAR3_FLAG":
                        mapper[i] = (e, v) => e.CLEAR3_FLAG = v;
                        break;
                    case "CLEAR4_FLAG":
                        mapper[i] = (e, v) => e.CLEAR4_FLAG = v;
                        break;
                    case "CLEAR5_FLAG":
                        mapper[i] = (e, v) => e.CLEAR5_FLAG = v;
                        break;
                    case "CLEAR6_FLAG":
                        mapper[i] = (e, v) => e.CLEAR6_FLAG = v;
                        break;
                    case "AR_STATUS":
                        mapper[i] = (e, v) => e.AR_STATUS = v == null ? (short?)null : short.Parse(v);
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
                    case "NEXT_SCHOOL":
                        mapper[i] = (e, v) => e.NEXT_SCHOOL = v;
                        break;
                    case "EXIT_CAT01":
                        mapper[i] = (e, v) => e.EXIT_CAT01 = v;
                        break;
                    case "EXIT_CAT02":
                        mapper[i] = (e, v) => e.EXIT_CAT02 = v;
                        break;
                    case "EXIT_DEST01":
                        mapper[i] = (e, v) => e.EXIT_DEST01 = v;
                        break;
                    case "EXIT_DEST02":
                        mapper[i] = (e, v) => e.EXIT_DEST02 = v;
                        break;
                    case "EXIT_MODIFY_DATE01":
                        mapper[i] = (e, v) => e.EXIT_MODIFY_DATE01 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXIT_MODIFY_DATE02":
                        mapper[i] = (e, v) => e.EXIT_MODIFY_DATE02 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FULLTIME":
                        mapper[i] = (e, v) => e.FULLTIME = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DEST_ARRIVAL_DATE":
                        mapper[i] = (e, v) => e.DEST_ARRIVAL_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DEPARTURE_DATE":
                        mapper[i] = (e, v) => e.DEPARTURE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ARRIVED_DESTINATION":
                        mapper[i] = (e, v) => e.ARRIVED_DESTINATION = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NOTIFIED_DESTINATION":
                        mapper[i] = (e, v) => e.NOTIFIED_DESTINATION = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "VCE_NOTIFIED":
                        mapper[i] = (e, v) => e.VCE_NOTIFIED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXIT_FORM":
                        mapper[i] = (e, v) => e.EXIT_FORM = v;
                        break;
                    case "TRANSFER_FORM":
                        mapper[i] = (e, v) => e.TRANSFER_FORM = v;
                        break;
                    case "PARENTAL_APPROVAL_DATE":
                        mapper[i] = (e, v) => e.PARENTAL_APPROVAL_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PARENTAL_APPROVAL_NOTE":
                        mapper[i] = (e, v) => e.PARENTAL_APPROVAL_NOTE = v;
                        break;
                    case "DISASTER_EXIT_REASON":
                        mapper[i] = (e, v) => e.DISASTER_EXIT_REASON = v;
                        break;
                    case "ATTENDANCE_MEMO":
                        mapper[i] = (e, v) => e.ATTENDANCE_MEMO = v;
                        break;
                    case "ABS_HDAY_PERIOD":
                        mapper[i] = (e, v) => e.ABS_HDAY_PERIOD = v;
                        break;
                    case "STRE_FLAG":
                        mapper[i] = (e, v) => e.STRE_FLAG = v;
                        break;
                    case "PROMOTED":
                        mapper[i] = (e, v) => e.PROMOTED = v;
                        break;
                    case "INAC_ABS_CODE":
                        mapper[i] = (e, v) => e.INAC_ABS_CODE = v == null ? (short?)null : short.Parse(v);
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
                    case "TRANSITION_STATEMENT":
                        mapper[i] = (e, v) => e.TRANSITION_STATEMENT = v;
                        break;
                    case "TFR_PERMISSION":
                        mapper[i] = (e, v) => e.TFR_PERMISSION = v;
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

        private Lazy<Dictionary<string, ST>> Index_STKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<ST>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_FAMILY;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_FAMB;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_FAMC;
        private Lazy<Dictionary<int, IReadOnlyList<ST>>> Index_REGISTRATION;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_PREVIOUS_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_TAG;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_HOME_GROUP;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_NEXT_HG;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_SCHOOL_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_HOUSE;
        private Lazy<NullDictionary<int?, IReadOnlyList<ST>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_RELIGION;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_REL_INSTR;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_VISA_SUBCLASS;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_BIRTH_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_HOME_LANG;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_DOCTOR;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EMERG_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EMERG_LANG02;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_LANGUAGE_PREVIOUS_SCHOOLING;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_NEXT_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_CAT01;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_CAT02;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_DEST01;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_DEST02;
        private Lazy<NullDictionary<short?, IReadOnlyList<ST>>> Index_INAC_ABS_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_LOTE_HOME_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find ST by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find ST</param>
        /// <returns>Related ST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find ST by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find ST</param>
        /// <param name="Value">Related ST entity</param>
        /// <returns>True if the related ST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out ST Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find ST by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find ST</param>
        /// <returns>Related ST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST TryFindBySTKEY(string STKEY)
        {
            ST value;
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
        /// Find ST by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find ST by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<ST> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find ST by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<ST> value;
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
        /// Find ST by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByFAMILY(string FAMILY)
        {
            return Index_FAMILY.Value[FAMILY];
        }

        /// <summary>
        /// Attempt to find ST by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMILY(string FAMILY, out IReadOnlyList<ST> Value)
        {
            return Index_FAMILY.Value.TryGetValue(FAMILY, out Value);
        }

        /// <summary>
        /// Attempt to find ST by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByFAMILY(string FAMILY)
        {
            IReadOnlyList<ST> value;
            if (Index_FAMILY.Value.TryGetValue(FAMILY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by FAMB field
        /// </summary>
        /// <param name="FAMB">FAMB value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByFAMB(string FAMB)
        {
            return Index_FAMB.Value[FAMB];
        }

        /// <summary>
        /// Attempt to find ST by FAMB field
        /// </summary>
        /// <param name="FAMB">FAMB value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMB(string FAMB, out IReadOnlyList<ST> Value)
        {
            return Index_FAMB.Value.TryGetValue(FAMB, out Value);
        }

        /// <summary>
        /// Attempt to find ST by FAMB field
        /// </summary>
        /// <param name="FAMB">FAMB value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByFAMB(string FAMB)
        {
            IReadOnlyList<ST> value;
            if (Index_FAMB.Value.TryGetValue(FAMB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by FAMC field
        /// </summary>
        /// <param name="FAMC">FAMC value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByFAMC(string FAMC)
        {
            return Index_FAMC.Value[FAMC];
        }

        /// <summary>
        /// Attempt to find ST by FAMC field
        /// </summary>
        /// <param name="FAMC">FAMC value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMC(string FAMC, out IReadOnlyList<ST> Value)
        {
            return Index_FAMC.Value.TryGetValue(FAMC, out Value);
        }

        /// <summary>
        /// Attempt to find ST by FAMC field
        /// </summary>
        /// <param name="FAMC">FAMC value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByFAMC(string FAMC)
        {
            IReadOnlyList<ST> value;
            if (Index_FAMC.Value.TryGetValue(FAMC, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by REGISTRATION field
        /// </summary>
        /// <param name="REGISTRATION">REGISTRATION value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByREGISTRATION(int REGISTRATION)
        {
            return Index_REGISTRATION.Value[REGISTRATION];
        }

        /// <summary>
        /// Attempt to find ST by REGISTRATION field
        /// </summary>
        /// <param name="REGISTRATION">REGISTRATION value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREGISTRATION(int REGISTRATION, out IReadOnlyList<ST> Value)
        {
            return Index_REGISTRATION.Value.TryGetValue(REGISTRATION, out Value);
        }

        /// <summary>
        /// Attempt to find ST by REGISTRATION field
        /// </summary>
        /// <param name="REGISTRATION">REGISTRATION value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByREGISTRATION(int REGISTRATION)
        {
            IReadOnlyList<ST> value;
            if (Index_REGISTRATION.Value.TryGetValue(REGISTRATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by PREVIOUS_SCHOOL field
        /// </summary>
        /// <param name="PREVIOUS_SCHOOL">PREVIOUS_SCHOOL value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByPREVIOUS_SCHOOL(string PREVIOUS_SCHOOL)
        {
            return Index_PREVIOUS_SCHOOL.Value[PREVIOUS_SCHOOL];
        }

        /// <summary>
        /// Attempt to find ST by PREVIOUS_SCHOOL field
        /// </summary>
        /// <param name="PREVIOUS_SCHOOL">PREVIOUS_SCHOOL value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPREVIOUS_SCHOOL(string PREVIOUS_SCHOOL, out IReadOnlyList<ST> Value)
        {
            return Index_PREVIOUS_SCHOOL.Value.TryGetValue(PREVIOUS_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find ST by PREVIOUS_SCHOOL field
        /// </summary>
        /// <param name="PREVIOUS_SCHOOL">PREVIOUS_SCHOOL value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByPREVIOUS_SCHOOL(string PREVIOUS_SCHOOL)
        {
            IReadOnlyList<ST> value;
            if (Index_PREVIOUS_SCHOOL.Value.TryGetValue(PREVIOUS_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by TAG field
        /// </summary>
        /// <param name="TAG">TAG value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByTAG(string TAG)
        {
            return Index_TAG.Value[TAG];
        }

        /// <summary>
        /// Attempt to find ST by TAG field
        /// </summary>
        /// <param name="TAG">TAG value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTAG(string TAG, out IReadOnlyList<ST> Value)
        {
            return Index_TAG.Value.TryGetValue(TAG, out Value);
        }

        /// <summary>
        /// Attempt to find ST by TAG field
        /// </summary>
        /// <param name="TAG">TAG value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByTAG(string TAG)
        {
            IReadOnlyList<ST> value;
            if (Index_TAG.Value.TryGetValue(TAG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByHOME_GROUP(string HOME_GROUP)
        {
            return Index_HOME_GROUP.Value[HOME_GROUP];
        }

        /// <summary>
        /// Attempt to find ST by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_GROUP(string HOME_GROUP, out IReadOnlyList<ST> Value)
        {
            return Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find ST by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByHOME_GROUP(string HOME_GROUP)
        {
            IReadOnlyList<ST> value;
            if (Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByNEXT_HG(string NEXT_HG)
        {
            return Index_NEXT_HG.Value[NEXT_HG];
        }

        /// <summary>
        /// Attempt to find ST by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEXT_HG(string NEXT_HG, out IReadOnlyList<ST> Value)
        {
            return Index_NEXT_HG.Value.TryGetValue(NEXT_HG, out Value);
        }

        /// <summary>
        /// Attempt to find ST by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByNEXT_HG(string NEXT_HG)
        {
            IReadOnlyList<ST> value;
            if (Index_NEXT_HG.Value.TryGetValue(NEXT_HG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            return Index_SCHOOL_YEAR.Value[SCHOOL_YEAR];
        }

        /// <summary>
        /// Attempt to find ST by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL_YEAR(string SCHOOL_YEAR, out IReadOnlyList<ST> Value)
        {
            return Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find ST by SCHOOL_YEAR field
        /// </summary>
        /// <param name="SCHOOL_YEAR">SCHOOL_YEAR value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindBySCHOOL_YEAR(string SCHOOL_YEAR)
        {
            IReadOnlyList<ST> value;
            if (Index_SCHOOL_YEAR.Value.TryGetValue(SCHOOL_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByHOUSE(string HOUSE)
        {
            return Index_HOUSE.Value[HOUSE];
        }

        /// <summary>
        /// Attempt to find ST by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOUSE(string HOUSE, out IReadOnlyList<ST> Value)
        {
            return Index_HOUSE.Value.TryGetValue(HOUSE, out Value);
        }

        /// <summary>
        /// Attempt to find ST by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByHOUSE(string HOUSE)
        {
            IReadOnlyList<ST> value;
            if (Index_HOUSE.Value.TryGetValue(HOUSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find ST by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<ST> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find ST by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<ST> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByRELIGION(string RELIGION)
        {
            return Index_RELIGION.Value[RELIGION];
        }

        /// <summary>
        /// Attempt to find ST by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRELIGION(string RELIGION, out IReadOnlyList<ST> Value)
        {
            return Index_RELIGION.Value.TryGetValue(RELIGION, out Value);
        }

        /// <summary>
        /// Attempt to find ST by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByRELIGION(string RELIGION)
        {
            IReadOnlyList<ST> value;
            if (Index_RELIGION.Value.TryGetValue(RELIGION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by REL_INSTR field
        /// </summary>
        /// <param name="REL_INSTR">REL_INSTR value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByREL_INSTR(string REL_INSTR)
        {
            return Index_REL_INSTR.Value[REL_INSTR];
        }

        /// <summary>
        /// Attempt to find ST by REL_INSTR field
        /// </summary>
        /// <param name="REL_INSTR">REL_INSTR value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREL_INSTR(string REL_INSTR, out IReadOnlyList<ST> Value)
        {
            return Index_REL_INSTR.Value.TryGetValue(REL_INSTR, out Value);
        }

        /// <summary>
        /// Attempt to find ST by REL_INSTR field
        /// </summary>
        /// <param name="REL_INSTR">REL_INSTR value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByREL_INSTR(string REL_INSTR)
        {
            IReadOnlyList<ST> value;
            if (Index_REL_INSTR.Value.TryGetValue(REL_INSTR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            return Index_VISA_SUBCLASS.Value[VISA_SUBCLASS];
        }

        /// <summary>
        /// Attempt to find ST by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVISA_SUBCLASS(string VISA_SUBCLASS, out IReadOnlyList<ST> Value)
        {
            return Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out Value);
        }

        /// <summary>
        /// Attempt to find ST by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            IReadOnlyList<ST> value;
            if (Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByBIRTH_COUNTRY(string BIRTH_COUNTRY)
        {
            return Index_BIRTH_COUNTRY.Value[BIRTH_COUNTRY];
        }

        /// <summary>
        /// Attempt to find ST by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBIRTH_COUNTRY(string BIRTH_COUNTRY, out IReadOnlyList<ST> Value)
        {
            return Index_BIRTH_COUNTRY.Value.TryGetValue(BIRTH_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find ST by BIRTH_COUNTRY field
        /// </summary>
        /// <param name="BIRTH_COUNTRY">BIRTH_COUNTRY value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByBIRTH_COUNTRY(string BIRTH_COUNTRY)
        {
            IReadOnlyList<ST> value;
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
        /// Find ST by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByHOME_LANG(string HOME_LANG)
        {
            return Index_HOME_LANG.Value[HOME_LANG];
        }

        /// <summary>
        /// Attempt to find ST by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_LANG(string HOME_LANG, out IReadOnlyList<ST> Value)
        {
            return Index_HOME_LANG.Value.TryGetValue(HOME_LANG, out Value);
        }

        /// <summary>
        /// Attempt to find ST by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByHOME_LANG(string HOME_LANG)
        {
            IReadOnlyList<ST> value;
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
        /// Find ST by DOCTOR field
        /// </summary>
        /// <param name="DOCTOR">DOCTOR value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByDOCTOR(string DOCTOR)
        {
            return Index_DOCTOR.Value[DOCTOR];
        }

        /// <summary>
        /// Attempt to find ST by DOCTOR field
        /// </summary>
        /// <param name="DOCTOR">DOCTOR value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDOCTOR(string DOCTOR, out IReadOnlyList<ST> Value)
        {
            return Index_DOCTOR.Value.TryGetValue(DOCTOR, out Value);
        }

        /// <summary>
        /// Attempt to find ST by DOCTOR field
        /// </summary>
        /// <param name="DOCTOR">DOCTOR value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByDOCTOR(string DOCTOR)
        {
            IReadOnlyList<ST> value;
            if (Index_DOCTOR.Value.TryGetValue(DOCTOR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByEMERG_LANG01(string EMERG_LANG01)
        {
            return Index_EMERG_LANG01.Value[EMERG_LANG01];
        }

        /// <summary>
        /// Attempt to find ST by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG01(string EMERG_LANG01, out IReadOnlyList<ST> Value)
        {
            return Index_EMERG_LANG01.Value.TryGetValue(EMERG_LANG01, out Value);
        }

        /// <summary>
        /// Attempt to find ST by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByEMERG_LANG01(string EMERG_LANG01)
        {
            IReadOnlyList<ST> value;
            if (Index_EMERG_LANG01.Value.TryGetValue(EMERG_LANG01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByEMERG_LANG02(string EMERG_LANG02)
        {
            return Index_EMERG_LANG02.Value[EMERG_LANG02];
        }

        /// <summary>
        /// Attempt to find ST by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG02(string EMERG_LANG02, out IReadOnlyList<ST> Value)
        {
            return Index_EMERG_LANG02.Value.TryGetValue(EMERG_LANG02, out Value);
        }

        /// <summary>
        /// Attempt to find ST by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByEMERG_LANG02(string EMERG_LANG02)
        {
            IReadOnlyList<ST> value;
            if (Index_EMERG_LANG02.Value.TryGetValue(EMERG_LANG02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by LANGUAGE_PREVIOUS_SCHOOLING field
        /// </summary>
        /// <param name="LANGUAGE_PREVIOUS_SCHOOLING">LANGUAGE_PREVIOUS_SCHOOLING value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByLANGUAGE_PREVIOUS_SCHOOLING(string LANGUAGE_PREVIOUS_SCHOOLING)
        {
            return Index_LANGUAGE_PREVIOUS_SCHOOLING.Value[LANGUAGE_PREVIOUS_SCHOOLING];
        }

        /// <summary>
        /// Attempt to find ST by LANGUAGE_PREVIOUS_SCHOOLING field
        /// </summary>
        /// <param name="LANGUAGE_PREVIOUS_SCHOOLING">LANGUAGE_PREVIOUS_SCHOOLING value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLANGUAGE_PREVIOUS_SCHOOLING(string LANGUAGE_PREVIOUS_SCHOOLING, out IReadOnlyList<ST> Value)
        {
            return Index_LANGUAGE_PREVIOUS_SCHOOLING.Value.TryGetValue(LANGUAGE_PREVIOUS_SCHOOLING, out Value);
        }

        /// <summary>
        /// Attempt to find ST by LANGUAGE_PREVIOUS_SCHOOLING field
        /// </summary>
        /// <param name="LANGUAGE_PREVIOUS_SCHOOLING">LANGUAGE_PREVIOUS_SCHOOLING value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByLANGUAGE_PREVIOUS_SCHOOLING(string LANGUAGE_PREVIOUS_SCHOOLING)
        {
            IReadOnlyList<ST> value;
            if (Index_LANGUAGE_PREVIOUS_SCHOOLING.Value.TryGetValue(LANGUAGE_PREVIOUS_SCHOOLING, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by NEXT_SCHOOL field
        /// </summary>
        /// <param name="NEXT_SCHOOL">NEXT_SCHOOL value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByNEXT_SCHOOL(string NEXT_SCHOOL)
        {
            return Index_NEXT_SCHOOL.Value[NEXT_SCHOOL];
        }

        /// <summary>
        /// Attempt to find ST by NEXT_SCHOOL field
        /// </summary>
        /// <param name="NEXT_SCHOOL">NEXT_SCHOOL value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEXT_SCHOOL(string NEXT_SCHOOL, out IReadOnlyList<ST> Value)
        {
            return Index_NEXT_SCHOOL.Value.TryGetValue(NEXT_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find ST by NEXT_SCHOOL field
        /// </summary>
        /// <param name="NEXT_SCHOOL">NEXT_SCHOOL value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByNEXT_SCHOOL(string NEXT_SCHOOL)
        {
            IReadOnlyList<ST> value;
            if (Index_NEXT_SCHOOL.Value.TryGetValue(NEXT_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by EXIT_CAT01 field
        /// </summary>
        /// <param name="EXIT_CAT01">EXIT_CAT01 value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByEXIT_CAT01(string EXIT_CAT01)
        {
            return Index_EXIT_CAT01.Value[EXIT_CAT01];
        }

        /// <summary>
        /// Attempt to find ST by EXIT_CAT01 field
        /// </summary>
        /// <param name="EXIT_CAT01">EXIT_CAT01 value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXIT_CAT01(string EXIT_CAT01, out IReadOnlyList<ST> Value)
        {
            return Index_EXIT_CAT01.Value.TryGetValue(EXIT_CAT01, out Value);
        }

        /// <summary>
        /// Attempt to find ST by EXIT_CAT01 field
        /// </summary>
        /// <param name="EXIT_CAT01">EXIT_CAT01 value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByEXIT_CAT01(string EXIT_CAT01)
        {
            IReadOnlyList<ST> value;
            if (Index_EXIT_CAT01.Value.TryGetValue(EXIT_CAT01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by EXIT_CAT02 field
        /// </summary>
        /// <param name="EXIT_CAT02">EXIT_CAT02 value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByEXIT_CAT02(string EXIT_CAT02)
        {
            return Index_EXIT_CAT02.Value[EXIT_CAT02];
        }

        /// <summary>
        /// Attempt to find ST by EXIT_CAT02 field
        /// </summary>
        /// <param name="EXIT_CAT02">EXIT_CAT02 value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXIT_CAT02(string EXIT_CAT02, out IReadOnlyList<ST> Value)
        {
            return Index_EXIT_CAT02.Value.TryGetValue(EXIT_CAT02, out Value);
        }

        /// <summary>
        /// Attempt to find ST by EXIT_CAT02 field
        /// </summary>
        /// <param name="EXIT_CAT02">EXIT_CAT02 value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByEXIT_CAT02(string EXIT_CAT02)
        {
            IReadOnlyList<ST> value;
            if (Index_EXIT_CAT02.Value.TryGetValue(EXIT_CAT02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by EXIT_DEST01 field
        /// </summary>
        /// <param name="EXIT_DEST01">EXIT_DEST01 value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByEXIT_DEST01(string EXIT_DEST01)
        {
            return Index_EXIT_DEST01.Value[EXIT_DEST01];
        }

        /// <summary>
        /// Attempt to find ST by EXIT_DEST01 field
        /// </summary>
        /// <param name="EXIT_DEST01">EXIT_DEST01 value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXIT_DEST01(string EXIT_DEST01, out IReadOnlyList<ST> Value)
        {
            return Index_EXIT_DEST01.Value.TryGetValue(EXIT_DEST01, out Value);
        }

        /// <summary>
        /// Attempt to find ST by EXIT_DEST01 field
        /// </summary>
        /// <param name="EXIT_DEST01">EXIT_DEST01 value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByEXIT_DEST01(string EXIT_DEST01)
        {
            IReadOnlyList<ST> value;
            if (Index_EXIT_DEST01.Value.TryGetValue(EXIT_DEST01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by EXIT_DEST02 field
        /// </summary>
        /// <param name="EXIT_DEST02">EXIT_DEST02 value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByEXIT_DEST02(string EXIT_DEST02)
        {
            return Index_EXIT_DEST02.Value[EXIT_DEST02];
        }

        /// <summary>
        /// Attempt to find ST by EXIT_DEST02 field
        /// </summary>
        /// <param name="EXIT_DEST02">EXIT_DEST02 value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXIT_DEST02(string EXIT_DEST02, out IReadOnlyList<ST> Value)
        {
            return Index_EXIT_DEST02.Value.TryGetValue(EXIT_DEST02, out Value);
        }

        /// <summary>
        /// Attempt to find ST by EXIT_DEST02 field
        /// </summary>
        /// <param name="EXIT_DEST02">EXIT_DEST02 value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByEXIT_DEST02(string EXIT_DEST02)
        {
            IReadOnlyList<ST> value;
            if (Index_EXIT_DEST02.Value.TryGetValue(EXIT_DEST02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by INAC_ABS_CODE field
        /// </summary>
        /// <param name="INAC_ABS_CODE">INAC_ABS_CODE value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByINAC_ABS_CODE(short? INAC_ABS_CODE)
        {
            return Index_INAC_ABS_CODE.Value[INAC_ABS_CODE];
        }

        /// <summary>
        /// Attempt to find ST by INAC_ABS_CODE field
        /// </summary>
        /// <param name="INAC_ABS_CODE">INAC_ABS_CODE value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINAC_ABS_CODE(short? INAC_ABS_CODE, out IReadOnlyList<ST> Value)
        {
            return Index_INAC_ABS_CODE.Value.TryGetValue(INAC_ABS_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find ST by INAC_ABS_CODE field
        /// </summary>
        /// <param name="INAC_ABS_CODE">INAC_ABS_CODE value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByINAC_ABS_CODE(short? INAC_ABS_CODE)
        {
            IReadOnlyList<ST> value;
            if (Index_INAC_ABS_CODE.Value.TryGetValue(INAC_ABS_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by LOTE_HOME_CODE field
        /// </summary>
        /// <param name="LOTE_HOME_CODE">LOTE_HOME_CODE value used to find ST</param>
        /// <returns>List of related ST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> FindByLOTE_HOME_CODE(string LOTE_HOME_CODE)
        {
            return Index_LOTE_HOME_CODE.Value[LOTE_HOME_CODE];
        }

        /// <summary>
        /// Attempt to find ST by LOTE_HOME_CODE field
        /// </summary>
        /// <param name="LOTE_HOME_CODE">LOTE_HOME_CODE value used to find ST</param>
        /// <param name="Value">List of related ST entities</param>
        /// <returns>True if the list of related ST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOTE_HOME_CODE(string LOTE_HOME_CODE, out IReadOnlyList<ST> Value)
        {
            return Index_LOTE_HOME_CODE.Value.TryGetValue(LOTE_HOME_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find ST by LOTE_HOME_CODE field
        /// </summary>
        /// <param name="LOTE_HOME_CODE">LOTE_HOME_CODE value used to find ST</param>
        /// <returns>List of related ST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST> TryFindByLOTE_HOME_CODE(string LOTE_HOME_CODE)
        {
            IReadOnlyList<ST> value;
            if (Index_LOTE_HOME_CODE.Value.TryGetValue(LOTE_HOME_CODE, out value))
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
