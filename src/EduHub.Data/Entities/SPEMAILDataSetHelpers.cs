using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class SPEMAILDataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the correct DESCRIPTION column. Updated in C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SPEMAIL]') AND
    name = 'DESCRIPTION' AND
    max_length = 50";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
