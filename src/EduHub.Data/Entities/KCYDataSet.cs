using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCYDataSet : SetBase<KCY>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCY"; } }

        internal KCYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCYKEY = new Lazy<Dictionary<string, KCY>>(() => this.ToDictionary(i => i.KCYKEY));
            Index_NEXT_YR = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_YR));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TEACHER_B = new Lazy<NullDictionary<string, IReadOnlyList<KCY>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER_B));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCY" /> fields for each CSV column header</returns>
        protected override Action<KCY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCYKEY":
                        mapper[i] = (e, v) => e.KCYKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NUM_EQVT":
                        mapper[i] = (e, v) => e.NUM_EQVT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SHORT_DESC":
                        mapper[i] = (e, v) => e.SHORT_DESC = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "NEXT_YR":
                        mapper[i] = (e, v) => e.NEXT_YR = v;
                        break;
                    case "FINAL_YR":
                        mapper[i] = (e, v) => e.FINAL_YR = v;
                        break;
                    case "CSF_REQUIRED":
                        mapper[i] = (e, v) => e.CSF_REQUIRED = v;
                        break;
                    case "HALF_DAY_ABS":
                        mapper[i] = (e, v) => e.HALF_DAY_ABS = v;
                        break;
                    case "PERIOD_ABS":
                        mapper[i] = (e, v) => e.PERIOD_ABS = v;
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
        /// Merges <see cref="KCY" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCY" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCY" /> items to added or update the base <see cref="KCY" /> items</param>
        /// <returns>A merged list of <see cref="KCY" /> items</returns>
        protected override List<KCY> ApplyDeltaItems(List<KCY> Items, List<KCY> DeltaItems)
        {
            Dictionary<string, int> Index_KCYKEY = Items.ToIndexDictionary(i => i.KCYKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCY deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCYKEY.TryGetValue(deltaItem.KCYKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCYKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCY>> Index_KCYKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_NEXT_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<KCY>>> Index_TEACHER_B;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCY FindByKCYKEY(string KCYKEY)
        {
            return Index_KCYKEY.Value[KCYKEY];
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <param name="Value">Related KCY entity</param>
        /// <returns>True if the related KCY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCYKEY(string KCYKEY, out KCY Value)
        {
            return Index_KCYKEY.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY field
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCY TryFindByKCYKEY(string KCYKEY)
        {
            KCY value;
            if (Index_KCYKEY.Value.TryGetValue(KCYKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByNEXT_YR(string NEXT_YR)
        {
            return Index_NEXT_YR.Value[NEXT_YR];
        }

        /// <summary>
        /// Attempt to find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEXT_YR(string NEXT_YR, out IReadOnlyList<KCY> Value)
        {
            return Index_NEXT_YR.Value.TryGetValue(NEXT_YR, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by NEXT_YR field
        /// </summary>
        /// <param name="NEXT_YR">NEXT_YR value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByNEXT_YR(string NEXT_YR)
        {
            IReadOnlyList<KCY> value;
            if (Index_NEXT_YR.Value.TryGetValue(NEXT_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<KCY> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<KCY> value;
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
        /// Find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <returns>List of related KCY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> FindByTEACHER_B(string TEACHER_B)
        {
            return Index_TEACHER_B.Value[TEACHER_B];
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <param name="Value">List of related KCY entities</param>
        /// <returns>True if the list of related KCY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER_B(string TEACHER_B, out IReadOnlyList<KCY> Value)
        {
            return Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KCY</param>
        /// <returns>List of related KCY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCY> TryFindByTEACHER_B(string TEACHER_B)
        {
            IReadOnlyList<KCY> value;
            if (Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out value))
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
