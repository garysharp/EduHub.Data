using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class DFDataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the USER_NAME and WEB_ENABLED columns. New to C21v57.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DF]') AND
	name IN ('USER_NAME', 'WEB_ENABLED')";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
