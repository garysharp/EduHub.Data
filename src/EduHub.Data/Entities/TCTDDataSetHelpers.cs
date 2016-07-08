using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class TCTDDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the TCTD_Index_TCTDKEY_TIME_TYPE_QKEY index. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.indexes
WHERE
	object_id = OBJECT_ID(N'[dbo].[TCTD]') AND
	name = 'TCTD_Index_TCTDKEY_TIME_TYPE_QKEY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
