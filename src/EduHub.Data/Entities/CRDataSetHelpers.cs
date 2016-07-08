using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class CRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the TRADE_INFO01-10 columns. New to C21v57.
            const string sql = @"SELECT
	10 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[CR]') AND
	name IN ('TRADE_INFO01', 'TRADE_INFO02', 'TRADE_INFO03', 'TRADE_INFO04', 'TRADE_INFO05',
             'TRADE_INFO06', 'TRADE_INFO07', 'TRADE_INFO08', 'TRADE_INFO09', 'TRADE_INFO10')";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
