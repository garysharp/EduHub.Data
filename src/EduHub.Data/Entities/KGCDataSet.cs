using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGCDataSet : SetBase<KGC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGC"; } }

        internal KGCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_KGCKEY = new Lazy<Dictionary<string, KGC>>(() => this.ToDictionary(i => i.KGCKEY));
            Index_MAX_AC_YR = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.MAX_AC_YR));
            Index_MIN_AC_YR = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.MIN_AC_YR));
            Index_NEXT_HG = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.NEXT_HG));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TEACHER_B = new Lazy<NullDictionary<string, IReadOnlyList<KGC>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER_B));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGC" /> fields for each CSV column header</returns>
        protected override Action<KGC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "HG_SIZE":
                        mapper[i] = (e, v) => e.HG_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MIN_AC_YR":
                        mapper[i] = (e, v) => e.MIN_AC_YR = v;
                        break;
                    case "MAX_AC_YR":
                        mapper[i] = (e, v) => e.MAX_AC_YR = v;
                        break;
                    case "NEXT_HG":
                        mapper[i] = (e, v) => e.NEXT_HG = v;
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
        /// Merges <see cref="KGC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGC" /> items to added or update the base <see cref="KGC" /> items</param>
        /// <returns>A merged list of <see cref="KGC" /> items</returns>
        protected override List<KGC> ApplyDeltaItems(List<KGC> Items, List<KGC> DeltaItems)
        {
            Dictionary<string, int> Index_KGCKEY = Items.ToIndexDictionary(i => i.KGCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGCKEY.TryGetValue(deltaItem.KGCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<KGC>>> Index_CAMPUS;
        private Lazy<Dictionary<string, KGC>> Index_KGCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_MAX_AC_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_MIN_AC_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_NEXT_HG;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<KGC>>> Index_TEACHER_B;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find KGC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<KGC> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<KGC> value;
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
        /// Find KGC by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGC FindByKGCKEY(string KGCKEY)
        {
            return Index_KGCKEY.Value[KGCKEY];
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC</param>
        /// <param name="Value">Related KGC entity</param>
        /// <returns>True if the related KGC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCKEY(string KGCKEY, out KGC Value)
        {
            return Index_KGCKEY.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGC TryFindByKGCKEY(string KGCKEY)
        {
            KGC value;
            if (Index_KGCKEY.Value.TryGetValue(KGCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by MAX_AC_YR field
        /// </summary>
        /// <param name="MAX_AC_YR">MAX_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByMAX_AC_YR(string MAX_AC_YR)
        {
            return Index_MAX_AC_YR.Value[MAX_AC_YR];
        }

        /// <summary>
        /// Attempt to find KGC by MAX_AC_YR field
        /// </summary>
        /// <param name="MAX_AC_YR">MAX_AC_YR value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAX_AC_YR(string MAX_AC_YR, out IReadOnlyList<KGC> Value)
        {
            return Index_MAX_AC_YR.Value.TryGetValue(MAX_AC_YR, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by MAX_AC_YR field
        /// </summary>
        /// <param name="MAX_AC_YR">MAX_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByMAX_AC_YR(string MAX_AC_YR)
        {
            IReadOnlyList<KGC> value;
            if (Index_MAX_AC_YR.Value.TryGetValue(MAX_AC_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by MIN_AC_YR field
        /// </summary>
        /// <param name="MIN_AC_YR">MIN_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByMIN_AC_YR(string MIN_AC_YR)
        {
            return Index_MIN_AC_YR.Value[MIN_AC_YR];
        }

        /// <summary>
        /// Attempt to find KGC by MIN_AC_YR field
        /// </summary>
        /// <param name="MIN_AC_YR">MIN_AC_YR value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMIN_AC_YR(string MIN_AC_YR, out IReadOnlyList<KGC> Value)
        {
            return Index_MIN_AC_YR.Value.TryGetValue(MIN_AC_YR, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by MIN_AC_YR field
        /// </summary>
        /// <param name="MIN_AC_YR">MIN_AC_YR value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByMIN_AC_YR(string MIN_AC_YR)
        {
            IReadOnlyList<KGC> value;
            if (Index_MIN_AC_YR.Value.TryGetValue(MIN_AC_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByNEXT_HG(string NEXT_HG)
        {
            return Index_NEXT_HG.Value[NEXT_HG];
        }

        /// <summary>
        /// Attempt to find KGC by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEXT_HG(string NEXT_HG, out IReadOnlyList<KGC> Value)
        {
            return Index_NEXT_HG.Value.TryGetValue(NEXT_HG, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by NEXT_HG field
        /// </summary>
        /// <param name="NEXT_HG">NEXT_HG value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByNEXT_HG(string NEXT_HG)
        {
            IReadOnlyList<KGC> value;
            if (Index_NEXT_HG.Value.TryGetValue(NEXT_HG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGC by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find KGC by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<KGC> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<KGC> value;
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
        /// Find KGC by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<KGC> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<KGC> value;
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
        /// Find KGC by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KGC</param>
        /// <returns>List of related KGC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> FindByTEACHER_B(string TEACHER_B)
        {
            return Index_TEACHER_B.Value[TEACHER_B];
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KGC</param>
        /// <param name="Value">List of related KGC entities</param>
        /// <returns>True if the list of related KGC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER_B(string TEACHER_B, out IReadOnlyList<KGC> Value)
        {
            return Index_TEACHER_B.Value.TryGetValue(TEACHER_B, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by TEACHER_B field
        /// </summary>
        /// <param name="TEACHER_B">TEACHER_B value used to find KGC</param>
        /// <returns>List of related KGC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGC> TryFindByTEACHER_B(string TEACHER_B)
        {
            IReadOnlyList<KGC> value;
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
