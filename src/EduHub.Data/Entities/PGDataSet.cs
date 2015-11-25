using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payment Summary Box Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PGDataSet : SetBase<PG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PG"; } }

        internal PGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PAYG_BOX = new Lazy<Dictionary<short, PG>>(() => this.ToDictionary(i => i.PAYG_BOX));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PG" /> fields for each CSV column header</returns>
        protected override Action<PG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PAYG_BOX":
                        mapper[i] = (e, v) => e.PAYG_BOX = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="PG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PG" /> items to added or update the base <see cref="PG" /> items</param>
        /// <returns>A merged list of <see cref="PG" /> items</returns>
        protected override List<PG> ApplyDeltaItems(List<PG> Items, List<PG> DeltaItems)
        {
            Dictionary<short, int> Index_PAYG_BOX = Items.ToIndexDictionary(i => i.PAYG_BOX);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PG deltaItem in DeltaItems)
            {
                int index;

                if (Index_PAYG_BOX.TryGetValue(deltaItem.PAYG_BOX, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PAYG_BOX)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, PG>> Index_PAYG_BOX;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PG FindByPAYG_BOX(short PAYG_BOX)
        {
            return Index_PAYG_BOX.Value[PAYG_BOX];
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <param name="Value">Related PG entity</param>
        /// <returns>True if the related PG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYG_BOX(short PAYG_BOX, out PG Value)
        {
            return Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out Value);
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PG TryFindByPAYG_BOX(short PAYG_BOX)
        {
            PG value;
            if (Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out value))
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
