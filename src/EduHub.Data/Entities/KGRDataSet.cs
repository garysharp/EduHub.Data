using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGRDataSet : SetBase<KGR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGR"; } }

        internal KGRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RELIGION = new Lazy<Dictionary<string, KGR>>(() => this.ToDictionary(i => i.RELIGION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGR" /> fields for each CSV column header</returns>
        protected override Action<KGR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
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
        /// Merges <see cref="KGR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGR" /> items to added or update the base <see cref="KGR" /> items</param>
        /// <returns>A merged list of <see cref="KGR" /> items</returns>
        protected override List<KGR> ApplyDeltaItems(List<KGR> Items, List<KGR> DeltaItems)
        {
            Dictionary<string, int> Index_RELIGION = Items.ToIndexDictionary(i => i.RELIGION);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGR deltaItem in DeltaItems)
            {
                int index;

                if (Index_RELIGION.TryGetValue(deltaItem.RELIGION, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.RELIGION)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGR>> Index_RELIGION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGR FindByRELIGION(string RELIGION)
        {
            return Index_RELIGION.Value[RELIGION];
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <param name="Value">Related KGR entity</param>
        /// <returns>True if the related KGR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRELIGION(string RELIGION, out KGR Value)
        {
            return Index_RELIGION.Value.TryGetValue(RELIGION, out Value);
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION field
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGR TryFindByRELIGION(string RELIGION)
        {
            KGR value;
            if (Index_RELIGION.Value.TryGetValue(RELIGION, out value))
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
