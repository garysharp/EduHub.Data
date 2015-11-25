using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// On line receipt history Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIRHDataSet : SetBase<SIRH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SIRH"; } }

        internal SIRHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PRINT_ID = new Lazy<Dictionary<int, SIRH>>(() => this.ToDictionary(i => i.PRINT_ID));
            Index_SIRHKEY = new Lazy<Dictionary<string, SIRH>>(() => this.ToDictionary(i => i.SIRHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIRH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIRH" /> fields for each CSV column header</returns>
        protected override Action<SIRH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SIRH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIRHKEY":
                        mapper[i] = (e, v) => e.SIRHKEY = v;
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "RECEIPT_USER":
                        mapper[i] = (e, v) => e.RECEIPT_USER = v;
                        break;
                    case "RECEIPT_DATE":
                        mapper[i] = (e, v) => e.RECEIPT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECEIPT_TIME":
                        mapper[i] = (e, v) => e.RECEIPT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NEW_TRREF":
                        mapper[i] = (e, v) => e.NEW_TRREF = v;
                        break;
                    case "ERROR_FLAG":
                        mapper[i] = (e, v) => e.ERROR_FLAG = v;
                        break;
                    case "ERROR_COMMENT":
                        mapper[i] = (e, v) => e.ERROR_COMMENT = v;
                        break;
                    case "ERROR_USER":
                        mapper[i] = (e, v) => e.ERROR_USER = v;
                        break;
                    case "FORMAT_ID":
                        mapper[i] = (e, v) => e.FORMAT_ID = v;
                        break;
                    case "PRINT_ID":
                        mapper[i] = (e, v) => e.PRINT_ID = int.Parse(v);
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
        /// Merges <see cref="SIRH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SIRH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SIRH" /> items to added or update the base <see cref="SIRH" /> items</param>
        /// <returns>A merged list of <see cref="SIRH" /> items</returns>
        protected override List<SIRH> ApplyDeltaItems(List<SIRH> Items, List<SIRH> DeltaItems)
        {
            Dictionary<int, int> Index_PRINT_ID = Items.ToIndexDictionary(i => i.PRINT_ID);
            Dictionary<string, int> Index_SIRHKEY = Items.ToIndexDictionary(i => i.SIRHKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SIRH deltaItem in DeltaItems)
            {
                int index;

                if (Index_PRINT_ID.TryGetValue(deltaItem.PRINT_ID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_SIRHKEY.TryGetValue(deltaItem.SIRHKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SIRHKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SIRH>> Index_PRINT_ID;
        private Lazy<Dictionary<string, SIRH>> Index_SIRHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <returns>Related SIRH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH FindByPRINT_ID(int PRINT_ID)
        {
            return Index_PRINT_ID.Value[PRINT_ID];
        }

        /// <summary>
        /// Attempt to find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <param name="Value">Related SIRH entity</param>
        /// <returns>True if the related SIRH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPRINT_ID(int PRINT_ID, out SIRH Value)
        {
            return Index_PRINT_ID.Value.TryGetValue(PRINT_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <returns>Related SIRH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH TryFindByPRINT_ID(int PRINT_ID)
        {
            SIRH value;
            if (Index_PRINT_ID.Value.TryGetValue(PRINT_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH FindBySIRHKEY(string SIRHKEY)
        {
            return Index_SIRHKEY.Value[SIRHKEY];
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <param name="Value">Related SIRH entity</param>
        /// <returns>True if the related SIRH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIRHKEY(string SIRHKEY, out SIRH Value)
        {
            return Index_SIRHKEY.Value.TryGetValue(SIRHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH TryFindBySIRHKEY(string SIRHKEY)
        {
            SIRH value;
            if (Index_SIRHKEY.Value.TryGetValue(SIRHKEY, out value))
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
