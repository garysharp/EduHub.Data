using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eduHub data set contract
    /// </summary>
    public interface IEduHubDataSet : IList
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// <see cref="EduHubContext"/> this entity belongs to
        /// </summary>
        EduHubContext Context { get; }

        /// <summary>
        /// Data Set Base Location
        /// </summary>
        [Obsolete("Use " + nameof(FilenameBase) + " instead")]
        string Filename { get; }

        /// <summary>
        /// Data Set Base Location
        /// </summary>
        string FilenameBase { get; }

        /// <summary>
        /// Data Set Delta Location
        /// </summary>
        string FilenameDelta { get; }

        /// <summary>
        /// Data Set total size in bytes (including Delta if available)
        /// </summary>
        long FileSize { get; }

        /// <summary>
        /// Data Set Base total size in bytes (excluding delta)
        /// </summary>
        long FileSizeBase { get; }

        /// <summary>
        /// Data Set Delta total size in bytes (0 if delta is unavailable)
        /// </summary>
        long FileSizeDelta { get; }

        /// <summary>
        /// Indicates that the eduHub Directory contains this data set
        /// </summary>
        bool IsAvailable { get; }

        /// <summary>
        /// Indicates that the eduHub Directory contains this data set and a newer matching delta file
        /// </summary>
        bool IsDeltaAvailable { get; }

        /// <summary>
        /// Throws an exception if the set is unavailable
        /// </summary>
        void EnsureAvailable();

        /// <summary>
        /// Throws an exception if the delta set is unavailable
        /// </summary>
        void EnsureDeltaAvailable();

        /// <summary>
        /// Data Set files last modified (including Delta if available)
        /// </summary>
        DateTime LastModified { get; }

        /// <summary>
        /// Data Set Base file last modified
        /// </summary>
        DateTime LastModifiedBase { get; }

        /// <summary>
        /// Data Set Delta file last modified
        /// </summary>
        DateTime LastModifiedDelta { get; }

        /// <summary>
        /// Indicates that this entity supports a last modified time stamp
        /// </summary>
        bool SupportsEntityLastModified { get; }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a database table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection);

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks whether the database table needs to be recreated (possibly due to schema changes). Returns null if no check is needed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection);

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes. Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/>, or null if the data set has no non-clustered indexes</returns>
        SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection);

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/>, or null if the data set has no non-clustered indexes</returns>
        SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection);

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the data set through <see cref="IEduHubDataSetDataReader"/> which includes progress
        /// </summary>
        /// <returns>A <see cref="IEduHubDataSetDataReader"/> for the data set</returns>
        IEduHubDataSetDataReader GetDataReader();

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database</param>
        EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database</param>
        Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="ProgressNotification">Intermittently reports percentage of progress and the current task</param>
        EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database, Action<double, string> ProgressNotification);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="ProgressNotification">Intermittently reports percentage of progress and the current task</param>
        Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database, Action<double, string> ProgressNotification);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database, string SqlUsername, string SqlPassword);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database, string SqlUsername, string SqlPassword);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        /// <param name="ProgressNotification">Intermittently reports percentage of progress and the current task</param>
        EduHubSqlServerWriteResult WriteToSqlServer(string Server, string Database, string SqlUsername, string SqlPassword, Action<double, string> ProgressNotification);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        /// <param name="ProgressNotification">Intermittently reports percentage of progress and the current task</param>
        Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(string Server, string Database, string SqlUsername, string SqlPassword, Action<double, string> ProgressNotification);

        /// <summary>
        /// Writes the data set to a SQL Server database table using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        EduHubSqlServerWriteResult WriteToSqlServer(SqlConnection Connection);

        /// <summary>
        /// Writes the data set to a SQL Server database table using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(SqlConnection Connection);

        /// <summary>
        /// Writes the data set to a SQL Server database table using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        /// <param name="ProgressNotification">Intermittently reports percentage of progress and the current task</param>
        EduHubSqlServerWriteResult WriteToSqlServer(SqlConnection Connection, Action<double, string> ProgressNotification);

        /// <summary>
        /// Writes the data set to a SQL Server database table using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        /// <param name="ProgressNotification">Intermittently reports percentage of progress</param>
        Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(SqlConnection Connection, Action<double, string> ProgressNotification);

        /// <summary>
        /// Writes the data set to a SQL Server database table using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        /// <param name="ProgressNotification">Intermittently reports percentage of progress and the current task</param>
        /// <param name="LastFullWrite">Timestamp of the last full write, used to determine if a delta update is sufficient</param>
        /// <param name="LastDeltaWrite">Timestamp of the delta write, used to determine if a delta partial update is sufficient</param>
        /// <param name="EntityLastModified">Maximum last modified entity timestamp</param>
        Task<EduHubSqlServerWriteResult> WriteToSqlServerAsync(SqlConnection Connection, Action<double, string> ProgressNotification, DateTime? LastFullWrite, DateTime? LastDeltaWrite, DateTime? EntityLastModified);

        /// <summary>
        /// Determines which method to use to write to the SQL Server based on parameters
        /// </summary>
        /// <param name="LastFullWrite">The last time a full write was performed</param>
        /// <param name="LastDeltaWrite">The last time a delta write was performed</param>
        /// <param name="EntityLastModifiedAvailable">Indicates that a last entity updated timestamp is available</param>
        /// <returns>A <see cref="EduHubSqlServerWriteMode"/> indicating which mode should be used</returns>
        EduHubSqlServerWriteMode DetermineSqlServerWriteType(DateTime? LastFullWrite, DateTime? LastDeltaWrite, bool EntityLastModifiedAvailable);
    }
}
