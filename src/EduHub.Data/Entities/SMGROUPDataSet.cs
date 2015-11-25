using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMGROUPDataSet : SetBase<SMGROUP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMGROUP"; } }

        internal SMGROUPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GROUPKEY = new Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>>(() => this.ToGroupedDictionary(i => i.GROUPKEY));
            Index_TID = new Lazy<Dictionary<int, SMGROUP>>(() => this.ToDictionary(i => i.TID));
            Index_GROUPKEY_ROOM = new Lazy<Dictionary<Tuple<string, string>, SMGROUP>>(() => this.ToDictionary(i => Tuple.Create(i.GROUPKEY, i.ROOM)));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SMGROUP>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMGROUP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMGROUP" /> fields for each CSV column header</returns>
        protected override Action<SMGROUP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMGROUP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GROUPKEY":
                        mapper[i] = (e, v) => e.GROUPKEY = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>> Index_GROUPKEY;
        private Lazy<Dictionary<int, SMGROUP>> Index_TID;
        private Lazy<Dictionary<Tuple<string, string>, SMGROUP>> Index_GROUPKEY_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<SMGROUP>>> Index_ROOM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> FindByGROUPKEY(string GROUPKEY)
        {
            return Index_GROUPKEY.Value[GROUPKEY];
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="Value">List of related SMGROUP entities</param>
        /// <returns>True if the list of related SMGROUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGROUPKEY(string GROUPKEY, out IReadOnlyList<SMGROUP> Value)
        {
            return Index_GROUPKEY.Value.TryGetValue(GROUPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> TryFindByGROUPKEY(string GROUPKEY)
        {
            IReadOnlyList<SMGROUP> value;
            if (Index_GROUPKEY.Value.TryGetValue(GROUPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <param name="Value">Related SMGROUP entity</param>
        /// <returns>True if the related SMGROUP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMGROUP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP TryFindByTID(int TID)
        {
            SMGROUP value;
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
        /// Find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP FindByGROUPKEY_ROOM(string GROUPKEY, string ROOM)
        {
            return Index_GROUPKEY_ROOM.Value[Tuple.Create(GROUPKEY, ROOM)];
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <param name="Value">Related SMGROUP entity</param>
        /// <returns>True if the related SMGROUP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGROUPKEY_ROOM(string GROUPKEY, string ROOM, out SMGROUP Value)
        {
            return Index_GROUPKEY_ROOM.Value.TryGetValue(Tuple.Create(GROUPKEY, ROOM), out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP TryFindByGROUPKEY_ROOM(string GROUPKEY, string ROOM)
        {
            SMGROUP value;
            if (Index_GROUPKEY_ROOM.Value.TryGetValue(Tuple.Create(GROUPKEY, ROOM), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <param name="Value">List of related SMGROUP entities</param>
        /// <returns>True if the list of related SMGROUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SMGROUP> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SMGROUP> value;
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
