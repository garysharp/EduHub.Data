using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMDataSet : SetBase<SM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SM"; } }

        internal SMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROOM = new Lazy<Dictionary<string, SM>>(() => this.ToDictionary(i => i.ROOM));
            Index_FACULTY = new Lazy<NullDictionary<string, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_STAFF_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.STAFF_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SM" /> fields for each CSV column header</returns>
        protected override Action<SM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SEATING":
                        mapper[i] = (e, v) => e.SEATING = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "AREA_CODE":
                        mapper[i] = (e, v) => e.AREA_CODE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STAFF_CODE":
                        mapper[i] = (e, v) => e.STAFF_CODE = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "BOARD":
                        mapper[i] = (e, v) => e.BOARD = v;
                        break;
                    case "BLACKOUT":
                        mapper[i] = (e, v) => e.BLACKOUT = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
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

        private Lazy<Dictionary<string, SM>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<SM>>> Index_FACULTY;
        private Lazy<NullDictionary<int?, IReadOnlyList<SM>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SM>>> Index_STAFF_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <returns>Related SM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SM FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <param name="Value">Related SM entity</param>
        /// <returns>True if the related SM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out SM Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <returns>Related SM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SM TryFindByROOM(string ROOM)
        {
            SM value;
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
        /// Find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindByFACULTY(string FACULTY)
        {
            return Index_FACULTY.Value[FACULTY];
        }

        /// <summary>
        /// Attempt to find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY(string FACULTY, out IReadOnlyList<SM> Value)
        {
            return Index_FACULTY.Value.TryGetValue(FACULTY, out Value);
        }

        /// <summary>
        /// Attempt to find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindByFACULTY(string FACULTY)
        {
            IReadOnlyList<SM> value;
            if (Index_FACULTY.Value.TryGetValue(FACULTY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SM> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SM> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindBySTAFF_CODE(string STAFF_CODE)
        {
            return Index_STAFF_CODE.Value[STAFF_CODE];
        }

        /// <summary>
        /// Attempt to find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF_CODE(string STAFF_CODE, out IReadOnlyList<SM> Value)
        {
            return Index_STAFF_CODE.Value.TryGetValue(STAFF_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindBySTAFF_CODE(string STAFF_CODE)
        {
            IReadOnlyList<SM> value;
            if (Index_STAFF_CODE.Value.TryGetValue(STAFF_CODE, out value))
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
