using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Class Information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTQDataSet : SetBase<TCTQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTQ"; } }

        internal TCTQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COMPOSITE = new Lazy<NullDictionary<short?, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.COMPOSITE));
            Index_EXTRA_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.EXTRA_ROOM));
            Index_EXTRA_TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.EXTRA_TEACH));
            Index_GKEY = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.GKEY));
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
            Index_R1ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.R1ROOM));
            Index_R2ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.R2ROOM));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_T1TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.T1TEACH));
            Index_T2TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>>(() => this.ToGroupedNullDictionary(i => i.T2TEACH));
            Index_TCTQKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTQ>>>(() => this.ToGroupedDictionary(i => i.TCTQKEY));
            Index_TID = new Lazy<Dictionary<int, TCTQ>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTQ" /> fields for each CSV column header</returns>
        protected override Action<TCTQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTQKEY":
                        mapper[i] = (e, v) => e.TCTQKEY = DateTime.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SIZE":
                        mapper[i] = (e, v) => e.CLASS_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "T1TEACH":
                        mapper[i] = (e, v) => e.T1TEACH = v;
                        break;
                    case "T2TEACH":
                        mapper[i] = (e, v) => e.T2TEACH = v;
                        break;
                    case "R1ROOM":
                        mapper[i] = (e, v) => e.R1ROOM = v;
                        break;
                    case "R2ROOM":
                        mapper[i] = (e, v) => e.R2ROOM = v;
                        break;
                    case "RESOURCES01":
                        mapper[i] = (e, v) => e.RESOURCES01 = v;
                        break;
                    case "RESOURCES02":
                        mapper[i] = (e, v) => e.RESOURCES02 = v;
                        break;
                    case "RESOURCES03":
                        mapper[i] = (e, v) => e.RESOURCES03 = v;
                        break;
                    case "RESOURCES04":
                        mapper[i] = (e, v) => e.RESOURCES04 = v;
                        break;
                    case "RESOURCES05":
                        mapper[i] = (e, v) => e.RESOURCES05 = v;
                        break;
                    case "RESOURCES06":
                        mapper[i] = (e, v) => e.RESOURCES06 = v;
                        break;
                    case "RESOURCES07":
                        mapper[i] = (e, v) => e.RESOURCES07 = v;
                        break;
                    case "RESOURCES08":
                        mapper[i] = (e, v) => e.RESOURCES08 = v;
                        break;
                    case "RESOURCES09":
                        mapper[i] = (e, v) => e.RESOURCES09 = v;
                        break;
                    case "EXTRA_TEACH":
                        mapper[i] = (e, v) => e.EXTRA_TEACH = v;
                        break;
                    case "EXTRA_ROOM":
                        mapper[i] = (e, v) => e.EXTRA_ROOM = v;
                        break;
                    case "QROW":
                        mapper[i] = (e, v) => e.QROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "QCOL":
                        mapper[i] = (e, v) => e.QCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "COMPOSITE":
                        mapper[i] = (e, v) => e.COMPOSITE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "GROW":
                        mapper[i] = (e, v) => e.GROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOL":
                        mapper[i] = (e, v) => e.GCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOLOUR":
                        mapper[i] = (e, v) => e.GCOLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "OCCUR":
                        mapper[i] = (e, v) => e.OCCUR = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="TCTQ" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TCTQ" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TCTQ" /> items to added or update the base <see cref="TCTQ" /> items</param>
        /// <returns>A merged list of <see cref="TCTQ" /> items</returns>
        protected override List<TCTQ> ApplyDeltaItems(List<TCTQ> Items, List<TCTQ> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TCTQ deltaItem in DeltaItems)
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
                .OrderBy(i => i.TCTQKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<short?, IReadOnlyList<TCTQ>>> Index_COMPOSITE;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_EXTRA_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_EXTRA_TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_GKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_QKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_R1ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_R2ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_SUBJ;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_T1TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTQ>>> Index_T2TEACH;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTQ>>> Index_TCTQKEY;
        private Lazy<Dictionary<int, TCTQ>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTQ by COMPOSITE field
        /// </summary>
        /// <param name="COMPOSITE">COMPOSITE value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByCOMPOSITE(short? COMPOSITE)
        {
            return Index_COMPOSITE.Value[COMPOSITE];
        }

        /// <summary>
        /// Attempt to find TCTQ by COMPOSITE field
        /// </summary>
        /// <param name="COMPOSITE">COMPOSITE value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPOSITE(short? COMPOSITE, out IReadOnlyList<TCTQ> Value)
        {
            return Index_COMPOSITE.Value.TryGetValue(COMPOSITE, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by COMPOSITE field
        /// </summary>
        /// <param name="COMPOSITE">COMPOSITE value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByCOMPOSITE(short? COMPOSITE)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_COMPOSITE.Value.TryGetValue(COMPOSITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by EXTRA_ROOM field
        /// </summary>
        /// <param name="EXTRA_ROOM">EXTRA_ROOM value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByEXTRA_ROOM(string EXTRA_ROOM)
        {
            return Index_EXTRA_ROOM.Value[EXTRA_ROOM];
        }

        /// <summary>
        /// Attempt to find TCTQ by EXTRA_ROOM field
        /// </summary>
        /// <param name="EXTRA_ROOM">EXTRA_ROOM value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXTRA_ROOM(string EXTRA_ROOM, out IReadOnlyList<TCTQ> Value)
        {
            return Index_EXTRA_ROOM.Value.TryGetValue(EXTRA_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by EXTRA_ROOM field
        /// </summary>
        /// <param name="EXTRA_ROOM">EXTRA_ROOM value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByEXTRA_ROOM(string EXTRA_ROOM)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_EXTRA_ROOM.Value.TryGetValue(EXTRA_ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by EXTRA_TEACH field
        /// </summary>
        /// <param name="EXTRA_TEACH">EXTRA_TEACH value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByEXTRA_TEACH(string EXTRA_TEACH)
        {
            return Index_EXTRA_TEACH.Value[EXTRA_TEACH];
        }

        /// <summary>
        /// Attempt to find TCTQ by EXTRA_TEACH field
        /// </summary>
        /// <param name="EXTRA_TEACH">EXTRA_TEACH value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXTRA_TEACH(string EXTRA_TEACH, out IReadOnlyList<TCTQ> Value)
        {
            return Index_EXTRA_TEACH.Value.TryGetValue(EXTRA_TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by EXTRA_TEACH field
        /// </summary>
        /// <param name="EXTRA_TEACH">EXTRA_TEACH value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByEXTRA_TEACH(string EXTRA_TEACH)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_EXTRA_TEACH.Value.TryGetValue(EXTRA_TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TCTQ by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TCTQ> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find TCTQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<TCTQ> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_QKEY.Value.TryGetValue(QKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByR1ROOM(string R1ROOM)
        {
            return Index_R1ROOM.Value[R1ROOM];
        }

        /// <summary>
        /// Attempt to find TCTQ by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR1ROOM(string R1ROOM, out IReadOnlyList<TCTQ> Value)
        {
            return Index_R1ROOM.Value.TryGetValue(R1ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByR1ROOM(string R1ROOM)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_R1ROOM.Value.TryGetValue(R1ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByR2ROOM(string R2ROOM)
        {
            return Index_R2ROOM.Value[R2ROOM];
        }

        /// <summary>
        /// Attempt to find TCTQ by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR2ROOM(string R2ROOM, out IReadOnlyList<TCTQ> Value)
        {
            return Index_R2ROOM.Value.TryGetValue(R2ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByR2ROOM(string R2ROOM)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_R2ROOM.Value.TryGetValue(R2ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TCTQ by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TCTQ> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TCTQ> value;
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
        /// Find TCTQ by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByT1TEACH(string T1TEACH)
        {
            return Index_T1TEACH.Value[T1TEACH];
        }

        /// <summary>
        /// Attempt to find TCTQ by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT1TEACH(string T1TEACH, out IReadOnlyList<TCTQ> Value)
        {
            return Index_T1TEACH.Value.TryGetValue(T1TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByT1TEACH(string T1TEACH)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_T1TEACH.Value.TryGetValue(T1TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByT2TEACH(string T2TEACH)
        {
            return Index_T2TEACH.Value[T2TEACH];
        }

        /// <summary>
        /// Attempt to find TCTQ by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT2TEACH(string T2TEACH, out IReadOnlyList<TCTQ> Value)
        {
            return Index_T2TEACH.Value.TryGetValue(T2TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByT2TEACH(string T2TEACH)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_T2TEACH.Value.TryGetValue(T2TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by TCTQKEY field
        /// </summary>
        /// <param name="TCTQKEY">TCTQKEY value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> FindByTCTQKEY(DateTime TCTQKEY)
        {
            return Index_TCTQKEY.Value[TCTQKEY];
        }

        /// <summary>
        /// Attempt to find TCTQ by TCTQKEY field
        /// </summary>
        /// <param name="TCTQKEY">TCTQKEY value used to find TCTQ</param>
        /// <param name="Value">List of related TCTQ entities</param>
        /// <returns>True if the list of related TCTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTQKEY(DateTime TCTQKEY, out IReadOnlyList<TCTQ> Value)
        {
            return Index_TCTQKEY.Value.TryGetValue(TCTQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by TCTQKEY field
        /// </summary>
        /// <param name="TCTQKEY">TCTQKEY value used to find TCTQ</param>
        /// <returns>List of related TCTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTQ> TryFindByTCTQKEY(DateTime TCTQKEY)
        {
            IReadOnlyList<TCTQ> value;
            if (Index_TCTQKEY.Value.TryGetValue(TCTQKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTQ</param>
        /// <returns>Related TCTQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTQ FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTQ</param>
        /// <param name="Value">Related TCTQ entity</param>
        /// <returns>True if the related TCTQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTQ Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTQ</param>
        /// <returns>Related TCTQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTQ TryFindByTID(int TID)
        {
            TCTQ value;
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
