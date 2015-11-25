using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDODataSet : SetBase<KDO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDO"; } }

        internal KDODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KDOKEY = new Lazy<Dictionary<string, KDO>>(() => this.ToDictionary(i => i.KDOKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDO" /> fields for each CSV column header</returns>
        protected override Action<KDO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AUSVELS_START":
                        mapper[i] = (e, v) => e.AUSVELS_START = v;
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
        /// Merges <see cref="KDO" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KDO" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KDO" /> items to added or update the base <see cref="KDO" /> items</param>
        /// <returns>A merged list of <see cref="KDO" /> items</returns>
        protected override List<KDO> ApplyDeltaItems(List<KDO> Items, List<KDO> DeltaItems)
        {
            Dictionary<string, int> Index_KDOKEY = Items.ToIndexDictionary(i => i.KDOKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KDO deltaItem in DeltaItems)
            {
                int index;

                if (Index_KDOKEY.TryGetValue(deltaItem.KDOKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KDOKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KDO>> Index_KDOKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDO FindByKDOKEY(string KDOKEY)
        {
            return Index_KDOKEY.Value[KDOKEY];
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <param name="Value">Related KDO entity</param>
        /// <returns>True if the related KDO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKDOKEY(string KDOKEY, out KDO Value)
        {
            return Index_KDOKEY.Value.TryGetValue(KDOKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY field
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDO TryFindByKDOKEY(string KDOKEY)
        {
            KDO value;
            if (Index_KDOKEY.Value.TryGetValue(KDOKEY, out value))
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
