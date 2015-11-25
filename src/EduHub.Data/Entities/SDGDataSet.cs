using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fee Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDGDataSet : SetBase<SDG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDG"; } }

        internal SDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SDGKEY = new Lazy<Dictionary<string, SDG>>(() => this.ToDictionary(i => i.SDGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDG" /> fields for each CSV column header</returns>
        protected override Action<SDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDGKEY":
                        mapper[i] = (e, v) => e.SDGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MEMBER_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_TYPE = v;
                        break;
                    case "SDG_MEMO":
                        mapper[i] = (e, v) => e.SDG_MEMO = v;
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
        /// Merges <see cref="SDG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDG" /> items to added or update the base <see cref="SDG" /> items</param>
        /// <returns>A merged list of <see cref="SDG" /> items</returns>
        protected override List<SDG> ApplyDeltaItems(List<SDG> Items, List<SDG> DeltaItems)
        {
            Dictionary<string, int> Index_SDGKEY = Items.ToIndexDictionary(i => i.SDGKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SDGKEY.TryGetValue(deltaItem.SDGKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SDGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SDG>> Index_SDGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDG FindBySDGKEY(string SDGKEY)
        {
            return Index_SDGKEY.Value[SDGKEY];
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <param name="Value">Related SDG entity</param>
        /// <returns>True if the related SDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDGKEY(string SDGKEY, out SDG Value)
        {
            return Index_SDGKEY.Value.TryGetValue(SDGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDG TryFindBySDGKEY(string SDGKEY)
        {
            SDG value;
            if (Index_SDGKEY.Value.TryGetValue(SDGKEY, out value))
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
