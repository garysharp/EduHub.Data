using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCDataSet : SetBase<TC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TC"; } }

        internal TCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCKEY = new Lazy<Dictionary<DateTime, TC>>(() => this.ToDictionary(i => i.TCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TC" /> fields for each CSV column header</returns>
        protected override Action<TC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCKEY":
                        mapper[i] = (e, v) => e.TCKEY = DateTime.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DAY_COMMENT":
                        mapper[i] = (e, v) => e.DAY_COMMENT = v;
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
        /// Merges <see cref="TC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TC" /> items to added or update the base <see cref="TC" /> items</param>
        /// <returns>A merged list of <see cref="TC" /> items</returns>
        protected override List<TC> ApplyDeltaItems(List<TC> Items, List<TC> DeltaItems)
        {
            Dictionary<DateTime, int> Index_TCKEY = Items.ToIndexDictionary(i => i.TCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TC deltaItem in DeltaItems)
            {
                int index;

                if (Index_TCKEY.TryGetValue(deltaItem.TCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<DateTime, TC>> Index_TCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <returns>Related TC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TC FindByTCKEY(DateTime TCKEY)
        {
            return Index_TCKEY.Value[TCKEY];
        }

        /// <summary>
        /// Attempt to find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <param name="Value">Related TC entity</param>
        /// <returns>True if the related TC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCKEY(DateTime TCKEY, out TC Value)
        {
            return Index_TCKEY.Value.TryGetValue(TCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TC by TCKEY field
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TC</param>
        /// <returns>Related TC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TC TryFindByTCKEY(DateTime TCKEY)
        {
            TC value;
            if (Index_TCKEY.Value.TryGetValue(TCKEY, out value))
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
