using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPay Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BPAY_DATDataSet : SetBase<BPAY_DAT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BPAY_DAT"; } }

        internal BPAY_DATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, BPAY_DAT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BPAY_DAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BPAY_DAT" /> fields for each CSV column header</returns>
        protected override Action<BPAY_DAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BPAY_DAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v;
                        break;
                    case "CUST_REF":
                        mapper[i] = (e, v) => e.CUST_REF = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "SUPPORT_REF":
                        mapper[i] = (e, v) => e.SUPPORT_REF = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
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
        /// Merges <see cref="BPAY_DAT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="BPAY_DAT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="BPAY_DAT" /> items to added or update the base <see cref="BPAY_DAT" /> items</param>
        /// <returns>A merged list of <see cref="BPAY_DAT" /> items</returns>
        protected override List<BPAY_DAT> ApplyDeltaItems(List<BPAY_DAT> Items, List<BPAY_DAT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (BPAY_DAT deltaItem in DeltaItems)
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
                .OrderBy(i => i.TID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, BPAY_DAT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BPAY_DAT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <param name="Value">Related BPAY_DAT entity</param>
        /// <returns>True if the related BPAY_DAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out BPAY_DAT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find BPAY_DAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BPAY_DAT</param>
        /// <returns>Related BPAY_DAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BPAY_DAT TryFindByTID(int TID)
        {
            BPAY_DAT value;
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
