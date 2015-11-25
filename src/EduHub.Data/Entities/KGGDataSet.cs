using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGGDataSet : SetBase<KGG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGG"; } }

        internal KGGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGGKEY = new Lazy<Dictionary<string, KGG>>(() => this.ToDictionary(i => i.KGGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGG" /> fields for each CSV column header</returns>
        protected override Action<KGG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGGKEY":
                        mapper[i] = (e, v) => e.KGGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "EDFLAG_ORDER":
                        mapper[i] = (e, v) => e.EDFLAG_ORDER = v;
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
        /// Merges <see cref="KGG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGG" /> items to added or update the base <see cref="KGG" /> items</param>
        /// <returns>A merged list of <see cref="KGG" /> items</returns>
        protected override List<KGG> ApplyDeltaItems(List<KGG> Items, List<KGG> DeltaItems)
        {
            Dictionary<string, int> Index_KGGKEY = Items.ToIndexDictionary(i => i.KGGKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGG deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGGKEY.TryGetValue(deltaItem.KGGKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGG>> Index_KGGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGG FindByKGGKEY(string KGGKEY)
        {
            return Index_KGGKEY.Value[KGGKEY];
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <param name="Value">Related KGG entity</param>
        /// <returns>True if the related KGG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGGKEY(string KGGKEY, out KGG Value)
        {
            return Index_KGGKEY.Value.TryGetValue(KGGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY field
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGG TryFindByKGGKEY(string KGGKEY)
        {
            KGG value;
            if (Index_KGGKEY.Value.TryGetValue(KGGKEY, out value))
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
