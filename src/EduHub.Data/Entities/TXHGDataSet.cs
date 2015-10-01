using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Daily Attendance Records Data Set
    /// </summary>
    public sealed class TXHGDataSet : SetBase<TXHG>
    {
        private Lazy<Dictionary<int, TXHG>> TXHG_IDIndex;

        internal TXHGDataSet(EduHubContext Context)
            : base(Context)
        {
            TXHG_IDIndex = new Lazy<Dictionary<int, TXHG>>(() => this.ToDictionary(e => e.TXHG_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TXHG"; } }

        /// <summary>
        /// Find TXHG by TXHG_ID key field
        /// </summary>
        /// <param name="Key">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TXHG_ID value didn't match any TXHG entities</exception>
        public TXHG FindByTXHG_ID(int Key)
        {
            TXHG result;
            if (TXHG_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID key field
        /// </summary>
        /// <param name="Key">TXHG_ID value used to find TXHG</param>
        /// <param name="Value">Related TXHG entity</param>
        /// <returns>True if the TXHG entity is found</returns>
        public bool TryFindByTXHG_ID(int Key, out TXHG Value)
        {
            return TXHG_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID key field
        /// </summary>
        /// <param name="Key">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity, or null if not found</returns>
        public TXHG TryFindByTXHG_ID(int Key)
        {
            TXHG result;
            if (TXHG_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TXHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TXHG" /> fields for each CSV column header</returns>
        protected override Action<TXHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TXHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TXHG_ID":
                        mapper[i] = (e, v) => e.TXHG_ID = int.Parse(v);
                        break;
                    case "TXHG_DATE":
                        mapper[i] = (e, v) => e.TXHG_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "AM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.AM_ROLL_MARKED = v;
                        break;
                    case "PM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.PM_ROLL_MARKED = v;
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
