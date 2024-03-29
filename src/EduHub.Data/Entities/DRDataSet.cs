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
    /// Accounts Receivable Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRDataSet : EduHubDataSet<DR>
    {
        /// <inheritdoc />
        public override string Name { get { return "DR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal DRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BUSCOUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<DR>>>(() => this.ToGroupedNullDictionary(i => i.BUSCOUNTRY));
            Index_DRKEY = new Lazy<Dictionary<string, DR>>(() => this.ToDictionary(i => i.DRKEY));
            Index_DRTABLEA = new Lazy<NullDictionary<string, IReadOnlyList<DR>>>(() => this.ToGroupedNullDictionary(i => i.DRTABLEA));
            Index_MAILCOUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<DR>>>(() => this.ToGroupedNullDictionary(i => i.MAILCOUNTRY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DR" /> fields for each CSV column header</returns>
        internal override Action<DR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DRKEY":
                        mapper[i] = (e, v) => e.DRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES":
                        mapper[i] = (e, v) => e.CHARGES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES_YTD":
                        mapper[i] = (e, v) => e.CHARGES_YTD = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "LASTREC":
                        mapper[i] = (e, v) => e.LASTREC = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTRECDATE":
                        mapper[i] = (e, v) => e.LASTRECDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "DRTYPE":
                        mapper[i] = (e, v) => e.DRTYPE = v;
                        break;
                    case "DRTABLEA":
                        mapper[i] = (e, v) => e.DRTABLEA = v;
                        break;
                    case "BUSNAME":
                        mapper[i] = (e, v) => e.BUSNAME = v;
                        break;
                    case "BUSADD01":
                        mapper[i] = (e, v) => e.BUSADD01 = v;
                        break;
                    case "BUSADD02":
                        mapper[i] = (e, v) => e.BUSADD02 = v;
                        break;
                    case "BUSADD03":
                        mapper[i] = (e, v) => e.BUSADD03 = v;
                        break;
                    case "BUSSTATE":
                        mapper[i] = (e, v) => e.BUSSTATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "BUSCOUNTRY":
                        mapper[i] = (e, v) => e.BUSCOUNTRY = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "BILLING_EMAIL":
                        mapper[i] = (e, v) => e.BILLING_EMAIL = v;
                        break;
                    case "MAILNAME":
                        mapper[i] = (e, v) => e.MAILNAME = v;
                        break;
                    case "MAILADD01":
                        mapper[i] = (e, v) => e.MAILADD01 = v;
                        break;
                    case "MAILADD02":
                        mapper[i] = (e, v) => e.MAILADD02 = v;
                        break;
                    case "MAILADD03":
                        mapper[i] = (e, v) => e.MAILADD03 = v;
                        break;
                    case "MAILSTATE":
                        mapper[i] = (e, v) => e.MAILSTATE = v;
                        break;
                    case "MAILPOST":
                        mapper[i] = (e, v) => e.MAILPOST = v;
                        break;
                    case "MAILCOUNTRY":
                        mapper[i] = (e, v) => e.MAILCOUNTRY = v;
                        break;
                    case "DELNAME":
                        mapper[i] = (e, v) => e.DELNAME = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "DELIVPOST":
                        mapper[i] = (e, v) => e.DELIVPOST = v;
                        break;
                    case "REMARK":
                        mapper[i] = (e, v) => e.REMARK = v;
                        break;
                    case "PRICELEVEL":
                        mapper[i] = (e, v) => e.PRICELEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MEMO_FLAG":
                        mapper[i] = (e, v) => e.MEMO_FLAG = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "DRSHORT":
                        mapper[i] = (e, v) => e.DRSHORT = v;
                        break;
                    case "CSR":
                        mapper[i] = (e, v) => e.CSR = v;
                        break;
                    case "DRGROUP":
                        mapper[i] = (e, v) => e.DRGROUP = v;
                        break;
                    case "COMMENCE":
                        mapper[i] = (e, v) => e.COMMENCE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DRFCOUNT":
                        mapper[i] = (e, v) => e.DRFCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TAX_INVOICE":
                        mapper[i] = (e, v) => e.TAX_INVOICE = v;
                        break;
                    case "BPAY_SEQUENCE":
                        mapper[i] = (e, v) => e.BPAY_SEQUENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "KNOTE_FLAG":
                        mapper[i] = (e, v) => e.KNOTE_FLAG = v;
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
        /// Merges <see cref="DR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="DR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="DR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{DR}"/> of entities</returns>
        internal override IEnumerable<DR> ApplyDeltaEntities(IEnumerable<DR> Entities, List<DR> DeltaEntities)
        {
            HashSet<string> Index_DRKEY = new HashSet<string>(DeltaEntities.Select(i => i.DRKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.DRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_DRKEY.Remove(entity.DRKEY);
                            
                            if (entity.DRKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<DR>>> Index_BUSCOUNTRY;
        private Lazy<Dictionary<string, DR>> Index_DRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<DR>>> Index_DRTABLEA;
        private Lazy<NullDictionary<string, IReadOnlyList<DR>>> Index_MAILCOUNTRY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DR by BUSCOUNTRY field
        /// </summary>
        /// <param name="BUSCOUNTRY">BUSCOUNTRY value used to find DR</param>
        /// <returns>List of related DR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> FindByBUSCOUNTRY(string BUSCOUNTRY)
        {
            return Index_BUSCOUNTRY.Value[BUSCOUNTRY];
        }

        /// <summary>
        /// Attempt to find DR by BUSCOUNTRY field
        /// </summary>
        /// <param name="BUSCOUNTRY">BUSCOUNTRY value used to find DR</param>
        /// <param name="Value">List of related DR entities</param>
        /// <returns>True if the list of related DR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBUSCOUNTRY(string BUSCOUNTRY, out IReadOnlyList<DR> Value)
        {
            return Index_BUSCOUNTRY.Value.TryGetValue(BUSCOUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find DR by BUSCOUNTRY field
        /// </summary>
        /// <param name="BUSCOUNTRY">BUSCOUNTRY value used to find DR</param>
        /// <returns>List of related DR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> TryFindByBUSCOUNTRY(string BUSCOUNTRY)
        {
            IReadOnlyList<DR> value;
            if (Index_BUSCOUNTRY.Value.TryGetValue(BUSCOUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <returns>Related DR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DR FindByDRKEY(string DRKEY)
        {
            return Index_DRKEY.Value[DRKEY];
        }

        /// <summary>
        /// Attempt to find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <param name="Value">Related DR entity</param>
        /// <returns>True if the related DR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDRKEY(string DRKEY, out DR Value)
        {
            return Index_DRKEY.Value.TryGetValue(DRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <returns>Related DR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DR TryFindByDRKEY(string DRKEY)
        {
            DR value;
            if (Index_DRKEY.Value.TryGetValue(DRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <returns>List of related DR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> FindByDRTABLEA(string DRTABLEA)
        {
            return Index_DRTABLEA.Value[DRTABLEA];
        }

        /// <summary>
        /// Attempt to find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <param name="Value">List of related DR entities</param>
        /// <returns>True if the list of related DR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDRTABLEA(string DRTABLEA, out IReadOnlyList<DR> Value)
        {
            return Index_DRTABLEA.Value.TryGetValue(DRTABLEA, out Value);
        }

        /// <summary>
        /// Attempt to find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <returns>List of related DR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> TryFindByDRTABLEA(string DRTABLEA)
        {
            IReadOnlyList<DR> value;
            if (Index_DRTABLEA.Value.TryGetValue(DRTABLEA, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DR by MAILCOUNTRY field
        /// </summary>
        /// <param name="MAILCOUNTRY">MAILCOUNTRY value used to find DR</param>
        /// <returns>List of related DR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> FindByMAILCOUNTRY(string MAILCOUNTRY)
        {
            return Index_MAILCOUNTRY.Value[MAILCOUNTRY];
        }

        /// <summary>
        /// Attempt to find DR by MAILCOUNTRY field
        /// </summary>
        /// <param name="MAILCOUNTRY">MAILCOUNTRY value used to find DR</param>
        /// <param name="Value">List of related DR entities</param>
        /// <returns>True if the list of related DR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILCOUNTRY(string MAILCOUNTRY, out IReadOnlyList<DR> Value)
        {
            return Index_MAILCOUNTRY.Value.TryGetValue(MAILCOUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find DR by MAILCOUNTRY field
        /// </summary>
        /// <param name="MAILCOUNTRY">MAILCOUNTRY value used to find DR</param>
        /// <returns>List of related DR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> TryFindByMAILCOUNTRY(string MAILCOUNTRY)
        {
            IReadOnlyList<DR> value;
            if (Index_MAILCOUNTRY.Value.TryGetValue(MAILCOUNTRY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a DR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DR](
        [DRKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [ALLOCAMT] money NULL,
        [CHARGES] money NULL,
        [CHARGES_YTD] money NULL,
        [AGED01] money NULL,
        [AGED02] money NULL,
        [AGED03] money NULL,
        [AGED04] money NULL,
        [AGED05] money NULL,
        [OPBAL] money NULL,
        [LASTREC] money NULL,
        [LASTRECDATE] datetime NULL,
        [ACCTYPE] smallint NULL,
        [CONTACT] varchar(30) NULL,
        [DRTYPE] varchar(1) NULL,
        [DRTABLEA] varchar(10) NULL,
        [BUSNAME] varchar(30) NULL,
        [BUSADD01] varchar(30) NULL,
        [BUSADD02] varchar(30) NULL,
        [BUSADD03] varchar(30) NULL,
        [BUSSTATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [BUSCOUNTRY] varchar(6) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [MOBILE] varchar(20) NULL,
        [BILLING_EMAIL] varchar(60) NULL,
        [MAILNAME] varchar(30) NULL,
        [MAILADD01] varchar(30) NULL,
        [MAILADD02] varchar(30) NULL,
        [MAILADD03] varchar(30) NULL,
        [MAILSTATE] varchar(3) NULL,
        [MAILPOST] varchar(4) NULL,
        [MAILCOUNTRY] varchar(6) NULL,
        [DELNAME] varchar(30) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [DELIVPOST] varchar(4) NULL,
        [REMARK] varchar(MAX) NULL,
        [PRICELEVEL] smallint NULL,
        [MEMO_FLAG] varchar(1) NULL,
        [NOTES] varchar(MAX) NULL,
        [DRSHORT] varchar(10) NULL,
        [CSR] varchar(4) NULL,
        [DRGROUP] varchar(10) NULL,
        [COMMENCE] datetime NULL,
        [DRFCOUNT] float NULL,
        [TAX_INVOICE] varchar(1) NULL,
        [BPAY_SEQUENCE] int NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [KNOTE_FLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DR_Index_DRKEY] PRIMARY KEY CLUSTERED (
            [DRKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [DR_Index_BUSCOUNTRY] ON [dbo].[DR]
    (
            [BUSCOUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [DR_Index_DRTABLEA] ON [dbo].[DR]
    (
            [DRTABLEA] ASC
    );
    CREATE NONCLUSTERED INDEX [DR_Index_MAILCOUNTRY] ON [dbo].[DR]
    (
            [MAILCOUNTRY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DR]') AND name = N'DR_Index_BUSCOUNTRY')
    ALTER INDEX [DR_Index_BUSCOUNTRY] ON [dbo].[DR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DR]') AND name = N'DR_Index_DRTABLEA')
    ALTER INDEX [DR_Index_DRTABLEA] ON [dbo].[DR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DR]') AND name = N'DR_Index_MAILCOUNTRY')
    ALTER INDEX [DR_Index_MAILCOUNTRY] ON [dbo].[DR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DR]') AND name = N'DR_Index_BUSCOUNTRY')
    ALTER INDEX [DR_Index_BUSCOUNTRY] ON [dbo].[DR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DR]') AND name = N'DR_Index_DRTABLEA')
    ALTER INDEX [DR_Index_DRTABLEA] ON [dbo].[DR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DR]') AND name = N'DR_Index_MAILCOUNTRY')
    ALTER INDEX [DR_Index_MAILCOUNTRY] ON [dbo].[DR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="DR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="DR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<DR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_DRKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_DRKEY.Add(entity.DRKEY);
            }

            builder.AppendLine("DELETE [dbo].[DR] WHERE");


            // Index_DRKEY
            builder.Append("[DRKEY] IN (");
            for (int index = 0; index < Index_DRKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // DRKEY
                var parameterDRKEY = $"@p{parameterIndex++}";
                builder.Append(parameterDRKEY);
                command.Parameters.Add(parameterDRKEY, SqlDbType.VarChar, 10).Value = Index_DRKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DR data set</returns>
        public override EduHubDataSetDataReader<DR> GetDataSetDataReader()
        {
            return new DRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DR data set</returns>
        public override EduHubDataSetDataReader<DR> GetDataSetDataReader(List<DR> Entities)
        {
            return new DRDataReader(new EduHubDataSetLoadedReader<DR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DRDataReader : EduHubDataSetDataReader<DR>
        {
            public DRDataReader(IEduHubDataSetReader<DR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 55; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // DRKEY
                        return Current.DRKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // ALLOCAMT
                        return Current.ALLOCAMT;
                    case 3: // CHARGES
                        return Current.CHARGES;
                    case 4: // CHARGES_YTD
                        return Current.CHARGES_YTD;
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
                    case 11: // LASTREC
                        return Current.LASTREC;
                    case 12: // LASTRECDATE
                        return Current.LASTRECDATE;
                    case 13: // ACCTYPE
                        return Current.ACCTYPE;
                    case 14: // CONTACT
                        return Current.CONTACT;
                    case 15: // DRTYPE
                        return Current.DRTYPE;
                    case 16: // DRTABLEA
                        return Current.DRTABLEA;
                    case 17: // BUSNAME
                        return Current.BUSNAME;
                    case 18: // BUSADD01
                        return Current.BUSADD01;
                    case 19: // BUSADD02
                        return Current.BUSADD02;
                    case 20: // BUSADD03
                        return Current.BUSADD03;
                    case 21: // BUSSTATE
                        return Current.BUSSTATE;
                    case 22: // POSTCODE
                        return Current.POSTCODE;
                    case 23: // BUSCOUNTRY
                        return Current.BUSCOUNTRY;
                    case 24: // TELEPHONE
                        return Current.TELEPHONE;
                    case 25: // FAX
                        return Current.FAX;
                    case 26: // MOBILE
                        return Current.MOBILE;
                    case 27: // BILLING_EMAIL
                        return Current.BILLING_EMAIL;
                    case 28: // MAILNAME
                        return Current.MAILNAME;
                    case 29: // MAILADD01
                        return Current.MAILADD01;
                    case 30: // MAILADD02
                        return Current.MAILADD02;
                    case 31: // MAILADD03
                        return Current.MAILADD03;
                    case 32: // MAILSTATE
                        return Current.MAILSTATE;
                    case 33: // MAILPOST
                        return Current.MAILPOST;
                    case 34: // MAILCOUNTRY
                        return Current.MAILCOUNTRY;
                    case 35: // DELNAME
                        return Current.DELNAME;
                    case 36: // ADDRESS01
                        return Current.ADDRESS01;
                    case 37: // ADDRESS02
                        return Current.ADDRESS02;
                    case 38: // DELIVPOST
                        return Current.DELIVPOST;
                    case 39: // REMARK
                        return Current.REMARK;
                    case 40: // PRICELEVEL
                        return Current.PRICELEVEL;
                    case 41: // MEMO_FLAG
                        return Current.MEMO_FLAG;
                    case 42: // NOTES
                        return Current.NOTES;
                    case 43: // DRSHORT
                        return Current.DRSHORT;
                    case 44: // CSR
                        return Current.CSR;
                    case 45: // DRGROUP
                        return Current.DRGROUP;
                    case 46: // COMMENCE
                        return Current.COMMENCE;
                    case 47: // DRFCOUNT
                        return Current.DRFCOUNT;
                    case 48: // TAX_INVOICE
                        return Current.TAX_INVOICE;
                    case 49: // BPAY_SEQUENCE
                        return Current.BPAY_SEQUENCE;
                    case 50: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE;
                    case 51: // KNOTE_FLAG
                        return Current.KNOTE_FLAG;
                    case 52: // LW_DATE
                        return Current.LW_DATE;
                    case 53: // LW_TIME
                        return Current.LW_TIME;
                    case 54: // LW_USER
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
                    case 3: // CHARGES
                        return Current.CHARGES == null;
                    case 4: // CHARGES_YTD
                        return Current.CHARGES_YTD == null;
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
                    case 11: // LASTREC
                        return Current.LASTREC == null;
                    case 12: // LASTRECDATE
                        return Current.LASTRECDATE == null;
                    case 13: // ACCTYPE
                        return Current.ACCTYPE == null;
                    case 14: // CONTACT
                        return Current.CONTACT == null;
                    case 15: // DRTYPE
                        return Current.DRTYPE == null;
                    case 16: // DRTABLEA
                        return Current.DRTABLEA == null;
                    case 17: // BUSNAME
                        return Current.BUSNAME == null;
                    case 18: // BUSADD01
                        return Current.BUSADD01 == null;
                    case 19: // BUSADD02
                        return Current.BUSADD02 == null;
                    case 20: // BUSADD03
                        return Current.BUSADD03 == null;
                    case 21: // BUSSTATE
                        return Current.BUSSTATE == null;
                    case 22: // POSTCODE
                        return Current.POSTCODE == null;
                    case 23: // BUSCOUNTRY
                        return Current.BUSCOUNTRY == null;
                    case 24: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 25: // FAX
                        return Current.FAX == null;
                    case 26: // MOBILE
                        return Current.MOBILE == null;
                    case 27: // BILLING_EMAIL
                        return Current.BILLING_EMAIL == null;
                    case 28: // MAILNAME
                        return Current.MAILNAME == null;
                    case 29: // MAILADD01
                        return Current.MAILADD01 == null;
                    case 30: // MAILADD02
                        return Current.MAILADD02 == null;
                    case 31: // MAILADD03
                        return Current.MAILADD03 == null;
                    case 32: // MAILSTATE
                        return Current.MAILSTATE == null;
                    case 33: // MAILPOST
                        return Current.MAILPOST == null;
                    case 34: // MAILCOUNTRY
                        return Current.MAILCOUNTRY == null;
                    case 35: // DELNAME
                        return Current.DELNAME == null;
                    case 36: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 37: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 38: // DELIVPOST
                        return Current.DELIVPOST == null;
                    case 39: // REMARK
                        return Current.REMARK == null;
                    case 40: // PRICELEVEL
                        return Current.PRICELEVEL == null;
                    case 41: // MEMO_FLAG
                        return Current.MEMO_FLAG == null;
                    case 42: // NOTES
                        return Current.NOTES == null;
                    case 43: // DRSHORT
                        return Current.DRSHORT == null;
                    case 44: // CSR
                        return Current.CSR == null;
                    case 45: // DRGROUP
                        return Current.DRGROUP == null;
                    case 46: // COMMENCE
                        return Current.COMMENCE == null;
                    case 47: // DRFCOUNT
                        return Current.DRFCOUNT == null;
                    case 48: // TAX_INVOICE
                        return Current.TAX_INVOICE == null;
                    case 49: // BPAY_SEQUENCE
                        return Current.BPAY_SEQUENCE == null;
                    case 50: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE == null;
                    case 51: // KNOTE_FLAG
                        return Current.KNOTE_FLAG == null;
                    case 52: // LW_DATE
                        return Current.LW_DATE == null;
                    case 53: // LW_TIME
                        return Current.LW_TIME == null;
                    case 54: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // DRKEY
                        return "DRKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ALLOCAMT
                        return "ALLOCAMT";
                    case 3: // CHARGES
                        return "CHARGES";
                    case 4: // CHARGES_YTD
                        return "CHARGES_YTD";
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
                    case 11: // LASTREC
                        return "LASTREC";
                    case 12: // LASTRECDATE
                        return "LASTRECDATE";
                    case 13: // ACCTYPE
                        return "ACCTYPE";
                    case 14: // CONTACT
                        return "CONTACT";
                    case 15: // DRTYPE
                        return "DRTYPE";
                    case 16: // DRTABLEA
                        return "DRTABLEA";
                    case 17: // BUSNAME
                        return "BUSNAME";
                    case 18: // BUSADD01
                        return "BUSADD01";
                    case 19: // BUSADD02
                        return "BUSADD02";
                    case 20: // BUSADD03
                        return "BUSADD03";
                    case 21: // BUSSTATE
                        return "BUSSTATE";
                    case 22: // POSTCODE
                        return "POSTCODE";
                    case 23: // BUSCOUNTRY
                        return "BUSCOUNTRY";
                    case 24: // TELEPHONE
                        return "TELEPHONE";
                    case 25: // FAX
                        return "FAX";
                    case 26: // MOBILE
                        return "MOBILE";
                    case 27: // BILLING_EMAIL
                        return "BILLING_EMAIL";
                    case 28: // MAILNAME
                        return "MAILNAME";
                    case 29: // MAILADD01
                        return "MAILADD01";
                    case 30: // MAILADD02
                        return "MAILADD02";
                    case 31: // MAILADD03
                        return "MAILADD03";
                    case 32: // MAILSTATE
                        return "MAILSTATE";
                    case 33: // MAILPOST
                        return "MAILPOST";
                    case 34: // MAILCOUNTRY
                        return "MAILCOUNTRY";
                    case 35: // DELNAME
                        return "DELNAME";
                    case 36: // ADDRESS01
                        return "ADDRESS01";
                    case 37: // ADDRESS02
                        return "ADDRESS02";
                    case 38: // DELIVPOST
                        return "DELIVPOST";
                    case 39: // REMARK
                        return "REMARK";
                    case 40: // PRICELEVEL
                        return "PRICELEVEL";
                    case 41: // MEMO_FLAG
                        return "MEMO_FLAG";
                    case 42: // NOTES
                        return "NOTES";
                    case 43: // DRSHORT
                        return "DRSHORT";
                    case 44: // CSR
                        return "CSR";
                    case 45: // DRGROUP
                        return "DRGROUP";
                    case 46: // COMMENCE
                        return "COMMENCE";
                    case 47: // DRFCOUNT
                        return "DRFCOUNT";
                    case 48: // TAX_INVOICE
                        return "TAX_INVOICE";
                    case 49: // BPAY_SEQUENCE
                        return "BPAY_SEQUENCE";
                    case 50: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 51: // KNOTE_FLAG
                        return "KNOTE_FLAG";
                    case 52: // LW_DATE
                        return "LW_DATE";
                    case 53: // LW_TIME
                        return "LW_TIME";
                    case 54: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "DRKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ALLOCAMT":
                        return 2;
                    case "CHARGES":
                        return 3;
                    case "CHARGES_YTD":
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
                    case "LASTREC":
                        return 11;
                    case "LASTRECDATE":
                        return 12;
                    case "ACCTYPE":
                        return 13;
                    case "CONTACT":
                        return 14;
                    case "DRTYPE":
                        return 15;
                    case "DRTABLEA":
                        return 16;
                    case "BUSNAME":
                        return 17;
                    case "BUSADD01":
                        return 18;
                    case "BUSADD02":
                        return 19;
                    case "BUSADD03":
                        return 20;
                    case "BUSSTATE":
                        return 21;
                    case "POSTCODE":
                        return 22;
                    case "BUSCOUNTRY":
                        return 23;
                    case "TELEPHONE":
                        return 24;
                    case "FAX":
                        return 25;
                    case "MOBILE":
                        return 26;
                    case "BILLING_EMAIL":
                        return 27;
                    case "MAILNAME":
                        return 28;
                    case "MAILADD01":
                        return 29;
                    case "MAILADD02":
                        return 30;
                    case "MAILADD03":
                        return 31;
                    case "MAILSTATE":
                        return 32;
                    case "MAILPOST":
                        return 33;
                    case "MAILCOUNTRY":
                        return 34;
                    case "DELNAME":
                        return 35;
                    case "ADDRESS01":
                        return 36;
                    case "ADDRESS02":
                        return 37;
                    case "DELIVPOST":
                        return 38;
                    case "REMARK":
                        return 39;
                    case "PRICELEVEL":
                        return 40;
                    case "MEMO_FLAG":
                        return 41;
                    case "NOTES":
                        return 42;
                    case "DRSHORT":
                        return 43;
                    case "CSR":
                        return 44;
                    case "DRGROUP":
                        return 45;
                    case "COMMENCE":
                        return 46;
                    case "DRFCOUNT":
                        return 47;
                    case "TAX_INVOICE":
                        return 48;
                    case "BPAY_SEQUENCE":
                        return 49;
                    case "BPAY_REFERENCE":
                        return 50;
                    case "KNOTE_FLAG":
                        return 51;
                    case "LW_DATE":
                        return 52;
                    case "LW_TIME":
                        return 53;
                    case "LW_USER":
                        return 54;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
