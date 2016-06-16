using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class SVAGDataSet
    {
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the NUMBER_AT31-34 and NO_NT columns. New to C21v57.
            const string sql = @"SELECT
	5 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SVAG]') AND
	name IN ('NUMBER_AT31', 'NUMBER_AT32', 'NUMBER_AT33', 'NUMBER_AT34', 'NO_NT')";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
