using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Book Hire Records Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKHRDataSet : SetBase<BKHR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BKHR"; } }

        internal BKHRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKHRKEY = new Lazy<Dictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedDictionary(i => i.BKHRKEY));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_TID = new Lazy<Dictionary<int, BKHR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BKHR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BKHR" /> fields for each CSV column header</returns>
        protected override Action<BKHR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BKHR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BKHRKEY":
                        mapper[i] = (e, v) => e.BKHRKEY = v;
                        break;
                    case "REF_NUMBER":
                        mapper[i] = (e, v) => e.REF_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ISSUE_DATE":
                        mapper[i] = (e, v) => e.ISSUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DUE_DATE":
                        mapper[i] = (e, v) => e.DUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RETURNED_DATE":
                        mapper[i] = (e, v) => e.RETURNED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONDITION":
                        mapper[i] = (e, v) => e.CONDITION = v;
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
        /// Merges <see cref="BKHR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="BKHR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="BKHR" /> items to added or update the base <see cref="BKHR" /> items</param>
        /// <returns>A merged list of <see cref="BKHR" /> items</returns>
        protected override List<BKHR> ApplyDeltaItems(List<BKHR> Items, List<BKHR> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (BKHR deltaItem in DeltaItems)
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
                .OrderBy(i => i.BKHRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<BKHR>>> Index_BKHRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<BKHR>>> Index_STAFF;
        private Lazy<NullDictionary<string, IReadOnlyList<BKHR>>> Index_STUDENT;
        private Lazy<Dictionary<int, BKHR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindByBKHRKEY(string BKHRKEY)
        {
            return Index_BKHRKEY.Value[BKHRKEY];
        }

        /// <summary>
        /// Attempt to find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKHRKEY(string BKHRKEY, out IReadOnlyList<BKHR> Value)
        {
            return Index_BKHRKEY.Value.TryGetValue(BKHRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindByBKHRKEY(string BKHRKEY)
        {
            IReadOnlyList<BKHR> value;
            if (Index_BKHRKEY.Value.TryGetValue(BKHRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<BKHR> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<BKHR> value;
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
        /// Find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<BKHR> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<BKHR> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <returns>Related BKHR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKHR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <param name="Value">Related BKHR entity</param>
        /// <returns>True if the related BKHR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out BKHR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <returns>Related BKHR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKHR TryFindByTID(int TID)
        {
            BKHR value;
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
