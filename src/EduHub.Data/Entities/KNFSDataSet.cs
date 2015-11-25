using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family/Student ID Sequence Numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNFSDataSet : SetBase<KNFS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KNFS"; } }

        internal KNFSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KNFSKEY = new Lazy<Dictionary<string, KNFS>>(() => this.ToDictionary(i => i.KNFSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KNFS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KNFS" /> fields for each CSV column header</returns>
        protected override Action<KNFS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KNFS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KNFSKEY":
                        mapper[i] = (e, v) => e.KNFSKEY = v;
                        break;
                    case "NEXT_NUMBER":
                        mapper[i] = (e, v) => e.NEXT_NUMBER = v;
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
        /// Merges <see cref="KNFS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KNFS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KNFS" /> items to added or update the base <see cref="KNFS" /> items</param>
        /// <returns>A merged list of <see cref="KNFS" /> items</returns>
        protected override List<KNFS> ApplyDeltaItems(List<KNFS> Items, List<KNFS> DeltaItems)
        {
            Dictionary<string, int> Index_KNFSKEY = Items.ToIndexDictionary(i => i.KNFSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KNFS deltaItem in DeltaItems)
            {
                int index;

                if (Index_KNFSKEY.TryGetValue(deltaItem.KNFSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KNFSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KNFS>> Index_KNFSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNFS FindByKNFSKEY(string KNFSKEY)
        {
            return Index_KNFSKEY.Value[KNFSKEY];
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <param name="Value">Related KNFS entity</param>
        /// <returns>True if the related KNFS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKNFSKEY(string KNFSKEY, out KNFS Value)
        {
            return Index_KNFSKEY.Value.TryGetValue(KNFSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNFS TryFindByKNFSKEY(string KNFSKEY)
        {
            KNFS value;
            if (Index_KNFSKEY.Value.TryGetValue(KNFSKEY, out value))
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
