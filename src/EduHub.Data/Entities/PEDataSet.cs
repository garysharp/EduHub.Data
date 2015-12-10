using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEDataSet : DataSetBase<PE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PE"; } }

        internal PEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_DEPARTMENT = new Lazy<NullDictionary<string, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.DEPARTMENT));
            Index_HOMEKEY = new Lazy<NullDictionary<int?, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.HOMEKEY));
            Index_LEAVE_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_GROUP));
            Index_LEAVEKEY = new Lazy<NullDictionary<int?, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.LEAVEKEY));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_PAYCODE = new Lazy<NullDictionary<short?, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.PAYCODE));
            Index_PEKEY = new Lazy<Dictionary<string, PE>>(() => this.ToDictionary(i => i.PEKEY));
            Index_TAXCODE = new Lazy<NullDictionary<short?, IReadOnlyList<PE>>>(() => this.ToGroupedNullDictionary(i => i.TAXCODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PE" /> fields for each CSV column header</returns>
        protected override Action<PE, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        /// <summary>
        /// Merges <see cref="PE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PE" /> items to added or update the base <see cref="PE" /> items</param>
        /// <returns>A merged list of <see cref="PE" /> items</returns>
        protected override List<PE> ApplyDeltaItems(List<PE> Items, List<PE> DeltaItems)
        {
            Dictionary<string, int> Index_PEKEY = Items.ToIndexDictionary(i => i.PEKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PE deltaItem in DeltaItems)
            {
                int index;

                if (Index_PEKEY.TryGetValue(deltaItem.PEKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PEKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PE>>> Index_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<PE>>> Index_DEPARTMENT;
        private Lazy<NullDictionary<int?, IReadOnlyList<PE>>> Index_HOMEKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PE>>> Index_LEAVE_GROUP;
        private Lazy<NullDictionary<int?, IReadOnlyList<PE>>> Index_LEAVEKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<PE>>> Index_MAILKEY;
        private Lazy<NullDictionary<short?, IReadOnlyList<PE>>> Index_PAYCODE;
        private Lazy<Dictionary<string, PE>> Index_PEKEY;
        private Lazy<NullDictionary<short?, IReadOnlyList<PE>>> Index_TAXCODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PE by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find PE by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<PE> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PE by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PE> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PE by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByDEPARTMENT(string DEPARTMENT)
        {
            return Index_DEPARTMENT.Value[DEPARTMENT];
        }

        /// <summary>
        /// Attempt to find PE by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPARTMENT(string DEPARTMENT, out IReadOnlyList<PE> Value)
        {
            return Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out Value);
        }

        /// <summary>
        /// Attempt to find PE by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByDEPARTMENT(string DEPARTMENT)
        {
            IReadOnlyList<PE> value;
            if (Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PE by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByHOMEKEY(int? HOMEKEY)
        {
            return Index_HOMEKEY.Value[HOMEKEY];
        }

        /// <summary>
        /// Attempt to find PE by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOMEKEY(int? HOMEKEY, out IReadOnlyList<PE> Value)
        {
            return Index_HOMEKEY.Value.TryGetValue(HOMEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PE by HOMEKEY field
        /// </summary>
        /// <param name="HOMEKEY">HOMEKEY value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByHOMEKEY(int? HOMEKEY)
        {
            IReadOnlyList<PE> value;
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
        /// Find PE by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PE by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PE> Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PE by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PE> value;
            if (Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PE by LEAVEKEY field
        /// </summary>
        /// <param name="LEAVEKEY">LEAVEKEY value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByLEAVEKEY(int? LEAVEKEY)
        {
            return Index_LEAVEKEY.Value[LEAVEKEY];
        }

        /// <summary>
        /// Attempt to find PE by LEAVEKEY field
        /// </summary>
        /// <param name="LEAVEKEY">LEAVEKEY value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVEKEY(int? LEAVEKEY, out IReadOnlyList<PE> Value)
        {
            return Index_LEAVEKEY.Value.TryGetValue(LEAVEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PE by LEAVEKEY field
        /// </summary>
        /// <param name="LEAVEKEY">LEAVEKEY value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByLEAVEKEY(int? LEAVEKEY)
        {
            IReadOnlyList<PE> value;
            if (Index_LEAVEKEY.Value.TryGetValue(LEAVEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PE by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByMAILKEY(int? MAILKEY)
        {
            return Index_MAILKEY.Value[MAILKEY];
        }

        /// <summary>
        /// Attempt to find PE by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILKEY(int? MAILKEY, out IReadOnlyList<PE> Value)
        {
            return Index_MAILKEY.Value.TryGetValue(MAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PE by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByMAILKEY(int? MAILKEY)
        {
            IReadOnlyList<PE> value;
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
        /// Find PE by PAYCODE field
        /// </summary>
        /// <param name="PAYCODE">PAYCODE value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByPAYCODE(short? PAYCODE)
        {
            return Index_PAYCODE.Value[PAYCODE];
        }

        /// <summary>
        /// Attempt to find PE by PAYCODE field
        /// </summary>
        /// <param name="PAYCODE">PAYCODE value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYCODE(short? PAYCODE, out IReadOnlyList<PE> Value)
        {
            return Index_PAYCODE.Value.TryGetValue(PAYCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PE by PAYCODE field
        /// </summary>
        /// <param name="PAYCODE">PAYCODE value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByPAYCODE(short? PAYCODE)
        {
            IReadOnlyList<PE> value;
            if (Index_PAYCODE.Value.TryGetValue(PAYCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PE by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PE</param>
        /// <returns>Related PE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PE FindByPEKEY(string PEKEY)
        {
            return Index_PEKEY.Value[PEKEY];
        }

        /// <summary>
        /// Attempt to find PE by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PE</param>
        /// <param name="Value">Related PE entity</param>
        /// <returns>True if the related PE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY(string PEKEY, out PE Value)
        {
            return Index_PEKEY.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PE by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PE</param>
        /// <returns>Related PE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PE TryFindByPEKEY(string PEKEY)
        {
            PE value;
            if (Index_PEKEY.Value.TryGetValue(PEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PE by TAXCODE field
        /// </summary>
        /// <param name="TAXCODE">TAXCODE value used to find PE</param>
        /// <returns>List of related PE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> FindByTAXCODE(short? TAXCODE)
        {
            return Index_TAXCODE.Value[TAXCODE];
        }

        /// <summary>
        /// Attempt to find PE by TAXCODE field
        /// </summary>
        /// <param name="TAXCODE">TAXCODE value used to find PE</param>
        /// <param name="Value">List of related PE entities</param>
        /// <returns>True if the list of related PE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTAXCODE(short? TAXCODE, out IReadOnlyList<PE> Value)
        {
            return Index_TAXCODE.Value.TryGetValue(TAXCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PE by TAXCODE field
        /// </summary>
        /// <param name="TAXCODE">TAXCODE value used to find PE</param>
        /// <returns>List of related PE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PE> TryFindByTAXCODE(short? TAXCODE)
        {
            IReadOnlyList<PE> value;
            if (Index_TAXCODE.Value.TryGetValue(TAXCODE, out value))
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
        /// Returns SQL which checks for the existence of a PE table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PE](
        [PEKEY] varchar(10) NOT NULL,
        [TITLE] varchar(4) NULL,
        [SURNAME] varchar(20) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [SECOND_NAME] varchar(20) NULL,
        [PREF_NAME] varchar(15) NULL,
        [PREVIOUS_NAME] varchar(30) NULL,
        [BIRTHDATE] datetime NULL,
        [GENDER] varchar(1) NULL,
        [HOMEADD01] varchar(38) NULL,
        [HOMEADD02] varchar(38) NULL,
        [HOMESUBURB] varchar(20) NULL,
        [HOMESTATE] varchar(3) NULL,
        [HOMEPOST] varchar(4) NULL,
        [COUNTRY] varchar(6) NULL,
        [HOMEPHONE] varchar(15) NULL,
        [BUS_PHONE] varchar(15) NULL,
        [PHONE_EXT] varchar(5) NULL,
        [FAX] varchar(15) NULL,
        [MOBILE] varchar(15) NULL,
        [EMAIL] varchar(60) NULL,
        [DRIVERS_LIC_NO] varchar(15) NULL,
        [OWN_VEHICLE] varchar(1) NULL,
        [COMMENTS] text NULL,
        [HOMEKEY] int NULL,
        [MAILKEY] int NULL,
        [LEAVEKEY] int NULL,
        [PAYCODE] smallint NULL,
        [TAXCODE] smallint NULL,
        [DEPARTMENT] varchar(10) NULL,
        [PENUMBER] int NULL,
        [TAXFILENUM] int NULL,
        [EMPLOY_TYPE] varchar(1) NULL,
        [NORMAL_HOURS] float NULL,
        [FTE_VALUE] float NULL,
        [ANNUAL_SALARY] money NULL,
        [STD_HOURS] float NULL,
        [UNION_NAME] varchar(20) NULL,
        [LEAVE_GROUP] varchar(8) NULL,
        [PAY_TYPE] varchar(1) NULL,
        [HOURLY_RATE] varchar(4) NULL,
        [SIX_SUPER_FUND] varchar(20) NULL,
        [SIX_MEMBER_NO] varchar(10) NULL,
        [SUPER_LEVY] float NULL,
        [ZONE] varchar(1) NULL,
        [ZONE_CODE] varchar(1) NULL,
        [ZONE_ALLOW] money NULL,
        [NO_DEPEND] smallint NULL,
        [ALLOWANCES] money NULL,
        [DEP_REBATE] money NULL,
        [MEDICARE] varchar(1) NULL,
        [MEDICARE_Q9NOTQ12z] varchar(1) NULL,
        [MEDICARE_Q09A] varchar(1) NULL,
        [MEDICARE_Q10A] varchar(1) NULL,
        [MEDICARE_Q11A] varchar(1) NULL,
        [MEDICARE_Q12A] varchar(1) NULL,
        [STARTDATE] datetime NULL,
        [TERMDATE] datetime NULL,
        [SALREVDATE] datetime NULL,
        [SUSPEND_DATE] datetime NULL,
        [LASTPAYPERD] int NULL,
        [NEXTPAYPERD] int NULL,
        [LASTPAYDATE] datetime NULL,
        [LASTPAYRATE] float NULL,
        [LASTNORMITEM] smallint NULL,
        [LASTPAYGROSS] money NULL,
        [LASTPAYNETT] money NULL,
        [LASTPAYTAX] money NULL,
        [GROSS01] money NULL,
        [GROSS02] money NULL,
        [GROSS03] money NULL,
        [GROSS04] money NULL,
        [GROSS05] money NULL,
        [GROSS06] money NULL,
        [GROSS07] money NULL,
        [GROSS08] money NULL,
        [GROSS09] money NULL,
        [GROSS10] money NULL,
        [GROSS11] money NULL,
        [GROSS12] money NULL,
        [NETT01] money NULL,
        [NETT02] money NULL,
        [NETT03] money NULL,
        [NETT04] money NULL,
        [NETT05] money NULL,
        [NETT06] money NULL,
        [NETT07] money NULL,
        [NETT08] money NULL,
        [NETT09] money NULL,
        [NETT10] money NULL,
        [NETT11] money NULL,
        [NETT12] money NULL,
        [TAX01] money NULL,
        [TAX02] money NULL,
        [TAX03] money NULL,
        [TAX04] money NULL,
        [TAX05] money NULL,
        [TAX06] money NULL,
        [TAX07] money NULL,
        [TAX08] money NULL,
        [TAX09] money NULL,
        [TAX10] money NULL,
        [TAX11] money NULL,
        [TAX12] money NULL,
        [PAYG_SUMMARY] varchar(1) NULL,
        [YEAR_LEVEL] smallint NULL,
        [REPORTABLE_FB] money NULL,
        [EMPLOYEE_PIC] image NULL,
        [VIT_REGISTRATION] varchar(15) NULL,
        [VIT_EXPIRY] datetime NULL,
        [WWCC_NUMBER] varchar(11) NULL,
        [WWCC_EXPIRY] datetime NULL,
        [WWCC_TYPE] varchar(1) NULL,
        [ESUPER_IGNORE_THRESHOLD] varchar(1) NULL,
        [ESUPER_FUND01] varchar(10) NULL,
        [ESUPER_FUND02] varchar(10) NULL,
        [ESUPER_FUND03] varchar(10) NULL,
        [ESUPER_FUND04] varchar(10) NULL,
        [ESUPER_FUND05] varchar(10) NULL,
        [ESUPER_MEMBER01] varchar(20) NULL,
        [ESUPER_MEMBER02] varchar(20) NULL,
        [ESUPER_MEMBER03] varchar(20) NULL,
        [ESUPER_MEMBER04] varchar(20) NULL,
        [ESUPER_MEMBER05] varchar(20) NULL,
        [ESUPER_PERCENT01] float NULL,
        [ESUPER_PERCENT02] float NULL,
        [ESUPER_PERCENT03] float NULL,
        [ESUPER_PERCENT04] float NULL,
        [ESUPER_PERCENT05] float NULL,
        [LEAVE_HOURS] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PE_Index_PEKEY] PRIMARY KEY CLUSTERED (
            [PEKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PE_Index_COUNTRY] ON [dbo].[PE]
    (
            [COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [PE_Index_DEPARTMENT] ON [dbo].[PE]
    (
            [DEPARTMENT] ASC
    );
    CREATE NONCLUSTERED INDEX [PE_Index_HOMEKEY] ON [dbo].[PE]
    (
            [HOMEKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [PE_Index_LEAVE_GROUP] ON [dbo].[PE]
    (
            [LEAVE_GROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [PE_Index_LEAVEKEY] ON [dbo].[PE]
    (
            [LEAVEKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [PE_Index_MAILKEY] ON [dbo].[PE]
    (
            [MAILKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [PE_Index_PAYCODE] ON [dbo].[PE]
    (
            [PAYCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PE_Index_TAXCODE] ON [dbo].[PE]
    (
            [TAXCODE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PE data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PEDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEDataReader : IDataReader, IDataRecord
        {
            private List<PE> Items;
            private int CurrentIndex;
            private PE CurrentItem;

            public PEDataReader(List<PE> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 133; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PEKEY
                        return CurrentItem.PEKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // SURNAME
                        return CurrentItem.SURNAME;
                    case 3: // FIRST_NAME
                        return CurrentItem.FIRST_NAME;
                    case 4: // SECOND_NAME
                        return CurrentItem.SECOND_NAME;
                    case 5: // PREF_NAME
                        return CurrentItem.PREF_NAME;
                    case 6: // PREVIOUS_NAME
                        return CurrentItem.PREVIOUS_NAME;
                    case 7: // BIRTHDATE
                        return CurrentItem.BIRTHDATE;
                    case 8: // GENDER
                        return CurrentItem.GENDER;
                    case 9: // HOMEADD01
                        return CurrentItem.HOMEADD01;
                    case 10: // HOMEADD02
                        return CurrentItem.HOMEADD02;
                    case 11: // HOMESUBURB
                        return CurrentItem.HOMESUBURB;
                    case 12: // HOMESTATE
                        return CurrentItem.HOMESTATE;
                    case 13: // HOMEPOST
                        return CurrentItem.HOMEPOST;
                    case 14: // COUNTRY
                        return CurrentItem.COUNTRY;
                    case 15: // HOMEPHONE
                        return CurrentItem.HOMEPHONE;
                    case 16: // BUS_PHONE
                        return CurrentItem.BUS_PHONE;
                    case 17: // PHONE_EXT
                        return CurrentItem.PHONE_EXT;
                    case 18: // FAX
                        return CurrentItem.FAX;
                    case 19: // MOBILE
                        return CurrentItem.MOBILE;
                    case 20: // EMAIL
                        return CurrentItem.EMAIL;
                    case 21: // DRIVERS_LIC_NO
                        return CurrentItem.DRIVERS_LIC_NO;
                    case 22: // OWN_VEHICLE
                        return CurrentItem.OWN_VEHICLE;
                    case 23: // COMMENTS
                        return CurrentItem.COMMENTS;
                    case 24: // HOMEKEY
                        return CurrentItem.HOMEKEY;
                    case 25: // MAILKEY
                        return CurrentItem.MAILKEY;
                    case 26: // LEAVEKEY
                        return CurrentItem.LEAVEKEY;
                    case 27: // PAYCODE
                        return CurrentItem.PAYCODE;
                    case 28: // TAXCODE
                        return CurrentItem.TAXCODE;
                    case 29: // DEPARTMENT
                        return CurrentItem.DEPARTMENT;
                    case 30: // PENUMBER
                        return CurrentItem.PENUMBER;
                    case 31: // TAXFILENUM
                        return CurrentItem.TAXFILENUM;
                    case 32: // EMPLOY_TYPE
                        return CurrentItem.EMPLOY_TYPE;
                    case 33: // NORMAL_HOURS
                        return CurrentItem.NORMAL_HOURS;
                    case 34: // FTE_VALUE
                        return CurrentItem.FTE_VALUE;
                    case 35: // ANNUAL_SALARY
                        return CurrentItem.ANNUAL_SALARY;
                    case 36: // STD_HOURS
                        return CurrentItem.STD_HOURS;
                    case 37: // UNION_NAME
                        return CurrentItem.UNION_NAME;
                    case 38: // LEAVE_GROUP
                        return CurrentItem.LEAVE_GROUP;
                    case 39: // PAY_TYPE
                        return CurrentItem.PAY_TYPE;
                    case 40: // HOURLY_RATE
                        return CurrentItem.HOURLY_RATE;
                    case 41: // SIX_SUPER_FUND
                        return CurrentItem.SIX_SUPER_FUND;
                    case 42: // SIX_MEMBER_NO
                        return CurrentItem.SIX_MEMBER_NO;
                    case 43: // SUPER_LEVY
                        return CurrentItem.SUPER_LEVY;
                    case 44: // ZONE
                        return CurrentItem.ZONE;
                    case 45: // ZONE_CODE
                        return CurrentItem.ZONE_CODE;
                    case 46: // ZONE_ALLOW
                        return CurrentItem.ZONE_ALLOW;
                    case 47: // NO_DEPEND
                        return CurrentItem.NO_DEPEND;
                    case 48: // ALLOWANCES
                        return CurrentItem.ALLOWANCES;
                    case 49: // DEP_REBATE
                        return CurrentItem.DEP_REBATE;
                    case 50: // MEDICARE
                        return CurrentItem.MEDICARE;
                    case 51: // MEDICARE_Q9NOTQ12z
                        return CurrentItem.MEDICARE_Q9NOTQ12z;
                    case 52: // MEDICARE_Q09A
                        return CurrentItem.MEDICARE_Q09A;
                    case 53: // MEDICARE_Q10A
                        return CurrentItem.MEDICARE_Q10A;
                    case 54: // MEDICARE_Q11A
                        return CurrentItem.MEDICARE_Q11A;
                    case 55: // MEDICARE_Q12A
                        return CurrentItem.MEDICARE_Q12A;
                    case 56: // STARTDATE
                        return CurrentItem.STARTDATE;
                    case 57: // TERMDATE
                        return CurrentItem.TERMDATE;
                    case 58: // SALREVDATE
                        return CurrentItem.SALREVDATE;
                    case 59: // SUSPEND_DATE
                        return CurrentItem.SUSPEND_DATE;
                    case 60: // LASTPAYPERD
                        return CurrentItem.LASTPAYPERD;
                    case 61: // NEXTPAYPERD
                        return CurrentItem.NEXTPAYPERD;
                    case 62: // LASTPAYDATE
                        return CurrentItem.LASTPAYDATE;
                    case 63: // LASTPAYRATE
                        return CurrentItem.LASTPAYRATE;
                    case 64: // LASTNORMITEM
                        return CurrentItem.LASTNORMITEM;
                    case 65: // LASTPAYGROSS
                        return CurrentItem.LASTPAYGROSS;
                    case 66: // LASTPAYNETT
                        return CurrentItem.LASTPAYNETT;
                    case 67: // LASTPAYTAX
                        return CurrentItem.LASTPAYTAX;
                    case 68: // GROSS01
                        return CurrentItem.GROSS01;
                    case 69: // GROSS02
                        return CurrentItem.GROSS02;
                    case 70: // GROSS03
                        return CurrentItem.GROSS03;
                    case 71: // GROSS04
                        return CurrentItem.GROSS04;
                    case 72: // GROSS05
                        return CurrentItem.GROSS05;
                    case 73: // GROSS06
                        return CurrentItem.GROSS06;
                    case 74: // GROSS07
                        return CurrentItem.GROSS07;
                    case 75: // GROSS08
                        return CurrentItem.GROSS08;
                    case 76: // GROSS09
                        return CurrentItem.GROSS09;
                    case 77: // GROSS10
                        return CurrentItem.GROSS10;
                    case 78: // GROSS11
                        return CurrentItem.GROSS11;
                    case 79: // GROSS12
                        return CurrentItem.GROSS12;
                    case 80: // NETT01
                        return CurrentItem.NETT01;
                    case 81: // NETT02
                        return CurrentItem.NETT02;
                    case 82: // NETT03
                        return CurrentItem.NETT03;
                    case 83: // NETT04
                        return CurrentItem.NETT04;
                    case 84: // NETT05
                        return CurrentItem.NETT05;
                    case 85: // NETT06
                        return CurrentItem.NETT06;
                    case 86: // NETT07
                        return CurrentItem.NETT07;
                    case 87: // NETT08
                        return CurrentItem.NETT08;
                    case 88: // NETT09
                        return CurrentItem.NETT09;
                    case 89: // NETT10
                        return CurrentItem.NETT10;
                    case 90: // NETT11
                        return CurrentItem.NETT11;
                    case 91: // NETT12
                        return CurrentItem.NETT12;
                    case 92: // TAX01
                        return CurrentItem.TAX01;
                    case 93: // TAX02
                        return CurrentItem.TAX02;
                    case 94: // TAX03
                        return CurrentItem.TAX03;
                    case 95: // TAX04
                        return CurrentItem.TAX04;
                    case 96: // TAX05
                        return CurrentItem.TAX05;
                    case 97: // TAX06
                        return CurrentItem.TAX06;
                    case 98: // TAX07
                        return CurrentItem.TAX07;
                    case 99: // TAX08
                        return CurrentItem.TAX08;
                    case 100: // TAX09
                        return CurrentItem.TAX09;
                    case 101: // TAX10
                        return CurrentItem.TAX10;
                    case 102: // TAX11
                        return CurrentItem.TAX11;
                    case 103: // TAX12
                        return CurrentItem.TAX12;
                    case 104: // PAYG_SUMMARY
                        return CurrentItem.PAYG_SUMMARY;
                    case 105: // YEAR_LEVEL
                        return CurrentItem.YEAR_LEVEL;
                    case 106: // REPORTABLE_FB
                        return CurrentItem.REPORTABLE_FB;
                    case 107: // EMPLOYEE_PIC
                        return CurrentItem.EMPLOYEE_PIC;
                    case 108: // VIT_REGISTRATION
                        return CurrentItem.VIT_REGISTRATION;
                    case 109: // VIT_EXPIRY
                        return CurrentItem.VIT_EXPIRY;
                    case 110: // WWCC_NUMBER
                        return CurrentItem.WWCC_NUMBER;
                    case 111: // WWCC_EXPIRY
                        return CurrentItem.WWCC_EXPIRY;
                    case 112: // WWCC_TYPE
                        return CurrentItem.WWCC_TYPE;
                    case 113: // ESUPER_IGNORE_THRESHOLD
                        return CurrentItem.ESUPER_IGNORE_THRESHOLD;
                    case 114: // ESUPER_FUND01
                        return CurrentItem.ESUPER_FUND01;
                    case 115: // ESUPER_FUND02
                        return CurrentItem.ESUPER_FUND02;
                    case 116: // ESUPER_FUND03
                        return CurrentItem.ESUPER_FUND03;
                    case 117: // ESUPER_FUND04
                        return CurrentItem.ESUPER_FUND04;
                    case 118: // ESUPER_FUND05
                        return CurrentItem.ESUPER_FUND05;
                    case 119: // ESUPER_MEMBER01
                        return CurrentItem.ESUPER_MEMBER01;
                    case 120: // ESUPER_MEMBER02
                        return CurrentItem.ESUPER_MEMBER02;
                    case 121: // ESUPER_MEMBER03
                        return CurrentItem.ESUPER_MEMBER03;
                    case 122: // ESUPER_MEMBER04
                        return CurrentItem.ESUPER_MEMBER04;
                    case 123: // ESUPER_MEMBER05
                        return CurrentItem.ESUPER_MEMBER05;
                    case 124: // ESUPER_PERCENT01
                        return CurrentItem.ESUPER_PERCENT01;
                    case 125: // ESUPER_PERCENT02
                        return CurrentItem.ESUPER_PERCENT02;
                    case 126: // ESUPER_PERCENT03
                        return CurrentItem.ESUPER_PERCENT03;
                    case 127: // ESUPER_PERCENT04
                        return CurrentItem.ESUPER_PERCENT04;
                    case 128: // ESUPER_PERCENT05
                        return CurrentItem.ESUPER_PERCENT05;
                    case 129: // LEAVE_HOURS
                        return CurrentItem.LEAVE_HOURS;
                    case 130: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 131: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 132: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // SURNAME
                        return CurrentItem.SURNAME == null;
                    case 3: // FIRST_NAME
                        return CurrentItem.FIRST_NAME == null;
                    case 4: // SECOND_NAME
                        return CurrentItem.SECOND_NAME == null;
                    case 5: // PREF_NAME
                        return CurrentItem.PREF_NAME == null;
                    case 6: // PREVIOUS_NAME
                        return CurrentItem.PREVIOUS_NAME == null;
                    case 7: // BIRTHDATE
                        return CurrentItem.BIRTHDATE == null;
                    case 8: // GENDER
                        return CurrentItem.GENDER == null;
                    case 9: // HOMEADD01
                        return CurrentItem.HOMEADD01 == null;
                    case 10: // HOMEADD02
                        return CurrentItem.HOMEADD02 == null;
                    case 11: // HOMESUBURB
                        return CurrentItem.HOMESUBURB == null;
                    case 12: // HOMESTATE
                        return CurrentItem.HOMESTATE == null;
                    case 13: // HOMEPOST
                        return CurrentItem.HOMEPOST == null;
                    case 14: // COUNTRY
                        return CurrentItem.COUNTRY == null;
                    case 15: // HOMEPHONE
                        return CurrentItem.HOMEPHONE == null;
                    case 16: // BUS_PHONE
                        return CurrentItem.BUS_PHONE == null;
                    case 17: // PHONE_EXT
                        return CurrentItem.PHONE_EXT == null;
                    case 18: // FAX
                        return CurrentItem.FAX == null;
                    case 19: // MOBILE
                        return CurrentItem.MOBILE == null;
                    case 20: // EMAIL
                        return CurrentItem.EMAIL == null;
                    case 21: // DRIVERS_LIC_NO
                        return CurrentItem.DRIVERS_LIC_NO == null;
                    case 22: // OWN_VEHICLE
                        return CurrentItem.OWN_VEHICLE == null;
                    case 23: // COMMENTS
                        return CurrentItem.COMMENTS == null;
                    case 24: // HOMEKEY
                        return CurrentItem.HOMEKEY == null;
                    case 25: // MAILKEY
                        return CurrentItem.MAILKEY == null;
                    case 26: // LEAVEKEY
                        return CurrentItem.LEAVEKEY == null;
                    case 27: // PAYCODE
                        return CurrentItem.PAYCODE == null;
                    case 28: // TAXCODE
                        return CurrentItem.TAXCODE == null;
                    case 29: // DEPARTMENT
                        return CurrentItem.DEPARTMENT == null;
                    case 30: // PENUMBER
                        return CurrentItem.PENUMBER == null;
                    case 31: // TAXFILENUM
                        return CurrentItem.TAXFILENUM == null;
                    case 32: // EMPLOY_TYPE
                        return CurrentItem.EMPLOY_TYPE == null;
                    case 33: // NORMAL_HOURS
                        return CurrentItem.NORMAL_HOURS == null;
                    case 34: // FTE_VALUE
                        return CurrentItem.FTE_VALUE == null;
                    case 35: // ANNUAL_SALARY
                        return CurrentItem.ANNUAL_SALARY == null;
                    case 36: // STD_HOURS
                        return CurrentItem.STD_HOURS == null;
                    case 37: // UNION_NAME
                        return CurrentItem.UNION_NAME == null;
                    case 38: // LEAVE_GROUP
                        return CurrentItem.LEAVE_GROUP == null;
                    case 39: // PAY_TYPE
                        return CurrentItem.PAY_TYPE == null;
                    case 40: // HOURLY_RATE
                        return CurrentItem.HOURLY_RATE == null;
                    case 41: // SIX_SUPER_FUND
                        return CurrentItem.SIX_SUPER_FUND == null;
                    case 42: // SIX_MEMBER_NO
                        return CurrentItem.SIX_MEMBER_NO == null;
                    case 43: // SUPER_LEVY
                        return CurrentItem.SUPER_LEVY == null;
                    case 44: // ZONE
                        return CurrentItem.ZONE == null;
                    case 45: // ZONE_CODE
                        return CurrentItem.ZONE_CODE == null;
                    case 46: // ZONE_ALLOW
                        return CurrentItem.ZONE_ALLOW == null;
                    case 47: // NO_DEPEND
                        return CurrentItem.NO_DEPEND == null;
                    case 48: // ALLOWANCES
                        return CurrentItem.ALLOWANCES == null;
                    case 49: // DEP_REBATE
                        return CurrentItem.DEP_REBATE == null;
                    case 50: // MEDICARE
                        return CurrentItem.MEDICARE == null;
                    case 51: // MEDICARE_Q9NOTQ12z
                        return CurrentItem.MEDICARE_Q9NOTQ12z == null;
                    case 52: // MEDICARE_Q09A
                        return CurrentItem.MEDICARE_Q09A == null;
                    case 53: // MEDICARE_Q10A
                        return CurrentItem.MEDICARE_Q10A == null;
                    case 54: // MEDICARE_Q11A
                        return CurrentItem.MEDICARE_Q11A == null;
                    case 55: // MEDICARE_Q12A
                        return CurrentItem.MEDICARE_Q12A == null;
                    case 56: // STARTDATE
                        return CurrentItem.STARTDATE == null;
                    case 57: // TERMDATE
                        return CurrentItem.TERMDATE == null;
                    case 58: // SALREVDATE
                        return CurrentItem.SALREVDATE == null;
                    case 59: // SUSPEND_DATE
                        return CurrentItem.SUSPEND_DATE == null;
                    case 60: // LASTPAYPERD
                        return CurrentItem.LASTPAYPERD == null;
                    case 61: // NEXTPAYPERD
                        return CurrentItem.NEXTPAYPERD == null;
                    case 62: // LASTPAYDATE
                        return CurrentItem.LASTPAYDATE == null;
                    case 63: // LASTPAYRATE
                        return CurrentItem.LASTPAYRATE == null;
                    case 64: // LASTNORMITEM
                        return CurrentItem.LASTNORMITEM == null;
                    case 65: // LASTPAYGROSS
                        return CurrentItem.LASTPAYGROSS == null;
                    case 66: // LASTPAYNETT
                        return CurrentItem.LASTPAYNETT == null;
                    case 67: // LASTPAYTAX
                        return CurrentItem.LASTPAYTAX == null;
                    case 68: // GROSS01
                        return CurrentItem.GROSS01 == null;
                    case 69: // GROSS02
                        return CurrentItem.GROSS02 == null;
                    case 70: // GROSS03
                        return CurrentItem.GROSS03 == null;
                    case 71: // GROSS04
                        return CurrentItem.GROSS04 == null;
                    case 72: // GROSS05
                        return CurrentItem.GROSS05 == null;
                    case 73: // GROSS06
                        return CurrentItem.GROSS06 == null;
                    case 74: // GROSS07
                        return CurrentItem.GROSS07 == null;
                    case 75: // GROSS08
                        return CurrentItem.GROSS08 == null;
                    case 76: // GROSS09
                        return CurrentItem.GROSS09 == null;
                    case 77: // GROSS10
                        return CurrentItem.GROSS10 == null;
                    case 78: // GROSS11
                        return CurrentItem.GROSS11 == null;
                    case 79: // GROSS12
                        return CurrentItem.GROSS12 == null;
                    case 80: // NETT01
                        return CurrentItem.NETT01 == null;
                    case 81: // NETT02
                        return CurrentItem.NETT02 == null;
                    case 82: // NETT03
                        return CurrentItem.NETT03 == null;
                    case 83: // NETT04
                        return CurrentItem.NETT04 == null;
                    case 84: // NETT05
                        return CurrentItem.NETT05 == null;
                    case 85: // NETT06
                        return CurrentItem.NETT06 == null;
                    case 86: // NETT07
                        return CurrentItem.NETT07 == null;
                    case 87: // NETT08
                        return CurrentItem.NETT08 == null;
                    case 88: // NETT09
                        return CurrentItem.NETT09 == null;
                    case 89: // NETT10
                        return CurrentItem.NETT10 == null;
                    case 90: // NETT11
                        return CurrentItem.NETT11 == null;
                    case 91: // NETT12
                        return CurrentItem.NETT12 == null;
                    case 92: // TAX01
                        return CurrentItem.TAX01 == null;
                    case 93: // TAX02
                        return CurrentItem.TAX02 == null;
                    case 94: // TAX03
                        return CurrentItem.TAX03 == null;
                    case 95: // TAX04
                        return CurrentItem.TAX04 == null;
                    case 96: // TAX05
                        return CurrentItem.TAX05 == null;
                    case 97: // TAX06
                        return CurrentItem.TAX06 == null;
                    case 98: // TAX07
                        return CurrentItem.TAX07 == null;
                    case 99: // TAX08
                        return CurrentItem.TAX08 == null;
                    case 100: // TAX09
                        return CurrentItem.TAX09 == null;
                    case 101: // TAX10
                        return CurrentItem.TAX10 == null;
                    case 102: // TAX11
                        return CurrentItem.TAX11 == null;
                    case 103: // TAX12
                        return CurrentItem.TAX12 == null;
                    case 104: // PAYG_SUMMARY
                        return CurrentItem.PAYG_SUMMARY == null;
                    case 105: // YEAR_LEVEL
                        return CurrentItem.YEAR_LEVEL == null;
                    case 106: // REPORTABLE_FB
                        return CurrentItem.REPORTABLE_FB == null;
                    case 107: // EMPLOYEE_PIC
                        return CurrentItem.EMPLOYEE_PIC == null;
                    case 108: // VIT_REGISTRATION
                        return CurrentItem.VIT_REGISTRATION == null;
                    case 109: // VIT_EXPIRY
                        return CurrentItem.VIT_EXPIRY == null;
                    case 110: // WWCC_NUMBER
                        return CurrentItem.WWCC_NUMBER == null;
                    case 111: // WWCC_EXPIRY
                        return CurrentItem.WWCC_EXPIRY == null;
                    case 112: // WWCC_TYPE
                        return CurrentItem.WWCC_TYPE == null;
                    case 113: // ESUPER_IGNORE_THRESHOLD
                        return CurrentItem.ESUPER_IGNORE_THRESHOLD == null;
                    case 114: // ESUPER_FUND01
                        return CurrentItem.ESUPER_FUND01 == null;
                    case 115: // ESUPER_FUND02
                        return CurrentItem.ESUPER_FUND02 == null;
                    case 116: // ESUPER_FUND03
                        return CurrentItem.ESUPER_FUND03 == null;
                    case 117: // ESUPER_FUND04
                        return CurrentItem.ESUPER_FUND04 == null;
                    case 118: // ESUPER_FUND05
                        return CurrentItem.ESUPER_FUND05 == null;
                    case 119: // ESUPER_MEMBER01
                        return CurrentItem.ESUPER_MEMBER01 == null;
                    case 120: // ESUPER_MEMBER02
                        return CurrentItem.ESUPER_MEMBER02 == null;
                    case 121: // ESUPER_MEMBER03
                        return CurrentItem.ESUPER_MEMBER03 == null;
                    case 122: // ESUPER_MEMBER04
                        return CurrentItem.ESUPER_MEMBER04 == null;
                    case 123: // ESUPER_MEMBER05
                        return CurrentItem.ESUPER_MEMBER05 == null;
                    case 124: // ESUPER_PERCENT01
                        return CurrentItem.ESUPER_PERCENT01 == null;
                    case 125: // ESUPER_PERCENT02
                        return CurrentItem.ESUPER_PERCENT02 == null;
                    case 126: // ESUPER_PERCENT03
                        return CurrentItem.ESUPER_PERCENT03 == null;
                    case 127: // ESUPER_PERCENT04
                        return CurrentItem.ESUPER_PERCENT04 == null;
                    case 128: // ESUPER_PERCENT05
                        return CurrentItem.ESUPER_PERCENT05 == null;
                    case 129: // LEAVE_HOURS
                        return CurrentItem.LEAVE_HOURS == null;
                    case 130: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 131: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 132: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PEKEY
                        return "PEKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // SURNAME
                        return "SURNAME";
                    case 3: // FIRST_NAME
                        return "FIRST_NAME";
                    case 4: // SECOND_NAME
                        return "SECOND_NAME";
                    case 5: // PREF_NAME
                        return "PREF_NAME";
                    case 6: // PREVIOUS_NAME
                        return "PREVIOUS_NAME";
                    case 7: // BIRTHDATE
                        return "BIRTHDATE";
                    case 8: // GENDER
                        return "GENDER";
                    case 9: // HOMEADD01
                        return "HOMEADD01";
                    case 10: // HOMEADD02
                        return "HOMEADD02";
                    case 11: // HOMESUBURB
                        return "HOMESUBURB";
                    case 12: // HOMESTATE
                        return "HOMESTATE";
                    case 13: // HOMEPOST
                        return "HOMEPOST";
                    case 14: // COUNTRY
                        return "COUNTRY";
                    case 15: // HOMEPHONE
                        return "HOMEPHONE";
                    case 16: // BUS_PHONE
                        return "BUS_PHONE";
                    case 17: // PHONE_EXT
                        return "PHONE_EXT";
                    case 18: // FAX
                        return "FAX";
                    case 19: // MOBILE
                        return "MOBILE";
                    case 20: // EMAIL
                        return "EMAIL";
                    case 21: // DRIVERS_LIC_NO
                        return "DRIVERS_LIC_NO";
                    case 22: // OWN_VEHICLE
                        return "OWN_VEHICLE";
                    case 23: // COMMENTS
                        return "COMMENTS";
                    case 24: // HOMEKEY
                        return "HOMEKEY";
                    case 25: // MAILKEY
                        return "MAILKEY";
                    case 26: // LEAVEKEY
                        return "LEAVEKEY";
                    case 27: // PAYCODE
                        return "PAYCODE";
                    case 28: // TAXCODE
                        return "TAXCODE";
                    case 29: // DEPARTMENT
                        return "DEPARTMENT";
                    case 30: // PENUMBER
                        return "PENUMBER";
                    case 31: // TAXFILENUM
                        return "TAXFILENUM";
                    case 32: // EMPLOY_TYPE
                        return "EMPLOY_TYPE";
                    case 33: // NORMAL_HOURS
                        return "NORMAL_HOURS";
                    case 34: // FTE_VALUE
                        return "FTE_VALUE";
                    case 35: // ANNUAL_SALARY
                        return "ANNUAL_SALARY";
                    case 36: // STD_HOURS
                        return "STD_HOURS";
                    case 37: // UNION_NAME
                        return "UNION_NAME";
                    case 38: // LEAVE_GROUP
                        return "LEAVE_GROUP";
                    case 39: // PAY_TYPE
                        return "PAY_TYPE";
                    case 40: // HOURLY_RATE
                        return "HOURLY_RATE";
                    case 41: // SIX_SUPER_FUND
                        return "SIX_SUPER_FUND";
                    case 42: // SIX_MEMBER_NO
                        return "SIX_MEMBER_NO";
                    case 43: // SUPER_LEVY
                        return "SUPER_LEVY";
                    case 44: // ZONE
                        return "ZONE";
                    case 45: // ZONE_CODE
                        return "ZONE_CODE";
                    case 46: // ZONE_ALLOW
                        return "ZONE_ALLOW";
                    case 47: // NO_DEPEND
                        return "NO_DEPEND";
                    case 48: // ALLOWANCES
                        return "ALLOWANCES";
                    case 49: // DEP_REBATE
                        return "DEP_REBATE";
                    case 50: // MEDICARE
                        return "MEDICARE";
                    case 51: // MEDICARE_Q9NOTQ12z
                        return "MEDICARE_Q9NOTQ12z";
                    case 52: // MEDICARE_Q09A
                        return "MEDICARE_Q09A";
                    case 53: // MEDICARE_Q10A
                        return "MEDICARE_Q10A";
                    case 54: // MEDICARE_Q11A
                        return "MEDICARE_Q11A";
                    case 55: // MEDICARE_Q12A
                        return "MEDICARE_Q12A";
                    case 56: // STARTDATE
                        return "STARTDATE";
                    case 57: // TERMDATE
                        return "TERMDATE";
                    case 58: // SALREVDATE
                        return "SALREVDATE";
                    case 59: // SUSPEND_DATE
                        return "SUSPEND_DATE";
                    case 60: // LASTPAYPERD
                        return "LASTPAYPERD";
                    case 61: // NEXTPAYPERD
                        return "NEXTPAYPERD";
                    case 62: // LASTPAYDATE
                        return "LASTPAYDATE";
                    case 63: // LASTPAYRATE
                        return "LASTPAYRATE";
                    case 64: // LASTNORMITEM
                        return "LASTNORMITEM";
                    case 65: // LASTPAYGROSS
                        return "LASTPAYGROSS";
                    case 66: // LASTPAYNETT
                        return "LASTPAYNETT";
                    case 67: // LASTPAYTAX
                        return "LASTPAYTAX";
                    case 68: // GROSS01
                        return "GROSS01";
                    case 69: // GROSS02
                        return "GROSS02";
                    case 70: // GROSS03
                        return "GROSS03";
                    case 71: // GROSS04
                        return "GROSS04";
                    case 72: // GROSS05
                        return "GROSS05";
                    case 73: // GROSS06
                        return "GROSS06";
                    case 74: // GROSS07
                        return "GROSS07";
                    case 75: // GROSS08
                        return "GROSS08";
                    case 76: // GROSS09
                        return "GROSS09";
                    case 77: // GROSS10
                        return "GROSS10";
                    case 78: // GROSS11
                        return "GROSS11";
                    case 79: // GROSS12
                        return "GROSS12";
                    case 80: // NETT01
                        return "NETT01";
                    case 81: // NETT02
                        return "NETT02";
                    case 82: // NETT03
                        return "NETT03";
                    case 83: // NETT04
                        return "NETT04";
                    case 84: // NETT05
                        return "NETT05";
                    case 85: // NETT06
                        return "NETT06";
                    case 86: // NETT07
                        return "NETT07";
                    case 87: // NETT08
                        return "NETT08";
                    case 88: // NETT09
                        return "NETT09";
                    case 89: // NETT10
                        return "NETT10";
                    case 90: // NETT11
                        return "NETT11";
                    case 91: // NETT12
                        return "NETT12";
                    case 92: // TAX01
                        return "TAX01";
                    case 93: // TAX02
                        return "TAX02";
                    case 94: // TAX03
                        return "TAX03";
                    case 95: // TAX04
                        return "TAX04";
                    case 96: // TAX05
                        return "TAX05";
                    case 97: // TAX06
                        return "TAX06";
                    case 98: // TAX07
                        return "TAX07";
                    case 99: // TAX08
                        return "TAX08";
                    case 100: // TAX09
                        return "TAX09";
                    case 101: // TAX10
                        return "TAX10";
                    case 102: // TAX11
                        return "TAX11";
                    case 103: // TAX12
                        return "TAX12";
                    case 104: // PAYG_SUMMARY
                        return "PAYG_SUMMARY";
                    case 105: // YEAR_LEVEL
                        return "YEAR_LEVEL";
                    case 106: // REPORTABLE_FB
                        return "REPORTABLE_FB";
                    case 107: // EMPLOYEE_PIC
                        return "EMPLOYEE_PIC";
                    case 108: // VIT_REGISTRATION
                        return "VIT_REGISTRATION";
                    case 109: // VIT_EXPIRY
                        return "VIT_EXPIRY";
                    case 110: // WWCC_NUMBER
                        return "WWCC_NUMBER";
                    case 111: // WWCC_EXPIRY
                        return "WWCC_EXPIRY";
                    case 112: // WWCC_TYPE
                        return "WWCC_TYPE";
                    case 113: // ESUPER_IGNORE_THRESHOLD
                        return "ESUPER_IGNORE_THRESHOLD";
                    case 114: // ESUPER_FUND01
                        return "ESUPER_FUND01";
                    case 115: // ESUPER_FUND02
                        return "ESUPER_FUND02";
                    case 116: // ESUPER_FUND03
                        return "ESUPER_FUND03";
                    case 117: // ESUPER_FUND04
                        return "ESUPER_FUND04";
                    case 118: // ESUPER_FUND05
                        return "ESUPER_FUND05";
                    case 119: // ESUPER_MEMBER01
                        return "ESUPER_MEMBER01";
                    case 120: // ESUPER_MEMBER02
                        return "ESUPER_MEMBER02";
                    case 121: // ESUPER_MEMBER03
                        return "ESUPER_MEMBER03";
                    case 122: // ESUPER_MEMBER04
                        return "ESUPER_MEMBER04";
                    case 123: // ESUPER_MEMBER05
                        return "ESUPER_MEMBER05";
                    case 124: // ESUPER_PERCENT01
                        return "ESUPER_PERCENT01";
                    case 125: // ESUPER_PERCENT02
                        return "ESUPER_PERCENT02";
                    case 126: // ESUPER_PERCENT03
                        return "ESUPER_PERCENT03";
                    case 127: // ESUPER_PERCENT04
                        return "ESUPER_PERCENT04";
                    case 128: // ESUPER_PERCENT05
                        return "ESUPER_PERCENT05";
                    case 129: // LEAVE_HOURS
                        return "LEAVE_HOURS";
                    case 130: // LW_DATE
                        return "LW_DATE";
                    case 131: // LW_TIME
                        return "LW_TIME";
                    case 132: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PEKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "SURNAME":
                        return 2;
                    case "FIRST_NAME":
                        return 3;
                    case "SECOND_NAME":
                        return 4;
                    case "PREF_NAME":
                        return 5;
                    case "PREVIOUS_NAME":
                        return 6;
                    case "BIRTHDATE":
                        return 7;
                    case "GENDER":
                        return 8;
                    case "HOMEADD01":
                        return 9;
                    case "HOMEADD02":
                        return 10;
                    case "HOMESUBURB":
                        return 11;
                    case "HOMESTATE":
                        return 12;
                    case "HOMEPOST":
                        return 13;
                    case "COUNTRY":
                        return 14;
                    case "HOMEPHONE":
                        return 15;
                    case "BUS_PHONE":
                        return 16;
                    case "PHONE_EXT":
                        return 17;
                    case "FAX":
                        return 18;
                    case "MOBILE":
                        return 19;
                    case "EMAIL":
                        return 20;
                    case "DRIVERS_LIC_NO":
                        return 21;
                    case "OWN_VEHICLE":
                        return 22;
                    case "COMMENTS":
                        return 23;
                    case "HOMEKEY":
                        return 24;
                    case "MAILKEY":
                        return 25;
                    case "LEAVEKEY":
                        return 26;
                    case "PAYCODE":
                        return 27;
                    case "TAXCODE":
                        return 28;
                    case "DEPARTMENT":
                        return 29;
                    case "PENUMBER":
                        return 30;
                    case "TAXFILENUM":
                        return 31;
                    case "EMPLOY_TYPE":
                        return 32;
                    case "NORMAL_HOURS":
                        return 33;
                    case "FTE_VALUE":
                        return 34;
                    case "ANNUAL_SALARY":
                        return 35;
                    case "STD_HOURS":
                        return 36;
                    case "UNION_NAME":
                        return 37;
                    case "LEAVE_GROUP":
                        return 38;
                    case "PAY_TYPE":
                        return 39;
                    case "HOURLY_RATE":
                        return 40;
                    case "SIX_SUPER_FUND":
                        return 41;
                    case "SIX_MEMBER_NO":
                        return 42;
                    case "SUPER_LEVY":
                        return 43;
                    case "ZONE":
                        return 44;
                    case "ZONE_CODE":
                        return 45;
                    case "ZONE_ALLOW":
                        return 46;
                    case "NO_DEPEND":
                        return 47;
                    case "ALLOWANCES":
                        return 48;
                    case "DEP_REBATE":
                        return 49;
                    case "MEDICARE":
                        return 50;
                    case "MEDICARE_Q9NOTQ12z":
                        return 51;
                    case "MEDICARE_Q09A":
                        return 52;
                    case "MEDICARE_Q10A":
                        return 53;
                    case "MEDICARE_Q11A":
                        return 54;
                    case "MEDICARE_Q12A":
                        return 55;
                    case "STARTDATE":
                        return 56;
                    case "TERMDATE":
                        return 57;
                    case "SALREVDATE":
                        return 58;
                    case "SUSPEND_DATE":
                        return 59;
                    case "LASTPAYPERD":
                        return 60;
                    case "NEXTPAYPERD":
                        return 61;
                    case "LASTPAYDATE":
                        return 62;
                    case "LASTPAYRATE":
                        return 63;
                    case "LASTNORMITEM":
                        return 64;
                    case "LASTPAYGROSS":
                        return 65;
                    case "LASTPAYNETT":
                        return 66;
                    case "LASTPAYTAX":
                        return 67;
                    case "GROSS01":
                        return 68;
                    case "GROSS02":
                        return 69;
                    case "GROSS03":
                        return 70;
                    case "GROSS04":
                        return 71;
                    case "GROSS05":
                        return 72;
                    case "GROSS06":
                        return 73;
                    case "GROSS07":
                        return 74;
                    case "GROSS08":
                        return 75;
                    case "GROSS09":
                        return 76;
                    case "GROSS10":
                        return 77;
                    case "GROSS11":
                        return 78;
                    case "GROSS12":
                        return 79;
                    case "NETT01":
                        return 80;
                    case "NETT02":
                        return 81;
                    case "NETT03":
                        return 82;
                    case "NETT04":
                        return 83;
                    case "NETT05":
                        return 84;
                    case "NETT06":
                        return 85;
                    case "NETT07":
                        return 86;
                    case "NETT08":
                        return 87;
                    case "NETT09":
                        return 88;
                    case "NETT10":
                        return 89;
                    case "NETT11":
                        return 90;
                    case "NETT12":
                        return 91;
                    case "TAX01":
                        return 92;
                    case "TAX02":
                        return 93;
                    case "TAX03":
                        return 94;
                    case "TAX04":
                        return 95;
                    case "TAX05":
                        return 96;
                    case "TAX06":
                        return 97;
                    case "TAX07":
                        return 98;
                    case "TAX08":
                        return 99;
                    case "TAX09":
                        return 100;
                    case "TAX10":
                        return 101;
                    case "TAX11":
                        return 102;
                    case "TAX12":
                        return 103;
                    case "PAYG_SUMMARY":
                        return 104;
                    case "YEAR_LEVEL":
                        return 105;
                    case "REPORTABLE_FB":
                        return 106;
                    case "EMPLOYEE_PIC":
                        return 107;
                    case "VIT_REGISTRATION":
                        return 108;
                    case "VIT_EXPIRY":
                        return 109;
                    case "WWCC_NUMBER":
                        return 110;
                    case "WWCC_EXPIRY":
                        return 111;
                    case "WWCC_TYPE":
                        return 112;
                    case "ESUPER_IGNORE_THRESHOLD":
                        return 113;
                    case "ESUPER_FUND01":
                        return 114;
                    case "ESUPER_FUND02":
                        return 115;
                    case "ESUPER_FUND03":
                        return 116;
                    case "ESUPER_FUND04":
                        return 117;
                    case "ESUPER_FUND05":
                        return 118;
                    case "ESUPER_MEMBER01":
                        return 119;
                    case "ESUPER_MEMBER02":
                        return 120;
                    case "ESUPER_MEMBER03":
                        return 121;
                    case "ESUPER_MEMBER04":
                        return 122;
                    case "ESUPER_MEMBER05":
                        return 123;
                    case "ESUPER_PERCENT01":
                        return 124;
                    case "ESUPER_PERCENT02":
                        return 125;
                    case "ESUPER_PERCENT03":
                        return 126;
                    case "ESUPER_PERCENT04":
                        return 127;
                    case "ESUPER_PERCENT05":
                        return 128;
                    case "LEAVE_HOURS":
                        return 129;
                    case "LW_DATE":
                        return 130;
                    case "LW_TIME":
                        return 131;
                    case "LW_USER":
                        return 132;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
