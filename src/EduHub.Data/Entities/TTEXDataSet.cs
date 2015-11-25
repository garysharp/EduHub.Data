using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Grid Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEXDataSet : SetBase<TTEX>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEX"; } }

        internal TTEXDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEX>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEX>>(() => this.ToDictionary(i => i.TID));
            Index_EXAM_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTEX>>>(() => this.ToGroupedNullDictionary(i => i.EXAM_ROOM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEX" /> fields for each CSV column header</returns>
        protected override Action<TTEX, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTES_TID":
                        mapper[i] = (e, v) => e.TTES_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXAM_ROW":
                        mapper[i] = (e, v) => e.EXAM_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_COL":
                        mapper[i] = (e, v) => e.EXAM_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_ROW":
                        mapper[i] = (e, v) => e.EXAM_FIX_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_COL":
                        mapper[i] = (e, v) => e.EXAM_FIX_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_ROOM":
                        mapper[i] = (e, v) => e.EXAM_ROOM = v;
                        break;
                    case "EXAM_DESCRIPTION":
                        mapper[i] = (e, v) => e.EXAM_DESCRIPTION = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<TTEX>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEX>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<TTEX>>> Index_EXAM_ROOM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <returns>List of related TTEX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <param name="Value">List of related TTEX entities</param>
        /// <returns>True if the list of related TTEX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEX> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <returns>List of related TTEX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEX> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <returns>Related TTEX entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEX FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <param name="Value">Related TTEX entity</param>
        /// <returns>True if the related TTEX entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEX Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <returns>Related TTEX entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEX TryFindByTID(int TID)
        {
            TTEX value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <returns>List of related TTEX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> FindByEXAM_ROOM(string EXAM_ROOM)
        {
            return Index_EXAM_ROOM.Value[EXAM_ROOM];
        }

        /// <summary>
        /// Attempt to find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <param name="Value">List of related TTEX entities</param>
        /// <returns>True if the list of related TTEX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXAM_ROOM(string EXAM_ROOM, out IReadOnlyList<TTEX> Value)
        {
            return Index_EXAM_ROOM.Value.TryGetValue(EXAM_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <returns>List of related TTEX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> TryFindByEXAM_ROOM(string EXAM_ROOM)
        {
            IReadOnlyList<TTEX> value;
            if (Index_EXAM_ROOM.Value.TryGetValue(EXAM_ROOM, out value))
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
