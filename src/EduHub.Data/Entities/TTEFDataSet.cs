using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Staff Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEFDataSet : SetBase<TTEF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEF"; } }

        internal TTEFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEF>>(() => this.ToDictionary(i => i.TID));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEF" /> fields for each CSV column header</returns>
        protected override Action<TTEF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEP_TID":
                        mapper[i] = (e, v) => e.TTEP_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<TTEF>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<TTEF>>> Index_STAFF;
        private Lazy<NullDictionary<string, IReadOnlyList<TTEF>>> Index_ROOM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEF> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEF> value;
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
        /// Find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <returns>Related TTEF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <param name="Value">Related TTEF entity</param>
        /// <returns>True if the related TTEF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <returns>Related TTEF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEF TryFindByTID(int TID)
        {
            TTEF value;
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
        /// Find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<TTEF> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<TTEF> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TTEF> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TTEF> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
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
