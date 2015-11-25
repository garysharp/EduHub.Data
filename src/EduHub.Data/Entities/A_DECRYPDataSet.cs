using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Decrypted data IMPORT Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class A_DECRYPDataSet : SetBase<A_DECRYP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "A_DECRYP"; } }

        internal A_DECRYPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, A_DECRYP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="A_DECRYP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="A_DECRYP" /> fields for each CSV column header</returns>
        protected override Action<A_DECRYP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<A_DECRYP, string>[Headers.Count];

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
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="A_DECRYP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="A_DECRYP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="A_DECRYP" /> items to added or update the base <see cref="A_DECRYP" /> items</param>
        /// <returns>A merged list of <see cref="A_DECRYP" /> items</returns>
        protected override List<A_DECRYP> ApplyDeltaItems(List<A_DECRYP> Items, List<A_DECRYP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (A_DECRYP deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, A_DECRYP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public A_DECRYP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <param name="Value">Related A_DECRYP entity</param>
        /// <returns>True if the related A_DECRYP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out A_DECRYP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public A_DECRYP TryFindByTID(int TID)
        {
            A_DECRYP value;
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
