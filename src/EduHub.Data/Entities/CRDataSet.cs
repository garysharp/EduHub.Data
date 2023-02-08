using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRDataSet : EduHubDataSet<CR>
    {
        /// <inheritdoc />
        public override string Name { get { return "CR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal CRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_CRKEY = new Lazy<Dictionary<string, CR>>(() => this.ToDictionary(i => i.CRKEY));
            Index_PPDKEY = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.PPDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CR" /> fields for each CSV column header</returns>
        internal override Action<CR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MTDPURCH":
                        mapper[i] = (e, v) => e.MTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "YTDPURCH":
                        mapper[i] = (e, v) => e.YTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED01":
                        mapper[i] = (e, v) => e.AGED01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED02":
                        mapper[i] = (e, v) => e.AGED02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED03":
                        mapper[i] = (e, v) => e.AGED03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED04":
                        mapper[i] = (e, v) => e.AGED04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED05":
                        mapper[i] = (e, v) => e.AGED05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRLIMIT":
                        mapper[i] = (e, v) => e.CRLIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LASTPAY":
                        mapper[i] = (e, v) => e.LASTPAY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERMS":
                        mapper[i] = (e, v) => e.TERMS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DISCOUNT":
                        mapper[i] = (e, v) => e.DISCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "CR_EMAIL":
                        mapper[i] = (e, v) => e.CR_EMAIL = v;
                        break;
                    case "EMAIL_FOR_PAYMENTS":
                        mapper[i] = (e, v) => e.EMAIL_FOR_PAYMENTS = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "COMMITMENT":
                        mapper[i] = (e, v) => e.COMMITMENT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STOP_FLAG":
                        mapper[i] = (e, v) => e.STOP_FLAG = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "PAYG_RATE":
                        mapper[i] = (e, v) => e.PAYG_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "LODGE_REF":
                        mapper[i] = (e, v) => e.LODGE_REF = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "TRADE_INFO01":
                        mapper[i] = (e, v) => e.TRADE_INFO01 = v;
                        break;
                    case "TRADE_INFO02":
                        mapper[i] = (e, v) => e.TRADE_INFO02 = v;
                        break;
                    case "TRADE_INFO03":
                        mapper[i] = (e, v) => e.TRADE_INFO03 = v;
                        break;
                    case "TRADE_INFO04":
                        mapper[i] = (e, v) => e.TRADE_INFO04 = v;
                        break;
                    case "TRADE_INFO05":
                        mapper[i] = (e, v) => e.TRADE_INFO05 = v;
                        break;
                    case "TRADE_INFO06":
                        mapper[i] = (e, v) => e.TRADE_INFO06 = v;
                        break;
                    case "TRADE_INFO07":
                        mapper[i] = (e, v) => e.TRADE_INFO07 = v;
                        break;
                    case "TRADE_INFO08":
                        mapper[i] = (e, v) => e.TRADE_INFO08 = v;
                        break;
                    case "TRADE_INFO09":
                        mapper[i] = (e, v) => e.TRADE_INFO09 = v;
                        break;
                    case "TRADE_INFO10":
                        mapper[i] = (e, v) => e.TRADE_INFO10 = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "PAYG_BIRTHDATE":
                        mapper[i] = (e, v) => e.PAYG_BIRTHDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PAYG_STARTDATE":
                        mapper[i] = (e, v) => e.PAYG_STARTDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PAYG_TERMDATE":
                        mapper[i] = (e, v) => e.PAYG_TERMDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PAYG_ADDRESS01":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS01 = v;
                        break;
                    case "PAYG_ADDRESS02":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS02 = v;
                        break;
                    case "PAYG_SUBURB":
                        mapper[i] = (e, v) => e.PAYG_SUBURB = v;
                        break;
                    case "PAYG_STATE":
                        mapper[i] = (e, v) => e.PAYG_STATE = v;
                        break;
                    case "PAYG_POST":
                        mapper[i] = (e, v) => e.PAYG_POST = v;
                        break;
                    case "PAYG_COUNTRY":
                        mapper[i] = (e, v) => e.PAYG_COUNTRY = v;
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PR_APPROVE":
                        mapper[i] = (e, v) => e.PR_APPROVE = v;
                        break;
                    case "PRMS_FLAG":
                        mapper[i] = (e, v) => e.PRMS_FLAG = v;
                        break;
                    case "LW_PRMSINFO_DATE":
                        mapper[i] = (e, v) => e.LW_PRMSINFO_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ARN":
                        mapper[i] = (e, v) => e.ARN = v;
                        break;
                    case "KNOTE_FLAG":
                        mapper[i] = (e, v) => e.KNOTE_FLAG = v;
                        break;
                    case "AIMSKEY":
                        mapper[i] = (e, v) => e.AIMSKEY = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="CR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="CR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="CR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{CR}"/> of entities</returns>
        internal override IEnumerable<CR> ApplyDeltaEntities(IEnumerable<CR> Entities, List<CR> DeltaEntities)
        {
            HashSet<string> Index_CRKEY = new HashSet<string>(DeltaEntities.Select(i => i.CRKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_CRKEY.Remove(entity.CRKEY);
                            
                            if (entity.CRKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_BSB;
        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_COUNTRY;
        private Lazy<Dictionary<string, CR>> Index_CRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_PPDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<CR> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByBSB(string BSB)
        {
            IReadOnlyList<CR> value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find CR by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<CR> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<CR> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR FindByCRKEY(string CRKEY)
        {
            return Index_CRKEY.Value[CRKEY];
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <param name="Value">Related CR entity</param>
        /// <returns>True if the related CR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCRKEY(string CRKEY, out CR Value)
        {
            return Index_CRKEY.Value.TryGetValue(CRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR TryFindByCRKEY(string CRKEY)
        {
            CR value;
            if (Index_CRKEY.Value.TryGetValue(CRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out IReadOnlyList<CR> Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByPPDKEY(string PPDKEY)
        {
            IReadOnlyList<CR> value;
            if (Index_PPDKEY.Value.TryGetValue(PPDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a CR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[CR](
        [CRKEY] varchar(10) NOT NULL,
        [TITLE] varchar(40) NULL,
        [ALLOCAMT] money NULL,
        [MTDPURCH] money NULL,
        [YTDPURCH] money NULL,
        [AGED01] money NULL,
        [AGED02] money NULL,
        [AGED03] money NULL,
        [AGED04] money NULL,
        [AGED05] money NULL,
        [OPBAL] money NULL,
        [CRLIMIT] money NULL,
        [LASTPAYDATE] datetime NULL,
        [LASTPAY] money NULL,
        [ACCTYPE] smallint NULL,
        [TERMS] smallint NULL,
        [DISCOUNT] float NULL,
        [CONTACT] varchar(30) NULL,
        [ADDRESS01] varchar(40) NULL,
        [ADDRESS02] varchar(40) NULL,
        [ADDRESS03] varchar(40) NULL,
        [STATE] varchar(4) NULL,
        [POSTCODE] varchar(4) NULL,
        [COUNTRY] varchar(6) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [CR_EMAIL] varchar(60) NULL,
        [EMAIL_FOR_PAYMENTS] varchar(60) NULL,
        [MOBILE] varchar(20) NULL,
        [COMMITMENT] money NULL,
        [STOP_FLAG] varchar(1) NULL,
        [ABN] varchar(15) NULL,
        [PAYG_RATE] float NULL,
        [BSB] varchar(6) NULL,
        [ACCOUNT_NO] varchar(15) NULL,
        [ACCOUNT_NAME] varchar(60) NULL,
        [LODGE_REF] varchar(18) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [TRADE_INFO01] varchar(50) NULL,
        [TRADE_INFO02] varchar(50) NULL,
        [TRADE_INFO03] varchar(50) NULL,
        [TRADE_INFO04] varchar(50) NULL,
        [TRADE_INFO05] varchar(50) NULL,
        [TRADE_INFO06] varchar(50) NULL,
        [TRADE_INFO07] varchar(50) NULL,
        [TRADE_INFO08] varchar(50) NULL,
        [TRADE_INFO09] varchar(50) NULL,
        [TRADE_INFO10] varchar(50) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(15) NULL,
        [SECOND_NAME] varchar(15) NULL,
        [PAYG_BIRTHDATE] datetime NULL,
        [PAYG_STARTDATE] datetime NULL,
        [PAYG_TERMDATE] datetime NULL,
        [PAYG_ADDRESS01] varchar(38) NULL,
        [PAYG_ADDRESS02] varchar(38) NULL,
        [PAYG_SUBURB] varchar(20) NULL,
        [PAYG_STATE] varchar(3) NULL,
        [PAYG_POST] varchar(4) NULL,
        [PAYG_COUNTRY] varchar(20) NULL,
        [PPDKEY] varchar(10) NULL,
        [PR_APPROVE] varchar(1) NULL,
        [PRMS_FLAG] varchar(1) NULL,
        [LW_PRMSINFO_DATE] datetime NULL,
        [ARN] varchar(15) NULL,
        [KNOTE_FLAG] varchar(1) NULL,
        [AIMSKEY] varchar(20) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CR_Index_CRKEY] PRIMARY KEY CLUSTERED (
            [CRKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [CR_Index_BSB] ON [dbo].[CR]
    (
            [BSB] ASC
    );
    CREATE NONCLUSTERED INDEX [CR_Index_COUNTRY] ON [dbo].[CR]
    (
            [COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [CR_Index_PPDKEY] ON [dbo].[CR]
    (
            [PPDKEY] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'CR_Index_BSB')
    ALTER INDEX [CR_Index_BSB] ON [dbo].[CR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'CR_Index_COUNTRY')
    ALTER INDEX [CR_Index_COUNTRY] ON [dbo].[CR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'CR_Index_PPDKEY')
    ALTER INDEX [CR_Index_PPDKEY] ON [dbo].[CR] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'CR_Index_BSB')
    ALTER INDEX [CR_Index_BSB] ON [dbo].[CR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'CR_Index_COUNTRY')
    ALTER INDEX [CR_Index_COUNTRY] ON [dbo].[CR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'CR_Index_PPDKEY')
    ALTER INDEX [CR_Index_PPDKEY] ON [dbo].[CR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="CR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="CR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<CR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_CRKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_CRKEY.Add(entity.CRKEY);
            }

            builder.AppendLine("DELETE [dbo].[CR] WHERE");


            // Index_CRKEY
            builder.Append("[CRKEY] IN (");
            for (int index = 0; index < Index_CRKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // CRKEY
                var parameterCRKEY = $"@p{parameterIndex++}";
                builder.Append(parameterCRKEY);
                command.Parameters.Add(parameterCRKEY, SqlDbType.VarChar, 10).Value = Index_CRKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CR data set</returns>
        public override EduHubDataSetDataReader<CR> GetDataSetDataReader()
        {
            return new CRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CR data set</returns>
        public override EduHubDataSetDataReader<CR> GetDataSetDataReader(List<CR> Entities)
        {
            return new CRDataReader(new EduHubDataSetLoadedReader<CR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRDataReader : EduHubDataSetDataReader<CR>
        {
            public CRDataReader(IEduHubDataSetReader<CR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 71; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // CRKEY
                        return Current.CRKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // ALLOCAMT
                        return Current.ALLOCAMT;
                    case 3: // MTDPURCH
                        return Current.MTDPURCH;
                    case 4: // YTDPURCH
                        return Current.YTDPURCH;
                    case 5: // AGED01
                        return Current.AGED01;
                    case 6: // AGED02
                        return Current.AGED02;
                    case 7: // AGED03
                        return Current.AGED03;
                    case 8: // AGED04
                        return Current.AGED04;
                    case 9: // AGED05
                        return Current.AGED05;
                    case 10: // OPBAL
                        return Current.OPBAL;
                    case 11: // CRLIMIT
                        return Current.CRLIMIT;
                    case 12: // LASTPAYDATE
                        return Current.LASTPAYDATE;
                    case 13: // LASTPAY
                        return Current.LASTPAY;
                    case 14: // ACCTYPE
                        return Current.ACCTYPE;
                    case 15: // TERMS
                        return Current.TERMS;
                    case 16: // DISCOUNT
                        return Current.DISCOUNT;
                    case 17: // CONTACT
                        return Current.CONTACT;
                    case 18: // ADDRESS01
                        return Current.ADDRESS01;
                    case 19: // ADDRESS02
                        return Current.ADDRESS02;
                    case 20: // ADDRESS03
                        return Current.ADDRESS03;
                    case 21: // STATE
                        return Current.STATE;
                    case 22: // POSTCODE
                        return Current.POSTCODE;
                    case 23: // COUNTRY
                        return Current.COUNTRY;
                    case 24: // TELEPHONE
                        return Current.TELEPHONE;
                    case 25: // FAX
                        return Current.FAX;
                    case 26: // CR_EMAIL
                        return Current.CR_EMAIL;
                    case 27: // EMAIL_FOR_PAYMENTS
                        return Current.EMAIL_FOR_PAYMENTS;
                    case 28: // MOBILE
                        return Current.MOBILE;
                    case 29: // COMMITMENT
                        return Current.COMMITMENT;
                    case 30: // STOP_FLAG
                        return Current.STOP_FLAG;
                    case 31: // ABN
                        return Current.ABN;
                    case 32: // PAYG_RATE
                        return Current.PAYG_RATE;
                    case 33: // BSB
                        return Current.BSB;
                    case 34: // ACCOUNT_NO
                        return Current.ACCOUNT_NO;
                    case 35: // ACCOUNT_NAME
                        return Current.ACCOUNT_NAME;
                    case 36: // LODGE_REF
                        return Current.LODGE_REF;
                    case 37: // BILLER_CODE
                        return Current.BILLER_CODE;
                    case 38: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE;
                    case 39: // TRADE_INFO01
                        return Current.TRADE_INFO01;
                    case 40: // TRADE_INFO02
                        return Current.TRADE_INFO02;
                    case 41: // TRADE_INFO03
                        return Current.TRADE_INFO03;
                    case 42: // TRADE_INFO04
                        return Current.TRADE_INFO04;
                    case 43: // TRADE_INFO05
                        return Current.TRADE_INFO05;
                    case 44: // TRADE_INFO06
                        return Current.TRADE_INFO06;
                    case 45: // TRADE_INFO07
                        return Current.TRADE_INFO07;
                    case 46: // TRADE_INFO08
                        return Current.TRADE_INFO08;
                    case 47: // TRADE_INFO09
                        return Current.TRADE_INFO09;
                    case 48: // TRADE_INFO10
                        return Current.TRADE_INFO10;
                    case 49: // SURNAME
                        return Current.SURNAME;
                    case 50: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 51: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 52: // PAYG_BIRTHDATE
                        return Current.PAYG_BIRTHDATE;
                    case 53: // PAYG_STARTDATE
                        return Current.PAYG_STARTDATE;
                    case 54: // PAYG_TERMDATE
                        return Current.PAYG_TERMDATE;
                    case 55: // PAYG_ADDRESS01
                        return Current.PAYG_ADDRESS01;
                    case 56: // PAYG_ADDRESS02
                        return Current.PAYG_ADDRESS02;
                    case 57: // PAYG_SUBURB
                        return Current.PAYG_SUBURB;
                    case 58: // PAYG_STATE
                        return Current.PAYG_STATE;
                    case 59: // PAYG_POST
                        return Current.PAYG_POST;
                    case 60: // PAYG_COUNTRY
                        return Current.PAYG_COUNTRY;
                    case 61: // PPDKEY
                        return Current.PPDKEY;
                    case 62: // PR_APPROVE
                        return Current.PR_APPROVE;
                    case 63: // PRMS_FLAG
                        return Current.PRMS_FLAG;
                    case 64: // LW_PRMSINFO_DATE
                        return Current.LW_PRMSINFO_DATE;
                    case 65: // ARN
                        return Current.ARN;
                    case 66: // KNOTE_FLAG
                        return Current.KNOTE_FLAG;
                    case 67: // AIMSKEY
                        return Current.AIMSKEY;
                    case 68: // LW_DATE
                        return Current.LW_DATE;
                    case 69: // LW_TIME
                        return Current.LW_TIME;
                    case 70: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // ALLOCAMT
                        return Current.ALLOCAMT == null;
                    case 3: // MTDPURCH
                        return Current.MTDPURCH == null;
                    case 4: // YTDPURCH
                        return Current.YTDPURCH == null;
                    case 5: // AGED01
                        return Current.AGED01 == null;
                    case 6: // AGED02
                        return Current.AGED02 == null;
                    case 7: // AGED03
                        return Current.AGED03 == null;
                    case 8: // AGED04
                        return Current.AGED04 == null;
                    case 9: // AGED05
                        return Current.AGED05 == null;
                    case 10: // OPBAL
                        return Current.OPBAL == null;
                    case 11: // CRLIMIT
                        return Current.CRLIMIT == null;
                    case 12: // LASTPAYDATE
                        return Current.LASTPAYDATE == null;
                    case 13: // LASTPAY
                        return Current.LASTPAY == null;
                    case 14: // ACCTYPE
                        return Current.ACCTYPE == null;
                    case 15: // TERMS
                        return Current.TERMS == null;
                    case 16: // DISCOUNT
                        return Current.DISCOUNT == null;
                    case 17: // CONTACT
                        return Current.CONTACT == null;
                    case 18: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 19: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 20: // ADDRESS03
                        return Current.ADDRESS03 == null;
                    case 21: // STATE
                        return Current.STATE == null;
                    case 22: // POSTCODE
                        return Current.POSTCODE == null;
                    case 23: // COUNTRY
                        return Current.COUNTRY == null;
                    case 24: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 25: // FAX
                        return Current.FAX == null;
                    case 26: // CR_EMAIL
                        return Current.CR_EMAIL == null;
                    case 27: // EMAIL_FOR_PAYMENTS
                        return Current.EMAIL_FOR_PAYMENTS == null;
                    case 28: // MOBILE
                        return Current.MOBILE == null;
                    case 29: // COMMITMENT
                        return Current.COMMITMENT == null;
                    case 30: // STOP_FLAG
                        return Current.STOP_FLAG == null;
                    case 31: // ABN
                        return Current.ABN == null;
                    case 32: // PAYG_RATE
                        return Current.PAYG_RATE == null;
                    case 33: // BSB
                        return Current.BSB == null;
                    case 34: // ACCOUNT_NO
                        return Current.ACCOUNT_NO == null;
                    case 35: // ACCOUNT_NAME
                        return Current.ACCOUNT_NAME == null;
                    case 36: // LODGE_REF
                        return Current.LODGE_REF == null;
                    case 37: // BILLER_CODE
                        return Current.BILLER_CODE == null;
                    case 38: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE == null;
                    case 39: // TRADE_INFO01
                        return Current.TRADE_INFO01 == null;
                    case 40: // TRADE_INFO02
                        return Current.TRADE_INFO02 == null;
                    case 41: // TRADE_INFO03
                        return Current.TRADE_INFO03 == null;
                    case 42: // TRADE_INFO04
                        return Current.TRADE_INFO04 == null;
                    case 43: // TRADE_INFO05
                        return Current.TRADE_INFO05 == null;
                    case 44: // TRADE_INFO06
                        return Current.TRADE_INFO06 == null;
                    case 45: // TRADE_INFO07
                        return Current.TRADE_INFO07 == null;
                    case 46: // TRADE_INFO08
                        return Current.TRADE_INFO08 == null;
                    case 47: // TRADE_INFO09
                        return Current.TRADE_INFO09 == null;
                    case 48: // TRADE_INFO10
                        return Current.TRADE_INFO10 == null;
                    case 49: // SURNAME
                        return Current.SURNAME == null;
                    case 50: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 51: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 52: // PAYG_BIRTHDATE
                        return Current.PAYG_BIRTHDATE == null;
                    case 53: // PAYG_STARTDATE
                        return Current.PAYG_STARTDATE == null;
                    case 54: // PAYG_TERMDATE
                        return Current.PAYG_TERMDATE == null;
                    case 55: // PAYG_ADDRESS01
                        return Current.PAYG_ADDRESS01 == null;
                    case 56: // PAYG_ADDRESS02
                        return Current.PAYG_ADDRESS02 == null;
                    case 57: // PAYG_SUBURB
                        return Current.PAYG_SUBURB == null;
                    case 58: // PAYG_STATE
                        return Current.PAYG_STATE == null;
                    case 59: // PAYG_POST
                        return Current.PAYG_POST == null;
                    case 60: // PAYG_COUNTRY
                        return Current.PAYG_COUNTRY == null;
                    case 61: // PPDKEY
                        return Current.PPDKEY == null;
                    case 62: // PR_APPROVE
                        return Current.PR_APPROVE == null;
                    case 63: // PRMS_FLAG
                        return Current.PRMS_FLAG == null;
                    case 64: // LW_PRMSINFO_DATE
                        return Current.LW_PRMSINFO_DATE == null;
                    case 65: // ARN
                        return Current.ARN == null;
                    case 66: // KNOTE_FLAG
                        return Current.KNOTE_FLAG == null;
                    case 67: // AIMSKEY
                        return Current.AIMSKEY == null;
                    case 68: // LW_DATE
                        return Current.LW_DATE == null;
                    case 69: // LW_TIME
                        return Current.LW_TIME == null;
                    case 70: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // CRKEY
                        return "CRKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ALLOCAMT
                        return "ALLOCAMT";
                    case 3: // MTDPURCH
                        return "MTDPURCH";
                    case 4: // YTDPURCH
                        return "YTDPURCH";
                    case 5: // AGED01
                        return "AGED01";
                    case 6: // AGED02
                        return "AGED02";
                    case 7: // AGED03
                        return "AGED03";
                    case 8: // AGED04
                        return "AGED04";
                    case 9: // AGED05
                        return "AGED05";
                    case 10: // OPBAL
                        return "OPBAL";
                    case 11: // CRLIMIT
                        return "CRLIMIT";
                    case 12: // LASTPAYDATE
                        return "LASTPAYDATE";
                    case 13: // LASTPAY
                        return "LASTPAY";
                    case 14: // ACCTYPE
                        return "ACCTYPE";
                    case 15: // TERMS
                        return "TERMS";
                    case 16: // DISCOUNT
                        return "DISCOUNT";
                    case 17: // CONTACT
                        return "CONTACT";
                    case 18: // ADDRESS01
                        return "ADDRESS01";
                    case 19: // ADDRESS02
                        return "ADDRESS02";
                    case 20: // ADDRESS03
                        return "ADDRESS03";
                    case 21: // STATE
                        return "STATE";
                    case 22: // POSTCODE
                        return "POSTCODE";
                    case 23: // COUNTRY
                        return "COUNTRY";
                    case 24: // TELEPHONE
                        return "TELEPHONE";
                    case 25: // FAX
                        return "FAX";
                    case 26: // CR_EMAIL
                        return "CR_EMAIL";
                    case 27: // EMAIL_FOR_PAYMENTS
                        return "EMAIL_FOR_PAYMENTS";
                    case 28: // MOBILE
                        return "MOBILE";
                    case 29: // COMMITMENT
                        return "COMMITMENT";
                    case 30: // STOP_FLAG
                        return "STOP_FLAG";
                    case 31: // ABN
                        return "ABN";
                    case 32: // PAYG_RATE
                        return "PAYG_RATE";
                    case 33: // BSB
                        return "BSB";
                    case 34: // ACCOUNT_NO
                        return "ACCOUNT_NO";
                    case 35: // ACCOUNT_NAME
                        return "ACCOUNT_NAME";
                    case 36: // LODGE_REF
                        return "LODGE_REF";
                    case 37: // BILLER_CODE
                        return "BILLER_CODE";
                    case 38: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 39: // TRADE_INFO01
                        return "TRADE_INFO01";
                    case 40: // TRADE_INFO02
                        return "TRADE_INFO02";
                    case 41: // TRADE_INFO03
                        return "TRADE_INFO03";
                    case 42: // TRADE_INFO04
                        return "TRADE_INFO04";
                    case 43: // TRADE_INFO05
                        return "TRADE_INFO05";
                    case 44: // TRADE_INFO06
                        return "TRADE_INFO06";
                    case 45: // TRADE_INFO07
                        return "TRADE_INFO07";
                    case 46: // TRADE_INFO08
                        return "TRADE_INFO08";
                    case 47: // TRADE_INFO09
                        return "TRADE_INFO09";
                    case 48: // TRADE_INFO10
                        return "TRADE_INFO10";
                    case 49: // SURNAME
                        return "SURNAME";
                    case 50: // FIRST_NAME
                        return "FIRST_NAME";
                    case 51: // SECOND_NAME
                        return "SECOND_NAME";
                    case 52: // PAYG_BIRTHDATE
                        return "PAYG_BIRTHDATE";
                    case 53: // PAYG_STARTDATE
                        return "PAYG_STARTDATE";
                    case 54: // PAYG_TERMDATE
                        return "PAYG_TERMDATE";
                    case 55: // PAYG_ADDRESS01
                        return "PAYG_ADDRESS01";
                    case 56: // PAYG_ADDRESS02
                        return "PAYG_ADDRESS02";
                    case 57: // PAYG_SUBURB
                        return "PAYG_SUBURB";
                    case 58: // PAYG_STATE
                        return "PAYG_STATE";
                    case 59: // PAYG_POST
                        return "PAYG_POST";
                    case 60: // PAYG_COUNTRY
                        return "PAYG_COUNTRY";
                    case 61: // PPDKEY
                        return "PPDKEY";
                    case 62: // PR_APPROVE
                        return "PR_APPROVE";
                    case 63: // PRMS_FLAG
                        return "PRMS_FLAG";
                    case 64: // LW_PRMSINFO_DATE
                        return "LW_PRMSINFO_DATE";
                    case 65: // ARN
                        return "ARN";
                    case 66: // KNOTE_FLAG
                        return "KNOTE_FLAG";
                    case 67: // AIMSKEY
                        return "AIMSKEY";
                    case 68: // LW_DATE
                        return "LW_DATE";
                    case 69: // LW_TIME
                        return "LW_TIME";
                    case 70: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "CRKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ALLOCAMT":
                        return 2;
                    case "MTDPURCH":
                        return 3;
                    case "YTDPURCH":
                        return 4;
                    case "AGED01":
                        return 5;
                    case "AGED02":
                        return 6;
                    case "AGED03":
                        return 7;
                    case "AGED04":
                        return 8;
                    case "AGED05":
                        return 9;
                    case "OPBAL":
                        return 10;
                    case "CRLIMIT":
                        return 11;
                    case "LASTPAYDATE":
                        return 12;
                    case "LASTPAY":
                        return 13;
                    case "ACCTYPE":
                        return 14;
                    case "TERMS":
                        return 15;
                    case "DISCOUNT":
                        return 16;
                    case "CONTACT":
                        return 17;
                    case "ADDRESS01":
                        return 18;
                    case "ADDRESS02":
                        return 19;
                    case "ADDRESS03":
                        return 20;
                    case "STATE":
                        return 21;
                    case "POSTCODE":
                        return 22;
                    case "COUNTRY":
                        return 23;
                    case "TELEPHONE":
                        return 24;
                    case "FAX":
                        return 25;
                    case "CR_EMAIL":
                        return 26;
                    case "EMAIL_FOR_PAYMENTS":
                        return 27;
                    case "MOBILE":
                        return 28;
                    case "COMMITMENT":
                        return 29;
                    case "STOP_FLAG":
                        return 30;
                    case "ABN":
                        return 31;
                    case "PAYG_RATE":
                        return 32;
                    case "BSB":
                        return 33;
                    case "ACCOUNT_NO":
                        return 34;
                    case "ACCOUNT_NAME":
                        return 35;
                    case "LODGE_REF":
                        return 36;
                    case "BILLER_CODE":
                        return 37;
                    case "BPAY_REFERENCE":
                        return 38;
                    case "TRADE_INFO01":
                        return 39;
                    case "TRADE_INFO02":
                        return 40;
                    case "TRADE_INFO03":
                        return 41;
                    case "TRADE_INFO04":
                        return 42;
                    case "TRADE_INFO05":
                        return 43;
                    case "TRADE_INFO06":
                        return 44;
                    case "TRADE_INFO07":
                        return 45;
                    case "TRADE_INFO08":
                        return 46;
                    case "TRADE_INFO09":
                        return 47;
                    case "TRADE_INFO10":
                        return 48;
                    case "SURNAME":
                        return 49;
                    case "FIRST_NAME":
                        return 50;
                    case "SECOND_NAME":
                        return 51;
                    case "PAYG_BIRTHDATE":
                        return 52;
                    case "PAYG_STARTDATE":
                        return 53;
                    case "PAYG_TERMDATE":
                        return 54;
                    case "PAYG_ADDRESS01":
                        return 55;
                    case "PAYG_ADDRESS02":
                        return 56;
                    case "PAYG_SUBURB":
                        return 57;
                    case "PAYG_STATE":
                        return 58;
                    case "PAYG_POST":
                        return 59;
                    case "PAYG_COUNTRY":
                        return 60;
                    case "PPDKEY":
                        return 61;
                    case "PR_APPROVE":
                        return 62;
                    case "PRMS_FLAG":
                        return 63;
                    case "LW_PRMSINFO_DATE":
                        return 64;
                    case "ARN":
                        return 65;
                    case "KNOTE_FLAG":
                        return 66;
                    case "AIMSKEY":
                        return 67;
                    case "LW_DATE":
                        return 68;
                    case "LW_TIME":
                        return 69;
                    case "LW_USER":
                        return 70;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
