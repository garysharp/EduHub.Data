using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGCHIDataSet : SetBase<KGCHI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGCHI"; } }

        internal KGCHIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGCHIKEY = new Lazy<Dictionary<int, KGCHI>>(() => this.ToDictionary(i => i.KGCHIKEY));
            Index_KGCKEY = new Lazy<NullDictionary<string, IReadOnlyList<KGCHI>>>(() => this.ToGroupedNullDictionary(i => i.KGCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGCHI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGCHI" /> fields for each CSV column header</returns>
        protected override Action<KGCHI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGCHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCHIKEY":
                        mapper[i] = (e, v) => e.KGCHIKEY = int.Parse(v);
                        break;
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KGCHI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGCHI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGCHI" /> items to added or update the base <see cref="KGCHI" /> items</param>
        /// <returns>A merged list of <see cref="KGCHI" /> items</returns>
        protected override List<KGCHI> ApplyDeltaItems(List<KGCHI> Items, List<KGCHI> DeltaItems)
        {
            Dictionary<int, int> Index_KGCHIKEY = Items.ToIndexDictionary(i => i.KGCHIKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGCHI deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGCHIKEY.TryGetValue(deltaItem.KGCHIKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGCHIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KGCHI>> Index_KGCHIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KGCHI>>> Index_KGCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCHI FindByKGCHIKEY(int KGCHIKEY)
        {
            return Index_KGCHIKEY.Value[KGCHIKEY];
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <param name="Value">Related KGCHI entity</param>
        /// <returns>True if the related KGCHI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCHIKEY(int KGCHIKEY, out KGCHI Value)
        {
            return Index_KGCHIKEY.Value.TryGetValue(KGCHIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCHI TryFindByKGCHIKEY(int KGCHIKEY)
        {
            KGCHI value;
            if (Index_KGCHIKEY.Value.TryGetValue(KGCHIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <returns>List of related KGCHI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGCHI> FindByKGCKEY(string KGCKEY)
        {
            return Index_KGCKEY.Value[KGCKEY];
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <param name="Value">List of related KGCHI entities</param>
        /// <returns>True if the list of related KGCHI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCKEY(string KGCKEY, out IReadOnlyList<KGCHI> Value)
        {
            return Index_KGCKEY.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <returns>List of related KGCHI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGCHI> TryFindByKGCKEY(string KGCKEY)
        {
            IReadOnlyList<KGCHI> value;
            if (Index_KGCKEY.Value.TryGetValue(KGCKEY, out value))
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
