#if NET452
using System.Data.SqlClient;
#elif NET10_0
using Microsoft.Data.SqlClient;
#endif

namespace EduHub.Data.Entities
{
    public partial class ARDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the AKR_DESC column. New to C21v67.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[AR]') AND
	name = 'AKR_DESC'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class CRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the SSB column. New to C21v72.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[CR]') AND
	name = 'SSB'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class CRFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the OLD_TRDELETE column. New to C21v73.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[CRF]') AND
	name = 'OLD_TRDELETE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

#if !EduHubScoped
    public partial class DF_TFRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the HEALTH_SUM_SI_ID column. Modified in C21v67.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns c
JOIN sys.types t ON c.system_type_id=t.system_type_id
WHERE
	object_id = OBJECT_ID(N'[dbo].[DF_TFR]') AND
	c.name = 'HEALTH_SUM_SI_ID'";

            return new SqlCommand(sql, SqlConnection);
        }
    }
#endif

    public partial class DFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the PREF_NAME_A column. New to C21v73.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DF]') AND
	name = 'PREF_NAME_A'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class DFFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the OLD_TRDELETE column. New to C21v73.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DFF]') AND
	name = 'OLD_TRDELETE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class DRDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the MAILCOUNTRY column. New to C21v67.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[DR]') AND
	name = 'MAILCOUNTRY'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

#if !EduHubScoped
    public partial class DRFDataSet
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

    public partial class FDT_IMPDataSet
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

    public partial class GLBANKDataSet
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
#endif

    public partial class GLDataSet
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

#if !EduHubScoped
    public partial class GLFBANKDataSet
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
#endif

    public partial class GLFDataSet
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

#if !EduHubScoped
    public partial class KCM_TFRDataSet
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
#endif

    public partial class KCMDataSet
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

    public partial class KCYDataSet
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

    public partial class KDIDataSet
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

    public partial class KDODataSet
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

    public partial class KGCDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the SELF_DESCRIBED column. New to C21v64.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KGC]') AND
    name = 'SELF_DESCRIBED'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class KGHDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the SELF_DESCRIBED column. New to C21v64.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[KGH]') AND
    name = 'SELF_DESCRIBED'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class KGLSUBDataSet
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

#if !EduHubScoped
    public partial class QBDataSet
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

    public partial class SCEN_STDataSet
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
#endif

    public partial class SCIDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the NCCD_SUMMARY_SAVED column. New to C21v64.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SCI]') AND
	name = 'NCCD_SUMMARY_SAVED'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class SFDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check that column lengths are correct. Changed in C21v67.
            const string sql = @"SELECT
	9 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SF]') AND
	(
		(name = 'FIRST_NAME' AND max_length >= 30)
		OR
		(name = 'PREF_NAME' AND max_length >= 30)
		OR
		(name = 'E_MAIL' AND max_length >= 70)
		OR
		(name LIKE 'EMERG_NAME0%' AND max_length >= 50)
		OR
		(name LIKE 'EMERG_RELATION0%' AND max_length >= 30)
		OR
		(name LIKE 'EMERG_CONTACT0%' AND max_length >= 30)
	)
";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class SGDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the FINANCIAL_SUPPORT column. New to C21v67.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SG]') AND
	name = 'FINANCIAL_SUPPORT'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class SKGSDataSet
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

    public partial class SMDataSet
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

    public partial class SMCDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the MEDICAL_PLAN column. New to C21v73.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[SMC]') AND
	name = 'MEDICAL_PLAN'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

#if !EduHubScoped
    public partial class ST_TFRDataSet
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
#endif

    public partial class STDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the DEPT_E_MAIL column. New to C21v73.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[ST]') AND
	name = 'DEPT_E_MAIL'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class STARDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the EXPIRY_DATE column. New to C21v68.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[STAR]') AND
	name = 'EXPIRY_DATE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class STMADataSet
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

#if !EduHubScoped
    public partial class STMBDataSet
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
#endif

    public partial class STNATDataSet
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

    public partial class STPODataSet
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

    public partial class STPSDataSet
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

    public partial class STVDIDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE index. New to C21v64.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.sysindexes
WHERE
	id = OBJECT_ID(N'[dbo].[STVDI]') AND
	name = 'STVDI_Index_SKEY_VDIMENSION_VDOMAIN_YEAR_SEMESTER_SCORE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class STVDODataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the Index_SKEY_VDIMENSION_YEAR_SEMESTER_VDOMAIN_SCORE index. New to C21v64.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.sysindexes
WHERE
	id = OBJECT_ID(N'[dbo].[STVDO]') AND
	name = 'STVDO_Index_SKEY_VDIMENSION_YEAR_SEMESTER_VDOMAIN_SCORE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class SUDataSet
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

#if !EduHubScoped
    public partial class SVAGDataSet
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
#endif

    public partial class SXABDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the Index_STKEY_AM_ACT_TYPE_PM_ACT_TYPE_TXHG_TID_ABSENCE_DATE_LW_DATE index. New to C21v64.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.sysindexes
WHERE
	id = OBJECT_ID(N'[dbo].[SXAB]') AND
	name = 'SXAB_Index_STKEY_AM_ACT_TYPE_PM_ACT_TYPE_TXHG_TID_ABSENCE_DATE_LW_DATE'";

            return new SqlCommand(sql, SqlConnection);
        }
    }

    public partial class TCDataSet
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

    public partial class TCTBDataSet
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

    public partial class TCTDDataSet
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

    public partial class TCTQDataSet
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

    public partial class TCTRDataSet
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

    public partial class TEDataSet
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

#if !EduHubScoped
    public partial class TETNDataSet
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
#endif

    public partial class TTDataSet
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

    public partial class UMDataSet
    {
        /// <inheritdoc />
        public override SqlCommand GetSqlTableIsValidCommand(SqlConnection SqlConnection)
        {
            // Check for the existence of the UM_TRANS_ID column. New to C21v67.
            const string sql = @"SELECT
	1 - COUNT(*)
FROM sys.columns
WHERE
	object_id = OBJECT_ID(N'[dbo].[UM]') AND
	name IN ('UM_TRANS_ID')";

            return new SqlCommand(sql, SqlConnection);
        }
    }

}
