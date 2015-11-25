using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religious Instruction Curricula Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCIDataSet : SetBase<KCI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCI"; } }

        internal KCIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCIKEY = new Lazy<Dictionary<string, KCI>>(() => this.ToDictionary(i => i.KCIKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCI" /> fields for each CSV column header</returns>
        protected override Action<KCI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCIKEY":
                        mapper[i] = (e, v) => e.KCIKEY = v;
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
        /// Merges <see cref="KCI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCI" /> items to added or update the base <see cref="KCI" /> items</param>
        /// <returns>A merged list of <see cref="KCI" /> items</returns>
        protected override List<KCI> ApplyDeltaItems(List<KCI> Items, List<KCI> DeltaItems)
        {
            Dictionary<string, int> Index_KCIKEY = Items.ToIndexDictionary(i => i.KCIKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCI deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCIKEY.TryGetValue(deltaItem.KCIKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCI>> Index_KCIKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCI by KCIKEY field
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCI FindByKCIKEY(string KCIKEY)
        {
            return Index_KCIKEY.Value[KCIKEY];
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY field
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find KCI</param>
        /// <param name="Value">Related KCI entity</param>
        /// <returns>True if the related KCI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCIKEY(string KCIKEY, out KCI Value)
        {
            return Index_KCIKEY.Value.TryGetValue(KCIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY field
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCI TryFindByKCIKEY(string KCIKEY)
        {
            KCI value;
            if (Index_KCIKEY.Value.TryGetValue(KCIKEY, out value))
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
