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
    /// Student Scheduled Sessions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SXASDataSet : EduHubDataSet<SXAS>
    {
        /// <inheritdoc />
        public override string Name { get { return "SXAS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SXASDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACT_ABS_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXAS>>>(() => this.ToGroupedNullDictionary(i => i.ACT_ABS_TYPE));
            Index_EXP_ABS_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SXAS>>>(() => this.ToGroupedNullDictionary(i => i.EXP_ABS_TYPE));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SXAS>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_ST_YEAR_LEVEL = new Lazy<NullDictionary<string, IReadOnlyList<SXAS>>>(() => this.ToGroupedNullDictionary(i => i.ST_YEAR_LEVEL));
            Index_STKEY = new Lazy<NullDictionary<string, IReadOnlyList<SXAS>>>(() => this.ToGroupedNullDictionary(i => i.STKEY));
            Index_TID = new Lazy<Dictionary<int, SXAS>>(() => this.ToDictionary(i => i.TID));
            Index_TXAS_ID = new Lazy<NullDictionary<int?, IReadOnlyList<SXAS>>>(() => this.ToGroupedNullDictionary(i => i.TXAS_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SXAS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SXAS" /> fields for each CSV column header</returns>
        internal override Action<SXAS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SXAS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TXAS_ID":
                        mapper[i] = (e, v) => e.TXAS_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "EXP_ABS_TYPE":
                        mapper[i] = (e, v) => e.EXP_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
                        break;
                    case "ACT_ABS_TYPE":
                        mapper[i] = (e, v) => e.ACT_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "APPROVED":
                        mapper[i] = (e, v) => e.APPROVED = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "ACTION_TAKEN":
                        mapper[i] = (e, v) => e.ACTION_TAKEN = v;
                        break;
                    case "ABSENCE_DATE":
                        mapper[i] = (e, v) => e.ABSENCE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ABSENCE_PERIOD":
                        mapper[i] = (e, v) => e.ABSENCE_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SMS_KEY":
                        mapper[i] = (e, v) => e.SMS_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMAIL_KEY":
                        mapper[i] = (e, v) => e.EMAIL_KEY = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="SXAS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SXAS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SXAS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SXAS}"/> of entities</returns>
        internal override IEnumerable<SXAS> ApplyDeltaEntities(IEnumerable<SXAS> Entities, List<SXAS> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<short?, IReadOnlyList<SXAS>>> Index_ACT_ABS_TYPE;
        private Lazy<NullDictionary<short?, IReadOnlyList<SXAS>>> Index_EXP_ABS_TYPE;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SXAS>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SXAS>>> Index_ST_YEAR_LEVEL;
        private Lazy<NullDictionary<string, IReadOnlyList<SXAS>>> Index_STKEY;
        private Lazy<Dictionary<int, SXAS>> Index_TID;
        private Lazy<NullDictionary<int?, IReadOnlyList<SXAS>>> Index_TXAS_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SXAS by ACT_ABS_TYPE field
        /// </summary>
        /// <param name="ACT_ABS_TYPE">ACT_ABS_TYPE value used to find SXAS</param>
        /// <returns>List of related SXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> FindByACT_ABS_TYPE(short? ACT_ABS_TYPE)
        {
            return Index_ACT_ABS_TYPE.Value[ACT_ABS_TYPE];
        }

        /// <summary>
        /// Attempt to find SXAS by ACT_ABS_TYPE field
        /// </summary>
        /// <param name="ACT_ABS_TYPE">ACT_ABS_TYPE value used to find SXAS</param>
        /// <param name="Value">List of related SXAS entities</param>
        /// <returns>True if the list of related SXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACT_ABS_TYPE(short? ACT_ABS_TYPE, out IReadOnlyList<SXAS> Value)
        {
            return Index_ACT_ABS_TYPE.Value.TryGetValue(ACT_ABS_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by ACT_ABS_TYPE field
        /// </summary>
        /// <param name="ACT_ABS_TYPE">ACT_ABS_TYPE value used to find SXAS</param>
        /// <returns>List of related SXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> TryFindByACT_ABS_TYPE(short? ACT_ABS_TYPE)
        {
            IReadOnlyList<SXAS> value;
            if (Index_ACT_ABS_TYPE.Value.TryGetValue(ACT_ABS_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAS by EXP_ABS_TYPE field
        /// </summary>
        /// <param name="EXP_ABS_TYPE">EXP_ABS_TYPE value used to find SXAS</param>
        /// <returns>List of related SXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> FindByEXP_ABS_TYPE(short? EXP_ABS_TYPE)
        {
            return Index_EXP_ABS_TYPE.Value[EXP_ABS_TYPE];
        }

        /// <summary>
        /// Attempt to find SXAS by EXP_ABS_TYPE field
        /// </summary>
        /// <param name="EXP_ABS_TYPE">EXP_ABS_TYPE value used to find SXAS</param>
        /// <param name="Value">List of related SXAS entities</param>
        /// <returns>True if the list of related SXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXP_ABS_TYPE(short? EXP_ABS_TYPE, out IReadOnlyList<SXAS> Value)
        {
            return Index_EXP_ABS_TYPE.Value.TryGetValue(EXP_ABS_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by EXP_ABS_TYPE field
        /// </summary>
        /// <param name="EXP_ABS_TYPE">EXP_ABS_TYPE value used to find SXAS</param>
        /// <returns>List of related SXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> TryFindByEXP_ABS_TYPE(short? EXP_ABS_TYPE)
        {
            IReadOnlyList<SXAS> value;
            if (Index_EXP_ABS_TYPE.Value.TryGetValue(EXP_ABS_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXAS</param>
        /// <returns>List of related SXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXAS</param>
        /// <param name="Value">List of related SXAS entities</param>
        /// <returns>True if the list of related SXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SXAS> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SXAS</param>
        /// <returns>List of related SXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SXAS> value;
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
        /// Find SXAS by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXAS</param>
        /// <returns>List of related SXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> FindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            return Index_ST_YEAR_LEVEL.Value[ST_YEAR_LEVEL];
        }

        /// <summary>
        /// Attempt to find SXAS by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXAS</param>
        /// <param name="Value">List of related SXAS entities</param>
        /// <returns>True if the list of related SXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL, out IReadOnlyList<SXAS> Value)
        {
            return Index_ST_YEAR_LEVEL.Value.TryGetValue(ST_YEAR_LEVEL, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by ST_YEAR_LEVEL field
        /// </summary>
        /// <param name="ST_YEAR_LEVEL">ST_YEAR_LEVEL value used to find SXAS</param>
        /// <returns>List of related SXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> TryFindByST_YEAR_LEVEL(string ST_YEAR_LEVEL)
        {
            IReadOnlyList<SXAS> value;
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
        /// Find SXAS by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAS</param>
        /// <returns>List of related SXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find SXAS by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAS</param>
        /// <param name="Value">List of related SXAS entities</param>
        /// <returns>True if the list of related SXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out IReadOnlyList<SXAS> Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAS</param>
        /// <returns>List of related SXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> TryFindBySTKEY(string STKEY)
        {
            IReadOnlyList<SXAS> value;
            if (Index_STKEY.Value.TryGetValue(STKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SXAS</param>
        /// <returns>Related SXAS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXAS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SXAS</param>
        /// <param name="Value">Related SXAS entity</param>
        /// <returns>True if the related SXAS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SXAS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SXAS</param>
        /// <returns>Related SXAS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXAS TryFindByTID(int TID)
        {
            SXAS value;
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
        /// Find SXAS by TXAS_ID field
        /// </summary>
        /// <param name="TXAS_ID">TXAS_ID value used to find SXAS</param>
        /// <returns>List of related SXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> FindByTXAS_ID(int? TXAS_ID)
        {
            return Index_TXAS_ID.Value[TXAS_ID];
        }

        /// <summary>
        /// Attempt to find SXAS by TXAS_ID field
        /// </summary>
        /// <param name="TXAS_ID">TXAS_ID value used to find SXAS</param>
        /// <param name="Value">List of related SXAS entities</param>
        /// <returns>True if the list of related SXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTXAS_ID(int? TXAS_ID, out IReadOnlyList<SXAS> Value)
        {
            return Index_TXAS_ID.Value.TryGetValue(TXAS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SXAS by TXAS_ID field
        /// </summary>
        /// <param name="TXAS_ID">TXAS_ID value used to find SXAS</param>
        /// <returns>List of related SXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXAS> TryFindByTXAS_ID(int? TXAS_ID)
        {
            IReadOnlyList<SXAS> value;
            if (Index_TXAS_ID.Value.TryGetValue(TXAS_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SXAS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SXAS](
        [TID] int IDENTITY NOT NULL,
        [TXAS_ID] int NULL,
        [STKEY] varchar(10) NULL,
        [ST_YEAR_LEVEL] varchar(4) NULL,
        [EXP_ABS_TYPE] smallint NULL,
        [ATTENDED] varchar(1) NULL,
        [ACT_ABS_TYPE] smallint NULL,
        [APPROVED] varchar(1) NULL,
        [NOTES] varchar(30) NULL,
        [ACTION_TAKEN] varchar(1) NULL,
        [ABSENCE_DATE] datetime NULL,
        [ABSENCE_PERIOD] smallint NULL,
        [SMS_KEY] int NULL,
        [EMAIL_KEY] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SXAS_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SXAS_Index_ACT_ABS_TYPE] ON [dbo].[SXAS]
    (
            [ACT_ABS_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAS_Index_EXP_ABS_TYPE] ON [dbo].[SXAS]
    (
            [EXP_ABS_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAS_Index_LW_DATE] ON [dbo].[SXAS]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAS_Index_ST_YEAR_LEVEL] ON [dbo].[SXAS]
    (
            [ST_YEAR_LEVEL] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAS_Index_STKEY] ON [dbo].[SXAS]
    (
            [STKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SXAS_Index_TXAS_ID] ON [dbo].[SXAS]
    (
            [TXAS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_ACT_ABS_TYPE')
    ALTER INDEX [Index_ACT_ABS_TYPE] ON [dbo].[SXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_EXP_ABS_TYPE')
    ALTER INDEX [Index_EXP_ABS_TYPE] ON [dbo].[SXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_ST_YEAR_LEVEL')
    ALTER INDEX [Index_ST_YEAR_LEVEL] ON [dbo].[SXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_STKEY')
    ALTER INDEX [Index_STKEY] ON [dbo].[SXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_TXAS_ID')
    ALTER INDEX [Index_TXAS_ID] ON [dbo].[SXAS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_ACT_ABS_TYPE')
    ALTER INDEX [Index_ACT_ABS_TYPE] ON [dbo].[SXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_EXP_ABS_TYPE')
    ALTER INDEX [Index_EXP_ABS_TYPE] ON [dbo].[SXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_ST_YEAR_LEVEL')
    ALTER INDEX [Index_ST_YEAR_LEVEL] ON [dbo].[SXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_STKEY')
    ALTER INDEX [Index_STKEY] ON [dbo].[SXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXAS]') AND name = N'Index_TXAS_ID')
    ALTER INDEX [Index_TXAS_ID] ON [dbo].[SXAS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SXAS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SXAS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SXAS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SXAS] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SXAS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SXAS data set</returns>
        public override EduHubDataSetDataReader<SXAS> GetDataSetDataReader()
        {
            return new SXASDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SXAS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SXAS data set</returns>
        public override EduHubDataSetDataReader<SXAS> GetDataSetDataReader(List<SXAS> Entities)
        {
            return new SXASDataReader(new EduHubDataSetLoadedReader<SXAS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SXASDataReader : EduHubDataSetDataReader<SXAS>
        {
            public SXASDataReader(IEduHubDataSetReader<SXAS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 17; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // TXAS_ID
                        return Current.TXAS_ID;
                    case 2: // STKEY
                        return Current.STKEY;
                    case 3: // ST_YEAR_LEVEL
                        return Current.ST_YEAR_LEVEL;
                    case 4: // EXP_ABS_TYPE
                        return Current.EXP_ABS_TYPE;
                    case 5: // ATTENDED
                        return Current.ATTENDED;
                    case 6: // ACT_ABS_TYPE
                        return Current.ACT_ABS_TYPE;
                    case 7: // APPROVED
                        return Current.APPROVED;
                    case 8: // NOTES
                        return Current.NOTES;
                    case 9: // ACTION_TAKEN
                        return Current.ACTION_TAKEN;
                    case 10: // ABSENCE_DATE
                        return Current.ABSENCE_DATE;
                    case 11: // ABSENCE_PERIOD
                        return Current.ABSENCE_PERIOD;
                    case 12: // SMS_KEY
                        return Current.SMS_KEY;
                    case 13: // EMAIL_KEY
                        return Current.EMAIL_KEY;
                    case 14: // LW_DATE
                        return Current.LW_DATE;
                    case 15: // LW_TIME
                        return Current.LW_TIME;
                    case 16: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TXAS_ID
                        return Current.TXAS_ID == null;
                    case 2: // STKEY
                        return Current.STKEY == null;
                    case 3: // ST_YEAR_LEVEL
                        return Current.ST_YEAR_LEVEL == null;
                    case 4: // EXP_ABS_TYPE
                        return Current.EXP_ABS_TYPE == null;
                    case 5: // ATTENDED
                        return Current.ATTENDED == null;
                    case 6: // ACT_ABS_TYPE
                        return Current.ACT_ABS_TYPE == null;
                    case 7: // APPROVED
                        return Current.APPROVED == null;
                    case 8: // NOTES
                        return Current.NOTES == null;
                    case 9: // ACTION_TAKEN
                        return Current.ACTION_TAKEN == null;
                    case 10: // ABSENCE_DATE
                        return Current.ABSENCE_DATE == null;
                    case 11: // ABSENCE_PERIOD
                        return Current.ABSENCE_PERIOD == null;
                    case 12: // SMS_KEY
                        return Current.SMS_KEY == null;
                    case 13: // EMAIL_KEY
                        return Current.EMAIL_KEY == null;
                    case 14: // LW_DATE
                        return Current.LW_DATE == null;
                    case 15: // LW_TIME
                        return Current.LW_TIME == null;
                    case 16: // LW_USER
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
                    case 1: // TXAS_ID
                        return "TXAS_ID";
                    case 2: // STKEY
                        return "STKEY";
                    case 3: // ST_YEAR_LEVEL
                        return "ST_YEAR_LEVEL";
                    case 4: // EXP_ABS_TYPE
                        return "EXP_ABS_TYPE";
                    case 5: // ATTENDED
                        return "ATTENDED";
                    case 6: // ACT_ABS_TYPE
                        return "ACT_ABS_TYPE";
                    case 7: // APPROVED
                        return "APPROVED";
                    case 8: // NOTES
                        return "NOTES";
                    case 9: // ACTION_TAKEN
                        return "ACTION_TAKEN";
                    case 10: // ABSENCE_DATE
                        return "ABSENCE_DATE";
                    case 11: // ABSENCE_PERIOD
                        return "ABSENCE_PERIOD";
                    case 12: // SMS_KEY
                        return "SMS_KEY";
                    case 13: // EMAIL_KEY
                        return "EMAIL_KEY";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
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
                    case "TXAS_ID":
                        return 1;
                    case "STKEY":
                        return 2;
                    case "ST_YEAR_LEVEL":
                        return 3;
                    case "EXP_ABS_TYPE":
                        return 4;
                    case "ATTENDED":
                        return 5;
                    case "ACT_ABS_TYPE":
                        return 6;
                    case "APPROVED":
                        return 7;
                    case "NOTES":
                        return 8;
                    case "ACTION_TAKEN":
                        return 9;
                    case "ABSENCE_DATE":
                        return 10;
                    case "ABSENCE_PERIOD":
                        return 11;
                    case "SMS_KEY":
                        return 12;
                    case "EMAIL_KEY":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
