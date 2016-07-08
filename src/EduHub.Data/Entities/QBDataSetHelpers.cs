using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class QBDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the EDUPAY column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[QB]') AND
	name = 'EDUPAY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
