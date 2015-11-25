using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Temporary Group Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGTRXDataSet : SetBase<SGTRX>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGTRX"; } }

        internal SGTRXDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGTRXKEY = new Lazy<Dictionary<string, IReadOnlyList<SGTRX>>>(() => this.ToGroupedDictionary(i => i.SGTRXKEY));
            Index_TID = new Lazy<Dictionary<int, SGTRX>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGTRX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGTRX" /> fields for each CSV column header</returns>
        protected override Action<SGTRX, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGTRX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGTRXKEY":
                        mapper[i] = (e, v) => e.SGTRXKEY = v;
                        break;
                    case "TRXTYPE":
                        mapper[i] = (e, v) => e.TRXTYPE = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
                        break;
                    case "SULINK":
                        mapper[i] = (e, v) => e.SULINK = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
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
        /// Merges <see cref="SGTRX" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGTRX" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGTRX" /> items to added or update the base <see cref="SGTRX" /> items</param>
        /// <returns>A merged list of <see cref="SGTRX" /> items</returns>
        protected override List<SGTRX> ApplyDeltaItems(List<SGTRX> Items, List<SGTRX> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGTRX deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGTRXKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SGTRX>>> Index_SGTRXKEY;
        private Lazy<Dictionary<int, SGTRX>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <returns>List of related SGTRX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGTRX> FindBySGTRXKEY(string SGTRXKEY)
        {
            return Index_SGTRXKEY.Value[SGTRXKEY];
        }

        /// <summary>
        /// Attempt to find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <param name="Value">List of related SGTRX entities</param>
        /// <returns>True if the list of related SGTRX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGTRXKEY(string SGTRXKEY, out IReadOnlyList<SGTRX> Value)
        {
            return Index_SGTRXKEY.Value.TryGetValue(SGTRXKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <returns>List of related SGTRX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGTRX> TryFindBySGTRXKEY(string SGTRXKEY)
        {
            IReadOnlyList<SGTRX> value;
            if (Index_SGTRXKEY.Value.TryGetValue(SGTRXKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <returns>Related SGTRX entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGTRX FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <param name="Value">Related SGTRX entity</param>
        /// <returns>True if the related SGTRX entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGTRX Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <returns>Related SGTRX entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGTRX TryFindByTID(int TID)
        {
            SGTRX value;
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
