using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payer Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPDDataSet : SetBase<PPD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PPD"; } }

        internal PPDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPD>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_PPDKEY = new Lazy<Dictionary<string, PPD>>(() => this.ToDictionary(i => i.PPDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PPD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PPD" /> fields for each CSV column header</returns>
        protected override Action<PPD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PPD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABN_OR_WPN":
                        mapper[i] = (e, v) => e.ABN_OR_WPN = v;
                        break;
                    case "NUMBER_TYPE":
                        mapper[i] = (e, v) => e.NUMBER_TYPE = v;
                        break;
                    case "BRANCH_NUMBER":
                        mapper[i] = (e, v) => e.BRANCH_NUMBER = v;
                        break;
                    case "FINANCIAL_YEAR":
                        mapper[i] = (e, v) => e.FINANCIAL_YEAR = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "TRADING_NAME":
                        mapper[i] = (e, v) => e.TRADING_NAME = v;
                        break;
                    case "L1_ADDRESS":
                        mapper[i] = (e, v) => e.L1_ADDRESS = v;
                        break;
                    case "L2_ADDRESS":
                        mapper[i] = (e, v) => e.L2_ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "SIGNATURE":
                        mapper[i] = (e, v) => e.SIGNATURE = v;
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
        /// Merges <see cref="PPD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PPD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PPD" /> items to added or update the base <see cref="PPD" /> items</param>
        /// <returns>A merged list of <see cref="PPD" /> items</returns>
        protected override List<PPD> ApplyDeltaItems(List<PPD> Items, List<PPD> DeltaItems)
        {
            Dictionary<string, int> Index_PPDKEY = Items.ToIndexDictionary(i => i.PPDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PPD deltaItem in DeltaItems)
            {
                int index;

                if (Index_PPDKEY.TryGetValue(deltaItem.PPDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PPDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PPD>>> Index_COUNTRY;
        private Lazy<Dictionary<string, PPD>> Index_PPDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <returns>List of related PPD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPD> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <param name="Value">List of related PPD entities</param>
        /// <returns>True if the list of related PPD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<PPD> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <returns>List of related PPD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPD> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPD> value;
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
        /// Find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPD FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <param name="Value">Related PPD entity</param>
        /// <returns>True if the related PPD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out PPD Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPD TryFindByPPDKEY(string PPDKEY)
        {
            PPD value;
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
