using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Actual Sessions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXASDataSet : SetBase<TXAS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TXAS"; } }

        internal TXASDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SCL_LINK = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.SCL_LINK));
            Index_SUBJECT = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TID = new Lazy<Dictionary<int, TXAS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TXAS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TXAS" /> fields for each CSV column header</returns>
        protected override Action<TXAS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TXAS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "THTQ_TID":
                        mapper[i] = (e, v) => e.THTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SESSION":
                        mapper[i] = (e, v) => e.CLASS_SESSION = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "PERIOD_NO":
                        mapper[i] = (e, v) => e.PERIOD_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_NO":
                        mapper[i] = (e, v) => e.DAY_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SESSION_DATE":
                        mapper[i] = (e, v) => e.SESSION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PERIOD_DESC":
                        mapper[i] = (e, v) => e.PERIOD_DESC = v;
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FINISH_TIME":
                        mapper[i] = (e, v) => e.FINISH_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROLL_MARKED":
                        mapper[i] = (e, v) => e.ROLL_MARKED = v;
                        break;
                    case "SCL_LINK":
                        mapper[i] = (e, v) => e.SCL_LINK = v;
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
        /// Merges <see cref="TXAS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TXAS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TXAS" /> items to added or update the base <see cref="TXAS" /> items</param>
        /// <returns>A merged list of <see cref="TXAS" /> items</returns>
        protected override List<TXAS> ApplyDeltaItems(List<TXAS> Items, List<TXAS> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TXAS deltaItem in DeltaItems)
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
                .OrderBy(i => i.TID)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_LOCATION;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<TXAS>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_SCL_LINK;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_TEACHER;
        private Lazy<Dictionary<int, TXAS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TXAS> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TXAS> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<TXAS> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<TXAS> value;
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
        /// Find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindBySCL_LINK(string SCL_LINK)
        {
            return Index_SCL_LINK.Value[SCL_LINK];
        }

        /// <summary>
        /// Attempt to find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCL_LINK(string SCL_LINK, out IReadOnlyList<TXAS> Value)
        {
            return Index_SCL_LINK.Value.TryGetValue(SCL_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindBySCL_LINK(string SCL_LINK)
        {
            IReadOnlyList<TXAS> value;
            if (Index_SCL_LINK.Value.TryGetValue(SCL_LINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<TXAS> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<TXAS> value;
            if (Index_SUBJECT.Value.TryGetValue(SUBJECT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<TXAS> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<TXAS> value;
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
        /// Find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXAS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <param name="Value">Related TXAS entity</param>
        /// <returns>True if the related TXAS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TXAS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXAS TryFindByTID(int TID)
        {
            TXAS value;
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
