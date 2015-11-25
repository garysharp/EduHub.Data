using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRDataSet : SetBase<CR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "CR"; } }

        internal CRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CRKEY = new Lazy<Dictionary<string, CR>>(() => this.ToDictionary(i => i.CRKEY));
            Index_PPDKEY = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.PPDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CR" /> fields for each CSV column header</returns>
        protected override Action<CR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MTDPURCH":
                        mapper[i] = (e, v) => e.MTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "YTDPURCH":
                        mapper[i] = (e, v) => e.YTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRLIMIT":
                        mapper[i] = (e, v) => e.CRLIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAY":
                        mapper[i] = (e, v) => e.LASTPAY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERMS":
                        mapper[i] = (e, v) => e.TERMS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DISCOUNT":
                        mapper[i] = (e, v) => e.DISCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "CR_EMAIL":
                        mapper[i] = (e, v) => e.CR_EMAIL = v;
                        break;
                    case "EMAIL_FOR_PAYMENTS":
                        mapper[i] = (e, v) => e.EMAIL_FOR_PAYMENTS = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "COMMITMENT":
                        mapper[i] = (e, v) => e.COMMITMENT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STOP_FLAG":
                        mapper[i] = (e, v) => e.STOP_FLAG = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "PAYG_RATE":
                        mapper[i] = (e, v) => e.PAYG_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "LODGE_REF":
                        mapper[i] = (e, v) => e.LODGE_REF = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
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
                    case "PAYG_BIRTHDATE":
                        mapper[i] = (e, v) => e.PAYG_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_STARTDATE":
                        mapper[i] = (e, v) => e.PAYG_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_TERMDATE":
                        mapper[i] = (e, v) => e.PAYG_TERMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_ADDRESS01":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS01 = v;
                        break;
                    case "PAYG_ADDRESS02":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS02 = v;
                        break;
                    case "PAYG_SUBURB":
                        mapper[i] = (e, v) => e.PAYG_SUBURB = v;
                        break;
                    case "PAYG_STATE":
                        mapper[i] = (e, v) => e.PAYG_STATE = v;
                        break;
                    case "PAYG_POST":
                        mapper[i] = (e, v) => e.PAYG_POST = v;
                        break;
                    case "PAYG_COUNTRY":
                        mapper[i] = (e, v) => e.PAYG_COUNTRY = v;
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PRMS_FLAG":
                        mapper[i] = (e, v) => e.PRMS_FLAG = v;
                        break;
                    case "LW_PRMSINFO_DATE":
                        mapper[i] = (e, v) => e.LW_PRMSINFO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="CR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="CR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="CR" /> items to added or update the base <see cref="CR" /> items</param>
        /// <returns>A merged list of <see cref="CR" /> items</returns>
        protected override List<CR> ApplyDeltaItems(List<CR> Items, List<CR> DeltaItems)
        {
            Dictionary<string, int> Index_CRKEY = Items.ToIndexDictionary(i => i.CRKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (CR deltaItem in DeltaItems)
            {
                int index;

                if (Index_CRKEY.TryGetValue(deltaItem.CRKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_BSB;
        private Lazy<Dictionary<string, CR>> Index_CRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_PPDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<CR> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByBSB(string BSB)
        {
            IReadOnlyList<CR> value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR FindByCRKEY(string CRKEY)
        {
            return Index_CRKEY.Value[CRKEY];
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <param name="Value">Related CR entity</param>
        /// <returns>True if the related CR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCRKEY(string CRKEY, out CR Value)
        {
            return Index_CRKEY.Value.TryGetValue(CRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR TryFindByCRKEY(string CRKEY)
        {
            CR value;
            if (Index_CRKEY.Value.TryGetValue(CRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out IReadOnlyList<CR> Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByPPDKEY(string PPDKEY)
        {
            IReadOnlyList<CR> value;
            if (Index_PPDKEY.Value.TryGetValue(PPDKEY, out value))
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
