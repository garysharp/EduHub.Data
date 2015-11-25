using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLGDataSet : SetBase<PLG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLG"; } }

        internal PLGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_GROUP = new Lazy<Dictionary<string, PLG>>(() => this.ToDictionary(i => i.LEAVE_GROUP));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLG" /> fields for each CSV column header</returns>
        protected override Action<PLG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_GROUP_DESC":
                        mapper[i] = (e, v) => e.LEAVE_GROUP_DESC = v;
                        break;
                    case "WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.WEEKLY_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DAILY_HOURS":
                        mapper[i] = (e, v) => e.DAILY_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="PLG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PLG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PLG" /> items to added or update the base <see cref="PLG" /> items</param>
        /// <returns>A merged list of <see cref="PLG" /> items</returns>
        protected override List<PLG> ApplyDeltaItems(List<PLG> Items, List<PLG> DeltaItems)
        {
            Dictionary<string, int> Index_LEAVE_GROUP = Items.ToIndexDictionary(i => i.LEAVE_GROUP);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PLG deltaItem in DeltaItems)
            {
                int index;

                if (Index_LEAVE_GROUP.TryGetValue(deltaItem.LEAVE_GROUP, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.LEAVE_GROUP)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, PLG>> Index_LEAVE_GROUP;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLG FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <param name="Value">Related PLG entity</param>
        /// <returns>True if the related PLG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out PLG Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLG TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            PLG value;
            if (Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out value))
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
