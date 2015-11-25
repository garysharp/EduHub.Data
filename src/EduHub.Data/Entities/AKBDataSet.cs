using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Sub-Category Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKBDataSet : SetBase<AKB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKB"; } }

        internal AKBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BRANCH = new Lazy<Dictionary<string, AKB>>(() => this.ToDictionary(i => i.BRANCH));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKB" /> fields for each CSV column header</returns>
        protected override Action<AKB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BRANCH":
                        mapper[i] = (e, v) => e.BRANCH = v;
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
        /// Merges <see cref="AKB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKB" /> items to added or update the base <see cref="AKB" /> items</param>
        /// <returns>A merged list of <see cref="AKB" /> items</returns>
        protected override List<AKB> ApplyDeltaItems(List<AKB> Items, List<AKB> DeltaItems)
        {
            Dictionary<string, int> Index_BRANCH = Items.ToIndexDictionary(i => i.BRANCH);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKB deltaItem in DeltaItems)
            {
                int index;

                if (Index_BRANCH.TryGetValue(deltaItem.BRANCH, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.BRANCH)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, AKB>> Index_BRANCH;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKB by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AKB</param>
        /// <returns>Related AKB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKB FindByBRANCH(string BRANCH)
        {
            return Index_BRANCH.Value[BRANCH];
        }

        /// <summary>
        /// Attempt to find AKB by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AKB</param>
        /// <param name="Value">Related AKB entity</param>
        /// <returns>True if the related AKB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBRANCH(string BRANCH, out AKB Value)
        {
            return Index_BRANCH.Value.TryGetValue(BRANCH, out Value);
        }

        /// <summary>
        /// Attempt to find AKB by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AKB</param>
        /// <returns>Related AKB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKB TryFindByBRANCH(string BRANCH)
        {
            AKB value;
            if (Index_BRANCH.Value.TryGetValue(BRANCH, out value))
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
