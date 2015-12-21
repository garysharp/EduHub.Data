using EduHub.Data.Entities;
using EduHub.Data.SeamlessViews;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EduHub.Data
{
    public partial class EduHubContext
    {
        private readonly SeamlessViewsContext seamlessViews;

        /// <summary>
        /// Default directory used when creating a context if none is provided to the constructor
        /// </summary>
        public static string DefaultEduHubDirectory { get; set; } = @"D:\eduHub";

        /// <summary>
        /// Default site identifier used when creating a context if none is provided to the constructor
        /// </summary>
        public static string DefaultEduHubSiteIdentifier { get; set; } = null;

        /// <summary>
        /// eduHub Data Set Directory
        /// </summary>
        public string EduHubDirectory { get; private set; }
        /// <summary>
        /// Data Set CSV Suffix
        /// </summary>
        public string EduHubSiteIdentifier { get; private set; }

        /// <summary>
        /// Creates an EduHubContext with a dynamically determined site identifier
        /// </summary>
        /// <param name="EduHubDirectory">Directory which contains the eduHub .csv data sets.</param>
        /// <exception cref="ArgumentException">eduHub Directory does not exist, has no valid data sets or contains multiple data sets</exception>
        public EduHubContext(string EduHubDirectory)
            : this(EduHubDirectory, null)
        {
        }

        /// <summary>
        /// Creates an EduHubContext with the default directory and dynamically determined site identifier
        /// </summary>
        /// <exception cref="ArgumentException">Default eduHub Directory does not exist, has no valid data sets or contains multiple data sets</exception>
        public EduHubContext()
            : this(null, null)
        {
        }

        /// <summary>
        /// Age of newest eduHub Data Set
        /// </summary>
        public DateTime? Age
        {
            get
            {
                return GetAvailableDataSetFiles()
                    .Max(f => (DateTime?)File.GetLastWriteTime(f));
            }
        }

        /// <summary>
        /// Names of all Data Sets
        /// </summary>
        public IEnumerable<string> GetDataSetNames()
        {
            foreach (var dataSet in GetDataSets())
            {
                yield return dataSet.Name;
            }
        }

        /// <summary>
        /// Retrieves a Data Set by Name
        /// </summary>
        /// <param name="Name">Name of the Data Set</param>
        public IEduHubDataSet GetDataSet(string Name)
        {
            foreach (var dataSet in GetDataSets())
            {
                if (dataSet.Name.Equals(Name, StringComparison.OrdinalIgnoreCase))
                {
                    return dataSet;
                }
            }

            throw new ArgumentException($"Unknown EduHub Data Set [{Name}]", nameof(Name));
        }

        /// <summary>
        /// Filenames of all Available eduHub Data Sets
        /// </summary>
        public IEnumerable<string> GetAvailableDataSetFiles()
        {
            // Valid Sets
            var sets = new HashSet<string>(GetDataSetNames(), StringComparer.OrdinalIgnoreCase);

            foreach (var file in Directory.EnumerateFiles(EduHubDirectory, $"*_{EduHubSiteIdentifier}.csv"))
            {
                var filename = Path.GetFileName(file);
                var fileSet = filename.Substring(0, filename.Length - EduHubSiteIdentifier.Length - 5);
                if (sets.Contains(fileSet))
                {
                    yield return file;
                }
            }
        }

        /// <summary>
        /// Names of Available Data Sets
        /// </summary>
        public IEnumerable<string> GetAvailableDataSetNames()
        {
            foreach (var file in GetAvailableDataSetFiles())
            {
                var filename = Path.GetFileName(file);
                yield return filename.Substring(0, filename.Length - EduHubSiteIdentifier.Length - 5);
            }
        }

        /// <summary>
        /// Available Data Sets
        /// </summary>
        public IEnumerable<IEduHubDataSet> GetAvailableDataSets()
        {
            foreach (var name in GetAvailableDataSetNames())
            {
                yield return GetDataSet(name);
            }
        }

        /// <summary>
        /// Determines site identifiers which are present in the eduHub directory
        /// </summary>
        /// <param name="EduHubDirectory">Directory which contains the eduHub CSV Data Sets</param>
        /// <returns>Enumerable of Site Identifiers</returns>
        /// <exception cref="ArgumentNullException"><see cref="EduHubDirectory"/> parameter is null</exception>
        /// <exception cref="ArgumentException">EduHub Directory does not exist</exception>
        public static IEnumerable<string> GetSiteIdentifiers(string EduHubDirectory)
        {
            if (string.IsNullOrWhiteSpace(EduHubDirectory))
                throw new ArgumentNullException(nameof(EduHubDirectory));
            if (!Directory.Exists(EduHubDirectory))
                throw new ArgumentException($"EduHub Directory [{EduHubDirectory}] does not exist");

            var testSiteIdentifier = new Regex(@".*_(.+)(?<!_D).csv$", RegexOptions.IgnoreCase);
            var siteIdentifiers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var file in Directory.EnumerateFiles(EduHubDirectory, "*.csv"))
            {
                var match = testSiteIdentifier.Match(file);
                if (match.Success)
                {
                    var siteIdentifier = match.Groups[1].Value;
                    if (siteIdentifiers.Add(siteIdentifier))
                    {
                        yield return siteIdentifier;
                    }
                }
            }
        }

        /// <summary>
        /// Determines site identifiers which are present in the default eduHub directory
        /// </summary>
        /// <returns>Enumerable of Site Identifiers</returns>
        /// <exception cref="ArgumentException"><see cref="DefaultEduHubDirectory"/> does not exist</exception>
        /// <exception cref="ArgumentNullException"><see cref="DefaultEduHubDirectory"/> property is null</exception>
        public static IEnumerable<string> GetSiteIdentifiers()
        {
            if (string.IsNullOrWhiteSpace(DefaultEduHubDirectory))
                throw new ArgumentNullException(nameof(DefaultEduHubDirectory));

            return GetSiteIdentifiers(DefaultEduHubDirectory);
        }

        /// <summary>
        /// Determines a site identifier for the eduHub directory
        /// </summary>
        /// <param name="EduHubDirectory"></param>
        /// <returns>A site identifier</returns>
        /// <exception cref="ArgumentException">EduHub Directory does not exist, has no valid data sets or contains multiple data sets</exception>
        /// <exception cref="ArgumentNullException"><see cref="EduHubDirectory"/> parameter is null</exception>
        public static string GetSiteIdentifier(string EduHubDirectory)
        {
            if (string.IsNullOrWhiteSpace(EduHubDirectory))
                throw new ArgumentNullException(nameof(EduHubDirectory));

            var identifiers = GetSiteIdentifiers(EduHubDirectory).ToList();

            if (identifiers.Count == 0)
            {
                throw new ArgumentException($"EduHub Directory [{EduHubDirectory}] contains no valid data sets.", nameof(EduHubDirectory));
            }
            else if (identifiers.Count > 1)
            {
                throw new ArgumentException($"EduHub Directory [{EduHubDirectory}] contains data sets for multiple sites. Explicitly pass a site identifier.", nameof(EduHubDirectory));
            }

            return identifiers[0];
        }

        /// <summary>
        /// Determines a site identifier for the default eduHub directory
        /// </summary>
        /// <returns>A site identifier</returns>
        /// <exception cref="ArgumentException"><see cref="DefaultEduHubDirectory"/> does not exist, has no valid data sets or contains multiple data sets</exception>
        /// <exception cref="ArgumentNullException"><see cref="DefaultEduHubDirectory"/> property is null</exception>
        public static string GetSiteIdentifier()
        {
            if (string.IsNullOrWhiteSpace(DefaultEduHubDirectory))
                throw new ArgumentNullException(nameof(DefaultEduHubDirectory));

            return GetSiteIdentifier(DefaultEduHubDirectory);
        }

        /// <summary>
        /// Seamless Views
        /// </summary>
        public SeamlessViewsContext SeamlessViews
        {
            get
            {
                return seamlessViews;
            }
        }

        /// <summary>
        /// Writes all available data sets to a SQL Server database table, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database</param>
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

        /// <summary>
        /// Writes all available data sets to a SQL Server database table, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to</param>
        /// <param name="Database">The name of the SQL database</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
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

        /// <summary>
        /// Writes all available data sets to a SQL Server database table using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        public void WriteToSqlServer(SqlConnection Connection)
        {
            foreach (var dataSet in GetAvailableDataSets())
            {
                dataSet.WriteToSqlServer(Connection);
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"eduHub Context for '{EduHubDirectory}' [Site: {EduHubSiteIdentifier}]";
        }
    }
}
