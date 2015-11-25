using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FDT Financal Holding Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FER_FDTDataSet : SetBase<FER_FDT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FER_FDT"; } }

        internal FER_FDTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SOURCE = new Lazy<Dictionary<string, IReadOnlyList<FER_FDT>>>(() => this.ToGroupedDictionary(i => i.SOURCE));
            Index_TID = new Lazy<Dictionary<int, FER_FDT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FER_FDT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FER_FDT" /> fields for each CSV column header</returns>
        protected override Action<FER_FDT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FER_FDT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "DR_DRKEY":
                        mapper[i] = (e, v) => e.DR_DRKEY = v;
                        break;
                    case "DR_DRKEY_IMP":
                        mapper[i] = (e, v) => e.DR_DRKEY_IMP = v;
                        break;
                    case "DR_TITLE":
                        mapper[i] = (e, v) => e.DR_TITLE = v;
                        break;
                    case "DR_CONTACT":
                        mapper[i] = (e, v) => e.DR_CONTACT = v;
                        break;
                    case "DR_BUSNAME":
                        mapper[i] = (e, v) => e.DR_BUSNAME = v;
                        break;
                    case "DR_BUSADD01":
                        mapper[i] = (e, v) => e.DR_BUSADD01 = v;
                        break;
                    case "DR_BUSADD02":
                        mapper[i] = (e, v) => e.DR_BUSADD02 = v;
                        break;
                    case "DR_BUSSTATE":
                        mapper[i] = (e, v) => e.DR_BUSSTATE = v;
                        break;
                    case "DR_POSTCODE":
                        mapper[i] = (e, v) => e.DR_POSTCODE = v;
                        break;
                    case "DR_TELEPHONE":
                        mapper[i] = (e, v) => e.DR_TELEPHONE = v;
                        break;
                    case "DR_FAX":
                        mapper[i] = (e, v) => e.DR_FAX = v;
                        break;
                    case "DR_MAILNAME":
                        mapper[i] = (e, v) => e.DR_MAILNAME = v;
                        break;
                    case "DR_MAILADD01":
                        mapper[i] = (e, v) => e.DR_MAILADD01 = v;
                        break;
                    case "DR_MAILADD02":
                        mapper[i] = (e, v) => e.DR_MAILADD02 = v;
                        break;
                    case "DR_MAILSTATE":
                        mapper[i] = (e, v) => e.DR_MAILSTATE = v;
                        break;
                    case "DR_MAILPOST":
                        mapper[i] = (e, v) => e.DR_MAILPOST = v;
                        break;
                    case "DR_DRTYPE":
                        mapper[i] = (e, v) => e.DR_DRTYPE = v;
                        break;
                    case "DR_CHARGES_YTD":
                        mapper[i] = (e, v) => e.DR_CHARGES_YTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DR_NOTES":
                        mapper[i] = (e, v) => e.DR_NOTES = v;
                        break;
                    case "DR_MEMO_FLAG":
                        mapper[i] = (e, v) => e.DR_MEMO_FLAG = v;
                        break;
                    case "DR_REMARK":
                        mapper[i] = (e, v) => e.DR_REMARK = v;
                        break;
                    case "DR_BILLING_EMAIL":
                        mapper[i] = (e, v) => e.DR_BILLING_EMAIL = v;
                        break;
                    case "DR_BALANCE":
                        mapper[i] = (e, v) => e.DR_BALANCE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CR_CRKEY":
                        mapper[i] = (e, v) => e.CR_CRKEY = v;
                        break;
                    case "CR_CRKEY_IMP":
                        mapper[i] = (e, v) => e.CR_CRKEY_IMP = v;
                        break;
                    case "CR_TITLE":
                        mapper[i] = (e, v) => e.CR_TITLE = v;
                        break;
                    case "CR_CUR_BAL":
                        mapper[i] = (e, v) => e.CR_CUR_BAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CR_CONTACT":
                        mapper[i] = (e, v) => e.CR_CONTACT = v;
                        break;
                    case "CR_ADDRESS01":
                        mapper[i] = (e, v) => e.CR_ADDRESS01 = v;
                        break;
                    case "CR_ADDRESS02":
                        mapper[i] = (e, v) => e.CR_ADDRESS02 = v;
                        break;
                    case "CR_ADDRESS03":
                        mapper[i] = (e, v) => e.CR_ADDRESS03 = v;
                        break;
                    case "CR_STATE":
                        mapper[i] = (e, v) => e.CR_STATE = v;
                        break;
                    case "CR_POSTCODE":
                        mapper[i] = (e, v) => e.CR_POSTCODE = v;
                        break;
                    case "CR_TELEPHONE":
                        mapper[i] = (e, v) => e.CR_TELEPHONE = v;
                        break;
                    case "CR_FAX":
                        mapper[i] = (e, v) => e.CR_FAX = v;
                        break;
                    case "CR_EMAIL":
                        mapper[i] = (e, v) => e.CR_EMAIL = v;
                        break;
                    case "CR_EMAIL_FOR_PAYMENTS":
                        mapper[i] = (e, v) => e.CR_EMAIL_FOR_PAYMENTS = v;
                        break;
                    case "CR_MOBILE":
                        mapper[i] = (e, v) => e.CR_MOBILE = v;
                        break;
                    case "CR_PRMS_FLAG":
                        mapper[i] = (e, v) => e.CR_PRMS_FLAG = v;
                        break;
                    case "CR_ABN":
                        mapper[i] = (e, v) => e.CR_ABN = v;
                        break;
                    case "CR_PAYG_RATE":
                        mapper[i] = (e, v) => e.CR_PAYG_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CR_CRLIMIT":
                        mapper[i] = (e, v) => e.CR_CRLIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CR_TERMS":
                        mapper[i] = (e, v) => e.CR_TERMS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CR_BSB":
                        mapper[i] = (e, v) => e.CR_BSB = v;
                        break;
                    case "CR_ACCOUNT_NO":
                        mapper[i] = (e, v) => e.CR_ACCOUNT_NO = v;
                        break;
                    case "CR_ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.CR_ACCOUNT_NAME = v;
                        break;
                    case "CR_LODGE_REF":
                        mapper[i] = (e, v) => e.CR_LODGE_REF = v;
                        break;
                    case "CR_SURNAME":
                        mapper[i] = (e, v) => e.CR_SURNAME = v;
                        break;
                    case "CR_FIRST_NAME":
                        mapper[i] = (e, v) => e.CR_FIRST_NAME = v;
                        break;
                    case "CR_SECOND_NAME":
                        mapper[i] = (e, v) => e.CR_SECOND_NAME = v;
                        break;
                    case "CR_PAYG_BIRTHDATE":
                        mapper[i] = (e, v) => e.CR_PAYG_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CR_PAYG_STARTDATE":
                        mapper[i] = (e, v) => e.CR_PAYG_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CR_PAYG_TERMDATE":
                        mapper[i] = (e, v) => e.CR_PAYG_TERMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CR_PAYG_ADDRESS01":
                        mapper[i] = (e, v) => e.CR_PAYG_ADDRESS01 = v;
                        break;
                    case "CR_PAYG_ADDRESS02":
                        mapper[i] = (e, v) => e.CR_PAYG_ADDRESS02 = v;
                        break;
                    case "CR_PAYG_SUBURB":
                        mapper[i] = (e, v) => e.CR_PAYG_SUBURB = v;
                        break;
                    case "CR_PAYG_STATE":
                        mapper[i] = (e, v) => e.CR_PAYG_STATE = v;
                        break;
                    case "CR_PAYG_POST":
                        mapper[i] = (e, v) => e.CR_PAYG_POST = v;
                        break;
                    case "CR_PAYG_COUNTRY":
                        mapper[i] = (e, v) => e.CR_PAYG_COUNTRY = v;
                        break;
                    case "CR_PPDKEY":
                        mapper[i] = (e, v) => e.CR_PPDKEY = v;
                        break;
                    case "CR_BILLER_CODE":
                        mapper[i] = (e, v) => e.CR_BILLER_CODE = v;
                        break;
                    case "CR_BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.CR_BPAY_REFERENCE = v;
                        break;
                    case "CR_LASTPAYDATE":
                        mapper[i] = (e, v) => e.CR_LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PE_PEKEY":
                        mapper[i] = (e, v) => e.PE_PEKEY = v;
                        break;
                    case "PE_PEKEY_IMP":
                        mapper[i] = (e, v) => e.PE_PEKEY_IMP = v;
                        break;
                    case "PE_SURNAME":
                        mapper[i] = (e, v) => e.PE_SURNAME = v;
                        break;
                    case "PE_FIRST_NAME":
                        mapper[i] = (e, v) => e.PE_FIRST_NAME = v;
                        break;
                    case "PE_SECOND_NAME":
                        mapper[i] = (e, v) => e.PE_SECOND_NAME = v;
                        break;
                    case "PE_PREF_NAME":
                        mapper[i] = (e, v) => e.PE_PREF_NAME = v;
                        break;
                    case "PE_PREVIOUS_NAME":
                        mapper[i] = (e, v) => e.PE_PREVIOUS_NAME = v;
                        break;
                    case "PE_BIRTHDATE":
                        mapper[i] = (e, v) => e.PE_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PE_GENDER":
                        mapper[i] = (e, v) => e.PE_GENDER = v;
                        break;
                    case "PE_HOMEADD01":
                        mapper[i] = (e, v) => e.PE_HOMEADD01 = v;
                        break;
                    case "PE_HOMEADD02":
                        mapper[i] = (e, v) => e.PE_HOMEADD02 = v;
                        break;
                    case "PE_HOMESUBURB":
                        mapper[i] = (e, v) => e.PE_HOMESUBURB = v;
                        break;
                    case "PE_HOMESTATE":
                        mapper[i] = (e, v) => e.PE_HOMESTATE = v;
                        break;
                    case "PE_HOMEPOST":
                        mapper[i] = (e, v) => e.PE_HOMEPOST = v;
                        break;
                    case "PE_COUNTRY":
                        mapper[i] = (e, v) => e.PE_COUNTRY = v;
                        break;
                    case "PE_HOMEPHONE":
                        mapper[i] = (e, v) => e.PE_HOMEPHONE = v;
                        break;
                    case "PE_BUS_PHONE":
                        mapper[i] = (e, v) => e.PE_BUS_PHONE = v;
                        break;
                    case "PE_PHONE_EXT":
                        mapper[i] = (e, v) => e.PE_PHONE_EXT = v;
                        break;
                    case "PE_FAX":
                        mapper[i] = (e, v) => e.PE_FAX = v;
                        break;
                    case "PE_MOBILE":
                        mapper[i] = (e, v) => e.PE_MOBILE = v;
                        break;
                    case "PE_EMAIL":
                        mapper[i] = (e, v) => e.PE_EMAIL = v;
                        break;
                    case "PE_DRIVERS_LIC_NO":
                        mapper[i] = (e, v) => e.PE_DRIVERS_LIC_NO = v;
                        break;
                    case "PE_SALREVDATE":
                        mapper[i] = (e, v) => e.PE_SALREVDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PE_SUSPEND_DATE":
                        mapper[i] = (e, v) => e.PE_SUSPEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PE_PENUMBER":
                        mapper[i] = (e, v) => e.PE_PENUMBER = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PE_TAXFILENUM":
                        mapper[i] = (e, v) => e.PE_TAXFILENUM = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PE_TAXCODE":
                        mapper[i] = (e, v) => e.PE_TAXCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PE_NO_DEPEND":
                        mapper[i] = (e, v) => e.PE_NO_DEPEND = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PE_DEP_REBATE":
                        mapper[i] = (e, v) => e.PE_DEP_REBATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PE_ZONE_CODE":
                        mapper[i] = (e, v) => e.PE_ZONE_CODE = v;
                        break;
                    case "PE_ZONE_ALLOW":
                        mapper[i] = (e, v) => e.PE_ZONE_ALLOW = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PE_ALLOWANCES":
                        mapper[i] = (e, v) => e.PE_ALLOWANCES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PE_PAYCODE":
                        mapper[i] = (e, v) => e.PE_PAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PE_DEPARTMENT":
                        mapper[i] = (e, v) => e.PE_DEPARTMENT = v;
                        break;
                    case "PE_EMPLOY_TYPE":
                        mapper[i] = (e, v) => e.PE_EMPLOY_TYPE = v;
                        break;
                    case "PE_NORMAL_HOURS":
                        mapper[i] = (e, v) => e.PE_NORMAL_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PE_FTE_VALUE":
                        mapper[i] = (e, v) => e.PE_FTE_VALUE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PE_ANNUAL_SALARY":
                        mapper[i] = (e, v) => e.PE_ANNUAL_SALARY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PE_STD_HOURS":
                        mapper[i] = (e, v) => e.PE_STD_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PE_UNION_NAME":
                        mapper[i] = (e, v) => e.PE_UNION_NAME = v;
                        break;
                    case "PE_MEDICARE_Q09A":
                        mapper[i] = (e, v) => e.PE_MEDICARE_Q09A = v;
                        break;
                    case "PE_MEDICARE_Q10A":
                        mapper[i] = (e, v) => e.PE_MEDICARE_Q10A = v;
                        break;
                    case "PE_MEDICARE_Q11A":
                        mapper[i] = (e, v) => e.PE_MEDICARE_Q11A = v;
                        break;
                    case "PE_MEDICARE_Q12A":
                        mapper[i] = (e, v) => e.PE_MEDICARE_Q12A = v;
                        break;
                    case "PE_LEAVE_GROUP":
                        mapper[i] = (e, v) => e.PE_LEAVE_GROUP = v;
                        break;
                    case "PE_ESUPER_IGNORE_THRESHOLD":
                        mapper[i] = (e, v) => e.PE_ESUPER_IGNORE_THRESHOLD = v;
                        break;
                    case "PE_ESUPER_FUND":
                        mapper[i] = (e, v) => e.PE_ESUPER_FUND = v;
                        break;
                    case "PE_ESUPER_MEMBER":
                        mapper[i] = (e, v) => e.PE_ESUPER_MEMBER = v;
                        break;
                    case "PE_ESUPER_PERCENT":
                        mapper[i] = (e, v) => e.PE_ESUPER_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PE_LASTPAYDATE":
                        mapper[i] = (e, v) => e.PE_LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PE_PEPS_TRCENTRE":
                        mapper[i] = (e, v) => e.PE_PEPS_TRCENTRE = v;
                        break;
                    case "PE_START_DATE_IMP":
                        mapper[i] = (e, v) => e.PE_START_DATE_IMP = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PEPS_CODE":
                        mapper[i] = (e, v) => e.PEPS_CODE = v;
                        break;
                    case "PEPS_PAYITEM":
                        mapper[i] = (e, v) => e.PEPS_PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PEPS_TRCOST":
                        mapper[i] = (e, v) => e.PEPS_TRCOST = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PEPS_TRQTY":
                        mapper[i] = (e, v) => e.PEPS_TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PEPS_TRAMT":
                        mapper[i] = (e, v) => e.PEPS_TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PEPS_TRDET":
                        mapper[i] = (e, v) => e.PEPS_TRDET = v;
                        break;
                    case "PEPS_FLAG":
                        mapper[i] = (e, v) => e.PEPS_FLAG = v;
                        break;
                    case "PEPS_PAY_STEP":
                        mapper[i] = (e, v) => e.PEPS_PAY_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PEPS_SUPER_FUND":
                        mapper[i] = (e, v) => e.PEPS_SUPER_FUND = v;
                        break;
                    case "PEPS_SUPER_MEMBER":
                        mapper[i] = (e, v) => e.PEPS_SUPER_MEMBER = v;
                        break;
                    case "PEPS_SUPER_PERCENT":
                        mapper[i] = (e, v) => e.PEPS_SUPER_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PEPS_TRCENTRE":
                        mapper[i] = (e, v) => e.PEPS_TRCENTRE = v;
                        break;
                    case "PEPM_CODE":
                        mapper[i] = (e, v) => e.PEPM_CODE = v;
                        break;
                    case "PEPM_NAME":
                        mapper[i] = (e, v) => e.PEPM_NAME = v;
                        break;
                    case "PEPM_CHQ_NO":
                        mapper[i] = (e, v) => e.PEPM_CHQ_NO = v;
                        break;
                    case "PEPM_DAMOUNT":
                        mapper[i] = (e, v) => e.PEPM_DAMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PEPM_BANK":
                        mapper[i] = (e, v) => e.PEPM_BANK = v;
                        break;
                    case "PEPM_BSB":
                        mapper[i] = (e, v) => e.PEPM_BSB = v;
                        break;
                    case "PEPM_ACCOUNT_NO":
                        mapper[i] = (e, v) => e.PEPM_ACCOUNT_NO = v;
                        break;
                    case "PEPM_AMOUNT":
                        mapper[i] = (e, v) => e.PEPM_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PEPM_FLAG":
                        mapper[i] = (e, v) => e.PEPM_FLAG = v;
                        break;
                    case "PEPM_PAYMODE":
                        mapper[i] = (e, v) => e.PEPM_PAYMODE = v;
                        break;
                    case "PEPY_CODE":
                        mapper[i] = (e, v) => e.PEPY_CODE = v;
                        break;
                    case "PEPY_TRANSDATE":
                        mapper[i] = (e, v) => e.PEPY_TRANSDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PEPY_STAFF":
                        mapper[i] = (e, v) => e.PEPY_STAFF = v;
                        break;
                    case "PEPY_PURPOSE":
                        mapper[i] = (e, v) => e.PEPY_PURPOSE = v;
                        break;
                    case "PEPY_NOTES":
                        mapper[i] = (e, v) => e.PEPY_NOTES = v;
                        break;
                    case "KPN_KPNKEY":
                        mapper[i] = (e, v) => e.KPN_KPNKEY = v;
                        break;
                    case "KPN_KPNKEY_IMP":
                        mapper[i] = (e, v) => e.KPN_KPNKEY_IMP = v;
                        break;
                    case "KPN_DESCRIPTION":
                        mapper[i] = (e, v) => e.KPN_DESCRIPTION = v;
                        break;
                    case "KPC_KPCKEY":
                        mapper[i] = (e, v) => e.KPC_KPCKEY = v;
                        break;
                    case "KPC_SURNAME":
                        mapper[i] = (e, v) => e.KPC_SURNAME = v;
                        break;
                    case "KPC_FIRST_NAME":
                        mapper[i] = (e, v) => e.KPC_FIRST_NAME = v;
                        break;
                    case "KPC_SECOND_NAME":
                        mapper[i] = (e, v) => e.KPC_SECOND_NAME = v;
                        break;
                    case "KPC_GENDER":
                        mapper[i] = (e, v) => e.KPC_GENDER = v;
                        break;
                    case "KPC_ADDRESS01":
                        mapper[i] = (e, v) => e.KPC_ADDRESS01 = v;
                        break;
                    case "KPC_ADDRESS02":
                        mapper[i] = (e, v) => e.KPC_ADDRESS02 = v;
                        break;
                    case "KPC_ADDRESS03":
                        mapper[i] = (e, v) => e.KPC_ADDRESS03 = v;
                        break;
                    case "KPC_STATE":
                        mapper[i] = (e, v) => e.KPC_STATE = v;
                        break;
                    case "KPC_POST":
                        mapper[i] = (e, v) => e.KPC_POST = v;
                        break;
                    case "KPC_BUS_PHONE":
                        mapper[i] = (e, v) => e.KPC_BUS_PHONE = v;
                        break;
                    case "KPC_HOME_PHONE":
                        mapper[i] = (e, v) => e.KPC_HOME_PHONE = v;
                        break;
                    case "KPC_MOBILE":
                        mapper[i] = (e, v) => e.KPC_MOBILE = v;
                        break;
                    case "KPC_EMAIL":
                        mapper[i] = (e, v) => e.KPC_EMAIL = v;
                        break;
                    case "KPCL_KPCLKEY":
                        mapper[i] = (e, v) => e.KPCL_KPCLKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "KPCL_LINK":
                        mapper[i] = (e, v) => e.KPCL_LINK = v;
                        break;
                    case "KPCL_SOURCE":
                        mapper[i] = (e, v) => e.KPCL_SOURCE = v;
                        break;
                    case "KPCL_CONTACT":
                        mapper[i] = (e, v) => e.KPCL_CONTACT = v;
                        break;
                    case "KPCL_CONTACT_TYPE":
                        mapper[i] = (e, v) => e.KPCL_CONTACT_TYPE = v;
                        break;
                    case "KPCL_CONTACT_PREFERENCE":
                        mapper[i] = (e, v) => e.KPCL_CONTACT_PREFERENCE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "KPCR_KPCRKEY":
                        mapper[i] = (e, v) => e.KPCR_KPCRKEY = v;
                        break;
                    case "KPCR_KPCRKEY_IMP":
                        mapper[i] = (e, v) => e.KPCR_KPCRKEY_IMP = v;
                        break;
                    case "KPCR_DESCRIPTION":
                        mapper[i] = (e, v) => e.KPCR_DESCRIPTION = v;
                        break;
                    case "PF_PFKEY":
                        mapper[i] = (e, v) => e.PF_PFKEY = v;
                        break;
                    case "PF_PFKEY_IMP":
                        mapper[i] = (e, v) => e.PF_PFKEY_IMP = v;
                        break;
                    case "PF_DESCRIPTION":
                        mapper[i] = (e, v) => e.PF_DESCRIPTION = v;
                        break;
                    case "PI_PIKEY":
                        mapper[i] = (e, v) => e.PI_PIKEY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PI_PIKEY_IMP":
                        mapper[i] = (e, v) => e.PI_PIKEY_IMP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PI_PAYCODE":
                        mapper[i] = (e, v) => e.PI_PAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PI_DESCRIPTION":
                        mapper[i] = (e, v) => e.PI_DESCRIPTION = v;
                        break;
                    case "PI_TRANSTYPE":
                        mapper[i] = (e, v) => e.PI_TRANSTYPE = v;
                        break;
                    case "PI_TAXABLE":
                        mapper[i] = (e, v) => e.PI_TAXABLE = v;
                        break;
                    case "PI_UNIT":
                        mapper[i] = (e, v) => e.PI_UNIT = v;
                        break;
                    case "PI_CATEGORY":
                        mapper[i] = (e, v) => e.PI_CATEGORY = v;
                        break;
                    case "PI_PAYG_BOX":
                        mapper[i] = (e, v) => e.PI_PAYG_BOX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PI_TAXRATE":
                        mapper[i] = (e, v) => e.PI_TAXRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PI_AUTOCALC":
                        mapper[i] = (e, v) => e.PI_AUTOCALC = v;
                        break;
                    case "PI_SUPER_LEVY":
                        mapper[i] = (e, v) => e.PI_SUPER_LEVY = v;
                        break;
                    case "PI_PERS_SUPER":
                        mapper[i] = (e, v) => e.PI_PERS_SUPER = v;
                        break;
                    case "PI_PERS_SUPER_RATE":
                        mapper[i] = (e, v) => e.PI_PERS_SUPER_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PI_INITIATIVE":
                        mapper[i] = (e, v) => e.PI_INITIATIVE = v;
                        break;
                    case "AR_ARKEY":
                        mapper[i] = (e, v) => e.AR_ARKEY = v;
                        break;
                    case "AR_ARKEY_IMP":
                        mapper[i] = (e, v) => e.AR_ARKEY_IMP = v;
                        break;
                    case "AR_TITLE":
                        mapper[i] = (e, v) => e.AR_TITLE = v;
                        break;
                    case "AR_DESCRIPTION01":
                        mapper[i] = (e, v) => e.AR_DESCRIPTION01 = v;
                        break;
                    case "AR_DESCRIPTION02":
                        mapper[i] = (e, v) => e.AR_DESCRIPTION02 = v;
                        break;
                    case "AR_ASSET_TYPE":
                        mapper[i] = (e, v) => e.AR_ASSET_TYPE = v;
                        break;
                    case "AR_CATEGORY":
                        mapper[i] = (e, v) => e.AR_CATEGORY = v;
                        break;
                    case "AR_CATEGORY_IMP":
                        mapper[i] = (e, v) => e.AR_CATEGORY_IMP = v;
                        break;
                    case "AR_SUBCATEGORY_IMP":
                        mapper[i] = (e, v) => e.AR_SUBCATEGORY_IMP = v;
                        break;
                    case "AR_TAX_CATEGORY":
                        mapper[i] = (e, v) => e.AR_TAX_CATEGORY = v;
                        break;
                    case "AR_RELEASE_TYPE":
                        mapper[i] = (e, v) => e.AR_RELEASE_TYPE = v;
                        break;
                    case "AR_AOB_COST":
                        mapper[i] = (e, v) => e.AR_AOB_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AR_OB_QTY":
                        mapper[i] = (e, v) => e.AR_OB_QTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AR_ORIG_INVOICE_NO":
                        mapper[i] = (e, v) => e.AR_ORIG_INVOICE_NO = v;
                        break;
                    case "AR_LAST_INVOICE_NO":
                        mapper[i] = (e, v) => e.AR_LAST_INVOICE_NO = v;
                        break;
                    case "AR_WARRANTY":
                        mapper[i] = (e, v) => e.AR_WARRANTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AR_WARRANTYEXP":
                        mapper[i] = (e, v) => e.AR_WARRANTYEXP = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_SERIAL":
                        mapper[i] = (e, v) => e.AR_SERIAL = v;
                        break;
                    case "AR_LOCATION":
                        mapper[i] = (e, v) => e.AR_LOCATION = v;
                        break;
                    case "AR_LOCATION_IMP":
                        mapper[i] = (e, v) => e.AR_LOCATION_IMP = v;
                        break;
                    case "AR_DEPARTMENT":
                        mapper[i] = (e, v) => e.AR_DEPARTMENT = v;
                        break;
                    case "AR_DEPARTMENT_IMP":
                        mapper[i] = (e, v) => e.AR_DEPARTMENT_IMP = v;
                        break;
                    case "AR_CAMPUS":
                        mapper[i] = (e, v) => e.AR_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AR_CAMPUS_IMP":
                        mapper[i] = (e, v) => e.AR_CAMPUS_IMP = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AR_BRANCH":
                        mapper[i] = (e, v) => e.AR_BRANCH = v;
                        break;
                    case "AR_LEASE_START_DATE":
                        mapper[i] = (e, v) => e.AR_LEASE_START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_LEASE_END_DATE":
                        mapper[i] = (e, v) => e.AR_LEASE_END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_LAST_ST_DATE":
                        mapper[i] = (e, v) => e.AR_LAST_ST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_LAST_ADDN_DATE":
                        mapper[i] = (e, v) => e.AR_LAST_ADDN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_EXPECTED_LIFE":
                        mapper[i] = (e, v) => e.AR_EXPECTED_LIFE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AR_LAST_SVC_DATE":
                        mapper[i] = (e, v) => e.AR_LAST_SVC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_NEXT_SVC_DATE":
                        mapper[i] = (e, v) => e.AR_NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_LAST_SVC_DETAILS":
                        mapper[i] = (e, v) => e.AR_LAST_SVC_DETAILS = v;
                        break;
                    case "AR_OWNER":
                        mapper[i] = (e, v) => e.AR_OWNER = v;
                        break;
                    case "AR_CLEANING":
                        mapper[i] = (e, v) => e.AR_CLEANING = v;
                        break;
                    case "AR_HAZARD":
                        mapper[i] = (e, v) => e.AR_HAZARD = v;
                        break;
                    case "AR_SITE_REFERENCE":
                        mapper[i] = (e, v) => e.AR_SITE_REFERENCE = v;
                        break;
                    case "AR_EXTRA_DETAILS":
                        mapper[i] = (e, v) => e.AR_EXTRA_DETAILS = v;
                        break;
                    case "AR_PURDATE":
                        mapper[i] = (e, v) => e.AR_PURDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_PURDATE_IMP":
                        mapper[i] = (e, v) => e.AR_PURDATE_IMP = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AR_ORIG_SUPPLIER":
                        mapper[i] = (e, v) => e.AR_ORIG_SUPPLIER = v;
                        break;
                    case "AR_ORIG_COST":
                        mapper[i] = (e, v) => e.AR_ORIG_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AR_ASSET_PIC":
                        mapper[i] = (e, v) => e.AR_ASSET_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "FDT_COMMENT":
                        mapper[i] = (e, v) => e.FDT_COMMENT = v;
                        break;
                    case "FDT_PROCESS_FLAG":
                        mapper[i] = (e, v) => e.FDT_PROCESS_FLAG = v;
                        break;
                    case "FDT_DATE_EXP":
                        mapper[i] = (e, v) => e.FDT_DATE_EXP = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FDT_TIME_EXP":
                        mapper[i] = (e, v) => e.FDT_TIME_EXP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FDT_DATE_IMP":
                        mapper[i] = (e, v) => e.FDT_DATE_IMP = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FDT_TIME_IMP":
                        mapper[i] = (e, v) => e.FDT_TIME_IMP = v == null ? (short?)null : short.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<FER_FDT>>> Index_SOURCE;
        private Lazy<Dictionary<int, FER_FDT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FER_FDT by SOURCE field
        /// </summary>
        /// <param name="SOURCE">SOURCE value used to find FER_FDT</param>
        /// <returns>List of related FER_FDT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FER_FDT> FindBySOURCE(string SOURCE)
        {
            return Index_SOURCE.Value[SOURCE];
        }

        /// <summary>
        /// Attempt to find FER_FDT by SOURCE field
        /// </summary>
        /// <param name="SOURCE">SOURCE value used to find FER_FDT</param>
        /// <param name="Value">List of related FER_FDT entities</param>
        /// <returns>True if the list of related FER_FDT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySOURCE(string SOURCE, out IReadOnlyList<FER_FDT> Value)
        {
            return Index_SOURCE.Value.TryGetValue(SOURCE, out Value);
        }

        /// <summary>
        /// Attempt to find FER_FDT by SOURCE field
        /// </summary>
        /// <param name="SOURCE">SOURCE value used to find FER_FDT</param>
        /// <returns>List of related FER_FDT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FER_FDT> TryFindBySOURCE(string SOURCE)
        {
            IReadOnlyList<FER_FDT> value;
            if (Index_SOURCE.Value.TryGetValue(SOURCE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find FER_FDT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FER_FDT</param>
        /// <returns>Related FER_FDT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FER_FDT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find FER_FDT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FER_FDT</param>
        /// <param name="Value">Related FER_FDT entity</param>
        /// <returns>True if the related FER_FDT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out FER_FDT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find FER_FDT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FER_FDT</param>
        /// <returns>Related FER_FDT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FER_FDT TryFindByTID(int TID)
        {
            FER_FDT value;
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

    }
}
