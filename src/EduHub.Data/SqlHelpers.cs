#if NET452
using System.Data.SqlClient;
#elif NET10_0
using Microsoft.Data.SqlClient;
#endif

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
#if NET10_0
                Encrypt = false,
#endif
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
#if NET10_0
                Encrypt = false,
#endif
                UserID = SqlUsername,
                Password = SqlPassword
            };
        }
    }
}
