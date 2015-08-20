using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employees Data Set
    /// </summary>
    public sealed class PEDataSet : SetBase<PE>
    {
        private Lazy<Dictionary<string, PE>> PEKEYIndex;

        internal PEDataSet(EduHubContext Context)
            : base(Context)
        {
            PEKEYIndex = new Lazy<Dictionary<string, PE>>(() => this.ToDictionary(e => e.PEKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PE"; } }

        /// <summary>
        /// Find PE by PEKEY key field
        /// </summary>
        /// <param name="Key">PEKEY value used to find PE</param>
        /// <returns>Related PE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PEKEY value didn't match any PE entities</exception>
        public PE FindByPEKEY(string Key)
        {
            PE result;
            if (PEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PE by PEKEY key field
        /// </summary>
        /// <param name="Key">PEKEY value used to find PE</param>
        /// <param name="Value">Related PE entity</param>
        /// <returns>True if the PE entity is found</returns>
        public bool TryFindByPEKEY(string Key, out PE Value)
        {
            return PEKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PE by PEKEY key field
        /// </summary>
        /// <param name="Key">PEKEY value used to find PE</param>
        /// <returns>Related PE entity, or null if not found</returns>
        public PE TryFindByPEKEY(string Key)
        {
            PE result;
            if (PEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PE" /> fields for each CSV column header</returns>
        protected override Action<PE, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
                    case "PREVIOUS_NAME":
                        mapper[i] = (e, v) => e.PREVIOUS_NAME = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "HOMEADD01":
                        mapper[i] = (e, v) => e.HOMEADD01 = v;
                        break;
                    case "HOMEADD02":
                        mapper[i] = (e, v) => e.HOMEADD02 = v;
                        break;
                    case "HOMESUBURB":
                        mapper[i] = (e, v) => e.HOMESUBURB = v;
                        break;
                    case "HOMESTATE":
                        mapper[i] = (e, v) => e.HOMESTATE = v;
                        break;
                    case "HOMEPOST":
                        mapper[i] = (e, v) => e.HOMEPOST = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "HOMEPHONE":
                        mapper[i] = (e, v) => e.HOMEPHONE = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "PHONE_EXT":
                        mapper[i] = (e, v) => e.PHONE_EXT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
                        break;
                    case "DRIVERS_LIC_NO":
                        mapper[i] = (e, v) => e.DRIVERS_LIC_NO = v;
                        break;
                    case "OWN_VEHICLE":
                        mapper[i] = (e, v) => e.OWN_VEHICLE = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LEAVEKEY":
                        mapper[i] = (e, v) => e.LEAVEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PAYCODE":
                        mapper[i] = (e, v) => e.PAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TAXCODE":
                        mapper[i] = (e, v) => e.TAXCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEPARTMENT":
                        mapper[i] = (e, v) => e.DEPARTMENT = v;
                        break;
                    case "PENUMBER":
                        mapper[i] = (e, v) => e.PENUMBER = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TAXFILENUM":
                        mapper[i] = (e, v) => e.TAXFILENUM = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMPLOY_TYPE":
                        mapper[i] = (e, v) => e.EMPLOY_TYPE = v;
                        break;
                    case "NORMAL_HOURS":
                        mapper[i] = (e, v) => e.NORMAL_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "FTE_VALUE":
                        mapper[i] = (e, v) => e.FTE_VALUE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ANNUAL_SALARY":
                        mapper[i] = (e, v) => e.ANNUAL_SALARY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_HOURS":
                        mapper[i] = (e, v) => e.STD_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "UNION_NAME":
                        mapper[i] = (e, v) => e.UNION_NAME = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v;
                        break;
                    case "SIX_SUPER_FUND":
                        mapper[i] = (e, v) => e.SIX_SUPER_FUND = v;
                        break;
                    case "SIX_MEMBER_NO":
                        mapper[i] = (e, v) => e.SIX_MEMBER_NO = v;
                        break;
                    case "SUPER_LEVY":
                        mapper[i] = (e, v) => e.SUPER_LEVY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ZONE":
                        mapper[i] = (e, v) => e.ZONE = v;
                        break;
                    case "ZONE_CODE":
                        mapper[i] = (e, v) => e.ZONE_CODE = v;
                        break;
                    case "ZONE_ALLOW":
                        mapper[i] = (e, v) => e.ZONE_ALLOW = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NO_DEPEND":
                        mapper[i] = (e, v) => e.NO_DEPEND = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ALLOWANCES":
                        mapper[i] = (e, v) => e.ALLOWANCES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DEP_REBATE":
                        mapper[i] = (e, v) => e.DEP_REBATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MEDICARE":
                        mapper[i] = (e, v) => e.MEDICARE = v;
                        break;
                    case "MEDICARE_Q9NOTQ12z":
                        mapper[i] = (e, v) => e.MEDICARE_Q9NOTQ12z = v;
                        break;
                    case "MEDICARE_Q09A":
                        mapper[i] = (e, v) => e.MEDICARE_Q09A = v;
                        break;
                    case "MEDICARE_Q10A":
                        mapper[i] = (e, v) => e.MEDICARE_Q10A = v;
                        break;
                    case "MEDICARE_Q11A":
                        mapper[i] = (e, v) => e.MEDICARE_Q11A = v;
                        break;
                    case "MEDICARE_Q12A":
                        mapper[i] = (e, v) => e.MEDICARE_Q12A = v;
                        break;
                    case "STARTDATE":
                        mapper[i] = (e, v) => e.STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TERMDATE":
                        mapper[i] = (e, v) => e.TERMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SALREVDATE":
                        mapper[i] = (e, v) => e.SALREVDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUSPEND_DATE":
                        mapper[i] = (e, v) => e.SUSPEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAYPERD":
                        mapper[i] = (e, v) => e.LASTPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NEXTPAYPERD":
                        mapper[i] = (e, v) => e.NEXTPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAYRATE":
                        mapper[i] = (e, v) => e.LASTPAYRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LASTNORMITEM":
                        mapper[i] = (e, v) => e.LASTNORMITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LASTPAYGROSS":
                        mapper[i] = (e, v) => e.LASTPAYGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYNETT":
                        mapper[i] = (e, v) => e.LASTPAYNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYTAX":
                        mapper[i] = (e, v) => e.LASTPAYTAX = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS01":
                        mapper[i] = (e, v) => e.GROSS01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS02":
                        mapper[i] = (e, v) => e.GROSS02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS03":
                        mapper[i] = (e, v) => e.GROSS03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS04":
                        mapper[i] = (e, v) => e.GROSS04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS05":
                        mapper[i] = (e, v) => e.GROSS05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS06":
                        mapper[i] = (e, v) => e.GROSS06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS07":
                        mapper[i] = (e, v) => e.GROSS07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS08":
                        mapper[i] = (e, v) => e.GROSS08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS09":
                        mapper[i] = (e, v) => e.GROSS09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS10":
                        mapper[i] = (e, v) => e.GROSS10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS11":
                        mapper[i] = (e, v) => e.GROSS11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS12":
                        mapper[i] = (e, v) => e.GROSS12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT01":
                        mapper[i] = (e, v) => e.NETT01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT02":
                        mapper[i] = (e, v) => e.NETT02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT03":
                        mapper[i] = (e, v) => e.NETT03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT04":
                        mapper[i] = (e, v) => e.NETT04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT05":
                        mapper[i] = (e, v) => e.NETT05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT06":
                        mapper[i] = (e, v) => e.NETT06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT07":
                        mapper[i] = (e, v) => e.NETT07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT08":
                        mapper[i] = (e, v) => e.NETT08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT09":
                        mapper[i] = (e, v) => e.NETT09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT10":
                        mapper[i] = (e, v) => e.NETT10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT11":
                        mapper[i] = (e, v) => e.NETT11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT12":
                        mapper[i] = (e, v) => e.NETT12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX01":
                        mapper[i] = (e, v) => e.TAX01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX02":
                        mapper[i] = (e, v) => e.TAX02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX03":
                        mapper[i] = (e, v) => e.TAX03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX04":
                        mapper[i] = (e, v) => e.TAX04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX05":
                        mapper[i] = (e, v) => e.TAX05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX06":
                        mapper[i] = (e, v) => e.TAX06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX07":
                        mapper[i] = (e, v) => e.TAX07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX08":
                        mapper[i] = (e, v) => e.TAX08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX09":
                        mapper[i] = (e, v) => e.TAX09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX10":
                        mapper[i] = (e, v) => e.TAX10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX11":
                        mapper[i] = (e, v) => e.TAX11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX12":
                        mapper[i] = (e, v) => e.TAX12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYG_SUMMARY":
                        mapper[i] = (e, v) => e.PAYG_SUMMARY = v;
                        break;
                    case "YEAR_LEVEL":
                        mapper[i] = (e, v) => e.YEAR_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REPORTABLE_FB":
                        mapper[i] = (e, v) => e.REPORTABLE_FB = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMPLOYEE_PIC":
                        mapper[i] = (e, v) => e.EMPLOYEE_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "VIT_REGISTRATION":
                        mapper[i] = (e, v) => e.VIT_REGISTRATION = v;
                        break;
                    case "VIT_EXPIRY":
                        mapper[i] = (e, v) => e.VIT_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "WWCC_NUMBER":
                        mapper[i] = (e, v) => e.WWCC_NUMBER = v;
                        break;
                    case "WWCC_EXPIRY":
                        mapper[i] = (e, v) => e.WWCC_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "WWCC_TYPE":
                        mapper[i] = (e, v) => e.WWCC_TYPE = v;
                        break;
                    case "ESUPER_IGNORE_THRESHOLD":
                        mapper[i] = (e, v) => e.ESUPER_IGNORE_THRESHOLD = v;
                        break;
                    case "ESUPER_FUND01":
                        mapper[i] = (e, v) => e.ESUPER_FUND01 = v;
                        break;
                    case "ESUPER_FUND02":
                        mapper[i] = (e, v) => e.ESUPER_FUND02 = v;
                        break;
                    case "ESUPER_FUND03":
                        mapper[i] = (e, v) => e.ESUPER_FUND03 = v;
                        break;
                    case "ESUPER_FUND04":
                        mapper[i] = (e, v) => e.ESUPER_FUND04 = v;
                        break;
                    case "ESUPER_FUND05":
                        mapper[i] = (e, v) => e.ESUPER_FUND05 = v;
                        break;
                    case "ESUPER_MEMBER01":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER01 = v;
                        break;
                    case "ESUPER_MEMBER02":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER02 = v;
                        break;
                    case "ESUPER_MEMBER03":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER03 = v;
                        break;
                    case "ESUPER_MEMBER04":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER04 = v;
                        break;
                    case "ESUPER_MEMBER05":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER05 = v;
                        break;
                    case "ESUPER_PERCENT01":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT02":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT03":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT04":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT05":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_HOURS = v == null ? (double?)null : double.Parse(v);
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
