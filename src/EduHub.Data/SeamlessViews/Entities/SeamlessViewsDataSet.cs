using EduHub.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Base Data Set for Seamless Views Entities
    /// </summary>
    /// <typeparam name="T">A Seamless View Entity derived from <see cref="SeamlessViewsEntity"/></typeparam>
    public abstract class SeamlessViewsDataSet<T> : ISeamlessViewsDataSet, IReadOnlyList<T> where T : SeamlessViewsEntity
    {
        /// <summary>
        /// Seamless Views Context
        /// </summary>
        protected readonly SeamlessViewsContext Context;

        private Lazy<List<T>> Items;

        internal SeamlessViewsDataSet(SeamlessViewsContext Context)
        {
            this.Context = Context;
            Items = new Lazy<List<T>>(EnsureAvailableAndLoad);
        }

        /// <inheritdoc />
        public abstract string Name { get; }

        /// <inheritdoc />
        public abstract IEnumerable<IEduHubDataSet> GetRequiredDataSets();

        /// <inheritdoc />
        public virtual bool IsAvailable
        {
            get
            {
                return GetRequiredDataSets()
                    .All(dataSet => dataSet.IsAvailable);
            }
        }

        /// <inheritdoc />
        public virtual void EnsureAvailable()
        {
            var missingDataSet = GetRequiredDataSets()
                .FirstOrDefault(dataSet => !dataSet.IsAvailable);

            if (missingDataSet != null)
            {
                throw new SeamlessViewsDataSetNotFoundException(Name, missingDataSet.Name, missingDataSet.FilenameBase);
            }
        }

        /// <summary>
        /// Returns SQL which checks for the existence of a database view, and if not found, creates the view
        /// </summary>
        /// <param name="ParentDatabaseName">Name of the database which contains the eduHub data sets</param>
        protected abstract string GetCreateViewSql(string ParentDatabaseName);

        private List<T> EnsureAvailableAndLoad()
        {
            EnsureAvailable();
            return Load();
        }

        /// <summary>
        /// Responsible for loading the data set entities
        /// </summary>
        /// <returns>The list of entities for this data set</returns>
        protected abstract List<T> Load();

        /// <inheritdoc />
        public void CreateInSqlServer(string Server, string Database)
        {
            CreateInSqlServer(Server, Database, Database);
        }

        /// <inheritdoc />
        public Task CreateInSqlServerAsync(string Server, string Database)
        {
            return CreateInSqlServerAsync(Server, Database, Database);
        }

        /// <inheritdoc />
        public void CreateInSqlServer(string Server, string Database, string ParentDatabase)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database).ConnectionString))
            {
                CreateInSqlServer(connection, ParentDatabase);
            }
        }

        /// <inheritdoc />
        public Task CreateInSqlServerAsync(string Server, string Database, string ParentDatabase)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database).ConnectionString))
            {
                return CreateInSqlServerAsync(connection, ParentDatabase);
            }
        }

        /// <inheritdoc />
        public void CreateInSqlServer(string Server, string Database, string SqlUsername, string SqlPassword)
        {
            CreateInSqlServer(Server, Database, Database, SqlUsername, SqlPassword);
        }

        /// <inheritdoc />
        public Task CreateInSqlServerAsync(string Server, string Database, string SqlUsername, string SqlPassword)
        {
            return CreateInSqlServerAsync(Server, Database, Database, SqlUsername, SqlPassword);
        }

        /// <inheritdoc />
        public void CreateInSqlServer(string Server, string Database, string ParentDatabase, string SqlUsername, string SqlPassword)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database, SqlUsername, SqlPassword).ConnectionString))
            {
                CreateInSqlServer(connection, ParentDatabase);
            }
        }

        /// <inheritdoc />
        public Task CreateInSqlServerAsync(string Server, string Database, string ParentDatabase, string SqlUsername, string SqlPassword)
        {
            using (var connection = new SqlConnection(
                SqlHelpers.BuildSqlConnectionString(Server, Database, SqlUsername, SqlPassword).ConnectionString))
            {
                return CreateInSqlServerAsync(connection, ParentDatabase);
            }
        }

        /// <inheritdoc />
        public void CreateInSqlServer(SqlConnection Connection)
        {
            CreateInSqlServer(Connection, Connection.Database);
        }

        /// <inheritdoc />
        public Task CreateInSqlServerAsync(SqlConnection Connection)
        {
            return CreateInSqlServerAsync(Connection, Connection.Database);
        }

        /// <inheritdoc />
        public void CreateInSqlServer(SqlConnection Connection, string ParentDatabase)
        {
            // Open the SQL Connection
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }

            // Create view (if it doesn't exist)
            using (var command = new SqlCommand(GetCreateViewSql(ParentDatabase), Connection))
            {
                command.ExecuteNonQuery();
            }
        }

        /// <inheritdoc />
        public async Task CreateInSqlServerAsync(SqlConnection Connection, string ParentDatabase)
        {
            // Open the SQL Connection
            if (Connection.State != ConnectionState.Open)
            {
                await Connection.OpenAsync();
            }

            // Create view (if it doesn't exist)
            using (var command = new SqlCommand(GetCreateViewSql(ParentDatabase), Connection))
            {
                await command.ExecuteNonQueryAsync();
            }
        }

        /// <inheritdoc />
        public void WriteToCsv(string Filename)
        {
            WriteToCsv(Filename, IncludeHeader: true);
        }

        /// <inheritdoc />
        public abstract void WriteToCsv(string Filename, bool IncludeHeader);

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

        /// <inheritdoc />
        public int Count
        {
            get
            {
                return Items.Value.Count;
            }
        }

        /// <summary>
        /// Gets the Seamless Views entity at the specified index in the data set.
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
        /// Gets the Seamless Views entity at the specified index in the data set.
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
