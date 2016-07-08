using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class KCYDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the BIRTHDATE_FROM and BIRTHDATE_TO columns. New to C21v57.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KCY]') AND
	name IN ('BIRTHDATE_FROM', 'BIRTHDATE_TO')";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
