using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Families Data Set
    /// </summary>
    public sealed class DF_DataSet : SetBase<DF_Entity>
    {
        private Lazy<Dictionary<string, DF_Entity>> DFKEY_Index;

        internal DF_DataSet(EduHubContext Context)
            : base(Context)
        {
            DFKEY_Index = new Lazy<Dictionary<string, DF_Entity>>(() => this.ToDictionary(e => e.DFKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "DF"; } }

        /// <summary>
        /// Find DF by DFKEY key field
        /// </summary>
        /// <param name="Key">DFKEY value used to find DF</param>
        /// <returns>Related DF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">DFKEY value didn't match any DF entities</exception>
        public DF_Entity FindByDFKEY(string Key)
        {
            DF_Entity result;
            if (DFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find DF by DFKEY key field
        /// </summary>
        /// <param name="Key">DFKEY value used to find DF</param>
        /// <param name="Value">Related DF entity</param>
        /// <returns>True if the DF Entity is found</returns>
        public bool TryFindByDFKEY(string Key, out DF_Entity Value)
        {
            return DFKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find DF by DFKEY key field
        /// </summary>
        /// <param name="Key">DFKEY value used to find DF</param>
        /// <returns>Related DF entity, or null if not found</returns>
        public DF_Entity TryFindByDFKEY(string Key)
        {
            DF_Entity result;
            if (DFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<DF_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<DF_Entity, string>[Headers.Count];

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
    }
}
