using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Entries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THTQDataSet : SetBase<THTQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "THTQ"; } }

        internal THTQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedDictionary(i => i.QKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_TID = new Lazy<Dictionary<int, THTQ>>(() => this.ToDictionary(i => i.TID));
            Index_GKEY = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.GKEY));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_IDENT = new Lazy<NullDictionary<int?, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.IDENT));
            Index_T1TEACH = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.T1TEACH));
            Index_T2TEACH = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.T2TEACH));
            Index_R1ROOM = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.R1ROOM));
            Index_R2ROOM = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.R2ROOM));
            Index_EXTRA_TEACH = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.EXTRA_TEACH));
            Index_EXTRA_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<THTQ>>>(() => this.ToGroupedNullDictionary(i => i.EXTRA_ROOM));
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

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> Index_QKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<THTQ>>> Index_LW_DATE;
        private Lazy<Dictionary<int, THTQ>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_GKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_SUBJ;
        private Lazy<NullDictionary<int?, IReadOnlyList<THTQ>>> Index_IDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_T1TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_T2TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_R1ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_R2ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_EXTRA_TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<THTQ>>> Index_EXTRA_ROOM;

        #endregion

        #region Index Methods

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

        #endregion

    }
}
