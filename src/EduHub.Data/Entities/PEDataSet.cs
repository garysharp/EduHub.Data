using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEDataSet : SetBase<PE>
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

    }
}
