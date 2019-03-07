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
    /// Actual Sessions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXASDataSet : EduHubDataSet<TXAS>
    {
        /// <inheritdoc />
        public override string Name { get { return "TXAS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TXASDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SCL_LINK = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.SCL_LINK));
            Index_SUBJECT = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<TXAS>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TID = new Lazy<Dictionary<int, TXAS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TXAS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TXAS" /> fields for each CSV column header</returns>
        internal override Action<TXAS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TXAS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "THTQ_TID":
                        mapper[i] = (e, v) => e.THTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SESSION":
                        mapper[i] = (e, v) => e.CLASS_SESSION = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "PERIOD_NO":
                        mapper[i] = (e, v) => e.PERIOD_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_NO":
                        mapper[i] = (e, v) => e.DAY_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SESSION_DATE":
                        mapper[i] = (e, v) => e.SESSION_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PERIOD_DESC":
                        mapper[i] = (e, v) => e.PERIOD_DESC = v;
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FINISH_TIME":
                        mapper[i] = (e, v) => e.FINISH_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROLL_MARKED":
                        mapper[i] = (e, v) => e.ROLL_MARKED = v;
                        break;
                    case "SCL_LINK":
                        mapper[i] = (e, v) => e.SCL_LINK = v;
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
        /// Merges <see cref="TXAS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TXAS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TXAS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TXAS}"/> of entities</returns>
        internal override IEnumerable<TXAS> ApplyDeltaEntities(IEnumerable<TXAS> Entities, List<TXAS> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_LOCATION;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<TXAS>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_SCL_LINK;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<TXAS>>> Index_TEACHER;
        private Lazy<Dictionary<int, TXAS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TXAS> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TXAS> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<TXAS> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<TXAS> value;
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
        /// Find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindBySCL_LINK(string SCL_LINK)
        {
            return Index_SCL_LINK.Value[SCL_LINK];
        }

        /// <summary>
        /// Attempt to find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCL_LINK(string SCL_LINK, out IReadOnlyList<TXAS> Value)
        {
            return Index_SCL_LINK.Value.TryGetValue(SCL_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by SCL_LINK field
        /// </summary>
        /// <param name="SCL_LINK">SCL_LINK value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindBySCL_LINK(string SCL_LINK)
        {
            IReadOnlyList<TXAS> value;
            if (Index_SCL_LINK.Value.TryGetValue(SCL_LINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<TXAS> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<TXAS> value;
            if (Index_SUBJECT.Value.TryGetValue(SUBJECT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <returns>List of related TXAS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <param name="Value">List of related TXAS entities</param>
        /// <returns>True if the list of related TXAS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<TXAS> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find TXAS</param>
        /// <returns>List of related TXAS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TXAS> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<TXAS> value;
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
        /// Find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXAS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <param name="Value">Related TXAS entity</param>
        /// <returns>True if the related TXAS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TXAS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TXAS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TXAS</param>
        /// <returns>Related TXAS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TXAS TryFindByTID(int TID)
        {
            TXAS value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TXAS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TXAS](
        [TID] int IDENTITY NOT NULL,
        [THTQ_TID] int NULL,
        [CLASS_SESSION] varchar(9) NULL,
        [SUBJECT] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TEACHER] varchar(4) NULL,
        [LOCATION] varchar(4) NULL,
        [PERIOD_NO] smallint NULL,
        [DAY_NO] smallint NULL,
        [SESSION_DATE] datetime NULL,
        [PERIOD_DESC] varchar(10) NULL,
        [START_TIME] smallint NULL,
        [FINISH_TIME] smallint NULL,
        [ROLL_MARKED] varchar(1) NULL,
        [SCL_LINK] varchar(17) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TXAS_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_LOCATION] ON [dbo].[TXAS]
    (
            [LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_LW_DATE] ON [dbo].[TXAS]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_SCL_LINK] ON [dbo].[TXAS]
    (
            [SCL_LINK] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_SUBJECT] ON [dbo].[TXAS]
    (
            [SUBJECT] ASC
    );
    CREATE NONCLUSTERED INDEX [TXAS_Index_TEACHER] ON [dbo].[TXAS]
    (
            [TEACHER] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_LOCATION')
    ALTER INDEX [Index_LOCATION] ON [dbo].[TXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[TXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_SCL_LINK')
    ALTER INDEX [Index_SCL_LINK] ON [dbo].[TXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_SUBJECT')
    ALTER INDEX [Index_SUBJECT] ON [dbo].[TXAS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_TEACHER')
    ALTER INDEX [Index_TEACHER] ON [dbo].[TXAS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_LOCATION')
    ALTER INDEX [Index_LOCATION] ON [dbo].[TXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[TXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_SCL_LINK')
    ALTER INDEX [Index_SCL_LINK] ON [dbo].[TXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_SUBJECT')
    ALTER INDEX [Index_SUBJECT] ON [dbo].[TXAS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TXAS]') AND name = N'Index_TEACHER')
    ALTER INDEX [Index_TEACHER] ON [dbo].[TXAS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TXAS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TXAS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TXAS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TXAS] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TXAS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TXAS data set</returns>
        public override EduHubDataSetDataReader<TXAS> GetDataSetDataReader()
        {
            return new TXASDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TXAS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TXAS data set</returns>
        public override EduHubDataSetDataReader<TXAS> GetDataSetDataReader(List<TXAS> Entities)
        {
            return new TXASDataReader(new EduHubDataSetLoadedReader<TXAS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TXASDataReader : EduHubDataSetDataReader<TXAS>
        {
            public TXASDataReader(IEduHubDataSetReader<TXAS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 18; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // THTQ_TID
                        return Current.THTQ_TID;
                    case 2: // CLASS_SESSION
                        return Current.CLASS_SESSION;
                    case 3: // SUBJECT
                        return Current.SUBJECT;
                    case 4: // CLASS
                        return Current.CLASS;
                    case 5: // TEACHER
                        return Current.TEACHER;
                    case 6: // LOCATION
                        return Current.LOCATION;
                    case 7: // PERIOD_NO
                        return Current.PERIOD_NO;
                    case 8: // DAY_NO
                        return Current.DAY_NO;
                    case 9: // SESSION_DATE
                        return Current.SESSION_DATE;
                    case 10: // PERIOD_DESC
                        return Current.PERIOD_DESC;
                    case 11: // START_TIME
                        return Current.START_TIME;
                    case 12: // FINISH_TIME
                        return Current.FINISH_TIME;
                    case 13: // ROLL_MARKED
                        return Current.ROLL_MARKED;
                    case 14: // SCL_LINK
                        return Current.SCL_LINK;
                    case 15: // LW_DATE
                        return Current.LW_DATE;
                    case 16: // LW_TIME
                        return Current.LW_TIME;
                    case 17: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // THTQ_TID
                        return Current.THTQ_TID == null;
                    case 2: // CLASS_SESSION
                        return Current.CLASS_SESSION == null;
                    case 3: // SUBJECT
                        return Current.SUBJECT == null;
                    case 4: // CLASS
                        return Current.CLASS == null;
                    case 5: // TEACHER
                        return Current.TEACHER == null;
                    case 6: // LOCATION
                        return Current.LOCATION == null;
                    case 7: // PERIOD_NO
                        return Current.PERIOD_NO == null;
                    case 8: // DAY_NO
                        return Current.DAY_NO == null;
                    case 9: // SESSION_DATE
                        return Current.SESSION_DATE == null;
                    case 10: // PERIOD_DESC
                        return Current.PERIOD_DESC == null;
                    case 11: // START_TIME
                        return Current.START_TIME == null;
                    case 12: // FINISH_TIME
                        return Current.FINISH_TIME == null;
                    case 13: // ROLL_MARKED
                        return Current.ROLL_MARKED == null;
                    case 14: // SCL_LINK
                        return Current.SCL_LINK == null;
                    case 15: // LW_DATE
                        return Current.LW_DATE == null;
                    case 16: // LW_TIME
                        return Current.LW_TIME == null;
                    case 17: // LW_USER
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
                    case 1: // THTQ_TID
                        return "THTQ_TID";
                    case 2: // CLASS_SESSION
                        return "CLASS_SESSION";
                    case 3: // SUBJECT
                        return "SUBJECT";
                    case 4: // CLASS
                        return "CLASS";
                    case 5: // TEACHER
                        return "TEACHER";
                    case 6: // LOCATION
                        return "LOCATION";
                    case 7: // PERIOD_NO
                        return "PERIOD_NO";
                    case 8: // DAY_NO
                        return "DAY_NO";
                    case 9: // SESSION_DATE
                        return "SESSION_DATE";
                    case 10: // PERIOD_DESC
                        return "PERIOD_DESC";
                    case 11: // START_TIME
                        return "START_TIME";
                    case 12: // FINISH_TIME
                        return "FINISH_TIME";
                    case 13: // ROLL_MARKED
                        return "ROLL_MARKED";
                    case 14: // SCL_LINK
                        return "SCL_LINK";
                    case 15: // LW_DATE
                        return "LW_DATE";
                    case 16: // LW_TIME
                        return "LW_TIME";
                    case 17: // LW_USER
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
                    case "THTQ_TID":
                        return 1;
                    case "CLASS_SESSION":
                        return 2;
                    case "SUBJECT":
                        return 3;
                    case "CLASS":
                        return 4;
                    case "TEACHER":
                        return 5;
                    case "LOCATION":
                        return 6;
                    case "PERIOD_NO":
                        return 7;
                    case "DAY_NO":
                        return 8;
                    case "SESSION_DATE":
                        return 9;
                    case "PERIOD_DESC":
                        return 10;
                    case "START_TIME":
                        return 11;
                    case "FINISH_TIME":
                        return 12;
                    case "ROLL_MARKED":
                        return 13;
                    case "SCL_LINK":
                        return 14;
                    case "LW_DATE":
                        return 15;
                    case "LW_TIME":
                        return 16;
                    case "LW_USER":
                        return 17;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
