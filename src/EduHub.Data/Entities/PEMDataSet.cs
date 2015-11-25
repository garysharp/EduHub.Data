using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Advice Slip Message Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEMDataSet : SetBase<PEM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEM"; } }

        internal PEMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEM>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PEM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEM" /> fields for each CSV column header</returns>
        protected override Action<PEM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "START_TRPAYPERD":
                        mapper[i] = (e, v) => e.START_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "END_TRPAYPERD":
                        mapper[i] = (e, v) => e.END_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMP_MESSAGE":
                        mapper[i] = (e, v) => e.EMP_MESSAGE = v;
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
        /// Merges <see cref="PEM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEM" /> items to added or update the base <see cref="PEM" /> items</param>
        /// <returns>A merged list of <see cref="PEM" /> items</returns>
        protected override List<PEM> ApplyDeltaItems(List<PEM> Items, List<PEM> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEM deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEM>>> Index_CODE;
        private Lazy<Dictionary<int, PEM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <returns>List of related PEM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEM> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <param name="Value">List of related PEM entities</param>
        /// <returns>True if the list of related PEM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEM> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <returns>List of related PEM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEM> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEM> value;
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
        /// Find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <returns>Related PEM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <param name="Value">Related PEM entity</param>
        /// <returns>True if the related PEM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <returns>Related PEM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEM TryFindByTID(int TID)
        {
            PEM value;
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
