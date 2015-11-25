using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Families Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFDataSet : SetBase<DF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DF"; } }

        internal DFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DFKEY = new Lazy<Dictionary<string, DF>>(() => this.ToDictionary(i => i.DFKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_BPAY_REFERENCE = new Lazy<NullDictionary<string, DF>>(() => this.ToNullDictionary(i => i.BPAY_REFERENCE));
            Index_NATIVE_LANG_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.NATIVE_LANG_A));
            Index_OTHER_LANG_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.OTHER_LANG_A));
            Index_BIRTH_COUNTRY_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY_A));
            Index_LOTE_HOME_CODE_A = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.LOTE_HOME_CODE_A));
            Index_NATIVE_LANG_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.NATIVE_LANG_B));
            Index_OTHER_LANG_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.OTHER_LANG_B));
            Index_BIRTH_COUNTRY_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.BIRTH_COUNTRY_B));
            Index_LOTE_HOME_CODE_B = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.LOTE_HOME_CODE_B));
            Index_PREF_NOTICE_LANG = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.PREF_NOTICE_LANG));
            Index_HOMEKEY = new Lazy<NullDictionary<int?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.HOMEKEY));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_BILLINGKEY = new Lazy<NullDictionary<int?, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.BILLINGKEY));
            Index_DOCTOR = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.DOCTOR));
            Index_EMERG_LANG01 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG01));
            Index_EMERG_LANG02 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG02));
            Index_EMERG_LANG03 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG03));
            Index_EMERG_LANG04 = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.EMERG_LANG04));
            Index_HOME_LANG = new Lazy<NullDictionary<string, IReadOnlyList<DF>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANG));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DF" /> fields for each CSV column header</returns>
        protected override Action<DF, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                    case "AH_AT_HOME_A":
                        mapper[i] = (e, v) => e.AH_AT_HOME_A = v;
                        break;
                    case "AH_CONTACT_A":
                        mapper[i] = (e, v) => e.AH_CONTACT_A = v;
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
                    case "AH_AT_HOME_B":
                        mapper[i] = (e, v) => e.AH_AT_HOME_B = v;
                        break;
                    case "AH_CONTACT_B":
                        mapper[i] = (e, v) => e.AH_CONTACT_B = v;
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
                        mapper[i] = (e, v) => e.LASTRECDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                    case "CASES_KEY":
                        mapper[i] = (e, v) => e.CASES_KEY = v;
                        break;
                    case "EMA_APPLY_DATE":
                        mapper[i] = (e, v) => e.EMA_APPLY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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

        private Lazy<Dictionary<string, DF>> Index_DFKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<DF>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, DF>> Index_BPAY_REFERENCE;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_NATIVE_LANG_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_OTHER_LANG_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_BIRTH_COUNTRY_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_LOTE_HOME_CODE_A;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_NATIVE_LANG_B;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_OTHER_LANG_B;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_BIRTH_COUNTRY_B;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_LOTE_HOME_CODE_B;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_PREF_NOTICE_LANG;
        private Lazy<NullDictionary<int?, IReadOnlyList<DF>>> Index_HOMEKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<DF>>> Index_MAILKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<DF>>> Index_BILLINGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_DOCTOR;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG01;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG02;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG03;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_EMERG_LANG04;
        private Lazy<NullDictionary<string, IReadOnlyList<DF>>> Index_HOME_LANG;

        #endregion

        #region Index Methods

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

        #endregion

    }
}
