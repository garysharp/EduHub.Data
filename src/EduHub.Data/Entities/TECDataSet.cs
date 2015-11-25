using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TECDataSet : SetBase<TEC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TEC"; } }

        internal TECDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CATEGORY = new Lazy<Dictionary<string, TEC>>(() => this.ToDictionary(i => i.CATEGORY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TEC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TEC" /> fields for each CSV column header</returns>
        protected override Action<TEC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TEC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
        /// Merges <see cref="TEC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TEC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TEC" /> items to added or update the base <see cref="TEC" /> items</param>
        /// <returns>A merged list of <see cref="TEC" /> items</returns>
        protected override List<TEC> ApplyDeltaItems(List<TEC> Items, List<TEC> DeltaItems)
        {
            Dictionary<string, int> Index_CATEGORY = Items.ToIndexDictionary(i => i.CATEGORY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TEC deltaItem in DeltaItems)
            {
                int index;

                if (Index_CATEGORY.TryGetValue(deltaItem.CATEGORY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CATEGORY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, TEC>> Index_CATEGORY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TEC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TEC</param>
        /// <returns>Related TEC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TEC FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find TEC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TEC</param>
        /// <param name="Value">Related TEC entity</param>
        /// <returns>True if the related TEC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out TEC Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find TEC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TEC</param>
        /// <returns>Related TEC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TEC TryFindByCATEGORY(string CATEGORY)
        {
            TEC value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
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
