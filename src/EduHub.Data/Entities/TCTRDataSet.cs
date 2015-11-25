using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Replacements Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTRDataSet : SetBase<TCTR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTR"; } }

        internal TCTRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCTRKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>>(() => this.ToGroupedDictionary(i => i.TCTRKEY));
            Index_TID = new Lazy<Dictionary<int, TCTR>>(() => this.ToDictionary(i => i.TID));
            Index_TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TCTR>>>(() => this.ToGroupedNullDictionary(i => i.TEACH));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTR>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTR" /> fields for each CSV column header</returns>
        protected override Action<TCTR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTRKEY":
                        mapper[i] = (e, v) => e.TCTRKEY = DateTime.Parse(v);
                        break;
                    case "TCTQ_TID":
                        mapper[i] = (e, v) => e.TCTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "COMMENT_R":
                        mapper[i] = (e, v) => e.COMMENT_R = v;
                        break;
                    case "COUNT_EXTRAS":
                        mapper[i] = (e, v) => e.COUNT_EXTRAS = v;
                        break;
                    case "EXTRAS_VALUE":
                        mapper[i] = (e, v) => e.EXTRAS_VALUE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABSENTEE_TID":
                        mapper[i] = (e, v) => e.ABSENTEE_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER_CLASH":
                        mapper[i] = (e, v) => e.TEACHER_CLASH = v;
                        break;
                    case "ROOM_CLASH":
                        mapper[i] = (e, v) => e.ROOM_CLASH = v;
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

        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>> Index_TCTRKEY;
        private Lazy<Dictionary<int, TCTR>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTR>>> Index_TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTR>>> Index_ROOM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByTCTRKEY(DateTime TCTRKEY)
        {
            return Index_TCTRKEY.Value[TCTRKEY];
        }

        /// <summary>
        /// Attempt to find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTRKEY(DateTime TCTRKEY, out IReadOnlyList<TCTR> Value)
        {
            return Index_TCTRKEY.Value.TryGetValue(TCTRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByTCTRKEY(DateTime TCTRKEY)
        {
            IReadOnlyList<TCTR> value;
            if (Index_TCTRKEY.Value.TryGetValue(TCTRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <returns>Related TCTR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <param name="Value">Related TCTR entity</param>
        /// <returns>True if the related TCTR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <returns>Related TCTR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTR TryFindByTID(int TID)
        {
            TCTR value;
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
        /// Find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<TCTR> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<TCTR> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TCTR> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TCTR> value;
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
