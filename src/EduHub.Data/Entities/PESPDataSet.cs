using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super Payment Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PESPDataSet : SetBase<PESP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PESP"; } }

        internal PESPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PESP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PESP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PESP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PESP" /> fields for each CSV column header</returns>
        protected override Action<PESP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PESP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYMENT_AMOUNT":
                        mapper[i] = (e, v) => e.PAYMENT_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_FROM_DATE":
                        mapper[i] = (e, v) => e.SUPER_FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUPER_TO_DATE":
                        mapper[i] = (e, v) => e.SUPER_TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PROCESS_DATE":
                        mapper[i] = (e, v) => e.PROCESS_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DATE_ADVISED":
                        mapper[i] = (e, v) => e.DATE_ADVISED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="PESP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PESP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PESP" /> items to added or update the base <see cref="PESP" /> items</param>
        /// <returns>A merged list of <see cref="PESP" /> items</returns>
        protected override List<PESP> ApplyDeltaItems(List<PESP> Items, List<PESP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PESP deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<PESP>>> Index_CODE;
        private Lazy<Dictionary<int, PESP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <returns>List of related PESP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESP> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <param name="Value">List of related PESP entities</param>
        /// <returns>True if the list of related PESP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PESP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PESP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESP</param>
        /// <returns>List of related PESP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESP> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PESP> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <returns>Related PESP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <param name="Value">Related PESP entity</param>
        /// <returns>True if the related PESP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PESP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PESP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESP</param>
        /// <returns>Related PESP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESP TryFindByTID(int TID)
        {
            PESP value;
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
