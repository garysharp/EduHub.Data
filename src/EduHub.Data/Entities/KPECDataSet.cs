using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPECDataSet : SetBase<KPEC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPEC"; } }

        internal KPECDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPECKEY = new Lazy<Dictionary<string, KPEC>>(() => this.ToDictionary(i => i.KPECKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPEC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPEC" /> fields for each CSV column header</returns>
        protected override Action<KPEC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPEC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPECKEY":
                        mapper[i] = (e, v) => e.KPECKEY = v;
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
        /// Merges <see cref="KPEC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPEC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPEC" /> items to added or update the base <see cref="KPEC" /> items</param>
        /// <returns>A merged list of <see cref="KPEC" /> items</returns>
        protected override List<KPEC> ApplyDeltaItems(List<KPEC> Items, List<KPEC> DeltaItems)
        {
            Dictionary<string, int> Index_KPECKEY = Items.ToIndexDictionary(i => i.KPECKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPEC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KPECKEY.TryGetValue(deltaItem.KPECKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KPECKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KPEC>> Index_KPECKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPEC by KPECKEY field
        /// </summary>
        /// <param name="KPECKEY">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPEC FindByKPECKEY(string KPECKEY)
        {
            return Index_KPECKEY.Value[KPECKEY];
        }

        /// <summary>
        /// Attempt to find KPEC by KPECKEY field
        /// </summary>
        /// <param name="KPECKEY">KPECKEY value used to find KPEC</param>
        /// <param name="Value">Related KPEC entity</param>
        /// <returns>True if the related KPEC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPECKEY(string KPECKEY, out KPEC Value)
        {
            return Index_KPECKEY.Value.TryGetValue(KPECKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPEC by KPECKEY field
        /// </summary>
        /// <param name="KPECKEY">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPEC TryFindByKPECKEY(string KPECKEY)
        {
            KPEC value;
            if (Index_KPECKEY.Value.TryGetValue(KPECKEY, out value))
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
