using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availablity Extras Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMAVDataSet : SetBase<SMAV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMAV"; } }

        internal SMAVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROOM = new Lazy<Dictionary<string, IReadOnlyList<SMAV>>>(() => this.ToGroupedDictionary(i => i.ROOM));
            Index_TID = new Lazy<Dictionary<int, SMAV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMAV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMAV" /> fields for each CSV column header</returns>
        protected override Action<SMAV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMAV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AVAILABLE_DATE":
                        mapper[i] = (e, v) => e.AVAILABLE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<SMAV>>> Index_ROOM;
        private Lazy<Dictionary<int, SMAV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <returns>List of related SMAV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAV> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <param name="Value">List of related SMAV entities</param>
        /// <returns>True if the list of related SMAV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SMAV> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <returns>List of related SMAV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAV> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SMAV> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <returns>Related SMAV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <param name="Value">Related SMAV entity</param>
        /// <returns>True if the related SMAV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMAV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <returns>Related SMAV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAV TryFindByTID(int TID)
        {
            SMAV value;
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
