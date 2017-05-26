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
    /// FDT Financal Holding Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FER_FDTDataSet : EduHubDataSet<FER_FDT>
    {
        /// <inheritdoc />
        public override string Name { get { return "FER_FDT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

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
        internal override Action<FER_FDT, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        /// <summary>
        /// Merges <see cref="FER_FDT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="FER_FDT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="FER_FDT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{FER_FDT}"/> of entities</returns>
        internal override IEnumerable<FER_FDT> ApplyDeltaEntities(IEnumerable<FER_FDT> Entities, List<FER_FDT> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SOURCE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SOURCE.CompareTo(deltaClusteredKey) <= 0)
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

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a FER_FDT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FER_FDT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[FER_FDT](
        [TID] int IDENTITY NOT NULL,
        [SOURCE] varchar(8) NOT NULL,
        [DR_DRKEY] varchar(10) NULL,
        [DR_DRKEY_IMP] varchar(10) NULL,
        [DR_TITLE] varchar(30) NULL,
        [DR_CONTACT] varchar(30) NULL,
        [DR_BUSNAME] varchar(30) NULL,
        [DR_BUSADD01] varchar(30) NULL,
        [DR_BUSADD02] varchar(30) NULL,
        [DR_BUSSTATE] varchar(3) NULL,
        [DR_POSTCODE] varchar(4) NULL,
        [DR_TELEPHONE] varchar(20) NULL,
        [DR_FAX] varchar(15) NULL,
        [DR_MAILNAME] varchar(30) NULL,
        [DR_MAILADD01] varchar(30) NULL,
        [DR_MAILADD02] varchar(30) NULL,
        [DR_MAILSTATE] varchar(3) NULL,
        [DR_MAILPOST] varchar(4) NULL,
        [DR_DRTYPE] varchar(1) NULL,
        [DR_CHARGES_YTD] money NULL,
        [DR_NOTES] varchar(MAX) NULL,
        [DR_MEMO_FLAG] varchar(1) NULL,
        [DR_REMARK] varchar(MAX) NULL,
        [DR_BILLING_EMAIL] varchar(60) NULL,
        [DR_BALANCE] money NULL,
        [CR_CRKEY] varchar(10) NULL,
        [CR_CRKEY_IMP] varchar(10) NULL,
        [CR_TITLE] varchar(40) NULL,
        [CR_CUR_BAL] money NULL,
        [CR_CONTACT] varchar(30) NULL,
        [CR_ADDRESS01] varchar(40) NULL,
        [CR_ADDRESS02] varchar(40) NULL,
        [CR_ADDRESS03] varchar(40) NULL,
        [CR_STATE] varchar(4) NULL,
        [CR_POSTCODE] varchar(4) NULL,
        [CR_TELEPHONE] varchar(15) NULL,
        [CR_FAX] varchar(15) NULL,
        [CR_EMAIL] varchar(60) NULL,
        [CR_EMAIL_FOR_PAYMENTS] varchar(60) NULL,
        [CR_MOBILE] varchar(15) NULL,
        [CR_PRMS_FLAG] varchar(1) NULL,
        [CR_ABN] varchar(15) NULL,
        [CR_PAYG_RATE] float NULL,
        [CR_CRLIMIT] money NULL,
        [CR_TERMS] smallint NULL,
        [CR_BSB] varchar(6) NULL,
        [CR_ACCOUNT_NO] varchar(15) NULL,
        [CR_ACCOUNT_NAME] varchar(60) NULL,
        [CR_LODGE_REF] varchar(18) NULL,
        [CR_SURNAME] varchar(30) NULL,
        [CR_FIRST_NAME] varchar(15) NULL,
        [CR_SECOND_NAME] varchar(15) NULL,
        [CR_PAYG_BIRTHDATE] datetime NULL,
        [CR_PAYG_STARTDATE] datetime NULL,
        [CR_PAYG_TERMDATE] datetime NULL,
        [CR_PAYG_ADDRESS01] varchar(38) NULL,
        [CR_PAYG_ADDRESS02] varchar(38) NULL,
        [CR_PAYG_SUBURB] varchar(20) NULL,
        [CR_PAYG_STATE] varchar(3) NULL,
        [CR_PAYG_POST] varchar(4) NULL,
        [CR_PAYG_COUNTRY] varchar(20) NULL,
        [CR_PPDKEY] varchar(10) NULL,
        [CR_BILLER_CODE] varchar(10) NULL,
        [CR_BPAY_REFERENCE] varchar(20) NULL,
        [CR_LASTPAYDATE] datetime NULL,
        [PE_PEKEY] varchar(10) NULL,
        [PE_PEKEY_IMP] varchar(10) NULL,
        [PE_SURNAME] varchar(20) NULL,
        [PE_FIRST_NAME] varchar(20) NULL,
        [PE_SECOND_NAME] varchar(20) NULL,
        [PE_PREF_NAME] varchar(15) NULL,
        [PE_PREVIOUS_NAME] varchar(30) NULL,
        [PE_BIRTHDATE] datetime NULL,
        [PE_GENDER] varchar(1) NULL,
        [PE_HOMEADD01] varchar(38) NULL,
        [PE_HOMEADD02] varchar(38) NULL,
        [PE_HOMESUBURB] varchar(20) NULL,
        [PE_HOMESTATE] varchar(3) NULL,
        [PE_HOMEPOST] varchar(4) NULL,
        [PE_COUNTRY] varchar(6) NULL,
        [PE_HOMEPHONE] varchar(15) NULL,
        [PE_BUS_PHONE] varchar(15) NULL,
        [PE_PHONE_EXT] varchar(5) NULL,
        [PE_FAX] varchar(15) NULL,
        [PE_MOBILE] varchar(15) NULL,
        [PE_EMAIL] varchar(60) NULL,
        [PE_DRIVERS_LIC_NO] varchar(15) NULL,
        [PE_SALREVDATE] datetime NULL,
        [PE_SUSPEND_DATE] datetime NULL,
        [PE_PENUMBER] int NULL,
        [PE_TAXFILENUM] int NULL,
        [PE_TAXCODE] smallint NULL,
        [PE_NO_DEPEND] smallint NULL,
        [PE_DEP_REBATE] money NULL,
        [PE_ZONE_CODE] varchar(1) NULL,
        [PE_ZONE_ALLOW] money NULL,
        [PE_ALLOWANCES] money NULL,
        [PE_PAYCODE] smallint NULL,
        [PE_DEPARTMENT] varchar(10) NULL,
        [PE_EMPLOY_TYPE] varchar(1) NULL,
        [PE_NORMAL_HOURS] float NULL,
        [PE_FTE_VALUE] float NULL,
        [PE_ANNUAL_SALARY] money NULL,
        [PE_STD_HOURS] float NULL,
        [PE_UNION_NAME] varchar(20) NULL,
        [PE_MEDICARE_Q09A] varchar(1) NULL,
        [PE_MEDICARE_Q10A] varchar(1) NULL,
        [PE_MEDICARE_Q11A] varchar(1) NULL,
        [PE_MEDICARE_Q12A] varchar(1) NULL,
        [PE_LEAVE_GROUP] varchar(8) NULL,
        [PE_ESUPER_IGNORE_THRESHOLD] varchar(1) NULL,
        [PE_ESUPER_FUND] varchar(10) NULL,
        [PE_ESUPER_MEMBER] varchar(20) NULL,
        [PE_ESUPER_PERCENT] float NULL,
        [PE_LASTPAYDATE] datetime NULL,
        [PE_PEPS_TRCENTRE] varchar(10) NULL,
        [PE_START_DATE_IMP] datetime NULL,
        [PEPS_CODE] varchar(10) NULL,
        [PEPS_PAYITEM] smallint NULL,
        [PEPS_TRCOST] float NULL,
        [PEPS_TRQTY] float NULL,
        [PEPS_TRAMT] money NULL,
        [PEPS_TRDET] varchar(30) NULL,
        [PEPS_FLAG] varchar(1) NULL,
        [PEPS_PAY_STEP] smallint NULL,
        [PEPS_SUPER_FUND] varchar(10) NULL,
        [PEPS_SUPER_MEMBER] varchar(20) NULL,
        [PEPS_SUPER_PERCENT] float NULL,
        [PEPS_TRCENTRE] varchar(10) NULL,
        [PEPM_CODE] varchar(10) NULL,
        [PEPM_NAME] varchar(30) NULL,
        [PEPM_CHQ_NO] varchar(10) NULL,
        [PEPM_DAMOUNT] money NULL,
        [PEPM_BANK] varchar(12) NULL,
        [PEPM_BSB] varchar(6) NULL,
        [PEPM_ACCOUNT_NO] varchar(15) NULL,
        [PEPM_AMOUNT] money NULL,
        [PEPM_FLAG] varchar(1) NULL,
        [PEPM_PAYMODE] varchar(2) NULL,
        [PEPY_CODE] varchar(10) NULL,
        [PEPY_TRANSDATE] datetime NULL,
        [PEPY_STAFF] varchar(10) NULL,
        [PEPY_PURPOSE] varchar(6) NULL,
        [PEPY_NOTES] varchar(MAX) NULL,
        [KPN_KPNKEY] varchar(6) NULL,
        [KPN_KPNKEY_IMP] varchar(6) NULL,
        [KPN_DESCRIPTION] varchar(40) NULL,
        [KPC_KPCKEY] varchar(10) NULL,
        [KPC_SURNAME] varchar(20) NULL,
        [KPC_FIRST_NAME] varchar(15) NULL,
        [KPC_SECOND_NAME] varchar(15) NULL,
        [KPC_GENDER] varchar(1) NULL,
        [KPC_ADDRESS01] varchar(30) NULL,
        [KPC_ADDRESS02] varchar(30) NULL,
        [KPC_ADDRESS03] varchar(30) NULL,
        [KPC_STATE] varchar(3) NULL,
        [KPC_POST] varchar(4) NULL,
        [KPC_BUS_PHONE] varchar(15) NULL,
        [KPC_HOME_PHONE] varchar(15) NULL,
        [KPC_MOBILE] varchar(15) NULL,
        [KPC_EMAIL] varchar(MAX) NULL,
        [KPCL_KPCLKEY] int NULL,
        [KPCL_LINK] varchar(10) NULL,
        [KPCL_SOURCE] varchar(3) NULL,
        [KPCL_CONTACT] varchar(10) NULL,
        [KPCL_CONTACT_TYPE] varchar(10) NULL,
        [KPCL_CONTACT_PREFERENCE] smallint NULL,
        [KPCR_KPCRKEY] varchar(10) NULL,
        [KPCR_KPCRKEY_IMP] varchar(10) NULL,
        [KPCR_DESCRIPTION] varchar(30) NULL,
        [PF_PFKEY] varchar(10) NULL,
        [PF_PFKEY_IMP] varchar(10) NULL,
        [PF_DESCRIPTION] varchar(30) NULL,
        [PI_PIKEY] smallint NULL,
        [PI_PIKEY_IMP] smallint NULL,
        [PI_PAYCODE] smallint NULL,
        [PI_DESCRIPTION] varchar(30) NULL,
        [PI_TRANSTYPE] varchar(1) NULL,
        [PI_TAXABLE] varchar(1) NULL,
        [PI_UNIT] varchar(3) NULL,
        [PI_CATEGORY] varchar(5) NULL,
        [PI_PAYG_BOX] smallint NULL,
        [PI_TAXRATE] float NULL,
        [PI_AUTOCALC] varchar(1) NULL,
        [PI_SUPER_LEVY] varchar(1) NULL,
        [PI_PERS_SUPER] varchar(1) NULL,
        [PI_PERS_SUPER_RATE] float NULL,
        [PI_INITIATIVE] varchar(3) NULL,
        [AR_ARKEY] varchar(10) NULL,
        [AR_ARKEY_IMP] varchar(10) NULL,
        [AR_TITLE] varchar(40) NULL,
        [AR_DESCRIPTION01] varchar(30) NULL,
        [AR_DESCRIPTION02] varchar(30) NULL,
        [AR_ASSET_TYPE] varchar(2) NULL,
        [AR_CATEGORY] varchar(10) NULL,
        [AR_CATEGORY_IMP] varchar(10) NULL,
        [AR_SUBCATEGORY_IMP] varchar(10) NULL,
        [AR_TAX_CATEGORY] varchar(10) NULL,
        [AR_RELEASE_TYPE] varchar(2) NULL,
        [AR_AOB_COST] money NULL,
        [AR_OB_QTY] smallint NULL,
        [AR_ORIG_INVOICE_NO] varchar(10) NULL,
        [AR_LAST_INVOICE_NO] varchar(10) NULL,
        [AR_WARRANTY] smallint NULL,
        [AR_WARRANTYEXP] datetime NULL,
        [AR_SERIAL] varchar(20) NULL,
        [AR_LOCATION] varchar(10) NULL,
        [AR_LOCATION_IMP] varchar(10) NULL,
        [AR_DEPARTMENT] varchar(10) NULL,
        [AR_DEPARTMENT_IMP] varchar(10) NULL,
        [AR_CAMPUS] int NULL,
        [AR_CAMPUS_IMP] int NULL,
        [AR_BRANCH] varchar(10) NULL,
        [AR_LEASE_START_DATE] datetime NULL,
        [AR_LEASE_END_DATE] datetime NULL,
        [AR_LAST_ST_DATE] datetime NULL,
        [AR_LAST_ADDN_DATE] datetime NULL,
        [AR_EXPECTED_LIFE] smallint NULL,
        [AR_LAST_SVC_DATE] datetime NULL,
        [AR_NEXT_SVC_DATE] datetime NULL,
        [AR_LAST_SVC_DETAILS] varchar(MAX) NULL,
        [AR_OWNER] varchar(30) NULL,
        [AR_CLEANING] varchar(MAX) NULL,
        [AR_HAZARD] varchar(MAX) NULL,
        [AR_SITE_REFERENCE] varchar(20) NULL,
        [AR_EXTRA_DETAILS] varchar(MAX) NULL,
        [AR_PURDATE] datetime NULL,
        [AR_PURDATE_IMP] datetime NULL,
        [AR_ORIG_SUPPLIER] varchar(10) NULL,
        [AR_ORIG_COST] money NULL,
        [AR_ASSET_PIC] varbinary(MAX) NULL,
        [FDT_COMMENT] varchar(MAX) NULL,
        [FDT_PROCESS_FLAG] varchar(1) NULL,
        [FDT_DATE_EXP] datetime NULL,
        [FDT_TIME_EXP] smallint NULL,
        [FDT_DATE_IMP] datetime NULL,
        [FDT_TIME_IMP] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [FER_FDT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [FER_FDT_Index_SOURCE] ON [dbo].[FER_FDT]
    (
            [SOURCE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[FER_FDT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[FER_FDT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[FER_FDT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[FER_FDT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="FER_FDT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="FER_FDT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<FER_FDT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[FER_FDT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the FER_FDT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FER_FDT data set</returns>
        public override EduHubDataSetDataReader<FER_FDT> GetDataSetDataReader()
        {
            return new FER_FDTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the FER_FDT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FER_FDT data set</returns>
        public override EduHubDataSetDataReader<FER_FDT> GetDataSetDataReader(List<FER_FDT> Entities)
        {
            return new FER_FDTDataReader(new EduHubDataSetLoadedReader<FER_FDT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class FER_FDTDataReader : EduHubDataSetDataReader<FER_FDT>
        {
            public FER_FDTDataReader(IEduHubDataSetReader<FER_FDT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 240; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SOURCE
                        return Current.SOURCE;
                    case 2: // DR_DRKEY
                        return Current.DR_DRKEY;
                    case 3: // DR_DRKEY_IMP
                        return Current.DR_DRKEY_IMP;
                    case 4: // DR_TITLE
                        return Current.DR_TITLE;
                    case 5: // DR_CONTACT
                        return Current.DR_CONTACT;
                    case 6: // DR_BUSNAME
                        return Current.DR_BUSNAME;
                    case 7: // DR_BUSADD01
                        return Current.DR_BUSADD01;
                    case 8: // DR_BUSADD02
                        return Current.DR_BUSADD02;
                    case 9: // DR_BUSSTATE
                        return Current.DR_BUSSTATE;
                    case 10: // DR_POSTCODE
                        return Current.DR_POSTCODE;
                    case 11: // DR_TELEPHONE
                        return Current.DR_TELEPHONE;
                    case 12: // DR_FAX
                        return Current.DR_FAX;
                    case 13: // DR_MAILNAME
                        return Current.DR_MAILNAME;
                    case 14: // DR_MAILADD01
                        return Current.DR_MAILADD01;
                    case 15: // DR_MAILADD02
                        return Current.DR_MAILADD02;
                    case 16: // DR_MAILSTATE
                        return Current.DR_MAILSTATE;
                    case 17: // DR_MAILPOST
                        return Current.DR_MAILPOST;
                    case 18: // DR_DRTYPE
                        return Current.DR_DRTYPE;
                    case 19: // DR_CHARGES_YTD
                        return Current.DR_CHARGES_YTD;
                    case 20: // DR_NOTES
                        return Current.DR_NOTES;
                    case 21: // DR_MEMO_FLAG
                        return Current.DR_MEMO_FLAG;
                    case 22: // DR_REMARK
                        return Current.DR_REMARK;
                    case 23: // DR_BILLING_EMAIL
                        return Current.DR_BILLING_EMAIL;
                    case 24: // DR_BALANCE
                        return Current.DR_BALANCE;
                    case 25: // CR_CRKEY
                        return Current.CR_CRKEY;
                    case 26: // CR_CRKEY_IMP
                        return Current.CR_CRKEY_IMP;
                    case 27: // CR_TITLE
                        return Current.CR_TITLE;
                    case 28: // CR_CUR_BAL
                        return Current.CR_CUR_BAL;
                    case 29: // CR_CONTACT
                        return Current.CR_CONTACT;
                    case 30: // CR_ADDRESS01
                        return Current.CR_ADDRESS01;
                    case 31: // CR_ADDRESS02
                        return Current.CR_ADDRESS02;
                    case 32: // CR_ADDRESS03
                        return Current.CR_ADDRESS03;
                    case 33: // CR_STATE
                        return Current.CR_STATE;
                    case 34: // CR_POSTCODE
                        return Current.CR_POSTCODE;
                    case 35: // CR_TELEPHONE
                        return Current.CR_TELEPHONE;
                    case 36: // CR_FAX
                        return Current.CR_FAX;
                    case 37: // CR_EMAIL
                        return Current.CR_EMAIL;
                    case 38: // CR_EMAIL_FOR_PAYMENTS
                        return Current.CR_EMAIL_FOR_PAYMENTS;
                    case 39: // CR_MOBILE
                        return Current.CR_MOBILE;
                    case 40: // CR_PRMS_FLAG
                        return Current.CR_PRMS_FLAG;
                    case 41: // CR_ABN
                        return Current.CR_ABN;
                    case 42: // CR_PAYG_RATE
                        return Current.CR_PAYG_RATE;
                    case 43: // CR_CRLIMIT
                        return Current.CR_CRLIMIT;
                    case 44: // CR_TERMS
                        return Current.CR_TERMS;
                    case 45: // CR_BSB
                        return Current.CR_BSB;
                    case 46: // CR_ACCOUNT_NO
                        return Current.CR_ACCOUNT_NO;
                    case 47: // CR_ACCOUNT_NAME
                        return Current.CR_ACCOUNT_NAME;
                    case 48: // CR_LODGE_REF
                        return Current.CR_LODGE_REF;
                    case 49: // CR_SURNAME
                        return Current.CR_SURNAME;
                    case 50: // CR_FIRST_NAME
                        return Current.CR_FIRST_NAME;
                    case 51: // CR_SECOND_NAME
                        return Current.CR_SECOND_NAME;
                    case 52: // CR_PAYG_BIRTHDATE
                        return Current.CR_PAYG_BIRTHDATE;
                    case 53: // CR_PAYG_STARTDATE
                        return Current.CR_PAYG_STARTDATE;
                    case 54: // CR_PAYG_TERMDATE
                        return Current.CR_PAYG_TERMDATE;
                    case 55: // CR_PAYG_ADDRESS01
                        return Current.CR_PAYG_ADDRESS01;
                    case 56: // CR_PAYG_ADDRESS02
                        return Current.CR_PAYG_ADDRESS02;
                    case 57: // CR_PAYG_SUBURB
                        return Current.CR_PAYG_SUBURB;
                    case 58: // CR_PAYG_STATE
                        return Current.CR_PAYG_STATE;
                    case 59: // CR_PAYG_POST
                        return Current.CR_PAYG_POST;
                    case 60: // CR_PAYG_COUNTRY
                        return Current.CR_PAYG_COUNTRY;
                    case 61: // CR_PPDKEY
                        return Current.CR_PPDKEY;
                    case 62: // CR_BILLER_CODE
                        return Current.CR_BILLER_CODE;
                    case 63: // CR_BPAY_REFERENCE
                        return Current.CR_BPAY_REFERENCE;
                    case 64: // CR_LASTPAYDATE
                        return Current.CR_LASTPAYDATE;
                    case 65: // PE_PEKEY
                        return Current.PE_PEKEY;
                    case 66: // PE_PEKEY_IMP
                        return Current.PE_PEKEY_IMP;
                    case 67: // PE_SURNAME
                        return Current.PE_SURNAME;
                    case 68: // PE_FIRST_NAME
                        return Current.PE_FIRST_NAME;
                    case 69: // PE_SECOND_NAME
                        return Current.PE_SECOND_NAME;
                    case 70: // PE_PREF_NAME
                        return Current.PE_PREF_NAME;
                    case 71: // PE_PREVIOUS_NAME
                        return Current.PE_PREVIOUS_NAME;
                    case 72: // PE_BIRTHDATE
                        return Current.PE_BIRTHDATE;
                    case 73: // PE_GENDER
                        return Current.PE_GENDER;
                    case 74: // PE_HOMEADD01
                        return Current.PE_HOMEADD01;
                    case 75: // PE_HOMEADD02
                        return Current.PE_HOMEADD02;
                    case 76: // PE_HOMESUBURB
                        return Current.PE_HOMESUBURB;
                    case 77: // PE_HOMESTATE
                        return Current.PE_HOMESTATE;
                    case 78: // PE_HOMEPOST
                        return Current.PE_HOMEPOST;
                    case 79: // PE_COUNTRY
                        return Current.PE_COUNTRY;
                    case 80: // PE_HOMEPHONE
                        return Current.PE_HOMEPHONE;
                    case 81: // PE_BUS_PHONE
                        return Current.PE_BUS_PHONE;
                    case 82: // PE_PHONE_EXT
                        return Current.PE_PHONE_EXT;
                    case 83: // PE_FAX
                        return Current.PE_FAX;
                    case 84: // PE_MOBILE
                        return Current.PE_MOBILE;
                    case 85: // PE_EMAIL
                        return Current.PE_EMAIL;
                    case 86: // PE_DRIVERS_LIC_NO
                        return Current.PE_DRIVERS_LIC_NO;
                    case 87: // PE_SALREVDATE
                        return Current.PE_SALREVDATE;
                    case 88: // PE_SUSPEND_DATE
                        return Current.PE_SUSPEND_DATE;
                    case 89: // PE_PENUMBER
                        return Current.PE_PENUMBER;
                    case 90: // PE_TAXFILENUM
                        return Current.PE_TAXFILENUM;
                    case 91: // PE_TAXCODE
                        return Current.PE_TAXCODE;
                    case 92: // PE_NO_DEPEND
                        return Current.PE_NO_DEPEND;
                    case 93: // PE_DEP_REBATE
                        return Current.PE_DEP_REBATE;
                    case 94: // PE_ZONE_CODE
                        return Current.PE_ZONE_CODE;
                    case 95: // PE_ZONE_ALLOW
                        return Current.PE_ZONE_ALLOW;
                    case 96: // PE_ALLOWANCES
                        return Current.PE_ALLOWANCES;
                    case 97: // PE_PAYCODE
                        return Current.PE_PAYCODE;
                    case 98: // PE_DEPARTMENT
                        return Current.PE_DEPARTMENT;
                    case 99: // PE_EMPLOY_TYPE
                        return Current.PE_EMPLOY_TYPE;
                    case 100: // PE_NORMAL_HOURS
                        return Current.PE_NORMAL_HOURS;
                    case 101: // PE_FTE_VALUE
                        return Current.PE_FTE_VALUE;
                    case 102: // PE_ANNUAL_SALARY
                        return Current.PE_ANNUAL_SALARY;
                    case 103: // PE_STD_HOURS
                        return Current.PE_STD_HOURS;
                    case 104: // PE_UNION_NAME
                        return Current.PE_UNION_NAME;
                    case 105: // PE_MEDICARE_Q09A
                        return Current.PE_MEDICARE_Q09A;
                    case 106: // PE_MEDICARE_Q10A
                        return Current.PE_MEDICARE_Q10A;
                    case 107: // PE_MEDICARE_Q11A
                        return Current.PE_MEDICARE_Q11A;
                    case 108: // PE_MEDICARE_Q12A
                        return Current.PE_MEDICARE_Q12A;
                    case 109: // PE_LEAVE_GROUP
                        return Current.PE_LEAVE_GROUP;
                    case 110: // PE_ESUPER_IGNORE_THRESHOLD
                        return Current.PE_ESUPER_IGNORE_THRESHOLD;
                    case 111: // PE_ESUPER_FUND
                        return Current.PE_ESUPER_FUND;
                    case 112: // PE_ESUPER_MEMBER
                        return Current.PE_ESUPER_MEMBER;
                    case 113: // PE_ESUPER_PERCENT
                        return Current.PE_ESUPER_PERCENT;
                    case 114: // PE_LASTPAYDATE
                        return Current.PE_LASTPAYDATE;
                    case 115: // PE_PEPS_TRCENTRE
                        return Current.PE_PEPS_TRCENTRE;
                    case 116: // PE_START_DATE_IMP
                        return Current.PE_START_DATE_IMP;
                    case 117: // PEPS_CODE
                        return Current.PEPS_CODE;
                    case 118: // PEPS_PAYITEM
                        return Current.PEPS_PAYITEM;
                    case 119: // PEPS_TRCOST
                        return Current.PEPS_TRCOST;
                    case 120: // PEPS_TRQTY
                        return Current.PEPS_TRQTY;
                    case 121: // PEPS_TRAMT
                        return Current.PEPS_TRAMT;
                    case 122: // PEPS_TRDET
                        return Current.PEPS_TRDET;
                    case 123: // PEPS_FLAG
                        return Current.PEPS_FLAG;
                    case 124: // PEPS_PAY_STEP
                        return Current.PEPS_PAY_STEP;
                    case 125: // PEPS_SUPER_FUND
                        return Current.PEPS_SUPER_FUND;
                    case 126: // PEPS_SUPER_MEMBER
                        return Current.PEPS_SUPER_MEMBER;
                    case 127: // PEPS_SUPER_PERCENT
                        return Current.PEPS_SUPER_PERCENT;
                    case 128: // PEPS_TRCENTRE
                        return Current.PEPS_TRCENTRE;
                    case 129: // PEPM_CODE
                        return Current.PEPM_CODE;
                    case 130: // PEPM_NAME
                        return Current.PEPM_NAME;
                    case 131: // PEPM_CHQ_NO
                        return Current.PEPM_CHQ_NO;
                    case 132: // PEPM_DAMOUNT
                        return Current.PEPM_DAMOUNT;
                    case 133: // PEPM_BANK
                        return Current.PEPM_BANK;
                    case 134: // PEPM_BSB
                        return Current.PEPM_BSB;
                    case 135: // PEPM_ACCOUNT_NO
                        return Current.PEPM_ACCOUNT_NO;
                    case 136: // PEPM_AMOUNT
                        return Current.PEPM_AMOUNT;
                    case 137: // PEPM_FLAG
                        return Current.PEPM_FLAG;
                    case 138: // PEPM_PAYMODE
                        return Current.PEPM_PAYMODE;
                    case 139: // PEPY_CODE
                        return Current.PEPY_CODE;
                    case 140: // PEPY_TRANSDATE
                        return Current.PEPY_TRANSDATE;
                    case 141: // PEPY_STAFF
                        return Current.PEPY_STAFF;
                    case 142: // PEPY_PURPOSE
                        return Current.PEPY_PURPOSE;
                    case 143: // PEPY_NOTES
                        return Current.PEPY_NOTES;
                    case 144: // KPN_KPNKEY
                        return Current.KPN_KPNKEY;
                    case 145: // KPN_KPNKEY_IMP
                        return Current.KPN_KPNKEY_IMP;
                    case 146: // KPN_DESCRIPTION
                        return Current.KPN_DESCRIPTION;
                    case 147: // KPC_KPCKEY
                        return Current.KPC_KPCKEY;
                    case 148: // KPC_SURNAME
                        return Current.KPC_SURNAME;
                    case 149: // KPC_FIRST_NAME
                        return Current.KPC_FIRST_NAME;
                    case 150: // KPC_SECOND_NAME
                        return Current.KPC_SECOND_NAME;
                    case 151: // KPC_GENDER
                        return Current.KPC_GENDER;
                    case 152: // KPC_ADDRESS01
                        return Current.KPC_ADDRESS01;
                    case 153: // KPC_ADDRESS02
                        return Current.KPC_ADDRESS02;
                    case 154: // KPC_ADDRESS03
                        return Current.KPC_ADDRESS03;
                    case 155: // KPC_STATE
                        return Current.KPC_STATE;
                    case 156: // KPC_POST
                        return Current.KPC_POST;
                    case 157: // KPC_BUS_PHONE
                        return Current.KPC_BUS_PHONE;
                    case 158: // KPC_HOME_PHONE
                        return Current.KPC_HOME_PHONE;
                    case 159: // KPC_MOBILE
                        return Current.KPC_MOBILE;
                    case 160: // KPC_EMAIL
                        return Current.KPC_EMAIL;
                    case 161: // KPCL_KPCLKEY
                        return Current.KPCL_KPCLKEY;
                    case 162: // KPCL_LINK
                        return Current.KPCL_LINK;
                    case 163: // KPCL_SOURCE
                        return Current.KPCL_SOURCE;
                    case 164: // KPCL_CONTACT
                        return Current.KPCL_CONTACT;
                    case 165: // KPCL_CONTACT_TYPE
                        return Current.KPCL_CONTACT_TYPE;
                    case 166: // KPCL_CONTACT_PREFERENCE
                        return Current.KPCL_CONTACT_PREFERENCE;
                    case 167: // KPCR_KPCRKEY
                        return Current.KPCR_KPCRKEY;
                    case 168: // KPCR_KPCRKEY_IMP
                        return Current.KPCR_KPCRKEY_IMP;
                    case 169: // KPCR_DESCRIPTION
                        return Current.KPCR_DESCRIPTION;
                    case 170: // PF_PFKEY
                        return Current.PF_PFKEY;
                    case 171: // PF_PFKEY_IMP
                        return Current.PF_PFKEY_IMP;
                    case 172: // PF_DESCRIPTION
                        return Current.PF_DESCRIPTION;
                    case 173: // PI_PIKEY
                        return Current.PI_PIKEY;
                    case 174: // PI_PIKEY_IMP
                        return Current.PI_PIKEY_IMP;
                    case 175: // PI_PAYCODE
                        return Current.PI_PAYCODE;
                    case 176: // PI_DESCRIPTION
                        return Current.PI_DESCRIPTION;
                    case 177: // PI_TRANSTYPE
                        return Current.PI_TRANSTYPE;
                    case 178: // PI_TAXABLE
                        return Current.PI_TAXABLE;
                    case 179: // PI_UNIT
                        return Current.PI_UNIT;
                    case 180: // PI_CATEGORY
                        return Current.PI_CATEGORY;
                    case 181: // PI_PAYG_BOX
                        return Current.PI_PAYG_BOX;
                    case 182: // PI_TAXRATE
                        return Current.PI_TAXRATE;
                    case 183: // PI_AUTOCALC
                        return Current.PI_AUTOCALC;
                    case 184: // PI_SUPER_LEVY
                        return Current.PI_SUPER_LEVY;
                    case 185: // PI_PERS_SUPER
                        return Current.PI_PERS_SUPER;
                    case 186: // PI_PERS_SUPER_RATE
                        return Current.PI_PERS_SUPER_RATE;
                    case 187: // PI_INITIATIVE
                        return Current.PI_INITIATIVE;
                    case 188: // AR_ARKEY
                        return Current.AR_ARKEY;
                    case 189: // AR_ARKEY_IMP
                        return Current.AR_ARKEY_IMP;
                    case 190: // AR_TITLE
                        return Current.AR_TITLE;
                    case 191: // AR_DESCRIPTION01
                        return Current.AR_DESCRIPTION01;
                    case 192: // AR_DESCRIPTION02
                        return Current.AR_DESCRIPTION02;
                    case 193: // AR_ASSET_TYPE
                        return Current.AR_ASSET_TYPE;
                    case 194: // AR_CATEGORY
                        return Current.AR_CATEGORY;
                    case 195: // AR_CATEGORY_IMP
                        return Current.AR_CATEGORY_IMP;
                    case 196: // AR_SUBCATEGORY_IMP
                        return Current.AR_SUBCATEGORY_IMP;
                    case 197: // AR_TAX_CATEGORY
                        return Current.AR_TAX_CATEGORY;
                    case 198: // AR_RELEASE_TYPE
                        return Current.AR_RELEASE_TYPE;
                    case 199: // AR_AOB_COST
                        return Current.AR_AOB_COST;
                    case 200: // AR_OB_QTY
                        return Current.AR_OB_QTY;
                    case 201: // AR_ORIG_INVOICE_NO
                        return Current.AR_ORIG_INVOICE_NO;
                    case 202: // AR_LAST_INVOICE_NO
                        return Current.AR_LAST_INVOICE_NO;
                    case 203: // AR_WARRANTY
                        return Current.AR_WARRANTY;
                    case 204: // AR_WARRANTYEXP
                        return Current.AR_WARRANTYEXP;
                    case 205: // AR_SERIAL
                        return Current.AR_SERIAL;
                    case 206: // AR_LOCATION
                        return Current.AR_LOCATION;
                    case 207: // AR_LOCATION_IMP
                        return Current.AR_LOCATION_IMP;
                    case 208: // AR_DEPARTMENT
                        return Current.AR_DEPARTMENT;
                    case 209: // AR_DEPARTMENT_IMP
                        return Current.AR_DEPARTMENT_IMP;
                    case 210: // AR_CAMPUS
                        return Current.AR_CAMPUS;
                    case 211: // AR_CAMPUS_IMP
                        return Current.AR_CAMPUS_IMP;
                    case 212: // AR_BRANCH
                        return Current.AR_BRANCH;
                    case 213: // AR_LEASE_START_DATE
                        return Current.AR_LEASE_START_DATE;
                    case 214: // AR_LEASE_END_DATE
                        return Current.AR_LEASE_END_DATE;
                    case 215: // AR_LAST_ST_DATE
                        return Current.AR_LAST_ST_DATE;
                    case 216: // AR_LAST_ADDN_DATE
                        return Current.AR_LAST_ADDN_DATE;
                    case 217: // AR_EXPECTED_LIFE
                        return Current.AR_EXPECTED_LIFE;
                    case 218: // AR_LAST_SVC_DATE
                        return Current.AR_LAST_SVC_DATE;
                    case 219: // AR_NEXT_SVC_DATE
                        return Current.AR_NEXT_SVC_DATE;
                    case 220: // AR_LAST_SVC_DETAILS
                        return Current.AR_LAST_SVC_DETAILS;
                    case 221: // AR_OWNER
                        return Current.AR_OWNER;
                    case 222: // AR_CLEANING
                        return Current.AR_CLEANING;
                    case 223: // AR_HAZARD
                        return Current.AR_HAZARD;
                    case 224: // AR_SITE_REFERENCE
                        return Current.AR_SITE_REFERENCE;
                    case 225: // AR_EXTRA_DETAILS
                        return Current.AR_EXTRA_DETAILS;
                    case 226: // AR_PURDATE
                        return Current.AR_PURDATE;
                    case 227: // AR_PURDATE_IMP
                        return Current.AR_PURDATE_IMP;
                    case 228: // AR_ORIG_SUPPLIER
                        return Current.AR_ORIG_SUPPLIER;
                    case 229: // AR_ORIG_COST
                        return Current.AR_ORIG_COST;
                    case 230: // AR_ASSET_PIC
                        return Current.AR_ASSET_PIC;
                    case 231: // FDT_COMMENT
                        return Current.FDT_COMMENT;
                    case 232: // FDT_PROCESS_FLAG
                        return Current.FDT_PROCESS_FLAG;
                    case 233: // FDT_DATE_EXP
                        return Current.FDT_DATE_EXP;
                    case 234: // FDT_TIME_EXP
                        return Current.FDT_TIME_EXP;
                    case 235: // FDT_DATE_IMP
                        return Current.FDT_DATE_IMP;
                    case 236: // FDT_TIME_IMP
                        return Current.FDT_TIME_IMP;
                    case 237: // LW_DATE
                        return Current.LW_DATE;
                    case 238: // LW_TIME
                        return Current.LW_TIME;
                    case 239: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // DR_DRKEY
                        return Current.DR_DRKEY == null;
                    case 3: // DR_DRKEY_IMP
                        return Current.DR_DRKEY_IMP == null;
                    case 4: // DR_TITLE
                        return Current.DR_TITLE == null;
                    case 5: // DR_CONTACT
                        return Current.DR_CONTACT == null;
                    case 6: // DR_BUSNAME
                        return Current.DR_BUSNAME == null;
                    case 7: // DR_BUSADD01
                        return Current.DR_BUSADD01 == null;
                    case 8: // DR_BUSADD02
                        return Current.DR_BUSADD02 == null;
                    case 9: // DR_BUSSTATE
                        return Current.DR_BUSSTATE == null;
                    case 10: // DR_POSTCODE
                        return Current.DR_POSTCODE == null;
                    case 11: // DR_TELEPHONE
                        return Current.DR_TELEPHONE == null;
                    case 12: // DR_FAX
                        return Current.DR_FAX == null;
                    case 13: // DR_MAILNAME
                        return Current.DR_MAILNAME == null;
                    case 14: // DR_MAILADD01
                        return Current.DR_MAILADD01 == null;
                    case 15: // DR_MAILADD02
                        return Current.DR_MAILADD02 == null;
                    case 16: // DR_MAILSTATE
                        return Current.DR_MAILSTATE == null;
                    case 17: // DR_MAILPOST
                        return Current.DR_MAILPOST == null;
                    case 18: // DR_DRTYPE
                        return Current.DR_DRTYPE == null;
                    case 19: // DR_CHARGES_YTD
                        return Current.DR_CHARGES_YTD == null;
                    case 20: // DR_NOTES
                        return Current.DR_NOTES == null;
                    case 21: // DR_MEMO_FLAG
                        return Current.DR_MEMO_FLAG == null;
                    case 22: // DR_REMARK
                        return Current.DR_REMARK == null;
                    case 23: // DR_BILLING_EMAIL
                        return Current.DR_BILLING_EMAIL == null;
                    case 24: // DR_BALANCE
                        return Current.DR_BALANCE == null;
                    case 25: // CR_CRKEY
                        return Current.CR_CRKEY == null;
                    case 26: // CR_CRKEY_IMP
                        return Current.CR_CRKEY_IMP == null;
                    case 27: // CR_TITLE
                        return Current.CR_TITLE == null;
                    case 28: // CR_CUR_BAL
                        return Current.CR_CUR_BAL == null;
                    case 29: // CR_CONTACT
                        return Current.CR_CONTACT == null;
                    case 30: // CR_ADDRESS01
                        return Current.CR_ADDRESS01 == null;
                    case 31: // CR_ADDRESS02
                        return Current.CR_ADDRESS02 == null;
                    case 32: // CR_ADDRESS03
                        return Current.CR_ADDRESS03 == null;
                    case 33: // CR_STATE
                        return Current.CR_STATE == null;
                    case 34: // CR_POSTCODE
                        return Current.CR_POSTCODE == null;
                    case 35: // CR_TELEPHONE
                        return Current.CR_TELEPHONE == null;
                    case 36: // CR_FAX
                        return Current.CR_FAX == null;
                    case 37: // CR_EMAIL
                        return Current.CR_EMAIL == null;
                    case 38: // CR_EMAIL_FOR_PAYMENTS
                        return Current.CR_EMAIL_FOR_PAYMENTS == null;
                    case 39: // CR_MOBILE
                        return Current.CR_MOBILE == null;
                    case 40: // CR_PRMS_FLAG
                        return Current.CR_PRMS_FLAG == null;
                    case 41: // CR_ABN
                        return Current.CR_ABN == null;
                    case 42: // CR_PAYG_RATE
                        return Current.CR_PAYG_RATE == null;
                    case 43: // CR_CRLIMIT
                        return Current.CR_CRLIMIT == null;
                    case 44: // CR_TERMS
                        return Current.CR_TERMS == null;
                    case 45: // CR_BSB
                        return Current.CR_BSB == null;
                    case 46: // CR_ACCOUNT_NO
                        return Current.CR_ACCOUNT_NO == null;
                    case 47: // CR_ACCOUNT_NAME
                        return Current.CR_ACCOUNT_NAME == null;
                    case 48: // CR_LODGE_REF
                        return Current.CR_LODGE_REF == null;
                    case 49: // CR_SURNAME
                        return Current.CR_SURNAME == null;
                    case 50: // CR_FIRST_NAME
                        return Current.CR_FIRST_NAME == null;
                    case 51: // CR_SECOND_NAME
                        return Current.CR_SECOND_NAME == null;
                    case 52: // CR_PAYG_BIRTHDATE
                        return Current.CR_PAYG_BIRTHDATE == null;
                    case 53: // CR_PAYG_STARTDATE
                        return Current.CR_PAYG_STARTDATE == null;
                    case 54: // CR_PAYG_TERMDATE
                        return Current.CR_PAYG_TERMDATE == null;
                    case 55: // CR_PAYG_ADDRESS01
                        return Current.CR_PAYG_ADDRESS01 == null;
                    case 56: // CR_PAYG_ADDRESS02
                        return Current.CR_PAYG_ADDRESS02 == null;
                    case 57: // CR_PAYG_SUBURB
                        return Current.CR_PAYG_SUBURB == null;
                    case 58: // CR_PAYG_STATE
                        return Current.CR_PAYG_STATE == null;
                    case 59: // CR_PAYG_POST
                        return Current.CR_PAYG_POST == null;
                    case 60: // CR_PAYG_COUNTRY
                        return Current.CR_PAYG_COUNTRY == null;
                    case 61: // CR_PPDKEY
                        return Current.CR_PPDKEY == null;
                    case 62: // CR_BILLER_CODE
                        return Current.CR_BILLER_CODE == null;
                    case 63: // CR_BPAY_REFERENCE
                        return Current.CR_BPAY_REFERENCE == null;
                    case 64: // CR_LASTPAYDATE
                        return Current.CR_LASTPAYDATE == null;
                    case 65: // PE_PEKEY
                        return Current.PE_PEKEY == null;
                    case 66: // PE_PEKEY_IMP
                        return Current.PE_PEKEY_IMP == null;
                    case 67: // PE_SURNAME
                        return Current.PE_SURNAME == null;
                    case 68: // PE_FIRST_NAME
                        return Current.PE_FIRST_NAME == null;
                    case 69: // PE_SECOND_NAME
                        return Current.PE_SECOND_NAME == null;
                    case 70: // PE_PREF_NAME
                        return Current.PE_PREF_NAME == null;
                    case 71: // PE_PREVIOUS_NAME
                        return Current.PE_PREVIOUS_NAME == null;
                    case 72: // PE_BIRTHDATE
                        return Current.PE_BIRTHDATE == null;
                    case 73: // PE_GENDER
                        return Current.PE_GENDER == null;
                    case 74: // PE_HOMEADD01
                        return Current.PE_HOMEADD01 == null;
                    case 75: // PE_HOMEADD02
                        return Current.PE_HOMEADD02 == null;
                    case 76: // PE_HOMESUBURB
                        return Current.PE_HOMESUBURB == null;
                    case 77: // PE_HOMESTATE
                        return Current.PE_HOMESTATE == null;
                    case 78: // PE_HOMEPOST
                        return Current.PE_HOMEPOST == null;
                    case 79: // PE_COUNTRY
                        return Current.PE_COUNTRY == null;
                    case 80: // PE_HOMEPHONE
                        return Current.PE_HOMEPHONE == null;
                    case 81: // PE_BUS_PHONE
                        return Current.PE_BUS_PHONE == null;
                    case 82: // PE_PHONE_EXT
                        return Current.PE_PHONE_EXT == null;
                    case 83: // PE_FAX
                        return Current.PE_FAX == null;
                    case 84: // PE_MOBILE
                        return Current.PE_MOBILE == null;
                    case 85: // PE_EMAIL
                        return Current.PE_EMAIL == null;
                    case 86: // PE_DRIVERS_LIC_NO
                        return Current.PE_DRIVERS_LIC_NO == null;
                    case 87: // PE_SALREVDATE
                        return Current.PE_SALREVDATE == null;
                    case 88: // PE_SUSPEND_DATE
                        return Current.PE_SUSPEND_DATE == null;
                    case 89: // PE_PENUMBER
                        return Current.PE_PENUMBER == null;
                    case 90: // PE_TAXFILENUM
                        return Current.PE_TAXFILENUM == null;
                    case 91: // PE_TAXCODE
                        return Current.PE_TAXCODE == null;
                    case 92: // PE_NO_DEPEND
                        return Current.PE_NO_DEPEND == null;
                    case 93: // PE_DEP_REBATE
                        return Current.PE_DEP_REBATE == null;
                    case 94: // PE_ZONE_CODE
                        return Current.PE_ZONE_CODE == null;
                    case 95: // PE_ZONE_ALLOW
                        return Current.PE_ZONE_ALLOW == null;
                    case 96: // PE_ALLOWANCES
                        return Current.PE_ALLOWANCES == null;
                    case 97: // PE_PAYCODE
                        return Current.PE_PAYCODE == null;
                    case 98: // PE_DEPARTMENT
                        return Current.PE_DEPARTMENT == null;
                    case 99: // PE_EMPLOY_TYPE
                        return Current.PE_EMPLOY_TYPE == null;
                    case 100: // PE_NORMAL_HOURS
                        return Current.PE_NORMAL_HOURS == null;
                    case 101: // PE_FTE_VALUE
                        return Current.PE_FTE_VALUE == null;
                    case 102: // PE_ANNUAL_SALARY
                        return Current.PE_ANNUAL_SALARY == null;
                    case 103: // PE_STD_HOURS
                        return Current.PE_STD_HOURS == null;
                    case 104: // PE_UNION_NAME
                        return Current.PE_UNION_NAME == null;
                    case 105: // PE_MEDICARE_Q09A
                        return Current.PE_MEDICARE_Q09A == null;
                    case 106: // PE_MEDICARE_Q10A
                        return Current.PE_MEDICARE_Q10A == null;
                    case 107: // PE_MEDICARE_Q11A
                        return Current.PE_MEDICARE_Q11A == null;
                    case 108: // PE_MEDICARE_Q12A
                        return Current.PE_MEDICARE_Q12A == null;
                    case 109: // PE_LEAVE_GROUP
                        return Current.PE_LEAVE_GROUP == null;
                    case 110: // PE_ESUPER_IGNORE_THRESHOLD
                        return Current.PE_ESUPER_IGNORE_THRESHOLD == null;
                    case 111: // PE_ESUPER_FUND
                        return Current.PE_ESUPER_FUND == null;
                    case 112: // PE_ESUPER_MEMBER
                        return Current.PE_ESUPER_MEMBER == null;
                    case 113: // PE_ESUPER_PERCENT
                        return Current.PE_ESUPER_PERCENT == null;
                    case 114: // PE_LASTPAYDATE
                        return Current.PE_LASTPAYDATE == null;
                    case 115: // PE_PEPS_TRCENTRE
                        return Current.PE_PEPS_TRCENTRE == null;
                    case 116: // PE_START_DATE_IMP
                        return Current.PE_START_DATE_IMP == null;
                    case 117: // PEPS_CODE
                        return Current.PEPS_CODE == null;
                    case 118: // PEPS_PAYITEM
                        return Current.PEPS_PAYITEM == null;
                    case 119: // PEPS_TRCOST
                        return Current.PEPS_TRCOST == null;
                    case 120: // PEPS_TRQTY
                        return Current.PEPS_TRQTY == null;
                    case 121: // PEPS_TRAMT
                        return Current.PEPS_TRAMT == null;
                    case 122: // PEPS_TRDET
                        return Current.PEPS_TRDET == null;
                    case 123: // PEPS_FLAG
                        return Current.PEPS_FLAG == null;
                    case 124: // PEPS_PAY_STEP
                        return Current.PEPS_PAY_STEP == null;
                    case 125: // PEPS_SUPER_FUND
                        return Current.PEPS_SUPER_FUND == null;
                    case 126: // PEPS_SUPER_MEMBER
                        return Current.PEPS_SUPER_MEMBER == null;
                    case 127: // PEPS_SUPER_PERCENT
                        return Current.PEPS_SUPER_PERCENT == null;
                    case 128: // PEPS_TRCENTRE
                        return Current.PEPS_TRCENTRE == null;
                    case 129: // PEPM_CODE
                        return Current.PEPM_CODE == null;
                    case 130: // PEPM_NAME
                        return Current.PEPM_NAME == null;
                    case 131: // PEPM_CHQ_NO
                        return Current.PEPM_CHQ_NO == null;
                    case 132: // PEPM_DAMOUNT
                        return Current.PEPM_DAMOUNT == null;
                    case 133: // PEPM_BANK
                        return Current.PEPM_BANK == null;
                    case 134: // PEPM_BSB
                        return Current.PEPM_BSB == null;
                    case 135: // PEPM_ACCOUNT_NO
                        return Current.PEPM_ACCOUNT_NO == null;
                    case 136: // PEPM_AMOUNT
                        return Current.PEPM_AMOUNT == null;
                    case 137: // PEPM_FLAG
                        return Current.PEPM_FLAG == null;
                    case 138: // PEPM_PAYMODE
                        return Current.PEPM_PAYMODE == null;
                    case 139: // PEPY_CODE
                        return Current.PEPY_CODE == null;
                    case 140: // PEPY_TRANSDATE
                        return Current.PEPY_TRANSDATE == null;
                    case 141: // PEPY_STAFF
                        return Current.PEPY_STAFF == null;
                    case 142: // PEPY_PURPOSE
                        return Current.PEPY_PURPOSE == null;
                    case 143: // PEPY_NOTES
                        return Current.PEPY_NOTES == null;
                    case 144: // KPN_KPNKEY
                        return Current.KPN_KPNKEY == null;
                    case 145: // KPN_KPNKEY_IMP
                        return Current.KPN_KPNKEY_IMP == null;
                    case 146: // KPN_DESCRIPTION
                        return Current.KPN_DESCRIPTION == null;
                    case 147: // KPC_KPCKEY
                        return Current.KPC_KPCKEY == null;
                    case 148: // KPC_SURNAME
                        return Current.KPC_SURNAME == null;
                    case 149: // KPC_FIRST_NAME
                        return Current.KPC_FIRST_NAME == null;
                    case 150: // KPC_SECOND_NAME
                        return Current.KPC_SECOND_NAME == null;
                    case 151: // KPC_GENDER
                        return Current.KPC_GENDER == null;
                    case 152: // KPC_ADDRESS01
                        return Current.KPC_ADDRESS01 == null;
                    case 153: // KPC_ADDRESS02
                        return Current.KPC_ADDRESS02 == null;
                    case 154: // KPC_ADDRESS03
                        return Current.KPC_ADDRESS03 == null;
                    case 155: // KPC_STATE
                        return Current.KPC_STATE == null;
                    case 156: // KPC_POST
                        return Current.KPC_POST == null;
                    case 157: // KPC_BUS_PHONE
                        return Current.KPC_BUS_PHONE == null;
                    case 158: // KPC_HOME_PHONE
                        return Current.KPC_HOME_PHONE == null;
                    case 159: // KPC_MOBILE
                        return Current.KPC_MOBILE == null;
                    case 160: // KPC_EMAIL
                        return Current.KPC_EMAIL == null;
                    case 161: // KPCL_KPCLKEY
                        return Current.KPCL_KPCLKEY == null;
                    case 162: // KPCL_LINK
                        return Current.KPCL_LINK == null;
                    case 163: // KPCL_SOURCE
                        return Current.KPCL_SOURCE == null;
                    case 164: // KPCL_CONTACT
                        return Current.KPCL_CONTACT == null;
                    case 165: // KPCL_CONTACT_TYPE
                        return Current.KPCL_CONTACT_TYPE == null;
                    case 166: // KPCL_CONTACT_PREFERENCE
                        return Current.KPCL_CONTACT_PREFERENCE == null;
                    case 167: // KPCR_KPCRKEY
                        return Current.KPCR_KPCRKEY == null;
                    case 168: // KPCR_KPCRKEY_IMP
                        return Current.KPCR_KPCRKEY_IMP == null;
                    case 169: // KPCR_DESCRIPTION
                        return Current.KPCR_DESCRIPTION == null;
                    case 170: // PF_PFKEY
                        return Current.PF_PFKEY == null;
                    case 171: // PF_PFKEY_IMP
                        return Current.PF_PFKEY_IMP == null;
                    case 172: // PF_DESCRIPTION
                        return Current.PF_DESCRIPTION == null;
                    case 173: // PI_PIKEY
                        return Current.PI_PIKEY == null;
                    case 174: // PI_PIKEY_IMP
                        return Current.PI_PIKEY_IMP == null;
                    case 175: // PI_PAYCODE
                        return Current.PI_PAYCODE == null;
                    case 176: // PI_DESCRIPTION
                        return Current.PI_DESCRIPTION == null;
                    case 177: // PI_TRANSTYPE
                        return Current.PI_TRANSTYPE == null;
                    case 178: // PI_TAXABLE
                        return Current.PI_TAXABLE == null;
                    case 179: // PI_UNIT
                        return Current.PI_UNIT == null;
                    case 180: // PI_CATEGORY
                        return Current.PI_CATEGORY == null;
                    case 181: // PI_PAYG_BOX
                        return Current.PI_PAYG_BOX == null;
                    case 182: // PI_TAXRATE
                        return Current.PI_TAXRATE == null;
                    case 183: // PI_AUTOCALC
                        return Current.PI_AUTOCALC == null;
                    case 184: // PI_SUPER_LEVY
                        return Current.PI_SUPER_LEVY == null;
                    case 185: // PI_PERS_SUPER
                        return Current.PI_PERS_SUPER == null;
                    case 186: // PI_PERS_SUPER_RATE
                        return Current.PI_PERS_SUPER_RATE == null;
                    case 187: // PI_INITIATIVE
                        return Current.PI_INITIATIVE == null;
                    case 188: // AR_ARKEY
                        return Current.AR_ARKEY == null;
                    case 189: // AR_ARKEY_IMP
                        return Current.AR_ARKEY_IMP == null;
                    case 190: // AR_TITLE
                        return Current.AR_TITLE == null;
                    case 191: // AR_DESCRIPTION01
                        return Current.AR_DESCRIPTION01 == null;
                    case 192: // AR_DESCRIPTION02
                        return Current.AR_DESCRIPTION02 == null;
                    case 193: // AR_ASSET_TYPE
                        return Current.AR_ASSET_TYPE == null;
                    case 194: // AR_CATEGORY
                        return Current.AR_CATEGORY == null;
                    case 195: // AR_CATEGORY_IMP
                        return Current.AR_CATEGORY_IMP == null;
                    case 196: // AR_SUBCATEGORY_IMP
                        return Current.AR_SUBCATEGORY_IMP == null;
                    case 197: // AR_TAX_CATEGORY
                        return Current.AR_TAX_CATEGORY == null;
                    case 198: // AR_RELEASE_TYPE
                        return Current.AR_RELEASE_TYPE == null;
                    case 199: // AR_AOB_COST
                        return Current.AR_AOB_COST == null;
                    case 200: // AR_OB_QTY
                        return Current.AR_OB_QTY == null;
                    case 201: // AR_ORIG_INVOICE_NO
                        return Current.AR_ORIG_INVOICE_NO == null;
                    case 202: // AR_LAST_INVOICE_NO
                        return Current.AR_LAST_INVOICE_NO == null;
                    case 203: // AR_WARRANTY
                        return Current.AR_WARRANTY == null;
                    case 204: // AR_WARRANTYEXP
                        return Current.AR_WARRANTYEXP == null;
                    case 205: // AR_SERIAL
                        return Current.AR_SERIAL == null;
                    case 206: // AR_LOCATION
                        return Current.AR_LOCATION == null;
                    case 207: // AR_LOCATION_IMP
                        return Current.AR_LOCATION_IMP == null;
                    case 208: // AR_DEPARTMENT
                        return Current.AR_DEPARTMENT == null;
                    case 209: // AR_DEPARTMENT_IMP
                        return Current.AR_DEPARTMENT_IMP == null;
                    case 210: // AR_CAMPUS
                        return Current.AR_CAMPUS == null;
                    case 211: // AR_CAMPUS_IMP
                        return Current.AR_CAMPUS_IMP == null;
                    case 212: // AR_BRANCH
                        return Current.AR_BRANCH == null;
                    case 213: // AR_LEASE_START_DATE
                        return Current.AR_LEASE_START_DATE == null;
                    case 214: // AR_LEASE_END_DATE
                        return Current.AR_LEASE_END_DATE == null;
                    case 215: // AR_LAST_ST_DATE
                        return Current.AR_LAST_ST_DATE == null;
                    case 216: // AR_LAST_ADDN_DATE
                        return Current.AR_LAST_ADDN_DATE == null;
                    case 217: // AR_EXPECTED_LIFE
                        return Current.AR_EXPECTED_LIFE == null;
                    case 218: // AR_LAST_SVC_DATE
                        return Current.AR_LAST_SVC_DATE == null;
                    case 219: // AR_NEXT_SVC_DATE
                        return Current.AR_NEXT_SVC_DATE == null;
                    case 220: // AR_LAST_SVC_DETAILS
                        return Current.AR_LAST_SVC_DETAILS == null;
                    case 221: // AR_OWNER
                        return Current.AR_OWNER == null;
                    case 222: // AR_CLEANING
                        return Current.AR_CLEANING == null;
                    case 223: // AR_HAZARD
                        return Current.AR_HAZARD == null;
                    case 224: // AR_SITE_REFERENCE
                        return Current.AR_SITE_REFERENCE == null;
                    case 225: // AR_EXTRA_DETAILS
                        return Current.AR_EXTRA_DETAILS == null;
                    case 226: // AR_PURDATE
                        return Current.AR_PURDATE == null;
                    case 227: // AR_PURDATE_IMP
                        return Current.AR_PURDATE_IMP == null;
                    case 228: // AR_ORIG_SUPPLIER
                        return Current.AR_ORIG_SUPPLIER == null;
                    case 229: // AR_ORIG_COST
                        return Current.AR_ORIG_COST == null;
                    case 230: // AR_ASSET_PIC
                        return Current.AR_ASSET_PIC == null;
                    case 231: // FDT_COMMENT
                        return Current.FDT_COMMENT == null;
                    case 232: // FDT_PROCESS_FLAG
                        return Current.FDT_PROCESS_FLAG == null;
                    case 233: // FDT_DATE_EXP
                        return Current.FDT_DATE_EXP == null;
                    case 234: // FDT_TIME_EXP
                        return Current.FDT_TIME_EXP == null;
                    case 235: // FDT_DATE_IMP
                        return Current.FDT_DATE_IMP == null;
                    case 236: // FDT_TIME_IMP
                        return Current.FDT_TIME_IMP == null;
                    case 237: // LW_DATE
                        return Current.LW_DATE == null;
                    case 238: // LW_TIME
                        return Current.LW_TIME == null;
                    case 239: // LW_USER
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
                    case 1: // SOURCE
                        return "SOURCE";
                    case 2: // DR_DRKEY
                        return "DR_DRKEY";
                    case 3: // DR_DRKEY_IMP
                        return "DR_DRKEY_IMP";
                    case 4: // DR_TITLE
                        return "DR_TITLE";
                    case 5: // DR_CONTACT
                        return "DR_CONTACT";
                    case 6: // DR_BUSNAME
                        return "DR_BUSNAME";
                    case 7: // DR_BUSADD01
                        return "DR_BUSADD01";
                    case 8: // DR_BUSADD02
                        return "DR_BUSADD02";
                    case 9: // DR_BUSSTATE
                        return "DR_BUSSTATE";
                    case 10: // DR_POSTCODE
                        return "DR_POSTCODE";
                    case 11: // DR_TELEPHONE
                        return "DR_TELEPHONE";
                    case 12: // DR_FAX
                        return "DR_FAX";
                    case 13: // DR_MAILNAME
                        return "DR_MAILNAME";
                    case 14: // DR_MAILADD01
                        return "DR_MAILADD01";
                    case 15: // DR_MAILADD02
                        return "DR_MAILADD02";
                    case 16: // DR_MAILSTATE
                        return "DR_MAILSTATE";
                    case 17: // DR_MAILPOST
                        return "DR_MAILPOST";
                    case 18: // DR_DRTYPE
                        return "DR_DRTYPE";
                    case 19: // DR_CHARGES_YTD
                        return "DR_CHARGES_YTD";
                    case 20: // DR_NOTES
                        return "DR_NOTES";
                    case 21: // DR_MEMO_FLAG
                        return "DR_MEMO_FLAG";
                    case 22: // DR_REMARK
                        return "DR_REMARK";
                    case 23: // DR_BILLING_EMAIL
                        return "DR_BILLING_EMAIL";
                    case 24: // DR_BALANCE
                        return "DR_BALANCE";
                    case 25: // CR_CRKEY
                        return "CR_CRKEY";
                    case 26: // CR_CRKEY_IMP
                        return "CR_CRKEY_IMP";
                    case 27: // CR_TITLE
                        return "CR_TITLE";
                    case 28: // CR_CUR_BAL
                        return "CR_CUR_BAL";
                    case 29: // CR_CONTACT
                        return "CR_CONTACT";
                    case 30: // CR_ADDRESS01
                        return "CR_ADDRESS01";
                    case 31: // CR_ADDRESS02
                        return "CR_ADDRESS02";
                    case 32: // CR_ADDRESS03
                        return "CR_ADDRESS03";
                    case 33: // CR_STATE
                        return "CR_STATE";
                    case 34: // CR_POSTCODE
                        return "CR_POSTCODE";
                    case 35: // CR_TELEPHONE
                        return "CR_TELEPHONE";
                    case 36: // CR_FAX
                        return "CR_FAX";
                    case 37: // CR_EMAIL
                        return "CR_EMAIL";
                    case 38: // CR_EMAIL_FOR_PAYMENTS
                        return "CR_EMAIL_FOR_PAYMENTS";
                    case 39: // CR_MOBILE
                        return "CR_MOBILE";
                    case 40: // CR_PRMS_FLAG
                        return "CR_PRMS_FLAG";
                    case 41: // CR_ABN
                        return "CR_ABN";
                    case 42: // CR_PAYG_RATE
                        return "CR_PAYG_RATE";
                    case 43: // CR_CRLIMIT
                        return "CR_CRLIMIT";
                    case 44: // CR_TERMS
                        return "CR_TERMS";
                    case 45: // CR_BSB
                        return "CR_BSB";
                    case 46: // CR_ACCOUNT_NO
                        return "CR_ACCOUNT_NO";
                    case 47: // CR_ACCOUNT_NAME
                        return "CR_ACCOUNT_NAME";
                    case 48: // CR_LODGE_REF
                        return "CR_LODGE_REF";
                    case 49: // CR_SURNAME
                        return "CR_SURNAME";
                    case 50: // CR_FIRST_NAME
                        return "CR_FIRST_NAME";
                    case 51: // CR_SECOND_NAME
                        return "CR_SECOND_NAME";
                    case 52: // CR_PAYG_BIRTHDATE
                        return "CR_PAYG_BIRTHDATE";
                    case 53: // CR_PAYG_STARTDATE
                        return "CR_PAYG_STARTDATE";
                    case 54: // CR_PAYG_TERMDATE
                        return "CR_PAYG_TERMDATE";
                    case 55: // CR_PAYG_ADDRESS01
                        return "CR_PAYG_ADDRESS01";
                    case 56: // CR_PAYG_ADDRESS02
                        return "CR_PAYG_ADDRESS02";
                    case 57: // CR_PAYG_SUBURB
                        return "CR_PAYG_SUBURB";
                    case 58: // CR_PAYG_STATE
                        return "CR_PAYG_STATE";
                    case 59: // CR_PAYG_POST
                        return "CR_PAYG_POST";
                    case 60: // CR_PAYG_COUNTRY
                        return "CR_PAYG_COUNTRY";
                    case 61: // CR_PPDKEY
                        return "CR_PPDKEY";
                    case 62: // CR_BILLER_CODE
                        return "CR_BILLER_CODE";
                    case 63: // CR_BPAY_REFERENCE
                        return "CR_BPAY_REFERENCE";
                    case 64: // CR_LASTPAYDATE
                        return "CR_LASTPAYDATE";
                    case 65: // PE_PEKEY
                        return "PE_PEKEY";
                    case 66: // PE_PEKEY_IMP
                        return "PE_PEKEY_IMP";
                    case 67: // PE_SURNAME
                        return "PE_SURNAME";
                    case 68: // PE_FIRST_NAME
                        return "PE_FIRST_NAME";
                    case 69: // PE_SECOND_NAME
                        return "PE_SECOND_NAME";
                    case 70: // PE_PREF_NAME
                        return "PE_PREF_NAME";
                    case 71: // PE_PREVIOUS_NAME
                        return "PE_PREVIOUS_NAME";
                    case 72: // PE_BIRTHDATE
                        return "PE_BIRTHDATE";
                    case 73: // PE_GENDER
                        return "PE_GENDER";
                    case 74: // PE_HOMEADD01
                        return "PE_HOMEADD01";
                    case 75: // PE_HOMEADD02
                        return "PE_HOMEADD02";
                    case 76: // PE_HOMESUBURB
                        return "PE_HOMESUBURB";
                    case 77: // PE_HOMESTATE
                        return "PE_HOMESTATE";
                    case 78: // PE_HOMEPOST
                        return "PE_HOMEPOST";
                    case 79: // PE_COUNTRY
                        return "PE_COUNTRY";
                    case 80: // PE_HOMEPHONE
                        return "PE_HOMEPHONE";
                    case 81: // PE_BUS_PHONE
                        return "PE_BUS_PHONE";
                    case 82: // PE_PHONE_EXT
                        return "PE_PHONE_EXT";
                    case 83: // PE_FAX
                        return "PE_FAX";
                    case 84: // PE_MOBILE
                        return "PE_MOBILE";
                    case 85: // PE_EMAIL
                        return "PE_EMAIL";
                    case 86: // PE_DRIVERS_LIC_NO
                        return "PE_DRIVERS_LIC_NO";
                    case 87: // PE_SALREVDATE
                        return "PE_SALREVDATE";
                    case 88: // PE_SUSPEND_DATE
                        return "PE_SUSPEND_DATE";
                    case 89: // PE_PENUMBER
                        return "PE_PENUMBER";
                    case 90: // PE_TAXFILENUM
                        return "PE_TAXFILENUM";
                    case 91: // PE_TAXCODE
                        return "PE_TAXCODE";
                    case 92: // PE_NO_DEPEND
                        return "PE_NO_DEPEND";
                    case 93: // PE_DEP_REBATE
                        return "PE_DEP_REBATE";
                    case 94: // PE_ZONE_CODE
                        return "PE_ZONE_CODE";
                    case 95: // PE_ZONE_ALLOW
                        return "PE_ZONE_ALLOW";
                    case 96: // PE_ALLOWANCES
                        return "PE_ALLOWANCES";
                    case 97: // PE_PAYCODE
                        return "PE_PAYCODE";
                    case 98: // PE_DEPARTMENT
                        return "PE_DEPARTMENT";
                    case 99: // PE_EMPLOY_TYPE
                        return "PE_EMPLOY_TYPE";
                    case 100: // PE_NORMAL_HOURS
                        return "PE_NORMAL_HOURS";
                    case 101: // PE_FTE_VALUE
                        return "PE_FTE_VALUE";
                    case 102: // PE_ANNUAL_SALARY
                        return "PE_ANNUAL_SALARY";
                    case 103: // PE_STD_HOURS
                        return "PE_STD_HOURS";
                    case 104: // PE_UNION_NAME
                        return "PE_UNION_NAME";
                    case 105: // PE_MEDICARE_Q09A
                        return "PE_MEDICARE_Q09A";
                    case 106: // PE_MEDICARE_Q10A
                        return "PE_MEDICARE_Q10A";
                    case 107: // PE_MEDICARE_Q11A
                        return "PE_MEDICARE_Q11A";
                    case 108: // PE_MEDICARE_Q12A
                        return "PE_MEDICARE_Q12A";
                    case 109: // PE_LEAVE_GROUP
                        return "PE_LEAVE_GROUP";
                    case 110: // PE_ESUPER_IGNORE_THRESHOLD
                        return "PE_ESUPER_IGNORE_THRESHOLD";
                    case 111: // PE_ESUPER_FUND
                        return "PE_ESUPER_FUND";
                    case 112: // PE_ESUPER_MEMBER
                        return "PE_ESUPER_MEMBER";
                    case 113: // PE_ESUPER_PERCENT
                        return "PE_ESUPER_PERCENT";
                    case 114: // PE_LASTPAYDATE
                        return "PE_LASTPAYDATE";
                    case 115: // PE_PEPS_TRCENTRE
                        return "PE_PEPS_TRCENTRE";
                    case 116: // PE_START_DATE_IMP
                        return "PE_START_DATE_IMP";
                    case 117: // PEPS_CODE
                        return "PEPS_CODE";
                    case 118: // PEPS_PAYITEM
                        return "PEPS_PAYITEM";
                    case 119: // PEPS_TRCOST
                        return "PEPS_TRCOST";
                    case 120: // PEPS_TRQTY
                        return "PEPS_TRQTY";
                    case 121: // PEPS_TRAMT
                        return "PEPS_TRAMT";
                    case 122: // PEPS_TRDET
                        return "PEPS_TRDET";
                    case 123: // PEPS_FLAG
                        return "PEPS_FLAG";
                    case 124: // PEPS_PAY_STEP
                        return "PEPS_PAY_STEP";
                    case 125: // PEPS_SUPER_FUND
                        return "PEPS_SUPER_FUND";
                    case 126: // PEPS_SUPER_MEMBER
                        return "PEPS_SUPER_MEMBER";
                    case 127: // PEPS_SUPER_PERCENT
                        return "PEPS_SUPER_PERCENT";
                    case 128: // PEPS_TRCENTRE
                        return "PEPS_TRCENTRE";
                    case 129: // PEPM_CODE
                        return "PEPM_CODE";
                    case 130: // PEPM_NAME
                        return "PEPM_NAME";
                    case 131: // PEPM_CHQ_NO
                        return "PEPM_CHQ_NO";
                    case 132: // PEPM_DAMOUNT
                        return "PEPM_DAMOUNT";
                    case 133: // PEPM_BANK
                        return "PEPM_BANK";
                    case 134: // PEPM_BSB
                        return "PEPM_BSB";
                    case 135: // PEPM_ACCOUNT_NO
                        return "PEPM_ACCOUNT_NO";
                    case 136: // PEPM_AMOUNT
                        return "PEPM_AMOUNT";
                    case 137: // PEPM_FLAG
                        return "PEPM_FLAG";
                    case 138: // PEPM_PAYMODE
                        return "PEPM_PAYMODE";
                    case 139: // PEPY_CODE
                        return "PEPY_CODE";
                    case 140: // PEPY_TRANSDATE
                        return "PEPY_TRANSDATE";
                    case 141: // PEPY_STAFF
                        return "PEPY_STAFF";
                    case 142: // PEPY_PURPOSE
                        return "PEPY_PURPOSE";
                    case 143: // PEPY_NOTES
                        return "PEPY_NOTES";
                    case 144: // KPN_KPNKEY
                        return "KPN_KPNKEY";
                    case 145: // KPN_KPNKEY_IMP
                        return "KPN_KPNKEY_IMP";
                    case 146: // KPN_DESCRIPTION
                        return "KPN_DESCRIPTION";
                    case 147: // KPC_KPCKEY
                        return "KPC_KPCKEY";
                    case 148: // KPC_SURNAME
                        return "KPC_SURNAME";
                    case 149: // KPC_FIRST_NAME
                        return "KPC_FIRST_NAME";
                    case 150: // KPC_SECOND_NAME
                        return "KPC_SECOND_NAME";
                    case 151: // KPC_GENDER
                        return "KPC_GENDER";
                    case 152: // KPC_ADDRESS01
                        return "KPC_ADDRESS01";
                    case 153: // KPC_ADDRESS02
                        return "KPC_ADDRESS02";
                    case 154: // KPC_ADDRESS03
                        return "KPC_ADDRESS03";
                    case 155: // KPC_STATE
                        return "KPC_STATE";
                    case 156: // KPC_POST
                        return "KPC_POST";
                    case 157: // KPC_BUS_PHONE
                        return "KPC_BUS_PHONE";
                    case 158: // KPC_HOME_PHONE
                        return "KPC_HOME_PHONE";
                    case 159: // KPC_MOBILE
                        return "KPC_MOBILE";
                    case 160: // KPC_EMAIL
                        return "KPC_EMAIL";
                    case 161: // KPCL_KPCLKEY
                        return "KPCL_KPCLKEY";
                    case 162: // KPCL_LINK
                        return "KPCL_LINK";
                    case 163: // KPCL_SOURCE
                        return "KPCL_SOURCE";
                    case 164: // KPCL_CONTACT
                        return "KPCL_CONTACT";
                    case 165: // KPCL_CONTACT_TYPE
                        return "KPCL_CONTACT_TYPE";
                    case 166: // KPCL_CONTACT_PREFERENCE
                        return "KPCL_CONTACT_PREFERENCE";
                    case 167: // KPCR_KPCRKEY
                        return "KPCR_KPCRKEY";
                    case 168: // KPCR_KPCRKEY_IMP
                        return "KPCR_KPCRKEY_IMP";
                    case 169: // KPCR_DESCRIPTION
                        return "KPCR_DESCRIPTION";
                    case 170: // PF_PFKEY
                        return "PF_PFKEY";
                    case 171: // PF_PFKEY_IMP
                        return "PF_PFKEY_IMP";
                    case 172: // PF_DESCRIPTION
                        return "PF_DESCRIPTION";
                    case 173: // PI_PIKEY
                        return "PI_PIKEY";
                    case 174: // PI_PIKEY_IMP
                        return "PI_PIKEY_IMP";
                    case 175: // PI_PAYCODE
                        return "PI_PAYCODE";
                    case 176: // PI_DESCRIPTION
                        return "PI_DESCRIPTION";
                    case 177: // PI_TRANSTYPE
                        return "PI_TRANSTYPE";
                    case 178: // PI_TAXABLE
                        return "PI_TAXABLE";
                    case 179: // PI_UNIT
                        return "PI_UNIT";
                    case 180: // PI_CATEGORY
                        return "PI_CATEGORY";
                    case 181: // PI_PAYG_BOX
                        return "PI_PAYG_BOX";
                    case 182: // PI_TAXRATE
                        return "PI_TAXRATE";
                    case 183: // PI_AUTOCALC
                        return "PI_AUTOCALC";
                    case 184: // PI_SUPER_LEVY
                        return "PI_SUPER_LEVY";
                    case 185: // PI_PERS_SUPER
                        return "PI_PERS_SUPER";
                    case 186: // PI_PERS_SUPER_RATE
                        return "PI_PERS_SUPER_RATE";
                    case 187: // PI_INITIATIVE
                        return "PI_INITIATIVE";
                    case 188: // AR_ARKEY
                        return "AR_ARKEY";
                    case 189: // AR_ARKEY_IMP
                        return "AR_ARKEY_IMP";
                    case 190: // AR_TITLE
                        return "AR_TITLE";
                    case 191: // AR_DESCRIPTION01
                        return "AR_DESCRIPTION01";
                    case 192: // AR_DESCRIPTION02
                        return "AR_DESCRIPTION02";
                    case 193: // AR_ASSET_TYPE
                        return "AR_ASSET_TYPE";
                    case 194: // AR_CATEGORY
                        return "AR_CATEGORY";
                    case 195: // AR_CATEGORY_IMP
                        return "AR_CATEGORY_IMP";
                    case 196: // AR_SUBCATEGORY_IMP
                        return "AR_SUBCATEGORY_IMP";
                    case 197: // AR_TAX_CATEGORY
                        return "AR_TAX_CATEGORY";
                    case 198: // AR_RELEASE_TYPE
                        return "AR_RELEASE_TYPE";
                    case 199: // AR_AOB_COST
                        return "AR_AOB_COST";
                    case 200: // AR_OB_QTY
                        return "AR_OB_QTY";
                    case 201: // AR_ORIG_INVOICE_NO
                        return "AR_ORIG_INVOICE_NO";
                    case 202: // AR_LAST_INVOICE_NO
                        return "AR_LAST_INVOICE_NO";
                    case 203: // AR_WARRANTY
                        return "AR_WARRANTY";
                    case 204: // AR_WARRANTYEXP
                        return "AR_WARRANTYEXP";
                    case 205: // AR_SERIAL
                        return "AR_SERIAL";
                    case 206: // AR_LOCATION
                        return "AR_LOCATION";
                    case 207: // AR_LOCATION_IMP
                        return "AR_LOCATION_IMP";
                    case 208: // AR_DEPARTMENT
                        return "AR_DEPARTMENT";
                    case 209: // AR_DEPARTMENT_IMP
                        return "AR_DEPARTMENT_IMP";
                    case 210: // AR_CAMPUS
                        return "AR_CAMPUS";
                    case 211: // AR_CAMPUS_IMP
                        return "AR_CAMPUS_IMP";
                    case 212: // AR_BRANCH
                        return "AR_BRANCH";
                    case 213: // AR_LEASE_START_DATE
                        return "AR_LEASE_START_DATE";
                    case 214: // AR_LEASE_END_DATE
                        return "AR_LEASE_END_DATE";
                    case 215: // AR_LAST_ST_DATE
                        return "AR_LAST_ST_DATE";
                    case 216: // AR_LAST_ADDN_DATE
                        return "AR_LAST_ADDN_DATE";
                    case 217: // AR_EXPECTED_LIFE
                        return "AR_EXPECTED_LIFE";
                    case 218: // AR_LAST_SVC_DATE
                        return "AR_LAST_SVC_DATE";
                    case 219: // AR_NEXT_SVC_DATE
                        return "AR_NEXT_SVC_DATE";
                    case 220: // AR_LAST_SVC_DETAILS
                        return "AR_LAST_SVC_DETAILS";
                    case 221: // AR_OWNER
                        return "AR_OWNER";
                    case 222: // AR_CLEANING
                        return "AR_CLEANING";
                    case 223: // AR_HAZARD
                        return "AR_HAZARD";
                    case 224: // AR_SITE_REFERENCE
                        return "AR_SITE_REFERENCE";
                    case 225: // AR_EXTRA_DETAILS
                        return "AR_EXTRA_DETAILS";
                    case 226: // AR_PURDATE
                        return "AR_PURDATE";
                    case 227: // AR_PURDATE_IMP
                        return "AR_PURDATE_IMP";
                    case 228: // AR_ORIG_SUPPLIER
                        return "AR_ORIG_SUPPLIER";
                    case 229: // AR_ORIG_COST
                        return "AR_ORIG_COST";
                    case 230: // AR_ASSET_PIC
                        return "AR_ASSET_PIC";
                    case 231: // FDT_COMMENT
                        return "FDT_COMMENT";
                    case 232: // FDT_PROCESS_FLAG
                        return "FDT_PROCESS_FLAG";
                    case 233: // FDT_DATE_EXP
                        return "FDT_DATE_EXP";
                    case 234: // FDT_TIME_EXP
                        return "FDT_TIME_EXP";
                    case 235: // FDT_DATE_IMP
                        return "FDT_DATE_IMP";
                    case 236: // FDT_TIME_IMP
                        return "FDT_TIME_IMP";
                    case 237: // LW_DATE
                        return "LW_DATE";
                    case 238: // LW_TIME
                        return "LW_TIME";
                    case 239: // LW_USER
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
                    case "SOURCE":
                        return 1;
                    case "DR_DRKEY":
                        return 2;
                    case "DR_DRKEY_IMP":
                        return 3;
                    case "DR_TITLE":
                        return 4;
                    case "DR_CONTACT":
                        return 5;
                    case "DR_BUSNAME":
                        return 6;
                    case "DR_BUSADD01":
                        return 7;
                    case "DR_BUSADD02":
                        return 8;
                    case "DR_BUSSTATE":
                        return 9;
                    case "DR_POSTCODE":
                        return 10;
                    case "DR_TELEPHONE":
                        return 11;
                    case "DR_FAX":
                        return 12;
                    case "DR_MAILNAME":
                        return 13;
                    case "DR_MAILADD01":
                        return 14;
                    case "DR_MAILADD02":
                        return 15;
                    case "DR_MAILSTATE":
                        return 16;
                    case "DR_MAILPOST":
                        return 17;
                    case "DR_DRTYPE":
                        return 18;
                    case "DR_CHARGES_YTD":
                        return 19;
                    case "DR_NOTES":
                        return 20;
                    case "DR_MEMO_FLAG":
                        return 21;
                    case "DR_REMARK":
                        return 22;
                    case "DR_BILLING_EMAIL":
                        return 23;
                    case "DR_BALANCE":
                        return 24;
                    case "CR_CRKEY":
                        return 25;
                    case "CR_CRKEY_IMP":
                        return 26;
                    case "CR_TITLE":
                        return 27;
                    case "CR_CUR_BAL":
                        return 28;
                    case "CR_CONTACT":
                        return 29;
                    case "CR_ADDRESS01":
                        return 30;
                    case "CR_ADDRESS02":
                        return 31;
                    case "CR_ADDRESS03":
                        return 32;
                    case "CR_STATE":
                        return 33;
                    case "CR_POSTCODE":
                        return 34;
                    case "CR_TELEPHONE":
                        return 35;
                    case "CR_FAX":
                        return 36;
                    case "CR_EMAIL":
                        return 37;
                    case "CR_EMAIL_FOR_PAYMENTS":
                        return 38;
                    case "CR_MOBILE":
                        return 39;
                    case "CR_PRMS_FLAG":
                        return 40;
                    case "CR_ABN":
                        return 41;
                    case "CR_PAYG_RATE":
                        return 42;
                    case "CR_CRLIMIT":
                        return 43;
                    case "CR_TERMS":
                        return 44;
                    case "CR_BSB":
                        return 45;
                    case "CR_ACCOUNT_NO":
                        return 46;
                    case "CR_ACCOUNT_NAME":
                        return 47;
                    case "CR_LODGE_REF":
                        return 48;
                    case "CR_SURNAME":
                        return 49;
                    case "CR_FIRST_NAME":
                        return 50;
                    case "CR_SECOND_NAME":
                        return 51;
                    case "CR_PAYG_BIRTHDATE":
                        return 52;
                    case "CR_PAYG_STARTDATE":
                        return 53;
                    case "CR_PAYG_TERMDATE":
                        return 54;
                    case "CR_PAYG_ADDRESS01":
                        return 55;
                    case "CR_PAYG_ADDRESS02":
                        return 56;
                    case "CR_PAYG_SUBURB":
                        return 57;
                    case "CR_PAYG_STATE":
                        return 58;
                    case "CR_PAYG_POST":
                        return 59;
                    case "CR_PAYG_COUNTRY":
                        return 60;
                    case "CR_PPDKEY":
                        return 61;
                    case "CR_BILLER_CODE":
                        return 62;
                    case "CR_BPAY_REFERENCE":
                        return 63;
                    case "CR_LASTPAYDATE":
                        return 64;
                    case "PE_PEKEY":
                        return 65;
                    case "PE_PEKEY_IMP":
                        return 66;
                    case "PE_SURNAME":
                        return 67;
                    case "PE_FIRST_NAME":
                        return 68;
                    case "PE_SECOND_NAME":
                        return 69;
                    case "PE_PREF_NAME":
                        return 70;
                    case "PE_PREVIOUS_NAME":
                        return 71;
                    case "PE_BIRTHDATE":
                        return 72;
                    case "PE_GENDER":
                        return 73;
                    case "PE_HOMEADD01":
                        return 74;
                    case "PE_HOMEADD02":
                        return 75;
                    case "PE_HOMESUBURB":
                        return 76;
                    case "PE_HOMESTATE":
                        return 77;
                    case "PE_HOMEPOST":
                        return 78;
                    case "PE_COUNTRY":
                        return 79;
                    case "PE_HOMEPHONE":
                        return 80;
                    case "PE_BUS_PHONE":
                        return 81;
                    case "PE_PHONE_EXT":
                        return 82;
                    case "PE_FAX":
                        return 83;
                    case "PE_MOBILE":
                        return 84;
                    case "PE_EMAIL":
                        return 85;
                    case "PE_DRIVERS_LIC_NO":
                        return 86;
                    case "PE_SALREVDATE":
                        return 87;
                    case "PE_SUSPEND_DATE":
                        return 88;
                    case "PE_PENUMBER":
                        return 89;
                    case "PE_TAXFILENUM":
                        return 90;
                    case "PE_TAXCODE":
                        return 91;
                    case "PE_NO_DEPEND":
                        return 92;
                    case "PE_DEP_REBATE":
                        return 93;
                    case "PE_ZONE_CODE":
                        return 94;
                    case "PE_ZONE_ALLOW":
                        return 95;
                    case "PE_ALLOWANCES":
                        return 96;
                    case "PE_PAYCODE":
                        return 97;
                    case "PE_DEPARTMENT":
                        return 98;
                    case "PE_EMPLOY_TYPE":
                        return 99;
                    case "PE_NORMAL_HOURS":
                        return 100;
                    case "PE_FTE_VALUE":
                        return 101;
                    case "PE_ANNUAL_SALARY":
                        return 102;
                    case "PE_STD_HOURS":
                        return 103;
                    case "PE_UNION_NAME":
                        return 104;
                    case "PE_MEDICARE_Q09A":
                        return 105;
                    case "PE_MEDICARE_Q10A":
                        return 106;
                    case "PE_MEDICARE_Q11A":
                        return 107;
                    case "PE_MEDICARE_Q12A":
                        return 108;
                    case "PE_LEAVE_GROUP":
                        return 109;
                    case "PE_ESUPER_IGNORE_THRESHOLD":
                        return 110;
                    case "PE_ESUPER_FUND":
                        return 111;
                    case "PE_ESUPER_MEMBER":
                        return 112;
                    case "PE_ESUPER_PERCENT":
                        return 113;
                    case "PE_LASTPAYDATE":
                        return 114;
                    case "PE_PEPS_TRCENTRE":
                        return 115;
                    case "PE_START_DATE_IMP":
                        return 116;
                    case "PEPS_CODE":
                        return 117;
                    case "PEPS_PAYITEM":
                        return 118;
                    case "PEPS_TRCOST":
                        return 119;
                    case "PEPS_TRQTY":
                        return 120;
                    case "PEPS_TRAMT":
                        return 121;
                    case "PEPS_TRDET":
                        return 122;
                    case "PEPS_FLAG":
                        return 123;
                    case "PEPS_PAY_STEP":
                        return 124;
                    case "PEPS_SUPER_FUND":
                        return 125;
                    case "PEPS_SUPER_MEMBER":
                        return 126;
                    case "PEPS_SUPER_PERCENT":
                        return 127;
                    case "PEPS_TRCENTRE":
                        return 128;
                    case "PEPM_CODE":
                        return 129;
                    case "PEPM_NAME":
                        return 130;
                    case "PEPM_CHQ_NO":
                        return 131;
                    case "PEPM_DAMOUNT":
                        return 132;
                    case "PEPM_BANK":
                        return 133;
                    case "PEPM_BSB":
                        return 134;
                    case "PEPM_ACCOUNT_NO":
                        return 135;
                    case "PEPM_AMOUNT":
                        return 136;
                    case "PEPM_FLAG":
                        return 137;
                    case "PEPM_PAYMODE":
                        return 138;
                    case "PEPY_CODE":
                        return 139;
                    case "PEPY_TRANSDATE":
                        return 140;
                    case "PEPY_STAFF":
                        return 141;
                    case "PEPY_PURPOSE":
                        return 142;
                    case "PEPY_NOTES":
                        return 143;
                    case "KPN_KPNKEY":
                        return 144;
                    case "KPN_KPNKEY_IMP":
                        return 145;
                    case "KPN_DESCRIPTION":
                        return 146;
                    case "KPC_KPCKEY":
                        return 147;
                    case "KPC_SURNAME":
                        return 148;
                    case "KPC_FIRST_NAME":
                        return 149;
                    case "KPC_SECOND_NAME":
                        return 150;
                    case "KPC_GENDER":
                        return 151;
                    case "KPC_ADDRESS01":
                        return 152;
                    case "KPC_ADDRESS02":
                        return 153;
                    case "KPC_ADDRESS03":
                        return 154;
                    case "KPC_STATE":
                        return 155;
                    case "KPC_POST":
                        return 156;
                    case "KPC_BUS_PHONE":
                        return 157;
                    case "KPC_HOME_PHONE":
                        return 158;
                    case "KPC_MOBILE":
                        return 159;
                    case "KPC_EMAIL":
                        return 160;
                    case "KPCL_KPCLKEY":
                        return 161;
                    case "KPCL_LINK":
                        return 162;
                    case "KPCL_SOURCE":
                        return 163;
                    case "KPCL_CONTACT":
                        return 164;
                    case "KPCL_CONTACT_TYPE":
                        return 165;
                    case "KPCL_CONTACT_PREFERENCE":
                        return 166;
                    case "KPCR_KPCRKEY":
                        return 167;
                    case "KPCR_KPCRKEY_IMP":
                        return 168;
                    case "KPCR_DESCRIPTION":
                        return 169;
                    case "PF_PFKEY":
                        return 170;
                    case "PF_PFKEY_IMP":
                        return 171;
                    case "PF_DESCRIPTION":
                        return 172;
                    case "PI_PIKEY":
                        return 173;
                    case "PI_PIKEY_IMP":
                        return 174;
                    case "PI_PAYCODE":
                        return 175;
                    case "PI_DESCRIPTION":
                        return 176;
                    case "PI_TRANSTYPE":
                        return 177;
                    case "PI_TAXABLE":
                        return 178;
                    case "PI_UNIT":
                        return 179;
                    case "PI_CATEGORY":
                        return 180;
                    case "PI_PAYG_BOX":
                        return 181;
                    case "PI_TAXRATE":
                        return 182;
                    case "PI_AUTOCALC":
                        return 183;
                    case "PI_SUPER_LEVY":
                        return 184;
                    case "PI_PERS_SUPER":
                        return 185;
                    case "PI_PERS_SUPER_RATE":
                        return 186;
                    case "PI_INITIATIVE":
                        return 187;
                    case "AR_ARKEY":
                        return 188;
                    case "AR_ARKEY_IMP":
                        return 189;
                    case "AR_TITLE":
                        return 190;
                    case "AR_DESCRIPTION01":
                        return 191;
                    case "AR_DESCRIPTION02":
                        return 192;
                    case "AR_ASSET_TYPE":
                        return 193;
                    case "AR_CATEGORY":
                        return 194;
                    case "AR_CATEGORY_IMP":
                        return 195;
                    case "AR_SUBCATEGORY_IMP":
                        return 196;
                    case "AR_TAX_CATEGORY":
                        return 197;
                    case "AR_RELEASE_TYPE":
                        return 198;
                    case "AR_AOB_COST":
                        return 199;
                    case "AR_OB_QTY":
                        return 200;
                    case "AR_ORIG_INVOICE_NO":
                        return 201;
                    case "AR_LAST_INVOICE_NO":
                        return 202;
                    case "AR_WARRANTY":
                        return 203;
                    case "AR_WARRANTYEXP":
                        return 204;
                    case "AR_SERIAL":
                        return 205;
                    case "AR_LOCATION":
                        return 206;
                    case "AR_LOCATION_IMP":
                        return 207;
                    case "AR_DEPARTMENT":
                        return 208;
                    case "AR_DEPARTMENT_IMP":
                        return 209;
                    case "AR_CAMPUS":
                        return 210;
                    case "AR_CAMPUS_IMP":
                        return 211;
                    case "AR_BRANCH":
                        return 212;
                    case "AR_LEASE_START_DATE":
                        return 213;
                    case "AR_LEASE_END_DATE":
                        return 214;
                    case "AR_LAST_ST_DATE":
                        return 215;
                    case "AR_LAST_ADDN_DATE":
                        return 216;
                    case "AR_EXPECTED_LIFE":
                        return 217;
                    case "AR_LAST_SVC_DATE":
                        return 218;
                    case "AR_NEXT_SVC_DATE":
                        return 219;
                    case "AR_LAST_SVC_DETAILS":
                        return 220;
                    case "AR_OWNER":
                        return 221;
                    case "AR_CLEANING":
                        return 222;
                    case "AR_HAZARD":
                        return 223;
                    case "AR_SITE_REFERENCE":
                        return 224;
                    case "AR_EXTRA_DETAILS":
                        return 225;
                    case "AR_PURDATE":
                        return 226;
                    case "AR_PURDATE_IMP":
                        return 227;
                    case "AR_ORIG_SUPPLIER":
                        return 228;
                    case "AR_ORIG_COST":
                        return 229;
                    case "AR_ASSET_PIC":
                        return 230;
                    case "FDT_COMMENT":
                        return 231;
                    case "FDT_PROCESS_FLAG":
                        return 232;
                    case "FDT_DATE_EXP":
                        return 233;
                    case "FDT_TIME_EXP":
                        return 234;
                    case "FDT_DATE_IMP":
                        return 235;
                    case "FDT_TIME_IMP":
                        return 236;
                    case "LW_DATE":
                        return 237;
                    case "LW_TIME":
                        return 238;
                    case "LW_USER":
                        return 239;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
