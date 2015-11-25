using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Group Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLTDataSet : SetBase<PLT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLT"; } }

        internal PLTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PLT>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_LEAVE_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<PLT>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_GROUP));
            Index_LEAVE_GROUP_LEAVE_CODE = new Lazy<Dictionary<Tuple<string, string>, PLT>>(() => this.ToDictionary(i => Tuple.Create(i.LEAVE_GROUP, i.LEAVE_CODE)));
            Index_PLTKEY = new Lazy<Dictionary<string, PLT>>(() => this.ToDictionary(i => i.PLTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLT" /> fields for each CSV column header</returns>
        protected override Action<PLT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "CALC_METHOD":
                        mapper[i] = (e, v) => e.CALC_METHOD = v;
                        break;
                    case "PERIOD_ALLOT01":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT02":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT03":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT04":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT05":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT06":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT07":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT08":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT09":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT10":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT11":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT12":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH01":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH02":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH03":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH04":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH05":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH06":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH07":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH08":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH09":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH10":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH11":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH12":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v;
                        break;
                    case "ANNUAL_ENTITLEMENT":
                        mapper[i] = (e, v) => e.ANNUAL_ENTITLEMENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ROLL_OVER":
                        mapper[i] = (e, v) => e.ROLL_OVER = v;
                        break;
                    case "ROLL_PERCENT":
                        mapper[i] = (e, v) => e.ROLL_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_LOADING":
                        mapper[i] = (e, v) => e.LEAVE_LOADING = v;
                        break;
                    case "LOADING_PERCENT":
                        mapper[i] = (e, v) => e.LOADING_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="PLT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PLT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PLT" /> items to added or update the base <see cref="PLT" /> items</param>
        /// <returns>A merged list of <see cref="PLT" /> items</returns>
        protected override List<PLT> ApplyDeltaItems(List<PLT> Items, List<PLT> DeltaItems)
        {
            Dictionary<Tuple<string, string>, int> Index_LEAVE_GROUP_LEAVE_CODE = Items.ToIndexDictionary(i => Tuple.Create(i.LEAVE_GROUP, i.LEAVE_CODE));
            Dictionary<string, int> Index_PLTKEY = Items.ToIndexDictionary(i => i.PLTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PLT deltaItem in DeltaItems)
            {
                int index;

                if (Index_LEAVE_GROUP_LEAVE_CODE.TryGetValue(Tuple.Create(deltaItem.LEAVE_GROUP, deltaItem.LEAVE_CODE), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_PLTKEY.TryGetValue(deltaItem.PLTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PLTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PLT>>> Index_LEAVE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PLT>>> Index_LEAVE_GROUP;
        private Lazy<Dictionary<Tuple<string, string>, PLT>> Index_LEAVE_GROUP_LEAVE_CODE;
        private Lazy<Dictionary<string, PLT>> Index_PLTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLT by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>List of related PLT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <param name="Value">List of related PLT entities</param>
        /// <returns>True if the list of related PLT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PLT> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>List of related PLT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PLT> value;
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
        /// Find PLT by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <returns>List of related PLT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="Value">List of related PLT entities</param>
        /// <returns>True if the list of related PLT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PLT> Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <returns>List of related PLT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PLT> value;
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
        /// Find PLT by LEAVE_GROUP and LEAVE_CODE fields
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>Related PLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT FindByLEAVE_GROUP_LEAVE_CODE(string LEAVE_GROUP, string LEAVE_CODE)
        {
            return Index_LEAVE_GROUP_LEAVE_CODE.Value[Tuple.Create(LEAVE_GROUP, LEAVE_CODE)];
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP and LEAVE_CODE fields
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <param name="Value">Related PLT entity</param>
        /// <returns>True if the related PLT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP_LEAVE_CODE(string LEAVE_GROUP, string LEAVE_CODE, out PLT Value)
        {
            return Index_LEAVE_GROUP_LEAVE_CODE.Value.TryGetValue(Tuple.Create(LEAVE_GROUP, LEAVE_CODE), out Value);
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP and LEAVE_CODE fields
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>Related PLT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT TryFindByLEAVE_GROUP_LEAVE_CODE(string LEAVE_GROUP, string LEAVE_CODE)
        {
            PLT value;
            if (Index_LEAVE_GROUP_LEAVE_CODE.Value.TryGetValue(Tuple.Create(LEAVE_GROUP, LEAVE_CODE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PLT by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PLT</param>
        /// <returns>Related PLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT FindByPLTKEY(string PLTKEY)
        {
            return Index_PLTKEY.Value[PLTKEY];
        }

        /// <summary>
        /// Attempt to find PLT by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PLT</param>
        /// <param name="Value">Related PLT entity</param>
        /// <returns>True if the related PLT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLTKEY(string PLTKEY, out PLT Value)
        {
            return Index_PLTKEY.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PLT by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PLT</param>
        /// <returns>Related PLT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT TryFindByPLTKEY(string PLTKEY)
        {
            PLT value;
            if (Index_PLTKEY.Value.TryGetValue(PLTKEY, out value))
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
