using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTBDataSet : SetBase<TCTB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTB"; } }

        internal TCTBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ABSENCE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.ABSENCE_TYPE));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_TCTBKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTB>>>(() => this.ToGroupedDictionary(i => i.TCTBKEY));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<TCTB>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TID = new Lazy<Dictionary<int, TCTB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTB" /> fields for each CSV column header</returns>
        protected override Action<TCTB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTBKEY":
                        mapper[i] = (e, v) => e.TCTBKEY = DateTime.Parse(v);
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TEACHER_AVAILABLE":
                        mapper[i] = (e, v) => e.TEACHER_AVAILABLE = v;
                        break;
                    case "ROOM_AVAILABLE":
                        mapper[i] = (e, v) => e.ROOM_AVAILABLE = v;
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "COMMENT_A":
                        mapper[i] = (e, v) => e.COMMENT_A = v;
                        break;
                    case "ABSENCE_TYPE":
                        mapper[i] = (e, v) => e.ABSENCE_TYPE = v;
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

        /// <summary>
        /// Merges <see cref="TCTB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TCTB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TCTB" /> items to added or update the base <see cref="TCTB" /> items</param>
        /// <returns>A merged list of <see cref="TCTB" /> items</returns>
        protected override List<TCTB> ApplyDeltaItems(List<TCTB> Items, List<TCTB> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TCTB deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TCTBKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_ABSENCE_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_SUBJ;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTB>>> Index_TCTBKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTB>>> Index_TEACHER;
        private Lazy<Dictionary<int, TCTB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTB by ABSENCE_TYPE field
        /// </summary>
        /// <param name="ABSENCE_TYPE">ABSENCE_TYPE value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByABSENCE_TYPE(string ABSENCE_TYPE)
        {
            return Index_ABSENCE_TYPE.Value[ABSENCE_TYPE];
        }

        /// <summary>
        /// Attempt to find TCTB by ABSENCE_TYPE field
        /// </summary>
        /// <param name="ABSENCE_TYPE">ABSENCE_TYPE value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABSENCE_TYPE(string ABSENCE_TYPE, out IReadOnlyList<TCTB> Value)
        {
            return Index_ABSENCE_TYPE.Value.TryGetValue(ABSENCE_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by ABSENCE_TYPE field
        /// </summary>
        /// <param name="ABSENCE_TYPE">ABSENCE_TYPE value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByABSENCE_TYPE(string ABSENCE_TYPE)
        {
            IReadOnlyList<TCTB> value;
            if (Index_ABSENCE_TYPE.Value.TryGetValue(ABSENCE_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TCTB by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TCTB> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TCTB> value;
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
        /// Find TCTB by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TCTB by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TCTB> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TCTB> value;
            if (Index_SUBJ.Value.TryGetValue(SUBJ, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by TCTBKEY field
        /// </summary>
        /// <param name="TCTBKEY">TCTBKEY value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByTCTBKEY(DateTime TCTBKEY)
        {
            return Index_TCTBKEY.Value[TCTBKEY];
        }

        /// <summary>
        /// Attempt to find TCTB by TCTBKEY field
        /// </summary>
        /// <param name="TCTBKEY">TCTBKEY value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTBKEY(DateTime TCTBKEY, out IReadOnlyList<TCTB> Value)
        {
            return Index_TCTBKEY.Value.TryGetValue(TCTBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by TCTBKEY field
        /// </summary>
        /// <param name="TCTBKEY">TCTBKEY value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByTCTBKEY(DateTime TCTBKEY)
        {
            IReadOnlyList<TCTB> value;
            if (Index_TCTBKEY.Value.TryGetValue(TCTBKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TCTB</param>
        /// <returns>List of related TCTB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find TCTB by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TCTB</param>
        /// <param name="Value">List of related TCTB entities</param>
        /// <returns>True if the list of related TCTB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<TCTB> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TCTB</param>
        /// <returns>List of related TCTB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTB> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<TCTB> value;
            if (Index_TEACHER.Value.TryGetValue(TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTB</param>
        /// <returns>Related TCTB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTB</param>
        /// <param name="Value">Related TCTB entity</param>
        /// <returns>True if the related TCTB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTB</param>
        /// <returns>Related TCTB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTB TryFindByTID(int TID)
        {
            TCTB value;
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
