using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Item Leave Items Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PILIDataSet : SetBase<PILI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PILI"; } }

        internal PILIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_LEAVE_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_GROUP));
            Index_PIKEY = new Lazy<Dictionary<short, IReadOnlyList<PILI>>>(() => this.ToGroupedDictionary(i => i.PIKEY));
            Index_PLTKEY = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.PLTKEY));
            Index_TID = new Lazy<Dictionary<int, PILI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PILI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PILI" /> fields for each CSV column header</returns>
        protected override Action<PILI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PILI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PIKEY":
                        mapper[i] = (e, v) => e.PIKEY = short.Parse(v);
                        break;
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
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
        /// Merges <see cref="PILI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PILI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PILI" /> items to added or update the base <see cref="PILI" /> items</param>
        /// <returns>A merged list of <see cref="PILI" /> items</returns>
        protected override List<PILI> ApplyDeltaItems(List<PILI> Items, List<PILI> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PILI deltaItem in DeltaItems)
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
                .OrderBy(i => i.PIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_LEAVE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_LEAVE_GROUP;
        private Lazy<Dictionary<short, IReadOnlyList<PILI>>> Index_PIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_PLTKEY;
        private Lazy<Dictionary<int, PILI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PILI> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PILI> value;
            if (Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PILI> Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PILI> value;
            if (Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByPIKEY(short PIKEY)
        {
            return Index_PIKEY.Value[PIKEY];
        }

        /// <summary>
        /// Attempt to find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPIKEY(short PIKEY, out IReadOnlyList<PILI> Value)
        {
            return Index_PIKEY.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByPIKEY(short PIKEY)
        {
            IReadOnlyList<PILI> value;
            if (Index_PIKEY.Value.TryGetValue(PIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByPLTKEY(string PLTKEY)
        {
            return Index_PLTKEY.Value[PLTKEY];
        }

        /// <summary>
        /// Attempt to find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLTKEY(string PLTKEY, out IReadOnlyList<PILI> Value)
        {
            return Index_PLTKEY.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByPLTKEY(string PLTKEY)
        {
            IReadOnlyList<PILI> value;
            if (Index_PLTKEY.Value.TryGetValue(PLTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <returns>Related PILI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PILI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <param name="Value">Related PILI entity</param>
        /// <returns>True if the related PILI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PILI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <returns>Related PILI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PILI TryFindByTID(int TID)
        {
            PILI value;
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
