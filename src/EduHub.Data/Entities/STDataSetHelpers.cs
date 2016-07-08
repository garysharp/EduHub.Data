using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class STDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the LEGAL_LIMIT_DECISION, LEGAL_LIMIT_CONTACT, LEGAL_LIMITATION,
            //  DOC_COPIES, LISTED_IN_SOCS, SUPPORT_SERVICES, STUDENT_SUPPORT, STUDENT_OTHER_SUPPORT,
            //  SUPPORT_GROUP, CHILD_PROTECTION, ATTENDANCE_CONCERNS, DISCIPLINARY_ACTION, WELFARE_RISKS,
            //  EFFORT, CLASS_BEHAVIOUR, ORGANISATION, SOCIAL_BEHAVIOUR, LEARNING_SUPPORT, NEW_ARRIVALS_PROGRAM,
            //  REFUGEE_BACKGROUND and TRANSFER_DOCS_SENT columns. New to C21v57.
            const string sql = @"SELECT
	21 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[ST]') AND
	name IN
        ('LEGAL_LIMIT_DECISION', 'LEGAL_LIMIT_CONTACT', 'LEGAL_LIMITATION', 'DOC_COPIES', 'LISTED_IN_SOCS',
         'SUPPORT_SERVICES', 'STUDENT_SUPPORT', 'STUDENT_OTHER_SUPPORT', 'SUPPORT_GROUP', 'CHILD_PROTECTION',
         'ATTENDANCE_CONCERNS', 'DISCIPLINARY_ACTION', 'WELFARE_RISKS', 'EFFORT', 'CLASS_BEHAVIOUR',
         'ORGANISATION', 'SOCIAL_BEHAVIOUR', 'LEARNING_SUPPORT', 'NEW_ARRIVALS_PROGRAM',
         'REFUGEE_BACKGROUND', 'TRANSFER_DOCS_SENT')";

            return new SqlCommand(sql, SqlConnection);
        }
    }
}
