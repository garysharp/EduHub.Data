using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class KCM_TFRDataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the DISABILITY column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND
	name = 'DISABILITY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
