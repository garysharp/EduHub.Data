using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// EduHub data set contract
    /// </summary>
    public interface IDataSet : IList
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Data Set Location
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// Data Set Delta Location
        /// </summary>
        string FilenameDelta { get; }

        /// <summary>
        /// Indicates if the eduHub Directory contains this data set
        /// </summary>
        bool IsAvailable { get; }

        /// <summary>
        /// Indicates if the eduHub Directory contains this data set and a newer matching delta file
        /// </summary>
        bool IsDeltaAvailable { get; }

        /// <summary>
        /// Throws an exception if the set is unavailable
        /// </summary>
        void EnsureAvailable();

        /// <summary>
        /// Data Set Age
        /// </summary>
        DateTime? Age { get; }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the data set</returns>
        IDataReader GetDataReader();

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database</param>
        void WriteToSqlServer(string Server, string Database);

        /// <summary>
        /// Writes the data set to a SQL Server database table, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        void WriteToSqlServer(string Server, string Database, string SqlUsername, string SqlPassword);

        /// <summary>
        /// Writes the data set to a SQL Server database table using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        void WriteToSqlServer(SqlConnection Connection);
    }
}
