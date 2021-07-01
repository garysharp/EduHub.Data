using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Base Data Set for eduHub Entities
    /// </summary>
    /// <typeparam name="T">An eduHub Entity derived from <see cref="EduHubEntity"/></typeparam>
    public abstract class EduHubDataSet<T> : IEduHubDataSet, IReadOnlyList<T> where T : EduHubEntity
    {
        /// <summary>
        /// EduHubContext this Data Set belongs to
        /// </summary>
        protected readonly EduHubContext context;
        /// <summary>
        /// Helper method for Mapper Builders used to ignore fields (no operation)
        /// </summary>
        protected static Action<T, string> MapperNoOp = (entity, field) => { };
        /// <summary>
        /// Internal list of entities
        /// </summary>
        protected Lazy<List<T>> Items;

        internal EduHubDataSet(EduHubContext Context)
        {
            context = Context;
            Items = new Lazy<List<T>>(LoadCache);
        }

        /// <inheritdoc />
        public abstract string Name { get; }

        private string NameDelta { get { return $"{Name}_D"; } }

        /// <inheritdoc />
        public EduHubContext Context
        {
            get
            {
                return context;
            }
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize an entity
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize entity fields for each CSV column header</returns>
        internal abstract Action<T, string>[] BuildMapper(IReadOnlyList<string> Headers);

        /// <summary>
        /// Merges delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base entities</param>
        /// <param name="DeltaEntities">Delta entities to added or update the base entities</param>
        /// <returns>A merged <see cref="IEnumerable{T}"/> of entities</returns>
        internal abstract IEnumerable<T> ApplyDeltaEntities(IEnumerable<T> Entities, List<T> DeltaEntities);

        /// <inheritdoc />
        public string Filename
        {
            get
            {
                return FilenameBase;
            }
        }

        /// <inheritdoc />
        public string FilenameBase
        {
            get
            {
                return Path.Combine(Context.EduHubDirectory, $"{Name}_{Context.EduHubSiteIdentifier}.csv");
            }
        }

        /// <inheritdoc />
        public string FilenameDelta
        {
            get
            {
                return Path.Combine(Context.EduHubDirectory, $"{Name}_{Context.EduHubSiteIdentifier}_D.csv");
            }
        }

        /// <inheritdoc />
        public long FileSize
        {
            get
            {
                return FileSizeBase + FileSizeDelta;
            }
        }

        /// <inheritdoc />
        public long FileSizeBase
        {
            get
            {
                if (IsAvailable)
                {
                    return new FileInfo(Filename).Length;
                }
                return 0;
            }
        }

        /// <inheritdoc />
        public long FileSizeDelta
        {
            get
            {
                if (IsDeltaAvailable)
                {
                    return new FileInfo(FilenameDelta).Length;
                }

                return 0;
            }
        }

        /// <inheritdoc />
        public bool IsAvailable
        {
            get
            {
                return Items.IsValueCreated || File.Exists(Filename);
            }
        }

        /// <inheritdoc />
        public bool IsDeltaAvailable
        {
            get
            {
                var filename = Filename;
                var filenameDelta = FilenameDelta;

                return File.Exists(filename) &&
                    File.Exists(filenameDelta) &&
                    File.GetLastWriteTime(filename) < File.GetLastWriteTime(filenameDelta);
            }
        }

        /// <inheritdoc />
        public void EnsureAvailable()
        {
            if (!IsAvailable)
            {
                throw new EduHubDataSetNotFoundException(Name, Filename);
            }
        }

        /// <inheritdoc />
        public void EnsureDeltaAvailable()
        {
            if (!IsDeltaAvailable)
            {
                throw new EduHubDataSetNotFoundException(NameDelta, FilenameDelta);
            }
        }

        /// <inheritdoc />
        public DateTime LastModified
        {
            get
            {
                if (IsDeltaAvailable)
                {
                    return LastModifiedDelta;
                }
                else
                {
                    return LastModifiedBase;
                }
            }
        }

        /// <inheritdoc />
        public DateTime LastModifiedBase
        {
            get
            {
                var filename = Filename;

                if (File.Exists(filename))
                {
                    return File.GetLastWriteTime(filename);
                }
                else
                {
                    throw new EduHubDataSetNotFoundException(Name, Filename);
                }
            }
        }

        /// <inheritdoc />
        public DateTime LastModifiedDelta
        {
            get
            {
                var filenameDelta = FilenameDelta;

                if (File.Exists(filenameDelta))
                {
                    return File.GetLastWriteTime(filenameDelta);
                }
                else
                {
                    throw new EduHubDataSetNotFoundException(NameDelta, FilenameDelta);
                }
            }
        }

        /// <inheritdoc />
        public abstract bool SupportsEntityLastModified { get; }

        /// <inheritdoc />
        public abstract SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection);

        /// <inheritdoc />
        public virtual SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Returns null indicating no check is required
            // Checks are manually added to DataSets based on changes to the database schema over time
            return null;
        }

        /// <inheritdoc />
        public abstract SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection);

        /// <inheritdoc />
        public abstract SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection);

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The entities to be deleted</param>
        public abstract SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<T> Entities);

        /// <inheritdoc />
        public IEduHubDataSetDataReader GetDataReader()
        {
            return GetDataSetDataReader();
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the data set through <see cref="EduHubDataSetDataReader{T}"/> which includes progress
        /// </summary>
        /// <returns>A <see cref="EduHubDataSetDataReader{T}"/> for the data set</returns>
        public abstract EduHubDataSetDataReader<T> GetDataSetDataReader();

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the provided entities
        /// </summary>
        /// <param name="Entities">The entities to be accessed through the <see cref="EduHubDataSetDataReader{T}"/></param>
        /// <returns>A <see cref="EduHubDataSetDataReader{T}"/> for the provided entities</returns>
        public abstract EduHubDataSetDataReader<T> GetDataSetDataReader(List<T> Entities);

        /// <inheritdoc />
        public EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database)
        {
            return WriteToSqlServer(Server, Database, null);
        }

        /// <inheritdoc />
        public Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database)
        {
            return WriteToSqlServerAsync(Server, Database, null);
        }

        /// <inheritdoc />
        public EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database, Action<double, string> ProgressNotification)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database).ConnectionString))
            {
                return WriteToSqlServer(connection, ProgressNotification);
            }
        }

        /// <inheritdoc />
        public Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database, Action<double, string> ProgressNotification)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database).ConnectionString))
            {
                return WriteToSqlServerAsync(connection, ProgressNotification);
            }
        }

        /// <inheritdoc />
        public EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database, string SqlUsername, string SqlPassword)
        {
            return WriteToSqlServer(Server, Database, SqlUsername, SqlPassword, null);
        }

        /// <inheritdoc />
        public Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database, string SqlUsername, string SqlPassword)
        {
            return WriteToSqlServerAsync(Server, Database, SqlUsername, SqlPassword, null);
        }

        /// <inheritdoc />
        public EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database, string SqlUsername, string SqlPassword, Action<double, string> ProgressNotification)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database, SqlUsername, SqlPassword).ConnectionString))
            {
                return WriteToSqlServer(connection, ProgressNotification);
            }
        }

        /// <inheritdoc />
        public Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database, string SqlUsername, string SqlPassword, Action<double, string> ProgressNotification)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database, SqlUsername, SqlPassword).ConnectionString))
            {
                return WriteToSqlServerAsync(connection, ProgressNotification);
            }
        }

        /// <inheritdoc />
        public EduHubSqlServerWriteResult WriteToSqlServer(SqlConnection Connection)
        {
            return WriteToSqlServer(Connection, null);
        }

        /// <inheritdoc />
        public Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(SqlConnection Connection)
        {
            return WriteToSqlServerAsync(Connection, null);
        }

        /// <inheritdoc />
        public EduHubSqlServerWriteResult WriteToSqlServer(SqlConnection Connection, Action<double, string> ProgressNotification)
        {
            var task = WriteToSqlServerAsync(Connection, ProgressNotification, null, null, null);

            return task.Result;
        }

        /// <inheritdoc />
        public Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(SqlConnection Connection, Action<double, string> ProgressNotification)
        {
            return WriteToSqlServerAsync(Connection, ProgressNotification, null, null, null);
        }

        /// <inheritdoc />
        public async Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(SqlConnection Connection, Action<double, string> ProgressNotification, DateTime? LastFullWrite, DateTime? LastDeltaWrite, DateTime? EntityLastModified)
        {
            if (Connection == null)
                throw new ArgumentNullException(nameof(Connection));
            if (!IsAvailable)
                throw new EduHubDataSetNotFoundException(Name, Filename);

            // Ensure the SQL Connection is open
            if (Connection.State != ConnectionState.Open)
            {
                ProgressNotification?.Invoke(0, "Opening database connection");
                await Connection.OpenAsync();
            }

            // Ensure Table Exists
            ProgressNotification?.Invoke(0, "Validating database table");
            using (var commandQuery = new SqlCommand($"SELECT COUNT(1) FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[{Name}]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1", Connection))
            {
                if ((int)await commandQuery.ExecuteScalarAsync() == 0)
                {
                    ProgressNotification?.Invoke(0, $"Creating {Name} database table");
                    // Table doesn't exist. Create
                    using (var commandCreate = GetSqlCreateTableCommand(Connection))
                    {
                        await commandCreate.ExecuteNonQueryAsync();

                        // Table created, reset last write
                        LastFullWrite = null;
                        LastDeltaWrite = null;
                        EntityLastModified = null;
                    }
                    ProgressNotification?.Invoke(0, $"Database table {Name} created");
                }
                else
                {
                    // Table exists, check it is valid
                    using (var commandCheck = GetSqlTableIsValidCommand(Connection))
                    {
                        if (commandCheck != null)
                        {
                            ProgressNotification?.Invoke(0, $"Validating {Name} database table");
                            if ((int)await commandCheck.ExecuteScalarAsync() > 0)
                            {
                                ProgressNotification?.Invoke(0, $"Rebuilding database table {Name}");
                                // Drop Table
                                using (var commandDrop = new SqlCommand($"DROP TABLE [{Name}];", Connection))
                                {
                                    await commandDrop.ExecuteNonQueryAsync();
                                }
                                // Recreate Table
                                using (var commandCreate = GetSqlCreateTableCommand(Connection))
                                {
                                    await commandCreate.ExecuteNonQueryAsync();

                                    // Table created, reset last write
                                    LastFullWrite = null;
                                    LastDeltaWrite = null;
                                    EntityLastModified = null;
                                }
                                ProgressNotification?.Invoke(0, $"Database table {Name} rebuilt");
                            }
                        }
                    }
                }
            }

            // Determine Write Type
            var mode = DetermineSqlServerWriteType(LastFullWrite, LastDeltaWrite, EntityLastModified.HasValue);

            // Write not required based on specified parameters
            if (mode == EduHubSqlServerWriteMode.Skipped)
            {
                ProgressNotification?.Invoke(0, $"Writing the data set is not required");
                return new EduHubSqlServerWriteResult(
                    DataSet: this,
                    Mode: mode,
                    Timestamp: DateTime.Now,
                    LastModified: LastModified);
            }

            ProgressNotification?.Invoke(0, $"Writing the data set in {mode} mode");

            switch (mode)
            {
                case EduHubSqlServerWriteMode.Full:
                    return await WriteToSqlServerFull(Connection, ProgressNotification);
                case EduHubSqlServerWriteMode.Delta:
                    return await WriteToSqlServerDelta(Connection, ProgressNotification);
                case EduHubSqlServerWriteMode.DeltaPartial:
                    return await WriteToSqlServerDelta(Connection, EntityLastModified.Value, ProgressNotification);
                default:
                    throw new InvalidOperationException("Unexpected " + nameof(EduHubSqlServerWriteMode));
            }
        }

        /// <summary>
        /// Writes the entire data set to the SQL Server
        /// </summary>
        /// <param name="Connection">A <see cref="SqlConnection"/> to the SQL Server</param>
        /// <param name="ProgressNotification">A method called to intermittently report the percentage of progress</param>
        /// <returns></returns>
        private async Task<EduHubSqlServerWriteResult> WriteToSqlServerFull(SqlConnection Connection, Action<double, string> ProgressNotification)
        {
            DateTime timestamp = DateTime.Now;
            DateTime lastModified = LastModified;
            int entitiesDeleted;
            int entitiesAdded;
            DateTime? entityLastModifiedMax;

            // Create transaction
            using (var sqlTransaction = Connection.BeginTransaction(IsolationLevel.Serializable))
            {
                // Disable Indexes
                using (var sqlCommandDisableIndexes = GetSqlDisableIndexesCommand(Connection))
                {
                    if (sqlCommandDisableIndexes != null)
                    {
                        ProgressNotification?.Invoke(5, "Disabling database table indexes");

                        sqlCommandDisableIndexes.Transaction = sqlTransaction;
                        await sqlCommandDisableIndexes.ExecuteNonQueryAsync();
                    }
                }

                // Drop records
                using (var sqlCommandTruncate = new SqlCommand($"TRUNCATE TABLE {Name}", Connection, sqlTransaction))
                {
                    ProgressNotification?.Invoke(10, "Truncating the database table");
                    entitiesDeleted = await sqlCommandTruncate.ExecuteNonQueryAsync();
                }

                using (var dataReader = GetDataSetDataReader())
                {
                    if (!dataReader.HasEntities)
                    {
                        ProgressNotification?.Invoke(95, $"Skipped writing to the database table, the data set is empty");
                        return new EduHubSqlServerWriteResult(
                            DataSet: this,
                            Mode: EduHubSqlServerWriteMode.Full,
                            Timestamp: timestamp,
                            LastModified: LastModified,
                            EntityLastModifiedMax: null,
                            EntitiesDeleted: -1,
                            EntitiesUpdated: 0,
                            EntitiesAdded: 0);
                    }
                    else
                    {
                        // Bulk copy records
                        using (var sqlBulkCopy = new SqlBulkCopy(Connection,
                            SqlBulkCopyOptions.KeepIdentity | SqlBulkCopyOptions.KeepNulls | SqlBulkCopyOptions.TableLock,
                            sqlTransaction))
                        {
                            sqlBulkCopy.DestinationTableName = Name;
                            sqlBulkCopy.EnableStreaming = true;
                            sqlBulkCopy.BulkCopyTimeout = 60 * 2; // 2 Minutes
                            sqlBulkCopy.NotifyAfter = 2000;
                            sqlBulkCopy.BatchSize = 2000;


                            if (ProgressNotification != null)
                            {
                                sqlBulkCopy.SqlRowsCopied += (sender, e) =>
                                {
                                    ProgressNotification(15 + (dataReader.Progress * .8), $"Written {e.RowsCopied} records to the database table");
                                };

                                ProgressNotification(15, "Writing records to the database table");
                            }

                            await sqlBulkCopy.WriteToServerAsync(dataReader);

                            ProgressNotification?.Invoke(95, $"Wrote {dataReader.EntitiesRead} records to the database table");

                            entitiesAdded = dataReader.EntitiesRead;
                            entityLastModifiedMax = dataReader.EntityLastModifiedMax;
                        }
                    }
                }

                // Rebuild & Enable Indexes
                using (var sqlCommandEnableIndexes = GetSqlRebuildIndexesCommand(Connection))
                {
                    if (sqlCommandEnableIndexes != null)
                    {
                        ProgressNotification?.Invoke(95, $"Rebuilding and enabling database table indexes");
                        sqlCommandEnableIndexes.Transaction = sqlTransaction;
                        await sqlCommandEnableIndexes.ExecuteNonQueryAsync();
                    }
                }

                sqlTransaction.Commit();
            }

            ProgressNotification?.Invoke(100, $"Successfully wrote the data set to the database table");

            return new EduHubSqlServerWriteResult(
                DataSet: this,
                Mode: EduHubSqlServerWriteMode.Full,
                Timestamp: timestamp,
                LastModified: lastModified,
                EntityLastModifiedMax: entityLastModifiedMax,
                EntitiesDeleted: entitiesDeleted,
                EntitiesUpdated: 0,
                EntitiesAdded: entitiesAdded);
        }

        private async Task<EduHubSqlServerWriteResult> WriteToSqlServerDelta(SqlConnection Connection, EduHubSqlServerWriteMode Mode, List<T> Entities, Action<double, string> ProgressNotification)
        {
            DateTime timestamp = DateTime.Now;
            DateTime lastModified = LastModified;
            int entitiesUpdated = 0;
            int entitiesAdded;
            DateTime? entityLastModifiedMax;

            // Create transaction
            using (var transaction = Connection.BeginTransaction(IsolationLevel.Serializable))
            {
                ProgressNotification?.Invoke(30, "Removing updated records from the database table");
                // Delete Entities (based on Unique fields)
                //  Batches of 100
                var batchCount = Math.Ceiling(Entities.Count / 100d);
                for (int batch = 0; batch < batchCount; batch++)
                {
                    var batchEntities = Entities.Skip(batch * 100).Take(100);
                    using (var deleteCommand = GetSqlDeleteCommand(Connection, batchEntities))
                    {
                        deleteCommand.Transaction = transaction;

                        entitiesUpdated += await deleteCommand.ExecuteNonQueryAsync();
                    }
                    ProgressNotification?.Invoke(30 + ((batch / batchCount) * 0.3), $"Removed {entitiesUpdated} updated records from the database table"); // 30% + 30% Weight
                }

                // Bulk Copy Delta Entities
                using (var bulkCopy = new SqlBulkCopy(Connection,
                    SqlBulkCopyOptions.KeepIdentity | SqlBulkCopyOptions.KeepNulls | SqlBulkCopyOptions.TableLock,
                    transaction))
                {
                    bulkCopy.DestinationTableName = Name;
                    bulkCopy.EnableStreaming = true;
                    bulkCopy.BulkCopyTimeout = 60 * 2; // 2 Minutes
                    bulkCopy.NotifyAfter = 2000;
                    bulkCopy.BatchSize = 2000;

                    using (var dataReader = GetDataSetDataReader(Entities))
                    {
                        if (ProgressNotification != null)
                        {
                            bulkCopy.SqlRowsCopied += (sender, e) =>
                            {
                                ProgressNotification(60 + (dataReader.Progress * .35), $"Written {e.RowsCopied} records to the database table"); // 60% + 35% Weight
                            };

                            ProgressNotification(60, "Writing delta records to the database table");
                        }

                        await bulkCopy.WriteToServerAsync(dataReader);

                        ProgressNotification?.Invoke(95, $"Wrote {dataReader.EntitiesRead} delta records to the database table");

                        entitiesAdded = dataReader.EntitiesRead;
                        entityLastModifiedMax = dataReader.EntityLastModifiedMax;
                    }
                }

                transaction.Commit();
            }

            ProgressNotification?.Invoke(100, $"Successfully wrote the delta data set to the database table");

            return new EduHubSqlServerWriteResult(
                DataSet: this,
                Mode: Mode,
                Timestamp: timestamp,
                LastModified: lastModified,
                EntityLastModifiedMax: entityLastModifiedMax,
                EntitiesDeleted: 0,
                EntitiesUpdated: entitiesUpdated,
                EntitiesAdded: entitiesAdded - entitiesUpdated);
        }

        /// <summary>
        /// Writes the data set delta to the SQL Server
        /// </summary>
        /// <param name="Connection">A <see cref="SqlConnection"/> to the SQL Server</param>
        /// <param name="ProgressNotification">A method called to intermittently report the percentage of progress</param>
        /// <returns></returns>
        private async Task<EduHubSqlServerWriteResult> WriteToSqlServerDelta(SqlConnection Connection, Action<double, string> ProgressNotification)
        {
            List<T> entities;

            // Load Delta Entities
            if (ProgressNotification == null)
            {
                entities = LoadDelta().ToList();
            }
            else
            {
                ProgressNotification(0, "Reading delta records into memory");

                // With progress (report every 2000 entities)
                entities = new List<T>();
                using (var entityReader = LoadDelta())
                {
                    using (var entityEnumerator = entityReader.GetEnumerator())
                    {
                        int entityCount = 0;
                        while (entityEnumerator.MoveNext())
                        {
                            entities.Add(entityEnumerator.Current);
                            if (entityCount++ >= 2000)
                            {
                                entityCount = 0;
                                ProgressNotification(entityReader.Progress * 0.3, $"Read {entities.Count} delta records into memory"); // 30% Weight
                            }
                        }
                    }
                }

                ProgressNotification(30, $"Read {entities.Count} delta records into memory");
            }

            if (entities.Count > 0)
            {
                return await WriteToSqlServerDelta(Connection, EduHubSqlServerWriteMode.Delta, entities, ProgressNotification);
            }
            else
            {
                ProgressNotification?.Invoke(100, $"Skipped writing the delta data set to the database table, no new records");
                return new EduHubSqlServerWriteResult(
                    DataSet: this,
                    Mode: EduHubSqlServerWriteMode.Delta,
                    Timestamp: DateTime.Now,
                    LastModified: LastModifiedDelta);
            }
        }

        /// <summary>
        /// Writes a subset of the data set delta to the SQL Server
        /// </summary>
        /// <param name="Connection">A <see cref="SqlConnection"/> to the SQL Server</param>
        /// <param name="EntityLastModified">A timestamp used to determine which entities to write</param>
        /// <param name="ProgressNotification">A method called to intermittently report the percentage of progress</param>
        /// <returns></returns>
        private async Task<EduHubSqlServerWriteResult> WriteToSqlServerDelta(SqlConnection Connection, DateTime EntityLastModified, Action<double, string> ProgressNotification)
        {
            List<T> entities;

            // Load Delta Entities
            if (ProgressNotification == null)
            {
                entities = LoadDelta()
                    .Where(e => e.EntityLastModified == null || e.EntityLastModified > EntityLastModified)
                    .ToList();
            }
            else
            {
                ProgressNotification(0, "Reading delta records updated after {EntityLastModified:yyyy-MM-dd HH:mm} into memory");

                // With progress (report every 2000 entities)
                entities = new List<T>();
                using (var entityReader = LoadDelta())
                {
                    using (var entityEnumerator = entityReader.GetEnumerator())
                    {
                        int entityCount = 0;
                        while (entityEnumerator.MoveNext())
                        {
                            var entity = entityEnumerator.Current;
                            if (entity.EntityLastModified == null || entity.EntityLastModified > EntityLastModified)
                            {
                                entities.Add(entityEnumerator.Current);
                            }
                            if (entityCount++ >= 2000)
                            {
                                entityCount = 0;
                                ProgressNotification(entityReader.Progress * 0.3, $"Read {entities.Count} delta records into memory"); // 30% Weight
                            }
                        }
                    }
                }

                ProgressNotification(30, $"Read {entities.Count} delta records into memory");
            }

            if (entities.Count > 0)
            {
                return await WriteToSqlServerDelta(Connection, EduHubSqlServerWriteMode.DeltaPartial, entities, ProgressNotification);
            }
            else
            {
                ProgressNotification?.Invoke(100, $"Skipped writing the delta data set to the database table, no new records");
                return new EduHubSqlServerWriteResult(
                    DataSet: this,
                    Mode: EduHubSqlServerWriteMode.DeltaPartial,
                    Timestamp: DateTime.Now,
                    LastModified: LastModifiedDelta);
            }
        }

        /// <inheritdoc />
        public EduHubSqlServerWriteMode DetermineSqlServerWriteType(DateTime? LastFullWrite, DateTime? LastDeltaWrite, bool EntityLastModifiedAvailable)
        {
            if (LastFullWrite == null ||            // Never written
                LastModifiedBase > LastFullWrite)   // Newer base file
            {
                return EduHubSqlServerWriteMode.Full;
            }
            else if (IsDeltaAvailable)
            {
                if (LastDeltaWrite == null &&       // Never written delta
                    LastModifiedDelta > LastFullWrite) // Irrelevant timestamp (delta was already overwritten)
                {
                    return EduHubSqlServerWriteMode.Delta;
                }
                else if (LastModifiedDelta > LastDeltaWrite) // Newer delta file
                {
                    if (SupportsEntityLastModified && EntityLastModifiedAvailable)
                    {
                        // Delta previously written and last modified entity timestamp supported
                        return EduHubSqlServerWriteMode.DeltaPartial;
                    }
                    else
                    {
                        // Write all delta
                        return EduHubSqlServerWriteMode.Delta;
                    }
                }
            }
            // No changes since last write
            return EduHubSqlServerWriteMode.Skipped;
        }

        /// <summary>
        /// Loads delta entities for the data set
        /// </summary>
        /// <returns>An <see cref="IEduHubDataSetReader{T}"/> containing delta entities for this data set</returns>
        public IEduHubDataSetReader<T> LoadDelta()
        {
            // Ensure the delta data set (including the base data set) is available
            EnsureDeltaAvailable();

            // Return a basic data set reader
            return new EduHubDataSetReader<T>(this, FilenameDelta);
        }

        /// <summary>
        /// Loads entities for the data set, applying delta items as the set is gradually loaded
        /// </summary>
        /// <returns>An <see cref="IEduHubDataSetReader{T}"/> containing entities for this data set</returns>
        public IEduHubDataSetReader<T> Load()
        {
            // Ensure the data set is available
            EnsureAvailable();

            // Check if the data set is already loaded into memory
            if (Items.IsValueCreated)
            {
                // Already loaded into memory, use memory cache
                return new EduHubDataSetLoadedReader<T>(this, Items.Value);
            }
            else
            {
                // Progressively load
                if (IsDeltaAvailable)
                {
                    // Apply Delta Entities
                    return new EduHubDataSetDeltaReader<T>(this);
                }
                else
                {
                    return new EduHubDataSetReader<T>(this);
                }
            }
        }

        private List<T> LoadCache()
        {
            List<T> items;

            // Load daily/base CSV data
            items = Load().ToList();

            return items;
        }

        /// <inheritdoc />
        public bool IsReadOnly { get { return true; } }

        /// <inheritdoc />
        public bool IsFixedSize { get { return true; } }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public object SyncRoot { get { throw new NotSupportedException("The data set is read-only"); } }

        /// <inheritdoc />
        public bool IsSynchronized { get { return true; } }

        /// <summary>
        /// Gets the number of entities in the data set.
        /// </summary>
        /// <returns>The number of entities in the data set.</returns>
        public int Count
        {
            get
            {
                return Items.Value.Count;
            }
        }

        /// <summary>
        /// Gets the EduHub entity at the specified index in the data set.
        /// </summary>
        /// <param name="index">The zero-based index of the entity to get.</param>
        /// <returns>The entity at the specified index in the data set.</returns>
        public T this[int index]
        {
            get
            {
                return Items.Value[index];
            }
        }

        /// <summary>
        /// Gets the EduHub entity at the specified index in the data set.
        /// </summary>
        /// <param name="index">The zero-based index of the entity to get.</param>
        /// <returns>The entity at the specified index in the data set.</returns>
        object IList.this[int index]
        {
            get
            {
                return Items.Value[index];
            }
            set
            {
                throw new NotSupportedException("The data set is read-only");
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the data set.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the data set.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a data set.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the data set.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public int Add(object value)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <inheritdoc />
        public bool Contains(object value)
        {
            T entity = value as T;
            if (entity != null)
            {
                return Items.Value.Contains(entity);
            }
            return false;
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void Clear()
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <inheritdoc />
        public int IndexOf(object value)
        {
            T entity = value as T;
            if (entity != null)
            {
                return Items.Value.IndexOf(entity);
            }
            return -1;
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void Insert(int index, object value)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void Remove(object value)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void RemoveAt(int index)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <summary>
        /// Not Supported.
        /// </summary>
        public void CopyTo(Array array, int index)
        {
            throw new NotSupportedException();
        }
    }
}
