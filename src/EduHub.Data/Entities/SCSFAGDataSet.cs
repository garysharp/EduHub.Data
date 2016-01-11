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
    /// CSF Data Aggregates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCSFAGDataSet : EduHubDataSet<SCSFAG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCSFAG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SCSFAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCSFKEY = new Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>>(() => this.ToGroupedDictionary(i => i.SCSFKEY));
            Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY = new Lazy<Dictionary<Tuple<string, string, int?, string, string>, SCSFAG>>(() => this.ToDictionary(i => Tuple.Create(i.SCSFKEY, i.YEAR_SEMESTER, i.ST_CAMPUS, i.ST_YEAR_LEVEL, i.ST_CATEGORY)));
            Index_ST_YEAR_LEVEL = new Lazy<NullDictionary<string, IReadOnlyList<SCSFAG>>>(() => this.ToGroupedNullDictionary(i => i.ST_YEAR_LEVEL));
            Index_TID = new Lazy<Dictionary<int, SCSFAG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSFAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSFAG" /> fields for each CSV column header</returns>
        internal override Action<SCSFAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCSFAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "ST_CAMPUS":
                        mapper[i] = (e, v) => e.ST_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ST_CATEGORY":
                        mapper[i] = (e, v) => e.ST_CATEGORY = v;
                        break;
                    case "TOTAL_IN_GROUP":
                        mapper[i] = (e, v) => e.TOTAL_IN_GROUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT01":
                        mapper[i] = (e, v) => e.NUMBER_AT01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT02":
                        mapper[i] = (e, v) => e.NUMBER_AT02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT03":
                        mapper[i] = (e, v) => e.NUMBER_AT03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT04":
                        mapper[i] = (e, v) => e.NUMBER_AT04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT05":
                        mapper[i] = (e, v) => e.NUMBER_AT05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT06":
                        mapper[i] = (e, v) => e.NUMBER_AT06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT07":
                        mapper[i] = (e, v) => e.NUMBER_AT07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT08":
                        mapper[i] = (e, v) => e.NUMBER_AT08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT09":
                        mapper[i] = (e, v) => e.NUMBER_AT09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT10":
                        mapper[i] = (e, v) => e.NUMBER_AT10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT11":
                        mapper[i] = (e, v) => e.NUMBER_AT11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT12":
                        mapper[i] = (e, v) => e.NUMBER_AT12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT13":
                        mapper[i] = (e, v) => e.NUMBER_AT13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT14":
                        mapper[i] = (e, v) => e.NUMBER_AT14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT15":
                        mapper[i] = (e, v) => e.NUMBER_AT15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT16":
                        mapper[i] = (e, v) => e.NUMBER_AT16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT17":
                        mapper[i] = (e, v) => e.NUMBER_AT17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT18":
                        mapper[i] = (e, v) => e.NUMBER_AT18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT19":
                        mapper[i] = (e, v) => e.NUMBER_AT19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT20":
                        mapper[i] = (e, v) => e.NUMBER_AT20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT21":
                        mapper[i] = (e, v) => e.NUMBER_AT21 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT22":
                        mapper[i] = (e, v) => e.NUMBER_AT22 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT23":
                        mapper[i] = (e, v) => e.NUMBER_AT23 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT24":
                        mapper[i] = (e, v) => e.NUMBER_AT24 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT25":
                        mapper[i] = (e, v) => e.NUMBER_AT25 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT26":
                        mapper[i] = (e, v) => e.NUMBER_AT26 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT27":
                        mapper[i] = (e, v) => e.NUMBER_AT27 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT28":
                        mapper[i] = (e, v) => e.NUMBER_AT28 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_MEAN":
                        mapper[i] = (e, v) => e.SCHOOL_MEAN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MIN":
                        mapper[i] = (e, v) => e.SCHOOL_MIN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MAX":
                        mapper[i] = (e, v) => e.SCHOOL_MAX = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_15TH":
                        mapper[i] = (e, v) => e.SCHOOL_15TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_25TH":
                        mapper[i] = (e, v) => e.SCHOOL_25TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_75TH":
                        mapper[i] = (e, v) => e.SCHOOL_75TH = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SCSFAG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCSFAG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCSFAG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCSFAG}"/> of entities</returns>
        internal override IEnumerable<SCSFAG> ApplyDeltaEntities(IEnumerable<SCSFAG> Entities, List<SCSFAG> DeltaEntities)
        {
            HashSet<Tuple<string, string, int?, string, string>> Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY = new HashSet<Tuple<string, string, int?, string, string>>(DeltaEntities.Select(i => Tuple.Create(i.SCSFKEY, i.YEAR_SEMESTER, i.ST_CAMPUS, i.ST_YEAR_LEVEL, i.ST_CATEGORY)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCSFKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Remove(Tuple.Create(entity.SCSFKEY, entity.YEAR_SEMESTER, entity.ST_CAMPUS, entity.ST_YEAR_LEVEL, entity.ST_CATEGORY));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.SCSFKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>> Index_SCSFKEY;
        private Lazy<Dictionary<Tuple<string, string, int?, string, string>, SCSFAG>> Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<SCSFAG>>> Index_ST_YEAR_LEVEL;
        private Lazy<Dictionary<int, SCSFAG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> FindBySCSFKEY(string SCSFKEY)
        {
            return Index_SCSFKEY.Value[SCSFKEY];
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="Value">List of related SCSFAG entities</param>
        /// <returns>True if the list of related SCSFAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY(string SCSFKEY, out IReadOnlyList<SCSFAG> Value)
        {
            return Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> TryFindBySCSFKEY(string SCSFKEY)
        {
            IReadOnlyList<SCSFAG> value;
            if (Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG FindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY)
        {
            return Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value[Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY)];
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <param name="Value">Related SCSFAG entity</param>
        /// <returns>True if the related SCSFAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY, out SCSFAG Value)
        {
            return Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value.TryGetValue(Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY), out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL and ST_CATEGORY fields
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG</param>
        /// <param name="YEAR_SEMESTER">YEAR_SEMESTER value used to find SCSFAG</param>
        /// <param name="ST_CAMPUS">ST_CAMPUS value used to find SCSFAG</param>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="ST_CATEGORY">ST_CATEGORY value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG TryFindBySCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY(string SCSFKEY, string YEAR_SEMESTER, int? ST_CAMPUS, string ST_YEAR_LEVEL, string ST_CATEGORY)
        {
            SCSFAG value;
            if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Value.TryGetValue(Tuple.Create(SCSFKEY, YEAR_SEMESTER, ST_CAMPUS, ST_YEAR_LEVEL, ST_CATEGORY), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> FindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            return Index_ST_YEAR_LEVEL.Value[ST_YEAR_LEVEL];
        }

        /// <summary>
        /// Attempt to find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <param name="Value">List of related SCSFAG entities</param>
        /// <returns>True if the list of related SCSFAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL, out IReadOnlyList<SCSFAG> Value)
        {
            return Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SCSFAG</param>
        /// <returns>List of related SCSFAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCSFAG> TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            IReadOnlyList<SCSFAG> value;
            if (Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <param name="Value">Related SCSFAG entity</param>
        /// <returns>True if the related SCSFAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SCSFAG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SCSFAG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCSFAG</param>
        /// <returns>Related SCSFAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSFAG TryFindByTID(int TID)
        {
            SCSFAG value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCSFAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCSFAG](
        [TID] int IDENTITY NOT NULL,
        [SCSFKEY] varchar(5) NOT NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [ST_CAMPUS] int NULL,
        [ST_YEAR_LEVEL] varchar(4) NULL,
        [ST_CATEGORY] varchar(2) NULL,
        [TOTAL_IN_GROUP] smallint NULL,
        [NUMBER_AT01] smallint NULL,
        [NUMBER_AT02] smallint NULL,
        [NUMBER_AT03] smallint NULL,
        [NUMBER_AT04] smallint NULL,
        [NUMBER_AT05] smallint NULL,
        [NUMBER_AT06] smallint NULL,
        [NUMBER_AT07] smallint NULL,
        [NUMBER_AT08] smallint NULL,
        [NUMBER_AT09] smallint NULL,
        [NUMBER_AT10] smallint NULL,
        [NUMBER_AT11] smallint NULL,
        [NUMBER_AT12] smallint NULL,
        [NUMBER_AT13] smallint NULL,
        [NUMBER_AT14] smallint NULL,
        [NUMBER_AT15] smallint NULL,
        [NUMBER_AT16] smallint NULL,
        [NUMBER_AT17] smallint NULL,
        [NUMBER_AT18] smallint NULL,
        [NUMBER_AT19] smallint NULL,
        [NUMBER_AT20] smallint NULL,
        [NUMBER_AT21] smallint NULL,
        [NUMBER_AT22] smallint NULL,
        [NUMBER_AT23] smallint NULL,
        [NUMBER_AT24] smallint NULL,
        [NUMBER_AT25] smallint NULL,
        [NUMBER_AT26] smallint NULL,
        [NUMBER_AT27] smallint NULL,
        [NUMBER_AT28] smallint NULL,
        [SCHOOL_MEAN] float NULL,
        [SCHOOL_MIN] float NULL,
        [SCHOOL_MAX] float NULL,
        [SCHOOL_15TH] float NULL,
        [SCHOOL_25TH] float NULL,
        [SCHOOL_75TH] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCSFAG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SCSFAG_Index_SCSFKEY] ON [dbo].[SCSFAG]
    (
            [SCSFKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SCSFAG_Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY] ON [dbo].[SCSFAG]
    (
            [SCSFKEY] ASC,
            [YEAR_SEMESTER] ASC,
            [ST_CAMPUS] ASC,
            [ST_YEAR_LEVEL] ASC,
            [ST_CATEGORY] ASC
    );
    CREATE NONCLUSTERED INDEX [SCSFAG_Index_ST_YEAR_LEVEL] ON [dbo].[SCSFAG]
    (
            [ST_YEAR_LEVEL] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND name = N'Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY')
    ALTER INDEX [Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY] ON [dbo].[SCSFAG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND name = N'Index_ST_YEAR_LEVEL')
    ALTER INDEX [Index_ST_YEAR_LEVEL] ON [dbo].[SCSFAG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SCSFAG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND name = N'Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY')
    ALTER INDEX [Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY] ON [dbo].[SCSFAG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND name = N'Index_ST_YEAR_LEVEL')
    ALTER INDEX [Index_ST_YEAR_LEVEL] ON [dbo].[SCSFAG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCSFAG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SCSFAG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCSFAG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCSFAG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCSFAG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string, int?, string, string>> Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY = new List<Tuple<string, string, int?, string, string>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Add(Tuple.Create(entity.SCSFKEY, entity.YEAR_SEMESTER, entity.ST_CAMPUS, entity.ST_YEAR_LEVEL, entity.ST_CATEGORY));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SCSFAG] WHERE");


            // Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY
            builder.Append("(");
            for (int index = 0; index < Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // SCSFKEY
                var parameterSCSFKEY = $"@p{parameterIndex++}";
                builder.Append("([SCSFKEY]=").Append(parameterSCSFKEY);
                command.Parameters.Add(parameterSCSFKEY, SqlDbType.VarChar, 5).Value = Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item1;

                // YEAR_SEMESTER
                if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item2 == null)
                {
                    builder.Append(" AND [YEAR_SEMESTER] IS NULL");
                }
                else
                {
                    var parameterYEAR_SEMESTER = $"@p{parameterIndex++}";
                    builder.Append(" AND [YEAR_SEMESTER]=").Append(parameterYEAR_SEMESTER);
                    command.Parameters.Add(parameterYEAR_SEMESTER, SqlDbType.VarChar, 6).Value = Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item2;
                }

                // ST_CAMPUS
                if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item3 == null)
                {
                    builder.Append(" AND [ST_CAMPUS] IS NULL");
                }
                else
                {
                    var parameterST_CAMPUS = $"@p{parameterIndex++}";
                    builder.Append(" AND [ST_CAMPUS]=").Append(parameterST_CAMPUS);
                    command.Parameters.Add(parameterST_CAMPUS, SqlDbType.Int).Value = Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item3;
                }

                // ST_YEAR_LEVEL
                if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item4 == null)
                {
                    builder.Append(" AND [ST_YEAR_LEVEL] IS NULL");
                }
                else
                {
                    var parameterST_YEAR_LEVEL = $"@p{parameterIndex++}";
                    builder.Append(" AND [ST_YEAR_LEVEL]=").Append(parameterST_YEAR_LEVEL);
                    command.Parameters.Add(parameterST_YEAR_LEVEL, SqlDbType.VarChar, 4).Value = Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item4;
                }

                // ST_CATEGORY
                if (Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item5 == null)
                {
                    builder.Append(" AND [ST_CATEGORY] IS NULL)");
                }
                else
                {
                    var parameterST_CATEGORY = $"@p{parameterIndex++}";
                    builder.Append(" AND [ST_CATEGORY]=").Append(parameterST_CATEGORY).Append(")");
                    command.Parameters.Add(parameterST_CATEGORY, SqlDbType.VarChar, 2).Value = Index_SCSFKEY_YEAR_SEMESTER_ST_CAMPUS_ST_YEAR_LEVEL_ST_CATEGORY[index].Item5;
                }
            }
            builder.AppendLine(") OR");

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
        /// Provides a <see cref="IDataReader"/> for the SCSFAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCSFAG data set</returns>
        public override EduHubDataSetDataReader<SCSFAG> GetDataSetDataReader()
        {
            return new SCSFAGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCSFAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCSFAG data set</returns>
        public override EduHubDataSetDataReader<SCSFAG> GetDataSetDataReader(List<SCSFAG> Entities)
        {
            return new SCSFAGDataReader(new EduHubDataSetLoadedReader<SCSFAG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCSFAGDataReader : EduHubDataSetDataReader<SCSFAG>
        {
            public SCSFAGDataReader(IEduHubDataSetReader<SCSFAG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 44; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SCSFKEY
                        return Current.SCSFKEY;
                    case 2: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER;
                    case 3: // ST_CAMPUS
                        return Current.ST_CAMPUS;
                    case 4: // ST_YEAR_LEVEL
                        return Current.ST_YEAR_LEVEL;
                    case 5: // ST_CATEGORY
                        return Current.ST_CATEGORY;
                    case 6: // TOTAL_IN_GROUP
                        return Current.TOTAL_IN_GROUP;
                    case 7: // NUMBER_AT01
                        return Current.NUMBER_AT01;
                    case 8: // NUMBER_AT02
                        return Current.NUMBER_AT02;
                    case 9: // NUMBER_AT03
                        return Current.NUMBER_AT03;
                    case 10: // NUMBER_AT04
                        return Current.NUMBER_AT04;
                    case 11: // NUMBER_AT05
                        return Current.NUMBER_AT05;
                    case 12: // NUMBER_AT06
                        return Current.NUMBER_AT06;
                    case 13: // NUMBER_AT07
                        return Current.NUMBER_AT07;
                    case 14: // NUMBER_AT08
                        return Current.NUMBER_AT08;
                    case 15: // NUMBER_AT09
                        return Current.NUMBER_AT09;
                    case 16: // NUMBER_AT10
                        return Current.NUMBER_AT10;
                    case 17: // NUMBER_AT11
                        return Current.NUMBER_AT11;
                    case 18: // NUMBER_AT12
                        return Current.NUMBER_AT12;
                    case 19: // NUMBER_AT13
                        return Current.NUMBER_AT13;
                    case 20: // NUMBER_AT14
                        return Current.NUMBER_AT14;
                    case 21: // NUMBER_AT15
                        return Current.NUMBER_AT15;
                    case 22: // NUMBER_AT16
                        return Current.NUMBER_AT16;
                    case 23: // NUMBER_AT17
                        return Current.NUMBER_AT17;
                    case 24: // NUMBER_AT18
                        return Current.NUMBER_AT18;
                    case 25: // NUMBER_AT19
                        return Current.NUMBER_AT19;
                    case 26: // NUMBER_AT20
                        return Current.NUMBER_AT20;
                    case 27: // NUMBER_AT21
                        return Current.NUMBER_AT21;
                    case 28: // NUMBER_AT22
                        return Current.NUMBER_AT22;
                    case 29: // NUMBER_AT23
                        return Current.NUMBER_AT23;
                    case 30: // NUMBER_AT24
                        return Current.NUMBER_AT24;
                    case 31: // NUMBER_AT25
                        return Current.NUMBER_AT25;
                    case 32: // NUMBER_AT26
                        return Current.NUMBER_AT26;
                    case 33: // NUMBER_AT27
                        return Current.NUMBER_AT27;
                    case 34: // NUMBER_AT28
                        return Current.NUMBER_AT28;
                    case 35: // SCHOOL_MEAN
                        return Current.SCHOOL_MEAN;
                    case 36: // SCHOOL_MIN
                        return Current.SCHOOL_MIN;
                    case 37: // SCHOOL_MAX
                        return Current.SCHOOL_MAX;
                    case 38: // SCHOOL_15TH
                        return Current.SCHOOL_15TH;
                    case 39: // SCHOOL_25TH
                        return Current.SCHOOL_25TH;
                    case 40: // SCHOOL_75TH
                        return Current.SCHOOL_75TH;
                    case 41: // LW_DATE
                        return Current.LW_DATE;
                    case 42: // LW_TIME
                        return Current.LW_TIME;
                    case 43: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER == null;
                    case 3: // ST_CAMPUS
                        return Current.ST_CAMPUS == null;
                    case 4: // ST_YEAR_LEVEL
                        return Current.ST_YEAR_LEVEL == null;
                    case 5: // ST_CATEGORY
                        return Current.ST_CATEGORY == null;
                    case 6: // TOTAL_IN_GROUP
                        return Current.TOTAL_IN_GROUP == null;
                    case 7: // NUMBER_AT01
                        return Current.NUMBER_AT01 == null;
                    case 8: // NUMBER_AT02
                        return Current.NUMBER_AT02 == null;
                    case 9: // NUMBER_AT03
                        return Current.NUMBER_AT03 == null;
                    case 10: // NUMBER_AT04
                        return Current.NUMBER_AT04 == null;
                    case 11: // NUMBER_AT05
                        return Current.NUMBER_AT05 == null;
                    case 12: // NUMBER_AT06
                        return Current.NUMBER_AT06 == null;
                    case 13: // NUMBER_AT07
                        return Current.NUMBER_AT07 == null;
                    case 14: // NUMBER_AT08
                        return Current.NUMBER_AT08 == null;
                    case 15: // NUMBER_AT09
                        return Current.NUMBER_AT09 == null;
                    case 16: // NUMBER_AT10
                        return Current.NUMBER_AT10 == null;
                    case 17: // NUMBER_AT11
                        return Current.NUMBER_AT11 == null;
                    case 18: // NUMBER_AT12
                        return Current.NUMBER_AT12 == null;
                    case 19: // NUMBER_AT13
                        return Current.NUMBER_AT13 == null;
                    case 20: // NUMBER_AT14
                        return Current.NUMBER_AT14 == null;
                    case 21: // NUMBER_AT15
                        return Current.NUMBER_AT15 == null;
                    case 22: // NUMBER_AT16
                        return Current.NUMBER_AT16 == null;
                    case 23: // NUMBER_AT17
                        return Current.NUMBER_AT17 == null;
                    case 24: // NUMBER_AT18
                        return Current.NUMBER_AT18 == null;
                    case 25: // NUMBER_AT19
                        return Current.NUMBER_AT19 == null;
                    case 26: // NUMBER_AT20
                        return Current.NUMBER_AT20 == null;
                    case 27: // NUMBER_AT21
                        return Current.NUMBER_AT21 == null;
                    case 28: // NUMBER_AT22
                        return Current.NUMBER_AT22 == null;
                    case 29: // NUMBER_AT23
                        return Current.NUMBER_AT23 == null;
                    case 30: // NUMBER_AT24
                        return Current.NUMBER_AT24 == null;
                    case 31: // NUMBER_AT25
                        return Current.NUMBER_AT25 == null;
                    case 32: // NUMBER_AT26
                        return Current.NUMBER_AT26 == null;
                    case 33: // NUMBER_AT27
                        return Current.NUMBER_AT27 == null;
                    case 34: // NUMBER_AT28
                        return Current.NUMBER_AT28 == null;
                    case 35: // SCHOOL_MEAN
                        return Current.SCHOOL_MEAN == null;
                    case 36: // SCHOOL_MIN
                        return Current.SCHOOL_MIN == null;
                    case 37: // SCHOOL_MAX
                        return Current.SCHOOL_MAX == null;
                    case 38: // SCHOOL_15TH
                        return Current.SCHOOL_15TH == null;
                    case 39: // SCHOOL_25TH
                        return Current.SCHOOL_25TH == null;
                    case 40: // SCHOOL_75TH
                        return Current.SCHOOL_75TH == null;
                    case 41: // LW_DATE
                        return Current.LW_DATE == null;
                    case 42: // LW_TIME
                        return Current.LW_TIME == null;
                    case 43: // LW_USER
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
                    case 1: // SCSFKEY
                        return "SCSFKEY";
                    case 2: // YEAR_SEMESTER
                        return "YEAR_SEMESTER";
                    case 3: // ST_CAMPUS
                        return "ST_CAMPUS";
                    case 4: // ST_YEAR_LEVEL
                        return "ST_YEAR_LEVEL";
                    case 5: // ST_CATEGORY
                        return "ST_CATEGORY";
                    case 6: // TOTAL_IN_GROUP
                        return "TOTAL_IN_GROUP";
                    case 7: // NUMBER_AT01
                        return "NUMBER_AT01";
                    case 8: // NUMBER_AT02
                        return "NUMBER_AT02";
                    case 9: // NUMBER_AT03
                        return "NUMBER_AT03";
                    case 10: // NUMBER_AT04
                        return "NUMBER_AT04";
                    case 11: // NUMBER_AT05
                        return "NUMBER_AT05";
                    case 12: // NUMBER_AT06
                        return "NUMBER_AT06";
                    case 13: // NUMBER_AT07
                        return "NUMBER_AT07";
                    case 14: // NUMBER_AT08
                        return "NUMBER_AT08";
                    case 15: // NUMBER_AT09
                        return "NUMBER_AT09";
                    case 16: // NUMBER_AT10
                        return "NUMBER_AT10";
                    case 17: // NUMBER_AT11
                        return "NUMBER_AT11";
                    case 18: // NUMBER_AT12
                        return "NUMBER_AT12";
                    case 19: // NUMBER_AT13
                        return "NUMBER_AT13";
                    case 20: // NUMBER_AT14
                        return "NUMBER_AT14";
                    case 21: // NUMBER_AT15
                        return "NUMBER_AT15";
                    case 22: // NUMBER_AT16
                        return "NUMBER_AT16";
                    case 23: // NUMBER_AT17
                        return "NUMBER_AT17";
                    case 24: // NUMBER_AT18
                        return "NUMBER_AT18";
                    case 25: // NUMBER_AT19
                        return "NUMBER_AT19";
                    case 26: // NUMBER_AT20
                        return "NUMBER_AT20";
                    case 27: // NUMBER_AT21
                        return "NUMBER_AT21";
                    case 28: // NUMBER_AT22
                        return "NUMBER_AT22";
                    case 29: // NUMBER_AT23
                        return "NUMBER_AT23";
                    case 30: // NUMBER_AT24
                        return "NUMBER_AT24";
                    case 31: // NUMBER_AT25
                        return "NUMBER_AT25";
                    case 32: // NUMBER_AT26
                        return "NUMBER_AT26";
                    case 33: // NUMBER_AT27
                        return "NUMBER_AT27";
                    case 34: // NUMBER_AT28
                        return "NUMBER_AT28";
                    case 35: // SCHOOL_MEAN
                        return "SCHOOL_MEAN";
                    case 36: // SCHOOL_MIN
                        return "SCHOOL_MIN";
                    case 37: // SCHOOL_MAX
                        return "SCHOOL_MAX";
                    case 38: // SCHOOL_15TH
                        return "SCHOOL_15TH";
                    case 39: // SCHOOL_25TH
                        return "SCHOOL_25TH";
                    case 40: // SCHOOL_75TH
                        return "SCHOOL_75TH";
                    case 41: // LW_DATE
                        return "LW_DATE";
                    case 42: // LW_TIME
                        return "LW_TIME";
                    case 43: // LW_USER
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
                    case "SCSFKEY":
                        return 1;
                    case "YEAR_SEMESTER":
                        return 2;
                    case "ST_CAMPUS":
                        return 3;
                    case "ST_YEAR_LEVEL":
                        return 4;
                    case "ST_CATEGORY":
                        return 5;
                    case "TOTAL_IN_GROUP":
                        return 6;
                    case "NUMBER_AT01":
                        return 7;
                    case "NUMBER_AT02":
                        return 8;
                    case "NUMBER_AT03":
                        return 9;
                    case "NUMBER_AT04":
                        return 10;
                    case "NUMBER_AT05":
                        return 11;
                    case "NUMBER_AT06":
                        return 12;
                    case "NUMBER_AT07":
                        return 13;
                    case "NUMBER_AT08":
                        return 14;
                    case "NUMBER_AT09":
                        return 15;
                    case "NUMBER_AT10":
                        return 16;
                    case "NUMBER_AT11":
                        return 17;
                    case "NUMBER_AT12":
                        return 18;
                    case "NUMBER_AT13":
                        return 19;
                    case "NUMBER_AT14":
                        return 20;
                    case "NUMBER_AT15":
                        return 21;
                    case "NUMBER_AT16":
                        return 22;
                    case "NUMBER_AT17":
                        return 23;
                    case "NUMBER_AT18":
                        return 24;
                    case "NUMBER_AT19":
                        return 25;
                    case "NUMBER_AT20":
                        return 26;
                    case "NUMBER_AT21":
                        return 27;
                    case "NUMBER_AT22":
                        return 28;
                    case "NUMBER_AT23":
                        return 29;
                    case "NUMBER_AT24":
                        return 30;
                    case "NUMBER_AT25":
                        return 31;
                    case "NUMBER_AT26":
                        return 32;
                    case "NUMBER_AT27":
                        return 33;
                    case "NUMBER_AT28":
                        return 34;
                    case "SCHOOL_MEAN":
                        return 35;
                    case "SCHOOL_MIN":
                        return 36;
                    case "SCHOOL_MAX":
                        return 37;
                    case "SCHOOL_15TH":
                        return 38;
                    case "SCHOOL_25TH":
                        return 39;
                    case "SCHOOL_75TH":
                        return 40;
                    case "LW_DATE":
                        return 41;
                    case "LW_TIME":
                        return 42;
                    case "LW_USER":
                        return 43;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
