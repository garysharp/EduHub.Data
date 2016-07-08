using System.Data.SqlClient;
using System.Linq;

namespace EduHub.Data.Entities
{
    partial class SCIDataSet
    {

        private SCI _ADMIN_SITE;

        /// <summary>
        /// The administrative campus for this school
        /// </summary>
        public SCI ADMIN_SITE
        {
            get
            {
                if (_ADMIN_SITE == null)
                {
                    _ADMIN_SITE = this.FirstOrDefault(s => s.ADMIN_SITE == "Y");
                }
                return _ADMIN_SITE;
            }
        }

        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the TFR_ENROLMENT_DATE column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SCI]') AND
	name = 'TFR_ENROLMENT_DATE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
