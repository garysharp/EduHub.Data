using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class ARDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the FAIR_MARKET column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[AR]') AND
	name = 'FAIR_MARKET'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class CRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the PR_APPROVE column. New to C21v59.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[CR]') AND
	name = 'PR_APPROVE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class CRFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the PO_PRINTED, APPROVED_BY, STAFF_ORDER_BY, CRPRTID columns. New to C21v59.
            const string sql = @"SELECT
	4 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[CRF]') AND
	name IN ('PO_PRINTED', 'APPROVED_BY', 'STAFF_ORDER_BY', 'CRPRTID')";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class DF_TFRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the EMERG_CONTACT columns have the right type. Modified in C21v60.
            const string sql = @"SELECT
	4 - COUNT(*)
FROM sys.columns c
JOIN sys.types t ON c.system_type_id=t.system_type_id
WHERE
	object_id = OBJECT_ID(N'[dbo].[DF_TFR]') AND
	c.name LIKE 'EMERG_CONTACT0%' AND
	t.name = 'varchar'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class DFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the EMERG_CONTACT columns have the right type. Modified in C21v60.
            const string sql = @"SELECT
	4 - COUNT(*)
FROM sys.columns c
JOIN sys.types t ON c.system_type_id=t.system_type_id
WHERE
	object_id = OBJECT_ID(N'[dbo].[DF]') AND
	c.name LIKE 'EMERG_CONTACT0%' AND
	t.name = 'varchar'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class DRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the REMARK and NOTES columns have the right type. Modified to C21v58.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DR]') AND
	name IN ('REMARK', 'NOTES') AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class DRFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the TRDEL_MONTHS column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DRF]') AND
	name = 'TRDEL_MONTHS'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class FDT_IMPDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the NOTES columns have the right type. Modified in C21v60.
            const string sql = @"SELECT
	4 - COUNT(*)
FROM sys.columns c
JOIN sys.types t ON c.system_type_id=t.system_type_id
WHERE
	object_id = OBJECT_ID(N'[dbo].[FDT_IMP]') AND
	c.name LIKE 'NOTES0%' AND
	t.name = 'varchar'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class GLBANKDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the COMMENTS_COMMIT column. New to C21v60.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[GLBANK]') AND
	name = 'COMMENTS_COMMIT'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class GLDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the BATCHABLE column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[GL]') AND
	name = 'BATCHABLE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class GLFBANKDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the SUBPROGRAM column. New to C21v60.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[GLFBANK]') AND
	name = 'SUBPROGRAM'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class GLFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the FEE_CODE column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[GLF]') AND
	name = 'FEE_CODE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class KCM_TFRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the DISABILITY column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND
	name = 'DISABILITY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class KCMDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the DISABILITY column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KCM]') AND
	name = 'DISABILITY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class KCYDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the BIRTHDATE_FROM and BIRTHDATE_TO columns. New to C21v57.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KCY]') AND
	name IN ('BIRTHDATE_FROM', 'BIRTHDATE_TO')";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class KDIDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the MIN_SCORE and MAX_SCORE columns have the right type. Modified to C21v58.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KDI]') AND
	name IN ('MIN_SCORE', 'MAX_SCORE') AND
	max_length = 6";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class KDODataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the DATA_ENTRY column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KDO]') AND
    name = 'DATA_ENTRY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class KGLSUBDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the BATCHABLE column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KGLSUB]') AND
    name = 'BATCHABLE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class QBDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the EDUPAY column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[QB]') AND
	name = 'EDUPAY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SCEN_STDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the CNSE, CSE and FSE columns. New to C21v59.
            const string sql = @"SELECT
	3 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SCEN_ST]') AND
	name IN ('CNSE', 'CSE', 'FSE')";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SCIDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the SF_PURCH_MANAGER column. New to C21v59.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SCI]') AND
	name = 'SF_PURCH_MANAGER'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the EMERG_CONTACT columns have the right type. Modified in C21v60.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns c
