using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SP2 dummy table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBUDGDataSet : SetBase<GLFBUDG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLFBUDG"; } }

        internal GLFBUDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKEY = new Lazy<Dictionary<string, IReadOnlyList<GLFBUDG>>>(() => this.ToGroupedDictionary(i => i.BKEY));
            Index_TID = new Lazy<Dictionary<int, GLFBUDG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLFBUDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLFBUDG" /> fields for each CSV column header</returns>
        protected override Action<GLFBUDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLFBUDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BKEY":
                        mapper[i] = (e, v) => e.BKEY = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<GLFBUDG>>> Index_BKEY;
        private Lazy<Dictionary<int, GLFBUDG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <returns>List of related GLFBUDG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBUDG> FindByBKEY(string BKEY)
        {
            return Index_BKEY.Value[BKEY];
        }

        /// <summary>
        /// Attempt to find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <param name="Value">List of related GLFBUDG entities</param>
        /// <returns>True if the list of related GLFBUDG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKEY(string BKEY, out IReadOnlyList<GLFBUDG> Value)
        {
            return Index_BKEY.Value.TryGetValue(BKEY, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <returns>List of related GLFBUDG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBUDG> TryFindByBKEY(string BKEY)
        {
            IReadOnlyList<GLFBUDG> value;
            if (Index_BKEY.Value.TryGetValue(BKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <returns>Related GLFBUDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBUDG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <param name="Value">Related GLFBUDG entity</param>
        /// <returns>True if the related GLFBUDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLFBUDG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <returns>Related GLFBUDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBUDG TryFindByTID(int TID)
        {
            GLFBUDG value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
