using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class SMC_TFRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the DISABILITY_ADJUSTMENT column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SMC_TFR]') AND
	name = 'DISABILITY_ADJUSTMENT'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
