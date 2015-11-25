using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Initiatives Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLINITDataSet : SetBase<KGLINIT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLINIT"; } }

        internal KGLINITDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INITIATIVE = new Lazy<Dictionary<string, KGLINIT>>(() => this.ToDictionary(i => i.INITIATIVE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLINIT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLINIT" /> fields for each CSV column header</returns>
        protected override Action<KGLINIT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLINIT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KGLINIT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGLINIT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGLINIT" /> items to added or update the base <see cref="KGLINIT" /> items</param>
        /// <returns>A merged list of <see cref="KGLINIT" /> items</returns>
        protected override List<KGLINIT> ApplyDeltaItems(List<KGLINIT> Items, List<KGLINIT> DeltaItems)
        {
            Dictionary<string, int> Index_INITIATIVE = Items.ToIndexDictionary(i => i.INITIATIVE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGLINIT deltaItem in DeltaItems)
            {
                int index;

                if (Index_INITIATIVE.TryGetValue(deltaItem.INITIATIVE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.INITIATIVE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGLINIT>> Index_INITIATIVE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLINIT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLINIT FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find KGLINIT</param>
        /// <param name="Value">Related KGLINIT entity</param>
        /// <returns>True if the related KGLINIT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out KGLINIT Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLINIT TryFindByINITIATIVE(string INITIATIVE)
        {
            KGLINIT value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
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
