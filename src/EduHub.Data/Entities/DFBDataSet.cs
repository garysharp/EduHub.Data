using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFBDataSet : SetBase<DFB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFB"; } }

        internal DFBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FAM_CODE = new Lazy<Dictionary<string, IReadOnlyList<DFB>>>(() => this.ToGroupedDictionary(i => i.FAM_CODE));
            Index_REFERENCE_NO = new Lazy<NullDictionary<string, IReadOnlyList<DFB>>>(() => this.ToGroupedNullDictionary(i => i.REFERENCE_NO));
            Index_TID = new Lazy<Dictionary<int, DFB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFB" /> fields for each CSV column header</returns>
        protected override Action<DFB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAM_CODE":
                        mapper[i] = (e, v) => e.FAM_CODE = v;
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CUST_REFERENCE":
                        mapper[i] = (e, v) => e.CUST_REFERENCE = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "INVOICE_TID":
                        mapper[i] = (e, v) => e.INVOICE_TID = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="DFB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DFB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DFB" /> items to added or update the base <see cref="DFB" /> items</param>
        /// <returns>A merged list of <see cref="DFB" /> items</returns>
        protected override List<DFB> ApplyDeltaItems(List<DFB> Items, List<DFB> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DFB deltaItem in DeltaItems)
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
                .OrderBy(i => i.FAM_CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DFB>>> Index_FAM_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFB>>> Index_REFERENCE_NO;
        private Lazy<Dictionary<int, DFB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFB by FAM_CODE field
        /// </summary>
        /// <param name="FAM_CODE">FAM_CODE value used to find DFB</param>
        /// <returns>List of related DFB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> FindByFAM_CODE(string FAM_CODE)
        {
            return Index_FAM_CODE.Value[FAM_CODE];
        }

        /// <summary>
        /// Attempt to find DFB by FAM_CODE field
        /// </summary>
        /// <param name="FAM_CODE">FAM_CODE value used to find DFB</param>
        /// <param name="Value">List of related DFB entities</param>
        /// <returns>True if the list of related DFB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAM_CODE(string FAM_CODE, out IReadOnlyList<DFB> Value)
        {
            return Index_FAM_CODE.Value.TryGetValue(FAM_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DFB by FAM_CODE field
        /// </summary>
        /// <param name="FAM_CODE">FAM_CODE value used to find DFB</param>
        /// <returns>List of related DFB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> TryFindByFAM_CODE(string FAM_CODE)
        {
            IReadOnlyList<DFB> value;
            if (Index_FAM_CODE.Value.TryGetValue(FAM_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DFB</param>
        /// <returns>List of related DFB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> FindByREFERENCE_NO(string REFERENCE_NO)
        {
            return Index_REFERENCE_NO.Value[REFERENCE_NO];
        }

        /// <summary>
        /// Attempt to find DFB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DFB</param>
        /// <param name="Value">List of related DFB entities</param>
        /// <returns>True if the list of related DFB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREFERENCE_NO(string REFERENCE_NO, out IReadOnlyList<DFB> Value)
        {
            return Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out Value);
        }

        /// <summary>
        /// Attempt to find DFB by REFERENCE_NO field
        /// </summary>
        /// <param name="REFERENCE_NO">REFERENCE_NO value used to find DFB</param>
        /// <returns>List of related DFB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFB> TryFindByREFERENCE_NO(string REFERENCE_NO)
        {
            IReadOnlyList<DFB> value;
            if (Index_REFERENCE_NO.Value.TryGetValue(REFERENCE_NO, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFB</param>
        /// <returns>Related DFB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFB</param>
        /// <param name="Value">Related DFB entity</param>
        /// <returns>True if the related DFB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFB</param>
        /// <returns>Related DFB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFB TryFindByTID(int TID)
        {
            DFB value;
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
