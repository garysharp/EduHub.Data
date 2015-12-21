using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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
        protected readonly EduHubContext Context;
        /// <summary>
        /// Helper method for Mapper Builders used to ignore fields (no operation)
        /// </summary>
        protected static Action<T, string> MapperNoOp = (entity, field) => { };
        /// <summary>
        /// Internal list of entities
        /// </summary>
        protected Lazy<List<T>> Items;
        private DateTime? age;

        internal EduHubDataSet(EduHubContext Context)
        {
            this.Context = Context;
            Items = new Lazy<List<T>>(Load);
        }

        /// <inheritdoc />
        public abstract string Name { get; }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize an entity
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize entity fields for each CSV column header</returns>
        protected abstract Action<T, string>[] BuildMapper(IReadOnlyList<string> Headers);

        /// <summary>
        /// Merges delta entities
        /// </summary>
        /// <param name="Items">Base items</param>
        /// <param name="DeltaItems">Delta items to added or update the base items</param>
        /// <returns>A merged list of sorted items where possible</returns>
        protected abstract List<T> ApplyDeltaItems(List<T> Items, List<T> DeltaItems);

        /// <inheritdoc />
        public string Filename
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
        public DateTime? Age
        {
            get
            {
                if (age.HasValue)
                {
                    return age.Value;
                }
                else
                {
                    return CalculateAge();
                }
            }
        }

        /// <summary>
        /// Returns SQL which checks for the existence of a database table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected abstract string GetCreateTableSql();

        /// <inheritdoc />
        public abstract IDataReader GetDataReader();

        /// <inheritdoc />
        public void WriteToSqlServer(string Server, string Database)
        {
            var builder = new SqlConnectionStringBuilder()
            {
                ApplicationName = "EduHub.Data",
                DataSource = Server,
                InitialCatalog = Database,
                MultipleActiveResultSets = true,
                IntegratedSecurity = true
            };

            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                WriteToSqlServer(connection);
            }
        }

        /// <inheritdoc />
        public void WriteToSqlServer(string Server, string Database, string SqlUsername, string SqlPassword)
        {
            var builder = new SqlConnectionStringBuilder()
            {
                ApplicationName = "EduHub.Data",
                DataSource = Server,
                InitialCatalog = Database,
                MultipleActiveResultSets = true,
                UserID = SqlUsername,
                Password = SqlPassword
            };

            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                WriteToSqlServer(connection);
            }
        }

        /// <inheritdoc />
        public void WriteToSqlServer(SqlConnection Connection)
        {
            // Open the SQL Connection
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }

            // Create table (if it doesn't exist)
            using (var command = new SqlCommand(GetCreateTableSql(), Connection))
            {
                command.ExecuteNonQuery();
            }

            // Create transaction
            using (var transaction = Connection.BeginTransaction(IsolationLevel.Serializable))
            {
                // Drop records
                using (var command = new SqlCommand($"DELETE {Name}", Connection, transaction))
                {
                    command.ExecuteNonQuery();
                }

                // Bulk copy records
                using (var bulkCopy = new SqlBulkCopy(Connection,
                    SqlBulkCopyOptions.KeepIdentity | SqlBulkCopyOptions.KeepNulls | SqlBulkCopyOptions.TableLock,
                    transaction))
                {
                    bulkCopy.DestinationTableName = Name;
                    bulkCopy.EnableStreaming = true;

                    using (var dataReader = GetDataReader())
                    {
                        bulkCopy.WriteToServer(dataReader);
                    }
                }

                transaction.Commit();
            }
        }

        private DateTime? CalculateAge()
        {
            var filename = Filename;
            if (File.Exists(filename))
            {
                var ageBase = File.GetLastWriteTime(filename);
                var filenameDelta = FilenameDelta;
                if (File.Exists(filenameDelta))
                {
                    var ageDelta = File.GetLastWriteTime(filenameDelta);
                    if (ageDelta > ageBase)
                    {
                        return ageDelta;
                    }
                    else
                    {
                        return ageBase;
                    }
                }
                else
                {
                    return ageBase;
                }
            }
            else
            {
                return null;
            }
        }

        private List<T> Load()
        {
            List<T> items;

            // Throw an exception if the dataset is unavailable
            EnsureAvailable();

            // Load daily/base CSV data
            items = LoadCsv(Filename);

            // Check for delta
            if (IsDeltaAvailable)
            {
                var deltaItems = LoadCsv(FilenameDelta);

                items = ApplyDeltaItems(items, deltaItems);
            }

            // Store dataset age values
            age = CalculateAge();

            return items;
        }

        private List<T> LoadCsv(string Filename)
        {
            List<T> items = new List<T>();

            if (!File.Exists(Filename))
                throw new EduHubDataSetNotFoundException(Name, Filename);

            // Create temporary file
            var fileTemp = Path.GetTempFileName();

            // Copy to temporary file (don't directly process eduHub files)
            try
            {
                File.Copy(Filename, fileTemp, true);

                using (FileStream stream = File.OpenRead(fileTemp))
                {
                    using (CsvReader reader = new CsvReader(stream))
                    {
                        var mapper = BuildMapper(reader.Header);

                        foreach (var record in reader.ReadRecords())
                        {
                            var entity = Activator.CreateInstance<T>();
                            entity.Context = Context;

                            for (int i = 0; i < record.Count; i++)
                            {
                                mapper[i](entity, record[i]);
                            }
                            items.Add(entity);
                        }
                    }
                }
            }
            finally
            {
                // Remove temporary file
                File.Delete(fileTemp);
            }

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
