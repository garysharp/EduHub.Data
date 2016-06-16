using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class TCTQDataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the TCTQ_Index_TCTQKEY_QROW_QKEY index. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.indexes
WHERE
	object_id = OBJECT_ID(N'[dbo].[TCTQ]') AND
	name = 'TCTQ_Index_TCTQKEY_QROW_QKEY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
