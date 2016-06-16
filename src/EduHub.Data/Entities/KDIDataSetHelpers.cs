using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class KDIDataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the correct KDOKEY and existance of the CURRICULUM column. Updated/New to C21v57.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KDI]') AND
	(
    (name = 'KDOKEY' AND max_length = 10) OR
	name = 'CURRICULUM'
	)";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
