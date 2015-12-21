using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Entries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THTQDataSet : EduHubDataSet<THTQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "THTQ"; } }

        internal THTQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_EXTRA_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.EXTRA_ROOM));
            Index_EXTRA_TEACH = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.EXTRA_TEACH));
            Index_GKEY = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.GKEY));
            Index_IDENT = new Lazy<NullDictionary<int?, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.IDENT));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_QKEY = new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedDictionary(i => i.QKEY));
            Index_R1ROOM = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.R1ROOM));
            Index_R2ROOM = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.R2ROOM));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_T1TEACH = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.T1TEACH));
            Index_T2TEACH = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.T2TEACH));
            Index_TID = new Lazy<Dictionary<int, THTQ>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="THTQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="THTQ" /> fields for each CSV column header</returns>
        protected override Action<THTQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<THTQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OCCUR":
                        mapper[i] = (e, v) => e.OCCUR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FREQ":
                        mapper[i] = (e, v) => e.FREQ = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROW_LABEL":
                        mapper[i] = (e, v) => e.ROW_LABEL = v;
                        break;
                    case "TIED":
                        mapper[i] = (e, v) => e.TIED = v == null ? (short?)null : short.Parse(v);
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
                    case "GROW":
                        mapper[i] = (e, v) => e.GROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOL":
                        mapper[i] = (e, v) => e.GCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LINK":
                        mapper[i] = (e, v) => e.LINK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "COMPOSITE":
                        mapper[i] = (e, v) => e.COMPOSITE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="THTQ" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="THTQ" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="THTQ" /> items to added or update the base <see cref="THTQ" /> items</param>
        /// <returns>A merged list of <see cref="THTQ" /> items</returns>
        protected override List<THTQ> ApplyDeltaItems(List<THTQ> Items, List<THTQ> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (THTQ deltaItem in DeltaItems)
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
                .OrderBy(i => i.QKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_EXTRA_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_EXTRA_TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_GKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<THTQ>>> Index_IDENT;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<THTQ>>> Index_LW_DATE;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> Index_QKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_R1ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_R2ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_SUBJ;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_T1TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_T2TEACH;
        private Lazy<Dictionary<int, THTQ>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find THTQ by EXTRA_ROOM field
        /// </summary>
        /// <param name="EXTRA_ROOM">EXTRA_ROOM value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByEXTRA_ROOM(string EXTRA_ROOM)
        {
            return Index_EXTRA_ROOM.Value[EXTRA_ROOM];
        }

        /// <summary>
        /// Attempt to find THTQ by EXTRA_ROOM field
        /// </summary>
        /// <param name="EXTRA_ROOM">EXTRA_ROOM value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXTRA_ROOM(string EXTRA_ROOM, out IReadOnlyList<THTQ> Value)
        {
            return Index_EXTRA_ROOM.Value.TryGetValue(EXTRA_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by EXTRA_ROOM field
        /// </summary>
        /// <param name="EXTRA_ROOM">EXTRA_ROOM value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByEXTRA_ROOM(string EXTRA_ROOM)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by EXTRA_TEACH field
        /// </summary>
        /// <param name="EXTRA_TEACH">EXTRA_TEACH value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByEXTRA_TEACH(string EXTRA_TEACH)
        {
            return Index_EXTRA_TEACH.Value[EXTRA_TEACH];
        }

        /// <summary>
        /// Attempt to find THTQ by EXTRA_TEACH field
        /// </summary>
        /// <param name="EXTRA_TEACH">EXTRA_TEACH value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXTRA_TEACH(string EXTRA_TEACH, out IReadOnlyList<THTQ> Value)
        {
            return Index_EXTRA_TEACH.Value.TryGetValue(EXTRA_TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by EXTRA_TEACH field
        /// </summary>
        /// <param name="EXTRA_TEACH">EXTRA_TEACH value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByEXTRA_TEACH(string EXTRA_TEACH)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find THTQ by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<THTQ> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByIDENT(int? IDENT)
        {
            return Index_IDENT.Value[IDENT];
        }

        /// <summary>
        /// Attempt to find THTQ by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByIDENT(int? IDENT, out IReadOnlyList<THTQ> Value)
        {
            return Index_IDENT.Value.TryGetValue(IDENT, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByIDENT(int? IDENT)
        {
            IReadOnlyList<THTQ> value;
            if (Index_IDENT.Value.TryGetValue(IDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find THTQ by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find THTQ by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<THTQ> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find THTQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<THTQ> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByR1ROOM(string R1ROOM)
        {
            return Index_R1ROOM.Value[R1ROOM];
        }

        /// <summary>
        /// Attempt to find THTQ by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR1ROOM(string R1ROOM, out IReadOnlyList<THTQ> Value)
        {
            return Index_R1ROOM.Value.TryGetValue(R1ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByR1ROOM(string R1ROOM)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByR2ROOM(string R2ROOM)
        {
            return Index_R2ROOM.Value[R2ROOM];
        }

        /// <summary>
        /// Attempt to find THTQ by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR2ROOM(string R2ROOM, out IReadOnlyList<THTQ> Value)
        {
            return Index_R2ROOM.Value.TryGetValue(R2ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByR2ROOM(string R2ROOM)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find THTQ by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<THTQ> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByT1TEACH(string T1TEACH)
        {
            return Index_T1TEACH.Value[T1TEACH];
        }

        /// <summary>
        /// Attempt to find THTQ by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT1TEACH(string T1TEACH, out IReadOnlyList<THTQ> Value)
        {
            return Index_T1TEACH.Value.TryGetValue(T1TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByT1TEACH(string T1TEACH)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find THTQ</param>
        /// <returns>List of related THTQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> FindByT2TEACH(string T2TEACH)
        {
            return Index_T2TEACH.Value[T2TEACH];
        }

        /// <summary>
        /// Attempt to find THTQ by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find THTQ</param>
        /// <param name="Value">List of related THTQ entities</param>
        /// <returns>True if the list of related THTQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT2TEACH(string T2TEACH, out IReadOnlyList<THTQ> Value)
        {
            return Index_T2TEACH.Value.TryGetValue(T2TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find THTQ</param>
        /// <returns>List of related THTQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTQ> TryFindByT2TEACH(string T2TEACH)
        {
            IReadOnlyList<THTQ> value;
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
        /// Find THTQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTQ</param>
        /// <returns>Related THTQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTQ FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find THTQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTQ</param>
        /// <param name="Value">Related THTQ entity</param>
        /// <returns>True if the related THTQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out THTQ Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find THTQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTQ</param>
        /// <returns>Related THTQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTQ TryFindByTID(int TID)
        {
            THTQ value;
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

        #region SQL Integration

        /// <summary>
        /// Returns SQL which checks for the existence of a THTQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[THTQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[THTQ](
        [TID] int IDENTITY NOT NULL,
        [QKEY] varchar(8) NOT NULL,
        [GKEY] varchar(8) NULL,
        [SUBJ] varchar(5) NULL,
        [CLASS] smallint NULL,
        [OCCUR] smallint NULL,
        [FREQ] smallint NULL,
        [ROW_LABEL] varchar(6) NULL,
        [TIED] smallint NULL,
        [IDENT] int NULL,
        [CLASS_SIZE] smallint NULL,
        [T1TEACH] varchar(4) NULL,
        [T2TEACH] varchar(4) NULL,
        [R1ROOM] varchar(4) NULL,
        [R2ROOM] varchar(4) NULL,
        [RESOURCES01] varchar(4) NULL,
        [RESOURCES02] varchar(4) NULL,
        [RESOURCES03] varchar(4) NULL,
        [RESOURCES04] varchar(4) NULL,
        [RESOURCES05] varchar(4) NULL,
        [RESOURCES06] varchar(4) NULL,
        [RESOURCES07] varchar(4) NULL,
        [RESOURCES08] varchar(4) NULL,
        [RESOURCES09] varchar(4) NULL,
        [EXTRA_TEACH] varchar(4) NULL,
        [EXTRA_ROOM] varchar(4) NULL,
        [QROW] smallint NULL,
        [QCOL] smallint NULL,
        [GROW] smallint NULL,
        [GCOL] smallint NULL,
        [LINK] smallint NULL,
        [COMPOSITE] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [THTQ_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_EXTRA_ROOM] ON [dbo].[THTQ]
    (
            [EXTRA_ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_EXTRA_TEACH] ON [dbo].[THTQ]
    (
            [EXTRA_TEACH] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_GKEY] ON [dbo].[THTQ]
    (
            [GKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_IDENT] ON [dbo].[THTQ]
    (
            [IDENT] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_LW_DATE] ON [dbo].[THTQ]
    (
            [LW_DATE] ASC
    );
    CREATE CLUSTERED INDEX [THTQ_Index_QKEY] ON [dbo].[THTQ]
    (
            [QKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_R1ROOM] ON [dbo].[THTQ]
    (
            [R1ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_R2ROOM] ON [dbo].[THTQ]
    (
            [R2ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_SUBJ] ON [dbo].[THTQ]
    (
            [SUBJ] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_T1TEACH] ON [dbo].[THTQ]
    (
            [T1TEACH] ASC
    );
    CREATE NONCLUSTERED INDEX [THTQ_Index_T2TEACH] ON [dbo].[THTQ]
    (
            [T2TEACH] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the THTQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the THTQ data set</returns>
        public override IDataReader GetDataReader()
        {
            return new THTQDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class THTQDataReader : IDataReader, IDataRecord
        {
            private List<THTQ> Items;
            private int CurrentIndex;
            private THTQ CurrentItem;

            public THTQDataReader(List<THTQ> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 35; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // QKEY
                        return CurrentItem.QKEY;
                    case 2: // GKEY
                        return CurrentItem.GKEY;
                    case 3: // SUBJ
                        return CurrentItem.SUBJ;
                    case 4: // CLASS
                        return CurrentItem.CLASS;
                    case 5: // OCCUR
                        return CurrentItem.OCCUR;
                    case 6: // FREQ
                        return CurrentItem.FREQ;
                    case 7: // ROW_LABEL
                        return CurrentItem.ROW_LABEL;
                    case 8: // TIED
                        return CurrentItem.TIED;
                    case 9: // IDENT
                        return CurrentItem.IDENT;
                    case 10: // CLASS_SIZE
                        return CurrentItem.CLASS_SIZE;
                    case 11: // T1TEACH
                        return CurrentItem.T1TEACH;
                    case 12: // T2TEACH
                        return CurrentItem.T2TEACH;
                    case 13: // R1ROOM
                        return CurrentItem.R1ROOM;
                    case 14: // R2ROOM
                        return CurrentItem.R2ROOM;
                    case 15: // RESOURCES01
                        return CurrentItem.RESOURCES01;
                    case 16: // RESOURCES02
                        return CurrentItem.RESOURCES02;
                    case 17: // RESOURCES03
                        return CurrentItem.RESOURCES03;
                    case 18: // RESOURCES04
                        return CurrentItem.RESOURCES04;
                    case 19: // RESOURCES05
                        return CurrentItem.RESOURCES05;
                    case 20: // RESOURCES06
                        return CurrentItem.RESOURCES06;
                    case 21: // RESOURCES07
                        return CurrentItem.RESOURCES07;
                    case 22: // RESOURCES08
                        return CurrentItem.RESOURCES08;
                    case 23: // RESOURCES09
                        return CurrentItem.RESOURCES09;
                    case 24: // EXTRA_TEACH
                        return CurrentItem.EXTRA_TEACH;
                    case 25: // EXTRA_ROOM
                        return CurrentItem.EXTRA_ROOM;
                    case 26: // QROW
                        return CurrentItem.QROW;
                    case 27: // QCOL
                        return CurrentItem.QCOL;
                    case 28: // GROW
                        return CurrentItem.GROW;
                    case 29: // GCOL
                        return CurrentItem.GCOL;
                    case 30: // LINK
                        return CurrentItem.LINK;
                    case 31: // COMPOSITE
                        return CurrentItem.COMPOSITE;
                    case 32: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 33: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 34: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // GKEY
                        return CurrentItem.GKEY == null;
                    case 3: // SUBJ
                        return CurrentItem.SUBJ == null;
                    case 4: // CLASS
                        return CurrentItem.CLASS == null;
                    case 5: // OCCUR
                        return CurrentItem.OCCUR == null;
                    case 6: // FREQ
                        return CurrentItem.FREQ == null;
                    case 7: // ROW_LABEL
                        return CurrentItem.ROW_LABEL == null;
                    case 8: // TIED
                        return CurrentItem.TIED == null;
                    case 9: // IDENT
                        return CurrentItem.IDENT == null;
                    case 10: // CLASS_SIZE
                        return CurrentItem.CLASS_SIZE == null;
                    case 11: // T1TEACH
                        return CurrentItem.T1TEACH == null;
                    case 12: // T2TEACH
                        return CurrentItem.T2TEACH == null;
                    case 13: // R1ROOM
                        return CurrentItem.R1ROOM == null;
                    case 14: // R2ROOM
                        return CurrentItem.R2ROOM == null;
                    case 15: // RESOURCES01
                        return CurrentItem.RESOURCES01 == null;
                    case 16: // RESOURCES02
                        return CurrentItem.RESOURCES02 == null;
                    case 17: // RESOURCES03
                        return CurrentItem.RESOURCES03 == null;
                    case 18: // RESOURCES04
                        return CurrentItem.RESOURCES04 == null;
                    case 19: // RESOURCES05
                        return CurrentItem.RESOURCES05 == null;
                    case 20: // RESOURCES06
                        return CurrentItem.RESOURCES06 == null;
                    case 21: // RESOURCES07
                        return CurrentItem.RESOURCES07 == null;
                    case 22: // RESOURCES08
                        return CurrentItem.RESOURCES08 == null;
                    case 23: // RESOURCES09
                        return CurrentItem.RESOURCES09 == null;
                    case 24: // EXTRA_TEACH
                        return CurrentItem.EXTRA_TEACH == null;
                    case 25: // EXTRA_ROOM
                        return CurrentItem.EXTRA_ROOM == null;
                    case 26: // QROW
                        return CurrentItem.QROW == null;
                    case 27: // QCOL
                        return CurrentItem.QCOL == null;
                    case 28: // GROW
                        return CurrentItem.GROW == null;
                    case 29: // GCOL
                        return CurrentItem.GCOL == null;
                    case 30: // LINK
                        return CurrentItem.LINK == null;
                    case 31: // COMPOSITE
                        return CurrentItem.COMPOSITE == null;
                    case 32: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 33: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 34: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // QKEY
                        return "QKEY";
                    case 2: // GKEY
                        return "GKEY";
                    case 3: // SUBJ
                        return "SUBJ";
                    case 4: // CLASS
                        return "CLASS";
                    case 5: // OCCUR
                        return "OCCUR";
                    case 6: // FREQ
                        return "FREQ";
                    case 7: // ROW_LABEL
                        return "ROW_LABEL";
                    case 8: // TIED
                        return "TIED";
                    case 9: // IDENT
                        return "IDENT";
                    case 10: // CLASS_SIZE
                        return "CLASS_SIZE";
                    case 11: // T1TEACH
                        return "T1TEACH";
                    case 12: // T2TEACH
                        return "T2TEACH";
                    case 13: // R1ROOM
                        return "R1ROOM";
                    case 14: // R2ROOM
                        return "R2ROOM";
                    case 15: // RESOURCES01
                        return "RESOURCES01";
                    case 16: // RESOURCES02
                        return "RESOURCES02";
                    case 17: // RESOURCES03
                        return "RESOURCES03";
                    case 18: // RESOURCES04
                        return "RESOURCES04";
                    case 19: // RESOURCES05
                        return "RESOURCES05";
                    case 20: // RESOURCES06
                        return "RESOURCES06";
                    case 21: // RESOURCES07
                        return "RESOURCES07";
                    case 22: // RESOURCES08
                        return "RESOURCES08";
                    case 23: // RESOURCES09
                        return "RESOURCES09";
                    case 24: // EXTRA_TEACH
                        return "EXTRA_TEACH";
                    case 25: // EXTRA_ROOM
                        return "EXTRA_ROOM";
                    case 26: // QROW
                        return "QROW";
                    case 27: // QCOL
                        return "QCOL";
                    case 28: // GROW
                        return "GROW";
                    case 29: // GCOL
                        return "GCOL";
                    case 30: // LINK
                        return "LINK";
                    case 31: // COMPOSITE
                        return "COMPOSITE";
                    case 32: // LW_DATE
                        return "LW_DATE";
                    case 33: // LW_TIME
                        return "LW_TIME";
                    case 34: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "QKEY":
                        return 1;
                    case "GKEY":
                        return 2;
                    case "SUBJ":
                        return 3;
                    case "CLASS":
                        return 4;
                    case "OCCUR":
                        return 5;
                    case "FREQ":
                        return 6;
                    case "ROW_LABEL":
                        return 7;
                    case "TIED":
                        return 8;
                    case "IDENT":
                        return 9;
                    case "CLASS_SIZE":
                        return 10;
                    case "T1TEACH":
                        return 11;
                    case "T2TEACH":
                        return 12;
                    case "R1ROOM":
                        return 13;
                    case "R2ROOM":
                        return 14;
                    case "RESOURCES01":
                        return 15;
                    case "RESOURCES02":
                        return 16;
                    case "RESOURCES03":
                        return 17;
                    case "RESOURCES04":
                        return 18;
                    case "RESOURCES05":
                        return 19;
                    case "RESOURCES06":
                        return 20;
                    case "RESOURCES07":
                        return 21;
                    case "RESOURCES08":
                        return 22;
                    case "RESOURCES09":
                        return 23;
                    case "EXTRA_TEACH":
                        return 24;
                    case "EXTRA_ROOM":
                        return 25;
                    case "QROW":
                        return 26;
                    case "QCOL":
                        return 27;
                    case "GROW":
                        return 28;
                    case "GCOL":
                        return 29;
                    case "LINK":
                        return 30;
                    case "COMPOSITE":
                        return 31;
                    case "LW_DATE":
                        return 32;
                    case "LW_TIME":
                        return 33;
                    case "LW_USER":
                        return 34;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
