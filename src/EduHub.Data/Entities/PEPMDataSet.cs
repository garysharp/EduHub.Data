using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Methods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPMDataSet : SetBase<PEPM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPM"; } }

        internal PEPMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<PEPM>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPM>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PEPM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPM" /> fields for each CSV column header</returns>
        protected override Action<PEPM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "PAYMODE":
                        mapper[i] = (e, v) => e.PAYMODE = v;
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CHQ_NO":
                        mapper[i] = (e, v) => e.CHQ_NO = v;
                        break;
                    case "DAMOUNT":
                        mapper[i] = (e, v) => e.DAMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EFT_CREATED":
                        mapper[i] = (e, v) => e.EFT_CREATED = v;
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
        /// Merges <see cref="PEPM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEPM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEPM" /> items to added or update the base <see cref="PEPM" /> items</param>
        /// <returns>A merged list of <see cref="PEPM" /> items</returns>
        protected override List<PEPM> ApplyDeltaItems(List<PEPM> Items, List<PEPM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEPM deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PEPM>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<PEPM>>> Index_CODE;
        private Lazy<Dictionary<int, PEPM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <returns>List of related PEPM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <param name="Value">List of related PEPM entities</param>
        /// <returns>True if the list of related PEPM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<PEPM> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <returns>List of related PEPM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> TryFindByBSB(string BSB)
        {
            IReadOnlyList<PEPM> value;
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
        /// Find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <returns>List of related PEPM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <param name="Value">List of related PEPM entities</param>
        /// <returns>True if the list of related PEPM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPM> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <returns>List of related PEPM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPM> value;
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
        /// Find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <returns>Related PEPM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <param name="Value">Related PEPM entity</param>
        /// <returns>True if the related PEPM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <returns>Related PEPM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPM TryFindByTID(int TID)
        {
            PEPM value;
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
