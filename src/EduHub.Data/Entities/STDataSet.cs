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
    /// Students Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STDataSet : EduHubDataSet<ST>
    {
        /// <inheritdoc />
        public override string Name { get { return "ST"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BIRTH_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_DOCTOR = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.DOCTOR));
            Index_EMERG_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG01));
            Index_EMERG_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG02));
            Index_EXIT_CAT01 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_CAT01));
            Index_EXIT_CAT02 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_CAT02));
            Index_EXIT_DEST01 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_DEST01));
            Index_EXIT_DEST02 = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.EXIT_DEST02));
            Index_FAMB = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.FAMB));
            Index_FAMC = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.FAMC));
            Index_FAMILY = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.FAMILY));
            Index_HOME_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.HOME_GROUP));
            Index_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANG));
            Index_HOUSE = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.HOUSE));
            Index_INAC_ABS_CODE = new Lazy<NullDictionary<short?, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.INAC_ABS_CODE));
            Index_LANGUAGE_PREVIOUS_SCHOOLING = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.LANGUAGE_PREVIOUS_SCHOOLING));
            Index_LOTE_HOME_CODE = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.LOTE_HOME_CODE));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_NEXT_HG = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_HG));
            Index_NEXT_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_SCHOOL));
            Index_PREVIOUS_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.PREVIOUS_SCHOOL));
            Index_REGISTRATION = new Lazy<Dictionary<int, ST>>(() => this.ToDictionary(i => i.REGISTRATION));
            Index_REL_INSTR = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.REL_INSTR));
            Index_RELIGION = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.RELIGION));
            Index_SCHOOL_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL_YEAR));
            Index_STKEY = new Lazy<Dictionary<string, ST>>(() => this.ToDictionary(i => i.STKEY));
            Index_TAG = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.TAG));
            Index_VISA_SUBCLASS = new Lazy<NullDictionary<string, IReadOnlyList<ST>>>(() => this.ToGroupedNullDictionary(i => i.VISA_SUBCLASS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST" /> fields for each CSV column header</returns>
        internal override Action<ST, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXIT_DATE":
                        mapper[i] = (e, v) => e.EXIT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                    case "DATELEFT":
                        mapper[i] = (e, v) => e.DATELEFT = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXPIRY_DATE":
                        mapper[i] = (e, v) => e.EXPIRY_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                    case "EMERG_CONTACT_MEMO01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO01 = v;
                        break;
                    case "EMERG_CONTACT_MEMO02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO02 = v;
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
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT_LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.PIC_LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.EXIT_MODIFY_DATE01 = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXIT_MODIFY_DATE02":
                        mapper[i] = (e, v) => e.EXIT_MODIFY_DATE02 = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.DEST_ARRIVAL_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DEPARTURE_DATE":
                        mapper[i] = (e, v) => e.DEPARTURE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ARRIVED_DESTINATION":
                        mapper[i] = (e, v) => e.ARRIVED_DESTINATION = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "NOTIFIED_DESTINATION":
                        mapper[i] = (e, v) => e.NOTIFIED_DESTINATION = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "VCE_NOTIFIED":
                        mapper[i] = (e, v) => e.VCE_NOTIFIED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXIT_FORM":
                        mapper[i] = (e, v) => e.EXIT_FORM = v;
                        break;
                    case "TRANSFER_FORM":
                        mapper[i] = (e, v) => e.TRANSFER_FORM = v;
                        break;
                    case "PARENTAL_APPROVAL_DATE":
                        mapper[i] = (e, v) => e.PARENTAL_APPROVAL_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                    case "VET":
                        mapper[i] = (e, v) => e.VET = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
                        break;
                    case "SCH_DEFINED01":
                        mapper[i] = (e, v) => e.SCH_DEFINED01 = v;
                        break;
                    case "SCH_DEFINED02":
                        mapper[i] = (e, v) => e.SCH_DEFINED02 = v;
                        break;
                    case "TEACHER_RECOMMENDATION":
                        mapper[i] = (e, v) => e.TEACHER_RECOMMENDATION = v;
                        break;
                    case "CRIS_ID":
                        mapper[i] = (e, v) => e.CRIS_ID = v;
                        break;
                    case "YOUNG_CARER":
                        mapper[i] = (e, v) => e.YOUNG_CARER = v;
                        break;
                    case "GENDER_DESC":
                        mapper[i] = (e, v) => e.GENDER_DESC = v;
                        break;
                    case "DET_TUTOR":
                        mapper[i] = (e, v) => e.DET_TUTOR = v;
                        break;
                    case "DET_TUTORNUM":
                        mapper[i] = (e, v) => e.DET_TUTORNUM = v;
                        break;
                    case "MYLNS_LITERACY":
                        mapper[i] = (e, v) => e.MYLNS_LITERACY = v;
                        break;
                    case "MYLNS_NUMERACY":
                        mapper[i] = (e, v) => e.MYLNS_NUMERACY = v;
                        break;
                    case "KLNP_LITERACY":
                        mapper[i] = (e, v) => e.KLNP_LITERACY = v;
                        break;
                    case "KLNP_NUMERACY":
                        mapper[i] = (e, v) => e.KLNP_NUMERACY = v;
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
                    case "FLO":
                        mapper[i] = (e, v) => e.FLO = v;
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
        /// Merges <see cref="ST" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="ST" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="ST" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{ST}"/> of entities</returns>
        internal override IEnumerable<ST> ApplyDeltaEntities(IEnumerable<ST> Entities, List<ST> DeltaEntities)
        {
            HashSet<int> Index_REGISTRATION = new HashSet<int>(DeltaEntities.Select(i => i.REGISTRATION));
            HashSet<string> Index_STKEY = new HashSet<string>(DeltaEntities.Select(i => i.STKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.STKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_REGISTRATION.Remove(entity.REGISTRATION);
                            overwritten = overwritten || Index_STKEY.Remove(entity.STKEY);
                            
                            if (entity.STKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_BIRTH_COUNTRY;
        private Lazy<NullDictionary<int?, IReadOnlyList<ST>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_DOCTOR;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EMERG_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EMERG_LANG02;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_CAT01;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_CAT02;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_DEST01;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_EXIT_DEST02;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_FAMB;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_FAMC;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_FAMILY;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_HOME_GROUP;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_HOME_LANG;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_HOUSE;
        private Lazy<NullDictionary<short?, IReadOnlyList<ST>>> Index_INAC_ABS_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_LANGUAGE_PREVIOUS_SCHOOLING;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_LOTE_HOME_CODE;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<ST>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_NEXT_HG;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_NEXT_SCHOOL;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_PREVIOUS_SCHOOL;
        private Lazy<Dictionary<int, ST>> Index_REGISTRATION;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_REL_INSTR;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_RELIGION;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_SCHOOL_YEAR;
        private Lazy<Dictionary<string, ST>> Index_STKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_TAG;
        private Lazy<NullDictionary<string, IReadOnlyList<ST>>> Index_VISA_SUBCLASS;

        #endregion

        #region Index Methods

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
        /// Find ST by REGISTRATION field
        /// </summary>
        /// <param name="REGISTRATION">REGISTRATION value used to find ST</param>
        /// <returns>Related ST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST FindByREGISTRATION(int REGISTRATION)
        {
            return Index_REGISTRATION.Value[REGISTRATION];
        }

        /// <summary>
        /// Attempt to find ST by REGISTRATION field
        /// </summary>
        /// <param name="REGISTRATION">REGISTRATION value used to find ST</param>
        /// <param name="Value">Related ST entity</param>
        /// <returns>True if the related ST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREGISTRATION(int REGISTRATION, out ST Value)
        {
            return Index_REGISTRATION.Value.TryGetValue(REGISTRATION, out Value);
        }

        /// <summary>
        /// Attempt to find ST by REGISTRATION field
        /// </summary>
        /// <param name="REGISTRATION">REGISTRATION value used to find ST</param>
        /// <returns>Related ST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST TryFindByREGISTRATION(int REGISTRATION)
        {
            ST value;
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

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a ST table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[ST](
        [STKEY] varchar(10) NOT NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [SECOND_NAME] varchar(20) NULL,
        [PREF_NAME] varchar(20) NULL,
        [TITLE] varchar(4) NULL,
        [FAMILY] varchar(10) NULL,
        [ACADEMIC_A] varchar(1) NULL,
        [LIVING_A] varchar(1) NULL,
        [RELATION_A01] varchar(20) NULL,
        [RELATION_A02] varchar(20) NULL,
        [CONTACT_A] varchar(1) NULL,
        [FAMB] varchar(10) NULL,
        [ACADEMIC_B] varchar(1) NULL,
        [LIVING_B] varchar(1) NULL,
        [RELATION_B01] varchar(20) NULL,
        [RELATION_B02] varchar(20) NULL,
        [CONTACT_B] varchar(1) NULL,
        [FAMC] varchar(10) NULL,
        [ACADEMIC_C] varchar(1) NULL,
        [LIVING_C] varchar(1) NULL,
        [RELATION_C01] varchar(20) NULL,
        [RELATION_C02] varchar(20) NULL,
        [CONTACT_C] varchar(1) NULL,
        [LIVING_ARR] varchar(1) NULL,
        [DIST_SCHL] float NULL,
        [TRANSPORT] varchar(1) NULL,
        [CAR_REGO] varchar(10) NULL,
        [E_MAIL] varchar(60) NULL,
        [MOBILE] varchar(20) NULL,
        [MAP_TYPE] varchar(1) NULL,
        [MAP_NUM] varchar(4) NULL,
        [X_AXIS] varchar(2) NULL,
        [Y_AXIS] varchar(2) NULL,
        [REGISTRATION] int IDENTITY NOT NULL,
        [FIRST_REG_NO] varchar(15) NULL,
        [GENDER] varchar(1) NULL,
        [BIRTHDATE] datetime NULL,
        [PROOF_DOB] varchar(1) NULL,
        [RESIDENT_STATUS] varchar(1) NULL,
        [PERMANENT_BASIS] varchar(1) NULL,
        [ENTRY] datetime NULL,
        [EXIT_DATE] datetime NULL,
        [ARRIVAL] datetime NULL,
        [AUSSIE_SCHOOL] datetime NULL,
        [INTEGRATION] varchar(1) NULL,
        [DATELEFT] datetime NULL,
        [EXPIRY_DATE] datetime NULL,
        [ID_CARD_VALID] varchar(1) NULL,
        [PREVIOUS_SCHOOL] varchar(8) NULL,
        [FAM_ORDER] smallint NULL,
        [NOTES] varchar(MAX) NULL,
        [SGB_FUNDED] varchar(1) NULL,
        [ED_ALLOW] varchar(1) NULL,
        [EMA_AMT1P] money NULL,
        [EMA_AMT2P] money NULL,
        [CASES_EMA_ID] varchar(10) NULL,
        [STATUS] varchar(4) NULL,
        [TAG] varchar(6) NULL,
        [ENROLMENT_YEAR] varchar(4) NULL,
        [ADV_SCHL_YR] varchar(1) NULL,
        [HOME_GROUP] varchar(3) NULL,
        [NEXT_HG] varchar(3) NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [HOUSE] varchar(10) NULL,
        [CAMPUS] int NULL,
        [LOCKER_NUM] varchar(8) NULL,
        [RELIGION] varchar(12) NULL,
        [REL_INSTR] varchar(10) NULL,
        [VCE_ID] varchar(10) NULL,
        [VISA_SUBCLASS] varchar(3) NULL,
        [VISA_STAT_CODE] varchar(4) NULL,
        [VISA_EXPIRY] datetime NULL,
        [REPEAT] varchar(1) NULL,
        [BIRTH_COUNTRY] varchar(6) NULL,
        [ENG_SPEAK] varchar(1) NULL,
        [HOME_LANG] varchar(7) NULL,
        [OVERSEAS] varchar(1) NULL,
        [KOORIE] varchar(1) NULL,
        [YOUTH_ALLOW] varchar(1) NULL,
        [AB_STUDY] varchar(1) NULL,
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
        [AMBULANCE_SUBSCRIBER] varchar(1) NULL,
        [MEDICARE_NO] varchar(12) NULL,
        [INTERNATIONAL_ST_ID] varchar(7) NULL,
        [DISABILITY] varchar(1) NULL,
        [DISABILITY_ID] varchar(6) NULL,
        [PSDREQ] varchar(1) NULL,
        [HEARING_IMPAIR] varchar(1) NULL,
        [VISUAL_IMPAIR] varchar(1) NULL,
        [SPEECH_IMPAIR] varchar(1) NULL,
        [PHYSICAL_IMPAIR] varchar(1) NULL,
        [MEDICAL_ALERT] varchar(1) NULL,
        [MEDICAL_CONDITION] varchar(1) NULL,
        [ACTIVITY_RESTRICTION] varchar(MAX) NULL,
        [IMMUNISE_CERT_STATUS] varchar(2) NULL,
        [IMMUN_CERT_SIGHTED] varchar(1) NULL,
        [IMMUNISE_PERMISSION] varchar(1) NULL,
        [IMMUNIZE] varchar(1) NULL,
        [DISABILITY_ADJUSTMENT_ASSESSED] varchar(1) NULL,
        [DISABILITY_ADJUSTMENT] varchar(1) NULL,
        [DISABILITY_TYPE] varchar(2) NULL,
        [DISABILITY_ADJUSTMENT_LEVEL] varchar(2) NULL,
        [DISABILITY_ADJUSTMENT_LW_DATE] datetime NULL,
        [HEAD_LICE_CHECK] varchar(1) NULL,
        [ANNUAL_TOT] float NULL,
        [STUDENT_PIC] varbinary(MAX) NULL,
        [PUBLISH_PHOTO_MEDIA] varchar(1) NULL,
        [OK_TO_PUBLISH] varchar(1) NULL,
        [PIC_LW_DATE] datetime NULL,
        [PIC_STATUS] varchar(1) NULL,
        [LIBRARY_FLAG] varchar(1) NULL,
        [REGISTRAR_FLAG] varchar(1) NULL,
        [CLEAR1_FLAG] varchar(1) NULL,
        [CLEAR2_FLAG] varchar(1) NULL,
        [CLEAR3_FLAG] varchar(1) NULL,
        [CLEAR4_FLAG] varchar(1) NULL,
        [CLEAR5_FLAG] varchar(1) NULL,
        [CLEAR6_FLAG] varchar(1) NULL,
        [AR_STATUS] smallint NULL,
        [YEARS_PREVIOUS_EDUCATION] smallint NULL,
        [YEARS_INTERRUPTION_EDUCATION] smallint NULL,
        [LANGUAGE_PREVIOUS_SCHOOLING] varchar(7) NULL,
        [NEXT_SCHOOL] varchar(8) NULL,
        [EXIT_CAT01] varchar(2) NULL,
        [EXIT_CAT02] varchar(2) NULL,
        [EXIT_DEST01] varchar(6) NULL,
        [EXIT_DEST02] varchar(6) NULL,
        [EXIT_MODIFY_DATE01] datetime NULL,
        [EXIT_MODIFY_DATE02] datetime NULL,
        [FULLTIME] varchar(1) NULL,
        [SGB_TIME_FRACTION] float NULL,
        [ACTUAL_TIME_FRACTION] float NULL,
        [DEST_ARRIVAL_DATE] datetime NULL,
        [DEPARTURE_DATE] datetime NULL,
        [ARRIVED_DESTINATION] datetime NULL,
        [NOTIFIED_DESTINATION] datetime NULL,
        [VCE_NOTIFIED] datetime NULL,
        [EXIT_FORM] varchar(1) NULL,
        [TRANSFER_FORM] varchar(1) NULL,
        [PARENTAL_APPROVAL_DATE] datetime NULL,
        [PARENTAL_APPROVAL_NOTE] varchar(MAX) NULL,
        [DISASTER_EXIT_REASON] varchar(1) NULL,
        [ATTENDANCE_MEMO] varchar(MAX) NULL,
        [ABS_HDAY_PERIOD] varchar(1) NULL,
        [STRE_FLAG] varchar(1) NULL,
        [PROMOTED] varchar(1) NULL,
        [INAC_ABS_CODE] smallint NULL,
        [LOTE_HOME_CODE] varchar(7) NULL,
        [VSN] varchar(12) NULL,
        [SPEC_CURR] varchar(2) NULL,
        [TRANSITION_STATEMENT] varchar(1) NULL,
        [TFR_PERMISSION] varchar(1) NULL,
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
        [VET] varchar(1) NULL,
        [USI] varchar(10) NULL,
        [SCH_DEFINED01] varchar(1) NULL,
        [SCH_DEFINED02] varchar(1) NULL,
        [TEACHER_RECOMMENDATION] varchar(1) NULL,
        [CRIS_ID] varchar(9) NULL,
        [YOUNG_CARER] varchar(40) NULL,
        [GENDER_DESC] varchar(100) NULL,
        [DET_TUTOR] varchar(1) NULL,
        [DET_TUTORNUM] varchar(1) NULL,
        [MYLNS_LITERACY] varchar(1) NULL,
        [MYLNS_NUMERACY] varchar(1) NULL,
        [KLNP_LITERACY] varchar(1) NULL,
        [KLNP_NUMERACY] varchar(1) NULL,
        [STUDENT_SI_ID] varchar(20) NULL,
        [ENROLMENT_SI_ID] varchar(20) NULL,
        [APPLICATION_SI_ID] varchar(20) NULL,
        [FLO] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [ST_Index_STKEY] PRIMARY KEY CLUSTERED (
            [STKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [ST_Index_BIRTH_COUNTRY] ON [dbo].[ST]
    (
            [BIRTH_COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_CAMPUS] ON [dbo].[ST]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_DOCTOR] ON [dbo].[ST]
    (
            [DOCTOR] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_EMERG_LANG01] ON [dbo].[ST]
    (
            [EMERG_LANG01] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_EMERG_LANG02] ON [dbo].[ST]
    (
            [EMERG_LANG02] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_EXIT_CAT01] ON [dbo].[ST]
    (
            [EXIT_CAT01] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_EXIT_CAT02] ON [dbo].[ST]
    (
            [EXIT_CAT02] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_EXIT_DEST01] ON [dbo].[ST]
    (
            [EXIT_DEST01] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_EXIT_DEST02] ON [dbo].[ST]
    (
            [EXIT_DEST02] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_FAMB] ON [dbo].[ST]
    (
            [FAMB] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_FAMC] ON [dbo].[ST]
    (
            [FAMC] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_FAMILY] ON [dbo].[ST]
    (
            [FAMILY] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_HOME_GROUP] ON [dbo].[ST]
    (
            [HOME_GROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_HOME_LANG] ON [dbo].[ST]
    (
            [HOME_LANG] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_HOUSE] ON [dbo].[ST]
    (
            [HOUSE] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_INAC_ABS_CODE] ON [dbo].[ST]
    (
            [INAC_ABS_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_LANGUAGE_PREVIOUS_SCHOOLING] ON [dbo].[ST]
    (
            [LANGUAGE_PREVIOUS_SCHOOLING] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_LOTE_HOME_CODE] ON [dbo].[ST]
    (
            [LOTE_HOME_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_LW_DATE] ON [dbo].[ST]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_NEXT_HG] ON [dbo].[ST]
    (
            [NEXT_HG] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_NEXT_SCHOOL] ON [dbo].[ST]
    (
            [NEXT_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_PREVIOUS_SCHOOL] ON [dbo].[ST]
    (
            [PREVIOUS_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_REGISTRATION] ON [dbo].[ST]
    (
            [REGISTRATION] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_REL_INSTR] ON [dbo].[ST]
    (
            [REL_INSTR] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_RELIGION] ON [dbo].[ST]
    (
            [RELIGION] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_SCHOOL_YEAR] ON [dbo].[ST]
    (
            [SCHOOL_YEAR] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_TAG] ON [dbo].[ST]
    (
            [TAG] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_Index_VISA_SUBCLASS] ON [dbo].[ST]
    (
            [VISA_SUBCLASS] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_BIRTH_COUNTRY')
    ALTER INDEX [ST_Index_BIRTH_COUNTRY] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_CAMPUS')
    ALTER INDEX [ST_Index_CAMPUS] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_DOCTOR')
    ALTER INDEX [ST_Index_DOCTOR] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EMERG_LANG01')
    ALTER INDEX [ST_Index_EMERG_LANG01] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EMERG_LANG02')
    ALTER INDEX [ST_Index_EMERG_LANG02] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_CAT01')
    ALTER INDEX [ST_Index_EXIT_CAT01] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_CAT02')
    ALTER INDEX [ST_Index_EXIT_CAT02] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_DEST01')
    ALTER INDEX [ST_Index_EXIT_DEST01] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_DEST02')
    ALTER INDEX [ST_Index_EXIT_DEST02] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_FAMB')
    ALTER INDEX [ST_Index_FAMB] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_FAMC')
    ALTER INDEX [ST_Index_FAMC] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_FAMILY')
    ALTER INDEX [ST_Index_FAMILY] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_HOME_GROUP')
    ALTER INDEX [ST_Index_HOME_GROUP] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_HOME_LANG')
    ALTER INDEX [ST_Index_HOME_LANG] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_HOUSE')
    ALTER INDEX [ST_Index_HOUSE] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_INAC_ABS_CODE')
    ALTER INDEX [ST_Index_INAC_ABS_CODE] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_LANGUAGE_PREVIOUS_SCHOOLING')
    ALTER INDEX [ST_Index_LANGUAGE_PREVIOUS_SCHOOLING] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_LOTE_HOME_CODE')
    ALTER INDEX [ST_Index_LOTE_HOME_CODE] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_LW_DATE')
    ALTER INDEX [ST_Index_LW_DATE] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_NEXT_HG')
    ALTER INDEX [ST_Index_NEXT_HG] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_NEXT_SCHOOL')
    ALTER INDEX [ST_Index_NEXT_SCHOOL] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_PREVIOUS_SCHOOL')
    ALTER INDEX [ST_Index_PREVIOUS_SCHOOL] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_REGISTRATION')
    ALTER INDEX [ST_Index_REGISTRATION] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_REL_INSTR')
    ALTER INDEX [ST_Index_REL_INSTR] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_RELIGION')
    ALTER INDEX [ST_Index_RELIGION] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_SCHOOL_YEAR')
    ALTER INDEX [ST_Index_SCHOOL_YEAR] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_TAG')
    ALTER INDEX [ST_Index_TAG] ON [dbo].[ST] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_VISA_SUBCLASS')
    ALTER INDEX [ST_Index_VISA_SUBCLASS] ON [dbo].[ST] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_BIRTH_COUNTRY')
    ALTER INDEX [ST_Index_BIRTH_COUNTRY] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_CAMPUS')
    ALTER INDEX [ST_Index_CAMPUS] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_DOCTOR')
    ALTER INDEX [ST_Index_DOCTOR] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EMERG_LANG01')
    ALTER INDEX [ST_Index_EMERG_LANG01] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EMERG_LANG02')
    ALTER INDEX [ST_Index_EMERG_LANG02] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_CAT01')
    ALTER INDEX [ST_Index_EXIT_CAT01] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_CAT02')
    ALTER INDEX [ST_Index_EXIT_CAT02] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_DEST01')
    ALTER INDEX [ST_Index_EXIT_DEST01] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_EXIT_DEST02')
    ALTER INDEX [ST_Index_EXIT_DEST02] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_FAMB')
    ALTER INDEX [ST_Index_FAMB] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_FAMC')
    ALTER INDEX [ST_Index_FAMC] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_FAMILY')
    ALTER INDEX [ST_Index_FAMILY] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_HOME_GROUP')
    ALTER INDEX [ST_Index_HOME_GROUP] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_HOME_LANG')
    ALTER INDEX [ST_Index_HOME_LANG] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_HOUSE')
    ALTER INDEX [ST_Index_HOUSE] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_INAC_ABS_CODE')
    ALTER INDEX [ST_Index_INAC_ABS_CODE] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_LANGUAGE_PREVIOUS_SCHOOLING')
    ALTER INDEX [ST_Index_LANGUAGE_PREVIOUS_SCHOOLING] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_LOTE_HOME_CODE')
    ALTER INDEX [ST_Index_LOTE_HOME_CODE] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_LW_DATE')
    ALTER INDEX [ST_Index_LW_DATE] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_NEXT_HG')
    ALTER INDEX [ST_Index_NEXT_HG] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_NEXT_SCHOOL')
    ALTER INDEX [ST_Index_NEXT_SCHOOL] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_PREVIOUS_SCHOOL')
    ALTER INDEX [ST_Index_PREVIOUS_SCHOOL] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_REGISTRATION')
    ALTER INDEX [ST_Index_REGISTRATION] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_REL_INSTR')
    ALTER INDEX [ST_Index_REL_INSTR] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_RELIGION')
    ALTER INDEX [ST_Index_RELIGION] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_SCHOOL_YEAR')
    ALTER INDEX [ST_Index_SCHOOL_YEAR] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_TAG')
    ALTER INDEX [ST_Index_TAG] ON [dbo].[ST] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST]') AND name = N'ST_Index_VISA_SUBCLASS')
    ALTER INDEX [ST_Index_VISA_SUBCLASS] ON [dbo].[ST] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="ST"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="ST"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<ST> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_REGISTRATION = new List<int>();
            List<string> Index_STKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_REGISTRATION.Add(entity.REGISTRATION);
                Index_STKEY.Add(entity.STKEY);
            }

            builder.AppendLine("DELETE [dbo].[ST] WHERE");


            // Index_REGISTRATION
            builder.Append("[REGISTRATION] IN (");
            for (int index = 0; index < Index_REGISTRATION.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // REGISTRATION
                var parameterREGISTRATION = $"@p{parameterIndex++}";
                builder.Append(parameterREGISTRATION);
                command.Parameters.Add(parameterREGISTRATION, SqlDbType.Int).Value = Index_REGISTRATION[index];
            }
            builder.AppendLine(") OR");

            // Index_STKEY
            builder.Append("[STKEY] IN (");
            for (int index = 0; index < Index_STKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STKEY
                var parameterSTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSTKEY);
                command.Parameters.Add(parameterSTKEY, SqlDbType.VarChar, 10).Value = Index_STKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the ST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ST data set</returns>
        public override EduHubDataSetDataReader<ST> GetDataSetDataReader()
        {
            return new STDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the ST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ST data set</returns>
        public override EduHubDataSetDataReader<ST> GetDataSetDataReader(List<ST> Entities)
        {
            return new STDataReader(new EduHubDataSetLoadedReader<ST>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STDataReader : EduHubDataSetDataReader<ST>
        {
            public STDataReader(IEduHubDataSetReader<ST> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 211; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // STKEY
                        return Current.STKEY;
                    case 1: // SURNAME
                        return Current.SURNAME;
                    case 2: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 3: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 4: // PREF_NAME
                        return Current.PREF_NAME;
                    case 5: // TITLE
                        return Current.TITLE;
                    case 6: // FAMILY
                        return Current.FAMILY;
                    case 7: // ACADEMIC_A
                        return Current.ACADEMIC_A;
                    case 8: // LIVING_A
                        return Current.LIVING_A;
                    case 9: // RELATION_A01
                        return Current.RELATION_A01;
                    case 10: // RELATION_A02
                        return Current.RELATION_A02;
                    case 11: // CONTACT_A
                        return Current.CONTACT_A;
                    case 12: // FAMB
                        return Current.FAMB;
                    case 13: // ACADEMIC_B
                        return Current.ACADEMIC_B;
                    case 14: // LIVING_B
                        return Current.LIVING_B;
                    case 15: // RELATION_B01
                        return Current.RELATION_B01;
                    case 16: // RELATION_B02
                        return Current.RELATION_B02;
                    case 17: // CONTACT_B
                        return Current.CONTACT_B;
                    case 18: // FAMC
                        return Current.FAMC;
                    case 19: // ACADEMIC_C
                        return Current.ACADEMIC_C;
                    case 20: // LIVING_C
                        return Current.LIVING_C;
                    case 21: // RELATION_C01
                        return Current.RELATION_C01;
                    case 22: // RELATION_C02
                        return Current.RELATION_C02;
                    case 23: // CONTACT_C
                        return Current.CONTACT_C;
                    case 24: // LIVING_ARR
                        return Current.LIVING_ARR;
                    case 25: // DIST_SCHL
                        return Current.DIST_SCHL;
                    case 26: // TRANSPORT
                        return Current.TRANSPORT;
                    case 27: // CAR_REGO
                        return Current.CAR_REGO;
                    case 28: // E_MAIL
                        return Current.E_MAIL;
                    case 29: // MOBILE
                        return Current.MOBILE;
                    case 30: // MAP_TYPE
                        return Current.MAP_TYPE;
                    case 31: // MAP_NUM
                        return Current.MAP_NUM;
                    case 32: // X_AXIS
                        return Current.X_AXIS;
                    case 33: // Y_AXIS
                        return Current.Y_AXIS;
                    case 34: // REGISTRATION
                        return Current.REGISTRATION;
                    case 35: // FIRST_REG_NO
                        return Current.FIRST_REG_NO;
                    case 36: // GENDER
                        return Current.GENDER;
                    case 37: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 38: // PROOF_DOB
                        return Current.PROOF_DOB;
                    case 39: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS;
                    case 40: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS;
                    case 41: // ENTRY
                        return Current.ENTRY;
                    case 42: // EXIT_DATE
                        return Current.EXIT_DATE;
                    case 43: // ARRIVAL
                        return Current.ARRIVAL;
                    case 44: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL;
                    case 45: // INTEGRATION
                        return Current.INTEGRATION;
                    case 46: // DATELEFT
                        return Current.DATELEFT;
                    case 47: // EXPIRY_DATE
                        return Current.EXPIRY_DATE;
                    case 48: // ID_CARD_VALID
                        return Current.ID_CARD_VALID;
                    case 49: // PREVIOUS_SCHOOL
                        return Current.PREVIOUS_SCHOOL;
                    case 50: // FAM_ORDER
                        return Current.FAM_ORDER;
                    case 51: // NOTES
                        return Current.NOTES;
                    case 52: // SGB_FUNDED
                        return Current.SGB_FUNDED;
                    case 53: // ED_ALLOW
                        return Current.ED_ALLOW;
                    case 54: // EMA_AMT1P
                        return Current.EMA_AMT1P;
                    case 55: // EMA_AMT2P
                        return Current.EMA_AMT2P;
                    case 56: // CASES_EMA_ID
                        return Current.CASES_EMA_ID;
                    case 57: // STATUS
                        return Current.STATUS;
                    case 58: // TAG
                        return Current.TAG;
                    case 59: // ENROLMENT_YEAR
                        return Current.ENROLMENT_YEAR;
                    case 60: // ADV_SCHL_YR
                        return Current.ADV_SCHL_YR;
                    case 61: // HOME_GROUP
                        return Current.HOME_GROUP;
                    case 62: // NEXT_HG
                        return Current.NEXT_HG;
                    case 63: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 64: // HOUSE
                        return Current.HOUSE;
                    case 65: // CAMPUS
                        return Current.CAMPUS;
                    case 66: // LOCKER_NUM
                        return Current.LOCKER_NUM;
                    case 67: // RELIGION
                        return Current.RELIGION;
                    case 68: // REL_INSTR
                        return Current.REL_INSTR;
                    case 69: // VCE_ID
                        return Current.VCE_ID;
                    case 70: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS;
                    case 71: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE;
                    case 72: // VISA_EXPIRY
                        return Current.VISA_EXPIRY;
                    case 73: // REPEAT
                        return Current.REPEAT;
                    case 74: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY;
                    case 75: // ENG_SPEAK
                        return Current.ENG_SPEAK;
                    case 76: // HOME_LANG
                        return Current.HOME_LANG;
                    case 77: // OVERSEAS
                        return Current.OVERSEAS;
                    case 78: // KOORIE
                        return Current.KOORIE;
                    case 79: // YOUTH_ALLOW
                        return Current.YOUTH_ALLOW;
                    case 80: // AB_STUDY
                        return Current.AB_STUDY;
                    case 81: // ACCESS
                        return Current.ACCESS;
                    case 82: // ACCESS_TYPE
                        return Current.ACCESS_TYPE;
                    case 83: // ACCESS_ALERT
                        return Current.ACCESS_ALERT;
                    case 84: // RISK_ALERT
                        return Current.RISK_ALERT;
                    case 85: // RISK_MEMO
                        return Current.RISK_MEMO;
                    case 86: // DOCTOR
                        return Current.DOCTOR;
                    case 87: // EMERG_NAME01
                        return Current.EMERG_NAME01;
                    case 88: // EMERG_NAME02
                        return Current.EMERG_NAME02;
                    case 89: // EMERG_LANG01
                        return Current.EMERG_LANG01;
                    case 90: // EMERG_LANG02
                        return Current.EMERG_LANG02;
                    case 91: // EMERG_RELATION01
                        return Current.EMERG_RELATION01;
                    case 92: // EMERG_RELATION02
                        return Current.EMERG_RELATION02;
                    case 93: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01;
                    case 94: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02;
                    case 95: // EMERG_CONTACT_MEMO01
                        return Current.EMERG_CONTACT_MEMO01;
                    case 96: // EMERG_CONTACT_MEMO02
                        return Current.EMERG_CONTACT_MEMO02;
                    case 97: // ACC_DECLARATION
                        return Current.ACC_DECLARATION;
                    case 98: // AMBULANCE_SUBSCRIBER
                        return Current.AMBULANCE_SUBSCRIBER;
                    case 99: // MEDICARE_NO
                        return Current.MEDICARE_NO;
                    case 100: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID;
                    case 101: // DISABILITY
                        return Current.DISABILITY;
                    case 102: // DISABILITY_ID
                        return Current.DISABILITY_ID;
                    case 103: // PSDREQ
                        return Current.PSDREQ;
                    case 104: // HEARING_IMPAIR
                        return Current.HEARING_IMPAIR;
                    case 105: // VISUAL_IMPAIR
                        return Current.VISUAL_IMPAIR;
                    case 106: // SPEECH_IMPAIR
                        return Current.SPEECH_IMPAIR;
                    case 107: // PHYSICAL_IMPAIR
                        return Current.PHYSICAL_IMPAIR;
                    case 108: // MEDICAL_ALERT
                        return Current.MEDICAL_ALERT;
                    case 109: // MEDICAL_CONDITION
                        return Current.MEDICAL_CONDITION;
                    case 110: // ACTIVITY_RESTRICTION
                        return Current.ACTIVITY_RESTRICTION;
                    case 111: // IMMUNISE_CERT_STATUS
                        return Current.IMMUNISE_CERT_STATUS;
                    case 112: // IMMUN_CERT_SIGHTED
                        return Current.IMMUN_CERT_SIGHTED;
                    case 113: // IMMUNISE_PERMISSION
                        return Current.IMMUNISE_PERMISSION;
                    case 114: // IMMUNIZE
                        return Current.IMMUNIZE;
                    case 115: // DISABILITY_ADJUSTMENT_ASSESSED
                        return Current.DISABILITY_ADJUSTMENT_ASSESSED;
                    case 116: // DISABILITY_ADJUSTMENT
                        return Current.DISABILITY_ADJUSTMENT;
                    case 117: // DISABILITY_TYPE
                        return Current.DISABILITY_TYPE;
                    case 118: // DISABILITY_ADJUSTMENT_LEVEL
                        return Current.DISABILITY_ADJUSTMENT_LEVEL;
                    case 119: // DISABILITY_ADJUSTMENT_LW_DATE
                        return Current.DISABILITY_ADJUSTMENT_LW_DATE;
                    case 120: // HEAD_LICE_CHECK
                        return Current.HEAD_LICE_CHECK;
                    case 121: // ANNUAL_TOT
                        return Current.ANNUAL_TOT;
                    case 122: // STUDENT_PIC
                        return Current.STUDENT_PIC;
                    case 123: // PUBLISH_PHOTO_MEDIA
                        return Current.PUBLISH_PHOTO_MEDIA;
                    case 124: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH;
                    case 125: // PIC_LW_DATE
                        return Current.PIC_LW_DATE;
                    case 126: // PIC_STATUS
                        return Current.PIC_STATUS;
                    case 127: // LIBRARY_FLAG
                        return Current.LIBRARY_FLAG;
                    case 128: // REGISTRAR_FLAG
                        return Current.REGISTRAR_FLAG;
                    case 129: // CLEAR1_FLAG
                        return Current.CLEAR1_FLAG;
                    case 130: // CLEAR2_FLAG
                        return Current.CLEAR2_FLAG;
                    case 131: // CLEAR3_FLAG
                        return Current.CLEAR3_FLAG;
                    case 132: // CLEAR4_FLAG
                        return Current.CLEAR4_FLAG;
                    case 133: // CLEAR5_FLAG
                        return Current.CLEAR5_FLAG;
                    case 134: // CLEAR6_FLAG
                        return Current.CLEAR6_FLAG;
                    case 135: // AR_STATUS
                        return Current.AR_STATUS;
                    case 136: // YEARS_PREVIOUS_EDUCATION
                        return Current.YEARS_PREVIOUS_EDUCATION;
                    case 137: // YEARS_INTERRUPTION_EDUCATION
                        return Current.YEARS_INTERRUPTION_EDUCATION;
                    case 138: // LANGUAGE_PREVIOUS_SCHOOLING
                        return Current.LANGUAGE_PREVIOUS_SCHOOLING;
                    case 139: // NEXT_SCHOOL
                        return Current.NEXT_SCHOOL;
                    case 140: // EXIT_CAT01
                        return Current.EXIT_CAT01;
                    case 141: // EXIT_CAT02
                        return Current.EXIT_CAT02;
                    case 142: // EXIT_DEST01
                        return Current.EXIT_DEST01;
                    case 143: // EXIT_DEST02
                        return Current.EXIT_DEST02;
                    case 144: // EXIT_MODIFY_DATE01
                        return Current.EXIT_MODIFY_DATE01;
                    case 145: // EXIT_MODIFY_DATE02
                        return Current.EXIT_MODIFY_DATE02;
                    case 146: // FULLTIME
                        return Current.FULLTIME;
                    case 147: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION;
                    case 148: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION;
                    case 149: // DEST_ARRIVAL_DATE
                        return Current.DEST_ARRIVAL_DATE;
                    case 150: // DEPARTURE_DATE
                        return Current.DEPARTURE_DATE;
                    case 151: // ARRIVED_DESTINATION
                        return Current.ARRIVED_DESTINATION;
                    case 152: // NOTIFIED_DESTINATION
                        return Current.NOTIFIED_DESTINATION;
                    case 153: // VCE_NOTIFIED
                        return Current.VCE_NOTIFIED;
                    case 154: // EXIT_FORM
                        return Current.EXIT_FORM;
                    case 155: // TRANSFER_FORM
                        return Current.TRANSFER_FORM;
                    case 156: // PARENTAL_APPROVAL_DATE
                        return Current.PARENTAL_APPROVAL_DATE;
                    case 157: // PARENTAL_APPROVAL_NOTE
                        return Current.PARENTAL_APPROVAL_NOTE;
                    case 158: // DISASTER_EXIT_REASON
                        return Current.DISASTER_EXIT_REASON;
                    case 159: // ATTENDANCE_MEMO
                        return Current.ATTENDANCE_MEMO;
                    case 160: // ABS_HDAY_PERIOD
                        return Current.ABS_HDAY_PERIOD;
                    case 161: // STRE_FLAG
                        return Current.STRE_FLAG;
                    case 162: // PROMOTED
                        return Current.PROMOTED;
                    case 163: // INAC_ABS_CODE
                        return Current.INAC_ABS_CODE;
                    case 164: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE;
                    case 165: // VSN
                        return Current.VSN;
                    case 166: // SPEC_CURR
                        return Current.SPEC_CURR;
                    case 167: // TRANSITION_STATEMENT
                        return Current.TRANSITION_STATEMENT;
                    case 168: // TFR_PERMISSION
                        return Current.TFR_PERMISSION;
                    case 169: // LEGAL_LIMIT_DECISION
                        return Current.LEGAL_LIMIT_DECISION;
                    case 170: // LEGAL_LIMIT_CONTACT
                        return Current.LEGAL_LIMIT_CONTACT;
                    case 171: // LEGAL_LIMITATION
                        return Current.LEGAL_LIMITATION;
                    case 172: // DOC_COPIES
                        return Current.DOC_COPIES;
                    case 173: // LISTED_IN_SOCS
                        return Current.LISTED_IN_SOCS;
                    case 174: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES;
                    case 175: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT;
                    case 176: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT;
                    case 177: // SUPPORT_GROUP
                        return Current.SUPPORT_GROUP;
                    case 178: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION;
                    case 179: // ATTENDANCE_CONCERNS
                        return Current.ATTENDANCE_CONCERNS;
                    case 180: // DISCIPLINARY_ACTION
                        return Current.DISCIPLINARY_ACTION;
                    case 181: // WELFARE_RISKS
                        return Current.WELFARE_RISKS;
                    case 182: // EFFORT
                        return Current.EFFORT;
                    case 183: // CLASS_BEHAVIOUR
                        return Current.CLASS_BEHAVIOUR;
                    case 184: // ORGANISATION
                        return Current.ORGANISATION;
                    case 185: // SOCIAL_BEHAVIOUR
                        return Current.SOCIAL_BEHAVIOUR;
                    case 186: // LEARNING_SUPPORT
                        return Current.LEARNING_SUPPORT;
                    case 187: // NEW_ARRIVALS_PROGRAM
                        return Current.NEW_ARRIVALS_PROGRAM;
                    case 188: // REFUGEE_BACKGROUND
                        return Current.REFUGEE_BACKGROUND;
                    case 189: // TRANSFER_DOCS_SENT
                        return Current.TRANSFER_DOCS_SENT;
                    case 190: // VET
                        return Current.VET;
                    case 191: // USI
                        return Current.USI;
                    case 192: // SCH_DEFINED01
                        return Current.SCH_DEFINED01;
                    case 193: // SCH_DEFINED02
                        return Current.SCH_DEFINED02;
                    case 194: // TEACHER_RECOMMENDATION
                        return Current.TEACHER_RECOMMENDATION;
                    case 195: // CRIS_ID
                        return Current.CRIS_ID;
                    case 196: // YOUNG_CARER
                        return Current.YOUNG_CARER;
                    case 197: // GENDER_DESC
                        return Current.GENDER_DESC;
                    case 198: // DET_TUTOR
                        return Current.DET_TUTOR;
                    case 199: // DET_TUTORNUM
                        return Current.DET_TUTORNUM;
                    case 200: // MYLNS_LITERACY
                        return Current.MYLNS_LITERACY;
                    case 201: // MYLNS_NUMERACY
                        return Current.MYLNS_NUMERACY;
                    case 202: // KLNP_LITERACY
                        return Current.KLNP_LITERACY;
                    case 203: // KLNP_NUMERACY
                        return Current.KLNP_NUMERACY;
                    case 204: // STUDENT_SI_ID
                        return Current.STUDENT_SI_ID;
                    case 205: // ENROLMENT_SI_ID
                        return Current.ENROLMENT_SI_ID;
                    case 206: // APPLICATION_SI_ID
                        return Current.APPLICATION_SI_ID;
                    case 207: // FLO
                        return Current.FLO;
                    case 208: // LW_DATE
                        return Current.LW_DATE;
                    case 209: // LW_TIME
                        return Current.LW_TIME;
                    case 210: // LW_USER
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
                    case 4: // PREF_NAME
                        return Current.PREF_NAME == null;
                    case 5: // TITLE
                        return Current.TITLE == null;
                    case 6: // FAMILY
                        return Current.FAMILY == null;
                    case 7: // ACADEMIC_A
                        return Current.ACADEMIC_A == null;
                    case 8: // LIVING_A
                        return Current.LIVING_A == null;
                    case 9: // RELATION_A01
                        return Current.RELATION_A01 == null;
                    case 10: // RELATION_A02
                        return Current.RELATION_A02 == null;
                    case 11: // CONTACT_A
                        return Current.CONTACT_A == null;
                    case 12: // FAMB
                        return Current.FAMB == null;
                    case 13: // ACADEMIC_B
                        return Current.ACADEMIC_B == null;
                    case 14: // LIVING_B
                        return Current.LIVING_B == null;
                    case 15: // RELATION_B01
                        return Current.RELATION_B01 == null;
                    case 16: // RELATION_B02
                        return Current.RELATION_B02 == null;
                    case 17: // CONTACT_B
                        return Current.CONTACT_B == null;
                    case 18: // FAMC
                        return Current.FAMC == null;
                    case 19: // ACADEMIC_C
                        return Current.ACADEMIC_C == null;
                    case 20: // LIVING_C
                        return Current.LIVING_C == null;
                    case 21: // RELATION_C01
                        return Current.RELATION_C01 == null;
                    case 22: // RELATION_C02
                        return Current.RELATION_C02 == null;
                    case 23: // CONTACT_C
                        return Current.CONTACT_C == null;
                    case 24: // LIVING_ARR
                        return Current.LIVING_ARR == null;
                    case 25: // DIST_SCHL
                        return Current.DIST_SCHL == null;
                    case 26: // TRANSPORT
                        return Current.TRANSPORT == null;
                    case 27: // CAR_REGO
                        return Current.CAR_REGO == null;
                    case 28: // E_MAIL
                        return Current.E_MAIL == null;
                    case 29: // MOBILE
                        return Current.MOBILE == null;
                    case 30: // MAP_TYPE
                        return Current.MAP_TYPE == null;
                    case 31: // MAP_NUM
                        return Current.MAP_NUM == null;
                    case 32: // X_AXIS
                        return Current.X_AXIS == null;
                    case 33: // Y_AXIS
                        return Current.Y_AXIS == null;
                    case 35: // FIRST_REG_NO
                        return Current.FIRST_REG_NO == null;
                    case 36: // GENDER
                        return Current.GENDER == null;
                    case 37: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 38: // PROOF_DOB
                        return Current.PROOF_DOB == null;
                    case 39: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS == null;
                    case 40: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS == null;
                    case 41: // ENTRY
                        return Current.ENTRY == null;
                    case 42: // EXIT_DATE
                        return Current.EXIT_DATE == null;
                    case 43: // ARRIVAL
                        return Current.ARRIVAL == null;
                    case 44: // AUSSIE_SCHOOL
                        return Current.AUSSIE_SCHOOL == null;
                    case 45: // INTEGRATION
                        return Current.INTEGRATION == null;
                    case 46: // DATELEFT
                        return Current.DATELEFT == null;
                    case 47: // EXPIRY_DATE
                        return Current.EXPIRY_DATE == null;
                    case 48: // ID_CARD_VALID
                        return Current.ID_CARD_VALID == null;
                    case 49: // PREVIOUS_SCHOOL
                        return Current.PREVIOUS_SCHOOL == null;
                    case 50: // FAM_ORDER
                        return Current.FAM_ORDER == null;
                    case 51: // NOTES
                        return Current.NOTES == null;
                    case 52: // SGB_FUNDED
                        return Current.SGB_FUNDED == null;
                    case 53: // ED_ALLOW
                        return Current.ED_ALLOW == null;
                    case 54: // EMA_AMT1P
                        return Current.EMA_AMT1P == null;
                    case 55: // EMA_AMT2P
                        return Current.EMA_AMT2P == null;
                    case 56: // CASES_EMA_ID
                        return Current.CASES_EMA_ID == null;
                    case 57: // STATUS
                        return Current.STATUS == null;
                    case 58: // TAG
                        return Current.TAG == null;
                    case 59: // ENROLMENT_YEAR
                        return Current.ENROLMENT_YEAR == null;
                    case 60: // ADV_SCHL_YR
                        return Current.ADV_SCHL_YR == null;
                    case 61: // HOME_GROUP
                        return Current.HOME_GROUP == null;
                    case 62: // NEXT_HG
                        return Current.NEXT_HG == null;
                    case 63: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 64: // HOUSE
                        return Current.HOUSE == null;
                    case 65: // CAMPUS
                        return Current.CAMPUS == null;
                    case 66: // LOCKER_NUM
                        return Current.LOCKER_NUM == null;
                    case 67: // RELIGION
                        return Current.RELIGION == null;
                    case 68: // REL_INSTR
                        return Current.REL_INSTR == null;
                    case 69: // VCE_ID
                        return Current.VCE_ID == null;
                    case 70: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS == null;
                    case 71: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE == null;
                    case 72: // VISA_EXPIRY
                        return Current.VISA_EXPIRY == null;
                    case 73: // REPEAT
                        return Current.REPEAT == null;
                    case 74: // BIRTH_COUNTRY
                        return Current.BIRTH_COUNTRY == null;
                    case 75: // ENG_SPEAK
                        return Current.ENG_SPEAK == null;
                    case 76: // HOME_LANG
                        return Current.HOME_LANG == null;
                    case 77: // OVERSEAS
                        return Current.OVERSEAS == null;
                    case 78: // KOORIE
                        return Current.KOORIE == null;
                    case 79: // YOUTH_ALLOW
                        return Current.YOUTH_ALLOW == null;
                    case 80: // AB_STUDY
                        return Current.AB_STUDY == null;
                    case 81: // ACCESS
                        return Current.ACCESS == null;
                    case 82: // ACCESS_TYPE
                        return Current.ACCESS_TYPE == null;
                    case 83: // ACCESS_ALERT
                        return Current.ACCESS_ALERT == null;
                    case 84: // RISK_ALERT
                        return Current.RISK_ALERT == null;
                    case 85: // RISK_MEMO
                        return Current.RISK_MEMO == null;
                    case 86: // DOCTOR
                        return Current.DOCTOR == null;
                    case 87: // EMERG_NAME01
                        return Current.EMERG_NAME01 == null;
                    case 88: // EMERG_NAME02
                        return Current.EMERG_NAME02 == null;
                    case 89: // EMERG_LANG01
                        return Current.EMERG_LANG01 == null;
                    case 90: // EMERG_LANG02
                        return Current.EMERG_LANG02 == null;
                    case 91: // EMERG_RELATION01
                        return Current.EMERG_RELATION01 == null;
                    case 92: // EMERG_RELATION02
                        return Current.EMERG_RELATION02 == null;
                    case 93: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01 == null;
                    case 94: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02 == null;
                    case 95: // EMERG_CONTACT_MEMO01
                        return Current.EMERG_CONTACT_MEMO01 == null;
                    case 96: // EMERG_CONTACT_MEMO02
                        return Current.EMERG_CONTACT_MEMO02 == null;
                    case 97: // ACC_DECLARATION
                        return Current.ACC_DECLARATION == null;
                    case 98: // AMBULANCE_SUBSCRIBER
                        return Current.AMBULANCE_SUBSCRIBER == null;
                    case 99: // MEDICARE_NO
                        return Current.MEDICARE_NO == null;
                    case 100: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID == null;
                    case 101: // DISABILITY
                        return Current.DISABILITY == null;
                    case 102: // DISABILITY_ID
                        return Current.DISABILITY_ID == null;
                    case 103: // PSDREQ
                        return Current.PSDREQ == null;
                    case 104: // HEARING_IMPAIR
                        return Current.HEARING_IMPAIR == null;
                    case 105: // VISUAL_IMPAIR
                        return Current.VISUAL_IMPAIR == null;
                    case 106: // SPEECH_IMPAIR
                        return Current.SPEECH_IMPAIR == null;
                    case 107: // PHYSICAL_IMPAIR
                        return Current.PHYSICAL_IMPAIR == null;
                    case 108: // MEDICAL_ALERT
                        return Current.MEDICAL_ALERT == null;
                    case 109: // MEDICAL_CONDITION
                        return Current.MEDICAL_CONDITION == null;
                    case 110: // ACTIVITY_RESTRICTION
                        return Current.ACTIVITY_RESTRICTION == null;
                    case 111: // IMMUNISE_CERT_STATUS
                        return Current.IMMUNISE_CERT_STATUS == null;
                    case 112: // IMMUN_CERT_SIGHTED
                        return Current.IMMUN_CERT_SIGHTED == null;
                    case 113: // IMMUNISE_PERMISSION
                        return Current.IMMUNISE_PERMISSION == null;
                    case 114: // IMMUNIZE
                        return Current.IMMUNIZE == null;
                    case 115: // DISABILITY_ADJUSTMENT_ASSESSED
                        return Current.DISABILITY_ADJUSTMENT_ASSESSED == null;
                    case 116: // DISABILITY_ADJUSTMENT
                        return Current.DISABILITY_ADJUSTMENT == null;
                    case 117: // DISABILITY_TYPE
                        return Current.DISABILITY_TYPE == null;
                    case 118: // DISABILITY_ADJUSTMENT_LEVEL
                        return Current.DISABILITY_ADJUSTMENT_LEVEL == null;
                    case 119: // DISABILITY_ADJUSTMENT_LW_DATE
                        return Current.DISABILITY_ADJUSTMENT_LW_DATE == null;
                    case 120: // HEAD_LICE_CHECK
                        return Current.HEAD_LICE_CHECK == null;
                    case 121: // ANNUAL_TOT
                        return Current.ANNUAL_TOT == null;
                    case 122: // STUDENT_PIC
                        return Current.STUDENT_PIC == null;
                    case 123: // PUBLISH_PHOTO_MEDIA
                        return Current.PUBLISH_PHOTO_MEDIA == null;
                    case 124: // OK_TO_PUBLISH
                        return Current.OK_TO_PUBLISH == null;
                    case 125: // PIC_LW_DATE
                        return Current.PIC_LW_DATE == null;
                    case 126: // PIC_STATUS
                        return Current.PIC_STATUS == null;
                    case 127: // LIBRARY_FLAG
                        return Current.LIBRARY_FLAG == null;
                    case 128: // REGISTRAR_FLAG
                        return Current.REGISTRAR_FLAG == null;
                    case 129: // CLEAR1_FLAG
                        return Current.CLEAR1_FLAG == null;
                    case 130: // CLEAR2_FLAG
                        return Current.CLEAR2_FLAG == null;
                    case 131: // CLEAR3_FLAG
                        return Current.CLEAR3_FLAG == null;
                    case 132: // CLEAR4_FLAG
                        return Current.CLEAR4_FLAG == null;
                    case 133: // CLEAR5_FLAG
                        return Current.CLEAR5_FLAG == null;
                    case 134: // CLEAR6_FLAG
                        return Current.CLEAR6_FLAG == null;
                    case 135: // AR_STATUS
                        return Current.AR_STATUS == null;
                    case 136: // YEARS_PREVIOUS_EDUCATION
                        return Current.YEARS_PREVIOUS_EDUCATION == null;
                    case 137: // YEARS_INTERRUPTION_EDUCATION
                        return Current.YEARS_INTERRUPTION_EDUCATION == null;
                    case 138: // LANGUAGE_PREVIOUS_SCHOOLING
                        return Current.LANGUAGE_PREVIOUS_SCHOOLING == null;
                    case 139: // NEXT_SCHOOL
                        return Current.NEXT_SCHOOL == null;
                    case 140: // EXIT_CAT01
                        return Current.EXIT_CAT01 == null;
                    case 141: // EXIT_CAT02
                        return Current.EXIT_CAT02 == null;
                    case 142: // EXIT_DEST01
                        return Current.EXIT_DEST01 == null;
                    case 143: // EXIT_DEST02
                        return Current.EXIT_DEST02 == null;
                    case 144: // EXIT_MODIFY_DATE01
                        return Current.EXIT_MODIFY_DATE01 == null;
                    case 145: // EXIT_MODIFY_DATE02
                        return Current.EXIT_MODIFY_DATE02 == null;
                    case 146: // FULLTIME
                        return Current.FULLTIME == null;
                    case 147: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION == null;
                    case 148: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION == null;
                    case 149: // DEST_ARRIVAL_DATE
                        return Current.DEST_ARRIVAL_DATE == null;
                    case 150: // DEPARTURE_DATE
                        return Current.DEPARTURE_DATE == null;
                    case 151: // ARRIVED_DESTINATION
                        return Current.ARRIVED_DESTINATION == null;
                    case 152: // NOTIFIED_DESTINATION
                        return Current.NOTIFIED_DESTINATION == null;
                    case 153: // VCE_NOTIFIED
                        return Current.VCE_NOTIFIED == null;
                    case 154: // EXIT_FORM
                        return Current.EXIT_FORM == null;
                    case 155: // TRANSFER_FORM
                        return Current.TRANSFER_FORM == null;
                    case 156: // PARENTAL_APPROVAL_DATE
                        return Current.PARENTAL_APPROVAL_DATE == null;
                    case 157: // PARENTAL_APPROVAL_NOTE
                        return Current.PARENTAL_APPROVAL_NOTE == null;
                    case 158: // DISASTER_EXIT_REASON
                        return Current.DISASTER_EXIT_REASON == null;
                    case 159: // ATTENDANCE_MEMO
                        return Current.ATTENDANCE_MEMO == null;
                    case 160: // ABS_HDAY_PERIOD
                        return Current.ABS_HDAY_PERIOD == null;
                    case 161: // STRE_FLAG
                        return Current.STRE_FLAG == null;
                    case 162: // PROMOTED
                        return Current.PROMOTED == null;
                    case 163: // INAC_ABS_CODE
                        return Current.INAC_ABS_CODE == null;
                    case 164: // LOTE_HOME_CODE
                        return Current.LOTE_HOME_CODE == null;
                    case 165: // VSN
                        return Current.VSN == null;
                    case 166: // SPEC_CURR
                        return Current.SPEC_CURR == null;
                    case 167: // TRANSITION_STATEMENT
                        return Current.TRANSITION_STATEMENT == null;
                    case 168: // TFR_PERMISSION
                        return Current.TFR_PERMISSION == null;
                    case 169: // LEGAL_LIMIT_DECISION
                        return Current.LEGAL_LIMIT_DECISION == null;
                    case 170: // LEGAL_LIMIT_CONTACT
                        return Current.LEGAL_LIMIT_CONTACT == null;
                    case 171: // LEGAL_LIMITATION
                        return Current.LEGAL_LIMITATION == null;
                    case 172: // DOC_COPIES
                        return Current.DOC_COPIES == null;
                    case 173: // LISTED_IN_SOCS
                        return Current.LISTED_IN_SOCS == null;
                    case 174: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES == null;
                    case 175: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT == null;
                    case 176: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT == null;
                    case 177: // SUPPORT_GROUP
                        return Current.SUPPORT_GROUP == null;
                    case 178: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION == null;
                    case 179: // ATTENDANCE_CONCERNS
                        return Current.ATTENDANCE_CONCERNS == null;
                    case 180: // DISCIPLINARY_ACTION
                        return Current.DISCIPLINARY_ACTION == null;
                    case 181: // WELFARE_RISKS
                        return Current.WELFARE_RISKS == null;
                    case 182: // EFFORT
                        return Current.EFFORT == null;
                    case 183: // CLASS_BEHAVIOUR
                        return Current.CLASS_BEHAVIOUR == null;
                    case 184: // ORGANISATION
                        return Current.ORGANISATION == null;
                    case 185: // SOCIAL_BEHAVIOUR
                        return Current.SOCIAL_BEHAVIOUR == null;
                    case 186: // LEARNING_SUPPORT
                        return Current.LEARNING_SUPPORT == null;
                    case 187: // NEW_ARRIVALS_PROGRAM
                        return Current.NEW_ARRIVALS_PROGRAM == null;
                    case 188: // REFUGEE_BACKGROUND
                        return Current.REFUGEE_BACKGROUND == null;
                    case 189: // TRANSFER_DOCS_SENT
                        return Current.TRANSFER_DOCS_SENT == null;
                    case 190: // VET
                        return Current.VET == null;
                    case 191: // USI
                        return Current.USI == null;
                    case 192: // SCH_DEFINED01
                        return Current.SCH_DEFINED01 == null;
                    case 193: // SCH_DEFINED02
                        return Current.SCH_DEFINED02 == null;
                    case 194: // TEACHER_RECOMMENDATION
                        return Current.TEACHER_RECOMMENDATION == null;
                    case 195: // CRIS_ID
                        return Current.CRIS_ID == null;
                    case 196: // YOUNG_CARER
                        return Current.YOUNG_CARER == null;
                    case 197: // GENDER_DESC
                        return Current.GENDER_DESC == null;
                    case 198: // DET_TUTOR
                        return Current.DET_TUTOR == null;
                    case 199: // DET_TUTORNUM
                        return Current.DET_TUTORNUM == null;
                    case 200: // MYLNS_LITERACY
                        return Current.MYLNS_LITERACY == null;
                    case 201: // MYLNS_NUMERACY
                        return Current.MYLNS_NUMERACY == null;
                    case 202: // KLNP_LITERACY
                        return Current.KLNP_LITERACY == null;
                    case 203: // KLNP_NUMERACY
                        return Current.KLNP_NUMERACY == null;
                    case 204: // STUDENT_SI_ID
                        return Current.STUDENT_SI_ID == null;
                    case 205: // ENROLMENT_SI_ID
                        return Current.ENROLMENT_SI_ID == null;
                    case 206: // APPLICATION_SI_ID
                        return Current.APPLICATION_SI_ID == null;
                    case 207: // FLO
                        return Current.FLO == null;
                    case 208: // LW_DATE
                        return Current.LW_DATE == null;
                    case 209: // LW_TIME
                        return Current.LW_TIME == null;
                    case 210: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // STKEY
                        return "STKEY";
                    case 1: // SURNAME
                        return "SURNAME";
                    case 2: // FIRST_NAME
                        return "FIRST_NAME";
                    case 3: // SECOND_NAME
                        return "SECOND_NAME";
                    case 4: // PREF_NAME
                        return "PREF_NAME";
                    case 5: // TITLE
                        return "TITLE";
                    case 6: // FAMILY
                        return "FAMILY";
                    case 7: // ACADEMIC_A
                        return "ACADEMIC_A";
                    case 8: // LIVING_A
                        return "LIVING_A";
                    case 9: // RELATION_A01
                        return "RELATION_A01";
                    case 10: // RELATION_A02
                        return "RELATION_A02";
                    case 11: // CONTACT_A
                        return "CONTACT_A";
                    case 12: // FAMB
                        return "FAMB";
                    case 13: // ACADEMIC_B
                        return "ACADEMIC_B";
                    case 14: // LIVING_B
                        return "LIVING_B";
                    case 15: // RELATION_B01
                        return "RELATION_B01";
                    case 16: // RELATION_B02
                        return "RELATION_B02";
                    case 17: // CONTACT_B
                        return "CONTACT_B";
                    case 18: // FAMC
                        return "FAMC";
                    case 19: // ACADEMIC_C
                        return "ACADEMIC_C";
                    case 20: // LIVING_C
                        return "LIVING_C";
                    case 21: // RELATION_C01
                        return "RELATION_C01";
                    case 22: // RELATION_C02
                        return "RELATION_C02";
                    case 23: // CONTACT_C
                        return "CONTACT_C";
                    case 24: // LIVING_ARR
                        return "LIVING_ARR";
                    case 25: // DIST_SCHL
                        return "DIST_SCHL";
                    case 26: // TRANSPORT
                        return "TRANSPORT";
                    case 27: // CAR_REGO
                        return "CAR_REGO";
                    case 28: // E_MAIL
                        return "E_MAIL";
                    case 29: // MOBILE
                        return "MOBILE";
                    case 30: // MAP_TYPE
                        return "MAP_TYPE";
                    case 31: // MAP_NUM
                        return "MAP_NUM";
                    case 32: // X_AXIS
                        return "X_AXIS";
                    case 33: // Y_AXIS
                        return "Y_AXIS";
                    case 34: // REGISTRATION
                        return "REGISTRATION";
                    case 35: // FIRST_REG_NO
                        return "FIRST_REG_NO";
                    case 36: // GENDER
                        return "GENDER";
                    case 37: // BIRTHDATE
                        return "BIRTHDATE";
                    case 38: // PROOF_DOB
                        return "PROOF_DOB";
                    case 39: // RESIDENT_STATUS
                        return "RESIDENT_STATUS";
                    case 40: // PERMANENT_BASIS
                        return "PERMANENT_BASIS";
                    case 41: // ENTRY
                        return "ENTRY";
                    case 42: // EXIT_DATE
                        return "EXIT_DATE";
                    case 43: // ARRIVAL
                        return "ARRIVAL";
                    case 44: // AUSSIE_SCHOOL
                        return "AUSSIE_SCHOOL";
                    case 45: // INTEGRATION
                        return "INTEGRATION";
                    case 46: // DATELEFT
                        return "DATELEFT";
                    case 47: // EXPIRY_DATE
                        return "EXPIRY_DATE";
                    case 48: // ID_CARD_VALID
                        return "ID_CARD_VALID";
                    case 49: // PREVIOUS_SCHOOL
                        return "PREVIOUS_SCHOOL";
                    case 50: // FAM_ORDER
                        return "FAM_ORDER";
                    case 51: // NOTES
                        return "NOTES";
                    case 52: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 53: // ED_ALLOW
                        return "ED_ALLOW";
                    case 54: // EMA_AMT1P
                        return "EMA_AMT1P";
                    case 55: // EMA_AMT2P
                        return "EMA_AMT2P";
                    case 56: // CASES_EMA_ID
                        return "CASES_EMA_ID";
                    case 57: // STATUS
                        return "STATUS";
                    case 58: // TAG
                        return "TAG";
                    case 59: // ENROLMENT_YEAR
                        return "ENROLMENT_YEAR";
                    case 60: // ADV_SCHL_YR
                        return "ADV_SCHL_YR";
                    case 61: // HOME_GROUP
                        return "HOME_GROUP";
                    case 62: // NEXT_HG
                        return "NEXT_HG";
                    case 63: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 64: // HOUSE
                        return "HOUSE";
                    case 65: // CAMPUS
                        return "CAMPUS";
                    case 66: // LOCKER_NUM
                        return "LOCKER_NUM";
                    case 67: // RELIGION
                        return "RELIGION";
                    case 68: // REL_INSTR
                        return "REL_INSTR";
                    case 69: // VCE_ID
                        return "VCE_ID";
                    case 70: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 71: // VISA_STAT_CODE
                        return "VISA_STAT_CODE";
                    case 72: // VISA_EXPIRY
                        return "VISA_EXPIRY";
                    case 73: // REPEAT
                        return "REPEAT";
                    case 74: // BIRTH_COUNTRY
                        return "BIRTH_COUNTRY";
                    case 75: // ENG_SPEAK
                        return "ENG_SPEAK";
                    case 76: // HOME_LANG
                        return "HOME_LANG";
                    case 77: // OVERSEAS
                        return "OVERSEAS";
                    case 78: // KOORIE
                        return "KOORIE";
                    case 79: // YOUTH_ALLOW
                        return "YOUTH_ALLOW";
                    case 80: // AB_STUDY
                        return "AB_STUDY";
                    case 81: // ACCESS
                        return "ACCESS";
                    case 82: // ACCESS_TYPE
                        return "ACCESS_TYPE";
                    case 83: // ACCESS_ALERT
                        return "ACCESS_ALERT";
                    case 84: // RISK_ALERT
                        return "RISK_ALERT";
                    case 85: // RISK_MEMO
                        return "RISK_MEMO";
                    case 86: // DOCTOR
                        return "DOCTOR";
                    case 87: // EMERG_NAME01
                        return "EMERG_NAME01";
                    case 88: // EMERG_NAME02
                        return "EMERG_NAME02";
                    case 89: // EMERG_LANG01
                        return "EMERG_LANG01";
                    case 90: // EMERG_LANG02
                        return "EMERG_LANG02";
                    case 91: // EMERG_RELATION01
                        return "EMERG_RELATION01";
                    case 92: // EMERG_RELATION02
                        return "EMERG_RELATION02";
                    case 93: // EMERG_CONTACT01
                        return "EMERG_CONTACT01";
                    case 94: // EMERG_CONTACT02
                        return "EMERG_CONTACT02";
                    case 95: // EMERG_CONTACT_MEMO01
                        return "EMERG_CONTACT_MEMO01";
                    case 96: // EMERG_CONTACT_MEMO02
                        return "EMERG_CONTACT_MEMO02";
                    case 97: // ACC_DECLARATION
                        return "ACC_DECLARATION";
                    case 98: // AMBULANCE_SUBSCRIBER
                        return "AMBULANCE_SUBSCRIBER";
                    case 99: // MEDICARE_NO
                        return "MEDICARE_NO";
                    case 100: // INTERNATIONAL_ST_ID
                        return "INTERNATIONAL_ST_ID";
                    case 101: // DISABILITY
                        return "DISABILITY";
                    case 102: // DISABILITY_ID
                        return "DISABILITY_ID";
                    case 103: // PSDREQ
                        return "PSDREQ";
                    case 104: // HEARING_IMPAIR
                        return "HEARING_IMPAIR";
                    case 105: // VISUAL_IMPAIR
                        return "VISUAL_IMPAIR";
                    case 106: // SPEECH_IMPAIR
                        return "SPEECH_IMPAIR";
                    case 107: // PHYSICAL_IMPAIR
                        return "PHYSICAL_IMPAIR";
                    case 108: // MEDICAL_ALERT
                        return "MEDICAL_ALERT";
                    case 109: // MEDICAL_CONDITION
                        return "MEDICAL_CONDITION";
                    case 110: // ACTIVITY_RESTRICTION
                        return "ACTIVITY_RESTRICTION";
                    case 111: // IMMUNISE_CERT_STATUS
                        return "IMMUNISE_CERT_STATUS";
                    case 112: // IMMUN_CERT_SIGHTED
                        return "IMMUN_CERT_SIGHTED";
                    case 113: // IMMUNISE_PERMISSION
                        return "IMMUNISE_PERMISSION";
                    case 114: // IMMUNIZE
                        return "IMMUNIZE";
                    case 115: // DISABILITY_ADJUSTMENT_ASSESSED
                        return "DISABILITY_ADJUSTMENT_ASSESSED";
                    case 116: // DISABILITY_ADJUSTMENT
                        return "DISABILITY_ADJUSTMENT";
                    case 117: // DISABILITY_TYPE
                        return "DISABILITY_TYPE";
                    case 118: // DISABILITY_ADJUSTMENT_LEVEL
                        return "DISABILITY_ADJUSTMENT_LEVEL";
                    case 119: // DISABILITY_ADJUSTMENT_LW_DATE
                        return "DISABILITY_ADJUSTMENT_LW_DATE";
                    case 120: // HEAD_LICE_CHECK
                        return "HEAD_LICE_CHECK";
                    case 121: // ANNUAL_TOT
                        return "ANNUAL_TOT";
                    case 122: // STUDENT_PIC
                        return "STUDENT_PIC";
                    case 123: // PUBLISH_PHOTO_MEDIA
                        return "PUBLISH_PHOTO_MEDIA";
                    case 124: // OK_TO_PUBLISH
                        return "OK_TO_PUBLISH";
                    case 125: // PIC_LW_DATE
                        return "PIC_LW_DATE";
                    case 126: // PIC_STATUS
                        return "PIC_STATUS";
                    case 127: // LIBRARY_FLAG
                        return "LIBRARY_FLAG";
                    case 128: // REGISTRAR_FLAG
                        return "REGISTRAR_FLAG";
                    case 129: // CLEAR1_FLAG
                        return "CLEAR1_FLAG";
                    case 130: // CLEAR2_FLAG
                        return "CLEAR2_FLAG";
                    case 131: // CLEAR3_FLAG
                        return "CLEAR3_FLAG";
                    case 132: // CLEAR4_FLAG
                        return "CLEAR4_FLAG";
                    case 133: // CLEAR5_FLAG
                        return "CLEAR5_FLAG";
                    case 134: // CLEAR6_FLAG
                        return "CLEAR6_FLAG";
                    case 135: // AR_STATUS
                        return "AR_STATUS";
                    case 136: // YEARS_PREVIOUS_EDUCATION
                        return "YEARS_PREVIOUS_EDUCATION";
                    case 137: // YEARS_INTERRUPTION_EDUCATION
                        return "YEARS_INTERRUPTION_EDUCATION";
                    case 138: // LANGUAGE_PREVIOUS_SCHOOLING
                        return "LANGUAGE_PREVIOUS_SCHOOLING";
                    case 139: // NEXT_SCHOOL
                        return "NEXT_SCHOOL";
                    case 140: // EXIT_CAT01
                        return "EXIT_CAT01";
                    case 141: // EXIT_CAT02
                        return "EXIT_CAT02";
                    case 142: // EXIT_DEST01
                        return "EXIT_DEST01";
                    case 143: // EXIT_DEST02
                        return "EXIT_DEST02";
                    case 144: // EXIT_MODIFY_DATE01
                        return "EXIT_MODIFY_DATE01";
                    case 145: // EXIT_MODIFY_DATE02
                        return "EXIT_MODIFY_DATE02";
                    case 146: // FULLTIME
                        return "FULLTIME";
                    case 147: // SGB_TIME_FRACTION
                        return "SGB_TIME_FRACTION";
                    case 148: // ACTUAL_TIME_FRACTION
                        return "ACTUAL_TIME_FRACTION";
                    case 149: // DEST_ARRIVAL_DATE
                        return "DEST_ARRIVAL_DATE";
                    case 150: // DEPARTURE_DATE
                        return "DEPARTURE_DATE";
                    case 151: // ARRIVED_DESTINATION
                        return "ARRIVED_DESTINATION";
                    case 152: // NOTIFIED_DESTINATION
                        return "NOTIFIED_DESTINATION";
                    case 153: // VCE_NOTIFIED
                        return "VCE_NOTIFIED";
                    case 154: // EXIT_FORM
                        return "EXIT_FORM";
                    case 155: // TRANSFER_FORM
                        return "TRANSFER_FORM";
                    case 156: // PARENTAL_APPROVAL_DATE
                        return "PARENTAL_APPROVAL_DATE";
                    case 157: // PARENTAL_APPROVAL_NOTE
                        return "PARENTAL_APPROVAL_NOTE";
                    case 158: // DISASTER_EXIT_REASON
                        return "DISASTER_EXIT_REASON";
                    case 159: // ATTENDANCE_MEMO
                        return "ATTENDANCE_MEMO";
                    case 160: // ABS_HDAY_PERIOD
                        return "ABS_HDAY_PERIOD";
                    case 161: // STRE_FLAG
                        return "STRE_FLAG";
                    case 162: // PROMOTED
                        return "PROMOTED";
                    case 163: // INAC_ABS_CODE
                        return "INAC_ABS_CODE";
                    case 164: // LOTE_HOME_CODE
                        return "LOTE_HOME_CODE";
                    case 165: // VSN
                        return "VSN";
                    case 166: // SPEC_CURR
                        return "SPEC_CURR";
                    case 167: // TRANSITION_STATEMENT
                        return "TRANSITION_STATEMENT";
                    case 168: // TFR_PERMISSION
                        return "TFR_PERMISSION";
                    case 169: // LEGAL_LIMIT_DECISION
                        return "LEGAL_LIMIT_DECISION";
                    case 170: // LEGAL_LIMIT_CONTACT
                        return "LEGAL_LIMIT_CONTACT";
                    case 171: // LEGAL_LIMITATION
                        return "LEGAL_LIMITATION";
                    case 172: // DOC_COPIES
                        return "DOC_COPIES";
                    case 173: // LISTED_IN_SOCS
                        return "LISTED_IN_SOCS";
                    case 174: // SUPPORT_SERVICES
                        return "SUPPORT_SERVICES";
                    case 175: // STUDENT_SUPPORT
                        return "STUDENT_SUPPORT";
                    case 176: // STUDENT_OTHER_SUPPORT
                        return "STUDENT_OTHER_SUPPORT";
                    case 177: // SUPPORT_GROUP
                        return "SUPPORT_GROUP";
                    case 178: // CHILD_PROTECTION
                        return "CHILD_PROTECTION";
                    case 179: // ATTENDANCE_CONCERNS
                        return "ATTENDANCE_CONCERNS";
                    case 180: // DISCIPLINARY_ACTION
                        return "DISCIPLINARY_ACTION";
                    case 181: // WELFARE_RISKS
                        return "WELFARE_RISKS";
                    case 182: // EFFORT
                        return "EFFORT";
                    case 183: // CLASS_BEHAVIOUR
                        return "CLASS_BEHAVIOUR";
                    case 184: // ORGANISATION
                        return "ORGANISATION";
                    case 185: // SOCIAL_BEHAVIOUR
                        return "SOCIAL_BEHAVIOUR";
                    case 186: // LEARNING_SUPPORT
                        return "LEARNING_SUPPORT";
                    case 187: // NEW_ARRIVALS_PROGRAM
                        return "NEW_ARRIVALS_PROGRAM";
                    case 188: // REFUGEE_BACKGROUND
                        return "REFUGEE_BACKGROUND";
                    case 189: // TRANSFER_DOCS_SENT
                        return "TRANSFER_DOCS_SENT";
                    case 190: // VET
                        return "VET";
                    case 191: // USI
                        return "USI";
                    case 192: // SCH_DEFINED01
                        return "SCH_DEFINED01";
                    case 193: // SCH_DEFINED02
                        return "SCH_DEFINED02";
                    case 194: // TEACHER_RECOMMENDATION
                        return "TEACHER_RECOMMENDATION";
                    case 195: // CRIS_ID
                        return "CRIS_ID";
                    case 196: // YOUNG_CARER
                        return "YOUNG_CARER";
                    case 197: // GENDER_DESC
                        return "GENDER_DESC";
                    case 198: // DET_TUTOR
                        return "DET_TUTOR";
                    case 199: // DET_TUTORNUM
                        return "DET_TUTORNUM";
                    case 200: // MYLNS_LITERACY
                        return "MYLNS_LITERACY";
                    case 201: // MYLNS_NUMERACY
                        return "MYLNS_NUMERACY";
                    case 202: // KLNP_LITERACY
                        return "KLNP_LITERACY";
                    case 203: // KLNP_NUMERACY
                        return "KLNP_NUMERACY";
                    case 204: // STUDENT_SI_ID
                        return "STUDENT_SI_ID";
                    case 205: // ENROLMENT_SI_ID
                        return "ENROLMENT_SI_ID";
                    case 206: // APPLICATION_SI_ID
                        return "APPLICATION_SI_ID";
                    case 207: // FLO
                        return "FLO";
                    case 208: // LW_DATE
                        return "LW_DATE";
                    case 209: // LW_TIME
                        return "LW_TIME";
                    case 210: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "STKEY":
                        return 0;
                    case "SURNAME":
                        return 1;
                    case "FIRST_NAME":
                        return 2;
                    case "SECOND_NAME":
                        return 3;
                    case "PREF_NAME":
                        return 4;
                    case "TITLE":
                        return 5;
                    case "FAMILY":
                        return 6;
                    case "ACADEMIC_A":
                        return 7;
                    case "LIVING_A":
                        return 8;
                    case "RELATION_A01":
                        return 9;
                    case "RELATION_A02":
                        return 10;
                    case "CONTACT_A":
                        return 11;
                    case "FAMB":
                        return 12;
                    case "ACADEMIC_B":
                        return 13;
                    case "LIVING_B":
                        return 14;
                    case "RELATION_B01":
                        return 15;
                    case "RELATION_B02":
                        return 16;
                    case "CONTACT_B":
                        return 17;
                    case "FAMC":
                        return 18;
                    case "ACADEMIC_C":
                        return 19;
                    case "LIVING_C":
                        return 20;
                    case "RELATION_C01":
                        return 21;
                    case "RELATION_C02":
                        return 22;
                    case "CONTACT_C":
                        return 23;
                    case "LIVING_ARR":
                        return 24;
                    case "DIST_SCHL":
                        return 25;
                    case "TRANSPORT":
                        return 26;
                    case "CAR_REGO":
                        return 27;
                    case "E_MAIL":
                        return 28;
                    case "MOBILE":
                        return 29;
                    case "MAP_TYPE":
                        return 30;
                    case "MAP_NUM":
                        return 31;
                    case "X_AXIS":
                        return 32;
                    case "Y_AXIS":
                        return 33;
                    case "REGISTRATION":
                        return 34;
                    case "FIRST_REG_NO":
                        return 35;
                    case "GENDER":
                        return 36;
                    case "BIRTHDATE":
                        return 37;
                    case "PROOF_DOB":
                        return 38;
                    case "RESIDENT_STATUS":
                        return 39;
                    case "PERMANENT_BASIS":
                        return 40;
                    case "ENTRY":
                        return 41;
                    case "EXIT_DATE":
                        return 42;
                    case "ARRIVAL":
                        return 43;
                    case "AUSSIE_SCHOOL":
                        return 44;
                    case "INTEGRATION":
                        return 45;
                    case "DATELEFT":
                        return 46;
                    case "EXPIRY_DATE":
                        return 47;
                    case "ID_CARD_VALID":
                        return 48;
                    case "PREVIOUS_SCHOOL":
                        return 49;
                    case "FAM_ORDER":
                        return 50;
                    case "NOTES":
                        return 51;
                    case "SGB_FUNDED":
                        return 52;
                    case "ED_ALLOW":
                        return 53;
                    case "EMA_AMT1P":
                        return 54;
                    case "EMA_AMT2P":
                        return 55;
                    case "CASES_EMA_ID":
                        return 56;
                    case "STATUS":
                        return 57;
                    case "TAG":
                        return 58;
                    case "ENROLMENT_YEAR":
                        return 59;
                    case "ADV_SCHL_YR":
                        return 60;
                    case "HOME_GROUP":
                        return 61;
                    case "NEXT_HG":
                        return 62;
                    case "SCHOOL_YEAR":
                        return 63;
                    case "HOUSE":
                        return 64;
                    case "CAMPUS":
                        return 65;
                    case "LOCKER_NUM":
                        return 66;
                    case "RELIGION":
                        return 67;
                    case "REL_INSTR":
                        return 68;
                    case "VCE_ID":
                        return 69;
                    case "VISA_SUBCLASS":
                        return 70;
                    case "VISA_STAT_CODE":
                        return 71;
                    case "VISA_EXPIRY":
                        return 72;
                    case "REPEAT":
                        return 73;
                    case "BIRTH_COUNTRY":
                        return 74;
                    case "ENG_SPEAK":
                        return 75;
                    case "HOME_LANG":
                        return 76;
                    case "OVERSEAS":
                        return 77;
                    case "KOORIE":
                        return 78;
                    case "YOUTH_ALLOW":
                        return 79;
                    case "AB_STUDY":
                        return 80;
                    case "ACCESS":
                        return 81;
                    case "ACCESS_TYPE":
                        return 82;
                    case "ACCESS_ALERT":
                        return 83;
                    case "RISK_ALERT":
                        return 84;
                    case "RISK_MEMO":
                        return 85;
                    case "DOCTOR":
                        return 86;
                    case "EMERG_NAME01":
                        return 87;
                    case "EMERG_NAME02":
                        return 88;
                    case "EMERG_LANG01":
                        return 89;
                    case "EMERG_LANG02":
                        return 90;
                    case "EMERG_RELATION01":
                        return 91;
                    case "EMERG_RELATION02":
                        return 92;
                    case "EMERG_CONTACT01":
                        return 93;
                    case "EMERG_CONTACT02":
                        return 94;
                    case "EMERG_CONTACT_MEMO01":
                        return 95;
                    case "EMERG_CONTACT_MEMO02":
                        return 96;
                    case "ACC_DECLARATION":
                        return 97;
                    case "AMBULANCE_SUBSCRIBER":
                        return 98;
                    case "MEDICARE_NO":
                        return 99;
                    case "INTERNATIONAL_ST_ID":
                        return 100;
                    case "DISABILITY":
                        return 101;
                    case "DISABILITY_ID":
                        return 102;
                    case "PSDREQ":
                        return 103;
                    case "HEARING_IMPAIR":
                        return 104;
                    case "VISUAL_IMPAIR":
                        return 105;
                    case "SPEECH_IMPAIR":
                        return 106;
                    case "PHYSICAL_IMPAIR":
                        return 107;
                    case "MEDICAL_ALERT":
                        return 108;
                    case "MEDICAL_CONDITION":
                        return 109;
                    case "ACTIVITY_RESTRICTION":
                        return 110;
                    case "IMMUNISE_CERT_STATUS":
                        return 111;
                    case "IMMUN_CERT_SIGHTED":
                        return 112;
                    case "IMMUNISE_PERMISSION":
                        return 113;
                    case "IMMUNIZE":
                        return 114;
                    case "DISABILITY_ADJUSTMENT_ASSESSED":
                        return 115;
                    case "DISABILITY_ADJUSTMENT":
                        return 116;
                    case "DISABILITY_TYPE":
                        return 117;
                    case "DISABILITY_ADJUSTMENT_LEVEL":
                        return 118;
                    case "DISABILITY_ADJUSTMENT_LW_DATE":
                        return 119;
                    case "HEAD_LICE_CHECK":
                        return 120;
                    case "ANNUAL_TOT":
                        return 121;
                    case "STUDENT_PIC":
                        return 122;
                    case "PUBLISH_PHOTO_MEDIA":
                        return 123;
                    case "OK_TO_PUBLISH":
                        return 124;
                    case "PIC_LW_DATE":
                        return 125;
                    case "PIC_STATUS":
                        return 126;
                    case "LIBRARY_FLAG":
                        return 127;
                    case "REGISTRAR_FLAG":
                        return 128;
                    case "CLEAR1_FLAG":
                        return 129;
                    case "CLEAR2_FLAG":
                        return 130;
                    case "CLEAR3_FLAG":
                        return 131;
                    case "CLEAR4_FLAG":
                        return 132;
                    case "CLEAR5_FLAG":
                        return 133;
                    case "CLEAR6_FLAG":
                        return 134;
                    case "AR_STATUS":
                        return 135;
                    case "YEARS_PREVIOUS_EDUCATION":
                        return 136;
                    case "YEARS_INTERRUPTION_EDUCATION":
                        return 137;
                    case "LANGUAGE_PREVIOUS_SCHOOLING":
                        return 138;
                    case "NEXT_SCHOOL":
                        return 139;
                    case "EXIT_CAT01":
                        return 140;
                    case "EXIT_CAT02":
                        return 141;
                    case "EXIT_DEST01":
                        return 142;
                    case "EXIT_DEST02":
                        return 143;
                    case "EXIT_MODIFY_DATE01":
                        return 144;
                    case "EXIT_MODIFY_DATE02":
                        return 145;
                    case "FULLTIME":
                        return 146;
                    case "SGB_TIME_FRACTION":
                        return 147;
                    case "ACTUAL_TIME_FRACTION":
                        return 148;
                    case "DEST_ARRIVAL_DATE":
                        return 149;
                    case "DEPARTURE_DATE":
                        return 150;
                    case "ARRIVED_DESTINATION":
                        return 151;
                    case "NOTIFIED_DESTINATION":
                        return 152;
                    case "VCE_NOTIFIED":
                        return 153;
                    case "EXIT_FORM":
                        return 154;
                    case "TRANSFER_FORM":
                        return 155;
                    case "PARENTAL_APPROVAL_DATE":
                        return 156;
                    case "PARENTAL_APPROVAL_NOTE":
                        return 157;
                    case "DISASTER_EXIT_REASON":
                        return 158;
                    case "ATTENDANCE_MEMO":
                        return 159;
                    case "ABS_HDAY_PERIOD":
                        return 160;
                    case "STRE_FLAG":
                        return 161;
                    case "PROMOTED":
                        return 162;
                    case "INAC_ABS_CODE":
                        return 163;
                    case "LOTE_HOME_CODE":
                        return 164;
                    case "VSN":
                        return 165;
                    case "SPEC_CURR":
                        return 166;
                    case "TRANSITION_STATEMENT":
                        return 167;
                    case "TFR_PERMISSION":
                        return 168;
                    case "LEGAL_LIMIT_DECISION":
                        return 169;
                    case "LEGAL_LIMIT_CONTACT":
                        return 170;
                    case "LEGAL_LIMITATION":
                        return 171;
                    case "DOC_COPIES":
                        return 172;
                    case "LISTED_IN_SOCS":
                        return 173;
                    case "SUPPORT_SERVICES":
                        return 174;
                    case "STUDENT_SUPPORT":
                        return 175;
                    case "STUDENT_OTHER_SUPPORT":
                        return 176;
                    case "SUPPORT_GROUP":
                        return 177;
                    case "CHILD_PROTECTION":
                        return 178;
                    case "ATTENDANCE_CONCERNS":
                        return 179;
                    case "DISCIPLINARY_ACTION":
                        return 180;
                    case "WELFARE_RISKS":
                        return 181;
                    case "EFFORT":
                        return 182;
                    case "CLASS_BEHAVIOUR":
                        return 183;
                    case "ORGANISATION":
                        return 184;
                    case "SOCIAL_BEHAVIOUR":
                        return 185;
                    case "LEARNING_SUPPORT":
                        return 186;
                    case "NEW_ARRIVALS_PROGRAM":
                        return 187;
                    case "REFUGEE_BACKGROUND":
                        return 188;
                    case "TRANSFER_DOCS_SENT":
                        return 189;
                    case "VET":
                        return 190;
                    case "USI":
                        return 191;
                    case "SCH_DEFINED01":
                        return 192;
                    case "SCH_DEFINED02":
                        return 193;
                    case "TEACHER_RECOMMENDATION":
                        return 194;
                    case "CRIS_ID":
                        return 195;
                    case "YOUNG_CARER":
                        return 196;
                    case "GENDER_DESC":
                        return 197;
                    case "DET_TUTOR":
                        return 198;
                    case "DET_TUTORNUM":
                        return 199;
                    case "MYLNS_LITERACY":
                        return 200;
                    case "MYLNS_NUMERACY":
                        return 201;
                    case "KLNP_LITERACY":
                        return 202;
                    case "KLNP_NUMERACY":
                        return 203;
                    case "STUDENT_SI_ID":
                        return 204;
                    case "ENROLMENT_SI_ID":
                        return 205;
                    case "APPLICATION_SI_ID":
                        return 206;
                    case "FLO":
                        return 207;
                    case "LW_DATE":
                        return 208;
                    case "LW_TIME":
                        return 209;
                    case "LW_USER":
                        return 210;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
