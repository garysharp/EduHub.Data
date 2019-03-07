using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Grid Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTTGDataSet : EduHubDataSet<TTTG>
    {
        /// <inheritdoc />
        public override string Name { get { return "TTTG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TTTGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_IDENT = new Lazy<NullDictionary<int?, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.IDENT));
            Index_R1ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.R1ROOM));
            Index_R2ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.R2ROOM));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
            Index_T1TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.T1TEACH));
            Index_T2TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TTTG>>>(() => this.ToGroupedNullDictionary(i => i.T2TEACH));
            Index_TID = new Lazy<Dictionary<int, TTTG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTTG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTTG" /> fields for each CSV column header</returns>
        internal override Action<TTTG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTTG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
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
                    case "FIRST_CLASS":
                        mapper[i] = (e, v) => e.FIRST_CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NSET":
                        mapper[i] = (e, v) => e.NSET = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SIZE":
                        mapper[i] = (e, v) => e.CLASS_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXIMUM":
                        mapper[i] = (e, v) => e.MAXIMUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MINIMUM":
                        mapper[i] = (e, v) => e.MINIMUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MINLINE":
                        mapper[i] = (e, v) => e.MINLINE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXLINE":
                        mapper[i] = (e, v) => e.MAXLINE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MCOLOUR":
                        mapper[i] = (e, v) => e.MCOLOUR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOLOUR":
                        mapper[i] = (e, v) => e.GCOLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS":
                        mapper[i] = (e, v) => e.UNITS = v == null ? (short?)null : short.Parse(v);
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
                    case "LAB":
                        mapper[i] = (e, v) => e.LAB = v;
                        break;
                    case "FROW":
                        mapper[i] = (e, v) => e.FROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FCOL":
                        mapper[i] = (e, v) => e.FCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HROW":
                        mapper[i] = (e, v) => e.HROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HCOL":
                        mapper[i] = (e, v) => e.HCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BLOCK":
                        mapper[i] = (e, v) => e.BLOCK = v;
                        break;
                    case "LOCK":
                        mapper[i] = (e, v) => e.LOCK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TCHAIN":
                        mapper[i] = (e, v) => e.TCHAIN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LCHAIN":
                        mapper[i] = (e, v) => e.LCHAIN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIED_COL":
                        mapper[i] = (e, v) => e.TIED_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LINK_COL":
                        mapper[i] = (e, v) => e.LINK_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_ROW_CLASSES":
                        mapper[i] = (e, v) => e.MAX_ROW_CLASSES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROW_GROUP":
                        mapper[i] = (e, v) => e.ROW_GROUP = v;
                        break;
                    case "DOUBLE_PERIODS":
                        mapper[i] = (e, v) => e.DOUBLE_PERIODS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="TTTG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TTTG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TTTG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TTTG}"/> of entities</returns>
        internal override IEnumerable<TTTG> ApplyDeltaEntities(IEnumerable<TTTG> Entities, List<TTTG> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.GKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.GKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> Index_GKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<TTTG>>> Index_IDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_R1ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_R2ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_SUBJ;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_T1TEACH;
        private Lazy<NullDictionary<string, IReadOnlyList<TTTG>>> Index_T2TEACH;
        private Lazy<Dictionary<int, TTTG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTTG by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTTG by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTTG> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTTG> value;
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
        /// Find TTTG by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByIDENT(int? IDENT)
        {
            return Index_IDENT.Value[IDENT];
        }

        /// <summary>
        /// Attempt to find TTTG by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByIDENT(int? IDENT, out IReadOnlyList<TTTG> Value)
        {
            return Index_IDENT.Value.TryGetValue(IDENT, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by IDENT field
        /// </summary>
        /// <param name="IDENT">IDENT value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByIDENT(int? IDENT)
        {
            IReadOnlyList<TTTG> value;
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
        /// Find TTTG by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByR1ROOM(string R1ROOM)
        {
            return Index_R1ROOM.Value[R1ROOM];
        }

        /// <summary>
        /// Attempt to find TTTG by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR1ROOM(string R1ROOM, out IReadOnlyList<TTTG> Value)
        {
            return Index_R1ROOM.Value.TryGetValue(R1ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by R1ROOM field
        /// </summary>
        /// <param name="R1ROOM">R1ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByR1ROOM(string R1ROOM)
        {
            IReadOnlyList<TTTG> value;
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
        /// Find TTTG by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByR2ROOM(string R2ROOM)
        {
            return Index_R2ROOM.Value[R2ROOM];
        }

        /// <summary>
        /// Attempt to find TTTG by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByR2ROOM(string R2ROOM, out IReadOnlyList<TTTG> Value)
        {
            return Index_R2ROOM.Value.TryGetValue(R2ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by R2ROOM field
        /// </summary>
        /// <param name="R2ROOM">R2ROOM value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByR2ROOM(string R2ROOM)
        {
            IReadOnlyList<TTTG> value;
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
        /// Find TTTG by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TTTG by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TTTG> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TTTG> value;
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
        /// Find TTTG by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByT1TEACH(string T1TEACH)
        {
            return Index_T1TEACH.Value[T1TEACH];
        }

        /// <summary>
        /// Attempt to find TTTG by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT1TEACH(string T1TEACH, out IReadOnlyList<TTTG> Value)
        {
            return Index_T1TEACH.Value.TryGetValue(T1TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by T1TEACH field
        /// </summary>
        /// <param name="T1TEACH">T1TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByT1TEACH(string T1TEACH)
        {
            IReadOnlyList<TTTG> value;
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
        /// Find TTTG by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> FindByT2TEACH(string T2TEACH)
        {
            return Index_T2TEACH.Value[T2TEACH];
        }

        /// <summary>
        /// Attempt to find TTTG by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TTTG</param>
        /// <param name="Value">List of related TTTG entities</param>
        /// <returns>True if the list of related TTTG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByT2TEACH(string T2TEACH, out IReadOnlyList<TTTG> Value)
        {
            return Index_T2TEACH.Value.TryGetValue(T2TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by T2TEACH field
        /// </summary>
        /// <param name="T2TEACH">T2TEACH value used to find TTTG</param>
        /// <returns>List of related TTTG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTTG> TryFindByT2TEACH(string T2TEACH)
        {
            IReadOnlyList<TTTG> value;
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
        /// Find TTTG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTTG</param>
        /// <returns>Related TTTG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTTG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTTG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTTG</param>
        /// <param name="Value">Related TTTG entity</param>
        /// <returns>True if the related TTTG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTTG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTTG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTTG</param>
        /// <returns>Related TTTG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTTG TryFindByTID(int TID)
        {
            TTTG value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TTTG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTTG](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [SUBJ] varchar(5) NULL,
        [CLASS] smallint NULL,
        [FIRST_CLASS] smallint NULL,
        [NSET] smallint NULL,
        [IDENT] int NULL,
        [CLASS_SIZE] smallint NULL,
        [MAXIMUM] smallint NULL,
        [MINIMUM] smallint NULL,
        [MINLINE] smallint NULL,
        [MAXLINE] smallint NULL,
        [MCOLOUR] smallint NULL,
        [GCOLOUR] int NULL,
        [UNITS] smallint NULL,
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
        [LAB] varchar(5) NULL,
        [FROW] smallint NULL,
        [FCOL] smallint NULL,
        [HROW] smallint NULL,
        [HCOL] smallint NULL,
        [BLOCK] varchar(1) NULL,
        [LOCK] smallint NULL,
        [TCHAIN] smallint NULL,
        [LCHAIN] smallint NULL,
        [TIED_COL] smallint NULL,
        [LINK_COL] smallint NULL,
        [MAX_ROW_CLASSES] smallint NULL,
        [ROW_GROUP] varchar(2) NULL,
        [DOUBLE_PERIODS] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTTG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTTG_Index_GKEY] ON [dbo].[TTTG]
    (
            [GKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TTTG_Index_IDENT] ON [dbo].[TTTG]
    (
            [IDENT] ASC
    );
    CREATE NONCLUSTERED INDEX [TTTG_Index_R1ROOM] ON [dbo].[TTTG]
    (
            [R1ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TTTG_Index_R2ROOM] ON [dbo].[TTTG]
    (
            [R2ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TTTG_Index_SUBJ] ON [dbo].[TTTG]
    (
            [SUBJ] ASC
    );
    CREATE NONCLUSTERED INDEX [TTTG_Index_T1TEACH] ON [dbo].[TTTG]
    (
            [T1TEACH] ASC
    );
    CREATE NONCLUSTERED INDEX [TTTG_Index_T2TEACH] ON [dbo].[TTTG]
    (
            [T2TEACH] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_IDENT')
    ALTER INDEX [Index_IDENT] ON [dbo].[TTTG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_R1ROOM')
    ALTER INDEX [Index_R1ROOM] ON [dbo].[TTTG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_R2ROOM')
    ALTER INDEX [Index_R2ROOM] ON [dbo].[TTTG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_SUBJ')
    ALTER INDEX [Index_SUBJ] ON [dbo].[TTTG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_T1TEACH')
    ALTER INDEX [Index_T1TEACH] ON [dbo].[TTTG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_T2TEACH')
    ALTER INDEX [Index_T2TEACH] ON [dbo].[TTTG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTTG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_IDENT')
    ALTER INDEX [Index_IDENT] ON [dbo].[TTTG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_R1ROOM')
    ALTER INDEX [Index_R1ROOM] ON [dbo].[TTTG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_R2ROOM')
    ALTER INDEX [Index_R2ROOM] ON [dbo].[TTTG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_SUBJ')
    ALTER INDEX [Index_SUBJ] ON [dbo].[TTTG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_T1TEACH')
    ALTER INDEX [Index_T1TEACH] ON [dbo].[TTTG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_T2TEACH')
    ALTER INDEX [Index_T2TEACH] ON [dbo].[TTTG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTTG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTTG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TTTG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TTTG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TTTG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TTTG] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TTTG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTTG data set</returns>
        public override EduHubDataSetDataReader<TTTG> GetDataSetDataReader()
        {
            return new TTTGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTTG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTTG data set</returns>
        public override EduHubDataSetDataReader<TTTG> GetDataSetDataReader(List<TTTG> Entities)
        {
            return new TTTGDataReader(new EduHubDataSetLoadedReader<TTTG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTTGDataReader : EduHubDataSetDataReader<TTTG>
        {
            public TTTGDataReader(IEduHubDataSetReader<TTTG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 45; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // GKEY
                        return Current.GKEY;
                    case 2: // SUBJ
                        return Current.SUBJ;
                    case 3: // CLASS
                        return Current.CLASS;
                    case 4: // FIRST_CLASS
                        return Current.FIRST_CLASS;
                    case 5: // NSET
                        return Current.NSET;
                    case 6: // IDENT
                        return Current.IDENT;
                    case 7: // CLASS_SIZE
                        return Current.CLASS_SIZE;
                    case 8: // MAXIMUM
                        return Current.MAXIMUM;
                    case 9: // MINIMUM
                        return Current.MINIMUM;
                    case 10: // MINLINE
                        return Current.MINLINE;
                    case 11: // MAXLINE
                        return Current.MAXLINE;
                    case 12: // MCOLOUR
                        return Current.MCOLOUR;
                    case 13: // GCOLOUR
                        return Current.GCOLOUR;
                    case 14: // UNITS
                        return Current.UNITS;
                    case 15: // T1TEACH
                        return Current.T1TEACH;
                    case 16: // T2TEACH
                        return Current.T2TEACH;
                    case 17: // R1ROOM
                        return Current.R1ROOM;
                    case 18: // R2ROOM
                        return Current.R2ROOM;
                    case 19: // RESOURCES01
                        return Current.RESOURCES01;
                    case 20: // RESOURCES02
                        return Current.RESOURCES02;
                    case 21: // RESOURCES03
                        return Current.RESOURCES03;
                    case 22: // RESOURCES04
                        return Current.RESOURCES04;
                    case 23: // RESOURCES05
                        return Current.RESOURCES05;
                    case 24: // RESOURCES06
                        return Current.RESOURCES06;
                    case 25: // RESOURCES07
                        return Current.RESOURCES07;
                    case 26: // RESOURCES08
                        return Current.RESOURCES08;
                    case 27: // RESOURCES09
                        return Current.RESOURCES09;
                    case 28: // LAB
                        return Current.LAB;
                    case 29: // FROW
                        return Current.FROW;
                    case 30: // FCOL
                        return Current.FCOL;
                    case 31: // HROW
                        return Current.HROW;
                    case 32: // HCOL
                        return Current.HCOL;
                    case 33: // BLOCK
                        return Current.BLOCK;
                    case 34: // LOCK
                        return Current.LOCK;
                    case 35: // TCHAIN
                        return Current.TCHAIN;
                    case 36: // LCHAIN
                        return Current.LCHAIN;
                    case 37: // TIED_COL
                        return Current.TIED_COL;
                    case 38: // LINK_COL
                        return Current.LINK_COL;
                    case 39: // MAX_ROW_CLASSES
                        return Current.MAX_ROW_CLASSES;
                    case 40: // ROW_GROUP
                        return Current.ROW_GROUP;
                    case 41: // DOUBLE_PERIODS
                        return Current.DOUBLE_PERIODS;
                    case 42: // LW_DATE
                        return Current.LW_DATE;
                    case 43: // LW_TIME
                        return Current.LW_TIME;
                    case 44: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SUBJ
                        return Current.SUBJ == null;
                    case 3: // CLASS
                        return Current.CLASS == null;
                    case 4: // FIRST_CLASS
                        return Current.FIRST_CLASS == null;
                    case 5: // NSET
                        return Current.NSET == null;
                    case 6: // IDENT
                        return Current.IDENT == null;
                    case 7: // CLASS_SIZE
                        return Current.CLASS_SIZE == null;
                    case 8: // MAXIMUM
                        return Current.MAXIMUM == null;
                    case 9: // MINIMUM
                        return Current.MINIMUM == null;
                    case 10: // MINLINE
                        return Current.MINLINE == null;
                    case 11: // MAXLINE
                        return Current.MAXLINE == null;
                    case 12: // MCOLOUR
                        return Current.MCOLOUR == null;
                    case 13: // GCOLOUR
                        return Current.GCOLOUR == null;
                    case 14: // UNITS
                        return Current.UNITS == null;
                    case 15: // T1TEACH
                        return Current.T1TEACH == null;
                    case 16: // T2TEACH
                        return Current.T2TEACH == null;
                    case 17: // R1ROOM
                        return Current.R1ROOM == null;
                    case 18: // R2ROOM
                        return Current.R2ROOM == null;
                    case 19: // RESOURCES01
                        return Current.RESOURCES01 == null;
                    case 20: // RESOURCES02
                        return Current.RESOURCES02 == null;
                    case 21: // RESOURCES03
                        return Current.RESOURCES03 == null;
                    case 22: // RESOURCES04
                        return Current.RESOURCES04 == null;
                    case 23: // RESOURCES05
                        return Current.RESOURCES05 == null;
                    case 24: // RESOURCES06
                        return Current.RESOURCES06 == null;
                    case 25: // RESOURCES07
                        return Current.RESOURCES07 == null;
                    case 26: // RESOURCES08
                        return Current.RESOURCES08 == null;
                    case 27: // RESOURCES09
                        return Current.RESOURCES09 == null;
                    case 28: // LAB
                        return Current.LAB == null;
                    case 29: // FROW
                        return Current.FROW == null;
                    case 30: // FCOL
                        return Current.FCOL == null;
                    case 31: // HROW
                        return Current.HROW == null;
                    case 32: // HCOL
                        return Current.HCOL == null;
                    case 33: // BLOCK
                        return Current.BLOCK == null;
                    case 34: // LOCK
                        return Current.LOCK == null;
                    case 35: // TCHAIN
                        return Current.TCHAIN == null;
                    case 36: // LCHAIN
                        return Current.LCHAIN == null;
                    case 37: // TIED_COL
                        return Current.TIED_COL == null;
                    case 38: // LINK_COL
                        return Current.LINK_COL == null;
                    case 39: // MAX_ROW_CLASSES
                        return Current.MAX_ROW_CLASSES == null;
                    case 40: // ROW_GROUP
                        return Current.ROW_GROUP == null;
                    case 41: // DOUBLE_PERIODS
                        return Current.DOUBLE_PERIODS == null;
                    case 42: // LW_DATE
                        return Current.LW_DATE == null;
                    case 43: // LW_TIME
                        return Current.LW_TIME == null;
                    case 44: // LW_USER
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
                    case 1: // GKEY
                        return "GKEY";
                    case 2: // SUBJ
                        return "SUBJ";
                    case 3: // CLASS
                        return "CLASS";
                    case 4: // FIRST_CLASS
                        return "FIRST_CLASS";
                    case 5: // NSET
                        return "NSET";
                    case 6: // IDENT
                        return "IDENT";
                    case 7: // CLASS_SIZE
                        return "CLASS_SIZE";
                    case 8: // MAXIMUM
                        return "MAXIMUM";
                    case 9: // MINIMUM
                        return "MINIMUM";
                    case 10: // MINLINE
                        return "MINLINE";
                    case 11: // MAXLINE
                        return "MAXLINE";
                    case 12: // MCOLOUR
                        return "MCOLOUR";
                    case 13: // GCOLOUR
                        return "GCOLOUR";
                    case 14: // UNITS
                        return "UNITS";
                    case 15: // T1TEACH
                        return "T1TEACH";
                    case 16: // T2TEACH
                        return "T2TEACH";
                    case 17: // R1ROOM
                        return "R1ROOM";
                    case 18: // R2ROOM
                        return "R2ROOM";
                    case 19: // RESOURCES01
                        return "RESOURCES01";
                    case 20: // RESOURCES02
                        return "RESOURCES02";
                    case 21: // RESOURCES03
                        return "RESOURCES03";
                    case 22: // RESOURCES04
                        return "RESOURCES04";
                    case 23: // RESOURCES05
                        return "RESOURCES05";
                    case 24: // RESOURCES06
                        return "RESOURCES06";
                    case 25: // RESOURCES07
                        return "RESOURCES07";
                    case 26: // RESOURCES08
                        return "RESOURCES08";
                    case 27: // RESOURCES09
                        return "RESOURCES09";
                    case 28: // LAB
                        return "LAB";
                    case 29: // FROW
                        return "FROW";
                    case 30: // FCOL
                        return "FCOL";
                    case 31: // HROW
                        return "HROW";
                    case 32: // HCOL
                        return "HCOL";
                    case 33: // BLOCK
                        return "BLOCK";
                    case 34: // LOCK
                        return "LOCK";
                    case 35: // TCHAIN
                        return "TCHAIN";
                    case 36: // LCHAIN
                        return "LCHAIN";
                    case 37: // TIED_COL
                        return "TIED_COL";
                    case 38: // LINK_COL
                        return "LINK_COL";
                    case 39: // MAX_ROW_CLASSES
                        return "MAX_ROW_CLASSES";
                    case 40: // ROW_GROUP
                        return "ROW_GROUP";
                    case 41: // DOUBLE_PERIODS
                        return "DOUBLE_PERIODS";
                    case 42: // LW_DATE
                        return "LW_DATE";
                    case 43: // LW_TIME
                        return "LW_TIME";
                    case 44: // LW_USER
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
                    case "GKEY":
                        return 1;
                    case "SUBJ":
                        return 2;
                    case "CLASS":
                        return 3;
                    case "FIRST_CLASS":
                        return 4;
                    case "NSET":
                        return 5;
                    case "IDENT":
                        return 6;
                    case "CLASS_SIZE":
                        return 7;
                    case "MAXIMUM":
                        return 8;
                    case "MINIMUM":
                        return 9;
                    case "MINLINE":
                        return 10;
                    case "MAXLINE":
                        return 11;
                    case "MCOLOUR":
                        return 12;
                    case "GCOLOUR":
                        return 13;
                    case "UNITS":
                        return 14;
                    case "T1TEACH":
                        return 15;
                    case "T2TEACH":
                        return 16;
                    case "R1ROOM":
                        return 17;
                    case "R2ROOM":
                        return 18;
                    case "RESOURCES01":
                        return 19;
                    case "RESOURCES02":
                        return 20;
                    case "RESOURCES03":
                        return 21;
                    case "RESOURCES04":
                        return 22;
                    case "RESOURCES05":
                        return 23;
                    case "RESOURCES06":
                        return 24;
                    case "RESOURCES07":
                        return 25;
                    case "RESOURCES08":
                        return 26;
                    case "RESOURCES09":
                        return 27;
                    case "LAB":
                        return 28;
                    case "FROW":
                        return 29;
                    case "FCOL":
                        return 30;
                    case "HROW":
                        return 31;
                    case "HCOL":
                        return 32;
                    case "BLOCK":
                        return 33;
                    case "LOCK":
                        return 34;
                    case "TCHAIN":
                        return 35;
                    case "LCHAIN":
                        return 36;
                    case "TIED_COL":
                        return 37;
                    case "LINK_COL":
                        return 38;
                    case "MAX_ROW_CLASSES":
                        return 39;
                    case "ROW_GROUP":
                        return 40;
                    case "DOUBLE_PERIODS":
                        return 41;
                    case "LW_DATE":
                        return 42;
                    case "LW_TIME":
                        return 43;
                    case "LW_USER":
                        return 44;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
