using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Voluntary Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFVTDataSet : SetBase<DFVT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFVT"; } }

        internal DFVTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FAMILY = new Lazy<Dictionary<string, IReadOnlyList<DFVT>>>(() => this.ToGroupedDictionary(i => i.FAMILY));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<DFVT>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_TID = new Lazy<Dictionary<int, DFVT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFVT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFVT" /> fields for each CSV column header</returns>
        protected override Action<DFVT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFVT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GROUPING":
                        mapper[i] = (e, v) => e.GROUPING = v;
                        break;
                    case "FROM_DATE":
                        mapper[i] = (e, v) => e.FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SHORTCUT":
                        mapper[i] = (e, v) => e.SHORTCUT = v;
                        break;
                    case "APPEAL":
                        mapper[i] = (e, v) => e.APPEAL = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
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
        /// Merges <see cref="DFVT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DFVT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DFVT" /> items to added or update the base <see cref="DFVT" /> items</param>
        /// <returns>A merged list of <see cref="DFVT" /> items</returns>
        protected override List<DFVT> ApplyDeltaItems(List<DFVT> Items, List<DFVT> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DFVT deltaItem in DeltaItems)
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
                .OrderBy(i => i.FAMILY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DFVT>>> Index_FAMILY;
        private Lazy<NullDictionary<string, IReadOnlyList<DFVT>>> Index_GST_TYPE;
        private Lazy<Dictionary<int, DFVT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <returns>List of related DFVT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> FindByFAMILY(string FAMILY)
        {
            return Index_FAMILY.Value[FAMILY];
        }

        /// <summary>
        /// Attempt to find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <param name="Value">List of related DFVT entities</param>
        /// <returns>True if the list of related DFVT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMILY(string FAMILY, out IReadOnlyList<DFVT> Value)
        {
            return Index_FAMILY.Value.TryGetValue(FAMILY, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <returns>List of related DFVT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> TryFindByFAMILY(string FAMILY)
        {
            IReadOnlyList<DFVT> value;
            if (Index_FAMILY.Value.TryGetValue(FAMILY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <returns>List of related DFVT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <param name="Value">List of related DFVT entities</param>
        /// <returns>True if the list of related DFVT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<DFVT> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <returns>List of related DFVT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<DFVT> value;
            if (Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <returns>Related DFVT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFVT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <param name="Value">Related DFVT entity</param>
        /// <returns>True if the related DFVT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFVT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <returns>Related DFVT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFVT TryFindByTID(int TID)
        {
            DFVT value;
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
