using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class DRFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the TRDEL_MONTHS column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DRF]') AND
	name = 'TRDEL_MONTHS'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
