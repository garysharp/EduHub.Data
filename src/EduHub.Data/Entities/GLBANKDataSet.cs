using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLBANKDataSet : SetBase<GLBANK>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLBANK"; } }

        internal GLBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLBANKKEY = new Lazy<Dictionary<int, GLBANK>>(() => this.ToDictionary(i => i.GLBANKKEY));
            Index_GLCODE = new Lazy<Dictionary<string, GLBANK>>(() => this.ToDictionary(i => i.GLCODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLBANK" /> fields for each CSV column header</returns>
        protected override Action<GLBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLBANK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANKKEY":
                        mapper[i] = (e, v) => e.GLBANKKEY = int.Parse(v);
                        break;
                    case "ACCOUNT_TYPE":
                        mapper[i] = (e, v) => e.ACCOUNT_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INTEREST_RATE":
                        mapper[i] = (e, v) => e.INTEREST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "INVESTMENT_DATE":
                        mapper[i] = (e, v) => e.INVESTMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MATURITY_DATE":
                        mapper[i] = (e, v) => e.MATURITY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INTEREST_EARNED":
                        mapper[i] = (e, v) => e.INTEREST_EARNED = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "TOTAL_BANK_BALANCE":
                        mapper[i] = (e, v) => e.TOTAL_BANK_BALANCE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_BANK_BALANCE":
                        mapper[i] = (e, v) => e.LY_BANK_BALANCE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CASH_GRANT":
                        mapper[i] = (e, v) => e.CASH_GRANT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_CASH_GRANT":
                        mapper[i] = (e, v) => e.LY_CASH_GRANT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPERATING_RESERVE":
                        mapper[i] = (e, v) => e.OPERATING_RESERVE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_OPERATING_RESERVE":
                        mapper[i] = (e, v) => e.LY_OPERATING_RESERVE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR01":
                        mapper[i] = (e, v) => e.CURR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR02":
                        mapper[i] = (e, v) => e.CURR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR03":
                        mapper[i] = (e, v) => e.CURR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR04":
                        mapper[i] = (e, v) => e.CURR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR05":
                        mapper[i] = (e, v) => e.CURR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR06":
                        mapper[i] = (e, v) => e.CURR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR07":
                        mapper[i] = (e, v) => e.CURR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR08":
                        mapper[i] = (e, v) => e.CURR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR09":
                        mapper[i] = (e, v) => e.CURR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR10":
                        mapper[i] = (e, v) => e.CURR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR11":
                        mapper[i] = (e, v) => e.CURR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR12":
                        mapper[i] = (e, v) => e.CURR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR01":
                        mapper[i] = (e, v) => e.LASTYR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR02":
                        mapper[i] = (e, v) => e.LASTYR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR03":
                        mapper[i] = (e, v) => e.LASTYR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR04":
                        mapper[i] = (e, v) => e.LASTYR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR05":
                        mapper[i] = (e, v) => e.LASTYR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR06":
                        mapper[i] = (e, v) => e.LASTYR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR07":
                        mapper[i] = (e, v) => e.LASTYR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR08":
                        mapper[i] = (e, v) => e.LASTYR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR09":
                        mapper[i] = (e, v) => e.LASTYR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR10":
                        mapper[i] = (e, v) => e.LASTYR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR11":
                        mapper[i] = (e, v) => e.LASTYR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR12":
                        mapper[i] = (e, v) => e.LASTYR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="GLBANK" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLBANK" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLBANK" /> items to added or update the base <see cref="GLBANK" /> items</param>
        /// <returns>A merged list of <see cref="GLBANK" /> items</returns>
        protected override List<GLBANK> ApplyDeltaItems(List<GLBANK> Items, List<GLBANK> DeltaItems)
        {
            Dictionary<int, int> Index_GLBANKKEY = Items.ToIndexDictionary(i => i.GLBANKKEY);
            Dictionary<string, int> Index_GLCODE = Items.ToIndexDictionary(i => i.GLCODE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLBANK deltaItem in DeltaItems)
            {
                int index;

                if (Index_GLBANKKEY.TryGetValue(deltaItem.GLBANKKEY, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_GLCODE.TryGetValue(deltaItem.GLCODE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.GLCODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, GLBANK>> Index_GLBANKKEY;
        private Lazy<Dictionary<string, GLBANK>> Index_GLCODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLBANK by GLBANKKEY field
        /// </summary>
        /// <param name="GLBANKKEY">GLBANKKEY value used to find GLBANK</param>
        /// <returns>Related GLBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK FindByGLBANKKEY(int GLBANKKEY)
        {
            return Index_GLBANKKEY.Value[GLBANKKEY];
        }

        /// <summary>
        /// Attempt to find GLBANK by GLBANKKEY field
        /// </summary>
        /// <param name="GLBANKKEY">GLBANKKEY value used to find GLBANK</param>
        /// <param name="Value">Related GLBANK entity</param>
        /// <returns>True if the related GLBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLBANKKEY(int GLBANKKEY, out GLBANK Value)
        {
            return Index_GLBANKKEY.Value.TryGetValue(GLBANKKEY, out Value);
        }

        /// <summary>
        /// Attempt to find GLBANK by GLBANKKEY field
        /// </summary>
        /// <param name="GLBANKKEY">GLBANKKEY value used to find GLBANK</param>
        /// <returns>Related GLBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK TryFindByGLBANKKEY(int GLBANKKEY)
        {
            GLBANK value;
            if (Index_GLBANKKEY.Value.TryGetValue(GLBANKKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find GLBANK</param>
        /// <returns>Related GLBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find GLBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find GLBANK</param>
        /// <param name="Value">Related GLBANK entity</param>
        /// <returns>True if the related GLBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out GLBANK Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find GLBANK</param>
        /// <returns>Related GLBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBANK TryFindByGLCODE(string GLCODE)
        {
            GLBANK value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
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
