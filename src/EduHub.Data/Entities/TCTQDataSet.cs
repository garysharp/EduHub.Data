using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Class Information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTQDataSet : EduHubDataSet<TCTQ>
    {
        /// <inheritdoc />
        public override string Name { get { return "TCTQ"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

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
        internal override Action<TCTQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
        /// <param name="Entities">Iterator for base <see cref="TCTQ" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TCTQ" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TCTQ}"/> of entities</returns>
        internal override IEnumerable<TCTQ> ApplyDeltaEntities(IEnumerable<TCTQ> Entities, List<TCTQ> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TCTQKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TCTQKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
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

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TCTQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCTQ](
        [TID] int IDENTITY NOT NULL,
        [TCTQKEY] datetime NOT NULL,
        [QKEY] varchar(8) NULL,
        [SUBJ] varchar(5) NULL,
        [CLASS] smallint NULL,
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
        [COMPOSITE] smallint NULL,
        [GKEY] varchar(8) NULL,
        [GROW] smallint NULL,
        [GCOL] smallint NULL,
        [GCOLOUR] int NULL,
        [OCCUR] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCTQ_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_COMPOSITE] ON [dbo].[TCTQ]
    (
            [COMPOSITE] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_EXTRA_ROOM] ON [dbo].[TCTQ]
    (
            [EXTRA_ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_EXTRA_TEACH] ON [dbo].[TCTQ]
    (
            [EXTRA_TEACH] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_GKEY] ON [dbo].[TCTQ]
    (
            [GKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_QKEY] ON [dbo].[TCTQ]
    (
            [QKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_R1ROOM] ON [dbo].[TCTQ]
    (
            [R1ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_R2ROOM] ON [dbo].[TCTQ]
    (
            [R2ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_SUBJ] ON [dbo].[TCTQ]
    (
            [SUBJ] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_T1TEACH] ON [dbo].[TCTQ]
    (
            [T1TEACH] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTQ_Index_T2TEACH] ON [dbo].[TCTQ]
    (
            [T2TEACH] ASC
    );
    CREATE CLUSTERED INDEX [TCTQ_Index_TCTQKEY] ON [dbo].[TCTQ]
    (
            [TCTQKEY] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_COMPOSITE')
    ALTER INDEX [Index_COMPOSITE] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_EXTRA_ROOM')
    ALTER INDEX [Index_EXTRA_ROOM] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_EXTRA_TEACH')
    ALTER INDEX [Index_EXTRA_TEACH] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_GKEY')
    ALTER INDEX [Index_GKEY] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_QKEY')
    ALTER INDEX [Index_QKEY] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_R1ROOM')
    ALTER INDEX [Index_R1ROOM] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_R2ROOM')
    ALTER INDEX [Index_R2ROOM] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_SUBJ')
    ALTER INDEX [Index_SUBJ] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_T1TEACH')
    ALTER INDEX [Index_T1TEACH] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_T2TEACH')
    ALTER INDEX [Index_T2TEACH] ON [dbo].[TCTQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TCTQ] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_COMPOSITE')
    ALTER INDEX [Index_COMPOSITE] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_EXTRA_ROOM')
    ALTER INDEX [Index_EXTRA_ROOM] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_EXTRA_TEACH')
    ALTER INDEX [Index_EXTRA_TEACH] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_GKEY')
    ALTER INDEX [Index_GKEY] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_QKEY')
    ALTER INDEX [Index_QKEY] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_R1ROOM')
    ALTER INDEX [Index_R1ROOM] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_R2ROOM')
    ALTER INDEX [Index_R2ROOM] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_SUBJ')
    ALTER INDEX [Index_SUBJ] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_T1TEACH')
    ALTER INDEX [Index_T1TEACH] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_T2TEACH')
    ALTER INDEX [Index_T2TEACH] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTQ]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TCTQ] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TCTQ"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TCTQ"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TCTQ> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TCTQ] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCTQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTQ data set</returns>
        public override EduHubDataSetDataReader<TCTQ> GetDataSetDataReader()
        {
            return new TCTQDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCTQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTQ data set</returns>
        public override EduHubDataSetDataReader<TCTQ> GetDataSetDataReader(List<TCTQ> Entities)
        {
            return new TCTQDataReader(new EduHubDataSetLoadedReader<TCTQ>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCTQDataReader : EduHubDataSetDataReader<TCTQ>
        {
            public TCTQDataReader(IEduHubDataSetReader<TCTQ> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 33; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // TCTQKEY
                        return Current.TCTQKEY;
                    case 2: // QKEY
                        return Current.QKEY;
                    case 3: // SUBJ
                        return Current.SUBJ;
                    case 4: // CLASS
                        return Current.CLASS;
                    case 5: // IDENT
                        return Current.IDENT;
                    case 6: // CLASS_SIZE
                        return Current.CLASS_SIZE;
                    case 7: // T1TEACH
                        return Current.T1TEACH;
                    case 8: // T2TEACH
                        return Current.T2TEACH;
                    case 9: // R1ROOM
                        return Current.R1ROOM;
                    case 10: // R2ROOM
                        return Current.R2ROOM;
                    case 11: // RESOURCES01
                        return Current.RESOURCES01;
                    case 12: // RESOURCES02
                        return Current.RESOURCES02;
                    case 13: // RESOURCES03
                        return Current.RESOURCES03;
                    case 14: // RESOURCES04
                        return Current.RESOURCES04;
                    case 15: // RESOURCES05
                        return Current.RESOURCES05;
                    case 16: // RESOURCES06
                        return Current.RESOURCES06;
                    case 17: // RESOURCES07
                        return Current.RESOURCES07;
                    case 18: // RESOURCES08
                        return Current.RESOURCES08;
                    case 19: // RESOURCES09
                        return Current.RESOURCES09;
                    case 20: // EXTRA_TEACH
                        return Current.EXTRA_TEACH;
                    case 21: // EXTRA_ROOM
                        return Current.EXTRA_ROOM;
                    case 22: // QROW
                        return Current.QROW;
                    case 23: // QCOL
                        return Current.QCOL;
                    case 24: // COMPOSITE
                        return Current.COMPOSITE;
                    case 25: // GKEY
                        return Current.GKEY;
                    case 26: // GROW
                        return Current.GROW;
                    case 27: // GCOL
                        return Current.GCOL;
                    case 28: // GCOLOUR
                        return Current.GCOLOUR;
                    case 29: // OCCUR
                        return Current.OCCUR;
                    case 30: // LW_DATE
                        return Current.LW_DATE;
                    case 31: // LW_TIME
                        return Current.LW_TIME;
                    case 32: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // QKEY
                        return Current.QKEY == null;
                    case 3: // SUBJ
                        return Current.SUBJ == null;
                    case 4: // CLASS
                        return Current.CLASS == null;
                    case 5: // IDENT
                        return Current.IDENT == null;
                    case 6: // CLASS_SIZE
                        return Current.CLASS_SIZE == null;
                    case 7: // T1TEACH
                        return Current.T1TEACH == null;
                    case 8: // T2TEACH
                        return Current.T2TEACH == null;
                    case 9: // R1ROOM
                        return Current.R1ROOM == null;
                    case 10: // R2ROOM
                        return Current.R2ROOM == null;
                    case 11: // RESOURCES01
                        return Current.RESOURCES01 == null;
                    case 12: // RESOURCES02
                        return Current.RESOURCES02 == null;
                    case 13: // RESOURCES03
                        return Current.RESOURCES03 == null;
                    case 14: // RESOURCES04
                        return Current.RESOURCES04 == null;
                    case 15: // RESOURCES05
                        return Current.RESOURCES05 == null;
                    case 16: // RESOURCES06
                        return Current.RESOURCES06 == null;
                    case 17: // RESOURCES07
                        return Current.RESOURCES07 == null;
                    case 18: // RESOURCES08
                        return Current.RESOURCES08 == null;
                    case 19: // RESOURCES09
                        return Current.RESOURCES09 == null;
                    case 20: // EXTRA_TEACH
                        return Current.EXTRA_TEACH == null;
                    case 21: // EXTRA_ROOM
                        return Current.EXTRA_ROOM == null;
                    case 22: // QROW
                        return Current.QROW == null;
                    case 23: // QCOL
                        return Current.QCOL == null;
                    case 24: // COMPOSITE
                        return Current.COMPOSITE == null;
                    case 25: // GKEY
                        return Current.GKEY == null;
                    case 26: // GROW
                        return Current.GROW == null;
                    case 27: // GCOL
                        return Current.GCOL == null;
                    case 28: // GCOLOUR
                        return Current.GCOLOUR == null;
                    case 29: // OCCUR
                        return Current.OCCUR == null;
                    case 30: // LW_DATE
                        return Current.LW_DATE == null;
                    case 31: // LW_TIME
                        return Current.LW_TIME == null;
                    case 32: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // TCTQKEY
                        return "TCTQKEY";
                    case 2: // QKEY
                        return "QKEY";
                    case 3: // SUBJ
                        return "SUBJ";
                    case 4: // CLASS
                        return "CLASS";
                    case 5: // IDENT
                        return "IDENT";
                    case 6: // CLASS_SIZE
                        return "CLASS_SIZE";
                    case 7: // T1TEACH
                        return "T1TEACH";
                    case 8: // T2TEACH
                        return "T2TEACH";
                    case 9: // R1ROOM
                        return "R1ROOM";
                    case 10: // R2ROOM
                        return "R2ROOM";
                    case 11: // RESOURCES01
                        return "RESOURCES01";
                    case 12: // RESOURCES02
                        return "RESOURCES02";
                    case 13: // RESOURCES03
                        return "RESOURCES03";
                    case 14: // RESOURCES04
                        return "RESOURCES04";
                    case 15: // RESOURCES05
                        return "RESOURCES05";
                    case 16: // RESOURCES06
                        return "RESOURCES06";
                    case 17: // RESOURCES07
                        return "RESOURCES07";
                    case 18: // RESOURCES08
                        return "RESOURCES08";
                    case 19: // RESOURCES09
                        return "RESOURCES09";
                    case 20: // EXTRA_TEACH
                        return "EXTRA_TEACH";
                    case 21: // EXTRA_ROOM
                        return "EXTRA_ROOM";
                    case 22: // QROW
                        return "QROW";
                    case 23: // QCOL
                        return "QCOL";
                    case 24: // COMPOSITE
                        return "COMPOSITE";
                    case 25: // GKEY
                        return "GKEY";
                    case 26: // GROW
                        return "GROW";
                    case 27: // GCOL
                        return "GCOL";
                    case 28: // GCOLOUR
                        return "GCOLOUR";
                    case 29: // OCCUR
                        return "OCCUR";
                    case 30: // LW_DATE
                        return "LW_DATE";
                    case 31: // LW_TIME
                        return "LW_TIME";
                    case 32: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "TCTQKEY":
                        return 1;
                    case "QKEY":
                        return 2;
                    case "SUBJ":
                        return 3;
                    case "CLASS":
                        return 4;
                    case "IDENT":
                        return 5;
                    case "CLASS_SIZE":
                        return 6;
                    case "T1TEACH":
                        return 7;
                    case "T2TEACH":
                        return 8;
                    case "R1ROOM":
                        return 9;
                    case "R2ROOM":
                        return 10;
                    case "RESOURCES01":
                        return 11;
                    case "RESOURCES02":
                        return 12;
                    case "RESOURCES03":
                        return 13;
                    case "RESOURCES04":
                        return 14;
                    case "RESOURCES05":
                        return 15;
                    case "RESOURCES06":
                        return 16;
                    case "RESOURCES07":
                        return 17;
                    case "RESOURCES08":
                        return 18;
                    case "RESOURCES09":
                        return 19;
                    case "EXTRA_TEACH":
                        return 20;
                    case "EXTRA_ROOM":
                        return 21;
                    case "QROW":
                        return 22;
                    case "QCOL":
                        return 23;
                    case "COMPOSITE":
                        return 24;
                    case "GKEY":
                        return 25;
                    case "GROW":
                        return 26;
                    case "GCOL":
                        return 27;
                    case "GCOLOUR":
                        return 28;
                    case "OCCUR":
                        return 29;
                    case "LW_DATE":
                        return 30;
                    case "LW_TIME":
                        return 31;
                    case "LW_USER":
                        return 32;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
