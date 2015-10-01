using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group Data Set
    /// </summary>
    public sealed class PLGDataSet : SetBase<PLG>
    {
        private Lazy<Dictionary<string, PLG>> LEAVE_GROUPIndex;

        internal PLGDataSet(EduHubContext Context)
            : base(Context)
        {
            LEAVE_GROUPIndex = new Lazy<Dictionary<string, PLG>>(() => this.ToDictionary(e => e.LEAVE_GROUP));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLG"; } }

        /// <summary>
        /// Find PLG by LEAVE_GROUP key field
        /// </summary>
        /// <param name="Key">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">LEAVE_GROUP value didn't match any PLG entities</exception>
        public PLG FindByLEAVE_GROUP(string Key)
        {
            PLG result;
            if (LEAVE_GROUPIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP key field
        /// </summary>
        /// <param name="Key">LEAVE_GROUP value used to find PLG</param>
        /// <param name="Value">Related PLG entity</param>
        /// <returns>True if the PLG entity is found</returns>
        public bool TryFindByLEAVE_GROUP(string Key, out PLG Value)
        {
            return LEAVE_GROUPIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP key field
        /// </summary>
        /// <param name="Key">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity, or null if not found</returns>
        public PLG TryFindByLEAVE_GROUP(string Key)
        {
            PLG result;
            if (LEAVE_GROUPIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
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
    }
}
