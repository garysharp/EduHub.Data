using System.Data.SqlClient;

namespace EduHub.Data
{
    internal static class SqlHelpers
    {
        internal static SqlConnectionStringBuilder BuildSqlConnectionString(string Server, string Database)
        {
            return new SqlConnectionStringBuilder()
            {
                ApplicationName = "EduHub.Data",
                DataSource = Server,
                InitialCatalog = Database,
                MultipleActiveResultSets = true,
                IntegratedSecurity = true
            };
        }

        internal static SqlConnectionStringBuilder BuildSqlConnectionString(string Server, string Database, string SqlUsername, string SqlPassword)
        {
            return new SqlConnectionStringBuilder()
            {
                ApplicationName = "EduHub.Data",
                DataSource = Server,
                InitialCatalog = Database,
                MultipleActiveResultSets = true,
                UserID = SqlUsername,
                Password = SqlPassword
            };
        }
    }
}
