using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KABDataSet : SetBase<KAB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAB"; } }

        internal KABDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<Dictionary<string, KAB>>(() => this.ToDictionary(i => i.BSB));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAB" /> fields for each CSV column header</returns>
        protected override Action<KAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
        /// Merges <see cref="KAB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KAB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KAB" /> items to added or update the base <see cref="KAB" /> items</param>
        /// <returns>A merged list of <see cref="KAB" /> items</returns>
        protected override List<KAB> ApplyDeltaItems(List<KAB> Items, List<KAB> DeltaItems)
        {
            Dictionary<string, int> Index_BSB = Items.ToIndexDictionary(i => i.BSB);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KAB deltaItem in DeltaItems)
            {
                int index;

                if (Index_BSB.TryGetValue(deltaItem.BSB, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.BSB)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KAB>> Index_BSB;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <returns>Related KAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAB FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <param name="Value">Related KAB entity</param>
        /// <returns>True if the related KAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out KAB Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <returns>Related KAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAB TryFindByBSB(string BSB)
        {
            KAB value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
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
