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
    /// Families Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFDataSet : EduHubDataSet<DF>
    {
        /// <inheritdoc />
        public override string Name { get { return "DF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal DFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BILLINGKEY = new Lazy<NullDictionary<int?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.BILLINGKEY));
            Index_BIRTH_COUNTRY_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY_A));
            Index_BIRTH_COUNTRY_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY_B));
            Index_BPAY_REFERENCE = new Lazy<NullDictionary<string, DF>>(() => this.ToNullDictionary(i => i.BPAY_REFERENCE));
            Index_DFKEY = new Lazy<Dictionary<string, DF>>(() => this.ToDictionary(i => i.DFKEY));
            Index_DOCTOR = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.DOCTOR));
            Index_EMERG_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG01));
            Index_EMERG_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG02));
            Index_EMERG_LANG03 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG03));
            Index_EMERG_LANG04 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG04));
            Index_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANG));
            Index_HOMEKEY = new Lazy<NullDictionary<int?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.HOMEKEY));
            Index_LOTE_HOME_CODE_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.LOTE_HOME_CODE_A));
            Index_LOTE_HOME_CODE_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.LOTE_HOME_CODE_B));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE = new Lazy<Dictionary<Tuple<string, string, string, string, int?>, IReadOnlyList<DF>>>(() => this.ToGroupedDictionary(i => Tuple.Create(i.NAME_A, i.SURNAME_A, i.NAME_B, i.SURNAME_B, i.BPAY_SEQUENCE)));
            Index_NATIVE_LANG_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.NATIVE_LANG_A));
            Index_NATIVE_LANG_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.NATIVE_LANG_B));
            Index_OTHER_LANG_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.OTHER_LANG_A));
            Index_OTHER_LANG_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.OTHER_LANG_B));
            Index_PREF_NOTICE_LANG = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.PREF_NOTICE_LANG));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DF" /> fields for each CSV column header</returns>
        internal override Action<DF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DFKEY":
                        mapper[i] = (e, v) => e.DFKEY = v;
                        break;
                    case "NAME_A":
                        mapper[i] = (e, v) => e.NAME_A = v;
                        break;
                    case "SURNAME_A":
                        mapper[i] = (e, v) => e.SURNAME_A = v;
                        break;
                    case "TITLE_A":
                        mapper[i] = (e, v) => e.TITLE_A = v;
                        break;
                    case "WORK_CONT_A":
                        mapper[i] = (e, v) => e.WORK_CONT_A = v;
                        break;
                    case "OCCUPATION_A":
                        mapper[i] = (e, v) => e.OCCUPATION_A = v;
                        break;
                    case "EMPLOYER_A":
                        mapper[i] = (e, v) => e.EMPLOYER_A = v;
                        break;
                    case "NATIVE_LANG_A":
                        mapper[i] = (e, v) => e.NATIVE_LANG_A = v;
                        break;
                    case "OTHER_LANG_A":
                        mapper[i] = (e, v) => e.OTHER_LANG_A = v;
                        break;
                    case "INTERPRETER_A":
                        mapper[i] = (e, v) => e.INTERPRETER_A = v;
                        break;
                    case "BIRTH_COUNTRY_A":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY_A = v;
                        break;
                    case "BH_AT_HOME_A":
                        mapper[i] = (e, v) => e.BH_AT_HOME_A = v;
                        break;
                    case "BH_CONTACT_A":
                        mapper[i] = (e, v) => e.BH_CONTACT_A = v;
                        break;
                    case "BH_CONTACT_A_MEMO":
                        mapper[i] = (e, v) => e.BH_CONTACT_A_MEMO = v;
                        break;
                    case "AH_AT_HOME_A":
                        mapper[i] = (e, v) => e.AH_AT_HOME_A = v;
                        break;
                    case "AH_CONTACT_A":
                        mapper[i] = (e, v) => e.AH_CONTACT_A = v;
                        break;
                    case "AH_CONTACT_A_MEMO":
                        mapper[i] = (e, v) => e.AH_CONTACT_A_MEMO = v;
                        break;
                    case "E_MAIL_A":
                        mapper[i] = (e, v) => e.E_MAIL_A = v;
                        break;
                    case "PREF_MAIL_MECH_A":
                        mapper[i] = (e, v) => e.PREF_MAIL_MECH_A = v;
                        break;
                    case "FAX_A":
                        mapper[i] = (e, v) => e.FAX_A = v;
                        break;
                    case "GENDER_A":
                        mapper[i] = (e, v) => e.GENDER_A = v;
                        break;
                    case "SCH_ED_A":
                        mapper[i] = (e, v) => e.SCH_ED_A = v;
                        break;
                    case "NON_SCH_ED_A":
                        mapper[i] = (e, v) => e.NON_SCH_ED_A = v;
                        break;
                    case "OCCUP_STATUS_A":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_A = v;
                        break;
                    case "LOTE_HOME_CODE_A":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE_A = v;
                        break;
                    case "MOBILE_A":
                        mapper[i] = (e, v) => e.MOBILE_A = v;
                        break;
                    case "SMS_NOTIFY_A":
                        mapper[i] = (e, v) => e.SMS_NOTIFY_A = v;
                        break;
                    case "E_MAIL_NOTIFY_A":
                        mapper[i] = (e, v) => e.E_MAIL_NOTIFY_A = v;
                        break;
                    case "WWCC_NUMBER_A":
                        mapper[i] = (e, v) => e.WWCC_NUMBER_A = v;
                        break;
                    case "WWCC_EXPIRY_A":
                        mapper[i] = (e, v) => e.WWCC_EXPIRY_A = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "WWCC_TYPE_A":
                        mapper[i] = (e, v) => e.WWCC_TYPE_A = v;
                        break;
                    case "NAME_B":
                        mapper[i] = (e, v) => e.NAME_B = v;
                        break;
                    case "SURNAME_B":
                        mapper[i] = (e, v) => e.SURNAME_B = v;
                        break;
                    case "TITLE_B":
                        mapper[i] = (e, v) => e.TITLE_B = v;
                        break;
                    case "WORK_CONT_B":
                        mapper[i] = (e, v) => e.WORK_CONT_B = v;
                        break;
                    case "OCCUPATION_B":
                        mapper[i] = (e, v) => e.OCCUPATION_B = v;
                        break;
                    case "EMPLOYER_B":
                        mapper[i] = (e, v) => e.EMPLOYER_B = v;
                        break;
                    case "NATIVE_LANG_B":
                        mapper[i] = (e, v) => e.NATIVE_LANG_B = v;
                        break;
                    case "OTHER_LANG_B":
                        mapper[i] = (e, v) => e.OTHER_LANG_B = v;
                        break;
                    case "INTERPRETER_B":
                        mapper[i] = (e, v) => e.INTERPRETER_B = v;
                        break;
                    case "BIRTH_COUNTRY_B":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY_B = v;
                        break;
                    case "BH_AT_HOME_B":
                        mapper[i] = (e, v) => e.BH_AT_HOME_B = v;
                        break;
                    case "BH_CONTACT_B":
                        mapper[i] = (e, v) => e.BH_CONTACT_B = v;
                        break;
                    case "BH_CONTACT_B_MEMO":
                        mapper[i] = (e, v) => e.BH_CONTACT_B_MEMO = v;
                        break;
                    case "AH_AT_HOME_B":
                        mapper[i] = (e, v) => e.AH_AT_HOME_B = v;
                        break;
                    case "AH_CONTACT_B":
                        mapper[i] = (e, v) => e.AH_CONTACT_B = v;
                        break;
                    case "AH_CONTACT_B_MEMO":
                        mapper[i] = (e, v) => e.AH_CONTACT_B_MEMO = v;
                        break;
                    case "E_MAIL_B":
                        mapper[i] = (e, v) => e.E_MAIL_B = v;
                        break;
                    case "PREF_MAIL_MECH_B":
                        mapper[i] = (e, v) => e.PREF_MAIL_MECH_B = v;
                        break;
                    case "FAX_B":
                        mapper[i] = (e, v) => e.FAX_B = v;
                        break;
                    case "GENDER_B":
                        mapper[i] = (e, v) => e.GENDER_B = v;
                        break;
                    case "SCH_ED_B":
                        mapper[i] = (e, v) => e.SCH_ED_B = v;
                        break;
                    case "NON_SCH_ED_B":
                        mapper[i] = (e, v) => e.NON_SCH_ED_B = v;
                        break;
                    case "OCCUP_STATUS_B":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_B = v;
                        break;
                    case "LOTE_HOME_CODE_B":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE_B = v;
                        break;
                    case "MOBILE_B":
                        mapper[i] = (e, v) => e.MOBILE_B = v;
                        break;
                    case "SMS_NOTIFY_B":
                        mapper[i] = (e, v) => e.SMS_NOTIFY_B = v;
                        break;
                    case "E_MAIL_NOTIFY_B":
                        mapper[i] = (e, v) => e.E_MAIL_NOTIFY_B = v;
                        break;
                    case "WWCC_NUMBER_B":
                        mapper[i] = (e, v) => e.WWCC_NUMBER_B = v;
                        break;
                    case "WWCC_EXPIRY_B":
                        mapper[i] = (e, v) => e.WWCC_EXPIRY_B = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "WWCC_TYPE_B":
                        mapper[i] = (e, v) => e.WWCC_TYPE_B = v;
                        break;
                    case "PREF_NOTICE_LANG":
                        mapper[i] = (e, v) => e.PREF_NOTICE_LANG = v;
                        break;
                    case "GROUP_AVAILABILITY":
                        mapper[i] = (e, v) => e.GROUP_AVAILABILITY = v;
                        break;
                    case "OCCUP_STATUS_GRP":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_GRP = v;
                        break;
                    case "HOMETITLE":
                        mapper[i] = (e, v) => e.HOMETITLE = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILTITLE":
                        mapper[i] = (e, v) => e.MAILTITLE = v;
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BILLINGTITLE":
                        mapper[i] = (e, v) => e.BILLINGTITLE = v;
                        break;
                    case "BILLINGKEY":
                        mapper[i] = (e, v) => e.BILLINGKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BILLING_MEMO":
                        mapper[i] = (e, v) => e.BILLING_MEMO = v;
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGED01":
                        mapper[i] = (e, v) => e.AGED01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED02":
                        mapper[i] = (e, v) => e.AGED02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED03":
                        mapper[i] = (e, v) => e.AGED03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED04":
                        mapper[i] = (e, v) => e.AGED04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED05":
                        mapper[i] = (e, v) => e.AGED05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES":
                        mapper[i] = (e, v) => e.CHARGES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTREC":
                        mapper[i] = (e, v) => e.LASTREC = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTRECDATE":
                        mapper[i] = (e, v) => e.LASTRECDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL_YEAR":
                        mapper[i] = (e, v) => e.OPBAL_YEAR = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PRICELEVEL":
                        mapper[i] = (e, v) => e.PRICELEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BPAY_SEQUENCE":
                        mapper[i] = (e, v) => e.BPAY_SEQUENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "NO_STUDENTS":
                        mapper[i] = (e, v) => e.NO_STUDENTS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NO_ASSOC_STUDENTS":
                        mapper[i] = (e, v) => e.NO_ASSOC_STUDENTS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREDIT_LIMIT":
                        mapper[i] = (e, v) => e.CREDIT_LIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BILL_GROUP":
                        mapper[i] = (e, v) => e.BILL_GROUP = v;
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
                    case "EMERG_NAME03":
                        mapper[i] = (e, v) => e.EMERG_NAME03 = v;
                        break;
                    case "EMERG_NAME04":
                        mapper[i] = (e, v) => e.EMERG_NAME04 = v;
                        break;
                    case "EMERG_RELATION01":
                        mapper[i] = (e, v) => e.EMERG_RELATION01 = v;
                        break;
                    case "EMERG_RELATION02":
                        mapper[i] = (e, v) => e.EMERG_RELATION02 = v;
                        break;
                    case "EMERG_RELATION03":
                        mapper[i] = (e, v) => e.EMERG_RELATION03 = v;
                        break;
                    case "EMERG_RELATION04":
                        mapper[i] = (e, v) => e.EMERG_RELATION04 = v;
                        break;
                    case "EMERG_LANG01":
                        mapper[i] = (e, v) => e.EMERG_LANG01 = v;
                        break;
                    case "EMERG_LANG02":
                        mapper[i] = (e, v) => e.EMERG_LANG02 = v;
                        break;
                    case "EMERG_LANG03":
                        mapper[i] = (e, v) => e.EMERG_LANG03 = v;
                        break;
                    case "EMERG_LANG04":
                        mapper[i] = (e, v) => e.EMERG_LANG04 = v;
                        break;
                    case "EMERG_CONTACT01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT01 = v;
                        break;
                    case "EMERG_CONTACT02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT02 = v;
                        break;
                    case "EMERG_CONTACT03":
                        mapper[i] = (e, v) => e.EMERG_CONTACT03 = v;
                        break;
                    case "EMERG_CONTACT04":
                        mapper[i] = (e, v) => e.EMERG_CONTACT04 = v;
                        break;
                    case "EMERG_CONTACT_MEMO01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO01 = v;
                        break;
                    case "EMERG_CONTACT_MEMO02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO02 = v;
                        break;
                    case "EMERG_CONTACT_MEMO03":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO03 = v;
                        break;
                    case "EMERG_CONTACT_MEMO04":
                        mapper[i] = (e, v) => e.EMERG_CONTACT_MEMO04 = v;
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
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "DRAWER":
                        mapper[i] = (e, v) => e.DRAWER = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "TAX_INVOICE":
                        mapper[i] = (e, v) => e.TAX_INVOICE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "BILLING_EMAIL":
                        mapper[i] = (e, v) => e.BILLING_EMAIL = v;
                        break;
                    case "PREF_EMAIL":
                        mapper[i] = (e, v) => e.PREF_EMAIL = v;
                        break;
                    case "USER_NAME":
                        mapper[i] = (e, v) => e.USER_NAME = v;
                        break;
                    case "WEB_ENABLED":
                        mapper[i] = (e, v) => e.WEB_ENABLED = v;
                        break;
                    case "CASES_KEY":
                        mapper[i] = (e, v) => e.CASES_KEY = v;
                        break;
                    case "EMA_APPLY_DATE":
                        mapper[i] = (e, v) => e.EMA_APPLY_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EMA_APPLY":
                        mapper[i] = (e, v) => e.EMA_APPLY = v;
                        break;
                    case "DSS_SURNAME":
                        mapper[i] = (e, v) => e.DSS_SURNAME = v;
                        break;
                    case "DSS_FIRST_NAME":
                        mapper[i] = (e, v) => e.DSS_FIRST_NAME = v;
                        break;
                    case "SSN_ELIG_CODE":
                        mapper[i] = (e, v) => e.SSN_ELIG_CODE = v;
                        break;
                    case "SSN":
                        mapper[i] = (e, v) => e.SSN = v;
                        break;
                    case "EMA_TOTAL1P":
                        mapper[i] = (e, v) => e.EMA_TOTAL1P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMA_STAT1P":
                        mapper[i] = (e, v) => e.EMA_STAT1P = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EMA_TOTAL2P":
                        mapper[i] = (e, v) => e.EMA_TOTAL2P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMA_STAT2P":
                        mapper[i] = (e, v) => e.EMA_STAT2P = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EMA_CLAIM_VN":
                        mapper[i] = (e, v) => e.EMA_CLAIM_VN = v;
                        break;
                    case "EMA_SEND":
                        mapper[i] = (e, v) => e.EMA_SEND = v;
                        break;
                    case "EMA_CLAIM_PD":
                        mapper[i] = (e, v) => e.EMA_CLAIM_PD = v;
                        break;
                    case "CASES_EMA_ID":
                        mapper[i] = (e, v) => e.CASES_EMA_ID = v;
                        break;
                    case "SCH_ED_A_LU":
                        mapper[i] = (e, v) => e.SCH_ED_A_LU = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "NON_SCH_ED_A_LU":
                        mapper[i] = (e, v) => e.NON_SCH_ED_A_LU = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "OCCUP_STATUS_A_LU":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_A_LU = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SCH_ED_B_LU":
                        mapper[i] = (e, v) => e.SCH_ED_B_LU = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "NON_SCH_ED_B_LU":
                        mapper[i] = (e, v) => e.NON_SCH_ED_B_LU = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "OCCUP_STATUS_B_LU":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_B_LU = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CNSE":
                        mapper[i] = (e, v) => e.CNSE = v;
                        break;
                    case "CSE":
                        mapper[i] = (e, v) => e.CSE = v;
                        break;
                    case "FSE":
                        mapper[i] = (e, v) => e.FSE = v;
                        break;
                    case "GENDER_DESC_A":
                        mapper[i] = (e, v) => e.GENDER_DESC_A = v;
                        break;
                    case "GENDER_DESC_B":
                        mapper[i] = (e, v) => e.GENDER_DESC_B = v;
                        break;
                    case "PARENT_A_SI_ID":
                        mapper[i] = (e, v) => e.PARENT_A_SI_ID = v;
                        break;
                    case "PARENT_B_SI_ID":
                        mapper[i] = (e, v) => e.PARENT_B_SI_ID = v;
                        break;
                    case "HEALTH_SUM_SI_ID":
                        mapper[i] = (e, v) => e.HEALTH_SUM_SI_ID = v;
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
        /// Merges <see cref="DF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="DF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="DF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{DF}"/> of entities</returns>
        internal override IEnumerable<DF> ApplyDeltaEntities(IEnumerable<DF> Entities, List<DF> DeltaEntities)
        {
            HashSet<string> Index_BPAY_REFERENCE = new HashSet<string>(DeltaEntities.Select(i => i.BPAY_REFERENCE));
            HashSet<string> Index_DFKEY = new HashSet<string>(DeltaEntities.Select(i => i.DFKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.DFKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_BPAY_REFERENCE.Remove(entity.BPAY_REFERENCE);
                            overwritten = overwritten || Index_DFKEY.Remove(entity.DFKEY);
                            
                            if (entity.DFKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<DF>>> Index_BILLINGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_BIRTH_COUNTRY_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_BIRTH_COUNTRY_B;
        private Lazy<NullDictionary<string, DF>> Index_BPAY_REFERENCE;
        private Lazy<Dictionary<string, DF>> Index_DFKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_DOCTOR;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG02;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG03;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG04;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_HOME_LANG;
        private Lazy<NullDictionary<int?, IReadOnlyList<DF>>> Index_HOMEKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_LOTE_HOME_CODE_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_LOTE_HOME_CODE_B;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<DF>>> Index_LW_DATE;
        private Lazy<NullDictionary<int?, IReadOnlyList<DF>>> Index_MAILKEY;
        private Lazy<Dictionary<Tuple<string, string, string, string, int?>, IReadOnlyList<DF>>> Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_NATIVE_LANG_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_NATIVE_LANG_B;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_OTHER_LANG_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_OTHER_LANG_B;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_PREF_NOTICE_LANG;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DF by BILLINGKEY field
        /// </summary>
        /// <param name="BILLINGKEY">BILLINGKEY value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByBILLINGKEY(int? BILLINGKEY)
        {
            return Index_BILLINGKEY.Value[BILLINGKEY];
        }

        /// <summary>
        /// Attempt to find DF by BILLINGKEY field
        /// </summary>
        /// <param name="BILLINGKEY">BILLINGKEY value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBILLINGKEY(int? BILLINGKEY, out IReadOnlyList<DF> Value)
        {
            return Index_BILLINGKEY.Value.TryGetValue(BILLINGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DF by BILLINGKEY field
        /// </summary>
        /// <param name="BILLINGKEY">BILLINGKEY value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByBILLINGKEY(int? BILLINGKEY)
        {
            IReadOnlyList<DF> value;
            if (Index_BILLINGKEY.Value.TryGetValue(BILLINGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by BIRTH_COUNTRY_A field
        /// </summary>
        /// <param name="BIRTH_COUNTRY_A">BIRTH_COUNTRY_A value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByBIRTH_COUNTRY_A(string BIRTH_COUNTRY_A)
        {
            return Index_BIRTH_COUNTRY_A.Value[BIRTH_COUNTRY_A];
        }

        /// <summary>
        /// Attempt to find DF by BIRTH_COUNTRY_A field
        /// </summary>
        /// <param name="BIRTH_COUNTRY_A">BIRTH_COUNTRY_A value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBIRTH_COUNTRY_A(string BIRTH_COUNTRY_A, out IReadOnlyList<DF> Value)
        {
            return Index_BIRTH_COUNTRY_A.Value.TryGetValue(BIRTH_COUNTRY_A, out Value);
        }

        /// <summary>
        /// Attempt to find DF by BIRTH_COUNTRY_A field
        /// </summary>
        /// <param name="BIRTH_COUNTRY_A">BIRTH_COUNTRY_A value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByBIRTH_COUNTRY_A(string BIRTH_COUNTRY_A)
        {
            IReadOnlyList<DF> value;
            if (Index_BIRTH_COUNTRY_A.Value.TryGetValue(BIRTH_COUNTRY_A, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by BIRTH_COUNTRY_B field
        /// </summary>
        /// <param name="BIRTH_COUNTRY_B">BIRTH_COUNTRY_B value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByBIRTH_COUNTRY_B(string BIRTH_COUNTRY_B)
        {
            return Index_BIRTH_COUNTRY_B.Value[BIRTH_COUNTRY_B];
        }

        /// <summary>
        /// Attempt to find DF by BIRTH_COUNTRY_B field
        /// </summary>
        /// <param name="BIRTH_COUNTRY_B">BIRTH_COUNTRY_B value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBIRTH_COUNTRY_B(string BIRTH_COUNTRY_B, out IReadOnlyList<DF> Value)
        {
            return Index_BIRTH_COUNTRY_B.Value.TryGetValue(BIRTH_COUNTRY_B, out Value);
        }

        /// <summary>
        /// Attempt to find DF by BIRTH_COUNTRY_B field
        /// </summary>
        /// <param name="BIRTH_COUNTRY_B">BIRTH_COUNTRY_B value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByBIRTH_COUNTRY_B(string BIRTH_COUNTRY_B)
        {
            IReadOnlyList<DF> value;
            if (Index_BIRTH_COUNTRY_B.Value.TryGetValue(BIRTH_COUNTRY_B, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by BPAY_REFERENCE field
        /// </summary>
        /// <param name="BPAY_REFERENCE">BPAY_REFERENCE value used to find DF</param>
        /// <returns>Related DF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF FindByBPAY_REFERENCE(string BPAY_REFERENCE)
        {
            return Index_BPAY_REFERENCE.Value[BPAY_REFERENCE];
        }

        /// <summary>
        /// Attempt to find DF by BPAY_REFERENCE field
        /// </summary>
        /// <param name="BPAY_REFERENCE">BPAY_REFERENCE value used to find DF</param>
        /// <param name="Value">Related DF entity</param>
        /// <returns>True if the related DF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBPAY_REFERENCE(string BPAY_REFERENCE, out DF Value)
        {
            return Index_BPAY_REFERENCE.Value.TryGetValue(BPAY_REFERENCE, out Value);
        }

        /// <summary>
        /// Attempt to find DF by BPAY_REFERENCE field
        /// </summary>
        /// <param name="BPAY_REFERENCE">BPAY_REFERENCE value used to find DF</param>
        /// <returns>Related DF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF TryFindByBPAY_REFERENCE(string BPAY_REFERENCE)
        {
            DF value;
            if (Index_BPAY_REFERENCE.Value.TryGetValue(BPAY_REFERENCE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by DFKEY field
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DF</param>
        /// <returns>Related DF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF FindByDFKEY(string DFKEY)
        {
            return Index_DFKEY.Value[DFKEY];
        }

        /// <summary>
        /// Attempt to find DF by DFKEY field
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DF</param>
        /// <param name="Value">Related DF entity</param>
        /// <returns>True if the related DF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDFKEY(string DFKEY, out DF Value)
        {
            return Index_DFKEY.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DF by DFKEY field
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DF</param>
        /// <returns>Related DF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DF TryFindByDFKEY(string DFKEY)
        {
            DF value;
            if (Index_DFKEY.Value.TryGetValue(DFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by DOCTOR field
        /// </summary>
        /// <param name="DOCTOR">DOCTOR value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByDOCTOR(string DOCTOR)
        {
            return Index_DOCTOR.Value[DOCTOR];
        }

        /// <summary>
        /// Attempt to find DF by DOCTOR field
        /// </summary>
        /// <param name="DOCTOR">DOCTOR value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDOCTOR(string DOCTOR, out IReadOnlyList<DF> Value)
        {
            return Index_DOCTOR.Value.TryGetValue(DOCTOR, out Value);
        }

        /// <summary>
        /// Attempt to find DF by DOCTOR field
        /// </summary>
        /// <param name="DOCTOR">DOCTOR value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByDOCTOR(string DOCTOR)
        {
            IReadOnlyList<DF> value;
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
        /// Find DF by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByEMERG_LANG01(string EMERG_LANG01)
        {
            return Index_EMERG_LANG01.Value[EMERG_LANG01];
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG01(string EMERG_LANG01, out IReadOnlyList<DF> Value)
        {
            return Index_EMERG_LANG01.Value.TryGetValue(EMERG_LANG01, out Value);
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG01 field
        /// </summary>
        /// <param name="EMERG_LANG01">EMERG_LANG01 value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByEMERG_LANG01(string EMERG_LANG01)
        {
            IReadOnlyList<DF> value;
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
        /// Find DF by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByEMERG_LANG02(string EMERG_LANG02)
        {
            return Index_EMERG_LANG02.Value[EMERG_LANG02];
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG02(string EMERG_LANG02, out IReadOnlyList<DF> Value)
        {
            return Index_EMERG_LANG02.Value.TryGetValue(EMERG_LANG02, out Value);
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG02 field
        /// </summary>
        /// <param name="EMERG_LANG02">EMERG_LANG02 value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByEMERG_LANG02(string EMERG_LANG02)
        {
            IReadOnlyList<DF> value;
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
        /// Find DF by EMERG_LANG03 field
        /// </summary>
        /// <param name="EMERG_LANG03">EMERG_LANG03 value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByEMERG_LANG03(string EMERG_LANG03)
        {
            return Index_EMERG_LANG03.Value[EMERG_LANG03];
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG03 field
        /// </summary>
        /// <param name="EMERG_LANG03">EMERG_LANG03 value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG03(string EMERG_LANG03, out IReadOnlyList<DF> Value)
        {
            return Index_EMERG_LANG03.Value.TryGetValue(EMERG_LANG03, out Value);
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG03 field
        /// </summary>
        /// <param name="EMERG_LANG03">EMERG_LANG03 value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByEMERG_LANG03(string EMERG_LANG03)
        {
            IReadOnlyList<DF> value;
            if (Index_EMERG_LANG03.Value.TryGetValue(EMERG_LANG03, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by EMERG_LANG04 field
        /// </summary>
        /// <param name="EMERG_LANG04">EMERG_LANG04 value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByEMERG_LANG04(string EMERG_LANG04)
        {
            return Index_EMERG_LANG04.Value[EMERG_LANG04];
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG04 field
        /// </summary>
        /// <param name="EMERG_LANG04">EMERG_LANG04 value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEMERG_LANG04(string EMERG_LANG04, out IReadOnlyList<DF> Value)
        {
            return Index_EMERG_LANG04.Value.TryGetValue(EMERG_LANG04, out Value);
        }

        /// <summary>
        /// Attempt to find DF by EMERG_LANG04 field
        /// </summary>
        /// <param name="EMERG_LANG04">EMERG_LANG04 value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByEMERG_LANG04(string EMERG_LANG04)
        {
            IReadOnlyList<DF> value;
            if (Index_EMERG_LANG04.Value.TryGetValue(EMERG_LANG04, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByHOME_LANG(string HOME_LANG)
        {
            return Index_HOME_LANG.Value[HOME_LANG];
        }

        /// <summary>
        /// Attempt to find DF by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_LANG(string HOME_LANG, out IReadOnlyList<DF> Value)
        {
            return Index_HOME_LANG.Value.TryGetValue(HOME_LANG, out Value);
        }

        /// <summary>
        /// Attempt to find DF by HOME_LANG field
        /// </summary>
        /// <param name="HOME_LANG">HOME_LANG value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByHOME_LANG(string HOME_LANG)
        {
            IReadOnlyList<DF> value;
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
        /// Find DF by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByHOMEKEY(int? HOMEKEY)
        {
            return Index_HOMEKEY.Value[HOMEKEY];
        }

        /// <summary>
        /// Attempt to find DF by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOMEKEY(int? HOMEKEY, out IReadOnlyList<DF> Value)
        {
            return Index_HOMEKEY.Value.TryGetValue(HOMEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DF by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByHOMEKEY(int? HOMEKEY)
        {
            IReadOnlyList<DF> value;
            if (Index_HOMEKEY.Value.TryGetValue(HOMEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by LOTE_HOME_CODE_A field
        /// </summary>
        /// <param name="LOTE_HOME_CODE_A">LOTE_HOME_CODE_A value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByLOTE_HOME_CODE_A(string LOTE_HOME_CODE_A)
        {
            return Index_LOTE_HOME_CODE_A.Value[LOTE_HOME_CODE_A];
        }

        /// <summary>
        /// Attempt to find DF by LOTE_HOME_CODE_A field
        /// </summary>
        /// <param name="LOTE_HOME_CODE_A">LOTE_HOME_CODE_A value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOTE_HOME_CODE_A(string LOTE_HOME_CODE_A, out IReadOnlyList<DF> Value)
        {
            return Index_LOTE_HOME_CODE_A.Value.TryGetValue(LOTE_HOME_CODE_A, out Value);
        }

        /// <summary>
        /// Attempt to find DF by LOTE_HOME_CODE_A field
        /// </summary>
        /// <param name="LOTE_HOME_CODE_A">LOTE_HOME_CODE_A value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByLOTE_HOME_CODE_A(string LOTE_HOME_CODE_A)
        {
            IReadOnlyList<DF> value;
            if (Index_LOTE_HOME_CODE_A.Value.TryGetValue(LOTE_HOME_CODE_A, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by LOTE_HOME_CODE_B field
        /// </summary>
        /// <param name="LOTE_HOME_CODE_B">LOTE_HOME_CODE_B value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByLOTE_HOME_CODE_B(string LOTE_HOME_CODE_B)
        {
            return Index_LOTE_HOME_CODE_B.Value[LOTE_HOME_CODE_B];
        }

        /// <summary>
        /// Attempt to find DF by LOTE_HOME_CODE_B field
        /// </summary>
        /// <param name="LOTE_HOME_CODE_B">LOTE_HOME_CODE_B value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOTE_HOME_CODE_B(string LOTE_HOME_CODE_B, out IReadOnlyList<DF> Value)
        {
            return Index_LOTE_HOME_CODE_B.Value.TryGetValue(LOTE_HOME_CODE_B, out Value);
        }

        /// <summary>
        /// Attempt to find DF by LOTE_HOME_CODE_B field
        /// </summary>
        /// <param name="LOTE_HOME_CODE_B">LOTE_HOME_CODE_B value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByLOTE_HOME_CODE_B(string LOTE_HOME_CODE_B)
        {
            IReadOnlyList<DF> value;
            if (Index_LOTE_HOME_CODE_B.Value.TryGetValue(LOTE_HOME_CODE_B, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find DF by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<DF> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find DF by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<DF> value;
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
        /// Find DF by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByMAILKEY(int? MAILKEY)
        {
            return Index_MAILKEY.Value[MAILKEY];
        }

        /// <summary>
        /// Attempt to find DF by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILKEY(int? MAILKEY, out IReadOnlyList<DF> Value)
        {
            return Index_MAILKEY.Value.TryGetValue(MAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DF by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByMAILKEY(int? MAILKEY)
        {
            IReadOnlyList<DF> value;
            if (Index_MAILKEY.Value.TryGetValue(MAILKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by NAME_A, SURNAME_A, NAME_B, SURNAME_B and BPAY_SEQUENCE fields
        /// </summary>
        /// <param name="NAME_A">NAME_A value used to find DF</param>
        /// <param name="SURNAME_A">SURNAME_A value used to find DF</param>
        /// <param name="NAME_B">NAME_B value used to find DF</param>
        /// <param name="SURNAME_B">SURNAME_B value used to find DF</param>
        /// <param name="BPAY_SEQUENCE">BPAY_SEQUENCE value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByNAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE(string NAME_A, string SURNAME_A, string NAME_B, string SURNAME_B, int? BPAY_SEQUENCE)
        {
            return Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE.Value[Tuple.Create(NAME_A, SURNAME_A, NAME_B, SURNAME_B, BPAY_SEQUENCE)];
        }

        /// <summary>
        /// Attempt to find DF by NAME_A, SURNAME_A, NAME_B, SURNAME_B and BPAY_SEQUENCE fields
        /// </summary>
        /// <param name="NAME_A">NAME_A value used to find DF</param>
        /// <param name="SURNAME_A">SURNAME_A value used to find DF</param>
        /// <param name="NAME_B">NAME_B value used to find DF</param>
        /// <param name="SURNAME_B">SURNAME_B value used to find DF</param>
        /// <param name="BPAY_SEQUENCE">BPAY_SEQUENCE value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE(string NAME_A, string SURNAME_A, string NAME_B, string SURNAME_B, int? BPAY_SEQUENCE, out IReadOnlyList<DF> Value)
        {
            return Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE.Value.TryGetValue(Tuple.Create(NAME_A, SURNAME_A, NAME_B, SURNAME_B, BPAY_SEQUENCE), out Value);
        }

        /// <summary>
        /// Attempt to find DF by NAME_A, SURNAME_A, NAME_B, SURNAME_B and BPAY_SEQUENCE fields
        /// </summary>
        /// <param name="NAME_A">NAME_A value used to find DF</param>
        /// <param name="SURNAME_A">SURNAME_A value used to find DF</param>
        /// <param name="NAME_B">NAME_B value used to find DF</param>
        /// <param name="SURNAME_B">SURNAME_B value used to find DF</param>
        /// <param name="BPAY_SEQUENCE">BPAY_SEQUENCE value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByNAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE(string NAME_A, string SURNAME_A, string NAME_B, string SURNAME_B, int? BPAY_SEQUENCE)
        {
            IReadOnlyList<DF> value;
            if (Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE.Value.TryGetValue(Tuple.Create(NAME_A, SURNAME_A, NAME_B, SURNAME_B, BPAY_SEQUENCE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by NATIVE_LANG_A field
        /// </summary>
        /// <param name="NATIVE_LANG_A">NATIVE_LANG_A value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByNATIVE_LANG_A(string NATIVE_LANG_A)
        {
            return Index_NATIVE_LANG_A.Value[NATIVE_LANG_A];
        }

        /// <summary>
        /// Attempt to find DF by NATIVE_LANG_A field
        /// </summary>
        /// <param name="NATIVE_LANG_A">NATIVE_LANG_A value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNATIVE_LANG_A(string NATIVE_LANG_A, out IReadOnlyList<DF> Value)
        {
            return Index_NATIVE_LANG_A.Value.TryGetValue(NATIVE_LANG_A, out Value);
        }

        /// <summary>
        /// Attempt to find DF by NATIVE_LANG_A field
        /// </summary>
        /// <param name="NATIVE_LANG_A">NATIVE_LANG_A value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByNATIVE_LANG_A(string NATIVE_LANG_A)
        {
            IReadOnlyList<DF> value;
            if (Index_NATIVE_LANG_A.Value.TryGetValue(NATIVE_LANG_A, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by NATIVE_LANG_B field
        /// </summary>
        /// <param name="NATIVE_LANG_B">NATIVE_LANG_B value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByNATIVE_LANG_B(string NATIVE_LANG_B)
        {
            return Index_NATIVE_LANG_B.Value[NATIVE_LANG_B];
        }

        /// <summary>
        /// Attempt to find DF by NATIVE_LANG_B field
        /// </summary>
        /// <param name="NATIVE_LANG_B">NATIVE_LANG_B value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNATIVE_LANG_B(string NATIVE_LANG_B, out IReadOnlyList<DF> Value)
        {
            return Index_NATIVE_LANG_B.Value.TryGetValue(NATIVE_LANG_B, out Value);
        }

        /// <summary>
        /// Attempt to find DF by NATIVE_LANG_B field
        /// </summary>
        /// <param name="NATIVE_LANG_B">NATIVE_LANG_B value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByNATIVE_LANG_B(string NATIVE_LANG_B)
        {
            IReadOnlyList<DF> value;
            if (Index_NATIVE_LANG_B.Value.TryGetValue(NATIVE_LANG_B, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by OTHER_LANG_A field
        /// </summary>
        /// <param name="OTHER_LANG_A">OTHER_LANG_A value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByOTHER_LANG_A(string OTHER_LANG_A)
        {
            return Index_OTHER_LANG_A.Value[OTHER_LANG_A];
        }

        /// <summary>
        /// Attempt to find DF by OTHER_LANG_A field
        /// </summary>
        /// <param name="OTHER_LANG_A">OTHER_LANG_A value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByOTHER_LANG_A(string OTHER_LANG_A, out IReadOnlyList<DF> Value)
        {
            return Index_OTHER_LANG_A.Value.TryGetValue(OTHER_LANG_A, out Value);
        }

        /// <summary>
        /// Attempt to find DF by OTHER_LANG_A field
        /// </summary>
        /// <param name="OTHER_LANG_A">OTHER_LANG_A value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByOTHER_LANG_A(string OTHER_LANG_A)
        {
            IReadOnlyList<DF> value;
            if (Index_OTHER_LANG_A.Value.TryGetValue(OTHER_LANG_A, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by OTHER_LANG_B field
        /// </summary>
        /// <param name="OTHER_LANG_B">OTHER_LANG_B value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByOTHER_LANG_B(string OTHER_LANG_B)
        {
            return Index_OTHER_LANG_B.Value[OTHER_LANG_B];
        }

        /// <summary>
        /// Attempt to find DF by OTHER_LANG_B field
        /// </summary>
        /// <param name="OTHER_LANG_B">OTHER_LANG_B value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByOTHER_LANG_B(string OTHER_LANG_B, out IReadOnlyList<DF> Value)
        {
            return Index_OTHER_LANG_B.Value.TryGetValue(OTHER_LANG_B, out Value);
        }

        /// <summary>
        /// Attempt to find DF by OTHER_LANG_B field
        /// </summary>
        /// <param name="OTHER_LANG_B">OTHER_LANG_B value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByOTHER_LANG_B(string OTHER_LANG_B)
        {
            IReadOnlyList<DF> value;
            if (Index_OTHER_LANG_B.Value.TryGetValue(OTHER_LANG_B, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DF by PREF_NOTICE_LANG field
        /// </summary>
        /// <param name="PREF_NOTICE_LANG">PREF_NOTICE_LANG value used to find DF</param>
        /// <returns>List of related DF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> FindByPREF_NOTICE_LANG(string PREF_NOTICE_LANG)
        {
            return Index_PREF_NOTICE_LANG.Value[PREF_NOTICE_LANG];
        }

        /// <summary>
        /// Attempt to find DF by PREF_NOTICE_LANG field
        /// </summary>
        /// <param name="PREF_NOTICE_LANG">PREF_NOTICE_LANG value used to find DF</param>
        /// <param name="Value">List of related DF entities</param>
        /// <returns>True if the list of related DF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPREF_NOTICE_LANG(string PREF_NOTICE_LANG, out IReadOnlyList<DF> Value)
        {
            return Index_PREF_NOTICE_LANG.Value.TryGetValue(PREF_NOTICE_LANG, out Value);
        }

        /// <summary>
        /// Attempt to find DF by PREF_NOTICE_LANG field
        /// </summary>
        /// <param name="PREF_NOTICE_LANG">PREF_NOTICE_LANG value used to find DF</param>
        /// <returns>List of related DF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DF> TryFindByPREF_NOTICE_LANG(string PREF_NOTICE_LANG)
        {
            IReadOnlyList<DF> value;
            if (Index_PREF_NOTICE_LANG.Value.TryGetValue(PREF_NOTICE_LANG, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a DF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DF](
        [DFKEY] varchar(10) NOT NULL,
        [NAME_A] varchar(30) NULL,
        [SURNAME_A] varchar(30) NULL,
        [TITLE_A] varchar(4) NULL,
        [WORK_CONT_A] varchar(1) NULL,
        [OCCUPATION_A] varchar(35) NULL,
        [EMPLOYER_A] varchar(30) NULL,
        [NATIVE_LANG_A] varchar(7) NULL,
        [OTHER_LANG_A] varchar(7) NULL,
        [INTERPRETER_A] varchar(1) NULL,
        [BIRTH_COUNTRY_A] varchar(6) NULL,
        [BH_AT_HOME_A] varchar(1) NULL,
        [BH_CONTACT_A] varchar(20) NULL,
        [BH_CONTACT_A_MEMO] varchar(MAX) NULL,
        [AH_AT_HOME_A] varchar(1) NULL,
        [AH_CONTACT_A] varchar(20) NULL,
        [AH_CONTACT_A_MEMO] varchar(MAX) NULL,
        [E_MAIL_A] varchar(60) NULL,
        [PREF_MAIL_MECH_A] varchar(1) NULL,
        [FAX_A] varchar(20) NULL,
        [GENDER_A] varchar(1) NULL,
        [SCH_ED_A] varchar(1) NULL,
        [NON_SCH_ED_A] varchar(1) NULL,
        [OCCUP_STATUS_A] varchar(1) NULL,
        [LOTE_HOME_CODE_A] varchar(7) NULL,
        [MOBILE_A] varchar(20) NULL,
        [SMS_NOTIFY_A] varchar(1) NULL,
        [E_MAIL_NOTIFY_A] varchar(1) NULL,
        [WWCC_NUMBER_A] varchar(11) NULL,
        [WWCC_EXPIRY_A] datetime NULL,
        [WWCC_TYPE_A] varchar(1) NULL,
        [NAME_B] varchar(30) NULL,
        [SURNAME_B] varchar(30) NULL,
        [TITLE_B] varchar(4) NULL,
        [WORK_CONT_B] varchar(1) NULL,
        [OCCUPATION_B] varchar(35) NULL,
        [EMPLOYER_B] varchar(30) NULL,
        [NATIVE_LANG_B] varchar(7) NULL,
        [OTHER_LANG_B] varchar(7) NULL,
        [INTERPRETER_B] varchar(1) NULL,
        [BIRTH_COUNTRY_B] varchar(6) NULL,
        [BH_AT_HOME_B] varchar(1) NULL,
        [BH_CONTACT_B] varchar(20) NULL,
        [BH_CONTACT_B_MEMO] varchar(MAX) NULL,
        [AH_AT_HOME_B] varchar(1) NULL,
        [AH_CONTACT_B] varchar(20) NULL,
        [AH_CONTACT_B_MEMO] varchar(MAX) NULL,
        [E_MAIL_B] varchar(60) NULL,
        [PREF_MAIL_MECH_B] varchar(1) NULL,
        [FAX_B] varchar(20) NULL,
        [GENDER_B] varchar(1) NULL,
        [SCH_ED_B] varchar(1) NULL,
        [NON_SCH_ED_B] varchar(1) NULL,
        [OCCUP_STATUS_B] varchar(1) NULL,
        [LOTE_HOME_CODE_B] varchar(7) NULL,
        [MOBILE_B] varchar(20) NULL,
        [SMS_NOTIFY_B] varchar(1) NULL,
        [E_MAIL_NOTIFY_B] varchar(1) NULL,
        [WWCC_NUMBER_B] varchar(11) NULL,
        [WWCC_EXPIRY_B] datetime NULL,
        [WWCC_TYPE_B] varchar(1) NULL,
        [PREF_NOTICE_LANG] varchar(7) NULL,
        [GROUP_AVAILABILITY] varchar(1) NULL,
        [OCCUP_STATUS_GRP] varchar(1) NULL,
        [HOMETITLE] varchar(30) NULL,
        [HOMEKEY] int NULL,
        [MAILTITLE] varchar(30) NULL,
        [MAILKEY] int NULL,
        [BILLINGTITLE] varchar(40) NULL,
        [BILLINGKEY] int NULL,
        [BILLING_MEMO] varchar(MAX) NULL,
        [ACCTYPE] smallint NULL,
        [AGED01] money NULL,
        [AGED02] money NULL,
        [AGED03] money NULL,
        [AGED04] money NULL,
        [AGED05] money NULL,
        [ALLOCAMT] money NULL,
        [CHARGES] money NULL,
        [LASTREC] money NULL,
        [LASTRECDATE] datetime NULL,
        [OPBAL] money NULL,
        [OPBAL_YEAR] money NULL,
        [PRICELEVEL] smallint NULL,
        [BPAY_SEQUENCE] int NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [NO_STUDENTS] smallint NULL,
        [NO_ASSOC_STUDENTS] smallint NULL,
        [CREDIT_LIMIT] money NULL,
        [BILL_GROUP] varchar(10) NULL,
        [DOCTOR] varchar(10) NULL,
        [EMERG_NAME01] varchar(30) NULL,
        [EMERG_NAME02] varchar(30) NULL,
        [EMERG_NAME03] varchar(30) NULL,
        [EMERG_NAME04] varchar(30) NULL,
        [EMERG_RELATION01] varchar(20) NULL,
        [EMERG_RELATION02] varchar(20) NULL,
        [EMERG_RELATION03] varchar(20) NULL,
        [EMERG_RELATION04] varchar(20) NULL,
        [EMERG_LANG01] varchar(7) NULL,
        [EMERG_LANG02] varchar(7) NULL,
        [EMERG_LANG03] varchar(7) NULL,
        [EMERG_LANG04] varchar(7) NULL,
        [EMERG_CONTACT01] varchar(20) NULL,
        [EMERG_CONTACT02] varchar(20) NULL,
        [EMERG_CONTACT03] varchar(20) NULL,
        [EMERG_CONTACT04] varchar(20) NULL,
        [EMERG_CONTACT_MEMO01] varchar(MAX) NULL,
        [EMERG_CONTACT_MEMO02] varchar(MAX) NULL,
        [EMERG_CONTACT_MEMO03] varchar(MAX) NULL,
        [EMERG_CONTACT_MEMO04] varchar(MAX) NULL,
        [ACC_DECLARATION] varchar(1) NULL,
        [AMBULANCE_SUBSCRIBER] varchar(1) NULL,
        [MEDICARE_NO] varchar(12) NULL,
        [HOME_LANG] varchar(7) NULL,
        [DRAWER] varchar(30) NULL,
        [BSB] varchar(6) NULL,
        [TAX_INVOICE] varchar(1) NULL,
        [ABN] varchar(15) NULL,
        [BILLING_EMAIL] varchar(60) NULL,
        [PREF_EMAIL] varchar(1) NULL,
        [USER_NAME] varchar(32) NULL,
        [WEB_ENABLED] varchar(1) NULL,
        [CASES_KEY] varchar(7) NULL,
        [EMA_APPLY_DATE] datetime NULL,
        [EMA_APPLY] varchar(1) NULL,
        [DSS_SURNAME] varchar(30) NULL,
        [DSS_FIRST_NAME] varchar(30) NULL,
        [SSN_ELIG_CODE] varchar(5) NULL,
        [SSN] varchar(15) NULL,
        [EMA_TOTAL1P] money NULL,
        [EMA_STAT1P] smallint NULL,
        [EMA_TOTAL2P] money NULL,
        [EMA_STAT2P] smallint NULL,
        [EMA_CLAIM_VN] varchar(1) NULL,
        [EMA_SEND] varchar(1) NULL,
        [EMA_CLAIM_PD] varchar(1) NULL,
        [CASES_EMA_ID] varchar(10) NULL,
        [SCH_ED_A_LU] datetime NULL,
        [NON_SCH_ED_A_LU] datetime NULL,
        [OCCUP_STATUS_A_LU] datetime NULL,
        [SCH_ED_B_LU] datetime NULL,
        [NON_SCH_ED_B_LU] datetime NULL,
        [OCCUP_STATUS_B_LU] datetime NULL,
        [CNSE] varchar(1) NULL,
        [CSE] varchar(1) NULL,
        [FSE] varchar(1) NULL,
        [GENDER_DESC_A] varchar(100) NULL,
        [GENDER_DESC_B] varchar(100) NULL,
        [PARENT_A_SI_ID] varchar(20) NULL,
        [PARENT_B_SI_ID] varchar(20) NULL,
        [HEALTH_SUM_SI_ID] varchar(20) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DF_Index_DFKEY] PRIMARY KEY CLUSTERED (
            [DFKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [DF_Index_BILLINGKEY] ON [dbo].[DF]
    (
            [BILLINGKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_BIRTH_COUNTRY_A] ON [dbo].[DF]
    (
            [BIRTH_COUNTRY_A] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_BIRTH_COUNTRY_B] ON [dbo].[DF]
    (
            [BIRTH_COUNTRY_B] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_BPAY_REFERENCE] ON [dbo].[DF]
    (
            [BPAY_REFERENCE] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_DOCTOR] ON [dbo].[DF]
    (
            [DOCTOR] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_EMERG_LANG01] ON [dbo].[DF]
    (
            [EMERG_LANG01] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_EMERG_LANG02] ON [dbo].[DF]
    (
            [EMERG_LANG02] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_EMERG_LANG03] ON [dbo].[DF]
    (
            [EMERG_LANG03] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_EMERG_LANG04] ON [dbo].[DF]
    (
            [EMERG_LANG04] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_HOME_LANG] ON [dbo].[DF]
    (
            [HOME_LANG] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_HOMEKEY] ON [dbo].[DF]
    (
            [HOMEKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_LOTE_HOME_CODE_A] ON [dbo].[DF]
    (
            [LOTE_HOME_CODE_A] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_LOTE_HOME_CODE_B] ON [dbo].[DF]
    (
            [LOTE_HOME_CODE_B] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_LW_DATE] ON [dbo].[DF]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_MAILKEY] ON [dbo].[DF]
    (
            [MAILKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE] ON [dbo].[DF]
    (
            [NAME_A] ASC,
            [SURNAME_A] ASC,
            [NAME_B] ASC,
            [SURNAME_B] ASC,
            [BPAY_SEQUENCE] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_NATIVE_LANG_A] ON [dbo].[DF]
    (
            [NATIVE_LANG_A] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_NATIVE_LANG_B] ON [dbo].[DF]
    (
            [NATIVE_LANG_B] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_OTHER_LANG_A] ON [dbo].[DF]
    (
            [OTHER_LANG_A] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_OTHER_LANG_B] ON [dbo].[DF]
    (
            [OTHER_LANG_B] ASC
    );
    CREATE NONCLUSTERED INDEX [DF_Index_PREF_NOTICE_LANG] ON [dbo].[DF]
    (
            [PREF_NOTICE_LANG] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BILLINGKEY')
    ALTER INDEX [DF_Index_BILLINGKEY] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BIRTH_COUNTRY_A')
    ALTER INDEX [DF_Index_BIRTH_COUNTRY_A] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BIRTH_COUNTRY_B')
    ALTER INDEX [DF_Index_BIRTH_COUNTRY_B] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BPAY_REFERENCE')
    ALTER INDEX [DF_Index_BPAY_REFERENCE] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_DOCTOR')
    ALTER INDEX [DF_Index_DOCTOR] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG01')
    ALTER INDEX [DF_Index_EMERG_LANG01] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG02')
    ALTER INDEX [DF_Index_EMERG_LANG02] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG03')
    ALTER INDEX [DF_Index_EMERG_LANG03] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG04')
    ALTER INDEX [DF_Index_EMERG_LANG04] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_HOME_LANG')
    ALTER INDEX [DF_Index_HOME_LANG] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_HOMEKEY')
    ALTER INDEX [DF_Index_HOMEKEY] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_LOTE_HOME_CODE_A')
    ALTER INDEX [DF_Index_LOTE_HOME_CODE_A] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_LOTE_HOME_CODE_B')
    ALTER INDEX [DF_Index_LOTE_HOME_CODE_B] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_LW_DATE')
    ALTER INDEX [DF_Index_LW_DATE] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_MAILKEY')
    ALTER INDEX [DF_Index_MAILKEY] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE')
    ALTER INDEX [DF_Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_NATIVE_LANG_A')
    ALTER INDEX [DF_Index_NATIVE_LANG_A] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_NATIVE_LANG_B')
    ALTER INDEX [DF_Index_NATIVE_LANG_B] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_OTHER_LANG_A')
    ALTER INDEX [DF_Index_OTHER_LANG_A] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_OTHER_LANG_B')
    ALTER INDEX [DF_Index_OTHER_LANG_B] ON [dbo].[DF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_PREF_NOTICE_LANG')
    ALTER INDEX [DF_Index_PREF_NOTICE_LANG] ON [dbo].[DF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BILLINGKEY')
    ALTER INDEX [DF_Index_BILLINGKEY] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BIRTH_COUNTRY_A')
    ALTER INDEX [DF_Index_BIRTH_COUNTRY_A] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BIRTH_COUNTRY_B')
    ALTER INDEX [DF_Index_BIRTH_COUNTRY_B] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_BPAY_REFERENCE')
    ALTER INDEX [DF_Index_BPAY_REFERENCE] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_DOCTOR')
    ALTER INDEX [DF_Index_DOCTOR] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG01')
    ALTER INDEX [DF_Index_EMERG_LANG01] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG02')
    ALTER INDEX [DF_Index_EMERG_LANG02] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG03')
    ALTER INDEX [DF_Index_EMERG_LANG03] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_EMERG_LANG04')
    ALTER INDEX [DF_Index_EMERG_LANG04] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_HOME_LANG')
    ALTER INDEX [DF_Index_HOME_LANG] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_HOMEKEY')
    ALTER INDEX [DF_Index_HOMEKEY] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_LOTE_HOME_CODE_A')
    ALTER INDEX [DF_Index_LOTE_HOME_CODE_A] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_LOTE_HOME_CODE_B')
    ALTER INDEX [DF_Index_LOTE_HOME_CODE_B] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_LW_DATE')
    ALTER INDEX [DF_Index_LW_DATE] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_MAILKEY')
    ALTER INDEX [DF_Index_MAILKEY] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE')
    ALTER INDEX [DF_Index_NAME_A_SURNAME_A_NAME_B_SURNAME_B_BPAY_SEQUENCE] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_NATIVE_LANG_A')
    ALTER INDEX [DF_Index_NATIVE_LANG_A] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_NATIVE_LANG_B')
    ALTER INDEX [DF_Index_NATIVE_LANG_B] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_OTHER_LANG_A')
    ALTER INDEX [DF_Index_OTHER_LANG_A] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_OTHER_LANG_B')
    ALTER INDEX [DF_Index_OTHER_LANG_B] ON [dbo].[DF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DF]') AND name = N'DF_Index_PREF_NOTICE_LANG')
    ALTER INDEX [DF_Index_PREF_NOTICE_LANG] ON [dbo].[DF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="DF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="DF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<DF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_BPAY_REFERENCE = new List<string>();
            List<string> Index_DFKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_BPAY_REFERENCE.Add(entity.BPAY_REFERENCE);
                Index_DFKEY.Add(entity.DFKEY);
            }

            builder.AppendLine("DELETE [dbo].[DF] WHERE");


            // Index_BPAY_REFERENCE
            builder.Append("[BPAY_REFERENCE] IN (");
            for (int index = 0; index < Index_BPAY_REFERENCE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // BPAY_REFERENCE
                var parameterBPAY_REFERENCE = $"@p{parameterIndex++}";
                builder.Append(parameterBPAY_REFERENCE);
                command.Parameters.Add(parameterBPAY_REFERENCE, SqlDbType.VarChar, 20).Value = (object)Index_BPAY_REFERENCE[index] ?? DBNull.Value;
            }
            builder.AppendLine(") OR");

            // Index_DFKEY
            builder.Append("[DFKEY] IN (");
            for (int index = 0; index < Index_DFKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // DFKEY
                var parameterDFKEY = $"@p{parameterIndex++}";
                builder.Append(parameterDFKEY);
                command.Parameters.Add(parameterDFKEY, SqlDbType.VarChar, 10).Value = Index_DFKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DF data set</returns>
        public override EduHubDataSetDataReader<DF> GetDataSetDataReader()
        {
            return new DFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DF data set</returns>
        public override EduHubDataSetDataReader<DF> GetDataSetDataReader(List<DF> Entities)
        {
            return new DFDataReader(new EduHubDataSetLoadedReader<DF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DFDataReader : EduHubDataSetDataReader<DF>
        {
            public DFDataReader(IEduHubDataSetReader<DF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 155; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // DFKEY
                        return Current.DFKEY;
                    case 1: // NAME_A
                        return Current.NAME_A;
                    case 2: // SURNAME_A
                        return Current.SURNAME_A;
                    case 3: // TITLE_A
                        return Current.TITLE_A;
                    case 4: // WORK_CONT_A
                        return Current.WORK_CONT_A;
                    case 5: // OCCUPATION_A
                        return Current.OCCUPATION_A;
                    case 6: // EMPLOYER_A
                        return Current.EMPLOYER_A;
                    case 7: // NATIVE_LANG_A
                        return Current.NATIVE_LANG_A;
                    case 8: // OTHER_LANG_A
                        return Current.OTHER_LANG_A;
                    case 9: // INTERPRETER_A
                        return Current.INTERPRETER_A;
                    case 10: // BIRTH_COUNTRY_A
                        return Current.BIRTH_COUNTRY_A;
                    case 11: // BH_AT_HOME_A
                        return Current.BH_AT_HOME_A;
                    case 12: // BH_CONTACT_A
                        return Current.BH_CONTACT_A;
                    case 13: // BH_CONTACT_A_MEMO
                        return Current.BH_CONTACT_A_MEMO;
                    case 14: // AH_AT_HOME_A
                        return Current.AH_AT_HOME_A;
                    case 15: // AH_CONTACT_A
                        return Current.AH_CONTACT_A;
                    case 16: // AH_CONTACT_A_MEMO
                        return Current.AH_CONTACT_A_MEMO;
                    case 17: // E_MAIL_A
                        return Current.E_MAIL_A;
                    case 18: // PREF_MAIL_MECH_A
                        return Current.PREF_MAIL_MECH_A;
                    case 19: // FAX_A
                        return Current.FAX_A;
                    case 20: // GENDER_A
                        return Current.GENDER_A;
                    case 21: // SCH_ED_A
                        return Current.SCH_ED_A;
                    case 22: // NON_SCH_ED_A
                        return Current.NON_SCH_ED_A;
                    case 23: // OCCUP_STATUS_A
                        return Current.OCCUP_STATUS_A;
                    case 24: // LOTE_HOME_CODE_A
                        return Current.LOTE_HOME_CODE_A;
                    case 25: // MOBILE_A
                        return Current.MOBILE_A;
                    case 26: // SMS_NOTIFY_A
                        return Current.SMS_NOTIFY_A;
                    case 27: // E_MAIL_NOTIFY_A
                        return Current.E_MAIL_NOTIFY_A;
                    case 28: // WWCC_NUMBER_A
                        return Current.WWCC_NUMBER_A;
                    case 29: // WWCC_EXPIRY_A
                        return Current.WWCC_EXPIRY_A;
                    case 30: // WWCC_TYPE_A
                        return Current.WWCC_TYPE_A;
                    case 31: // NAME_B
                        return Current.NAME_B;
                    case 32: // SURNAME_B
                        return Current.SURNAME_B;
                    case 33: // TITLE_B
                        return Current.TITLE_B;
                    case 34: // WORK_CONT_B
                        return Current.WORK_CONT_B;
                    case 35: // OCCUPATION_B
                        return Current.OCCUPATION_B;
                    case 36: // EMPLOYER_B
                        return Current.EMPLOYER_B;
                    case 37: // NATIVE_LANG_B
                        return Current.NATIVE_LANG_B;
                    case 38: // OTHER_LANG_B
                        return Current.OTHER_LANG_B;
                    case 39: // INTERPRETER_B
                        return Current.INTERPRETER_B;
                    case 40: // BIRTH_COUNTRY_B
                        return Current.BIRTH_COUNTRY_B;
                    case 41: // BH_AT_HOME_B
                        return Current.BH_AT_HOME_B;
                    case 42: // BH_CONTACT_B
                        return Current.BH_CONTACT_B;
                    case 43: // BH_CONTACT_B_MEMO
                        return Current.BH_CONTACT_B_MEMO;
                    case 44: // AH_AT_HOME_B
                        return Current.AH_AT_HOME_B;
                    case 45: // AH_CONTACT_B
                        return Current.AH_CONTACT_B;
                    case 46: // AH_CONTACT_B_MEMO
                        return Current.AH_CONTACT_B_MEMO;
                    case 47: // E_MAIL_B
                        return Current.E_MAIL_B;
                    case 48: // PREF_MAIL_MECH_B
                        return Current.PREF_MAIL_MECH_B;
                    case 49: // FAX_B
                        return Current.FAX_B;
                    case 50: // GENDER_B
                        return Current.GENDER_B;
                    case 51: // SCH_ED_B
                        return Current.SCH_ED_B;
                    case 52: // NON_SCH_ED_B
                        return Current.NON_SCH_ED_B;
                    case 53: // OCCUP_STATUS_B
                        return Current.OCCUP_STATUS_B;
                    case 54: // LOTE_HOME_CODE_B
                        return Current.LOTE_HOME_CODE_B;
                    case 55: // MOBILE_B
                        return Current.MOBILE_B;
                    case 56: // SMS_NOTIFY_B
                        return Current.SMS_NOTIFY_B;
                    case 57: // E_MAIL_NOTIFY_B
                        return Current.E_MAIL_NOTIFY_B;
                    case 58: // WWCC_NUMBER_B
                        return Current.WWCC_NUMBER_B;
                    case 59: // WWCC_EXPIRY_B
                        return Current.WWCC_EXPIRY_B;
                    case 60: // WWCC_TYPE_B
                        return Current.WWCC_TYPE_B;
                    case 61: // PREF_NOTICE_LANG
                        return Current.PREF_NOTICE_LANG;
                    case 62: // GROUP_AVAILABILITY
                        return Current.GROUP_AVAILABILITY;
                    case 63: // OCCUP_STATUS_GRP
                        return Current.OCCUP_STATUS_GRP;
                    case 64: // HOMETITLE
                        return Current.HOMETITLE;
                    case 65: // HOMEKEY
                        return Current.HOMEKEY;
                    case 66: // MAILTITLE
                        return Current.MAILTITLE;
                    case 67: // MAILKEY
                        return Current.MAILKEY;
                    case 68: // BILLINGTITLE
                        return Current.BILLINGTITLE;
                    case 69: // BILLINGKEY
                        return Current.BILLINGKEY;
                    case 70: // BILLING_MEMO
                        return Current.BILLING_MEMO;
                    case 71: // ACCTYPE
                        return Current.ACCTYPE;
                    case 72: // AGED01
                        return Current.AGED01;
                    case 73: // AGED02
                        return Current.AGED02;
                    case 74: // AGED03
                        return Current.AGED03;
                    case 75: // AGED04
                        return Current.AGED04;
                    case 76: // AGED05
                        return Current.AGED05;
                    case 77: // ALLOCAMT
                        return Current.ALLOCAMT;
                    case 78: // CHARGES
                        return Current.CHARGES;
                    case 79: // LASTREC
                        return Current.LASTREC;
                    case 80: // LASTRECDATE
                        return Current.LASTRECDATE;
                    case 81: // OPBAL
                        return Current.OPBAL;
                    case 82: // OPBAL_YEAR
                        return Current.OPBAL_YEAR;
                    case 83: // PRICELEVEL
                        return Current.PRICELEVEL;
                    case 84: // BPAY_SEQUENCE
                        return Current.BPAY_SEQUENCE;
                    case 85: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE;
                    case 86: // NO_STUDENTS
                        return Current.NO_STUDENTS;
                    case 87: // NO_ASSOC_STUDENTS
                        return Current.NO_ASSOC_STUDENTS;
                    case 88: // CREDIT_LIMIT
                        return Current.CREDIT_LIMIT;
                    case 89: // BILL_GROUP
                        return Current.BILL_GROUP;
                    case 90: // DOCTOR
                        return Current.DOCTOR;
                    case 91: // EMERG_NAME01
                        return Current.EMERG_NAME01;
                    case 92: // EMERG_NAME02
                        return Current.EMERG_NAME02;
                    case 93: // EMERG_NAME03
                        return Current.EMERG_NAME03;
                    case 94: // EMERG_NAME04
                        return Current.EMERG_NAME04;
                    case 95: // EMERG_RELATION01
                        return Current.EMERG_RELATION01;
                    case 96: // EMERG_RELATION02
                        return Current.EMERG_RELATION02;
                    case 97: // EMERG_RELATION03
                        return Current.EMERG_RELATION03;
                    case 98: // EMERG_RELATION04
                        return Current.EMERG_RELATION04;
                    case 99: // EMERG_LANG01
                        return Current.EMERG_LANG01;
                    case 100: // EMERG_LANG02
                        return Current.EMERG_LANG02;
                    case 101: // EMERG_LANG03
                        return Current.EMERG_LANG03;
                    case 102: // EMERG_LANG04
                        return Current.EMERG_LANG04;
                    case 103: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01;
                    case 104: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02;
                    case 105: // EMERG_CONTACT03
                        return Current.EMERG_CONTACT03;
                    case 106: // EMERG_CONTACT04
                        return Current.EMERG_CONTACT04;
                    case 107: // EMERG_CONTACT_MEMO01
                        return Current.EMERG_CONTACT_MEMO01;
                    case 108: // EMERG_CONTACT_MEMO02
                        return Current.EMERG_CONTACT_MEMO02;
                    case 109: // EMERG_CONTACT_MEMO03
                        return Current.EMERG_CONTACT_MEMO03;
                    case 110: // EMERG_CONTACT_MEMO04
                        return Current.EMERG_CONTACT_MEMO04;
                    case 111: // ACC_DECLARATION
                        return Current.ACC_DECLARATION;
                    case 112: // AMBULANCE_SUBSCRIBER
                        return Current.AMBULANCE_SUBSCRIBER;
                    case 113: // MEDICARE_NO
                        return Current.MEDICARE_NO;
                    case 114: // HOME_LANG
                        return Current.HOME_LANG;
                    case 115: // DRAWER
                        return Current.DRAWER;
                    case 116: // BSB
                        return Current.BSB;
                    case 117: // TAX_INVOICE
                        return Current.TAX_INVOICE;
                    case 118: // ABN
                        return Current.ABN;
                    case 119: // BILLING_EMAIL
                        return Current.BILLING_EMAIL;
                    case 120: // PREF_EMAIL
                        return Current.PREF_EMAIL;
                    case 121: // USER_NAME
                        return Current.USER_NAME;
                    case 122: // WEB_ENABLED
                        return Current.WEB_ENABLED;
                    case 123: // CASES_KEY
                        return Current.CASES_KEY;
                    case 124: // EMA_APPLY_DATE
                        return Current.EMA_APPLY_DATE;
                    case 125: // EMA_APPLY
                        return Current.EMA_APPLY;
                    case 126: // DSS_SURNAME
                        return Current.DSS_SURNAME;
                    case 127: // DSS_FIRST_NAME
                        return Current.DSS_FIRST_NAME;
                    case 128: // SSN_ELIG_CODE
                        return Current.SSN_ELIG_CODE;
                    case 129: // SSN
                        return Current.SSN;
                    case 130: // EMA_TOTAL1P
                        return Current.EMA_TOTAL1P;
                    case 131: // EMA_STAT1P
                        return Current.EMA_STAT1P;
                    case 132: // EMA_TOTAL2P
                        return Current.EMA_TOTAL2P;
                    case 133: // EMA_STAT2P
                        return Current.EMA_STAT2P;
                    case 134: // EMA_CLAIM_VN
                        return Current.EMA_CLAIM_VN;
                    case 135: // EMA_SEND
                        return Current.EMA_SEND;
                    case 136: // EMA_CLAIM_PD
                        return Current.EMA_CLAIM_PD;
                    case 137: // CASES_EMA_ID
                        return Current.CASES_EMA_ID;
                    case 138: // SCH_ED_A_LU
                        return Current.SCH_ED_A_LU;
                    case 139: // NON_SCH_ED_A_LU
                        return Current.NON_SCH_ED_A_LU;
                    case 140: // OCCUP_STATUS_A_LU
                        return Current.OCCUP_STATUS_A_LU;
                    case 141: // SCH_ED_B_LU
                        return Current.SCH_ED_B_LU;
                    case 142: // NON_SCH_ED_B_LU
                        return Current.NON_SCH_ED_B_LU;
                    case 143: // OCCUP_STATUS_B_LU
                        return Current.OCCUP_STATUS_B_LU;
                    case 144: // CNSE
                        return Current.CNSE;
                    case 145: // CSE
                        return Current.CSE;
                    case 146: // FSE
                        return Current.FSE;
                    case 147: // GENDER_DESC_A
                        return Current.GENDER_DESC_A;
                    case 148: // GENDER_DESC_B
                        return Current.GENDER_DESC_B;
                    case 149: // PARENT_A_SI_ID
                        return Current.PARENT_A_SI_ID;
                    case 150: // PARENT_B_SI_ID
                        return Current.PARENT_B_SI_ID;
                    case 151: // HEALTH_SUM_SI_ID
                        return Current.HEALTH_SUM_SI_ID;
                    case 152: // LW_DATE
                        return Current.LW_DATE;
                    case 153: // LW_TIME
                        return Current.LW_TIME;
                    case 154: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // NAME_A
                        return Current.NAME_A == null;
                    case 2: // SURNAME_A
                        return Current.SURNAME_A == null;
                    case 3: // TITLE_A
                        return Current.TITLE_A == null;
                    case 4: // WORK_CONT_A
                        return Current.WORK_CONT_A == null;
                    case 5: // OCCUPATION_A
                        return Current.OCCUPATION_A == null;
                    case 6: // EMPLOYER_A
                        return Current.EMPLOYER_A == null;
                    case 7: // NATIVE_LANG_A
                        return Current.NATIVE_LANG_A == null;
                    case 8: // OTHER_LANG_A
                        return Current.OTHER_LANG_A == null;
                    case 9: // INTERPRETER_A
                        return Current.INTERPRETER_A == null;
                    case 10: // BIRTH_COUNTRY_A
                        return Current.BIRTH_COUNTRY_A == null;
                    case 11: // BH_AT_HOME_A
                        return Current.BH_AT_HOME_A == null;
                    case 12: // BH_CONTACT_A
                        return Current.BH_CONTACT_A == null;
                    case 13: // BH_CONTACT_A_MEMO
                        return Current.BH_CONTACT_A_MEMO == null;
                    case 14: // AH_AT_HOME_A
                        return Current.AH_AT_HOME_A == null;
                    case 15: // AH_CONTACT_A
                        return Current.AH_CONTACT_A == null;
                    case 16: // AH_CONTACT_A_MEMO
                        return Current.AH_CONTACT_A_MEMO == null;
                    case 17: // E_MAIL_A
                        return Current.E_MAIL_A == null;
                    case 18: // PREF_MAIL_MECH_A
                        return Current.PREF_MAIL_MECH_A == null;
                    case 19: // FAX_A
                        return Current.FAX_A == null;
                    case 20: // GENDER_A
                        return Current.GENDER_A == null;
                    case 21: // SCH_ED_A
                        return Current.SCH_ED_A == null;
                    case 22: // NON_SCH_ED_A
                        return Current.NON_SCH_ED_A == null;
                    case 23: // OCCUP_STATUS_A
                        return Current.OCCUP_STATUS_A == null;
                    case 24: // LOTE_HOME_CODE_A
                        return Current.LOTE_HOME_CODE_A == null;
                    case 25: // MOBILE_A
                        return Current.MOBILE_A == null;
                    case 26: // SMS_NOTIFY_A
                        return Current.SMS_NOTIFY_A == null;
                    case 27: // E_MAIL_NOTIFY_A
                        return Current.E_MAIL_NOTIFY_A == null;
                    case 28: // WWCC_NUMBER_A
                        return Current.WWCC_NUMBER_A == null;
                    case 29: // WWCC_EXPIRY_A
                        return Current.WWCC_EXPIRY_A == null;
                    case 30: // WWCC_TYPE_A
                        return Current.WWCC_TYPE_A == null;
                    case 31: // NAME_B
                        return Current.NAME_B == null;
                    case 32: // SURNAME_B
                        return Current.SURNAME_B == null;
                    case 33: // TITLE_B
                        return Current.TITLE_B == null;
                    case 34: // WORK_CONT_B
                        return Current.WORK_CONT_B == null;
                    case 35: // OCCUPATION_B
                        return Current.OCCUPATION_B == null;
                    case 36: // EMPLOYER_B
                        return Current.EMPLOYER_B == null;
                    case 37: // NATIVE_LANG_B
                        return Current.NATIVE_LANG_B == null;
                    case 38: // OTHER_LANG_B
                        return Current.OTHER_LANG_B == null;
                    case 39: // INTERPRETER_B
                        return Current.INTERPRETER_B == null;
                    case 40: // BIRTH_COUNTRY_B
                        return Current.BIRTH_COUNTRY_B == null;
                    case 41: // BH_AT_HOME_B
                        return Current.BH_AT_HOME_B == null;
                    case 42: // BH_CONTACT_B
                        return Current.BH_CONTACT_B == null;
                    case 43: // BH_CONTACT_B_MEMO
                        return Current.BH_CONTACT_B_MEMO == null;
                    case 44: // AH_AT_HOME_B
                        return Current.AH_AT_HOME_B == null;
                    case 45: // AH_CONTACT_B
                        return Current.AH_CONTACT_B == null;
                    case 46: // AH_CONTACT_B_MEMO
                        return Current.AH_CONTACT_B_MEMO == null;
                    case 47: // E_MAIL_B
                        return Current.E_MAIL_B == null;
                    case 48: // PREF_MAIL_MECH_B
                        return Current.PREF_MAIL_MECH_B == null;
                    case 49: // FAX_B
                        return Current.FAX_B == null;
                    case 50: // GENDER_B
                        return Current.GENDER_B == null;
                    case 51: // SCH_ED_B
                        return Current.SCH_ED_B == null;
                    case 52: // NON_SCH_ED_B
                        return Current.NON_SCH_ED_B == null;
                    case 53: // OCCUP_STATUS_B
                        return Current.OCCUP_STATUS_B == null;
                    case 54: // LOTE_HOME_CODE_B
                        return Current.LOTE_HOME_CODE_B == null;
                    case 55: // MOBILE_B
                        return Current.MOBILE_B == null;
                    case 56: // SMS_NOTIFY_B
                        return Current.SMS_NOTIFY_B == null;
                    case 57: // E_MAIL_NOTIFY_B
                        return Current.E_MAIL_NOTIFY_B == null;
                    case 58: // WWCC_NUMBER_B
                        return Current.WWCC_NUMBER_B == null;
                    case 59: // WWCC_EXPIRY_B
                        return Current.WWCC_EXPIRY_B == null;
                    case 60: // WWCC_TYPE_B
                        return Current.WWCC_TYPE_B == null;
                    case 61: // PREF_NOTICE_LANG
                        return Current.PREF_NOTICE_LANG == null;
                    case 62: // GROUP_AVAILABILITY
                        return Current.GROUP_AVAILABILITY == null;
                    case 63: // OCCUP_STATUS_GRP
                        return Current.OCCUP_STATUS_GRP == null;
                    case 64: // HOMETITLE
                        return Current.HOMETITLE == null;
                    case 65: // HOMEKEY
                        return Current.HOMEKEY == null;
                    case 66: // MAILTITLE
                        return Current.MAILTITLE == null;
                    case 67: // MAILKEY
                        return Current.MAILKEY == null;
                    case 68: // BILLINGTITLE
                        return Current.BILLINGTITLE == null;
                    case 69: // BILLINGKEY
                        return Current.BILLINGKEY == null;
                    case 70: // BILLING_MEMO
                        return Current.BILLING_MEMO == null;
                    case 71: // ACCTYPE
                        return Current.ACCTYPE == null;
                    case 72: // AGED01
                        return Current.AGED01 == null;
                    case 73: // AGED02
                        return Current.AGED02 == null;
                    case 74: // AGED03
                        return Current.AGED03 == null;
                    case 75: // AGED04
                        return Current.AGED04 == null;
                    case 76: // AGED05
                        return Current.AGED05 == null;
                    case 77: // ALLOCAMT
                        return Current.ALLOCAMT == null;
                    case 78: // CHARGES
                        return Current.CHARGES == null;
                    case 79: // LASTREC
                        return Current.LASTREC == null;
                    case 80: // LASTRECDATE
                        return Current.LASTRECDATE == null;
                    case 81: // OPBAL
                        return Current.OPBAL == null;
                    case 82: // OPBAL_YEAR
                        return Current.OPBAL_YEAR == null;
                    case 83: // PRICELEVEL
                        return Current.PRICELEVEL == null;
                    case 84: // BPAY_SEQUENCE
                        return Current.BPAY_SEQUENCE == null;
                    case 85: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE == null;
                    case 86: // NO_STUDENTS
                        return Current.NO_STUDENTS == null;
                    case 87: // NO_ASSOC_STUDENTS
                        return Current.NO_ASSOC_STUDENTS == null;
                    case 88: // CREDIT_LIMIT
                        return Current.CREDIT_LIMIT == null;
                    case 89: // BILL_GROUP
                        return Current.BILL_GROUP == null;
                    case 90: // DOCTOR
                        return Current.DOCTOR == null;
                    case 91: // EMERG_NAME01
                        return Current.EMERG_NAME01 == null;
                    case 92: // EMERG_NAME02
                        return Current.EMERG_NAME02 == null;
                    case 93: // EMERG_NAME03
                        return Current.EMERG_NAME03 == null;
                    case 94: // EMERG_NAME04
                        return Current.EMERG_NAME04 == null;
                    case 95: // EMERG_RELATION01
                        return Current.EMERG_RELATION01 == null;
                    case 96: // EMERG_RELATION02
                        return Current.EMERG_RELATION02 == null;
                    case 97: // EMERG_RELATION03
                        return Current.EMERG_RELATION03 == null;
                    case 98: // EMERG_RELATION04
                        return Current.EMERG_RELATION04 == null;
                    case 99: // EMERG_LANG01
                        return Current.EMERG_LANG01 == null;
                    case 100: // EMERG_LANG02
                        return Current.EMERG_LANG02 == null;
                    case 101: // EMERG_LANG03
                        return Current.EMERG_LANG03 == null;
                    case 102: // EMERG_LANG04
                        return Current.EMERG_LANG04 == null;
                    case 103: // EMERG_CONTACT01
                        return Current.EMERG_CONTACT01 == null;
                    case 104: // EMERG_CONTACT02
                        return Current.EMERG_CONTACT02 == null;
                    case 105: // EMERG_CONTACT03
                        return Current.EMERG_CONTACT03 == null;
                    case 106: // EMERG_CONTACT04
                        return Current.EMERG_CONTACT04 == null;
                    case 107: // EMERG_CONTACT_MEMO01
                        return Current.EMERG_CONTACT_MEMO01 == null;
                    case 108: // EMERG_CONTACT_MEMO02
                        return Current.EMERG_CONTACT_MEMO02 == null;
                    case 109: // EMERG_CONTACT_MEMO03
                        return Current.EMERG_CONTACT_MEMO03 == null;
                    case 110: // EMERG_CONTACT_MEMO04
                        return Current.EMERG_CONTACT_MEMO04 == null;
                    case 111: // ACC_DECLARATION
                        return Current.ACC_DECLARATION == null;
                    case 112: // AMBULANCE_SUBSCRIBER
                        return Current.AMBULANCE_SUBSCRIBER == null;
                    case 113: // MEDICARE_NO
                        return Current.MEDICARE_NO == null;
                    case 114: // HOME_LANG
                        return Current.HOME_LANG == null;
                    case 115: // DRAWER
                        return Current.DRAWER == null;
                    case 116: // BSB
                        return Current.BSB == null;
                    case 117: // TAX_INVOICE
                        return Current.TAX_INVOICE == null;
                    case 118: // ABN
                        return Current.ABN == null;
                    case 119: // BILLING_EMAIL
                        return Current.BILLING_EMAIL == null;
                    case 120: // PREF_EMAIL
                        return Current.PREF_EMAIL == null;
                    case 121: // USER_NAME
                        return Current.USER_NAME == null;
                    case 122: // WEB_ENABLED
                        return Current.WEB_ENABLED == null;
                    case 123: // CASES_KEY
                        return Current.CASES_KEY == null;
                    case 124: // EMA_APPLY_DATE
                        return Current.EMA_APPLY_DATE == null;
                    case 125: // EMA_APPLY
                        return Current.EMA_APPLY == null;
                    case 126: // DSS_SURNAME
                        return Current.DSS_SURNAME == null;
                    case 127: // DSS_FIRST_NAME
                        return Current.DSS_FIRST_NAME == null;
                    case 128: // SSN_ELIG_CODE
                        return Current.SSN_ELIG_CODE == null;
                    case 129: // SSN
                        return Current.SSN == null;
                    case 130: // EMA_TOTAL1P
                        return Current.EMA_TOTAL1P == null;
                    case 131: // EMA_STAT1P
                        return Current.EMA_STAT1P == null;
                    case 132: // EMA_TOTAL2P
                        return Current.EMA_TOTAL2P == null;
                    case 133: // EMA_STAT2P
                        return Current.EMA_STAT2P == null;
                    case 134: // EMA_CLAIM_VN
                        return Current.EMA_CLAIM_VN == null;
                    case 135: // EMA_SEND
                        return Current.EMA_SEND == null;
                    case 136: // EMA_CLAIM_PD
                        return Current.EMA_CLAIM_PD == null;
                    case 137: // CASES_EMA_ID
                        return Current.CASES_EMA_ID == null;
                    case 138: // SCH_ED_A_LU
                        return Current.SCH_ED_A_LU == null;
                    case 139: // NON_SCH_ED_A_LU
                        return Current.NON_SCH_ED_A_LU == null;
                    case 140: // OCCUP_STATUS_A_LU
                        return Current.OCCUP_STATUS_A_LU == null;
                    case 141: // SCH_ED_B_LU
                        return Current.SCH_ED_B_LU == null;
                    case 142: // NON_SCH_ED_B_LU
                        return Current.NON_SCH_ED_B_LU == null;
                    case 143: // OCCUP_STATUS_B_LU
                        return Current.OCCUP_STATUS_B_LU == null;
                    case 144: // CNSE
                        return Current.CNSE == null;
                    case 145: // CSE
                        return Current.CSE == null;
                    case 146: // FSE
                        return Current.FSE == null;
                    case 147: // GENDER_DESC_A
                        return Current.GENDER_DESC_A == null;
                    case 148: // GENDER_DESC_B
                        return Current.GENDER_DESC_B == null;
                    case 149: // PARENT_A_SI_ID
                        return Current.PARENT_A_SI_ID == null;
                    case 150: // PARENT_B_SI_ID
                        return Current.PARENT_B_SI_ID == null;
                    case 151: // HEALTH_SUM_SI_ID
                        return Current.HEALTH_SUM_SI_ID == null;
                    case 152: // LW_DATE
                        return Current.LW_DATE == null;
                    case 153: // LW_TIME
                        return Current.LW_TIME == null;
                    case 154: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // DFKEY
                        return "DFKEY";
                    case 1: // NAME_A
                        return "NAME_A";
                    case 2: // SURNAME_A
                        return "SURNAME_A";
                    case 3: // TITLE_A
                        return "TITLE_A";
                    case 4: // WORK_CONT_A
                        return "WORK_CONT_A";
                    case 5: // OCCUPATION_A
                        return "OCCUPATION_A";
                    case 6: // EMPLOYER_A
                        return "EMPLOYER_A";
                    case 7: // NATIVE_LANG_A
                        return "NATIVE_LANG_A";
                    case 8: // OTHER_LANG_A
                        return "OTHER_LANG_A";
                    case 9: // INTERPRETER_A
                        return "INTERPRETER_A";
                    case 10: // BIRTH_COUNTRY_A
                        return "BIRTH_COUNTRY_A";
                    case 11: // BH_AT_HOME_A
                        return "BH_AT_HOME_A";
                    case 12: // BH_CONTACT_A
                        return "BH_CONTACT_A";
                    case 13: // BH_CONTACT_A_MEMO
                        return "BH_CONTACT_A_MEMO";
                    case 14: // AH_AT_HOME_A
                        return "AH_AT_HOME_A";
                    case 15: // AH_CONTACT_A
                        return "AH_CONTACT_A";
                    case 16: // AH_CONTACT_A_MEMO
                        return "AH_CONTACT_A_MEMO";
                    case 17: // E_MAIL_A
                        return "E_MAIL_A";
                    case 18: // PREF_MAIL_MECH_A
                        return "PREF_MAIL_MECH_A";
                    case 19: // FAX_A
                        return "FAX_A";
                    case 20: // GENDER_A
                        return "GENDER_A";
                    case 21: // SCH_ED_A
                        return "SCH_ED_A";
                    case 22: // NON_SCH_ED_A
                        return "NON_SCH_ED_A";
                    case 23: // OCCUP_STATUS_A
                        return "OCCUP_STATUS_A";
                    case 24: // LOTE_HOME_CODE_A
                        return "LOTE_HOME_CODE_A";
                    case 25: // MOBILE_A
                        return "MOBILE_A";
                    case 26: // SMS_NOTIFY_A
                        return "SMS_NOTIFY_A";
                    case 27: // E_MAIL_NOTIFY_A
                        return "E_MAIL_NOTIFY_A";
                    case 28: // WWCC_NUMBER_A
                        return "WWCC_NUMBER_A";
                    case 29: // WWCC_EXPIRY_A
                        return "WWCC_EXPIRY_A";
                    case 30: // WWCC_TYPE_A
                        return "WWCC_TYPE_A";
                    case 31: // NAME_B
                        return "NAME_B";
                    case 32: // SURNAME_B
                        return "SURNAME_B";
                    case 33: // TITLE_B
                        return "TITLE_B";
                    case 34: // WORK_CONT_B
                        return "WORK_CONT_B";
                    case 35: // OCCUPATION_B
                        return "OCCUPATION_B";
                    case 36: // EMPLOYER_B
                        return "EMPLOYER_B";
                    case 37: // NATIVE_LANG_B
                        return "NATIVE_LANG_B";
                    case 38: // OTHER_LANG_B
                        return "OTHER_LANG_B";
                    case 39: // INTERPRETER_B
                        return "INTERPRETER_B";
                    case 40: // BIRTH_COUNTRY_B
                        return "BIRTH_COUNTRY_B";
                    case 41: // BH_AT_HOME_B
                        return "BH_AT_HOME_B";
                    case 42: // BH_CONTACT_B
                        return "BH_CONTACT_B";
                    case 43: // BH_CONTACT_B_MEMO
                        return "BH_CONTACT_B_MEMO";
                    case 44: // AH_AT_HOME_B
                        return "AH_AT_HOME_B";
                    case 45: // AH_CONTACT_B
                        return "AH_CONTACT_B";
                    case 46: // AH_CONTACT_B_MEMO
                        return "AH_CONTACT_B_MEMO";
                    case 47: // E_MAIL_B
                        return "E_MAIL_B";
                    case 48: // PREF_MAIL_MECH_B
                        return "PREF_MAIL_MECH_B";
                    case 49: // FAX_B
                        return "FAX_B";
                    case 50: // GENDER_B
                        return "GENDER_B";
                    case 51: // SCH_ED_B
                        return "SCH_ED_B";
                    case 52: // NON_SCH_ED_B
                        return "NON_SCH_ED_B";
                    case 53: // OCCUP_STATUS_B
                        return "OCCUP_STATUS_B";
                    case 54: // LOTE_HOME_CODE_B
                        return "LOTE_HOME_CODE_B";
                    case 55: // MOBILE_B
                        return "MOBILE_B";
                    case 56: // SMS_NOTIFY_B
                        return "SMS_NOTIFY_B";
                    case 57: // E_MAIL_NOTIFY_B
                        return "E_MAIL_NOTIFY_B";
                    case 58: // WWCC_NUMBER_B
                        return "WWCC_NUMBER_B";
                    case 59: // WWCC_EXPIRY_B
                        return "WWCC_EXPIRY_B";
                    case 60: // WWCC_TYPE_B
                        return "WWCC_TYPE_B";
                    case 61: // PREF_NOTICE_LANG
                        return "PREF_NOTICE_LANG";
                    case 62: // GROUP_AVAILABILITY
                        return "GROUP_AVAILABILITY";
                    case 63: // OCCUP_STATUS_GRP
                        return "OCCUP_STATUS_GRP";
                    case 64: // HOMETITLE
                        return "HOMETITLE";
                    case 65: // HOMEKEY
                        return "HOMEKEY";
                    case 66: // MAILTITLE
                        return "MAILTITLE";
                    case 67: // MAILKEY
                        return "MAILKEY";
                    case 68: // BILLINGTITLE
                        return "BILLINGTITLE";
                    case 69: // BILLINGKEY
                        return "BILLINGKEY";
                    case 70: // BILLING_MEMO
                        return "BILLING_MEMO";
                    case 71: // ACCTYPE
                        return "ACCTYPE";
                    case 72: // AGED01
                        return "AGED01";
                    case 73: // AGED02
                        return "AGED02";
                    case 74: // AGED03
                        return "AGED03";
                    case 75: // AGED04
                        return "AGED04";
                    case 76: // AGED05
                        return "AGED05";
                    case 77: // ALLOCAMT
                        return "ALLOCAMT";
                    case 78: // CHARGES
                        return "CHARGES";
                    case 79: // LASTREC
                        return "LASTREC";
                    case 80: // LASTRECDATE
                        return "LASTRECDATE";
                    case 81: // OPBAL
                        return "OPBAL";
                    case 82: // OPBAL_YEAR
                        return "OPBAL_YEAR";
                    case 83: // PRICELEVEL
                        return "PRICELEVEL";
                    case 84: // BPAY_SEQUENCE
                        return "BPAY_SEQUENCE";
                    case 85: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 86: // NO_STUDENTS
                        return "NO_STUDENTS";
                    case 87: // NO_ASSOC_STUDENTS
                        return "NO_ASSOC_STUDENTS";
                    case 88: // CREDIT_LIMIT
                        return "CREDIT_LIMIT";
                    case 89: // BILL_GROUP
                        return "BILL_GROUP";
                    case 90: // DOCTOR
                        return "DOCTOR";
                    case 91: // EMERG_NAME01
                        return "EMERG_NAME01";
                    case 92: // EMERG_NAME02
                        return "EMERG_NAME02";
                    case 93: // EMERG_NAME03
                        return "EMERG_NAME03";
                    case 94: // EMERG_NAME04
                        return "EMERG_NAME04";
                    case 95: // EMERG_RELATION01
                        return "EMERG_RELATION01";
                    case 96: // EMERG_RELATION02
                        return "EMERG_RELATION02";
                    case 97: // EMERG_RELATION03
                        return "EMERG_RELATION03";
                    case 98: // EMERG_RELATION04
                        return "EMERG_RELATION04";
                    case 99: // EMERG_LANG01
                        return "EMERG_LANG01";
                    case 100: // EMERG_LANG02
                        return "EMERG_LANG02";
                    case 101: // EMERG_LANG03
                        return "EMERG_LANG03";
                    case 102: // EMERG_LANG04
                        return "EMERG_LANG04";
                    case 103: // EMERG_CONTACT01
                        return "EMERG_CONTACT01";
                    case 104: // EMERG_CONTACT02
                        return "EMERG_CONTACT02";
                    case 105: // EMERG_CONTACT03
                        return "EMERG_CONTACT03";
                    case 106: // EMERG_CONTACT04
                        return "EMERG_CONTACT04";
                    case 107: // EMERG_CONTACT_MEMO01
                        return "EMERG_CONTACT_MEMO01";
                    case 108: // EMERG_CONTACT_MEMO02
                        return "EMERG_CONTACT_MEMO02";
                    case 109: // EMERG_CONTACT_MEMO03
                        return "EMERG_CONTACT_MEMO03";
                    case 110: // EMERG_CONTACT_MEMO04
                        return "EMERG_CONTACT_MEMO04";
                    case 111: // ACC_DECLARATION
                        return "ACC_DECLARATION";
                    case 112: // AMBULANCE_SUBSCRIBER
                        return "AMBULANCE_SUBSCRIBER";
                    case 113: // MEDICARE_NO
                        return "MEDICARE_NO";
                    case 114: // HOME_LANG
                        return "HOME_LANG";
                    case 115: // DRAWER
                        return "DRAWER";
                    case 116: // BSB
                        return "BSB";
                    case 117: // TAX_INVOICE
                        return "TAX_INVOICE";
                    case 118: // ABN
                        return "ABN";
                    case 119: // BILLING_EMAIL
                        return "BILLING_EMAIL";
                    case 120: // PREF_EMAIL
                        return "PREF_EMAIL";
                    case 121: // USER_NAME
                        return "USER_NAME";
                    case 122: // WEB_ENABLED
                        return "WEB_ENABLED";
                    case 123: // CASES_KEY
                        return "CASES_KEY";
                    case 124: // EMA_APPLY_DATE
                        return "EMA_APPLY_DATE";
                    case 125: // EMA_APPLY
                        return "EMA_APPLY";
                    case 126: // DSS_SURNAME
                        return "DSS_SURNAME";
                    case 127: // DSS_FIRST_NAME
                        return "DSS_FIRST_NAME";
                    case 128: // SSN_ELIG_CODE
                        return "SSN_ELIG_CODE";
                    case 129: // SSN
                        return "SSN";
                    case 130: // EMA_TOTAL1P
                        return "EMA_TOTAL1P";
                    case 131: // EMA_STAT1P
                        return "EMA_STAT1P";
                    case 132: // EMA_TOTAL2P
                        return "EMA_TOTAL2P";
                    case 133: // EMA_STAT2P
                        return "EMA_STAT2P";
                    case 134: // EMA_CLAIM_VN
                        return "EMA_CLAIM_VN";
                    case 135: // EMA_SEND
                        return "EMA_SEND";
                    case 136: // EMA_CLAIM_PD
                        return "EMA_CLAIM_PD";
                    case 137: // CASES_EMA_ID
                        return "CASES_EMA_ID";
                    case 138: // SCH_ED_A_LU
                        return "SCH_ED_A_LU";
                    case 139: // NON_SCH_ED_A_LU
                        return "NON_SCH_ED_A_LU";
                    case 140: // OCCUP_STATUS_A_LU
                        return "OCCUP_STATUS_A_LU";
                    case 141: // SCH_ED_B_LU
                        return "SCH_ED_B_LU";
                    case 142: // NON_SCH_ED_B_LU
                        return "NON_SCH_ED_B_LU";
                    case 143: // OCCUP_STATUS_B_LU
                        return "OCCUP_STATUS_B_LU";
                    case 144: // CNSE
                        return "CNSE";
                    case 145: // CSE
                        return "CSE";
                    case 146: // FSE
                        return "FSE";
                    case 147: // GENDER_DESC_A
                        return "GENDER_DESC_A";
                    case 148: // GENDER_DESC_B
                        return "GENDER_DESC_B";
                    case 149: // PARENT_A_SI_ID
                        return "PARENT_A_SI_ID";
                    case 150: // PARENT_B_SI_ID
                        return "PARENT_B_SI_ID";
                    case 151: // HEALTH_SUM_SI_ID
                        return "HEALTH_SUM_SI_ID";
                    case 152: // LW_DATE
                        return "LW_DATE";
                    case 153: // LW_TIME
                        return "LW_TIME";
                    case 154: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "DFKEY":
                        return 0;
                    case "NAME_A":
                        return 1;
                    case "SURNAME_A":
                        return 2;
                    case "TITLE_A":
                        return 3;
                    case "WORK_CONT_A":
                        return 4;
                    case "OCCUPATION_A":
                        return 5;
                    case "EMPLOYER_A":
                        return 6;
                    case "NATIVE_LANG_A":
                        return 7;
                    case "OTHER_LANG_A":
                        return 8;
                    case "INTERPRETER_A":
                        return 9;
                    case "BIRTH_COUNTRY_A":
                        return 10;
                    case "BH_AT_HOME_A":
                        return 11;
                    case "BH_CONTACT_A":
                        return 12;
                    case "BH_CONTACT_A_MEMO":
                        return 13;
                    case "AH_AT_HOME_A":
                        return 14;
                    case "AH_CONTACT_A":
                        return 15;
                    case "AH_CONTACT_A_MEMO":
                        return 16;
                    case "E_MAIL_A":
                        return 17;
                    case "PREF_MAIL_MECH_A":
                        return 18;
                    case "FAX_A":
                        return 19;
                    case "GENDER_A":
                        return 20;
                    case "SCH_ED_A":
                        return 21;
                    case "NON_SCH_ED_A":
                        return 22;
                    case "OCCUP_STATUS_A":
                        return 23;
                    case "LOTE_HOME_CODE_A":
                        return 24;
                    case "MOBILE_A":
                        return 25;
                    case "SMS_NOTIFY_A":
                        return 26;
                    case "E_MAIL_NOTIFY_A":
                        return 27;
                    case "WWCC_NUMBER_A":
                        return 28;
                    case "WWCC_EXPIRY_A":
                        return 29;
                    case "WWCC_TYPE_A":
                        return 30;
                    case "NAME_B":
                        return 31;
                    case "SURNAME_B":
                        return 32;
                    case "TITLE_B":
                        return 33;
                    case "WORK_CONT_B":
                        return 34;
                    case "OCCUPATION_B":
                        return 35;
                    case "EMPLOYER_B":
                        return 36;
                    case "NATIVE_LANG_B":
                        return 37;
                    case "OTHER_LANG_B":
                        return 38;
                    case "INTERPRETER_B":
                        return 39;
                    case "BIRTH_COUNTRY_B":
                        return 40;
                    case "BH_AT_HOME_B":
                        return 41;
                    case "BH_CONTACT_B":
                        return 42;
                    case "BH_CONTACT_B_MEMO":
                        return 43;
                    case "AH_AT_HOME_B":
                        return 44;
                    case "AH_CONTACT_B":
                        return 45;
                    case "AH_CONTACT_B_MEMO":
                        return 46;
                    case "E_MAIL_B":
                        return 47;
                    case "PREF_MAIL_MECH_B":
                        return 48;
                    case "FAX_B":
                        return 49;
                    case "GENDER_B":
                        return 50;
                    case "SCH_ED_B":
                        return 51;
                    case "NON_SCH_ED_B":
                        return 52;
                    case "OCCUP_STATUS_B":
                        return 53;
                    case "LOTE_HOME_CODE_B":
                        return 54;
                    case "MOBILE_B":
                        return 55;
                    case "SMS_NOTIFY_B":
                        return 56;
                    case "E_MAIL_NOTIFY_B":
                        return 57;
                    case "WWCC_NUMBER_B":
                        return 58;
                    case "WWCC_EXPIRY_B":
                        return 59;
                    case "WWCC_TYPE_B":
                        return 60;
                    case "PREF_NOTICE_LANG":
                        return 61;
                    case "GROUP_AVAILABILITY":
                        return 62;
                    case "OCCUP_STATUS_GRP":
                        return 63;
                    case "HOMETITLE":
                        return 64;
                    case "HOMEKEY":
                        return 65;
                    case "MAILTITLE":
                        return 66;
                    case "MAILKEY":
                        return 67;
                    case "BILLINGTITLE":
                        return 68;
                    case "BILLINGKEY":
                        return 69;
                    case "BILLING_MEMO":
                        return 70;
                    case "ACCTYPE":
                        return 71;
                    case "AGED01":
                        return 72;
                    case "AGED02":
                        return 73;
                    case "AGED03":
                        return 74;
                    case "AGED04":
                        return 75;
                    case "AGED05":
                        return 76;
                    case "ALLOCAMT":
                        return 77;
                    case "CHARGES":
                        return 78;
                    case "LASTREC":
                        return 79;
                    case "LASTRECDATE":
                        return 80;
                    case "OPBAL":
                        return 81;
                    case "OPBAL_YEAR":
                        return 82;
                    case "PRICELEVEL":
                        return 83;
                    case "BPAY_SEQUENCE":
                        return 84;
                    case "BPAY_REFERENCE":
                        return 85;
                    case "NO_STUDENTS":
                        return 86;
                    case "NO_ASSOC_STUDENTS":
                        return 87;
                    case "CREDIT_LIMIT":
                        return 88;
                    case "BILL_GROUP":
                        return 89;
                    case "DOCTOR":
                        return 90;
                    case "EMERG_NAME01":
                        return 91;
                    case "EMERG_NAME02":
                        return 92;
                    case "EMERG_NAME03":
                        return 93;
                    case "EMERG_NAME04":
                        return 94;
                    case "EMERG_RELATION01":
                        return 95;
                    case "EMERG_RELATION02":
                        return 96;
                    case "EMERG_RELATION03":
                        return 97;
                    case "EMERG_RELATION04":
                        return 98;
                    case "EMERG_LANG01":
                        return 99;
                    case "EMERG_LANG02":
                        return 100;
                    case "EMERG_LANG03":
                        return 101;
                    case "EMERG_LANG04":
                        return 102;
                    case "EMERG_CONTACT01":
                        return 103;
                    case "EMERG_CONTACT02":
                        return 104;
                    case "EMERG_CONTACT03":
                        return 105;
                    case "EMERG_CONTACT04":
                        return 106;
                    case "EMERG_CONTACT_MEMO01":
                        return 107;
                    case "EMERG_CONTACT_MEMO02":
                        return 108;
                    case "EMERG_CONTACT_MEMO03":
                        return 109;
                    case "EMERG_CONTACT_MEMO04":
                        return 110;
                    case "ACC_DECLARATION":
                        return 111;
                    case "AMBULANCE_SUBSCRIBER":
                        return 112;
                    case "MEDICARE_NO":
                        return 113;
                    case "HOME_LANG":
                        return 114;
                    case "DRAWER":
                        return 115;
                    case "BSB":
                        return 116;
                    case "TAX_INVOICE":
                        return 117;
                    case "ABN":
                        return 118;
                    case "BILLING_EMAIL":
                        return 119;
                    case "PREF_EMAIL":
                        return 120;
                    case "USER_NAME":
                        return 121;
                    case "WEB_ENABLED":
                        return 122;
                    case "CASES_KEY":
                        return 123;
                    case "EMA_APPLY_DATE":
                        return 124;
                    case "EMA_APPLY":
                        return 125;
                    case "DSS_SURNAME":
                        return 126;
                    case "DSS_FIRST_NAME":
                        return 127;
                    case "SSN_ELIG_CODE":
                        return 128;
                    case "SSN":
                        return 129;
                    case "EMA_TOTAL1P":
                        return 130;
                    case "EMA_STAT1P":
                        return 131;
                    case "EMA_TOTAL2P":
                        return 132;
                    case "EMA_STAT2P":
                        return 133;
                    case "EMA_CLAIM_VN":
                        return 134;
                    case "EMA_SEND":
                        return 135;
                    case "EMA_CLAIM_PD":
                        return 136;
                    case "CASES_EMA_ID":
                        return 137;
                    case "SCH_ED_A_LU":
                        return 138;
                    case "NON_SCH_ED_A_LU":
                        return 139;
                    case "OCCUP_STATUS_A_LU":
                        return 140;
                    case "SCH_ED_B_LU":
                        return 141;
                    case "NON_SCH_ED_B_LU":
                        return 142;
                    case "OCCUP_STATUS_B_LU":
                        return 143;
                    case "CNSE":
                        return 144;
                    case "CSE":
                        return 145;
                    case "FSE":
                        return 146;
                    case "GENDER_DESC_A":
                        return 147;
                    case "GENDER_DESC_B":
                        return 148;
                    case "PARENT_A_SI_ID":
                        return 149;
                    case "PARENT_B_SI_ID":
                        return 150;
                    case "HEALTH_SUM_SI_ID":
                        return 151;
                    case "LW_DATE":
                        return 152;
                    case "LW_TIME":
                        return 153;
                    case "LW_USER":
                        return 154;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
