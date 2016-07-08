using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class CRFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the KCPC_TID column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[CRF]') AND
	name = 'KCPC_TID'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
