using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PRMS Order Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPRMSDataSet : SetBase<KPRMS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPRMS"; } }

        internal KPRMSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KPRMS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPRMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPRMS" /> fields for each CSV column header</returns>
        protected override Action<KPRMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPRMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PRMS_ORDERNO":
                        mapper[i] = (e, v) => e.PRMS_ORDERNO = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ORDER_LINENO":
                        mapper[i] = (e, v) => e.ORDER_LINENO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ORDER_DESC":
                        mapper[i] = (e, v) => e.ORDER_DESC = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "GLSUBPROG":
                        mapper[i] = (e, v) => e.GLSUBPROG = v;
                        break;
                    case "GLINIT":
                        mapper[i] = (e, v) => e.GLINIT = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "GST_CODE":
                        mapper[i] = (e, v) => e.GST_CODE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
        /// Merges <see cref="KPRMS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPRMS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPRMS" /> items to added or update the base <see cref="KPRMS" /> items</param>
        /// <returns>A merged list of <see cref="KPRMS" /> items</returns>
        protected override List<KPRMS> ApplyDeltaItems(List<KPRMS> Items, List<KPRMS> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPRMS deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, KPRMS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPRMS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <param name="Value">Related KPRMS entity</param>
        /// <returns>True if the related KPRMS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KPRMS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPRMS TryFindByTID(int TID)
        {
            KPRMS value;
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
