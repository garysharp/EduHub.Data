using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Note Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPNDataSet : SetBase<KPN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPN"; } }

        internal KPNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPNKEY = new Lazy<Dictionary<string, KPN>>(() => this.ToDictionary(i => i.KPNKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPN" /> fields for each CSV column header</returns>
        protected override Action<KPN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPNKEY":
                        mapper[i] = (e, v) => e.KPNKEY = v;
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
        /// Merges <see cref="KPN" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPN" /> items to added or update the base <see cref="KPN" /> items</param>
        /// <returns>A merged list of <see cref="KPN" /> items</returns>
        protected override List<KPN> ApplyDeltaItems(List<KPN> Items, List<KPN> DeltaItems)
        {
            Dictionary<string, int> Index_KPNKEY = Items.ToIndexDictionary(i => i.KPNKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPN deltaItem in DeltaItems)
            {
                int index;

                if (Index_KPNKEY.TryGetValue(deltaItem.KPNKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KPNKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KPN>> Index_KPNKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPN by KPNKEY field
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPN FindByKPNKEY(string KPNKEY)
        {
            return Index_KPNKEY.Value[KPNKEY];
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY field
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find KPN</param>
        /// <param name="Value">Related KPN entity</param>
        /// <returns>True if the related KPN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPNKEY(string KPNKEY, out KPN Value)
        {
            return Index_KPNKEY.Value.TryGetValue(KPNKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY field
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPN TryFindByKPNKEY(string KPNKEY)
        {
            KPN value;
            if (Index_KPNKEY.Value.TryGetValue(KPNKEY, out value))
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