JOIN sys.types t ON c.system_type_id=t.system_type_id
WHERE
	object_id = OBJECT_ID(N'[dbo].[SF]') AND
	c.name LIKE 'EMERG_CONTACT0%' AND
	t.name = 'varchar'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SGDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the VET column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SG]') AND
	name = 'VET'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SKGSDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the CONCURRENT_ENTROL column. New to C21v60.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SKGS]') AND
	name = 'CONCURRENT_ENROL'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SMDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the COMMENTA column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SM]') AND
	name = 'COMMENTA' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SMCDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the SYMPTOMS, SMC_COMMENT, SMC_ACTION, ASTHMA_MGT_PLAN and
            //  DISABILITY_ADJUSTMENT columns have the right type. Modified to C21v58.
            const string sql = @"SELECT
	5 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SMC]') AND
	name IN ('SYMPTOMS', 'SMC_COMMENT', 'SMC_ACTION', 'ASTHMA_MGT_PLAN', 'DISABILITY_ADJUSTMENT') AND
    max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class ST_TFRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the EMERG_CONTACT columns have the right type. Modified in C21v60.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns c
JOIN sys.types t ON c.system_type_id=t.system_type_id
WHERE
	object_id = OBJECT_ID(N'[dbo].[ST_TFR]') AND
	c.name LIKE 'EMERG_CONTACT0%' AND
	t.name = 'varchar'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the EMERG_CONTACT columns have the right type. Modified in C21v60.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns c
JOIN sys.types t ON c.system_type_id=t.system_type_id
WHERE
	object_id = OBJECT_ID(N'[dbo].[ST]') AND
	c.name LIKE 'EMERG_CONTACT0%' AND
	t.name = 'varchar'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STARDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the RESTRICTION column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STAR]') AND
	name = 'RESTRICTION' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STMADataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the COMMENTA and COMMENTB columns have the right type. Modified to C21v58.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STMA]') AND
	name IN ('COMMENTA', 'COMMENTB') AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STMBDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the CREATOR column. New to C21v59.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STMB]') AND
	name = 'CREATOR'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STNATDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the REMARK and ATTACHMENT columns have the right type. Modified to C21v58.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STNAT]') AND
	name IN ('REMARK', 'ATTACHMENT') AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STPODataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the PERFORMANCE and OTHER columns have the right type. Modified to C21v58.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STPO]') AND
	name IN ('PERFORMANCE', 'OTHER') AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STPSDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the REASON_LEFT column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STPS]') AND
	name = 'REASON_LEFT' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STVDIDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the SCORE column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STVDI]') AND
	name = 'SCORE' AND max_length = 6";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class STVDODataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the SCORE column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STVDO]') AND
	name = 'SCORE' AND max_length = 6";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SUDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the OVERVIEW column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SU]') AND
	name = 'OVERVIEW' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SVAGDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the VDOMAIN column. New to C21v59.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SVAG]') AND
	name = 'VDOMAIN'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TCDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the DAY_COMMENT column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[TC]') AND
	name = 'DAY_COMMENT' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TCTBDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the COMMENT_A column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[TCTB]') AND
	name = 'COMMENT_A' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TCTDDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the TCTD_Index_TCTDKEY_TIME_TYPE_QKEY index. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.indexes
WHERE
	object_id = OBJECT_ID(N'[dbo].[TCTD]') AND
	name = 'TCTD_Index_TCTDKEY_TIME_TYPE_QKEY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TCTQDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the TCTQ_Index_TCTQKEY_QROW_QKEY index. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.indexes
WHERE
	object_id = OBJECT_ID(N'[dbo].[TCTQ]') AND
	name = 'TCTQ_Index_TCTQKEY_QROW_QKEY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TCTRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the COMMENT_R column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[TCTR]') AND
	name = 'COMMENT_R' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TEDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the COMMENTS column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[TE]') AND
	name = 'COMMENTS' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TETNDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the TETN_Index_TETELINK_ATTENDEE_TYPE index. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.indexes
WHERE
	object_id = OBJECT_ID(N'[dbo].[TETN]') AND
	name = 'TETN_Index_TETELINK_ATTENDEE_TYPE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class TTDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the GSOLS column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[TT]') AND
	name = 'GSOLS' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class UMDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the LATITUDE and LONGITUDE columns. New to C21v59.
            const string sql = @"SELECT
	2 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[UM]') AND
	name IN ('LATITUDE', 'LONGITUDE')";

            return new SqlCommand(sql, SqlConnection);
        }
    }

}
