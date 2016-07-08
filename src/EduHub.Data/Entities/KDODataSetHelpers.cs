using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class KDODataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the correct KDOKEY column. Updated in C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KDO]') AND
    name = 'KDOKEY' AND
    max_length = 10";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
