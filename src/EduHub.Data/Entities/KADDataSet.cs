using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Delivery Addresses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KADDataSet : SetBase<KAD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAD"; } }

        internal KADDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KADKEY = new Lazy<Dictionary<string, KAD>>(() => this.ToDictionary(i => i.KADKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAD" /> fields for each CSV column header</returns>
        protected override Action<KAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADKEY":
                        mapper[i] = (e, v) => e.KADKEY = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
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
        /// Merges <see cref="KAD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KAD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KAD" /> items to added or update the base <see cref="KAD" /> items</param>
        /// <returns>A merged list of <see cref="KAD" /> items</returns>
        protected override List<KAD> ApplyDeltaItems(List<KAD> Items, List<KAD> DeltaItems)
        {
            Dictionary<string, int> Index_KADKEY = Items.ToIndexDictionary(i => i.KADKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KAD deltaItem in DeltaItems)
            {
                int index;

                if (Index_KADKEY.TryGetValue(deltaItem.KADKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KADKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KAD>> Index_KADKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAD FindByKADKEY(string KADKEY)
        {
            return Index_KADKEY.Value[KADKEY];
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <param name="Value">Related KAD entity</param>
        /// <returns>True if the related KAD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKADKEY(string KADKEY, out KAD Value)
        {
            return Index_KADKEY.Value.TryGetValue(KADKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAD TryFindByKADKEY(string KADKEY)
        {
            KAD value;
            if (Index_KADKEY.Value.TryGetValue(KADKEY, out value))
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
