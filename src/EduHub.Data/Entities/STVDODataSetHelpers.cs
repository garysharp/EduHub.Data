using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class STVDODataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the correct VDOMAIN and existance of the ORIGINAL_SCHOOL column. Updated/New to C21v57.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STVDO]') AND
	(
    (name = 'VDOMAIN' AND max_length = 10) OR
	name = 'ORIGINAL_SCHOOL'
	)";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
