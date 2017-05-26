using System.Data.SqlClient;

namespace EduHub.Data.Entities
{
    partial class ARDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the FAIR_MARKET column. New to C21v58.
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

    partial class CRFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that the AMEMO column has the right type. Modified to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[CRF]') AND
	name = 'AMEMO' AND max_length = -1";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class DFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the SCH_ED_A_LU, NON_SCH_ED_A_LU, OCCUP_STATUS_A_LU, SCH_ED_B_LU, NON_SCH_ED_B_LU,
            //  OCCUP_STATUS_B_LU, CNSE, CSE, and FSE columns. New to C21v58.
            const string sql = @"SELECT
	9 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DF]') AND
	name IN ('SCH_ED_A_LU', 'NON_SCH_ED_A_LU', 'OCCUP_STATUS_A_LU', 'SCH_ED_B_LU',
             'NON_SCH_ED_B_LU', 'OCCUP_STATUS_B_LU', 'CNSE', 'CSE', 'FSE')";

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
            // Check for the existance of the TRDEL_MONTHS column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DRF]') AND
	name = 'TRDEL_MONTHS'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class GLDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the BATCHABLE column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[GL]') AND
	name = 'BATCHABLE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class GLFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the FEE_CODE column. New to C21v58.
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
            // Check for the existance of the DISABILITY column. New to C21v57.
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
            // Check for the existance of the DISABILITY column. New to C21v57.
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
            // Check for the existance of the BIRTHDATE_FROM and BIRTHDATE_TO columns. New to C21v57.
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
            // Check for the existance of the DATA_ENTRY column. New to C21v58.
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
            // Check for the existance of the BATCHABLE column. New to C21v58.
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
            // Check for the existance of the EDUPAY column. New to C21v57.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[QB]') AND
	name = 'EDUPAY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SCIDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the SCH_DEFINED01, SCH_DEFINED02 and PREF_MAIL_MECH columns. New to C21v58.
            const string sql = @"SELECT
	3 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SCI]') AND
	name IN ('SCH_DEFINED01', 'SCH_DEFINED02', 'PREF_MAIL_MECH')";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the SF_Index_SMS_REPLY index. New to C21v58.

            // Check for the existance of the DRIVERS_LIC_NO, DRIVERS_LIC_EXPIRY, VIT_EXPIRY,
            //   WWCC_NUMBER, WWCC_EXPIRY and WWCC_TYPE columns. New to C21v58.
            const string sql = @"SELECT
	(SELECT
		1 - COUNT(*)
	FROM sys.indexes
	WHERE
		object_id = OBJECT_ID(N'[dbo].[SF]') AND
		name = 'SF_Index_SMS_REPLY')
	+
	(SELECT
		7 - COUNT(*)
	FROM sys.columns
	WHERE
		object_id = OBJECT_ID(N'[dbo].[SF]') AND
		name IN ('DRIVERS_LIC_NO', 'DRIVERS_LIC_EXPIRY', 'VIT_EXPIRY', 'WWCC_NUMBER', 'WWCC_EXPIRY', 'WWCC_TYPE', 'SMS_REPLY'))";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    partial class SGDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the VET column. New to C21v58.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SG]') AND
	name = 'VET'";

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

    partial class STDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existance of the VET, USI, SCH_DEFINED01, SCH_DEFINED02 and TEACHER_RECOMMENDATION columns. New to C21v58.
            const string sql = @"SELECT
	5 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[ST]') AND
	name IN
        ('VET', 'USI', 'SCH_DEFINED01', 'SCH_DEFINED02', 'TEACHER_RECOMMENDATION')";

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

    partial class TCTQDataSet
    {
        /// <inheritdoc />
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

}
