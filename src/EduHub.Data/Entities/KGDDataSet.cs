using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGDDataSet : SetBase<KGD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGD"; } }

        internal KGDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGDKEY = new Lazy<Dictionary<string, KGD>>(() => this.ToDictionary(i => i.KGDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGD" /> fields for each CSV column header</returns>
        protected override Action<KGD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGDKEY":
                        mapper[i] = (e, v) => e.KGDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KGD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGD" /> items to added or update the base <see cref="KGD" /> items</param>
        /// <returns>A merged list of <see cref="KGD" /> items</returns>
        protected override List<KGD> ApplyDeltaItems(List<KGD> Items, List<KGD> DeltaItems)
        {
            Dictionary<string, int> Index_KGDKEY = Items.ToIndexDictionary(i => i.KGDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGD deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGDKEY.TryGetValue(deltaItem.KGDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGD>> Index_KGDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGD FindByKGDKEY(string KGDKEY)
        {
            return Index_KGDKEY.Value[KGDKEY];
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <param name="Value">Related KGD entity</param>
        /// <returns>True if the related KGD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGDKEY(string KGDKEY, out KGD Value)
        {
            return Index_KGDKEY.Value.TryGetValue(KGDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY field
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGD TryFindByKGDKEY(string KGDKEY)
        {
            KGD value;
            if (Index_KGDKEY.Value.TryGetValue(KGDKEY, out value))
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
