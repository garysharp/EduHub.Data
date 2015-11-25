using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Daily Attendance Records Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXHGDataSet : SetBase<TXHG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TXHG"; } }

        internal TXHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TXHG_ID = new Lazy<Dictionary<int, TXHG>>(() => this.ToDictionary(i => i.TXHG_ID));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<TXHG>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_HOME_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<TXHG>>>(() => this.ToGroupedNullDictionary(i => i.HOME_GROUP));
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

        #region Index Fields

        private Lazy<Dictionary<int, TXHG>> Index_TXHG_ID;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<TXHG>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<TXHG>>> Index_HOME_GROUP;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXHG FindByTXHG_ID(int TXHG_ID)
        {
            return Index_TXHG_ID.Value[TXHG_ID];
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <param name="Value">Related TXHG entity</param>
        /// <returns>True if the related TXHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTXHG_ID(int TXHG_ID, out TXHG Value)
        {
            return Index_TXHG_ID.Value.TryGetValue(TXHG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID field
        /// </summary>
        /// <param name="TXHG_ID">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXHG TryFindByTXHG_ID(int TXHG_ID)
        {
            TXHG value;
            if (Index_TXHG_ID.Value.TryGetValue(TXHG_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <returns>List of related TXHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <param name="Value">List of related TXHG entities</param>
        /// <returns>True if the list of related TXHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<TXHG> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXHG</param>
        /// <returns>List of related TXHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<TXHG> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <returns>List of related TXHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> FindByHOME_GROUP(string HOME_GROUP)
        {
            return Index_HOME_GROUP.Value[HOME_GROUP];
        }

        /// <summary>
        /// Attempt to find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <param name="Value">List of related TXHG entities</param>
        /// <returns>True if the list of related TXHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_GROUP(string HOME_GROUP, out IReadOnlyList<TXHG> Value)
        {
            return Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by HOME_GROUP field
        /// </summary>
        /// <param name="HOME_GROUP">HOME_GROUP value used to find TXHG</param>
        /// <returns>List of related TXHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXHG> TryFindByHOME_GROUP(string HOME_GROUP)
        {
            IReadOnlyList<TXHG> value;
            if (Index_HOME_GROUP.Value.TryGetValue(HOME_GROUP, out value))
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
