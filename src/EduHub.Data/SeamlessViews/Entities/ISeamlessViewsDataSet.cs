using EduHub.Data.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Seamless View data set contract
    /// </summary>
    public interface ISeamlessViewsDataSet : IList
    {
        /// <summary>
        /// Seamless View Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Lists the data sets required for this view
        /// </summary>
        IEnumerable<IEduHubDataSet> GetRequiredDataSets();

        /// <summary>
        /// Indicates if the eduHub Directory contains all needed data sets for this view
        /// </summary>
        bool IsAvailable { get; }

        /// <summary>
        /// Throws an exception if the view is unavailable
        /// </summary>
        void EnsureAvailable();

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database to add the view to, and which contains the eduHub Datasets</param>
        void CreateInSqlServer(string Server, string Database);

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database to add the view to, and which contains the eduHub Datasets</param>
        Task CreateInSqlServerAsync(string Server, string Database);

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the Seamless Views SQL database</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        void CreateInSqlServer(string Server, string Database, string ParentDatabase);

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the Seamless Views SQL database</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        Task CreateInSqlServerAsync(string Server, string Database, string ParentDatabase);

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database to add the view to, and which contains the eduHub Datasets</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        void CreateInSqlServer(string Server, string Database, string SqlUsername, string SqlPassword);

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database to add the view to, and which contains the eduHub Datasets</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        Task CreateInSqlServerAsync(string Server, string Database, string SqlUsername, string SqlPassword);

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the Seamless Views SQL database</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        void CreateInSqlServer(string Server, string Database, string ParentDatabase, string SqlUsername, string SqlPassword);

        /// <summary>
        /// Creates the view in a SQL Server database, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the Seamless Views SQL database</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        Task CreateInSqlServerAsync(string Server, string Database, string ParentDatabase, string SqlUsername, string SqlPassword);

        /// <summary>
        /// Creates the view in a SQL Server database using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        void CreateInSqlServer(SqlConnection Connection);

        /// <summary>
        /// Creates the view in a SQL Server database using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        Task CreateInSqlServerAsync(SqlConnection Connection);

        /// <summary>
        /// Creates the view in a SQL Server database using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        void CreateInSqlServer(SqlConnection Connection, string ParentDatabase);

        /// <summary>
        /// Creates the view in a SQL Server database using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        Task CreateInSqlServerAsync(SqlConnection Connection, string ParentDatabase);

        /// <summary>
        /// Writes the view in CSV format including the header
        /// </summary>
        /// <param name="Filename">Location to write the CSV file</param>
        void WriteToCsv(string Filename);

        /// <summary>
        /// Writes the view in CSV format
        /// </summary>
        /// <param name="Filename">Location to write the CSV file</param>
        /// <param name="IncludeHeader">True when the header is written</param>
        void WriteToCsv(string Filename, bool IncludeHeader);

        /// <summary>
        /// Gets the number of entities in the data set.
        /// </summary>
        /// <returns>The number of entities in the data set.</returns>
        new int Count { get; }
    }
}
