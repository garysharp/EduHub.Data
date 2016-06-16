using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class TETNDataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the TETN_Index_TETELINK_ATTENDEE_TYPE index. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.indexes
WHERE
	object_id = OBJECT_ID(N'[dbo].[TETN]') AND
	name = 'TETN_Index_TETELINK_ATTENDEE_TYPE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
